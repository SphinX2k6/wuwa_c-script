using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B6B RID: 7019
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchMainView : UiViewBase
{
	// Token: 0x0600D0B4 RID: 53428 RVA: 0x002FAB3E File Offset: 0x002F8D3E
	[NullableContext(1)]
	public FloroRanchMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D0B5 RID: 53429 RVA: 0x002FAB48 File Offset: 0x002F8D48
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

	// Token: 0x0600D0B6 RID: 53430 RVA: 0x002FAD1C File Offset: 0x002F8F1C
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

	// Token: 0x0600D0B7 RID: 53431 RVA: 0x002FAE44 File Offset: 0x002F9044
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.FloroRanchDataRedDot, new Action(this.OnRefreshData));
		EventSystem.Instance.Add(EEventName.FloroRanchSettlement, new Action(this.OnFloroRanchSettlement));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600D0B8 RID: 53432 RVA: 0x002FAEA8 File Offset: 0x002F90A8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.FloroRanchDataRedDot, new Action(this.OnRefreshData));
		EventSystem.Instance.Remove(EEventName.FloroRanchSettlement, new Action(this.OnFloroRanchSettlement));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600D0B9 RID: 53433 RVA: 0x002FAF09 File Offset: 0x002F9109
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

	// Token: 0x0600D0BA RID: 53434 RVA: 0x002FAF48 File Offset: 0x002F9148
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

	// Token: 0x0600D0BB RID: 53435 RVA: 0x002FAFC8 File Offset: 0x002F91C8
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

	// Token: 0x0600D0BC RID: 53436 RVA: 0x002FB0AC File Offset: 0x002F92AC
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

	// Token: 0x0600D0BD RID: 53437 RVA: 0x002FB12F File Offset: 0x002F932F
	protected override void OnBeforeHide()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		this.IsRequesting = false;
	}

	// Token: 0x0600D0BE RID: 53438 RVA: 0x002FB158 File Offset: 0x002F9358
	private void OnRefreshData()
	{
		this.RefreshData();
	}

	// Token: 0x0600D0BF RID: 53439 RVA: 0x002FB160 File Offset: 0x002F9360
	private void OnFloroRanchSettlement()
	{
		this.RefreshView();
	}

	// Token: 0x0600D0C0 RID: 53440 RVA: 0x002FB168 File Offset: 0x002F9368
	private void OnRefreshCommonActivityRedDot(int _)
	{
		this.RefreshView();
	}

	// Token: 0x0600D0C1 RID: 53441 RVA: 0x002FB170 File Offset: 0x002F9370
	private void OnLimitRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchLimitRewardView, null, null);
	}

	// Token: 0x0600D0C2 RID: 53442 RVA: 0x002FB183 File Offset: 0x002F9383
	private void OnPermanentRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchPermanentRewardView, null, null);
	}

	// Token: 0x0600D0C3 RID: 53443 RVA: 0x002FB198 File Offset: 0x002F9398
	private void OnSkillBtnClick(int _)
	{
		FloroRanchSkillViewParam floroRanchSkillViewParam = new FloroRanchSkillViewParam
		{
			CanSelect = false,
			ActivityDataType = EFloroRanchActivityDataType.Normal
		};
		UiManager.Instance.OpenView(EUiViewName.FloroRanchSkillView, floroRanchSkillViewParam, null);
	}

	// Token: 0x0600D0C4 RID: 53444 RVA: 0x002FB1D5 File Offset: 0x002F93D5
	private void OnHandBookBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchHandBookView, null, null);
	}

	// Token: 0x0600D0C5 RID: 53445 RVA: 0x002FB1E8 File Offset: 0x002F93E8
	private void OnTechnologyBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchTechnologyView, null, null);
	}

	// Token: 0x0600D0C6 RID: 53446 RVA: 0x002FB1FC File Offset: 0x002F93FC
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

	// Token: 0x0600D0C7 RID: 53447 RVA: 0x002FB34E File Offset: 0x002F954E
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005FCD RID: 24525
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x04005FCE RID: 24526
	private ButtonItem LimitRewardBtn;

	// Token: 0x04005FCF RID: 24527
	private ButtonItem PermanentRewardBtn;

	// Token: 0x04005FD0 RID: 24528
	private ButtonItem SkillBtn;

	// Token: 0x04005FD1 RID: 24529
	private ButtonItem HandBookBtn;

	// Token: 0x04005FD2 RID: 24530
	private ButtonItem TechnologyBtn;

	// Token: 0x04005FD3 RID: 24531
	private TimerHandle TimerHandle;

	// Token: 0x04005FD4 RID: 24532
	private bool IsRequesting;

	// Token: 0x020080DA RID: 32986
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A0A5 RID: 172197
		public const int ItemCaption = 0;

		// Token: 0x0402A0A6 RID: 172198
		public const int ItemLimitRewardBtn = 1;

		// Token: 0x0402A0A7 RID: 172199
		public const int ItemPermanentRewardBtn = 2;

		// Token: 0x0402A0A8 RID: 172200
		public const int ItemSkillBtn = 3;

		// Token: 0x0402A0A9 RID: 172201
		public const int ItemHandBookBtn = 4;

		// Token: 0x0402A0AA RID: 172202
		public const int ItemTechnologyBtn = 5;

		// Token: 0x0402A0AB RID: 172203
		public const int DungeonSelectBtn = 6;

		// Token: 0x0402A0AC RID: 172204
		public const int TextDungeonSelectBtn = 7;

		// Token: 0x0402A0AD RID: 172205
		public const int ItemHasRecord = 8;

		// Token: 0x0402A0AE RID: 172206
		public const int ItemDungeonSelectRedDot = 9;

		// Token: 0x0402A0AF RID: 172207
		public const int ItemMask = 10;
	}
}
