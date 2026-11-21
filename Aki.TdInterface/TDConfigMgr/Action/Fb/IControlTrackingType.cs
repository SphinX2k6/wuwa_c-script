using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A38 RID: 10808
	public class IControlTrackingType
	{
		// Token: 0x0600EECC RID: 61132 RVA: 0x0023027D File Offset: 0x0022E47D
		public static IControlTrackingType Create(IControlTrackingType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700470A RID: 18186
		// (get) Token: 0x0600EECD RID: 61133 RVA: 0x0023029C File Offset: 0x0022E49C
		public virtual EControlTrackingType Type
		{
			get
			{
				return (EControlTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x04008320 RID: 33568
		private IControlTrackingType Instance;
	}
}
