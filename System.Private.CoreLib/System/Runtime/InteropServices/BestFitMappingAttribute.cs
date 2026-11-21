using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005AB RID: 1451
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = false)]
	public sealed class BestFitMappingAttribute : Attribute
	{
		// Token: 0x06006FC0 RID: 28608 RVA: 0x0010D3D9 File Offset: 0x0010B5D9
		public BestFitMappingAttribute(bool BestFitMapping)
		{
			this.BestFitMapping = BestFitMapping;
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06006FC1 RID: 28609 RVA: 0x0010D3E8 File Offset: 0x0010B5E8
		public bool BestFitMapping { get; }

		// Token: 0x0400124C RID: 4684
		public bool ThrowOnUnmappableChar;
	}
}
