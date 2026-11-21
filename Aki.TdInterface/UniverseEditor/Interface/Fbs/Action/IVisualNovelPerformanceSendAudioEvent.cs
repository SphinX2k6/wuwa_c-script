using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB8 RID: 32184
	public struct IVisualNovelPerformanceSendAudioEvent : IFlatbufferObject
	{
		// Token: 0x1700F10C RID: 61708
		// (get) Token: 0x0603A263 RID: 238179 RVA: 0x007D6CFF File Offset: 0x007D4EFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A264 RID: 238180 RVA: 0x007D6D0C File Offset: 0x007D4F0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A265 RID: 238181 RVA: 0x007D6D14 File Offset: 0x007D4F14
		public static IVisualNovelPerformanceSendAudioEvent GetRootAsIVisualNovelPerformanceSendAudioEvent(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceSendAudioEvent.GetRootAsIVisualNovelPerformanceSendAudioEvent(_bb, default(IVisualNovelPerformanceSendAudioEvent));
		}

		// Token: 0x0603A266 RID: 238182 RVA: 0x007D6D30 File Offset: 0x007D4F30
		public static IVisualNovelPerformanceSendAudioEvent GetRootAsIVisualNovelPerformanceSendAudioEvent(ByteBuffer _bb, IVisualNovelPerformanceSendAudioEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A267 RID: 238183 RVA: 0x007D6D4D File Offset: 0x007D4F4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A268 RID: 238184 RVA: 0x007D6D5C File Offset: 0x007D4F5C
		public IVisualNovelPerformanceSendAudioEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F10D RID: 61709
		// (get) Token: 0x0603A269 RID: 238185 RVA: 0x007D6D6C File Offset: 0x007D4F6C
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

		// Token: 0x1700F10E RID: 61710
		// (get) Token: 0x0603A26A RID: 238186 RVA: 0x007D6DA8 File Offset: 0x007D4FA8
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

		// Token: 0x1700F10F RID: 61711
		// (get) Token: 0x0603A26B RID: 238187 RVA: 0x007D6DE8 File Offset: 0x007D4FE8
		public string AudioEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A26C RID: 238188 RVA: 0x007D6E1F File Offset: 0x007D501F
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603A26D RID: 238189 RVA: 0x007D6E2E File Offset: 0x007D502E
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700F110 RID: 61712
		// (get) Token: 0x0603A26E RID: 238190 RVA: 0x007D6E3C File Offset: 0x007D503C
		public float EndFadeOutTime
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

		// Token: 0x1700F111 RID: 61713
		// (get) Token: 0x0603A26F RID: 238191 RVA: 0x007D6E80 File Offset: 0x007D5080
		public bool IsNotCountTimeAndNotInterrupted
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F112 RID: 61714
		// (get) Token: 0x0603A270 RID: 238192 RVA: 0x007D6EC0 File Offset: 0x007D50C0
		public bool SkipOnUltraFastForward
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F113 RID: 61715
		// (get) Token: 0x0603A271 RID: 238193 RVA: 0x007D6F00 File Offset: 0x007D5100
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A272 RID: 238194 RVA: 0x007D6F40 File Offset: 0x007D5140
		public static Offset<IVisualNovelPerformanceSendAudioEvent> CreateIVisualNovelPerformanceSendAudioEvent(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, StringOffset AudioEventOffset = default(StringOffset), float EndFadeOutTime = 0f, bool IsNotCountTimeAndNotInterrupted = false, bool SkipOnUltraFastForward = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IVisualNovelPerformanceSendAudioEvent.AddEndFadeOutTime(builder, EndFadeOutTime);
			IVisualNovelPerformanceSendAudioEvent.AddAudioEvent(builder, AudioEventOffset);
			IVisualNovelPerformanceSendAudioEvent.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceSendAudioEvent.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceSendAudioEvent.AddSkipOnUltraFastForward(builder, SkipOnUltraFastForward);
			IVisualNovelPerformanceSendAudioEvent.AddIsNotCountTimeAndNotInterrupted(builder, IsNotCountTimeAndNotInterrupted);
			IVisualNovelPerformanceSendAudioEvent.AddType(builder, Type);
			return IVisualNovelPerformanceSendAudioEvent.EndIVisualNovelPerformanceSendAudioEvent(builder);
		}

		// Token: 0x0603A273 RID: 238195 RVA: 0x007D6F8F File Offset: 0x007D518F
		public static void StartIVisualNovelPerformanceSendAudioEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603A274 RID: 238196 RVA: 0x007D6F98 File Offset: 0x007D5198
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A275 RID: 238197 RVA: 0x007D6FA3 File Offset: 0x007D51A3
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A276 RID: 238198 RVA: 0x007D6FB6 File Offset: 0x007D51B6
		public static void AddAudioEvent(FlatBufferBuilder builder, StringOffset audioEventOffset)
		{
			builder.AddOffset(2, audioEventOffset.Value, 0);
		}

		// Token: 0x0603A277 RID: 238199 RVA: 0x007D6FC6 File Offset: 0x007D51C6
		public static void AddEndFadeOutTime(FlatBufferBuilder builder, float endFadeOutTime)
		{
			builder.AddFloat(3, endFadeOutTime, 0.0);
		}

		// Token: 0x0603A278 RID: 238200 RVA: 0x007D6FD9 File Offset: 0x007D51D9
		public static void AddIsNotCountTimeAndNotInterrupted(FlatBufferBuilder builder, bool isNotCountTimeAndNotInterrupted)
		{
			builder.AddBool(4, isNotCountTimeAndNotInterrupted, false);
		}

		// Token: 0x0603A279 RID: 238201 RVA: 0x007D6FE4 File Offset: 0x007D51E4
		public static void AddSkipOnUltraFastForward(FlatBufferBuilder builder, bool skipOnUltraFastForward)
		{
			builder.AddBool(5, skipOnUltraFastForward, false);
		}

		// Token: 0x0603A27A RID: 238202 RVA: 0x007D6FEF File Offset: 0x007D51EF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603A27B RID: 238203 RVA: 0x007D6FFA File Offset: 0x007D51FA
		public static Offset<IVisualNovelPerformanceSendAudioEvent> EndIVisualNovelPerformanceSendAudioEvent(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceSendAudioEvent>(builder.EndTable());
		}

		// Token: 0x0603A27C RID: 238204 RVA: 0x007D7008 File Offset: 0x007D5208
		public IVisualNovelPerformanceSendAudioEventT UnPack()
		{
			IVisualNovelPerformanceSendAudioEventT visualNovelPerformanceSendAudioEventT = new IVisualNovelPerformanceSendAudioEventT();
			this.UnPackTo(visualNovelPerformanceSendAudioEventT);
			return visualNovelPerformanceSendAudioEventT;
		}

		// Token: 0x0603A27D RID: 238205 RVA: 0x007D7024 File Offset: 0x007D5224
		public void UnPackTo(IVisualNovelPerformanceSendAudioEventT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.AudioEvent = this.AudioEvent;
			_o.EndFadeOutTime = this.EndFadeOutTime;
			_o.IsNotCountTimeAndNotInterrupted = this.IsNotCountTimeAndNotInterrupted;
			_o.SkipOnUltraFastForward = this.SkipOnUltraFastForward;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A27E RID: 238206 RVA: 0x007D7088 File Offset: 0x007D5288
		public static Offset<IVisualNovelPerformanceSendAudioEvent> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceSendAudioEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceSendAudioEvent>);
			}
			StringOffset audioEventOffset = (_o.AudioEvent == null) ? default(StringOffset) : builder.CreateString(_o.AudioEvent);
			return IVisualNovelPerformanceSendAudioEvent.CreateIVisualNovelPerformanceSendAudioEvent(builder, _o.Type, _o.StartTime, audioEventOffset, _o.EndFadeOutTime, _o.IsNotCountTimeAndNotInterrupted, _o.SkipOnUltraFastForward, _o.NullMask);
		}

		// Token: 0x0401353F RID: 79167
		private Table __p;
	}
}
