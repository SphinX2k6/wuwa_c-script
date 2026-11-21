using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002927 RID: 10535
	public class IDeliverItemProbeCollectibleViewStyle
	{
		// Token: 0x0600EA1A RID: 59930 RVA: 0x00228CA1 File Offset: 0x00226EA1
		public static IDeliverItemProbeCollectibleViewStyle Create(IDeliverItemProbeCollectibleViewStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectibleViewStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700447A RID: 17530
		// (get) Token: 0x0600EA1B RID: 59931 RVA: 0x00228CC0 File Offset: 0x00226EC0
		public virtual EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				return (EDeliverItemProbeCollectibleViewStyle)this.Instance.Type;
			}
		}

		// Token: 0x04008109 RID: 33033
		private IDeliverItemProbeCollectibleViewStyle Instance;
	}
}
