using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007BB RID: 1979
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class UnmanagedMarshal
	{
		// Token: 0x06007F69 RID: 32617 RVA: 0x0012D7B6 File Offset: 0x0012B9B6
		private UnmanagedMarshal(UnmanagedType maint, int cnt)
		{
			this.count = cnt;
			this.t = maint;
			this.tbase = maint;
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x0012D7D3 File Offset: 0x0012B9D3
		private UnmanagedMarshal(UnmanagedType maint, UnmanagedType elemt)
		{
			this.count = 0;
			this.t = maint;
			this.tbase = elemt;
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x0012D7F0 File Offset: 0x0012B9F0
		public static UnmanagedMarshal DefineByValArray(int elemCount)
		{
			return new UnmanagedMarshal(UnmanagedType.ByValArray, elemCount);
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x0012D7FA File Offset: 0x0012B9FA
		public static UnmanagedMarshal DefineByValTStr(int elemCount)
		{
			return new UnmanagedMarshal(UnmanagedType.ByValTStr, elemCount);
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x0012D804 File Offset: 0x0012BA04
		public static UnmanagedMarshal DefineLPArray(UnmanagedType elemType)
		{
			return new UnmanagedMarshal(UnmanagedType.LPArray, elemType);
		}

		// Token: 0x06007F6E RID: 32622 RVA: 0x0012D80E File Offset: 0x0012BA0E
		public static UnmanagedMarshal DefineUnmanagedMarshal(UnmanagedType unmanagedType)
		{
			return new UnmanagedMarshal(unmanagedType, unmanagedType);
		}

		// Token: 0x06007F6F RID: 32623 RVA: 0x0012D817 File Offset: 0x0012BA17
		internal static UnmanagedMarshal DefineLPArrayInternal(UnmanagedType elemType, int sizeConst, int sizeParamIndex)
		{
			return new UnmanagedMarshal(UnmanagedType.LPArray, elemType)
			{
				count = sizeConst,
				param_num = sizeParamIndex,
				has_size = true
			};
		}

		// Token: 0x0400189A RID: 6298
		private int count;

		// Token: 0x0400189B RID: 6299
		private UnmanagedType t;

		// Token: 0x0400189C RID: 6300
		private UnmanagedType tbase;

		// Token: 0x0400189D RID: 6301
		private string guid;

		// Token: 0x0400189E RID: 6302
		private string mcookie;

		// Token: 0x0400189F RID: 6303
		private string marshaltype;

		// Token: 0x040018A0 RID: 6304
		internal Type marshaltyperef;

		// Token: 0x040018A1 RID: 6305
		private int param_num;

		// Token: 0x040018A2 RID: 6306
		private bool has_size;
	}
}
