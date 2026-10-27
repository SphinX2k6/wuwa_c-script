using System;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000105 RID: 261
	public class CheckConditions
	{
		// Token: 0x0600087B RID: 2171 RVA: 0x0003E9AC File Offset: 0x0003CBAC
		public void ExpectChange(int num)
		{
			int num2 = 1 << num;
			if ((this.Expect & num2) > 0)
			{
				return;
			}
			this.Expect += 1 << num;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0003E9E0 File Offset: 0x0003CBE0
		public void ValueChange(int num)
		{
			int num2 = 1 << num;
			if ((this.Value & num2) > 0)
			{
				return;
			}
			this.Value += 1 << num;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0003EA13 File Offset: 0x0003CC13
		public bool Meet()
		{
			return this.Expect == this.Value;
		}

		// Token: 0x040004D5 RID: 1237
		private int Expect;

		// Token: 0x040004D6 RID: 1238
		private int Value;
	}
}
