using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A83 RID: 31363
	public class ITalkEffectActionType_UnionUnion
	{
		// Token: 0x1700E5B6 RID: 58806
		// (get) Token: 0x06037471 RID: 226417 RVA: 0x00761995 File Offset: 0x0075FB95
		// (set) Token: 0x06037472 RID: 226418 RVA: 0x0076199D File Offset: 0x0075FB9D
		public ITalkEffectActionType_Union Type { get; set; }

		// Token: 0x1700E5B7 RID: 58807
		// (get) Token: 0x06037473 RID: 226419 RVA: 0x007619A6 File Offset: 0x0075FBA6
		// (set) Token: 0x06037474 RID: 226420 RVA: 0x007619AE File Offset: 0x0075FBAE
		public object Value { get; set; }

		// Token: 0x06037475 RID: 226421 RVA: 0x007619B7 File Offset: 0x0075FBB7
		public ITalkEffectActionType_UnionUnion()
		{
			this.Type = ITalkEffectActionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06037476 RID: 226422 RVA: 0x007619CD File Offset: 0x0075FBCD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037477 RID: 226423 RVA: 0x007619DF File Offset: 0x0075FBDF
		public ITalkEffectActionTypeT AsITalkEffectActionType()
		{
			return this.As<ITalkEffectActionTypeT>();
		}

		// Token: 0x06037478 RID: 226424 RVA: 0x007619E7 File Offset: 0x0075FBE7
		public static ITalkEffectActionType_UnionUnion FromITalkEffectActionType(ITalkEffectActionTypeT _italkeffectactiontype)
		{
			return new ITalkEffectActionType_UnionUnion
			{
				Type = ITalkEffectActionType_Union.ITalkEffectActionType,
				Value = _italkeffectactiontype
			};
		}

		// Token: 0x06037479 RID: 226425 RVA: 0x007619FC File Offset: 0x0075FBFC
		public ITalkEffectPlayT AsITalkEffectPlay()
		{
			return this.As<ITalkEffectPlayT>();
		}

		// Token: 0x0603747A RID: 226426 RVA: 0x00761A04 File Offset: 0x0075FC04
		public static ITalkEffectActionType_UnionUnion FromITalkEffectPlay(ITalkEffectPlayT _italkeffectplay)
		{
			return new ITalkEffectActionType_UnionUnion
			{
				Type = ITalkEffectActionType_Union.ITalkEffectPlay,
				Value = _italkeffectplay
			};
		}

		// Token: 0x0603747B RID: 226427 RVA: 0x00761A19 File Offset: 0x0075FC19
		public ITalkEffectStopT AsITalkEffectStop()
		{
			return this.As<ITalkEffectStopT>();
		}

		// Token: 0x0603747C RID: 226428 RVA: 0x00761A21 File Offset: 0x0075FC21
		public static ITalkEffectActionType_UnionUnion FromITalkEffectStop(ITalkEffectStopT _italkeffectstop)
		{
			return new ITalkEffectActionType_UnionUnion
			{
				Type = ITalkEffectActionType_Union.ITalkEffectStop,
				Value = _italkeffectstop
			};
		}

		// Token: 0x0603747D RID: 226429 RVA: 0x00761A38 File Offset: 0x0075FC38
		public static int Pack(FlatBufferBuilder builder, ITalkEffectActionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkEffectActionType_Union.ITalkEffectActionType:
				return ITalkEffectActionType.Pack(builder, _o.AsITalkEffectActionType()).Value;
			case ITalkEffectActionType_Union.ITalkEffectPlay:
				return ITalkEffectPlay.Pack(builder, _o.AsITalkEffectPlay()).Value;
			case ITalkEffectActionType_Union.ITalkEffectStop:
				return ITalkEffectStop.Pack(builder, _o.AsITalkEffectStop()).Value;
			default:
				return 0;
			}
		}
	}
}
