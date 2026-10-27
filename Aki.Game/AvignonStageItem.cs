using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001113 RID: 4371
public class AvignonStageItem : UiPanelBase
{
	// Token: 0x0600724F RID: 29263 RVA: 0x00176244 File Offset: 0x00174444
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007250 RID: 29264 RVA: 0x001763D4 File Offset: 0x001745D4
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshProgressAndRedDot));
		this.StageId = (int)this.OpenParam;
		this.AvignonStageConf = AvignonConfig.Instance.GetStageConfigById(this.StageId);
		this.AvignonStageInfo = AvignonModel.Instance.GetAvignonStageInfo(this.StageId);
		if (this.AvignonStageConf == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.AvignonStageConf.Value.Title, Array.Empty<object>());
		string path = this.AvignonStageConf.Value.Icon;
		if (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female)
		{
			path = this.AvignonStageConf.Value.FemaleIcon;
		}
		base.SetTextureByPath(path, base.GetTexture(6), null, null);
		this.SetSpriteByPath(this.AvignonStageConf.Value.RomaIcon, base.GetSprite(7), false, null, null);
		this.RefreshUI();
	}

	// Token: 0x06007251 RID: 29265 RVA: 0x001764F1 File Offset: 0x001746F1
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new <>f__AnonymousDelegate2<int>(this.RefreshProgressAndRedDot));
	}

	// Token: 0x06007252 RID: 29266 RVA: 0x00176510 File Offset: 0x00174710
	private void RefreshUI()
	{
		EStageState stageState = this.AvignonStageInfo.StageState;
		base.GetItem(1).SetUIActive(stageState == EStageState.Lock);
		this.RefreshProgressAndRedDot(0);
		if (stageState == EStageState.Lock)
		{
			string textStringId = LevelGeneralCommons.GetConditionGroupHintText(this.AvignonStageConf.Value.OpenConditionId) ?? string.Empty;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
		}
	}

	// Token: 0x06007253 RID: 29267 RVA: 0x0017657C File Offset: 0x0017477C
	private void RefreshProgressAndRedDot(int i = 0)
	{
		this.AvignonStageInfo = AvignonModel.Instance.GetAvignonStageInfo(this.StageId);
		int taskProgress = this.AvignonStageInfo.GetTaskProgress();
		UUIText text = base.GetText(4);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(taskProgress);
		defaultInterpolatedStringHandler.AppendLiteral("<size=-18>%</size>");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		EStageState stageState = this.AvignonStageInfo.StageState;
		base.GetSprite(5).SetUIActive(stageState == EStageState.Finished);
		bool uiactive = this.AvignonStageInfo.GetRewardState() || this.AvignonStageInfo.HasNewStageFlag();
		base.GetItem(8).SetUIActive(uiactive);
	}

	// Token: 0x06007254 RID: 29268 RVA: 0x00176624 File Offset: 0x00174824
	private void OnClicked()
	{
		if (this.AvignonStageInfo == null)
		{
			return;
		}
		if (this.AvignonStageInfo.IsUnlock)
		{
			UiManager.Instance.OpenView(EUiViewName.AvignonStageTaskView, this.StageId, null);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId(this.AvignonStageInfo.GetLockConditionText(), Array.Empty<object>());
	}

	// Token: 0x040034F3 RID: 13555
	private int StageId;

	// Token: 0x040034F4 RID: 13556
	private AvignonStage? AvignonStageConf;

	// Token: 0x040034F5 RID: 13557
	[Nullable(2)]
	private AvignonStageInfo AvignonStageInfo;

	// Token: 0x020076D6 RID: 30422
	private class EComponents
	{
		// Token: 0x04027370 RID: 160624
		public const int BtnRoot = 0;

		// Token: 0x04027371 RID: 160625
		public const int ItemLock = 1;

		// Token: 0x04027372 RID: 160626
		public const int TxtUnlockCondition = 2;

		// Token: 0x04027373 RID: 160627
		public const int TxtStageName = 3;

		// Token: 0x04027374 RID: 160628
		public const int TxtFinishPercent = 4;

		// Token: 0x04027375 RID: 160629
		public const int SpriteFinish = 5;

		// Token: 0x04027376 RID: 160630
		public const int TextureIcon = 6;

		// Token: 0x04027377 RID: 160631
		public const int SpriteRoma = 7;

		// Token: 0x04027378 RID: 160632
		public const int ItemRedDot = 8;
	}
}
