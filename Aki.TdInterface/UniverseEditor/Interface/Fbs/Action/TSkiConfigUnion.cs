using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007790 RID: 30608
	public class TSkiConfigUnion
	{
		// Token: 0x1700E6A3 RID: 59043
		// (get) Token: 0x06037902 RID: 227586 RVA: 0x007848D2 File Offset: 0x00782AD2
		// (set) Token: 0x06037903 RID: 227587 RVA: 0x007848DA File Offset: 0x00782ADA
		public TSkiConfig Type { get; set; }

		// Token: 0x1700E6A4 RID: 59044
		// (get) Token: 0x06037904 RID: 227588 RVA: 0x007848E3 File Offset: 0x00782AE3
		// (set) Token: 0x06037905 RID: 227589 RVA: 0x007848EB File Offset: 0x00782AEB
		public object Value { get; set; }

		// Token: 0x06037906 RID: 227590 RVA: 0x007848F4 File Offset: 0x00782AF4
		public TSkiConfigUnion()
		{
			this.Type = TSkiConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037907 RID: 227591 RVA: 0x0078490A File Offset: 0x00782B0A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037908 RID: 227592 RVA: 0x0078491C File Offset: 0x00782B1C
		public IAccelerateSkiConfigT AsIAccelerateSkiConfig()
		{
			return this.As<IAccelerateSkiConfigT>();
		}

		// Token: 0x06037909 RID: 227593 RVA: 0x00784924 File Offset: 0x00782B24
		public static TSkiConfigUnion FromIAccelerateSkiConfig(IAccelerateSkiConfigT _iaccelerateskiconfig)
		{
			return new TSkiConfigUnion
			{
				Type = TSkiConfig.IAccelerateSkiConfig,
				Value = _iaccelerateskiconfig
			};
		}

		// Token: 0x0603790A RID: 227594 RVA: 0x00784939 File Offset: 0x00782B39
		public ICloseSkiConfigT AsICloseSkiConfig()
		{
			return this.As<ICloseSkiConfigT>();
		}

		// Token: 0x0603790B RID: 227595 RVA: 0x00784941 File Offset: 0x00782B41
		public static TSkiConfigUnion FromICloseSkiConfig(ICloseSkiConfigT _icloseskiconfig)
		{
			return new TSkiConfigUnion
			{
				Type = TSkiConfig.ICloseSkiConfig,
				Value = _icloseskiconfig
			};
		}

		// Token: 0x0603790C RID: 227596 RVA: 0x00784956 File Offset: 0x00782B56
		public IOpenSkiConfigT AsIOpenSkiConfig()
		{
			return this.As<IOpenSkiConfigT>();
		}

		// Token: 0x0603790D RID: 227597 RVA: 0x0078495E File Offset: 0x00782B5E
		public static TSkiConfigUnion FromIOpenSkiConfig(IOpenSkiConfigT _iopenskiconfig)
		{
			return new TSkiConfigUnion
			{
				Type = TSkiConfig.IOpenSkiConfig,
				Value = _iopenskiconfig
			};
		}

		// Token: 0x0603790E RID: 227598 RVA: 0x00784974 File Offset: 0x00782B74
		public static int Pack(FlatBufferBuilder builder, TSkiConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TSkiConfig.IAccelerateSkiConfig:
				return IAccelerateSkiConfig.Pack(builder, _o.AsIAccelerateSkiConfig()).Value;
			case TSkiConfig.ICloseSkiConfig:
				return ICloseSkiConfig.Pack(builder, _o.AsICloseSkiConfig()).Value;
			case TSkiConfig.IOpenSkiConfig:
				return IOpenSkiConfig.Pack(builder, _o.AsIOpenSkiConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
