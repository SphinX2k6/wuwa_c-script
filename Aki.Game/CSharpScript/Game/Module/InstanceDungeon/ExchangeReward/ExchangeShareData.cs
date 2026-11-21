using System;

namespace CSharpScript.Game.Module.InstanceDungeon.ExchangeReward
{
	// Token: 0x0200488D RID: 18573
	public class ExchangeShareData
	{
		// Token: 0x0602EB26 RID: 191270 RVA: 0x00D088D1 File Offset: 0x00D06AD1
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x0602EB27 RID: 191271 RVA: 0x00D088D9 File Offset: 0x00D06AD9
		public int GetCount()
		{
			return this.Count;
		}

		// Token: 0x0602EB28 RID: 191272 RVA: 0x00D088E1 File Offset: 0x00D06AE1
		public void Phrase(int id, int count)
		{
			this.Id = id;
			this.Count = count;
		}

		// Token: 0x04018D21 RID: 101665
		private int Id;

		// Token: 0x04018D22 RID: 101666
		private int Count;
	}
}
