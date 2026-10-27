using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004917 RID: 18711
	public struct TCsvLoopTeleportData : IFlatbufferObject
	{
		// Token: 0x170087B1 RID: 34737
		// (get) Token: 0x0601D430 RID: 119856 RVA: 0x00420AB4 File Offset: 0x0041ECB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D431 RID: 119857 RVA: 0x00420AC1 File Offset: 0x0041ECC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D432 RID: 119858 RVA: 0x00420AC8 File Offset: 0x0041ECC8
		public static TCsvLoopTeleportData GetRootAsTCsvLoopTeleportData(ByteBuffer _bb)
		{
			return TCsvLoopTeleportData.GetRootAsTCsvLoopTeleportData(_bb, default(TCsvLoopTeleportData));
		}

		// Token: 0x0601D433 RID: 119859 RVA: 0x00420AE4 File Offset: 0x0041ECE4
		public static TCsvLoopTeleportData GetRootAsTCsvLoopTeleportData(ByteBuffer _bb, TCsvLoopTeleportData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D434 RID: 119860 RVA: 0x00420B01 File Offset: 0x0041ED01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D435 RID: 119861 RVA: 0x00420B10 File Offset: 0x0041ED10
		public TCsvLoopTeleportData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087B2 RID: 34738
		// (get) Token: 0x0601D436 RID: 119862 RVA: 0x00420B20 File Offset: 0x0041ED20
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

		// Token: 0x170087B3 RID: 34739
		// (get) Token: 0x0601D437 RID: 119863 RVA: 0x00420B5C File Offset: 0x0041ED5C
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

		// Token: 0x0601D438 RID: 119864 RVA: 0x00420BBC File Offset: 0x0041EDBC
		public ILoopTeleportClientLogicItemBase_Union ClientLogicType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return ILoopTeleportClientLogicItemBase_Union.NONE;
			}
			return (ILoopTeleportClientLogicItemBase_Union)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170087B4 RID: 34740
		// (get) Token: 0x0601D439 RID: 119865 RVA: 0x00420BFC File Offset: 0x0041EDFC
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

		// Token: 0x0601D43A RID: 119866 RVA: 0x00420C27 File Offset: 0x0041EE27
		public Span<ILoopTeleportClientLogicItemBase_Union> GetClientLogicTypeBytes()
		{
			return this.__p.__vector_as_span<ILoopTeleportClientLogicItemBase_Union>(8, 1);
		}

		// Token: 0x0601D43B RID: 119867 RVA: 0x00420C38 File Offset: 0x0041EE38
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

		// Token: 0x0601D43C RID: 119868 RVA: 0x00420CA4 File Offset: 0x0041EEA4
		public TTable? ClientLogic<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170087B5 RID: 34741
		// (get) Token: 0x0601D43D RID: 119869 RVA: 0x00420CEC File Offset: 0x0041EEEC
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

		// Token: 0x0601D43E RID: 119870 RVA: 0x00420D18 File Offset: 0x0041EF18
		public static Offset<TCsvLoopTeleportData> CreateTCsvLoopTeleportData(FlatBufferBuilder builder, int Id = 0, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ClientLogic_typeOffset = default(VectorOffset), VectorOffset ClientLogicOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			TCsvLoopTeleportData.AddClientLogic(builder, ClientLogicOffset);
			TCsvLoopTeleportData.AddClientLogicType(builder, ClientLogic_typeOffset);
			TCsvLoopTeleportData.AddConditions(builder, ConditionsOffset);
			TCsvLoopTeleportData.AddId(builder, Id);
			return TCsvLoopTeleportData.EndTCsvLoopTeleportData(builder);
		}

		// Token: 0x0601D43F RID: 119871 RVA: 0x00420D44 File Offset: 0x0041EF44
		public static void StartTCsvLoopTeleportData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D440 RID: 119872 RVA: 0x00420D4D File Offset: 0x0041EF4D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601D441 RID: 119873 RVA: 0x00420D58 File Offset: 0x0041EF58
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0601D442 RID: 119874 RVA: 0x00420D68 File Offset: 0x0041EF68
		public static void AddClientLogicType(FlatBufferBuilder builder, VectorOffset clientLogicTypeOffset)
		{
			builder.AddOffset(2, clientLogicTypeOffset.Value, 0);
		}

		// Token: 0x0601D443 RID: 119875 RVA: 0x00420D78 File Offset: 0x0041EF78
		public static VectorOffset CreateClientLogicTypeVector(FlatBufferBuilder builder, ILoopTeleportClientLogicItemBase_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D444 RID: 119876 RVA: 0x00420DAF File Offset: 0x0041EFAF
		public static VectorOffset CreateClientLogicTypeVectorBlock(FlatBufferBuilder builder, ILoopTeleportClientLogicItemBase_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ILoopTeleportClientLogicItemBase_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D445 RID: 119877 RVA: 0x00420DC9 File Offset: 0x0041EFC9
		public static VectorOffset CreateClientLogicTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<ILoopTeleportClientLogicItemBase_Union> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ILoopTeleportClientLogicItemBase_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D446 RID: 119878 RVA: 0x00420DE7 File Offset: 0x0041EFE7
		public static VectorOffset CreateClientLogicTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ILoopTeleportClientLogicItemBase_Union>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D447 RID: 119879 RVA: 0x00420E00 File Offset: 0x0041F000
		public static void StartClientLogicTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601D448 RID: 119880 RVA: 0x00420E0B File Offset: 0x0041F00B
		public static void AddClientLogic(FlatBufferBuilder builder, VectorOffset clientLogicOffset)
		{
			builder.AddOffset(3, clientLogicOffset.Value, 0);
		}

		// Token: 0x0601D449 RID: 119881 RVA: 0x00420E1C File Offset: 0x0041F01C
		public static VectorOffset CreateClientLogicVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D44A RID: 119882 RVA: 0x00420E53 File Offset: 0x0041F053
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D44B RID: 119883 RVA: 0x00420E6D File Offset: 0x0041F06D
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D44C RID: 119884 RVA: 0x00420E8B File Offset: 0x0041F08B
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D44D RID: 119885 RVA: 0x00420EA4 File Offset: 0x0041F0A4
		public static void StartClientLogicVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D44E RID: 119886 RVA: 0x00420EAF File Offset: 0x0041F0AF
		public static Offset<TCsvLoopTeleportData> EndTCsvLoopTeleportData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvLoopTeleportData>(builder.EndTable());
		}

		// Token: 0x0601D44F RID: 119887 RVA: 0x00420EBC File Offset: 0x0041F0BC
		public TCsvLoopTeleportDataT UnPack()
		{
			TCsvLoopTeleportDataT tcsvLoopTeleportDataT = new TCsvLoopTeleportDataT();
			this.UnPackTo(tcsvLoopTeleportDataT);
			return tcsvLoopTeleportDataT;
		}

		// Token: 0x0601D450 RID: 119888 RVA: 0x00420ED8 File Offset: 0x0041F0D8
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

		// Token: 0x0601D451 RID: 119889 RVA: 0x00420FE0 File Offset: 0x0041F1E0
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

		// Token: 0x0400CF91 RID: 53137
		private Table __p;
	}
}
