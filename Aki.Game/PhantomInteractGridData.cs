using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200245C RID: 9308
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractGridData : IPhantomInteractGridData
{
	// Token: 0x17001847 RID: 6215
	// (get) Token: 0x06012AC9 RID: 76489 RVA: 0x0049C57B File Offset: 0x0049A77B
	// (set) Token: 0x06012ACA RID: 76490 RVA: 0x0049C583 File Offset: 0x0049A783
	public int MonsterId { get; set; }

	// Token: 0x17001848 RID: 6216
	// (get) Token: 0x06012ACB RID: 76491 RVA: 0x0049C58C File Offset: 0x0049A78C
	// (set) Token: 0x06012ACC RID: 76492 RVA: 0x0049C594 File Offset: 0x0049A794
	public int MonsterInfoId { get; set; }

	// Token: 0x17001849 RID: 6217
	// (get) Token: 0x06012ACD RID: 76493 RVA: 0x0049C59D File Offset: 0x0049A79D
	// (set) Token: 0x06012ACE RID: 76494 RVA: 0x0049C5A5 File Offset: 0x0049A7A5
	public List<int> SkinIds { get; set; } = new List<int>();

	// Token: 0x1700184A RID: 6218
	// (get) Token: 0x06012ACF RID: 76495 RVA: 0x0049C5AE File Offset: 0x0049A7AE
	// (set) Token: 0x06012AD0 RID: 76496 RVA: 0x0049C5B6 File Offset: 0x0049A7B6
	public int EquippedSkin { get; set; }

	// Token: 0x1700184B RID: 6219
	// (get) Token: 0x06012AD1 RID: 76497 RVA: 0x0049C5BF File Offset: 0x0049A7BF
	// (set) Token: 0x06012AD2 RID: 76498 RVA: 0x0049C5C7 File Offset: 0x0049A7C7
	public bool IsSpecial { get; set; }

	// Token: 0x1700184C RID: 6220
	// (get) Token: 0x06012AD3 RID: 76499 RVA: 0x0049C5D0 File Offset: 0x0049A7D0
	// (set) Token: 0x06012AD4 RID: 76500 RVA: 0x0049C5D8 File Offset: 0x0049A7D8
	public int Cost { get; set; }

	// Token: 0x1700184D RID: 6221
	// (get) Token: 0x06012AD5 RID: 76501 RVA: 0x0049C5E1 File Offset: 0x0049A7E1
	// (set) Token: 0x06012AD6 RID: 76502 RVA: 0x0049C5E9 File Offset: 0x0049A7E9
	[Nullable(2)]
	public string Name { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700184E RID: 6222
	// (get) Token: 0x06012AD7 RID: 76503 RVA: 0x0049C5F2 File Offset: 0x0049A7F2
	// (set) Token: 0x06012AD8 RID: 76504 RVA: 0x0049C5FA File Offset: 0x0049A7FA
	public bool IsUnlocked { get; set; }

	// Token: 0x1700184F RID: 6223
	// (get) Token: 0x06012AD9 RID: 76505 RVA: 0x0049C603 File Offset: 0x0049A803
	// (set) Token: 0x06012ADA RID: 76506 RVA: 0x0049C60B File Offset: 0x0049A80B
	public List<int> InteractAreaList { get; set; } = new List<int>();

	// Token: 0x17001850 RID: 6224
	// (get) Token: 0x06012ADB RID: 76507 RVA: 0x0049C614 File Offset: 0x0049A814
	// (set) Token: 0x06012ADC RID: 76508 RVA: 0x0049C61C File Offset: 0x0049A81C
	public int InSlotIndex { get; set; } = -1;

	// Token: 0x17001851 RID: 6225
	// (get) Token: 0x06012ADD RID: 76509 RVA: 0x0049C625 File Offset: 0x0049A825
	// (set) Token: 0x06012ADE RID: 76510 RVA: 0x0049C62D File Offset: 0x0049A82D
	[Nullable(2)]
	public string IconPath { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001852 RID: 6226
	// (get) Token: 0x06012ADF RID: 76511 RVA: 0x0049C636 File Offset: 0x0049A836
	// (set) Token: 0x06012AE0 RID: 76512 RVA: 0x0049C63E File Offset: 0x0049A83E
	public bool HasSkin { get; set; }

	// Token: 0x17001853 RID: 6227
	// (get) Token: 0x06012AE1 RID: 76513 RVA: 0x0049C647 File Offset: 0x0049A847
	// (set) Token: 0x06012AE2 RID: 76514 RVA: 0x0049C64F File Offset: 0x0049A84F
	public int GetWayConfigId { get; set; }

	// Token: 0x17001854 RID: 6228
	// (get) Token: 0x06012AE3 RID: 76515 RVA: 0x0049C658 File Offset: 0x0049A858
	// (set) Token: 0x06012AE4 RID: 76516 RVA: 0x0049C660 File Offset: 0x0049A860
	public int SortId { get; set; }

	// Token: 0x06012AE5 RID: 76517 RVA: 0x0049C66C File Offset: 0x0049A86C
	public void LoadSkinId(int skinId)
	{
		this.EquippedSkin = skinId;
		int monsterId = this.MonsterId;
		bool flag = false;
		if (skinId != 0)
		{
			Aki.Config.PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(skinId);
			if (phantomItemById != null)
			{
				monsterId = phantomItemById.Value.MonsterId;
				this.IconPath = phantomItemById.Value.IconMiddle;
				flag = true;
			}
			else
			{
				monsterId = -1;
			}
		}
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(monsterId);
		int num = (calabashDevelopRewardByMonsterId != null) ? calabashDevelopRewardByMonsterId.Value.MonsterInfoId : 0;
		Aki.Config.MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(num);
		if (monsterInfoConfig != null)
		{
			this.Name = monsterInfoConfig.Value.Name;
		}
		this.MonsterInfoId = num;
		if (flag)
		{
			return;
		}
		IReadOnlyList<Aki.Config.PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(this.MonsterId);
		if (phantomItemByMonsterId == null || phantomItemByMonsterId.Count <= 0)
		{
			return;
		}
		this.IconPath = phantomItemByMonsterId[0].IconMiddle;
	}

	// Token: 0x06012AE6 RID: 76518 RVA: 0x0049C768 File Offset: 0x0049A968
	public void LoadData(UnlockIllustratedPhantom proto)
	{
		int monsterId = proto.MonsterId;
		int monsterId2 = monsterId;
		if (proto.EqupiedSkin > 0)
		{
			monsterId2 = proto.EqupiedSkin;
		}
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(monsterId2);
		IReadOnlyList<Aki.Config.PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId);
		if (phantomItemByMonsterId == null || phantomItemByMonsterId.Count <= 0)
		{
			return;
		}
		Aki.Config.PhantomItem phantomItem = phantomItemByMonsterId[0];
		this.IsUnlocked = true;
		this.HasSkin = PhantomInteractGridData.CheckHasSkin(proto.MonsterId);
		this.MonsterId = monsterId;
		this.SkinIds = new List<int>
		{
			0
		};
		foreach (int item in proto.SkinIds)
		{
			this.SkinIds.Add(item);
		}
		this.GetWayConfigId = ((calabashDevelopRewardByMonsterId != null) ? calabashDevelopRewardByMonsterId.Value.ItemAccess : 0);
		this.SortId = ((calabashDevelopRewardByMonsterId != null) ? calabashDevelopRewardByMonsterId.Value.SortId : 0);
		this.LoadSkinId(proto.EqupiedSkin);
		this.IsSpecial = (calabashDevelopRewardByMonsterId != null && calabashDevelopRewardByMonsterId.Value.IsWorldInteractable);
		this.InteractAreaList = new List<int>();
		if (calabashDevelopRewardByMonsterId != null)
		{
			int[] interactAreaListArray = calabashDevelopRewardByMonsterId.Value.GetInteractAreaListArray();
			if (interactAreaListArray != null)
			{
				foreach (int item2 in interactAreaListArray)
				{
					this.InteractAreaList.Add(item2);
				}
			}
		}
		int rarity = phantomItem.Rarity;
		PhantomRarity? phantomRareConfig = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity);
		if (phantomRareConfig != null)
		{
			this.Cost = phantomRareConfig.Value.Cost;
		}
	}

	// Token: 0x06012AE7 RID: 76519 RVA: 0x0049C938 File Offset: 0x0049AB38
	public void LoadLockData(int monsterId)
	{
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(monsterId);
		int monsterInfoId = calabashDevelopRewardByMonsterId.Value.MonsterInfoId;
		Aki.Config.MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(monsterInfoId);
		IReadOnlyList<Aki.Config.PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId);
		if (phantomItemByMonsterId == null || phantomItemByMonsterId.Count <= 0)
		{
			return;
		}
		Aki.Config.PhantomItem phantomItem = phantomItemByMonsterId[0];
		this.IsUnlocked = false;
		this.MonsterInfoId = monsterInfoId;
		this.MonsterId = monsterId;
		this.SkinIds = new List<int>();
		this.LoadSkinId(0);
		this.EquippedSkin = 0;
		this.IsSpecial = calabashDevelopRewardByMonsterId.Value.IsWorldInteractable;
		this.GetWayConfigId = calabashDevelopRewardByMonsterId.Value.ItemAccess;
		this.SortId = calabashDevelopRewardByMonsterId.Value.SortId;
		this.Name = monsterInfoConfig.Value.Name;
		int rarity = phantomItem.Rarity;
		this.Cost = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost;
		this.InteractAreaList = new List<int>();
		int[] interactAreaListArray = calabashDevelopRewardByMonsterId.Value.GetInteractAreaListArray();
		if (interactAreaListArray != null)
		{
			foreach (int item in interactAreaListArray)
			{
				this.InteractAreaList.Add(item);
			}
		}
		this.HasSkin = false;
	}

	// Token: 0x06012AE8 RID: 76520 RVA: 0x0049CA98 File Offset: 0x0049AC98
	private static bool CheckHasSkin(int monsterId)
	{
		IReadOnlyList<Aki.Config.PhantomItem> phantomItemByParentMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByParentMonsterId(monsterId);
		return phantomItemByParentMonsterId != null && phantomItemByParentMonsterId.Count > 0;
	}
}
