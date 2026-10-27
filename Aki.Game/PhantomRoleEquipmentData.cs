using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020023FD RID: 9213
[NullableContext(1)]
[Nullable(0)]
public class PhantomRoleEquipmentData
{
	// Token: 0x060126E0 RID: 75488 RVA: 0x0048C34C File Offset: 0x0048A54C
	public PhantomRoleEquipmentData()
	{
		this.PhantomItemIncrId = new int[5];
	}

	// Token: 0x060126E1 RID: 75489 RVA: 0x0048C360 File Offset: 0x0048A560
	public void Phrase(object data)
	{
		RolePhantomEquipInfo rolePhantomEquipInfo = data as RolePhantomEquipInfo;
		if (rolePhantomEquipInfo != null)
		{
			this.RoleId = rolePhantomEquipInfo.RoleId;
			this.PhantomItemIncrId = ((rolePhantomEquipInfo.PhantomItemIncrId != null) ? rolePhantomEquipInfo.PhantomItemIncrId.ToArray<int>() : new int[5]);
			return;
		}
		RolePhantomPropInfo rolePhantomPropInfo = data as RolePhantomPropInfo;
		if (rolePhantomPropInfo != null)
		{
			this.Prop = rolePhantomPropInfo;
		}
	}

	// Token: 0x060126E2 RID: 75490 RVA: 0x0048C3B6 File Offset: 0x0048A5B6
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x060126E3 RID: 75491 RVA: 0x0048C3C0 File Offset: 0x0048A5C0
	public void RemoveIncrIdLocal(int uniqueId)
	{
		if (uniqueId > 0)
		{
			int num = Array.IndexOf<int>(this.PhantomItemIncrId, uniqueId);
			if (num >= 0)
			{
				this.PhantomItemIncrId[num] = 0;
			}
		}
	}

	// Token: 0x060126E4 RID: 75492 RVA: 0x0048C3EB File Offset: 0x0048A5EB
	public List<int> GetIncrIdList()
	{
		return this.PhantomItemIncrId.ToList<int>();
	}

	// Token: 0x060126E5 RID: 75493 RVA: 0x0048C3F8 File Offset: 0x0048A5F8
	[NullableContext(2)]
	public RolePhantomPropInfo GetPropData()
	{
		return this.Prop;
	}

	// Token: 0x060126E6 RID: 75494 RVA: 0x0048C400 File Offset: 0x0048A600
	public bool CheckPhantomIsMain(int uniqueId)
	{
		return this.PhantomItemIncrId.Length != 0 && this.PhantomItemIncrId[0] == uniqueId;
	}

	// Token: 0x060126E7 RID: 75495 RVA: 0x0048C418 File Offset: 0x0048A618
	public bool CheckPhantomIsSub(int uniqueId)
	{
		return this.PhantomItemIncrId.Length != 0 && this.PhantomItemIncrId[0] != uniqueId && Array.IndexOf<int>(this.PhantomItemIncrId, uniqueId) >= 0;
	}

