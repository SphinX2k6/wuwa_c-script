using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2C RID: 27948
	public struct IPlayMovie : IFlatbufferObject
	{
		// Token: 0x1700D02D RID: 53293
		// (get) Token: 0x060314C6 RID: 201926 RVA: 0x006AF993 File Offset: 0x006ADB93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060314C7 RID: 201927 RVA: 0x006AF9A0 File Offset: 0x006ADBA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060314C8 RID: 201928 RVA: 0x006AF9A8 File Offset: 0x006ADBA8
		public static IPlayMovie GetRootAsIPlayMovie(ByteBuffer _bb)
		{
			return IPlayMovie.GetRootAsIPlayMovie(_bb, default(IPlayMovie));
		}

		// Token: 0x060314C9 RID: 201929 RVA: 0x006AF9C4 File Offset: 0x006ADBC4
		public static IPlayMovie GetRootAsIPlayMovie(ByteBuffer _bb, IPlayMovie obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060314CA RID: 201930 RVA: 0x006AF9E1 File Offset: 0x006ADBE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060314CB RID: 201931 RVA: 0x006AF9F0 File Offset: 0x006ADBF0
		public IPlayMovie __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D02E RID: 53294
		// (get) Token: 0x060314CC RID: 201932 RVA: 0x006AFA00 File Offset: 0x006ADC00
		public string VideoName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060314CD RID: 201933 RVA: 0x006AFA37 File Offset: 0x006ADC37
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060314CE RID: 201934 RVA: 0x006AFA46 File Offset: 0x006ADC46
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D02F RID: 53295
		// (get) Token: 0x060314CF RID: 201935 RVA: 0x006AFA54 File Offset: 0x006ADC54
		public IMovieBackgroundFadeData? BackgroundFade
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMovieBackgroundFadeData?(default(IMovieBackgroundFadeData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x1700D030 RID: 53296
		// (get) Token: 0x060314D0 RID: 201936 RVA: 0x006AFAA8 File Offset: 0x006ADCA8
		public IMp4UiReplaceMaterial? ProgramSpecialConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMp4UiReplaceMaterial?(default(IMp4UiReplaceMaterial).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D031 RID: 53297
		// (get) Token: 0x060314D1 RID: 201937 RVA: 0x006AFB08 File Offset: 0x006ADD08
		public float Mp4FadeOutTime
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

		// Token: 0x1700D032 RID: 53298
		// (get) Token: 0x060314D2 RID: 201938 RVA: 0x006AFB4C File Offset: 0x006ADD4C
		public float BlackBorderFadeOutTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060314D3 RID: 201939 RVA: 0x006AFB90 File Offset: 0x006ADD90
		public IMp4FrameEvent? Mp4FrameEvents(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IMp4FrameEvent?(default(IMp4FrameEvent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D033 RID: 53299
		// (get) Token: 0x060314D4 RID: 201940 RVA: 0x006AFBF4 File Offset: 0x006ADDF4
		public int Mp4FrameEventsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700D034 RID: 53300
		// (get) Token: 0x060314D5 RID: 201941 RVA: 0x006AFC20 File Offset: 0x006ADE20
		public ISetBlendAnim? Mp4BlendAnim
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ISetBlendAnim?(default(ISetBlendAnim).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D035 RID: 53301
		// (get) Token: 0x060314D6 RID: 201942 RVA: 0x006AFC80 File Offset: 0x006ADE80
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060314D7 RID: 201943 RVA: 0x006AFCC0 File Offset: 0x006ADEC0
		public static Offset<IPlayMovie> CreateIPlayMovie(FlatBufferBuilder builder, StringOffset VideoNameOffset = default(StringOffset), IMovieBackgroundFadeDataT BackgroundFade = null, Offset<IMp4UiReplaceMaterial> ProgramSpecialConfigOffset = default(Offset<IMp4UiReplaceMaterial>), float Mp4FadeOutTime = 0f, float BlackBorderFadeOutTime = 0f, VectorOffset Mp4FrameEventsOffset = default(VectorOffset), Offset<ISetBlendAnim> Mp4BlendAnimOffset = default(Offset<ISetBlendAnim>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IPlayMovie.AddMp4BlendAnim(builder, Mp4BlendAnimOffset);
			IPlayMovie.AddMp4FrameEvents(builder, Mp4FrameEventsOffset);
			IPlayMovie.AddBlackBorderFadeOutTime(builder, BlackBorderFadeOutTime);
			IPlayMovie.AddMp4FadeOutTime(builder, Mp4FadeOutTime);
			IPlayMovie.AddProgramSpecialConfig(builder, ProgramSpecialConfigOffset);
			IPlayMovie.AddBackgroundFade(builder, IMovieBackgroundFadeData.Pack(builder, BackgroundFade));
			IPlayMovie.AddVideoName(builder, VideoNameOffset);
			IPlayMovie.AddNullMask(builder, NullMask);
			return IPlayMovie.EndIPlayMovie(builder);
		}

		// Token: 0x060314D8 RID: 201944 RVA: 0x006AFD1D File Offset: 0x006ADF1D
		public static void StartIPlayMovie(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060314D9 RID: 201945 RVA: 0x006AFD26 File Offset: 0x006ADF26
		public static void AddVideoName(FlatBufferBuilder builder, StringOffset videoNameOffset)
		{
			builder.AddOffset(0, videoNameOffset.Value, 0);
		}

		// Token: 0x060314DA RID: 201946 RVA: 0x006AFD36 File Offset: 0x006ADF36
		public static void AddBackgroundFade(FlatBufferBuilder builder, Offset<IMovieBackgroundFadeData> backgroundFadeOffset)
		{
			builder.AddStruct(1, backgroundFadeOffset.Value, 0);
		}

		// Token: 0x060314DB RID: 201947 RVA: 0x006AFD46 File Offset: 0x006ADF46
		public static void AddProgramSpecialConfig(FlatBufferBuilder builder, Offset<IMp4UiReplaceMaterial> programSpecialConfigOffset)
		{
			builder.AddOffset(2, programSpecialConfigOffset.Value, 0);
		}

		// Token: 0x060314DC RID: 201948 RVA: 0x006AFD56 File Offset: 0x006ADF56
		public static void AddMp4FadeOutTime(FlatBufferBuilder builder, float mp4FadeOutTime)
		{
			builder.AddFloat(3, mp4FadeOutTime, 0.0);
		}

		// Token: 0x060314DD RID: 201949 RVA: 0x006AFD69 File Offset: 0x006ADF69
		public static void AddBlackBorderFadeOutTime(FlatBufferBuilder builder, float blackBorderFadeOutTime)
		{
			builder.AddFloat(4, blackBorderFadeOutTime, 0.0);
		}

		// Token: 0x060314DE RID: 201950 RVA: 0x006AFD7C File Offset: 0x006ADF7C
		public static void AddMp4FrameEvents(FlatBufferBuilder builder, VectorOffset mp4FrameEventsOffset)
		{
			builder.AddOffset(5, mp4FrameEventsOffset.Value, 0);
		}

		// Token: 0x060314DF RID: 201951 RVA: 0x006AFD8C File Offset: 0x006ADF8C
		public static VectorOffset CreateMp4FrameEventsVector(FlatBufferBuilder builder, Offset<IMp4FrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060314E0 RID: 201952 RVA: 0x006AFDCC File Offset: 0x006ADFCC
		public static VectorOffset CreateMp4FrameEventsVectorBlock(FlatBufferBuilder builder, Offset<IMp4FrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMp4FrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060314E1 RID: 201953 RVA: 0x006AFDE6 File Offset: 0x006ADFE6
		public static VectorOffset CreateMp4FrameEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMp4FrameEvent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMp4FrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060314E2 RID: 201954 RVA: 0x006AFE04 File Offset: 0x006AE004
		public static VectorOffset CreateMp4FrameEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMp4FrameEvent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060314E3 RID: 201955 RVA: 0x006AFE1D File Offset: 0x006AE01D
		public static void StartMp4FrameEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060314E4 RID: 201956 RVA: 0x006AFE28 File Offset: 0x006AE028
		public static void AddMp4BlendAnim(FlatBufferBuilder builder, Offset<ISetBlendAnim> mp4BlendAnimOffset)
		{
			builder.AddOffset(6, mp4BlendAnimOffset.Value, 0);
		}

		// Token: 0x060314E5 RID: 201957 RVA: 0x006AFE38 File Offset: 0x006AE038
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060314E6 RID: 201958 RVA: 0x006AFE43 File Offset: 0x006AE043
		public static Offset<IPlayMovie> EndIPlayMovie(FlatBufferBuilder builder)
		{
			return new Offset<IPlayMovie>(builder.EndTable());
		}

		// Token: 0x060314E7 RID: 201959 RVA: 0x006AFE50 File Offset: 0x006AE050
		public IPlayMovieT UnPack()
		{
			IPlayMovieT playMovieT = new IPlayMovieT();
			this.UnPackTo(playMovieT);
			return playMovieT;
		}

		// Token: 0x060314E8 RID: 201960 RVA: 0x006AFE6C File Offset: 0x006AE06C
		public void UnPackTo(IPlayMovieT _o)
		{
			_o.VideoName = this.VideoName;
			_o.BackgroundFade = ((this.BackgroundFade != null) ? this.BackgroundFade.Value.UnPack() : null);
			_o.ProgramSpecialConfig = ((this.ProgramSpecialConfig != null) ? this.ProgramSpecialConfig.Value.UnPack() : null);
			_o.Mp4FadeOutTime = this.Mp4FadeOutTime;
			_o.BlackBorderFadeOutTime = this.BlackBorderFadeOutTime;
			_o.Mp4FrameEvents = new List<IMp4FrameEventT>();
			for (int i = 0; i < this.Mp4FrameEventsLength; i++)
			{
				_o.Mp4FrameEvents.Add((this.Mp4FrameEvents(i) != null) ? this.Mp4FrameEvents(i).Value.UnPack() : null);
			}
			_o.Mp4BlendAnim = ((this.Mp4BlendAnim != null) ? this.Mp4BlendAnim.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060314E9 RID: 201961 RVA: 0x006AFF94 File Offset: 0x006AE194
		public static Offset<IPlayMovie> Pack(FlatBufferBuilder builder, IPlayMovieT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayMovie>);
			}
			StringOffset videoNameOffset = (_o.VideoName == null) ? default(StringOffset) : builder.CreateString(_o.VideoName);
			Offset<IMp4UiReplaceMaterial> programSpecialConfigOffset = (_o.ProgramSpecialConfig == null) ? default(Offset<IMp4UiReplaceMaterial>) : IMp4UiReplaceMaterial.Pack(builder, _o.ProgramSpecialConfig);
			VectorOffset mp4FrameEventsOffset = default(VectorOffset);
			if (_o.Mp4FrameEvents != null)
			{
				Offset<IMp4FrameEvent>[] array = new Offset<IMp4FrameEvent>[_o.Mp4FrameEvents.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMp4FrameEvent.Pack(builder, _o.Mp4FrameEvents[i]);
				}
				mp4FrameEventsOffset = IPlayMovie.CreateMp4FrameEventsVector(builder, array);
			}
			Offset<ISetBlendAnim> mp4BlendAnimOffset = (_o.Mp4BlendAnim == null) ? default(Offset<ISetBlendAnim>) : ISetBlendAnim.Pack(builder, _o.Mp4BlendAnim);
			return IPlayMovie.CreateIPlayMovie(builder, videoNameOffset, _o.BackgroundFade, programSpecialConfigOffset, _o.Mp4FadeOutTime, _o.BlackBorderFadeOutTime, mp4FrameEventsOffset, mp4BlendAnimOffset, _o.NullMask);
		}

		// Token: 0x040116B8 RID: 71352
		private Table __p;
	}
}
