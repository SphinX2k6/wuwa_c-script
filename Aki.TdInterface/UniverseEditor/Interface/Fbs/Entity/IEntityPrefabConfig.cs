using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047CC RID: 18380
	public struct IEntityPrefabConfig : IFlatbufferObject
	{
		// Token: 0x17008411 RID: 33809
		// (get) Token: 0x0601C657 RID: 116311 RVA: 0x00404AA7 File Offset: 0x00402CA7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C658 RID: 116312 RVA: 0x00404AB4 File Offset: 0x00402CB4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C659 RID: 116313 RVA: 0x00404ABC File Offset: 0x00402CBC
		public static IEntityPrefabConfig GetRootAsIEntityPrefabConfig(ByteBuffer _bb)
		{
			return IEntityPrefabConfig.GetRootAsIEntityPrefabConfig(_bb, default(IEntityPrefabConfig));
		}

		// Token: 0x0601C65A RID: 116314 RVA: 0x00404AD8 File Offset: 0x00402CD8
		public static IEntityPrefabConfig GetRootAsIEntityPrefabConfig(ByteBuffer _bb, IEntityPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C65B RID: 116315 RVA: 0x00404AF5 File Offset: 0x00402CF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C65C RID: 116316 RVA: 0x00404B04 File Offset: 0x00402D04
		public IEntityPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C65D RID: 116317 RVA: 0x00404B14 File Offset: 0x00402D14
		public IEntityPrefab? Prefabs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityPrefab?(default(IEntityPrefab).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008412 RID: 33810
		// (get) Token: 0x0601C65E RID: 116318 RVA: 0x00404B74 File Offset: 0x00402D74
		public int PrefabsLength
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

		// Token: 0x0601C65F RID: 116319 RVA: 0x00404B9F File Offset: 0x00402D9F
		public static Offset<IEntityPrefabConfig> CreateIEntityPrefabConfig(FlatBufferBuilder builder, VectorOffset PrefabsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityPrefabConfig.AddPrefabs(builder, PrefabsOffset);
			return IEntityPrefabConfig.EndIEntityPrefabConfig(builder);
		}

		// Token: 0x0601C660 RID: 116320 RVA: 0x00404BB5 File Offset: 0x00402DB5
		public static void StartIEntityPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C661 RID: 116321 RVA: 0x00404BBE File Offset: 0x00402DBE
		public static void AddPrefabs(FlatBufferBuilder builder, VectorOffset prefabsOffset)
		{
			builder.AddOffset(0, prefabsOffset.Value, 0);
		}

		// Token: 0x0601C662 RID: 116322 RVA: 0x00404BD0 File Offset: 0x00402DD0
		public static VectorOffset CreatePrefabsVector(FlatBufferBuilder builder, Offset<IEntityPrefab>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C663 RID: 116323 RVA: 0x00404C10 File Offset: 0x00402E10
		public static VectorOffset CreatePrefabsVectorBlock(FlatBufferBuilder builder, Offset<IEntityPrefab>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityPrefab>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C664 RID: 116324 RVA: 0x00404C2A File Offset: 0x00402E2A
		public static VectorOffset CreatePrefabsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityPrefab>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityPrefab>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C665 RID: 116325 RVA: 0x00404C48 File Offset: 0x00402E48
		public static VectorOffset CreatePrefabsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityPrefab>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C666 RID: 116326 RVA: 0x00404C61 File Offset: 0x00402E61
		public static void StartPrefabsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C667 RID: 116327 RVA: 0x00404C6C File Offset: 0x00402E6C
		public static Offset<IEntityPrefabConfig> EndIEntityPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPrefabConfig>(builder.EndTable());
		}

		// Token: 0x0601C668 RID: 116328 RVA: 0x00404C7C File Offset: 0x00402E7C
		public IEntityPrefabConfigT UnPack()
		{
			IEntityPrefabConfigT entityPrefabConfigT = new IEntityPrefabConfigT();
			this.UnPackTo(entityPrefabConfigT);
			return entityPrefabConfigT;
		}

		// Token: 0x0601C669 RID: 116329 RVA: 0x00404C98 File Offset: 0x00402E98
		public void UnPackTo(IEntityPrefabConfigT _o)
		{
			_o.Prefabs = new List<IEntityPrefabT>();
			for (int i = 0; i < this.PrefabsLength; i++)
			{
				_o.Prefabs.Add((this.Prefabs(i) != null) ? this.Prefabs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C66A RID: 116330 RVA: 0x00404CF8 File Offset: 0x00402EF8
		public static Offset<IEntityPrefabConfig> Pack(FlatBufferBuilder builder, IEntityPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPrefabConfig>);
			}
			VectorOffset prefabsOffset = default(VectorOffset);
			if (_o.Prefabs != null)
			{
				Offset<IEntityPrefab>[] array = new Offset<IEntityPrefab>[_o.Prefabs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityPrefab.Pack(builder, _o.Prefabs[i]);
				}
				prefabsOffset = IEntityPrefabConfig.CreatePrefabsVector(builder, array);
			}
			return IEntityPrefabConfig.CreateIEntityPrefabConfig(builder, prefabsOffset);
		}

		// Token: 0x0400CC5D RID: 52317
		private Table __p;
	}
}
