using System;
using System.Runtime.CompilerServices;

// Token: 0x02000039 RID: 57
[NullableContext(1)]
public interface ILogCaptureParam
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000147 RID: 327
	ELogLevel LogLevel { get; }

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000148 RID: 328
	TLogCaptureCallback Callback { get; }
}
