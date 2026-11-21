using System;

namespace System.Reflection
{
	// Token: 0x02000713 RID: 1811
	internal struct MonoPropertyInfo
	{
		// Token: 0x040015C1 RID: 5569
		public Type parent;

		// Token: 0x040015C2 RID: 5570
		public Type declaring_type;

		// Token: 0x040015C3 RID: 5571
		public string name;

		// Token: 0x040015C4 RID: 5572
		public MethodInfo get_method;

		// Token: 0x040015C5 RID: 5573
		public MethodInfo set_method;

		// Token: 0x040015C6 RID: 5574
		public PropertyAttributes attrs;
	}
}
