using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02002918 RID: 10520
[NullableContext(1)]
[Nullable(0)]
public abstract class RouletteListDataBase
{
	// Token: 0x17001D29 RID: 7465
	// (get) Token: 0x06015AF9 RID: 88825
	public abstract ERouletteType RouletteType { get; }

	// Token: 0x17001D2A RID: 7466
	// (get) Token: 0x06015AFA RID: 88826
	public abstract ERoulettePriority Priority { get; }

	// Token: 0x06015AFB RID: 88827
	public abstract List<int> GetRouletteIdList();

	// Token: 0x06015AFC RID: 88828
	public abstract int GetExtraItemId();

	// Token: 0x06015AFD RID: 88829
	public abstract int GetEquipExploreSkillId();

	// Token: 0x06015AFE RID: 88830
	public abstract void Init();

	// Token: 0x06015AFF RID: 88831
	public abstract void Clear();

	// Token: 0x06015B00 RID: 88832
	public abstract bool IsActivate();

	// Token: 0x06015B01 RID: 88833
	public abstract bool IsRouletteReplace();

	// Token: 0x06015B02 RID: 88834
	public abstract bool IsRouletteOpen();

	// Token: 0x06015B03 RID: 88835
	public abstract bool IsMainRouletteCanOpenView(bool checkTips);

	// Token: 0x06015B04 RID: 88836 RVA: 0x0057877E File Offset: 0x0057697E
	public virtual void UpdateData(ExploreSkillRoulette exploreList)
	{
		this.RouletteIdListServer = exploreList.SkillIds.ToList<int>();
		this.ExtraItemIdServer = exploreList.ExtraItemId;
		this.EquipExploreSkillIdServer = exploreList.ExploreSkill;
	}

	// Token: 0x06015B05 RID: 88837 RVA: 0x005787A9 File Offset: 0x005769A9
	public bool IsFirstExplorePriority()
	{
		return RouletteModel.Instance.GetCurrentExploreRouletteListData().RouletteType == this.RouletteType;
	}

	// Token: 0x06015B06 RID: 88838 RVA: 0x005787C4 File Offset: 0x005769C4
	public bool IsExploreSkillIdAllowEquip(int skillId)
	{
		ExploreTools exploreTools;
		return RouletteModel.Instance.UnlockExploreSkillDataMap.TryGetValue(skillId, out exploreTools) && exploreTools.GetRouletteTypeArray().Contains((int)this.RouletteType);
	}

	// Token: 0x06015B07 RID: 88839 RVA: 0x005787F9 File Offset: 0x005769F9
	public IRouletteListSaveData GetRouletteListSaveData()
	{
		return new RouletteListSaveData
		{
			RouletteType = this.RouletteType,
			RouletteIdList = new List<int>(this.RouletteIdListServer),
			ExtraItemId = this.ExtraItemIdServer,
			EquipExploreSkillId = this.EquipExploreSkillIdServer
		};
	}

	// Token: 0x06015B08 RID: 88840
	public abstract Dictionary<ERouletteGridType, List<AssemblyGridData>> CreateAssemblyGridData();

	// Token: 0x06015B09 RID: 88841
	public abstract int? GetRouletteGridId(int index, ERouletteGridType type, bool useDisplay);

	// Token: 0x06015B0A RID: 88842
	public abstract RouletteMainViewProxyBase GetRouletteMainViewProxy();

	// Token: 0x06015B0B RID: 88843
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public abstract List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteDataMap();

	// Token: 0x0400A1A5 RID: 41381
	public List<int> RouletteIdListServer = new List<int>(new int[8]);

	// Token: 0x0400A1A6 RID: 41382
	public int ExtraItemIdServer;

	// Token: 0x0400A1A7 RID: 41383
	public int EquipExploreSkillIdServer;
}
