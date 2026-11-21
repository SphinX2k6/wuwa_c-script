using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200036B RID: 875
public class PotatoEntityModelBuilder
{
	// Token: 0x060030D9 RID: 12505 RVA: 0x00119958 File Offset: 0x00117B58
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IPotatoCombatInfo Get(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		Func<EntityPb, Dictionary<string, EntityComponentPb>, IPotatoCombatInfo>[] modelTypes = PotatoEntityModelBuilder.ModelTypes;
		for (int i = 0; i < modelTypes.Length; i++)
		{
			IPotatoCombatInfo potatoCombatInfo = modelTypes[i](entityData, componentDataMap);
			if (potatoCombatInfo != null)
			{
				return potatoCombatInfo;
			}
		}
		return null;
	}

	// Token: 0x060030DA RID: 12506 RVA: 0x0011998A File Offset: 0x00117B8A
	public static void Clear()
	{
		PotatoActivityEntityModel.Clear();
		PotatoEntityModel.Clear();
	}

	// Token: 0x04002B12 RID: 11026
	[Nullable(new byte[]
	{
		1,
		1,
		1,
		1,
		1,
		1,
		2
	})]
	[StaticVariableRuleIgnore]
	private static readonly Func<EntityPb, Dictionary<string, EntityComponentPb>, IPotatoCombatInfo>[] ModelTypes = new Func<EntityPb, Dictionary<string, EntityComponentPb>, IPotatoCombatInfo>[]
	{
		new Func<EntityPb, Dictionary<string, EntityComponentPb>, IPotatoCombatInfo>(PotatoActivityEntityModel.BuildModel),
		new Func<EntityPb, Dictionary<string, EntityComponentPb>, IPotatoCombatInfo>(PotatoEntityModel.BuildModel)
	};
}
