using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CBE RID: 19646
	public struct IEditorArgConfig : IFlatbufferObject
	{
		// Token: 0x17008B48 RID: 35656
		// (get) Token: 0x0601E2A3 RID: 123555 RVA: 0x00439FAF File Offset: 0x004381AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E2A4 RID: 123556 RVA: 0x00439FBC File Offset: 0x004381BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E2A5 RID: 123557 RVA: 0x00439FC4 File Offset: 0x004381C4
		public static IEditorArgConfig GetRootAsIEditorArgConfig(ByteBuffer _bb)
		{
			return IEditorArgConfig.GetRootAsIEditorArgConfig(_bb, default(IEditorArgConfig));
		}

		// Token: 0x0601E2A6 RID: 123558 RVA: 0x00439FE0 File Offset: 0x004381E0
		public static IEditorArgConfig GetRootAsIEditorArgConfig(ByteBuffer _bb, IEditorArgConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E2A7 RID: 123559 RVA: 0x00439FFD File Offset: 0x004381FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E2A8 RID: 123560 RVA: 0x0043A00C File Offset: 0x0043820C
		public IEditorArgConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B49 RID: 35657
		// (get) Token: 0x0601E2A9 RID: 123561 RVA: 0x0043A01C File Offset: 0x0043821C
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

		// Token: 0x0601E2AA RID: 123562 RVA: 0x0043A053 File Offset: 0x00438253
		public Span<byte> GetExecCmdsBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E2AB RID: 123563 RVA: 0x0043A062 File Offset: 0x00438262
		public byte[] GetExecCmdsArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008B4A RID: 35658
		// (get) Token: 0x0601E2AC RID: 123564 RVA: 0x0043A070 File Offset: 0x00438270
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

		// Token: 0x0601E2AD RID: 123565 RVA: 0x0043A0A7 File Offset: 0x004382A7
		public Span<byte> GetLocalGameServerStartPortBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E2AE RID: 123566 RVA: 0x0043A0B6 File Offset: 0x004382B6
		public byte[] GetLocalGameServerStartPortArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008B4B RID: 35659
		// (get) Token: 0x0601E2AF RID: 123567 RVA: 0x0043A0C4 File Offset: 0x004382C4
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

		// Token: 0x0601E2B0 RID: 123568 RVA: 0x0043A0FB File Offset: 0x004382FB
		public Span<byte> GetLocalGameServerNodeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E2B1 RID: 123569 RVA: 0x0043A10A File Offset: 0x0043830A
		public byte[] GetLocalGameServerNodeArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008B4C RID: 35660
		// (get) Token: 0x0601E2B2 RID: 123570 RVA: 0x0043A118 File Offset: 0x00438318
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

		// Token: 0x0601E2B3 RID: 123571 RVA: 0x0043A150 File Offset: 0x00438350
		public Span<byte> GetTsEditorServicePortBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601E2B4 RID: 123572 RVA: 0x0043A160 File Offset: 0x00438360
		public byte[] GetTsEditorServicePortArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008B4D RID: 35661
		// (get) Token: 0x0601E2B5 RID: 123573 RVA: 0x0043A170 File Offset: 0x00438370
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

		// Token: 0x0601E2B6 RID: 123574 RVA: 0x0043A1A8 File Offset: 0x004383A8
		public Span<byte> GetIgnoreStartupCheckBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601E2B7 RID: 123575 RVA: 0x0043A1B8 File Offset: 0x004383B8
		public byte[] GetIgnoreStartupCheckArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008B4E RID: 35662
		// (get) Token: 0x0601E2B8 RID: 123576 RVA: 0x0043A1C8 File Offset: 0x004383C8
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

		// Token: 0x0601E2B9 RID: 123577 RVA: 0x0043A200 File Offset: 0x00438400
		public Span<byte> GetDisablePopEditorSaviorOnErrorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601E2BA RID: 123578 RVA: 0x0043A210 File Offset: 0x00438410
		public byte[] GetDisablePopEditorSaviorOnErrorArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008B4F RID: 35663
		// (get) Token: 0x0601E2BB RID: 123579 RVA: 0x0043A220 File Offset: 0x00438420
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

		// Token: 0x0601E2BC RID: 123580 RVA: 0x0043A258 File Offset: 0x00438458
		public Span<byte> GetDisableAutoStartServerBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601E2BD RID: 123581 RVA: 0x0043A268 File Offset: 0x00438468
		public byte[] GetDisableAutoStartServerArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17008B50 RID: 35664
		// (get) Token: 0x0601E2BE RID: 123582 RVA: 0x0043A278 File Offset: 0x00438478
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

		// Token: 0x0601E2BF RID: 123583 RVA: 0x0043A2B0 File Offset: 0x004384B0
		public Span<byte> GetUseTempBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601E2C0 RID: 123584 RVA: 0x0043A2C0 File Offset: 0x004384C0
		public byte[] GetUseTempArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008B51 RID: 35665
		// (get) Token: 0x0601E2C1 RID: 123585 RVA: 0x0043A2D0 File Offset: 0x004384D0
		public string PipelineServerLogStamp
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E2C2 RID: 123586 RVA: 0x0043A308 File Offset: 0x00438508
		public Span<byte> GetPipelineServerLogStampBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601E2C3 RID: 123587 RVA: 0x0043A318 File Offset: 0x00438518
		public byte[] GetPipelineServerLogStampArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x0601E2C4 RID: 123588 RVA: 0x0043A328 File Offset: 0x00438528
		public static Offset<IEditorArgConfig> CreateIEditorArgConfig(FlatBufferBuilder builder, StringOffset ExecCmdsOffset = default(StringOffset), StringOffset LocalGameServerStartPortOffset = default(StringOffset), StringOffset LocalGameServerNodeOffset = default(StringOffset), StringOffset TsEditorServicePortOffset = default(StringOffset), StringOffset IgnoreStartupCheckOffset = default(StringOffset), StringOffset DisablePopEditorSaviorOnErrorOffset = default(StringOffset), StringOffset DisableAutoStartServerOffset = default(StringOffset), StringOffset UseTempOffset = default(StringOffset), StringOffset PipelineServerLogStampOffset = default(StringOffset))
		{
			builder.StartTable(9);
			IEditorArgConfig.AddPipelineServerLogStamp(builder, PipelineServerLogStampOffset);
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

		// Token: 0x0601E2C5 RID: 123589 RVA: 0x0043A388 File Offset: 0x00438588
		public static void StartIEditorArgConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601E2C6 RID: 123590 RVA: 0x0043A392 File Offset: 0x00438592
		public static void AddExecCmds(FlatBufferBuilder builder, StringOffset execCmdsOffset)
		{
			builder.AddOffset(0, execCmdsOffset.Value, 0);
		}

		// Token: 0x0601E2C7 RID: 123591 RVA: 0x0043A3A2 File Offset: 0x004385A2
		public static void AddLocalGameServerStartPort(FlatBufferBuilder builder, StringOffset localGameServerStartPortOffset)
		{
			builder.AddOffset(1, localGameServerStartPortOffset.Value, 0);
		}

		// Token: 0x0601E2C8 RID: 123592 RVA: 0x0043A3B2 File Offset: 0x004385B2
		public static void AddLocalGameServerNode(FlatBufferBuilder builder, StringOffset localGameServerNodeOffset)
		{
			builder.AddOffset(2, localGameServerNodeOffset.Value, 0);
		}

		// Token: 0x0601E2C9 RID: 123593 RVA: 0x0043A3C2 File Offset: 0x004385C2
		public static void AddTsEditorServicePort(FlatBufferBuilder builder, StringOffset tsEditorServicePortOffset)
		{
			builder.AddOffset(3, tsEditorServicePortOffset.Value, 0);
		}

		// Token: 0x0601E2CA RID: 123594 RVA: 0x0043A3D2 File Offset: 0x004385D2
		public static void AddIgnoreStartupCheck(FlatBufferBuilder builder, StringOffset ignoreStartupCheckOffset)
		{
			builder.AddOffset(4, ignoreStartupCheckOffset.Value, 0);
		}

		// Token: 0x0601E2CB RID: 123595 RVA: 0x0043A3E2 File Offset: 0x004385E2
		public static void AddDisablePopEditorSaviorOnError(FlatBufferBuilder builder, StringOffset disablePopEditorSaviorOnErrorOffset)
		{
			builder.AddOffset(5, disablePopEditorSaviorOnErrorOffset.Value, 0);
		}

		// Token: 0x0601E2CC RID: 123596 RVA: 0x0043A3F2 File Offset: 0x004385F2
		public static void AddDisableAutoStartServer(FlatBufferBuilder builder, StringOffset disableAutoStartServerOffset)
		{
			builder.AddOffset(6, disableAutoStartServerOffset.Value, 0);
		}

		// Token: 0x0601E2CD RID: 123597 RVA: 0x0043A402 File Offset: 0x00438602
		public static void AddUseTemp(FlatBufferBuilder builder, StringOffset useTempOffset)
		{
			builder.AddOffset(7, useTempOffset.Value, 0);
		}

		// Token: 0x0601E2CE RID: 123598 RVA: 0x0043A412 File Offset: 0x00438612
		public static void AddPipelineServerLogStamp(FlatBufferBuilder builder, StringOffset pipelineServerLogStampOffset)
		{
			builder.AddOffset(8, pipelineServerLogStampOffset.Value, 0);
		}

		// Token: 0x0601E2CF RID: 123599 RVA: 0x0043A422 File Offset: 0x00438622
		public static Offset<IEditorArgConfig> EndIEditorArgConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorArgConfig>(builder.EndTable());
		}

		// Token: 0x0601E2D0 RID: 123600 RVA: 0x0043A430 File Offset: 0x00438630
		public IEditorArgConfigT UnPack()
		{
			IEditorArgConfigT editorArgConfigT = new IEditorArgConfigT();
			this.UnPackTo(editorArgConfigT);
			return editorArgConfigT;
		}

		// Token: 0x0601E2D1 RID: 123601 RVA: 0x0043A44C File Offset: 0x0043864C
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
			_o.PipelineServerLogStamp = this.PipelineServerLogStamp;
		}

		// Token: 0x0601E2D2 RID: 123602 RVA: 0x0043A4C8 File Offset: 0x004386C8
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
			StringOffset pipelineServerLogStampOffset = (_o.PipelineServerLogStamp == null) ? default(StringOffset) : builder.CreateString(_o.PipelineServerLogStamp);
			return IEditorArgConfig.CreateIEditorArgConfig(builder, execCmdsOffset, localGameServerStartPortOffset, localGameServerNodeOffset, tsEditorServicePortOffset, ignoreStartupCheckOffset, disablePopEditorSaviorOnErrorOffset, disableAutoStartServerOffset, useTempOffset, pipelineServerLogStampOffset);
		}

		// Token: 0x0400D7CC RID: 55244
		private Table __p;
	}
}
