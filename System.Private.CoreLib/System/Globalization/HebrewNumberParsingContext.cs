using System;

namespace System.Globalization
{
	// Token: 0x020002F2 RID: 754
	internal struct HebrewNumberParsingContext
	{
		// Token: 0x06003742 RID: 14146 RVA: 0x000B522E File Offset: 0x000B342E
		public HebrewNumberParsingContext(int result)
		{
			this.state = HebrewNumber.HS.Start;
			this.result = result;
		}

		// Token: 0x04000AAA RID: 2730
		internal HebrewNumber.HS state;

		// Token: 0x04000AAB RID: 2731
		internal int result;
	}
}
