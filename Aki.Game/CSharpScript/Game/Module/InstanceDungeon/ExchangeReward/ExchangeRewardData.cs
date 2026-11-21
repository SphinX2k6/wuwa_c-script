using System;

namespace CSharpScript.Game.Module.InstanceDungeon.ExchangeReward
{
	// Token: 0x0200488C RID: 18572
	public class ExchangeRewardData
	{
		// Token: 0x0602EB22 RID: 191266 RVA: 0x00D088A9 File Offset: 0x00D06AA9
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x0602EB23 RID: 191267 RVA: 0x00D088B1 File Offset: 0x00D06AB1
		public int GetCount()
		{
			return this.Count;
		}

		// Token: 0x0602EB24 RID: 191268 RVA: 0x00D088B9 File Offset: 0x00D06AB9
		public void Phrase(int id, int count)
		{
			this.Id = id;
			this.Count = count;
		}

		// Token: 0x04018D1F RID: 101663
		private int Id;

		// Token: 0x04018D20 RID: 101664
		private int Count;
	}
}
