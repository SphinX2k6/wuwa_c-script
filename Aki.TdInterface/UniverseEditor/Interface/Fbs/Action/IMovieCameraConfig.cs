using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B4 RID: 29364
	public struct IMovieCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700D752 RID: 55122
		// (get) Token: 0x06033305 RID: 209669 RVA: 0x006E845C File Offset: 0x006E665C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033306 RID: 209670 RVA: 0x006E8469 File Offset: 0x006E6669
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033307 RID: 209671 RVA: 0x006E8470 File Offset: 0x006E6670
		public static IMovieCameraConfig GetRootAsIMovieCameraConfig(ByteBuffer _bb)
		{
			return IMovieCameraConfig.GetRootAsIMovieCameraConfig(_bb, default(IMovieCameraConfig));
		}

		// Token: 0x06033308 RID: 209672 RVA: 0x006E848C File Offset: 0x006E668C
		public static IMovieCameraConfig GetRootAsIMovieCameraConfig(ByteBuffer _bb, IMovieCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033309 RID: 209673 RVA: 0x006E84A9 File Offset: 0x006E66A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603330A RID: 209674 RVA: 0x006E84B8 File Offset: 0x006E66B8
		public IMovieCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D753 RID: 55123
		// (get) Token: 0x0603330B RID: 209675 RVA: 0x006E84C8 File Offset: 0x006E66C8
		public TEnterMovieCameraType MovieCameraTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TEnterMovieCameraType.NONE;
				}
				return (TEnterMovieCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603330C RID: 209676 RVA: 0x006E8504 File Offset: 0x006E6704
		public TTable? MovieCameraType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603330D RID: 209677 RVA: 0x006E8548 File Offset: 0x006E6748
		public IEnterCommonMovieCamera MovieCameraTypeAsIEnterCommonMovieCamera()
		{
			return this.MovieCameraType<IEnterCommonMovieCamera>().Value;
		}

		// Token: 0x0603330E RID: 209678 RVA: 0x006E8564 File Offset: 0x006E6764
		public IEnterRandomMovieCamera MovieCameraTypeAsIEnterRandomMovieCamera()
		{
			return this.MovieCameraType<IEnterRandomMovieCamera>().Value;
		}

		// Token: 0x0603330F RID: 209679 RVA: 0x006E8580 File Offset: 0x006E6780
		public IEnterSpecMovieCamera MovieCameraTypeAsIEnterSpecMovieCamera()
		{
			return this.MovieCameraType<IEnterSpecMovieCamera>().Value;
		}

		// Token: 0x06033310 RID: 209680 RVA: 0x006E859B File Offset: 0x006E679B
		public static Offset<IMovieCameraConfig> CreateIMovieCameraConfig(FlatBufferBuilder builder, TEnterMovieCameraType MovieCameraType_type = TEnterMovieCameraType.NONE, int MovieCameraTypeOffset = 0)
		{
			builder.StartTable(2);
			IMovieCameraConfig.AddMovieCameraType(builder, MovieCameraTypeOffset);
			IMovieCameraConfig.AddMovieCameraTypeType(builder, MovieCameraType_type);
			return IMovieCameraConfig.EndIMovieCameraConfig(builder);
		}

		// Token: 0x06033311 RID: 209681 RVA: 0x006E85B8 File Offset: 0x006E67B8
		public static void StartIMovieCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033312 RID: 209682 RVA: 0x006E85C1 File Offset: 0x006E67C1
		public static void AddMovieCameraTypeType(FlatBufferBuilder builder, TEnterMovieCameraType movieCameraTypeType)
		{
			builder.AddByte(0, (byte)movieCameraTypeType, 0);
		}

		// Token: 0x06033313 RID: 209683 RVA: 0x006E85CC File Offset: 0x006E67CC
		public static void AddMovieCameraType(FlatBufferBuilder builder, int movieCameraTypeOffset)
		{
			builder.AddOffset(1, movieCameraTypeOffset, 0);
		}

		// Token: 0x06033314 RID: 209684 RVA: 0x006E85D7 File Offset: 0x006E67D7
		public static Offset<IMovieCameraConfig> EndIMovieCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMovieCameraConfig>(builder.EndTable());
		}

		// Token: 0x06033315 RID: 209685 RVA: 0x006E85E4 File Offset: 0x006E67E4
		public IMovieCameraConfigT UnPack()
		{
			IMovieCameraConfigT movieCameraConfigT = new IMovieCameraConfigT();
			this.UnPackTo(movieCameraConfigT);
			return movieCameraConfigT;
		}

		// Token: 0x06033316 RID: 209686 RVA: 0x006E8600 File Offset: 0x006E6800
		public void UnPackTo(IMovieCameraConfigT _o)
		{
			_o.MovieCameraType = new TEnterMovieCameraTypeUnion();
			_o.MovieCameraType.Type = this.MovieCameraTypeType;
			switch (this.MovieCameraTypeType)
			{
			case TEnterMovieCameraType.IEnterCommonMovieCamera:
				_o.MovieCameraType.Value = ((this.MovieCameraType<IEnterCommonMovieCamera>() != null) ? this.MovieCameraType<IEnterCommonMovieCamera>().Value.UnPack() : null);
				return;
			case TEnterMovieCameraType.IEnterRandomMovieCamera:
				_o.MovieCameraType.Value = ((this.MovieCameraType<IEnterRandomMovieCamera>() != null) ? this.MovieCameraType<IEnterRandomMovieCamera>().Value.UnPack() : null);
				return;
			case TEnterMovieCameraType.IEnterSpecMovieCamera:
				_o.MovieCameraType.Value = ((this.MovieCameraType<IEnterSpecMovieCamera>() != null) ? this.MovieCameraType<IEnterSpecMovieCamera>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033317 RID: 209687 RVA: 0x006E86E8 File Offset: 0x006E68E8
		public static Offset<IMovieCameraConfig> Pack(FlatBufferBuilder builder, IMovieCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovieCameraConfig>);
			}
			TEnterMovieCameraType movieCameraType_type = (_o.MovieCameraType == null) ? TEnterMovieCameraType.NONE : _o.MovieCameraType.Type;
			int movieCameraTypeOffset = (_o.MovieCameraType == null) ? 0 : TEnterMovieCameraTypeUnion.Pack(builder, _o.MovieCameraType);
			return IMovieCameraConfig.CreateIMovieCameraConfig(builder, movieCameraType_type, movieCameraTypeOffset);
		}

		// Token: 0x04012351 RID: 74577
		private Table __p;
	}
}
