using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02003509 RID: 13577
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class SetSubLevelVisibleParams
{
	// Token: 0x0601DC57 RID: 121943 RVA: 0x00857AA0 File Offset: 0x00855CA0
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public SetSubLevelVisibleParams()
	{
	}

	// Token: 0x0400E998 RID: 59800
	[RequiredMember]
	public ClientPreEnableSubLevels ActionParams;

	// Token: 0x0400E999 RID: 59801
	[RequiredMember]
	public GeneralContext Context;

	// Token: 0x0400E99A RID: 59802
	public int ActionId;

	// Token: 0x0400E99B RID: 59803
	public int GroupId;

	// Token: 0x0400E99C RID: 59804
	[RequiredMember]
	public Action<bool> FinishCallback;
}
