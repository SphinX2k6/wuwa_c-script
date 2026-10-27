using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA0 RID: 15776
	public struct ICompareVarConditionInChildQuest : IFlatbufferObject
	{
		// Token: 0x17006C86 RID: 27782
		// (get) Token: 0x06015EC4 RID: 89796 RVA: 0x0032A69B File Offset: 0x0032889B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015EC5 RID: 89797 RVA: 0x0032A6A8 File Offset: 0x003288A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015EC6 RID: 89798 RVA: 0x0032A6B0 File Offset: 0x003288B0
		public static ICompareVarConditionInChildQuest GetRootAsICompareVarConditionInChildQuest(ByteBuffer _bb)
		{
			return ICompareVarConditionInChildQuest.GetRootAsICompareVarConditionInChildQuest(_bb, default(ICompareVarConditionInChildQuest));
		}

		// Token: 0x06015EC7 RID: 89799 RVA: 0x0032A6CC File Offset: 0x003288CC
		public static ICompareVarConditionInChildQuest GetRootAsICompareVarConditionInChildQuest(ByteBuffer _bb, ICompareVarConditionInChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015EC8 RID: 89800 RVA: 0x0032A6E9 File Offset: 0x003288E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015EC9 RID: 89801 RVA: 0x0032A6F8 File Offset: 0x003288F8
		public ICompareVarConditionInChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C87 RID: 27783
		// (get) Token: 0x06015ECA RID: 89802 RVA: 0x0032A708 File Offset: 0x00328908
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

		// Token: 0x17006C88 RID: 27784
		// (get) Token: 0x06015ECB RID: 89803 RVA: 0x0032A744 File Offset: 0x00328944
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

		// Token: 0x17006C89 RID: 27785
		// (get) Token: 0x06015ECC RID: 89804 RVA: 0x0032A7A4 File Offset: 0x003289A4
		public EConditionCount Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015ECD RID: 89805 RVA: 0x0032A7E0 File Offset: 0x003289E0
		public ICompareVarInChildQuest? Conditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICompareVarInChildQuest?(default(ICompareVarInChildQuest).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006C8A RID: 27786
		// (get) Token: 0x06015ECE RID: 89806 RVA: 0x0032A844 File Offset: 0x00328A44
		public int ConditionsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06015ECF RID: 89807 RVA: 0x0032A870 File Offset: 0x00328A70
		public static Offset<ICompareVarConditionInChildQuest> CreateICompareVarConditionInChildQuest(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICompareVarConditionInChildQuest.AddConditions(builder, ConditionsOffset);
			ICompareVarConditionInChildQuest.AddPreConditions(builder, PreConditionsOffset);
			ICompareVarConditionInChildQuest.AddCount(builder, Count);
			ICompareVarConditionInChildQuest.AddType(builder, Type);
			return ICompareVarConditionInChildQuest.EndICompareVarConditionInChildQuest(builder);
		}

		// Token: 0x06015ED0 RID: 89808 RVA: 0x0032A89C File Offset: 0x00328A9C
		public static void StartICompareVarConditionInChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015ED1 RID: 89809 RVA: 0x0032A8A5 File Offset: 0x00328AA5
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015ED2 RID: 89810 RVA: 0x0032A8B0 File Offset: 0x00328AB0
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015ED3 RID: 89811 RVA: 0x0032A8C0 File Offset: 0x00328AC0
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x06015ED4 RID: 89812 RVA: 0x0032A8CB File Offset: 0x00328ACB
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x06015ED5 RID: 89813 RVA: 0x0032A8DC File Offset: 0x00328ADC
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICompareVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015ED6 RID: 89814 RVA: 0x0032A91C File Offset: 0x00328B1C
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICompareVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICompareVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015ED7 RID: 89815 RVA: 0x0032A936 File Offset: 0x00328B36
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICompareVarInChildQuest>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICompareVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015ED8 RID: 89816 RVA: 0x0032A954 File Offset: 0x00328B54
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICompareVarInChildQuest>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015ED9 RID: 89817 RVA: 0x0032A96D File Offset: 0x00328B6D
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015EDA RID: 89818 RVA: 0x0032A978 File Offset: 0x00328B78
		public static Offset<ICompareVarConditionInChildQuest> EndICompareVarConditionInChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVarConditionInChildQuest>(builder.EndTable());
		}

		// Token: 0x06015EDB RID: 89819 RVA: 0x0032A988 File Offset: 0x00328B88
		public ICompareVarConditionInChildQuestT UnPack()
		{
			ICompareVarConditionInChildQuestT compareVarConditionInChildQuestT = new ICompareVarConditionInChildQuestT();
			this.UnPackTo(compareVarConditionInChildQuestT);
			return compareVarConditionInChildQuestT;
		}

		// Token: 0x06015EDC RID: 89820 RVA: 0x0032A9A4 File Offset: 0x00328BA4
		public void UnPackTo(ICompareVarConditionInChildQuestT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Count = this.Count;
			_o.Conditions = new List<ICompareVarInChildQuestT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06015EDD RID: 89821 RVA: 0x0032AA4C File Offset: 0x00328C4C
		public static Offset<ICompareVarConditionInChildQuest> Pack(FlatBufferBuilder builder, ICompareVarConditionInChildQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareVarConditionInChildQuest>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICompareVarInChildQuest>[] array = new Offset<ICompareVarInChildQuest>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICompareVarInChildQuest.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = ICompareVarConditionInChildQuest.CreateConditionsVector(builder, array);
			}
			return ICompareVarConditionInChildQuest.CreateICompareVarConditionInChildQuest(builder, _o.Type, preConditionsOffset, _o.Count, conditionsOffset);
		}

		// Token: 0x0400B6AF RID: 46767
		private Table __p;
	}
}
