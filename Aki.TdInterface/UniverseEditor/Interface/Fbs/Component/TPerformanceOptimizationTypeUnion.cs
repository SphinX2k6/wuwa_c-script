using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C82 RID: 23682
	public class TPerformanceOptimizationTypeUnion
	{
		// Token: 0x1700B234 RID: 45620
		// (get) Token: 0x0602891D RID: 166173 RVA: 0x00593EA6 File Offset: 0x005920A6
		// (set) Token: 0x0602891E RID: 166174 RVA: 0x00593EAE File Offset: 0x005920AE
		public TPerformanceOptimizationType Type { get; set; }

		// Token: 0x1700B235 RID: 45621
		// (get) Token: 0x0602891F RID: 166175 RVA: 0x00593EB7 File Offset: 0x005920B7
		// (set) Token: 0x06028920 RID: 166176 RVA: 0x00593EBF File Offset: 0x005920BF
		public object Value { get; set; }

		// Token: 0x06028921 RID: 166177 RVA: 0x00593EC8 File Offset: 0x005920C8
		public TPerformanceOptimizationTypeUnion()
		{
			this.Type = TPerformanceOptimizationType.NONE;
			this.Value = null;
		}

		// Token: 0x06028922 RID: 166178 RVA: 0x00593EDE File Offset: 0x005920DE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028923 RID: 166179 RVA: 0x00593EF0 File Offset: 0x005920F0
		public IDamageTextOptimizationConfigT AsIDamageTextOptimizationConfig()
		{
			return this.As<IDamageTextOptimizationConfigT>();
		}

		// Token: 0x06028924 RID: 166180 RVA: 0x00593EF8 File Offset: 0x005920F8
		public static TPerformanceOptimizationTypeUnion FromIDamageTextOptimizationConfig(IDamageTextOptimizationConfigT _idamagetextoptimizationconfig)
		{
			return new TPerformanceOptimizationTypeUnion
			{
				Type = TPerformanceOptimizationType.IDamageTextOptimizationConfig,
				Value = _idamagetextoptimizationconfig
			};
		}

		// Token: 0x06028925 RID: 166181 RVA: 0x00593F0D File Offset: 0x0059210D
		public IPlaneMovementOptimizationConfigT AsIPlaneMovementOptimizationConfig()
		{
			return this.As<IPlaneMovementOptimizationConfigT>();
		}

		// Token: 0x06028926 RID: 166182 RVA: 0x00593F15 File Offset: 0x00592115
		public static TPerformanceOptimizationTypeUnion FromIPlaneMovementOptimizationConfig(IPlaneMovementOptimizationConfigT _iplanemovementoptimizationconfig)
		{
			return new TPerformanceOptimizationTypeUnion
			{
				Type = TPerformanceOptimizationType.IPlaneMovementOptimizationConfig,
				Value = _iplanemovementoptimizationconfig
			};
		}

		// Token: 0x06028927 RID: 166183 RVA: 0x00593F2C File Offset: 0x0059212C
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
