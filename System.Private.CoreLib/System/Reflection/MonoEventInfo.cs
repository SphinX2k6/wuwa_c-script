using System;

namespace System.Reflection
{
	// Token: 0x02000706 RID: 1798
	internal struct MonoEventInfo
	{
		// Token: 0x04001575 RID: 5493
		public Type declaring_type;

		// Token: 0x04001576 RID: 5494
		public Type reflected_type;

		// Token: 0x04001577 RID: 5495
		public string name;

		// Token: 0x04001578 RID: 5496
		public MethodInfo add_method;

		// Token: 0x04001579 RID: 5497
		public MethodInfo remove_method;

		// Token: 0x0400157A RID: 5498
		public MethodInfo raise_method;

		// Token: 0x0400157B RID: 5499
		public EventAttributes attrs;

		// Token: 0x0400157C RID: 5500
		public MethodInfo[] other_methods;
	}
}
