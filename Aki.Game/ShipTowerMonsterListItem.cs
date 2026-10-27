using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029B9 RID: 10681
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerMonsterListItem : UiPanelBase
{
	// Token: 0x06016258 RID: 90712 RVA: 0x00599DDC File Offset: 0x00597FDC
	public UniTask Init(UUIItem item)
	{
		ShipTowerMonsterListItem.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerMonsterListItem.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06016259 RID: 90713 RVA: 0x00599E27 File Offset: 0x00598027
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0601625A RID: 90714 RVA: 0x00599E60 File Offset: 0x00598060
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerMonsterListItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerMonsterListItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601625B RID: 90715 RVA: 0x00599EA3 File Offset: 0x005980A3
	public void UpdateData(ShipTowerMonsterListItemData data)
	{
		base.GetText(0).SetText(data.Title, true);
		GenericLayout<ShipTowerMonsterInfoItem, ShipTowerMonsterInfoItemData> layoutInfo = this.LayoutInfo;
		if (layoutInfo == null)
		{
			return;
		}
		layoutInfo.RefreshByData(data.MonsterInfoList, null, false);
	}

	// Token: 0x0601625C RID: 90716 RVA: 0x00599ED0 File Offset: 0x005980D0
	private ShipTowerMonsterInfoItem CreateItem()
	{
		return new ShipTowerMonsterInfoItem();
	}

	// Token: 0x0400A4FC RID: 42236
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMonsterInfoItem, ShipTowerMonsterInfoItemData> LayoutInfo;

	// Token: 0x02008FCE RID: 36814
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E934 RID: 190772
		public const int TxtTitle = 0;

		// Token: 0x0402E935 RID: 190773
		public const int GLayoutContainer = 1;
	}
}
