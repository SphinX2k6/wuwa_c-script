using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200487D RID: 18557
	public struct IGameServerConnectionConfig : IFlatbufferObject
	{
		// Token: 0x17008655 RID: 34389
		// (get) Token: 0x0601CE92 RID: 118418 RVA: 0x0041605C File Offset: 0x0041425C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE93 RID: 118419 RVA: 0x00416069 File Offset: 0x00414269
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE94 RID: 118420 RVA: 0x00416070 File Offset: 0x00414270
		public static IGameServerConnectionConfig GetRootAsIGameServerConnectionConfig(ByteBuffer _bb)
		{
			return IGameServerConnectionConfig.GetRootAsIGameServerConnectionConfig(_bb, default(IGameServerConnectionConfig));
		}

		// Token: 0x0601CE95 RID: 118421 RVA: 0x0041608C File Offset: 0x0041428C
		public static IGameServerConnectionConfig GetRootAsIGameServerConnectionConfig(ByteBuffer _bb, IGameServerConnectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE96 RID: 118422 RVA: 0x004160A9 File Offset: 0x004142A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE97 RID: 118423 RVA: 0x004160B8 File Offset: 0x004142B8
		public IGameServerConnectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008656 RID: 34390
		// (get) Token: 0x0601CE98 RID: 118424 RVA: 0x004160C8 File Offset: 0x004142C8
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

		// Token: 0x0601CE99 RID: 118425 RVA: 0x004160FF File Offset: 0x004142FF
		public Span<byte> GetLocalGameServerNodeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CE9A RID: 118426 RVA: 0x0041610E File Offset: 0x0041430E
		public byte[] GetLocalGameServerNodeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008657 RID: 34391
		// (get) Token: 0x0601CE9B RID: 118427 RVA: 0x0041611C File Offset: 0x0041431C
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

		// Token: 0x17008658 RID: 34392
		// (get) Token: 0x0601CE9C RID: 118428 RVA: 0x00416158 File Offset: 0x00414358
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

		// Token: 0x17008659 RID: 34393
		// (get) Token: 0x0601CE9D RID: 118429 RVA: 0x00416194 File Offset: 0x00414394
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

		// Token: 0x0601CE9E RID: 118430 RVA: 0x004161D1 File Offset: 0x004143D1
		public static Offset<IGameServerConnectionConfig> CreateIGameServerConnectionConfig(FlatBufferBuilder builder, StringOffset LocalGameServerNodeOffset = default(StringOffset), int LocalGameServerApiPort = 0, int LocalGameServerLoginPort = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGameServerConnectionConfig.AddLocalGameServerLoginPort(builder, LocalGameServerLoginPort);
			IGameServerConnectionConfig.AddLocalGameServerApiPort(builder, LocalGameServerApiPort);
			IGameServerConnectionConfig.AddLocalGameServerNode(builder, LocalGameServerNodeOffset);
			IGameServerConnectionConfig.AddNullMask(builder, NullMask);
			return IGameServerConnectionConfig.EndIGameServerConnectionConfig(builder);
		}

		// Token: 0x0601CE9F RID: 118431 RVA: 0x004161FD File Offset: 0x004143FD
		public static void StartIGameServerConnectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CEA0 RID: 118432 RVA: 0x00416206 File Offset: 0x00414406
		public static void AddLocalGameServerNode(FlatBufferBuilder builder, StringOffset localGameServerNodeOffset)
		{
			builder.AddOffset(0, localGameServerNodeOffset.Value, 0);
		}

		// Token: 0x0601CEA1 RID: 118433 RVA: 0x00416216 File Offset: 0x00414416
		public static void AddLocalGameServerApiPort(FlatBufferBuilder builder, int localGameServerApiPort)
		{
			builder.AddInt(1, localGameServerApiPort, 0);
		}

		// Token: 0x0601CEA2 RID: 118434 RVA: 0x00416221 File Offset: 0x00414421
		public static void AddLocalGameServerLoginPort(FlatBufferBuilder builder, int localGameServerLoginPort)
		{
			builder.AddInt(2, localGameServerLoginPort, 0);
		}

		// Token: 0x0601CEA3 RID: 118435 RVA: 0x0041622C File Offset: 0x0041442C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601CEA4 RID: 118436 RVA: 0x00416237 File Offset: 0x00414437
		public static Offset<IGameServerConnectionConfig> EndIGameServerConnectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGameServerConnectionConfig>(builder.EndTable());
		}

		// Token: 0x0601CEA5 RID: 118437 RVA: 0x00416244 File Offset: 0x00414444
		public IGameServerConnectionConfigT UnPack()
		{
			IGameServerConnectionConfigT gameServerConnectionConfigT = new IGameServerConnectionConfigT();
			this.UnPackTo(gameServerConnectionConfigT);
			return gameServerConnectionConfigT;
		}

		// Token: 0x0601CEA6 RID: 118438 RVA: 0x0041625F File Offset: 0x0041445F
		public void UnPackTo(IGameServerConnectionConfigT _o)
		{
			_o.LocalGameServerNode = this.LocalGameServerNode;
			_o.LocalGameServerApiPort = this.LocalGameServerApiPort;
			_o.LocalGameServerLoginPort = this.LocalGameServerLoginPort;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601CEA7 RID: 118439 RVA: 0x00416294 File Offset: 0x00414494
		public static Offset<IGameServerConnectionConfig> Pack(FlatBufferBuilder builder, IGameServerConnectionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameServerConnectionConfig>);
			}
			StringOffset localGameServerNodeOffset = (_o.LocalGameServerNode == null) ? default(StringOffset) : builder.CreateString(_o.LocalGameServerNode);
			return IGameServerConnectionConfig.CreateIGameServerConnectionConfig(builder, localGameServerNodeOffset, _o.LocalGameServerApiPort, _o.LocalGameServerLoginPort, _o.NullMask);
		}

		// Token: 0x0400CE43 RID: 52803
		private Table __p;
	}
}
