using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005818 RID: 22552
	public class CoopSpRewardData
	{
		// Token: 0x17006B14 RID: 27412
		// (get) Token: 0x06037A90 RID: 227984 RVA: 0x00F8F8D4 File Offset: 0x00F8DAD4
		public CoopSpReward? GetConfig
		{
			get
			{
				return CoopConfig.Instance.GetCoopSpRewardConfigById(this.Id);
			}
		}

		// Token: 0x06037A91 RID: 227985 RVA: 0x00F8F8E6 File Offset: 0x00F8DAE6
		public CoopSpRewardData(int id, ECoopSpRewardState state)
		{
			this.Id = id;
			this.State = state;
		}

		// Token: 0x06037A92 RID: 227986 RVA: 0x00F8F8FC File Offset: 0x00F8DAFC
		public void SetState(ECoopSpRewardState state)
		{
			this.State = state;
		}

		// Token: 0x0401D58C RID: 120204
		public int Id;

		// Token: 0x0401D58D RID: 120205
		public ECoopSpRewardState State;
	}
}
