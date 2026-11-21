using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002470 RID: 9328
[RequiredMember]
public class RequirementRelationship : IRequirement
{
	// Token: 0x1700246F RID: 9327
	// (get) Token: 0x06017476 RID: 95350 RVA: 0x006D7ECF File Offset: 0x006D60CF
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.Relationship;
		}
	}

	// Token: 0x06017477 RID: 95351 RVA: 0x006D7ED3 File Offset: 0x006D60D3
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementRelationship()
	{
	}

	// Token: 0x0400C530 RID: 50480
	[RequiredMember]
	public ERequirementTargetType RequireTargetType1;

	// Token: 0x0400C531 RID: 50481
	[RequiredMember]
	public ERequirementTargetType RequireTargetType2;

	// Token: 0x0400C532 RID: 50482
	[RequiredMember]
	public ERelation Relationship;
}
