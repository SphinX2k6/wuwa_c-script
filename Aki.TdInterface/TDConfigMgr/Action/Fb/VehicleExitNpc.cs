using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CAE RID: 11438
	public class VehicleExitNpc : ActionParams
	{
		// Token: 0x0600FAEE RID: 64238 RVA: 0x00245E15 File Offset: 0x00244015
		public static VehicleExitNpc Create(IVehicleExitNpc? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleExitNpc
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E40 RID: 20032
		// (get) Token: 0x0600FAEF RID: 64239 RVA: 0x00245E34 File Offset: 0x00244034
		public virtual int TargetNpc
		{
			get
			{
				return this.Instance.TargetNpc;
			}
		}

		// Token: 0x17004E41 RID: 20033
		// (get) Token: 0x0600FAF0 RID: 64240 RVA: 0x00245E41 File Offset: 0x00244041
		public virtual IExitVehicleType ExitType
		{
			get
			{
				if (this._ExitTypeInited)
				{
					return this._ExitTypeCache;
				}
				this._ExitTypeInited = true;
				this._ExitTypeCache = ActionReadHelper.ReadVehicleExitNpc_ExitType(this.Instance);
				return this._ExitTypeCache;
			}
		}

		// Token: 0x04008910 RID: 35088
		private IVehicleExitNpc Instance;

		// Token: 0x04008911 RID: 35089
		private IExitVehicleType _ExitTypeCache;

		// Token: 0x04008912 RID: 35090
		private bool _ExitTypeInited;
	}
}
