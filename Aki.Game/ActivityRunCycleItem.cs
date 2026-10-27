using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014D3 RID: 5331
public class ActivityRunCycleItem : UiPanelBase, IGridProxy<int>
{
	// Token: 0x17000D12 RID: 3346
	// (get) Token: 0x06009781 RID: 38785 RVA: 0x0020BA73 File Offset: 0x00209C73
	// (set) Token: 0x06009782 RID: 38786 RVA: 0x0020BA7B File Offset: 0x00209C7B
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

	// Token: 0x17000D13 RID: 3347
	// (get) Token: 0x06009783 RID: 38787 RVA: 0x0020BA84 File Offset: 0x00209C84
	// (set) Token: 0x06009784 RID: 38788 RVA: 0x0020BA8C File Offset: 0x00209C8C
	public int GridIndex { get; set; }

	// Token: 0x17000D14 RID: 3348
	// (get) Token: 0x06009785 RID: 38789 RVA: 0x0020BA95 File Offset: 0x00209C95
	// (set) Token: 0x06009786 RID: 38790 RVA: 0x0020BA9D File Offset: 0x00209C9D
	public int DisplayIndex { get; set; }

	// Token: 0x06009787 RID: 38791 RVA: 0x0020BAA8 File Offset: 0x00209CA8
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

	// Token: 0x06009788 RID: 38792 RVA: 0x0020BC9C File Offset: 0x00209E9C
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

	// Token: 0x06009789 RID: 38793 RVA: 0x0020BCEE File Offset: 0x00209EEE
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

	// Token: 0x0600978A RID: 38794 RVA: 0x0020BD23 File Offset: 0x00209F23
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600978B RID: 38795 RVA: 0x0020BD3C File Offset: 0x00209F3C
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

	// Token: 0x0600978C RID: 38796 RVA: 0x0020BD90 File Offset: 0x00209F90
	private void RefreshView()
	{
		this.CurrentChallengeData = ActivityRunModel.Instance.GetActivityRunData(this.CurrentChallengeId);
		base.SetTextureByPath(this.CurrentChallengeData.GetBackgroundTexturePath(), base.GetTexture(11), null, null);
		this.RefreshTitle();
		this.RefreshFinishedItem();
		this.RefreshLockItem();
	}

	// Token: 0x0600978D RID: 38797 RVA: 0x0020BDE8 File Offset: 0x00209FE8
	private void RefreshTitle()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(this.CurrentChallengeData.GetTitle(), true);
	}

	// Token: 0x0600978E RID: 38798 RVA: 0x0020BE08 File Offset: 0x0020A008
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

	// Token: 0x0600978F RID: 38799 RVA: 0x0020BEA4 File Offset: 0x0020A0A4
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

	// Token: 0x06009790 RID: 38800 RVA: 0x0020BF11 File Offset: 0x0020A111
	public void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.CurrentChallengeId = data;
		this.TryBindRedDot();
		this.RefreshView();
	}

	// Token: 0x06009791 RID: 38801 RVA: 0x0020BF26 File Offset: 0x0020A126
	public void Clear()
	{
	}

	// Token: 0x06009792 RID: 38802 RVA: 0x0020BF28 File Offset: 0x0020A128
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

	// Token: 0x06009793 RID: 38803 RVA: 0x0020BFBD File Offset: 0x0020A1BD
	public void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06009794 RID: 38804 RVA: 0x0020BFD5 File Offset: 0x0020A1D5
	[NullableContext(1)]
	public object GetKey(int data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x040042B0 RID: 17072
	private int CurrentChallengeId;

	// Token: 0x040042B1 RID: 17073
	[Nullable(2)]
	private ActivityRunData CurrentChallengeData;

	// Token: 0x040042B2 RID: 17074
	private bool IsRedDotBind;

	// Token: 0x040042B3 RID: 17075
	[Nullable(1)]
	private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}";

	// Token: 0x02007B0D RID: 31501
	private class EComponents
	{
		// Token: 0x04028780 RID: 165760
		public const int Toggle = 0;

		// Token: 0x04028781 RID: 165761
		public const int Title = 1;

		// Token: 0x04028782 RID: 165762
		public const int SprRome = 2;

		// Token: 0x04028783 RID: 165763
		public const int SprDone = 3;

		// Token: 0x04028784 RID: 165764
		public const int LockItemSelected = 4;

		// Token: 0x04028785 RID: 165765
		public const int LockMask = 5;

		// Token: 0x04028786 RID: 165766
		public const int RedPointSelected = 6;

		// Token: 0x04028787 RID: 165767
		public const int SprRomeIcon = 7;

		// Token: 0x04028788 RID: 165768
		public const int SprDoneSelected = 8;

		// Token: 0x04028789 RID: 165769
		public const int LockItem = 9;

		// Token: 0x0402878A RID: 165770
		public const int RedPoint = 10;

		// Token: 0x0402878B RID: 165771
		public const int TexBg = 11;
	}
}
