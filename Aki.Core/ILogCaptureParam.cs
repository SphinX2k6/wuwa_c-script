using System;
using System.Runtime.CompilerServices;

// Token: 0x02000039 RID: 57
[NullableContext(1)]
public interface ILogCaptureParam
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000149 RID: 329
	ELogLevel LogLevel { get; }

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600014A RID: 330
	TLogCaptureCallback Callback { get; }
}
