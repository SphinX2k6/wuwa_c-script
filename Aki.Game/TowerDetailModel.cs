using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002BDC RID: 11228
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TowerDetailModel : ModelBase
{
	// Token: 0x060174E6 RID: 95462 RVA: 0x005ECB24 File Offset: 0x005EAD24
	public void AddSwitchData(int index, string name)
	{
		TowerSwitchData towerSwitchData = new TowerSwitchData();
		towerSwitchData.Index = index;
		towerSwitchData.Name = name;
		this.BuffMap[towerSwitchData] = new List<TowerDetailBuffData>();
		this.MonsterMap[towerSwitchData] = new List<TowerDetailMonsterData>();
		this.SwitchData.Add(towerSwitchData);
	}

	// Token: 0x060174E7 RID: 95463 RVA: 0x005ECB74 File Offset: 0x005EAD74
	public void AddBuff(int index, List<TowerDetailBuff> buffs, string title, int priority)
	{
		TowerDetailBuffData towerDetailBuffData = new TowerDetailBuffData();
		towerDetailBuffData.Buffs = buffs;
		towerDetailBuffData.Title = title;
		towerDetailBuffData.Priority = priority;
		for (int i = 0; i < this.SwitchData.Count; i++)
		{
			TowerSwitchData towerSwitchData = this.SwitchData[i];
			List<TowerDetailBuffData> list;
			if (towerSwitchData.Index == index && this.BuffMap.TryGetValue(towerSwitchData, out list))
			{
				list.Add(towerDetailBuffData);
			}
		}
	}

	// Token: 0x060174E8 RID: 95464 RVA: 0x005ECBE0 File Offset: 0x005EADE0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<TowerDetailBuffData> GetBuffs(TowerSwitchData switchData)
	{
		List<TowerDetailBuffData> result;
		if (this.BuffMap.TryGetValue(switchData, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060174E9 RID: 95465 RVA: 0x005ECC00 File Offset: 0x005EAE00
	public void AddMonster(int index, List<TowerDetailMonster> towerDetailMonster, string title, int priority)
	{
		TowerDetailMonsterData towerDetailMonsterData = new TowerDetailMonsterData();
		towerDetailMonsterData.Title = title;
		towerDetailMonsterData.MonsterInfos = towerDetailMonster;
		towerDetailMonsterData.Priority = priority;
		for (int i = 0; i < this.SwitchData.Count; i++)
		{
			TowerSwitchData towerSwitchData = this.SwitchData[i];
			List<TowerDetailMonsterData> list;
			if (towerSwitchData.Index == index && this.MonsterMap.TryGetValue(towerSwitchData, out list))
			{
				list.Add(towerDetailMonsterData);
			}
		}
	}

	// Token: 0x060174EA RID: 95466 RVA: 0x005ECC6C File Offset: 0x005EAE6C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<TowerDetailMonsterData> GetMonsters(TowerSwitchData switchData)
	{
		List<TowerDetailMonsterData> result;
		if (this.MonsterMap.TryGetValue(switchData, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060174EB RID: 95467 RVA: 0x005ECC8C File Offset: 0x005EAE8C
	public void Reset()
	{
		this.BuffMap = new Dictionary<TowerSwitchData, List<TowerDetailBuffData>>();
		this.MonsterMap = new Dictionary<TowerSwitchData, List<TowerDetailMonsterData>>();
		this.SwitchData = new List<TowerSwitchData>();
	}

	// Token: 0x17001F67 RID: 8039
	// (get) Token: 0x060174EC RID: 95468 RVA: 0x005ECCAF File Offset: 0x005EAEAF
	public static TowerDetailModel Instance
	{
		get
		{
			return TowerDetailModel._Instance;
		}
	}

	// Token: 0x060174ED RID: 95469 RVA: 0x005ECCB6 File Offset: 0x005EAEB6
	public static TowerDetailModel GetOrCreateInstance()
	{
		if (TowerDetailModel._Instance == null)
		{
			TowerDetailModel.CreateInstance();
		}
		return TowerDetailModel._Instance;
	}

	// Token: 0x060174EE RID: 95470 RVA: 0x005ECCCA File Offset: 0x005EAECA
	public static bool CreateInstance()
	{
		if (TowerDetailModel._Instance != null)
		{
			return true;
		}
		TowerDetailModel._Instance = new TowerDetailModel();
		return true;
	}

	// Token: 0x060174EF RID: 95471 RVA: 0x005ECCE0 File Offset: 0x005EAEE0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060174F0 RID: 95472 RVA: 0x005ECCE2 File Offset: 0x005EAEE2
	public static void ResetStaticDefaultValue()
	{
		TowerDetailModel._Instance = null;
	}

	// Token: 0x060174F1 RID: 95473 RVA: 0x005ECCEA File Offset: 0x005EAEEA
	static TowerDetailModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDetailModel.CreateStaticDefaultValue), new Action(TowerDetailModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AE81 RID: 44673
	public int CurrentSelectDetailId;

	// Token: 0x0400AE82 RID: 44674
	public string TowerTitle = string.Empty;

	// Token: 0x0400AE83 RID: 44675
	public int SwitchButtonIndex;

	// Token: 0x0400AE84 RID: 44676
	public List<TowerSwitchData> SwitchData = new List<TowerSwitchData>();

	// Token: 0x0400AE85 RID: 44677
	private Dictionary<TowerSwitchData, List<TowerDetailBuffData>> BuffMap = new Dictionary<TowerSwitchData, List<TowerDetailBuffData>>();

	// Token: 0x0400AE86 RID: 44678
	private Dictionary<TowerSwitchData, List<TowerDetailMonsterData>> MonsterMap = new Dictionary<TowerSwitchData, List<TowerDetailMonsterData>>();

	// Token: 0x0400AE87 RID: 44679
	[Nullable(2)]
	private static TowerDetailModel _Instance;
}
