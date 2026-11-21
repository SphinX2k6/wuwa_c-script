using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CDB RID: 7387
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerMonsterSelectItem : GridProxyAbstract<RoleTowerMonsterSelectData>
{
	// Token: 0x06012493 RID: 74899 RVA: 0x005646D1 File Offset: 0x005628D1
	public void SetConfirmCallback(Action<int> callback)
	{
		this.ConfirmCallback = callback;
	}

	// Token: 0x06012494 RID: 74900 RVA: 0x005646DC File Offset: 0x005628DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUITexture)),
			new ValueTuple<int, Type>(13, typeof(UUISprite)),
			new ValueTuple<int, Type>(15, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickConfirm))
		};
	}

	// Token: 0x06012495 RID: 74901 RVA: 0x00564868 File Offset: 0x00562A68
	protected override void OnStart()
	{
		this.MonsterLayout = new GenericLayout<RoleTowerMonsterPreviewGridItem, RoleTowerMonsterInfoData>(base.GetHorizontalLayout(3), () => new RoleTowerMonsterPreviewGridItem(), null, false, true);
		this.RewardLayout = new GenericLayout<RoleTowerMonsterSelectGridItem, RoleTowerMonsterInfoData>(base.GetHorizontalLayout(7), () => new RoleTowerMonsterSelectGridItem(), null, false, true);
	}

	// Token: 0x06012496 RID: 74902 RVA: 0x005648E0 File Offset: 0x00562AE0
	public override void Refresh(RoleTowerMonsterSelectData data, bool isSelected, int gridIndex)
	{
		this.BranchId = data.BranchId;
		RoleTowerBranch? branchCfg = RoleTowerModel.Instance.GetBranchCfg(data.BranchId);
		if (branchCfg == null)
		{
			return;
		}
		RoleTowerBranch value = branchCfg.Value;
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.ShowTextNew(value.BranchTitle);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value.BranchDes, value.BranchDesParam());
		bool flag = value.Type == 1;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUITexture texture = base.GetTexture(12);
		if (texture != null)
		{
			texture.SetUIActive(flag);
		}
		UUISprite sprite = base.GetSprite(13);
		if (sprite != null)
		{
			bool bUseChangeColor = flag;
			FColor? fcolor = null;
			sprite.SetChangeColor(bUseChangeColor, fcolor);
		}
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(value.AddTime > 0);
		}
		UUIText text2 = base.GetText(6);
		if (text2 != null)
		{
			text2.SetText(RoleTowerTimeUtil.Format((long)value.AddTime), true);
		}
		List<RoleTowerMonsterInfoData> list = new List<RoleTowerMonsterInfoData>();
		RoleTowerFloor? floorCfg = RoleTowerModel.Instance.GetFloorCfg(data.FloorId);
		if (floorCfg != null)
		{
			RoleTowerFloor value2 = floorCfg.Value;
			for (int i = 0; i < value2.MonsterPreviewLength; i++)
			{
				list.Add(new RoleTowerMonsterInfoData
				{
					MonsterInfoId = value2.MonsterPreview(i)
				});
			}
		}
		GenericLayout<RoleTowerMonsterPreviewGridItem, RoleTowerMonsterInfoData> monsterLayout = this.MonsterLayout;
		if (monsterLayout != null)
		{
			monsterLayout.RefreshByData(list, null, false);
		}
		List<RoleTowerMonsterInfoData> list2 = new List<RoleTowerMonsterInfoData>();
		for (int j = 0; j < value.BranchTokenListLength; j++)
		{
			DicIntInt? dicIntInt = value.BranchTokenList(j);
			if (dicIntInt != null)
			{
				list2.Add(new RoleTowerMonsterInfoData
				{
					TokenId = dicIntInt.Value.Key,
					TokenCount = dicIntInt.Value.Value
				});
			}
		}
		UUIItem item3 = base.GetItem(15);
		if (item3 != null)
		{
			item3.SetUIActive(list2.Count > 0);
		}
		GenericLayout<RoleTowerMonsterSelectGridItem, RoleTowerMonsterInfoData> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(list2, null, false);
	}

	// Token: 0x06012497 RID: 74903 RVA: 0x00564AE8 File Offset: 0x00562CE8
	private void OnClickConfirm()
	{
		Action<int> confirmCallback = this.ConfirmCallback;
		if (confirmCallback == null)
		{
			return;
		}
		confirmCallback(this.BranchId);
	}

	// Token: 0x06012498 RID: 74904 RVA: 0x00564B00 File Offset: 0x00562D00
	public override object GetKey(RoleTowerMonsterSelectData data, int displayIndex)
	{
		return data.BranchId;
	}

	// Token: 0x04009F9C RID: 40860
	private int BranchId;

	// Token: 0x04009F9D RID: 40861
	[Nullable(2)]
	private Action<int> ConfirmCallback;

	// Token: 0x04009F9E RID: 40862
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerMonsterPreviewGridItem, RoleTowerMonsterInfoData> MonsterLayout;

	// Token: 0x04009F9F RID: 40863
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerMonsterSelectGridItem, RoleTowerMonsterInfoData> RewardLayout;

	// Token: 0x02007FD8 RID: 32728
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040295B2 RID: 169394
		public const int TxtCardTitle = 0;

		// Token: 0x040295B3 RID: 169395
		public const int PnlStrengthenState = 1;

		// Token: 0x040295B4 RID: 169396
		public const int TxtDesc = 2;

		// Token: 0x040295B5 RID: 169397
		public const int PnlMonsterItemLayout = 3;

		// Token: 0x040295B6 RID: 169398
		public const int UiItemItemBaseA = 4;

		// Token: 0x040295B7 RID: 169399
		public const int TxtInfoDesc = 5;

		// Token: 0x040295B8 RID: 169400
		public const int TxtTime = 6;

		// Token: 0x040295B9 RID: 169401
		public const int PnlRewardItem = 7;

		// Token: 0x040295BA RID: 169402
		public const int UiItemItemBaseB = 8;

		// Token: 0x040295BB RID: 169403
		public const int BtnConfirmB = 9;

		// Token: 0x040295BC RID: 169404
		public const int SprSel = 10;

		// Token: 0x040295BD RID: 169405
		public const int PnlAddTime = 11;

		// Token: 0x040295BE RID: 169406
		public const int TexBgRed = 12;

		// Token: 0x040295BF RID: 169407
		public const int SprTitleBgDeco = 13;

		// Token: 0x040295C0 RID: 169408
		public const int PnlRewardItemRoot = 15;
	}
}
