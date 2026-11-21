using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001941 RID: 6465
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractGridData : IPhantomInteractGridData
{
	// Token: 0x17001881 RID: 6273
	// (get) Token: 0x0600FF81 RID: 65409 RVA: 0x004A9CE7 File Offset: 0x004A7EE7
	// (set) Token: 0x0600FF82 RID: 65410 RVA: 0x004A9CEF File Offset: 0x004A7EEF
	public int MonsterId { get; set; }

	// Token: 0x17001882 RID: 6274
	// (get) Token: 0x0600FF83 RID: 65411 RVA: 0x004A9CF8 File Offset: 0x004A7EF8
	// (set) Token: 0x0600FF84 RID: 65412 RVA: 0x004A9D00 File Offset: 0x004A7F00
	public int MonsterInfoId { get; set; }

	// Token: 0x17001883 RID: 6275
	// (get) Token: 0x0600FF85 RID: 65413 RVA: 0x004A9D09 File Offset: 0x004A7F09
	// (set) Token: 0x0600FF86 RID: 65414 RVA: 0x004A9D11 File Offset: 0x004A7F11
	public List<int> SkinIds { get; set; } = new List<int>();

	// Token: 0x17001884 RID: 6276
	// (get) Token: 0x0600FF87 RID: 65415 RVA: 0x004A9D1A File Offset: 0x004A7F1A
	// (set) Token: 0x0600FF88 RID: 65416 RVA: 0x004A9D22 File Offset: 0x004A7F22
	public int EquippedSkin { get; set; }

	// Token: 0x17001885 RID: 6277
	// (get) Token: 0x0600FF89 RID: 65417 RVA: 0x004A9D2B File Offset: 0x004A7F2B
	// (set) Token: 0x0600FF8A RID: 65418 RVA: 0x004A9D33 File Offset: 0x004A7F33
	public bool IsSpecial { get; set; }

	// Token: 0x17001886 RID: 6278
	// (get) Token: 0x0600FF8B RID: 65419 RVA: 0x004A9D3C File Offset: 0x004A7F3C
	// (set) Token: 0x0600FF8C RID: 65420 RVA: 0x004A9D44 File Offset: 0x004A7F44
	public int Cost { get; set; }

	// Token: 0x17001887 RID: 6279
	// (get) Token: 0x0600FF8D RID: 65421 RVA: 0x004A9D4D File Offset: 0x004A7F4D
	// (set) Token: 0x0600FF8E RID: 65422 RVA: 0x004A9D55 File Offset: 0x004A7F55
	[Nullable(2)]
	public string Name { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001888 RID: 6280
	// (get) Token: 0x0600FF8F RID: 65423 RVA: 0x004A9D5E File Offset: 0x004A7F5E
	// (set) Token: 0x0600FF90 RID: 65424 RVA: 0x004A9D66 File Offset: 0x004A7F66
	public bool IsUnlocked { get; set; }

	// Token: 0x17001889 RID: 6281
	// (get) Token: 0x0600FF91 RID: 65425 RVA: 0x004A9D6F File Offset: 0x004A7F6F
	// (set) Token: 0x0600FF92 RID: 65426 RVA: 0x004A9D77 File Offset: 0x004A7F77
	public List<int> InteractAreaList { get; set; } = new List<int>();

	// Token: 0x1700188A RID: 6282
	// (get) Token: 0x0600FF93 RID: 65427 RVA: 0x004A9D80 File Offset: 0x004A7F80
	// (set) Token: 0x0600FF94 RID: 65428 RVA: 0x004A9D88 File Offset: 0x004A7F88
	public int InSlotIndex { get; set; } = -1;

	// Token: 0x1700188B RID: 6283
	// (get) Token: 0x0600FF95 RID: 65429 RVA: 0x004A9D91 File Offset: 0x004A7F91
	// (set) Token: 0x0600FF96 RID: 65430 RVA: 0x004A9D99 File Offset: 0x004A7F99
	[Nullable(2)]
	public string IconPath { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700188C RID: 6284
	// (get) Token: 0x0600FF97 RID: 65431 RVA: 0x004A9DA2 File Offset: 0x004A7FA2
	// (set) Token: 0x0600FF98 RID: 65432 RVA: 0x004A9DAA File Offset: 0x004A7FAA
	public bool HasSkin { get; set; }

	// Token: 0x1700188D RID: 6285
	// (get) Token: 0x0600FF99 RID: 65433 RVA: 0x004A9DB3 File Offset: 0x004A7FB3
	// (set) Token: 0x0600FF9A RID: 65434 RVA: 0x004A9DBB File Offset: 0x004A7FBB
	public int GetWayConfigId { get; set; }

	// Token: 0x1700188E RID: 6286
	// (get) Token: 0x0600FF9B RID: 65435 RVA: 0x004A9DC4 File Offset: 0x004A7FC4
	// (set) Token: 0x0600FF9C RID: 65436 RVA: 0x004A9DCC File Offset: 0x004A7FCC
	public int SortId { get; set; }

	// Token: 0x0600FF9D RID: 65437 RVA: 0x004A9DD8 File Offset: 0x004A7FD8
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

	// Token: 0x0600FF9E RID: 65438 RVA: 0x004A9ED4 File Offset: 0x004A80D4
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

	// Token: 0x0600FF9F RID: 65439 RVA: 0x004AA0A4 File Offset: 0x004A82A4
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

	// Token: 0x0600FFA0 RID: 65440 RVA: 0x004AA204 File Offset: 0x004A8404
	private static bool CheckHasSkin(int monsterId)
	{
		IReadOnlyList<Aki.Config.PhantomItem> phantomItemByParentMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByParentMonsterId(monsterId);
		return phantomItemByParentMonsterId != null && phantomItemByParentMonsterId.Count > 0;
	}
}
