using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017F7 RID: 6135
[NullableContext(1)]
[Nullable(0)]
public class CommonItemSelectView<[Nullable(0)] T> : UiPanelBase where T : ItemDataBase
{
	// Token: 0x0600B3AD RID: 45997 RVA: 0x00289B2B File Offset: 0x00287D2B
	[NullableContext(2)]
	public CommonItemSelectView(UUIItem commonItemActor = null)
	{
		if (commonItemActor != null)
		{
			base.CreateThenShowByActor(commonItemActor.GetOwner(), null);
		}
	}

	// Token: 0x0600B3AE RID: 45998 RVA: 0x00289B44 File Offset: 0x00287D44
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

	// Token: 0x0600B3AF RID: 45999 RVA: 0x00289BB4 File Offset: 0x00287DB4
	private void RefreshEmptyItem(List<T> itemDataBaseList)
	{
		base.GetItem(3).SetUIActive(itemDataBaseList == null || itemDataBaseList.Count <= 0);
	}

	// Token: 0x0600B3B0 RID: 46000 RVA: 0x00289BD4 File Offset: 0x00287DD4
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

	// Token: 0x0600B3B1 RID: 46001 RVA: 0x00289C4F File Offset: 0x00287E4F
	public List<ISelectedData> GetCurrentSelectedData()
	{
		return this.SelectableComponent.GetCurrentSelectedData();
	}

	// Token: 0x0600B3B2 RID: 46002 RVA: 0x00289C5C File Offset: 0x00287E5C
	public void UpdateByDataList(List<T> itemDataBaseList)
	{
		this.SelectableComponent.UpdateDataList(itemDataBaseList);
		this.RefreshEmptyItem(itemDataBaseList);
	}

	// Token: 0x0600B3B3 RID: 46003 RVA: 0x00289C71 File Offset: 0x00287E71
	public void RefreshPartByIndex(int index)
	{
		this.SelectableComponent.RefreshPartByIndex(index);
	}

	// Token: 0x0600B3B4 RID: 46004 RVA: 0x00289C7F File Offset: 0x00287E7F
	public void UpdateChangeItemSelectList()
	{
		this.SelectableComponent.UpdateChangeItemSelectList();
	}

	// Token: 0x0600B3B5 RID: 46005 RVA: 0x00289C8C File Offset: 0x00287E8C
	public void SetMaxSize(int maxSize)
	{
		this.SelectableComponent.SetMaxSize(maxSize);
	}

	// Token: 0x0600B3B6 RID: 46006 RVA: 0x00289C9A File Offset: 0x00287E9A
	public void SetOnlyGold(bool onlyGold)
	{
		this.SelectableComponent.SetOnlyGold(onlyGold);
	}

	// Token: 0x0600B3B7 RID: 46007 RVA: 0x00289CA8 File Offset: 0x00287EA8
	protected override void OnBeforeDestroy()
	{
		SelectableComponent<T> selectableComponent = this.SelectableComponent;
		if (selectableComponent == null)
		{
			return;
		}
		selectableComponent.Destroy(null);
	}

	// Token: 0x0400515A RID: 20826
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SelectableComponent<T> SelectableComponent;

	// Token: 0x02007DF3 RID: 32243
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029386 RID: 168838
		LoopScrooller,
		// Token: 0x04029387 RID: 168839
		LoopItem,
		// Token: 0x04029388 RID: 168840
		FilterItem,
		// Token: 0x04029389 RID: 168841
		EmptyItem
	}
}
