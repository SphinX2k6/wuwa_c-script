using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A42 RID: 14914
	public struct IBvbCardFilterGroup : IFlatbufferObject
	{
		// Token: 0x17006633 RID: 26163
		// (get) Token: 0x060142FA RID: 82682 RVA: 0x002F3518 File Offset: 0x002F1718
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060142FB RID: 82683 RVA: 0x002F3525 File Offset: 0x002F1725
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060142FC RID: 82684 RVA: 0x002F352C File Offset: 0x002F172C
		public static IBvbCardFilterGroup GetRootAsIBvbCardFilterGroup(ByteBuffer _bb)
		{
			return IBvbCardFilterGroup.GetRootAsIBvbCardFilterGroup(_bb, default(IBvbCardFilterGroup));
		}

		// Token: 0x060142FD RID: 82685 RVA: 0x002F3548 File Offset: 0x002F1748
		public static IBvbCardFilterGroup GetRootAsIBvbCardFilterGroup(ByteBuffer _bb, IBvbCardFilterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060142FE RID: 82686 RVA: 0x002F3565 File Offset: 0x002F1765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060142FF RID: 82687 RVA: 0x002F3574 File Offset: 0x002F1774
		public IBvbCardFilterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006634 RID: 26164
		// (get) Token: 0x06014300 RID: 82688 RVA: 0x002F3584 File Offset: 0x002F1784
		public EVarConditionType GroupType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVarConditionType.All;
				}
				return (EVarConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014301 RID: 82689 RVA: 0x002F35C0 File Offset: 0x002F17C0
		public IBvbCardFilterBase_Union ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return IBvbCardFilterBase_Union.NONE;
			}
			return (IBvbCardFilterBase_Union)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006635 RID: 26165
		// (get) Token: 0x06014302 RID: 82690 RVA: 0x002F3600 File Offset: 0x002F1800
		public int ConditionsTypeLength
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

		// Token: 0x06014303 RID: 82691 RVA: 0x002F362B File Offset: 0x002F182B
		public Span<IBvbCardFilterBase_Union> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<IBvbCardFilterBase_Union>(6, 1);
		}

		// Token: 0x06014304 RID: 82692 RVA: 0x002F363C File Offset: 0x002F183C
		public IBvbCardFilterBase_Union[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			IBvbCardFilterBase_Union[] array = new IBvbCardFilterBase_Union[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (IBvbCardFilterBase_Union)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06014305 RID: 82693 RVA: 0x002F36A8 File Offset: 0x002F18A8
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17006636 RID: 26166
		// (get) Token: 0x06014306 RID: 82694 RVA: 0x002F36F0 File Offset: 0x002F18F0
		public int ConditionsLength
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

		// Token: 0x06014307 RID: 82695 RVA: 0x002F371B File Offset: 0x002F191B
		public static Offset<IBvbCardFilterGroup> CreateIBvbCardFilterGroup(FlatBufferBuilder builder, EVarConditionType GroupType = EVarConditionType.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IBvbCardFilterGroup.AddConditions(builder, ConditionsOffset);
			IBvbCardFilterGroup.AddConditionsType(builder, Conditions_typeOffset);
			IBvbCardFilterGroup.AddGroupType(builder, GroupType);
			return IBvbCardFilterGroup.EndIBvbCardFilterGroup(builder);
		}

		// Token: 0x06014308 RID: 82696 RVA: 0x002F373F File Offset: 0x002F193F
		public static void StartIBvbCardFilterGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014309 RID: 82697 RVA: 0x002F3748 File Offset: 0x002F1948
		public static void AddGroupType(FlatBufferBuilder builder, EVarConditionType groupType)
		{
			builder.AddByte(0, (byte)groupType, 0);
		}

		// Token: 0x0601430A RID: 82698 RVA: 0x002F3753 File Offset: 0x002F1953
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601430B RID: 82699 RVA: 0x002F3764 File Offset: 0x002F1964
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, IBvbCardFilterBase_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601430C RID: 82700 RVA: 0x002F379B File Offset: 0x002F199B
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IBvbCardFilterBase_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<IBvbCardFilterBase_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0601430D RID: 82701 RVA: 0x002F37B5 File Offset: 0x002F19B5
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<IBvbCardFilterBase_Union> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<IBvbCardFilterBase_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0601430E RID: 82702 RVA: 0x002F37D3 File Offset: 0x002F19D3
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<IBvbCardFilterBase_Union>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601430F RID: 82703 RVA: 0x002F37EC File Offset: 0x002F19EC
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06014310 RID: 82704 RVA: 0x002F37F7 File Offset: 0x002F19F7
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x06014311 RID: 82705 RVA: 0x002F3808 File Offset: 0x002F1A08
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06014312 RID: 82706 RVA: 0x002F383F File Offset: 0x002F1A3F
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06014313 RID: 82707 RVA: 0x002F3859 File Offset: 0x002F1A59
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06014314 RID: 82708 RVA: 0x002F3877 File Offset: 0x002F1A77
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014315 RID: 82709 RVA: 0x002F3890 File Offset: 0x002F1A90
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014316 RID: 82710 RVA: 0x002F389B File Offset: 0x002F1A9B
		public static Offset<IBvbCardFilterGroup> EndIBvbCardFilterGroup(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterGroup>(builder.EndTable());
		}

		// Token: 0x06014317 RID: 82711 RVA: 0x002F38A8 File Offset: 0x002F1AA8
		public IBvbCardFilterGroupT UnPack()
		{
			IBvbCardFilterGroupT bvbCardFilterGroupT = new IBvbCardFilterGroupT();
			this.UnPackTo(bvbCardFilterGroupT);
			return bvbCardFilterGroupT;
		}

		// Token: 0x06014318 RID: 82712 RVA: 0x002F38C4 File Offset: 0x002F1AC4
		public void UnPackTo(IBvbCardFilterGroupT _o)
		{
			_o.GroupType = this.GroupType;
			_o.Conditions = new List<IBvbCardFilterBase_UnionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				IBvbCardFilterBase_UnionUnion bvbCardFilterBase_UnionUnion = new IBvbCardFilterBase_UnionUnion();
				bvbCardFilterBase_UnionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case IBvbCardFilterBase_Union.IBvbCardFilterBase:
					bvbCardFilterBase_UnionUnion.Value = ((this.Conditions<IBvbCardFilterBase>(i) != null) ? this.Conditions<IBvbCardFilterBase>(i).Value.UnPack() : null);
					break;
				case IBvbCardFilterBase_Union.IBvbCardFilterCompareCost:
					bvbCardFilterBase_UnionUnion.Value = ((this.Conditions<IBvbCardFilterCompareCost>(i) != null) ? this.Conditions<IBvbCardFilterCompareCost>(i).Value.UnPack() : null);
					break;
				case IBvbCardFilterBase_Union.IBvbCardFilterCompareCardType:
					bvbCardFilterBase_UnionUnion.Value = ((this.Conditions<IBvbCardFilterCompareCardType>(i) != null) ? this.Conditions<IBvbCardFilterCompareCardType>(i).Value.UnPack() : null);
					break;
				case IBvbCardFilterBase_Union.IBvbCardFilterCheckIsCore:
					bvbCardFilterBase_UnionUnion.Value = ((this.Conditions<IBvbCardFilterCheckIsCore>(i) != null) ? this.Conditions<IBvbCardFilterCheckIsCore>(i).Value.UnPack() : null);
					break;
				case IBvbCardFilterBase_Union.IBvbCardFilterCompareActiveSkillTag:
					bvbCardFilterBase_UnionUnion.Value = ((this.Conditions<IBvbCardFilterCompareActiveSkillTag>(i) != null) ? this.Conditions<IBvbCardFilterCompareActiveSkillTag>(i).Value.UnPack() : null);
					break;
				case IBvbCardFilterBase_Union.IBvbCardFilterCheckHasBattleFactor:
					bvbCardFilterBase_UnionUnion.Value = ((this.Conditions<IBvbCardFilterCheckHasBattleFactor>(i) != null) ? this.Conditions<IBvbCardFilterCheckHasBattleFactor>(i).Value.UnPack() : null);
					break;
				case IBvbCardFilterBase_Union.IBvbCardFilterCheckHasOptimalFactor:
					bvbCardFilterBase_UnionUnion.Value = ((this.Conditions<IBvbCardFilterCheckHasOptimalFactor>(i) != null) ? this.Conditions<IBvbCardFilterCheckHasOptimalFactor>(i).Value.UnPack() : null);
					break;
				case IBvbCardFilterBase_Union.IBvbCardFilterCheckIsCapableToEvolve:
					bvbCardFilterBase_UnionUnion.Value = ((this.Conditions<IBvbCardFilterCheckIsCapableToEvolve>(i) != null) ? this.Conditions<IBvbCardFilterCheckIsCapableToEvolve>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(bvbCardFilterBase_UnionUnion);
			}
		}

		// Token: 0x06014319 RID: 82713 RVA: 0x002F3B10 File Offset: 0x002F1D10
		public static Offset<IBvbCardFilterGroup> Pack(FlatBufferBuilder builder, IBvbCardFilterGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterGroup>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				IBvbCardFilterBase_Union[] array = new IBvbCardFilterBase_Union[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = IBvbCardFilterGroup.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IBvbCardFilterBase_UnionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = IBvbCardFilterGroup.CreateConditionsVector(builder, array2);
			}
			return IBvbCardFilterGroup.CreateIBvbCardFilterGroup(builder, _o.GroupType, conditions_typeOffset, conditionsOffset);
		}

		// Token: 0x0400AEC2 RID: 44738
		private Table __p;
	}
}
