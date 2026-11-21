using System;

// Token: 0x02001562 RID: 5474
public enum ELoginConfig
{
	// Token: 0x04007A17 RID: 31255
	KcpConnectTimeoutMsPerTry = 3000,
	// Token: 0x04007A18 RID: 31256
	KcpConnectRetryCount = 1,
	// Token: 0x04007A19 RID: 31257
	ConnectGateWayRetryCount = 3,
	// Token: 0x04007A1A RID: 31258
	GetGameServerTokenTimeout = 13000,
	// Token: 0x04007A1B RID: 31259
	GetGlobalSdkTokenTimeout = 13000,
	// Token: 0x04007A1C RID: 31260
	ProtoKeyRequestTimeoutMs = 3000,
	// Token: 0x04007A1D RID: 31261
	CreateCharacterRequestTimeoutMs = 13000,
	// Token: 0x04007A1E RID: 31262
	EnterGameRequestTimeoutMs = 13000,
	// Token: 0x04007A1F RID: 31263
	LoginRequestTimeoutMs = 13000
}
