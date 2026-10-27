using System;
using System.Runtime.CompilerServices;

// Token: 0x02000076 RID: 118
[NullableContext(1)]
public interface IEntityArgs
{
	// Token: 0x0600037F RID: 895
	T GetP1<[Nullable(2)] T>();

	// Token: 0x06000380 RID: 896
	T GetP2<[Nullable(2)] T>();

	// Token: 0x06000381 RID: 897
	T GetP3<[Nullable(2)] T>();

	// Token: 0x06000382 RID: 898
	T GetP4<[Nullable(2)] T>();

	// Token: 0x06000383 RID: 899
	T GetP5<[Nullable(2)] T>();
}
