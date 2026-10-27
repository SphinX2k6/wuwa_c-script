using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002769 RID: 10089
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableNearbyTracking : ActionParams
	{
		// Token: 0x0600E0B8 RID: 57528 RVA: 0x002135EC File Offset: 0x002117EC
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

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x0600E0B9 RID: 57529 RVA: 0x0021360B File Offset: 0x0021180B
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x170043A9 RID: 17321
		// (get) Token: 0x0600E0BA RID: 57530 RVA: 0x00213618 File Offset: 0x00211818
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

		// Token: 0x04007C6F RID: 31855
		private IEnableNearbyTracking Instance;

		// Token: 0x04007C70 RID: 31856
		private IControlTrackingType _ControlTypeCache;

		// Token: 0x04007C71 RID: 31857
		private bool _ControlTypeInited;
	}
}
