using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie
{
	// Token: 0x02007101 RID: 28929
	[NullableContext(1)]
	[Nullable(0)]
	internal class SelfieMontageSlot
	{
		// Token: 0x06046A03 RID: 289283 RVA: 0x011C604A File Offset: 0x011C424A
		public void Clear()
		{
			this.ConfigId = 0;
			this.DataTablePath = "";
			this.Montage = null;
			this.AnimInstance = null;
		}

		// Token: 0x06046A04 RID: 289284 RVA: 0x011C606C File Offset: 0x011C426C
		public bool IsCurrent(int configId, string dtPath)
		{
			return this.ConfigId == configId && this.DataTablePath == dtPath;
		}

		// Token: 0x0402510D RID: 151821
		public int Token;

		// Token: 0x0402510E RID: 151822
		public int ConfigId;

		// Token: 0x0402510F RID: 151823
		public string DataTablePath = "";

		// Token: 0x04025110 RID: 151824
		[Nullable(2)]
		public UAnimMontage Montage;

		// Token: 0x04025111 RID: 151825
		[Nullable(2)]
		public UAnimInstance AnimInstance;
	}
}
