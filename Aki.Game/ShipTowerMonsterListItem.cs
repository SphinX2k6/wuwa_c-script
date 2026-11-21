using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F34 RID: 7988
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerMonsterListItem : UiPanelBase
{
	// Token: 0x06013C5E RID: 80990 RVA: 0x005C4D68 File Offset: 0x005C2F68
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

	// Token: 0x06013C5F RID: 80991 RVA: 0x005C4DB3 File Offset: 0x005C2FB3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x06013C60 RID: 80992 RVA: 0x005C4DEC File Offset: 0x005C2FEC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerMonsterListItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerMonsterListItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C61 RID: 80993 RVA: 0x005C4E2F File Offset: 0x005C302F
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

	// Token: 0x06013C62 RID: 80994 RVA: 0x005C4E5C File Offset: 0x005C305C
	private ShipTowerMonsterInfoItem CreateItem()
	{
		return new ShipTowerMonsterInfoItem();
	}

	// Token: 0x0400A8E6 RID: 43238
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMonsterInfoItem, ShipTowerMonsterInfoItemData> LayoutInfo;

	// Token: 0x02008216 RID: 33302
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A031 RID: 172081
		public const int TxtTitle = 0;

		// Token: 0x0402A032 RID: 172082
		public const int GLayoutContainer = 1;
	}
}
