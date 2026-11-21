using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062B3 RID: 25267
	public class TPerformanceOptimizationTypeUnion
	{
		// Token: 0x1700BB8E RID: 48014
		// (get) Token: 0x0602AF63 RID: 175971 RVA: 0x005DC5DE File Offset: 0x005DA7DE
		// (set) Token: 0x0602AF64 RID: 175972 RVA: 0x005DC5E6 File Offset: 0x005DA7E6
		public TPerformanceOptimizationType Type { get; set; }

		// Token: 0x1700BB8F RID: 48015
		// (get) Token: 0x0602AF65 RID: 175973 RVA: 0x005DC5EF File Offset: 0x005DA7EF
		// (set) Token: 0x0602AF66 RID: 175974 RVA: 0x005DC5F7 File Offset: 0x005DA7F7
		public object Value { get; set; }

		// Token: 0x0602AF67 RID: 175975 RVA: 0x005DC600 File Offset: 0x005DA800
		public TPerformanceOptimizationTypeUnion()
		{
			this.Type = TPerformanceOptimizationType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF68 RID: 175976 RVA: 0x005DC616 File Offset: 0x005DA816
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF69 RID: 175977 RVA: 0x005DC628 File Offset: 0x005DA828
		public IDamageTextOptimizationConfigT AsIDamageTextOptimizationConfig()
		{
			return this.As<IDamageTextOptimizationConfigT>();
		}

		// Token: 0x0602AF6A RID: 175978 RVA: 0x005DC630 File Offset: 0x005DA830
		public static TPerformanceOptimizationTypeUnion FromIDamageTextOptimizationConfig(IDamageTextOptimizationConfigT _idamagetextoptimizationconfig)
		{
			return new TPerformanceOptimizationTypeUnion
			{
				Type = TPerformanceOptimizationType.IDamageTextOptimizationConfig,
				Value = _idamagetextoptimizationconfig
			};
		}

		// Token: 0x0602AF6B RID: 175979 RVA: 0x005DC645 File Offset: 0x005DA845
		public IPlaneMovementOptimizationConfigT AsIPlaneMovementOptimizationConfig()
		{
			return this.As<IPlaneMovementOptimizationConfigT>();
		}

		// Token: 0x0602AF6C RID: 175980 RVA: 0x005DC64D File Offset: 0x005DA84D
		public static TPerformanceOptimizationTypeUnion FromIPlaneMovementOptimizationConfig(IPlaneMovementOptimizationConfigT _iplanemovementoptimizationconfig)
		{
			return new TPerformanceOptimizationTypeUnion
			{
				Type = TPerformanceOptimizationType.IPlaneMovementOptimizationConfig,
				Value = _iplanemovementoptimizationconfig
			};
		}

		// Token: 0x0602AF6D RID: 175981 RVA: 0x005DC664 File Offset: 0x005DA864
		public static int Pack(FlatBufferBuilder builder, TPerformanceOptimizationTypeUnion _o)
		{
			TPerformanceOptimizationType type = _o.Type;
			if (type == TPerformanceOptimizationType.IDamageTextOptimizationConfig)
			{
				return IDamageTextOptimizationConfig.Pack(builder, _o.AsIDamageTextOptimizationConfig()).Value;
			}
			if (type != TPerformanceOptimizationType.IPlaneMovementOptimizationConfig)
			{
				return 0;
			}
			return IPlaneMovementOptimizationConfig.Pack(builder, _o.AsIPlaneMovementOptimizationConfig()).Value;
		}
	}
}
