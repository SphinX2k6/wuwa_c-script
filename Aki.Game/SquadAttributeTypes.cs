using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200280E RID: 10254
[NullableContext(1)]
[Nullable(0)]
public class SquadAttributeTypes : IStaticVariableResetter
{
	// Token: 0x06019CDA RID: 105690 RVA: 0x007F2CB4 File Offset: 0x007F0EB4
	static SquadAttributeTypes()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SquadAttributeTypes.CreateStaticDefaultValue), new Action(SquadAttributeTypes.ResetStaticDefaultValue));
	}

	// Token: 0x06019CDB RID: 105691 RVA: 0x007F2D32 File Offset: 0x007F0F32
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06019CDC RID: 105692 RVA: 0x007F2D34 File Offset: 0x007F0F34
	public static void ResetStaticDefaultValue()
	{
	}

	// Token: 0x0400E247 RID: 57927
	public const int SQUAD_ATTRIBUTE_ID_MAX = 3;

	// Token: 0x0400E248 RID: 57928
	public const int PER_TEN_THOUSAND = 10000;

	// Token: 0x0400E249 RID: 57929
	public const float DIVIDED_TEN_THOUSAND = 0.0001f;

	// Token: 0x0400E24A RID: 57930
	[StaticVariableRuleIgnore]
	public static readonly HashSet<ESquadAttributeType> squadStateAttributeIds = new HashSet<ESquadAttributeType>
	{
		ESquadAttributeType.EnsembleEnergy
	};

	// Token: 0x0400E24B RID: 57931
	[StaticVariableRuleIgnore]
	public static readonly HashSet<ESquadAttributeType> squadWritableAttributeIds = new HashSet<ESquadAttributeType>();

	// Token: 0x0400E24C RID: 57932
	[StaticVariableRuleIgnore]
	public static readonly HashSet<ESquadAttributeType> squadLocalAttributeIds = new HashSet<ESquadAttributeType>();

	// Token: 0x0400E24D RID: 57933
	[StaticVariableRuleIgnore]
	public static readonly HashSet<ESquadAttributeType> squadAttrsNotClampZero = new HashSet<ESquadAttributeType>();

	// Token: 0x0400E24E RID: 57934
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<ESquadAttributeType, ESquadAttributeType> squadAttrIdsWithMax = new Dictionary<ESquadAttributeType, ESquadAttributeType>
	{
		{
			ESquadAttributeType.EnsembleEnergy,
			ESquadAttributeType.EnsembleEnergyMax
		}
	};

	// Token: 0x0400E24F RID: 57935
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<ESquadAttributeType, ESquadAttributeType> squadAttrIdsMaxToAttrId = new Dictionary<ESquadAttributeType, ESquadAttributeType>
	{
		{
			ESquadAttributeType.EnsembleEnergyMax,
			ESquadAttributeType.EnsembleEnergy
		}
	};
}
