using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F4 RID: 10740
	public class IVehicleNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600ED89 RID: 60809 RVA: 0x0022EACE File Offset: 0x0022CCCE
		public static IVehicleNewSplineMoveTarget Create(IVehicleNewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleNewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x0600ED8A RID: 60810 RVA: 0x0022EAED File Offset: 0x0022CCED
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004650 RID: 18000
		// (get) Token: 0x0600ED8B RID: 60811 RVA: 0x0022EAFA File Offset: 0x0022CCFA
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this._TargetVehicleInited)
				{
					return this._TargetVehicleCache;
				}
				this._TargetVehicleInited = true;
				this._TargetVehicleCache = ActionReadHelper.ReadIVehicleNewSplineMoveTarget_TargetVehicle(this.Instance);
				return this._TargetVehicleCache;
			}
		}

		// Token: 0x17004651 RID: 18001
		// (get) Token: 0x0600ED8C RID: 60812 RVA: 0x0022EB2C File Offset: 0x0022CD2C
		public virtual bool? IsLookDir
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLookDir);
			}
		}

		// Token: 0x040082BC RID: 33468
		private IVehicleNewSplineMoveTarget Instance;

		// Token: 0x040082BD RID: 33469
		private ITargetVehicle _TargetVehicleCache;

		// Token: 0x040082BE RID: 33470
		private bool _TargetVehicleInited;
	}
}
