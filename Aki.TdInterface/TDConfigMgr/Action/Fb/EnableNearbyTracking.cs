using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3B RID: 10811
	public class EnableNearbyTracking : ActionParams
	{
		// Token: 0x0600EED6 RID: 61142 RVA: 0x00230380 File Offset: 0x0022E580
		public static EnableNearbyTracking Create(IEnableNearbyTracking? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableNearbyTracking
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700470E RID: 18190
		// (get) Token: 0x0600EED7 RID: 61143 RVA: 0x0023039F File Offset: 0x0022E59F
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x1700470F RID: 18191
		// (get) Token: 0x0600EED8 RID: 61144 RVA: 0x002303AC File Offset: 0x0022E5AC
		public virtual IControlTrackingType ControlType
		{
			get
			{
				if (this._ControlTypeInited)
				{
					return this._ControlTypeCache;
				}
				this._ControlTypeInited = true;
				this._ControlTypeCache = ActionReadHelper.ReadEnableNearbyTracking_ControlType(this.Instance);
				return this._ControlTypeCache;
			}
		}

		// Token: 0x04008325 RID: 33573
		private IEnableNearbyTracking Instance;

		// Token: 0x04008326 RID: 33574
		private IControlTrackingType _ControlTypeCache;

		// Token: 0x04008327 RID: 33575
		private bool _ControlTypeInited;
	}
}
