using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060CD RID: 24781
	public struct ITrafficAudioControl : IFlatbufferObject
	{
		// Token: 0x1700B831 RID: 47153
		// (get) Token: 0x06029EE6 RID: 171750 RVA: 0x005B8F25 File Offset: 0x005B7125
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029EE7 RID: 171751 RVA: 0x005B8F32 File Offset: 0x005B7132
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029EE8 RID: 171752 RVA: 0x005B8F3C File Offset: 0x005B713C
		public static ITrafficAudioControl GetRootAsITrafficAudioControl(ByteBuffer _bb)
		{
			return ITrafficAudioControl.GetRootAsITrafficAudioControl(_bb, default(ITrafficAudioControl));
		}

		// Token: 0x06029EE9 RID: 171753 RVA: 0x005B8F58 File Offset: 0x005B7158
		public static ITrafficAudioControl GetRootAsITrafficAudioControl(ByteBuffer _bb, ITrafficAudioControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029EEA RID: 171754 RVA: 0x005B8F75 File Offset: 0x005B7175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029EEB RID: 171755 RVA: 0x005B8F84 File Offset: 0x005B7184
		public ITrafficAudioControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B832 RID: 47154
		// (get) Token: 0x06029EEC RID: 171756 RVA: 0x005B8F94 File Offset: 0x005B7194
		public EAudioControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAudioControlType.Gramophone;
				}
				return (EAudioControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B833 RID: 47155
		// (get) Token: 0x06029EED RID: 171757 RVA: 0x005B8FD0 File Offset: 0x005B71D0
		public string EngineAudio
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029EEE RID: 171758 RVA: 0x005B9007 File Offset: 0x005B7207
		public Span<byte> GetEngineAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029EEF RID: 171759 RVA: 0x005B9016 File Offset: 0x005B7216
		public byte[] GetEngineAudioArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B834 RID: 47156
		// (get) Token: 0x06029EF0 RID: 171760 RVA: 0x005B9024 File Offset: 0x005B7224
		public string BrakingAudio
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

		// Token: 0x06029EF1 RID: 171761 RVA: 0x005B905B File Offset: 0x005B725B
		public Span<byte> GetBrakingAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06029EF2 RID: 171762 RVA: 0x005B906A File Offset: 0x005B726A
		public byte[] GetBrakingAudioArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B835 RID: 47157
		// (get) Token: 0x06029EF3 RID: 171763 RVA: 0x005B9078 File Offset: 0x005B7278
		public string BrakingShortAudio
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029EF4 RID: 171764 RVA: 0x005B90B0 File Offset: 0x005B72B0
		public Span<byte> GetBrakingShortAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06029EF5 RID: 171765 RVA: 0x005B90C0 File Offset: 0x005B72C0
		public byte[] GetBrakingShortAudioArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B836 RID: 47158
		// (get) Token: 0x06029EF6 RID: 171766 RVA: 0x005B90D0 File Offset: 0x005B72D0
		public string HornAudio
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029EF7 RID: 171767 RVA: 0x005B9108 File Offset: 0x005B7308
		public Span<byte> GetHornAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06029EF8 RID: 171768 RVA: 0x005B9118 File Offset: 0x005B7318
		public byte[] GetHornAudioArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06029EF9 RID: 171769 RVA: 0x005B9127 File Offset: 0x005B7327
		public static Offset<ITrafficAudioControl> CreateITrafficAudioControl(FlatBufferBuilder builder, EAudioControlType Type = EAudioControlType.Gramophone, StringOffset EngineAudioOffset = default(StringOffset), StringOffset BrakingAudioOffset = default(StringOffset), StringOffset BrakingShortAudioOffset = default(StringOffset), StringOffset HornAudioOffset = default(StringOffset))
		{
			builder.StartTable(5);
			ITrafficAudioControl.AddHornAudio(builder, HornAudioOffset);
			ITrafficAudioControl.AddBrakingShortAudio(builder, BrakingShortAudioOffset);
			ITrafficAudioControl.AddBrakingAudio(builder, BrakingAudioOffset);
			ITrafficAudioControl.AddEngineAudio(builder, EngineAudioOffset);
			ITrafficAudioControl.AddType(builder, Type);
			return ITrafficAudioControl.EndITrafficAudioControl(builder);
		}

		// Token: 0x06029EFA RID: 171770 RVA: 0x005B915B File Offset: 0x005B735B
		public static void StartITrafficAudioControl(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029EFB RID: 171771 RVA: 0x005B9164 File Offset: 0x005B7364
		public static void AddType(FlatBufferBuilder builder, EAudioControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029EFC RID: 171772 RVA: 0x005B916F File Offset: 0x005B736F
		public static void AddEngineAudio(FlatBufferBuilder builder, StringOffset engineAudioOffset)
		{
			builder.AddOffset(1, engineAudioOffset.Value, 0);
		}

		// Token: 0x06029EFD RID: 171773 RVA: 0x005B917F File Offset: 0x005B737F
		public static void AddBrakingAudio(FlatBufferBuilder builder, StringOffset brakingAudioOffset)
		{
			builder.AddOffset(2, brakingAudioOffset.Value, 0);
		}

		// Token: 0x06029EFE RID: 171774 RVA: 0x005B918F File Offset: 0x005B738F
		public static void AddBrakingShortAudio(FlatBufferBuilder builder, StringOffset brakingShortAudioOffset)
		{
			builder.AddOffset(3, brakingShortAudioOffset.Value, 0);
		}

		// Token: 0x06029EFF RID: 171775 RVA: 0x005B919F File Offset: 0x005B739F
		public static void AddHornAudio(FlatBufferBuilder builder, StringOffset hornAudioOffset)
		{
			builder.AddOffset(4, hornAudioOffset.Value, 0);
		}

		// Token: 0x06029F00 RID: 171776 RVA: 0x005B91AF File Offset: 0x005B73AF
		public static Offset<ITrafficAudioControl> EndITrafficAudioControl(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficAudioControl>(builder.EndTable());
		}

		// Token: 0x06029F01 RID: 171777 RVA: 0x005B91BC File Offset: 0x005B73BC
		public ITrafficAudioControlT UnPack()
		{
			ITrafficAudioControlT trafficAudioControlT = new ITrafficAudioControlT();
			this.UnPackTo(trafficAudioControlT);
			return trafficAudioControlT;
		}

		// Token: 0x06029F02 RID: 171778 RVA: 0x005B91D7 File Offset: 0x005B73D7
		public void UnPackTo(ITrafficAudioControlT _o)
		{
			_o.Type = this.Type;
			_o.EngineAudio = this.EngineAudio;
			_o.BrakingAudio = this.BrakingAudio;
			_o.BrakingShortAudio = this.BrakingShortAudio;
			_o.HornAudio = this.HornAudio;
		}

		// Token: 0x06029F03 RID: 171779 RVA: 0x005B9218 File Offset: 0x005B7418
		public static Offset<ITrafficAudioControl> Pack(FlatBufferBuilder builder, ITrafficAudioControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficAudioControl>);
			}
			StringOffset engineAudioOffset = (_o.EngineAudio == null) ? default(StringOffset) : builder.CreateString(_o.EngineAudio);
			StringOffset brakingAudioOffset = (_o.BrakingAudio == null) ? default(StringOffset) : builder.CreateString(_o.BrakingAudio);
			StringOffset brakingShortAudioOffset = (_o.BrakingShortAudio == null) ? default(StringOffset) : builder.CreateString(_o.BrakingShortAudio);
			StringOffset hornAudioOffset = (_o.HornAudio == null) ? default(StringOffset) : builder.CreateString(_o.HornAudio);
			return ITrafficAudioControl.CreateITrafficAudioControl(builder, _o.Type, engineAudioOffset, brakingAudioOffset, brakingShortAudioOffset, hornAudioOffset);
		}

		// Token: 0x0400FE82 RID: 65154
		private Table __p;
	}
}
