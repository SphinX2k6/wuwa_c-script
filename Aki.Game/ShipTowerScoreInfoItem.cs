using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F49 RID: 8009
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerScoreInfoItem : GridProxyAbstract<ShipTowerScoreInfoData>
{
	// Token: 0x06013CE9 RID: 81129 RVA: 0x005C7318 File Offset: 0x005C5518
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06013CEA RID: 81130 RVA: 0x005C7374 File Offset: 0x005C5574
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerScoreInfoItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerScoreInfoItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CEB RID: 81131 RVA: 0x005C73B7 File Offset: 0x005C55B7
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06013CEC RID: 81132 RVA: 0x005C73B9 File Offset: 0x005C55B9
	protected override void OnStart()
	{
	}

	// Token: 0x06013CED RID: 81133 RVA: 0x005C73BB File Offset: 0x005C55BB
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06013CEE RID: 81134 RVA: 0x005C73C0 File Offset: 0x005C55C0
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

	// Token: 0x06013CEF RID: 81135 RVA: 0x005C7416 File Offset: 0x005C5616
	private ShipTowerScoreTargetItem CreateScoreTargetItem()
	{
		return new ShipTowerScoreTargetItem();
	}

	// Token: 0x0400A913 RID: 43283
	[Nullable(2)]
	private ShipTowerScoreInfoData ItemData;

	// Token: 0x0400A914 RID: 43284
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerScoreTargetItem, ShipTowerScoreTargetData> ItemLayout;

	// Token: 0x0200823A RID: 33338
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A0C8 RID: 172232
		public const int TxtTitle = 0;

		// Token: 0x0402A0C9 RID: 172233
		public const int VLayoutItemList = 1;

		// Token: 0x0402A0CA RID: 172234
		public const int ItemItem = 2;
	}
}
