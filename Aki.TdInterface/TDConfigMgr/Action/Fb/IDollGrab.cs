using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B12 RID: 11026
	public class IDollGrab : IUiGame
	{
		// Token: 0x0600F292 RID: 62098 RVA: 0x00236DF0 File Offset: 0x00234FF0
		public static IDollGrab Create(IDollGrab? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrab
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700491C RID: 18716
		// (get) Token: 0x0600F293 RID: 62099 RVA: 0x00236E0F File Offset: 0x0023500F
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700491D RID: 18717
		// (get) Token: 0x0600F294 RID: 62100 RVA: 0x00236E1C File Offset: 0x0023501C
		public virtual int TargetDollGrabMachineId
		{
			get
			{
				return this.Instance.TargetDollGrabMachineId;
			}
		}

		// Token: 0x04008522 RID: 34082
		private IDollGrab Instance;
	}
}
