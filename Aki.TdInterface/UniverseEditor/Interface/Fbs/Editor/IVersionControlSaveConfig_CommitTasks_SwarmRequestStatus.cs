using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C5 RID: 18629
	public struct IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus : IFlatbufferObject
	{
		// Token: 0x1700873B RID: 34619
		// (get) Token: 0x0601D1F8 RID: 119288 RVA: 0x0041CC29 File Offset: 0x0041AE29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D1F9 RID: 119289 RVA: 0x0041CC36 File Offset: 0x0041AE36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D1FA RID: 119290 RVA: 0x0041CC40 File Offset: 0x0041AE40
		public static IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus GetRootAsIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(ByteBuffer _bb)
		{
			return IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.GetRootAsIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(_bb, default(IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus));
		}

		// Token: 0x0601D1FB RID: 119291 RVA: 0x0041CC5C File Offset: 0x0041AE5C
		public static IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus GetRootAsIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(ByteBuffer _bb, IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D1FC RID: 119292 RVA: 0x0041CC79 File Offset: 0x0041AE79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D1FD RID: 119293 RVA: 0x0041CC88 File Offset: 0x0041AE88
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700873C RID: 34620
		// (get) Token: 0x0601D1FE RID: 119294 RVA: 0x0041CC98 File Offset: 0x0041AE98
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

		// Token: 0x1700873D RID: 34621
		// (get) Token: 0x0601D1FF RID: 119295 RVA: 0x0041CCD4 File Offset: 0x0041AED4
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

		// Token: 0x0601D200 RID: 119296 RVA: 0x0041CD0B File Offset: 0x0041AF0B
		public Span<byte> GetSwarmRequestInvalidMsgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D201 RID: 119297 RVA: 0x0041CD1A File Offset: 0x0041AF1A
		public byte[] GetSwarmRequestInvalidMsgArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D202 RID: 119298 RVA: 0x0041CD28 File Offset: 0x0041AF28
		public static Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> CreateIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(FlatBufferBuilder builder, int SwarmState = 0, StringOffset SwarmRequestInvalidMsgOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.AddSwarmRequestInvalidMsg(builder, SwarmRequestInvalidMsgOffset);
			IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.AddSwarmState(builder, SwarmState);
			return IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.EndIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(builder);
		}

		// Token: 0x0601D203 RID: 119299 RVA: 0x0041CD45 File Offset: 0x0041AF45
		public static void StartIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D204 RID: 119300 RVA: 0x0041CD4E File Offset: 0x0041AF4E
		public static void AddSwarmState(FlatBufferBuilder builder, int swarmState)
		{
			builder.AddInt(0, swarmState, 0);
		}

		// Token: 0x0601D205 RID: 119301 RVA: 0x0041CD59 File Offset: 0x0041AF59
		public static void AddSwarmRequestInvalidMsg(FlatBufferBuilder builder, StringOffset swarmRequestInvalidMsgOffset)
		{
			builder.AddOffset(1, swarmRequestInvalidMsgOffset.Value, 0);
		}

		// Token: 0x0601D206 RID: 119302 RVA: 0x0041CD69 File Offset: 0x0041AF69
		public static Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> EndIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(FlatBufferBuilder builder)
		{
			return new Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus>(builder.EndTable());
		}

		// Token: 0x0601D207 RID: 119303 RVA: 0x0041CD78 File Offset: 0x0041AF78
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT UnPack()
		{
			IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT versionControlSaveConfig_CommitTasks_SwarmRequestStatusT = new IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT();
			this.UnPackTo(versionControlSaveConfig_CommitTasks_SwarmRequestStatusT);
			return versionControlSaveConfig_CommitTasks_SwarmRequestStatusT;
		}

		// Token: 0x0601D208 RID: 119304 RVA: 0x0041CD93 File Offset: 0x0041AF93
		public void UnPackTo(IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT _o)
		{
			_o.SwarmState = this.SwarmState;
			_o.SwarmRequestInvalidMsg = this.SwarmRequestInvalidMsg;
		}

		// Token: 0x0601D209 RID: 119305 RVA: 0x0041CDB0 File Offset: 0x0041AFB0
		public static Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> Pack(FlatBufferBuilder builder, IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus>);
			}
			StringOffset swarmRequestInvalidMsgOffset = (_o.SwarmRequestInvalidMsg == null) ? default(StringOffset) : builder.CreateString(_o.SwarmRequestInvalidMsg);
			return IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.CreateIVersionControlSaveConfig_CommitTasks_SwarmRequestStatus(builder, _o.SwarmState, swarmRequestInvalidMsgOffset);
		}

		// Token: 0x0400CECC RID: 52940
		private Table __p;
	}
}
