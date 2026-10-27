using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C9 RID: 17865
	public struct ITrapDefenseSpawnMonsterConditionGroup : IFlatbufferObject
	{
		// Token: 0x17007EF9 RID: 32505
		// (get) Token: 0x0601B057 RID: 110679 RVA: 0x003DA032 File Offset: 0x003D8232
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B058 RID: 110680 RVA: 0x003DA03F File Offset: 0x003D823F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B059 RID: 110681 RVA: 0x003DA048 File Offset: 0x003D8248
		public static ITrapDefenseSpawnMonsterConditionGroup GetRootAsITrapDefenseSpawnMonsterConditionGroup(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionGroup.GetRootAsITrapDefenseSpawnMonsterConditionGroup(_bb, default(ITrapDefenseSpawnMonsterConditionGroup));
		}

		// Token: 0x0601B05A RID: 110682 RVA: 0x003DA064 File Offset: 0x003D8264
		public static ITrapDefenseSpawnMonsterConditionGroup GetRootAsITrapDefenseSpawnMonsterConditionGroup(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B05B RID: 110683 RVA: 0x003DA081 File Offset: 0x003D8281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B05C RID: 110684 RVA: 0x003DA090 File Offset: 0x003D8290
		public ITrapDefenseSpawnMonsterConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EFA RID: 32506
		// (get) Token: 0x0601B05D RID: 110685 RVA: 0x003DA0A0 File Offset: 0x003D82A0
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

		// Token: 0x0601B05E RID: 110686 RVA: 0x003DA0DC File Offset: 0x003D82DC
		public TTrapDefenseSpawnMonsterCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TTrapDefenseSpawnMonsterCondition.NONE;
			}
			return (TTrapDefenseSpawnMonsterCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007EFB RID: 32507
		// (get) Token: 0x0601B05F RID: 110687 RVA: 0x003DA11C File Offset: 0x003D831C
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

		// Token: 0x0601B060 RID: 110688 RVA: 0x003DA147 File Offset: 0x003D8347
		public Span<TTrapDefenseSpawnMonsterCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TTrapDefenseSpawnMonsterCondition>(6, 1);
		}

		// Token: 0x0601B061 RID: 110689 RVA: 0x003DA158 File Offset: 0x003D8358
		public TTrapDefenseSpawnMonsterCondition[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTrapDefenseSpawnMonsterCondition[] array = new TTrapDefenseSpawnMonsterCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTrapDefenseSpawnMonsterCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601B062 RID: 110690 RVA: 0x003DA1C4 File Offset: 0x003D83C4
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007EFC RID: 32508
		// (get) Token: 0x0601B063 RID: 110691 RVA: 0x003DA20C File Offset: 0x003D840C
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

		// Token: 0x0601B064 RID: 110692 RVA: 0x003DA237 File Offset: 0x003D8437
		public static Offset<ITrapDefenseSpawnMonsterConditionGroup> CreateITrapDefenseSpawnMonsterConditionGroup(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ITrapDefenseSpawnMonsterConditionGroup.AddConditions(builder, ConditionsOffset);
			ITrapDefenseSpawnMonsterConditionGroup.AddConditionsType(builder, Conditions_typeOffset);
			ITrapDefenseSpawnMonsterConditionGroup.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionGroup.EndITrapDefenseSpawnMonsterConditionGroup(builder);
		}

		// Token: 0x0601B065 RID: 110693 RVA: 0x003DA25B File Offset: 0x003D845B
		public static void StartITrapDefenseSpawnMonsterConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B066 RID: 110694 RVA: 0x003DA264 File Offset: 0x003D8464
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B067 RID: 110695 RVA: 0x003DA26F File Offset: 0x003D846F
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601B068 RID: 110696 RVA: 0x003DA280 File Offset: 0x003D8480
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TTrapDefenseSpawnMonsterCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B069 RID: 110697 RVA: 0x003DA2B7 File Offset: 0x003D84B7
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TTrapDefenseSpawnMonsterCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTrapDefenseSpawnMonsterCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B06A RID: 110698 RVA: 0x003DA2D1 File Offset: 0x003D84D1
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTrapDefenseSpawnMonsterCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTrapDefenseSpawnMonsterCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B06B RID: 110699 RVA: 0x003DA2EF File Offset: 0x003D84EF
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTrapDefenseSpawnMonsterCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B06C RID: 110700 RVA: 0x003DA308 File Offset: 0x003D8508
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B06D RID: 110701 RVA: 0x003DA313 File Offset: 0x003D8513
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601B06E RID: 110702 RVA: 0x003DA324 File Offset: 0x003D8524
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B06F RID: 110703 RVA: 0x003DA35B File Offset: 0x003D855B
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B070 RID: 110704 RVA: 0x003DA375 File Offset: 0x003D8575
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B071 RID: 110705 RVA: 0x003DA393 File Offset: 0x003D8593
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B072 RID: 110706 RVA: 0x003DA3AC File Offset: 0x003D85AC
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B073 RID: 110707 RVA: 0x003DA3B7 File Offset: 0x003D85B7
		public static Offset<ITrapDefenseSpawnMonsterConditionGroup> EndITrapDefenseSpawnMonsterConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionGroup>(builder.EndTable());
		}

		// Token: 0x0601B074 RID: 110708 RVA: 0x003DA3C4 File Offset: 0x003D85C4
		public ITrapDefenseSpawnMonsterConditionGroupT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionGroupT trapDefenseSpawnMonsterConditionGroupT = new ITrapDefenseSpawnMonsterConditionGroupT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionGroupT);
			return trapDefenseSpawnMonsterConditionGroupT;
		}

		// Token: 0x0601B075 RID: 110709 RVA: 0x003DA3E0 File Offset: 0x003D85E0
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionGroupT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<TTrapDefenseSpawnMonsterConditionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				TTrapDefenseSpawnMonsterConditionUnion ttrapDefenseSpawnMonsterConditionUnion = new TTrapDefenseSpawnMonsterConditionUnion();
				ttrapDefenseSpawnMonsterConditionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion:
					ttrapDefenseSpawnMonsterConditionUnion.Value = ((this.Conditions<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion>(i) != null) ? this.Conditions<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion>(i).Value.UnPack() : null);
					break;
				case TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionCompleted:
					ttrapDefenseSpawnMonsterConditionUnion.Value = ((this.Conditions<ITrapDefenseSpawnMonsterConditionCompleted>(i) != null) ? this.Conditions<ITrapDefenseSpawnMonsterConditionCompleted>(i).Value.UnPack() : null);
					break;
				case TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionOpen:
					ttrapDefenseSpawnMonsterConditionUnion.Value = ((this.Conditions<ITrapDefenseSpawnMonsterConditionOpen>(i) != null) ? this.Conditions<ITrapDefenseSpawnMonsterConditionOpen>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(ttrapDefenseSpawnMonsterConditionUnion);
			}
		}

		// Token: 0x0601B076 RID: 110710 RVA: 0x003DA4FC File Offset: 0x003D86FC
		public static Offset<ITrapDefenseSpawnMonsterConditionGroup> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionGroup>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				TTrapDefenseSpawnMonsterCondition[] array = new TTrapDefenseSpawnMonsterCondition[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = ITrapDefenseSpawnMonsterConditionGroup.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTrapDefenseSpawnMonsterConditionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = ITrapDefenseSpawnMonsterConditionGroup.CreateConditionsVector(builder, array2);
			}
			return ITrapDefenseSpawnMonsterConditionGroup.CreateITrapDefenseSpawnMonsterConditionGroup(builder, _o.Type, conditions_typeOffset, conditionsOffset);
		}

		// Token: 0x0400C69A RID: 50842
		private Table __p;
	}
}
