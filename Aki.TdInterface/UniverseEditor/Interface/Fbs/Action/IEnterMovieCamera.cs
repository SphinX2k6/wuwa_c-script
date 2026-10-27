using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066AB RID: 26283
	public struct IEnterMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700C34D RID: 49997
		// (get) Token: 0x0602DAF5 RID: 187125 RVA: 0x00640364 File Offset: 0x0063E564
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DAF6 RID: 187126 RVA: 0x00640371 File Offset: 0x0063E571
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DAF7 RID: 187127 RVA: 0x00640378 File Offset: 0x0063E578
		public static IEnterMovieCamera GetRootAsIEnterMovieCamera(ByteBuffer _bb)
		{
			return IEnterMovieCamera.GetRootAsIEnterMovieCamera(_bb, default(IEnterMovieCamera));
		}

		// Token: 0x0602DAF8 RID: 187128 RVA: 0x00640394 File Offset: 0x0063E594
		public static IEnterMovieCamera GetRootAsIEnterMovieCamera(ByteBuffer _bb, IEnterMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DAF9 RID: 187129 RVA: 0x006403B1 File Offset: 0x0063E5B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DAFA RID: 187130 RVA: 0x006403C0 File Offset: 0x0063E5C0
		public IEnterMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C34E RID: 49998
		// (get) Token: 0x0602DAFB RID: 187131 RVA: 0x006403D0 File Offset: 0x0063E5D0
		public TEnterMovieCameraType MovieCameraConfigType
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

		// Token: 0x0602DAFC RID: 187132 RVA: 0x0064040C File Offset: 0x0063E60C
		public TTable? MovieCameraConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DAFD RID: 187133 RVA: 0x00640450 File Offset: 0x0063E650
		public IEnterCommonMovieCamera MovieCameraConfigAsIEnterCommonMovieCamera()
		{
			return this.MovieCameraConfig<IEnterCommonMovieCamera>().Value;
		}

		// Token: 0x0602DAFE RID: 187134 RVA: 0x0064046C File Offset: 0x0063E66C
		public IEnterRandomMovieCamera MovieCameraConfigAsIEnterRandomMovieCamera()
		{
			return this.MovieCameraConfig<IEnterRandomMovieCamera>().Value;
		}

		// Token: 0x0602DAFF RID: 187135 RVA: 0x00640488 File Offset: 0x0063E688
		public IEnterSpecMovieCamera MovieCameraConfigAsIEnterSpecMovieCamera()
		{
			return this.MovieCameraConfig<IEnterSpecMovieCamera>().Value;
		}

		// Token: 0x0602DB00 RID: 187136 RVA: 0x006404A3 File Offset: 0x0063E6A3
		public static Offset<IEnterMovieCamera> CreateIEnterMovieCamera(FlatBufferBuilder builder, TEnterMovieCameraType MovieCameraConfig_type = TEnterMovieCameraType.NONE, int MovieCameraConfigOffset = 0)
		{
			builder.StartTable(2);
			IEnterMovieCamera.AddMovieCameraConfig(builder, MovieCameraConfigOffset);
			IEnterMovieCamera.AddMovieCameraConfigType(builder, MovieCameraConfig_type);
			return IEnterMovieCamera.EndIEnterMovieCamera(builder);
		}

		// Token: 0x0602DB01 RID: 187137 RVA: 0x006404C0 File Offset: 0x0063E6C0
		public static void StartIEnterMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DB02 RID: 187138 RVA: 0x006404C9 File Offset: 0x0063E6C9
		public static void AddMovieCameraConfigType(FlatBufferBuilder builder, TEnterMovieCameraType movieCameraConfigType)
		{
			builder.AddByte(0, (byte)movieCameraConfigType, 0);
		}

		// Token: 0x0602DB03 RID: 187139 RVA: 0x006404D4 File Offset: 0x0063E6D4
		public static void AddMovieCameraConfig(FlatBufferBuilder builder, int movieCameraConfigOffset)
		{
			builder.AddOffset(1, movieCameraConfigOffset, 0);
		}

		// Token: 0x0602DB04 RID: 187140 RVA: 0x006404DF File Offset: 0x0063E6DF
		public static Offset<IEnterMovieCamera> EndIEnterMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterMovieCamera>(builder.EndTable());
		}

		// Token: 0x0602DB05 RID: 187141 RVA: 0x006404EC File Offset: 0x0063E6EC
		public IEnterMovieCameraT UnPack()
		{
			IEnterMovieCameraT enterMovieCameraT = new IEnterMovieCameraT();
			this.UnPackTo(enterMovieCameraT);
			return enterMovieCameraT;
		}

		// Token: 0x0602DB06 RID: 187142 RVA: 0x00640508 File Offset: 0x0063E708
		public void UnPackTo(IEnterMovieCameraT _o)
		{
			_o.MovieCameraConfig = new TEnterMovieCameraTypeUnion();
			_o.MovieCameraConfig.Type = this.MovieCameraConfigType;
			switch (this.MovieCameraConfigType)
			{
			case TEnterMovieCameraType.IEnterCommonMovieCamera:
				_o.MovieCameraConfig.Value = ((this.MovieCameraConfig<IEnterCommonMovieCamera>() != null) ? this.MovieCameraConfig<IEnterCommonMovieCamera>().Value.UnPack() : null);
				return;
			case TEnterMovieCameraType.IEnterRandomMovieCamera:
				_o.MovieCameraConfig.Value = ((this.MovieCameraConfig<IEnterRandomMovieCamera>() != null) ? this.MovieCameraConfig<IEnterRandomMovieCamera>().Value.UnPack() : null);
				return;
			case TEnterMovieCameraType.IEnterSpecMovieCamera:
				_o.MovieCameraConfig.Value = ((this.MovieCameraConfig<IEnterSpecMovieCamera>() != null) ? this.MovieCameraConfig<IEnterSpecMovieCamera>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602DB07 RID: 187143 RVA: 0x006405F0 File Offset: 0x0063E7F0
		public static Offset<IEnterMovieCamera> Pack(FlatBufferBuilder builder, IEnterMovieCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterMovieCamera>);
			}
			TEnterMovieCameraType movieCameraConfig_type = (_o.MovieCameraConfig == null) ? TEnterMovieCameraType.NONE : _o.MovieCameraConfig.Type;
			int movieCameraConfigOffset = (_o.MovieCameraConfig == null) ? 0 : TEnterMovieCameraTypeUnion.Pack(builder, _o.MovieCameraConfig);
			return IEnterMovieCamera.CreateIEnterMovieCamera(builder, movieCameraConfig_type, movieCameraConfigOffset);
		}

		// Token: 0x04010D65 RID: 68965
		private Table __p;
	}
}
