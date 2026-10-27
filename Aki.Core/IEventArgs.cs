using System;
using System.Runtime.CompilerServices;

// Token: 0x0200008D RID: 141
[NullableContext(1)]
public interface IEventArgs
{
	// Token: 0x0600045E RID: 1118
	bool Invoke(Enum name, Delegate handle);

	// Token: 0x0600045F RID: 1119
	bool Invoke(long name, Delegate handle);
}
