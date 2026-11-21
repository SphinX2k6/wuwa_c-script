using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CE2 RID: 19682
	public struct IGameServerConnectionConfig : IFlatbufferObject
	{
		// Token: 0x17008C9D RID: 35997
		// (get) Token: 0x0601E67F RID: 124543 RVA: 0x004427F8 File Offset: 0x004409F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E680 RID: 124544 RVA: 0x00442805 File Offset: 0x00440A05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E681 RID: 124545 RVA: 0x0044280C File Offset: 0x00440A0C
		public static IGameServerConnectionConfig GetRootAsIGameServerConnectionConfig(ByteBuffer _bb)
		{
			return IGameServerConnectionConfig.GetRootAsIGameServerConnectionConfig(_bb, default(IGameServerConnectionConfig));
		}

		// Token: 0x0601E682 RID: 124546 RVA: 0x00442828 File Offset: 0x00440A28
		public static IGameServerConnectionConfig GetRootAsIGameServerConnectionConfig(ByteBuffer _bb, IGameServerConnectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E683 RID: 124547 RVA: 0x00442845 File Offset: 0x00440A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E684 RID: 124548 RVA: 0x00442854 File Offset: 0x00440A54
		public IGameServerConnectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C9E RID: 35998
		// (get) Token: 0x0601E685 RID: 124549 RVA: 0x00442864 File Offset: 0x00440A64
		public string LocalGameServerNode
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

		// Token: 0x0601E686 RID: 124550 RVA: 0x0044289B File Offset: 0x00440A9B
		public Span<byte> GetLocalGameServerNodeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E687 RID: 124551 RVA: 0x004428AA File Offset: 0x00440AAA
		public byte[] GetLocalGameServerNodeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008C9F RID: 35999
		// (get) Token: 0x0601E688 RID: 124552 RVA: 0x004428B8 File Offset: 0x00440AB8
		public int LocalGameServerApiPort
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CA0 RID: 36000
		// (get) Token: 0x0601E689 RID: 124553 RVA: 0x004428F4 File Offset: 0x00440AF4
		public int LocalGameServerLoginPort
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CA1 RID: 36001
		// (get) Token: 0x0601E68A RID: 124554 RVA: 0x00442930 File Offset: 0x00440B30
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E68B RID: 124555 RVA: 0x0044296D File Offset: 0x00440B6D
		public static Offset<IGameServerConnectionConfig> CreateIGameServerConnectionConfig(FlatBufferBuilder builder, StringOffset LocalGameServerNodeOffset = default(StringOffset), int LocalGameServerApiPort = 0, int LocalGameServerLoginPort = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGameServerConnectionConfig.AddLocalGameServerLoginPort(builder, LocalGameServerLoginPort);
			IGameServerConnectionConfig.AddLocalGameServerApiPort(builder, LocalGameServerApiPort);
			IGameServerConnectionConfig.AddLocalGameServerNode(builder, LocalGameServerNodeOffset);
			IGameServerConnectionConfig.AddNullMask(builder, NullMask);
			return IGameServerConnectionConfig.EndIGameServerConnectionConfig(builder);
		}

		// Token: 0x0601E68C RID: 124556 RVA: 0x00442999 File Offset: 0x00440B99
		public static void StartIGameServerConnectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E68D RID: 124557 RVA: 0x004429A2 File Offset: 0x00440BA2
		public static void AddLocalGameServerNode(FlatBufferBuilder builder, StringOffset localGameServerNodeOffset)
		{
			builder.AddOffset(0, localGameServerNodeOffset.Value, 0);
		}

		// Token: 0x0601E68E RID: 124558 RVA: 0x004429B2 File Offset: 0x00440BB2
		public static void AddLocalGameServerApiPort(FlatBufferBuilder builder, int localGameServerApiPort)
		{
			builder.AddInt(1, localGameServerApiPort, 0);
		}

		// Token: 0x0601E68F RID: 124559 RVA: 0x004429BD File Offset: 0x00440BBD
		public static void AddLocalGameServerLoginPort(FlatBufferBuilder builder, int localGameServerLoginPort)
		{
			builder.AddInt(2, localGameServerLoginPort, 0);
		}

		// Token: 0x0601E690 RID: 124560 RVA: 0x004429C8 File Offset: 0x00440BC8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601E691 RID: 124561 RVA: 0x004429D3 File Offset: 0x00440BD3
		public static Offset<IGameServerConnectionConfig> EndIGameServerConnectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGameServerConnectionConfig>(builder.EndTable());
		}

		// Token: 0x0601E692 RID: 124562 RVA: 0x004429E0 File Offset: 0x00440BE0
		public IGameServerConnectionConfigT UnPack()
		{
			IGameServerConnectionConfigT gameServerConnectionConfigT = new IGameServerConnectionConfigT();
			this.UnPackTo(gameServerConnectionConfigT);
			return gameServerConnectionConfigT;
		}

		// Token: 0x0601E693 RID: 124563 RVA: 0x004429FB File Offset: 0x00440BFB
		public void UnPackTo(IGameServerConnectionConfigT _o)
		{
			_o.LocalGameServerNode = this.LocalGameServerNode;
			_o.LocalGameServerApiPort = this.LocalGameServerApiPort;
			_o.LocalGameServerLoginPort = this.LocalGameServerLoginPort;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E694 RID: 124564 RVA: 0x00442A30 File Offset: 0x00440C30
		public static Offset<IGameServerConnectionConfig> Pack(FlatBufferBuilder builder, IGameServerConnectionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameServerConnectionConfig>);
			}
			StringOffset localGameServerNodeOffset = (_o.LocalGameServerNode == null) ? default(StringOffset) : builder.CreateString(_o.LocalGameServerNode);
			return IGameServerConnectionConfig.CreateIGameServerConnectionConfig(builder, localGameServerNodeOffset, _o.LocalGameServerApiPort, _o.LocalGameServerLoginPort, _o.NullMask);
		}

		// Token: 0x0400D87C RID: 55420
		private Table __p;
	}
}
