using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EDA RID: 20186
	public struct IAudioRangeConfig : IFlatbufferObject
	{
		// Token: 0x170090E6 RID: 37094
		// (get) Token: 0x0601FD0B RID: 130315 RVA: 0x0046D6CC File Offset: 0x0046B8CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD0C RID: 130316 RVA: 0x0046D6D9 File Offset: 0x0046B8D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD0D RID: 130317 RVA: 0x0046D6E0 File Offset: 0x0046B8E0
		public static IAudioRangeConfig GetRootAsIAudioRangeConfig(ByteBuffer _bb)
		{
			return IAudioRangeConfig.GetRootAsIAudioRangeConfig(_bb, default(IAudioRangeConfig));
		}

		// Token: 0x0601FD0E RID: 130318 RVA: 0x0046D6FC File Offset: 0x0046B8FC
		public static IAudioRangeConfig GetRootAsIAudioRangeConfig(ByteBuffer _bb, IAudioRangeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD0F RID: 130319 RVA: 0x0046D719 File Offset: 0x0046B919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD10 RID: 130320 RVA: 0x0046D728 File Offset: 0x0046B928
		public IAudioRangeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090E7 RID: 37095
		// (get) Token: 0x0601FD11 RID: 130321 RVA: 0x0046D738 File Offset: 0x0046B938
		public string LeaveAkEvent
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

		// Token: 0x0601FD12 RID: 130322 RVA: 0x0046D76F File Offset: 0x0046B96F
		public Span<byte> GetLeaveAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601FD13 RID: 130323 RVA: 0x0046D77E File Offset: 0x0046B97E
		public byte[] GetLeaveAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601FD14 RID: 130324 RVA: 0x0046D78C File Offset: 0x0046B98C
		public static Offset<IAudioRangeConfig> CreateIAudioRangeConfig(FlatBufferBuilder builder, StringOffset LeaveAkEventOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IAudioRangeConfig.AddLeaveAkEvent(builder, LeaveAkEventOffset);
			return IAudioRangeConfig.EndIAudioRangeConfig(builder);
		}

		// Token: 0x0601FD15 RID: 130325 RVA: 0x0046D7A2 File Offset: 0x0046B9A2
		public static void StartIAudioRangeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FD16 RID: 130326 RVA: 0x0046D7AB File Offset: 0x0046B9AB
		public static void AddLeaveAkEvent(FlatBufferBuilder builder, StringOffset leaveAkEventOffset)
		{
			builder.AddOffset(0, leaveAkEventOffset.Value, 0);
		}

		// Token: 0x0601FD17 RID: 130327 RVA: 0x0046D7BB File Offset: 0x0046B9BB
		public static Offset<IAudioRangeConfig> EndIAudioRangeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAudioRangeConfig>(builder.EndTable());
		}

		// Token: 0x0601FD18 RID: 130328 RVA: 0x0046D7C8 File Offset: 0x0046B9C8
		public IAudioRangeConfigT UnPack()
		{
			IAudioRangeConfigT audioRangeConfigT = new IAudioRangeConfigT();
			this.UnPackTo(audioRangeConfigT);
			return audioRangeConfigT;
		}

		// Token: 0x0601FD19 RID: 130329 RVA: 0x0046D7E3 File Offset: 0x0046B9E3
		public void UnPackTo(IAudioRangeConfigT _o)
		{
			_o.LeaveAkEvent = this.LeaveAkEvent;
		}

		// Token: 0x0601FD1A RID: 130330 RVA: 0x0046D7F4 File Offset: 0x0046B9F4
		public static Offset<IAudioRangeConfig> Pack(FlatBufferBuilder builder, IAudioRangeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioRangeConfig>);
			}
			StringOffset leaveAkEventOffset = (_o.LeaveAkEvent == null) ? default(StringOffset) : builder.CreateString(_o.LeaveAkEvent);
			return IAudioRangeConfig.CreateIAudioRangeConfig(builder, leaveAkEventOffset);
		}

		// Token: 0x0400DCE3 RID: 56547
		private Table __p;
	}
}
