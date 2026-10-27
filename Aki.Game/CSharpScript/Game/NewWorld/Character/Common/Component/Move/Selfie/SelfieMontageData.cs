using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie
{
	// Token: 0x02007100 RID: 28928
	public class SelfieMontageData
	{
		// Token: 0x06046A02 RID: 289282 RVA: 0x011C6019 File Offset: 0x011C4219
		[NullableContext(1)]
		public SelfieMontageData(SSelfieMontage row)
		{
			this.ConfigId = row.ConfigId;
			this.MontageType = row.MontageType;
			this.MontageRef = row.MontageRef;
		}

		// Token: 0x0402510A RID: 151818
		public int ConfigId;

		// Token: 0x0402510B RID: 151819
		public ESelfieMontageType MontageType;

		// Token: 0x0402510C RID: 151820
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TSoftObjectPtr<UAnimMontage> MontageRef;
	}
}
