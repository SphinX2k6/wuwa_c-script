using System;

namespace System.Reflection
{
	// Token: 0x02000724 RID: 1828
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDelaySignAttribute : Attribute
	{
		// Token: 0x06007866 RID: 30822 RVA: 0x0011E705 File Offset: 0x0011C905
		public AssemblyDelaySignAttribute(bool delaySign)
		{
			this.DelaySign = delaySign;
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06007867 RID: 30823 RVA: 0x0011E714 File Offset: 0x0011C914
		public bool DelaySign { get; }
	}
}
