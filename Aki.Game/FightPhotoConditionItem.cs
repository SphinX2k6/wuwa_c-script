using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020025B4 RID: 9652
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoConditionItem : GridProxyAbstract<FightPhotoConditionData>
{
	// Token: 0x06013918 RID: 80152 RVA: 0x004E4550 File Offset: 0x004E2750
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06013919 RID: 80153 RVA: 0x004E45AA File Offset: 0x004E27AA
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnChangeFightPhotoOption, new Action(this.OnChangeFightPhotoOption));
	}

	// Token: 0x0601391A RID: 80154 RVA: 0x004E45C8 File Offset: 0x004E27C8
	[NullableContext(1)]
	public override void Refresh(FightPhotoConditionData data, bool isSelected, int gridIndex)
	{
		this.ConditionType = data.ConditionType;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Text, Array.Empty<object>());
		this.RefreshConditionStatus();
	}

	// Token: 0x0601391B RID: 80155 RVA: 0x004E45F8 File Offset: 0x004E27F8
	public void RefreshConditionStatus()
	{
		FightPhotoModel instance = FightPhotoModel.Instance;
		TakePicturesWithTimeScaleChildQuestNode currentBtNode = PhotographController.Instance.CurrentBtNode;
		bool uiactive;
		if (this.ConditionType == EFightPhotoConditionType.CameraCondition)
		{
			uiactive = instance.CheckCameraCondition((currentBtNode != null) ? currentBtNode.CameraCondition : null);
		}
		else
		{
			uiactive = (instance.CheckRoleInCamera((currentBtNode != null) ? currentBtNode.PhotographCondition : null) && instance.CheckPhotographCondition((currentBtNode != null) ? currentBtNode.PhotographCondition : null));
		}
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetUIActive(uiactive);
		}
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(uiactive);
	}

	// Token: 0x0601391C RID: 80156 RVA: 0x004E4685 File Offset: 0x004E2885
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeFightPhotoOption, new Action(this.OnChangeFightPhotoOption));
	}

	// Token: 0x0601391D RID: 80157 RVA: 0x004E46A3 File Offset: 0x004E28A3
	private void OnChangeFightPhotoOption()
	{
		this.RefreshConditionStatus();
	}

	// Token: 0x040093BD RID: 37821
	private EFightPhotoConditionType ConditionType;

	// Token: 0x02008BB8 RID: 35768
	private enum EComponents
	{
		// Token: 0x0402D5A2 RID: 185762
		SpriteFinish,
		// Token: 0x0402D5A3 RID: 185763
		TextDescription,
		// Token: 0x0402D5A4 RID: 185764
		TextureFinishBg
	}
}
