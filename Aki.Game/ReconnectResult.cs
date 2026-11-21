using System;

// Token: 0x02001C33 RID: 7219
public class ReconnectResult
{
	// Token: 0x06011EF1 RID: 73457 RVA: 0x00546E49 File Offset: 0x00545049
	public ReconnectResult(EReconnectResult result, EReconnectProcessStep step, int? errorCode = null, bool isPermittedSilentLogin = false)
	{
		this.Result = result;
		this.Step = step;
		this.ErrorCode = errorCode;
		this.IsPermittedSilentLogin = isPermittedSilentLogin;
	}

	// Token: 0x04009C4E RID: 40014
	public EReconnectResult Result;

	// Token: 0x04009C4F RID: 40015
	public EReconnectProcessStep Step = EReconnectProcessStep.Max;

	// Token: 0x04009C50 RID: 40016
	public int? ErrorCode;

	// Token: 0x04009C51 RID: 40017
	public bool IsPermittedSilentLogin;
}
