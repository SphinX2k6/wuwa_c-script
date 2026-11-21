using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02002A7E RID: 10878
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class SetSubLevelVisibleParams
{
	// Token: 0x0601B971 RID: 113009 RVA: 0x0088006C File Offset: 0x0087E26C
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public SetSubLevelVisibleParams()
	{
	}

	// Token: 0x0400EE53 RID: 61011
	[RequiredMember]
	public ClientPreEnableSubLevels ActionParams;

	// Token: 0x0400EE54 RID: 61012
	[RequiredMember]
	public GeneralContext Context;

	// Token: 0x0400EE55 RID: 61013
	public int ActionId;

	// Token: 0x0400EE56 RID: 61014
	public int GroupId;

	// Token: 0x0400EE57 RID: 61015
	[RequiredMember]
	public Action<bool> FinishCallback;
}
