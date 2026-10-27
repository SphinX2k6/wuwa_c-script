using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064BC RID: 25788
	public struct ICondition : IFlatbufferObject
	{
		// Token: 0x1700BFE3 RID: 49123
		// (get) Token: 0x0602CB7E RID: 183166 RVA: 0x0062564B File Offset: 0x0062384B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CB7F RID: 183167 RVA: 0x00625658 File Offset: 0x00623858
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CB80 RID: 183168 RVA: 0x00625660 File Offset: 0x00623860
		public static ICondition GetRootAsICondition(ByteBuffer _bb)
		{
			return ICondition.GetRootAsICondition(_bb, default(ICondition));
		}

		// Token: 0x0602CB81 RID: 183169 RVA: 0x0062567C File Offset: 0x0062387C
		public static ICondition GetRootAsICondition(ByteBuffer _bb, ICondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CB82 RID: 183170 RVA: 0x00625699 File Offset: 0x00623899
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CB83 RID: 183171 RVA: 0x006256A8 File Offset: 0x006238A8
		public ICondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFE4 RID: 49124
		// (get) Token: 0x0602CB84 RID: 183172 RVA: 0x006256B8 File Offset: 0x006238B8
		public TVarValue Var1Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TVarValue.NONE;
				}
				return (TVarValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB85 RID: 183173 RVA: 0x006256F4 File Offset: 0x006238F4
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CB86 RID: 183174 RVA: 0x00625738 File Offset: 0x00623938
		public BooleanValue Var1AsBooleanValue()
		{
			return this.Var1<BooleanValue>().Value;
		}

		// Token: 0x0602CB87 RID: 183175 RVA: 0x00625754 File Offset: 0x00623954
		public IntValue Var1AsIntValue()
		{
			return this.Var1<IntValue>().Value;
		}

		// Token: 0x0602CB88 RID: 183176 RVA: 0x00625770 File Offset: 0x00623970
		public FloatValue Var1AsFloatValue()
		{
			return this.Var1<FloatValue>().Value;
		}

		// Token: 0x0602CB89 RID: 183177 RVA: 0x0062578C File Offset: 0x0062398C
		public StringValue Var1AsStringValue()
		{
			return this.Var1<StringValue>().Value;
		}

		// Token: 0x0602CB8A RID: 183178 RVA: 0x006257A8 File Offset: 0x006239A8
		public QuestStateValue Var1AsQuestStateValue()
		{
			return this.Var1<QuestStateValue>().Value;
		}

		// Token: 0x0602CB8B RID: 183179 RVA: 0x006257C4 File Offset: 0x006239C4
		public EntityValue Var1AsEntityValue()
		{
			return this.Var1<EntityValue>().Value;
		}

		// Token: 0x0602CB8C RID: 183180 RVA: 0x006257E0 File Offset: 0x006239E0
		public QuestValue Var1AsQuestValue()
		{
			return this.Var1<QuestValue>().Value;
		}

		// Token: 0x0602CB8D RID: 183181 RVA: 0x006257FC File Offset: 0x006239FC
		public PrefabValue Var1AsPrefabValue()
		{
			return this.Var1<PrefabValue>().Value;
		}

		// Token: 0x0602CB8E RID: 183182 RVA: 0x00625818 File Offset: 0x00623A18
		public TransformValue Var1AsTransformValue()
		{
			return this.Var1<TransformValue>().Value;
		}

		// Token: 0x1700BFE5 RID: 49125
		// (get) Token: 0x0602CB8F RID: 183183 RVA: 0x00625834 File Offset: 0x00623A34
		public TVarValue Var2Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarValue.NONE;
				}
				return (TVarValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB90 RID: 183184 RVA: 0x00625870 File Offset: 0x00623A70
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CB91 RID: 183185 RVA: 0x006258B8 File Offset: 0x00623AB8
		public BooleanValue Var2AsBooleanValue()
		{
			return this.Var2<BooleanValue>().Value;
		}

		// Token: 0x0602CB92 RID: 183186 RVA: 0x006258D4 File Offset: 0x00623AD4
		public IntValue Var2AsIntValue()
		{
			return this.Var2<IntValue>().Value;
		}

		// Token: 0x0602CB93 RID: 183187 RVA: 0x006258F0 File Offset: 0x00623AF0
		public FloatValue Var2AsFloatValue()
		{
			return this.Var2<FloatValue>().Value;
		}

		// Token: 0x0602CB94 RID: 183188 RVA: 0x0062590C File Offset: 0x00623B0C
		public StringValue Var2AsStringValue()
		{
			return this.Var2<StringValue>().Value;
		}

		// Token: 0x0602CB95 RID: 183189 RVA: 0x00625928 File Offset: 0x00623B28
		public QuestStateValue Var2AsQuestStateValue()
		{
			return this.Var2<QuestStateValue>().Value;
		}

		// Token: 0x0602CB96 RID: 183190 RVA: 0x00625944 File Offset: 0x00623B44
		public EntityValue Var2AsEntityValue()
		{
			return this.Var2<EntityValue>().Value;
		}

		// Token: 0x0602CB97 RID: 183191 RVA: 0x00625960 File Offset: 0x00623B60
		public QuestValue Var2AsQuestValue()
		{
			return this.Var2<QuestValue>().Value;
		}

		// Token: 0x0602CB98 RID: 183192 RVA: 0x0062597C File Offset: 0x00623B7C
		public PrefabValue Var2AsPrefabValue()
		{
			return this.Var2<PrefabValue>().Value;
		}

		// Token: 0x0602CB99 RID: 183193 RVA: 0x00625998 File Offset: 0x00623B98
		public TransformValue Var2AsTransformValue()
		{
			return this.Var2<TransformValue>().Value;
		}

		// Token: 0x1700BFE6 RID: 49126
		// (get) Token: 0x0602CB9A RID: 183194 RVA: 0x006259B4 File Offset: 0x00623BB4
		public string Compare
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB9B RID: 183195 RVA: 0x006259EC File Offset: 0x00623BEC
		public Span<byte> GetCompareBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602CB9C RID: 183196 RVA: 0x006259FC File Offset: 0x00623BFC
		public byte[] GetCompareArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0602CB9D RID: 183197 RVA: 0x00625A0B File Offset: 0x00623C0B
		public static Offset<ICondition> CreateICondition(FlatBufferBuilder builder, TVarValue Var1_type = TVarValue.NONE, int Var1Offset = 0, TVarValue Var2_type = TVarValue.NONE, int Var2Offset = 0, StringOffset CompareOffset = default(StringOffset))
		{
			builder.StartTable(5);
			ICondition.AddCompare(builder, CompareOffset);
			ICondition.AddVar2(builder, Var2Offset);
			ICondition.AddVar1(builder, Var1Offset);
			ICondition.AddVar2Type(builder, Var2_type);
			ICondition.AddVar1Type(builder, Var1_type);
			return ICondition.EndICondition(builder);
		}

		// Token: 0x0602CB9E RID: 183198 RVA: 0x00625A3F File Offset: 0x00623C3F
		public static void StartICondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602CB9F RID: 183199 RVA: 0x00625A48 File Offset: 0x00623C48
		public static void AddVar1Type(FlatBufferBuilder builder, TVarValue var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0602CBA0 RID: 183200 RVA: 0x00625A53 File Offset: 0x00623C53
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0602CBA1 RID: 183201 RVA: 0x00625A5E File Offset: 0x00623C5E
		public static void AddVar2Type(FlatBufferBuilder builder, TVarValue var2Type)
		{
			builder.AddByte(2, (byte)var2Type, 0);
		}

		// Token: 0x0602CBA2 RID: 183202 RVA: 0x00625A69 File Offset: 0x00623C69
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(3, var2Offset, 0);
		}

		// Token: 0x0602CBA3 RID: 183203 RVA: 0x00625A74 File Offset: 0x00623C74
		public static void AddCompare(FlatBufferBuilder builder, StringOffset compareOffset)
		{
			builder.AddOffset(4, compareOffset.Value, 0);
		}

		// Token: 0x0602CBA4 RID: 183204 RVA: 0x00625A84 File Offset: 0x00623C84
		public static Offset<ICondition> EndICondition(FlatBufferBuilder builder)
		{
			return new Offset<ICondition>(builder.EndTable());
		}

		// Token: 0x0602CBA5 RID: 183205 RVA: 0x00625A94 File Offset: 0x00623C94
		public IConditionT UnPack()
		{
			IConditionT conditionT = new IConditionT();
			this.UnPackTo(conditionT);
			return conditionT;
		}

		// Token: 0x0602CBA6 RID: 183206 RVA: 0x00625AB0 File Offset: 0x00623CB0
		public void UnPackTo(IConditionT _o)
		{
			_o.Var1 = new TVarValueUnion();
			_o.Var1.Type = this.Var1Type;
			switch (this.Var1Type)
			{
			case TVarValue.BooleanValue:
				_o.Var1.Value = ((this.Var1<BooleanValue>() != null) ? this.Var1<BooleanValue>().Value.UnPack() : null);
				break;
			case TVarValue.IntValue:
				_o.Var1.Value = ((this.Var1<IntValue>() != null) ? this.Var1<IntValue>().Value.UnPack() : null);
				break;
			case TVarValue.FloatValue:
				_o.Var1.Value = ((this.Var1<FloatValue>() != null) ? this.Var1<FloatValue>().Value.UnPack() : null);
				break;
			case TVarValue.StringValue:
				_o.Var1.Value = ((this.Var1<StringValue>() != null) ? this.Var1<StringValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestStateValue:
				_o.Var1.Value = ((this.Var1<QuestStateValue>() != null) ? this.Var1<QuestStateValue>().Value.UnPack() : null);
				break;
			case TVarValue.EntityValue:
				_o.Var1.Value = ((this.Var1<EntityValue>() != null) ? this.Var1<EntityValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestValue:
				_o.Var1.Value = ((this.Var1<QuestValue>() != null) ? this.Var1<QuestValue>().Value.UnPack() : null);
				break;
			case TVarValue.PrefabValue:
				_o.Var1.Value = ((this.Var1<PrefabValue>() != null) ? this.Var1<PrefabValue>().Value.UnPack() : null);
				break;
			case TVarValue.TransformValue:
				_o.Var1.Value = ((this.Var1<TransformValue>() != null) ? this.Var1<TransformValue>().Value.UnPack() : null);
				break;
			}
			_o.Var2 = new TVarValueUnion();
			_o.Var2.Type = this.Var2Type;
			switch (this.Var2Type)
			{
			case TVarValue.BooleanValue:
				_o.Var2.Value = ((this.Var2<BooleanValue>() != null) ? this.Var2<BooleanValue>().Value.UnPack() : null);
				break;
			case TVarValue.IntValue:
				_o.Var2.Value = ((this.Var2<IntValue>() != null) ? this.Var2<IntValue>().Value.UnPack() : null);
				break;
			case TVarValue.FloatValue:
				_o.Var2.Value = ((this.Var2<FloatValue>() != null) ? this.Var2<FloatValue>().Value.UnPack() : null);
				break;
			case TVarValue.StringValue:
				_o.Var2.Value = ((this.Var2<StringValue>() != null) ? this.Var2<StringValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestStateValue:
				_o.Var2.Value = ((this.Var2<QuestStateValue>() != null) ? this.Var2<QuestStateValue>().Value.UnPack() : null);
				break;
			case TVarValue.EntityValue:
				_o.Var2.Value = ((this.Var2<EntityValue>() != null) ? this.Var2<EntityValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestValue:
				_o.Var2.Value = ((this.Var2<QuestValue>() != null) ? this.Var2<QuestValue>().Value.UnPack() : null);
				break;
			case TVarValue.PrefabValue:
				_o.Var2.Value = ((this.Var2<PrefabValue>() != null) ? this.Var2<PrefabValue>().Value.UnPack() : null);
				break;
			case TVarValue.TransformValue:
				_o.Var2.Value = ((this.Var2<TransformValue>() != null) ? this.Var2<TransformValue>().Value.UnPack() : null);
				break;
			}
			_o.Compare = this.Compare;
		}

		// Token: 0x0602CBA7 RID: 183207 RVA: 0x00625F8C File Offset: 0x0062418C
		public static Offset<ICondition> Pack(FlatBufferBuilder builder, IConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICondition>);
			}
			TVarValue var1_type = (_o.Var1 == null) ? TVarValue.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarValueUnion.Pack(builder, _o.Var1);
			TVarValue var2_type = (_o.Var2 == null) ? TVarValue.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarValueUnion.Pack(builder, _o.Var2);
			StringOffset compareOffset = (_o.Compare == null) ? default(StringOffset) : builder.CreateString(_o.Compare);
			return ICondition.CreateICondition(builder, var1_type, var1Offset, var2_type, var2Offset, compareOffset);
		}

		// Token: 0x04010AEE RID: 68334
		private Table __p;
	}
}
