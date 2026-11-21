using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200441E RID: 17438
	public struct IQuestFailedConditionEntityDeath : IFlatbufferObject
	{
		// Token: 0x170078C0 RID: 30912
		// (get) Token: 0x06018F04 RID: 102148 RVA: 0x0038EA62 File Offset: 0x0038CC62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F05 RID: 102149 RVA: 0x0038EA6F File Offset: 0x0038CC6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F06 RID: 102150 RVA: 0x0038EA78 File Offset: 0x0038CC78
		public static IQuestFailedConditionEntityDeath GetRootAsIQuestFailedConditionEntityDeath(ByteBuffer _bb)
		{
			return IQuestFailedConditionEntityDeath.GetRootAsIQuestFailedConditionEntityDeath(_bb, default(IQuestFailedConditionEntityDeath));
		}

		// Token: 0x06018F07 RID: 102151 RVA: 0x0038EA94 File Offset: 0x0038CC94
		public static IQuestFailedConditionEntityDeath GetRootAsIQuestFailedConditionEntityDeath(ByteBuffer _bb, IQuestFailedConditionEntityDeath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F08 RID: 102152 RVA: 0x0038EAB1 File Offset: 0x0038CCB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F09 RID: 102153 RVA: 0x0038EAC0 File Offset: 0x0038CCC0
		public IQuestFailedConditionEntityDeath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018F0A RID: 102154 RVA: 0x0038EAD0 File Offset: 0x0038CCD0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170078C1 RID: 30913
		// (get) Token: 0x06018F0B RID: 102155 RVA: 0x0038EB10 File Offset: 0x0038CD10
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

		// Token: 0x06018F0C RID: 102156 RVA: 0x0038EB3B File Offset: 0x0038CD3B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06018F0D RID: 102157 RVA: 0x0038EB4A File Offset: 0x0038CD4A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06018F0E RID: 102158 RVA: 0x0038EB58 File Offset: 0x0038CD58
		public static Offset<IQuestFailedConditionEntityDeath> CreateIQuestFailedConditionEntityDeath(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IQuestFailedConditionEntityDeath.AddEntityIds(builder, EntityIdsOffset);
			return IQuestFailedConditionEntityDeath.EndIQuestFailedConditionEntityDeath(builder);
		}

		// Token: 0x06018F0F RID: 102159 RVA: 0x0038EB6E File Offset: 0x0038CD6E
		public static void StartIQuestFailedConditionEntityDeath(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018F10 RID: 102160 RVA: 0x0038EB77 File Offset: 0x0038CD77
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06018F11 RID: 102161 RVA: 0x0038EB88 File Offset: 0x0038CD88
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018F12 RID: 102162 RVA: 0x0038EBBF File Offset: 0x0038CDBF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F13 RID: 102163 RVA: 0x0038EBD9 File Offset: 0x0038CDD9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F14 RID: 102164 RVA: 0x0038EBF7 File Offset: 0x0038CDF7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018F15 RID: 102165 RVA: 0x0038EC10 File Offset: 0x0038CE10
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018F16 RID: 102166 RVA: 0x0038EC1B File Offset: 0x0038CE1B
		public static Offset<IQuestFailedConditionEntityDeath> EndIQuestFailedConditionEntityDeath(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionEntityDeath>(builder.EndTable());
		}

		// Token: 0x06018F17 RID: 102167 RVA: 0x0038EC28 File Offset: 0x0038CE28
		public IQuestFailedConditionEntityDeathT UnPack()
		{
			IQuestFailedConditionEntityDeathT questFailedConditionEntityDeathT = new IQuestFailedConditionEntityDeathT();
			this.UnPackTo(questFailedConditionEntityDeathT);
			return questFailedConditionEntityDeathT;
		}

		// Token: 0x06018F18 RID: 102168 RVA: 0x0038EC44 File Offset: 0x0038CE44
		public void UnPackTo(IQuestFailedConditionEntityDeathT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06018F19 RID: 102169 RVA: 0x0038EC80 File Offset: 0x0038CE80
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

		// Token: 0x0400C4C5 RID: 50373
		private Table __p;
	}
}
