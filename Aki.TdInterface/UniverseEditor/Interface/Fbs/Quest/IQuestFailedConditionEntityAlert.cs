using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200441B RID: 17435
	public struct IQuestFailedConditionEntityAlert : IFlatbufferObject
	{
		// Token: 0x170078BD RID: 30909
		// (get) Token: 0x06018EEA RID: 102122 RVA: 0x0038E7BE File Offset: 0x0038C9BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018EEB RID: 102123 RVA: 0x0038E7CB File Offset: 0x0038C9CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018EEC RID: 102124 RVA: 0x0038E7D4 File Offset: 0x0038C9D4
		public static IQuestFailedConditionEntityAlert GetRootAsIQuestFailedConditionEntityAlert(ByteBuffer _bb)
		{
			return IQuestFailedConditionEntityAlert.GetRootAsIQuestFailedConditionEntityAlert(_bb, default(IQuestFailedConditionEntityAlert));
		}

		// Token: 0x06018EED RID: 102125 RVA: 0x0038E7F0 File Offset: 0x0038C9F0
		public static IQuestFailedConditionEntityAlert GetRootAsIQuestFailedConditionEntityAlert(ByteBuffer _bb, IQuestFailedConditionEntityAlert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018EEE RID: 102126 RVA: 0x0038E80D File Offset: 0x0038CA0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018EEF RID: 102127 RVA: 0x0038E81C File Offset: 0x0038CA1C
		public IQuestFailedConditionEntityAlert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018EF0 RID: 102128 RVA: 0x0038E82C File Offset: 0x0038CA2C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170078BE RID: 30910
		// (get) Token: 0x06018EF1 RID: 102129 RVA: 0x0038E86C File Offset: 0x0038CA6C
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

		// Token: 0x06018EF2 RID: 102130 RVA: 0x0038E897 File Offset: 0x0038CA97
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06018EF3 RID: 102131 RVA: 0x0038E8A6 File Offset: 0x0038CAA6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06018EF4 RID: 102132 RVA: 0x0038E8B4 File Offset: 0x0038CAB4
		public static Offset<IQuestFailedConditionEntityAlert> CreateIQuestFailedConditionEntityAlert(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IQuestFailedConditionEntityAlert.AddEntityIds(builder, EntityIdsOffset);
			return IQuestFailedConditionEntityAlert.EndIQuestFailedConditionEntityAlert(builder);
		}

		// Token: 0x06018EF5 RID: 102133 RVA: 0x0038E8CA File Offset: 0x0038CACA
		public static void StartIQuestFailedConditionEntityAlert(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018EF6 RID: 102134 RVA: 0x0038E8D3 File Offset: 0x0038CAD3
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06018EF7 RID: 102135 RVA: 0x0038E8E4 File Offset: 0x0038CAE4
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018EF8 RID: 102136 RVA: 0x0038E91B File Offset: 0x0038CB1B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018EF9 RID: 102137 RVA: 0x0038E935 File Offset: 0x0038CB35
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018EFA RID: 102138 RVA: 0x0038E953 File Offset: 0x0038CB53
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018EFB RID: 102139 RVA: 0x0038E96C File Offset: 0x0038CB6C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018EFC RID: 102140 RVA: 0x0038E977 File Offset: 0x0038CB77
		public static Offset<IQuestFailedConditionEntityAlert> EndIQuestFailedConditionEntityAlert(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionEntityAlert>(builder.EndTable());
		}

		// Token: 0x06018EFD RID: 102141 RVA: 0x0038E984 File Offset: 0x0038CB84
		public IQuestFailedConditionEntityAlertT UnPack()
		{
			IQuestFailedConditionEntityAlertT questFailedConditionEntityAlertT = new IQuestFailedConditionEntityAlertT();
			this.UnPackTo(questFailedConditionEntityAlertT);
			return questFailedConditionEntityAlertT;
		}

		// Token: 0x06018EFE RID: 102142 RVA: 0x0038E9A0 File Offset: 0x0038CBA0
		public void UnPackTo(IQuestFailedConditionEntityAlertT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06018EFF RID: 102143 RVA: 0x0038E9DC File Offset: 0x0038CBDC
		public static Offset<IQuestFailedConditionEntityAlert> Pack(FlatBufferBuilder builder, IQuestFailedConditionEntityAlertT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConditionEntityAlert>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IQuestFailedConditionEntityAlert.CreateEntityIdsVector(builder, data);
			}
			return IQuestFailedConditionEntityAlert.CreateIQuestFailedConditionEntityAlert(builder, entityIdsOffset);
		}

		// Token: 0x0400C4C3 RID: 50371
		private Table __p;
	}
}
