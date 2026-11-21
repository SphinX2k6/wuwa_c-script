using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Bulitin.Utils;

namespace Aki.Common.Common
{
	// Token: 0x0200001D RID: 29
	[NullableContext(1)]
	public interface ILogFormattedPrint
	{
		// Token: 0x06000136 RID: 310
		string ToFormattedString();

		// Token: 0x06000137 RID: 311 RVA: 0x0000E9D2 File Offset: 0x0000CBD2
		void ToFormattedString(UnsafeStringBuilder sb)
		{
			sb.Append(this.ToFormattedString());
		}
	}
}
