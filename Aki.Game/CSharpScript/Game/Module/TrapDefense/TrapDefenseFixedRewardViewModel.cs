using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A86 RID: 19078
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseFixedRewardViewModel
	{
		// Token: 0x0603174A RID: 202570 RVA: 0x00B7670C File Offset: 0x00B7490C
		public static TrapDefenseFixedRewardViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseFixedRewardViewModel
			{
				Model = model
			};
		}

		// Token: 0x0603174B RID: 202571 RVA: 0x00B7671A File Offset: 0x00B7491A
		private TrapDefenseFixedRewardViewModel()
		{
		}

		// Token: 0x0603174C RID: 202572 RVA: 0x00B76722 File Offset: 0x00B74922
		public void OnViewClose()
		{
		}

		// Token: 0x0603174D RID: 202573 RVA: 0x00B76724 File Offset: 0x00B74924
		public List<TrapDefenseRewardItemData> GetFixedRewardDataList()
		{
			this.Model.RewardData.SortFixedRewardList();
			return this.Model.RewardData.FixedRewardDataList;
		}

		// Token: 0x0401A724 RID: 108324
		public TrapDefenseModel Model;
	}
}
