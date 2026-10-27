using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066BB RID: 26299
	public class IEnterMovieModeDurationType_UnionUnion
	{
		// Token: 0x1700C365 RID: 50021
		// (get) Token: 0x0602DB6A RID: 187242 RVA: 0x00641211 File Offset: 0x0063F411
		// (set) Token: 0x0602DB6B RID: 187243 RVA: 0x00641219 File Offset: 0x0063F419
		public IEnterMovieModeDurationType_Union Type { get; set; }

		// Token: 0x1700C366 RID: 50022
		// (get) Token: 0x0602DB6C RID: 187244 RVA: 0x00641222 File Offset: 0x0063F422
		// (set) Token: 0x0602DB6D RID: 187245 RVA: 0x0064122A File Offset: 0x0063F42A
		public object Value { get; set; }

		// Token: 0x0602DB6E RID: 187246 RVA: 0x00641233 File Offset: 0x0063F433
		public IEnterMovieModeDurationType_UnionUnion()
		{
			this.Type = IEnterMovieModeDurationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DB6F RID: 187247 RVA: 0x00641249 File Offset: 0x0063F449
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DB70 RID: 187248 RVA: 0x0064125B File Offset: 0x0063F45B
		public IEnterMovieModeDurationTypeT AsIEnterMovieModeDurationType()
		{
			return this.As<IEnterMovieModeDurationTypeT>();
		}

		// Token: 0x0602DB71 RID: 187249 RVA: 0x00641263 File Offset: 0x0063F463
		public static IEnterMovieModeDurationType_UnionUnion FromIEnterMovieModeDurationType(IEnterMovieModeDurationTypeT _ientermoviemodedurationtype)
		{
			return new IEnterMovieModeDurationType_UnionUnion
			{
				Type = IEnterMovieModeDurationType_Union.IEnterMovieModeDurationType,
				Value = _ientermoviemodedurationtype
			};
		}

		// Token: 0x0602DB72 RID: 187250 RVA: 0x00641278 File Offset: 0x0063F478
		public IWaitMovieModeBorderAnimFinishedT AsIWaitMovieModeBorderAnimFinished()
		{
			return this.As<IWaitMovieModeBorderAnimFinishedT>();
		}

		// Token: 0x0602DB73 RID: 187251 RVA: 0x00641280 File Offset: 0x0063F480
		public static IEnterMovieModeDurationType_UnionUnion FromIWaitMovieModeBorderAnimFinished(IWaitMovieModeBorderAnimFinishedT _iwaitmoviemodeborderanimfinished)
		{
			return new IEnterMovieModeDurationType_UnionUnion
			{
				Type = IEnterMovieModeDurationType_Union.IWaitMovieModeBorderAnimFinished,
				Value = _iwaitmoviemodeborderanimfinished
			};
		}

		// Token: 0x0602DB74 RID: 187252 RVA: 0x00641295 File Offset: 0x0063F495
		public IWaitMovieModeFixedTimeT AsIWaitMovieModeFixedTime()
		{
			return this.As<IWaitMovieModeFixedTimeT>();
		}

		// Token: 0x0602DB75 RID: 187253 RVA: 0x0064129D File Offset: 0x0063F49D
		public static IEnterMovieModeDurationType_UnionUnion FromIWaitMovieModeFixedTime(IWaitMovieModeFixedTimeT _iwaitmoviemodefixedtime)
		{
			return new IEnterMovieModeDurationType_UnionUnion
			{
				Type = IEnterMovieModeDurationType_Union.IWaitMovieModeFixedTime,
				Value = _iwaitmoviemodefixedtime
			};
		}

		// Token: 0x0602DB76 RID: 187254 RVA: 0x006412B4 File Offset: 0x0063F4B4
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
