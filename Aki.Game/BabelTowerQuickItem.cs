using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001156 RID: 4438
public class BabelTowerQuickItem : UiPanelBase
{
	// Token: 0x060074BA RID: 29882 RVA: 0x0017F3D4 File Offset: 0x0017D5D4
	public int GetSelectedQuickIndex()
	{
		return this.SelectedQuickIndex;
	}

	// Token: 0x060074BB RID: 29883 RVA: 0x0017F3DC File Offset: 0x0017D5DC
	public int GetPrevSelectedQuickIndex()
	{
		return this.PrevSelectedQuickIndex;
	}

	// Token: 0x060074BC RID: 29884 RVA: 0x0017F3E4 File Offset: 0x0017D5E4
	[NullableContext(2)]
	public UUIItem GetFirstQuickItem()
	{
		if (this.QuickLoopScroll == null)
		{
			return null;
		}
		QuickOptionItem quickOptionItem = this.QuickLoopScroll.UnsafeGetGridProxy(0, true);
		if (quickOptionItem == null)
		{
			return null;
		}
		return quickOptionItem.GetRootItem();
	}

	// Token: 0x060074BD RID: 29885 RVA: 0x0017F408 File Offset: 0x0017D608
	[NullableContext(1)]
	public void BindLateUpdate(Action<float> callBack)
	{
		LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
		if (quickLoopScroll == null)
		{
			return;
		}
		quickLoopScroll.BindLateUpdate(callBack);
	}

	// Token: 0x060074BE RID: 29886 RVA: 0x0017F41B File Offset: 0x0017D61B
	public void UnBindLateUpdate()
	{
		LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
		if (quickLoopScroll == null)
		{
			return;
		}
		quickLoopScroll.UnBindLateUpdate();
	}

