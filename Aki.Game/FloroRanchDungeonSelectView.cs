using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001020 RID: 4128
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDungeonSelectView : UiViewBase
{
	// Token: 0x0600A40D RID: 41997 RVA: 0x00301AA9 File Offset: 0x002FFCA9
	public FloroRanchDungeonSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A40E RID: 41998 RVA: 0x00301AC0 File Offset: 0x002FFCC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnStartBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A40F RID: 41999 RVA: 0x00301CD8 File Offset: 0x002FFED8
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchDungeonSelectView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchDungeonSelectView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A410 RID: 42000 RVA: 0x00301D1C File Offset: 0x002FFF1C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.FloroRanchRaceRedDot, new Action<IReadOnlyList<int>>(this.RefreshRaceList));
		EventSystem.Instance.Add<EFloroRanchActivityDataType, int>(EEventName.FloroRanchSkillChange, new Action<EFloroRanchActivityDataType, int>(this.OnSkillChange));
		EventSystem.Instance.Add<EFloroRanchActivityDataType>(EEventName.FloroRanchSkillRedDotRefresh, new Action<EFloroRanchActivityDataType>(this.OnSkillRedDotRefresh));
	}

	// Token: 0x0600A411 RID: 42001 RVA: 0x00301D80 File Offset: 0x002FFF80
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.FloroRanchRaceRedDot, new Action<IReadOnlyList<int>>(this.RefreshRaceList));
		EventSystem.Instance.Remove(EEventName.FloroRanchSkillChange, new Action<EFloroRanchActivityDataType, int>(this.OnSkillChange));
		EventSystem.Instance.Remove(EEventName.FloroRanchSkillRedDotRefresh, new Action<EFloroRanchActivityDataType>(this.OnSkillRedDotRefresh));
	}

	// Token: 0x0600A412 RID: 42002 RVA: 0x00301DE1 File Offset: 0x002FFFE1
	private void RefreshView(FloroRanchDungeonData dungeonData)
	{
		this.RefreshView(dungeonData, null);
	}

	// Token: 0x0600A413 RID: 42003 RVA: 0x00301DEC File Offset: 0x002FFFEC
	private void RefreshView(FloroRanchDungeonData dungeonData, [Nullable(2)] FloroRanchSubDungeonData subDungeonData = null)
	{
		this.DungeonScrollLayout.LateScrollTo(this.DungeonScrollLayout.GetItemByKey(dungeonData.Id), null, false);
		GenericScrollViewNew<FloroRanchDungeonItem, FloroRanchDungeonData> dungeonScrollLayout = this.DungeonScrollLayout;
		FloroRanchDungeonItem scrollItemByKey = this.DungeonScrollLayout.GetScrollItemByKey(dungeonData.Id);
		dungeonScrollLayout.SelectGridProxy((scrollItemByKey != null) ? scrollItemByKey.GridIndex : 0, false);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(dungeonData.IsUnLock);
		}
		FloroRanchDungeonSelectRightPanel rightPanel = this.RightPanel;
		if (rightPanel != null)
		{
			rightPanel.RefreshDungeonInfo(dungeonData, subDungeonData);
		}
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(dungeonData.IsUnLock);
		}
		if (!dungeonData.IsUnLock)
		{
			UUIItem item2 = base.GetItem(10);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}
	}

	// Token: 0x0600A414 RID: 42004 RVA: 0x00301EB5 File Offset: 0x003000B5
	public void RefreshRaceList(IReadOnlyList<int> raceIds)
	{
		this.RaceIds = new List<int>(raceIds);
		FloroRanchDungeonSelectRightPanel rightPanel = this.RightPanel;
		if (rightPanel == null)
		{
			return;
		}
		rightPanel.RefreshRaceList(raceIds);
	}

	// Token: 0x0600A415 RID: 42005 RVA: 0x00301ED4 File Offset: 0x003000D4
	public void RefreshSkillItem(int skillId)
	{
		this.SkillId = skillId;
		FloroRanchSkillItem skillItem = this.SkillItem;
		if (skillItem == null)
		{
			return;
		}
		skillItem.Refresh(skillId);
	}

	// Token: 0x0600A416 RID: 42006 RVA: 0x00301EEE File Offset: 0x003000EE
	public void RefreshSkillItemRedDot()
	{
		FloroRanchSkillItem skillItem = this.SkillItem;
		if (skillItem == null)
		{
			return;
		}
		skillItem.RefreshRedDot();
	}

	// Token: 0x0600A417 RID: 42007 RVA: 0x00301F00 File Offset: 0x00300100
	private void OnSkillChange(EFloroRanchActivityDataType activityDataType, int skillId)
	{
		if (activityDataType != EFloroRanchActivityDataType.Normal)
		{
			return;
		}
		this.RefreshSkillItem(skillId);
	}

	// Token: 0x0600A418 RID: 42008 RVA: 0x00301F0D File Offset: 0x0030010D
	private void OnSkillRedDotRefresh(EFloroRanchActivityDataType activityDataType)
	{
		if (activityDataType != EFloroRanchActivityDataType.Normal)
		{
			return;
		}
		this.RefreshSkillItemRedDot();
	}

	// Token: 0x0600A419 RID: 42009 RVA: 0x00301F1C File Offset: 0x0030011C
	private void SetSubDungeonId(int subDungeonId)
	{
		this.SubDungeonId = subDungeonId;
		FloroRanchSubDungeonData floroRanchSubDungeonData = this.ActivityData.GetFloroRanchSubDungeonData(subDungeonId);
		this.RaceIds = floroRanchSubDungeonData.SelectedRaceIds;
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(floroRanchSubDungeonData.IsUnLock);
		}
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(!floroRanchSubDungeonData.IsUnLock);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "FloroRanchDayNum", new <>z__ReadOnlySingleElementList<object>(floroRanchSubDungeonData.MaxDays));
		long maxCoin = floroRanchSubDungeonData.MaxCoin;
		string coinText = FloroRanchModel.Instance.GetCoinText(maxCoin);
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.SetText(coinText, true);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(floroRanchSubDungeonData.HasHistory);
		}
		if (!floroRanchSubDungeonData.IsUnLock)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(floroRanchSubDungeonData.ConditionId);
			FunctionalPanelConditionLock panelLock = this.PanelLock;
			if (panelLock == null)
			{
				return;
			}
			panelLock.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
		}
	}

	// Token: 0x0600A41A RID: 42010 RVA: 0x0030201B File Offset: 0x0030021B
	private FloroRanchDungeonItem CreateDungeonItem()
	{
		FloroRanchDungeonItem floroRanchDungeonItem = new FloroRanchDungeonItem();
		floroRanchDungeonItem.SetToggleCallBack(new Action<FloroRanchDungeonData>(this.RefreshView));
		return floroRanchDungeonItem;
	}

	// Token: 0x0600A41B RID: 42011 RVA: 0x00302034 File Offset: 0x00300234
	private void OnCloseBtnClick()
	{
		if (this.IsStartClick)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600A41C RID: 42012 RVA: 0x00302048 File Offset: 0x00300248
	private void OnStartBtnClick()
	{
		if (this.IsStartClick)
		{
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
			return;
		}
		if (this.RaceIds.Contains(0))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ChooseRace", Array.Empty<object>());
			return;
		}
		if (this.SkillId == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ChooseSkill", Array.Empty<object>());
			return;
		}
		this.IsStartClick = true;
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		FloroRanchController.Instance.SendFloroRanchStartPlayRequest(this.ActivityData.Id, this.SubDungeonId, this.RaceIds.ToArray(), new int?(this.SkillId), delegate(FloroRanchStartPlayResponse _)
		{
			this.IsStartClick = false;
			UUIButtonComponent button2 = base.GetButton(2);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			base.CloseMe(null);
		});
	}

	// Token: 0x0600A41D RID: 42013 RVA: 0x00302137 File Offset: 0x00300337
	protected override void OnBeforeDestroy()
	{
		this.IsStartClick = false;
	}

	// Token: 0x04006060 RID: 24672
	[Nullable(2)]
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x04006061 RID: 24673
	private int SubDungeonId;

	// Token: 0x04006062 RID: 24674
	private int SkillId;

	// Token: 0x04006063 RID: 24675
	private List<int> RaceIds = new List<int>();

	// Token: 0x04006064 RID: 24676
	private GenericScrollViewNew<FloroRanchDungeonItem, FloroRanchDungeonData> DungeonScrollLayout;

	// Token: 0x04006065 RID: 24677
	[Nullable(2)]
	private FloroRanchDungeonSelectRightPanel RightPanel;

	// Token: 0x04006066 RID: 24678
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04006067 RID: 24679
	[Nullable(2)]
	private FloroRanchSkillItem SkillItem;

	// Token: 0x04006068 RID: 24680
	private bool IsStartClick;

	// Token: 0x02007247 RID: 29255
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040252EF RID: 152303
		public const int TextTitle = 0;

		// Token: 0x040252F0 RID: 152304
		public const int BtnClose = 1;

		// Token: 0x040252F1 RID: 152305
		public const int BtnStart = 2;

		// Token: 0x040252F2 RID: 152306
		public const int ItemRightPanel = 3;

		// Token: 0x040252F3 RID: 152307
		public const int ItemHistoryPanel = 4;

		// Token: 0x040252F4 RID: 152308
		public const int TextHistoryDay = 5;

		// Token: 0x040252F5 RID: 152309
		public const int TextHistoryCoin = 6;

		// Token: 0x040252F6 RID: 152310
		public const int SpineRole = 7;

		// Token: 0x040252F7 RID: 152311
		public const int ItemSKill = 8;

		// Token: 0x040252F8 RID: 152312
		public const int ScrollLayoutDungeon = 9;

		// Token: 0x040252F9 RID: 152313
		public const int ItemLockPanel = 10;

		// Token: 0x040252FA RID: 152314
		public const int MaskPanel = 11;
	}
}
