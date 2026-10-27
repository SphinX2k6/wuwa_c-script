using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B6 RID: 20918
	public struct IEntityStateAudioConfig : IFlatbufferObject
	{
		// Token: 0x170098E6 RID: 39142
		// (get) Token: 0x06021DE4 RID: 138724 RVA: 0x004B2A6D File Offset: 0x004B0C6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021DE5 RID: 138725 RVA: 0x004B2A7A File Offset: 0x004B0C7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021DE6 RID: 138726 RVA: 0x004B2A84 File Offset: 0x004B0C84
		public static IEntityStateAudioConfig GetRootAsIEntityStateAudioConfig(ByteBuffer _bb)
		{
			return IEntityStateAudioConfig.GetRootAsIEntityStateAudioConfig(_bb, default(IEntityStateAudioConfig));
		}

		// Token: 0x06021DE7 RID: 138727 RVA: 0x004B2AA0 File Offset: 0x004B0CA0
		public static IEntityStateAudioConfig GetRootAsIEntityStateAudioConfig(ByteBuffer _bb, IEntityStateAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021DE8 RID: 138728 RVA: 0x004B2ABD File Offset: 0x004B0CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021DE9 RID: 138729 RVA: 0x004B2ACC File Offset: 0x004B0CCC
		public IEntityStateAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098E7 RID: 39143
		// (get) Token: 0x06021DEA RID: 138730 RVA: 0x004B2ADC File Offset: 0x004B0CDC
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

		// Token: 0x06021DEB RID: 138731 RVA: 0x004B2B13 File Offset: 0x004B0D13
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021DEC RID: 138732 RVA: 0x004B2B22 File Offset: 0x004B0D22
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170098E8 RID: 39144
		// (get) Token: 0x06021DED RID: 138733 RVA: 0x004B2B30 File Offset: 0x004B0D30
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

		// Token: 0x06021DEE RID: 138734 RVA: 0x004B2B67 File Offset: 0x004B0D67
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021DEF RID: 138735 RVA: 0x004B2B76 File Offset: 0x004B0D76
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170098E9 RID: 39145
		// (get) Token: 0x06021DF0 RID: 138736 RVA: 0x004B2B84 File Offset: 0x004B0D84
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

		// Token: 0x06021DF1 RID: 138737 RVA: 0x004B2BBB File Offset: 0x004B0DBB
		public Span<byte> GetLeaveAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06021DF2 RID: 138738 RVA: 0x004B2BCA File Offset: 0x004B0DCA
		public byte[] GetLeaveAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170098EA RID: 39146
		// (get) Token: 0x06021DF3 RID: 138739 RVA: 0x004B2BD8 File Offset: 0x004B0DD8
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

		// Token: 0x170098EB RID: 39147
		// (get) Token: 0x06021DF4 RID: 138740 RVA: 0x004B2C38 File Offset: 0x004B0E38
		public bool IsBanVehicleRadio
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098EC RID: 39148
		// (get) Token: 0x06021DF5 RID: 138741 RVA: 0x004B2C78 File Offset: 0x004B0E78
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

		// Token: 0x06021DF6 RID: 138742 RVA: 0x004B2CB5 File Offset: 0x004B0EB5
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

		// Token: 0x06021DF7 RID: 138743 RVA: 0x004B2CF1 File Offset: 0x004B0EF1
		public static void StartIEntityStateAudioConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06021DF8 RID: 138744 RVA: 0x004B2CFA File Offset: 0x004B0EFA
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06021DF9 RID: 138745 RVA: 0x004B2D0A File Offset: 0x004B0F0A
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(1, akEventOffset.Value, 0);
		}

		// Token: 0x06021DFA RID: 138746 RVA: 0x004B2D1A File Offset: 0x004B0F1A
		public static void AddLeaveAkEvent(FlatBufferBuilder builder, StringOffset leaveAkEventOffset)
		{
			builder.AddOffset(2, leaveAkEventOffset.Value, 0);
		}

		// Token: 0x06021DFB RID: 138747 RVA: 0x004B2D2A File Offset: 0x004B0F2A
		public static void AddAudioFade(FlatBufferBuilder builder, Offset<IAudioFade> audioFadeOffset)
		{
			builder.AddOffset(3, audioFadeOffset.Value, 0);
		}

		// Token: 0x06021DFC RID: 138748 RVA: 0x004B2D3A File Offset: 0x004B0F3A
		public static void AddIsBanVehicleRadio(FlatBufferBuilder builder, bool isBanVehicleRadio)
		{
			builder.AddBool(4, isBanVehicleRadio, false);
		}

		// Token: 0x06021DFD RID: 138749 RVA: 0x004B2D45 File Offset: 0x004B0F45
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06021DFE RID: 138750 RVA: 0x004B2D50 File Offset: 0x004B0F50
		public static Offset<IEntityStateAudioConfig> EndIEntityStateAudioConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateAudioConfig>(builder.EndTable());
		}

		// Token: 0x06021DFF RID: 138751 RVA: 0x004B2D60 File Offset: 0x004B0F60
		public IEntityStateAudioConfigT UnPack()
		{
			IEntityStateAudioConfigT entityStateAudioConfigT = new IEntityStateAudioConfigT();
			this.UnPackTo(entityStateAudioConfigT);
			return entityStateAudioConfigT;
		}

		// Token: 0x06021E00 RID: 138752 RVA: 0x004B2D7C File Offset: 0x004B0F7C
		public void UnPackTo(IEntityStateAudioConfigT _o)
		{
			_o.State = this.State;
			_o.AkEvent = this.AkEvent;
			_o.LeaveAkEvent = this.LeaveAkEvent;
			_o.AudioFade = ((this.AudioFade != null) ? this.AudioFade.Value.UnPack() : null);
			_o.IsBanVehicleRadio = this.IsBanVehicleRadio;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021E01 RID: 138753 RVA: 0x004B2DF4 File Offset: 0x004B0FF4
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

		// Token: 0x0400E29F RID: 58015
		private Table __p;
	}
}
