using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200102A RID: 4138
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchMainView : UiViewBase
{
	// Token: 0x0600A4C5 RID: 42181 RVA: 0x00305C17 File Offset: 0x00303E17
	[NullableContext(1)]
	public FloroRanchMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A4C6 RID: 42182 RVA: 0x00305C20 File Offset: 0x00303E20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnDungeonSelectBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A4C7 RID: 42183 RVA: 0x00305DF4 File Offset: 0x00303FF4
	protected override void OnStart()
	{
		new PopupCaptionItem(base.GetItem(0)).SetCloseCallBack(new Action(this.OnCloseBtnClick));
		this.ActivityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		this.LimitRewardBtn = new ButtonItem(base.GetItem(1));
		this.LimitRewardBtn.SetFunction(new Action<int>(this.OnLimitRewardBtnClick));
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(this.ActivityData.IsInLimitTime());
		}
		this.PermanentRewardBtn = new ButtonItem(base.GetItem(2));
		this.PermanentRewardBtn.SetFunction(new Action<int>(this.OnPermanentRewardBtnClick));
		this.SkillBtn = new ButtonItem(base.GetItem(3));
		this.SkillBtn.SetFunction(new Action<int>(this.OnSkillBtnClick));
		this.HandBookBtn = new ButtonItem(base.GetItem(4));
		this.HandBookBtn.SetFunction(new Action<int>(this.OnHandBookBtnClick));
		this.TechnologyBtn = new ButtonItem(base.GetItem(5));
		this.TechnologyBtn.SetFunction(new Action<int>(this.OnTechnologyBtnClick));
	}

	// Token: 0x0600A4C8 RID: 42184 RVA: 0x00305F1C File Offset: 0x0030411C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.FloroRanchDataRedDot, new Action(this.OnRefreshData));
		EventSystem.Instance.Add(EEventName.FloroRanchSettlement, new Action(this.OnFloroRanchSettlement));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600A4C9 RID: 42185 RVA: 0x00305F80 File Offset: 0x00304180
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.FloroRanchDataRedDot, new Action(this.OnRefreshData));
		EventSystem.Instance.Remove(EEventName.FloroRanchSettlement, new Action(this.OnFloroRanchSettlement));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600A4CA RID: 42186 RVA: 0x00305FE1 File Offset: 0x003041E1
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.RefreshTimeText();
		this.RefreshData();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.RefreshTimeText();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600A4CB RID: 42187 RVA: 0x00306020 File Offset: 0x00304220
	private void RefreshData()
	{
		bool redDotVisible = this.ActivityData.IsSkillHasRedDot();
		ButtonItem skillBtn = this.SkillBtn;
		if (skillBtn != null)
		{
			skillBtn.SetRedDotVisible(redDotVisible);
		}
		ButtonItem handBookBtn = this.HandBookBtn;
		if (handBookBtn != null)
		{
			handBookBtn.SetRedDotVisible(this.ActivityData.IsHandBookHasRedDot());
		}
		string technologyProgress = this.ActivityData.GetTechnologyProgress();
		ButtonItem technologyBtn = this.TechnologyBtn;
		if (technologyBtn != null)
		{
			technologyBtn.SetText(technologyProgress);
		}
		ButtonItem technologyBtn2 = this.TechnologyBtn;
		if (technologyBtn2 == null)
		{
			return;
		}
		technologyBtn2.SetRedDotVisible(this.ActivityData.HasAnyTechPointCanUnlock());
	}

	// Token: 0x0600A4CC RID: 42188 RVA: 0x003060A0 File Offset: 0x003042A0
	public void RefreshView()
	{
		string permanentRewardProgress = this.ActivityData.GetPermanentRewardProgress();
		ButtonItem permanentRewardBtn = this.PermanentRewardBtn;
		if (permanentRewardBtn != null)
		{
			permanentRewardBtn.SetText(permanentRewardProgress);
		}
		ButtonItem permanentRewardBtn2 = this.PermanentRewardBtn;
		if (permanentRewardBtn2 != null)
		{
			permanentRewardBtn2.SetRedDotVisible(this.ActivityData.IsPermanentTaskHasRedDot());
		}
		ButtonItem limitRewardBtn = this.LimitRewardBtn;
		if (limitRewardBtn != null)
		{
			limitRewardBtn.SetRedDotVisible(this.ActivityData.IsLimitTaskHasRedDot());
		}
		string handBookProgress = this.ActivityData.GetHandBookProgress();
		ButtonItem handBookBtn = this.HandBookBtn;
		if (handBookBtn != null)
		{
			handBookBtn.SetText(handBookProgress);
		}
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(this.ActivityData.IsDungeonHasRedDot());
		}
		bool flag = this.ActivityData.HasUnFinishedSubIns();
		string textStringId = flag ? "Farm_ContinueGame" : "Farm_NewGame";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), textStringId, Array.Empty<object>());
		UUIItem item2 = base.GetItem(8);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(flag);
	}

	// Token: 0x0600A4CD RID: 42189 RVA: 0x00306184 File Offset: 0x00304384
	private void RefreshTimeText()
	{
		if (!this.ActivityData.IsInLimitTime() && this.TimerHandle != null)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(this.ActivityData.IsInLimitTime());
			}
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.GetLimitTimeActivityEndTime(), "{0}");
		ButtonItem limitRewardBtn = this.LimitRewardBtn;
		if (limitRewardBtn == null)
		{
			return;
		}
		limitRewardBtn.SetText(remainTimeText);
	}

	// Token: 0x0600A4CE RID: 42190 RVA: 0x00306207 File Offset: 0x00304407
	protected override void OnBeforeHide()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		this.IsRequesting = false;
	}

	// Token: 0x0600A4CF RID: 42191 RVA: 0x00306230 File Offset: 0x00304430
	private void OnRefreshData()
	{
		this.RefreshData();
	}

	// Token: 0x0600A4D0 RID: 42192 RVA: 0x00306238 File Offset: 0x00304438
	private void OnFloroRanchSettlement()
	{
		this.RefreshView();
	}

	// Token: 0x0600A4D1 RID: 42193 RVA: 0x00306240 File Offset: 0x00304440
	private void OnRefreshCommonActivityRedDot(int _)
	{
		this.RefreshView();
	}

	// Token: 0x0600A4D2 RID: 42194 RVA: 0x00306248 File Offset: 0x00304448
	private void OnLimitRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchLimitRewardView, null, null);
	}

	// Token: 0x0600A4D3 RID: 42195 RVA: 0x0030625B File Offset: 0x0030445B
	private void OnPermanentRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchPermanentRewardView, null, null);
	}

	// Token: 0x0600A4D4 RID: 42196 RVA: 0x00306270 File Offset: 0x00304470
	private void OnSkillBtnClick(int _)
	{
		FloroRanchSkillViewParam floroRanchSkillViewParam = new FloroRanchSkillViewParam
		{
			CanSelect = false,
			ActivityDataType = EFloroRanchActivityDataType.Normal
		};
		UiManager.Instance.OpenView(EUiViewName.FloroRanchSkillView, floroRanchSkillViewParam, null);
	}

	// Token: 0x0600A4D5 RID: 42197 RVA: 0x003062AD File Offset: 0x003044AD
	private void OnHandBookBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchHandBookView, null, null);
	}

	// Token: 0x0600A4D6 RID: 42198 RVA: 0x003062C0 File Offset: 0x003044C0
	private void OnTechnologyBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchTechnologyView, null, null);
	}

	// Token: 0x0600A4D7 RID: 42199 RVA: 0x003062D4 File Offset: 0x003044D4
	private void OnDungeonSelectBtnClick()
	{
		if (this.IsRequesting)
		{
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
			return;
		}
		if (this.ActivityData.HasUnFinishedSubIns())
		{
			FloroRanchSubDungeonData subDungeonData = this.ActivityData.GetUnFinishedSubDungeonData();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FloroRanchArchive);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.ActivityData.GetFloroRanchDungeonData(subDungeonData.InstanceId).GetDungeonName(), null);
			EFloroRanchDifficulty difficulty = (EFloroRanchDifficulty)subDungeonData.Difficulty;
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(FloroRanchDefine.FloroRanchDifficultyTextId[difficulty], null);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				localTextNew,
				localTextNew2,
				this.ActivityData.GetSavedStage().ToString()
			});
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			this.IsRequesting = true;
			bool isConfirmed = false;
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				isConfirmed = true;
				FloroRanchController.Instance.SendFloroRanchAbandonArchiveRequest(this.ActivityData.Id, subDungeonData.Id, delegate(FloroRanchSettleResponse _)
				{
					this.IsRequesting = false;
					UiManager.Instance.OpenView(EUiViewName.FloroRanchDungeonSelectView, null, null);
				});
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				isConfirmed = true;
				FloroRanchController.Instance.SendFloroRanchStartPlayRequest(this.ActivityData.Id, subDungeonData.Id, null, null, delegate(FloroRanchStartPlayResponse response)
				{
					if (response == null)
					{
						this.IsRequesting = false;
					}
				});
			};
			confirmBoxDataNew.DestroyFunction = delegate()
			{
				if (!isConfirmed)
				{
					this.IsRequesting = false;
				}
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.FloroRanchDungeonSelectView, null, null);
	}

	// Token: 0x0600A4D8 RID: 42200 RVA: 0x00306426 File Offset: 0x00304626
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400609C RID: 24732
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x0400609D RID: 24733
	private ButtonItem LimitRewardBtn;

	// Token: 0x0400609E RID: 24734
	private ButtonItem PermanentRewardBtn;

	// Token: 0x0400609F RID: 24735
	private ButtonItem SkillBtn;

	// Token: 0x040060A0 RID: 24736
	private ButtonItem HandBookBtn;

	// Token: 0x040060A1 RID: 24737
	private ButtonItem TechnologyBtn;

	// Token: 0x040060A2 RID: 24738
	private TimerHandle TimerHandle;

	// Token: 0x040060A3 RID: 24739
	private bool IsRequesting;

	// Token: 0x02007268 RID: 29288
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040253D9 RID: 152537
		public const int ItemCaption = 0;

		// Token: 0x040253DA RID: 152538
		public const int ItemLimitRewardBtn = 1;

		// Token: 0x040253DB RID: 152539
		public const int ItemPermanentRewardBtn = 2;

		// Token: 0x040253DC RID: 152540
		public const int ItemSkillBtn = 3;

		// Token: 0x040253DD RID: 152541
		public const int ItemHandBookBtn = 4;

		// Token: 0x040253DE RID: 152542
		public const int ItemTechnologyBtn = 5;

		// Token: 0x040253DF RID: 152543
		public const int DungeonSelectBtn = 6;

		// Token: 0x040253E0 RID: 152544
		public const int TextDungeonSelectBtn = 7;

		// Token: 0x040253E1 RID: 152545
		public const int ItemHasRecord = 8;

		// Token: 0x040253E2 RID: 152546
		public const int ItemDungeonSelectRedDot = 9;

		// Token: 0x040253E3 RID: 152547
		public const int ItemMask = 10;
	}
}
