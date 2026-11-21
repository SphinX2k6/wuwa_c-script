using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x020030B3 RID: 12467
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/E_SE_RootType.E_SE_RootType")]
	public enum E_SE_RootType : byte
	{
		// Token: 0x0400FD1B RID: 64795
		Fight,
		// Token: 0x0400FD1C RID: 64796
		Plot,
		// Token: 0x0400FD1D RID: 64797
		General,
		// Token: 0x0400FD1E RID: 64798
		CoverLoading,
		// Token: 0x0400FD1F RID: 64799
		E_SE_MAX
	}
}
