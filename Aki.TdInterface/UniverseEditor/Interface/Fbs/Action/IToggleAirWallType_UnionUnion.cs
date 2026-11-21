using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BDC RID: 31708
	public class IToggleAirWallType_UnionUnion
	{
		// Token: 0x1700ED80 RID: 60800
		// (get) Token: 0x0603925A RID: 234074 RVA: 0x007B8DB1 File Offset: 0x007B6FB1
		// (set) Token: 0x0603925B RID: 234075 RVA: 0x007B8DB9 File Offset: 0x007B6FB9
		public IToggleAirWallType_Union Type { get; set; }

		// Token: 0x1700ED81 RID: 60801
		// (get) Token: 0x0603925C RID: 234076 RVA: 0x007B8DC2 File Offset: 0x007B6FC2
		// (set) Token: 0x0603925D RID: 234077 RVA: 0x007B8DCA File Offset: 0x007B6FCA
		public object Value { get; set; }

		// Token: 0x0603925E RID: 234078 RVA: 0x007B8DD3 File Offset: 0x007B6FD3
		public IToggleAirWallType_UnionUnion()
		{
			this.Type = IToggleAirWallType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603925F RID: 234079 RVA: 0x007B8DE9 File Offset: 0x007B6FE9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039260 RID: 234080 RVA: 0x007B8DFB File Offset: 0x007B6FFB
		public IToggleAirWallTypeT AsIToggleAirWallType()
		{
			return this.As<IToggleAirWallTypeT>();
		}

		// Token: 0x06039261 RID: 234081 RVA: 0x007B8E03 File Offset: 0x007B7003
		public static IToggleAirWallType_UnionUnion FromIToggleAirWallType(IToggleAirWallTypeT _itoggleairwalltype)
		{
			return new IToggleAirWallType_UnionUnion
			{
				Type = IToggleAirWallType_Union.IToggleAirWallType,
				Value = _itoggleairwalltype
			};
		}

		// Token: 0x06039262 RID: 234082 RVA: 0x007B8E18 File Offset: 0x007B7018
		public IOpenAirWallT AsIOpenAirWall()
		{
			return this.As<IOpenAirWallT>();
		}

		// Token: 0x06039263 RID: 234083 RVA: 0x007B8E20 File Offset: 0x007B7020
		public static IToggleAirWallType_UnionUnion FromIOpenAirWall(IOpenAirWallT _iopenairwall)
		{
			return new IToggleAirWallType_UnionUnion
			{
				Type = IToggleAirWallType_Union.IOpenAirWall,
				Value = _iopenairwall
			};
		}

		// Token: 0x06039264 RID: 234084 RVA: 0x007B8E35 File Offset: 0x007B7035
		public ICloseAirWallT AsICloseAirWall()
		{
			return this.As<ICloseAirWallT>();
		}

		// Token: 0x06039265 RID: 234085 RVA: 0x007B8E3D File Offset: 0x007B703D
		public static IToggleAirWallType_UnionUnion FromICloseAirWall(ICloseAirWallT _icloseairwall)
		{
			return new IToggleAirWallType_UnionUnion
			{
				Type = IToggleAirWallType_Union.ICloseAirWall,
				Value = _icloseairwall
			};
		}

		// Token: 0x06039266 RID: 234086 RVA: 0x007B8E54 File Offset: 0x007B7054
		public static int Pack(FlatBufferBuilder builder, IToggleAirWallType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IToggleAirWallType_Union.IToggleAirWallType:
				return IToggleAirWallType.Pack(builder, _o.AsIToggleAirWallType()).Value;
			case IToggleAirWallType_Union.IOpenAirWall:
				return IOpenAirWall.Pack(builder, _o.AsIOpenAirWall()).Value;
			case IToggleAirWallType_Union.ICloseAirWall:
				return ICloseAirWall.Pack(builder, _o.AsICloseAirWall()).Value;
			default:
				return 0;
			}
		}
	}
}
