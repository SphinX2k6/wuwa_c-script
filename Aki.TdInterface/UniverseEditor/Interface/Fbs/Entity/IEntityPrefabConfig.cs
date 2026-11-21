using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C34 RID: 19508
	public struct IEntityPrefabConfig : IFlatbufferObject
	{
		// Token: 0x17008A52 RID: 35410
		// (get) Token: 0x0601DE2C RID: 122412 RVA: 0x00430D43 File Offset: 0x0042EF43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE2D RID: 122413 RVA: 0x00430D50 File Offset: 0x0042EF50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE2E RID: 122414 RVA: 0x00430D58 File Offset: 0x0042EF58
		public static IEntityPrefabConfig GetRootAsIEntityPrefabConfig(ByteBuffer _bb)
		{
			return IEntityPrefabConfig.GetRootAsIEntityPrefabConfig(_bb, default(IEntityPrefabConfig));
		}

		// Token: 0x0601DE2F RID: 122415 RVA: 0x00430D74 File Offset: 0x0042EF74
		public static IEntityPrefabConfig GetRootAsIEntityPrefabConfig(ByteBuffer _bb, IEntityPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE30 RID: 122416 RVA: 0x00430D91 File Offset: 0x0042EF91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE31 RID: 122417 RVA: 0x00430DA0 File Offset: 0x0042EFA0
		public IEntityPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DE32 RID: 122418 RVA: 0x00430DB0 File Offset: 0x0042EFB0
		public IEntityPrefab? Prefabs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityPrefab?(default(IEntityPrefab).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008A53 RID: 35411
		// (get) Token: 0x0601DE33 RID: 122419 RVA: 0x00430E10 File Offset: 0x0042F010
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

		// Token: 0x0601DE34 RID: 122420 RVA: 0x00430E3B File Offset: 0x0042F03B
		public static Offset<IEntityPrefabConfig> CreateIEntityPrefabConfig(FlatBufferBuilder builder, VectorOffset PrefabsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityPrefabConfig.AddPrefabs(builder, PrefabsOffset);
			return IEntityPrefabConfig.EndIEntityPrefabConfig(builder);
		}

		// Token: 0x0601DE35 RID: 122421 RVA: 0x00430E51 File Offset: 0x0042F051
		public static void StartIEntityPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DE36 RID: 122422 RVA: 0x00430E5A File Offset: 0x0042F05A
		public static void AddPrefabs(FlatBufferBuilder builder, VectorOffset prefabsOffset)
		{
			builder.AddOffset(0, prefabsOffset.Value, 0);
		}

		// Token: 0x0601DE37 RID: 122423 RVA: 0x00430E6C File Offset: 0x0042F06C
		public static VectorOffset CreatePrefabsVector(FlatBufferBuilder builder, Offset<IEntityPrefab>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DE38 RID: 122424 RVA: 0x00430EAC File Offset: 0x0042F0AC
		public static VectorOffset CreatePrefabsVectorBlock(FlatBufferBuilder builder, Offset<IEntityPrefab>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityPrefab>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE39 RID: 122425 RVA: 0x00430EC6 File Offset: 0x0042F0C6
		public static VectorOffset CreatePrefabsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityPrefab>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityPrefab>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE3A RID: 122426 RVA: 0x00430EE4 File Offset: 0x0042F0E4
		public static VectorOffset CreatePrefabsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityPrefab>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE3B RID: 122427 RVA: 0x00430EFD File Offset: 0x0042F0FD
		public static void StartPrefabsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE3C RID: 122428 RVA: 0x00430F08 File Offset: 0x0042F108
		public static Offset<IEntityPrefabConfig> EndIEntityPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPrefabConfig>(builder.EndTable());
		}

		// Token: 0x0601DE3D RID: 122429 RVA: 0x00430F18 File Offset: 0x0042F118
		public IEntityPrefabConfigT UnPack()
		{
			IEntityPrefabConfigT entityPrefabConfigT = new IEntityPrefabConfigT();
			this.UnPackTo(entityPrefabConfigT);
			return entityPrefabConfigT;
		}

		// Token: 0x0601DE3E RID: 122430 RVA: 0x00430F34 File Offset: 0x0042F134
		public void UnPackTo(IEntityPrefabConfigT _o)
		{
			_o.Prefabs = new List<IEntityPrefabT>();
			for (int i = 0; i < this.PrefabsLength; i++)
			{
				_o.Prefabs.Add((this.Prefabs(i) != null) ? this.Prefabs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DE3F RID: 122431 RVA: 0x00430F94 File Offset: 0x0042F194
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

		// Token: 0x0400D693 RID: 54931
		private Table __p;
	}
}
