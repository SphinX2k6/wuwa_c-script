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

// Token: 0x02000CAD RID: 3245
[NullableContext(2)]
[Nullable(0)]
public class CommonItemDropGrid : GridProxyAbstract<TItem>
{
	// Token: 0x06008771 RID: 34673 RVA: 0x00293A43 File Offset: 0x00291C43
	[NullableContext(1)]
	public void Initialize(AActor rootActor)
	{
		this.CreateThenShowByActor(rootActor);
	}

	// Token: 0x06008772 RID: 34674 RVA: 0x00293A4C File Offset: 0x00291C4C
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

	// Token: 0x06008773 RID: 34675 RVA: 0x00293B14 File Offset: 0x00291D14
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

	// Token: 0x06008774 RID: 34676 RVA: 0x00293B5C File Offset: 0x00291D5C
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

	// Token: 0x06008775 RID: 34677 RVA: 0x00293C24 File Offset: 0x00291E24
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

	// Token: 0x06008776 RID: 34678 RVA: 0x00293C80 File Offset: 0x00291E80
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

	// Token: 0x06008777 RID: 34679 RVA: 0x00293CEF File Offset: 0x00291EEF
	public override void Clear()
	{
		this.ItemConfig = null;
		this.OnClickedCallback = null;
	}

	// Token: 0x06008778 RID: 34680 RVA: 0x00293CFF File Offset: 0x00291EFF
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(1).GetOwner());
	}

	// Token: 0x06008779 RID: 34681 RVA: 0x00293D23 File Offset: 0x00291F23
	public int GetUniqueId()
	{
		return this.UniqueId;
	}

	// Token: 0x0600877A RID: 34682 RVA: 0x00293D2B File Offset: 0x00291F2B
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600877B RID: 34683 RVA: 0x00293D33 File Offset: 0x00291F33
	public ItemConfig GetItemConfig()
	{
		return this.ItemConfig;
	}

	// Token: 0x0600877C RID: 34684 RVA: 0x00293D3B File Offset: 0x00291F3B
	[NullableContext(1)]
	public void BindOnClicked(Action<CommonItemDropGrid> onClickedCallback)
	{
		this.OnClickedCallback = onClickedCallback;
	}

	// Token: 0x0600877D RID: 34685 RVA: 0x00293D44 File Offset: 0x00291F44
	private void OnItemButtonClicked()
	{
		if (this.OnClickedCallback != null)
		{
			this.OnClickedCallback(this);
		}
	}

	// Token: 0x040051F5 RID: 20981
	private int UniqueId;

	// Token: 0x040051F6 RID: 20982
	private int ConfigId;

	// Token: 0x040051F7 RID: 20983
	public int Count;

	// Token: 0x040051F8 RID: 20984
	private ItemConfig ItemConfig;

	// Token: 0x040051F9 RID: 20985
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<CommonItemDropGrid> OnClickedCallback;

	// Token: 0x040051FA RID: 20986
	private SmallItemGrid ItemGrid;

	// Token: 0x02006F70 RID: 28528
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04024684 RID: 149124
		ItemButton,
		// Token: 0x04024685 RID: 149125
		ItemGridItem,
		// Token: 0x04024686 RID: 149126
		QualityEffect
	}
}
