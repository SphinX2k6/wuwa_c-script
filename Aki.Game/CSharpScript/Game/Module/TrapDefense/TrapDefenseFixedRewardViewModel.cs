using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A2E RID: 14894
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseFixedRewardViewModel
	{
		// Token: 0x060264DA RID: 156890 RVA: 0x00ABA6C0 File Offset: 0x00AB88C0
		public static TrapDefenseFixedRewardViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseFixedRewardViewModel
			{
				Model = model
			};
		}

		// Token: 0x060264DB RID: 156891 RVA: 0x00ABA6CE File Offset: 0x00AB88CE
		private TrapDefenseFixedRewardViewModel()
		{
		}

		// Token: 0x060264DC RID: 156892 RVA: 0x00ABA6D6 File Offset: 0x00AB88D6
		public void OnViewClose()
		{
		}

		// Token: 0x060264DD RID: 156893 RVA: 0x00ABA6D8 File Offset: 0x00AB88D8
		public List<TrapDefenseRewardItemData> GetFixedRewardDataList()
		{
			this.Model.RewardData.SortFixedRewardList();
			return this.Model.RewardData.FixedRewardDataList;
		}

		// Token: 0x04015076 RID: 86134
		public TrapDefenseModel Model;
	}
}
