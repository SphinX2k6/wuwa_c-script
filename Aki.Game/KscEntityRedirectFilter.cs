using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x0200033B RID: 827
[NullableContext(1)]
[Nullable(0)]
public class KscEntityRedirectFilter : CreatureController.IEntityRedirectFilter, IStaticVariableResetter
{
	// Token: 0x06002E64 RID: 11876 RVA: 0x00110834 File Offset: 0x0010EA34
	static KscEntityRedirectFilter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KscEntityRedirectFilter.CreateStaticDefaultValue), new Action(KscEntityRedirectFilter.ResetStaticDefaultValue));
	}

	// Token: 0x06002E65 RID: 11877 RVA: 0x00110853 File Offset: 0x0010EA53
	public static void CreateStaticDefaultValue()
	{
		KscEntityRedirectFilter.ComponentDataMap = new Dictionary<string, EntityComponentPb>();
	}

	// Token: 0x06002E66 RID: 11878 RVA: 0x0011085F File Offset: 0x0010EA5F
	public static void ResetStaticDefaultValue()
	{
		KscEntityRedirectFilter.ComponentDataMap = null;
	}

	// Token: 0x06002E67 RID: 11879 RVA: 0x00110868 File Offset: 0x0010EA68
	public bool TryCreateEntity(EntityPb entityData)
	{
		KscEntityRedirectFilter.ComponentDataMap.Clear();
		if (entityData.ComponentPbs != null)
		{
			foreach (EntityComponentPb entityComponentPb in entityData.ComponentPbs)
			{
				EntityComponentPb.ComponentOneofCase componentCase = entityComponentPb.ComponentCase;
				KscEntityRedirectFilter.ComponentDataMap[componentCase.ToString()] = entityComponentPb;
			}
		}
		bool flag = KscEntityRedirectFilter.ComponentDataMap.ContainsKey("SimpleCombatComponentPb");
		EntityComponentPb entityComponentPb2;
		if (KscEntityRedirectFilter.ComponentDataMap.TryGetValue("TrapDefenseComponentPb", out entityComponentPb2))
		{
			bool flag2;
			if (entityComponentPb2 == null)
			{
				flag2 = (null != null);
			}
			else
			{
				TrapDefenseComponentPb trapDefenseComponentPb = entityComponentPb2.TrapDefenseComponentPb;
				if (trapDefenseComponentPb == null)
				{
					flag2 = (null != null);
				}
				else
				{
					TrapDefenseAuxiliaryPbData auxiliaryPbData = trapDefenseComponentPb.AuxiliaryPbData;
					flag2 = (((auxiliaryPbData != null) ? auxiliaryPbData.ConfigIds : null) != null);
				}
			}
			if (flag2)
			{
				return false;
			}
		}
		if (flag)
		{
			this.FilteredEntities.Add(entityData.Id);
			if (!this.OnCreateEntity(entityData, KscEntityRedirectFilter.ComponentDataMap))
			{
				KscLog.EModule flag3 = KscLog.EModule.Common;
				ELogAuthor author = ELogAuthor.XY;
				UObject obj = null;
				string log = "创建KSC实体数据失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", entityData.Id);
				KscLog.Error(flag3, author, obj, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		KscEntityRedirectFilter.ComponentDataMap.Clear();
		return flag;
	}

	// Token: 0x06002E68 RID: 11880 RVA: 0x00110988 File Offset: 0x0010EB88
	public void InstantiateEntities()
	{
		this.OnInstantiateEntities();
	}

	// Token: 0x06002E69 RID: 11881 RVA: 0x00110990 File Offset: 0x0010EB90
	public bool TryRemoveEntity(long creatureDataId)
	{
		if (this.FilteredEntities.Contains((long)((int)creatureDataId)))
		{
			this.FilteredEntities.Remove((long)((int)creatureDataId));
			if (!this.OnRemoveEntity((int)creatureDataId))
			{
				KscLog.EModule flag = KscLog.EModule.Common;
				ELogAuthor author = ELogAuthor.XY;
				UObject obj = null;
				string log = "移除KSC实体数据失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
				KscLog.Error(flag, author, obj, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return true;
		}
		return false;
	}

	// Token: 0x06002E6A RID: 11882 RVA: 0x001109F0 File Offset: 0x0010EBF0
	public virtual void Reset()
	{
		this.FilteredEntities.Clear();
	}

	// Token: 0x06002E6B RID: 11883 RVA: 0x001109FD File Offset: 0x0010EBFD
	protected virtual bool OnCreateEntity(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return false;
	}

	// Token: 0x06002E6C RID: 11884 RVA: 0x00110A00 File Offset: 0x0010EC00
	protected virtual void OnInstantiateEntities()
	{
	}

	// Token: 0x06002E6D RID: 11885 RVA: 0x00110A02 File Offset: 0x0010EC02
	protected virtual bool OnRemoveEntity(int creatureDataId)
	{
		return false;
	}

	// Token: 0x04002A1E RID: 10782
	private static Dictionary<string, EntityComponentPb> ComponentDataMap;

	// Token: 0x04002A1F RID: 10783
	private readonly HashSet<long> FilteredEntities = new HashSet<long>();
}
