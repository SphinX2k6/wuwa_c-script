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
	// Token: 0x17000257 RID: 599
	// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0004474C File Offset: 0x0004294C
	[Nullable(2)]
	public AiModel Model
	{
		[NullableContext(2)]
		get
		{
			return AiModel.Instance;
		}
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x00044753 File Offset: 0x00042953
	public void AddAiToTeam(AiController ai, int teamLevelId)
	{
		ai.AiTeam = this.Model.GetAiTeam(teamLevelId);
		ai.AiTeam.AddMember(ai);
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00044774 File Offset: 0x00042974
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

	// Token: 0x06000CD2 RID: 3282 RVA: 0x0004479C File Offset: 0x0004299C
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

	// Token: 0x06000CD3 RID: 3283 RVA: 0x0004482C File Offset: 0x00042A2C
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

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00044AC0 File Offset: 0x00042CC0
	public static AiModelController Instance
	{
		get
		{
			return AiModelController._Instance;
		}
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00044AC7 File Offset: 0x00042CC7
	public static AiModelController GetOrCreateInstance()
	{
		if (AiModelController._Instance == null)
		{
			AiModelController.CreateInstance();
		}
		return AiModelController._Instance;
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00044ADB File Offset: 0x00042CDB
	public static bool CreateInstance()
	{
		if (AiModelController._Instance != null)
		{
			return true;
		}
		AiModelController._Instance = new AiModelController();
		return true;
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00044AF1 File Offset: 0x00042CF1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00044AF3 File Offset: 0x00042CF3
	public static void ResetStaticDefaultValue()
	{
		AiModelController._Instance = null;
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00044AFB File Offset: 0x00042CFB
	static AiModelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AiModelController.CreateStaticDefaultValue), new Action(AiModelController.ResetStaticDefaultValue));
	}

	// Token: 0x04000A2E RID: 2606
	[Nullable(2)]
	private static AiModelController _Instance;
}
