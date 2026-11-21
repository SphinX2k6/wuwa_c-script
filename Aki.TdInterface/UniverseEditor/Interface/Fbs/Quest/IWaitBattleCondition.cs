using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046DC RID: 18140
	public struct IWaitBattleCondition : IFlatbufferObject
	{
		// Token: 0x17007F03 RID: 32515
		// (get) Token: 0x0601AA9E RID: 109214 RVA: 0x003CA39E File Offset: 0x003C859E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA9F RID: 109215 RVA: 0x003CA3AB File Offset: 0x003C85AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AAA0 RID: 109216 RVA: 0x003CA3B4 File Offset: 0x003C85B4
		public static IWaitBattleCondition GetRootAsIWaitBattleCondition(ByteBuffer _bb)
		{
			return IWaitBattleCondition.GetRootAsIWaitBattleCondition(_bb, default(IWaitBattleCondition));
		}

		// Token: 0x0601AAA1 RID: 109217 RVA: 0x003CA3D0 File Offset: 0x003C85D0
		public static IWaitBattleCondition GetRootAsIWaitBattleCondition(ByteBuffer _bb, IWaitBattleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AAA2 RID: 109218 RVA: 0x003CA3ED File Offset: 0x003C85ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AAA3 RID: 109219 RVA: 0x003CA3FC File Offset: 0x003C85FC
		public IWaitBattleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F04 RID: 32516
		// (get) Token: 0x0601AAA4 RID: 109220 RVA: 0x003CA40C File Offset: 0x003C860C
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

		// Token: 0x17007F05 RID: 32517
		// (get) Token: 0x0601AAA5 RID: 109221 RVA: 0x003CA448 File Offset: 0x003C8648
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

		// Token: 0x17007F06 RID: 32518
		// (get) Token: 0x0601AAA6 RID: 109222 RVA: 0x003CA4A8 File Offset: 0x003C86A8
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

		// Token: 0x0601AAA7 RID: 109223 RVA: 0x003CA4E4 File Offset: 0x003C86E4
		public TBattleCondition OptionType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TBattleCondition.NONE;
			}
			return (TBattleCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007F07 RID: 32519
		// (get) Token: 0x0601AAA8 RID: 109224 RVA: 0x003CA524 File Offset: 0x003C8724
		public int OptionTypeLength
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

		// Token: 0x0601AAA9 RID: 109225 RVA: 0x003CA550 File Offset: 0x003C8750
		public Span<TBattleCondition> GetOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TBattleCondition>(10, 1);
		}

		// Token: 0x0601AAAA RID: 109226 RVA: 0x003CA560 File Offset: 0x003C8760
		public TBattleCondition[] GetOptionTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TBattleCondition[] array = new TBattleCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TBattleCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601AAAB RID: 109227 RVA: 0x003CA5CC File Offset: 0x003C87CC
		public TTable? Option<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007F08 RID: 32520
		// (get) Token: 0x0601AAAC RID: 109228 RVA: 0x003CA614 File Offset: 0x003C8814
		public int OptionLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601AAAD RID: 109229 RVA: 0x003CA640 File Offset: 0x003C8840
		public static Offset<IWaitBattleCondition> CreateIWaitBattleCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset Option_typeOffset = default(VectorOffset), VectorOffset OptionOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IWaitBattleCondition.AddOption(builder, OptionOffset);
			IWaitBattleCondition.AddOptionType(builder, Option_typeOffset);
			IWaitBattleCondition.AddPreConditions(builder, PreConditionsOffset);
			IWaitBattleCondition.AddCount(builder, Count);
			IWaitBattleCondition.AddType(builder, Type);
			return IWaitBattleCondition.EndIWaitBattleCondition(builder);
		}

		// Token: 0x0601AAAE RID: 109230 RVA: 0x003CA674 File Offset: 0x003C8874
		public static void StartIWaitBattleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601AAAF RID: 109231 RVA: 0x003CA67D File Offset: 0x003C887D
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AAB0 RID: 109232 RVA: 0x003CA688 File Offset: 0x003C8888
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601AAB1 RID: 109233 RVA: 0x003CA698 File Offset: 0x003C8898
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x0601AAB2 RID: 109234 RVA: 0x003CA6A3 File Offset: 0x003C88A3
		public static void AddOptionType(FlatBufferBuilder builder, VectorOffset optionTypeOffset)
		{
			builder.AddOffset(3, optionTypeOffset.Value, 0);
		}

		// Token: 0x0601AAB3 RID: 109235 RVA: 0x003CA6B4 File Offset: 0x003C88B4
		public static VectorOffset CreateOptionTypeVector(FlatBufferBuilder builder, TBattleCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AAB4 RID: 109236 RVA: 0x003CA6EB File Offset: 0x003C88EB
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, TBattleCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBattleCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AAB5 RID: 109237 RVA: 0x003CA705 File Offset: 0x003C8905
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBattleCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBattleCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AAB6 RID: 109238 RVA: 0x003CA723 File Offset: 0x003C8923
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBattleCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AAB7 RID: 109239 RVA: 0x003CA73C File Offset: 0x003C893C
		public static void StartOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AAB8 RID: 109240 RVA: 0x003CA747 File Offset: 0x003C8947
		public static void AddOption(FlatBufferBuilder builder, VectorOffset optionOffset)
		{
			builder.AddOffset(4, optionOffset.Value, 0);
		}

		// Token: 0x0601AAB9 RID: 109241 RVA: 0x003CA758 File Offset: 0x003C8958
		public static VectorOffset CreateOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AABA RID: 109242 RVA: 0x003CA78F File Offset: 0x003C898F
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AABB RID: 109243 RVA: 0x003CA7A9 File Offset: 0x003C89A9
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AABC RID: 109244 RVA: 0x003CA7C7 File Offset: 0x003C89C7
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AABD RID: 109245 RVA: 0x003CA7E0 File Offset: 0x003C89E0
		public static void StartOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AABE RID: 109246 RVA: 0x003CA7EB File Offset: 0x003C89EB
		public static Offset<IWaitBattleCondition> EndIWaitBattleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IWaitBattleCondition>(builder.EndTable());
		}

		// Token: 0x0601AABF RID: 109247 RVA: 0x003CA7F8 File Offset: 0x003C89F8
		public IWaitBattleConditionT UnPack()
		{
			IWaitBattleConditionT waitBattleConditionT = new IWaitBattleConditionT();
			this.UnPackTo(waitBattleConditionT);
			return waitBattleConditionT;
		}

		// Token: 0x0601AAC0 RID: 109248 RVA: 0x003CA814 File Offset: 0x003C8A14
		public void UnPackTo(IWaitBattleConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Count = this.Count;
			_o.Option = new List<TBattleConditionUnion>();
			for (int i = 0; i < this.OptionLength; i++)
			{
				TBattleConditionUnion tbattleConditionUnion = new TBattleConditionUnion();
				tbattleConditionUnion.Type = this.OptionType(i);
				switch (this.OptionType(i))
				{
				case TBattleCondition.IBattleTagCondition:
					tbattleConditionUnion.Value = ((this.Option<IBattleTagCondition>(i) != null) ? this.Option<IBattleTagCondition>(i).Value.UnPack() : null);
					break;
				case TBattleCondition.ICounterAttackCondition:
					tbattleConditionUnion.Value = ((this.Option<ICounterAttackCondition>(i) != null) ? this.Option<ICounterAttackCondition>(i).Value.UnPack() : null);
					break;
				case TBattleCondition.IPerfectDodgeCondition:
					tbattleConditionUnion.Value = ((this.Option<IPerfectDodgeCondition>(i) != null) ? this.Option<IPerfectDodgeCondition>(i).Value.UnPack() : null);
					break;
				}
				_o.Option.Add(tbattleConditionUnion);
			}
		}

		// Token: 0x0601AAC1 RID: 109249 RVA: 0x003CA96C File Offset: 0x003C8B6C
		public static Offset<IWaitBattleCondition> Pack(FlatBufferBuilder builder, IWaitBattleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitBattleCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset option_typeOffset = default(VectorOffset);
			if (_o.Option != null)
			{
				TBattleCondition[] array = new TBattleCondition[_o.Option.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Option[i].Type;
				}
				option_typeOffset = IWaitBattleCondition.CreateOptionTypeVector(builder, array);
			}
			VectorOffset optionOffset = default(VectorOffset);
			if (_o.Option != null)
			{
				int[] array2 = new int[_o.Option.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TBattleConditionUnion.Pack(builder, _o.Option[j]);
				}
				optionOffset = IWaitBattleCondition.CreateOptionVector(builder, array2);
			}
			return IWaitBattleCondition.CreateIWaitBattleCondition(builder, _o.Type, preConditionsOffset, _o.Count, option_typeOffset, optionOffset);
		}

		// Token: 0x0400C923 RID: 51491
		private Table __p;
	}
}
