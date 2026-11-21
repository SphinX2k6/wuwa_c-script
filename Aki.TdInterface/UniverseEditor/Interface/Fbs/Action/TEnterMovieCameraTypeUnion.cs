using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EC2 RID: 32450
	public class TEnterMovieCameraTypeUnion
	{
		// Token: 0x1700F24F RID: 62031
		// (get) Token: 0x0603A91D RID: 239901 RVA: 0x007E1AD8 File Offset: 0x007DFCD8
		// (set) Token: 0x0603A91E RID: 239902 RVA: 0x007E1AE0 File Offset: 0x007DFCE0
		public TEnterMovieCameraType Type { get; set; }

		// Token: 0x1700F250 RID: 62032
		// (get) Token: 0x0603A91F RID: 239903 RVA: 0x007E1AE9 File Offset: 0x007DFCE9
		// (set) Token: 0x0603A920 RID: 239904 RVA: 0x007E1AF1 File Offset: 0x007DFCF1
		public object Value { get; set; }

		// Token: 0x0603A921 RID: 239905 RVA: 0x007E1AFA File Offset: 0x007DFCFA
		public TEnterMovieCameraTypeUnion()
		{
			this.Type = TEnterMovieCameraType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A922 RID: 239906 RVA: 0x007E1B10 File Offset: 0x007DFD10
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A923 RID: 239907 RVA: 0x007E1B22 File Offset: 0x007DFD22
		public IEnterCommonMovieCameraT AsIEnterCommonMovieCamera()
		{
			return this.As<IEnterCommonMovieCameraT>();
		}

		// Token: 0x0603A924 RID: 239908 RVA: 0x007E1B2A File Offset: 0x007DFD2A
		public static TEnterMovieCameraTypeUnion FromIEnterCommonMovieCamera(IEnterCommonMovieCameraT _ientercommonmoviecamera)
		{
			return new TEnterMovieCameraTypeUnion
			{
				Type = TEnterMovieCameraType.IEnterCommonMovieCamera,
				Value = _ientercommonmoviecamera
			};
		}

		// Token: 0x0603A925 RID: 239909 RVA: 0x007E1B3F File Offset: 0x007DFD3F
		public IEnterRandomMovieCameraT AsIEnterRandomMovieCamera()
		{
			return this.As<IEnterRandomMovieCameraT>();
		}

		// Token: 0x0603A926 RID: 239910 RVA: 0x007E1B47 File Offset: 0x007DFD47
		public static TEnterMovieCameraTypeUnion FromIEnterRandomMovieCamera(IEnterRandomMovieCameraT _ienterrandommoviecamera)
		{
			return new TEnterMovieCameraTypeUnion
			{
				Type = TEnterMovieCameraType.IEnterRandomMovieCamera,
				Value = _ienterrandommoviecamera
			};
		}

		// Token: 0x0603A927 RID: 239911 RVA: 0x007E1B5C File Offset: 0x007DFD5C
		public IEnterSpecMovieCameraT AsIEnterSpecMovieCamera()
		{
			return this.As<IEnterSpecMovieCameraT>();
		}

		// Token: 0x0603A928 RID: 239912 RVA: 0x007E1B64 File Offset: 0x007DFD64
		public static TEnterMovieCameraTypeUnion FromIEnterSpecMovieCamera(IEnterSpecMovieCameraT _ienterspecmoviecamera)
		{
			return new TEnterMovieCameraTypeUnion
			{
				Type = TEnterMovieCameraType.IEnterSpecMovieCamera,
				Value = _ienterspecmoviecamera
			};
		}

		// Token: 0x0603A929 RID: 239913 RVA: 0x007E1B7C File Offset: 0x007DFD7C
		public static int Pack(FlatBufferBuilder builder, TEnterMovieCameraTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TEnterMovieCameraType.IEnterCommonMovieCamera:
				return IEnterCommonMovieCamera.Pack(builder, _o.AsIEnterCommonMovieCamera()).Value;
			case TEnterMovieCameraType.IEnterRandomMovieCamera:
				return IEnterRandomMovieCamera.Pack(builder, _o.AsIEnterRandomMovieCamera()).Value;
			case TEnterMovieCameraType.IEnterSpecMovieCamera:
				return IEnterSpecMovieCamera.Pack(builder, _o.AsIEnterSpecMovieCamera()).Value;
			default:
				return 0;
			}
		}
	}
}
