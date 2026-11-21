using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A31 RID: 18993
	public struct ITrapDefenseSpawnMonsterConditionGroup : IFlatbufferObject
	{
		// Token: 0x1700853A RID: 34106
		// (get) Token: 0x0601C82C RID: 116780 RVA: 0x004062CE File Offset: 0x004044CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C82D RID: 116781 RVA: 0x004062DB File Offset: 0x004044DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C82E RID: 116782 RVA: 0x004062E4 File Offset: 0x004044E4
		public static ITrapDefenseSpawnMonsterConditionGroup GetRootAsITrapDefenseSpawnMonsterConditionGroup(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionGroup.GetRootAsITrapDefenseSpawnMonsterConditionGroup(_bb, default(ITrapDefenseSpawnMonsterConditionGroup));
		}

		// Token: 0x0601C82F RID: 116783 RVA: 0x00406300 File Offset: 0x00404500
		public static ITrapDefenseSpawnMonsterConditionGroup GetRootAsITrapDefenseSpawnMonsterConditionGroup(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C830 RID: 116784 RVA: 0x0040631D File Offset: 0x0040451D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C831 RID: 116785 RVA: 0x0040632C File Offset: 0x0040452C
		public ITrapDefenseSpawnMonsterConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700853B RID: 34107
		// (get) Token: 0x0601C832 RID: 116786 RVA: 0x0040633C File Offset: 0x0040453C
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

		// Token: 0x0601C833 RID: 116787 RVA: 0x00406378 File Offset: 0x00404578
		public TTrapDefenseSpawnMonsterCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TTrapDefenseSpawnMonsterCondition.NONE;
			}
			return (TTrapDefenseSpawnMonsterCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700853C RID: 34108
		// (get) Token: 0x0601C834 RID: 116788 RVA: 0x004063B8 File Offset: 0x004045B8
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

		// Token: 0x0601C835 RID: 116789 RVA: 0x004063E3 File Offset: 0x004045E3
		public Span<TTrapDefenseSpawnMonsterCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TTrapDefenseSpawnMonsterCondition>(6, 1);
		}

		// Token: 0x0601C836 RID: 116790 RVA: 0x004063F4 File Offset: 0x004045F4
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

		// Token: 0x0601C837 RID: 116791 RVA: 0x00406460 File Offset: 0x00404660
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700853D RID: 34109
		// (get) Token: 0x0601C838 RID: 116792 RVA: 0x004064A8 File Offset: 0x004046A8
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

		// Token: 0x0601C839 RID: 116793 RVA: 0x004064D3 File Offset: 0x004046D3
		public static Offset<ITrapDefenseSpawnMonsterConditionGroup> CreateITrapDefenseSpawnMonsterConditionGroup(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ITrapDefenseSpawnMonsterConditionGroup.AddConditions(builder, ConditionsOffset);
			ITrapDefenseSpawnMonsterConditionGroup.AddConditionsType(builder, Conditions_typeOffset);
			ITrapDefenseSpawnMonsterConditionGroup.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionGroup.EndITrapDefenseSpawnMonsterConditionGroup(builder);
		}

		// Token: 0x0601C83A RID: 116794 RVA: 0x004064F7 File Offset: 0x004046F7
		public static void StartITrapDefenseSpawnMonsterConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C83B RID: 116795 RVA: 0x00406500 File Offset: 0x00404700
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C83C RID: 116796 RVA: 0x0040650B File Offset: 0x0040470B
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601C83D RID: 116797 RVA: 0x0040651C File Offset: 0x0040471C
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TTrapDefenseSpawnMonsterCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C83E RID: 116798 RVA: 0x00406553 File Offset: 0x00404753
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TTrapDefenseSpawnMonsterCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTrapDefenseSpawnMonsterCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C83F RID: 116799 RVA: 0x0040656D File Offset: 0x0040476D
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTrapDefenseSpawnMonsterCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTrapDefenseSpawnMonsterCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C840 RID: 116800 RVA: 0x0040658B File Offset: 0x0040478B
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTrapDefenseSpawnMonsterCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C841 RID: 116801 RVA: 0x004065A4 File Offset: 0x004047A4
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C842 RID: 116802 RVA: 0x004065AF File Offset: 0x004047AF
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601C843 RID: 116803 RVA: 0x004065C0 File Offset: 0x004047C0
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C844 RID: 116804 RVA: 0x004065F7 File Offset: 0x004047F7
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C845 RID: 116805 RVA: 0x00406611 File Offset: 0x00404811
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C846 RID: 116806 RVA: 0x0040662F File Offset: 0x0040482F
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C847 RID: 116807 RVA: 0x00406648 File Offset: 0x00404848
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C848 RID: 116808 RVA: 0x00406653 File Offset: 0x00404853
		public static Offset<ITrapDefenseSpawnMonsterConditionGroup> EndITrapDefenseSpawnMonsterConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionGroup>(builder.EndTable());
		}

		// Token: 0x0601C849 RID: 116809 RVA: 0x00406660 File Offset: 0x00404860
		public ITrapDefenseSpawnMonsterConditionGroupT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionGroupT trapDefenseSpawnMonsterConditionGroupT = new ITrapDefenseSpawnMonsterConditionGroupT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionGroupT);
			return trapDefenseSpawnMonsterConditionGroupT;
		}

		// Token: 0x0601C84A RID: 116810 RVA: 0x0040667C File Offset: 0x0040487C
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

		// Token: 0x0601C84B RID: 116811 RVA: 0x00406798 File Offset: 0x00404998
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

		// Token: 0x0400D0C9 RID: 53449
		private Table __p;
	}
}
