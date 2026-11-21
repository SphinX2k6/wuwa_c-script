using System;

namespace Sharphereal.AOTRedirector.Attributes
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class RRIDAttribute : Attribute
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000028B1 File Offset: 0x00000AB1
		public RRIDAttribute(int RRID)
		{
			this.RRID = RRID;
		}

		// Token: 0x0400001C RID: 28
		private int RRID;
	}
}
