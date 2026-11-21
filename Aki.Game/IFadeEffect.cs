using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002000 RID: 8192
[NullableContext(2)]
public interface IFadeEffect
{
	// Token: 0x17001E84 RID: 7812
	// (get) Token: 0x060144C5 RID: 83141
	// (set) Token: 0x060144C6 RID: 83142
	EFadeInScreenShowType? FadeColor { get; set; }

	// Token: 0x17001E85 RID: 7813
	// (get) Token: 0x060144C7 RID: 83143
	// (set) Token: 0x060144C8 RID: 83144
	float? FadeInTime { get; set; }

	// Token: 0x17001E86 RID: 7814
	// (get) Token: 0x060144C9 RID: 83145
	// (set) Token: 0x060144CA RID: 83146
	float? FadeOutTime { get; set; }

	// Token: 0x17001E87 RID: 7815
	// (get) Token: 0x060144CB RID: 83147
	// (set) Token: 0x060144CC RID: 83148
	string ScreenEffect { get; set; }
}
