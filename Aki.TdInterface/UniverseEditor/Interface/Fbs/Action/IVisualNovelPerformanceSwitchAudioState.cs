using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C5 RID: 30149
	public struct IVisualNovelPerformanceSwitchAudioState : IFlatbufferObject
	{
		// Token: 0x1700E4F7 RID: 58615
		// (get) Token: 0x06036E7E RID: 224894 RVA: 0x00773E60 File Offset: 0x00772060
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E7F RID: 224895 RVA: 0x00773E6D File Offset: 0x0077206D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E80 RID: 224896 RVA: 0x00773E74 File Offset: 0x00772074
		public static IVisualNovelPerformanceSwitchAudioState GetRootAsIVisualNovelPerformanceSwitchAudioState(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceSwitchAudioState.GetRootAsIVisualNovelPerformanceSwitchAudioState(_bb, default(IVisualNovelPerformanceSwitchAudioState));
		}

		// Token: 0x06036E81 RID: 224897 RVA: 0x00773E90 File Offset: 0x00772090
		public static IVisualNovelPerformanceSwitchAudioState GetRootAsIVisualNovelPerformanceSwitchAudioState(ByteBuffer _bb, IVisualNovelPerformanceSwitchAudioState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E82 RID: 224898 RVA: 0x00773EAD File Offset: 0x007720AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E83 RID: 224899 RVA: 0x00773EBC File Offset: 0x007720BC
		public IVisualNovelPerformanceSwitchAudioState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4F8 RID: 58616
		// (get) Token: 0x06036E84 RID: 224900 RVA: 0x00773ECC File Offset: 0x007720CC
		public EVisualNovelPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return (EVisualNovelPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E4F9 RID: 58617
		// (get) Token: 0x06036E85 RID: 224901 RVA: 0x00773F08 File Offset: 0x00772108
		public float StartTime
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

		// Token: 0x1700E4FA RID: 58618
		// (get) Token: 0x06036E86 RID: 224902 RVA: 0x00773F48 File Offset: 0x00772148
		public IAudioState? AudioState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IAudioState?(default(IAudioState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E4FB RID: 58619
		// (get) Token: 0x06036E87 RID: 224903 RVA: 0x00773FA8 File Offset: 0x007721A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036E88 RID: 224904 RVA: 0x00773FE5 File Offset: 0x007721E5
		public static Offset<IVisualNovelPerformanceSwitchAudioState> CreateIVisualNovelPerformanceSwitchAudioState(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IAudioState> AudioStateOffset = default(Offset<IAudioState>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceSwitchAudioState.AddAudioState(builder, AudioStateOffset);
			IVisualNovelPerformanceSwitchAudioState.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceSwitchAudioState.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceSwitchAudioState.AddType(builder, Type);
			return IVisualNovelPerformanceSwitchAudioState.EndIVisualNovelPerformanceSwitchAudioState(builder);
		}

		// Token: 0x06036E89 RID: 224905 RVA: 0x00774011 File Offset: 0x00772211
		public static void StartIVisualNovelPerformanceSwitchAudioState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036E8A RID: 224906 RVA: 0x0077401A File Offset: 0x0077221A
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E8B RID: 224907 RVA: 0x00774025 File Offset: 0x00772225
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036E8C RID: 224908 RVA: 0x00774038 File Offset: 0x00772238
		public static void AddAudioState(FlatBufferBuilder builder, Offset<IAudioState> audioStateOffset)
		{
			builder.AddOffset(2, audioStateOffset.Value, 0);
		}

		// Token: 0x06036E8D RID: 224909 RVA: 0x00774048 File Offset: 0x00772248
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036E8E RID: 224910 RVA: 0x00774053 File Offset: 0x00772253
		public static Offset<IVisualNovelPerformanceSwitchAudioState> EndIVisualNovelPerformanceSwitchAudioState(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceSwitchAudioState>(builder.EndTable());
		}

		// Token: 0x06036E8F RID: 224911 RVA: 0x00774060 File Offset: 0x00772260
		public IVisualNovelPerformanceSwitchAudioStateT UnPack()
		{
			IVisualNovelPerformanceSwitchAudioStateT visualNovelPerformanceSwitchAudioStateT = new IVisualNovelPerformanceSwitchAudioStateT();
			this.UnPackTo(visualNovelPerformanceSwitchAudioStateT);
			return visualNovelPerformanceSwitchAudioStateT;
		}

		// Token: 0x06036E90 RID: 224912 RVA: 0x0077407C File Offset: 0x0077227C
		public void UnPackTo(IVisualNovelPerformanceSwitchAudioStateT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.AudioState = ((this.AudioState != null) ? this.AudioState.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036E91 RID: 224913 RVA: 0x007740DC File Offset: 0x007722DC
		public static Offset<IVisualNovelPerformanceSwitchAudioState> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceSwitchAudioStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceSwitchAudioState>);
			}
			Offset<IAudioState> audioStateOffset = (_o.AudioState == null) ? default(Offset<IAudioState>) : IAudioState.Pack(builder, _o.AudioState);
			return IVisualNovelPerformanceSwitchAudioState.CreateIVisualNovelPerformanceSwitchAudioState(builder, _o.Type, _o.StartTime, audioStateOffset, _o.NullMask);
		}

		// Token: 0x04012519 RID: 75033
		private Table __p;
	}
}
