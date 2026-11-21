using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200037E RID: 894
public class SurvivorsRogueEntityModelBuilder
{
	// Token: 0x060031AA RID: 12714 RVA: 0x0011CEAC File Offset: 0x0011B0AC
	[NullableContext(1)]
	[return: Nullable(2)]
	public static ISurvivorsRogueCombatInfo Get(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		Func<EntityPb, Dictionary<string, EntityComponentPb>, ISurvivorsRogueCombatInfo>[] modelTypes = SurvivorsRogueEntityModelBuilder.ModelTypes;
		for (int i = 0; i < modelTypes.Length; i++)
		{
			ISurvivorsRogueCombatInfo survivorsRogueCombatInfo = modelTypes[i](entityData, componentDataMap);
			if (survivorsRogueCombatInfo != null)
			{
				return survivorsRogueCombatInfo;
			}
		}
		return null;
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x0011CEDE File Offset: 0x0011B0DE
	public static void Clear()
	{
		SurvivorsRogueActivityEntityModel.Clear();
		SurvivorsRogueEntityModel.Clear();
	}

	// Token: 0x04002B62 RID: 11106
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
	private static readonly Func<EntityPb, Dictionary<string, EntityComponentPb>, ISurvivorsRogueCombatInfo>[] ModelTypes = new Func<EntityPb, Dictionary<string, EntityComponentPb>, ISurvivorsRogueCombatInfo>[]
	{
		new Func<EntityPb, Dictionary<string, EntityComponentPb>, ISurvivorsRogueCombatInfo>(SurvivorsRogueActivityEntityModel.BuildModel),
		new Func<EntityPb, Dictionary<string, EntityComponentPb>, ISurvivorsRogueCombatInfo>(SurvivorsRogueEntityModel.BuildModel)
	};
}
