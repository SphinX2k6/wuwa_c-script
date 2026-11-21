using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002157 RID: 8535
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TowerDetailModel : ModelBase
{
	// Token: 0x06014F17 RID: 85783 RVA: 0x00619660 File Offset: 0x00617860
	public void AddSwitchData(int index, string name)
	{
		TowerSwitchData towerSwitchData = new TowerSwitchData();
		towerSwitchData.Index = index;
		towerSwitchData.Name = name;
		this.BuffMap[towerSwitchData] = new List<TowerDetailBuffData>();
		this.MonsterMap[towerSwitchData] = new List<TowerDetailMonsterData>();
		this.SwitchData.Add(towerSwitchData);
	}

	// Token: 0x06014F18 RID: 85784 RVA: 0x006196B0 File Offset: 0x006178B0
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

	// Token: 0x06014F19 RID: 85785 RVA: 0x0061971C File Offset: 0x0061791C
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

	// Token: 0x06014F1A RID: 85786 RVA: 0x0061973C File Offset: 0x0061793C
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

	// Token: 0x06014F1B RID: 85787 RVA: 0x006197A8 File Offset: 0x006179A8
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

	// Token: 0x06014F1C RID: 85788 RVA: 0x006197C8 File Offset: 0x006179C8
	public void Reset()
	{
		this.BuffMap = new Dictionary<TowerSwitchData, List<TowerDetailBuffData>>();
		this.MonsterMap = new Dictionary<TowerSwitchData, List<TowerDetailMonsterData>>();
		this.SwitchData = new List<TowerSwitchData>();
	}

	// Token: 0x17001FBF RID: 8127
	// (get) Token: 0x06014F1D RID: 85789 RVA: 0x006197EB File Offset: 0x006179EB
	public static TowerDetailModel Instance
	{
		get
		{
			return TowerDetailModel._Instance;
		}
	}

	// Token: 0x06014F1E RID: 85790 RVA: 0x006197F2 File Offset: 0x006179F2
	public static TowerDetailModel GetOrCreateInstance()
	{
		if (TowerDetailModel._Instance == null)
		{
			TowerDetailModel.CreateInstance();
		}
		return TowerDetailModel._Instance;
	}

	// Token: 0x06014F1F RID: 85791 RVA: 0x00619806 File Offset: 0x00617A06
	public static bool CreateInstance()
	{
		if (TowerDetailModel._Instance != null)
		{
			return true;
		}
		TowerDetailModel._Instance = new TowerDetailModel();
		return true;
	}

	// Token: 0x06014F20 RID: 85792 RVA: 0x0061981C File Offset: 0x00617A1C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014F21 RID: 85793 RVA: 0x0061981E File Offset: 0x00617A1E
	public static void ResetStaticDefaultValue()
	{
		TowerDetailModel._Instance = null;
	}

	// Token: 0x06014F22 RID: 85794 RVA: 0x00619826 File Offset: 0x00617A26
	static TowerDetailModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDetailModel.CreateStaticDefaultValue), new Action(TowerDetailModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B286 RID: 45702
	public int CurrentSelectDetailId;

	// Token: 0x0400B287 RID: 45703
	public string TowerTitle = string.Empty;

	// Token: 0x0400B288 RID: 45704
	public int SwitchButtonIndex;

	// Token: 0x0400B289 RID: 45705
	public List<TowerSwitchData> SwitchData = new List<TowerSwitchData>();

	// Token: 0x0400B28A RID: 45706
	private Dictionary<TowerSwitchData, List<TowerDetailBuffData>> BuffMap = new Dictionary<TowerSwitchData, List<TowerDetailBuffData>>();

	// Token: 0x0400B28B RID: 45707
	private Dictionary<TowerSwitchData, List<TowerDetailMonsterData>> MonsterMap = new Dictionary<TowerSwitchData, List<TowerDetailMonsterData>>();

	// Token: 0x0400B28C RID: 45708
	[Nullable(2)]
	private static TowerDetailModel _Instance;
}
