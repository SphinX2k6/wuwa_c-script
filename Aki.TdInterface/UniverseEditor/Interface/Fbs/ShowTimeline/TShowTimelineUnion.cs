using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BD2 RID: 15314
	public class TShowTimelineUnion
	{
		// Token: 0x17006917 RID: 26903
		// (get) Token: 0x060150D9 RID: 86233 RVA: 0x0030D4AB File Offset: 0x0030B6AB
		// (set) Token: 0x060150DA RID: 86234 RVA: 0x0030D4B3 File Offset: 0x0030B6B3
		public TShowTimeline Type { get; set; }

		// Token: 0x17006918 RID: 26904
		// (get) Token: 0x060150DB RID: 86235 RVA: 0x0030D4BC File Offset: 0x0030B6BC
		// (set) Token: 0x060150DC RID: 86236 RVA: 0x0030D4C4 File Offset: 0x0030B6C4
		public object Value { get; set; }

		// Token: 0x060150DD RID: 86237 RVA: 0x0030D4CD File Offset: 0x0030B6CD
		public TShowTimelineUnion()
		{
			this.Type = TShowTimeline.NONE;
			this.Value = null;
		}

		// Token: 0x060150DE RID: 86238 RVA: 0x0030D4E3 File Offset: 0x0030B6E3
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060150DF RID: 86239 RVA: 0x0030D4F5 File Offset: 0x0030B6F5
		public IShowTimelineActionT AsIShowTimelineAction()
		{
			return this.As<IShowTimelineActionT>();
		}

		// Token: 0x060150E0 RID: 86240 RVA: 0x0030D4FD File Offset: 0x0030B6FD
		public static TShowTimelineUnion FromIShowTimelineAction(IShowTimelineActionT _ishowtimelineaction)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineAction,
				Value = _ishowtimelineaction
			};
		}

		// Token: 0x060150E1 RID: 86241 RVA: 0x0030D512 File Offset: 0x0030B712
		public IShowTimelineBuffT AsIShowTimelineBuff()
		{
			return this.As<IShowTimelineBuffT>();
		}

		// Token: 0x060150E2 RID: 86242 RVA: 0x0030D51A File Offset: 0x0030B71A
		public static TShowTimelineUnion FromIShowTimelineBuff(IShowTimelineBuffT _ishowtimelinebuff)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineBuff,
				Value = _ishowtimelinebuff
			};
		}

		// Token: 0x060150E3 RID: 86243 RVA: 0x0030D52F File Offset: 0x0030B72F
		public IShowTimelineCheckpointT AsIShowTimelineCheckpoint()
		{
			return this.As<IShowTimelineCheckpointT>();
		}

		// Token: 0x060150E4 RID: 86244 RVA: 0x0030D537 File Offset: 0x0030B737
		public static TShowTimelineUnion FromIShowTimelineCheckpoint(IShowTimelineCheckpointT _ishowtimelinecheckpoint)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineCheckpoint,
				Value = _ishowtimelinecheckpoint
			};
		}

		// Token: 0x060150E5 RID: 86245 RVA: 0x0030D54C File Offset: 0x0030B74C
		public IShowTimelineGuideT AsIShowTimelineGuide()
		{
			return this.As<IShowTimelineGuideT>();
		}

		// Token: 0x060150E6 RID: 86246 RVA: 0x0030D554 File Offset: 0x0030B754
		public static TShowTimelineUnion FromIShowTimelineGuide(IShowTimelineGuideT _ishowtimelineguide)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineGuide,
				Value = _ishowtimelineguide
			};
		}

		// Token: 0x060150E7 RID: 86247 RVA: 0x0030D569 File Offset: 0x0030B769
		public IShowTimelineInputT AsIShowTimelineInput()
		{
			return this.As<IShowTimelineInputT>();
		}

		// Token: 0x060150E8 RID: 86248 RVA: 0x0030D571 File Offset: 0x0030B771
		public static TShowTimelineUnion FromIShowTimelineInput(IShowTimelineInputT _ishowtimelineinput)
		{
			return new TShowTimelineUnion
			{
				Type = TShowTimeline.IShowTimelineInput,
				Value = _ishowtimelineinput
			};
		}

		// Token: 0x060150E9 RID: 86249 RVA: 0x0030D588 File Offset: 0x0030B788
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
