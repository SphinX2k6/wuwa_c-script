using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B74 RID: 11124
	public class ISeasonLoopConfig
	{
		// Token: 0x0600F465 RID: 62565 RVA: 0x0023A387 File Offset: 0x00238587
		public static ISeasonLoopConfig Create(ISeasonLoopConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISeasonLoopConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x0600F466 RID: 62566 RVA: 0x0023A3A6 File Offset: 0x002385A6
		public virtual float HoldTime
		{
			get
			{
				return this.Instance.HoldTime;
			}
		}

		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x0600F467 RID: 62567 RVA: 0x0023A3B3 File Offset: 0x002385B3
		public virtual float SwitchTime
		{
			get
			{
				return this.Instance.SwitchTime;
			}
		}

		// Token: 0x04008604 RID: 34308
		private ISeasonLoopConfig Instance;
	}
}
