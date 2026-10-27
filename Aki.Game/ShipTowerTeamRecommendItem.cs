using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029DA RID: 10714
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerTeamRecommendItem : GridProxyAbstract<ShipTowerTeamRecommendItemData>
{
	// Token: 0x06016335 RID: 90933 RVA: 0x0059D858 File Offset: 0x0059BA58
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
	}

	// Token: 0x06016336 RID: 90934 RVA: 0x0059D8E0 File Offset: 0x0059BAE0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerTeamRecommendItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerTeamRecommendItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016337 RID: 90935 RVA: 0x0059D923 File Offset: 0x0059BB23
	protected override void OnStart()
	{
	}

	// Token: 0x06016338 RID: 90936 RVA: 0x0059D928 File Offset: 0x0059BB28
	public override void Refresh(ShipTowerTeamRecommendItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		List<ShipTowerMediumItemData> list = new List<ShipTowerMediumItemData>();
		for (int i = 0; i < data.RoleIdList1.Count; i++)
		{
			list.Add(data.RoleIdList1[i]);
		}
		list.Add(new ShipTowerMediumItemData
		{
			Id = data.Buff1,
			Count = 1,
			IsBuff = new bool?(true),
			SkillBranchId = 0
		});
		List<ShipTowerMediumItemData> list2 = new List<ShipTowerMediumItemData>();
		for (int j = 0; j < data.RoleIdList2.Count; j++)
		{
			list2.Add(data.RoleIdList2[j]);
		}
		list2.Add(new ShipTowerMediumItemData
		{
			Id = data.Buff2,
			Count = 1,
			IsBuff = new bool?(true),
			SkillBranchId = 0
		});
		GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> layoutTeam = this.LayoutTeam1;
		if (layoutTeam != null)
		{
			layoutTeam.RefreshByData(list, null, false);
		}
		GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> layoutTeam2 = this.LayoutTeam2;
		if (layoutTeam2 != null)
		{
			layoutTeam2.RefreshByData(list2, null, false);
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(data.Name, true);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(data.UseRate.ToString() + "%", true);
		}
		bool enableClick = this.ItemData.StageData != null && this.ItemData.StageData.IsCanApplyTeamRecommend(this.ItemData);
		this.BtnUse.SetEnableClick(enableClick);
	}

	// Token: 0x06016339 RID: 90937 RVA: 0x0059DA9B File Offset: 0x0059BC9B
	private void OnClickUse()
	{
		Action<ShipTowerTeamRecommendItemData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x0601633A RID: 90938 RVA: 0x0059DAB3 File Offset: 0x0059BCB3
	private ShipTowerMediumItem CreateRecommendRoleItem()
	{
		ShipTowerMediumItem shipTowerMediumItem = new ShipTowerMediumItem();
		shipTowerMediumItem.RefreshCallBack = new Action<ShipTowerMediumItemData>(shipTowerMediumItem.RefreshRecommend);
		shipTowerMediumItem.GetStageIdCallback = new Func<int?>(this.GetStageIdCallback);
		return shipTowerMediumItem;
	}

	// Token: 0x0601633B RID: 90939 RVA: 0x0059DAE0 File Offset: 0x0059BCE0
	private int? GetStageIdCallback()
	{
		ShipTowerStageData stageData = this.ItemData.StageData;
		if (stageData == null)
		{
			return null;
		}
		return new int?(stageData.Id);
	}

	// Token: 0x0400A544 RID: 42308
	private ShipTowerTeamRecommendItemData ItemData;

	// Token: 0x0400A545 RID: 42309
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> LayoutTeam1;

	// Token: 0x0400A546 RID: 42310
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> LayoutTeam2;

	// Token: 0x0400A547 RID: 42311
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerTeamRecommendItemData> ClickCallBack;

	// Token: 0x0400A548 RID: 42312
	[Nullable(2)]
	private ButtonItem BtnUse;

	// Token: 0x02009007 RID: 36871
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402EA2C RID: 191020
		public const int TextName = 0;

		// Token: 0x0402EA2D RID: 191021
		public const int TextUseRate = 1;

		// Token: 0x0402EA2E RID: 191022
		public const int HLayoutTeam1 = 2;

		// Token: 0x0402EA2F RID: 191023
		public const int HLayoutTeam2 = 3;

		// Token: 0x0402EA30 RID: 191024
		public const int BtnUse = 4;
	}
}
