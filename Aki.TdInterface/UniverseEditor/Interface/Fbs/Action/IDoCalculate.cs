using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065FA RID: 26106
	public struct IDoCalculate : IFlatbufferObject
	{
		// Token: 0x1700C1F6 RID: 49654
		// (get) Token: 0x0602D515 RID: 185621 RVA: 0x00635ED5 File Offset: 0x006340D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D516 RID: 185622 RVA: 0x00635EE2 File Offset: 0x006340E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D517 RID: 185623 RVA: 0x00635EEC File Offset: 0x006340EC
		public static IDoCalculate GetRootAsIDoCalculate(ByteBuffer _bb)
		{
			return IDoCalculate.GetRootAsIDoCalculate(_bb, default(IDoCalculate));
		}

		// Token: 0x0602D518 RID: 185624 RVA: 0x00635F08 File Offset: 0x00634108
		public static IDoCalculate GetRootAsIDoCalculate(ByteBuffer _bb, IDoCalculate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D519 RID: 185625 RVA: 0x00635F25 File Offset: 0x00634125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D51A RID: 185626 RVA: 0x00635F34 File Offset: 0x00634134
		public IDoCalculate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1F7 RID: 49655
		// (get) Token: 0x0602D51B RID: 185627 RVA: 0x00635F44 File Offset: 0x00634144
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

		// Token: 0x0602D51C RID: 185628 RVA: 0x00635F80 File Offset: 0x00634180
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D51D RID: 185629 RVA: 0x00635FC4 File Offset: 0x006341C4
		public BooleanValue Var1AsBooleanValue()
		{
			return this.Var1<BooleanValue>().Value;
		}

		// Token: 0x0602D51E RID: 185630 RVA: 0x00635FE0 File Offset: 0x006341E0
		public IntValue Var1AsIntValue()
		{
			return this.Var1<IntValue>().Value;
		}

		// Token: 0x0602D51F RID: 185631 RVA: 0x00635FFC File Offset: 0x006341FC
		public FloatValue Var1AsFloatValue()
		{
			return this.Var1<FloatValue>().Value;
		}

		// Token: 0x0602D520 RID: 185632 RVA: 0x00636018 File Offset: 0x00634218
		public StringValue Var1AsStringValue()
		{
			return this.Var1<StringValue>().Value;
		}

		// Token: 0x0602D521 RID: 185633 RVA: 0x00636034 File Offset: 0x00634234
		public QuestStateValue Var1AsQuestStateValue()
		{
			return this.Var1<QuestStateValue>().Value;
		}

		// Token: 0x0602D522 RID: 185634 RVA: 0x00636050 File Offset: 0x00634250
		public EntityValue Var1AsEntityValue()
		{
			return this.Var1<EntityValue>().Value;
		}

		// Token: 0x0602D523 RID: 185635 RVA: 0x0063606C File Offset: 0x0063426C
		public QuestValue Var1AsQuestValue()
		{
			return this.Var1<QuestValue>().Value;
		}

		// Token: 0x0602D524 RID: 185636 RVA: 0x00636088 File Offset: 0x00634288
		public PrefabValue Var1AsPrefabValue()
		{
			return this.Var1<PrefabValue>().Value;
		}

		// Token: 0x0602D525 RID: 185637 RVA: 0x006360A4 File Offset: 0x006342A4
		public TransformValue Var1AsTransformValue()
		{
			return this.Var1<TransformValue>().Value;
		}

		// Token: 0x1700C1F8 RID: 49656
		// (get) Token: 0x0602D526 RID: 185638 RVA: 0x006360C0 File Offset: 0x006342C0
		public string Op
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D527 RID: 185639 RVA: 0x006360F7 File Offset: 0x006342F7
		public Span<byte> GetOpBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602D528 RID: 185640 RVA: 0x00636106 File Offset: 0x00634306
		public byte[] GetOpArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C1F9 RID: 49657
		// (get) Token: 0x0602D529 RID: 185641 RVA: 0x00636114 File Offset: 0x00634314
		public TVarValue Var2Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarValue.NONE;
				}
				return (TVarValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D52A RID: 185642 RVA: 0x00636154 File Offset: 0x00634354
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D52B RID: 185643 RVA: 0x0063619C File Offset: 0x0063439C
		public BooleanValue Var2AsBooleanValue()
		{
			return this.Var2<BooleanValue>().Value;
		}

		// Token: 0x0602D52C RID: 185644 RVA: 0x006361B8 File Offset: 0x006343B8
		public IntValue Var2AsIntValue()
		{
			return this.Var2<IntValue>().Value;
		}

		// Token: 0x0602D52D RID: 185645 RVA: 0x006361D4 File Offset: 0x006343D4
		public FloatValue Var2AsFloatValue()
		{
			return this.Var2<FloatValue>().Value;
		}

		// Token: 0x0602D52E RID: 185646 RVA: 0x006361F0 File Offset: 0x006343F0
		public StringValue Var2AsStringValue()
		{
			return this.Var2<StringValue>().Value;
		}

		// Token: 0x0602D52F RID: 185647 RVA: 0x0063620C File Offset: 0x0063440C
		public QuestStateValue Var2AsQuestStateValue()
		{
			return this.Var2<QuestStateValue>().Value;
		}

		// Token: 0x0602D530 RID: 185648 RVA: 0x00636228 File Offset: 0x00634428
		public EntityValue Var2AsEntityValue()
		{
			return this.Var2<EntityValue>().Value;
		}

		// Token: 0x0602D531 RID: 185649 RVA: 0x00636244 File Offset: 0x00634444
		public QuestValue Var2AsQuestValue()
		{
			return this.Var2<QuestValue>().Value;
		}

		// Token: 0x0602D532 RID: 185650 RVA: 0x00636260 File Offset: 0x00634460
		public PrefabValue Var2AsPrefabValue()
		{
			return this.Var2<PrefabValue>().Value;
		}

		// Token: 0x0602D533 RID: 185651 RVA: 0x0063627C File Offset: 0x0063447C
		public TransformValue Var2AsTransformValue()
		{
			return this.Var2<TransformValue>().Value;
		}

		// Token: 0x1700C1FA RID: 49658
		// (get) Token: 0x0602D534 RID: 185652 RVA: 0x00636298 File Offset: 0x00634498
		public string Result
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D535 RID: 185653 RVA: 0x006362D0 File Offset: 0x006344D0
		public Span<byte> GetResultBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602D536 RID: 185654 RVA: 0x006362E0 File Offset: 0x006344E0
		public byte[] GetResultArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0602D537 RID: 185655 RVA: 0x006362EF File Offset: 0x006344EF
		public static Offset<IDoCalculate> CreateIDoCalculate(FlatBufferBuilder builder, TVarValue Var1_type = TVarValue.NONE, int Var1Offset = 0, StringOffset OpOffset = default(StringOffset), TVarValue Var2_type = TVarValue.NONE, int Var2Offset = 0, StringOffset ResultOffset = default(StringOffset))
		{
			builder.StartTable(6);
			IDoCalculate.AddResult(builder, ResultOffset);
			IDoCalculate.AddVar2(builder, Var2Offset);
			IDoCalculate.AddOp(builder, OpOffset);
			IDoCalculate.AddVar1(builder, Var1Offset);
			IDoCalculate.AddVar2Type(builder, Var2_type);
			IDoCalculate.AddVar1Type(builder, Var1_type);
			return IDoCalculate.EndIDoCalculate(builder);
		}

		// Token: 0x0602D538 RID: 185656 RVA: 0x0063632B File Offset: 0x0063452B
		public static void StartIDoCalculate(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602D539 RID: 185657 RVA: 0x00636334 File Offset: 0x00634534
		public static void AddVar1Type(FlatBufferBuilder builder, TVarValue var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0602D53A RID: 185658 RVA: 0x0063633F File Offset: 0x0063453F
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0602D53B RID: 185659 RVA: 0x0063634A File Offset: 0x0063454A
		public static void AddOp(FlatBufferBuilder builder, StringOffset opOffset)
		{
			builder.AddOffset(2, opOffset.Value, 0);
		}

		// Token: 0x0602D53C RID: 185660 RVA: 0x0063635A File Offset: 0x0063455A
		public static void AddVar2Type(FlatBufferBuilder builder, TVarValue var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x0602D53D RID: 185661 RVA: 0x00636365 File Offset: 0x00634565
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x0602D53E RID: 185662 RVA: 0x00636370 File Offset: 0x00634570
		public static void AddResult(FlatBufferBuilder builder, StringOffset resultOffset)
		{
			builder.AddOffset(5, resultOffset.Value, 0);
		}

		// Token: 0x0602D53F RID: 185663 RVA: 0x00636380 File Offset: 0x00634580
		public static Offset<IDoCalculate> EndIDoCalculate(FlatBufferBuilder builder)
		{
			return new Offset<IDoCalculate>(builder.EndTable());
		}

		// Token: 0x0602D540 RID: 185664 RVA: 0x00636390 File Offset: 0x00634590
		public IDoCalculateT UnPack()
		{
			IDoCalculateT doCalculateT = new IDoCalculateT();
			this.UnPackTo(doCalculateT);
			return doCalculateT;
		}

		// Token: 0x0602D541 RID: 185665 RVA: 0x006363AC File Offset: 0x006345AC
		public void UnPackTo(IDoCalculateT _o)
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
			_o.Op = this.Op;
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
			_o.Result = this.Result;
		}

		// Token: 0x0602D542 RID: 185666 RVA: 0x00636894 File Offset: 0x00634A94
		public static Offset<IDoCalculate> Pack(FlatBufferBuilder builder, IDoCalculateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDoCalculate>);
			}
			TVarValue var1_type = (_o.Var1 == null) ? TVarValue.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarValueUnion.Pack(builder, _o.Var1);
			StringOffset opOffset = (_o.Op == null) ? default(StringOffset) : builder.CreateString(_o.Op);
			TVarValue var2_type = (_o.Var2 == null) ? TVarValue.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarValueUnion.Pack(builder, _o.Var2);
			StringOffset resultOffset = (_o.Result == null) ? default(StringOffset) : builder.CreateString(_o.Result);
			return IDoCalculate.CreateIDoCalculate(builder, var1_type, var1Offset, opOffset, var2_type, var2Offset, resultOffset);
		}

		// Token: 0x04010C7D RID: 68733
		private Table __p;
	}
}
