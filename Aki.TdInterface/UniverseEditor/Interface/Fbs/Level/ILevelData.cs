using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Entity;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004874 RID: 18548
	public struct ILevelData : IFlatbufferObject
	{
		// Token: 0x1700812A RID: 33066
		// (get) Token: 0x0601B6D3 RID: 112339 RVA: 0x003E1D4F File Offset: 0x003DFF4F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B6D4 RID: 112340 RVA: 0x003E1D5C File Offset: 0x003DFF5C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B6D5 RID: 112341 RVA: 0x003E1D64 File Offset: 0x003DFF64
		public static ILevelData GetRootAsILevelData(ByteBuffer _bb)
		{
			return ILevelData.GetRootAsILevelData(_bb, default(ILevelData));
		}

		// Token: 0x0601B6D6 RID: 112342 RVA: 0x003E1D80 File Offset: 0x003DFF80
		public static ILevelData GetRootAsILevelData(ByteBuffer _bb, ILevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B6D7 RID: 112343 RVA: 0x003E1D9D File Offset: 0x003DFF9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B6D8 RID: 112344 RVA: 0x003E1DAC File Offset: 0x003DFFAC
		public ILevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601B6D9 RID: 112345 RVA: 0x003E1DBC File Offset: 0x003DFFBC
		public IEntityData? EntityDatas(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityData?(default(IEntityData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700812B RID: 33067
		// (get) Token: 0x0601B6DA RID: 112346 RVA: 0x003E1E1C File Offset: 0x003E001C
		public int EntityDatasLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601B6DB RID: 112347 RVA: 0x003E1E47 File Offset: 0x003E0047
		public static Offset<ILevelData> CreateILevelData(FlatBufferBuilder builder, VectorOffset EntityDatasOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILevelData.AddEntityDatas(builder, EntityDatasOffset);
			return ILevelData.EndILevelData(builder);
		}

		// Token: 0x0601B6DC RID: 112348 RVA: 0x003E1E5D File Offset: 0x003E005D
		public static void StartILevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B6DD RID: 112349 RVA: 0x003E1E66 File Offset: 0x003E0066
		public static void AddEntityDatas(FlatBufferBuilder builder, VectorOffset entityDatasOffset)
		{
			builder.AddOffset(0, entityDatasOffset.Value, 0);
		}

		// Token: 0x0601B6DE RID: 112350 RVA: 0x003E1E78 File Offset: 0x003E0078
		public static VectorOffset CreateEntityDatasVector(FlatBufferBuilder builder, Offset<IEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B6DF RID: 112351 RVA: 0x003E1EB8 File Offset: 0x003E00B8
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, Offset<IEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B6E0 RID: 112352 RVA: 0x003E1ED2 File Offset: 0x003E00D2
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B6E1 RID: 112353 RVA: 0x003E1EF0 File Offset: 0x003E00F0
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B6E2 RID: 112354 RVA: 0x003E1F09 File Offset: 0x003E0109
		public static void StartEntityDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B6E3 RID: 112355 RVA: 0x003E1F14 File Offset: 0x003E0114
		public static Offset<ILevelData> EndILevelData(FlatBufferBuilder builder)
		{
			return new Offset<ILevelData>(builder.EndTable());
		}

		// Token: 0x0601B6E4 RID: 112356 RVA: 0x003E1F24 File Offset: 0x003E0124
		public ILevelDataT UnPack()
		{
			ILevelDataT levelDataT = new ILevelDataT();
			this.UnPackTo(levelDataT);
			return levelDataT;
		}

		// Token: 0x0601B6E5 RID: 112357 RVA: 0x003E1F40 File Offset: 0x003E0140
		public void UnPackTo(ILevelDataT _o)
		{
			_o.EntityDatas = new List<IEntityDataT>();
			for (int i = 0; i < this.EntityDatasLength; i++)
			{
				_o.EntityDatas.Add((this.EntityDatas(i) != null) ? this.EntityDatas(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B6E6 RID: 112358 RVA: 0x003E1FA0 File Offset: 0x003E01A0
		public static Offset<ILevelData> Pack(FlatBufferBuilder builder, ILevelDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelData>);
			}
			VectorOffset entityDatasOffset = default(VectorOffset);
			if (_o.EntityDatas != null)
			{
				Offset<IEntityData>[] array = new Offset<IEntityData>[_o.EntityDatas.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityData.Pack(builder, _o.EntityDatas[i]);
				}
				entityDatasOffset = ILevelData.CreateEntityDatasVector(builder, array);
			}
			return ILevelData.CreateILevelData(builder, entityDatasOffset);
		}

		// Token: 0x0400CD98 RID: 52632
		private Table __p;
	}
}
