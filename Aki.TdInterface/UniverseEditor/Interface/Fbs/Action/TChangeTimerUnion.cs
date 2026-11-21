using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E74 RID: 32372
	public class TChangeTimerUnion
	{
		// Token: 0x1700F215 RID: 61973
		// (get) Token: 0x0603A763 RID: 239459 RVA: 0x007DECA0 File Offset: 0x007DCEA0
		// (set) Token: 0x0603A764 RID: 239460 RVA: 0x007DECA8 File Offset: 0x007DCEA8
		public TChangeTimer Type { get; set; }

		// Token: 0x1700F216 RID: 61974
		// (get) Token: 0x0603A765 RID: 239461 RVA: 0x007DECB1 File Offset: 0x007DCEB1
		// (set) Token: 0x0603A766 RID: 239462 RVA: 0x007DECB9 File Offset: 0x007DCEB9
		public object Value { get; set; }

		// Token: 0x0603A767 RID: 239463 RVA: 0x007DECC2 File Offset: 0x007DCEC2
		public TChangeTimerUnion()
		{
			this.Type = TChangeTimer.NONE;
			this.Value = null;
		}

		// Token: 0x0603A768 RID: 239464 RVA: 0x007DECD8 File Offset: 0x007DCED8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A769 RID: 239465 RVA: 0x007DECEA File Offset: 0x007DCEEA
		public IAddTimeT AsIAddTime()
		{
			return this.As<IAddTimeT>();
		}

		// Token: 0x0603A76A RID: 239466 RVA: 0x007DECF2 File Offset: 0x007DCEF2
		public static TChangeTimerUnion FromIAddTime(IAddTimeT _iaddtime)
		{
			return new TChangeTimerUnion
			{
				Type = TChangeTimer.IAddTime,
				Value = _iaddtime
			};
		}

		// Token: 0x0603A76B RID: 239467 RVA: 0x007DED07 File Offset: 0x007DCF07
		public IReduceTimeT AsIReduceTime()
		{
			return this.As<IReduceTimeT>();
		}

		// Token: 0x0603A76C RID: 239468 RVA: 0x007DED0F File Offset: 0x007DCF0F
		public static TChangeTimerUnion FromIReduceTime(IReduceTimeT _ireducetime)
		{
			return new TChangeTimerUnion
			{
				Type = TChangeTimer.IReduceTime,
				Value = _ireducetime
			};
		}

		// Token: 0x0603A76D RID: 239469 RVA: 0x007DED24 File Offset: 0x007DCF24
		public ISetTimeT AsISetTime()
		{
			return this.As<ISetTimeT>();
		}

		// Token: 0x0603A76E RID: 239470 RVA: 0x007DED2C File Offset: 0x007DCF2C
		public static TChangeTimerUnion FromISetTime(ISetTimeT _isettime)
		{
			return new TChangeTimerUnion
			{
				Type = TChangeTimer.ISetTime,
				Value = _isettime
			};
		}

		// Token: 0x0603A76F RID: 239471 RVA: 0x007DED44 File Offset: 0x007DCF44
		public static int Pack(FlatBufferBuilder builder, TChangeTimerUnion _o)
		{
			switch (_o.Type)
			{
			case TChangeTimer.IAddTime:
				return IAddTime.Pack(builder, _o.AsIAddTime()).Value;
			case TChangeTimer.IReduceTime:
				return IReduceTime.Pack(builder, _o.AsIReduceTime()).Value;
			case TChangeTimer.ISetTime:
				return ISetTime.Pack(builder, _o.AsISetTime()).Value;
			default:
				return 0;
			}
		}
	}
}
