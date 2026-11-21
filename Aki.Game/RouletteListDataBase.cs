using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001E93 RID: 7827
[NullableContext(1)]
[Nullable(0)]
public abstract class RouletteListDataBase
{
	// Token: 0x17001D83 RID: 7555
	// (get) Token: 0x060134FD RID: 79101
	public abstract ERouletteType RouletteType { get; }

	// Token: 0x17001D84 RID: 7556
	// (get) Token: 0x060134FE RID: 79102
	public abstract ERoulettePriority Priority { get; }

	// Token: 0x060134FF RID: 79103
	public abstract List<int> GetRouletteIdList();

	// Token: 0x06013500 RID: 79104
	public abstract int GetExtraItemId();

	// Token: 0x06013501 RID: 79105
	public abstract int GetEquipExploreSkillId();

	// Token: 0x06013502 RID: 79106
	public abstract void Init();

	// Token: 0x06013503 RID: 79107
	public abstract void Clear();

	// Token: 0x06013504 RID: 79108
	public abstract bool IsActivate();

	// Token: 0x06013505 RID: 79109
	public abstract bool IsRouletteReplace();

	// Token: 0x06013506 RID: 79110
	public abstract bool IsRouletteOpen();

	// Token: 0x06013507 RID: 79111
	public abstract bool IsMainRouletteCanOpenView(bool checkTips);

	// Token: 0x06013508 RID: 79112 RVA: 0x005A3672 File Offset: 0x005A1872
	public virtual void UpdateData(ExploreSkillRoulette exploreList)
	{
		this.RouletteIdListServer = exploreList.SkillIds.ToList<int>();
		this.ExtraItemIdServer = exploreList.ExtraItemId;
		this.EquipExploreSkillIdServer = exploreList.ExploreSkill;
	}

	// Token: 0x06013509 RID: 79113 RVA: 0x005A369D File Offset: 0x005A189D
	public bool IsFirstExplorePriority()
	{
		return RouletteModel.Instance.GetCurrentExploreRouletteListData().RouletteType == this.RouletteType;
	}

	// Token: 0x0601350A RID: 79114 RVA: 0x005A36B8 File Offset: 0x005A18B8
	public bool IsExploreSkillIdAllowEquip(int skillId)
	{
		ExploreTools exploreTools;
		return RouletteModel.Instance.UnlockExploreSkillDataMap.TryGetValue(skillId, out exploreTools) && NoLinq.Contains<int>(exploreTools.GetRouletteTypeBytes(), (int)this.RouletteType);
	}

	// Token: 0x0601350B RID: 79115 RVA: 0x005A36ED File Offset: 0x005A18ED
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

	// Token: 0x0601350C RID: 79116
	public abstract Dictionary<ERouletteGridType, List<AssemblyGridData>> CreateAssemblyGridData();

	// Token: 0x0601350D RID: 79117
	public abstract int? GetRouletteGridId(int index, ERouletteGridType type, bool useDisplay);

	// Token: 0x0601350E RID: 79118
	public abstract RouletteMainViewProxyBase GetRouletteMainViewProxy();

	// Token: 0x0601350F RID: 79119
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public abstract List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteDataMap();

	// Token: 0x0400A590 RID: 42384
	public List<int> RouletteIdListServer = new List<int>(new int[8]);

	// Token: 0x0400A591 RID: 42385
	public int ExtraItemIdServer;

	// Token: 0x0400A592 RID: 42386
	public int EquipExploreSkillIdServer;
}
