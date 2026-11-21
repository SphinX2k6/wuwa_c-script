using System;
using System.Runtime.CompilerServices;

// Token: 0x02002562 RID: 9570
[NullableContext(1)]
[Nullable(0)]
public class FunctionRequestProxy<T> where T : class, IFunctionRequestHandle<T>
{
	// Token: 0x06017A3C RID: 96828 RVA: 0x006FCD60 File Offset: 0x006FAF60
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

	// Token: 0x0400C94B RID: 51531
	public int RequestLastTime;

	// Token: 0x0400C94C RID: 51532
	[Nullable(2)]
	public T PreFunctionRequestCache;
}
