using System;

namespace CSharpScript.Game.Module.InstanceDungeon.ExchangeReward
{
	// Token: 0x020058B5 RID: 22709
	public class ExchangeShareData
	{
		// Token: 0x06039C03 RID: 236547 RVA: 0x00DB99B9 File Offset: 0x00DB7BB9
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x06039C04 RID: 236548 RVA: 0x00DB99C1 File Offset: 0x00DB7BC1
		public int GetCount()
		{
			return this.Count;
		}

		// Token: 0x06039C05 RID: 236549 RVA: 0x00DB99C9 File Offset: 0x00DB7BC9
		public void Phrase(int id, int count)
		{
			this.Id = id;
			this.Count = count;
		}

		// Token: 0x0401E284 RID: 123524
		private int Id;

		// Token: 0x0401E285 RID: 123525
		private int Count;
	}
}
