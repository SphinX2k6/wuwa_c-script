using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200501B RID: 20507
	public struct IConnectorPointToPointPathAdvance : IFlatbufferObject
	{
		// Token: 0x170094A9 RID: 38057
		// (get) Token: 0x06020D05 RID: 134405 RVA: 0x0048FCD2 File Offset: 0x0048DED2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D06 RID: 134406 RVA: 0x0048FCDF File Offset: 0x0048DEDF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D07 RID: 134407 RVA: 0x0048FCE8 File Offset: 0x0048DEE8
		public static IConnectorPointToPointPathAdvance GetRootAsIConnectorPointToPointPathAdvance(ByteBuffer _bb)
		{
			return IConnectorPointToPointPathAdvance.GetRootAsIConnectorPointToPointPathAdvance(_bb, default(IConnectorPointToPointPathAdvance));
		}

		// Token: 0x06020D08 RID: 134408 RVA: 0x0048FD04 File Offset: 0x0048DF04
		public static IConnectorPointToPointPathAdvance GetRootAsIConnectorPointToPointPathAdvance(ByteBuffer _bb, IConnectorPointToPointPathAdvance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D09 RID: 134409 RVA: 0x0048FD21 File Offset: 0x0048DF21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D0A RID: 134410 RVA: 0x0048FD30 File Offset: 0x0048DF30
		public IConnectorPointToPointPathAdvance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094AA RID: 38058
		// (get) Token: 0x06020D0B RID: 134411 RVA: 0x0048FD40 File Offset: 0x0048DF40
		public EConnectorLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConnectorLogicType.Range;
				}
				return (EConnectorLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094AB RID: 38059
		// (get) Token: 0x06020D0C RID: 134412 RVA: 0x0048FD7C File Offset: 0x0048DF7C
		public IConnectorEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConnectorEffectConfig?(default(IConnectorEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170094AC RID: 38060
		// (get) Token: 0x06020D0D RID: 134413 RVA: 0x0048FDDC File Offset: 0x0048DFDC
		public IConnectorPathAdvanceInitiator? Initiator
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConnectorPathAdvanceInitiator?(default(IConnectorPathAdvanceInitiator).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170094AD RID: 38061
		// (get) Token: 0x06020D0E RID: 134414 RVA: 0x0048FE3C File Offset: 0x0048E03C
		public IConnectorPathAdvanceReceiver? Receiver
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConnectorPathAdvanceReceiver?(default(IConnectorPathAdvanceReceiver).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020D0F RID: 134415 RVA: 0x0048FE9A File Offset: 0x0048E09A
		public static Offset<IConnectorPointToPointPathAdvance> CreateIConnectorPointToPointPathAdvance(FlatBufferBuilder builder, EConnectorLogicType Type = EConnectorLogicType.Range, Offset<IConnectorEffectConfig> EffectConfigOffset = default(Offset<IConnectorEffectConfig>), Offset<IConnectorPathAdvanceInitiator> InitiatorOffset = default(Offset<IConnectorPathAdvanceInitiator>), Offset<IConnectorPathAdvanceReceiver> ReceiverOffset = default(Offset<IConnectorPathAdvanceReceiver>))
		{
			builder.StartTable(4);
			IConnectorPointToPointPathAdvance.AddReceiver(builder, ReceiverOffset);
			IConnectorPointToPointPathAdvance.AddInitiator(builder, InitiatorOffset);
			IConnectorPointToPointPathAdvance.AddEffectConfig(builder, EffectConfigOffset);
			IConnectorPointToPointPathAdvance.AddType(builder, Type);
			return IConnectorPointToPointPathAdvance.EndIConnectorPointToPointPathAdvance(builder);
		}

		// Token: 0x06020D10 RID: 134416 RVA: 0x0048FEC6 File Offset: 0x0048E0C6
		public static void StartIConnectorPointToPointPathAdvance(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020D11 RID: 134417 RVA: 0x0048FECF File Offset: 0x0048E0CF
		public static void AddType(FlatBufferBuilder builder, EConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020D12 RID: 134418 RVA: 0x0048FEDA File Offset: 0x0048E0DA
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06020D13 RID: 134419 RVA: 0x0048FEEA File Offset: 0x0048E0EA
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IConnectorPathAdvanceInitiator> initiatorOffset)
		{
			builder.AddOffset(2, initiatorOffset.Value, 0);
		}

		// Token: 0x06020D14 RID: 134420 RVA: 0x0048FEFA File Offset: 0x0048E0FA
		public static void AddReceiver(FlatBufferBuilder builder, Offset<IConnectorPathAdvanceReceiver> receiverOffset)
		{
			builder.AddOffset(3, receiverOffset.Value, 0);
		}

		// Token: 0x06020D15 RID: 134421 RVA: 0x0048FF0A File Offset: 0x0048E10A
		public static Offset<IConnectorPointToPointPathAdvance> EndIConnectorPointToPointPathAdvance(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPointToPointPathAdvance>(builder.EndTable());
		}

		// Token: 0x06020D16 RID: 134422 RVA: 0x0048FF18 File Offset: 0x0048E118
		public IConnectorPointToPointPathAdvanceT UnPack()
		{
			IConnectorPointToPointPathAdvanceT connectorPointToPointPathAdvanceT = new IConnectorPointToPointPathAdvanceT();
			this.UnPackTo(connectorPointToPointPathAdvanceT);
			return connectorPointToPointPathAdvanceT;
		}

		// Token: 0x06020D17 RID: 134423 RVA: 0x0048FF34 File Offset: 0x0048E134
		public void UnPackTo(IConnectorPointToPointPathAdvanceT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Receiver = ((this.Receiver != null) ? this.Receiver.Value.UnPack() : null);
		}

		// Token: 0x06020D18 RID: 134424 RVA: 0x0048FFE0 File Offset: 0x0048E1E0
		public static Offset<IConnectorPointToPointPathAdvance> Pack(FlatBufferBuilder builder, IConnectorPointToPointPathAdvanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorPointToPointPathAdvance>);
			}
			Offset<IConnectorEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IConnectorEffectConfig>) : IConnectorEffectConfig.Pack(builder, _o.EffectConfig);
			Offset<IConnectorPathAdvanceInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IConnectorPathAdvanceInitiator>) : IConnectorPathAdvanceInitiator.Pack(builder, _o.Initiator);
			Offset<IConnectorPathAdvanceReceiver> receiverOffset = (_o.Receiver == null) ? default(Offset<IConnectorPathAdvanceReceiver>) : IConnectorPathAdvanceReceiver.Pack(builder, _o.Receiver);
			return IConnectorPointToPointPathAdvance.CreateIConnectorPointToPointPathAdvance(builder, _o.Type, effectConfigOffset, initiatorOffset, receiverOffset);
		}

		// Token: 0x0400DFEE RID: 57326
		private Table __p;
	}
}
