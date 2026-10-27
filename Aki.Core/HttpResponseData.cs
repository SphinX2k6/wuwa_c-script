using System;
using System.Runtime.CompilerServices;

// Token: 0x020000AF RID: 175
[NullableContext(1)]
[Nullable(0)]
public class HttpResponseData
{
	// Token: 0x06000547 RID: 1351 RVA: 0x0001C27D File Offset: 0x0001A47D
	public HttpResponseData(bool Success, int Code, string Data)
	{
		this.Success = Success;
		this.Code = Code;
		this.Data = Data;
	}

	// Token: 0x0400045F RID: 1119
	public readonly bool Success;

	// Token: 0x04000460 RID: 1120
	public readonly int Code;

	// Token: 0x04000461 RID: 1121
	public readonly string Data;
}
