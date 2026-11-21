using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DBE RID: 32190
	public struct IVisualNovelPerformanceSwitchAudioState : IFlatbufferObject
	{
		// Token: 0x1700F124 RID: 61732
		// (get) Token: 0x0603A2AD RID: 238253 RVA: 0x007D75E7 File Offset: 0x007D57E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A2AE RID: 238254 RVA: 0x007D75F4 File Offset: 0x007D57F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A2AF RID: 238255 RVA: 0x007D75FC File Offset: 0x007D57FC
		public static IVisualNovelPerformanceSwitchAudioState GetRootAsIVisualNovelPerformanceSwitchAudioState(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceSwitchAudioState.GetRootAsIVisualNovelPerformanceSwitchAudioState(_bb, default(IVisualNovelPerformanceSwitchAudioState));
		}

		// Token: 0x0603A2B0 RID: 238256 RVA: 0x007D7618 File Offset: 0x007D5818
		public static IVisualNovelPerformanceSwitchAudioState GetRootAsIVisualNovelPerformanceSwitchAudioState(ByteBuffer _bb, IVisualNovelPerformanceSwitchAudioState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A2B1 RID: 238257 RVA: 0x007D7635 File Offset: 0x007D5835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A2B2 RID: 238258 RVA: 0x007D7644 File Offset: 0x007D5844
		public IVisualNovelPerformanceSwitchAudioState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F125 RID: 61733
		// (get) Token: 0x0603A2B3 RID: 238259 RVA: 0x007D7654 File Offset: 0x007D5854
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

		// Token: 0x1700F126 RID: 61734
		// (get) Token: 0x0603A2B4 RID: 238260 RVA: 0x007D7690 File Offset: 0x007D5890
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

		// Token: 0x1700F127 RID: 61735
		// (get) Token: 0x0603A2B5 RID: 238261 RVA: 0x007D76D0 File Offset: 0x007D58D0
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

		// Token: 0x1700F128 RID: 61736
		// (get) Token: 0x0603A2B6 RID: 238262 RVA: 0x007D7730 File Offset: 0x007D5930
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

		// Token: 0x0603A2B7 RID: 238263 RVA: 0x007D776D File Offset: 0x007D596D
		public static Offset<IVisualNovelPerformanceSwitchAudioState> CreateIVisualNovelPerformanceSwitchAudioState(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IAudioState> AudioStateOffset = default(Offset<IAudioState>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceSwitchAudioState.AddAudioState(builder, AudioStateOffset);
			IVisualNovelPerformanceSwitchAudioState.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceSwitchAudioState.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceSwitchAudioState.AddType(builder, Type);
			return IVisualNovelPerformanceSwitchAudioState.EndIVisualNovelPerformanceSwitchAudioState(builder);
		}

		// Token: 0x0603A2B8 RID: 238264 RVA: 0x007D7799 File Offset: 0x007D5999
		public static void StartIVisualNovelPerformanceSwitchAudioState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603A2B9 RID: 238265 RVA: 0x007D77A2 File Offset: 0x007D59A2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A2BA RID: 238266 RVA: 0x007D77AD File Offset: 0x007D59AD
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A2BB RID: 238267 RVA: 0x007D77C0 File Offset: 0x007D59C0
		public static void AddAudioState(FlatBufferBuilder builder, Offset<IAudioState> audioStateOffset)
		{
			builder.AddOffset(2, audioStateOffset.Value, 0);
		}

		// Token: 0x0603A2BC RID: 238268 RVA: 0x007D77D0 File Offset: 0x007D59D0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603A2BD RID: 238269 RVA: 0x007D77DB File Offset: 0x007D59DB
		public static Offset<IVisualNovelPerformanceSwitchAudioState> EndIVisualNovelPerformanceSwitchAudioState(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceSwitchAudioState>(builder.EndTable());
		}

		// Token: 0x0603A2BE RID: 238270 RVA: 0x007D77E8 File Offset: 0x007D59E8
		public IVisualNovelPerformanceSwitchAudioStateT UnPack()
		{
			IVisualNovelPerformanceSwitchAudioStateT visualNovelPerformanceSwitchAudioStateT = new IVisualNovelPerformanceSwitchAudioStateT();
			this.UnPackTo(visualNovelPerformanceSwitchAudioStateT);
			return visualNovelPerformanceSwitchAudioStateT;
		}

		// Token: 0x0603A2BF RID: 238271 RVA: 0x007D7804 File Offset: 0x007D5A04
		public void UnPackTo(IVisualNovelPerformanceSwitchAudioStateT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.AudioState = ((this.AudioState != null) ? this.AudioState.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A2C0 RID: 238272 RVA: 0x007D7864 File Offset: 0x007D5A64
		public static Offset<IVisualNovelPerformanceSwitchAudioState> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceSwitchAudioStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceSwitchAudioState>);
			}
			Offset<IAudioState> audioStateOffset = (_o.AudioState == null) ? default(Offset<IAudioState>) : IAudioState.Pack(builder, _o.AudioState);
			return IVisualNovelPerformanceSwitchAudioState.CreateIVisualNovelPerformanceSwitchAudioState(builder, _o.Type, _o.StartTime, audioStateOffset, _o.NullMask);
		}

		// Token: 0x0401354C RID: 79180
		private Table __p;
	}
}
