using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200060A RID: 1546
public class BabelTowerQuickItem : UiPanelBase
{
	// Token: 0x06004851 RID: 18513 RVA: 0x00187F20 File Offset: 0x00186120
	public int GetSelectedQuickIndex()
	{
		return this.SelectedQuickIndex;
	}

	// Token: 0x06004852 RID: 18514 RVA: 0x00187F28 File Offset: 0x00186128
	public int GetPrevSelectedQuickIndex()
	{
		return this.PrevSelectedQuickIndex;
	}

	// Token: 0x06004853 RID: 18515 RVA: 0x00187F30 File Offset: 0x00186130
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

	// Token: 0x06004854 RID: 18516 RVA: 0x00187F54 File Offset: 0x00186154
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

	// Token: 0x06004855 RID: 18517 RVA: 0x00187F67 File Offset: 0x00186167
	public void UnBindLateUpdate()
	{
		LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
		if (quickLoopScroll == null)
		{
			return;
		}
		quickLoopScroll.UnBindLateUpdate();
	}

	// Token: 0x06004856 RID: 18518 RVA: 0x00187F7C File Offset: 0x0018617C
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

	// Token: 0x06004857 RID: 18519 RVA: 0x00188048 File Offset: 0x00186248
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

	// Token: 0x06004858 RID: 18520 RVA: 0x00188098 File Offset: 0x00186298
	public void SetLevelId(int levelId)
	{
		this.InstId = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId).InstId;
		this.RefreshQuickList();
	}

	// Token: 0x06004859 RID: 18521 RVA: 0x001880C4 File Offset: 0x001862C4
	[NullableContext(1)]
	private QuickOptionItem InitQuickOptionItem()
	{
		return new QuickOptionItem
		{
			OnQuickOptionClickWithIndex = new Action<BabelTowerQuick, int>(this.OnQuickOptionClickHandlerWithIndex)
		};
	}

	// Token: 0x0600485A RID: 18522 RVA: 0x001880E0 File Offset: 0x001862E0
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

	// Token: 0x0600485B RID: 18523 RVA: 0x00188164 File Offset: 0x00186364
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

	// Token: 0x0600485C RID: 18524 RVA: 0x001881E8 File Offset: 0x001863E8
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

	// Token: 0x0600485D RID: 18525 RVA: 0x00188250 File Offset: 0x00186450
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

	// Token: 0x0600485E RID: 18526 RVA: 0x001882C8 File Offset: 0x001864C8
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

	// Token: 0x0600485F RID: 18527 RVA: 0x00188324 File Offset: 0x00186524
	public void PlayContentAnimController()
	{
		LoopScrollView<QuickOptionItem, BabelTowerQuick> quickLoopScroll = this.QuickLoopScroll;
		if (quickLoopScroll == null)
		{
			return;
		}
		quickLoopScroll.ResetGridController();
	}

	// Token: 0x04003647 RID: 13895
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<QuickOptionItem, BabelTowerQuick> QuickLoopScroll;

	// Token: 0x04003648 RID: 13896
	private int InstId;

	// Token: 0x04003649 RID: 13897
	private int SelectedQuickIndex = -1;

	// Token: 0x0400364A RID: 13898
	private int PrevSelectedQuickIndex = -1;

	// Token: 0x0400364B RID: 13899
	[Nullable(2)]
	public Action<BabelTowerQuick> OnQuickSelectApplied;

	// Token: 0x0400364C RID: 13900
	[Nullable(2)]
	public Action OnQuickSelectCleared;

	// Token: 0x020068A2 RID: 26786
	private class EComponentDefine
	{
		// Token: 0x040227BC RID: 141244
		public const int TopTextColor = 0;

		// Token: 0x040227BD RID: 141245
		public const int BuffScroll = 1;

		// Token: 0x040227BE RID: 141246
		public const int BuffItem = 2;

		// Token: 0x040227BF RID: 141247
		public const int BuffTips = 3;

		// Token: 0x040227C0 RID: 141248
		public const int TitleName = 4;
	}

	// Token: 0x020068A3 RID: 26787
	private class EBuffItemSubComponent
	{
		// Token: 0x040227C1 RID: 141249
		public const int QuickItem = 0;

		// Token: 0x040227C2 RID: 141250
		public const int ColorSprite = 1;

		// Token: 0x040227C3 RID: 141251
		public const int TitleText = 2;

		// Token: 0x040227C4 RID: 141252
		public const int DescText = 3;

		// Token: 0x040227C5 RID: 141253
		public const int DeLevelArt = 4;

		// Token: 0x040227C6 RID: 141254
		public const int LockItem = 5;
	}
}
