using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D24 RID: 19748
	public struct IVersionControlSaveConfig : IFlatbufferObject
	{
		// Token: 0x17008D5F RID: 36191
		// (get) Token: 0x0601E95F RID: 125279 RVA: 0x00447E34 File Offset: 0x00446034
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E960 RID: 125280 RVA: 0x00447E41 File Offset: 0x00446041
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E961 RID: 125281 RVA: 0x00447E48 File Offset: 0x00446048
		public static IVersionControlSaveConfig GetRootAsIVersionControlSaveConfig(ByteBuffer _bb)
		{
			return IVersionControlSaveConfig.GetRootAsIVersionControlSaveConfig(_bb, default(IVersionControlSaveConfig));
		}

		// Token: 0x0601E962 RID: 125282 RVA: 0x00447E64 File Offset: 0x00446064
		public static IVersionControlSaveConfig GetRootAsIVersionControlSaveConfig(ByteBuffer _bb, IVersionControlSaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E963 RID: 125283 RVA: 0x00447E81 File Offset: 0x00446081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E964 RID: 125284 RVA: 0x00447E90 File Offset: 0x00446090
		public IVersionControlSaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D60 RID: 36192
		// (get) Token: 0x0601E965 RID: 125285 RVA: 0x00447EA0 File Offset: 0x004460A0
		public bool IsSwarmPassAutoSync
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E966 RID: 125286 RVA: 0x00447EE0 File Offset: 0x004460E0
		public ICommitLog? CommitLogs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICommitLog?(default(ICommitLog).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008D61 RID: 36193
		// (get) Token: 0x0601E967 RID: 125287 RVA: 0x00447F40 File Offset: 0x00446140
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

		// Token: 0x17008D62 RID: 36194
		// (get) Token: 0x0601E968 RID: 125288 RVA: 0x00447F6C File Offset: 0x0044616C
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

		// Token: 0x0601E969 RID: 125289 RVA: 0x00447FA3 File Offset: 0x004461A3
		public Span<byte> GetCommitLogInputCacheBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E96A RID: 125290 RVA: 0x00447FB2 File Offset: 0x004461B2
		public byte[] GetCommitLogInputCacheArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601E96B RID: 125291 RVA: 0x00447FC0 File Offset: 0x004461C0
		public string IgnoreCols(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008D63 RID: 36195
		// (get) Token: 0x0601E96C RID: 125292 RVA: 0x00447FFC File Offset: 0x004461FC
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

		// Token: 0x17008D64 RID: 36196
		// (get) Token: 0x0601E96D RID: 125293 RVA: 0x00448028 File Offset: 0x00446228
		public bool IsFastScan
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008D65 RID: 36197
		// (get) Token: 0x0601E96E RID: 125294 RVA: 0x00448068 File Offset: 0x00446268
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

		// Token: 0x17008D66 RID: 36198
		// (get) Token: 0x0601E96F RID: 125295 RVA: 0x004480C8 File Offset: 0x004462C8
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

		// Token: 0x0601E970 RID: 125296 RVA: 0x00448128 File Offset: 0x00446328
		public IVersionControlSaveConfig_CommitTasks? CommitTasks(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IVersionControlSaveConfig_CommitTasks?(default(IVersionControlSaveConfig_CommitTasks).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008D67 RID: 36199
		// (get) Token: 0x0601E971 RID: 125297 RVA: 0x0044818C File Offset: 0x0044638C
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

		// Token: 0x17008D68 RID: 36200
		// (get) Token: 0x0601E972 RID: 125298 RVA: 0x004481B8 File Offset: 0x004463B8
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

		// Token: 0x0601E973 RID: 125299 RVA: 0x004481F8 File Offset: 0x004463F8
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

		// Token: 0x0601E974 RID: 125300 RVA: 0x00448258 File Offset: 0x00446458
		public static void StartIVersionControlSaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601E975 RID: 125301 RVA: 0x00448262 File Offset: 0x00446462
		public static void AddIsSwarmPassAutoSync(FlatBufferBuilder builder, bool isSwarmPassAutoSync)
		{
			builder.AddBool(0, isSwarmPassAutoSync, false);
		}

		// Token: 0x0601E976 RID: 125302 RVA: 0x0044826D File Offset: 0x0044646D
		public static void AddCommitLogs(FlatBufferBuilder builder, VectorOffset commitLogsOffset)
		{
			builder.AddOffset(1, commitLogsOffset.Value, 0);
		}

		// Token: 0x0601E977 RID: 125303 RVA: 0x00448280 File Offset: 0x00446480
		public static VectorOffset CreateCommitLogsVector(FlatBufferBuilder builder, Offset<ICommitLog>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E978 RID: 125304 RVA: 0x004482C0 File Offset: 0x004464C0
		public static VectorOffset CreateCommitLogsVectorBlock(FlatBufferBuilder builder, Offset<ICommitLog>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommitLog>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E979 RID: 125305 RVA: 0x004482DA File Offset: 0x004464DA
		public static VectorOffset CreateCommitLogsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommitLog>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommitLog>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E97A RID: 125306 RVA: 0x004482F8 File Offset: 0x004464F8
		public static VectorOffset CreateCommitLogsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommitLog>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E97B RID: 125307 RVA: 0x00448311 File Offset: 0x00446511
		public static void StartCommitLogsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E97C RID: 125308 RVA: 0x0044831C File Offset: 0x0044651C
		public static void AddCommitLogInputCache(FlatBufferBuilder builder, StringOffset commitLogInputCacheOffset)
		{
			builder.AddOffset(2, commitLogInputCacheOffset.Value, 0);
		}

		// Token: 0x0601E97D RID: 125309 RVA: 0x0044832C File Offset: 0x0044652C
		public static void AddIgnoreCols(FlatBufferBuilder builder, VectorOffset ignoreColsOffset)
		{
			builder.AddOffset(3, ignoreColsOffset.Value, 0);
		}

		// Token: 0x0601E97E RID: 125310 RVA: 0x0044833C File Offset: 0x0044653C
		public static VectorOffset CreateIgnoreColsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E97F RID: 125311 RVA: 0x0044837C File Offset: 0x0044657C
		public static VectorOffset CreateIgnoreColsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E980 RID: 125312 RVA: 0x00448396 File Offset: 0x00446596
		public static VectorOffset CreateIgnoreColsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E981 RID: 125313 RVA: 0x004483B4 File Offset: 0x004465B4
		public static VectorOffset CreateIgnoreColsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E982 RID: 125314 RVA: 0x004483CD File Offset: 0x004465CD
		public static void StartIgnoreColsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E983 RID: 125315 RVA: 0x004483D8 File Offset: 0x004465D8
		public static void AddIsFastScan(FlatBufferBuilder builder, bool isFastScan)
		{
			builder.AddBool(4, isFastScan, false);
		}

		// Token: 0x0601E984 RID: 125316 RVA: 0x004483E3 File Offset: 0x004465E3
		public static void AddSpecificLevelScanData(FlatBufferBuilder builder, Offset<ISpecificLevelScanData> specificLevelScanDataOffset)
		{
			builder.AddOffset(5, specificLevelScanDataOffset.Value, 0);
		}

		// Token: 0x0601E985 RID: 125317 RVA: 0x004483F3 File Offset: 0x004465F3
		public static void AddCustomScanDirectoryData(FlatBufferBuilder builder, Offset<ICustomScanDirectoryData> customScanDirectoryDataOffset)
		{
			builder.AddOffset(6, customScanDirectoryDataOffset.Value, 0);
		}

		// Token: 0x0601E986 RID: 125318 RVA: 0x00448403 File Offset: 0x00446603
		public static void AddCommitTasks(FlatBufferBuilder builder, VectorOffset commitTasksOffset)
		{
			builder.AddOffset(7, commitTasksOffset.Value, 0);
		}

		// Token: 0x0601E987 RID: 125319 RVA: 0x00448414 File Offset: 0x00446614
		public static VectorOffset CreateCommitTasksVector(FlatBufferBuilder builder, Offset<IVersionControlSaveConfig_CommitTasks>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E988 RID: 125320 RVA: 0x00448454 File Offset: 0x00446654
		public static VectorOffset CreateCommitTasksVectorBlock(FlatBufferBuilder builder, Offset<IVersionControlSaveConfig_CommitTasks>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVersionControlSaveConfig_CommitTasks>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E989 RID: 125321 RVA: 0x0044846E File Offset: 0x0044666E
		public static VectorOffset CreateCommitTasksVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVersionControlSaveConfig_CommitTasks>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVersionControlSaveConfig_CommitTasks>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E98A RID: 125322 RVA: 0x0044848C File Offset: 0x0044668C
		public static VectorOffset CreateCommitTasksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVersionControlSaveConfig_CommitTasks>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E98B RID: 125323 RVA: 0x004484A5 File Offset: 0x004466A5
		public static void StartCommitTasksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E98C RID: 125324 RVA: 0x004484B0 File Offset: 0x004466B0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601E98D RID: 125325 RVA: 0x004484BB File Offset: 0x004466BB
		public static Offset<IVersionControlSaveConfig> EndIVersionControlSaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVersionControlSaveConfig>(builder.EndTable());
		}

		// Token: 0x0601E98E RID: 125326 RVA: 0x004484C8 File Offset: 0x004466C8
		public IVersionControlSaveConfigT UnPack()
		{
			IVersionControlSaveConfigT versionControlSaveConfigT = new IVersionControlSaveConfigT();
			this.UnPackTo(versionControlSaveConfigT);
			return versionControlSaveConfigT;
		}

		// Token: 0x0601E98F RID: 125327 RVA: 0x004484E4 File Offset: 0x004466E4
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

		// Token: 0x0601E990 RID: 125328 RVA: 0x00448660 File Offset: 0x00446860
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

		// Token: 0x0400D8F2 RID: 55538
		private Table __p;
	}
}
