using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F36 RID: 7990
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerMonsterWordItem : UiPanelBase
{
	// Token: 0x06013C69 RID: 81001 RVA: 0x005C4F40 File Offset: 0x005C3140
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

	// Token: 0x06013C6A RID: 81002 RVA: 0x005C4F8C File Offset: 0x005C318C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06013C6B RID: 81003 RVA: 0x005C4FE8 File Offset: 0x005C31E8
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerMonsterWordItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerMonsterWordItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C6C RID: 81004 RVA: 0x005C502B File Offset: 0x005C322B
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

	// Token: 0x06013C6D RID: 81005 RVA: 0x005C5058 File Offset: 0x005C3258
	private ShipTowerMonsterWordInfoItem CreateItem()
	{
		return new ShipTowerMonsterWordInfoItem();
	}

	// Token: 0x0400A8E7 RID: 43239
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMonsterWordInfoItem, ShipTowerMonsterWordInfoItemData> LayoutInfo;

	// Token: 0x0200821A RID: 33306
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A03F RID: 172095
		public const int TxtTitle = 0;

		// Token: 0x0402A040 RID: 172096
		public const int VLayoutContainer = 1;

		// Token: 0x0402A041 RID: 172097
		public const int ItemWordInfo = 2;
	}
}
