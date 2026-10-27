using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x02003AEA RID: 15082
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/E_SE_RootType.E_SE_RootType")]
	public enum E_SE_RootType : byte
	{
		// Token: 0x0400FD8E RID: 64910
		Fight,
		// Token: 0x0400FD8F RID: 64911
		Plot,
		// Token: 0x0400FD90 RID: 64912
		General,
		// Token: 0x0400FD91 RID: 64913
		CoverLoading,
		// Token: 0x0400FD92 RID: 64914
		E_SE_MAX
	}
}
