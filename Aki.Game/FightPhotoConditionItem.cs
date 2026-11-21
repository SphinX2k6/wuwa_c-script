using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A9F RID: 6815
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoConditionItem : GridProxyAbstract<FightPhotoConditionData>
{
	// Token: 0x06010DF8 RID: 69112 RVA: 0x004F3150 File Offset: 0x004F1350
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06010DF9 RID: 69113 RVA: 0x004F31AA File Offset: 0x004F13AA
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnChangeFightPhotoOption, new Action(this.OnChangeFightPhotoOption));
	}

	// Token: 0x06010DFA RID: 69114 RVA: 0x004F31C8 File Offset: 0x004F13C8
	[NullableContext(1)]
	public override void Refresh(FightPhotoConditionData data, bool isSelected, int gridIndex)
	{
		this.ConditionType = data.ConditionType;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Text, Array.Empty<object>());
		this.RefreshConditionStatus();
	}

	// Token: 0x06010DFB RID: 69115 RVA: 0x004F31F8 File Offset: 0x004F13F8
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

	// Token: 0x06010DFC RID: 69116 RVA: 0x004F3285 File Offset: 0x004F1485
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeFightPhotoOption, new Action(this.OnChangeFightPhotoOption));
	}

	// Token: 0x06010DFD RID: 69117 RVA: 0x004F32A3 File Offset: 0x004F14A3
	private void OnChangeFightPhotoOption()
	{
		this.RefreshConditionStatus();
	}

	// Token: 0x04009513 RID: 38163
	private EFightPhotoConditionType ConditionType;

	// Token: 0x02007D40 RID: 32064
	private enum EComponents
	{
		// Token: 0x040288B7 RID: 166071
		SpriteFinish,
		// Token: 0x040288B8 RID: 166072
		TextDescription,
		// Token: 0x040288B9 RID: 166073
		TextureFinishBg
	}
}
