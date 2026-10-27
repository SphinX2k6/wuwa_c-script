using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068C8 RID: 26824
	public class CoopSpRewardData
	{
		// Token: 0x170097D4 RID: 38868
		// (get) Token: 0x06042F38 RID: 274232 RVA: 0x0104E2AC File Offset: 0x0104C4AC
		public CoopSpReward? GetConfig
		{
			get
			{
				return CoopConfig.Instance.GetCoopSpRewardConfigById(this.Id);
			}
		}

		// Token: 0x06042F39 RID: 274233 RVA: 0x0104E2BE File Offset: 0x0104C4BE
		public CoopSpRewardData(int id, ECoopSpRewardState state)
		{
			this.Id = id;
			this.State = state;
		}

		// Token: 0x06042F3A RID: 274234 RVA: 0x0104E2D4 File Offset: 0x0104C4D4
		public void SetState(ECoopSpRewardState state)
		{
			this.State = state;
		}

		// Token: 0x04022D30 RID: 142640
		public int Id;

		// Token: 0x04022D31 RID: 142641
		public ECoopSpRewardState State;
	}
}
