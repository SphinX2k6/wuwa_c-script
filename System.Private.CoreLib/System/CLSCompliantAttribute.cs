using System;

namespace System
{
	// Token: 0x020000E5 RID: 229
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public sealed class CLSCompliantAttribute : Attribute
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x000227CB File Offset: 0x000209CB
		public CLSCompliantAttribute(bool isCompliant)
		{
			this._compliant = isCompliant;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000227DA File Offset: 0x000209DA
		public bool IsCompliant
		{
			get
			{
				return this._compliant;
			}
		}

		// Token: 0x0400030C RID: 780
		private readonly bool _compliant;
	}
}
