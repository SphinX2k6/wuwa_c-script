using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FDD RID: 16349
	public class TShowTimelineUnion
	{
		// Token: 0x17006EBF RID: 28351
		// (get) Token: 0x060165CF RID: 91599 RVA: 0x00334033 File Offset: 0x00332233
		// (set) Token: 0x060165D0 RID: 91600 RVA: 0x0033403B File Offset: 0x0033223B
		public TShowTimeline Type { get; set; }

		// Token: 0x17006EC0 RID: 28352
		// (get) Token: 0x060165D1 RID: 91601 RVA: 0x00334044 File Offset: 0x00332244
		// (set) Token: 0x060165D2 RID: 91602 RVA: 0x0033404C File Offset: 0x0033224C
		public object Value { get; set; }

		// Token: 0x060165D3 RID: 91603 RVA: 0x00334055 File Offset: 0x00332255
		public TShowTimelineUnion()
		{
			this.Type = TShowTimeline.NONE;
			this.Value = null;
		}

		// Token: 0x060165D4 RID: 91604 RVA: 0x0033406B File Offset: 0x0033226B
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060165D5 RID: 91605 RVA: 0x0033407D File Offset: 0x0033227D
		public IShowTimelineActionT AsIShowTimelineAction()
		{
			return this.As<IShowTimelineActionT>();
		}

		// Token: 0x060165D6 RID: 91606 RVA: 0x00334085 File Offset: 0x00332285
		public static TShowTimelineUnion FromIShowTimelineAction(IShowTimelineActionT _ishowtimelineaction)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineAction,
				Value = _ishowtimelineaction
			};
		}

		// Token: 0x060165D7 RID: 91607 RVA: 0x0033409A File Offset: 0x0033229A
		public IShowTimelineBuffT AsIShowTimelineBuff()
		{
			return this.As<IShowTimelineBuffT>();
		}

		// Token: 0x060165D8 RID: 91608 RVA: 0x003340A2 File Offset: 0x003322A2
		public static TShowTimelineUnion FromIShowTimelineBuff(IShowTimelineBuffT _ishowtimelinebuff)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineBuff,
				Value = _ishowtimelinebuff
			};
		}

		// Token: 0x060165D9 RID: 91609 RVA: 0x003340B7 File Offset: 0x003322B7
		public IShowTimelineCheckpointT AsIShowTimelineCheckpoint()
		{
			return this.As<IShowTimelineCheckpointT>();
		}

		// Token: 0x060165DA RID: 91610 RVA: 0x003340BF File Offset: 0x003322BF
		public static TShowTimelineUnion FromIShowTimelineCheckpoint(IShowTimelineCheckpointT _ishowtimelinecheckpoint)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineCheckpoint,
				Value = _ishowtimelinecheckpoint
			};
		}

		// Token: 0x060165DB RID: 91611 RVA: 0x003340D4 File Offset: 0x003322D4
		public IShowTimelineGuideT AsIShowTimelineGuide()
		{
			return this.As<IShowTimelineGuideT>();
		}

		// Token: 0x060165DC RID: 91612 RVA: 0x003340DC File Offset: 0x003322DC
		public static TShowTimelineUnion FromIShowTimelineGuide(IShowTimelineGuideT _ishowtimelineguide)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineGuide,
				Value = _ishowtimelineguide
			};
		}

		// Token: 0x060165DD RID: 91613 RVA: 0x003340F1 File Offset: 0x003322F1
		public IShowTimelineInputT AsIShowTimelineInput()
		{
			return this.As<IShowTimelineInputT>();
		}

		// Token: 0x060165DE RID: 91614 RVA: 0x003340F9 File Offset: 0x003322F9
		public static TShowTimelineUnion FromIShowTimelineInput(IShowTimelineInputT _ishowtimelineinput)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineInput,
				Value = _ishowtimelineinput
			};
		}

		// Token: 0x060165DF RID: 91615 RVA: 0x00334110 File Offset: 0x00332310
		public static int Pack(FlatBufferBuilder builder, TShowTimelineUnion _o)
		{
			switch (_o.Type)
			{
			case TShowTimeline.IShowTimelineAction:
				return IShowTimelineAction.Pack(builder, _o.AsIShowTimelineAction()).Value;
			case TShowTimeline.IShowTimelineBuff:
				return IShowTimelineBuff.Pack(builder, _o.AsIShowTimelineBuff()).Value;
			case TShowTimeline.IShowTimelineCheckpoint:
				return IShowTimelineCheckpoint.Pack(builder, _o.AsIShowTimelineCheckpoint()).Value;
			case TShowTimeline.IShowTimelineGuide:
				return IShowTimelineGuide.Pack(builder, _o.AsIShowTimelineGuide()).Value;
			case TShowTimeline.IShowTimelineInput:
				return IShowTimelineInput.Pack(builder, _o.AsIShowTimelineInput()).Value;
			default:
				return 0;
			}
		}
	}
}
