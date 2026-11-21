using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F4B RID: 8011
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerShareLineupItem : GridProxyAbstract<ShipTowerRecordItemData>
{
	// Token: 0x06013CFB RID: 81147 RVA: 0x005C7600 File Offset: 0x005C5800
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06013CFC RID: 81148 RVA: 0x005C7688 File Offset: 0x005C5888
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerShareLineupItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerShareLineupItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CFD RID: 81149 RVA: 0x005C76CC File Offset: 0x005C58CC
	public override void Refresh(ShipTowerRecordItemData data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(data.Title, true);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(data.Score.ToString(), true);
		}
		UUIText text3 = base.GetText(2);
		if (text3 != null)
		{
			text3.SetText(data.Wave.ToString(), true);
		}
		List<ShipTowerMediumItemData> data2 = new List<ShipTowerMediumItemData>(data.TeamList)
		{
			new ShipTowerMediumItemData
			{
				Id = data.BuffId,
				Count = 1,
				IsBuff = new bool?(true),
				SkillBranchId = 0
			}
		};
		GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> roleLayout = this.RoleLayout;
		if (roleLayout == null)
		{
			return;
		}
		roleLayout.RefreshByData(data2, null, false);
	}

	// Token: 0x06013CFE RID: 81150 RVA: 0x005C777E File Offset: 0x005C597E
	private ShipTowerMediumItem CreateRoleItem()
	{
		ShipTowerMediumItem shipTowerMediumItem = new ShipTowerMediumItem();
		shipTowerMediumItem.RefreshCallBack = new Action<ShipTowerMediumItemData>(shipTowerMediumItem.RefreshRecord);
		return shipTowerMediumItem;
	}

	// Token: 0x0400A916 RID: 43286
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> RoleLayout;

	// Token: 0x0200823E RID: 33342
	[NullableContext(0)]
	private enum ELineupItemComponent
	{
		// Token: 0x0402A0DA RID: 172250
		TitleText,
		// Token: 0x0402A0DB RID: 172251
		NumOneText,
		// Token: 0x0402A0DC RID: 172252
		NumTwoText,
		// Token: 0x0402A0DD RID: 172253
		PnHor,
		// Token: 0x0402A0DE RID: 172254
		RoleItem
	}
}
