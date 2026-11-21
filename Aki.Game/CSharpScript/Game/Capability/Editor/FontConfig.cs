using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability.Editor
{
	// Token: 0x02006420 RID: 25632
	[RequiredMember]
	public class FontConfig
	{
		// Token: 0x0603E3B7 RID: 254903 RVA: 0x0121281D File Offset: 0x01210A1D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public FontConfig()
		{
		}

		// Token: 0x040211D1 RID: 135633
		[RequiredMember]
		public int Size;

		// Token: 0x040211D2 RID: 135634
		[Nullable(1)]
		[RequiredMember]
		public string Typeface;

		// Token: 0x040211D3 RID: 135635
		[RequiredMember]
		public int LetterSpacing;

		// Token: 0x040211D4 RID: 135636
		[RequiredMember]
		public FLinearColor Color;
	}
}
