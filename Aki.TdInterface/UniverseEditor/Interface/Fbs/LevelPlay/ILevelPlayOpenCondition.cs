using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004509 RID: 17673
	public struct ILevelPlayOpenCondition : IFlatbufferObject
	{
		// Token: 0x17007D4B RID: 32075
		// (get) Token: 0x0601A8C7 RID: 108743 RVA: 0x003CA8BD File Offset: 0x003C8ABD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A8C8 RID: 108744 RVA: 0x003CA8CA File Offset: 0x003C8ACA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A8C9 RID: 108745 RVA: 0x003CA8D4 File Offset: 0x003C8AD4
		public static ILevelPlayOpenCondition GetRootAsILevelPlayOpenCondition(ByteBuffer _bb)
		{
			return ILevelPlayOpenCondition.GetRootAsILevelPlayOpenCondition(_bb, default(ILevelPlayOpenCondition));
		}

		// Token: 0x0601A8CA RID: 108746 RVA: 0x003CA8F0 File Offset: 0x003C8AF0
		public static ILevelPlayOpenCondition GetRootAsILevelPlayOpenCondition(ByteBuffer _bb, ILevelPlayOpenCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A8CB RID: 108747 RVA: 0x003CA90D File Offset: 0x003C8B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A8CC RID: 108748 RVA: 0x003CA91C File Offset: 0x003C8B1C
		public ILevelPlayOpenCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D4C RID: 32076
		// (get) Token: 0x0601A8CD RID: 108749 RVA: 0x003CA92C File Offset: 0x003C8B2C
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

		// Token: 0x0601A8CE RID: 108750 RVA: 0x003CA968 File Offset: 0x003C8B68
		public TAccessQuestCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TAccessQuestCondition.NONE;
			}
			return (TAccessQuestCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007D4D RID: 32077
		// (get) Token: 0x0601A8CF RID: 108751 RVA: 0x003CA9A8 File Offset: 0x003C8BA8
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

		// Token: 0x0601A8D0 RID: 108752 RVA: 0x003CA9D3 File Offset: 0x003C8BD3
		public Span<TAccessQuestCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TAccessQuestCondition>(6, 1);
		}

		// Token: 0x0601A8D1 RID: 108753 RVA: 0x003CA9E4 File Offset: 0x003C8BE4
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

		// Token: 0x0601A8D2 RID: 108754 RVA: 0x003CAA50 File Offset: 0x003C8C50
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007D4E RID: 32078
		// (get) Token: 0x0601A8D3 RID: 108755 RVA: 0x003CAA98 File Offset: 0x003C8C98
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

		// Token: 0x17007D4F RID: 32079
		// (get) Token: 0x0601A8D4 RID: 108756 RVA: 0x003CAAC4 File Offset: 0x003C8CC4
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007D50 RID: 32080
		// (get) Token: 0x0601A8D5 RID: 108757 RVA: 0x003CAB04 File Offset: 0x003C8D04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A8D6 RID: 108758 RVA: 0x003CAB41 File Offset: 0x003C8D41
		public static Offset<ILevelPlayOpenCondition> CreateILevelPlayOpenCondition(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset), bool DelayRefresh = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ILevelPlayOpenCondition.AddConditions(builder, ConditionsOffset);
			ILevelPlayOpenCondition.AddConditionsType(builder, Conditions_typeOffset);
			ILevelPlayOpenCondition.AddNullMask(builder, NullMask);
			ILevelPlayOpenCondition.AddDelayRefresh(builder, DelayRefresh);
			ILevelPlayOpenCondition.AddType(builder, Type);
			return ILevelPlayOpenCondition.EndILevelPlayOpenCondition(builder);
		}

		// Token: 0x0601A8D7 RID: 108759 RVA: 0x003CAB75 File Offset: 0x003C8D75
		public static void StartILevelPlayOpenCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601A8D8 RID: 108760 RVA: 0x003CAB7E File Offset: 0x003C8D7E
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A8D9 RID: 108761 RVA: 0x003CAB89 File Offset: 0x003C8D89
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601A8DA RID: 108762 RVA: 0x003CAB9C File Offset: 0x003C8D9C
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TAccessQuestCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A8DB RID: 108763 RVA: 0x003CABD3 File Offset: 0x003C8DD3
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TAccessQuestCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TAccessQuestCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A8DC RID: 108764 RVA: 0x003CABED File Offset: 0x003C8DED
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TAccessQuestCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TAccessQuestCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A8DD RID: 108765 RVA: 0x003CAC0B File Offset: 0x003C8E0B
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TAccessQuestCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A8DE RID: 108766 RVA: 0x003CAC24 File Offset: 0x003C8E24
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A8DF RID: 108767 RVA: 0x003CAC2F File Offset: 0x003C8E2F
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601A8E0 RID: 108768 RVA: 0x003CAC40 File Offset: 0x003C8E40
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A8E1 RID: 108769 RVA: 0x003CAC77 File Offset: 0x003C8E77
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A8E2 RID: 108770 RVA: 0x003CAC91 File Offset: 0x003C8E91
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A8E3 RID: 108771 RVA: 0x003CACAF File Offset: 0x003C8EAF
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A8E4 RID: 108772 RVA: 0x003CACC8 File Offset: 0x003C8EC8
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A8E5 RID: 108773 RVA: 0x003CACD3 File Offset: 0x003C8ED3
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(3, delayRefresh, false);
		}

		// Token: 0x0601A8E6 RID: 108774 RVA: 0x003CACDE File Offset: 0x003C8EDE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601A8E7 RID: 108775 RVA: 0x003CACE9 File Offset: 0x003C8EE9
		public static Offset<ILevelPlayOpenCondition> EndILevelPlayOpenCondition(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayOpenCondition>(builder.EndTable());
		}

		// Token: 0x0601A8E8 RID: 108776 RVA: 0x003CACF8 File Offset: 0x003C8EF8
		public ILevelPlayOpenConditionT UnPack()
		{
			ILevelPlayOpenConditionT levelPlayOpenConditionT = new ILevelPlayOpenConditionT();
			this.UnPackTo(levelPlayOpenConditionT);
			return levelPlayOpenConditionT;
		}

		// Token: 0x0601A8E9 RID: 108777 RVA: 0x003CAD14 File Offset: 0x003C8F14
		public void UnPackTo(ILevelPlayOpenConditionT _o)
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
			_o.DelayRefresh = this.DelayRefresh;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A8EA RID: 108778 RVA: 0x003CB06C File Offset: 0x003C926C
		public static Offset<ILevelPlayOpenCondition> Pack(FlatBufferBuilder builder, ILevelPlayOpenConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayOpenCondition>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				TAccessQuestCondition[] array = new TAccessQuestCondition[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = ILevelPlayOpenCondition.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TAccessQuestConditionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = ILevelPlayOpenCondition.CreateConditionsVector(builder, array2);
			}
			return ILevelPlayOpenCondition.CreateILevelPlayOpenCondition(builder, _o.Type, conditions_typeOffset, conditionsOffset, _o.DelayRefresh, _o.NullMask);
		}

		// Token: 0x0400C572 RID: 50546
		private Table __p;
	}
}
