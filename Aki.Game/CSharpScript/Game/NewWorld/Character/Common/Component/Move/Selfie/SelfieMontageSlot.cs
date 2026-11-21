using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie
{
	// Token: 0x020063B1 RID: 25521
	[NullableContext(1)]
	[Nullable(0)]
	internal class SelfieMontageSlot
	{
		// Token: 0x0603DE02 RID: 253442 RVA: 0x011F506A File Offset: 0x011F326A
		public void Clear()
		{
			this.ConfigId = 0;
			this.DataTablePath = "";
			this.Montage = null;
			this.AnimInstance = null;
		}

		// Token: 0x0603DE03 RID: 253443 RVA: 0x011F508C File Offset: 0x011F328C
		public bool IsCurrent(int configId, string dtPath)
		{
			return this.ConfigId == configId && this.DataTablePath == dtPath;
		}

		// Token: 0x04020DA2 RID: 134562
		public int Token;

		// Token: 0x04020DA3 RID: 134563
		public int ConfigId;

		// Token: 0x04020DA4 RID: 134564
		public string DataTablePath = "";

		// Token: 0x04020DA5 RID: 134565
		[Nullable(2)]
		public UAnimMontage Montage;

		// Token: 0x04020DA6 RID: 134566
		[Nullable(2)]
		public UAnimInstance AnimInstance;
	}
}
