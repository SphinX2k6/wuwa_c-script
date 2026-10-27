using System;

// Token: 0x0200274C RID: 10060
public enum EReconnectProcessStep
{
	// Token: 0x04009B02 RID: 39682
	ConvGate,
	// Token: 0x04009B03 RID: 39683
	ConvRet,
	// Token: 0x04009B04 RID: 39684
	ProtoKeyReq,
	// Token: 0x04009B05 RID: 39685
	ProtoKeyRet,
	// Token: 0x04009B06 RID: 39686
	ReconvReq,
	// Token: 0x04009B07 RID: 39687
	ReconvRet,
	// Token: 0x04009B08 RID: 39688
	ReconvCancel,
	// Token: 0x04009B09 RID: 39689
	ReconvSuccess,
	// Token: 0x04009B0A RID: 39690
	ReconvFail,
	// Token: 0x04009B0B RID: 39691
	Max
}
