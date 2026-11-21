using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418A RID: 16778
	public struct ICheckTargetBattleAttributeCondition : IFlatbufferObject
	{
		// Token: 0x170071AE RID: 29102
		// (get) Token: 0x06017191 RID: 94609 RVA: 0x0034ABC0 File Offset: 0x00348DC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017192 RID: 94610 RVA: 0x0034ABCD File Offset: 0x00348DCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017193 RID: 94611 RVA: 0x0034ABD4 File Offset: 0x00348DD4
		public static ICheckTargetBattleAttributeCondition GetRootAsICheckTargetBattleAttributeCondition(ByteBuffer _bb)
		{
			return ICheckTargetBattleAttributeCondition.GetRootAsICheckTargetBattleAttributeCondition(_bb, default(ICheckTargetBattleAttributeCondition));
		}

		// Token: 0x06017194 RID: 94612 RVA: 0x0034ABF0 File Offset: 0x00348DF0
		public static ICheckTargetBattleAttributeCondition GetRootAsICheckTargetBattleAttributeCondition(ByteBuffer _bb, ICheckTargetBattleAttributeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017195 RID: 94613 RVA: 0x0034AC0D File Offset: 0x00348E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017196 RID: 94614 RVA: 0x0034AC1C File Offset: 0x00348E1C
		public ICheckTargetBattleAttributeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071AF RID: 29103
		// (get) Token: 0x06017197 RID: 94615 RVA: 0x0034AC2C File Offset: 0x00348E2C
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

		// Token: 0x170071B0 RID: 29104
		// (get) Token: 0x06017198 RID: 94616 RVA: 0x0034AC68 File Offset: 0x00348E68
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

		// Token: 0x170071B1 RID: 29105
		// (get) Token: 0x06017199 RID: 94617 RVA: 0x0034ACC8 File Offset: 0x00348EC8
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

		// Token: 0x0601719A RID: 94618 RVA: 0x0034AD04 File Offset: 0x00348F04
		public TTargetBattleAttribute OptionType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TTargetBattleAttribute.NONE;
			}
			return (TTargetBattleAttribute)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170071B2 RID: 29106
		// (get) Token: 0x0601719B RID: 94619 RVA: 0x0034AD44 File Offset: 0x00348F44
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

		// Token: 0x0601719C RID: 94620 RVA: 0x0034AD70 File Offset: 0x00348F70
		public Span<TTargetBattleAttribute> GetOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TTargetBattleAttribute>(10, 1);
		}

		// Token: 0x0601719D RID: 94621 RVA: 0x0034AD80 File Offset: 0x00348F80
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

		// Token: 0x0601719E RID: 94622 RVA: 0x0034ADEC File Offset: 0x00348FEC
		public TTable? Option<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170071B3 RID: 29107
		// (get) Token: 0x0601719F RID: 94623 RVA: 0x0034AE34 File Offset: 0x00349034
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

		// Token: 0x060171A0 RID: 94624 RVA: 0x0034AE60 File Offset: 0x00349060
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

		// Token: 0x060171A1 RID: 94625 RVA: 0x0034AE94 File Offset: 0x00349094
		public static void StartICheckTargetBattleAttributeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060171A2 RID: 94626 RVA: 0x0034AE9D File Offset: 0x0034909D
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060171A3 RID: 94627 RVA: 0x0034AEA8 File Offset: 0x003490A8
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060171A4 RID: 94628 RVA: 0x0034AEB8 File Offset: 0x003490B8
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x060171A5 RID: 94629 RVA: 0x0034AEC3 File Offset: 0x003490C3
		public static void AddOptionType(FlatBufferBuilder builder, VectorOffset optionTypeOffset)
		{
			builder.AddOffset(3, optionTypeOffset.Value, 0);
		}

		// Token: 0x060171A6 RID: 94630 RVA: 0x0034AED4 File Offset: 0x003490D4
		public static VectorOffset CreateOptionTypeVector(FlatBufferBuilder builder, TTargetBattleAttribute[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060171A7 RID: 94631 RVA: 0x0034AF0B File Offset: 0x0034910B
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, TTargetBattleAttribute[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTargetBattleAttribute>(data);
			return builder.EndVector();
		}

		// Token: 0x060171A8 RID: 94632 RVA: 0x0034AF25 File Offset: 0x00349125
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTargetBattleAttribute> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTargetBattleAttribute>(data);
			return builder.EndVector();
		}

		// Token: 0x060171A9 RID: 94633 RVA: 0x0034AF43 File Offset: 0x00349143
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTargetBattleAttribute>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060171AA RID: 94634 RVA: 0x0034AF5C File Offset: 0x0034915C
		public static void StartOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060171AB RID: 94635 RVA: 0x0034AF67 File Offset: 0x00349167
		public static void AddOption(FlatBufferBuilder builder, VectorOffset optionOffset)
		{
			builder.AddOffset(4, optionOffset.Value, 0);
		}

		// Token: 0x060171AC RID: 94636 RVA: 0x0034AF78 File Offset: 0x00349178
		public static VectorOffset CreateOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060171AD RID: 94637 RVA: 0x0034AFAF File Offset: 0x003491AF
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060171AE RID: 94638 RVA: 0x0034AFC9 File Offset: 0x003491C9
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060171AF RID: 94639 RVA: 0x0034AFE7 File Offset: 0x003491E7
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060171B0 RID: 94640 RVA: 0x0034B000 File Offset: 0x00349200
		public static void StartOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060171B1 RID: 94641 RVA: 0x0034B00B File Offset: 0x0034920B
		public static Offset<ICheckTargetBattleAttributeCondition> EndICheckTargetBattleAttributeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetBattleAttributeCondition>(builder.EndTable());
		}

		// Token: 0x060171B2 RID: 94642 RVA: 0x0034B018 File Offset: 0x00349218
		public ICheckTargetBattleAttributeConditionT UnPack()
		{
			ICheckTargetBattleAttributeConditionT checkTargetBattleAttributeConditionT = new ICheckTargetBattleAttributeConditionT();
			this.UnPackTo(checkTargetBattleAttributeConditionT);
			return checkTargetBattleAttributeConditionT;
		}

		// Token: 0x060171B3 RID: 94643 RVA: 0x0034B034 File Offset: 0x00349234
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

		// Token: 0x060171B4 RID: 94644 RVA: 0x0034B148 File Offset: 0x00349348
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

		// Token: 0x0400C007 RID: 49159
		private Table __p;
	}
}
