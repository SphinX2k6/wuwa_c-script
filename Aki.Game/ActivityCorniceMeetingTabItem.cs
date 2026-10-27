using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011FC RID: 4604
public class ActivityCorniceMeetingTabItem : UiPanelBase, IGridProxy<int>
{
	// Token: 0x17000A86 RID: 2694
	// (get) Token: 0x06007B1D RID: 31517 RVA: 0x0019F178 File Offset: 0x0019D378
	// (set) Token: 0x06007B1E RID: 31518 RVA: 0x0019F180 File Offset: 0x0019D380
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

	// Token: 0x17000A87 RID: 2695
	// (get) Token: 0x06007B1F RID: 31519 RVA: 0x0019F189 File Offset: 0x0019D389
	// (set) Token: 0x06007B20 RID: 31520 RVA: 0x0019F191 File Offset: 0x0019D391
	public int GridIndex { get; set; }

	// Token: 0x17000A88 RID: 2696
	// (get) Token: 0x06007B21 RID: 31521 RVA: 0x0019F19A File Offset: 0x0019D39A
	// (set) Token: 0x06007B22 RID: 31522 RVA: 0x0019F1A2 File Offset: 0x0019D3A2
	public int DisplayIndex { get; set; }

	// Token: 0x17000A89 RID: 2697
	// (get) Token: 0x06007B23 RID: 31523 RVA: 0x0019F1AB File Offset: 0x0019D3AB
	// (set) Token: 0x06007B24 RID: 31524 RVA: 0x0019F1B3 File Offset: 0x0019D3B3
	public int LevelPlayId { get; set; }

	// Token: 0x06007B25 RID: 31525 RVA: 0x0019F1BC File Offset: 0x0019D3BC
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

	// Token: 0x06007B26 RID: 31526 RVA: 0x0019F1FC File Offset: 0x0019D3FC
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

	// Token: 0x06007B27 RID: 31527 RVA: 0x0019F3F0 File Offset: 0x0019D5F0
	protected override void OnStart()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06007B28 RID: 31528 RVA: 0x0019F404 File Offset: 0x0019D604
	private void OnClickItem(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ScrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, true);
		}
		EventSystem.Instance.Emit<int>(EEventName.OnClickActivityCorniceMeetingTab, this.LevelPlayId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.LevelPlayId);
	}

	// Token: 0x06007B29 RID: 31529 RVA: 0x0019F45C File Offset: 0x0019D65C
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

	// Token: 0x06007B2A RID: 31530 RVA: 0x0019F4CC File Offset: 0x0019D6CC
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityCorniceMeeting, base.GetItem(10), this.LevelPlayId);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityCorniceMeeting, base.GetItem(6), this.LevelPlayId);
		base.GetSprite(7).SetSprite(null, true);
	}

	// Token: 0x06007B2B RID: 31531 RVA: 0x0019F520 File Offset: 0x0019D720
	private void RefreshView()
	{
		ActivityCorniceMeetingLevelEntryData levelEntryData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData().GetLevelEntryData(this.LevelPlayId);
		base.SetTextureByPath(levelEntryData.GetBackgroundPath(), base.GetTexture(11), null, null);
		this.RefreshTitle();
		this.RefreshFinishedItem();
		this.RefreshLockItem();
	}

	// Token: 0x06007B2C RID: 31532 RVA: 0x0019F574 File Offset: 0x0019D774
	private void RefreshTitle()
	{
		ActivityCorniceMeetingLevelEntryData levelEntryData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData().GetLevelEntryData(this.LevelPlayId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), levelEntryData.GetTitle(), Array.Empty<object>());
	}

	// Token: 0x06007B2D RID: 31533 RVA: 0x0019F5B4 File Offset: 0x0019D7B4
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

	// Token: 0x06007B2E RID: 31534 RVA: 0x0019F64C File Offset: 0x0019D84C
	private void RefreshLockItem()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		base.GetItem(9).SetUIActive(!currentActivityData.GetIsShow(this.LevelPlayId));
		base.GetItem(5).SetUIActive(!currentActivityData.GetIsShow(this.LevelPlayId));
		base.GetItem(4).SetUIActive(!currentActivityData.GetIsShow(this.LevelPlayId));
	}

	// Token: 0x06007B2F RID: 31535 RVA: 0x0019F6B6 File Offset: 0x0019D8B6
	public void Clear()
	{
	}

	// Token: 0x06007B30 RID: 31536 RVA: 0x0019F6B8 File Offset: 0x0019D8B8
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

	// Token: 0x06007B31 RID: 31537 RVA: 0x0019F759 File Offset: 0x0019D959
	public void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06007B32 RID: 31538 RVA: 0x0019F76C File Offset: 0x0019D96C
	[NullableContext(1)]
	public object GetKey(int data, int gridIndex)
	{
		return this.LevelPlayId;
	}

	// Token: 0x0400385D RID: 14429
	[Nullable(1)]
	private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}";

	// Token: 0x04003862 RID: 14434
	private bool IsRedDotBind;

	// Token: 0x020077E4 RID: 30692
	private class EComponents
	{
		// Token: 0x0402785B RID: 161883
		public const int Toggle = 0;

		// Token: 0x0402785C RID: 161884
		public const int Title = 1;

		// Token: 0x0402785D RID: 161885
		public const int SprRome = 2;

		// Token: 0x0402785E RID: 161886
		public const int SprDone = 3;

		// Token: 0x0402785F RID: 161887
		public const int LockItemSelected = 4;

		// Token: 0x04027860 RID: 161888
		public const int LockMask = 5;

		// Token: 0x04027861 RID: 161889
		public const int RedPointSelected = 6;

		// Token: 0x04027862 RID: 161890
		public const int SprRomeIcon = 7;

		// Token: 0x04027863 RID: 161891
		public const int SprDoneSelected = 8;

		// Token: 0x04027864 RID: 161892
		public const int LockItem = 9;

		// Token: 0x04027865 RID: 161893
		public const int RedPoint = 10;

		// Token: 0x04027866 RID: 161894
		public const int TexBg = 11;
	}
}
