using System;
using System.Runtime.CompilerServices;

// Token: 0x0200300C RID: 12300
[NullableContext(1)]
[Nullable(0)]
public class FunctionRequestProxy<T> where T : class, IFunctionRequestHandle<T>
{
	// Token: 0x0601A0F4 RID: 106740 RVA: 0x006D4E58 File Offset: 0x006D3058
	public bool DecideCall(T request)
	{
		if (this.RequestLastTime == Time.Instance.Frame && this.PreFunctionRequestCache != null && this.PreFunctionRequestCache.CompareRequest(request))
		{
			return false;
		}
		this.PreFunctionRequestCache = request;
		this.RequestLastTime = Time.Instance.Frame;
		return true;
	}

	// Token: 0x0400C57E RID: 50558
	public int RequestLastTime;

	// Token: 0x0400C57F RID: 50559
	[Nullable(2)]
	public T PreFunctionRequestCache;
}
