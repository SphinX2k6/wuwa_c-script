using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020006B0 RID: 1712
public class ActivityCorniceMeetingTabItem : UiPanelBase, IGridProxy<int>
{
	// Token: 0x17000AA6 RID: 2726
	// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x001A7E30 File Offset: 0x001A6030
	// (set) Token: 0x06004EB4 RID: 20148 RVA: 0x001A7E38 File Offset: 0x001A6038
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IScrollViewDelegate<IGridProxy<int>, int> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000AA7 RID: 2727
	// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x001A7E41 File Offset: 0x001A6041
	// (set) Token: 0x06004EB6 RID: 20150 RVA: 0x001A7E49 File Offset: 0x001A6049
	public int GridIndex { get; set; }

	// Token: 0x17000AA8 RID: 2728
	// (get) Token: 0x06004EB7 RID: 20151 RVA: 0x001A7E52 File Offset: 0x001A6052
	// (set) Token: 0x06004EB8 RID: 20152 RVA: 0x001A7E5A File Offset: 0x001A605A
	public int DisplayIndex { get; set; }

	// Token: 0x17000AA9 RID: 2729
	// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x001A7E63 File Offset: 0x001A6063
	// (set) Token: 0x06004EBA RID: 20154 RVA: 0x001A7E6B File Offset: 0x001A606B
	public int LevelPlayId { get; set; }

	// Token: 0x06004EBB RID: 20155 RVA: 0x001A7E74 File Offset: 0x001A6074
	public void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.LevelPlayId = data;
		this.GridIndex = gridIndex;
		this.RefreshView();
		if (isSelected)
		{
			IScrollViewDelegate<IGridProxy<int>, int> scrollViewDelegate = this.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, false);
			}
		}
		this.TryBindRedDot();
	}

	// Token: 0x06004EBC RID: 20156 RVA: 0x001A7EB4 File Offset: 0x001A60B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004EBD RID: 20157 RVA: 0x001A80A8 File Offset: 0x001A62A8
	protected override void OnStart()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06004EBE RID: 20158 RVA: 0x001A80BC File Offset: 0x001A62BC
	private void OnClickItem(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ScrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, true);
		}
		EventSystem.Instance.Emit<int>(EEventName.OnClickActivityCorniceMeetingTab, this.LevelPlayId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.LevelPlayId);
	}

	// Token: 0x06004EBF RID: 20159 RVA: 0x001A8114 File Offset: 0x001A6314
	public void TryBindRedDot()
	{
		if (this.IsRedDotBind)
		{
			return;
		}
		this.IsRedDotBind = true;
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityCorniceMeeting, base.GetItem(10), delegate(bool toState, int _)
		{
			base.GetItem(10).SetUIActive(toState);
		}, this.LevelPlayId);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityCorniceMeeting, base.GetItem(6), delegate(bool toState, int _)
		{
			base.GetItem(6).SetUIActive(toState);
		}, this.LevelPlayId);
	}

	// Token: 0x06004EC0 RID: 20160 RVA: 0x001A8184 File Offset: 0x001A6384
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityCorniceMeeting, base.GetItem(10), this.LevelPlayId);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityCorniceMeeting, base.GetItem(6), this.LevelPlayId);
		base.GetSprite(7).SetSprite(null, true);
	}

	// Token: 0x06004EC1 RID: 20161 RVA: 0x001A81D8 File Offset: 0x001A63D8
	private void RefreshView()
	{
		ActivityCorniceMeetingLevelEntryData levelEntryData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData().GetLevelEntryData(this.LevelPlayId);
		base.SetTextureByPath(levelEntryData.GetBackgroundPath(), base.GetTexture(11), null, null);
		this.RefreshTitle();
		this.RefreshFinishedItem();
		this.RefreshLockItem();
	}

	// Token: 0x06004EC2 RID: 20162 RVA: 0x001A822C File Offset: 0x001A642C
	private void RefreshTitle()
	{
		ActivityCorniceMeetingLevelEntryData levelEntryData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData().GetLevelEntryData(this.LevelPlayId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), levelEntryData.GetTitle(), Array.Empty<object>());
	}

	// Token: 0x06004EC3 RID: 20163 RVA: 0x001A826C File Offset: 0x001A646C
	private void RefreshFinishedItem()
	{
		ActivityCorniceMeetingLevelEntryData levelEntryData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData().GetLevelEntryData(this.LevelPlayId);
		base.GetSprite(3).SetUIActive(levelEntryData.IsRewardAllFinished());
		base.GetSprite(8).SetUIActive(levelEntryData.IsRewardAllFinished());
		base.GetSprite(2).SetUIActive(false);
		string text = (this.GridIndex + 1).ToString();
		this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}", new string[]
		{
			text,
			text
		}), base.GetSprite(7), false, null, null);
	}

	// Token: 0x06004EC4 RID: 20164 RVA: 0x001A8304 File Offset: 0x001A6504
	private void RefreshLockItem()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		base.GetItem(9).SetUIActive(!currentActivityData.GetIsShow(this.LevelPlayId));
		base.GetItem(5).SetUIActive(!currentActivityData.GetIsShow(this.LevelPlayId));
		base.GetItem(4).SetUIActive(!currentActivityData.GetIsShow(this.LevelPlayId));
	}

	// Token: 0x06004EC5 RID: 20165 RVA: 0x001A836E File Offset: 0x001A656E
	public void Clear()
	{
	}

	// Token: 0x06004EC6 RID: 20166 RVA: 0x001A8370 File Offset: 0x001A6570
	public void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		currentActivityData.CurrentSelectLevelPlayId = this.LevelPlayId;
		ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(this.LevelPlayId);
		if (currentActivityData.GetIsShow(this.LevelPlayId))
		{
			if (levelEntryData.GetChallengeNewLocalRedDot())
			{
				levelEntryData.SetChallengeLocalRedDot(false);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCorniceMeetingRedDot, this.LevelPlayId);
			}
			else
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCorniceMeetingRedDot, this.LevelPlayId);
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.LevelPlayId);
	}

	// Token: 0x06004EC7 RID: 20167 RVA: 0x001A8411 File Offset: 0x001A6611
	public void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06004EC8 RID: 20168 RVA: 0x001A8424 File Offset: 0x001A6624
	[NullableContext(1)]
	public object GetKey(int data, int gridIndex)
	{
		return this.LevelPlayId;
	}

	// Token: 0x040038F6 RID: 14582
	[Nullable(1)]
	private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}";

	// Token: 0x040038FB RID: 14587
	private bool IsRedDotBind;

	// Token: 0x0200696F RID: 26991
	private class EComponents
	{
		// Token: 0x04022B8D RID: 142221
		public const int Toggle = 0;

		// Token: 0x04022B8E RID: 142222
		public const int Title = 1;

		// Token: 0x04022B8F RID: 142223
		public const int SprRome = 2;

		// Token: 0x04022B90 RID: 142224
		public const int SprDone = 3;

		// Token: 0x04022B91 RID: 142225
		public const int LockItemSelected = 4;

		// Token: 0x04022B92 RID: 142226
		public const int LockMask = 5;

		// Token: 0x04022B93 RID: 142227
		public const int RedPointSelected = 6;

		// Token: 0x04022B94 RID: 142228
		public const int SprRomeIcon = 7;

		// Token: 0x04022B95 RID: 142229
		public const int SprDoneSelected = 8;

		// Token: 0x04022B96 RID: 142230
		public const int LockItem = 9;

		// Token: 0x04022B97 RID: 142231
		public const int RedPoint = 10;

		// Token: 0x04022B98 RID: 142232
		public const int TexBg = 11;
	}
}
