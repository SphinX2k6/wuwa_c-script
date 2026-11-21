using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557A RID: 21882
	public struct IConnectorPointToPointPathAdvance : IFlatbufferObject
	{
		// Token: 0x17009C8A RID: 40074
		// (get) Token: 0x06022C25 RID: 142373 RVA: 0x004C9722 File Offset: 0x004C7922
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C26 RID: 142374 RVA: 0x004C972F File Offset: 0x004C792F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C27 RID: 142375 RVA: 0x004C9738 File Offset: 0x004C7938
		public static IConnectorPointToPointPathAdvance GetRootAsIConnectorPointToPointPathAdvance(ByteBuffer _bb)
		{
			return IConnectorPointToPointPathAdvance.GetRootAsIConnectorPointToPointPathAdvance(_bb, default(IConnectorPointToPointPathAdvance));
		}

		// Token: 0x06022C28 RID: 142376 RVA: 0x004C9754 File Offset: 0x004C7954
		public static IConnectorPointToPointPathAdvance GetRootAsIConnectorPointToPointPathAdvance(ByteBuffer _bb, IConnectorPointToPointPathAdvance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C29 RID: 142377 RVA: 0x004C9771 File Offset: 0x004C7971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C2A RID: 142378 RVA: 0x004C9780 File Offset: 0x004C7980
		public IConnectorPointToPointPathAdvance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C8B RID: 40075
		// (get) Token: 0x06022C2B RID: 142379 RVA: 0x004C9790 File Offset: 0x004C7990
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

		// Token: 0x17009C8C RID: 40076
		// (get) Token: 0x06022C2C RID: 142380 RVA: 0x004C97CC File Offset: 0x004C79CC
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

		// Token: 0x17009C8D RID: 40077
		// (get) Token: 0x06022C2D RID: 142381 RVA: 0x004C982C File Offset: 0x004C7A2C
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

		// Token: 0x17009C8E RID: 40078
		// (get) Token: 0x06022C2E RID: 142382 RVA: 0x004C988C File Offset: 0x004C7A8C
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

		// Token: 0x06022C2F RID: 142383 RVA: 0x004C98EA File Offset: 0x004C7AEA
		public static Offset<IConnectorPointToPointPathAdvance> CreateIConnectorPointToPointPathAdvance(FlatBufferBuilder builder, EConnectorLogicType Type = EConnectorLogicType.Range, Offset<IConnectorEffectConfig> EffectConfigOffset = default(Offset<IConnectorEffectConfig>), Offset<IConnectorPathAdvanceInitiator> InitiatorOffset = default(Offset<IConnectorPathAdvanceInitiator>), Offset<IConnectorPathAdvanceReceiver> ReceiverOffset = default(Offset<IConnectorPathAdvanceReceiver>))
		{
			builder.StartTable(4);
			IConnectorPointToPointPathAdvance.AddReceiver(builder, ReceiverOffset);
			IConnectorPointToPointPathAdvance.AddInitiator(builder, InitiatorOffset);
			IConnectorPointToPointPathAdvance.AddEffectConfig(builder, EffectConfigOffset);
			IConnectorPointToPointPathAdvance.AddType(builder, Type);
			return IConnectorPointToPointPathAdvance.EndIConnectorPointToPointPathAdvance(builder);
		}

		// Token: 0x06022C30 RID: 142384 RVA: 0x004C9916 File Offset: 0x004C7B16
		public static void StartIConnectorPointToPointPathAdvance(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022C31 RID: 142385 RVA: 0x004C991F File Offset: 0x004C7B1F
		public static void AddType(FlatBufferBuilder builder, EConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022C32 RID: 142386 RVA: 0x004C992A File Offset: 0x004C7B2A
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06022C33 RID: 142387 RVA: 0x004C993A File Offset: 0x004C7B3A
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IConnectorPathAdvanceInitiator> initiatorOffset)
		{
			builder.AddOffset(2, initiatorOffset.Value, 0);
		}

		// Token: 0x06022C34 RID: 142388 RVA: 0x004C994A File Offset: 0x004C7B4A
		public static void AddReceiver(FlatBufferBuilder builder, Offset<IConnectorPathAdvanceReceiver> receiverOffset)
		{
			builder.AddOffset(3, receiverOffset.Value, 0);
		}

		// Token: 0x06022C35 RID: 142389 RVA: 0x004C995A File Offset: 0x004C7B5A
		public static Offset<IConnectorPointToPointPathAdvance> EndIConnectorPointToPointPathAdvance(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPointToPointPathAdvance>(builder.EndTable());
		}

		// Token: 0x06022C36 RID: 142390 RVA: 0x004C9968 File Offset: 0x004C7B68
		public IConnectorPointToPointPathAdvanceT UnPack()
		{
			IConnectorPointToPointPathAdvanceT connectorPointToPointPathAdvanceT = new IConnectorPointToPointPathAdvanceT();
			this.UnPackTo(connectorPointToPointPathAdvanceT);
			return connectorPointToPointPathAdvanceT;
		}

		// Token: 0x06022C37 RID: 142391 RVA: 0x004C9984 File Offset: 0x004C7B84
		public void UnPackTo(IConnectorPointToPointPathAdvanceT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Receiver = ((this.Receiver != null) ? this.Receiver.Value.UnPack() : null);
		}

		// Token: 0x06022C38 RID: 142392 RVA: 0x004C9A30 File Offset: 0x004C7C30
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

		// Token: 0x0400EBE4 RID: 60388
		private Table __p;
	}
}
