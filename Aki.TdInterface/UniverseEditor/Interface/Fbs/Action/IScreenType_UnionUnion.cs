using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007706 RID: 30470
	public class IScreenType_UnionUnion
	{
		// Token: 0x1700DF76 RID: 57206
		// (get) Token: 0x0603575B RID: 218971 RVA: 0x0072B335 File Offset: 0x00729535
		// (set) Token: 0x0603575C RID: 218972 RVA: 0x0072B33D File Offset: 0x0072953D
		public IScreenType_Union Type { get; set; }

		// Token: 0x1700DF77 RID: 57207
		// (get) Token: 0x0603575D RID: 218973 RVA: 0x0072B346 File Offset: 0x00729546
		// (set) Token: 0x0603575E RID: 218974 RVA: 0x0072B34E File Offset: 0x0072954E
		public object Value { get; set; }

		// Token: 0x0603575F RID: 218975 RVA: 0x0072B357 File Offset: 0x00729557
		public IScreenType_UnionUnion()
		{
			this.Type = IScreenType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035760 RID: 218976 RVA: 0x0072B36D File Offset: 0x0072956D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035761 RID: 218977 RVA: 0x0072B37F File Offset: 0x0072957F
		public IScreenTypeT AsIScreenType()
		{
			return this.As<IScreenTypeT>();
		}

		// Token: 0x06035762 RID: 218978 RVA: 0x0072B387 File Offset: 0x00729587
		public static IScreenType_UnionUnion FromIScreenType(IScreenTypeT _iscreentype)
		{
			return new IScreenType_UnionUnion
			{
				Type = IScreenType_Union.IScreenType,
				Value = _iscreentype
			};
		}

		// Token: 0x06035763 RID: 218979 RVA: 0x0072B39C File Offset: 0x0072959C
		public IMainScreenT AsIMainScreen()
		{
			return this.As<IMainScreenT>();
		}

		// Token: 0x06035764 RID: 218980 RVA: 0x0072B3A4 File Offset: 0x007295A4
		public static IScreenType_UnionUnion FromIMainScreen(IMainScreenT _imainscreen)
		{
			return new IScreenType_UnionUnion
			{
				Type = IScreenType_Union.IMainScreen,
				Value = _imainscreen
			};
		}

		// Token: 0x06035765 RID: 218981 RVA: 0x0072B3B9 File Offset: 0x007295B9
		public ISubScreenT AsISubScreen()
		{
			return this.As<ISubScreenT>();
		}

		// Token: 0x06035766 RID: 218982 RVA: 0x0072B3C1 File Offset: 0x007295C1
		public static IScreenType_UnionUnion FromISubScreen(ISubScreenT _isubscreen)
		{
			return new IScreenType_UnionUnion
			{
				Type = IScreenType_Union.ISubScreen,
				Value = _isubscreen
			};
		}

		// Token: 0x06035767 RID: 218983 RVA: 0x0072B3D8 File Offset: 0x007295D8
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
