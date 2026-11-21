using System;
using System.Runtime.CompilerServices;

// Token: 0x020000B1 RID: 177
[NullableContext(1)]
[Nullable(0)]
public class HttpResponseData
{
	// Token: 0x06000588 RID: 1416 RVA: 0x0001C965 File Offset: 0x0001AB65
	public HttpResponseData(bool Success, int Code, string Data)
	{
		this.Success = Success;
		this.Code = Code;
		this.Data = Data;
	}

	// Token: 0x0400046D RID: 1133
	public readonly bool Success;

	// Token: 0x0400046E RID: 1134
	public readonly int Code;

	// Token: 0x0400046F RID: 1135
	public readonly string Data;
}
