using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABA RID: 23226
	public class IMechascoutDragTypeBase_UnionUnion
	{
		// Token: 0x1700A946 RID: 43334
		// (get) Token: 0x06026155 RID: 155989 RVA: 0x00537B59 File Offset: 0x00535D59
		// (set) Token: 0x06026156 RID: 155990 RVA: 0x00537B61 File Offset: 0x00535D61
		public IMechascoutDragTypeBase_Union Type { get; set; }

		// Token: 0x1700A947 RID: 43335
		// (get) Token: 0x06026157 RID: 155991 RVA: 0x00537B6A File Offset: 0x00535D6A
		// (set) Token: 0x06026158 RID: 155992 RVA: 0x00537B72 File Offset: 0x00535D72
		public object Value { get; set; }

		// Token: 0x06026159 RID: 155993 RVA: 0x00537B7B File Offset: 0x00535D7B
		public IMechascoutDragTypeBase_UnionUnion()
		{
			this.Type = IMechascoutDragTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602615A RID: 155994 RVA: 0x00537B91 File Offset: 0x00535D91
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602615B RID: 155995 RVA: 0x00537BA3 File Offset: 0x00535DA3
		public IMechascoutDragTypeBaseT AsIMechascoutDragTypeBase()
		{
			return this.As<IMechascoutDragTypeBaseT>();
		}

		// Token: 0x0602615C RID: 155996 RVA: 0x00537BAB File Offset: 0x00535DAB
		public static IMechascoutDragTypeBase_UnionUnion FromIMechascoutDragTypeBase(IMechascoutDragTypeBaseT _imechascoutdragtypebase)
		{
			return new IMechascoutDragTypeBase_UnionUnion
			{
				Type = IMechascoutDragTypeBase_Union.IMechascoutDragTypeBase,
				Value = _imechascoutdragtypebase
			};
		}

		// Token: 0x0602615D RID: 155997 RVA: 0x00537BC0 File Offset: 0x00535DC0
		public IMechascoutDragInstantT AsIMechascoutDragInstant()
		{
			return this.As<IMechascoutDragInstantT>();
		}

		// Token: 0x0602615E RID: 155998 RVA: 0x00537BC8 File Offset: 0x00535DC8
		public static IMechascoutDragTypeBase_UnionUnion FromIMechascoutDragInstant(IMechascoutDragInstantT _imechascoutdraginstant)
		{
			return new IMechascoutDragTypeBase_UnionUnion
			{
				Type = IMechascoutDragTypeBase_Union.IMechascoutDragInstant,
				Value = _imechascoutdraginstant
			};
		}

		// Token: 0x0602615F RID: 155999 RVA: 0x00537BDD File Offset: 0x00535DDD
		public IMechascoutDragLongPressT AsIMechascoutDragLongPress()
		{
			return this.As<IMechascoutDragLongPressT>();
		}

		// Token: 0x06026160 RID: 156000 RVA: 0x00537BE5 File Offset: 0x00535DE5
		public static IMechascoutDragTypeBase_UnionUnion FromIMechascoutDragLongPress(IMechascoutDragLongPressT _imechascoutdraglongpress)
		{
			return new IMechascoutDragTypeBase_UnionUnion
			{
				Type = IMechascoutDragTypeBase_Union.IMechascoutDragLongPress,
				Value = _imechascoutdraglongpress
			};
		}

		// Token: 0x06026161 RID: 156001 RVA: 0x00537BFC File Offset: 0x00535DFC
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
