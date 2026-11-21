using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B4C RID: 19276
	[RequiredMember]
	public class MediumItemGridCostComponentData
	{
		// Token: 0x060302E0 RID: 197344 RVA: 0x00D6F2EB File Offset: 0x00D6D4EB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumItemGridCostComponentData()
		{
		}

		// Token: 0x040198DB RID: 104667
		[RequiredMember]
		public int Cost;

		// Token: 0x040198DC RID: 104668
		[RequiredMember]
		public FColor Color;

		// Token: 0x040198DD RID: 104669
		[Nullable(2)]
		public string Text;

		// Token: 0x040198DE RID: 104670
		public int? BeforeCost;

		// Token: 0x040198DF RID: 104671
		public FColor? BeforeColor;
	}
}
