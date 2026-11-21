using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000FE7 RID: 4071
[NullableContext(1)]
[Nullable(0)]
[StaticVariableRuleIgnore]
public class FloroRanchEntityComponentIndexGetter<[Nullable(0)] T> where T : FloroRanchEntityComponentBase
{
	// Token: 0x1700115B RID: 4443
	// (get) Token: 0x0600A24F RID: 41551 RVA: 0x002FA85C File Offset: 0x002F8A5C
	public static int Index { get; }

	// Token: 0x0600A250 RID: 41552 RVA: 0x002FA864 File Offset: 0x002F8A64
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

	// Token: 0x0600A252 RID: 41554 RVA: 0x002FA8D0 File Offset: 0x002F8AD0
	// Note: this type is marked as 'beforefieldinit'.
	static FloroRanchEntityComponentIndexGetter()
	{
		EFloroRanchEntityComponent efloroRanchEntityComponent;
		FloroRanchEntityComponentIndexGetter<T>.Index = (Enum.TryParse<EFloroRanchEntityComponent>(typeof(T).Name, out efloroRanchEntityComponent) ? efloroRanchEntityComponent : ((EFloroRanchEntityComponent)(-1)));
	}

	// Token: 0x04005F5D RID: 24413
	public static Dictionary<string, int> ComponentIndex;
}
