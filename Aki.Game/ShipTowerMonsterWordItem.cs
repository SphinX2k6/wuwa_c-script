using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029BB RID: 10683
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerMonsterWordItem : UiPanelBase
{
	// Token: 0x06016263 RID: 90723 RVA: 0x00599FB4 File Offset: 0x005981B4
	public UniTask Init(UUIItem item)
	{
		ShipTowerMonsterWordItem.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerMonsterWordItem.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06016264 RID: 90724 RVA: 0x0059A000 File Offset: 0x00598200
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06016265 RID: 90725 RVA: 0x0059A05C File Offset: 0x0059825C
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerMonsterWordItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerMonsterWordItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016266 RID: 90726 RVA: 0x0059A09F File Offset: 0x0059829F
	public void UpdateData(ShipTowerMonsterWordItemData data)
	{
		base.GetText(0).SetText(data.Title, true);
		GenericLayout<ShipTowerMonsterWordInfoItem, ShipTowerMonsterWordInfoItemData> layoutInfo = this.LayoutInfo;
		if (layoutInfo == null)
		{
			return;
		}
		layoutInfo.RefreshByData(data.InfoList, null, false);
	}

	// Token: 0x06016267 RID: 90727 RVA: 0x0059A0CC File Offset: 0x005982CC
	private ShipTowerMonsterWordInfoItem CreateItem()
	{
		return new ShipTowerMonsterWordInfoItem();
	}

	// Token: 0x0400A4FD RID: 42237
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMonsterWordInfoItem, ShipTowerMonsterWordInfoItemData> LayoutInfo;

	// Token: 0x02008FD2 RID: 36818
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E942 RID: 190786
		public const int TxtTitle = 0;

		// Token: 0x0402E943 RID: 190787
		public const int VLayoutContainer = 1;

		// Token: 0x0402E944 RID: 190788
		public const int ItemWordInfo = 2;
	}
}
