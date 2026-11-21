using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E40 RID: 3648
	[NullableContext(2)]
	[Nullable(0)]
	public class IMovementVehicleFeature : IVehicleFeature
	{
		// Token: 0x06005299 RID: 21145 RVA: 0x000CC356 File Offset: 0x000CA556
		[NullableContext(0)]
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

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x0600529A RID: 21146 RVA: 0x000CC375 File Offset: 0x000CA575
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x0600529B RID: 21147 RVA: 0x000CC384 File Offset: 0x000CA584
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

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x0600529C RID: 21148 RVA: 0x000CC3BA File Offset: 0x000CA5BA
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

		// Token: 0x04002F2D RID: 12077
		private IMovementVehicleFeature Instance;

		// Token: 0x04002F2E RID: 12078
		private IMovementPerformConfig _MovePerformConfigCache;

		// Token: 0x04002F2F RID: 12079
		private bool _MovePerformConfigInited;
	}
}
