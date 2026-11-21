using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D38 RID: 3384
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaySplineStartPoint : IWaySplinePointType
	{
		// Token: 0x06004D0E RID: 19726 RVA: 0x000C0885 File Offset: 0x000BEA85
		[NullableContext(0)]
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

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06004D0F RID: 19727 RVA: 0x000C08A4 File Offset: 0x000BEAA4
		public override EWaySplinePointType Type
		{
			get
			{
				return (EWaySplinePointType)this.Instance.Type;
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x000C08B1 File Offset: 0x000BEAB1
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

		// Token: 0x04002BB1 RID: 11185
		private IWaySplineStartPoint Instance;

		// Token: 0x04002BB2 RID: 11186
		private IVehicleGenerationConfig _GenerationConfigCache;

		// Token: 0x04002BB3 RID: 11187
		private bool _GenerationConfigInited;
	}
}
