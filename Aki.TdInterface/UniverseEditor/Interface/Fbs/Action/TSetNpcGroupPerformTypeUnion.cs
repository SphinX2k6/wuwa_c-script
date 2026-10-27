using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007784 RID: 30596
	public class TSetNpcGroupPerformTypeUnion
	{
		// Token: 0x1700E69B RID: 59035
		// (get) Token: 0x060378CA RID: 227530 RVA: 0x007843C2 File Offset: 0x007825C2
		// (set) Token: 0x060378CB RID: 227531 RVA: 0x007843CA File Offset: 0x007825CA
		public TSetNpcGroupPerformType Type { get; set; }

		// Token: 0x1700E69C RID: 59036
		// (get) Token: 0x060378CC RID: 227532 RVA: 0x007843D3 File Offset: 0x007825D3
		// (set) Token: 0x060378CD RID: 227533 RVA: 0x007843DB File Offset: 0x007825DB
		public object Value { get; set; }

		// Token: 0x060378CE RID: 227534 RVA: 0x007843E4 File Offset: 0x007825E4
		public TSetNpcGroupPerformTypeUnion()
		{
			this.Type = TSetNpcGroupPerformType.NONE;
			this.Value = null;
		}

		// Token: 0x060378CF RID: 227535 RVA: 0x007843FA File Offset: 0x007825FA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060378D0 RID: 227536 RVA: 0x0078440C File Offset: 0x0078260C
		public ISetNpcHandInHandPerformT AsISetNpcHandInHandPerform()
		{
			return this.As<ISetNpcHandInHandPerformT>();
		}

		// Token: 0x060378D1 RID: 227537 RVA: 0x00784414 File Offset: 0x00782614
		public static TSetNpcGroupPerformTypeUnion FromISetNpcHandInHandPerform(ISetNpcHandInHandPerformT _isetnpchandinhandperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcHandInHandPerform,
				Value = _isetnpchandinhandperform
			};
		}

		// Token: 0x060378D2 RID: 227538 RVA: 0x00784429 File Offset: 0x00782629
		public ISetNpcHighFivePerformT AsISetNpcHighFivePerform()
		{
			return this.As<ISetNpcHighFivePerformT>();
		}

		// Token: 0x060378D3 RID: 227539 RVA: 0x00784431 File Offset: 0x00782631
		public static TSetNpcGroupPerformTypeUnion FromISetNpcHighFivePerform(ISetNpcHighFivePerformT _isetnpchighfiveperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcHighFivePerform,
				Value = _isetnpchighfiveperform
			};
		}

		// Token: 0x060378D4 RID: 227540 RVA: 0x00784446 File Offset: 0x00782646
		public ISetNpcHuggingBearPerformT AsISetNpcHuggingBearPerform()
		{
			return this.As<ISetNpcHuggingBearPerformT>();
		}

		// Token: 0x060378D5 RID: 227541 RVA: 0x0078444E File Offset: 0x0078264E
		public static TSetNpcGroupPerformTypeUnion FromISetNpcHuggingBearPerform(ISetNpcHuggingBearPerformT _isetnpchuggingbearperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcHuggingBearPerform,
				Value = _isetnpchuggingbearperform
			};
		}

		// Token: 0x060378D6 RID: 227542 RVA: 0x00784463 File Offset: 0x00782663
		public ISetNpcSupportedWalkingPerformT AsISetNpcSupportedWalkingPerform()
		{
			return this.As<ISetNpcSupportedWalkingPerformT>();
		}

		// Token: 0x060378D7 RID: 227543 RVA: 0x0078446B File Offset: 0x0078266B
		public static TSetNpcGroupPerformTypeUnion FromISetNpcSupportedWalkingPerform(ISetNpcSupportedWalkingPerformT _isetnpcsupportedwalkingperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcSupportedWalkingPerform,
				Value = _isetnpcsupportedwalkingperform
			};
		}

		// Token: 0x060378D8 RID: 227544 RVA: 0x00784480 File Offset: 0x00782680
		public ISetNpcTwoPersonPerformT AsISetNpcTwoPersonPerform()
		{
			return this.As<ISetNpcTwoPersonPerformT>();
		}

		// Token: 0x060378D9 RID: 227545 RVA: 0x00784488 File Offset: 0x00782688
		public static TSetNpcGroupPerformTypeUnion FromISetNpcTwoPersonPerform(ISetNpcTwoPersonPerformT _isetnpctwopersonperform)
		{
			return new TSetNpcGroupPerformTypeUnion
			{
				Type = TSetNpcGroupPerformType.ISetNpcTwoPersonPerform,
				Value = _isetnpctwopersonperform
			};
		}

		// Token: 0x060378DA RID: 227546 RVA: 0x007844A0 File Offset: 0x007826A0
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
