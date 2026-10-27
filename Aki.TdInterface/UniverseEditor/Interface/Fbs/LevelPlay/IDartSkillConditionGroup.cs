using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004482 RID: 17538
	public struct IDartSkillConditionGroup : IFlatbufferObject
	{
		// Token: 0x17007BC7 RID: 31687
		// (get) Token: 0x0601A266 RID: 107110 RVA: 0x003BC4A1 File Offset: 0x003BA6A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A267 RID: 107111 RVA: 0x003BC4AE File Offset: 0x003BA6AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A268 RID: 107112 RVA: 0x003BC4B8 File Offset: 0x003BA6B8
		public static IDartSkillConditionGroup GetRootAsIDartSkillConditionGroup(ByteBuffer _bb)
		{
			return IDartSkillConditionGroup.GetRootAsIDartSkillConditionGroup(_bb, default(IDartSkillConditionGroup));
		}

		// Token: 0x0601A269 RID: 107113 RVA: 0x003BC4D4 File Offset: 0x003BA6D4
		public static IDartSkillConditionGroup GetRootAsIDartSkillConditionGroup(ByteBuffer _bb, IDartSkillConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A26A RID: 107114 RVA: 0x003BC4F1 File Offset: 0x003BA6F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A26B RID: 107115 RVA: 0x003BC500 File Offset: 0x003BA700
		public IDartSkillConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BC8 RID: 31688
		// (get) Token: 0x0601A26C RID: 107116 RVA: 0x003BC510 File Offset: 0x003BA710
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

		// Token: 0x0601A26D RID: 107117 RVA: 0x003BC54C File Offset: 0x003BA74C
		public TDartSkillCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TDartSkillCondition.NONE;
			}
			return (TDartSkillCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007BC9 RID: 31689
		// (get) Token: 0x0601A26E RID: 107118 RVA: 0x003BC58C File Offset: 0x003BA78C
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

		// Token: 0x0601A26F RID: 107119 RVA: 0x003BC5B7 File Offset: 0x003BA7B7
		public Span<TDartSkillCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TDartSkillCondition>(6, 1);
		}

		// Token: 0x0601A270 RID: 107120 RVA: 0x003BC5C8 File Offset: 0x003BA7C8
		public TDartSkillCondition[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TDartSkillCondition[] array = new TDartSkillCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TDartSkillCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601A271 RID: 107121 RVA: 0x003BC634 File Offset: 0x003BA834
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007BCA RID: 31690
		// (get) Token: 0x0601A272 RID: 107122 RVA: 0x003BC67C File Offset: 0x003BA87C
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

		// Token: 0x0601A273 RID: 107123 RVA: 0x003BC6A7 File Offset: 0x003BA8A7
		public static Offset<IDartSkillConditionGroup> CreateIDartSkillConditionGroup(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDartSkillConditionGroup.AddConditions(builder, ConditionsOffset);
			IDartSkillConditionGroup.AddConditionsType(builder, Conditions_typeOffset);
			IDartSkillConditionGroup.AddType(builder, Type);
			return IDartSkillConditionGroup.EndIDartSkillConditionGroup(builder);
		}

		// Token: 0x0601A274 RID: 107124 RVA: 0x003BC6CB File Offset: 0x003BA8CB
		public static void StartIDartSkillConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A275 RID: 107125 RVA: 0x003BC6D4 File Offset: 0x003BA8D4
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A276 RID: 107126 RVA: 0x003BC6DF File Offset: 0x003BA8DF
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601A277 RID: 107127 RVA: 0x003BC6F0 File Offset: 0x003BA8F0
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TDartSkillCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A278 RID: 107128 RVA: 0x003BC727 File Offset: 0x003BA927
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TDartSkillCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartSkillCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A279 RID: 107129 RVA: 0x003BC741 File Offset: 0x003BA941
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartSkillCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartSkillCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A27A RID: 107130 RVA: 0x003BC75F File Offset: 0x003BA95F
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartSkillCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A27B RID: 107131 RVA: 0x003BC778 File Offset: 0x003BA978
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A27C RID: 107132 RVA: 0x003BC783 File Offset: 0x003BA983
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601A27D RID: 107133 RVA: 0x003BC794 File Offset: 0x003BA994
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A27E RID: 107134 RVA: 0x003BC7CB File Offset: 0x003BA9CB
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A27F RID: 107135 RVA: 0x003BC7E5 File Offset: 0x003BA9E5
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A280 RID: 107136 RVA: 0x003BC803 File Offset: 0x003BAA03
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A281 RID: 107137 RVA: 0x003BC81C File Offset: 0x003BAA1C
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A282 RID: 107138 RVA: 0x003BC827 File Offset: 0x003BAA27
		public static Offset<IDartSkillConditionGroup> EndIDartSkillConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkillConditionGroup>(builder.EndTable());
		}

		// Token: 0x0601A283 RID: 107139 RVA: 0x003BC834 File Offset: 0x003BAA34
		public IDartSkillConditionGroupT UnPack()
		{
			IDartSkillConditionGroupT dartSkillConditionGroupT = new IDartSkillConditionGroupT();
			this.UnPackTo(dartSkillConditionGroupT);
			return dartSkillConditionGroupT;
		}

		// Token: 0x0601A284 RID: 107140 RVA: 0x003BC850 File Offset: 0x003BAA50
		public void UnPackTo(IDartSkillConditionGroupT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<TDartSkillConditionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				TDartSkillConditionUnion tdartSkillConditionUnion = new TDartSkillConditionUnion();
				tdartSkillConditionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case TDartSkillCondition.IBehindScoreGeCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IBehindScoreGeCondition>(i) != null) ? this.Conditions<IBehindScoreGeCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IBehindScoreLeCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IBehindScoreLeCondition>(i) != null) ? this.Conditions<IBehindScoreLeCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IFirstRoundsCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IFirstRoundsCondition>(i) != null) ? this.Conditions<IFirstRoundsCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IRemainScoreCanWinCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IRemainScoreCanWinCondition>(i) != null) ? this.Conditions<IRemainScoreCanWinCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IRemainScoreGeCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IRemainScoreGeCondition>(i) != null) ? this.Conditions<IRemainScoreGeCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IRemainScoreLeCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IRemainScoreLeCondition>(i) != null) ? this.Conditions<IRemainScoreLeCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IRoundIndexCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IRoundIndexCondition>(i) != null) ? this.Conditions<IRoundIndexCondition>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(tdartSkillConditionUnion);
			}
		}

		// Token: 0x0601A285 RID: 107141 RVA: 0x003BCA60 File Offset: 0x003BAC60
		public static Offset<IDartSkillConditionGroup> Pack(FlatBufferBuilder builder, IDartSkillConditionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartSkillConditionGroup>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				TDartSkillCondition[] array = new TDartSkillCondition[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = IDartSkillConditionGroup.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TDartSkillConditionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = IDartSkillConditionGroup.CreateConditionsVector(builder, array2);
			}
			return IDartSkillConditionGroup.CreateIDartSkillConditionGroup(builder, _o.Type, conditions_typeOffset, conditionsOffset);
		}

		// Token: 0x0400C478 RID: 50296
		private Table __p;
	}
}
