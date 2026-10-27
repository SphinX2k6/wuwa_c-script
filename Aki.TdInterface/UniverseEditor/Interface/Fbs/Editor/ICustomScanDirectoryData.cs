using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004844 RID: 18500
	public struct ICustomScanDirectoryData : IFlatbufferObject
	{
		// Token: 0x170084C6 RID: 33990
		// (get) Token: 0x0601C9AF RID: 117167 RVA: 0x0040B1E9 File Offset: 0x004093E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C9B0 RID: 117168 RVA: 0x0040B1F6 File Offset: 0x004093F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C9B1 RID: 117169 RVA: 0x0040B200 File Offset: 0x00409400
		public static ICustomScanDirectoryData GetRootAsICustomScanDirectoryData(ByteBuffer _bb)
		{
			return ICustomScanDirectoryData.GetRootAsICustomScanDirectoryData(_bb, default(ICustomScanDirectoryData));
		}

		// Token: 0x0601C9B2 RID: 117170 RVA: 0x0040B21C File Offset: 0x0040941C
		public static ICustomScanDirectoryData GetRootAsICustomScanDirectoryData(ByteBuffer _bb, ICustomScanDirectoryData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C9B3 RID: 117171 RVA: 0x0040B239 File Offset: 0x00409439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C9B4 RID: 117172 RVA: 0x0040B248 File Offset: 0x00409448
		public ICustomScanDirectoryData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084C7 RID: 33991
		// (get) Token: 0x0601C9B5 RID: 117173 RVA: 0x0040B258 File Offset: 0x00409458
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170084C8 RID: 33992
		// (get) Token: 0x0601C9B6 RID: 117174 RVA: 0x0040B298 File Offset: 0x00409498
		public bool IsEnableBaseDirs
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601C9B7 RID: 117175 RVA: 0x0040B2D8 File Offset: 0x004094D8
		public string DisabledBaseDirs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170084C9 RID: 33993
		// (get) Token: 0x0601C9B8 RID: 117176 RVA: 0x0040B314 File Offset: 0x00409514
		public int DisabledBaseDirsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601C9B9 RID: 117177 RVA: 0x0040B340 File Offset: 0x00409540
		public IScanDirectory? AppendDirs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IScanDirectory?(default(IScanDirectory).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170084CA RID: 33994
		// (get) Token: 0x0601C9BA RID: 117178 RVA: 0x0040B3A4 File Offset: 0x004095A4
		public int AppendDirsLength
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

		// Token: 0x170084CB RID: 33995
		// (get) Token: 0x0601C9BB RID: 117179 RVA: 0x0040B3D0 File Offset: 0x004095D0
		public bool IsSwarmDirs
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601C9BC RID: 117180 RVA: 0x0040B410 File Offset: 0x00409610
		public static Offset<ICustomScanDirectoryData> CreateICustomScanDirectoryData(FlatBufferBuilder builder, bool IsEnable = false, bool IsEnableBaseDirs = false, VectorOffset DisabledBaseDirsOffset = default(VectorOffset), VectorOffset AppendDirsOffset = default(VectorOffset), bool IsSwarmDirs = false)
		{
			builder.StartTable(5);
			ICustomScanDirectoryData.AddAppendDirs(builder, AppendDirsOffset);
			ICustomScanDirectoryData.AddDisabledBaseDirs(builder, DisabledBaseDirsOffset);
			ICustomScanDirectoryData.AddIsSwarmDirs(builder, IsSwarmDirs);
			ICustomScanDirectoryData.AddIsEnableBaseDirs(builder, IsEnableBaseDirs);
			ICustomScanDirectoryData.AddIsEnable(builder, IsEnable);
			return ICustomScanDirectoryData.EndICustomScanDirectoryData(builder);
		}

		// Token: 0x0601C9BD RID: 117181 RVA: 0x0040B444 File Offset: 0x00409644
		public static void StartICustomScanDirectoryData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601C9BE RID: 117182 RVA: 0x0040B44D File Offset: 0x0040964D
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0601C9BF RID: 117183 RVA: 0x0040B458 File Offset: 0x00409658
		public static void AddIsEnableBaseDirs(FlatBufferBuilder builder, bool isEnableBaseDirs)
		{
			builder.AddBool(1, isEnableBaseDirs, false);
		}

		// Token: 0x0601C9C0 RID: 117184 RVA: 0x0040B463 File Offset: 0x00409663
		public static void AddDisabledBaseDirs(FlatBufferBuilder builder, VectorOffset disabledBaseDirsOffset)
		{
			builder.AddOffset(2, disabledBaseDirsOffset.Value, 0);
		}

		// Token: 0x0601C9C1 RID: 117185 RVA: 0x0040B474 File Offset: 0x00409674
		public static VectorOffset CreateDisabledBaseDirsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C9C2 RID: 117186 RVA: 0x0040B4B4 File Offset: 0x004096B4
		public static VectorOffset CreateDisabledBaseDirsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9C3 RID: 117187 RVA: 0x0040B4CE File Offset: 0x004096CE
		public static VectorOffset CreateDisabledBaseDirsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9C4 RID: 117188 RVA: 0x0040B4EC File Offset: 0x004096EC
		public static VectorOffset CreateDisabledBaseDirsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C9C5 RID: 117189 RVA: 0x0040B505 File Offset: 0x00409705
		public static void StartDisabledBaseDirsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C9C6 RID: 117190 RVA: 0x0040B510 File Offset: 0x00409710
		public static void AddAppendDirs(FlatBufferBuilder builder, VectorOffset appendDirsOffset)
		{
			builder.AddOffset(3, appendDirsOffset.Value, 0);
		}

		// Token: 0x0601C9C7 RID: 117191 RVA: 0x0040B520 File Offset: 0x00409720
		public static VectorOffset CreateAppendDirsVector(FlatBufferBuilder builder, Offset<IScanDirectory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C9C8 RID: 117192 RVA: 0x0040B560 File Offset: 0x00409760
		public static VectorOffset CreateAppendDirsVectorBlock(FlatBufferBuilder builder, Offset<IScanDirectory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IScanDirectory>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9C9 RID: 117193 RVA: 0x0040B57A File Offset: 0x0040977A
		public static VectorOffset CreateAppendDirsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IScanDirectory>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IScanDirectory>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C9CA RID: 117194 RVA: 0x0040B598 File Offset: 0x00409798
		public static VectorOffset CreateAppendDirsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IScanDirectory>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C9CB RID: 117195 RVA: 0x0040B5B1 File Offset: 0x004097B1
		public static void StartAppendDirsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C9CC RID: 117196 RVA: 0x0040B5BC File Offset: 0x004097BC
		public static void AddIsSwarmDirs(FlatBufferBuilder builder, bool isSwarmDirs)
		{
			builder.AddBool(4, isSwarmDirs, false);
		}

		// Token: 0x0601C9CD RID: 117197 RVA: 0x0040B5C7 File Offset: 0x004097C7
		public static Offset<ICustomScanDirectoryData> EndICustomScanDirectoryData(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScanDirectoryData>(builder.EndTable());
		}

		// Token: 0x0601C9CE RID: 117198 RVA: 0x0040B5D4 File Offset: 0x004097D4
		public ICustomScanDirectoryDataT UnPack()
		{
			ICustomScanDirectoryDataT customScanDirectoryDataT = new ICustomScanDirectoryDataT();
			this.UnPackTo(customScanDirectoryDataT);
			return customScanDirectoryDataT;
		}

		// Token: 0x0601C9CF RID: 117199 RVA: 0x0040B5F0 File Offset: 0x004097F0
		public void UnPackTo(ICustomScanDirectoryDataT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.IsEnableBaseDirs = this.IsEnableBaseDirs;
			_o.DisabledBaseDirs = new List<string>();
			for (int i = 0; i < this.DisabledBaseDirsLength; i++)
			{
				_o.DisabledBaseDirs.Add(this.DisabledBaseDirs(i));
			}
			_o.AppendDirs = new List<IScanDirectoryT>();
			for (int j = 0; j < this.AppendDirsLength; j++)
			{
				_o.AppendDirs.Add((this.AppendDirs(j) != null) ? this.AppendDirs(j).Value.UnPack() : null);
			}
			_o.IsSwarmDirs = this.IsSwarmDirs;
		}

		// Token: 0x0601C9D0 RID: 117200 RVA: 0x0040B6A4 File Offset: 0x004098A4
		public static Offset<ICustomScanDirectoryData> Pack(FlatBufferBuilder builder, ICustomScanDirectoryDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScanDirectoryData>);
			}
			VectorOffset disabledBaseDirsOffset = default(VectorOffset);
			if (_o.DisabledBaseDirs != null)
			{
				StringOffset[] array = new StringOffset[_o.DisabledBaseDirs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.DisabledBaseDirs[i]);
				}
				disabledBaseDirsOffset = ICustomScanDirectoryData.CreateDisabledBaseDirsVector(builder, array);
			}
			VectorOffset appendDirsOffset = default(VectorOffset);
			if (_o.AppendDirs != null)
			{
				Offset<IScanDirectory>[] array2 = new Offset<IScanDirectory>[_o.AppendDirs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IScanDirectory.Pack(builder, _o.AppendDirs[j]);
				}
				appendDirsOffset = ICustomScanDirectoryData.CreateAppendDirsVector(builder, array2);
			}
			return ICustomScanDirectoryData.CreateICustomScanDirectoryData(builder, _o.IsEnable, _o.IsEnableBaseDirs, disabledBaseDirsOffset, appendDirsOffset, _o.IsSwarmDirs);
		}

		// Token: 0x0400CD73 RID: 52595
		private Table __p;
	}
}
