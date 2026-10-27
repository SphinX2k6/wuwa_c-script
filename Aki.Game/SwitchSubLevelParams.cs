using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200350A RID: 13578
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class SwitchSubLevelParams
{
	// Token: 0x0601DC58 RID: 121944 RVA: 0x00857AA8 File Offset: 0x00855CA8
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public SwitchSubLevelParams()
	{
	}

	// Token: 0x0400E99D RID: 59805
	[Nullable(1)]
	[RequiredMember]
	public Dictionary<string, bool> LevelsWithVisible;

	// Token: 0x0400E99E RID: 59806
	[Nullable(1)]
	[RequiredMember]
	public IList<string> UnloadLevels;

	// Token: 0x0400E99F RID: 59807
	public EScreenEffectType ScreenEffect;

	// Token: 0x0400E9A0 RID: 59808
	public Vector Location;

	// Token: 0x0400E9A1 RID: 59809
	public Rotator Rotator;

	// Token: 0x0400E9A2 RID: 59810
	public Action<bool> FinishCallback;

	// Token: 0x0400E9A3 RID: 59811
	public Action BeforeWaitTeam;
}
