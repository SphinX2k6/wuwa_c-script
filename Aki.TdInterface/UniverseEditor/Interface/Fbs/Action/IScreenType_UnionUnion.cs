using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F4C RID: 28492
	public class IScreenType_UnionUnion
	{
		// Token: 0x1700D3B7 RID: 54199
		// (get) Token: 0x0603255B RID: 206171 RVA: 0x006CC079 File Offset: 0x006CA279
		// (set) Token: 0x0603255C RID: 206172 RVA: 0x006CC081 File Offset: 0x006CA281
		public IScreenType_Union Type { get; set; }

		// Token: 0x1700D3B8 RID: 54200
		// (get) Token: 0x0603255D RID: 206173 RVA: 0x006CC08A File Offset: 0x006CA28A
		// (set) Token: 0x0603255E RID: 206174 RVA: 0x006CC092 File Offset: 0x006CA292
		public object Value { get; set; }

		// Token: 0x0603255F RID: 206175 RVA: 0x006CC09B File Offset: 0x006CA29B
		public IScreenType_UnionUnion()
		{
			this.Type = IScreenType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032560 RID: 206176 RVA: 0x006CC0B1 File Offset: 0x006CA2B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032561 RID: 206177 RVA: 0x006CC0C3 File Offset: 0x006CA2C3
		public IScreenTypeT AsIScreenType()
		{
			return this.As<IScreenTypeT>();
		}

		// Token: 0x06032562 RID: 206178 RVA: 0x006CC0CB File Offset: 0x006CA2CB
		public static IScreenType_UnionUnion FromIScreenType(IScreenTypeT _iscreentype)
		{
			return new IScreenType_UnionUnion
			{
				Type = IScreenType_Union.IScreenType,
				Value = _iscreentype
			};
		}

		// Token: 0x06032563 RID: 206179 RVA: 0x006CC0E0 File Offset: 0x006CA2E0
		public IMainScreenT AsIMainScreen()
		{
			return this.As<IMainScreenT>();
		}

		// Token: 0x06032564 RID: 206180 RVA: 0x006CC0E8 File Offset: 0x006CA2E8
		public static IScreenType_UnionUnion FromIMainScreen(IMainScreenT _imainscreen)
		{
			return new IScreenType_UnionUnion
			{
				Type = IScreenType_Union.IMainScreen,
				Value = _imainscreen
			};
		}

		// Token: 0x06032565 RID: 206181 RVA: 0x006CC0FD File Offset: 0x006CA2FD
		public ISubScreenT AsISubScreen()
		{
			return this.As<ISubScreenT>();
		}

		// Token: 0x06032566 RID: 206182 RVA: 0x006CC105 File Offset: 0x006CA305
		public static IScreenType_UnionUnion FromISubScreen(ISubScreenT _isubscreen)
		{
			return new IScreenType_UnionUnion
			{
				Type = IScreenType_Union.ISubScreen,
				Value = _isubscreen
			};
		}

		// Token: 0x06032567 RID: 206183 RVA: 0x006CC11C File Offset: 0x006CA31C
		public static int Pack(FlatBufferBuilder builder, IScreenType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IScreenType_Union.IScreenType:
				return IScreenType.Pack(builder, _o.AsIScreenType()).Value;
			case IScreenType_Union.IMainScreen:
				return IMainScreen.Pack(builder, _o.AsIMainScreen()).Value;
			case IScreenType_Union.ISubScreen:
				return ISubScreen.Pack(builder, _o.AsISubScreen()).Value;
			default:
				return 0;
			}
		}
	}
}
