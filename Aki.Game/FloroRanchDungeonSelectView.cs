using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B61 RID: 7009
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDungeonSelectView : UiViewBase
{
	// Token: 0x0600CFFC RID: 53244 RVA: 0x002F69D1 File Offset: 0x002F4BD1
	public FloroRanchDungeonSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600CFFD RID: 53245 RVA: 0x002F69E8 File Offset: 0x002F4BE8
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

	// Token: 0x0600CFFE RID: 53246 RVA: 0x002F6C00 File Offset: 0x002F4E00
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchDungeonSelectView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchDungeonSelectView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CFFF RID: 53247 RVA: 0x002F6C44 File Offset: 0x002F4E44
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.FloroRanchRaceRedDot, new Action<IReadOnlyList<int>>(this.RefreshRaceList));
		EventSystem.Instance.Add<EFloroRanchActivityDataType, int>(EEventName.FloroRanchSkillChange, new Action<EFloroRanchActivityDataType, int>(this.OnSkillChange));
		EventSystem.Instance.Add<EFloroRanchActivityDataType>(EEventName.FloroRanchSkillRedDotRefresh, new Action<EFloroRanchActivityDataType>(this.OnSkillRedDotRefresh));
	}

	// Token: 0x0600D000 RID: 53248 RVA: 0x002F6CA8 File Offset: 0x002F4EA8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.FloroRanchRaceRedDot, new Action<IReadOnlyList<int>>(this.RefreshRaceList));
		EventSystem.Instance.Remove(EEventName.FloroRanchSkillChange, new Action<EFloroRanchActivityDataType, int>(this.OnSkillChange));
		EventSystem.Instance.Remove(EEventName.FloroRanchSkillRedDotRefresh, new Action<EFloroRanchActivityDataType>(this.OnSkillRedDotRefresh));
	}

	// Token: 0x0600D001 RID: 53249 RVA: 0x002F6D09 File Offset: 0x002F4F09
	private void RefreshView(FloroRanchDungeonData dungeonData)
	{
		this.RefreshView(dungeonData, null);
	}

	// Token: 0x0600D002 RID: 53250 RVA: 0x002F6D14 File Offset: 0x002F4F14
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

	// Token: 0x0600D003 RID: 53251 RVA: 0x002F6DDD File Offset: 0x002F4FDD
	public void RefreshRaceList(IReadOnlyList<int> raceIds)
	{
		this.RaceIds = raceIds.ToList<int>();
		FloroRanchDungeonSelectRightPanel rightPanel = this.RightPanel;
		if (rightPanel == null)
		{
			return;
		}
		rightPanel.RefreshRaceList(raceIds);
	}

	// Token: 0x0600D004 RID: 53252 RVA: 0x002F6DFC File Offset: 0x002F4FFC
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

	// Token: 0x0600D005 RID: 53253 RVA: 0x002F6E16 File Offset: 0x002F5016
	public void RefreshSkillItemRedDot()
	{
		FloroRanchSkillItem skillItem = this.SkillItem;
		if (skillItem == null)
		{
			return;
		}
		skillItem.RefreshRedDot();
	}

	// Token: 0x0600D006 RID: 53254 RVA: 0x002F6E28 File Offset: 0x002F5028
	private void OnSkillChange(EFloroRanchActivityDataType activityDataType, int skillId)
	{
		if (activityDataType != EFloroRanchActivityDataType.Normal)
		{
			return;
		}
		this.RefreshSkillItem(skillId);
	}

	// Token: 0x0600D007 RID: 53255 RVA: 0x002F6E35 File Offset: 0x002F5035
	private void OnSkillRedDotRefresh(EFloroRanchActivityDataType activityDataType)
	{
		if (activityDataType != EFloroRanchActivityDataType.Normal)
		{
			return;
		}
		this.RefreshSkillItemRedDot();
	}

	// Token: 0x0600D008 RID: 53256 RVA: 0x002F6E44 File Offset: 0x002F5044
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

	// Token: 0x0600D009 RID: 53257 RVA: 0x002F6F43 File Offset: 0x002F5143
	private FloroRanchDungeonItem CreateDungeonItem()
	{
		FloroRanchDungeonItem floroRanchDungeonItem = new FloroRanchDungeonItem();
		floroRanchDungeonItem.SetToggleCallBack(new Action<FloroRanchDungeonData>(this.RefreshView));
		return floroRanchDungeonItem;
	}

	// Token: 0x0600D00A RID: 53258 RVA: 0x002F6F5C File Offset: 0x002F515C
	private void OnCloseBtnClick()
	{
		if (this.IsStartClick)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600D00B RID: 53259 RVA: 0x002F6F70 File Offset: 0x002F5170
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

	// Token: 0x0600D00C RID: 53260 RVA: 0x002F705F File Offset: 0x002F525F
	protected override void OnBeforeDestroy()
	{
		this.IsStartClick = false;
	}

	// Token: 0x04005F91 RID: 24465
	[Nullable(2)]
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x04005F92 RID: 24466
	private int SubDungeonId;

	// Token: 0x04005F93 RID: 24467
	private int SkillId;

	// Token: 0x04005F94 RID: 24468
	private List<int> RaceIds = new List<int>();

	// Token: 0x04005F95 RID: 24469
	private GenericScrollViewNew<FloroRanchDungeonItem, FloroRanchDungeonData> DungeonScrollLayout;

	// Token: 0x04005F96 RID: 24470
	[Nullable(2)]
	private FloroRanchDungeonSelectRightPanel RightPanel;

	// Token: 0x04005F97 RID: 24471
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04005F98 RID: 24472
	[Nullable(2)]
	private FloroRanchSkillItem SkillItem;

	// Token: 0x04005F99 RID: 24473
	private bool IsStartClick;

	// Token: 0x020080B9 RID: 32953
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04029FBB RID: 171963
		public const int TextTitle = 0;

		// Token: 0x04029FBC RID: 171964
		public const int BtnClose = 1;

		// Token: 0x04029FBD RID: 171965
		public const int BtnStart = 2;

		// Token: 0x04029FBE RID: 171966
		public const int ItemRightPanel = 3;

		// Token: 0x04029FBF RID: 171967
		public const int ItemHistoryPanel = 4;

		// Token: 0x04029FC0 RID: 171968
		public const int TextHistoryDay = 5;

		// Token: 0x04029FC1 RID: 171969
		public const int TextHistoryCoin = 6;

		// Token: 0x04029FC2 RID: 171970
		public const int SpineRole = 7;

		// Token: 0x04029FC3 RID: 171971
		public const int ItemSKill = 8;

		// Token: 0x04029FC4 RID: 171972
		public const int ScrollLayoutDungeon = 9;

		// Token: 0x04029FC5 RID: 171973
		public const int ItemLockPanel = 10;

		// Token: 0x04029FC6 RID: 171974
		public const int MaskPanel = 11;
	}
}
