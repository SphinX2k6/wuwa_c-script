using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EB6 RID: 3766
[NullableContext(1)]
[Nullable(0)]
public class PotatoEntityModelBuilder
{
	// Token: 0x06005D42 RID: 23874 RVA: 0x00111CBC File Offset: 0x0010FEBC
	[return: Nullable(2)]
	public static IPotatoCombatInfo Get(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		Type[] modelTypes = PotatoEntityModelBuilder.ModelTypes;
		for (int i = 0; i < modelTypes.Length; i++)
		{
			MethodInfo method = modelTypes[i].GetMethod("BuildModel", BindingFlags.Static | BindingFlags.Public);
			if (method != null)
			{
				object obj = method.Invoke(null, new object[]
				{
					entityData,
					componentDataMap
				});
				if (obj != null)
				{
					return (IPotatoCombatInfo)obj;
				}
			}
		}
		return null;
	}

	// Token: 0x06005D43 RID: 23875 RVA: 0x00111D17 File Offset: 0x0010FF17
	public static void Clear()
	{
		PotatoActivityEntityModel.Clear();
		PotatoEntityModel.Clear();
	}

	// Token: 0x04002A77 RID: 10871
	[StaticVariableRuleIgnore]
	private static readonly Type[] ModelTypes = new Type[]
	{
		typeof(PotatoActivityEntityModel),
		typeof(PotatoEntityModel)
	};
}
