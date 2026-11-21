using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FE RID: 10750
	public class INpcNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600EDB1 RID: 60849 RVA: 0x0022EE9B File Offset: 0x0022D09B
		public static INpcNewSplineStopTarget Create(INpcNewSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcNewSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004663 RID: 18019
		// (get) Token: 0x0600EDB2 RID: 60850 RVA: 0x0022EEBA File Offset: 0x0022D0BA
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x0600EDB3 RID: 60851 RVA: 0x0022EEC7 File Offset: 0x0022D0C7
		public virtual int NpcId
		{
			get
			{
				return this.Instance.NpcId;
			}
		}

		// Token: 0x040082CC RID: 33484
		private INpcNewSplineStopTarget Instance;
	}
}
