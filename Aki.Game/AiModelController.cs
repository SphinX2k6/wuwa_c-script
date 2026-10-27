using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

// Token: 0x020000D5 RID: 213
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
[TickController(0)]
public class AiModelController : ControllerBase
{
	// Token: 0x17000254 RID: 596
	// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00043BB8 File Offset: 0x00041DB8
	[Nullable(2)]
	public AiModel Model
	{
		[NullableContext(2)]
		get
		{
			return AiModel.Instance;
		}
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00043BBF File Offset: 0x00041DBF
	public void AddAiToTeam(AiController ai, int teamLevelId)
	{
		ai.AiTeam = this.Model.GetAiTeam(teamLevelId);
		ai.AiTeam.AddMember(ai);
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x00043BE0 File Offset: 0x00041DE0
	public void RemoveAiFromTeam(AiController ai)
	{
		AiTeam aiTeam = ai.AiTeam;
		if (aiTeam == null)
		{
			return;
		}
		aiTeam.RemoveMember(ai);
		ai.AiTeam = null;
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00043C08 File Offset: 0x00041E08
	protected override void OnTick(float delta)
	{
		this.Model.AiScoreManager.Update();
		foreach (KeyValuePair<int, AiTeam> keyValuePair in this.Model.ActiveAiTeams)
		{
			AiTeam value = keyValuePair.Value;
			if (value.TeamMemberToGroup.Count > 0)
			{
				value.Tick();
			}
		}
		this.ShareHatredTarget();
		this.Model.UpdateEntityLookAt();
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x00043C98 File Offset: 0x00041E98
	private void ShareHatredTarget()
	{
		foreach (KeyValuePair<int, Dictionary<long, HashSet<AiController>>> keyValuePair in this.Model.HatredGroups)
		{
			foreach (KeyValuePair<long, HashSet<AiController>> keyValuePair2 in keyValuePair.Value)
			{
				HashSet<AiController> value = keyValuePair2.Value;
				List<AiController> list = new List<AiController>();
				foreach (AiController aiController in value)
				{
					CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
					if (charAiDesignComp == null || !charAiDesignComp.Valid || !aiController.CharAiDesignComp.Entity.Valid)
					{
						list.Add(aiController);
					}
				}
				foreach (AiController item in list)
				{
					value.Remove(item);
				}
			}
		}
		foreach (KeyValuePair<int, Dictionary<long, HashSet<AiController>>> keyValuePair3 in this.Model.HatredGroups)
		{
			foreach (KeyValuePair<long, HashSet<AiController>> keyValuePair4 in keyValuePair3.Value)
			{
				HashSet<AiController> value2 = keyValuePair4.Value;
				foreach (AiController aiController2 in value2)
				{
					if (aiController2.AiHateList.IsCurrentTargetInMaxArea)
					{
						int id = aiController2.AiHateList.GetCurrentTarget().Id;
						foreach (AiController aiController3 in value2)
						{
							if (aiController2 != aiController3)
							{
								aiController3.AiHateList.SharedHatredTarget(id);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00043F2C File Offset: 0x0004212C
	public static AiModelController Instance
	{
		get
		{
			return AiModelController._Instance;
		}
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00043F33 File Offset: 0x00042133
	public static AiModelController GetOrCreateInstance()
	{
		if (AiModelController._Instance == null)
		{
			AiModelController.CreateInstance();
		}
		return AiModelController._Instance;
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x00043F47 File Offset: 0x00042147
	public static bool CreateInstance()
	{
		if (AiModelController._Instance != null)
		{
			return true;
		}
		AiModelController._Instance = new AiModelController();
		return true;
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00043F5D File Offset: 0x0004215D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00043F5F File Offset: 0x0004215F
	public static void ResetStaticDefaultValue()
	{
		AiModelController._Instance = null;
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00043F67 File Offset: 0x00042167
	static AiModelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AiModelController.CreateStaticDefaultValue), new Action(AiModelController.ResetStaticDefaultValue));
	}

	// Token: 0x04000A26 RID: 2598
	[Nullable(2)]
	private static AiModelController _Instance;
}
