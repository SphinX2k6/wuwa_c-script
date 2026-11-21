using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E1B RID: 19995
	public struct IAccessQuestCondition : IFlatbufferObject
	{
		// Token: 0x17008E76 RID: 36470
		// (get) Token: 0x0601EE8B RID: 126603 RVA: 0x0045173A File Offset: 0x0044F93A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE8C RID: 126604 RVA: 0x00451747 File Offset: 0x0044F947
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE8D RID: 126605 RVA: 0x00451750 File Offset: 0x0044F950
		public static IAccessQuestCondition GetRootAsIAccessQuestCondition(ByteBuffer _bb)
		{
			return IAccessQuestCondition.GetRootAsIAccessQuestCondition(_bb, default(IAccessQuestCondition));
		}

		// Token: 0x0601EE8E RID: 126606 RVA: 0x0045176C File Offset: 0x0044F96C
		public static IAccessQuestCondition GetRootAsIAccessQuestCondition(ByteBuffer _bb, IAccessQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE8F RID: 126607 RVA: 0x00451789 File Offset: 0x0044F989
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE90 RID: 126608 RVA: 0x00451798 File Offset: 0x0044F998
		public IAccessQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E77 RID: 36471
		// (get) Token: 0x0601EE91 RID: 126609 RVA: 0x004517A8 File Offset: 0x0044F9A8
		public EConditionCount Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EE92 RID: 126610 RVA: 0x004517E4 File Offset: 0x0044F9E4
		public TAccessQuestCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TAccessQuestCondition.NONE;
			}
			return (TAccessQuestCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008E78 RID: 36472
		// (get) Token: 0x0601EE93 RID: 126611 RVA: 0x00451824 File Offset: 0x0044FA24
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

		// Token: 0x0601EE94 RID: 126612 RVA: 0x0045184F File Offset: 0x0044FA4F
		public Span<TAccessQuestCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TAccessQuestCondition>(6, 1);
		}

		// Token: 0x0601EE95 RID: 126613 RVA: 0x00451860 File Offset: 0x0044FA60
		public TAccessQuestCondition[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TAccessQuestCondition[] array = new TAccessQuestCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TAccessQuestCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601EE96 RID: 126614 RVA: 0x004518CC File Offset: 0x0044FACC
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008E79 RID: 36473
		// (get) Token: 0x0601EE97 RID: 126615 RVA: 0x00451914 File Offset: 0x0044FB14
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

		// Token: 0x17008E7A RID: 36474
		// (get) Token: 0x0601EE98 RID: 126616 RVA: 0x00451940 File Offset: 0x0044FB40
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EE99 RID: 126617 RVA: 0x0045197D File Offset: 0x0044FB7D
		public static Offset<IAccessQuestCondition> CreateIAccessQuestCondition(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IAccessQuestCondition.AddConditions(builder, ConditionsOffset);
			IAccessQuestCondition.AddConditionsType(builder, Conditions_typeOffset);
			IAccessQuestCondition.AddNullMask(builder, NullMask);
			IAccessQuestCondition.AddType(builder, Type);
			return IAccessQuestCondition.EndIAccessQuestCondition(builder);
		}

		// Token: 0x0601EE9A RID: 126618 RVA: 0x004519A9 File Offset: 0x0044FBA9
		public static void StartIAccessQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EE9B RID: 126619 RVA: 0x004519B2 File Offset: 0x0044FBB2
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EE9C RID: 126620 RVA: 0x004519BD File Offset: 0x0044FBBD
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601EE9D RID: 126621 RVA: 0x004519D0 File Offset: 0x0044FBD0
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TAccessQuestCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EE9E RID: 126622 RVA: 0x00451A07 File Offset: 0x0044FC07
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TAccessQuestCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TAccessQuestCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE9F RID: 126623 RVA: 0x00451A21 File Offset: 0x0044FC21
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TAccessQuestCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TAccessQuestCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EEA0 RID: 126624 RVA: 0x00451A3F File Offset: 0x0044FC3F
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TAccessQuestCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EEA1 RID: 126625 RVA: 0x00451A58 File Offset: 0x0044FC58
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601EEA2 RID: 126626 RVA: 0x00451A63 File Offset: 0x0044FC63
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601EEA3 RID: 126627 RVA: 0x00451A74 File Offset: 0x0044FC74
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EEA4 RID: 126628 RVA: 0x00451AAB File Offset: 0x0044FCAB
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EEA5 RID: 126629 RVA: 0x00451AC5 File Offset: 0x0044FCC5
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EEA6 RID: 126630 RVA: 0x00451AE3 File Offset: 0x0044FCE3
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EEA7 RID: 126631 RVA: 0x00451AFC File Offset: 0x0044FCFC
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EEA8 RID: 126632 RVA: 0x00451B07 File Offset: 0x0044FD07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601EEA9 RID: 126633 RVA: 0x00451B12 File Offset: 0x0044FD12
		public static Offset<IAccessQuestCondition> EndIAccessQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IAccessQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601EEAA RID: 126634 RVA: 0x00451B20 File Offset: 0x0044FD20
		public IAccessQuestConditionT UnPack()
		{
			IAccessQuestConditionT accessQuestConditionT = new IAccessQuestConditionT();
			this.UnPackTo(accessQuestConditionT);
			return accessQuestConditionT;
		}

		// Token: 0x0601EEAB RID: 126635 RVA: 0x00451B3C File Offset: 0x0044FD3C
		public void UnPackTo(IAccessQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<TAccessQuestConditionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				TAccessQuestConditionUnion taccessQuestConditionUnion = new TAccessQuestConditionUnion();
				taccessQuestConditionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case TAccessQuestCondition.IDungeonQuestPreCondition:
					taccessQuestConditionUnion.Value = ((this.Conditions<IDungeonQuestPreCondition>(i) != null) ? this.Conditions<IDungeonQuestPreCondition>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IExploreLevelCondtion:
					taccessQuestConditionUnion.Value = ((this.Conditions<IExploreLevelCondtion>(i) != null) ? this.Conditions<IExploreLevelCondtion>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IFeatureCollectionLevelPreCondition:
					taccessQuestConditionUnion.Value = ((this.Conditions<IFeatureCollectionLevelPreCondition>(i) != null) ? this.Conditions<IFeatureCollectionLevelPreCondition>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IItemCondition:
					taccessQuestConditionUnion.Value = ((this.Conditions<IItemCondition>(i) != null) ? this.Conditions<IItemCondition>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IPreChildQuestCondtion:
					taccessQuestConditionUnion.Value = ((this.Conditions<IPreChildQuestCondtion>(i) != null) ? this.Conditions<IPreChildQuestCondtion>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IPreGenderCondtion:
					taccessQuestConditionUnion.Value = ((this.Conditions<IPreGenderCondtion>(i) != null) ? this.Conditions<IPreGenderCondtion>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IPreLevelPlayCondtion:
					taccessQuestConditionUnion.Value = ((this.Conditions<IPreLevelPlayCondtion>(i) != null) ? this.Conditions<IPreLevelPlayCondtion>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IPreQuestCondtion:
					taccessQuestConditionUnion.Value = ((this.Conditions<IPreQuestCondtion>(i) != null) ? this.Conditions<IPreQuestCondtion>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IReachAreaCondtion:
					taccessQuestConditionUnion.Value = ((this.Conditions<IReachAreaCondtion>(i) != null) ? this.Conditions<IReachAreaCondtion>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.ISystemStateConditon:
					taccessQuestConditionUnion.Value = ((this.Conditions<ISystemStateConditon>(i) != null) ? this.Conditions<ISystemStateConditon>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IOpenDateConditon:
					taccessQuestConditionUnion.Value = ((this.Conditions<IOpenDateConditon>(i) != null) ? this.Conditions<IOpenDateConditon>(i).Value.UnPack() : null);
					break;
				case TAccessQuestCondition.IMapThemedActivityReachRank:
					taccessQuestConditionUnion.Value = ((this.Conditions<IMapThemedActivityReachRank>(i) != null) ? this.Conditions<IMapThemedActivityReachRank>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(taccessQuestConditionUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601EEAC RID: 126636 RVA: 0x00451E88 File Offset: 0x00450088
		public static Offset<IAccessQuestCondition> Pack(FlatBufferBuilder builder, IAccessQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAccessQuestCondition>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				TAccessQuestCondition[] array = new TAccessQuestCondition[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = IAccessQuestCondition.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TAccessQuestConditionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = IAccessQuestCondition.CreateConditionsVector(builder, array2);
			}
			return IAccessQuestCondition.CreateIAccessQuestCondition(builder, _o.Type, conditions_typeOffset, conditionsOffset, _o.NullMask);
		}

		// Token: 0x0400DC24 RID: 56356
		private Table __p;
	}
}
