using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2C RID: 27948
	public class IEnterMovieCameraType_UnionUnion
	{
		// Token: 0x1700CD04 RID: 52484
		// (get) Token: 0x0603033B RID: 197435 RVA: 0x0068DAE5 File Offset: 0x0068BCE5
		// (set) Token: 0x0603033C RID: 197436 RVA: 0x0068DAED File Offset: 0x0068BCED
		public IEnterMovieCameraType_Union Type { get; set; }

		// Token: 0x1700CD05 RID: 52485
		// (get) Token: 0x0603033D RID: 197437 RVA: 0x0068DAF6 File Offset: 0x0068BCF6
		// (set) Token: 0x0603033E RID: 197438 RVA: 0x0068DAFE File Offset: 0x0068BCFE
		public object Value { get; set; }

		// Token: 0x0603033F RID: 197439 RVA: 0x0068DB07 File Offset: 0x0068BD07
		public IEnterMovieCameraType_UnionUnion()
		{
			this.Type = IEnterMovieCameraType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030340 RID: 197440 RVA: 0x0068DB1D File Offset: 0x0068BD1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030341 RID: 197441 RVA: 0x0068DB2F File Offset: 0x0068BD2F
		public IEnterMovieCameraTypeT AsIEnterMovieCameraType()
		{
			return this.As<IEnterMovieCameraTypeT>();
		}

		// Token: 0x06030342 RID: 197442 RVA: 0x0068DB37 File Offset: 0x0068BD37
		public static IEnterMovieCameraType_UnionUnion FromIEnterMovieCameraType(IEnterMovieCameraTypeT _ientermoviecameratype)
		{
			return new IEnterMovieCameraType_UnionUnion
			{
				Type = IEnterMovieCameraType_Union.IEnterMovieCameraType,
				Value = _ientermoviecameratype
			};
		}

		// Token: 0x06030343 RID: 197443 RVA: 0x0068DB4C File Offset: 0x0068BD4C
		public IEnterCommonMovieCameraT AsIEnterCommonMovieCamera()
		{
			return this.As<IEnterCommonMovieCameraT>();
		}

		// Token: 0x06030344 RID: 197444 RVA: 0x0068DB54 File Offset: 0x0068BD54
		public static IEnterMovieCameraType_UnionUnion FromIEnterCommonMovieCamera(IEnterCommonMovieCameraT _ientercommonmoviecamera)
		{
			return new IEnterMovieCameraType_UnionUnion
			{
				Type = IEnterMovieCameraType_Union.IEnterCommonMovieCamera,
				Value = _ientercommonmoviecamera
			};
		}

		// Token: 0x06030345 RID: 197445 RVA: 0x0068DB69 File Offset: 0x0068BD69
		public IEnterSpecMovieCameraT AsIEnterSpecMovieCamera()
		{
			return this.As<IEnterSpecMovieCameraT>();
		}

		// Token: 0x06030346 RID: 197446 RVA: 0x0068DB71 File Offset: 0x0068BD71
		public static IEnterMovieCameraType_UnionUnion FromIEnterSpecMovieCamera(IEnterSpecMovieCameraT _ienterspecmoviecamera)
		{
			return new IEnterMovieCameraType_UnionUnion
			{
				Type = IEnterMovieCameraType_Union.IEnterSpecMovieCamera,
				Value = _ienterspecmoviecamera
			};
		}

		// Token: 0x06030347 RID: 197447 RVA: 0x0068DB86 File Offset: 0x0068BD86
		public IEnterRandomMovieCameraT AsIEnterRandomMovieCamera()
		{
			return this.As<IEnterRandomMovieCameraT>();
		}

		// Token: 0x06030348 RID: 197448 RVA: 0x0068DB8E File Offset: 0x0068BD8E
		public static IEnterMovieCameraType_UnionUnion FromIEnterRandomMovieCamera(IEnterRandomMovieCameraT _ienterrandommoviecamera)
		{
			return new IEnterMovieCameraType_UnionUnion
			{
				Type = IEnterMovieCameraType_Union.IEnterRandomMovieCamera,
				Value = _ienterrandommoviecamera
			};
		}

		// Token: 0x06030349 RID: 197449 RVA: 0x0068DBA4 File Offset: 0x0068BDA4
		public static int Pack(FlatBufferBuilder builder, IEnterMovieCameraType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEnterMovieCameraType_Union.IEnterMovieCameraType:
				return IEnterMovieCameraType.Pack(builder, _o.AsIEnterMovieCameraType()).Value;
			case IEnterMovieCameraType_Union.IEnterCommonMovieCamera:
				return IEnterCommonMovieCamera.Pack(builder, _o.AsIEnterCommonMovieCamera()).Value;
			case IEnterMovieCameraType_Union.IEnterSpecMovieCamera:
				return IEnterSpecMovieCamera.Pack(builder, _o.AsIEnterSpecMovieCamera()).Value;
			case IEnterMovieCameraType_Union.IEnterRandomMovieCamera:
				return IEnterRandomMovieCamera.Pack(builder, _o.AsIEnterRandomMovieCamera()).Value;
			default:
				return 0;
			}
		}
	}
}
