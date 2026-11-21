using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC7 RID: 19911
	public struct TCsvLoopTeleportData : IFlatbufferObject
	{
		// Token: 0x17008E6A RID: 36458
		// (get) Token: 0x0601EE49 RID: 126537 RVA: 0x00450E6A File Offset: 0x0044F06A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE4A RID: 126538 RVA: 0x00450E77 File Offset: 0x0044F077
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE4B RID: 126539 RVA: 0x00450E80 File Offset: 0x0044F080
		public static TCsvLoopTeleportData GetRootAsTCsvLoopTeleportData(ByteBuffer _bb)
		{
			return TCsvLoopTeleportData.GetRootAsTCsvLoopTeleportData(_bb, default(TCsvLoopTeleportData));
		}

		// Token: 0x0601EE4C RID: 126540 RVA: 0x00450E9C File Offset: 0x0044F09C
		public static TCsvLoopTeleportData GetRootAsTCsvLoopTeleportData(ByteBuffer _bb, TCsvLoopTeleportData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE4D RID: 126541 RVA: 0x00450EB9 File Offset: 0x0044F0B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE4E RID: 126542 RVA: 0x00450EC8 File Offset: 0x0044F0C8
		public TCsvLoopTeleportData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E6B RID: 36459
		// (get) Token: 0x0601EE4F RID: 126543 RVA: 0x00450ED8 File Offset: 0x0044F0D8
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

		// Token: 0x17008E6C RID: 36460
		// (get) Token: 0x0601EE50 RID: 126544 RVA: 0x00450F14 File Offset: 0x0044F114
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601EE51 RID: 126545 RVA: 0x00450F74 File Offset: 0x0044F174
		public ILoopTeleportClientLogicItemBase_Union ClientLogicType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return ILoopTeleportClientLogicItemBase_Union.NONE;
			}
			return (ILoopTeleportClientLogicItemBase_Union)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008E6D RID: 36461
		// (get) Token: 0x0601EE52 RID: 126546 RVA: 0x00450FB4 File Offset: 0x0044F1B4
		public int ClientLogicTypeLength
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

		// Token: 0x0601EE53 RID: 126547 RVA: 0x00450FDF File Offset: 0x0044F1DF
		public Span<ILoopTeleportClientLogicItemBase_Union> GetClientLogicTypeBytes()
		{
			return this.__p.__vector_as_span<ILoopTeleportClientLogicItemBase_Union>(8, 1);
		}

		// Token: 0x0601EE54 RID: 126548 RVA: 0x00450FF0 File Offset: 0x0044F1F0
		public ILoopTeleportClientLogicItemBase_Union[] GetClientLogicTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ILoopTeleportClientLogicItemBase_Union[] array = new ILoopTeleportClientLogicItemBase_Union[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ILoopTeleportClientLogicItemBase_Union)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601EE55 RID: 126549 RVA: 0x0045105C File Offset: 0x0044F25C
		public TTable? ClientLogic<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008E6E RID: 36462
		// (get) Token: 0x0601EE56 RID: 126550 RVA: 0x004510A4 File Offset: 0x0044F2A4
		public int ClientLogicLength
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

		// Token: 0x0601EE57 RID: 126551 RVA: 0x004510D0 File Offset: 0x0044F2D0
		public static Offset<TCsvLoopTeleportData> CreateTCsvLoopTeleportData(FlatBufferBuilder builder, int Id = 0, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ClientLogic_typeOffset = default(VectorOffset), VectorOffset ClientLogicOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			TCsvLoopTeleportData.AddClientLogic(builder, ClientLogicOffset);
			TCsvLoopTeleportData.AddClientLogicType(builder, ClientLogic_typeOffset);
			TCsvLoopTeleportData.AddConditions(builder, ConditionsOffset);
			TCsvLoopTeleportData.AddId(builder, Id);
			return TCsvLoopTeleportData.EndTCsvLoopTeleportData(builder);
		}

		// Token: 0x0601EE58 RID: 126552 RVA: 0x004510FC File Offset: 0x0044F2FC
		public static void StartTCsvLoopTeleportData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EE59 RID: 126553 RVA: 0x00451105 File Offset: 0x0044F305
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601EE5A RID: 126554 RVA: 0x00451110 File Offset: 0x0044F310
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0601EE5B RID: 126555 RVA: 0x00451120 File Offset: 0x0044F320
		public static void AddClientLogicType(FlatBufferBuilder builder, VectorOffset clientLogicTypeOffset)
		{
			builder.AddOffset(2, clientLogicTypeOffset.Value, 0);
		}

		// Token: 0x0601EE5C RID: 126556 RVA: 0x00451130 File Offset: 0x0044F330
		public static VectorOffset CreateClientLogicTypeVector(FlatBufferBuilder builder, ILoopTeleportClientLogicItemBase_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EE5D RID: 126557 RVA: 0x00451167 File Offset: 0x0044F367
		public static VectorOffset CreateClientLogicTypeVectorBlock(FlatBufferBuilder builder, ILoopTeleportClientLogicItemBase_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ILoopTeleportClientLogicItemBase_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE5E RID: 126558 RVA: 0x00451181 File Offset: 0x0044F381
		public static VectorOffset CreateClientLogicTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<ILoopTeleportClientLogicItemBase_Union> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ILoopTeleportClientLogicItemBase_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE5F RID: 126559 RVA: 0x0045119F File Offset: 0x0044F39F
		public static VectorOffset CreateClientLogicTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ILoopTeleportClientLogicItemBase_Union>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EE60 RID: 126560 RVA: 0x004511B8 File Offset: 0x0044F3B8
		public static void StartClientLogicTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601EE61 RID: 126561 RVA: 0x004511C3 File Offset: 0x0044F3C3
		public static void AddClientLogic(FlatBufferBuilder builder, VectorOffset clientLogicOffset)
		{
			builder.AddOffset(3, clientLogicOffset.Value, 0);
		}

		// Token: 0x0601EE62 RID: 126562 RVA: 0x004511D4 File Offset: 0x0044F3D4
		public static VectorOffset CreateClientLogicVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EE63 RID: 126563 RVA: 0x0045120B File Offset: 0x0044F40B
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE64 RID: 126564 RVA: 0x00451225 File Offset: 0x0044F425
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE65 RID: 126565 RVA: 0x00451243 File Offset: 0x0044F443
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EE66 RID: 126566 RVA: 0x0045125C File Offset: 0x0044F45C
		public static void StartClientLogicVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EE67 RID: 126567 RVA: 0x00451267 File Offset: 0x0044F467
		public static Offset<TCsvLoopTeleportData> EndTCsvLoopTeleportData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvLoopTeleportData>(builder.EndTable());
		}

		// Token: 0x0601EE68 RID: 126568 RVA: 0x00451274 File Offset: 0x0044F474
		public TCsvLoopTeleportDataT UnPack()
		{
			TCsvLoopTeleportDataT tcsvLoopTeleportDataT = new TCsvLoopTeleportDataT();
			this.UnPackTo(tcsvLoopTeleportDataT);
			return tcsvLoopTeleportDataT;
		}

		// Token: 0x0601EE69 RID: 126569 RVA: 0x00451290 File Offset: 0x0044F490
		public void UnPackTo(TCsvLoopTeleportDataT _o)
		{
			_o.Id = this.Id;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.ClientLogic = new List<ILoopTeleportClientLogicItemBase_UnionUnion>();
			for (int i = 0; i < this.ClientLogicLength; i++)
			{
				ILoopTeleportClientLogicItemBase_UnionUnion loopTeleportClientLogicItemBase_UnionUnion = new ILoopTeleportClientLogicItemBase_UnionUnion();
				loopTeleportClientLogicItemBase_UnionUnion.Type = this.ClientLogicType(i);
				ILoopTeleportClientLogicItemBase_Union loopTeleportClientLogicItemBase_Union = this.ClientLogicType(i);
				if (loopTeleportClientLogicItemBase_Union != ILoopTeleportClientLogicItemBase_Union.ILoopTeleportClientLogicItemBase)
				{
					if (loopTeleportClientLogicItemBase_Union == ILoopTeleportClientLogicItemBase_Union.ILoopTeleportClientPlayEffectLogic)
					{
						loopTeleportClientLogicItemBase_UnionUnion.Value = ((this.ClientLogic<ILoopTeleportClientPlayEffectLogic>(i) != null) ? this.ClientLogic<ILoopTeleportClientPlayEffectLogic>(i).Value.UnPack() : null);
					}
				}
				else
				{
					loopTeleportClientLogicItemBase_UnionUnion.Value = ((this.ClientLogic<ILoopTeleportClientLogicItemBase>(i) != null) ? this.ClientLogic<ILoopTeleportClientLogicItemBase>(i).Value.UnPack() : null);
				}
				_o.ClientLogic.Add(loopTeleportClientLogicItemBase_UnionUnion);
			}
		}

		// Token: 0x0601EE6A RID: 126570 RVA: 0x00451398 File Offset: 0x0044F598
		public static Offset<TCsvLoopTeleportData> Pack(FlatBufferBuilder builder, TCsvLoopTeleportDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvLoopTeleportData>);
			}
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			VectorOffset clientLogic_typeOffset = default(VectorOffset);
			if (_o.ClientLogic != null)
			{
				ILoopTeleportClientLogicItemBase_Union[] array = new ILoopTeleportClientLogicItemBase_Union[_o.ClientLogic.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.ClientLogic[i].Type;
				}
				clientLogic_typeOffset = TCsvLoopTeleportData.CreateClientLogicTypeVector(builder, array);
			}
			VectorOffset clientLogicOffset = default(VectorOffset);
			if (_o.ClientLogic != null)
			{
				int[] array2 = new int[_o.ClientLogic.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ILoopTeleportClientLogicItemBase_UnionUnion.Pack(builder, _o.ClientLogic[j]);
				}
				clientLogicOffset = TCsvLoopTeleportData.CreateClientLogicVector(builder, array2);
			}
			return TCsvLoopTeleportData.CreateTCsvLoopTeleportData(builder, _o.Id, conditionsOffset, clientLogic_typeOffset, clientLogicOffset);
		}

		// Token: 0x0400DA3A RID: 55866
		private Table __p;
	}
}
