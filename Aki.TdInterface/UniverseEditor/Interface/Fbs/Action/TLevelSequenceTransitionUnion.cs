using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F19 RID: 32537
	public class TLevelSequenceTransitionUnion
	{
		// Token: 0x1700F289 RID: 62089
		// (get) Token: 0x0603AB2F RID: 240431 RVA: 0x007E5008 File Offset: 0x007E3208
		// (set) Token: 0x0603AB30 RID: 240432 RVA: 0x007E5010 File Offset: 0x007E3210
		public TLevelSequenceTransition Type { get; set; }

		// Token: 0x1700F28A RID: 62090
		// (get) Token: 0x0603AB31 RID: 240433 RVA: 0x007E5019 File Offset: 0x007E3219
		// (set) Token: 0x0603AB32 RID: 240434 RVA: 0x007E5021 File Offset: 0x007E3221
		public object Value { get; set; }

		// Token: 0x0603AB33 RID: 240435 RVA: 0x007E502A File Offset: 0x007E322A
		public TLevelSequenceTransitionUnion()
		{
			this.Type = TLevelSequenceTransition.NONE;
			this.Value = null;
		}

		// Token: 0x0603AB34 RID: 240436 RVA: 0x007E5040 File Offset: 0x007E3240
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AB35 RID: 240437 RVA: 0x007E5052 File Offset: 0x007E3252
		public ICameraTransitionT AsICameraTransition()
		{
			return this.As<ICameraTransitionT>();
		}

		// Token: 0x0603AB36 RID: 240438 RVA: 0x007E505A File Offset: 0x007E325A
		public static TLevelSequenceTransitionUnion FromICameraTransition(ICameraTransitionT _icameratransition)
		{
			return new TLevelSequenceTransitionUnion
			{
				Type = TLevelSequenceTransition.ICameraTransition,
				Value = _icameratransition
			};
		}

		// Token: 0x0603AB37 RID: 240439 RVA: 0x007E506F File Offset: 0x007E326F
		public IMaskTransitionT AsIMaskTransition()
		{
			return this.As<IMaskTransitionT>();
		}

		// Token: 0x0603AB38 RID: 240440 RVA: 0x007E5077 File Offset: 0x007E3277
		public static TLevelSequenceTransitionUnion FromIMaskTransition(IMaskTransitionT _imasktransition)
		{
			return new TLevelSequenceTransitionUnion
			{
				Type = TLevelSequenceTransition.IMaskTransition,
				Value = _imasktransition
			};
		}

		// Token: 0x0603AB39 RID: 240441 RVA: 0x007E508C File Offset: 0x007E328C
		public static int Pack(FlatBufferBuilder builder, TLevelSequenceTransitionUnion _o)
		{
			TLevelSequenceTransition type = _o.Type;
			if (type == TLevelSequenceTransition.ICameraTransition)
			{
				return ICameraTransition.Pack(builder, _o.AsICameraTransition()).Value;
			}
			if (type != TLevelSequenceTransition.IMaskTransition)
			{
				return 0;
			}
			return IMaskTransition.Pack(builder, _o.AsIMaskTransition()).Value;
		}
	}
}
