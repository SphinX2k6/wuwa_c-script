using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017F4 RID: 6132
[NullableContext(2)]
[Nullable(0)]
public class CommonItemDropGrid : GridProxyAbstract<TItem>
{
	// Token: 0x0600B387 RID: 45959 RVA: 0x00289347 File Offset: 0x00287547
	[NullableContext(1)]
	public void Initialize(AActor rootActor)
	{
		this.CreateThenShowByActor(rootActor);
	}

	// Token: 0x0600B388 RID: 45960 RVA: 0x00289350 File Offset: 0x00287550
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnItemButtonClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B389 RID: 45961 RVA: 0x00289418 File Offset: 0x00287618
	public override void Refresh(TItem data, bool isSelected, int gridIndex)
	{
		if (data.Equals(default(TItem)))
		{
			return;
		}
		InventoryDefine.IGetItemData itemData = data.ItemData;
		if (itemData == null)
		{
			return;
		}
		this.RefreshByItemInfo(itemData.ItemId, data.Count, new int?(itemData.IncId));
	}

	// Token: 0x0600B38A RID: 45962 RVA: 0x00289460 File Offset: 0x00287660
	public void RefreshByItemInfo(int configId, int count, int? uniqueId = null)
	{
		this.UniqueId = uniqueId.GetValueOrDefault();
		this.ConfigId = configId;
		this.Count = count;
		this.ItemConfig = InventoryConfig.Instance.GetItemConfigData(this.ConfigId);
		if (this.ItemConfig == null)
		{
			return;
		}
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.Data = new object[]
		{
			configId,
			uniqueId
		};
		propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
		SmallItemGridBase smallItemGridBase = propSmallItemGrid;
		string bottomText;
		if (count <= 0)
		{
			bottomText = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		smallItemGridBase.BottomText = bottomText;
		PropSmallItemGrid parameters = propSmallItemGrid;
		this.ItemGrid.Apply<PropSmallItemGrid>(parameters);
		this.SetQualityEffect(this.ItemConfig.QualityId, null);
	}

	// Token: 0x0600B38B RID: 45963 RVA: 0x00289528 File Offset: 0x00287728
	public UniTask AsyncRefreshByItemInfo(int configId, int count, int? uniqueId = null)
	{
		CommonItemDropGrid.<AsyncRefreshByItemInfo>d__11 <AsyncRefreshByItemInfo>d__;
		<AsyncRefreshByItemInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AsyncRefreshByItemInfo>d__.<>4__this = this;
		<AsyncRefreshByItemInfo>d__.configId = configId;
		<AsyncRefreshByItemInfo>d__.count = count;
		<AsyncRefreshByItemInfo>d__.uniqueId = uniqueId;
		<AsyncRefreshByItemInfo>d__.<>1__state = -1;
		<AsyncRefreshByItemInfo>d__.<>t__builder.Start<CommonItemDropGrid.<AsyncRefreshByItemInfo>d__11>(ref <AsyncRefreshByItemInfo>d__);
		return <AsyncRefreshByItemInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600B38C RID: 45964 RVA: 0x00289584 File Offset: 0x00287784
	private void SetQualityEffect(int qualityId, Action loadedCallback = null)
	{
		QualityInfo? itemQualityConfig = InventoryConfig.Instance.GetItemQualityConfig(qualityId);
		if (itemQualityConfig == null)
		{
			return;
		}
		string dropItemQualityNiagaraPath = itemQualityConfig.Value.DropItemQualityNiagaraPath;
		if (StringUtils.IsEmpty(dropItemQualityNiagaraPath))
		{
			return;
		}
		ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(dropItemQualityNiagaraPath, delegate([Nullable(2)] UNiagaraSystem niagaraSystem, string _)
		{
			this.GetUiNiagara(2).SetNiagaraSystem(niagaraSystem);
			if (loadedCallback != null)
			{
				loadedCallback();
			}
		}, 100, "js_undefined");
	}

	// Token: 0x0600B38D RID: 45965 RVA: 0x002895F3 File Offset: 0x002877F3
	public override void Clear()
	{
		this.ItemConfig = null;
		this.OnClickedCallback = null;
	}

	// Token: 0x0600B38E RID: 45966 RVA: 0x00289603 File Offset: 0x00287803
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(1).GetOwner());
	}

	// Token: 0x0600B38F RID: 45967 RVA: 0x00289627 File Offset: 0x00287827
	public int GetUniqueId()
	{
		return this.UniqueId;
	}

	// Token: 0x0600B390 RID: 45968 RVA: 0x0028962F File Offset: 0x0028782F
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600B391 RID: 45969 RVA: 0x00289637 File Offset: 0x00287837
	public ItemConfig GetItemConfig()
	{
		return this.ItemConfig;
	}

	// Token: 0x0600B392 RID: 45970 RVA: 0x0028963F File Offset: 0x0028783F
	[NullableContext(1)]
	public void BindOnClicked(Action<CommonItemDropGrid> onClickedCallback)
	{
		this.OnClickedCallback = onClickedCallback;
	}

	// Token: 0x0600B393 RID: 45971 RVA: 0x00289648 File Offset: 0x00287848
	private void OnItemButtonClicked()
	{
		if (this.OnClickedCallback != null)
		{
			this.OnClickedCallback(this);
		}
	}

	// Token: 0x0400514A RID: 20810
	private int UniqueId;

	// Token: 0x0400514B RID: 20811
	private int ConfigId;

	// Token: 0x0400514C RID: 20812
	public int Count;

	// Token: 0x0400514D RID: 20813
	private ItemConfig ItemConfig;

	// Token: 0x0400514E RID: 20814
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<CommonItemDropGrid> OnClickedCallback;

	// Token: 0x0400514F RID: 20815
	private SmallItemGrid ItemGrid;

	// Token: 0x02007DEA RID: 32234
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029359 RID: 168793
		ItemButton,
		// Token: 0x0402935A RID: 168794
		ItemGridItem,
		// Token: 0x0402935B RID: 168795
		QualityEffect
	}
}
