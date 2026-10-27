using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048BF RID: 18623
	public struct IVersionControlSaveConfig : IFlatbufferObject
	{
		// Token: 0x17008717 RID: 34583
		// (get) Token: 0x0601D172 RID: 119154 RVA: 0x0041B698 File Offset: 0x00419898
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D173 RID: 119155 RVA: 0x0041B6A5 File Offset: 0x004198A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D174 RID: 119156 RVA: 0x0041B6AC File Offset: 0x004198AC
		public static IVersionControlSaveConfig GetRootAsIVersionControlSaveConfig(ByteBuffer _bb)
		{
			return IVersionControlSaveConfig.GetRootAsIVersionControlSaveConfig(_bb, default(IVersionControlSaveConfig));
		}

		// Token: 0x0601D175 RID: 119157 RVA: 0x0041B6C8 File Offset: 0x004198C8
		public static IVersionControlSaveConfig GetRootAsIVersionControlSaveConfig(ByteBuffer _bb, IVersionControlSaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D176 RID: 119158 RVA: 0x0041B6E5 File Offset: 0x004198E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D177 RID: 119159 RVA: 0x0041B6F4 File Offset: 0x004198F4
		public IVersionControlSaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008718 RID: 34584
		// (get) Token: 0x0601D178 RID: 119160 RVA: 0x0041B704 File Offset: 0x00419904
		public bool IsSwarmPassAutoSync
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D179 RID: 119161 RVA: 0x0041B744 File Offset: 0x00419944
		public ICommitLog? CommitLogs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICommitLog?(default(ICommitLog).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008719 RID: 34585
		// (get) Token: 0x0601D17A RID: 119162 RVA: 0x0041B7A4 File Offset: 0x004199A4
		public int CommitLogsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700871A RID: 34586
		// (get) Token: 0x0601D17B RID: 119163 RVA: 0x0041B7D0 File Offset: 0x004199D0
		public string CommitLogInputCache
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

		// Token: 0x0601D17C RID: 119164 RVA: 0x0041B807 File Offset: 0x00419A07
		public Span<byte> GetCommitLogInputCacheBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D17D RID: 119165 RVA: 0x0041B816 File Offset: 0x00419A16
		public byte[] GetCommitLogInputCacheArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601D17E RID: 119166 RVA: 0x0041B824 File Offset: 0x00419A24
		public string IgnoreCols(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700871B RID: 34587
		// (get) Token: 0x0601D17F RID: 119167 RVA: 0x0041B860 File Offset: 0x00419A60
		public int IgnoreColsLength
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

		// Token: 0x1700871C RID: 34588
		// (get) Token: 0x0601D180 RID: 119168 RVA: 0x0041B88C File Offset: 0x00419A8C
		public bool IsFastScan
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700871D RID: 34589
		// (get) Token: 0x0601D181 RID: 119169 RVA: 0x0041B8CC File Offset: 0x00419ACC
		public ISpecificLevelScanData? SpecificLevelScanData
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ISpecificLevelScanData?(default(ISpecificLevelScanData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700871E RID: 34590
		// (get) Token: 0x0601D182 RID: 119170 RVA: 0x0041B92C File Offset: 0x00419B2C
		public ICustomScanDirectoryData? CustomScanDirectoryData
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ICustomScanDirectoryData?(default(ICustomScanDirectoryData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D183 RID: 119171 RVA: 0x0041B98C File Offset: 0x00419B8C
		public IVersionControlSaveConfig_CommitTasks? CommitTasks(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IVersionControlSaveConfig_CommitTasks?(default(IVersionControlSaveConfig_CommitTasks).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700871F RID: 34591
		// (get) Token: 0x0601D184 RID: 119172 RVA: 0x0041B9F0 File Offset: 0x00419BF0
		public int CommitTasksLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008720 RID: 34592
		// (get) Token: 0x0601D185 RID: 119173 RVA: 0x0041BA1C File Offset: 0x00419C1C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D186 RID: 119174 RVA: 0x0041BA5C File Offset: 0x00419C5C
		public static Offset<IVersionControlSaveConfig> CreateIVersionControlSaveConfig(FlatBufferBuilder builder, bool IsSwarmPassAutoSync = false, VectorOffset CommitLogsOffset = default(VectorOffset), StringOffset CommitLogInputCacheOffset = default(StringOffset), VectorOffset IgnoreColsOffset = default(VectorOffset), bool IsFastScan = false, Offset<ISpecificLevelScanData> SpecificLevelScanDataOffset = default(Offset<ISpecificLevelScanData>), Offset<ICustomScanDirectoryData> CustomScanDirectoryDataOffset = default(Offset<ICustomScanDirectoryData>), VectorOffset CommitTasksOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IVersionControlSaveConfig.AddCommitTasks(builder, CommitTasksOffset);
			IVersionControlSaveConfig.AddCustomScanDirectoryData(builder, CustomScanDirectoryDataOffset);
			IVersionControlSaveConfig.AddSpecificLevelScanData(builder, SpecificLevelScanDataOffset);
			IVersionControlSaveConfig.AddIgnoreCols(builder, IgnoreColsOffset);
			IVersionControlSaveConfig.AddCommitLogInputCache(builder, CommitLogInputCacheOffset);
			IVersionControlSaveConfig.AddCommitLogs(builder, CommitLogsOffset);
			IVersionControlSaveConfig.AddNullMask(builder, NullMask);
			IVersionControlSaveConfig.AddIsFastScan(builder, IsFastScan);
			IVersionControlSaveConfig.AddIsSwarmPassAutoSync(builder, IsSwarmPassAutoSync);
			return IVersionControlSaveConfig.EndIVersionControlSaveConfig(builder);
		}

		// Token: 0x0601D187 RID: 119175 RVA: 0x0041BABC File Offset: 0x00419CBC
		public static void StartIVersionControlSaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601D188 RID: 119176 RVA: 0x0041BAC6 File Offset: 0x00419CC6
		public static void AddIsSwarmPassAutoSync(FlatBufferBuilder builder, bool isSwarmPassAutoSync)
		{
			builder.AddBool(0, isSwarmPassAutoSync, false);
		}

		// Token: 0x0601D189 RID: 119177 RVA: 0x0041BAD1 File Offset: 0x00419CD1
		public static void AddCommitLogs(FlatBufferBuilder builder, VectorOffset commitLogsOffset)
		{
			builder.AddOffset(1, commitLogsOffset.Value, 0);
		}

		// Token: 0x0601D18A RID: 119178 RVA: 0x0041BAE4 File Offset: 0x00419CE4
		public static VectorOffset CreateCommitLogsVector(FlatBufferBuilder builder, Offset<ICommitLog>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D18B RID: 119179 RVA: 0x0041BB24 File Offset: 0x00419D24
		public static VectorOffset CreateCommitLogsVectorBlock(FlatBufferBuilder builder, Offset<ICommitLog>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommitLog>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D18C RID: 119180 RVA: 0x0041BB3E File Offset: 0x00419D3E
		public static VectorOffset CreateCommitLogsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommitLog>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommitLog>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D18D RID: 119181 RVA: 0x0041BB5C File Offset: 0x00419D5C
		public static VectorOffset CreateCommitLogsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommitLog>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D18E RID: 119182 RVA: 0x0041BB75 File Offset: 0x00419D75
		public static void StartCommitLogsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D18F RID: 119183 RVA: 0x0041BB80 File Offset: 0x00419D80
		public static void AddCommitLogInputCache(FlatBufferBuilder builder, StringOffset commitLogInputCacheOffset)
		{
			builder.AddOffset(2, commitLogInputCacheOffset.Value, 0);
		}

		// Token: 0x0601D190 RID: 119184 RVA: 0x0041BB90 File Offset: 0x00419D90
		public static void AddIgnoreCols(FlatBufferBuilder builder, VectorOffset ignoreColsOffset)
		{
			builder.AddOffset(3, ignoreColsOffset.Value, 0);
		}

		// Token: 0x0601D191 RID: 119185 RVA: 0x0041BBA0 File Offset: 0x00419DA0
		public static VectorOffset CreateIgnoreColsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D192 RID: 119186 RVA: 0x0041BBE0 File Offset: 0x00419DE0
		public static VectorOffset CreateIgnoreColsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D193 RID: 119187 RVA: 0x0041BBFA File Offset: 0x00419DFA
		public static VectorOffset CreateIgnoreColsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D194 RID: 119188 RVA: 0x0041BC18 File Offset: 0x00419E18
		public static VectorOffset CreateIgnoreColsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D195 RID: 119189 RVA: 0x0041BC31 File Offset: 0x00419E31
		public static void StartIgnoreColsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D196 RID: 119190 RVA: 0x0041BC3C File Offset: 0x00419E3C
		public static void AddIsFastScan(FlatBufferBuilder builder, bool isFastScan)
		{
			builder.AddBool(4, isFastScan, false);
		}

		// Token: 0x0601D197 RID: 119191 RVA: 0x0041BC47 File Offset: 0x00419E47
		public static void AddSpecificLevelScanData(FlatBufferBuilder builder, Offset<ISpecificLevelScanData> specificLevelScanDataOffset)
		{
			builder.AddOffset(5, specificLevelScanDataOffset.Value, 0);
		}

		// Token: 0x0601D198 RID: 119192 RVA: 0x0041BC57 File Offset: 0x00419E57
		public static void AddCustomScanDirectoryData(FlatBufferBuilder builder, Offset<ICustomScanDirectoryData> customScanDirectoryDataOffset)
		{
			builder.AddOffset(6, customScanDirectoryDataOffset.Value, 0);
		}

		// Token: 0x0601D199 RID: 119193 RVA: 0x0041BC67 File Offset: 0x00419E67
		public static void AddCommitTasks(FlatBufferBuilder builder, VectorOffset commitTasksOffset)
		{
			builder.AddOffset(7, commitTasksOffset.Value, 0);
		}

		// Token: 0x0601D19A RID: 119194 RVA: 0x0041BC78 File Offset: 0x00419E78
		public static VectorOffset CreateCommitTasksVector(FlatBufferBuilder builder, Offset<IVersionControlSaveConfig_CommitTasks>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D19B RID: 119195 RVA: 0x0041BCB8 File Offset: 0x00419EB8
		public static VectorOffset CreateCommitTasksVectorBlock(FlatBufferBuilder builder, Offset<IVersionControlSaveConfig_CommitTasks>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVersionControlSaveConfig_CommitTasks>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D19C RID: 119196 RVA: 0x0041BCD2 File Offset: 0x00419ED2
		public static VectorOffset CreateCommitTasksVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVersionControlSaveConfig_CommitTasks>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVersionControlSaveConfig_CommitTasks>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D19D RID: 119197 RVA: 0x0041BCF0 File Offset: 0x00419EF0
		public static VectorOffset CreateCommitTasksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVersionControlSaveConfig_CommitTasks>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D19E RID: 119198 RVA: 0x0041BD09 File Offset: 0x00419F09
		public static void StartCommitTasksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D19F RID: 119199 RVA: 0x0041BD14 File Offset: 0x00419F14
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601D1A0 RID: 119200 RVA: 0x0041BD1F File Offset: 0x00419F1F
		public static Offset<IVersionControlSaveConfig> EndIVersionControlSaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVersionControlSaveConfig>(builder.EndTable());
		}

		// Token: 0x0601D1A1 RID: 119201 RVA: 0x0041BD2C File Offset: 0x00419F2C
		public IVersionControlSaveConfigT UnPack()
		{
			IVersionControlSaveConfigT versionControlSaveConfigT = new IVersionControlSaveConfigT();
			this.UnPackTo(versionControlSaveConfigT);
			return versionControlSaveConfigT;
		}

		// Token: 0x0601D1A2 RID: 119202 RVA: 0x0041BD48 File Offset: 0x00419F48
		public void UnPackTo(IVersionControlSaveConfigT _o)
		{
			_o.IsSwarmPassAutoSync = this.IsSwarmPassAutoSync;
			_o.CommitLogs = new List<ICommitLogT>();
			for (int i = 0; i < this.CommitLogsLength; i++)
			{
				_o.CommitLogs.Add((this.CommitLogs(i) != null) ? this.CommitLogs(i).Value.UnPack() : null);
			}
			_o.CommitLogInputCache = this.CommitLogInputCache;
			_o.IgnoreCols = new List<string>();
			for (int j = 0; j < this.IgnoreColsLength; j++)
			{
				_o.IgnoreCols.Add(this.IgnoreCols(j));
			}
			_o.IsFastScan = this.IsFastScan;
			_o.SpecificLevelScanData = ((this.SpecificLevelScanData != null) ? this.SpecificLevelScanData.Value.UnPack() : null);
			_o.CustomScanDirectoryData = ((this.CustomScanDirectoryData != null) ? this.CustomScanDirectoryData.Value.UnPack() : null);
			_o.CommitTasks = new List<IVersionControlSaveConfig_CommitTasksT>();
			for (int k = 0; k < this.CommitTasksLength; k++)
			{
				_o.CommitTasks.Add((this.CommitTasks(k) != null) ? this.CommitTasks(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D1A3 RID: 119203 RVA: 0x0041BEC4 File Offset: 0x0041A0C4
		public static Offset<IVersionControlSaveConfig> Pack(FlatBufferBuilder builder, IVersionControlSaveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVersionControlSaveConfig>);
			}
			VectorOffset commitLogsOffset = default(VectorOffset);
			if (_o.CommitLogs != null)
			{
				Offset<ICommitLog>[] array = new Offset<ICommitLog>[_o.CommitLogs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICommitLog.Pack(builder, _o.CommitLogs[i]);
				}
				commitLogsOffset = IVersionControlSaveConfig.CreateCommitLogsVector(builder, array);
			}
			StringOffset commitLogInputCacheOffset = (_o.CommitLogInputCache == null) ? default(StringOffset) : builder.CreateString(_o.CommitLogInputCache);
			VectorOffset ignoreColsOffset = default(VectorOffset);
			if (_o.IgnoreCols != null)
			{
				StringOffset[] array2 = new StringOffset[_o.IgnoreCols.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.IgnoreCols[j]);
				}
				ignoreColsOffset = IVersionControlSaveConfig.CreateIgnoreColsVector(builder, array2);
			}
			Offset<ISpecificLevelScanData> specificLevelScanDataOffset = (_o.SpecificLevelScanData == null) ? default(Offset<ISpecificLevelScanData>) : ISpecificLevelScanData.Pack(builder, _o.SpecificLevelScanData);
			Offset<ICustomScanDirectoryData> customScanDirectoryDataOffset = (_o.CustomScanDirectoryData == null) ? default(Offset<ICustomScanDirectoryData>) : ICustomScanDirectoryData.Pack(builder, _o.CustomScanDirectoryData);
			VectorOffset commitTasksOffset = default(VectorOffset);
			if (_o.CommitTasks != null)
			{
				Offset<IVersionControlSaveConfig_CommitTasks>[] array3 = new Offset<IVersionControlSaveConfig_CommitTasks>[_o.CommitTasks.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IVersionControlSaveConfig_CommitTasks.Pack(builder, _o.CommitTasks[k]);
				}
				commitTasksOffset = IVersionControlSaveConfig.CreateCommitTasksVector(builder, array3);
			}
			return IVersionControlSaveConfig.CreateIVersionControlSaveConfig(builder, _o.IsSwarmPassAutoSync, commitLogsOffset, commitLogInputCacheOffset, ignoreColsOffset, _o.IsFastScan, specificLevelScanDataOffset, customScanDirectoryDataOffset, commitTasksOffset, _o.NullMask);
		}

		// Token: 0x0400CEB9 RID: 52921
		private Table __p;
	}
}
