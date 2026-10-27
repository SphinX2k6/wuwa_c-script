using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200500F RID: 20495
	public struct IConnectorPathAdvanceReceiver : IFlatbufferObject
	{
		// Token: 0x17009490 RID: 38032
		// (get) Token: 0x06020C9D RID: 134301 RVA: 0x0048F1B8 File Offset: 0x0048D3B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C9E RID: 134302 RVA: 0x0048F1C5 File Offset: 0x0048D3C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C9F RID: 134303 RVA: 0x0048F1CC File Offset: 0x0048D3CC
		public static IConnectorPathAdvanceReceiver GetRootAsIConnectorPathAdvanceReceiver(ByteBuffer _bb)
		{
			return IConnectorPathAdvanceReceiver.GetRootAsIConnectorPathAdvanceReceiver(_bb, default(IConnectorPathAdvanceReceiver));
		}

		// Token: 0x06020CA0 RID: 134304 RVA: 0x0048F1E8 File Offset: 0x0048D3E8
		public static IConnectorPathAdvanceReceiver GetRootAsIConnectorPathAdvanceReceiver(ByteBuffer _bb, IConnectorPathAdvanceReceiver obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020CA1 RID: 134305 RVA: 0x0048F205 File Offset: 0x0048D405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020CA2 RID: 134306 RVA: 0x0048F214 File Offset: 0x0048D414
		public IConnectorPathAdvanceReceiver __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009491 RID: 38033
		// (get) Token: 0x06020CA3 RID: 134307 RVA: 0x0048F224 File Offset: 0x0048D424
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

		// Token: 0x06020CA4 RID: 134308 RVA: 0x0048F25B File Offset: 0x0048D45B
		public Span<byte> GetConnectedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06020CA5 RID: 134309 RVA: 0x0048F26A File Offset: 0x0048D46A
		public byte[] GetConnectedStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009492 RID: 38034
		// (get) Token: 0x06020CA6 RID: 134310 RVA: 0x0048F278 File Offset: 0x0048D478
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

		// Token: 0x06020CA7 RID: 134311 RVA: 0x0048F2AF File Offset: 0x0048D4AF
		public Span<byte> GetDisconnectedStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020CA8 RID: 134312 RVA: 0x0048F2BE File Offset: 0x0048D4BE
		public byte[] GetDisconnectedStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06020CA9 RID: 134313 RVA: 0x0048F2CC File Offset: 0x0048D4CC
		public static Offset<IConnectorPathAdvanceReceiver> CreateIConnectorPathAdvanceReceiver(FlatBufferBuilder builder, StringOffset ConnectedStateOffset = default(StringOffset), StringOffset DisconnectedStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IConnectorPathAdvanceReceiver.AddDisconnectedState(builder, DisconnectedStateOffset);
			IConnectorPathAdvanceReceiver.AddConnectedState(builder, ConnectedStateOffset);
			return IConnectorPathAdvanceReceiver.EndIConnectorPathAdvanceReceiver(builder);
		}

		// Token: 0x06020CAA RID: 134314 RVA: 0x0048F2E9 File Offset: 0x0048D4E9
		public static void StartIConnectorPathAdvanceReceiver(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020CAB RID: 134315 RVA: 0x0048F2F2 File Offset: 0x0048D4F2
		public static void AddConnectedState(FlatBufferBuilder builder, StringOffset connectedStateOffset)
		{
			builder.AddOffset(0, connectedStateOffset.Value, 0);
		}

		// Token: 0x06020CAC RID: 134316 RVA: 0x0048F302 File Offset: 0x0048D502
		public static void AddDisconnectedState(FlatBufferBuilder builder, StringOffset disconnectedStateOffset)
		{
			builder.AddOffset(1, disconnectedStateOffset.Value, 0);
		}

		// Token: 0x06020CAD RID: 134317 RVA: 0x0048F312 File Offset: 0x0048D512
		public static Offset<IConnectorPathAdvanceReceiver> EndIConnectorPathAdvanceReceiver(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPathAdvanceReceiver>(builder.EndTable());
		}

		// Token: 0x06020CAE RID: 134318 RVA: 0x0048F320 File Offset: 0x0048D520
		public IConnectorPathAdvanceReceiverT UnPack()
		{
			IConnectorPathAdvanceReceiverT connectorPathAdvanceReceiverT = new IConnectorPathAdvanceReceiverT();
			this.UnPackTo(connectorPathAdvanceReceiverT);
			return connectorPathAdvanceReceiverT;
		}

		// Token: 0x06020CAF RID: 134319 RVA: 0x0048F33B File Offset: 0x0048D53B
		public void UnPackTo(IConnectorPathAdvanceReceiverT _o)
		{
			_o.ConnectedState = this.ConnectedState;
			_o.DisconnectedState = this.DisconnectedState;
		}

		// Token: 0x06020CB0 RID: 134320 RVA: 0x0048F358 File Offset: 0x0048D558
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

		// Token: 0x0400DFDB RID: 57307
		private Table __p;
	}
}
