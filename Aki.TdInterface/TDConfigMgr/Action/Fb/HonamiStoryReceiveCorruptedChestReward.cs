using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D84 RID: 11652
	public class HonamiStoryReceiveCorruptedChestReward : ActionParams
	{
		// Token: 0x0600FE15 RID: 65045 RVA: 0x0024AA06 File Offset: 0x00248C06
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

		// Token: 0x17004FBB RID: 20411
		// (get) Token: 0x0600FE16 RID: 65046 RVA: 0x0024AA25 File Offset: 0x00248C25
		public virtual int Cost
		{
			get
			{
				return this.Instance.Cost;
			}
		}

		// Token: 0x17004FBC RID: 20412
		// (get) Token: 0x0600FE17 RID: 65047 RVA: 0x0024AA34 File Offset: 0x00248C34
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

		// Token: 0x17004FBD RID: 20413
		// (get) Token: 0x0600FE18 RID: 65048 RVA: 0x0024AA6A File Offset: 0x00248C6A
		[Nullable(2)]
		public virtual string ChangeSelfEntityStateAfterReceived
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ChangeSelfEntityStateAfterReceived;
			}
		}

		// Token: 0x04008AB6 RID: 35510
		private IHonamiStoryReceiveCorruptedChestReward Instance;
	}
}
