using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001640 RID: 5696
	public enum ClientStepState
	{
		// Token: 0x0400C0AA RID: 49322
		[OriginalName("NoStep")]
		NoStep,
		// Token: 0x0400C0AB RID: 49323
		[OriginalName("SpecialEffect")]
		SpecialEffect,
		// Token: 0x0400C0AC RID: 49324
		[OriginalName("EventPloting")]
		EventPloting
	}
}
