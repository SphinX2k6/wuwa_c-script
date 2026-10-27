using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BA RID: 30394
	public class TEnterMovieModeDurationTypeUnion
	{
		// Token: 0x1700E615 RID: 58901
		// (get) Token: 0x06037488 RID: 226440 RVA: 0x0077DAD0 File Offset: 0x0077BCD0
		// (set) Token: 0x06037489 RID: 226441 RVA: 0x0077DAD8 File Offset: 0x0077BCD8
		public TEnterMovieModeDurationType Type { get; set; }

		// Token: 0x1700E616 RID: 58902
		// (get) Token: 0x0603748A RID: 226442 RVA: 0x0077DAE1 File Offset: 0x0077BCE1
		// (set) Token: 0x0603748B RID: 226443 RVA: 0x0077DAE9 File Offset: 0x0077BCE9
		public object Value { get; set; }

		// Token: 0x0603748C RID: 226444 RVA: 0x0077DAF2 File Offset: 0x0077BCF2
		public TEnterMovieModeDurationTypeUnion()
		{
			this.Type = TEnterMovieModeDurationType.NONE;
			this.Value = null;
		}

		// Token: 0x0603748D RID: 226445 RVA: 0x0077DB08 File Offset: 0x0077BD08
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603748E RID: 226446 RVA: 0x0077DB1A File Offset: 0x0077BD1A
		public IWaitMovieModeBorderAnimFinishedT AsIWaitMovieModeBorderAnimFinished()
		{
			return this.As<IWaitMovieModeBorderAnimFinishedT>();
		}

		// Token: 0x0603748F RID: 226447 RVA: 0x0077DB22 File Offset: 0x0077BD22
		public static TEnterMovieModeDurationTypeUnion FromIWaitMovieModeBorderAnimFinished(IWaitMovieModeBorderAnimFinishedT _iwaitmoviemodeborderanimfinished)
		{
			return new TEnterMovieModeDurationTypeUnion
			{
				Type = TEnterMovieModeDurationType.IWaitMovieModeBorderAnimFinished,
				Value = _iwaitmoviemodeborderanimfinished
			};
		}

		// Token: 0x06037490 RID: 226448 RVA: 0x0077DB37 File Offset: 0x0077BD37
		public IWaitMovieModeFixedTimeT AsIWaitMovieModeFixedTime()
		{
			return this.As<IWaitMovieModeFixedTimeT>();
		}

		// Token: 0x06037491 RID: 226449 RVA: 0x0077DB3F File Offset: 0x0077BD3F
		public static TEnterMovieModeDurationTypeUnion FromIWaitMovieModeFixedTime(IWaitMovieModeFixedTimeT _iwaitmoviemodefixedtime)
		{
			return new TEnterMovieModeDurationTypeUnion
			{
				Type = TEnterMovieModeDurationType.IWaitMovieModeFixedTime,
				Value = _iwaitmoviemodefixedtime
			};
		}

		// Token: 0x06037492 RID: 226450 RVA: 0x0077DB54 File Offset: 0x0077BD54
		public static int Pack(FlatBufferBuilder builder, TEnterMovieModeDurationTypeUnion _o)
		{
			TEnterMovieModeDurationType type = _o.Type;
			if (type == TEnterMovieModeDurationType.IWaitMovieModeBorderAnimFinished)
			{
				return IWaitMovieModeBorderAnimFinished.Pack(builder, _o.AsIWaitMovieModeBorderAnimFinished()).Value;
			}
			if (type != TEnterMovieModeDurationType.IWaitMovieModeFixedTime)
			{
				return 0;
			}
			return IWaitMovieModeFixedTime.Pack(builder, _o.AsIWaitMovieModeFixedTime()).Value;
		}
	}
}
