using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Bulitin.Utils;

namespace Aki.Common.Common
{
	// Token: 0x0200001C RID: 28
	[NullableContext(1)]
	public interface ILogFormattedPrint
	{
		// Token: 0x060000C9 RID: 201
		string ToFormattedString();

		// Token: 0x060000CA RID: 202 RVA: 0x0000B206 File Offset: 0x00009406
		void ToFormattedString(UnsafeStringBuilder sb)
		{
			sb.Append(this.ToFormattedString());
		}
	}
}
