using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029CE RID: 10702
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerScoreInfoItem : GridProxyAbstract<ShipTowerScoreInfoData>
{
	// Token: 0x060162E3 RID: 90851 RVA: 0x0059C360 File Offset: 0x0059A560
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060162E4 RID: 90852 RVA: 0x0059C3BC File Offset: 0x0059A5BC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerScoreInfoItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerScoreInfoItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060162E5 RID: 90853 RVA: 0x0059C3FF File Offset: 0x0059A5FF
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x060162E6 RID: 90854 RVA: 0x0059C401 File Offset: 0x0059A601
	protected override void OnStart()
	{
	}

	// Token: 0x060162E7 RID: 90855 RVA: 0x0059C403 File Offset: 0x0059A603
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x060162E8 RID: 90856 RVA: 0x0059C408 File Offset: 0x0059A608
	public override void Refresh(ShipTowerScoreInfoData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.GetText(0).SetText(this.ItemData.Title, true);
		GenericLayout<ShipTowerScoreTargetItem, ShipTowerScoreTargetData> itemLayout = this.ItemLayout;
		if (itemLayout == null)
		{
			return;
		}
		itemLayout.RefreshByDataAsync(this.ItemData.TargetList, false, null).Forget();
	}

	// Token: 0x060162E9 RID: 90857 RVA: 0x0059C45E File Offset: 0x0059A65E
	private ShipTowerScoreTargetItem CreateScoreTargetItem()
	{
		return new ShipTowerScoreTargetItem();
	}

	// Token: 0x0400A529 RID: 42281
	[Nullable(2)]
	private ShipTowerScoreInfoData ItemData;

	// Token: 0x0400A52A RID: 42282
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerScoreTargetItem, ShipTowerScoreTargetData> ItemLayout;

	// Token: 0x02008FF3 RID: 36851
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E9D0 RID: 190928
		public const int TxtTitle = 0;

		// Token: 0x0402E9D1 RID: 190929
		public const int VLayoutItemList = 1;

		// Token: 0x0402E9D2 RID: 190930
		public const int ItemItem = 2;
	}
}
