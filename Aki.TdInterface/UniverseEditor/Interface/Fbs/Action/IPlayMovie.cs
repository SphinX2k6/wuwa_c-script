using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A7 RID: 29863
	public struct IPlayMovie : IFlatbufferObject
	{
		// Token: 0x1700DB73 RID: 56179
		// (get) Token: 0x060344BE RID: 214206 RVA: 0x0070AFD7 File Offset: 0x007091D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060344BF RID: 214207 RVA: 0x0070AFE4 File Offset: 0x007091E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060344C0 RID: 214208 RVA: 0x0070AFEC File Offset: 0x007091EC
		public static IPlayMovie GetRootAsIPlayMovie(ByteBuffer _bb)
		{
			return IPlayMovie.GetRootAsIPlayMovie(_bb, default(IPlayMovie));
		}

		// Token: 0x060344C1 RID: 214209 RVA: 0x0070B008 File Offset: 0x00709208
		public static IPlayMovie GetRootAsIPlayMovie(ByteBuffer _bb, IPlayMovie obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060344C2 RID: 214210 RVA: 0x0070B025 File Offset: 0x00709225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060344C3 RID: 214211 RVA: 0x0070B034 File Offset: 0x00709234
		public IPlayMovie __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB74 RID: 56180
		// (get) Token: 0x060344C4 RID: 214212 RVA: 0x0070B044 File Offset: 0x00709244
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

		// Token: 0x060344C5 RID: 214213 RVA: 0x0070B07B File Offset: 0x0070927B
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060344C6 RID: 214214 RVA: 0x0070B08A File Offset: 0x0070928A
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DB75 RID: 56181
		// (get) Token: 0x060344C7 RID: 214215 RVA: 0x0070B098 File Offset: 0x00709298
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

		// Token: 0x1700DB76 RID: 56182
		// (get) Token: 0x060344C8 RID: 214216 RVA: 0x0070B0EC File Offset: 0x007092EC
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

		// Token: 0x1700DB77 RID: 56183
		// (get) Token: 0x060344C9 RID: 214217 RVA: 0x0070B14C File Offset: 0x0070934C
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

		// Token: 0x1700DB78 RID: 56184
		// (get) Token: 0x060344CA RID: 214218 RVA: 0x0070B190 File Offset: 0x00709390
		public float Mp4FadeInTime
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

		// Token: 0x1700DB79 RID: 56185
		// (get) Token: 0x060344CB RID: 214219 RVA: 0x0070B1D4 File Offset: 0x007093D4
		public float BlackBorderFadeOutTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060344CC RID: 214220 RVA: 0x0070B218 File Offset: 0x00709418
		public IMp4FrameEvent? Mp4FrameEvents(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IMp4FrameEvent?(default(IMp4FrameEvent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DB7A RID: 56186
		// (get) Token: 0x060344CD RID: 214221 RVA: 0x0070B27C File Offset: 0x0070947C
		public int Mp4FrameEventsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DB7B RID: 56187
		// (get) Token: 0x060344CE RID: 214222 RVA: 0x0070B2A8 File Offset: 0x007094A8
		public ISetBlendAnim? Mp4BlendAnim
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ISetBlendAnim?(default(ISetBlendAnim).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DB7C RID: 56188
		// (get) Token: 0x060344CF RID: 214223 RVA: 0x0070B308 File Offset: 0x00709508
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060344D0 RID: 214224 RVA: 0x0070B348 File Offset: 0x00709548
		public static Offset<IPlayMovie> CreateIPlayMovie(FlatBufferBuilder builder, StringOffset VideoNameOffset = default(StringOffset), IMovieBackgroundFadeDataT BackgroundFade = null, Offset<IMp4UiReplaceMaterial> ProgramSpecialConfigOffset = default(Offset<IMp4UiReplaceMaterial>), float Mp4FadeOutTime = 0f, float Mp4FadeInTime = 0f, float BlackBorderFadeOutTime = 0f, VectorOffset Mp4FrameEventsOffset = default(VectorOffset), Offset<ISetBlendAnim> Mp4BlendAnimOffset = default(Offset<ISetBlendAnim>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IPlayMovie.AddMp4BlendAnim(builder, Mp4BlendAnimOffset);
			IPlayMovie.AddMp4FrameEvents(builder, Mp4FrameEventsOffset);
			IPlayMovie.AddBlackBorderFadeOutTime(builder, BlackBorderFadeOutTime);
			IPlayMovie.AddMp4FadeInTime(builder, Mp4FadeInTime);
			IPlayMovie.AddMp4FadeOutTime(builder, Mp4FadeOutTime);
			IPlayMovie.AddProgramSpecialConfig(builder, ProgramSpecialConfigOffset);
			IPlayMovie.AddBackgroundFade(builder, IMovieBackgroundFadeData.Pack(builder, BackgroundFade));
			IPlayMovie.AddVideoName(builder, VideoNameOffset);
			IPlayMovie.AddNullMask(builder, NullMask);
			return IPlayMovie.EndIPlayMovie(builder);
		}

		// Token: 0x060344D1 RID: 214225 RVA: 0x0070B3AE File Offset: 0x007095AE
		public static void StartIPlayMovie(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060344D2 RID: 214226 RVA: 0x0070B3B8 File Offset: 0x007095B8
		public static void AddVideoName(FlatBufferBuilder builder, StringOffset videoNameOffset)
		{
			builder.AddOffset(0, videoNameOffset.Value, 0);
		}

		// Token: 0x060344D3 RID: 214227 RVA: 0x0070B3C8 File Offset: 0x007095C8
		public static void AddBackgroundFade(FlatBufferBuilder builder, Offset<IMovieBackgroundFadeData> backgroundFadeOffset)
		{
			builder.AddStruct(1, backgroundFadeOffset.Value, 0);
		}

		// Token: 0x060344D4 RID: 214228 RVA: 0x0070B3D8 File Offset: 0x007095D8
		public static void AddProgramSpecialConfig(FlatBufferBuilder builder, Offset<IMp4UiReplaceMaterial> programSpecialConfigOffset)
		{
			builder.AddOffset(2, programSpecialConfigOffset.Value, 0);
		}

		// Token: 0x060344D5 RID: 214229 RVA: 0x0070B3E8 File Offset: 0x007095E8
		public static void AddMp4FadeOutTime(FlatBufferBuilder builder, float mp4FadeOutTime)
		{
			builder.AddFloat(3, mp4FadeOutTime, 0.0);
		}

		// Token: 0x060344D6 RID: 214230 RVA: 0x0070B3FB File Offset: 0x007095FB
		public static void AddMp4FadeInTime(FlatBufferBuilder builder, float mp4FadeInTime)
		{
			builder.AddFloat(4, mp4FadeInTime, 0.0);
		}

		// Token: 0x060344D7 RID: 214231 RVA: 0x0070B40E File Offset: 0x0070960E
		public static void AddBlackBorderFadeOutTime(FlatBufferBuilder builder, float blackBorderFadeOutTime)
		{
			builder.AddFloat(5, blackBorderFadeOutTime, 0.0);
		}

		// Token: 0x060344D8 RID: 214232 RVA: 0x0070B421 File Offset: 0x00709621
		public static void AddMp4FrameEvents(FlatBufferBuilder builder, VectorOffset mp4FrameEventsOffset)
		{
			builder.AddOffset(6, mp4FrameEventsOffset.Value, 0);
		}

		// Token: 0x060344D9 RID: 214233 RVA: 0x0070B434 File Offset: 0x00709634
		public static VectorOffset CreateMp4FrameEventsVector(FlatBufferBuilder builder, Offset<IMp4FrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060344DA RID: 214234 RVA: 0x0070B474 File Offset: 0x00709674
		public static VectorOffset CreateMp4FrameEventsVectorBlock(FlatBufferBuilder builder, Offset<IMp4FrameEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMp4FrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060344DB RID: 214235 RVA: 0x0070B48E File Offset: 0x0070968E
		public static VectorOffset CreateMp4FrameEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMp4FrameEvent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMp4FrameEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x060344DC RID: 214236 RVA: 0x0070B4AC File Offset: 0x007096AC
		public static VectorOffset CreateMp4FrameEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMp4FrameEvent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060344DD RID: 214237 RVA: 0x0070B4C5 File Offset: 0x007096C5
		public static void StartMp4FrameEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060344DE RID: 214238 RVA: 0x0070B4D0 File Offset: 0x007096D0
		public static void AddMp4BlendAnim(FlatBufferBuilder builder, Offset<ISetBlendAnim> mp4BlendAnimOffset)
		{
			builder.AddOffset(7, mp4BlendAnimOffset.Value, 0);
		}

		// Token: 0x060344DF RID: 214239 RVA: 0x0070B4E0 File Offset: 0x007096E0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060344E0 RID: 214240 RVA: 0x0070B4EB File Offset: 0x007096EB
		public static Offset<IPlayMovie> EndIPlayMovie(FlatBufferBuilder builder)
		{
			return new Offset<IPlayMovie>(builder.EndTable());
		}

		// Token: 0x060344E1 RID: 214241 RVA: 0x0070B4F8 File Offset: 0x007096F8
		public IPlayMovieT UnPack()
		{
			IPlayMovieT playMovieT = new IPlayMovieT();
			this.UnPackTo(playMovieT);
			return playMovieT;
		}

		// Token: 0x060344E2 RID: 214242 RVA: 0x0070B514 File Offset: 0x00709714
		public void UnPackTo(IPlayMovieT _o)
		{
			_o.VideoName = this.VideoName;
			_o.BackgroundFade = ((this.BackgroundFade != null) ? this.BackgroundFade.Value.UnPack() : null);
			_o.ProgramSpecialConfig = ((this.ProgramSpecialConfig != null) ? this.ProgramSpecialConfig.Value.UnPack() : null);
			_o.Mp4FadeOutTime = this.Mp4FadeOutTime;
			_o.Mp4FadeInTime = this.Mp4FadeInTime;
			_o.BlackBorderFadeOutTime = this.BlackBorderFadeOutTime;
			_o.Mp4FrameEvents = new List<IMp4FrameEventT>();
			for (int i = 0; i < this.Mp4FrameEventsLength; i++)
			{
				_o.Mp4FrameEvents.Add((this.Mp4FrameEvents(i) != null) ? this.Mp4FrameEvents(i).Value.UnPack() : null);
			}
			_o.Mp4BlendAnim = ((this.Mp4BlendAnim != null) ? this.Mp4BlendAnim.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060344E3 RID: 214243 RVA: 0x0070B648 File Offset: 0x00709848
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
			return IPlayMovie.CreateIPlayMovie(builder, videoNameOffset, _o.BackgroundFade, programSpecialConfigOffset, _o.Mp4FadeOutTime, _o.Mp4FadeInTime, _o.BlackBorderFadeOutTime, mp4FrameEventsOffset, mp4BlendAnimOffset, _o.NullMask);
		}

		// Token: 0x04012633 RID: 75315
		private Table __p;
	}
}
