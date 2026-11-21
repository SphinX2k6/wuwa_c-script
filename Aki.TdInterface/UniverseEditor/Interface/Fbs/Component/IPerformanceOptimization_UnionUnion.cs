using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D26 RID: 23846
	public class IPerformanceOptimization_UnionUnion
	{
		// Token: 0x1700AF4A RID: 44874
		// (get) Token: 0x06027A13 RID: 162323 RVA: 0x0056BF59 File Offset: 0x0056A159
		// (set) Token: 0x06027A14 RID: 162324 RVA: 0x0056BF61 File Offset: 0x0056A161
		public IPerformanceOptimization_Union Type { get; set; }

		// Token: 0x1700AF4B RID: 44875
		// (get) Token: 0x06027A15 RID: 162325 RVA: 0x0056BF6A File Offset: 0x0056A16A
		// (set) Token: 0x06027A16 RID: 162326 RVA: 0x0056BF72 File Offset: 0x0056A172
		public object Value { get; set; }

		// Token: 0x06027A17 RID: 162327 RVA: 0x0056BF7B File Offset: 0x0056A17B
		public IPerformanceOptimization_UnionUnion()
		{
			this.Type = IPerformanceOptimization_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027A18 RID: 162328 RVA: 0x0056BF91 File Offset: 0x0056A191
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027A19 RID: 162329 RVA: 0x0056BFA3 File Offset: 0x0056A1A3
		public IPerformanceOptimizationT AsIPerformanceOptimization()
		{
			return this.As<IPerformanceOptimizationT>();
		}

		// Token: 0x06027A1A RID: 162330 RVA: 0x0056BFAB File Offset: 0x0056A1AB
		public static IPerformanceOptimization_UnionUnion FromIPerformanceOptimization(IPerformanceOptimizationT _iperformanceoptimization)
		{
			return new IPerformanceOptimization_UnionUnion
			{
				Type = IPerformanceOptimization_Union.IPerformanceOptimization,
				Value = _iperformanceoptimization
			};
		}

		// Token: 0x06027A1B RID: 162331 RVA: 0x0056BFC0 File Offset: 0x0056A1C0
		public IPlaneMovementOptimizationConfigT AsIPlaneMovementOptimizationConfig()
		{
			return this.As<IPlaneMovementOptimizationConfigT>();
		}

		// Token: 0x06027A1C RID: 162332 RVA: 0x0056BFC8 File Offset: 0x0056A1C8
		public static IPerformanceOptimization_UnionUnion FromIPlaneMovementOptimizationConfig(IPlaneMovementOptimizationConfigT _iplanemovementoptimizationconfig)
		{
			return new IPerformanceOptimization_UnionUnion
			{
				Type = IPerformanceOptimization_Union.IPlaneMovementOptimizationConfig,
				Value = _iplanemovementoptimizationconfig
			};
		}

		// Token: 0x06027A1D RID: 162333 RVA: 0x0056BFDD File Offset: 0x0056A1DD
		public IDamageTextOptimizationConfigT AsIDamageTextOptimizationConfig()
		{
			return this.As<IDamageTextOptimizationConfigT>();
		}

		// Token: 0x06027A1E RID: 162334 RVA: 0x0056BFE5 File Offset: 0x0056A1E5
		public static IPerformanceOptimization_UnionUnion FromIDamageTextOptimizationConfig(IDamageTextOptimizationConfigT _idamagetextoptimizationconfig)
		{
			return new IPerformanceOptimization_UnionUnion
			{
				Type = IPerformanceOptimization_Union.IDamageTextOptimizationConfig,
				Value = _idamagetextoptimizationconfig
			};
		}

		// Token: 0x06027A1F RID: 162335 RVA: 0x0056BFFC File Offset: 0x0056A1FC
		public static int Pack(FlatBufferBuilder builder, IPerformanceOptimization_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPerformanceOptimization_Union.IPerformanceOptimization:
				return IPerformanceOptimization.Pack(builder, _o.AsIPerformanceOptimization()).Value;
			case IPerformanceOptimization_Union.IPlaneMovementOptimizationConfig:
				return IPlaneMovementOptimizationConfig.Pack(builder, _o.AsIPlaneMovementOptimizationConfig()).Value;
			case IPerformanceOptimization_Union.IDamageTextOptimizationConfig:
				return IDamageTextOptimizationConfig.Pack(builder, _o.AsIDamageTextOptimizationConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
