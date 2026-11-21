using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200098B RID: 2443
public class ActivityRunCycleItem : UiPanelBase, IGridProxy<int>
{
	// Token: 0x17000D33 RID: 3379
	// (get) Token: 0x06006B5B RID: 27483 RVA: 0x002157B3 File Offset: 0x002139B3
	// (set) Token: 0x06006B5C RID: 27484 RVA: 0x002157BB File Offset: 0x002139BB
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

	// Token: 0x17000D34 RID: 3380
	// (get) Token: 0x06006B5D RID: 27485 RVA: 0x002157C4 File Offset: 0x002139C4
	// (set) Token: 0x06006B5E RID: 27486 RVA: 0x002157CC File Offset: 0x002139CC
	public int GridIndex { get; set; }

	// Token: 0x17000D35 RID: 3381
	// (get) Token: 0x06006B5F RID: 27487 RVA: 0x002157D5 File Offset: 0x002139D5
	// (set) Token: 0x06006B60 RID: 27488 RVA: 0x002157DD File Offset: 0x002139DD
	public int DisplayIndex { get; set; }

	// Token: 0x06006B61 RID: 27489 RVA: 0x002157E8 File Offset: 0x002139E8
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

	// Token: 0x06006B62 RID: 27490 RVA: 0x002159DC File Offset: 0x00213BDC
	public void TryBindRedDot()
	{
		if (this.IsRedDotBind)
		{
			return;
		}
		this.IsRedDotBind = true;
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRun, base.GetItem(10), null, this.CurrentChallengeId);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRun, base.GetItem(6), null, this.CurrentChallengeId);
	}

	// Token: 0x06006B63 RID: 27491 RVA: 0x00215A2E File Offset: 0x00213C2E
	private void OnClickItem(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			IScrollViewDelegate<IGridProxy<int>, int> scrollViewDelegate = this.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, true);
			}
		}
		EventSystem.Instance.Emit<ActivityRunCycleItem>(EEventName.OnClickActivityRunChallenge, this);
	}

	// Token: 0x06006B64 RID: 27492 RVA: 0x00215A63 File Offset: 0x00213C63
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06006B65 RID: 27493 RVA: 0x00215A7C File Offset: 0x00213C7C
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRun, base.GetItem(10), this.CurrentChallengeId);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRun, base.GetItem(6), this.CurrentChallengeId);
		UUISprite sprite = base.GetSprite(7);
		if (sprite == null)
		{
			return;
		}
		sprite.SetSprite(null, true);
	}

	// Token: 0x06006B66 RID: 27494 RVA: 0x00215AD0 File Offset: 0x00213CD0
	private void RefreshView()
	{
		this.CurrentChallengeData = ActivityRunModel.Instance.GetActivityRunData(this.CurrentChallengeId);
		base.SetTextureByPath(this.CurrentChallengeData.GetBackgroundTexturePath(), base.GetTexture(11), null, null);
		this.RefreshTitle();
		this.RefreshFinishedItem();
		this.RefreshLockItem();
	}

	// Token: 0x06006B67 RID: 27495 RVA: 0x00215B28 File Offset: 0x00213D28
	private void RefreshTitle()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(this.CurrentChallengeData.GetTitle(), true);
	}

	// Token: 0x06006B68 RID: 27496 RVA: 0x00215B48 File Offset: 0x00213D48
	private void RefreshFinishedItem()
	{
		UUISprite sprite = base.GetSprite(3);
		if (sprite != null)
		{
			sprite.SetUIActive(this.CurrentChallengeData.GetIfRewardAllFinished());
		}
		UUISprite sprite2 = base.GetSprite(8);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(this.CurrentChallengeData.GetIfRewardAllFinished());
		}
		UUISprite sprite3 = base.GetSprite(2);
		if (sprite3 != null)
		{
			sprite3.SetUIActive(false);
		}
		string text = (this.GridIndex + 1).ToString();
		this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}", new string[]
		{
			text,
			text
		}), base.GetSprite(7), false, null, null);
	}

	// Token: 0x06006B69 RID: 27497 RVA: 0x00215BE4 File Offset: 0x00213DE4
	private void RefreshLockItem()
	{
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(!this.CurrentChallengeData.GetIsShow());
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(!this.CurrentChallengeData.GetIsShow());
		}
		UUIItem item3 = base.GetItem(4);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(!this.CurrentChallengeData.GetIsShow());
	}

	// Token: 0x06006B6A RID: 27498 RVA: 0x00215C51 File Offset: 0x00213E51
	public void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.CurrentChallengeId = data;
		this.TryBindRedDot();
		this.RefreshView();
	}

	// Token: 0x06006B6B RID: 27499 RVA: 0x00215C66 File Offset: 0x00213E66
	public void Clear()
	{
	}

	// Token: 0x06006B6C RID: 27500 RVA: 0x00215C68 File Offset: 0x00213E68
	public void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}
		ActivityRunModel.Instance.CurrentSelectChallengeId = this.CurrentChallengeId;
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(this.CurrentChallengeData.GetActivityId());
		if (activityById == null)
		{
			return;
		}
		(activityById as ActivityRun).SetActivityContentIndex(this.GridIndex);
		if (this.CurrentChallengeData.GetIsShow() && this.CurrentChallengeData.GetChallengeNewLocalRedPoint())
		{
			this.CurrentChallengeData.SetChallengeLocalRedPointState(false);
		}
		EventSystem.Instance.Emit(EEventName.OnSelectActivityRunChallengeItem);
	}

	// Token: 0x06006B6D RID: 27501 RVA: 0x00215CFD File Offset: 0x00213EFD
	public void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06006B6E RID: 27502 RVA: 0x00215D15 File Offset: 0x00213F15
	[NullableContext(1)]
	public object GetKey(int data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x04004355 RID: 17237
	private int CurrentChallengeId;

	// Token: 0x04004356 RID: 17238
	[Nullable(2)]
	private ActivityRunData CurrentChallengeData;

	// Token: 0x04004357 RID: 17239
	private bool IsRedDotBind;

	// Token: 0x04004358 RID: 17240
	[Nullable(1)]
	private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}";

	// Token: 0x02006C99 RID: 27801
	private class EComponents
	{
		// Token: 0x04023ABE RID: 146110
		public const int Toggle = 0;

		// Token: 0x04023ABF RID: 146111
		public const int Title = 1;

		// Token: 0x04023AC0 RID: 146112
		public const int SprRome = 2;

		// Token: 0x04023AC1 RID: 146113
		public const int SprDone = 3;

		// Token: 0x04023AC2 RID: 146114
		public const int LockItemSelected = 4;

		// Token: 0x04023AC3 RID: 146115
		public const int LockMask = 5;

		// Token: 0x04023AC4 RID: 146116
		public const int RedPointSelected = 6;

		// Token: 0x04023AC5 RID: 146117
		public const int SprRomeIcon = 7;

		// Token: 0x04023AC6 RID: 146118
		public const int SprDoneSelected = 8;

		// Token: 0x04023AC7 RID: 146119
		public const int LockItem = 9;

		// Token: 0x04023AC8 RID: 146120
		public const int RedPoint = 10;

		// Token: 0x04023AC9 RID: 146121
		public const int TexBg = 11;
	}
}
