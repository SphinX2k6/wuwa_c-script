using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A4 RID: 29092
	public struct IMechEscortPoint : IFlatbufferObject
	{
		// Token: 0x1700D513 RID: 54547
		// (get) Token: 0x0603298F RID: 207247 RVA: 0x006D6563 File Offset: 0x006D4763
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032990 RID: 207248 RVA: 0x006D6570 File Offset: 0x006D4770
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032991 RID: 207249 RVA: 0x006D6578 File Offset: 0x006D4778
		public static IMechEscortPoint GetRootAsIMechEscortPoint(ByteBuffer _bb)
		{
			return IMechEscortPoint.GetRootAsIMechEscortPoint(_bb, default(IMechEscortPoint));
		}

		// Token: 0x06032992 RID: 207250 RVA: 0x006D6594 File Offset: 0x006D4794
		public static IMechEscortPoint GetRootAsIMechEscortPoint(ByteBuffer _bb, IMechEscortPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032993 RID: 207251 RVA: 0x006D65B1 File Offset: 0x006D47B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032994 RID: 207252 RVA: 0x006D65C0 File Offset: 0x006D47C0
		public IMechEscortPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D514 RID: 54548
		// (get) Token: 0x06032995 RID: 207253 RVA: 0x006D65D0 File Offset: 0x006D47D0
		public int SplinePointIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D515 RID: 54549
		// (get) Token: 0x06032996 RID: 207254 RVA: 0x006D660C File Offset: 0x006D480C
		public float ForwardOffset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D516 RID: 54550
		// (get) Token: 0x06032997 RID: 207255 RVA: 0x006D664C File Offset: 0x006D484C
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D517 RID: 54551
		// (get) Token: 0x06032998 RID: 207256 RVA: 0x006D668C File Offset: 0x006D488C
		public float Angle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D518 RID: 54552
		// (get) Token: 0x06032999 RID: 207257 RVA: 0x006D66D0 File Offset: 0x006D48D0
		public TEnterMovieCameraType MovieCameraType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TEnterMovieCameraType.NONE;
				}
				return (TEnterMovieCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603299A RID: 207258 RVA: 0x006D6710 File Offset: 0x006D4910
		public TTable? MovieCamera<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603299B RID: 207259 RVA: 0x006D6758 File Offset: 0x006D4958
		public IEnterCommonMovieCamera MovieCameraAsIEnterCommonMovieCamera()
		{
			return this.MovieCamera<IEnterCommonMovieCamera>().Value;
		}

		// Token: 0x0603299C RID: 207260 RVA: 0x006D6774 File Offset: 0x006D4974
		public IEnterRandomMovieCamera MovieCameraAsIEnterRandomMovieCamera()
		{
			return this.MovieCamera<IEnterRandomMovieCamera>().Value;
		}

		// Token: 0x0603299D RID: 207261 RVA: 0x006D6790 File Offset: 0x006D4990
		public IEnterSpecMovieCamera MovieCameraAsIEnterSpecMovieCamera()
		{
			return this.MovieCamera<IEnterSpecMovieCamera>().Value;
		}

		// Token: 0x0603299E RID: 207262 RVA: 0x006D67AB File Offset: 0x006D49AB
		public static Offset<IMechEscortPoint> CreateIMechEscortPoint(FlatBufferBuilder builder, int SplinePointIndex = 0, float ForwardOffset = 0f, float Radius = 0f, float Angle = 0f, TEnterMovieCameraType MovieCamera_type = TEnterMovieCameraType.NONE, int MovieCameraOffset = 0)
		{
			builder.StartTable(6);
			IMechEscortPoint.AddMovieCamera(builder, MovieCameraOffset);
			IMechEscortPoint.AddAngle(builder, Angle);
			IMechEscortPoint.AddRadius(builder, Radius);
			IMechEscortPoint.AddForwardOffset(builder, ForwardOffset);
			IMechEscortPoint.AddSplinePointIndex(builder, SplinePointIndex);
			IMechEscortPoint.AddMovieCameraType(builder, MovieCamera_type);
			return IMechEscortPoint.EndIMechEscortPoint(builder);
		}

		// Token: 0x0603299F RID: 207263 RVA: 0x006D67E7 File Offset: 0x006D49E7
		public static void StartIMechEscortPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060329A0 RID: 207264 RVA: 0x006D67F0 File Offset: 0x006D49F0
		public static void AddSplinePointIndex(FlatBufferBuilder builder, int splinePointIndex)
		{
			builder.AddInt(0, splinePointIndex, 0);
		}

		// Token: 0x060329A1 RID: 207265 RVA: 0x006D67FB File Offset: 0x006D49FB
		public static void AddForwardOffset(FlatBufferBuilder builder, float forwardOffset)
		{
			builder.AddFloat(1, forwardOffset, 0.0);
		}

		// Token: 0x060329A2 RID: 207266 RVA: 0x006D680E File Offset: 0x006D4A0E
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060329A3 RID: 207267 RVA: 0x006D6821 File Offset: 0x006D4A21
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(3, angle, 0.0);
		}

		// Token: 0x060329A4 RID: 207268 RVA: 0x006D6834 File Offset: 0x006D4A34
		public static void AddMovieCameraType(FlatBufferBuilder builder, TEnterMovieCameraType movieCameraType)
		{
			builder.AddByte(4, (byte)movieCameraType, 0);
		}

		// Token: 0x060329A5 RID: 207269 RVA: 0x006D683F File Offset: 0x006D4A3F
		public static void AddMovieCamera(FlatBufferBuilder builder, int movieCameraOffset)
		{
			builder.AddOffset(5, movieCameraOffset, 0);
		}

		// Token: 0x060329A6 RID: 207270 RVA: 0x006D684A File Offset: 0x006D4A4A
		public static Offset<IMechEscortPoint> EndIMechEscortPoint(FlatBufferBuilder builder)
		{
			return new Offset<IMechEscortPoint>(builder.EndTable());
		}

		// Token: 0x060329A7 RID: 207271 RVA: 0x006D6858 File Offset: 0x006D4A58
		public IMechEscortPointT UnPack()
		{
			IMechEscortPointT mechEscortPointT = new IMechEscortPointT();
			this.UnPackTo(mechEscortPointT);
			return mechEscortPointT;
		}

		// Token: 0x060329A8 RID: 207272 RVA: 0x006D6874 File Offset: 0x006D4A74
		public void UnPackTo(IMechEscortPointT _o)
		{
			_o.SplinePointIndex = this.SplinePointIndex;
			_o.ForwardOffset = this.ForwardOffset;
			_o.Radius = this.Radius;
			_o.Angle = this.Angle;
			_o.MovieCamera = new TEnterMovieCameraTypeUnion();
			_o.MovieCamera.Type = this.MovieCameraType;
			switch (this.MovieCameraType)
			{
			case TEnterMovieCameraType.IEnterCommonMovieCamera:
				_o.MovieCamera.Value = ((this.MovieCamera<IEnterCommonMovieCamera>() != null) ? this.MovieCamera<IEnterCommonMovieCamera>().Value.UnPack() : null);
				return;
			case TEnterMovieCameraType.IEnterRandomMovieCamera:
				_o.MovieCamera.Value = ((this.MovieCamera<IEnterRandomMovieCamera>() != null) ? this.MovieCamera<IEnterRandomMovieCamera>().Value.UnPack() : null);
				return;
			case TEnterMovieCameraType.IEnterSpecMovieCamera:
				_o.MovieCamera.Value = ((this.MovieCamera<IEnterSpecMovieCamera>() != null) ? this.MovieCamera<IEnterSpecMovieCamera>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060329A9 RID: 207273 RVA: 0x006D698C File Offset: 0x006D4B8C
		public static Offset<IMechEscortPoint> Pack(FlatBufferBuilder builder, IMechEscortPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechEscortPoint>);
			}
			TEnterMovieCameraType movieCamera_type = (_o.MovieCamera == null) ? TEnterMovieCameraType.NONE : _o.MovieCamera.Type;
			int movieCameraOffset = (_o.MovieCamera == null) ? 0 : TEnterMovieCameraTypeUnion.Pack(builder, _o.MovieCamera);
			return IMechEscortPoint.CreateIMechEscortPoint(builder, _o.SplinePointIndex, _o.ForwardOffset, _o.Radius, _o.Angle, movieCamera_type, movieCameraOffset);
		}

		// Token: 0x040121B0 RID: 74160
		private Table __p;
	}
}
