using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F2 RID: 29682
	public class IToggleAirWallType_UnionUnion
	{
		// Token: 0x1700E16B RID: 57707
		// (get) Token: 0x06035EA7 RID: 220839 RVA: 0x0075663D File Offset: 0x0075483D
		// (set) Token: 0x06035EA8 RID: 220840 RVA: 0x00756645 File Offset: 0x00754845
		public IToggleAirWallType_Union Type { get; set; }

		// Token: 0x1700E16C RID: 57708
		// (get) Token: 0x06035EA9 RID: 220841 RVA: 0x0075664E File Offset: 0x0075484E
		// (set) Token: 0x06035EAA RID: 220842 RVA: 0x00756656 File Offset: 0x00754856
		public object Value { get; set; }

		// Token: 0x06035EAB RID: 220843 RVA: 0x0075665F File Offset: 0x0075485F
		public IToggleAirWallType_UnionUnion()
		{
			this.Type = IToggleAirWallType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035EAC RID: 220844 RVA: 0x00756675 File Offset: 0x00754875
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035EAD RID: 220845 RVA: 0x00756687 File Offset: 0x00754887
		public IToggleAirWallTypeT AsIToggleAirWallType()
		{
			return this.As<IToggleAirWallTypeT>();
		}

		// Token: 0x06035EAE RID: 220846 RVA: 0x0075668F File Offset: 0x0075488F
		public static IToggleAirWallType_UnionUnion FromIToggleAirWallType(IToggleAirWallTypeT _itoggleairwalltype)
		{
			return new IToggleAirWallType_UnionUnion
			{
				Type = IToggleAirWallType_Union.IToggleAirWallType,
				Value = _itoggleairwalltype
			};
		}

		// Token: 0x06035EAF RID: 220847 RVA: 0x007566A4 File Offset: 0x007548A4
		public IOpenAirWallT AsIOpenAirWall()
		{
			return this.As<IOpenAirWallT>();
		}

		// Token: 0x06035EB0 RID: 220848 RVA: 0x007566AC File Offset: 0x007548AC
		public static IToggleAirWallType_UnionUnion FromIOpenAirWall(IOpenAirWallT _iopenairwall)
		{
			return new IToggleAirWallType_UnionUnion
			{
				Type = IToggleAirWallType_Union.IOpenAirWall,
				Value = _iopenairwall
			};
		}

		// Token: 0x06035EB1 RID: 220849 RVA: 0x007566C1 File Offset: 0x007548C1
		public ICloseAirWallT AsICloseAirWall()
		{
			return this.As<ICloseAirWallT>();
		}

		// Token: 0x06035EB2 RID: 220850 RVA: 0x007566C9 File Offset: 0x007548C9
		public static IToggleAirWallType_UnionUnion FromICloseAirWall(ICloseAirWallT _icloseairwall)
		{
			return new IToggleAirWallType_UnionUnion
			{
				Type = IToggleAirWallType_Union.ICloseAirWall,
				Value = _icloseairwall
			};
		}

		// Token: 0x06035EB3 RID: 220851 RVA: 0x007566E0 File Offset: 0x007548E0
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
