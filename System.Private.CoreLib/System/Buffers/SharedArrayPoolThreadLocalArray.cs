using System;

namespace System.Buffers
{
	// Token: 0x0200034C RID: 844
	internal struct SharedArrayPoolThreadLocalArray
	{
		// Token: 0x06003AD4 RID: 15060 RVA: 0x000C3DBD File Offset: 0x000C1FBD
		public SharedArrayPoolThreadLocalArray(Array array)
		{
			this.Array = array;
			this.MillisecondsTimeStamp = 0;
		}

		// Token: 0x04000C53 RID: 3155
		public Array Array;

		// Token: 0x04000C54 RID: 3156
		public int MillisecondsTimeStamp;
	}
}
