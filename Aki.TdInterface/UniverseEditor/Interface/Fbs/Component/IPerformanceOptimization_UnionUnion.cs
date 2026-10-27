using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571F RID: 22303
	public class IPerformanceOptimization_UnionUnion
	{
		// Token: 0x1700A62A RID: 42538
		// (get) Token: 0x06025504 RID: 152836 RVA: 0x00526251 File Offset: 0x00524451
		// (set) Token: 0x06025505 RID: 152837 RVA: 0x00526259 File Offset: 0x00524459
		public IPerformanceOptimization_Union Type { get; set; }

		// Token: 0x1700A62B RID: 42539
		// (get) Token: 0x06025506 RID: 152838 RVA: 0x00526262 File Offset: 0x00524462
		// (set) Token: 0x06025507 RID: 152839 RVA: 0x0052626A File Offset: 0x0052446A
		public object Value { get; set; }

		// Token: 0x06025508 RID: 152840 RVA: 0x00526273 File Offset: 0x00524473
		public IPerformanceOptimization_UnionUnion()
		{
			this.Type = IPerformanceOptimization_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025509 RID: 152841 RVA: 0x00526289 File Offset: 0x00524489
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602550A RID: 152842 RVA: 0x0052629B File Offset: 0x0052449B
		public IPerformanceOptimizationT AsIPerformanceOptimization()
		{
			return this.As<IPerformanceOptimizationT>();
		}

		// Token: 0x0602550B RID: 152843 RVA: 0x005262A3 File Offset: 0x005244A3
		public static IPerformanceOptimization_UnionUnion FromIPerformanceOptimization(IPerformanceOptimizationT _iperformanceoptimization)
		{
			return new IPerformanceOptimization_UnionUnion
			{
				Type = IPerformanceOptimization_Union.IPerformanceOptimization,
				Value = _iperformanceoptimization
			};
		}

		// Token: 0x0602550C RID: 152844 RVA: 0x005262B8 File Offset: 0x005244B8
		public IPlaneMovementOptimizationConfigT AsIPlaneMovementOptimizationConfig()
		{
			return this.As<IPlaneMovementOptimizationConfigT>();
		}

		// Token: 0x0602550D RID: 152845 RVA: 0x005262C0 File Offset: 0x005244C0
		public static IPerformanceOptimization_UnionUnion FromIPlaneMovementOptimizationConfig(IPlaneMovementOptimizationConfigT _iplanemovementoptimizationconfig)
		{
			return new IPerformanceOptimization_UnionUnion
			{
				Type = IPerformanceOptimization_Union.IPlaneMovementOptimizationConfig,
				Value = _iplanemovementoptimizationconfig
			};
		}

		// Token: 0x0602550E RID: 152846 RVA: 0x005262D5 File Offset: 0x005244D5
		public IDamageTextOptimizationConfigT AsIDamageTextOptimizationConfig()
		{
			return this.As<IDamageTextOptimizationConfigT>();
		}

		// Token: 0x0602550F RID: 152847 RVA: 0x005262DD File Offset: 0x005244DD
		public static IPerformanceOptimization_UnionUnion FromIDamageTextOptimizationConfig(IDamageTextOptimizationConfigT _idamagetextoptimizationconfig)
		{
			return new IPerformanceOptimization_UnionUnion
			{
				Type = IPerformanceOptimization_Union.IDamageTextOptimizationConfig,
				Value = _idamagetextoptimizationconfig
			};
		}

		// Token: 0x06025510 RID: 152848 RVA: 0x005262F4 File Offset: 0x005244F4
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
