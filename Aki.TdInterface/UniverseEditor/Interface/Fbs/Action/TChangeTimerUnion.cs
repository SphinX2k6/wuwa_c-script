using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007666 RID: 30310
	public class TChangeTimerUnion
	{
		// Token: 0x1700E5D7 RID: 58839
		// (get) Token: 0x060372BE RID: 225982 RVA: 0x0077ABA4 File Offset: 0x00778DA4
		// (set) Token: 0x060372BF RID: 225983 RVA: 0x0077ABAC File Offset: 0x00778DAC
		public TChangeTimer Type { get; set; }

		// Token: 0x1700E5D8 RID: 58840
		// (get) Token: 0x060372C0 RID: 225984 RVA: 0x0077ABB5 File Offset: 0x00778DB5
		// (set) Token: 0x060372C1 RID: 225985 RVA: 0x0077ABBD File Offset: 0x00778DBD
		public object Value { get; set; }

		// Token: 0x060372C2 RID: 225986 RVA: 0x0077ABC6 File Offset: 0x00778DC6
		public TChangeTimerUnion()
		{
			this.Type = TChangeTimer.NONE;
			this.Value = null;
		}

		// Token: 0x060372C3 RID: 225987 RVA: 0x0077ABDC File Offset: 0x00778DDC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060372C4 RID: 225988 RVA: 0x0077ABEE File Offset: 0x00778DEE
		public IAddTimeT AsIAddTime()
		{
			return this.As<IAddTimeT>();
		}

		// Token: 0x060372C5 RID: 225989 RVA: 0x0077ABF6 File Offset: 0x00778DF6
		public static TChangeTimerUnion FromIAddTime(IAddTimeT _iaddtime)
		{
			return new TChangeTimerUnion
			{
				Type = TChangeTimer.IAddTime,
				Value = _iaddtime
			};
		}

		// Token: 0x060372C6 RID: 225990 RVA: 0x0077AC0B File Offset: 0x00778E0B
		public IReduceTimeT AsIReduceTime()
		{
			return this.As<IReduceTimeT>();
		}

		// Token: 0x060372C7 RID: 225991 RVA: 0x0077AC13 File Offset: 0x00778E13
		public static TChangeTimerUnion FromIReduceTime(IReduceTimeT _ireducetime)
		{
			return new TChangeTimerUnion
			{
				Type = TChangeTimer.IReduceTime,
				Value = _ireducetime
			};
		}

		// Token: 0x060372C8 RID: 225992 RVA: 0x0077AC28 File Offset: 0x00778E28
		public ISetTimeT AsISetTime()
		{
			return this.As<ISetTimeT>();
		}

		// Token: 0x060372C9 RID: 225993 RVA: 0x0077AC30 File Offset: 0x00778E30
		public static TChangeTimerUnion FromISetTime(ISetTimeT _isettime)
		{
			return new TChangeTimerUnion
			{
				Type = TChangeTimer.ISetTime,
				Value = _isettime
			};
		}

		// Token: 0x060372CA RID: 225994 RVA: 0x0077AC48 File Offset: 0x00778E48
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
