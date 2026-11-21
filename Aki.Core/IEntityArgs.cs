using System;
using System.Runtime.CompilerServices;

// Token: 0x02000077 RID: 119
[NullableContext(1)]
public interface IEntityArgs
{
	// Token: 0x060003B8 RID: 952
	T GetP1<[Nullable(2)] T>();

	// Token: 0x060003B9 RID: 953
	T GetP2<[Nullable(2)] T>();

	// Token: 0x060003BA RID: 954
	T GetP3<[Nullable(2)] T>();

	// Token: 0x060003BB RID: 955
	T GetP4<[Nullable(2)] T>();

	// Token: 0x060003BC RID: 956
	T GetP5<[Nullable(2)] T>();
}
