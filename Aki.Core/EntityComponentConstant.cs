using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200007F RID: 127
[NullableContext(1)]
[Nullable(0)]
public class EntityComponentConstant : IStaticVariableResetter
{
	// Token: 0x060003DD RID: 989 RVA: 0x0001715B File Offset: 0x0001535B
	static EntityComponentConstant()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntityComponentConstant.CreateStaticDefaultValue), new Action(EntityComponentConstant.ResetStaticDefaultValue));
	}

	// Token: 0x060003DE RID: 990 RVA: 0x0001717A File Offset: 0x0001537A
	public static void CreateStaticDefaultValue()
	{
		EntityComponentConstant.CacheDependencies = new Dictionary<Type, Type[]>();
		EntityComponentConstant.CacheIndex = new Dictionary<Type, int>();
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00017190 File Offset: 0x00015390
	public static void ResetStaticDefaultValue()
	{
		EntityComponentConstant.ComponentTypeToIndexHook = null;
		EntityComponentConstant.CacheDependencies = null;
		EntityComponentConstant.CacheIndex = null;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x000171A4 File Offset: 0x000153A4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static Type[] GetComponentDependencies(Type componentType)
	{
		Type[] result;
		if (!EntityComponentConstant.CacheDependencies.TryGetValue(componentType, out result))
		{
			EntityComponent entityComponent = RuntimeHelpers.GetUninitializedObject(componentType) as EntityComponent;
			if (entityComponent == null)
			{
				return null;
			}
			result = (EntityComponentConstant.CacheDependencies[componentType] = entityComponent.Dependencies);
		}
		return result;
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x000171E8 File Offset: 0x000153E8
	public static int GetComponentIndex(Type componentType)
	{
		int result;
		if (!EntityComponentConstant.CacheIndex.TryGetValue(componentType, out result))
		{
			Dictionary<Type, int> cacheIndex = EntityComponentConstant.CacheIndex;
			Func<string, int> componentTypeToIndexHook = EntityComponentConstant.ComponentTypeToIndexHook;
			result = (cacheIndex[componentType] = ((componentTypeToIndexHook != null) ? componentTypeToIndexHook(componentType.Name) : -1));
		}
		return result;
	}

	// Token: 0x040003A7 RID: 935
	public static Func<string, int> ComponentTypeToIndexHook;

	// Token: 0x040003A8 RID: 936
	[Nullable(new byte[]
	{
		1,
		1,
		2,
		1
	})]
	private static Dictionary<Type, Type[]> CacheDependencies;

	// Token: 0x040003A9 RID: 937
	private static Dictionary<Type, int> CacheIndex;
}
