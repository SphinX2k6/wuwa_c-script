using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D46 RID: 3398
	[NullableContext(2)]
	[Nullable(0)]
	public class IMovementVehicleFeature : IVehicleFeature
	{
		// Token: 0x06004D7D RID: 19837 RVA: 0x000C0C12 File Offset: 0x000BEE12
		[NullableContext(1)]
		public static IMovementVehicleFeature Create(IMovementVehicleFeature? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementVehicleFeature
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x000C0C31 File Offset: 0x000BEE31
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06004D7F RID: 19839 RVA: 0x000C0C40 File Offset: 0x000BEE40
		public virtual int? MoveSpline
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MoveSpline);
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x06004D80 RID: 19840 RVA: 0x000C0C76 File Offset: 0x000BEE76
		public virtual IMovementPerformConfig MovePerformConfig
		{
			get
			{
				if (this._MovePerformConfigInited)
				{
					return this._MovePerformConfigCache;
				}
				this._MovePerformConfigInited = true;
				this._MovePerformConfigCache = IMovementPerformConfig.Create(this.Instance.MovePerformConfig);
				return this._MovePerformConfigCache;
			}
		}

		// Token: 0x04002C6D RID: 11373
		private IMovementVehicleFeature Instance;

		// Token: 0x04002C6E RID: 11374
		private IMovementPerformConfig _MovePerformConfigCache;

		// Token: 0x04002C6F RID: 11375
		private bool _MovePerformConfigInited;
	}
}
