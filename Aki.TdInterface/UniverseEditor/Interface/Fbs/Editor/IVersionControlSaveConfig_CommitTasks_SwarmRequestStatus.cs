using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D2A RID: 19754
	public struct IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus : IFlatbufferObject
	{
		// Token: 0x17008D83 RID: 36227
		// (get) Token: 0x0601E9E5 RID: 125413 RVA: 0x004493C5 File Offset: 0x004475C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E9E6 RID: 125414 RVA: 0x004493D2 File Offset: 0x004475D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E9E7 RID: 125415 RVA: 0x004493DC File Offset: 0x004475DC
		public static IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus GetRootAsIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(ByteBuffer _bb)
		{
			return IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.GetRootAsIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(_bb, default(IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus));
		}

		// Token: 0x0601E9E8 RID: 125416 RVA: 0x004493F8 File Offset: 0x004475F8
		public static IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus GetRootAsIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(ByteBuffer _bb, IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E9E9 RID: 125417 RVA: 0x00449415 File Offset: 0x00447615
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E9EA RID: 125418 RVA: 0x00449424 File Offset: 0x00447624
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D84 RID: 36228
		// (get) Token: 0x0601E9EB RID: 125419 RVA: 0x00449434 File Offset: 0x00447634
		public int SwarmState
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

		// Token: 0x17008D85 RID: 36229
		// (get) Token: 0x0601E9EC RID: 125420 RVA: 0x00449470 File Offset: 0x00447670
		public string SwarmRequestInvalidMsg
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

		// Token: 0x0601E9ED RID: 125421 RVA: 0x004494A7 File Offset: 0x004476A7
		public Span<byte> GetSwarmRequestInvalidMsgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E9EE RID: 125422 RVA: 0x004494B6 File Offset: 0x004476B6
		public byte[] GetSwarmRequestInvalidMsgArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601E9EF RID: 125423 RVA: 0x004494C4 File Offset: 0x004476C4
		public static Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> CreateIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(FlatBufferBuilder builder, int SwarmState = 0, StringOffset SwarmRequestInvalidMsgOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.AddSwarmRequestInvalidMsg(builder, SwarmRequestInvalidMsgOffset);
			IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.AddSwarmState(builder, SwarmState);
			return IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.EndIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(builder);
		}

		// Token: 0x0601E9F0 RID: 125424 RVA: 0x004494E1 File Offset: 0x004476E1
		public static void StartIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E9F1 RID: 125425 RVA: 0x004494EA File Offset: 0x004476EA
		public static void AddSwarmState(FlatBufferBuilder builder, int swarmState)
		{
			builder.AddInt(0, swarmState, 0);
		}

		// Token: 0x0601E9F2 RID: 125426 RVA: 0x004494F5 File Offset: 0x004476F5
		public static void AddSwarmRequestInvalidMsg(FlatBufferBuilder builder, StringOffset swarmRequestInvalidMsgOffset)
		{
			builder.AddOffset(1, swarmRequestInvalidMsgOffset.Value, 0);
		}

		// Token: 0x0601E9F3 RID: 125427 RVA: 0x00449505 File Offset: 0x00447705
		public static Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> EndIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(FlatBufferBuilder builder)
		{
			return new Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus>(builder.EndTable());
		}

		// Token: 0x0601E9F4 RID: 125428 RVA: 0x00449514 File Offset: 0x00447714
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT UnPack()
		{
			IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT versionControlSaveConfig_CommitTasks_SwarmRequestStatusT = new IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT();
			this.UnPackTo(versionControlSaveConfig_CommitTasks_SwarmRequestStatusT);
			return versionControlSaveConfig_CommitTasks_SwarmRequestStatusT;
		}

		// Token: 0x0601E9F5 RID: 125429 RVA: 0x0044952F File Offset: 0x0044772F
		public void UnPackTo(IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT _o)
		{
			_o.SwarmState = this.SwarmState;
			_o.SwarmRequestInvalidMsg = this.SwarmRequestInvalidMsg;
		}

		// Token: 0x0601E9F6 RID: 125430 RVA: 0x0044954C File Offset: 0x0044774C
		public static Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> Pack(FlatBufferBuilder builder, IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus>);
			}
			StringOffset swarmRequestInvalidMsgOffset = (_o.SwarmRequestInvalidMsg == null) ? default(StringOffset) : builder.CreateString(_o.SwarmRequestInvalidMsg);
			return IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.CreateIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(builder, _o.SwarmState, swarmRequestInvalidMsgOffset);
		}

		// Token: 0x0400D905 RID: 55557
		private Table __p;
	}
}
