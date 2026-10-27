using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200479C RID: 18332
	public struct IEntityCustomPrimitiveData : IFlatbufferObject
	{
		// Token: 0x17008389 RID: 33673
		// (get) Token: 0x0601C40D RID: 115725 RVA: 0x003FFFC4 File Offset: 0x003FE1C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C40E RID: 115726 RVA: 0x003FFFD1 File Offset: 0x003FE1D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C40F RID: 115727 RVA: 0x003FFFD8 File Offset: 0x003FE1D8
		public static IEntityCustomPrimitiveData GetRootAsIEntityCustomPrimitiveData(ByteBuffer _bb)
		{
			return IEntityCustomPrimitiveData.GetRootAsIEntityCustomPrimitiveData(_bb, default(IEntityCustomPrimitiveData));
		}

		// Token: 0x0601C410 RID: 115728 RVA: 0x003FFFF4 File Offset: 0x003FE1F4
		public static IEntityCustomPrimitiveData GetRootAsIEntityCustomPrimitiveData(ByteBuffer _bb, IEntityCustomPrimitiveData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C411 RID: 115729 RVA: 0x00400011 File Offset: 0x003FE211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C412 RID: 115730 RVA: 0x00400020 File Offset: 0x003FE220
		public IEntityCustomPrimitiveData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700838A RID: 33674
		// (get) Token: 0x0601C413 RID: 115731 RVA: 0x00400030 File Offset: 0x003FE230
		public int Id
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

		// Token: 0x0601C414 RID: 115732 RVA: 0x0040006C File Offset: 0x003FE26C
		public IEntityCustomPrimitiveData_CustomDataRow? CustomData(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCustomPrimitiveData_CustomDataRow?(default(IEntityCustomPrimitiveData_CustomDataRow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700838B RID: 33675
		// (get) Token: 0x0601C415 RID: 115733 RVA: 0x004000CC File Offset: 0x003FE2CC
		public int CustomDataLength
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

		// Token: 0x0601C416 RID: 115734 RVA: 0x004000F7 File Offset: 0x003FE2F7
		public static Offset<IEntityCustomPrimitiveData> CreateIEntityCustomPrimitiveData(FlatBufferBuilder builder, int Id = 0, VectorOffset CustomDataOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityCustomPrimitiveData.AddCustomData(builder, CustomDataOffset);
			IEntityCustomPrimitiveData.AddId(builder, Id);
			return IEntityCustomPrimitiveData.EndIEntityCustomPrimitiveData(builder);
		}

		// Token: 0x0601C417 RID: 115735 RVA: 0x00400114 File Offset: 0x003FE314
		public static void StartIEntityCustomPrimitiveData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C418 RID: 115736 RVA: 0x0040011D File Offset: 0x003FE31D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C419 RID: 115737 RVA: 0x00400128 File Offset: 0x003FE328
		public static void AddCustomData(FlatBufferBuilder builder, VectorOffset customDataOffset)
		{
			builder.AddOffset(1, customDataOffset.Value, 0);
		}

		// Token: 0x0601C41A RID: 115738 RVA: 0x00400138 File Offset: 0x003FE338
		public static VectorOffset CreateCustomDataVector(FlatBufferBuilder builder, Offset<IEntityCustomPrimitiveData_CustomDataRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C41B RID: 115739 RVA: 0x00400178 File Offset: 0x003FE378
		public static VectorOffset CreateCustomDataVectorBlock(FlatBufferBuilder builder, Offset<IEntityCustomPrimitiveData_CustomDataRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCustomPrimitiveData_CustomDataRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C41C RID: 115740 RVA: 0x00400192 File Offset: 0x003FE392
		public static VectorOffset CreateCustomDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCustomPrimitiveData_CustomDataRow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCustomPrimitiveData_CustomDataRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C41D RID: 115741 RVA: 0x004001B0 File Offset: 0x003FE3B0
		public static VectorOffset CreateCustomDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCustomPrimitiveData_CustomDataRow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C41E RID: 115742 RVA: 0x004001C9 File Offset: 0x003FE3C9
		public static void StartCustomDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C41F RID: 115743 RVA: 0x004001D4 File Offset: 0x003FE3D4
		public static Offset<IEntityCustomPrimitiveData> EndIEntityCustomPrimitiveData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCustomPrimitiveData>(builder.EndTable());
		}

		// Token: 0x0601C420 RID: 115744 RVA: 0x004001E4 File Offset: 0x003FE3E4
		public IEntityCustomPrimitiveDataT UnPack()
		{
			IEntityCustomPrimitiveDataT entityCustomPrimitiveDataT = new IEntityCustomPrimitiveDataT();
			this.UnPackTo(entityCustomPrimitiveDataT);
			return entityCustomPrimitiveDataT;
		}

		// Token: 0x0601C421 RID: 115745 RVA: 0x00400200 File Offset: 0x003FE400
		public void UnPackTo(IEntityCustomPrimitiveDataT _o)
		{
			_o.Id = this.Id;
			_o.CustomData = new List<IEntityCustomPrimitiveData_CustomDataRowT>();
			for (int i = 0; i < this.CustomDataLength; i++)
			{
				_o.CustomData.Add((this.CustomData(i) != null) ? this.CustomData(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C422 RID: 115746 RVA: 0x0040026C File Offset: 0x003FE46C
		public static Offset<IEntityCustomPrimitiveData> Pack(FlatBufferBuilder builder, IEntityCustomPrimitiveDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityCustomPrimitiveData>);
			}
			VectorOffset customDataOffset = default(VectorOffset);
			if (_o.CustomData != null)
			{
				Offset<IEntityCustomPrimitiveData_CustomDataRow>[] array = new Offset<IEntityCustomPrimitiveData_CustomDataRow>[_o.CustomData.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityCustomPrimitiveData_CustomDataRow.Pack(builder, _o.CustomData[i]);
				}
				customDataOffset = IEntityCustomPrimitiveData.CreateCustomDataVector(builder, array);
			}
			return IEntityCustomPrimitiveData.CreateIEntityCustomPrimitiveData(builder, _o.Id, customDataOffset);
		}

		// Token: 0x0400CC0B RID: 52235
		private Table __p;
	}
}
