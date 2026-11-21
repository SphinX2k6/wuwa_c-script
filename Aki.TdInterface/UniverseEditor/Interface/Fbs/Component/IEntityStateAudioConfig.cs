using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571B RID: 22299
	public struct IEntityStateAudioConfig : IFlatbufferObject
	{
		// Token: 0x1700A0D5 RID: 41173
		// (get) Token: 0x06023D3C RID: 146748 RVA: 0x004ECAD5 File Offset: 0x004EACD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023D3D RID: 146749 RVA: 0x004ECAE2 File Offset: 0x004EACE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023D3E RID: 146750 RVA: 0x004ECAEC File Offset: 0x004EACEC
		public static IEntityStateAudioConfig GetRootAsIEntityStateAudioConfig(ByteBuffer _bb)
		{
			return IEntityStateAudioConfig.GetRootAsIEntityStateAudioConfig(_bb, default(IEntityStateAudioConfig));
		}

		// Token: 0x06023D3F RID: 146751 RVA: 0x004ECB08 File Offset: 0x004EAD08
		public static IEntityStateAudioConfig GetRootAsIEntityStateAudioConfig(ByteBuffer _bb, IEntityStateAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023D40 RID: 146752 RVA: 0x004ECB25 File Offset: 0x004EAD25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023D41 RID: 146753 RVA: 0x004ECB34 File Offset: 0x004EAD34
		public IEntityStateAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0D6 RID: 41174
		// (get) Token: 0x06023D42 RID: 146754 RVA: 0x004ECB44 File Offset: 0x004EAD44
		public string State
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

		// Token: 0x06023D43 RID: 146755 RVA: 0x004ECB7B File Offset: 0x004EAD7B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023D44 RID: 146756 RVA: 0x004ECB8A File Offset: 0x004EAD8A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A0D7 RID: 41175
		// (get) Token: 0x06023D45 RID: 146757 RVA: 0x004ECB98 File Offset: 0x004EAD98
		public string AkEvent
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

		// Token: 0x06023D46 RID: 146758 RVA: 0x004ECBCF File Offset: 0x004EADCF
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023D47 RID: 146759 RVA: 0x004ECBDE File Offset: 0x004EADDE
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A0D8 RID: 41176
		// (get) Token: 0x06023D48 RID: 146760 RVA: 0x004ECBEC File Offset: 0x004EADEC
		public string LeaveAkEvent
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

		// Token: 0x06023D49 RID: 146761 RVA: 0x004ECC23 File Offset: 0x004EAE23
		public Span<byte> GetLeaveAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06023D4A RID: 146762 RVA: 0x004ECC32 File Offset: 0x004EAE32
		public byte[] GetLeaveAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A0D9 RID: 41177
		// (get) Token: 0x06023D4B RID: 146763 RVA: 0x004ECC40 File Offset: 0x004EAE40
		public IAudioFade? AudioFade
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IAudioFade?(default(IAudioFade).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A0DA RID: 41178
		// (get) Token: 0x06023D4C RID: 146764 RVA: 0x004ECCA0 File Offset: 0x004EAEA0
		public bool IsBanVehicleRadio
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0DB RID: 41179
		// (get) Token: 0x06023D4D RID: 146765 RVA: 0x004ECCE0 File Offset: 0x004EAEE0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D4E RID: 146766 RVA: 0x004ECD1D File Offset: 0x004EAF1D
		public static Offset<IEntityStateAudioConfig> CreateIEntityStateAudioConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), StringOffset AkEventOffset = default(StringOffset), StringOffset LeaveAkEventOffset = default(StringOffset), Offset<IAudioFade> AudioFadeOffset = default(Offset<IAudioFade>), bool IsBanVehicleRadio = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IEntityStateAudioConfig.AddAudioFade(builder, AudioFadeOffset);
			IEntityStateAudioConfig.AddLeaveAkEvent(builder, LeaveAkEventOffset);
			IEntityStateAudioConfig.AddAkEvent(builder, AkEventOffset);
			IEntityStateAudioConfig.AddState(builder, StateOffset);
			IEntityStateAudioConfig.AddNullMask(builder, NullMask);
			IEntityStateAudioConfig.AddIsBanVehicleRadio(builder, IsBanVehicleRadio);
			return IEntityStateAudioConfig.EndIEntityStateAudioConfig(builder);
		}

		// Token: 0x06023D4F RID: 146767 RVA: 0x004ECD59 File Offset: 0x004EAF59
		public static void StartIEntityStateAudioConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023D50 RID: 146768 RVA: 0x004ECD62 File Offset: 0x004EAF62
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06023D51 RID: 146769 RVA: 0x004ECD72 File Offset: 0x004EAF72
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(1, akEventOffset.Value, 0);
		}

		// Token: 0x06023D52 RID: 146770 RVA: 0x004ECD82 File Offset: 0x004EAF82
		public static void AddLeaveAkEvent(FlatBufferBuilder builder, StringOffset leaveAkEventOffset)
		{
			builder.AddOffset(2, leaveAkEventOffset.Value, 0);
		}

		// Token: 0x06023D53 RID: 146771 RVA: 0x004ECD92 File Offset: 0x004EAF92
		public static void AddAudioFade(FlatBufferBuilder builder, Offset<IAudioFade> audioFadeOffset)
		{
			builder.AddOffset(3, audioFadeOffset.Value, 0);
		}

		// Token: 0x06023D54 RID: 146772 RVA: 0x004ECDA2 File Offset: 0x004EAFA2
		public static void AddIsBanVehicleRadio(FlatBufferBuilder builder, bool isBanVehicleRadio)
		{
			builder.AddBool(4, isBanVehicleRadio, false);
		}

		// Token: 0x06023D55 RID: 146773 RVA: 0x004ECDAD File Offset: 0x004EAFAD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06023D56 RID: 146774 RVA: 0x004ECDB8 File Offset: 0x004EAFB8
		public static Offset<IEntityStateAudioConfig> EndIEntityStateAudioConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateAudioConfig>(builder.EndTable());
		}

		// Token: 0x06023D57 RID: 146775 RVA: 0x004ECDC8 File Offset: 0x004EAFC8
		public IEntityStateAudioConfigT UnPack()
		{
			IEntityStateAudioConfigT entityStateAudioConfigT = new IEntityStateAudioConfigT();
			this.UnPackTo(entityStateAudioConfigT);
			return entityStateAudioConfigT;
		}

		// Token: 0x06023D58 RID: 146776 RVA: 0x004ECDE4 File Offset: 0x004EAFE4
		public void UnPackTo(IEntityStateAudioConfigT _o)
		{
			_o.State = this.State;
			_o.AkEvent = this.AkEvent;
			_o.LeaveAkEvent = this.LeaveAkEvent;
			_o.AudioFade = ((this.AudioFade != null) ? this.AudioFade.Value.UnPack() : null);
			_o.IsBanVehicleRadio = this.IsBanVehicleRadio;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023D59 RID: 146777 RVA: 0x004ECE5C File Offset: 0x004EB05C
		public static Offset<IEntityStateAudioConfig> Pack(FlatBufferBuilder builder, IEntityStateAudioConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateAudioConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			StringOffset leaveAkEventOffset = (_o.LeaveAkEvent == null) ? default(StringOffset) : builder.CreateString(_o.LeaveAkEvent);
			Offset<IAudioFade> audioFadeOffset = (_o.AudioFade == null) ? default(Offset<IAudioFade>) : IAudioFade.Pack(builder, _o.AudioFade);
			return IEntityStateAudioConfig.CreateIEntityStateAudioConfig(builder, stateOffset, akEventOffset, leaveAkEventOffset, audioFadeOffset, _o.IsBanVehicleRadio, _o.NullMask);
		}

		// Token: 0x0400EE9D RID: 61085
		private Table __p;
	}
}
