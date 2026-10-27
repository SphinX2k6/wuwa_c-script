using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EC9 RID: 3785
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueEntityModelBuilder
{
	// Token: 0x06005E13 RID: 24083 RVA: 0x001151CC File Offset: 0x001133CC
	[return: Nullable(2)]
	public static ISurvivorsRogueCombatInfo Get(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		Type[] modelTypes = SurvivorsRogueEntityModelBuilder.ModelTypes;
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
					return (ISurvivorsRogueCombatInfo)obj;
				}
			}
		}
		return null;
	}

	// Token: 0x06005E14 RID: 24084 RVA: 0x00115227 File Offset: 0x00113427
	public static void Clear()
	{
		SurvivorsRogueActivityEntityModel.Clear();
		SurvivorsRogueEntityModel.Clear();
	}

	// Token: 0x04002AC7 RID: 10951
	[StaticVariableRuleIgnore]
	private static readonly Type[] ModelTypes = new Type[]
	{
		typeof(SurvivorsRogueActivityEntityModel),
		typeof(SurvivorsRogueEntityModel)
	};
}
