using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004964 RID: 18788
	public struct IAccessQuestCondition : IFlatbufferObject
	{
		// Token: 0x170087BB RID: 34747
		// (get) Token: 0x0601D466 RID: 119910 RVA: 0x00421286 File Offset: 0x0041F486
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D467 RID: 119911 RVA: 0x00421293 File Offset: 0x0041F493
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D468 RID: 119912 RVA: 0x0042129C File Offset: 0x0041F49C
		public static IAccessQuestCondition GetRootAsIAccessQuestCondition(ByteBuffer _bb)
		{
			return IAccessQuestCondition.GetRootAsIAccessQuestCondition(_bb, default(IAccessQuestCondition));
		}

		// Token: 0x0601D469 RID: 119913 RVA: 0x004212B8 File Offset: 0x0041F4B8
		public static IAccessQuestCondition GetRootAsIAccessQuestCondition(ByteBuffer _bb, IAccessQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D46A RID: 119914 RVA: 0x004212D5 File Offset: 0x0041F4D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D46B RID: 119915 RVA: 0x004212E4 File Offset: 0x0041F4E4
		public IAccessQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087BC RID: 34748
		// (get) Token: 0x0601D46C RID: 119916 RVA: 0x004212F4 File Offset: 0x0041F4F4
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

		// Token: 0x0601D46D RID: 119917 RVA: 0x00421330 File Offset: 0x0041F530
		public TAccessQuestCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TAccessQuestCondition.NONE;
			}
			return (TAccessQuestCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170087BD RID: 34749
		// (get) Token: 0x0601D46E RID: 119918 RVA: 0x00421370 File Offset: 0x0041F570
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

		// Token: 0x0601D46F RID: 119919 RVA: 0x0042139B File Offset: 0x0041F59B
		public Span<TAccessQuestCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TAccessQuestCondition>(6, 1);
		}

		// Token: 0x0601D470 RID: 119920 RVA: 0x004213AC File Offset: 0x0041F5AC
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

		// Token: 0x0601D471 RID: 119921 RVA: 0x00421418 File Offset: 0x0041F618
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170087BE RID: 34750
		// (get) Token: 0x0601D472 RID: 119922 RVA: 0x00421460 File Offset: 0x0041F660
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

		// Token: 0x170087BF RID: 34751
		// (get) Token: 0x0601D473 RID: 119923 RVA: 0x0042148C File Offset: 0x0041F68C
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

		// Token: 0x0601D474 RID: 119924 RVA: 0x004214C9 File Offset: 0x0041F6C9
		public static Offset<IAccessQuestCondition> CreateIAccessQuestCondition(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IAccessQuestCondition.AddConditions(builder, ConditionsOffset);
			IAccessQuestCondition.AddConditionsType(builder, Conditions_typeOffset);
			IAccessQuestCondition.AddNullMask(builder, NullMask);
			IAccessQuestCondition.AddType(builder, Type);
			return IAccessQuestCondition.EndIAccessQuestCondition(builder);
		}

		// Token: 0x0601D475 RID: 119925 RVA: 0x004214F5 File Offset: 0x0041F6F5
		public static void StartIAccessQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D476 RID: 119926 RVA: 0x004214FE File Offset: 0x0041F6FE
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D477 RID: 119927 RVA: 0x00421509 File Offset: 0x0041F709
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601D478 RID: 119928 RVA: 0x0042151C File Offset: 0x0041F71C
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TAccessQuestCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D479 RID: 119929 RVA: 0x00421553 File Offset: 0x0041F753
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TAccessQuestCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TAccessQuestCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D47A RID: 119930 RVA: 0x0042156D File Offset: 0x0041F76D
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TAccessQuestCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TAccessQuestCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D47B RID: 119931 RVA: 0x0042158B File Offset: 0x0041F78B
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TAccessQuestCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D47C RID: 119932 RVA: 0x004215A4 File Offset: 0x0041F7A4
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601D47D RID: 119933 RVA: 0x004215AF File Offset: 0x0041F7AF
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601D47E RID: 119934 RVA: 0x004215C0 File Offset: 0x0041F7C0
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D47F RID: 119935 RVA: 0x004215F7 File Offset: 0x0041F7F7
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D480 RID: 119936 RVA: 0x00421611 File Offset: 0x0041F811
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D481 RID: 119937 RVA: 0x0042162F File Offset: 0x0041F82F
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D482 RID: 119938 RVA: 0x00421648 File Offset: 0x0041F848
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D483 RID: 119939 RVA: 0x00421653 File Offset: 0x0041F853
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601D484 RID: 119940 RVA: 0x0042165E File Offset: 0x0041F85E
		public static Offset<IAccessQuestCondition> EndIAccessQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IAccessQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601D485 RID: 119941 RVA: 0x0042166C File Offset: 0x0041F86C
		public IAccessQuestConditionT UnPack()
		{
			IAccessQuestConditionT accessQuestConditionT = new IAccessQuestConditionT();
			this.UnPackTo(accessQuestConditionT);
			return accessQuestConditionT;
		}

		// Token: 0x0601D486 RID: 119942 RVA: 0x00421688 File Offset: 0x0041F888
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

		// Token: 0x0601D487 RID: 119943 RVA: 0x004219D4 File Offset: 0x0041FBD4
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

		// Token: 0x0400D15C RID: 53596
		private Table __p;
	}
}
