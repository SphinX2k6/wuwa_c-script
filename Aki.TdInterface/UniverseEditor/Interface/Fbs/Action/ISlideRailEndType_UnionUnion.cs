using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714C RID: 29004
	public class ISlideRailEndType_UnionUnion
	{
		// Token: 0x1700D77B RID: 55163
		// (get) Token: 0x060336A4 RID: 210596 RVA: 0x006EDA6D File Offset: 0x006EBC6D
		// (set) Token: 0x060336A5 RID: 210597 RVA: 0x006EDA75 File Offset: 0x006EBC75
		public ISlideRailEndType_Union Type { get; set; }

		// Token: 0x1700D77C RID: 55164
		// (get) Token: 0x060336A6 RID: 210598 RVA: 0x006EDA7E File Offset: 0x006EBC7E
		// (set) Token: 0x060336A7 RID: 210599 RVA: 0x006EDA86 File Offset: 0x006EBC86
		public object Value { get; set; }

		// Token: 0x060336A8 RID: 210600 RVA: 0x006EDA8F File Offset: 0x006EBC8F
		public ISlideRailEndType_UnionUnion()
		{
			this.Type = ISlideRailEndType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060336A9 RID: 210601 RVA: 0x006EDAA5 File Offset: 0x006EBCA5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060336AA RID: 210602 RVA: 0x006EDAB7 File Offset: 0x006EBCB7
		public ISlideRailEndTypeT AsISlideRailEndType()
		{
			return this.As<ISlideRailEndTypeT>();
		}

		// Token: 0x060336AB RID: 210603 RVA: 0x006EDABF File Offset: 0x006EBCBF
		public static ISlideRailEndType_UnionUnion FromISlideRailEndType(ISlideRailEndTypeT _isliderailendtype)
		{
			return new ISlideRailEndType_UnionUnion
			{
				Type = ISlideRailEndType_Union.ISlideRailEndType,
				Value = _isliderailendtype
			};
		}

		// Token: 0x060336AC RID: 210604 RVA: 0x006EDAD4 File Offset: 0x006EBCD4
		public IPlayerSlideRailEndT AsIPlayerSlideRailEnd()
		{
			return this.As<IPlayerSlideRailEndT>();
		}

		// Token: 0x060336AD RID: 210605 RVA: 0x006EDADC File Offset: 0x006EBCDC
		public static ISlideRailEndType_UnionUnion FromIPlayerSlideRailEnd(IPlayerSlideRailEndT _iplayersliderailend)
		{
			return new ISlideRailEndType_UnionUnion
			{
				Type = ISlideRailEndType_Union.IPlayerSlideRailEnd,
				Value = _iplayersliderailend
			};
		}

		// Token: 0x060336AE RID: 210606 RVA: 0x006EDAF1 File Offset: 0x006EBCF1
		public IAiFollowerSlideRailEndT AsIAiFollowerSlideRailEnd()
		{
			return this.As<IAiFollowerSlideRailEndT>();
		}

		// Token: 0x060336AF RID: 210607 RVA: 0x006EDAF9 File Offset: 0x006EBCF9
		public static ISlideRailEndType_UnionUnion FromIAiFollowerSlideRailEnd(IAiFollowerSlideRailEndT _iaifollowersliderailend)
		{
			return new ISlideRailEndType_UnionUnion
			{
				Type = ISlideRailEndType_Union.IAiFollowerSlideRailEnd,
				Value = _iaifollowersliderailend
			};
		}

		// Token: 0x060336B0 RID: 210608 RVA: 0x006EDB10 File Offset: 0x006EBD10
		public static int Pack(FlatBufferBuilder builder, ISlideRailEndType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISlideRailEndType_Union.ISlideRailEndType:
				return ISlideRailEndType.Pack(builder, _o.AsISlideRailEndType()).Value;
			case ISlideRailEndType_Union.IPlayerSlideRailEnd:
				return IPlayerSlideRailEnd.Pack(builder, _o.AsIPlayerSlideRailEnd()).Value;
			case ISlideRailEndType_Union.IAiFollowerSlideRailEnd:
				return IAiFollowerSlideRailEnd.Pack(builder, _o.AsIAiFollowerSlideRailEnd()).Value;
			default:
				return 0;
			}
		}
	}
}
