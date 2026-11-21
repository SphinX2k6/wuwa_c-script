using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3D RID: 3645
	public class IVehicleMontagePlayConfig
	{
		// Token: 0x06005289 RID: 21129 RVA: 0x000CC139 File Offset: 0x000CA339
		public static IVehicleMontagePlayConfig Create(IVehicleMontagePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleMontagePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x0600528A RID: 21130 RVA: 0x000CC158 File Offset: 0x000CA358
		public virtual float MinMontageSpeedFactor
		{
			get
			{
				return this.Instance.MinMontageSpeedFactor;
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x000CC165 File Offset: 0x000CA365
		public virtual float MaxMontageSpeedFactor
		{
			get
			{
				return this.Instance.MaxMontageSpeedFactor;
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x0600528C RID: 21132 RVA: 0x000CC172 File Offset: 0x000CA372
		public virtual float MinVehicleSpeed
		{
			get
			{
				return this.Instance.MinVehicleSpeed;
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x000CC17F File Offset: 0x000CA37F
		public virtual float MaxVehicleSpeed
		{
			get
			{
				return this.Instance.MaxVehicleSpeed;
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x000CC18C File Offset: 0x000CA38C
		public virtual string TargetState
		{
			get
			{
				return this.Instance.TargetState;
			}
		}

		// Token: 0x04002F24 RID: 12068
		private IVehicleMontagePlayConfig Instance;
	}
}
