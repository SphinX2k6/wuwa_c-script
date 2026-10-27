using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6E RID: 27502
	public struct IMovieCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700CC6D RID: 52333
		// (get) Token: 0x060304AD RID: 197805 RVA: 0x0068FE3C File Offset: 0x0068E03C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060304AE RID: 197806 RVA: 0x0068FE49 File Offset: 0x0068E049
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060304AF RID: 197807 RVA: 0x0068FE50 File Offset: 0x0068E050
		public static IMovieCameraConfig GetRootAsIMovieCameraConfig(ByteBuffer _bb)
		{
			return IMovieCameraConfig.GetRootAsIMovieCameraConfig(_bb, default(IMovieCameraConfig));
		}

		// Token: 0x060304B0 RID: 197808 RVA: 0x0068FE6C File Offset: 0x0068E06C
		public static IMovieCameraConfig GetRootAsIMovieCameraConfig(ByteBuffer _bb, IMovieCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060304B1 RID: 197809 RVA: 0x0068FE89 File Offset: 0x0068E089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060304B2 RID: 197810 RVA: 0x0068FE98 File Offset: 0x0068E098
		public IMovieCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC6E RID: 52334
		// (get) Token: 0x060304B3 RID: 197811 RVA: 0x0068FEA8 File Offset: 0x0068E0A8
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

		// Token: 0x060304B4 RID: 197812 RVA: 0x0068FEE4 File Offset: 0x0068E0E4
		public TTable? MovieCameraType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060304B5 RID: 197813 RVA: 0x0068FF28 File Offset: 0x0068E128
		public IEnterCommonMovieCamera MovieCameraTypeAsIEnterCommonMovieCamera()
		{
			return this.MovieCameraType<IEnterCommonMovieCamera>().Value;
		}

		// Token: 0x060304B6 RID: 197814 RVA: 0x0068FF44 File Offset: 0x0068E144
		public IEnterRandomMovieCamera MovieCameraTypeAsIEnterRandomMovieCamera()
		{
			return this.MovieCameraType<IEnterRandomMovieCamera>().Value;
		}

		// Token: 0x060304B7 RID: 197815 RVA: 0x0068FF60 File Offset: 0x0068E160
		public IEnterSpecMovieCamera MovieCameraTypeAsIEnterSpecMovieCamera()
		{
			return this.MovieCameraType<IEnterSpecMovieCamera>().Value;
		}

		// Token: 0x060304B8 RID: 197816 RVA: 0x0068FF7B File Offset: 0x0068E17B
		public static Offset<IMovieCameraConfig> CreateIMovieCameraConfig(FlatBufferBuilder builder, TEnterMovieCameraType MovieCameraType_type = TEnterMovieCameraType.NONE, int MovieCameraTypeOffset = 0)
		{
			builder.StartTable(2);
			IMovieCameraConfig.AddMovieCameraType(builder, MovieCameraTypeOffset);
			IMovieCameraConfig.AddMovieCameraTypeType(builder, MovieCameraType_type);
			return IMovieCameraConfig.EndIMovieCameraConfig(builder);
		}

		// Token: 0x060304B9 RID: 197817 RVA: 0x0068FF98 File Offset: 0x0068E198
		public static void StartIMovieCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060304BA RID: 197818 RVA: 0x0068FFA1 File Offset: 0x0068E1A1
		public static void AddMovieCameraTypeType(FlatBufferBuilder builder, TEnterMovieCameraType movieCameraTypeType)
		{
			builder.AddByte(0, (byte)movieCameraTypeType, 0);
		}

		// Token: 0x060304BB RID: 197819 RVA: 0x0068FFAC File Offset: 0x0068E1AC
		public static void AddMovieCameraType(FlatBufferBuilder builder, int movieCameraTypeOffset)
		{
			builder.AddOffset(1, movieCameraTypeOffset, 0);
		}

		// Token: 0x060304BC RID: 197820 RVA: 0x0068FFB7 File Offset: 0x0068E1B7
		public static Offset<IMovieCameraConfig> EndIMovieCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMovieCameraConfig>(builder.EndTable());
		}

		// Token: 0x060304BD RID: 197821 RVA: 0x0068FFC4 File Offset: 0x0068E1C4
		public IMovieCameraConfigT UnPack()
		{
			IMovieCameraConfigT movieCameraConfigT = new IMovieCameraConfigT();
			this.UnPackTo(movieCameraConfigT);
			return movieCameraConfigT;
		}

		// Token: 0x060304BE RID: 197822 RVA: 0x0068FFE0 File Offset: 0x0068E1E0
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

		// Token: 0x060304BF RID: 197823 RVA: 0x006900C8 File Offset: 0x0068E2C8
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

		// Token: 0x04011428 RID: 70696
		private Table __p;
	}
}
