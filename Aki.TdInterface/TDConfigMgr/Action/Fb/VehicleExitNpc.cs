using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C1 RID: 10689
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleExitNpc : ActionParams
	{
		// Token: 0x0600EC57 RID: 60503 RVA: 0x00228491 File Offset: 0x00226691
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

		// Token: 0x17004A97 RID: 19095
		// (get) Token: 0x0600EC58 RID: 60504 RVA: 0x002284B0 File Offset: 0x002266B0
		public virtual int TargetNpc
		{
			get
			{
				return this.Instance.TargetNpc;
			}
		}

		// Token: 0x17004A98 RID: 19096
		// (get) Token: 0x0600EC59 RID: 60505 RVA: 0x002284BD File Offset: 0x002266BD
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

		// Token: 0x0400821F RID: 33311
		private IVehicleExitNpc Instance;

		// Token: 0x04008220 RID: 33312
		private IExitVehicleType _ExitTypeCache;

		// Token: 0x04008221 RID: 33313
		private bool _ExitTypeInited;
	}
}
