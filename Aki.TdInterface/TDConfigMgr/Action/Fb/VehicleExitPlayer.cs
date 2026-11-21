using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CAD RID: 11437
	public class VehicleExitPlayer : ActionParams
	{
		// Token: 0x0600FAEA RID: 64234 RVA: 0x00245D87 File Offset: 0x00243F87
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

		// Token: 0x17004E3E RID: 20030
		// (get) Token: 0x0600FAEB RID: 64235 RVA: 0x00245DA8 File Offset: 0x00243FA8
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

		// Token: 0x17004E3F RID: 20031
		// (get) Token: 0x0600FAEC RID: 64236 RVA: 0x00245DDE File Offset: 0x00243FDE
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

		// Token: 0x0400890D RID: 35085
		private IVehicleExitPlayer Instance;

		// Token: 0x0400890E RID: 35086
		private IExitVehicleType _ExitTypeCache;

		// Token: 0x0400890F RID: 35087
		private bool _ExitTypeInited;
	}
}
