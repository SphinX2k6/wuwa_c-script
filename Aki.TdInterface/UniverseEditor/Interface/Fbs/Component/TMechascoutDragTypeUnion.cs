using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006280 RID: 25216
	public class TMechascoutDragTypeUnion
	{
		// Token: 0x1700BB6C RID: 47980
		// (get) Token: 0x0602AE6B RID: 175723 RVA: 0x005DAF0E File Offset: 0x005D910E
		// (set) Token: 0x0602AE6C RID: 175724 RVA: 0x005DAF16 File Offset: 0x005D9116
		public TMechascoutDragType Type { get; set; }

		// Token: 0x1700BB6D RID: 47981
		// (get) Token: 0x0602AE6D RID: 175725 RVA: 0x005DAF1F File Offset: 0x005D911F
		// (set) Token: 0x0602AE6E RID: 175726 RVA: 0x005DAF27 File Offset: 0x005D9127
		public object Value { get; set; }

		// Token: 0x0602AE6F RID: 175727 RVA: 0x005DAF30 File Offset: 0x005D9130
		public TMechascoutDragTypeUnion()
		{
			this.Type = TMechascoutDragType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE70 RID: 175728 RVA: 0x005DAF46 File Offset: 0x005D9146
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE71 RID: 175729 RVA: 0x005DAF58 File Offset: 0x005D9158
		public IMechascoutDragInstantT AsIMechascoutDragInstant()
		{
			return this.As<IMechascoutDragInstantT>();
		}

		// Token: 0x0602AE72 RID: 175730 RVA: 0x005DAF60 File Offset: 0x005D9160
		public static TMechascoutDragTypeUnion FromIMechascoutDragInstant(IMechascoutDragInstantT _imechascoutdraginstant)
		{
			return new TMechascoutDragTypeUnion
			{
				Type = TMechascoutDragType.IMechascoutDragInstant,
				Value = _imechascoutdraginstant
			};
		}

		// Token: 0x0602AE73 RID: 175731 RVA: 0x005DAF75 File Offset: 0x005D9175
		public IMechascoutDragLongPressT AsIMechascoutDragLongPress()
		{
			return this.As<IMechascoutDragLongPressT>();
		}

		// Token: 0x0602AE74 RID: 175732 RVA: 0x005DAF7D File Offset: 0x005D917D
		public static TMechascoutDragTypeUnion FromIMechascoutDragLongPress(IMechascoutDragLongPressT _imechascoutdraglongpress)
		{
			return new TMechascoutDragTypeUnion
			{
				Type = TMechascoutDragType.IMechascoutDragLongPress,
				Value = _imechascoutdraglongpress
			};
		}

		// Token: 0x0602AE75 RID: 175733 RVA: 0x005DAF94 File Offset: 0x005D9194
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
