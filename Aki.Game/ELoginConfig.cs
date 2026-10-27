using System;

// Token: 0x0200208F RID: 8335
public enum ELoginConfig
{
	// Token: 0x0400792E RID: 31022
	KcpConnectTimeoutMsPerTry = 3000,
	// Token: 0x0400792F RID: 31023
	KcpConnectRetryCount = 1,
	// Token: 0x04007930 RID: 31024
	ConnectGateWayRetryCount = 3,
	// Token: 0x04007931 RID: 31025
	GetGameServerTokenTimeout = 13000,
	// Token: 0x04007932 RID: 31026
	GetGlobalSdkTokenTimeout = 13000,
	// Token: 0x04007933 RID: 31027
	ProtoKeyRequestTimeoutMs = 3000,
	// Token: 0x04007934 RID: 31028
	CreateCharacterRequestTimeoutMs = 13000,
	// Token: 0x04007935 RID: 31029
	EnterGameRequestTimeoutMs = 13000,
	// Token: 0x04007936 RID: 31030
	LoginRequestTimeoutMs = 13000
}
