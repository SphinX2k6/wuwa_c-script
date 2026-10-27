using System;

namespace CSharpScript.Game.Module.InstanceDungeon.ExchangeReward
{
	// Token: 0x020058B4 RID: 22708
	public class ExchangeRewardData
	{
		// Token: 0x06039BFF RID: 236543 RVA: 0x00DB9991 File Offset: 0x00DB7B91
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x06039C00 RID: 236544 RVA: 0x00DB9999 File Offset: 0x00DB7B99
		public int GetCount()
		{
			return this.Count;
		}

		// Token: 0x06039C01 RID: 236545 RVA: 0x00DB99A1 File Offset: 0x00DB7BA1
		public void Phrase(int id, int count)
		{
			this.Id = id;
			this.Count = count;
		}

		// Token: 0x0401E282 RID: 123522
		private int Id;

		// Token: 0x0401E283 RID: 123523
		private int Count;
	}
}
