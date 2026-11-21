using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x02000878 RID: 2168
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class MonoStackFrame
	{
		// Token: 0x04001E0E RID: 7694
		internal int ilOffset;

		// Token: 0x04001E0F RID: 7695
		internal int nativeOffset;

		// Token: 0x04001E10 RID: 7696
		internal long methodAddress;

		// Token: 0x04001E11 RID: 7697
		internal uint methodIndex;

		// Token: 0x04001E12 RID: 7698
		internal MethodBase methodBase;

		// Token: 0x04001E13 RID: 7699
		internal string fileName;

		// Token: 0x04001E14 RID: 7700
		internal int lineNumber;

		// Token: 0x04001E15 RID: 7701
		internal int columnNumber;

		// Token: 0x04001E16 RID: 7702
		internal string internalMethodName;

		// Token: 0x04001E17 RID: 7703
		internal bool isLastFrameFromForeignException;
	}
}
