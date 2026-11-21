using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556E RID: 21870
	public struct IConnectorPathAdvanceReceiver : IFlatbufferObject
	{
		// Token: 0x17009C71 RID: 40049
		// (get) Token: 0x06022BBD RID: 142269 RVA: 0x004C8C08 File Offset: 0x004C6E08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022BBE RID: 142270 RVA: 0x004C8C15 File Offset: 0x004C6E15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022BBF RID: 142271 RVA: 0x004C8C1C File Offset: 0x004C6E1C
		public static IConnectorPathAdvanceReceiver GetRootAsIConnectorPathAdvanceReceiver(ByteBuffer _bb)
		{
			return IConnectorPathAdvanceReceiver.GetRootAsIConnectorPathAdvanceReceiver(_bb, default(IConnectorPathAdvanceReceiver));
		}

		// Token: 0x06022BC0 RID: 142272 RVA: 0x004C8C38 File Offset: 0x004C6E38
		public static IConnectorPathAdvanceReceiver GetRootAsIConnectorPathAdvanceReceiver(ByteBuffer _bb, IConnectorPathAdvanceReceiver obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022BC1 RID: 142273 RVA: 0x004C8C55 File Offset: 0x004C6E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022BC2 RID: 142274 RVA: 0x004C8C64 File Offset: 0x004C6E64
		public IConnectorPathAdvanceReceiver __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C72 RID: 40050
		// (get) Token: 0x06022BC3 RID: 142275 RVA: 0x004C8C74 File Offset: 0x004C6E74
		public string ConnectedState
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

		// Token: 0x06022BC4 RID: 142276 RVA: 0x004C8CAB File Offset: 0x004C6EAB
		public Span<byte> GetConnectedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022BC5 RID: 142277 RVA: 0x004C8CBA File Offset: 0x004C6EBA
		public byte[] GetConnectedStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009C73 RID: 40051
		// (get) Token: 0x06022BC6 RID: 142278 RVA: 0x004C8CC8 File Offset: 0x004C6EC8
		public string DisconnectedState
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

		// Token: 0x06022BC7 RID: 142279 RVA: 0x004C8CFF File Offset: 0x004C6EFF
		public Span<byte> GetDisconnectedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022BC8 RID: 142280 RVA: 0x004C8D0E File Offset: 0x004C6F0E
		public byte[] GetDisconnectedStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06022BC9 RID: 142281 RVA: 0x004C8D1C File Offset: 0x004C6F1C
		public static Offset<IConnectorPathAdvanceReceiver> CreateIConnectorPathAdvanceReceiver(FlatBufferBuilder builder, StringOffset ConnectedStateOffset = default(StringOffset), StringOffset DisconnectedStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IConnectorPathAdvanceReceiver.AddDisconnectedState(builder, DisconnectedStateOffset);
			IConnectorPathAdvanceReceiver.AddConnectedState(builder, ConnectedStateOffset);
			return IConnectorPathAdvanceReceiver.EndIConnectorPathAdvanceReceiver(builder);
		}

		// Token: 0x06022BCA RID: 142282 RVA: 0x004C8D39 File Offset: 0x004C6F39
		public static void StartIConnectorPathAdvanceReceiver(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022BCB RID: 142283 RVA: 0x004C8D42 File Offset: 0x004C6F42
		public static void AddConnectedState(FlatBufferBuilder builder, StringOffset connectedStateOffset)
		{
			builder.AddOffset(0, connectedStateOffset.Value, 0);
		}

		// Token: 0x06022BCC RID: 142284 RVA: 0x004C8D52 File Offset: 0x004C6F52
		public static void AddDisconnectedState(FlatBufferBuilder builder, StringOffset disconnectedStateOffset)
		{
			builder.AddOffset(1, disconnectedStateOffset.Value, 0);
		}

		// Token: 0x06022BCD RID: 142285 RVA: 0x004C8D62 File Offset: 0x004C6F62
		public static Offset<IConnectorPathAdvanceReceiver> EndIConnectorPathAdvanceReceiver(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPathAdvanceReceiver>(builder.EndTable());
		}

		// Token: 0x06022BCE RID: 142286 RVA: 0x004C8D70 File Offset: 0x004C6F70
		public IConnectorPathAdvanceReceiverT UnPack()
		{
			IConnectorPathAdvanceReceiverT connectorPathAdvanceReceiverT = new IConnectorPathAdvanceReceiverT();
			this.UnPackTo(connectorPathAdvanceReceiverT);
			return connectorPathAdvanceReceiverT;
		}

		// Token: 0x06022BCF RID: 142287 RVA: 0x004C8D8B File Offset: 0x004C6F8B
		public void UnPackTo(IConnectorPathAdvanceReceiverT _o)
		{
			_o.ConnectedState = this.ConnectedState;
			_o.DisconnectedState = this.DisconnectedState;
		}

		// Token: 0x06022BD0 RID: 142288 RVA: 0x004C8DA8 File Offset: 0x004C6FA8
		public static Offset<IConnectorPathAdvanceReceiver> Pack(FlatBufferBuilder builder, IConnectorPathAdvanceReceiverT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorPathAdvanceReceiver>);
			}
			StringOffset connectedStateOffset = (_o.ConnectedState == null) ? default(StringOffset) : builder.CreateString(_o.ConnectedState);
			StringOffset disconnectedStateOffset = (_o.DisconnectedState == null) ? default(StringOffset) : builder.CreateString(_o.DisconnectedState);
			return IConnectorPathAdvanceReceiver.CreateIConnectorPathAdvanceReceiver(builder, connectedStateOffset, disconnectedStateOffset);
		}

		// Token: 0x0400EBD1 RID: 60369
		private Table __p;
	}
}
