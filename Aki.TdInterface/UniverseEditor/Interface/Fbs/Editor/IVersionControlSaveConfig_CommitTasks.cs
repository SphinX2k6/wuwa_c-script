using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D27 RID: 19751
	public struct IVersionControlSaveConfig_CommitTasks : IFlatbufferObject
	{
		// Token: 0x17008D72 RID: 36210
		// (get) Token: 0x0601E9A5 RID: 125349 RVA: 0x00448A0E File Offset: 0x00446C0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E9A6 RID: 125350 RVA: 0x00448A1B File Offset: 0x00446C1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E9A7 RID: 125351 RVA: 0x00448A24 File Offset: 0x00446C24
		public static IVersionControlSaveConfig_CommitTasks GetRootAsIVersionControlSaveConfig_CommitTasks(ByteBuffer _bb)
		{
			return IVersionControlSaveConfig_CommitTasks.GetRootAsIVersionControlSaveConfig_CommitTasks(_bb, default(IVersionControlSaveConfig_CommitTasks));
		}

		// Token: 0x0601E9A8 RID: 125352 RVA: 0x00448A40 File Offset: 0x00446C40
		public static IVersionControlSaveConfig_CommitTasks GetRootAsIVersionControlSaveConfig_CommitTasks(ByteBuffer _bb, IVersionControlSaveConfig_CommitTasks obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E9A9 RID: 125353 RVA: 0x00448A5D File Offset: 0x00446C5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E9AA RID: 125354 RVA: 0x00448A6C File Offset: 0x00446C6C
		public IVersionControlSaveConfig_CommitTasks __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D73 RID: 36211
		// (get) Token: 0x0601E9AB RID: 125355 RVA: 0x00448A7C File Offset: 0x00446C7C
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

		// Token: 0x17008D74 RID: 36212
		// (get) Token: 0x0601E9AC RID: 125356 RVA: 0x00448AB8 File Offset: 0x00446CB8
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

		// Token: 0x17008D75 RID: 36213
		// (get) Token: 0x0601E9AD RID: 125357 RVA: 0x00448AF4 File Offset: 0x00446CF4
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

		// Token: 0x0601E9AE RID: 125358 RVA: 0x00448B54 File Offset: 0x00446D54
		public string SwarmPassDiffFiles(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008D76 RID: 36214
		// (get) Token: 0x0601E9AF RID: 125359 RVA: 0x00448B90 File Offset: 0x00446D90
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

		// Token: 0x0601E9B0 RID: 125360 RVA: 0x00448BBC File Offset: 0x00446DBC
		public string SwarmPassOccupiedFiles(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008D77 RID: 36215
		// (get) Token: 0x0601E9B1 RID: 125361 RVA: 0x00448BF8 File Offset: 0x00446DF8
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

		// Token: 0x17008D78 RID: 36216
		// (get) Token: 0x0601E9B2 RID: 125362 RVA: 0x00448C24 File Offset: 0x00446E24
		public bool IsUpdatingSwarmPassFiles
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E9B3 RID: 125363 RVA: 0x00448C64 File Offset: 0x00446E64
		public string Files(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008D79 RID: 36217
		// (get) Token: 0x0601E9B4 RID: 125364 RVA: 0x00448CA0 File Offset: 0x00446EA0
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

		// Token: 0x17008D7A RID: 36218
		// (get) Token: 0x0601E9B5 RID: 125365 RVA: 0x00448CCC File Offset: 0x00446ECC
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

		// Token: 0x0601E9B6 RID: 125366 RVA: 0x00448D0C File Offset: 0x00446F0C
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

		// Token: 0x0601E9B7 RID: 125367 RVA: 0x00448D63 File Offset: 0x00446F63
		public static void StartIVersionControlSaveConfig_CommitTasks(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601E9B8 RID: 125368 RVA: 0x00448D6C File Offset: 0x00446F6C
		public static void AddSwarmId(FlatBufferBuilder builder, int swarmId)
		{
			builder.AddInt(0, swarmId, 0);
		}

		// Token: 0x0601E9B9 RID: 125369 RVA: 0x00448D77 File Offset: 0x00446F77
		public static void AddChangeListId(FlatBufferBuilder builder, int changeListId)
		{
			builder.AddInt(1, changeListId, 0);
		}

		// Token: 0x0601E9BA RID: 125370 RVA: 0x00448D82 File Offset: 0x00446F82
		public static void AddSwarmRequestStatus(FlatBufferBuilder builder, Offset<IVersionControlSaveConfig_CommitTasks_SwarmRequestStatus> swarmRequestStatusOffset)
		{
			builder.AddOffset(2, swarmRequestStatusOffset.Value, 0);
		}

		// Token: 0x0601E9BB RID: 125371 RVA: 0x00448D92 File Offset: 0x00446F92
		public static void AddSwarmPassDiffFiles(FlatBufferBuilder builder, VectorOffset swarmPassDiffFilesOffset)
		{
			builder.AddOffset(3, swarmPassDiffFilesOffset.Value, 0);
		}

		// Token: 0x0601E9BC RID: 125372 RVA: 0x00448DA4 File Offset: 0x00446FA4
		public static VectorOffset CreateSwarmPassDiffFilesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E9BD RID: 125373 RVA: 0x00448DE4 File Offset: 0x00446FE4
		public static VectorOffset CreateSwarmPassDiffFilesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E9BE RID: 125374 RVA: 0x00448DFE File Offset: 0x00446FFE
		public static VectorOffset CreateSwarmPassDiffFilesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E9BF RID: 125375 RVA: 0x00448E1C File Offset: 0x0044701C
		public static VectorOffset CreateSwarmPassDiffFilesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E9C0 RID: 125376 RVA: 0x00448E35 File Offset: 0x00447035
		public static void StartSwarmPassDiffFilesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E9C1 RID: 125377 RVA: 0x00448E40 File Offset: 0x00447040
		public static void AddSwarmPassOccupiedFiles(FlatBufferBuilder builder, VectorOffset swarmPassOccupiedFilesOffset)
		{
			builder.AddOffset(4, swarmPassOccupiedFilesOffset.Value, 0);
		}

		// Token: 0x0601E9C2 RID: 125378 RVA: 0x00448E50 File Offset: 0x00447050
		public static VectorOffset CreateSwarmPassOccupiedFilesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E9C3 RID: 125379 RVA: 0x00448E90 File Offset: 0x00447090
		public static VectorOffset CreateSwarmPassOccupiedFilesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E9C4 RID: 125380 RVA: 0x00448EAA File Offset: 0x004470AA
		public static VectorOffset CreateSwarmPassOccupiedFilesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E9C5 RID: 125381 RVA: 0x00448EC8 File Offset: 0x004470C8
		public static VectorOffset CreateSwarmPassOccupiedFilesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E9C6 RID: 125382 RVA: 0x00448EE1 File Offset: 0x004470E1
		public static void StartSwarmPassOccupiedFilesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E9C7 RID: 125383 RVA: 0x00448EEC File Offset: 0x004470EC
		public static void AddIsUpdatingSwarmPassFiles(FlatBufferBuilder builder, bool isUpdatingSwarmPassFiles)
		{
			builder.AddBool(5, isUpdatingSwarmPassFiles, false);
		}

		// Token: 0x0601E9C8 RID: 125384 RVA: 0x00448EF7 File Offset: 0x004470F7
		public static void AddFiles(FlatBufferBuilder builder, VectorOffset filesOffset)
		{
			builder.AddOffset(6, filesOffset.Value, 0);
		}

		// Token: 0x0601E9C9 RID: 125385 RVA: 0x00448F08 File Offset: 0x00447108
		public static VectorOffset CreateFilesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E9CA RID: 125386 RVA: 0x00448F48 File Offset: 0x00447148
		public static VectorOffset CreateFilesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E9CB RID: 125387 RVA: 0x00448F62 File Offset: 0x00447162
		public static VectorOffset CreateFilesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E9CC RID: 125388 RVA: 0x00448F80 File Offset: 0x00447180
		public static VectorOffset CreateFilesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E9CD RID: 125389 RVA: 0x00448F99 File Offset: 0x00447199
		public static void StartFilesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E9CE RID: 125390 RVA: 0x00448FA4 File Offset: 0x004471A4
		public static void AddTimestamp(FlatBufferBuilder builder, long timestamp)
		{
			builder.AddLong(7, timestamp, 0L);
		}

		// Token: 0x0601E9CF RID: 125391 RVA: 0x00448FB0 File Offset: 0x004471B0
		public static Offset<IVersionControlSaveConfig_CommitTasks> EndIVersionControlSaveConfig_CommitTasks(FlatBufferBuilder builder)
		{
			return new Offset<IVersionControlSaveConfig_CommitTasks>(builder.EndTable());
		}

		// Token: 0x0601E9D0 RID: 125392 RVA: 0x00448FC0 File Offset: 0x004471C0
		public IVersionControlSaveConfig_CommitTasksT UnPack()
		{
			IVersionControlSaveConfig_CommitTasksT versionControlSaveConfig_CommitTasksT = new IVersionControlSaveConfig_CommitTasksT();
			this.UnPackTo(versionControlSaveConfig_CommitTasksT);
			return versionControlSaveConfig_CommitTasksT;
		}

		// Token: 0x0601E9D1 RID: 125393 RVA: 0x00448FDC File Offset: 0x004471DC
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

		// Token: 0x0601E9D2 RID: 125394 RVA: 0x004490D8 File Offset: 0x004472D8
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

		// Token: 0x0400D8FC RID: 55548
		private Table __p;
	}
}
