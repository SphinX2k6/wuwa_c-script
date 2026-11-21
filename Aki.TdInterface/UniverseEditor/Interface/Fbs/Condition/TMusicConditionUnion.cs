using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005245 RID: 21061
	public class TMusicConditionUnion
	{
		// Token: 0x17009684 RID: 38532
		// (get) Token: 0x060212AB RID: 135851 RVA: 0x00494212 File Offset: 0x00492412
		// (set) Token: 0x060212AC RID: 135852 RVA: 0x0049421A File Offset: 0x0049241A
		public TMusicCondition Type { get; set; }

		// Token: 0x17009685 RID: 38533
		// (get) Token: 0x060212AD RID: 135853 RVA: 0x00494223 File Offset: 0x00492423
		// (set) Token: 0x060212AE RID: 135854 RVA: 0x0049422B File Offset: 0x0049242B
		public object Value { get; set; }

		// Token: 0x060212AF RID: 135855 RVA: 0x00494234 File Offset: 0x00492434
		public TMusicConditionUnion()
		{
			this.Type = TMusicCondition.NONE;
			this.Value = null;
		}

		// Token: 0x060212B0 RID: 135856 RVA: 0x0049424A File Offset: 0x0049244A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060212B1 RID: 135857 RVA: 0x0049425C File Offset: 0x0049245C
		public ICheckFlForestMusicBeatsT AsICheckFlForestMusicBeats()
		{
			return this.As<ICheckFlForestMusicBeatsT>();
		}

		// Token: 0x060212B2 RID: 135858 RVA: 0x00494264 File Offset: 0x00492464
		public static TMusicConditionUnion FromICheckFlForestMusicBeats(ICheckFlForestMusicBeatsT _icheckflforestmusicbeats)
		{
			return new TMusicConditionUnion
			{
				Type = TMusicCondition.ICheckFlForestMusicBeats,
				Value = _icheckflforestmusicbeats
			};
		}

		// Token: 0x060212B3 RID: 135859 RVA: 0x00494279 File Offset: 0x00492479
		public ICheckHcMusicBeatsT AsICheckHcMusicBeats()
		{
			return this.As<ICheckHcMusicBeatsT>();
		}

		// Token: 0x060212B4 RID: 135860 RVA: 0x00494281 File Offset: 0x00492481
		public static TMusicConditionUnion FromICheckHcMusicBeats(ICheckHcMusicBeatsT _icheckhcmusicbeats)
		{
			return new TMusicConditionUnion
			{
				Type = TMusicCondition.ICheckHcMusicBeats,
				Value = _icheckhcmusicbeats
			};
		}

		// Token: 0x060212B5 RID: 135861 RVA: 0x00494298 File Offset: 0x00492498
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
