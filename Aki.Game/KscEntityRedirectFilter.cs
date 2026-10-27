using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000E86 RID: 3718
[NullableContext(1)]
[Nullable(0)]
public class KscEntityRedirectFilter : CreatureController.IEntityRedirectFilter, IStaticVariableResetter
{
	// Token: 0x06005ACD RID: 23245 RVA: 0x00108B84 File Offset: 0x00106D84
	static KscEntityRedirectFilter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KscEntityRedirectFilter.CreateStaticDefaultValue), new Action(KscEntityRedirectFilter.ResetStaticDefaultValue));
	}

	// Token: 0x06005ACE RID: 23246 RVA: 0x00108BA3 File Offset: 0x00106DA3
	public static void CreateStaticDefaultValue()
	{
		KscEntityRedirectFilter.ComponentDataMap = new Dictionary<string, EntityComponentPb>();
	}

	// Token: 0x06005ACF RID: 23247 RVA: 0x00108BAF File Offset: 0x00106DAF
	public static void ResetStaticDefaultValue()
	{
		KscEntityRedirectFilter.ComponentDataMap = null;
	}

	// Token: 0x06005AD0 RID: 23248 RVA: 0x00108BB8 File Offset: 0x00106DB8
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
				bool isBuildDevelopmentOrDebug = Info.Instance.IsBuildDevelopmentOrDebug;
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

	// Token: 0x06005AD1 RID: 23249 RVA: 0x00108CE4 File Offset: 0x00106EE4
	public void InstantiateEntities()
	{
		this.OnInstantiateEntities();
	}

	// Token: 0x06005AD2 RID: 23250 RVA: 0x00108CEC File Offset: 0x00106EEC
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

	// Token: 0x06005AD3 RID: 23251 RVA: 0x00108D4C File Offset: 0x00106F4C
	public virtual void Reset()
	{
		this.FilteredEntities.Clear();
	}

	// Token: 0x06005AD4 RID: 23252 RVA: 0x00108D59 File Offset: 0x00106F59
	protected virtual bool OnCreateEntity(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return false;
	}

	// Token: 0x06005AD5 RID: 23253 RVA: 0x00108D5C File Offset: 0x00106F5C
	protected virtual void OnInstantiateEntities()
	{
	}

	// Token: 0x06005AD6 RID: 23254 RVA: 0x00108D5E File Offset: 0x00106F5E
	protected virtual bool OnRemoveEntity(int creatureDataId)
	{
		return false;
	}

	// Token: 0x04002983 RID: 10627
	private static Dictionary<string, EntityComponentPb> ComponentDataMap;

	// Token: 0x04002984 RID: 10628
	private readonly HashSet<long> FilteredEntities = new HashSet<long>();
}
