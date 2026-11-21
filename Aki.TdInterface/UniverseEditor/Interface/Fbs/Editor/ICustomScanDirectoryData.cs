using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CAC RID: 19628
	public struct ICustomScanDirectoryData : IFlatbufferObject
	{
		// Token: 0x17008B11 RID: 35601
		// (get) Token: 0x0601E1AC RID: 123308 RVA: 0x00437B39 File Offset: 0x00435D39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E1AD RID: 123309 RVA: 0x00437B46 File Offset: 0x00435D46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E1AE RID: 123310 RVA: 0x00437B50 File Offset: 0x00435D50
		public static ICustomScanDirectoryData GetRootAsICustomScanDirectoryData(ByteBuffer _bb)
		{
			return ICustomScanDirectoryData.GetRootAsICustomScanDirectoryData(_bb, default(ICustomScanDirectoryData));
		}

		// Token: 0x0601E1AF RID: 123311 RVA: 0x00437B6C File Offset: 0x00435D6C
		public static ICustomScanDirectoryData GetRootAsICustomScanDirectoryData(ByteBuffer _bb, ICustomScanDirectoryData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E1B0 RID: 123312 RVA: 0x00437B89 File Offset: 0x00435D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E1B1 RID: 123313 RVA: 0x00437B98 File Offset: 0x00435D98
		public ICustomScanDirectoryData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B12 RID: 35602
		// (get) Token: 0x0601E1B2 RID: 123314 RVA: 0x00437BA8 File Offset: 0x00435DA8
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B13 RID: 35603
		// (get) Token: 0x0601E1B3 RID: 123315 RVA: 0x00437BE8 File Offset: 0x00435DE8
		public bool IsEnableBaseDirs
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E1B4 RID: 123316 RVA: 0x00437C28 File Offset: 0x00435E28
		public string DisabledBaseDirs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008B14 RID: 35604
		// (get) Token: 0x0601E1B5 RID: 123317 RVA: 0x00437C64 File Offset: 0x00435E64
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

		// Token: 0x0601E1B6 RID: 123318 RVA: 0x00437C90 File Offset: 0x00435E90
		public IScanDirectory? AppendDirs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IScanDirectory?(default(IScanDirectory).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B15 RID: 35605
		// (get) Token: 0x0601E1B7 RID: 123319 RVA: 0x00437CF4 File Offset: 0x00435EF4
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

		// Token: 0x17008B16 RID: 35606
		// (get) Token: 0x0601E1B8 RID: 123320 RVA: 0x00437D20 File Offset: 0x00435F20
		public bool IsSwarmDirs
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E1B9 RID: 123321 RVA: 0x00437D60 File Offset: 0x00435F60
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

		// Token: 0x0601E1BA RID: 123322 RVA: 0x00437D94 File Offset: 0x00435F94
		public static void StartICustomScanDirectoryData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E1BB RID: 123323 RVA: 0x00437D9D File Offset: 0x00435F9D
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0601E1BC RID: 123324 RVA: 0x00437DA8 File Offset: 0x00435FA8
		public static void AddIsEnableBaseDirs(FlatBufferBuilder builder, bool isEnableBaseDirs)
		{
			builder.AddBool(1, isEnableBaseDirs, false);
		}

		// Token: 0x0601E1BD RID: 123325 RVA: 0x00437DB3 File Offset: 0x00435FB3
		public static void AddDisabledBaseDirs(FlatBufferBuilder builder, VectorOffset disabledBaseDirsOffset)
		{
			builder.AddOffset(2, disabledBaseDirsOffset.Value, 0);
		}

		// Token: 0x0601E1BE RID: 123326 RVA: 0x00437DC4 File Offset: 0x00435FC4
		public static VectorOffset CreateDisabledBaseDirsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E1BF RID: 123327 RVA: 0x00437E04 File Offset: 0x00436004
		public static VectorOffset CreateDisabledBaseDirsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E1C0 RID: 123328 RVA: 0x00437E1E File Offset: 0x0043601E
		public static VectorOffset CreateDisabledBaseDirsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E1C1 RID: 123329 RVA: 0x00437E3C File Offset: 0x0043603C
		public static VectorOffset CreateDisabledBaseDirsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E1C2 RID: 123330 RVA: 0x00437E55 File Offset: 0x00436055
		public static void StartDisabledBaseDirsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E1C3 RID: 123331 RVA: 0x00437E60 File Offset: 0x00436060
		public static void AddAppendDirs(FlatBufferBuilder builder, VectorOffset appendDirsOffset)
		{
			builder.AddOffset(3, appendDirsOffset.Value, 0);
		}

		// Token: 0x0601E1C4 RID: 123332 RVA: 0x00437E70 File Offset: 0x00436070
		public static VectorOffset CreateAppendDirsVector(FlatBufferBuilder builder, Offset<IScanDirectory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E1C5 RID: 123333 RVA: 0x00437EB0 File Offset: 0x004360B0
		public static VectorOffset CreateAppendDirsVectorBlock(FlatBufferBuilder builder, Offset<IScanDirectory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IScanDirectory>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E1C6 RID: 123334 RVA: 0x00437ECA File Offset: 0x004360CA
		public static VectorOffset CreateAppendDirsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IScanDirectory>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IScanDirectory>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E1C7 RID: 123335 RVA: 0x00437EE8 File Offset: 0x004360E8
		public static VectorOffset CreateAppendDirsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IScanDirectory>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E1C8 RID: 123336 RVA: 0x00437F01 File Offset: 0x00436101
		public static void StartAppendDirsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E1C9 RID: 123337 RVA: 0x00437F0C File Offset: 0x0043610C
		public static void AddIsSwarmDirs(FlatBufferBuilder builder, bool isSwarmDirs)
		{
			builder.AddBool(4, isSwarmDirs, false);
		}

		// Token: 0x0601E1CA RID: 123338 RVA: 0x00437F17 File Offset: 0x00436117
		public static Offset<ICustomScanDirectoryData> EndICustomScanDirectoryData(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScanDirectoryData>(builder.EndTable());
		}

		// Token: 0x0601E1CB RID: 123339 RVA: 0x00437F24 File Offset: 0x00436124
		public ICustomScanDirectoryDataT UnPack()
		{
			ICustomScanDirectoryDataT customScanDirectoryDataT = new ICustomScanDirectoryDataT();
			this.UnPackTo(customScanDirectoryDataT);
			return customScanDirectoryDataT;
		}

		// Token: 0x0601E1CC RID: 123340 RVA: 0x00437F40 File Offset: 0x00436140
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

		// Token: 0x0601E1CD RID: 123341 RVA: 0x00437FF4 File Offset: 0x004361F4
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

		// Token: 0x0400D7AE RID: 55214
		private Table __p;
	}
}
