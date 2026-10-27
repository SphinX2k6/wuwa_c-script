using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029D0 RID: 10704
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerShareLineupItem : GridProxyAbstract<ShipTowerRecordItemData>
{
	// Token: 0x060162F5 RID: 90869 RVA: 0x0059C648 File Offset: 0x0059A848
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

	// Token: 0x060162F6 RID: 90870 RVA: 0x0059C6D0 File Offset: 0x0059A8D0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerShareLineupItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerShareLineupItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060162F7 RID: 90871 RVA: 0x0059C714 File Offset: 0x0059A914
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

	// Token: 0x060162F8 RID: 90872 RVA: 0x0059C7C6 File Offset: 0x0059A9C6
	private ShipTowerMediumItem CreateRoleItem()
	{
		ShipTowerMediumItem shipTowerMediumItem = new ShipTowerMediumItem();
		shipTowerMediumItem.RefreshCallBack = new Action<ShipTowerMediumItemData>(shipTowerMediumItem.RefreshRecord);
		return shipTowerMediumItem;
	}

	// Token: 0x0400A52C RID: 42284
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> RoleLayout;

	// Token: 0x02008FF7 RID: 36855
	[NullableContext(0)]
	private enum ELineupItemComponent
	{
		// Token: 0x0402E9E2 RID: 190946
		TitleText,
		// Token: 0x0402E9E3 RID: 190947
		NumOneText,
		// Token: 0x0402E9E4 RID: 190948
		NumTwoText,
		// Token: 0x0402E9E5 RID: 190949
		PnHor,
		// Token: 0x0402E9E6 RID: 190950
		RoleItem
	}
}
