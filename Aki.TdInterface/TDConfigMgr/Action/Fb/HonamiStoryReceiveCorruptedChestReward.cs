using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A90 RID: 10896
	[NullableContext(2)]
	[Nullable(0)]
	public class HonamiStoryReceiveCorruptedChestReward : ActionParams
	{
		// Token: 0x0600EF5F RID: 61279 RVA: 0x0022CCFA File Offset: 0x0022AEFA
		[NullableContext(1)]
		public static HonamiStoryReceiveCorruptedChestReward Create(IHonamiStoryReceiveCorruptedChestReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryReceiveCorruptedChestReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x0600EF60 RID: 61280 RVA: 0x0022CD19 File Offset: 0x0022AF19
		public virtual int Cost
		{
			get
			{
				return this.Instance.Cost;
			}
		}

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x0600EF61 RID: 61281 RVA: 0x0022CD28 File Offset: 0x0022AF28
		public virtual int? CostGroup
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.CostGroup);
			}
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x0600EF62 RID: 61282 RVA: 0x0022CD5E File Offset: 0x0022AF5E
		public virtual string ChangeSelfEntityStateAfterReceived
		{
			get
			{
				return this.Instance.ChangeSelfEntityStateAfterReceived;
			}
		}

		// Token: 0x040083B2 RID: 33714
		private IHonamiStoryReceiveCorruptedChestReward Instance;
	}
}
