using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D43 RID: 3395
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleMontagePlayConfig
	{
		// Token: 0x06004D6D RID: 19821 RVA: 0x000C09F5 File Offset: 0x000BEBF5
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

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x000C0A14 File Offset: 0x000BEC14
		public virtual float MinMontageSpeedFactor
		{
			get
			{
				return this.Instance.MinMontageSpeedFactor;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06004D6F RID: 19823 RVA: 0x000C0A21 File Offset: 0x000BEC21
		public virtual float MaxMontageSpeedFactor
		{
			get
			{
				return this.Instance.MaxMontageSpeedFactor;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06004D70 RID: 19824 RVA: 0x000C0A2E File Offset: 0x000BEC2E
		public virtual float MinVehicleSpeed
		{
			get
			{
				return this.Instance.MinVehicleSpeed;
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06004D71 RID: 19825 RVA: 0x000C0A3B File Offset: 0x000BEC3B
		public virtual float MaxVehicleSpeed
		{
			get
			{
				return this.Instance.MaxVehicleSpeed;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06004D72 RID: 19826 RVA: 0x000C0A48 File Offset: 0x000BEC48
		public virtual string TargetState
		{
			get
			{
				return this.Instance.TargetState;
			}
		}

		// Token: 0x04002C64 RID: 11364
		private IVehicleMontagePlayConfig Instance;
	}
}
