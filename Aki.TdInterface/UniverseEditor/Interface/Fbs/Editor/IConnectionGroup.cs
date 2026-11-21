using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CA6 RID: 19622
	public struct IConnectionGroup : IFlatbufferObject
	{
		// Token: 0x17008B03 RID: 35587
		// (get) Token: 0x0601E176 RID: 123254 RVA: 0x004374E8 File Offset: 0x004356E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E177 RID: 123255 RVA: 0x004374F5 File Offset: 0x004356F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E178 RID: 123256 RVA: 0x004374FC File Offset: 0x004356FC
		public static IConnectionGroup GetRootAsIConnectionGroup(ByteBuffer _bb)
		{
			return IConnectionGroup.GetRootAsIConnectionGroup(_bb, default(IConnectionGroup));
		}

		// Token: 0x0601E179 RID: 123257 RVA: 0x00437518 File Offset: 0x00435718
		public static IConnectionGroup GetRootAsIConnectionGroup(ByteBuffer _bb, IConnectionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E17A RID: 123258 RVA: 0x00437535 File Offset: 0x00435735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E17B RID: 123259 RVA: 0x00437544 File Offset: 0x00435744
		public IConnectionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B04 RID: 35588
		// (get) Token: 0x0601E17C RID: 123260 RVA: 0x00437554 File Offset: 0x00435754
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

		// Token: 0x17008B05 RID: 35589
		// (get) Token: 0x0601E17D RID: 123261 RVA: 0x00437590 File Offset: 0x00435790
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

		// Token: 0x17008B06 RID: 35590
		// (get) Token: 0x0601E17E RID: 123262 RVA: 0x004375CC File Offset: 0x004357CC
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

		// Token: 0x17008B07 RID: 35591
		// (get) Token: 0x0601E17F RID: 123263 RVA: 0x0043762C File Offset: 0x0043582C
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

		// Token: 0x0601E180 RID: 123264 RVA: 0x0043768A File Offset: 0x0043588A
		public static Offset<IConnectionGroup> CreateIConnectionGroup(FlatBufferBuilder builder, int EditorPort = 0, int GameClientGmPort = 0, Offset<IConnectionIpEndPoint> P4ProxyOffset = default(Offset<IConnectionIpEndPoint>), Offset<IGameServerConnectionConfig> GameServerConfigOffset = default(Offset<IGameServerConnectionConfig>))
		{
			builder.StartTable(4);
			IConnectionGroup.AddGameServerConfig(builder, GameServerConfigOffset);
			IConnectionGroup.AddP4Proxy(builder, P4ProxyOffset);
			IConnectionGroup.AddGameClientGmPort(builder, GameClientGmPort);
			IConnectionGroup.AddEditorPort(builder, EditorPort);
			return IConnectionGroup.EndIConnectionGroup(builder);
		}

		// Token: 0x0601E181 RID: 123265 RVA: 0x004376B6 File Offset: 0x004358B6
		public static void StartIConnectionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E182 RID: 123266 RVA: 0x004376BF File Offset: 0x004358BF
		public static void AddEditorPort(FlatBufferBuilder builder, int editorPort)
		{
			builder.AddInt(0, editorPort, 0);
		}

		// Token: 0x0601E183 RID: 123267 RVA: 0x004376CA File Offset: 0x004358CA
		public static void AddGameClientGmPort(FlatBufferBuilder builder, int gameClientGmPort)
		{
			builder.AddInt(1, gameClientGmPort, 0);
		}

		// Token: 0x0601E184 RID: 123268 RVA: 0x004376D5 File Offset: 0x004358D5
		public static void AddP4Proxy(FlatBufferBuilder builder, Offset<IConnectionIpEndPoint> p4ProxyOffset)
		{
			builder.AddOffset(2, p4ProxyOffset.Value, 0);
		}

		// Token: 0x0601E185 RID: 123269 RVA: 0x004376E5 File Offset: 0x004358E5
		public static void AddGameServerConfig(FlatBufferBuilder builder, Offset<IGameServerConnectionConfig> gameServerConfigOffset)
		{
			builder.AddOffset(3, gameServerConfigOffset.Value, 0);
		}

		// Token: 0x0601E186 RID: 123270 RVA: 0x004376F5 File Offset: 0x004358F5
		public static Offset<IConnectionGroup> EndIConnectionGroup(FlatBufferBuilder builder)
		{
			return new Offset<IConnectionGroup>(builder.EndTable());
		}

		// Token: 0x0601E187 RID: 123271 RVA: 0x00437704 File Offset: 0x00435904
		public IConnectionGroupT UnPack()
		{
			IConnectionGroupT connectionGroupT = new IConnectionGroupT();
			this.UnPackTo(connectionGroupT);
			return connectionGroupT;
		}

		// Token: 0x0601E188 RID: 123272 RVA: 0x00437720 File Offset: 0x00435920
		public void UnPackTo(IConnectionGroupT _o)
		{
			_o.EditorPort = this.EditorPort;
			_o.GameClientGmPort = this.GameClientGmPort;
			_o.P4Proxy = ((this.P4Proxy != null) ? this.P4Proxy.Value.UnPack() : null);
			_o.GameServerConfig = ((this.GameServerConfig != null) ? this.GameServerConfig.Value.UnPack() : null);
		}

		// Token: 0x0601E189 RID: 123273 RVA: 0x004377A4 File Offset: 0x004359A4
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

		// Token: 0x0400D7A6 RID: 55206
		private Table __p;
	}
}
