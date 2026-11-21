using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020018E2 RID: 6370
[NullableContext(1)]
[Nullable(0)]
public class PhantomRoleEquipmentData
{
	// Token: 0x0600FB92 RID: 64402 RVA: 0x00499834 File Offset: 0x00497A34
	public PhantomRoleEquipmentData()
	{
		this.PhantomItemIncrId = new int[5];
	}

	// Token: 0x0600FB93 RID: 64403 RVA: 0x00499848 File Offset: 0x00497A48
	public void Phrase(object data)
	{
		RolePhantomEquipInfo rolePhantomEquipInfo = data as RolePhantomEquipInfo;
		if (rolePhantomEquipInfo == null)
		{
			RolePhantomPropInfo rolePhantomPropInfo = data as RolePhantomPropInfo;
			if (rolePhantomPropInfo != null)
			{
				this.Prop = rolePhantomPropInfo;
			}
			return;
		}
		this.RoleId = rolePhantomEquipInfo.RoleId;
		if (rolePhantomEquipInfo.PhantomItemIncrId != null)
		{
			int[] array = new int[rolePhantomEquipInfo.PhantomItemIncrId.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rolePhantomEquipInfo.PhantomItemIncrId[i];
			}
			this.PhantomItemIncrId = array;
			return;
		}
		this.PhantomItemIncrId = new int[5];
	}

	// Token: 0x0600FB94 RID: 64404 RVA: 0x004998C7 File Offset: 0x00497AC7
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x0600FB95 RID: 64405 RVA: 0x004998D0 File Offset: 0x00497AD0
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

	// Token: 0x0600FB96 RID: 64406 RVA: 0x004998FB File Offset: 0x00497AFB
	public List<int> GetIncrIdList()
	{
		return new List<int>(this.PhantomItemIncrId);
	}

	// Token: 0x0600FB97 RID: 64407 RVA: 0x00499908 File Offset: 0x00497B08
	[NullableContext(2)]
	public RolePhantomPropInfo GetPropData()
	{
		return this.Prop;
	}

	// Token: 0x0600FB98 RID: 64408 RVA: 0x00499910 File Offset: 0x00497B10
	public bool CheckPhantomIsMain(int uniqueId)
	{
		return this.PhantomItemIncrId.Length != 0 && this.PhantomItemIncrId[0] == uniqueId;
	}

	// Token: 0x0600FB99 RID: 64409 RVA: 0x00499928 File Offset: 0x00497B28
	public bool CheckPhantomIsSub(int uniqueId)
	{
		return this.PhantomItemIncrId.Length != 0 && this.PhantomItemIncrId[0] != uniqueId && Array.IndexOf<int>(this.PhantomItemIncrId, uniqueId) >= 0;
	}

	// Token: 0x0600FB9A RID: 64410 RVA: 0x00499954 File Offset: 0x00497B54
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

	// Token: 0x0600FB9B RID: 64411 RVA: 0x0049999C File Offset: 0x00497B9C
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

	// Token: 0x0600FB9C RID: 64412 RVA: 0x004999CC File Offset: 0x00497BCC
	public int GetIndexPhantomId(int index)
	{
		if (this.PhantomItemIncrId.Length <= index)
		{
			return 0;
		}
		return this.PhantomItemIncrId[index];
	}

	// Token: 0x0600FB9D RID: 64413 RVA: 0x004999E4 File Offset: 0x00497BE4
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

	// Token: 0x0600FB9E RID: 64414 RVA: 0x00499A28 File Offset: 0x00497C28
	public int GetAverageEquipLevel()
	{
		int num = this.PhantomItemIncrId.Length;
		if (num <= 0)
		{
			return 0;
		}
		return this.GetSumEquipLevel() / num;
	}

	// Token: 0x0600FB9F RID: 64415 RVA: 0x00499A4C File Offset: 0x00497C4C
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

	// Token: 0x0600FBA0 RID: 64416 RVA: 0x00499A70 File Offset: 0x00497C70
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

	// Token: 0x0600FBA1 RID: 64417 RVA: 0x00499B38 File Offset: 0x00497D38
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

	// Token: 0x0600FBA2 RID: 64418 RVA: 0x00499C1C File Offset: 0x00497E1C
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

	// Token: 0x0600FBA3 RID: 64419 RVA: 0x00499DB4 File Offset: 0x00497FB4
	public bool CheckHasEmpty()
	{
		if (this.PhantomItemIncrId == null)
		{
			return false;
		}
		return Array.FindIndex<int>(this.PhantomItemIncrId, (int x) => x == 0) >= 0;
	}

	// Token: 0x0600FBA4 RID: 64420 RVA: 0x00499DF0 File Offset: 0x00497FF0
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

	// Token: 0x04008CA2 RID: 36002
	private int RoleId;

	// Token: 0x04008CA3 RID: 36003
	private int[] PhantomItemIncrId;

	// Token: 0x04008CA4 RID: 36004
	[Nullable(2)]
	private RolePhantomPropInfo Prop;
}
