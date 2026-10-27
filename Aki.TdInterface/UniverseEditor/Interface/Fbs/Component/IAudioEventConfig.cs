using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ED1 RID: 20177
	public struct IAudioEventConfig : IFlatbufferObject
	{
		// Token: 0x170090D5 RID: 37077
		// (get) Token: 0x0601FCC3 RID: 130243 RVA: 0x0046D00C File Offset: 0x0046B20C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FCC4 RID: 130244 RVA: 0x0046D019 File Offset: 0x0046B219
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FCC5 RID: 130245 RVA: 0x0046D020 File Offset: 0x0046B220
		public static IAudioEventConfig GetRootAsIAudioEventConfig(ByteBuffer _bb)
		{
			return IAudioEventConfig.GetRootAsIAudioEventConfig(_bb, default(IAudioEventConfig));
		}

		// Token: 0x0601FCC6 RID: 130246 RVA: 0x0046D03C File Offset: 0x0046B23C
		public static IAudioEventConfig GetRootAsIAudioEventConfig(ByteBuffer _bb, IAudioEventConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FCC7 RID: 130247 RVA: 0x0046D059 File Offset: 0x0046B259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FCC8 RID: 130248 RVA: 0x0046D068 File Offset: 0x0046B268
		public IAudioEventConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090D6 RID: 37078
		// (get) Token: 0x0601FCC9 RID: 130249 RVA: 0x0046D078 File Offset: 0x0046B278
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

		// Token: 0x0601FCCA RID: 130250 RVA: 0x0046D0AF File Offset: 0x0046B2AF
		public Span<byte> GetCollectAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601FCCB RID: 130251 RVA: 0x0046D0BE File Offset: 0x0046B2BE
		public byte[] GetCollectAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601FCCC RID: 130252 RVA: 0x0046D0CC File Offset: 0x0046B2CC
		public static Offset<IAudioEventConfig> CreateIAudioEventConfig(FlatBufferBuilder builder, StringOffset CollectAkEventOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IAudioEventConfig.AddCollectAkEvent(builder, CollectAkEventOffset);
			return IAudioEventConfig.EndIAudioEventConfig(builder);
		}

		// Token: 0x0601FCCD RID: 130253 RVA: 0x0046D0E2 File Offset: 0x0046B2E2
		public static void StartIAudioEventConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FCCE RID: 130254 RVA: 0x0046D0EB File Offset: 0x0046B2EB
		public static void AddCollectAkEvent(FlatBufferBuilder builder, StringOffset collectAkEventOffset)
		{
			builder.AddOffset(0, collectAkEventOffset.Value, 0);
		}

		// Token: 0x0601FCCF RID: 130255 RVA: 0x0046D0FB File Offset: 0x0046B2FB
		public static Offset<IAudioEventConfig> EndIAudioEventConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAudioEventConfig>(builder.EndTable());
		}

		// Token: 0x0601FCD0 RID: 130256 RVA: 0x0046D108 File Offset: 0x0046B308
		public IAudioEventConfigT UnPack()
		{
			IAudioEventConfigT audioEventConfigT = new IAudioEventConfigT();
			this.UnPackTo(audioEventConfigT);
			return audioEventConfigT;
		}

		// Token: 0x0601FCD1 RID: 130257 RVA: 0x0046D123 File Offset: 0x0046B323
		public void UnPackTo(IAudioEventConfigT _o)
		{
			_o.CollectAkEvent = this.CollectAkEvent;
		}

		// Token: 0x0601FCD2 RID: 130258 RVA: 0x0046D134 File Offset: 0x0046B334
		public static Offset<IAudioEventConfig> Pack(FlatBufferBuilder builder, IAudioEventConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioEventConfig>);
			}
			StringOffset collectAkEventOffset = (_o.CollectAkEvent == null) ? default(StringOffset) : builder.CreateString(_o.CollectAkEvent);
			return IAudioEventConfig.CreateIAudioEventConfig(builder, collectAkEventOffset);
		}

		// Token: 0x0400DCD9 RID: 56537
		private Table __p;
	}
}
