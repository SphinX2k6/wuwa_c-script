using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C2 RID: 18626
	public struct IVersionControlSaveConfig_CommitTasks : IFlatbufferObject
	{
		// Token: 0x1700872A RID: 34602
		// (get) Token: 0x0601D1B8 RID: 119224 RVA: 0x0041C272 File Offset: 0x0041A472
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D1B9 RID: 119225 RVA: 0x0041C27F File Offset: 0x0041A47F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D1BA RID: 119226 RVA: 0x0041C288 File Offset: 0x0041A488
		public static IVersionControlSaveConfig_CommitTasks GetRootAsIVersionControlSaveConfig_CommitTasks(ByteBuffer _bb)
		{
			return IVersionControlSaveConfig_CommitTasks.GetRootAsIVersionControlSaveConfig_CommitTasks(_bb, default(IVersionControlSaveConfig_CommitTasks));
		}

		// Token: 0x0601D1BB RID: 119227 RVA: 0x0041C2A4 File Offset: 0x0041A4A4
		public static IVersionControlSaveConfig_CommitTasks GetRootAsIVersionControlSaveConfig_CommitTasks(ByteBuffer _bb, IVersionControlSaveConfig_CommitTasks obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D1BC RID: 119228 RVA: 0x0041C2C1 File Offset: 0x0041A4C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D1BD RID: 119229 RVA: 0x0041C2D0 File Offset: 0x0041A4D0
		public IVersionControlSaveConfig_CommitTasks __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700872B RID: 34603
		// (get) Token: 0x0601D1BE RID: 119230 RVA: 0x0041C2E0 File Offset: 0x0041A4E0
		public int SwarmId
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

		// Token: 0x1700872C RID: 34604
		// (get) Token: 0x0601D1BF RID: 119231 RVA: 0x0041C31C File Offset: 0x0041A51C
		public int ChangeListId
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

		// Token: 0x1700872D RID: 34605
		// (get) Token: 0x0601D1C0 RID: 119232 RVA: 0x0041C358 File Offset: 0x0041A558
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus? SwarmRequestStatus
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus?(default(IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D1C1 RID: 119233 RVA: 0x0041C3B8 File Offset: 0x0041A5B8
		public string SwarmPassDiffFiles(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700872E RID: 34606
		// (get) Token: 0x0601D1C2 RID: 119234 RVA: 0x0041C3F4 File Offset: 0x0041A5F4
		public int SwarmPassDiffFilesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601D1C3 RID: 119235 RVA: 0x0041C420 File Offset: 0x0041A620
		public string SwarmPassOccupiedFiles(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700872F RID: 34607
		// (get) Token: 0x0601D1C4 RID: 119236 RVA: 0x0041C45C File Offset: 0x0041A65C
		public int SwarmPassOccupiedFilesLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008730 RID: 34608
		// (get) Token: 0x0601D1C5 RID: 119237 RVA: 0x0041C488 File Offset: 0x0041A688
		public bool IsUpdatingSwarmPassFiles
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D1C6 RID: 119238 RVA: 0x0041C4C8 File Offset: 0x0041A6C8
		public string Files(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008731 RID: 34609
		// (get) Token: 0x0601D1C7 RID: 119239 RVA: 0x0041C504 File Offset: 0x0041A704
		public int FilesLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008732 RID: 34610
		// (get) Token: 0x0601D1C8 RID: 119240 RVA: 0x0041C530 File Offset: 0x0041A730
		public long Timestamp
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D1C9 RID: 119241 RVA: 0x0041C570 File Offset: 0x0041A770
		public static Offset<IVersionControlSaveConfig_CommitTasks> CreateIVersionControlSaveConfig_CommitTasks(FlatBufferBuilder builder, int SwarmId = 0, int ChangeListId = 0, Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> SwarmRequestStatusOffset = default(Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus>), VectorOffset SwarmPassDiffFilesOffset = default(VectorOffset), VectorOffset SwarmPassOccupiedFilesOffset = default(VectorOffset), bool IsUpdatingSwarmPassFiles = false, VectorOffset FilesOffset = default(VectorOffset), long Timestamp = 0L)
		{
			builder.StartTable(8);
			IVersionControlSaveConfig_CommitTasks.AddTimestamp(builder, Timestamp);
			IVersionControlSaveConfig_CommitTasks.AddFiles(builder, FilesOffset);
			IVersionControlSaveConfig_CommitTasks.AddSwarmPassOccupiedFiles(builder, SwarmPassOccupiedFilesOffset);
			IVersionControlSaveConfig_CommitTasks.AddSwarmPassDiffFiles(builder, SwarmPassDiffFilesOffset);
			IVersionControlSaveConfig_CommitTasks.AddSwarmRequestStatus(builder, SwarmRequestStatusOffset);
			IVersionControlSaveConfig_CommitTasks.AddChangeListId(builder, ChangeListId);
			IVersionControlSaveConfig_CommitTasks.AddSwarmId(builder, SwarmId);
			IVersionControlSaveConfig_CommitTasks.AddIsUpdatingSwarmPassFiles(builder, IsUpdatingSwarmPassFiles);
			return IVersionControlSaveConfig_CommitTasks.EndIVersionControlSaveConfig_CommitTasks(builder);
		}

		// Token: 0x0601D1CA RID: 119242 RVA: 0x0041C5C7 File Offset: 0x0041A7C7
		public static void StartIVersionControlSaveConfig_CommitTasks(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601D1CB RID: 119243 RVA: 0x0041C5D0 File Offset: 0x0041A7D0
		public static void AddSwarmId(FlatBufferBuilder builder, int swarmId)
		{
			builder.AddInt(0, swarmId, 0);
		}

		// Token: 0x0601D1CC RID: 119244 RVA: 0x0041C5DB File Offset: 0x0041A7DB
		public static void AddChangeListId(FlatBufferBuilder builder, int changeListId)
		{
			builder.AddInt(1, changeListId, 0);
		}

		// Token: 0x0601D1CD RID: 119245 RVA: 0x0041C5E6 File Offset: 0x0041A7E6
		public static void AddSwarmRequestStatus(FlatBufferBuilder builder, Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> swarmRequestStatusOffset)
		{
			builder.AddOffset(2, swarmRequestStatusOffset.Value, 0);
		}

		// Token: 0x0601D1CE RID: 119246 RVA: 0x0041C5F6 File Offset: 0x0041A7F6
		public static void AddSwarmPassDiffFiles(FlatBufferBuilder builder, VectorOffset swarmPassDiffFilesOffset)
		{
			builder.AddOffset(3, swarmPassDiffFilesOffset.Value, 0);
		}

		// Token: 0x0601D1CF RID: 119247 RVA: 0x0041C608 File Offset: 0x0041A808
		public static VectorOffset CreateSwarmPassDiffFilesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D1D0 RID: 119248 RVA: 0x0041C648 File Offset: 0x0041A848
		public static VectorOffset CreateSwarmPassDiffFilesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D1D1 RID: 119249 RVA: 0x0041C662 File Offset: 0x0041A862
		public static VectorOffset CreateSwarmPassDiffFilesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D1D2 RID: 119250 RVA: 0x0041C680 File Offset: 0x0041A880
		public static VectorOffset CreateSwarmPassDiffFilesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D1D3 RID: 119251 RVA: 0x0041C699 File Offset: 0x0041A899
		public static void StartSwarmPassDiffFilesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D1D4 RID: 119252 RVA: 0x0041C6A4 File Offset: 0x0041A8A4
		public static void AddSwarmPassOccupiedFiles(FlatBufferBuilder builder, VectorOffset swarmPassOccupiedFilesOffset)
		{
			builder.AddOffset(4, swarmPassOccupiedFilesOffset.Value, 0);
		}

		// Token: 0x0601D1D5 RID: 119253 RVA: 0x0041C6B4 File Offset: 0x0041A8B4
		public static VectorOffset CreateSwarmPassOccupiedFilesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D1D6 RID: 119254 RVA: 0x0041C6F4 File Offset: 0x0041A8F4
		public static VectorOffset CreateSwarmPassOccupiedFilesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D1D7 RID: 119255 RVA: 0x0041C70E File Offset: 0x0041A90E
		public static VectorOffset CreateSwarmPassOccupiedFilesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D1D8 RID: 119256 RVA: 0x0041C72C File Offset: 0x0041A92C
		public static VectorOffset CreateSwarmPassOccupiedFilesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D1D9 RID: 119257 RVA: 0x0041C745 File Offset: 0x0041A945
		public static void StartSwarmPassOccupiedFilesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D1DA RID: 119258 RVA: 0x0041C750 File Offset: 0x0041A950
		public static void AddIsUpdatingSwarmPassFiles(FlatBufferBuilder builder, bool isUpdatingSwarmPassFiles)
		{
			builder.AddBool(5, isUpdatingSwarmPassFiles, false);
		}

		// Token: 0x0601D1DB RID: 119259 RVA: 0x0041C75B File Offset: 0x0041A95B
		public static void AddFiles(FlatBufferBuilder builder, VectorOffset filesOffset)
		{
			builder.AddOffset(6, filesOffset.Value, 0);
		}

		// Token: 0x0601D1DC RID: 119260 RVA: 0x0041C76C File Offset: 0x0041A96C
		public static VectorOffset CreateFilesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D1DD RID: 119261 RVA: 0x0041C7AC File Offset: 0x0041A9AC
		public static VectorOffset CreateFilesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D1DE RID: 119262 RVA: 0x0041C7C6 File Offset: 0x0041A9C6
		public static VectorOffset CreateFilesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D1DF RID: 119263 RVA: 0x0041C7E4 File Offset: 0x0041A9E4
		public static VectorOffset CreateFilesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D1E0 RID: 119264 RVA: 0x0041C7FD File Offset: 0x0041A9FD
		public static void StartFilesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D1E1 RID: 119265 RVA: 0x0041C808 File Offset: 0x0041AA08
		public static void AddTimestamp(FlatBufferBuilder builder, long timestamp)
		{
			builder.AddLong(7, timestamp, 0L);
		}

		// Token: 0x0601D1E2 RID: 119266 RVA: 0x0041C814 File Offset: 0x0041AA14
		public static Offset<IVersionControlSaveConfig_CommitTasks> EndIVersionControlSaveConfig_CommitTasks(FlatBufferBuilder builder)
		{
			return new Offset<IVersionControlSaveConfig_CommitTasks>(builder.EndTable());
		}

		// Token: 0x0601D1E3 RID: 119267 RVA: 0x0041C824 File Offset: 0x0041AA24
		public IVersionControlSaveConfig_CommitTasksT UnPack()
		{
			IVersionControlSaveConfig_CommitTasksT versionControlSaveConfig_CommitTasksT = new IVersionControlSaveConfig_CommitTasksT();
			this.UnPackTo(versionControlSaveConfig_CommitTasksT);
			return versionControlSaveConfig_CommitTasksT;
		}

		// Token: 0x0601D1E4 RID: 119268 RVA: 0x0041C840 File Offset: 0x0041AA40
		public void UnPackTo(IVersionControlSaveConfig_CommitTasksT _o)
		{
			_o.SwarmId = this.SwarmId;
			_o.ChangeListId = this.ChangeListId;
			_o.SwarmRequestStatus = ((this.SwarmRequestStatus != null) ? this.SwarmRequestStatus.Value.UnPack() : null);
			_o.SwarmPassDiffFiles = new List<string>();
			for (int i = 0; i < this.SwarmPassDiffFilesLength; i++)
			{
				_o.SwarmPassDiffFiles.Add(this.SwarmPassDiffFiles(i));
			}
			_o.SwarmPassOccupiedFiles = new List<string>();
			for (int j = 0; j < this.SwarmPassOccupiedFilesLength; j++)
			{
				_o.SwarmPassOccupiedFiles.Add(this.SwarmPassOccupiedFiles(j));
			}
			_o.IsUpdatingSwarmPassFiles = this.IsUpdatingSwarmPassFiles;
			_o.Files = new List<string>();
			for (int k = 0; k < this.FilesLength; k++)
			{
				_o.Files.Add(this.Files(k));
			}
			_o.Timestamp = this.Timestamp;
		}

		// Token: 0x0601D1E5 RID: 119269 RVA: 0x0041C93C File Offset: 0x0041AB3C
		public static Offset<IVersionControlSaveConfig_CommitTasks> Pack(FlatBufferBuilder builder, IVersionControlSaveConfig_CommitTasksT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVersionControlSaveConfig_CommitTasks>);
			}
			Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> swarmRequestStatusOffset = (_o.SwarmRequestStatus == null) ? default(Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus>) : IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus.Pack(builder, _o.SwarmRequestStatus);
			VectorOffset swarmPassDiffFilesOffset = default(VectorOffset);
			if (_o.SwarmPassDiffFiles != null)
			{
				StringOffset[] array = new StringOffset[_o.SwarmPassDiffFiles.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.SwarmPassDiffFiles[i]);
				}
				swarmPassDiffFilesOffset = IVersionControlSaveConfig_CommitTasks.CreateSwarmPassDiffFilesVector(builder, array);
			}
			VectorOffset swarmPassOccupiedFilesOffset = default(VectorOffset);
			if (_o.SwarmPassOccupiedFiles != null)
			{
				StringOffset[] array2 = new StringOffset[_o.SwarmPassOccupiedFiles.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.SwarmPassOccupiedFiles[j]);
				}
				swarmPassOccupiedFilesOffset = IVersionControlSaveConfig_CommitTasks.CreateSwarmPassOccupiedFilesVector(builder, array2);
			}
			VectorOffset filesOffset = default(VectorOffset);
			if (_o.Files != null)
			{
				StringOffset[] array3 = new StringOffset[_o.Files.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.Files[k]);
				}
				filesOffset = IVersionControlSaveConfig_CommitTasks.CreateFilesVector(builder, array3);
			}
			return IVersionControlSaveConfig_CommitTasks.CreateIVersionControlSaveConfig_CommitTasks(builder, _o.SwarmId, _o.ChangeListId, swarmRequestStatusOffset, swarmPassDiffFilesOffset, swarmPassOccupiedFilesOffset, _o.IsUpdatingSwarmPassFiles, filesOffset, _o.Timestamp);
		}

		// Token: 0x0400CEC3 RID: 52931
		private Table __p;
	}
}
