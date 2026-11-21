using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D35 RID: 27957
	public class IEnterMovieModeDurationType_UnionUnion
	{
		// Token: 0x1700CD16 RID: 52502
		// (get) Token: 0x06030387 RID: 197511 RVA: 0x0068E4C5 File Offset: 0x0068C6C5
		// (set) Token: 0x06030388 RID: 197512 RVA: 0x0068E4CD File Offset: 0x0068C6CD
		public IEnterMovieModeDurationType_Union Type { get; set; }

		// Token: 0x1700CD17 RID: 52503
		// (get) Token: 0x06030389 RID: 197513 RVA: 0x0068E4D6 File Offset: 0x0068C6D6
		// (set) Token: 0x0603038A RID: 197514 RVA: 0x0068E4DE File Offset: 0x0068C6DE
		public object Value { get; set; }

		// Token: 0x0603038B RID: 197515 RVA: 0x0068E4E7 File Offset: 0x0068C6E7
		public IEnterMovieModeDurationType_UnionUnion()
		{
			this.Type = IEnterMovieModeDurationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603038C RID: 197516 RVA: 0x0068E4FD File Offset: 0x0068C6FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603038D RID: 197517 RVA: 0x0068E50F File Offset: 0x0068C70F
		public IEnterMovieModeDurationTypeT AsIEnterMovieModeDurationType()
		{
			return this.As<IEnterMovieModeDurationTypeT>();
		}

		// Token: 0x0603038E RID: 197518 RVA: 0x0068E517 File Offset: 0x0068C717
		public static IEnterMovieModeDurationType_UnionUnion FromIEnterMovieModeDurationType(IEnterMovieModeDurationTypeT _ientermoviemodedurationtype)
		{
			return new IEnterMovieModeDurationType_UnionUnion
			{
				Type = IEnterMovieModeDurationType_Union.IEnterMovieModeDurationType,
				Value = _ientermoviemodedurationtype
			};
		}

		// Token: 0x0603038F RID: 197519 RVA: 0x0068E52C File Offset: 0x0068C72C
		public IWaitMovieModeBorderAnimFinishedT AsIWaitMovieModeBorderAnimFinished()
		{
			return this.As<IWaitMovieModeBorderAnimFinishedT>();
		}

		// Token: 0x06030390 RID: 197520 RVA: 0x0068E534 File Offset: 0x0068C734
		public static IEnterMovieModeDurationType_UnionUnion FromIWaitMovieModeBorderAnimFinished(IWaitMovieModeBorderAnimFinishedT _iwaitmoviemodeborderanimfinished)
		{
			return new IEnterMovieModeDurationType_UnionUnion
			{
				Type = IEnterMovieModeDurationType_Union.IWaitMovieModeBorderAnimFinished,
				Value = _iwaitmoviemodeborderanimfinished
			};
		}

		// Token: 0x06030391 RID: 197521 RVA: 0x0068E549 File Offset: 0x0068C749
		public IWaitMovieModeFixedTimeT AsIWaitMovieModeFixedTime()
		{
			return this.As<IWaitMovieModeFixedTimeT>();
		}

		// Token: 0x06030392 RID: 197522 RVA: 0x0068E551 File Offset: 0x0068C751
		public static IEnterMovieModeDurationType_UnionUnion FromIWaitMovieModeFixedTime(IWaitMovieModeFixedTimeT _iwaitmoviemodefixedtime)
		{
			return new IEnterMovieModeDurationType_UnionUnion
			{
				Type = IEnterMovieModeDurationType_Union.IWaitMovieModeFixedTime,
				Value = _iwaitmoviemodefixedtime
			};
		}

		// Token: 0x06030393 RID: 197523 RVA: 0x0068E568 File Offset: 0x0068C768
		public static int Pack(FlatBufferBuilder builder, IEnterMovieModeDurationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEnterMovieModeDurationType_Union.IEnterMovieModeDurationType:
				return IEnterMovieModeDurationType.Pack(builder, _o.AsIEnterMovieModeDurationType()).Value;
			case IEnterMovieModeDurationType_Union.IWaitMovieModeBorderAnimFinished:
				return IWaitMovieModeBorderAnimFinished.Pack(builder, _o.AsIWaitMovieModeBorderAnimFinished()).Value;
			case IEnterMovieModeDurationType_Union.IWaitMovieModeFixedTime:
				return IWaitMovieModeFixedTime.Pack(builder, _o.AsIWaitMovieModeFixedTime()).Value;
			default:
				return 0;
			}
		}
	}
}
