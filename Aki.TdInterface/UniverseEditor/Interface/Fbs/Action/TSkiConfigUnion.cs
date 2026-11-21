using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FC8 RID: 32712
	public class TSkiConfigUnion
	{
		// Token: 0x1700F2FD RID: 62205
		// (get) Token: 0x0603AE7D RID: 241277 RVA: 0x007E9DD2 File Offset: 0x007E7FD2
		// (set) Token: 0x0603AE7E RID: 241278 RVA: 0x007E9DDA File Offset: 0x007E7FDA
		public TSkiConfig Type { get; set; }

		// Token: 0x1700F2FE RID: 62206
		// (get) Token: 0x0603AE7F RID: 241279 RVA: 0x007E9DE3 File Offset: 0x007E7FE3
		// (set) Token: 0x0603AE80 RID: 241280 RVA: 0x007E9DEB File Offset: 0x007E7FEB
		public object Value { get; set; }

		// Token: 0x0603AE81 RID: 241281 RVA: 0x007E9DF4 File Offset: 0x007E7FF4
		public TSkiConfigUnion()
		{
			this.Type = TSkiConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE82 RID: 241282 RVA: 0x007E9E0A File Offset: 0x007E800A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE83 RID: 241283 RVA: 0x007E9E1C File Offset: 0x007E801C
		public IAccelerateSkiConfigT AsIAccelerateSkiConfig()
		{
			return this.As<IAccelerateSkiConfigT>();
		}

		// Token: 0x0603AE84 RID: 241284 RVA: 0x007E9E24 File Offset: 0x007E8024
		public static TSkiConfigUnion FromIAccelerateSkiConfig(IAccelerateSkiConfigT _iaccelerateskiconfig)
		{
			return new TSkiConfigUnion
			{
				Type = TSkiConfig.IAccelerateSkiConfig,
				Value = _iaccelerateskiconfig
			};
		}

		// Token: 0x0603AE85 RID: 241285 RVA: 0x007E9E39 File Offset: 0x007E8039
		public ICloseSkiConfigT AsICloseSkiConfig()
		{
			return this.As<ICloseSkiConfigT>();
		}

		// Token: 0x0603AE86 RID: 241286 RVA: 0x007E9E41 File Offset: 0x007E8041
		public static TSkiConfigUnion FromICloseSkiConfig(ICloseSkiConfigT _icloseskiconfig)
		{
			return new TSkiConfigUnion
			{
				Type = TSkiConfig.ICloseSkiConfig,
				Value = _icloseskiconfig
			};
		}

		// Token: 0x0603AE87 RID: 241287 RVA: 0x007E9E56 File Offset: 0x007E8056
		public IOpenSkiConfigT AsIOpenSkiConfig()
		{
			return this.As<IOpenSkiConfigT>();
		}

		// Token: 0x0603AE88 RID: 241288 RVA: 0x007E9E5E File Offset: 0x007E805E
		public static TSkiConfigUnion FromIOpenSkiConfig(IOpenSkiConfigT _iopenskiconfig)
		{
			return new TSkiConfigUnion
			{
				Type = TSkiConfig.IOpenSkiConfig,
				Value = _iopenskiconfig
			};
		}

		// Token: 0x0603AE89 RID: 241289 RVA: 0x007E9E74 File Offset: 0x007E8074
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
