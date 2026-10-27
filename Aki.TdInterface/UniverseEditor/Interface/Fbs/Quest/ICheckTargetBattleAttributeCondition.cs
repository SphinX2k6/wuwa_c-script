using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D73 RID: 15731
	public struct ICheckTargetBattleAttributeCondition : IFlatbufferObject
	{
		// Token: 0x17006BF4 RID: 27636
		// (get) Token: 0x06015C59 RID: 89177 RVA: 0x00323948 File Offset: 0x00321B48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C5A RID: 89178 RVA: 0x00323955 File Offset: 0x00321B55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C5B RID: 89179 RVA: 0x0032395C File Offset: 0x00321B5C
		public static ICheckTargetBattleAttributeCondition GetRootAsICheckTargetBattleAttributeCondition(ByteBuffer _bb)
		{
			return ICheckTargetBattleAttributeCondition.GetRootAsICheckTargetBattleAttributeCondition(_bb, default(ICheckTargetBattleAttributeCondition));
		}

		// Token: 0x06015C5C RID: 89180 RVA: 0x00323978 File Offset: 0x00321B78
		public static ICheckTargetBattleAttributeCondition GetRootAsICheckTargetBattleAttributeCondition(ByteBuffer _bb, ICheckTargetBattleAttributeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C5D RID: 89181 RVA: 0x00323995 File Offset: 0x00321B95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C5E RID: 89182 RVA: 0x003239A4 File Offset: 0x00321BA4
		public ICheckTargetBattleAttributeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BF5 RID: 27637
		// (get) Token: 0x06015C5F RID: 89183 RVA: 0x003239B4 File Offset: 0x00321BB4
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

		// Token: 0x17006BF6 RID: 27638
		// (get) Token: 0x06015C60 RID: 89184 RVA: 0x003239F0 File Offset: 0x00321BF0
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

		// Token: 0x17006BF7 RID: 27639
		// (get) Token: 0x06015C61 RID: 89185 RVA: 0x00323A50 File Offset: 0x00321C50
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

		// Token: 0x06015C62 RID: 89186 RVA: 0x00323A8C File Offset: 0x00321C8C
		public TTargetBattleAttribute OptionType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TTargetBattleAttribute.NONE;
			}
			return (TTargetBattleAttribute)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006BF8 RID: 27640
		// (get) Token: 0x06015C63 RID: 89187 RVA: 0x00323ACC File Offset: 0x00321CCC
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

		// Token: 0x06015C64 RID: 89188 RVA: 0x00323AF8 File Offset: 0x00321CF8
		public Span<TTargetBattleAttribute> GetOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TTargetBattleAttribute>(10, 1);
		}

		// Token: 0x06015C65 RID: 89189 RVA: 0x00323B08 File Offset: 0x00321D08
		public TTargetBattleAttribute[] GetOptionTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTargetBattleAttribute[] array = new TTargetBattleAttribute[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTargetBattleAttribute)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06015C66 RID: 89190 RVA: 0x00323B74 File Offset: 0x00321D74
		public TTable? Option<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17006BF9 RID: 27641
		// (get) Token: 0x06015C67 RID: 89191 RVA: 0x00323BBC File Offset: 0x00321DBC
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

		// Token: 0x06015C68 RID: 89192 RVA: 0x00323BE8 File Offset: 0x00321DE8
		public static Offset<ICheckTargetBattleAttributeCondition> CreateICheckTargetBattleAttributeCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset Option_typeOffset = default(VectorOffset), VectorOffset OptionOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			ICheckTargetBattleAttributeCondition.AddOption(builder, OptionOffset);
			ICheckTargetBattleAttributeCondition.AddOptionType(builder, Option_typeOffset);
			ICheckTargetBattleAttributeCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckTargetBattleAttributeCondition.AddCount(builder, Count);
			ICheckTargetBattleAttributeCondition.AddType(builder, Type);
			return ICheckTargetBattleAttributeCondition.EndICheckTargetBattleAttributeCondition(builder);
		}

		// Token: 0x06015C69 RID: 89193 RVA: 0x00323C1C File Offset: 0x00321E1C
		public static void StartICheckTargetBattleAttributeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015C6A RID: 89194 RVA: 0x00323C25 File Offset: 0x00321E25
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C6B RID: 89195 RVA: 0x00323C30 File Offset: 0x00321E30
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015C6C RID: 89196 RVA: 0x00323C40 File Offset: 0x00321E40
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x06015C6D RID: 89197 RVA: 0x00323C4B File Offset: 0x00321E4B
		public static void AddOptionType(FlatBufferBuilder builder, VectorOffset optionTypeOffset)
		{
			builder.AddOffset(3, optionTypeOffset.Value, 0);
		}

		// Token: 0x06015C6E RID: 89198 RVA: 0x00323C5C File Offset: 0x00321E5C
		public static VectorOffset CreateOptionTypeVector(FlatBufferBuilder builder, TTargetBattleAttribute[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015C6F RID: 89199 RVA: 0x00323C93 File Offset: 0x00321E93
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, TTargetBattleAttribute[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTargetBattleAttribute>(data);
			return builder.EndVector();
		}

		// Token: 0x06015C70 RID: 89200 RVA: 0x00323CAD File Offset: 0x00321EAD
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTargetBattleAttribute> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTargetBattleAttribute>(data);
			return builder.EndVector();
		}

		// Token: 0x06015C71 RID: 89201 RVA: 0x00323CCB File Offset: 0x00321ECB
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTargetBattleAttribute>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015C72 RID: 89202 RVA: 0x00323CE4 File Offset: 0x00321EE4
		public static void StartOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06015C73 RID: 89203 RVA: 0x00323CEF File Offset: 0x00321EEF
		public static void AddOption(FlatBufferBuilder builder, VectorOffset optionOffset)
		{
			builder.AddOffset(4, optionOffset.Value, 0);
		}

		// Token: 0x06015C74 RID: 89204 RVA: 0x00323D00 File Offset: 0x00321F00
		public static VectorOffset CreateOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015C75 RID: 89205 RVA: 0x00323D37 File Offset: 0x00321F37
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015C76 RID: 89206 RVA: 0x00323D51 File Offset: 0x00321F51
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015C77 RID: 89207 RVA: 0x00323D6F File Offset: 0x00321F6F
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015C78 RID: 89208 RVA: 0x00323D88 File Offset: 0x00321F88
		public static void StartOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015C79 RID: 89209 RVA: 0x00323D93 File Offset: 0x00321F93
		public static Offset<ICheckTargetBattleAttributeCondition> EndICheckTargetBattleAttributeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetBattleAttributeCondition>(builder.EndTable());
		}

		// Token: 0x06015C7A RID: 89210 RVA: 0x00323DA0 File Offset: 0x00321FA0
		public ICheckTargetBattleAttributeConditionT UnPack()
		{
			ICheckTargetBattleAttributeConditionT checkTargetBattleAttributeConditionT = new ICheckTargetBattleAttributeConditionT();
			this.UnPackTo(checkTargetBattleAttributeConditionT);
			return checkTargetBattleAttributeConditionT;
		}

		// Token: 0x06015C7B RID: 89211 RVA: 0x00323DBC File Offset: 0x00321FBC
		public void UnPackTo(ICheckTargetBattleAttributeConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Count = this.Count;
			_o.Option = new List<TTargetBattleAttributeUnion>();
			for (int i = 0; i < this.OptionLength; i++)
			{
				TTargetBattleAttributeUnion ttargetBattleAttributeUnion = new TTargetBattleAttributeUnion();
				ttargetBattleAttributeUnion.Type = this.OptionType(i);
				TTargetBattleAttribute ttargetBattleAttribute = this.OptionType(i);
				if (ttargetBattleAttribute != TTargetBattleAttribute.ICheckMonsterBattleAttribute)
				{
					if (ttargetBattleAttribute == TTargetBattleAttribute.ICheckPlayerBattleAttribute)
					{
						ttargetBattleAttributeUnion.Value = ((this.Option<ICheckPlayerBattleAttribute>(i) != null) ? this.Option<ICheckPlayerBattleAttribute>(i).Value.UnPack() : null);
					}
				}
				else
				{
					ttargetBattleAttributeUnion.Value = ((this.Option<ICheckMonsterBattleAttribute>(i) != null) ? this.Option<ICheckMonsterBattleAttribute>(i).Value.UnPack() : null);
				}
				_o.Option.Add(ttargetBattleAttributeUnion);
			}
		}

		// Token: 0x06015C7C RID: 89212 RVA: 0x00323ED0 File Offset: 0x003220D0
		public static Offset<ICheckTargetBattleAttributeCondition> Pack(FlatBufferBuilder builder, ICheckTargetBattleAttributeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTargetBattleAttributeCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset option_typeOffset = default(VectorOffset);
			if (_o.Option != null)
			{
				TTargetBattleAttribute[] array = new TTargetBattleAttribute[_o.Option.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Option[i].Type;
				}
				option_typeOffset = ICheckTargetBattleAttributeCondition.CreateOptionTypeVector(builder, array);
			}
			VectorOffset optionOffset = default(VectorOffset);
			if (_o.Option != null)
			{
				int[] array2 = new int[_o.Option.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTargetBattleAttributeUnion.Pack(builder, _o.Option[j]);
				}
				optionOffset = ICheckTargetBattleAttributeCondition.CreateOptionVector(builder, array2);
			}
			return ICheckTargetBattleAttributeCondition.CreateICheckTargetBattleAttributeCondition(builder, _o.Type, preConditionsOffset, _o.Count, option_typeOffset, optionOffset);
		}

		// Token: 0x0400B65A RID: 46682
		private Table __p;
	}
}
