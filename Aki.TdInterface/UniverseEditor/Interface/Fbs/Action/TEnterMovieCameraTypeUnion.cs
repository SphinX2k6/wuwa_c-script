using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B7 RID: 30391
	public class TEnterMovieCameraTypeUnion
	{
		// Token: 0x1700E613 RID: 58899
		// (get) Token: 0x0603747A RID: 226426 RVA: 0x0077D984 File Offset: 0x0077BB84
		// (set) Token: 0x0603747B RID: 226427 RVA: 0x0077D98C File Offset: 0x0077BB8C
		public TEnterMovieCameraType Type { get; set; }

		// Token: 0x1700E614 RID: 58900
		// (get) Token: 0x0603747C RID: 226428 RVA: 0x0077D995 File Offset: 0x0077BB95
		// (set) Token: 0x0603747D RID: 226429 RVA: 0x0077D99D File Offset: 0x0077BB9D
		public object Value { get; set; }

		// Token: 0x0603747E RID: 226430 RVA: 0x0077D9A6 File Offset: 0x0077BBA6
		public TEnterMovieCameraTypeUnion()
		{
			this.Type = TEnterMovieCameraType.NONE;
			this.Value = null;
		}

		// Token: 0x0603747F RID: 226431 RVA: 0x0077D9BC File Offset: 0x0077BBBC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037480 RID: 226432 RVA: 0x0077D9CE File Offset: 0x0077BBCE
		public IEnterCommonMovieCameraT AsIEnterCommonMovieCamera()
		{
			return this.As<IEnterCommonMovieCameraT>();
		}

		// Token: 0x06037481 RID: 226433 RVA: 0x0077D9D6 File Offset: 0x0077BBD6
		public static TEnterMovieCameraTypeUnion FromIEnterCommonMovieCamera(IEnterCommonMovieCameraT _ientercommonmoviecamera)
		{
			return new TEnterMovieCameraTypeUnion
			{
				Type = TEnterMovieCameraType.IEnterCommonMovieCamera,
				Value = _ientercommonmoviecamera
			};
		}

		// Token: 0x06037482 RID: 226434 RVA: 0x0077D9EB File Offset: 0x0077BBEB
		public IEnterRandomMovieCameraT AsIEnterRandomMovieCamera()
		{
			return this.As<IEnterRandomMovieCameraT>();
		}

		// Token: 0x06037483 RID: 226435 RVA: 0x0077D9F3 File Offset: 0x0077BBF3
		public static TEnterMovieCameraTypeUnion FromIEnterRandomMovieCamera(IEnterRandomMovieCameraT _ienterrandommoviecamera)
		{
			return new TEnterMovieCameraTypeUnion
			{
				Type = TEnterMovieCameraType.IEnterRandomMovieCamera,
				Value = _ienterrandommoviecamera
			};
		}

		// Token: 0x06037484 RID: 226436 RVA: 0x0077DA08 File Offset: 0x0077BC08
		public IEnterSpecMovieCameraT AsIEnterSpecMovieCamera()
		{
			return this.As<IEnterSpecMovieCameraT>();
		}

		// Token: 0x06037485 RID: 226437 RVA: 0x0077DA10 File Offset: 0x0077BC10
		public static TEnterMovieCameraTypeUnion FromIEnterSpecMovieCamera(IEnterSpecMovieCameraT _ienterspecmoviecamera)
		{
			return new TEnterMovieCameraTypeUnion
			{
				Type = TEnterMovieCameraType.IEnterSpecMovieCamera,
				Value = _ienterspecmoviecamera
			};
		}

		// Token: 0x06037486 RID: 226438 RVA: 0x0077DA28 File Offset: 0x0077BC28
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
