using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D49 RID: 19785
	public class TMusicConditionUnion
	{
		// Token: 0x17008F4B RID: 36683
		// (get) Token: 0x0601F662 RID: 128610 RVA: 0x0046023E File Offset: 0x0045E43E
		// (set) Token: 0x0601F663 RID: 128611 RVA: 0x00460246 File Offset: 0x0045E446
		public TMusicCondition Type { get; set; }

		// Token: 0x17008F4C RID: 36684
		// (get) Token: 0x0601F664 RID: 128612 RVA: 0x0046024F File Offset: 0x0045E44F
		// (set) Token: 0x0601F665 RID: 128613 RVA: 0x00460257 File Offset: 0x0045E457
		public object Value { get; set; }

		// Token: 0x0601F666 RID: 128614 RVA: 0x00460260 File Offset: 0x0045E460
		public TMusicConditionUnion()
		{
			this.Type = TMusicCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601F667 RID: 128615 RVA: 0x00460276 File Offset: 0x0045E476
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F668 RID: 128616 RVA: 0x00460288 File Offset: 0x0045E488
		public ICheckFlForestMusicBeatsT AsICheckFlForestMusicBeats()
		{
			return this.As<ICheckFlForestMusicBeatsT>();
		}

		// Token: 0x0601F669 RID: 128617 RVA: 0x00460290 File Offset: 0x0045E490
		public static TMusicConditionUnion FromICheckFlForestMusicBeats(ICheckFlForestMusicBeatsT _icheckflforestmusicbeats)
		{
			return new TMusicConditionUnion
			{
				Type = TMusicCondition.ICheckFlForestMusicBeats,
				Value = _icheckflforestmusicbeats
			};
		}

		// Token: 0x0601F66A RID: 128618 RVA: 0x004602A5 File Offset: 0x0045E4A5
		public ICheckHcMusicBeatsT AsICheckHcMusicBeats()
		{
			return this.As<ICheckHcMusicBeatsT>();
		}

		// Token: 0x0601F66B RID: 128619 RVA: 0x004602AD File Offset: 0x0045E4AD
		public static TMusicConditionUnion FromICheckHcMusicBeats(ICheckHcMusicBeatsT _icheckhcmusicbeats)
		{
			return new TMusicConditionUnion
			{
				Type = TMusicCondition.ICheckHcMusicBeats,
				Value = _icheckhcmusicbeats
			};
		}

		// Token: 0x0601F66C RID: 128620 RVA: 0x004602C4 File Offset: 0x0045E4C4
		public static int Pack(FlatBufferBuilder builder, TMusicConditionUnion _o)
		{
			TMusicCondition type = _o.Type;
			if (type == TMusicCondition.ICheckFlForestMusicBeats)
			{
				return ICheckFlForestMusicBeats.Pack(builder, _o.AsICheckFlForestMusicBeats()).Value;
			}
			if (type != TMusicCondition.ICheckHcMusicBeats)
			{
				return 0;
			}
			return ICheckHcMusicBeats.Pack(builder, _o.AsICheckHcMusicBeats()).Value;
		}
	}
}
