using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002F1D RID: 12061
[RequiredMember]
public class RequirementRelationship : IRequirement
{
	// Token: 0x170023AD RID: 9133
	// (get) Token: 0x06019B6B RID: 105323 RVA: 0x006B1BB7 File Offset: 0x006AFDB7
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.Relationship;
		}
	}

	// Token: 0x06019B6C RID: 105324 RVA: 0x006B1BBB File Offset: 0x006AFDBB
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementRelationship()
	{
	}

	// Token: 0x0400C18E RID: 49550
	[RequiredMember]
	public ERequirementTargetType RequireTargetType1;

	// Token: 0x0400C18F RID: 49551
	[RequiredMember]
	public ERequirementTargetType RequireTargetType2;

	// Token: 0x0400C190 RID: 49552
	[RequiredMember]
	public ERelation Relationship;
}
