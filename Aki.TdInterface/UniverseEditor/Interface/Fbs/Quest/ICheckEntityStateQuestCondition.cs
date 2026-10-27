using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D4C RID: 15692
	public struct ICheckEntityStateQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006BAD RID: 27565
		// (get) Token: 0x06015B1B RID: 88859 RVA: 0x00321472 File Offset: 0x0031F672
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B1C RID: 88860 RVA: 0x0032147F File Offset: 0x0031F67F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B1D RID: 88861 RVA: 0x00321488 File Offset: 0x0031F688
		public static ICheckEntityStateQuestCondition GetRootAsICheckEntityStateQuestCondition(ByteBuffer _bb)
		{
			return ICheckEntityStateQuestCondition.GetRootAsICheckEntityStateQuestCondition(_bb, default(ICheckEntityStateQuestCondition));
		}

		// Token: 0x06015B1E RID: 88862 RVA: 0x003214A4 File Offset: 0x0031F6A4
		public static ICheckEntityStateQuestCondition GetRootAsICheckEntityStateQuestCondition(ByteBuffer _bb, ICheckEntityStateQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B1F RID: 88863 RVA: 0x003214C1 File Offset: 0x0031F6C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B20 RID: 88864 RVA: 0x003214D0 File Offset: 0x0031F6D0
		public ICheckEntityStateQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BAE RID: 27566
		// (get) Token: 0x06015B21 RID: 88865 RVA: 0x003214E0 File Offset: 0x0031F6E0
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BAF RID: 27567
		// (get) Token: 0x06015B22 RID: 88866 RVA: 0x0032151C File Offset: 0x0031F71C
		public IConditionGroup? PreConditions
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

		// Token: 0x06015B23 RID: 88867 RVA: 0x0032157C File Offset: 0x0031F77C
		public IEntityStateCondition? Conditions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006BB0 RID: 27568
		// (get) Token: 0x06015B24 RID: 88868 RVA: 0x003215DC File Offset: 0x0031F7DC
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

		// Token: 0x06015B25 RID: 88869 RVA: 0x00321607 File Offset: 0x0031F807
		public static Offset<ICheckEntityStateQuestCondition> CreateICheckEntityStateQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckEntityStateQuestCondition.AddConditions(builder, ConditionsOffset);
			ICheckEntityStateQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckEntityStateQuestCondition.AddType(builder, Type);
			return ICheckEntityStateQuestCondition.EndICheckEntityStateQuestCondition(builder);
		}

		// Token: 0x06015B26 RID: 88870 RVA: 0x0032162B File Offset: 0x0031F82B
		public static void StartICheckEntityStateQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015B27 RID: 88871 RVA: 0x00321634 File Offset: 0x0031F834
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015B28 RID: 88872 RVA: 0x0032163F File Offset: 0x0031F83F
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015B29 RID: 88873 RVA: 0x0032164F File Offset: 0x0031F84F
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x06015B2A RID: 88874 RVA: 0x00321660 File Offset: 0x0031F860
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015B2B RID: 88875 RVA: 0x003216A0 File Offset: 0x0031F8A0
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015B2C RID: 88876 RVA: 0x003216BA File Offset: 0x0031F8BA
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015B2D RID: 88877 RVA: 0x003216D8 File Offset: 0x0031F8D8
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015B2E RID: 88878 RVA: 0x003216F1 File Offset: 0x0031F8F1
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015B2F RID: 88879 RVA: 0x003216FC File Offset: 0x0031F8FC
		public static Offset<ICheckEntityStateQuestCondition> EndICheckEntityStateQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityStateQuestCondition>(builder.EndTable());
		}

		// Token: 0x06015B30 RID: 88880 RVA: 0x0032170C File Offset: 0x0031F90C
		public ICheckEntityStateQuestConditionT UnPack()
		{
			ICheckEntityStateQuestConditionT checkEntityStateQuestConditionT = new ICheckEntityStateQuestConditionT();
			this.UnPackTo(checkEntityStateQuestConditionT);
			return checkEntityStateQuestConditionT;
		}

		// Token: 0x06015B31 RID: 88881 RVA: 0x00321728 File Offset: 0x0031F928
		public void UnPackTo(ICheckEntityStateQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Conditions = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06015B32 RID: 88882 RVA: 0x003217C4 File Offset: 0x0031F9C4
		public static Offset<ICheckEntityStateQuestCondition> Pack(FlatBufferBuilder builder, ICheckEntityStateQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityStateQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<IEntityStateCondition>[] array = new Offset<IEntityStateCondition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateCondition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = ICheckEntityStateQuestCondition.CreateConditionsVector(builder, array);
			}
			return ICheckEntityStateQuestCondition.CreateICheckEntityStateQuestCondition(builder, _o.Type, preConditionsOffset, conditionsOffset);
		}

		// Token: 0x0400B626 RID: 46630
		private Table __p;
	}
}
