using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B2 RID: 26290
	public class IEnterMovieCameraType_UnionUnion
	{
		// Token: 0x1700C353 RID: 50003
		// (get) Token: 0x0602DB1E RID: 187166 RVA: 0x00640831 File Offset: 0x0063EA31
		// (set) Token: 0x0602DB1F RID: 187167 RVA: 0x00640839 File Offset: 0x0063EA39
		public IEnterMovieCameraType_Union Type { get; set; }

		// Token: 0x1700C354 RID: 50004
		// (get) Token: 0x0602DB20 RID: 187168 RVA: 0x00640842 File Offset: 0x0063EA42
		// (set) Token: 0x0602DB21 RID: 187169 RVA: 0x0064084A File Offset: 0x0063EA4A
		public object Value { get; set; }

		// Token: 0x0602DB22 RID: 187170 RVA: 0x00640853 File Offset: 0x0063EA53
		public IEnterMovieCameraType_UnionUnion()
		{
			this.Type = IEnterMovieCameraType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DB23 RID: 187171 RVA: 0x00640869 File Offset: 0x0063EA69
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DB24 RID: 187172 RVA: 0x0064087B File Offset: 0x0063EA7B
		public IEnterMovieCameraTypeT AsIEnterMovieCameraType()
		{
			return this.As<IEnterMovieCameraTypeT>();
		}

		// Token: 0x0602DB25 RID: 187173 RVA: 0x00640883 File Offset: 0x0063EA83
		public static IEnterMovieCameraType_UnionUnion FromIEnterMovieCameraType(IEnterMovieCameraTypeT _ientermoviecameratype)
		{
			return new IEnterMovieCameraType_UnionUnion
			{
				Type = IEnterMovieCameraType_Union.IEnterMovieCameraType,
				Value = _ientermoviecameratype
			};
		}

		// Token: 0x0602DB26 RID: 187174 RVA: 0x00640898 File Offset: 0x0063EA98
		public IEnterCommonMovieCameraT AsIEnterCommonMovieCamera()
		{
			return this.As<IEnterCommonMovieCameraT>();
		}

		// Token: 0x0602DB27 RID: 187175 RVA: 0x006408A0 File Offset: 0x0063EAA0
		public static IEnterMovieCameraType_UnionUnion FromIEnterCommonMovieCamera(IEnterCommonMovieCameraT _ientercommonmoviecamera)
		{
			return new IEnterMovieCameraType_UnionUnion
			{
				Type = IEnterMovieCameraType_Union.IEnterCommonMovieCamera,
				Value = _ientercommonmoviecamera
			};
		}

		// Token: 0x0602DB28 RID: 187176 RVA: 0x006408B5 File Offset: 0x0063EAB5
		public IEnterSpecMovieCameraT AsIEnterSpecMovieCamera()
		{
			return this.As<IEnterSpecMovieCameraT>();
		}

		// Token: 0x0602DB29 RID: 187177 RVA: 0x006408BD File Offset: 0x0063EABD
		public static IEnterMovieCameraType_UnionUnion FromIEnterSpecMovieCamera(IEnterSpecMovieCameraT _ienterspecmoviecamera)
		{
			return new IEnterMovieCameraType_UnionUnion
			{
				Type = IEnterMovieCameraType_Union.IEnterSpecMovieCamera,
				Value = _ienterspecmoviecamera
			};
		}

		// Token: 0x0602DB2A RID: 187178 RVA: 0x006408D2 File Offset: 0x0063EAD2
		public IEnterRandomMovieCameraT AsIEnterRandomMovieCamera()
		{
			return this.As<IEnterRandomMovieCameraT>();
		}

		// Token: 0x0602DB2B RID: 187179 RVA: 0x006408DA File Offset: 0x0063EADA
		public static IEnterMovieCameraType_UnionUnion FromIEnterRandomMovieCamera(IEnterRandomMovieCameraT _ienterrandommoviecamera)
		{
			return new IEnterMovieCameraType_UnionUnion
			{
				Type = IEnterMovieCameraType_Union.IEnterRandomMovieCamera,
				Value = _ienterrandommoviecamera
			};
		}

		// Token: 0x0602DB2C RID: 187180 RVA: 0x006408F0 File Offset: 0x0063EAF0
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
