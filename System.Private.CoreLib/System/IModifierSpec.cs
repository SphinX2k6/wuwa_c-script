using System;
using System.Text;

namespace System
{
	// Token: 0x020000A8 RID: 168
	internal interface IModifierSpec
	{
		// Token: 0x060008B3 RID: 2227
		Type Resolve(Type type);

		// Token: 0x060008B4 RID: 2228
		StringBuilder Append(StringBuilder sb);
	}
}
