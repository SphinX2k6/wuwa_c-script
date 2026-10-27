using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200329D RID: 12957
[NullableContext(1)]
[Nullable(0)]
public class SquadAttributeTypes : IStaticVariableResetter
{
	// Token: 0x0601C0AC RID: 114860 RVA: 0x007CB9F4 File Offset: 0x007C9BF4
	static SquadAttributeTypes()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SquadAttributeTypes.CreateStaticDefaultValue), new Action(SquadAttributeTypes.ResetStaticDefaultValue));
	}

	// Token: 0x0601C0AD RID: 114861 RVA: 0x007CBA72 File Offset: 0x007C9C72
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601C0AE RID: 114862 RVA: 0x007CBA74 File Offset: 0x007C9C74
	public static void ResetStaticDefaultValue()
	{
	}

	// Token: 0x0400DDA0 RID: 56736
	public const int SQUAD_ATTRIBUTE_ID_MAX = 3;

	// Token: 0x0400DDA1 RID: 56737
	public const int PER_TEN_THOUSAND = 10000;

	// Token: 0x0400DDA2 RID: 56738
	public const float DIVIDED_TEN_THOUSAND = 0.0001f;

	// Token: 0x0400DDA3 RID: 56739
	[StaticVariableRuleIgnore]
	public static readonly HashSet<ESquadAttributeType> squadStateAttributeIds = new HashSet<ESquadAttributeType>
	{
		ESquadAttributeType.EnsembleEnergy
	};

	// Token: 0x0400DDA4 RID: 56740
	[StaticVariableRuleIgnore]
	public static readonly HashSet<ESquadAttributeType> squadWritableAttributeIds = new HashSet<ESquadAttributeType>();

	// Token: 0x0400DDA5 RID: 56741
	[StaticVariableRuleIgnore]
	public static readonly HashSet<ESquadAttributeType> squadLocalAttributeIds = new HashSet<ESquadAttributeType>();

	// Token: 0x0400DDA6 RID: 56742
	[StaticVariableRuleIgnore]
	public static readonly HashSet<ESquadAttributeType> squadAttrsNotClampZero = new HashSet<ESquadAttributeType>();

	// Token: 0x0400DDA7 RID: 56743
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<ESquadAttributeType, ESquadAttributeType> squadAttrIdsWithMax = new Dictionary<ESquadAttributeType, ESquadAttributeType>
	{
		{
			ESquadAttributeType.EnsembleEnergy,
			ESquadAttributeType.EnsembleEnergyMax
		}
	};

	// Token: 0x0400DDA8 RID: 56744
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<ESquadAttributeType, ESquadAttributeType> squadAttrIdsMaxToAttrId = new Dictionary<ESquadAttributeType, ESquadAttributeType>
	{
		{
			ESquadAttributeType.EnsembleEnergyMax,
			ESquadAttributeType.EnsembleEnergy
		}
	};
}
