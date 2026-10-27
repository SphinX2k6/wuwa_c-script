using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200483E RID: 18494
	public struct IConnectionGroup : IFlatbufferObject
	{
		// Token: 0x170084B8 RID: 33976
		// (get) Token: 0x0601C979 RID: 117113 RVA: 0x0040AB98 File Offset: 0x00408D98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C97A RID: 117114 RVA: 0x0040ABA5 File Offset: 0x00408DA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C97B RID: 117115 RVA: 0x0040ABAC File Offset: 0x00408DAC
		public static IConnectionGroup GetRootAsIConnectionGroup(ByteBuffer _bb)
		{
			return IConnectionGroup.GetRootAsIConnectionGroup(_bb, default(IConnectionGroup));
		}

		// Token: 0x0601C97C RID: 117116 RVA: 0x0040ABC8 File Offset: 0x00408DC8
		public static IConnectionGroup GetRootAsIConnectionGroup(ByteBuffer _bb, IConnectionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C97D RID: 117117 RVA: 0x0040ABE5 File Offset: 0x00408DE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C97E RID: 117118 RVA: 0x0040ABF4 File Offset: 0x00408DF4
		public IConnectionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084B9 RID: 33977
		// (get) Token: 0x0601C97F RID: 117119 RVA: 0x0040AC04 File Offset: 0x00408E04
		public int EditorPort
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170084BA RID: 33978
		// (get) Token: 0x0601C980 RID: 117120 RVA: 0x0040AC40 File Offset: 0x00408E40
		public int GameClientGmPort
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

		// Token: 0x170084BB RID: 33979
		// (get) Token: 0x0601C981 RID: 117121 RVA: 0x0040AC7C File Offset: 0x00408E7C
		public IConnectionIpEndPoint? P4Proxy
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConnectionIpEndPoint?(default(IConnectionIpEndPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170084BC RID: 33980
		// (get) Token: 0x0601C982 RID: 117122 RVA: 0x0040ACDC File Offset: 0x00408EDC
		public IGameServerConnectionConfig? GameServerConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IGameServerConnectionConfig?(default(IGameServerConnectionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C983 RID: 117123 RVA: 0x0040AD3A File Offset: 0x00408F3A
		public static Offset<IConnectionGroup> CreateIConnectionGroup(FlatBufferBuilder builder, int EditorPort = 0, int GameClientGmPort = 0, Offset<IConnectionIpEndPoint> P4ProxyOffset = default(Offset<IConnectionIpEndPoint>), Offset<IGameServerConnectionConfig> GameServerConfigOffset = default(Offset<IGameServerConnectionConfig>))
		{
			builder.StartTable(4);
			IConnectionGroup.AddGameServerConfig(builder, GameServerConfigOffset);
			IConnectionGroup.AddP4Proxy(builder, P4ProxyOffset);
			IConnectionGroup.AddGameClientGmPort(builder, GameClientGmPort);
			IConnectionGroup.AddEditorPort(builder, EditorPort);
			return IConnectionGroup.EndIConnectionGroup(builder);
		}

		// Token: 0x0601C984 RID: 117124 RVA: 0x0040AD66 File Offset: 0x00408F66
		public static void StartIConnectionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C985 RID: 117125 RVA: 0x0040AD6F File Offset: 0x00408F6F
		public static void AddEditorPort(FlatBufferBuilder builder, int editorPort)
		{
			builder.AddInt(0, editorPort, 0);
		}

		// Token: 0x0601C986 RID: 117126 RVA: 0x0040AD7A File Offset: 0x00408F7A
		public static void AddGameClientGmPort(FlatBufferBuilder builder, int gameClientGmPort)
		{
			builder.AddInt(1, gameClientGmPort, 0);
		}

		// Token: 0x0601C987 RID: 117127 RVA: 0x0040AD85 File Offset: 0x00408F85
		public static void AddP4Proxy(FlatBufferBuilder builder, Offset<IConnectionIpEndPoint> p4ProxyOffset)
		{
			builder.AddOffset(2, p4ProxyOffset.Value, 0);
		}

		// Token: 0x0601C988 RID: 117128 RVA: 0x0040AD95 File Offset: 0x00408F95
		public static void AddGameServerConfig(FlatBufferBuilder builder, Offset<IGameServerConnectionConfig> gameServerConfigOffset)
		{
			builder.AddOffset(3, gameServerConfigOffset.Value, 0);
		}

		// Token: 0x0601C989 RID: 117129 RVA: 0x0040ADA5 File Offset: 0x00408FA5
		public static Offset<IConnectionGroup> EndIConnectionGroup(FlatBufferBuilder builder)
		{
			return new Offset<IConnectionGroup>(builder.EndTable());
		}

		// Token: 0x0601C98A RID: 117130 RVA: 0x0040ADB4 File Offset: 0x00408FB4
		public IConnectionGroupT UnPack()
		{
			IConnectionGroupT connectionGroupT = new IConnectionGroupT();
			this.UnPackTo(connectionGroupT);
			return connectionGroupT;
		}

		// Token: 0x0601C98B RID: 117131 RVA: 0x0040ADD0 File Offset: 0x00408FD0
		public void UnPackTo(IConnectionGroupT _o)
		{
			_o.EditorPort = this.EditorPort;
			_o.GameClientGmPort = this.GameClientGmPort;
			_o.P4Proxy = ((this.P4Proxy != null) ? this.P4Proxy.Value.UnPack() : null);
			_o.GameServerConfig = ((this.GameServerConfig != null) ? this.GameServerConfig.Value.UnPack() : null);
		}

		// Token: 0x0601C98C RID: 117132 RVA: 0x0040AE54 File Offset: 0x00409054
		public static Offset<IConnectionGroup> Pack(FlatBufferBuilder builder, IConnectionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectionGroup>);
			}
			Offset<IConnectionIpEndPoint> p4ProxyOffset = (_o.P4Proxy == null) ? default(Offset<IConnectionIpEndPoint>) : IConnectionIpEndPoint.Pack(builder, _o.P4Proxy);
			Offset<IGameServerConnectionConfig> gameServerConfigOffset = (_o.GameServerConfig == null) ? default(Offset<IGameServerConnectionConfig>) : IGameServerConnectionConfig.Pack(builder, _o.GameServerConfig);
			return IConnectionGroup.CreateIConnectionGroup(builder, _o.EditorPort, _o.GameClientGmPort, p4ProxyOffset, gameServerConfigOffset);
		}

		// Token: 0x0400CD6B RID: 52587
		private Table __p;
	}
}
