using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004971 RID: 18801
	public struct ILevelPlayOpenCondition : IFlatbufferObject
	{
		// Token: 0x1700838C RID: 33676
		// (get) Token: 0x0601C09C RID: 114844 RVA: 0x003F6B59 File Offset: 0x003F4D59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C09D RID: 114845 RVA: 0x003F6B66 File Offset: 0x003F4D66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C09E RID: 114846 RVA: 0x003F6B70 File Offset: 0x003F4D70
		public static ILevelPlayOpenCondition GetRootAsILevelPlayOpenCondition(ByteBuffer _bb)
		{
			return ILevelPlayOpenCondition.GetRootAsILevelPlayOpenCondition(_bb, default(ILevelPlayOpenCondition));
		}

		// Token: 0x0601C09F RID: 114847 RVA: 0x003F6B8C File Offset: 0x003F4D8C
		public static ILevelPlayOpenCondition GetRootAsILevelPlayOpenCondition(ByteBuffer _bb, ILevelPlayOpenCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C0A0 RID: 114848 RVA: 0x003F6BA9 File Offset: 0x003F4DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C0A1 RID: 114849 RVA: 0x003F6BB8 File Offset: 0x003F4DB8
		public ILevelPlayOpenCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700838D RID: 33677
		// (get) Token: 0x0601C0A2 RID: 114850 RVA: 0x003F6BC8 File Offset: 0x003F4DC8
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

		// Token: 0x0601C0A3 RID: 114851 RVA: 0x003F6C04 File Offset: 0x003F4E04
		public TAccessQuestCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TAccessQuestCondition.NONE;
			}
			return (TAccessQuestCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700838E RID: 33678
		// (get) Token: 0x0601C0A4 RID: 114852 RVA: 0x003F6C44 File Offset: 0x003F4E44
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

		// Token: 0x0601C0A5 RID: 114853 RVA: 0x003F6C6F File Offset: 0x003F4E6F
		public Span<TAccessQuestCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TAccessQuestCondition>(6, 1);
		}

		// Token: 0x0601C0A6 RID: 114854 RVA: 0x003F6C80 File Offset: 0x003F4E80
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

		// Token: 0x0601C0A7 RID: 114855 RVA: 0x003F6CEC File Offset: 0x003F4EEC
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700838F RID: 33679
		// (get) Token: 0x0601C0A8 RID: 114856 RVA: 0x003F6D34 File Offset: 0x003F4F34
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

		// Token: 0x17008390 RID: 33680
		// (get) Token: 0x0601C0A9 RID: 114857 RVA: 0x003F6D60 File Offset: 0x003F4F60
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008391 RID: 33681
		// (get) Token: 0x0601C0AA RID: 114858 RVA: 0x003F6DA0 File Offset: 0x003F4FA0
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

		// Token: 0x0601C0AB RID: 114859 RVA: 0x003F6DDD File Offset: 0x003F4FDD
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

		// Token: 0x0601C0AC RID: 114860 RVA: 0x003F6E11 File Offset: 0x003F5011
		public static void StartILevelPlayOpenCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601C0AD RID: 114861 RVA: 0x003F6E1A File Offset: 0x003F501A
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C0AE RID: 114862 RVA: 0x003F6E25 File Offset: 0x003F5025
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601C0AF RID: 114863 RVA: 0x003F6E38 File Offset: 0x003F5038
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TAccessQuestCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C0B0 RID: 114864 RVA: 0x003F6E6F File Offset: 0x003F506F
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TAccessQuestCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TAccessQuestCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0B1 RID: 114865 RVA: 0x003F6E89 File Offset: 0x003F5089
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TAccessQuestCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TAccessQuestCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0B2 RID: 114866 RVA: 0x003F6EA7 File Offset: 0x003F50A7
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TAccessQuestCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C0B3 RID: 114867 RVA: 0x003F6EC0 File Offset: 0x003F50C0
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C0B4 RID: 114868 RVA: 0x003F6ECB File Offset: 0x003F50CB
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601C0B5 RID: 114869 RVA: 0x003F6EDC File Offset: 0x003F50DC
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C0B6 RID: 114870 RVA: 0x003F6F13 File Offset: 0x003F5113
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0B7 RID: 114871 RVA: 0x003F6F2D File Offset: 0x003F512D
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0B8 RID: 114872 RVA: 0x003F6F4B File Offset: 0x003F514B
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C0B9 RID: 114873 RVA: 0x003F6F64 File Offset: 0x003F5164
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C0BA RID: 114874 RVA: 0x003F6F6F File Offset: 0x003F516F
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(3, delayRefresh, false);
		}

		// Token: 0x0601C0BB RID: 114875 RVA: 0x003F6F7A File Offset: 0x003F517A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601C0BC RID: 114876 RVA: 0x003F6F85 File Offset: 0x003F5185
		public static Offset<ILevelPlayOpenCondition> EndILevelPlayOpenCondition(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayOpenCondition>(builder.EndTable());
		}

		// Token: 0x0601C0BD RID: 114877 RVA: 0x003F6F94 File Offset: 0x003F5194
		public ILevelPlayOpenConditionT UnPack()
		{
			ILevelPlayOpenConditionT levelPlayOpenConditionT = new ILevelPlayOpenConditionT();
			this.UnPackTo(levelPlayOpenConditionT);
			return levelPlayOpenConditionT;
		}

		// Token: 0x0601C0BE RID: 114878 RVA: 0x003F6FB0 File Offset: 0x003F51B0
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

		// Token: 0x0601C0BF RID: 114879 RVA: 0x003F7308 File Offset: 0x003F5508
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

		// Token: 0x0400CFA1 RID: 53153
		private Table __p;
	}
}
