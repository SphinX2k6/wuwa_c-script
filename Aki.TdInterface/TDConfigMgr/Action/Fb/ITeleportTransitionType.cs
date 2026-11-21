using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002950 RID: 10576
	public class ITeleportTransitionType
	{
		// Token: 0x0600EAD1 RID: 60113 RVA: 0x0022A111 File Offset: 0x00228311
		public static ITeleportTransitionType Create(ITeleportTransitionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x0600EAD2 RID: 60114 RVA: 0x0022A130 File Offset: 0x00228330
		public virtual ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x04008160 RID: 33120
		private ITeleportTransitionType Instance;
	}
}
