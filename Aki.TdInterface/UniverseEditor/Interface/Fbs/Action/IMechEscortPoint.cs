using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A82 RID: 27266
	public struct IMechEscortPoint : IFlatbufferObject
	{
		// Token: 0x1700CA68 RID: 51816
		// (get) Token: 0x0602FC69 RID: 195689 RVA: 0x006804A3 File Offset: 0x0067E6A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC6A RID: 195690 RVA: 0x006804B0 File Offset: 0x0067E6B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC6B RID: 195691 RVA: 0x006804B8 File Offset: 0x0067E6B8
		public static IMechEscortPoint GetRootAsIMechEscortPoint(ByteBuffer _bb)
		{
			return IMechEscortPoint.GetRootAsIMechEscortPoint(_bb, default(IMechEscortPoint));
		}

		// Token: 0x0602FC6C RID: 195692 RVA: 0x006804D4 File Offset: 0x0067E6D4
		public static IMechEscortPoint GetRootAsIMechEscortPoint(ByteBuffer _bb, IMechEscortPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC6D RID: 195693 RVA: 0x006804F1 File Offset: 0x0067E6F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC6E RID: 195694 RVA: 0x00680500 File Offset: 0x0067E700
		public IMechEscortPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA69 RID: 51817
		// (get) Token: 0x0602FC6F RID: 195695 RVA: 0x00680510 File Offset: 0x0067E710
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

		// Token: 0x1700CA6A RID: 51818
		// (get) Token: 0x0602FC70 RID: 195696 RVA: 0x0068054C File Offset: 0x0067E74C
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

		// Token: 0x1700CA6B RID: 51819
		// (get) Token: 0x0602FC71 RID: 195697 RVA: 0x0068058C File Offset: 0x0067E78C
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

		// Token: 0x1700CA6C RID: 51820
		// (get) Token: 0x0602FC72 RID: 195698 RVA: 0x006805CC File Offset: 0x0067E7CC
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

		// Token: 0x1700CA6D RID: 51821
		// (get) Token: 0x0602FC73 RID: 195699 RVA: 0x00680610 File Offset: 0x0067E810
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

		// Token: 0x0602FC74 RID: 195700 RVA: 0x00680650 File Offset: 0x0067E850
		public TTable? MovieCamera<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FC75 RID: 195701 RVA: 0x00680698 File Offset: 0x0067E898
		public IEnterCommonMovieCamera MovieCameraAsIEnterCommonMovieCamera()
		{
			return this.MovieCamera<IEnterCommonMovieCamera>().Value;
		}

		// Token: 0x0602FC76 RID: 195702 RVA: 0x006806B4 File Offset: 0x0067E8B4
		public IEnterRandomMovieCamera MovieCameraAsIEnterRandomMovieCamera()
		{
			return this.MovieCamera<IEnterRandomMovieCamera>().Value;
		}

		// Token: 0x0602FC77 RID: 195703 RVA: 0x006806D0 File Offset: 0x0067E8D0
		public IEnterSpecMovieCamera MovieCameraAsIEnterSpecMovieCamera()
		{
			return this.MovieCamera<IEnterSpecMovieCamera>().Value;
		}

		// Token: 0x0602FC78 RID: 195704 RVA: 0x006806EB File Offset: 0x0067E8EB
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

		// Token: 0x0602FC79 RID: 195705 RVA: 0x00680727 File Offset: 0x0067E927
		public static void StartIMechEscortPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602FC7A RID: 195706 RVA: 0x00680730 File Offset: 0x0067E930
		public static void AddSplinePointIndex(FlatBufferBuilder builder, int splinePointIndex)
		{
			builder.AddInt(0, splinePointIndex, 0);
		}

		// Token: 0x0602FC7B RID: 195707 RVA: 0x0068073B File Offset: 0x0067E93B
		public static void AddForwardOffset(FlatBufferBuilder builder, float forwardOffset)
		{
			builder.AddFloat(1, forwardOffset, 0.0);
		}

		// Token: 0x0602FC7C RID: 195708 RVA: 0x0068074E File Offset: 0x0067E94E
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x0602FC7D RID: 195709 RVA: 0x00680761 File Offset: 0x0067E961
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(3, angle, 0.0);
		}

		// Token: 0x0602FC7E RID: 195710 RVA: 0x00680774 File Offset: 0x0067E974
		public static void AddMovieCameraType(FlatBufferBuilder builder, TEnterMovieCameraType movieCameraType)
		{
			builder.AddByte(4, (byte)movieCameraType, 0);
		}

		// Token: 0x0602FC7F RID: 195711 RVA: 0x0068077F File Offset: 0x0067E97F
		public static void AddMovieCamera(FlatBufferBuilder builder, int movieCameraOffset)
		{
			builder.AddOffset(5, movieCameraOffset, 0);
		}

		// Token: 0x0602FC80 RID: 195712 RVA: 0x0068078A File Offset: 0x0067E98A
		public static Offset<IMechEscortPoint> EndIMechEscortPoint(FlatBufferBuilder builder)
		{
			return new Offset<IMechEscortPoint>(builder.EndTable());
		}

		// Token: 0x0602FC81 RID: 195713 RVA: 0x00680798 File Offset: 0x0067E998
		public IMechEscortPointT UnPack()
		{
			IMechEscortPointT mechEscortPointT = new IMechEscortPointT();
			this.UnPackTo(mechEscortPointT);
			return mechEscortPointT;
		}

		// Token: 0x0602FC82 RID: 195714 RVA: 0x006807B4 File Offset: 0x0067E9B4
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

		// Token: 0x0602FC83 RID: 195715 RVA: 0x006808CC File Offset: 0x0067EACC
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

		// Token: 0x040112B8 RID: 70328
		private Table __p;
	}
}
