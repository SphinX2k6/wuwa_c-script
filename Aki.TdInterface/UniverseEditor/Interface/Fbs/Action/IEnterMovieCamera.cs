using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D25 RID: 27941
	public struct IEnterMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700CCFE RID: 52478
		// (get) Token: 0x06030312 RID: 197394 RVA: 0x0068D618 File Offset: 0x0068B818
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030313 RID: 197395 RVA: 0x0068D625 File Offset: 0x0068B825
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030314 RID: 197396 RVA: 0x0068D62C File Offset: 0x0068B82C
		public static IEnterMovieCamera GetRootAsIEnterMovieCamera(ByteBuffer _bb)
		{
			return IEnterMovieCamera.GetRootAsIEnterMovieCamera(_bb, default(IEnterMovieCamera));
		}

		// Token: 0x06030315 RID: 197397 RVA: 0x0068D648 File Offset: 0x0068B848
		public static IEnterMovieCamera GetRootAsIEnterMovieCamera(ByteBuffer _bb, IEnterMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030316 RID: 197398 RVA: 0x0068D665 File Offset: 0x0068B865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030317 RID: 197399 RVA: 0x0068D674 File Offset: 0x0068B874
		public IEnterMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCFF RID: 52479
		// (get) Token: 0x06030318 RID: 197400 RVA: 0x0068D684 File Offset: 0x0068B884
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

		// Token: 0x06030319 RID: 197401 RVA: 0x0068D6C0 File Offset: 0x0068B8C0
		public TTable? MovieCameraConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603031A RID: 197402 RVA: 0x0068D704 File Offset: 0x0068B904
		public IEnterCommonMovieCamera MovieCameraConfigAsIEnterCommonMovieCamera()
		{
			return this.MovieCameraConfig<IEnterCommonMovieCamera>().Value;
		}

		// Token: 0x0603031B RID: 197403 RVA: 0x0068D720 File Offset: 0x0068B920
		public IEnterRandomMovieCamera MovieCameraConfigAsIEnterRandomMovieCamera()
		{
			return this.MovieCameraConfig<IEnterRandomMovieCamera>().Value;
		}

		// Token: 0x0603031C RID: 197404 RVA: 0x0068D73C File Offset: 0x0068B93C
		public IEnterSpecMovieCamera MovieCameraConfigAsIEnterSpecMovieCamera()
		{
			return this.MovieCameraConfig<IEnterSpecMovieCamera>().Value;
		}

		// Token: 0x0603031D RID: 197405 RVA: 0x0068D757 File Offset: 0x0068B957
		public static Offset<IEnterMovieCamera> CreateIEnterMovieCamera(FlatBufferBuilder builder, TEnterMovieCameraType MovieCameraConfig_type = TEnterMovieCameraType.NONE, int MovieCameraConfigOffset = 0)
		{
			builder.StartTable(2);
			IEnterMovieCamera.AddMovieCameraConfig(builder, MovieCameraConfigOffset);
			IEnterMovieCamera.AddMovieCameraConfigType(builder, MovieCameraConfig_type);
			return IEnterMovieCamera.EndIEnterMovieCamera(builder);
		}

		// Token: 0x0603031E RID: 197406 RVA: 0x0068D774 File Offset: 0x0068B974
		public static void StartIEnterMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603031F RID: 197407 RVA: 0x0068D77D File Offset: 0x0068B97D
		public static void AddMovieCameraConfigType(FlatBufferBuilder builder, TEnterMovieCameraType movieCameraConfigType)
		{
			builder.AddByte(0, (byte)movieCameraConfigType, 0);
		}

		// Token: 0x06030320 RID: 197408 RVA: 0x0068D788 File Offset: 0x0068B988
		public static void AddMovieCameraConfig(FlatBufferBuilder builder, int movieCameraConfigOffset)
		{
			builder.AddOffset(1, movieCameraConfigOffset, 0);
		}

		// Token: 0x06030321 RID: 197409 RVA: 0x0068D793 File Offset: 0x0068B993
		public static Offset<IEnterMovieCamera> EndIEnterMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterMovieCamera>(builder.EndTable());
		}

		// Token: 0x06030322 RID: 197410 RVA: 0x0068D7A0 File Offset: 0x0068B9A0
		public IEnterMovieCameraT UnPack()
		{
			IEnterMovieCameraT enterMovieCameraT = new IEnterMovieCameraT();
			this.UnPackTo(enterMovieCameraT);
			return enterMovieCameraT;
		}

		// Token: 0x06030323 RID: 197411 RVA: 0x0068D7BC File Offset: 0x0068B9BC
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

		// Token: 0x06030324 RID: 197412 RVA: 0x0068D8A4 File Offset: 0x0068BAA4
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

		// Token: 0x04011B8B RID: 72587
		private Table __p;
	}
}
