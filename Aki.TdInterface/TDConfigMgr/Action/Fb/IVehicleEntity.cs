using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BE RID: 10174
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleEntity : ITargetEntityType
	{
		// Token: 0x0600E250 RID: 57936 RVA: 0x00216DD2 File Offset: 0x00214FD2
		public static IVehicleEntity Create(IVehicleEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004496 RID: 17558
		// (get) Token: 0x0600E251 RID: 57937 RVA: 0x00216DF1 File Offset: 0x00214FF1
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004497 RID: 17559
		// (get) Token: 0x0600E252 RID: 57938 RVA: 0x00216DFE File Offset: 0x00214FFE
		public virtual ITargetVehicle Vehicle
		{
			get
			{
				if (this._VehicleInited)
				{
					return this._VehicleCache;
				}
				this._VehicleInited = true;
				this._VehicleCache = ActionReadHelper.ReadIVehicleEntity_Vehicle(this.Instance);
				return this._VehicleCache;
			}
		}

		// Token: 0x04007D7E RID: 32126
		private IVehicleEntity Instance;

		// Token: 0x04007D7F RID: 32127
		private ITargetVehicle _VehicleCache;

		// Token: 0x04007D80 RID: 32128
		private bool _VehicleInited;
	}
}
