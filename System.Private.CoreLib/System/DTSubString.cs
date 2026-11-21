using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200012B RID: 299
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct DTSubString
	{
		// Token: 0x170001D5 RID: 469
		internal unsafe char this[int relativeIndex]
		{
			get
			{
				return (char)(*this.s[this.index + relativeIndex]);
			}
		}

		// Token: 0x04000419 RID: 1049
		internal ReadOnlySpan<char> s;

		// Token: 0x0400041A RID: 1050
		internal int index;

		// Token: 0x0400041B RID: 1051
		internal int length;

		// Token: 0x0400041C RID: 1052
		internal DTSubStringType type;

		// Token: 0x0400041D RID: 1053
		internal int value;
	}
}
