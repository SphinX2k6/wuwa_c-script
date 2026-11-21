using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A7F RID: 10879
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class SwitchSubLevelParams
{
	// Token: 0x0601B972 RID: 113010 RVA: 0x00880074 File Offset: 0x0087E274
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public SwitchSubLevelParams()
	{
	}

	// Token: 0x0400EE58 RID: 61016
	[Nullable(1)]
	[RequiredMember]
	public Dictionary<string, bool> LevelsWithVisible;

	// Token: 0x0400EE59 RID: 61017
	[Nullable(1)]
	[RequiredMember]
	public IList<string> UnloadLevels;

	// Token: 0x0400EE5A RID: 61018
	public EScreenEffectType ScreenEffect;

	// Token: 0x0400EE5B RID: 61019
	public Vector Location;

	// Token: 0x0400EE5C RID: 61020
	public Rotator Rotator;

	// Token: 0x0400EE5D RID: 61021
	public Action<bool> FinishCallback;

	// Token: 0x0400EE5E RID: 61022
	public Action BeforeWaitTeam;
}
