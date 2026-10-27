using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B28 RID: 6952
[NullableContext(1)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class FloroRanchEntityComponentIndexGetter<[Nullable(0)] T> where T : FloroRanchEntityComponentBase
{
	// Token: 0x17001136 RID: 4406
	// (get) Token: 0x0600CE3E RID: 52798 RVA: 0x002EF77C File Offset: 0x002ED97C
	public static int Index { get; }

	// Token: 0x0600CE3F RID: 52799 RVA: 0x002EF784 File Offset: 0x002ED984
	public static int GetByType(string typeName, bool useCache = false)
	{
		if (useCache)
		{
			int num = -1;
			if (FloroRanchEntityComponentIndexGetter<T>.ComponentIndex != null)
			{
				if (FloroRanchEntityComponentIndexGetter<T>.ComponentIndex.TryGetValue(typeName, out num))
				{
					return num;
				}
			}
			else
			{
				FloroRanchEntityComponentIndexGetter<T>.ComponentIndex = new Dictionary<string, int>();
			}
			EFloroRanchEntityComponent efloroRanchEntityComponent;
			num = (int)(Enum.TryParse<EFloroRanchEntityComponent>(typeName, out efloroRanchEntityComponent) ? efloroRanchEntityComponent : ((EFloroRanchEntityComponent)(-1)));
			if (num != -1)
			{
				FloroRanchEntityComponentIndexGetter<T>.ComponentIndex[typeName] = num;
			}
			return num;
		}
		EFloroRanchEntityComponent result;
		if (!Enum.TryParse<EFloroRanchEntityComponent>(typeName, out result))
		{
			return -1;
		}
		return (int)result;
	}

	// Token: 0x0600CE41 RID: 52801 RVA: 0x002EF7F0 File Offset: 0x002ED9F0
	// Note: this type is marked as 'beforefieldinit'.
	static FloroRanchEntityComponentIndexGetter()
	{
		EFloroRanchEntityComponent efloroRanchEntityComponent;
		FloroRanchEntityComponentIndexGetter<T>.Index = (Enum.TryParse<EFloroRanchEntityComponent>(typeof(T).Name, out efloroRanchEntityComponent) ? efloroRanchEntityComponent : ((EFloroRanchEntityComponent)(-1)));
	}

	// Token: 0x04005E8E RID: 24206
	public static Dictionary<string, int> ComponentIndex;
}
