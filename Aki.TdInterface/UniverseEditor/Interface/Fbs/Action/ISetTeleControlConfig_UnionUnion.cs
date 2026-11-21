using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200785B RID: 30811
	public class ISetTeleControlConfig_UnionUnion
	{
		// Token: 0x1700E200 RID: 57856
		// (get) Token: 0x060362F9 RID: 221945 RVA: 0x00742372 File Offset: 0x00740572
		// (set) Token: 0x060362FA RID: 221946 RVA: 0x0074237A File Offset: 0x0074057A
		public ISetTeleControlConfig_Union Type { get; set; }

		// Token: 0x1700E201 RID: 57857
		// (get) Token: 0x060362FB RID: 221947 RVA: 0x00742383 File Offset: 0x00740583
		// (set) Token: 0x060362FC RID: 221948 RVA: 0x0074238B File Offset: 0x0074058B
		public object Value { get; set; }

		// Token: 0x060362FD RID: 221949 RVA: 0x00742394 File Offset: 0x00740594
		public ISetTeleControlConfig_UnionUnion()
		{
			this.Type = ISetTeleControlConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060362FE RID: 221950 RVA: 0x007423AA File Offset: 0x007405AA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060362FF RID: 221951 RVA: 0x007423BC File Offset: 0x007405BC
		public ISetTeleControlConfigT AsISetTeleControlConfig()
		{
			return this.As<ISetTeleControlConfigT>();
		}

		// Token: 0x06036300 RID: 221952 RVA: 0x007423C4 File Offset: 0x007405C4
		public static ISetTeleControlConfig_UnionUnion FromISetTeleControlConfig(ISetTeleControlConfigT _isettelecontrolconfig)
		{
			return new ISetTeleControlConfig_UnionUnion
			{
				Type = ISetTeleControlConfig_Union.ISetTeleControlConfig,
				Value = _isettelecontrolconfig
			};
		}

		// Token: 0x06036301 RID: 221953 RVA: 0x007423D9 File Offset: 0x007405D9
		public IOpenGravityT AsIOpenGravity()
		{
			return this.As<IOpenGravityT>();
		}

		// Token: 0x06036302 RID: 221954 RVA: 0x007423E1 File Offset: 0x007405E1
		public static ISetTeleControlConfig_UnionUnion FromIOpenGravity(IOpenGravityT _iopengravity)
		{
			return new ISetTeleControlConfig_UnionUnion
			{
				Type = ISetTeleControlConfig_Union.IOpenGravity,
				Value = _iopengravity
			};
		}

		// Token: 0x06036303 RID: 221955 RVA: 0x007423F6 File Offset: 0x007405F6
		public ISetResetPositionT AsISetResetPosition()
		{
			return this.As<ISetResetPositionT>();
		}

		// Token: 0x06036304 RID: 221956 RVA: 0x007423FE File Offset: 0x007405FE
		public static ISetTeleControlConfig_UnionUnion FromISetResetPosition(ISetResetPositionT _isetresetposition)
		{
			return new ISetTeleControlConfig_UnionUnion
			{
				Type = ISetTeleControlConfig_Union.ISetResetPosition,
				Value = _isetresetposition
			};
		}

		// Token: 0x06036305 RID: 221957 RVA: 0x00742414 File Offset: 0x00740614
		public static int Pack(FlatBufferBuilder builder, ISetTeleControlConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISetTeleControlConfig_Union.ISetTeleControlConfig:
				return ISetTeleControlConfig.Pack(builder, _o.AsISetTeleControlConfig()).Value;
			case ISetTeleControlConfig_Union.IOpenGravity:
				return IOpenGravity.Pack(builder, _o.AsIOpenGravity()).Value;
			case ISetTeleControlConfig_Union.ISetResetPosition:
				return ISetResetPosition.Pack(builder, _o.AsISetResetPosition()).Value;
			default:
				return 0;
			}
		}
	}
}
