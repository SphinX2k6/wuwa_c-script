using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5B RID: 23643
	public class TMechascoutDragTypeUnion
	{
		// Token: 0x1700B21A RID: 45594
		// (get) Token: 0x0602885D RID: 165981 RVA: 0x00592CF6 File Offset: 0x00590EF6
		// (set) Token: 0x0602885E RID: 165982 RVA: 0x00592CFE File Offset: 0x00590EFE
		public TMechascoutDragType Type { get; set; }

		// Token: 0x1700B21B RID: 45595
		// (get) Token: 0x0602885F RID: 165983 RVA: 0x00592D07 File Offset: 0x00590F07
		// (set) Token: 0x06028860 RID: 165984 RVA: 0x00592D0F File Offset: 0x00590F0F
		public object Value { get; set; }

		// Token: 0x06028861 RID: 165985 RVA: 0x00592D18 File Offset: 0x00590F18
		public TMechascoutDragTypeUnion()
		{
			this.Type = TMechascoutDragType.NONE;
			this.Value = null;
		}

		// Token: 0x06028862 RID: 165986 RVA: 0x00592D2E File Offset: 0x00590F2E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028863 RID: 165987 RVA: 0x00592D40 File Offset: 0x00590F40
		public IMechascoutDragInstantT AsIMechascoutDragInstant()
		{
			return this.As<IMechascoutDragInstantT>();
		}

		// Token: 0x06028864 RID: 165988 RVA: 0x00592D48 File Offset: 0x00590F48
		public static TMechascoutDragTypeUnion FromIMechascoutDragInstant(IMechascoutDragInstantT _imechascoutdraginstant)
		{
			return new TMechascoutDragTypeUnion
			{
				Type = TMechascoutDragType.IMechascoutDragInstant,
				Value = _imechascoutdraginstant
			};
		}

		// Token: 0x06028865 RID: 165989 RVA: 0x00592D5D File Offset: 0x00590F5D
		public IMechascoutDragLongPressT AsIMechascoutDragLongPress()
		{
			return this.As<IMechascoutDragLongPressT>();
		}

		// Token: 0x06028866 RID: 165990 RVA: 0x00592D65 File Offset: 0x00590F65
		public static TMechascoutDragTypeUnion FromIMechascoutDragLongPress(IMechascoutDragLongPressT _imechascoutdraglongpress)
		{
			return new TMechascoutDragTypeUnion
			{
				Type = TMechascoutDragType.IMechascoutDragLongPress,
				Value = _imechascoutdraglongpress
			};
		}

		// Token: 0x06028867 RID: 165991 RVA: 0x00592D7C File Offset: 0x00590F7C
		public static int Pack(FlatBufferBuilder builder, TMechascoutDragTypeUnion _o)
		{
			TMechascoutDragType type = _o.Type;
			if (type == TMechascoutDragType.IMechascoutDragInstant)
			{
				return IMechascoutDragInstant.Pack(builder, _o.AsIMechascoutDragInstant()).Value;
			}
			if (type != TMechascoutDragType.IMechascoutDragLongPress)
			{
				return 0;
			}
			return IMechascoutDragLongPress.Pack(builder, _o.AsIMechascoutDragLongPress()).Value;
		}
	}
}
