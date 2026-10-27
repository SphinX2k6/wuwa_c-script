using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B6D RID: 23405
	[RequiredMember]
	public class MediumItemGridCostComponentData
	{
		// Token: 0x0603B394 RID: 242580 RVA: 0x00E1ED7F File Offset: 0x00E1CF7F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumItemGridCostComponentData()
		{
		}

		// Token: 0x0401EE2C RID: 126508
		[RequiredMember]
		public int Cost;

		// Token: 0x0401EE2D RID: 126509
		[RequiredMember]
		public FColor Color;

		// Token: 0x0401EE2E RID: 126510
		[Nullable(2)]
		public string Text;

		// Token: 0x0401EE2F RID: 126511
		public int? BeforeCost;

		// Token: 0x0401EE30 RID: 126512
		public FColor? BeforeColor;
	}
}
