using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005534 RID: 21812
	public class IMechascoutDragTypeBase_UnionUnion
	{
		// Token: 0x1700A10C RID: 41228
		// (get) Token: 0x0602409B RID: 147611 RVA: 0x004FAA35 File Offset: 0x004F8C35
		// (set) Token: 0x0602409C RID: 147612 RVA: 0x004FAA3D File Offset: 0x004F8C3D
		public IMechascoutDragTypeBase_Union Type { get; set; }

		// Token: 0x1700A10D RID: 41229
		// (get) Token: 0x0602409D RID: 147613 RVA: 0x004FAA46 File Offset: 0x004F8C46
		// (set) Token: 0x0602409E RID: 147614 RVA: 0x004FAA4E File Offset: 0x004F8C4E
		public object Value { get; set; }

		// Token: 0x0602409F RID: 147615 RVA: 0x004FAA57 File Offset: 0x004F8C57
		public IMechascoutDragTypeBase_UnionUnion()
		{
			this.Type = IMechascoutDragTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060240A0 RID: 147616 RVA: 0x004FAA6D File Offset: 0x004F8C6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060240A1 RID: 147617 RVA: 0x004FAA7F File Offset: 0x004F8C7F
		public IMechascoutDragTypeBaseT AsIMechascoutDragTypeBase()
		{
			return this.As<IMechascoutDragTypeBaseT>();
		}

		// Token: 0x060240A2 RID: 147618 RVA: 0x004FAA87 File Offset: 0x004F8C87
		public static IMechascoutDragTypeBase_UnionUnion FromIMechascoutDragTypeBase(IMechascoutDragTypeBaseT _imechascoutdragtypebase)
		{
			return new IMechascoutDragTypeBase_UnionUnion
			{
				Type = IMechascoutDragTypeBase_Union.IMechascoutDragTypeBase,
				Value = _imechascoutdragtypebase
			};
		}

		// Token: 0x060240A3 RID: 147619 RVA: 0x004FAA9C File Offset: 0x004F8C9C
		public IMechascoutDragInstantT AsIMechascoutDragInstant()
		{
			return this.As<IMechascoutDragInstantT>();
		}

		// Token: 0x060240A4 RID: 147620 RVA: 0x004FAAA4 File Offset: 0x004F8CA4
		public static IMechascoutDragTypeBase_UnionUnion FromIMechascoutDragInstant(IMechascoutDragInstantT _imechascoutdraginstant)
		{
			return new IMechascoutDragTypeBase_UnionUnion
			{
				Type = IMechascoutDragTypeBase_Union.IMechascoutDragInstant,
				Value = _imechascoutdraginstant
			};
		}

		// Token: 0x060240A5 RID: 147621 RVA: 0x004FAAB9 File Offset: 0x004F8CB9
		public IMechascoutDragLongPressT AsIMechascoutDragLongPress()
		{
			return this.As<IMechascoutDragLongPressT>();
		}

		// Token: 0x060240A6 RID: 147622 RVA: 0x004FAAC1 File Offset: 0x004F8CC1
		public static IMechascoutDragTypeBase_UnionUnion FromIMechascoutDragLongPress(IMechascoutDragLongPressT _imechascoutdraglongpress)
		{
			return new IMechascoutDragTypeBase_UnionUnion
			{
				Type = IMechascoutDragTypeBase_Union.IMechascoutDragLongPress,
				Value = _imechascoutdraglongpress
			};
		}

		// Token: 0x060240A7 RID: 147623 RVA: 0x004FAAD8 File Offset: 0x004F8CD8
		public static int Pack(FlatBufferBuilder builder, IMechascoutDragTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMechascoutDragTypeBase_Union.IMechascoutDragTypeBase:
				return IMechascoutDragTypeBase.Pack(builder, _o.AsIMechascoutDragTypeBase()).Value;
			case IMechascoutDragTypeBase_Union.IMechascoutDragInstant:
				return IMechascoutDragInstant.Pack(builder, _o.AsIMechascoutDragInstant()).Value;
			case IMechascoutDragTypeBase_Union.IMechascoutDragLongPress:
				return IMechascoutDragLongPress.Pack(builder, _o.AsIMechascoutDragLongPress()).Value;
			default:
				return 0;
			}
		}
	}
}
