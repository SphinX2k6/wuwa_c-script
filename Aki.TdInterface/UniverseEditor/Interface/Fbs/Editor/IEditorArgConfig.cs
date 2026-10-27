using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004856 RID: 18518
	public struct IEditorArgConfig : IFlatbufferObject
	{
		// Token: 0x170084FD RID: 34045
		// (get) Token: 0x0601CAA6 RID: 117414 RVA: 0x0040D65F File Offset: 0x0040B85F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CAA7 RID: 117415 RVA: 0x0040D66C File Offset: 0x0040B86C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CAA8 RID: 117416 RVA: 0x0040D674 File Offset: 0x0040B874
		public static IEditorArgConfig GetRootAsIEditorArgConfig(ByteBuffer _bb)
		{
			return IEditorArgConfig.GetRootAsIEditorArgConfig(_bb, default(IEditorArgConfig));
		}

		// Token: 0x0601CAA9 RID: 117417 RVA: 0x0040D690 File Offset: 0x0040B890
		public static IEditorArgConfig GetRootAsIEditorArgConfig(ByteBuffer _bb, IEditorArgConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CAAA RID: 117418 RVA: 0x0040D6AD File Offset: 0x0040B8AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CAAB RID: 117419 RVA: 0x0040D6BC File Offset: 0x0040B8BC
		public IEditorArgConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084FE RID: 34046
		// (get) Token: 0x0601CAAC RID: 117420 RVA: 0x0040D6CC File Offset: 0x0040B8CC
		public string ExecCmds
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

		// Token: 0x0601CAAD RID: 117421 RVA: 0x0040D703 File Offset: 0x0040B903
		public Span<byte> GetExecCmdsBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CAAE RID: 117422 RVA: 0x0040D712 File Offset: 0x0040B912
		public byte[] GetExecCmdsArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170084FF RID: 34047
		// (get) Token: 0x0601CAAF RID: 117423 RVA: 0x0040D720 File Offset: 0x0040B920
		public string LocalGameServerStartPort
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

		// Token: 0x0601CAB0 RID: 117424 RVA: 0x0040D757 File Offset: 0x0040B957
		public Span<byte> GetLocalGameServerStartPortBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CAB1 RID: 117425 RVA: 0x0040D766 File Offset: 0x0040B966
		public byte[] GetLocalGameServerStartPortArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008500 RID: 34048
		// (get) Token: 0x0601CAB2 RID: 117426 RVA: 0x0040D774 File Offset: 0x0040B974
		public string LocalGameServerNode
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

		// Token: 0x0601CAB3 RID: 117427 RVA: 0x0040D7AB File Offset: 0x0040B9AB
		public Span<byte> GetLocalGameServerNodeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601CAB4 RID: 117428 RVA: 0x0040D7BA File Offset: 0x0040B9BA
		public byte[] GetLocalGameServerNodeArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008501 RID: 34049
		// (get) Token: 0x0601CAB5 RID: 117429 RVA: 0x0040D7C8 File Offset: 0x0040B9C8
		public string TsEditorServicePort
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CAB6 RID: 117430 RVA: 0x0040D800 File Offset: 0x0040BA00
		public Span<byte> GetTsEditorServicePortBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601CAB7 RID: 117431 RVA: 0x0040D810 File Offset: 0x0040BA10
		public byte[] GetTsEditorServicePortArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008502 RID: 34050
		// (get) Token: 0x0601CAB8 RID: 117432 RVA: 0x0040D820 File Offset: 0x0040BA20
		public string IgnoreStartupCheck
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CAB9 RID: 117433 RVA: 0x0040D858 File Offset: 0x0040BA58
		public Span<byte> GetIgnoreStartupCheckBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601CABA RID: 117434 RVA: 0x0040D868 File Offset: 0x0040BA68
		public byte[] GetIgnoreStartupCheckArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008503 RID: 34051
		// (get) Token: 0x0601CABB RID: 117435 RVA: 0x0040D878 File Offset: 0x0040BA78
		public string DisablePopEditorSaviorOnError
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CABC RID: 117436 RVA: 0x0040D8B0 File Offset: 0x0040BAB0
		public Span<byte> GetDisablePopEditorSaviorOnErrorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601CABD RID: 117437 RVA: 0x0040D8C0 File Offset: 0x0040BAC0
		public byte[] GetDisablePopEditorSaviorOnErrorArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008504 RID: 34052
		// (get) Token: 0x0601CABE RID: 117438 RVA: 0x0040D8D0 File Offset: 0x0040BAD0
		public string DisableAutoStartServer
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CABF RID: 117439 RVA: 0x0040D908 File Offset: 0x0040BB08
		public Span<byte> GetDisableAutoStartServerBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601CAC0 RID: 117440 RVA: 0x0040D918 File Offset: 0x0040BB18
		public byte[] GetDisableAutoStartServerArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17008505 RID: 34053
		// (get) Token: 0x0601CAC1 RID: 117441 RVA: 0x0040D928 File Offset: 0x0040BB28
		public string UseTemp
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CAC2 RID: 117442 RVA: 0x0040D960 File Offset: 0x0040BB60
		public Span<byte> GetUseTempBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601CAC3 RID: 117443 RVA: 0x0040D970 File Offset: 0x0040BB70
		public byte[] GetUseTempArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x0601CAC4 RID: 117444 RVA: 0x0040D980 File Offset: 0x0040BB80
		public static Offset<IEditorArgConfig> CreateIEditorArgConfig(FlatBufferBuilder builder, StringOffset ExecCmdsOffset = default(StringOffset), StringOffset LocalGameServerStartPortOffset = default(StringOffset), StringOffset LocalGameServerNodeOffset = default(StringOffset), StringOffset TsEditorServicePortOffset = default(StringOffset), StringOffset IgnoreStartupCheckOffset = default(StringOffset), StringOffset DisablePopEditorSaviorOnErrorOffset = default(StringOffset), StringOffset DisableAutoStartServerOffset = default(StringOffset), StringOffset UseTempOffset = default(StringOffset))
		{
			builder.StartTable(8);
			IEditorArgConfig.AddUseTemp(builder, UseTempOffset);
			IEditorArgConfig.AddDisableAutoStartServer(builder, DisableAutoStartServerOffset);
			IEditorArgConfig.AddDisablePopEditorSaviorOnError(builder, DisablePopEditorSaviorOnErrorOffset);
			IEditorArgConfig.AddIgnoreStartupCheck(builder, IgnoreStartupCheckOffset);
			IEditorArgConfig.AddTsEditorServicePort(builder, TsEditorServicePortOffset);
			IEditorArgConfig.AddLocalGameServerNode(builder, LocalGameServerNodeOffset);
			IEditorArgConfig.AddLocalGameServerStartPort(builder, LocalGameServerStartPortOffset);
			IEditorArgConfig.AddExecCmds(builder, ExecCmdsOffset);
			return IEditorArgConfig.EndIEditorArgConfig(builder);
		}

		// Token: 0x0601CAC5 RID: 117445 RVA: 0x0040D9D7 File Offset: 0x0040BBD7
		public static void StartIEditorArgConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601CAC6 RID: 117446 RVA: 0x0040D9E0 File Offset: 0x0040BBE0
		public static void AddExecCmds(FlatBufferBuilder builder, StringOffset execCmdsOffset)
		{
			builder.AddOffset(0, execCmdsOffset.Value, 0);
		}

		// Token: 0x0601CAC7 RID: 117447 RVA: 0x0040D9F0 File Offset: 0x0040BBF0
		public static void AddLocalGameServerStartPort(FlatBufferBuilder builder, StringOffset localGameServerStartPortOffset)
		{
			builder.AddOffset(1, localGameServerStartPortOffset.Value, 0);
		}

		// Token: 0x0601CAC8 RID: 117448 RVA: 0x0040DA00 File Offset: 0x0040BC00
		public static void AddLocalGameServerNode(FlatBufferBuilder builder, StringOffset localGameServerNodeOffset)
		{
			builder.AddOffset(2, localGameServerNodeOffset.Value, 0);
		}

		// Token: 0x0601CAC9 RID: 117449 RVA: 0x0040DA10 File Offset: 0x0040BC10
		public static void AddTsEditorServicePort(FlatBufferBuilder builder, StringOffset tsEditorServicePortOffset)
		{
			builder.AddOffset(3, tsEditorServicePortOffset.Value, 0);
		}

		// Token: 0x0601CACA RID: 117450 RVA: 0x0040DA20 File Offset: 0x0040BC20
		public static void AddIgnoreStartupCheck(FlatBufferBuilder builder, StringOffset ignoreStartupCheckOffset)
		{
			builder.AddOffset(4, ignoreStartupCheckOffset.Value, 0);
		}

		// Token: 0x0601CACB RID: 117451 RVA: 0x0040DA30 File Offset: 0x0040BC30
		public static void AddDisablePopEditorSaviorOnError(FlatBufferBuilder builder, StringOffset disablePopEditorSaviorOnErrorOffset)
		{
			builder.AddOffset(5, disablePopEditorSaviorOnErrorOffset.Value, 0);
		}

		// Token: 0x0601CACC RID: 117452 RVA: 0x0040DA40 File Offset: 0x0040BC40
		public static void AddDisableAutoStartServer(FlatBufferBuilder builder, StringOffset disableAutoStartServerOffset)
		{
			builder.AddOffset(6, disableAutoStartServerOffset.Value, 0);
		}

		// Token: 0x0601CACD RID: 117453 RVA: 0x0040DA50 File Offset: 0x0040BC50
		public static void AddUseTemp(FlatBufferBuilder builder, StringOffset useTempOffset)
		{
			builder.AddOffset(7, useTempOffset.Value, 0);
		}

		// Token: 0x0601CACE RID: 117454 RVA: 0x0040DA60 File Offset: 0x0040BC60
		public static Offset<IEditorArgConfig> EndIEditorArgConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorArgConfig>(builder.EndTable());
		}

		// Token: 0x0601CACF RID: 117455 RVA: 0x0040DA70 File Offset: 0x0040BC70
		public IEditorArgConfigT UnPack()
		{
			IEditorArgConfigT editorArgConfigT = new IEditorArgConfigT();
			this.UnPackTo(editorArgConfigT);
			return editorArgConfigT;
		}

		// Token: 0x0601CAD0 RID: 117456 RVA: 0x0040DA8C File Offset: 0x0040BC8C
		public void UnPackTo(IEditorArgConfigT _o)
		{
			_o.ExecCmds = this.ExecCmds;
			_o.LocalGameServerStartPort = this.LocalGameServerStartPort;
			_o.LocalGameServerNode = this.LocalGameServerNode;
			_o.TsEditorServicePort = this.TsEditorServicePort;
			_o.IgnoreStartupCheck = this.IgnoreStartupCheck;
			_o.DisablePopEditorSaviorOnError = this.DisablePopEditorSaviorOnError;
			_o.DisableAutoStartServer = this.DisableAutoStartServer;
			_o.UseTemp = this.UseTemp;
		}

		// Token: 0x0601CAD1 RID: 117457 RVA: 0x0040DAFC File Offset: 0x0040BCFC
		public static Offset<IEditorArgConfig> Pack(FlatBufferBuilder builder, IEditorArgConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorArgConfig>);
			}
			StringOffset execCmdsOffset = (_o.ExecCmds == null) ? default(StringOffset) : builder.CreateString(_o.ExecCmds);
			StringOffset localGameServerStartPortOffset = (_o.LocalGameServerStartPort == null) ? default(StringOffset) : builder.CreateString(_o.LocalGameServerStartPort);
			StringOffset localGameServerNodeOffset = (_o.LocalGameServerNode == null) ? default(StringOffset) : builder.CreateString(_o.LocalGameServerNode);
			StringOffset tsEditorServicePortOffset = (_o.TsEditorServicePort == null) ? default(StringOffset) : builder.CreateString(_o.TsEditorServicePort);
			StringOffset ignoreStartupCheckOffset = (_o.IgnoreStartupCheck == null) ? default(StringOffset) : builder.CreateString(_o.IgnoreStartupCheck);
			StringOffset disablePopEditorSaviorOnErrorOffset = (_o.DisablePopEditorSaviorOnError == null) ? default(StringOffset) : builder.CreateString(_o.DisablePopEditorSaviorOnError);
			StringOffset disableAutoStartServerOffset = (_o.DisableAutoStartServer == null) ? default(StringOffset) : builder.CreateString(_o.DisableAutoStartServer);
			StringOffset useTempOffset = (_o.UseTemp == null) ? default(StringOffset) : builder.CreateString(_o.UseTemp);
			return IEditorArgConfig.CreateIEditorArgConfig(builder, execCmdsOffset, localGameServerStartPortOffset, localGameServerNodeOffset, tsEditorServicePortOffset, ignoreStartupCheckOffset, disablePopEditorSaviorOnErrorOffset, disableAutoStartServerOffset, useTempOffset);
		}

		// Token: 0x0400CD91 RID: 52625
		private Table __p;
	}
}
