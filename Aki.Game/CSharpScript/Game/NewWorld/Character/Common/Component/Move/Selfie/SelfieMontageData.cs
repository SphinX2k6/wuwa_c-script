using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie
{
	// Token: 0x020063B0 RID: 25520
	public class SelfieMontageData
	{
		// Token: 0x0603DE01 RID: 253441 RVA: 0x011F5039 File Offset: 0x011F3239
		[NullableContext(1)]
		public SelfieMontageData(SSelfieMontage row)
		{
			this.ConfigId = row.ConfigId;
			this.MontageType = row.MontageType;
			this.MontageRef = row.MontageRef;
		}

		// Token: 0x04020D9F RID: 134559
		public int ConfigId;

		// Token: 0x04020DA0 RID: 134560
		public ESelfieMontageType MontageType;

		// Token: 0x04020DA1 RID: 134561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TSoftObjectPtr<UAnimMontage> MontageRef;
	}
}
