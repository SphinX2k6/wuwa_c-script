using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CD8 RID: 7384
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerMonsterGroupItem : GridProxyAbstract<RoleTowerMonsterFloorData>
{
	// Token: 0x06012488 RID: 74888 RVA: 0x00564234 File Offset: 0x00562434
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06012489 RID: 74889 RVA: 0x005642E6 File Offset: 0x005624E6
	protected override void OnStart()
	{
		this.MonsterLayout = new GenericLayout<RoleTowerMonsterInfoItem, RoleTowerMonsterInfoData>(base.GetGridLayout(5), () => new RoleTowerMonsterInfoItem(), null, false, true);
	}

	// Token: 0x0601248A RID: 74890 RVA: 0x0056431C File Offset: 0x0056251C
	public override void Refresh(RoleTowerMonsterFloorData data, bool isSelected, int gridIndex)
	{
		RoleTowerFloor? floorCfg = RoleTowerModel.Instance.GetFloorCfg(data.FloorId);
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(data.ShowFloorTitle);
		}
		if (data.ShowFloorTitle)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(((floorCfg != null) ? floorCfg.GetValueOrDefault().FloorName : null) ?? "");
			}
		}
		bool flag = data.BranchId > 0;
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		if (flag)
		{
			RoleTowerBranch? branchCfg = RoleTowerModel.Instance.GetBranchCfg(data.BranchId);
			if (branchCfg != null)
			{
				UUIText text2 = base.GetText(3);
				if (text2 != null)
				{
					text2.ShowTextNew(branchCfg.Value.BranchTitle);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), branchCfg.Value.BranchDes, branchCfg.Value.BranchDesParam());
			}
		}
		List<RoleTowerMonsterInfoData> list = new List<RoleTowerMonsterInfoData>();
		if (floorCfg != null)
		{
			RoleTowerFloor value = floorCfg.Value;
			for (int i = 0; i < value.MonsterPreviewLength; i++)
			{
				list.Add(new RoleTowerMonsterInfoData
				{
					MonsterInfoId = value.MonsterPreview(i)
				});
			}
		}
		GenericLayout<RoleTowerMonsterInfoItem, RoleTowerMonsterInfoData> monsterLayout = this.MonsterLayout;
		if (monsterLayout == null)
		{
			return;
		}
		monsterLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0601248B RID: 74891 RVA: 0x00564479 File Offset: 0x00562679
	public override object GetKey(RoleTowerMonsterFloorData data, int displayIndex)
	{
		return data.FloorId;
	}

	// Token: 0x04009F97 RID: 40855
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerMonsterInfoItem, RoleTowerMonsterInfoData> MonsterLayout;

	// Token: 0x02007FD4 RID: 32724
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040295A3 RID: 169379
		public const int UiItemTitle = 0;

		// Token: 0x040295A4 RID: 169380
		public const int TxtGroupTitle = 1;

		// Token: 0x040295A5 RID: 169381
		public const int PnlDescItem = 2;

		// Token: 0x040295A6 RID: 169382
		public const int TxtBuffTitle = 3;

		// Token: 0x040295A7 RID: 169383
		public const int TxtDesc = 4;

		// Token: 0x040295A8 RID: 169384
		public const int PnlMonsterGrid = 5;

		// Token: 0x040295A9 RID: 169385
		public const int UiItemMonsterInfo = 6;
	}
}
