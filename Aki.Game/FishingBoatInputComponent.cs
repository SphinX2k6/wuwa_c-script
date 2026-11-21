using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;

// Token: 0x02002858 RID: 10328
[NullableContext(1)]
[Nullable(0)]
public class FishingBoatInputComponent : GongduolaInputComponent
{
	// Token: 0x0601A233 RID: 107059 RVA: 0x00814139 File Offset: 0x00812339
	protected override void ExecuteSprint(SInputCommand command)
	{
	}

	// Token: 0x0601A234 RID: 107060 RVA: 0x0081413B File Offset: 0x0081233B
	protected override void ExecuteSkill(SInputCommand command)
	{
		this.BeginSkill(command.IntValue);
	}

	// Token: 0x0601A235 RID: 107061 RVA: 0x00814149 File Offset: 0x00812349
	private void BeginSkill(int skillId)
	{
		if (skillId == 210012)
		{
			PhotographController.Instance.PhotographFastScreenShot(ECameraCaptureType.NormalCamera);
			return;
		}
		base.Entity.GetComponent<BaseSkillComponent>().BeginSkill(skillId, new SkillParam
		{
			Reason = "FishingBoatInputComponent.ExecuteSkill"
		});
	}

	// Token: 0x0601A236 RID: 107062 RVA: 0x00814184 File Offset: 0x00812384
	public void ExecuteSkillWithConfirmBox(int skillId, EConfirmBoxConfigId configId, int itemId)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(configId);
		if (itemId > 0)
		{
			confirmBoxDataNew.ItemIdMap[itemId] = 1;
		}
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.BeginSkill(skillId);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x17002A92 RID: 10898
	// (get) Token: 0x0601A237 RID: 107063 RVA: 0x008141E1 File Offset: 0x008123E1
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A93 RID: 10899
	// (get) Token: 0x0601A238 RID: 107064 RVA: 0x008141E4 File Offset: 0x008123E4
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A94 RID: 10900
	// (get) Token: 0x0601A239 RID: 107065 RVA: 0x008141E7 File Offset: 0x008123E7
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A95 RID: 10901
	// (get) Token: 0x0601A23A RID: 107066 RVA: 0x008141EA File Offset: 0x008123EA
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}
}
