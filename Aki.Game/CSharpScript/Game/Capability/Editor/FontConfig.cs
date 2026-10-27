using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability.Editor
{
	// Token: 0x020072A1 RID: 29345
	[RequiredMember]
	public class FontConfig
	{
		// Token: 0x06047FEE RID: 294894 RVA: 0x01271889 File Offset: 0x0126FA89
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public FontConfig()
		{
		}

		// Token: 0x04025EFE RID: 155390
		[RequiredMember]
		public int Size;

		// Token: 0x04025EFF RID: 155391
		[Nullable(1)]
		[RequiredMember]
		public string Typeface;

		// Token: 0x04025F00 RID: 155392
		[RequiredMember]
		public int LetterSpacing;

		// Token: 0x04025F01 RID: 155393
		[RequiredMember]
		public FLinearColor Color;
	}
}
