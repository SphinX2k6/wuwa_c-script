using System;
using System.Runtime.CompilerServices;

// Token: 0x0200008F RID: 143
[NullableContext(1)]
public interface IEventArgs
{
	// Token: 0x0600049F RID: 1183
	bool Invoke(Enum name, Delegate handle);

	// Token: 0x060004A0 RID: 1184
	bool Invoke(long name, Delegate handle);
}
