using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708F RID: 28815
	public class ISetTeleControlConfig_UnionUnion
	{
		// Token: 0x1700D61D RID: 54813
		// (get) Token: 0x06033057 RID: 208983 RVA: 0x006E1D66 File Offset: 0x006DFF66
		// (set) Token: 0x06033058 RID: 208984 RVA: 0x006E1D6E File Offset: 0x006DFF6E
		public ISetTeleControlConfig_Union Type { get; set; }

		// Token: 0x1700D61E RID: 54814
		// (get) Token: 0x06033059 RID: 208985 RVA: 0x006E1D77 File Offset: 0x006DFF77
		// (set) Token: 0x0603305A RID: 208986 RVA: 0x006E1D7F File Offset: 0x006DFF7F
		public object Value { get; set; }

		// Token: 0x0603305B RID: 208987 RVA: 0x006E1D88 File Offset: 0x006DFF88
		public ISetTeleControlConfig_UnionUnion()
		{
			this.Type = ISetTeleControlConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603305C RID: 208988 RVA: 0x006E1D9E File Offset: 0x006DFF9E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603305D RID: 208989 RVA: 0x006E1DB0 File Offset: 0x006DFFB0
		public ISetTeleControlConfigT AsISetTeleControlConfig()
		{
			return this.As<ISetTeleControlConfigT>();
		}

		// Token: 0x0603305E RID: 208990 RVA: 0x006E1DB8 File Offset: 0x006DFFB8
		public static ISetTeleControlConfig_UnionUnion FromISetTeleControlConfig(ISetTeleControlConfigT _isettelecontrolconfig)
		{
			return new ISetTeleControlConfig_UnionUnion
			{
				Type = ISetTeleControlConfig_Union.ISetTeleControlConfig,
				Value = _isettelecontrolconfig
			};
		}

		// Token: 0x0603305F RID: 208991 RVA: 0x006E1DCD File Offset: 0x006DFFCD
		public IOpenGravityT AsIOpenGravity()
		{
			return this.As<IOpenGravityT>();
		}

		// Token: 0x06033060 RID: 208992 RVA: 0x006E1DD5 File Offset: 0x006DFFD5
		public static ISetTeleControlConfig_UnionUnion FromIOpenGravity(IOpenGravityT _iopengravity)
		{
			return new ISetTeleControlConfig_UnionUnion
			{
				Type = ISetTeleControlConfig_Union.IOpenGravity,
				Value = _iopengravity
			};
		}

		// Token: 0x06033061 RID: 208993 RVA: 0x006E1DEA File Offset: 0x006DFFEA
		public ISetResetPositionT AsISetResetPosition()
		{
			return this.As<ISetResetPositionT>();
		}

		// Token: 0x06033062 RID: 208994 RVA: 0x006E1DF2 File Offset: 0x006DFFF2
		public static ISetTeleControlConfig_UnionUnion FromISetResetPosition(ISetResetPositionT _isetresetposition)
		{
			return new ISetTeleControlConfig_UnionUnion
			{
				Type = ISetTeleControlConfig_Union.ISetResetPosition,
				Value = _isetresetposition
			};
		}

		// Token: 0x06033063 RID: 208995 RVA: 0x006E1E08 File Offset: 0x006E0008
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
