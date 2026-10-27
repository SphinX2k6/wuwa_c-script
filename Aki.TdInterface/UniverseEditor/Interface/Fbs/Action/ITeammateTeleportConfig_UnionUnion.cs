using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736E RID: 29550
	public class ITeammateTeleportConfig_UnionUnion
	{
		// Token: 0x1700E057 RID: 57431
		// (get) Token: 0x06035A12 RID: 219666 RVA: 0x0074D881 File Offset: 0x0074BA81
		// (set) Token: 0x06035A13 RID: 219667 RVA: 0x0074D889 File Offset: 0x0074BA89
		public ITeammateTeleportConfig_Union Type { get; set; }

		// Token: 0x1700E058 RID: 57432
		// (get) Token: 0x06035A14 RID: 219668 RVA: 0x0074D892 File Offset: 0x0074BA92
		// (set) Token: 0x06035A15 RID: 219669 RVA: 0x0074D89A File Offset: 0x0074BA9A
		public object Value { get; set; }

		// Token: 0x06035A16 RID: 219670 RVA: 0x0074D8A3 File Offset: 0x0074BAA3
		public ITeammateTeleportConfig_UnionUnion()
		{
			this.Type = ITeammateTeleportConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035A17 RID: 219671 RVA: 0x0074D8B9 File Offset: 0x0074BAB9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035A18 RID: 219672 RVA: 0x0074D8CB File Offset: 0x0074BACB
		public ITeammateTeleportConfigT AsITeammateTeleportConfig()
		{
			return this.As<ITeammateTeleportConfigT>();
		}

		// Token: 0x06035A19 RID: 219673 RVA: 0x0074D8D3 File Offset: 0x0074BAD3
		public static ITeammateTeleportConfig_UnionUnion FromITeammateTeleportConfig(ITeammateTeleportConfigT _iteammateteleportconfig)
		{
			return new ITeammateTeleportConfig_UnionUnion
			{
				Type = ITeammateTeleportConfig_Union.ITeammateTeleportConfig,
				Value = _iteammateteleportconfig
			};
		}

		// Token: 0x06035A1A RID: 219674 RVA: 0x0074D8E8 File Offset: 0x0074BAE8
		public ITelePortAfterTimeOutT AsITelePortAfterTimeOut()
		{
			return this.As<ITelePortAfterTimeOutT>();
		}

		// Token: 0x06035A1B RID: 219675 RVA: 0x0074D8F0 File Offset: 0x0074BAF0
		public static ITeammateTeleportConfig_UnionUnion FromITelePortAfterTimeOut(ITelePortAfterTimeOutT _iteleportaftertimeout)
		{
			return new ITeammateTeleportConfig_UnionUnion
			{
				Type = ITeammateTeleportConfig_Union.ITelePortAfterTimeOut,
				Value = _iteleportaftertimeout
			};
		}

		// Token: 0x06035A1C RID: 219676 RVA: 0x0074D908 File Offset: 0x0074BB08
		public static int Pack(FlatBufferBuilder builder, ITeammateTeleportConfig_UnionUnion _o)
		{
			ITeammateTeleportConfig_Union type = _o.Type;
			if (type == ITeammateTeleportConfig_Union.ITeammateTeleportConfig)
			{
				return ITeammateTeleportConfig.Pack(builder, _o.AsITeammateTeleportConfig()).Value;
			}
			if (type != ITeammateTeleportConfig_Union.ITelePortAfterTimeOut)
			{
				return 0;
			}
			return ITelePortAfterTimeOut.Pack(builder, _o.AsITelePortAfterTimeOut()).Value;
		}
	}
}
