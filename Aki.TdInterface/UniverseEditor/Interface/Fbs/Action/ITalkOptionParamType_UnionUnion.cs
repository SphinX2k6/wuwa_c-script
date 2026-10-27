using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007335 RID: 29493
	public class ITalkOptionParamType_UnionUnion
	{
		// Token: 0x1700E001 RID: 57345
		// (get) Token: 0x06035850 RID: 219216 RVA: 0x0074A725 File Offset: 0x00748925
		// (set) Token: 0x06035851 RID: 219217 RVA: 0x0074A72D File Offset: 0x0074892D
		public ITalkOptionParamType_Union Type { get; set; }

		// Token: 0x1700E002 RID: 57346
		// (get) Token: 0x06035852 RID: 219218 RVA: 0x0074A736 File Offset: 0x00748936
		// (set) Token: 0x06035853 RID: 219219 RVA: 0x0074A73E File Offset: 0x0074893E
		public object Value { get; set; }

		// Token: 0x06035854 RID: 219220 RVA: 0x0074A747 File Offset: 0x00748947
		public ITalkOptionParamType_UnionUnion()
		{
			this.Type = ITalkOptionParamType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035855 RID: 219221 RVA: 0x0074A75D File Offset: 0x0074895D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035856 RID: 219222 RVA: 0x0074A76F File Offset: 0x0074896F
		public ITalkOptionParamTypeT AsITalkOptionParamType()
		{
			return this.As<ITalkOptionParamTypeT>();
		}

		// Token: 0x06035857 RID: 219223 RVA: 0x0074A777 File Offset: 0x00748977
		public static ITalkOptionParamType_UnionUnion FromITalkOptionParamType(ITalkOptionParamTypeT _italkoptionparamtype)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionParamType,
				Value = _italkoptionparamtype
			};
		}

		// Token: 0x06035858 RID: 219224 RVA: 0x0074A78C File Offset: 0x0074898C
		public ITalkOptionQteSucceedT AsITalkOptionQteSucceed()
		{
			return this.As<ITalkOptionQteSucceedT>();
		}

		// Token: 0x06035859 RID: 219225 RVA: 0x0074A794 File Offset: 0x00748994
		public static ITalkOptionParamType_UnionUnion FromITalkOptionQteSucceed(ITalkOptionQteSucceedT _italkoptionqtesucceed)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionQteSucceed,
				Value = _italkoptionqtesucceed
			};
		}

		// Token: 0x0603585A RID: 219226 RVA: 0x0074A7A9 File Offset: 0x007489A9
		public ITalkOptionQteFailedT AsITalkOptionQteFailed()
		{
			return this.As<ITalkOptionQteFailedT>();
		}

		// Token: 0x0603585B RID: 219227 RVA: 0x0074A7B1 File Offset: 0x007489B1
		public static ITalkOptionParamType_UnionUnion FromITalkOptionQteFailed(ITalkOptionQteFailedT _italkoptionqtefailed)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionQteFailed,
				Value = _italkoptionqtefailed
			};
		}

		// Token: 0x0603585C RID: 219228 RVA: 0x0074A7C6 File Offset: 0x007489C6
		public ITalkOptionQteSucceedDelayExecT AsITalkOptionQteSucceedDelayExec()
		{
			return this.As<ITalkOptionQteSucceedDelayExecT>();
		}

		// Token: 0x0603585D RID: 219229 RVA: 0x0074A7CE File Offset: 0x007489CE
		public static ITalkOptionParamType_UnionUnion FromITalkOptionQteSucceedDelayExec(ITalkOptionQteSucceedDelayExecT _italkoptionqtesucceeddelayexec)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionQteSucceedDelayExec,
				Value = _italkoptionqtesucceeddelayexec
			};
		}

		// Token: 0x0603585E RID: 219230 RVA: 0x0074A7E3 File Offset: 0x007489E3
		public ITalkOptionQteFailedDelayExecT AsITalkOptionQteFailedDelayExec()
		{
			return this.As<ITalkOptionQteFailedDelayExecT>();
		}

		// Token: 0x0603585F RID: 219231 RVA: 0x0074A7EB File Offset: 0x007489EB
		public static ITalkOptionParamType_UnionUnion FromITalkOptionQteFailedDelayExec(ITalkOptionQteFailedDelayExecT _italkoptionqtefaileddelayexec)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionQteFailedDelayExec,
				Value = _italkoptionqtefaileddelayexec
			};
		}

		// Token: 0x06035860 RID: 219232 RVA: 0x0074A800 File Offset: 0x00748A00
		public ITalkOptionRogueRandomEventT AsITalkOptionRogueRandomEvent()
		{
			return this.As<ITalkOptionRogueRandomEventT>();
		}

		// Token: 0x06035861 RID: 219233 RVA: 0x0074A808 File Offset: 0x00748A08
		public static ITalkOptionParamType_UnionUnion FromITalkOptionRogueRandomEvent(ITalkOptionRogueRandomEventT _italkoptionroguerandomevent)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionRogueRandomEvent,
				Value = _italkoptionroguerandomevent
			};
		}

		// Token: 0x06035862 RID: 219234 RVA: 0x0074A81D File Offset: 0x00748A1D
		public ITalkOptionPhoneMessageEmojiT AsITalkOptionPhoneMessageEmoji()
		{
			return this.As<ITalkOptionPhoneMessageEmojiT>();
		}

		// Token: 0x06035863 RID: 219235 RVA: 0x0074A825 File Offset: 0x00748A25
		public static ITalkOptionParamType_UnionUnion FromITalkOptionPhoneMessageEmoji(ITalkOptionPhoneMessageEmojiT _italkoptionphonemessageemoji)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionPhoneMessageEmoji,
				Value = _italkoptionphonemessageemoji
			};
		}

		// Token: 0x06035864 RID: 219236 RVA: 0x0074A83A File Offset: 0x00748A3A
		public ITalkOptionVisualNovelT AsITalkOptionVisualNovel()
		{
			return this.As<ITalkOptionVisualNovelT>();
		}

		// Token: 0x06035865 RID: 219237 RVA: 0x0074A842 File Offset: 0x00748A42
		public static ITalkOptionParamType_UnionUnion FromITalkOptionVisualNovel(ITalkOptionVisualNovelT _italkoptionvisualnovel)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionVisualNovel,
				Value = _italkoptionvisualnovel
			};
		}

		// Token: 0x06035866 RID: 219238 RVA: 0x0074A858 File Offset: 0x00748A58
		public static int Pack(FlatBufferBuilder builder, ITalkOptionParamType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkOptionParamType_Union.ITalkOptionParamType:
				return ITalkOptionParamType.Pack(builder, _o.AsITalkOptionParamType()).Value;
			case ITalkOptionParamType_Union.ITalkOptionQteSucceed:
				return ITalkOptionQteSucceed.Pack(builder, _o.AsITalkOptionQteSucceed()).Value;
			case ITalkOptionParamType_Union.ITalkOptionQteFailed:
				return ITalkOptionQteFailed.Pack(builder, _o.AsITalkOptionQteFailed()).Value;
			case ITalkOptionParamType_Union.ITalkOptionQteSucceedDelayExec:
				return ITalkOptionQteSucceedDelayExec.Pack(builder, _o.AsITalkOptionQteSucceedDelayExec()).Value;
			case ITalkOptionParamType_Union.ITalkOptionQteFailedDelayExec:
				return ITalkOptionQteFailedDelayExec.Pack(builder, _o.AsITalkOptionQteFailedDelayExec()).Value;
			case ITalkOptionParamType_Union.ITalkOptionRogueRandomEvent:
				return ITalkOptionRogueRandomEvent.Pack(builder, _o.AsITalkOptionRogueRandomEvent()).Value;
			case ITalkOptionParamType_Union.ITalkOptionPhoneMessageEmoji:
				return ITalkOptionPhoneMessageEmoji.Pack(builder, _o.AsITalkOptionPhoneMessageEmoji()).Value;
			case ITalkOptionParamType_Union.ITalkOptionVisualNovel:
				return ITalkOptionVisualNovel.Pack(builder, _o.AsITalkOptionVisualNovel()).Value;
			default:
				return 0;
			}
		}
	}
}
