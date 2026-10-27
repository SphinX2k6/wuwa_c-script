using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000071 RID: 113
[StaticVariableRuleIgnore]
public static class ComponentIndexGetter
{
	// Token: 0x06000324 RID: 804 RVA: 0x000131A6 File Offset: 0x000113A6
	public static int IndexOf<T>() where T : EntityComponent
	{
		return ComponentIndexGetter.GetByType(typeof(T).Name, true);
	}

	// Token: 0x06000325 RID: 805 RVA: 0x000131C0 File Offset: 0x000113C0
	[NullableContext(1)]
	public static int GetByType(string typeName, bool useCache = false)
	{
		if (useCache)
		{
			int num = -1;
			if (ComponentIndexGetter.ComponentIndex != null)
			{
				if (ComponentIndexGetter.ComponentIndex.TryGetValue(typeName, out num))
				{
					return num;
				}
			}
			else
			{
				ComponentIndexGetter.ComponentIndex = new Dictionary<string, int>();
			}
			Func<string, int> componentTypeToIndexHook = EntityComponentConstant.ComponentTypeToIndexHook;
			num = ((componentTypeToIndexHook != null) ? componentTypeToIndexHook(typeName) : -1);
			if (num != -1)
			{
				ComponentIndexGetter.ComponentIndex[typeName] = num;
			}
			return num;
		}
		Func<string, int> componentTypeToIndexHook2 = EntityComponentConstant.ComponentTypeToIndexHook;
		if (componentTypeToIndexHook2 == null)
		{
			return -1;
		}
		return componentTypeToIndexHook2(typeName);
	}

	// Token: 0x0400033C RID: 828
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static Dictionary<string, int> ComponentIndex;
}
