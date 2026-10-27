using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BEC RID: 23532
	public class TAttachTimingUnion
	{
		// Token: 0x1700B1C7 RID: 45511
		// (get) Token: 0x06028531 RID: 165169 RVA: 0x0058A458 File Offset: 0x00588658
		// (set) Token: 0x06028532 RID: 165170 RVA: 0x0058A460 File Offset: 0x00588660
		public TAttachTiming Type { get; set; }

		// Token: 0x1700B1C8 RID: 45512
		// (get) Token: 0x06028533 RID: 165171 RVA: 0x0058A469 File Offset: 0x00588669
		// (set) Token: 0x06028534 RID: 165172 RVA: 0x0058A471 File Offset: 0x00588671
		public object Value { get; set; }

		// Token: 0x06028535 RID: 165173 RVA: 0x0058A47A File Offset: 0x0058867A
		public TAttachTimingUnion()
		{
			this.Type = TAttachTiming.NONE;
			this.Value = null;
		}

		// Token: 0x06028536 RID: 165174 RVA: 0x0058A490 File Offset: 0x00588690
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028537 RID: 165175 RVA: 0x0058A4A2 File Offset: 0x005886A2
		public IDefaultAttachTimingT AsIDefaultAttachTiming()
		{
			return this.As<IDefaultAttachTimingT>();
		}

		// Token: 0x06028538 RID: 165176 RVA: 0x0058A4AA File Offset: 0x005886AA
		public static TAttachTimingUnion FromIDefaultAttachTiming(IDefaultAttachTimingT _idefaultattachtiming)
		{
			return new TAttachTimingUnion
			{
				Type = TAttachTiming.IDefaultAttachTiming,
				Value = _idefaultattachtiming
			};
		}

		// Token: 0x06028539 RID: 165177 RVA: 0x0058A4BF File Offset: 0x005886BF
		public IOnMoveWithSplineEndAttachTimingT AsIOnMoveWithSplineEndAttachTiming()
		{
			return this.As<IOnMoveWithSplineEndAttachTimingT>();
		}

		// Token: 0x0602853A RID: 165178 RVA: 0x0058A4C7 File Offset: 0x005886C7
		public static TAttachTimingUnion FromIOnMoveWithSplineEndAttachTiming(IOnMoveWithSplineEndAttachTimingT _ionmovewithsplineendattachtiming)
		{
			return new TAttachTimingUnion
			{
				Type = TAttachTiming.IOnMoveWithSplineEndAttachTiming,
				Value = _ionmovewithsplineendattachtiming
			};
		}

		// Token: 0x0602853B RID: 165179 RVA: 0x0058A4DC File Offset: 0x005886DC
		public static int Pack(FlatBufferBuilder builder, TAttachTimingUnion _o)
		{
			TAttachTiming type = _o.Type;
			if (type == TAttachTiming.IDefaultAttachTiming)
			{
				return IDefaultAttachTiming.Pack(builder, _o.AsIDefaultAttachTiming()).Value;
			}
			if (type != TAttachTiming.IOnMoveWithSplineEndAttachTiming)
			{
				return 0;
			}
			return IOnMoveWithSplineEndAttachTiming.Pack(builder, _o.AsIOnMoveWithSplineEndAttachTiming()).Value;
		}
	}
}
