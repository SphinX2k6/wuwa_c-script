using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FDD RID: 16349
	public struct IQuestFailedConditionEntityDeath : IFlatbufferObject
	{
		// Token: 0x170072BE RID: 29374
		// (get) Token: 0x0601786B RID: 96363 RVA: 0x00364C6E File Offset: 0x00362E6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601786C RID: 96364 RVA: 0x00364C7B File Offset: 0x00362E7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601786D RID: 96365 RVA: 0x00364C84 File Offset: 0x00362E84
		public static IQuestFailedConditionEntityDeath GetRootAsIQuestFailedConditionEntityDeath(ByteBuffer _bb)
		{
			return IQuestFailedConditionEntityDeath.GetRootAsIQuestFailedConditionEntityDeath(_bb, default(IQuestFailedConditionEntityDeath));
		}

		// Token: 0x0601786E RID: 96366 RVA: 0x00364CA0 File Offset: 0x00362EA0
		public static IQuestFailedConditionEntityDeath GetRootAsIQuestFailedConditionEntityDeath(ByteBuffer _bb, IQuestFailedConditionEntityDeath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601786F RID: 96367 RVA: 0x00364CBD File Offset: 0x00362EBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017870 RID: 96368 RVA: 0x00364CCC File Offset: 0x00362ECC
		public IQuestFailedConditionEntityDeath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06017871 RID: 96369 RVA: 0x00364CDC File Offset: 0x00362EDC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170072BF RID: 29375
		// (get) Token: 0x06017872 RID: 96370 RVA: 0x00364D1C File Offset: 0x00362F1C
		public int EntityIdsLength
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

		// Token: 0x06017873 RID: 96371 RVA: 0x00364D47 File Offset: 0x00362F47
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06017874 RID: 96372 RVA: 0x00364D56 File Offset: 0x00362F56
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06017875 RID: 96373 RVA: 0x00364D64 File Offset: 0x00362F64
		public static Offset<IQuestFailedConditionEntityDeath> CreateIQuestFailedConditionEntityDeath(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IQuestFailedConditionEntityDeath.AddEntityIds(builder, EntityIdsOffset);
			return IQuestFailedConditionEntityDeath.EndIQuestFailedConditionEntityDeath(builder);
		}

		// Token: 0x06017876 RID: 96374 RVA: 0x00364D7A File Offset: 0x00362F7A
		public static void StartIQuestFailedConditionEntityDeath(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017877 RID: 96375 RVA: 0x00364D83 File Offset: 0x00362F83
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06017878 RID: 96376 RVA: 0x00364D94 File Offset: 0x00362F94
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017879 RID: 96377 RVA: 0x00364DCB File Offset: 0x00362FCB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601787A RID: 96378 RVA: 0x00364DE5 File Offset: 0x00362FE5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601787B RID: 96379 RVA: 0x00364E03 File Offset: 0x00363003
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601787C RID: 96380 RVA: 0x00364E1C File Offset: 0x0036301C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601787D RID: 96381 RVA: 0x00364E27 File Offset: 0x00363027
		public static Offset<IQuestFailedConditionEntityDeath> EndIQuestFailedConditionEntityDeath(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionEntityDeath>(builder.EndTable());
		}

		// Token: 0x0601787E RID: 96382 RVA: 0x00364E34 File Offset: 0x00363034
		public IQuestFailedConditionEntityDeathT UnPack()
		{
			IQuestFailedConditionEntityDeathT questFailedConditionEntityDeathT = new IQuestFailedConditionEntityDeathT();
			this.UnPackTo(questFailedConditionEntityDeathT);
			return questFailedConditionEntityDeathT;
		}

		// Token: 0x0601787F RID: 96383 RVA: 0x00364E50 File Offset: 0x00363050
		public void UnPackTo(IQuestFailedConditionEntityDeathT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06017880 RID: 96384 RVA: 0x00364E8C File Offset: 0x0036308C
		public static Offset<IQuestFailedConditionEntityDeath> Pack(FlatBufferBuilder builder, IQuestFailedConditionEntityDeathT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConditionEntityDeath>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IQuestFailedConditionEntityDeath.CreateEntityIdsVector(builder, data);
			}
			return IQuestFailedConditionEntityDeath.CreateIQuestFailedConditionEntityDeath(builder, entityIdsOffset);
		}

		// Token: 0x0400BADE RID: 47838
		private Table __p;
	}
}
