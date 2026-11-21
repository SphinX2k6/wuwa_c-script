using System;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000109 RID: 265
	public class CheckConditions
	{
		// Token: 0x060008AF RID: 2223 RVA: 0x00040D4C File Offset: 0x0003EF4C
		public void ExpectChange(int num)
		{
			int num2 = 1 << num;
			if ((this.Expect & num2) > 0)
			{
				return;
			}
			this.Expect += 1 << num;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00040D80 File Offset: 0x0003EF80
		public void ValueChange(int num)
		{
			int num2 = 1 << num;
			if ((this.Value & num2) > 0)
			{
				return;
			}
			this.Value += 1 << num;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00040DB3 File Offset: 0x0003EFB3
		public bool Meet()
		{
			return this.Expect == this.Value;
		}

		// Token: 0x04000510 RID: 1296
		private int Expect;

		// Token: 0x04000511 RID: 1297
		private int Value;
	}
}
