using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007975 RID: 31093
	public class ISportConfig_UnionUnion
	{
		// Token: 0x1700E3FB RID: 58363
		// (get) Token: 0x06036C1A RID: 224282 RVA: 0x00753205 File Offset: 0x00751405
		// (set) Token: 0x06036C1B RID: 224283 RVA: 0x0075320D File Offset: 0x0075140D
		public ISportConfig_Union Type { get; set; }

		// Token: 0x1700E3FC RID: 58364
		// (get) Token: 0x06036C1C RID: 224284 RVA: 0x00753216 File Offset: 0x00751416
		// (set) Token: 0x06036C1D RID: 224285 RVA: 0x0075321E File Offset: 0x0075141E
		public object Value { get; set; }

		// Token: 0x06036C1E RID: 224286 RVA: 0x00753227 File Offset: 0x00751427
		public ISportConfig_UnionUnion()
		{
			this.Type = ISportConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036C1F RID: 224287 RVA: 0x0075323D File Offset: 0x0075143D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036C20 RID: 224288 RVA: 0x0075324F File Offset: 0x0075144F
		public ISportConfigT AsISportConfig()
		{
			return this.As<ISportConfigT>();
		}

		// Token: 0x06036C21 RID: 224289 RVA: 0x00753257 File Offset: 0x00751457
		public static ISportConfig_UnionUnion FromISportConfig(ISportConfigT _isportconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.ISportConfig,
				Value = _isportconfig
			};
		}

		// Token: 0x06036C22 RID: 224290 RVA: 0x0075326C File Offset: 0x0075146C
		public ISkiConfigT AsISkiConfig()
		{
			return this.As<ISkiConfigT>();
		}

		// Token: 0x06036C23 RID: 224291 RVA: 0x00753274 File Offset: 0x00751474
		public static ISportConfig_UnionUnion FromISkiConfig(ISkiConfigT _iskiconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.ISkiConfig,
				Value = _iskiconfig
			};
		}

		// Token: 0x06036C24 RID: 224292 RVA: 0x00753289 File Offset: 0x00751489
		public ISlideConfigT AsISlideConfig()
		{
			return this.As<ISlideConfigT>();
		}

		// Token: 0x06036C25 RID: 224293 RVA: 0x00753291 File Offset: 0x00751491
		public static ISportConfig_UnionUnion FromISlideConfig(ISlideConfigT _islideconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.ISlideConfig,
				Value = _islideconfig
			};
		}

		// Token: 0x06036C26 RID: 224294 RVA: 0x007532A6 File Offset: 0x007514A6
		public IPetalGrabConfigT AsIPetalGrabConfig()
		{
			return this.As<IPetalGrabConfigT>();
		}

		// Token: 0x06036C27 RID: 224295 RVA: 0x007532AE File Offset: 0x007514AE
		public static ISportConfig_UnionUnion FromIPetalGrabConfig(IPetalGrabConfigT _ipetalgrabconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.IPetalGrabConfig,
				Value = _ipetalgrabconfig
			};
		}

		// Token: 0x06036C28 RID: 224296 RVA: 0x007532C3 File Offset: 0x007514C3
		public IPetalFlyConfigT AsIPetalFlyConfig()
		{
			return this.As<IPetalFlyConfigT>();
		}

		// Token: 0x06036C29 RID: 224297 RVA: 0x007532CB File Offset: 0x007514CB
		public static ISportConfig_UnionUnion FromIPetalFlyConfig(IPetalFlyConfigT _ipetalflyconfig)
		{
			return new ISportConfig_UnionUnion
			{
				Type = ISportConfig_Union.IPetalFlyConfig,
				Value = _ipetalflyconfig
			};
		}

		// Token: 0x06036C2A RID: 224298 RVA: 0x007532E0 File Offset: 0x007514E0
		public static int Pack(FlatBufferBuilder builder, ISportConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISportConfig_Union.ISportConfig:
				return ISportConfig.Pack(builder, _o.AsISportConfig()).Value;
			case ISportConfig_Union.ISkiConfig:
				return ISkiConfig.Pack(builder, _o.AsISkiConfig()).Value;
			case ISportConfig_Union.ISlideConfig:
				return ISlideConfig.Pack(builder, _o.AsISlideConfig()).Value;
			case ISportConfig_Union.IPetalGrabConfig:
				return IPetalGrabConfig.Pack(builder, _o.AsIPetalGrabConfig()).Value;
			case ISportConfig_Union.IPetalFlyConfig:
				return IPetalFlyConfig.Pack(builder, _o.AsIPetalFlyConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