	// Token: 0x060074BF RID: 29887 RVA: 0x0017F430 File Offset: 0x0017D630
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060074C0 RID: 29888 RVA: 0x0017F4FC File Offset: 0x0017D6FC
	protected override void OnStart()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(1);
		UUIItem item = base.GetItem(2);
		if (loopScrollViewComponent == null || item == null)
		{
			return;
		}
		AUIBaseActor auibaseActor = item.GetOwner() as AUIBaseActor;
		if (auibaseActor == null)
		{
			return;
		}
		this.QuickLoopScroll = new LoopScrollView<QuickOptionItem, BabelTowerQuick>(loopScrollViewComponent, auibaseActor, new Func<QuickOptionItem>(this.InitQuickOptionItem), false);
	}

	// Token: 0x060074C1 RID: 29889 RVA: 0x0017F54C File Offset: 0x0017D74C
	public void SetLevelId(int levelId)
	{
		this.InstId = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId).InstId;
		this.RefreshQuickList();
	}

	// Token: 0x060074C2 RID: 29890 RVA: 0x0017F578 File Offset: 0x0017D778
	[NullableContext(1)]
	private QuickOptionItem InitQuickOptionItem()
	{
		return new QuickOptionItem
		{
			OnQuickOptionClickWithIndex = new Action<BabelTowerQuick, int>(this.OnQuickOptionClickHandlerWithIndex)
		};
	}

	// Token: 0x060074C3 RID: 29891 RVA: 0x0017F594 File Offset: 0x0017D794
	private void OnQuickOptionClickHandlerWithIndex(BabelTowerQuick quickConfig, int index)
	{
		if (this.SelectedQuickIndex >= 0 && this.SelectedQuickIndex != index)
		{
			LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
			QuickOptionItem quickOptionItem = (quickLoopScroll != null) ? quickLoopScroll.UnsafeGetGridProxy(this.SelectedQuickIndex, false) : null;
			UUIExtendToggle uuiextendToggle = (quickOptionItem != null) ? quickOptionItem.GetQuickToggle() : null;
			if (uuiextendToggle != null)
			{
				uuiextendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		this.PrevSelectedQuickIndex = this.SelectedQuickIndex;
		this.SelectedQuickIndex = index;
		BabelTowerModel.Instance.CurrentQuickIndex = index;
		Action<BabelTowerQuick> onQuickSelectApplied = this.OnQuickSelectApplied;
		if (onQuickSelectApplied == null)
		{
			return;
		}
		onQuickSelectApplied(quickConfig);
	}

	// Token: 0x060074C4 RID: 29892 RVA: 0x0017F618 File Offset: 0x0017D818
	public void RefreshQuickList()
	{
		IReadOnlyList<BabelTowerQuick> babelTowerQuickByInstId = BabelTowerConfig.Instance.GetBabelTowerQuickByInstId(this.InstId);
		if (babelTowerQuickByInstId == null || babelTowerQuickByInstId.Count == 0)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
			if (quickLoopScroll == null)
			{
				return;
			}
			quickLoopScroll.RefreshByData(new List<BabelTowerQuick>(), false, null, false);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll2 = this.QuickLoopScroll;
			if (quickLoopScroll2 == null)
			{
				return;
			}
			quickLoopScroll2.RefreshByData(new List<BabelTowerQuick>(babelTowerQuickByInstId), false, null, false);
			return;
		}
	}

	// Token: 0x060074C5 RID: 29893 RVA: 0x0017F69C File Offset: 0x0017D89C
	public void RefreshQuickListWithSelection()
	{
		if (this.SelectedQuickIndex < 0)
		{
			return;
		}
		LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
		QuickOptionItem quickOptionItem = (quickLoopScroll != null) ? quickLoopScroll.UnsafeGetGridProxy(this.SelectedQuickIndex, false) : null;
		BabelTowerQuick? babelTowerQuick = (quickOptionItem != null) ? quickOptionItem.GetCurrentData() : null;
		if (quickOptionItem != null && babelTowerQuick != null)
		{
			quickOptionItem.Refresh(babelTowerQuick.Value, true, this.SelectedQuickIndex);
		}
	}

	// Token: 0x060074C6 RID: 29894 RVA: 0x0017F704 File Offset: 0x0017D904
	public void ClearSelection()
	{
		if (this.SelectedQuickIndex >= 0)
		{
			LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
			QuickOptionItem quickOptionItem = (quickLoopScroll != null) ? quickLoopScroll.UnsafeGetGridProxy(this.SelectedQuickIndex, false) : null;
			UUIExtendToggle uuiextendToggle = (quickOptionItem != null) ? quickOptionItem.GetQuickToggle() : null;
			if (uuiextendToggle != null)
			{
				uuiextendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		this.PrevSelectedQuickIndex = this.SelectedQuickIndex;
		this.SelectedQuickIndex = -1;
		BabelTowerModel.Instance.CurrentQuickIndex = -1;
		Action onQuickSelectCleared = this.OnQuickSelectCleared;
		if (onQuickSelectCleared == null)
		{
			return;
		}
		onQuickSelectCleared();
	}

	// Token: 0x060074C7 RID: 29895 RVA: 0x0017F77C File Offset: 0x0017D97C
	public void ClearSelectionWithoutCallback()
	{
		if (this.SelectedQuickIndex >= 0)
		{
			LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
			QuickOptionItem quickOptionItem = (quickLoopScroll != null) ? quickLoopScroll.UnsafeGetGridProxy(this.SelectedQuickIndex, false) : null;
			UUIExtendToggle uuiextendToggle = (quickOptionItem != null) ? quickOptionItem.GetQuickToggle() : null;
			if (uuiextendToggle != null)
			{
				uuiextendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		this.PrevSelectedQuickIndex = this.SelectedQuickIndex;
		this.SelectedQuickIndex = -1;
	}

	// Token: 0x060074C8 RID: 29896 RVA: 0x0017F7D8 File Offset: 0x0017D9D8
	public void PlayContentAnimController()
	{
		LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
		if (quickLoopScroll == null)
		{
			return;
		}
		quickLoopScroll.ResetGridController();
	}

	// Token: 0x040035AE RID: 13742
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<QuickOptionItem, BabelTowerQuick> QuickLoopScroll;

	// Token: 0x040035AF RID: 13743
	private int InstId;

	// Token: 0x040035B0 RID: 13744
	private int SelectedQuickIndex = -1;

	// Token: 0x040035B1 RID: 13745
	private int PrevSelectedQuickIndex = -1;

	// Token: 0x040035B2 RID: 13746
	[Nullable(2)]
	public Action<BabelTowerQuick> OnQuickSelectApplied;

	// Token: 0x040035B3 RID: 13747
	[Nullable(2)]
	public Action OnQuickSelectCleared;

	// Token: 0x02007713 RID: 30483
	private class EComponentDefine
	{
		// Token: 0x0402747B RID: 160891
		public const int TopTextColor = 0;

		// Token: 0x0402747C RID: 160892
		public const int BuffScroll = 1;

		// Token: 0x0402747D RID: 160893
		public const int BuffItem = 2;

		// Token: 0x0402747E RID: 160894
		public const int BuffTips = 3;

		// Token: 0x0402747F RID: 160895
		public const int TitleName = 4;
	}

	// Token: 0x02007714 RID: 30484
	private class EBuffItemSubComponent
	{
		// Token: 0x04027480 RID: 160896
		public const int QuickItem = 0;

		// Token: 0x04027481 RID: 160897
		public const int ColorSprite = 1;

		// Token: 0x04027482 RID: 160898
		public const int TitleText = 2;

		// Token: 0x04027483 RID: 160899
		public const int DescText = 3;

		// Token: 0x04027484 RID: 160900
		public const int DeLevelArt = 4;

		// Token: 0x04027485 RID: 160901
		public const int LockItem = 5;
	}
}