	// Token: 0x060126E8 RID: 75496 RVA: 0x0048C444 File Offset: 0x0048A644
	public bool CheckMonsterIsEquip(int monsterId)
	{
		int num = this.PhantomItemIncrId.Length;
		for (int i = 0; i < num; i++)
		{
			PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.PhantomItemIncrId[i]);
			if (phantomItemDataByUniqueId != null && phantomItemDataByUniqueId.GetMonsterId(false) == monsterId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060126E9 RID: 75497 RVA: 0x0048C48C File Offset: 0x0048A68C
	public int GetPhantomIndex(int uniqueId)
	{
		int num = this.PhantomItemIncrId.Length;
		for (int i = 0; i < num; i++)
		{
			if (this.PhantomItemIncrId[i] == uniqueId)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060126EA RID: 75498 RVA: 0x0048C4BC File Offset: 0x0048A6BC
	public int GetIndexPhantomId(int index)
	{
		if (this.PhantomItemIncrId.Length <= index)
		{
			return 0;
		}
		return this.PhantomItemIncrId[index];
	}

	// Token: 0x060126EB RID: 75499 RVA: 0x0048C4D4 File Offset: 0x0048A6D4
	public int GetSumEquipLevel()
	{
		int num = 0;
		foreach (int uniqueId in this.PhantomItemIncrId)
		{
			PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(uniqueId);
			if (phantomItemDataByUniqueId != null)
			{
				num += phantomItemDataByUniqueId.GetPhantomLevel();
			}
		}
		return num;
	}

	// Token: 0x060126EC RID: 75500 RVA: 0x0048C518 File Offset: 0x0048A718
	public int GetAverageEquipLevel()
	{
		int num = this.PhantomItemIncrId.Length;
		if (num <= 0)
		{
			return 0;
		}
		return this.GetSumEquipLevel() / num;
	}

	// Token: 0x060126ED RID: 75501 RVA: 0x0048C53C File Offset: 0x0048A73C
	public EEquipType GetPhantomOperationState(int index, int uniqueId)
	{
		int num = this.PhantomItemIncrId[index];
		if (num == 0)
		{
			return EEquipType.Equip;
		}
		if (num == uniqueId)
		{
			return EEquipType.UnEquip;
		}
		return EEquipType.Replace;
	}

	// Token: 0x060126EE RID: 75502 RVA: 0x0048C560 File Offset: 0x0048A760
	public int GetCombinationActiveNum(List<int> monsterIdList)
	{
		int num = 0;
		List<int> list = new List<int>();
		foreach (int num2 in monsterIdList)
		{
			foreach (int uniqueId in this.GetIncrIdList())
			{
				PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(uniqueId);
				if (phantomItemDataByUniqueId != null && num2 == phantomItemDataByUniqueId.GetMonsterId(false) && !list.Contains(num2))
				{
					list.Add(num2);
					num++;
				}
			}
		}
		return monsterIdList.Count - num;
	}

	// Token: 0x060126EF RID: 75503 RVA: 0x0048C628 File Offset: 0x0048A828
	public List<AttrListScrollData> GetPropDetailAttributeList()
	{
		IEnumerable<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionMainViewExtraAttribute");
		List<AttrListScrollData> propShowAttributeList = this.GetPropShowAttributeList();
		int count = propShowAttributeList.Count;
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		foreach (int num in intArrayConfig)
		{
			bool flag = false;
			for (int i = 0; i < count; i++)
			{
				if (propShowAttributeList[i].Id == num)
				{
					list.Add(propShowAttributeList[i]);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(new RoleAttrListScrollData(num, 0.0, 0.0, PropertyIndexConfig.Instance.GetPropertyIndexInfo(num).Value.Priority, false, CommonComponentDefine.EAttributeType.PhantomType));
			}
		}
		return list;
	}

	// Token: 0x060126F0 RID: 75504 RVA: 0x0048C70C File Offset: 0x0048A90C
	public List<AttrListScrollData> GetPropShowAttributeList()
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		RolePhantomPropInfo prop = this.Prop;
		if (((prop != null) ? prop.BaseProp : null) != null)
		{
			foreach (ArrayIntInt arrayIntInt in this.Prop.BaseProp)
			{
				dictionary[arrayIntInt.Key] = arrayIntInt.Value;
			}
		}
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		RolePhantomPropInfo prop2 = this.Prop;
		if (((prop2 != null) ? prop2.AddProp : null) != null)
		{
			foreach (ArrayIntInt arrayIntInt2 in this.Prop.AddProp)
			{
				dictionary2[arrayIntInt2.Key] = arrayIntInt2.Value;
				if (!dictionary.ContainsKey(arrayIntInt2.Key))
				{
					dictionary[arrayIntInt2.Key] = 0;
				}
			}
		}
		List<int> list2 = new List<int>(dictionary.Keys);
		int count = list2.Count;
		for (int i = 0; i < count; i++)
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(list2[i]);
			int num;
			if (!dictionary2.TryGetValue(list2[i], out num))
			{
				num = 0;
			}
			list.Add(new RoleAttrListScrollData(list2[i], (double)dictionary[list2[i]], (double)num, propertyIndexInfo.Value.Priority, false, CommonComponentDefine.EAttributeType.PhantomType));
		}
		return list;
	}

	// Token: 0x060126F1 RID: 75505 RVA: 0x0048C8A4 File Offset: 0x0048AAA4
	public bool CheckHasEmpty()
	{
		if (this.PhantomItemIncrId == null)
		{
			return false;
		}
		return Array.FindIndex<int>(this.PhantomItemIncrId, (int x) => x == 0) >= 0;
	}

	// Token: 0x060126F2 RID: 75506 RVA: 0x0048C8E0 File Offset: 0x0048AAE0
	public int GetEquippedNum()
	{
		if (this.PhantomItemIncrId == null)
		{
			return 0;
		}
		int num = 0;
		int[] phantomItemIncrId = this.PhantomItemIncrId;
		for (int i = 0; i < phantomItemIncrId.Length; i++)
		{
			if (phantomItemIncrId[i] > 0)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x04008B5B RID: 35675
	private int RoleId;

	// Token: 0x04008B5C RID: 35676
	private int[] PhantomItemIncrId;

	// Token: 0x04008B5D RID: 35677
	[Nullable(2)]
	private RolePhantomPropInfo Prop;
}
