using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E1D RID: 15901
	public struct IBvbCardFilterGroup : IFlatbufferObject
	{
		// Token: 0x17006B63 RID: 27491
		// (get) Token: 0x06015616 RID: 87574 RVA: 0x00316704 File Offset: 0x00314904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015617 RID: 87575 RVA: 0x00316711 File Offset: 0x00314911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015618 RID: 87576 RVA: 0x00316718 File Offset: 0x00314918
		public static IBvbCardFilterGroup GetRootAsIBvbCardFilterGroup(ByteBuffer _bb)
		{
			return IBvbCardFilterGroup.GetRootAsIBvbCardFilterGroup(_bb, default(IBvbCardFilterGroup));
		}

		// Token: 0x06015619 RID: 87577 RVA: 0x00316734 File Offset: 0x00314934
		public static IBvbCardFilterGroup GetRootAsIBvbCardFilterGroup(ByteBuffer _bb, IBvbCardFilterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601561A RID: 87578 RVA: 0x00316751 File Offset: 0x00314951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601561B RID: 87579 RVA: 0x00316760 File Offset: 0x00314960
		public IBvbCardFilterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B64 RID: 27492
		// (get) Token: 0x0601561C RID: 87580 RVA: 0x00316770 File Offset: 0x00314970
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

		// Token: 0x0601561D RID: 87581 RVA: 0x003167AC File Offset: 0x003149AC
		public IBvbCardFilterBase_Union ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return IBvbCardFilterBase_Union.NONE;
			}
			return (IBvbCardFilterBase_Union)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006B65 RID: 27493
		// (get) Token: 0x0601561E RID: 87582 RVA: 0x003167EC File Offset: 0x003149EC
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

		// Token: 0x0601561F RID: 87583 RVA: 0x00316817 File Offset: 0x00314A17
		public Span<IBvbCardFilterBase_Union> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<IBvbCardFilterBase_Union>(6, 1);
		}

		// Token: 0x06015620 RID: 87584 RVA: 0x00316828 File Offset: 0x00314A28
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

		// Token: 0x06015621 RID: 87585 RVA: 0x00316894 File Offset: 0x00314A94
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17006B66 RID: 27494
		// (get) Token: 0x06015622 RID: 87586 RVA: 0x003168DC File Offset: 0x00314ADC
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

		// Token: 0x06015623 RID: 87587 RVA: 0x00316907 File Offset: 0x00314B07
		public static Offset<IBvbCardFilterGroup> CreateIBvbCardFilterGroup(FlatBufferBuilder builder, EVarConditionType GroupType = EVarConditionType.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IBvbCardFilterGroup.AddConditions(builder, ConditionsOffset);
			IBvbCardFilterGroup.AddConditionsType(builder, Conditions_typeOffset);
			IBvbCardFilterGroup.AddGroupType(builder, GroupType);
			return IBvbCardFilterGroup.EndIBvbCardFilterGroup(builder);
		}

		// Token: 0x06015624 RID: 87588 RVA: 0x0031692B File Offset: 0x00314B2B
		public static void StartIBvbCardFilterGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015625 RID: 87589 RVA: 0x00316934 File Offset: 0x00314B34
		public static void AddGroupType(FlatBufferBuilder builder, EVarConditionType groupType)
		{
			builder.AddByte(0, (byte)groupType, 0);
		}

		// Token: 0x06015626 RID: 87590 RVA: 0x0031693F File Offset: 0x00314B3F
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x06015627 RID: 87591 RVA: 0x00316950 File Offset: 0x00314B50
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, IBvbCardFilterBase_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015628 RID: 87592 RVA: 0x00316987 File Offset: 0x00314B87
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IBvbCardFilterBase_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<IBvbCardFilterBase_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x06015629 RID: 87593 RVA: 0x003169A1 File Offset: 0x00314BA1
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<IBvbCardFilterBase_Union> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<IBvbCardFilterBase_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0601562A RID: 87594 RVA: 0x003169BF File Offset: 0x00314BBF
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<IBvbCardFilterBase_Union>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601562B RID: 87595 RVA: 0x003169D8 File Offset: 0x00314BD8
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601562C RID: 87596 RVA: 0x003169E3 File Offset: 0x00314BE3
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601562D RID: 87597 RVA: 0x003169F4 File Offset: 0x00314BF4
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601562E RID: 87598 RVA: 0x00316A2B File Offset: 0x00314C2B
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601562F RID: 87599 RVA: 0x00316A45 File Offset: 0x00314C45
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015630 RID: 87600 RVA: 0x00316A63 File Offset: 0x00314C63
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015631 RID: 87601 RVA: 0x00316A7C File Offset: 0x00314C7C
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015632 RID: 87602 RVA: 0x00316A87 File Offset: 0x00314C87
		public static Offset<IBvbCardFilterGroup> EndIBvbCardFilterGroup(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterGroup>(builder.EndTable());
		}

		// Token: 0x06015633 RID: 87603 RVA: 0x00316A94 File Offset: 0x00314C94
		public IBvbCardFilterGroupT UnPack()
		{
			IBvbCardFilterGroupT bvbCardFilterGroupT = new IBvbCardFilterGroupT();
			this.UnPackTo(bvbCardFilterGroupT);
			return bvbCardFilterGroupT;
		}

		// Token: 0x06015634 RID: 87604 RVA: 0x00316AB0 File Offset: 0x00314CB0
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

		// Token: 0x06015635 RID: 87605 RVA: 0x00316CFC File Offset: 0x00314EFC
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

		// Token: 0x0400B7E4 RID: 47076
		private Table __p;
	}
}
