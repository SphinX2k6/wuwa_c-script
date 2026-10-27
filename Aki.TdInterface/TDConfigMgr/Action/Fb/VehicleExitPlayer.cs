using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C0 RID: 10688
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleExitPlayer : ActionParams
	{
		// Token: 0x0600EC53 RID: 60499 RVA: 0x00228403 File Offset: 0x00226603
		public static VehicleExitPlayer Create(IVehicleExitPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleExitPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A95 RID: 19093
		// (get) Token: 0x0600EC54 RID: 60500 RVA: 0x00228424 File Offset: 0x00226624
		public virtual bool? DestroyVehicle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DestroyVehicle);
			}
		}

		// Token: 0x17004A96 RID: 19094
		// (get) Token: 0x0600EC55 RID: 60501 RVA: 0x0022845A File Offset: 0x0022665A
		public virtual IExitVehicleType ExitType
		{
			get
			{
				if (this._ExitTypeInited)
				{
					return this._ExitTypeCache;
				}
				this._ExitTypeInited = true;
				this._ExitTypeCache = ActionReadHelper.ReadVehicleExitPlayer_ExitType(this.Instance);
				return this._ExitTypeCache;
			}
		}

		// Token: 0x0400821C RID: 33308
		private IVehicleExitPlayer Instance;

		// Token: 0x0400821D RID: 33309
		private IExitVehicleType _ExitTypeCache;

		// Token: 0x0400821E RID: 33310
		private bool _ExitTypeInited;
	}
}
