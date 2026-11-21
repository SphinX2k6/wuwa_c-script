using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005400 RID: 21504
	public struct IAudioEventConfig : IFlatbufferObject
	{
		// Token: 0x17009848 RID: 38984
		// (get) Token: 0x06021A07 RID: 137735 RVA: 0x004A2DDC File Offset: 0x004A0FDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A08 RID: 137736 RVA: 0x004A2DE9 File Offset: 0x004A0FE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A09 RID: 137737 RVA: 0x004A2DF0 File Offset: 0x004A0FF0
		public static IAudioEventConfig GetRootAsIAudioEventConfig(ByteBuffer _bb)
		{
			return IAudioEventConfig.GetRootAsIAudioEventConfig(_bb, default(IAudioEventConfig));
		}

		// Token: 0x06021A0A RID: 137738 RVA: 0x004A2E0C File Offset: 0x004A100C
		public static IAudioEventConfig GetRootAsIAudioEventConfig(ByteBuffer _bb, IAudioEventConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A0B RID: 137739 RVA: 0x004A2E29 File Offset: 0x004A1029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A0C RID: 137740 RVA: 0x004A2E38 File Offset: 0x004A1038
		public IAudioEventConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009849 RID: 38985
		// (get) Token: 0x06021A0D RID: 137741 RVA: 0x004A2E48 File Offset: 0x004A1048
		public string CollectAkEvent
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

		// Token: 0x06021A0E RID: 137742 RVA: 0x004A2E7F File Offset: 0x004A107F
		public Span<byte> GetCollectAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021A0F RID: 137743 RVA: 0x004A2E8E File Offset: 0x004A108E
		public byte[] GetCollectAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06021A10 RID: 137744 RVA: 0x004A2E9C File Offset: 0x004A109C
		public static Offset<IAudioEventConfig> CreateIAudioEventConfig(FlatBufferBuilder builder, StringOffset CollectAkEventOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IAudioEventConfig.AddCollectAkEvent(builder, CollectAkEventOffset);
			return IAudioEventConfig.EndIAudioEventConfig(builder);
		}

		// Token: 0x06021A11 RID: 137745 RVA: 0x004A2EB2 File Offset: 0x004A10B2
		public static void StartIAudioEventConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021A12 RID: 137746 RVA: 0x004A2EBB File Offset: 0x004A10BB
		public static void AddCollectAkEvent(FlatBufferBuilder builder, StringOffset collectAkEventOffset)
		{
			builder.AddOffset(0, collectAkEventOffset.Value, 0);
		}

		// Token: 0x06021A13 RID: 137747 RVA: 0x004A2ECB File Offset: 0x004A10CB
		public static Offset<IAudioEventConfig> EndIAudioEventConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAudioEventConfig>(builder.EndTable());
		}

		// Token: 0x06021A14 RID: 137748 RVA: 0x004A2ED8 File Offset: 0x004A10D8
		public IAudioEventConfigT UnPack()
		{
			IAudioEventConfigT audioEventConfigT = new IAudioEventConfigT();
			this.UnPackTo(audioEventConfigT);
			return audioEventConfigT;
		}

		// Token: 0x06021A15 RID: 137749 RVA: 0x004A2EF3 File Offset: 0x004A10F3
		public void UnPackTo(IAudioEventConfigT _o)
		{
			_o.CollectAkEvent = this.CollectAkEvent;
		}

		// Token: 0x06021A16 RID: 137750 RVA: 0x004A2F04 File Offset: 0x004A1104
		public static Offset<IAudioEventConfig> Pack(FlatBufferBuilder builder, IAudioEventConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioEventConfig>);
			}
			StringOffset collectAkEventOffset = (_o.CollectAkEvent == null) ? default(StringOffset) : builder.CreateString(_o.CollectAkEvent);
			return IAudioEventConfig.CreateIAudioEventConfig(builder, collectAkEventOffset);
		}

		// Token: 0x0400E880 RID: 59520
		private Table __p;
	}
}
