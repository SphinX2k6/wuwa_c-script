using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Entity;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200440C RID: 17420
	public struct ILevelData : IFlatbufferObject
	{
		// Token: 0x17007AEB RID: 31467
		// (get) Token: 0x06019F02 RID: 106242 RVA: 0x003B5B43 File Offset: 0x003B3D43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F03 RID: 106243 RVA: 0x003B5B50 File Offset: 0x003B3D50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F04 RID: 106244 RVA: 0x003B5B58 File Offset: 0x003B3D58
		public static ILevelData GetRootAsILevelData(ByteBuffer _bb)
		{
			return ILevelData.GetRootAsILevelData(_bb, default(ILevelData));
		}

		// Token: 0x06019F05 RID: 106245 RVA: 0x003B5B74 File Offset: 0x003B3D74
		public static ILevelData GetRootAsILevelData(ByteBuffer _bb, ILevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F06 RID: 106246 RVA: 0x003B5B91 File Offset: 0x003B3D91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F07 RID: 106247 RVA: 0x003B5BA0 File Offset: 0x003B3DA0
		public ILevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019F08 RID: 106248 RVA: 0x003B5BB0 File Offset: 0x003B3DB0
		public IEntityData? EntityDatas(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityData?(default(IEntityData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007AEC RID: 31468
		// (get) Token: 0x06019F09 RID: 106249 RVA: 0x003B5C10 File Offset: 0x003B3E10
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

		// Token: 0x06019F0A RID: 106250 RVA: 0x003B5C3B File Offset: 0x003B3E3B
		public static Offset<ILevelData> CreateILevelData(FlatBufferBuilder builder, VectorOffset EntityDatasOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILevelData.AddEntityDatas(builder, EntityDatasOffset);
			return ILevelData.EndILevelData(builder);
		}

		// Token: 0x06019F0B RID: 106251 RVA: 0x003B5C51 File Offset: 0x003B3E51
		public static void StartILevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019F0C RID: 106252 RVA: 0x003B5C5A File Offset: 0x003B3E5A
		public static void AddEntityDatas(FlatBufferBuilder builder, VectorOffset entityDatasOffset)
		{
			builder.AddOffset(0, entityDatasOffset.Value, 0);
		}

		// Token: 0x06019F0D RID: 106253 RVA: 0x003B5C6C File Offset: 0x003B3E6C
		public static VectorOffset CreateEntityDatasVector(FlatBufferBuilder builder, Offset<IEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019F0E RID: 106254 RVA: 0x003B5CAC File Offset: 0x003B3EAC
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, Offset<IEntityData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F0F RID: 106255 RVA: 0x003B5CC6 File Offset: 0x003B3EC6
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F10 RID: 106256 RVA: 0x003B5CE4 File Offset: 0x003B3EE4
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019F11 RID: 106257 RVA: 0x003B5CFD File Offset: 0x003B3EFD
		public static void StartEntityDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019F12 RID: 106258 RVA: 0x003B5D08 File Offset: 0x003B3F08
		public static Offset<ILevelData> EndILevelData(FlatBufferBuilder builder)
		{
			return new Offset<ILevelData>(builder.EndTable());
		}

		// Token: 0x06019F13 RID: 106259 RVA: 0x003B5D18 File Offset: 0x003B3F18
		public ILevelDataT UnPack()
		{
			ILevelDataT levelDataT = new ILevelDataT();
			this.UnPackTo(levelDataT);
			return levelDataT;
		}

		// Token: 0x06019F14 RID: 106260 RVA: 0x003B5D34 File Offset: 0x003B3F34
		public void UnPackTo(ILevelDataT _o)
		{
			_o.EntityDatas = new List<IEntityDataT>();
			for (int i = 0; i < this.EntityDatasLength; i++)
			{
				_o.EntityDatas.Add((this.EntityDatas(i) != null) ? this.EntityDatas(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06019F15 RID: 106261 RVA: 0x003B5D94 File Offset: 0x003B3F94
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

		// Token: 0x0400C36B RID: 50027
		private Table __p;
	}
}
