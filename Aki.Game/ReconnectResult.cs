using System;

// Token: 0x02002748 RID: 10056
public class ReconnectResult
{
	// Token: 0x06014A0F RID: 84495 RVA: 0x00538075 File Offset: 0x00536275
	public ReconnectResult(EReconnectResult result, EReconnectProcessStep step, int? errorCode = null, bool isPermittedSilentLogin = false)
	{
		this.Result = result;
		this.Step = step;
		this.ErrorCode = errorCode;
		this.IsPermittedSilentLogin = isPermittedSilentLogin;
	}

	// Token: 0x04009AF6 RID: 39670
	public EReconnectResult Result;

	// Token: 0x04009AF7 RID: 39671
	public EReconnectProcessStep Step = EReconnectProcessStep.Max;

	// Token: 0x04009AF8 RID: 39672
	public int? ErrorCode;

	// Token: 0x04009AF9 RID: 39673
	public bool IsPermittedSilentLogin;
}
