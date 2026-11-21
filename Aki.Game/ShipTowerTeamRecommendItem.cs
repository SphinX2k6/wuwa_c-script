using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F55 RID: 8021
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerTeamRecommendItem : GridProxyAbstract<ShipTowerTeamRecommendItemData>
{
	// Token: 0x06013D3B RID: 81211 RVA: 0x005C8810 File Offset: 0x005C6A10
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

	// Token: 0x06013D3C RID: 81212 RVA: 0x005C8898 File Offset: 0x005C6A98
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerTeamRecommendItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerTeamRecommendItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013D3D RID: 81213 RVA: 0x005C88DB File Offset: 0x005C6ADB
	protected override void OnStart()
	{
	}

	// Token: 0x06013D3E RID: 81214 RVA: 0x005C88E0 File Offset: 0x005C6AE0
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

	// Token: 0x06013D3F RID: 81215 RVA: 0x005C8A53 File Offset: 0x005C6C53
	private void OnClickUse()
	{
		Action<ShipTowerTeamRecommendItemData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x06013D40 RID: 81216 RVA: 0x005C8A6B File Offset: 0x005C6C6B
	private ShipTowerMediumItem CreateRecommendRoleItem()
	{
		ShipTowerMediumItem shipTowerMediumItem = new ShipTowerMediumItem();
		shipTowerMediumItem.RefreshCallBack = new Action<ShipTowerMediumItemData>(shipTowerMediumItem.RefreshRecommend);
		shipTowerMediumItem.GetStageIdCallback = new Func<int?>(this.GetStageIdCallback);
		return shipTowerMediumItem;
	}

	// Token: 0x06013D41 RID: 81217 RVA: 0x005C8A98 File Offset: 0x005C6C98
	private int? GetStageIdCallback()
	{
		ShipTowerStageData stageData = this.ItemData.StageData;
		if (stageData == null)
		{
			return null;
		}
		return new int?(stageData.Id);
	}

	// Token: 0x0400A92E RID: 43310
	private ShipTowerTeamRecommendItemData ItemData;

	// Token: 0x0400A92F RID: 43311
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> LayoutTeam1;

	// Token: 0x0400A930 RID: 43312
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> LayoutTeam2;

	// Token: 0x0400A931 RID: 43313
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerTeamRecommendItemData> ClickCallBack;

	// Token: 0x0400A932 RID: 43314
	[Nullable(2)]
	private ButtonItem BtnUse;

	// Token: 0x0200824E RID: 33358
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A124 RID: 172324
		public const int TextName = 0;

		// Token: 0x0402A125 RID: 172325
		public const int TextUseRate = 1;

		// Token: 0x0402A126 RID: 172326
		public const int HLayoutTeam1 = 2;

		// Token: 0x0402A127 RID: 172327
		public const int HLayoutTeam2 = 3;

		// Token: 0x0402A128 RID: 172328
		public const int BtnUse = 4;
	}
}
