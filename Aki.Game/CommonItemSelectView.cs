using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CB0 RID: 3248
[NullableContext(1)]
[Nullable(0)]
public class CommonItemSelectView<[Nullable(0)] T> : UiPanelBase where T : ItemDataBase
{
	// Token: 0x06008797 RID: 34711 RVA: 0x00294227 File Offset: 0x00292427
	[NullableContext(2)]
	public CommonItemSelectView(UUIItem commonItemActor = null)
	{
		if (commonItemActor != null)
		{
			base.CreateThenShowByActor(commonItemActor.GetOwner(), null);
		}
	}

	// Token: 0x06008798 RID: 34712 RVA: 0x00294240 File Offset: 0x00292440
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06008799 RID: 34713 RVA: 0x002942B0 File Offset: 0x002924B0
	private void RefreshEmptyItem(List<T> itemDataBaseList)
	{
		base.GetItem(3).SetUIActive(itemDataBaseList == null || itemDataBaseList.Count <= 0);
	}

	// Token: 0x0600879A RID: 34714 RVA: 0x002942D0 File Offset: 0x002924D0
	public void UpdateSelectableComponent(ESelectableComponentType selectableComponentType, List<T> itemDataBaseList, List<ISelectedData> selectedDataList, SelectableComponentData data, [Nullable(2)] CommonIntensifyPropExpData expData = null)
	{
		if (this.SelectableComponent == null)
		{
			if (selectableComponentType == ESelectableComponentType.Normal)
			{
				this.SelectableComponent = new SelectableComponent<T>();
			}
			else
			{
				this.SelectableComponent = new VisionRecoverySelectableComponent<T>();
			}
			this.SelectableComponent.InitLoopScroller(base.GetLoopScrollViewComponent(0), base.GetItem(1), data);
		}
		this.SetMaxSize(data.MaxSelectedGridNum);
		this.SetOnlyGold(data.OnlyGold);
		this.RefreshEmptyItem(itemDataBaseList);
		this.SelectableComponent.UpdateComponent(itemDataBaseList, selectedDataList, expData);
	}

	// Token: 0x0600879B RID: 34715 RVA: 0x0029434B File Offset: 0x0029254B
	public List<ISelectedData> GetCurrentSelectedData()
	{
		return this.SelectableComponent.GetCurrentSelectedData();
	}

	// Token: 0x0600879C RID: 34716 RVA: 0x00294358 File Offset: 0x00292558
	public void UpdateByDataList(List<T> itemDataBaseList)
	{
		this.SelectableComponent.UpdateDataList(itemDataBaseList);
		this.RefreshEmptyItem(itemDataBaseList);
	}

	// Token: 0x0600879D RID: 34717 RVA: 0x0029436D File Offset: 0x0029256D
	public void RefreshPartByIndex(int index)
	{
		this.SelectableComponent.RefreshPartByIndex(index);
	}

	// Token: 0x0600879E RID: 34718 RVA: 0x0029437B File Offset: 0x0029257B
	public void UpdateChangeItemSelectList()
	{
		this.SelectableComponent.UpdateChangeItemSelectList();
	}

	// Token: 0x0600879F RID: 34719 RVA: 0x00294388 File Offset: 0x00292588
	public void SetMaxSize(int maxSize)
	{
		this.SelectableComponent.SetMaxSize(maxSize);
	}

	// Token: 0x060087A0 RID: 34720 RVA: 0x00294396 File Offset: 0x00292596
	public void SetOnlyGold(bool onlyGold)
	{
		this.SelectableComponent.SetOnlyGold(onlyGold);
	}

	// Token: 0x060087A1 RID: 34721 RVA: 0x002943A4 File Offset: 0x002925A4
	protected override void OnBeforeDestroy()
	{
		SelectableComponent<T> selectableComponent = this.SelectableComponent;
		if (selectableComponent == null)
		{
			return;
		}
		selectableComponent.Destroy(null);
	}

	// Token: 0x04005205 RID: 20997
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SelectableComponent<T> SelectableComponent;

	// Token: 0x02006F79 RID: 28537
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040246B1 RID: 149169
		LoopScrooller,
		// Token: 0x040246B2 RID: 149170
		LoopItem,
		// Token: 0x040246B3 RID: 149171
		FilterItem,
		// Token: 0x040246B4 RID: 149172
		EmptyItem
	}
}
