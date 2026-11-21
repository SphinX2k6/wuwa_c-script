using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FBC RID: 32700
	public class TSetNpcGroupPerformTypeUnion
	{
		// Token: 0x1700F2F5 RID: 62197
		// (get) Token: 0x0603AE43 RID: 241219 RVA: 0x007E9882 File Offset: 0x007E7A82
		// (set) Token: 0x0603AE44 RID: 241220 RVA: 0x007E988A File Offset: 0x007E7A8A
		public TSetNpcGroupPerformType Type { get; set; }

		// Token: 0x1700F2F6 RID: 62198
		// (get) Token: 0x0603AE45 RID: 241221 RVA: 0x007E9893 File Offset: 0x007E7A93
		// (set) Token: 0x0603AE46 RID: 241222 RVA: 0x007E989B File Offset: 0x007E7A9B
		public object Value { get; set; }

		// Token: 0x0603AE47 RID: 241223 RVA: 0x007E98A4 File Offset: 0x007E7AA4
		public TSetNpcGroupPerformTypeUnion()
		{
			this.Type = TSetNpcGroupPerformType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE48 RID: 241224 RVA: 0x007E98BA File Offset: 0x007E7ABA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE49 RID: 241225 RVA: 0x007E98CC File Offset: 0x007E7ACC
		public ISetNpcHandInHandPerformT AsISetNpcHandInHandPerform()
		{
			return this.As<ISetNpcHandInHandPerformT>();
		}

		// Token: 0x0603AE4A RID: 241226 RVA: 0x007E98D4 File Offset: 0x007E7AD4
		public static TSetNpcGroupPerformTypeUnion FromISetNpcHandInHandPerform(ISetNpcHandInHandPerformT _isetnpchandinhandperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcHandInHandPerform,
				Value = _isetnpchandinhandperform
			};
		}

		// Token: 0x0603AE4B RID: 241227 RVA: 0x007E98E9 File Offset: 0x007E7AE9
		public ISetNpcHighFivePerformT AsISetNpcHighFivePerform()
		{
			return this.As<ISetNpcHighFivePerformT>();
		}

		// Token: 0x0603AE4C RID: 241228 RVA: 0x007E98F1 File Offset: 0x007E7AF1
		public static TSetNpcGroupPerformTypeUnion FromISetNpcHighFivePerform(ISetNpcHighFivePerformT _isetnpchighfiveperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcHighFivePerform,
				Value = _isetnpchighfiveperform
			};
		}

		// Token: 0x0603AE4D RID: 241229 RVA: 0x007E9906 File Offset: 0x007E7B06
		public ISetNpcHuggingBearPerformT AsISetNpcHuggingBearPerform()
		{
			return this.As<ISetNpcHuggingBearPerformT>();
		}

		// Token: 0x0603AE4E RID: 241230 RVA: 0x007E990E File Offset: 0x007E7B0E
		public static TSetNpcGroupPerformTypeUnion FromISetNpcHuggingBearPerform(ISetNpcHuggingBearPerformT _isetnpchuggingbearperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcHuggingBearPerform,
				Value = _isetnpchuggingbearperform
			};
		}

		// Token: 0x0603AE4F RID: 241231 RVA: 0x007E9923 File Offset: 0x007E7B23
		public ISetNpcSequencePerformT AsISetNpcSequencePerform()
		{
			return this.As<ISetNpcSequencePerformT>();
		}

		// Token: 0x0603AE50 RID: 241232 RVA: 0x007E992B File Offset: 0x007E7B2B
		public static TSetNpcGroupPerformTypeUnion FromISetNpcSequencePerform(ISetNpcSequencePerformT _isetnpcsequenceperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcSequencePerform,
				Value = _isetnpcsequenceperform
			};
		}

		// Token: 0x0603AE51 RID: 241233 RVA: 0x007E9940 File Offset: 0x007E7B40
		public ISetNpcSupportedWalkingPerformT AsISetNpcSupportedWalkingPerform()
		{
			return this.As<ISetNpcSupportedWalkingPerformT>();
		}

		// Token: 0x0603AE52 RID: 241234 RVA: 0x007E9948 File Offset: 0x007E7B48
		public static TSetNpcGroupPerformTypeUnion FromISetNpcSupportedWalkingPerform(ISetNpcSupportedWalkingPerformT _isetnpcsupportedwalkingperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcSupportedWalkingPerform,
				Value = _isetnpcsupportedwalkingperform
			};
		}

		// Token: 0x0603AE53 RID: 241235 RVA: 0x007E995D File Offset: 0x007E7B5D
		public ISetNpcTwoPersonPerformT AsISetNpcTwoPersonPerform()
		{
			return this.As<ISetNpcTwoPersonPerformT>();
		}

		// Token: 0x0603AE54 RID: 241236 RVA: 0x007E9965 File Offset: 0x007E7B65
		public static TSetNpcGroupPerformTypeUnion FromISetNpcTwoPersonPerform(ISetNpcTwoPersonPerformT _isetnpctwopersonperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcTwoPersonPerform,
				Value = _isetnpctwopersonperform
			};
		}

		// Token: 0x0603AE55 RID: 241237 RVA: 0x007E997C File Offset: 0x007E7B7C
		public static int Pack(FlatBufferBuilder builder, TSetNpcGroupPerformTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TSetNpcGroupPerformType.ISetNpcHandInHandPerform:
				return ISetNpcHandInHandPerform.Pack(builder, _o.AsISetNpcHandInHandPerform()).Value;
			case TSetNpcGroupPerformType.ISetNpcHighFivePerform:
				return ISetNpcHighFivePerform.Pack(builder, _o.AsISetNpcHighFivePerform()).Value;
			case TSetNpcGroupPerformType.ISetNpcHuggingBearPerform:
				return ISetNpcHuggingBearPerform.Pack(builder, _o.AsISetNpcHuggingBearPerform()).Value;
			case TSetNpcGroupPerformType.ISetNpcSequencePerform:
				return ISetNpcSequencePerform.Pack(builder, _o.AsISetNpcSequencePerform()).Value;
			case TSetNpcGroupPerformType.ISetNpcSupportedWalkingPerform:
				return ISetNpcSupportedWalkingPerform.Pack(builder, _o.AsISetNpcSupportedWalkingPerform()).Value;
			case TSetNpcGroupPerformType.ISetNpcTwoPersonPerform:
				return ISetNpcTwoPersonPerform.Pack(builder, _o.AsISetNpcTwoPersonPerform()).Value;
			default:
				return 0;
			}
		}
	}
}
