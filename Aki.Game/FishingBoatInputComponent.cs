using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;

// Token: 0x020032E6 RID: 13030
[NullableContext(1)]
[Nullable(0)]
public class FishingBoatInputComponent : GongduolaInputComponent
{
	// Token: 0x0601C58B RID: 116107 RVA: 0x007ED9EC File Offset: 0x007EBBEC
	protected override void ExecuteSprint(SInputCommand command)
	{
	}

	// Token: 0x0601C58C RID: 116108 RVA: 0x007ED9EE File Offset: 0x007EBBEE
	protected override void ExecuteSkill(SInputCommand command)
	{
		this.BeginSkill(command.IntValue);
	}

	// Token: 0x0601C58D RID: 116109 RVA: 0x007ED9FC File Offset: 0x007EBBFC
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

	// Token: 0x0601C58E RID: 116110 RVA: 0x007EDA34 File Offset: 0x007EBC34
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

	// Token: 0x0601C58F RID: 116111 RVA: 0x007EDA91 File Offset: 0x007EBC91
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		FishingBoatInputComponent fishingBoatInputComponent = (FishingBoatInputComponent)componentTemplate;
		return true;
	}
}
