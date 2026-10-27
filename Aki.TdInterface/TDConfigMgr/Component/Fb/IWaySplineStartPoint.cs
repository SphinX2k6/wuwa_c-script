using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5F RID: 3167
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaySplineStartPoint : IWaySplinePointType
	{
		// Token: 0x06004889 RID: 18569 RVA: 0x000B6291 File Offset: 0x000B4491
		[NullableContext(1)]
		public static IWaySplineStartPoint Create(IWaySplineStartPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySplineStartPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x000B62B0 File Offset: 0x000B44B0
		public override EWaySplinePointType Type
		{
			get
			{
				return (EWaySplinePointType)this.Instance.Type;
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x0600488B RID: 18571 RVA: 0x000B62BD File Offset: 0x000B44BD
		public virtual IVehicleGenerationConfig GenerationConfig
		{
			get
			{
				if (this._GenerationConfigInited)
				{
					return this._GenerationConfigCache;
				}
				this._GenerationConfigInited = true;
				this._GenerationConfigCache = IVehicleGenerationConfig.Create(this.Instance.GenerationConfig);
				return this._GenerationConfigCache;
			}
		}

		// Token: 0x04002950 RID: 10576
		private IWaySplineStartPoint Instance;

		// Token: 0x04002951 RID: 10577
		private IVehicleGenerationConfig _GenerationConfigCache;

		// Token: 0x04002952 RID: 10578
		private bool _GenerationConfigInited;
	}
}
