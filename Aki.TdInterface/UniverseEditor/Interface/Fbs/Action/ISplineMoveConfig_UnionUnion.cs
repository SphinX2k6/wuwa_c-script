using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007182 RID: 29058
	public class ISplineMoveConfig_UnionUnion
	{
		// Token: 0x1700D7D8 RID: 55256
		// (get) Token: 0x06033846 RID: 211014 RVA: 0x006F0950 File Offset: 0x006EEB50
		// (set) Token: 0x06033847 RID: 211015 RVA: 0x006F0958 File Offset: 0x006EEB58
		public ISplineMoveConfig_Union Type { get; set; }

		// Token: 0x1700D7D9 RID: 55257
		// (get) Token: 0x06033848 RID: 211016 RVA: 0x006F0961 File Offset: 0x006EEB61
		// (set) Token: 0x06033849 RID: 211017 RVA: 0x006F0969 File Offset: 0x006EEB69
		public object Value { get; set; }

		// Token: 0x0603384A RID: 211018 RVA: 0x006F0972 File Offset: 0x006EEB72
		public ISplineMoveConfig_UnionUnion()
		{
			this.Type = ISplineMoveConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603384B RID: 211019 RVA: 0x006F0988 File Offset: 0x006EEB88
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603384C RID: 211020 RVA: 0x006F099A File Offset: 0x006EEB9A
		public ISplineMoveConfigT AsISplineMoveConfig()
		{
			return this.As<ISplineMoveConfigT>();
		}

		// Token: 0x0603384D RID: 211021 RVA: 0x006F09A2 File Offset: 0x006EEBA2
		public static ISplineMoveConfig_UnionUnion FromISplineMoveConfig(ISplineMoveConfigT _isplinemoveconfig)
		{
			return new ISplineMoveConfig_UnionUnion
			{
				Type = ISplineMoveConfig_Union.ISplineMoveConfig,
				Value = _isplinemoveconfig
			};
		}

		// Token: 0x0603384E RID: 211022 RVA: 0x006F09B7 File Offset: 0x006EEBB7
		public IOpenSplineMoveT AsIOpenSplineMove()
		{
			return this.As<IOpenSplineMoveT>();
		}

		// Token: 0x0603384F RID: 211023 RVA: 0x006F09BF File Offset: 0x006EEBBF
		public static ISplineMoveConfig_UnionUnion FromIOpenSplineMove(IOpenSplineMoveT _iopensplinemove)
		{
			return new ISplineMoveConfig_UnionUnion
			{
				Type = ISplineMoveConfig_Union.IOpenSplineMove,
				Value = _iopensplinemove
			};
		}

		// Token: 0x06033850 RID: 211024 RVA: 0x006F09D4 File Offset: 0x006EEBD4
		public ICloseSplineMoveT AsICloseSplineMove()
		{
			return this.As<ICloseSplineMoveT>();
		}

		// Token: 0x06033851 RID: 211025 RVA: 0x006F09DC File Offset: 0x006EEBDC
		public static ISplineMoveConfig_UnionUnion FromICloseSplineMove(ICloseSplineMoveT _iclosesplinemove)
		{
			return new ISplineMoveConfig_UnionUnion
			{
				Type = ISplineMoveConfig_Union.ICloseSplineMove,
				Value = _iclosesplinemove
			};
		}

		// Token: 0x06033852 RID: 211026 RVA: 0x006F09F4 File Offset: 0x006EEBF4
		public static int Pack(FlatBufferBuilder builder, ISplineMoveConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISplineMoveConfig_Union.ISplineMoveConfig:
				return ISplineMoveConfig.Pack(builder, _o.AsISplineMoveConfig()).Value;
			case ISplineMoveConfig_Union.IOpenSplineMove:
				return IOpenSplineMove.Pack(builder, _o.AsIOpenSplineMove()).Value;
			case ISplineMoveConfig_Union.ICloseSplineMove:
				return ICloseSplineMove.Pack(builder, _o.AsICloseSplineMove()).Value;
			default:
				return 0;
			}
		}
	}
}
