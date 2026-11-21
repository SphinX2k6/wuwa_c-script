using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B27 RID: 27431
	public struct ICondition : IFlatbufferObject
	{
		// Token: 0x1700C970 RID: 51568
		// (get) Token: 0x0602F302 RID: 193282 RVA: 0x00671773 File Offset: 0x0066F973
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F303 RID: 193283 RVA: 0x00671780 File Offset: 0x0066F980
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F304 RID: 193284 RVA: 0x00671788 File Offset: 0x0066F988
		public static ICondition GetRootAsICondition(ByteBuffer _bb)
		{
			return ICondition.GetRootAsICondition(_bb, default(ICondition));
		}

		// Token: 0x0602F305 RID: 193285 RVA: 0x006717A4 File Offset: 0x0066F9A4
		public static ICondition GetRootAsICondition(ByteBuffer _bb, ICondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F306 RID: 193286 RVA: 0x006717C1 File Offset: 0x0066F9C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F307 RID: 193287 RVA: 0x006717D0 File Offset: 0x0066F9D0
		public ICondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C971 RID: 51569
		// (get) Token: 0x0602F308 RID: 193288 RVA: 0x006717E0 File Offset: 0x0066F9E0
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

		// Token: 0x0602F309 RID: 193289 RVA: 0x0067181C File Offset: 0x0066FA1C
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F30A RID: 193290 RVA: 0x00671860 File Offset: 0x0066FA60
		public BooleanValue Var1AsBooleanValue()
		{
			return this.Var1<BooleanValue>().Value;
		}

		// Token: 0x0602F30B RID: 193291 RVA: 0x0067187C File Offset: 0x0066FA7C
		public IntValue Var1AsIntValue()
		{
			return this.Var1<IntValue>().Value;
		}

		// Token: 0x0602F30C RID: 193292 RVA: 0x00671898 File Offset: 0x0066FA98
		public FloatValue Var1AsFloatValue()
		{
			return this.Var1<FloatValue>().Value;
		}

		// Token: 0x0602F30D RID: 193293 RVA: 0x006718B4 File Offset: 0x0066FAB4
		public StringValue Var1AsStringValue()
		{
			return this.Var1<StringValue>().Value;
		}

		// Token: 0x0602F30E RID: 193294 RVA: 0x006718D0 File Offset: 0x0066FAD0
		public QuestStateValue Var1AsQuestStateValue()
		{
			return this.Var1<QuestStateValue>().Value;
		}

		// Token: 0x0602F30F RID: 193295 RVA: 0x006718EC File Offset: 0x0066FAEC
		public EntityValue Var1AsEntityValue()
		{
			return this.Var1<EntityValue>().Value;
		}

		// Token: 0x0602F310 RID: 193296 RVA: 0x00671908 File Offset: 0x0066FB08
		public QuestValue Var1AsQuestValue()
		{
			return this.Var1<QuestValue>().Value;
		}

		// Token: 0x0602F311 RID: 193297 RVA: 0x00671924 File Offset: 0x0066FB24
		public PrefabValue Var1AsPrefabValue()
		{
			return this.Var1<PrefabValue>().Value;
		}

		// Token: 0x0602F312 RID: 193298 RVA: 0x00671940 File Offset: 0x0066FB40
		public TransformValue Var1AsTransformValue()
		{
			return this.Var1<TransformValue>().Value;
		}

		// Token: 0x1700C972 RID: 51570
		// (get) Token: 0x0602F313 RID: 193299 RVA: 0x0067195C File Offset: 0x0066FB5C
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

		// Token: 0x0602F314 RID: 193300 RVA: 0x00671998 File Offset: 0x0066FB98
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F315 RID: 193301 RVA: 0x006719E0 File Offset: 0x0066FBE0
		public BooleanValue Var2AsBooleanValue()
		{
			return this.Var2<BooleanValue>().Value;
		}

		// Token: 0x0602F316 RID: 193302 RVA: 0x006719FC File Offset: 0x0066FBFC
		public IntValue Var2AsIntValue()
		{
			return this.Var2<IntValue>().Value;
		}

		// Token: 0x0602F317 RID: 193303 RVA: 0x00671A18 File Offset: 0x0066FC18
		public FloatValue Var2AsFloatValue()
		{
			return this.Var2<FloatValue>().Value;
		}

		// Token: 0x0602F318 RID: 193304 RVA: 0x00671A34 File Offset: 0x0066FC34
		public StringValue Var2AsStringValue()
		{
			return this.Var2<StringValue>().Value;
		}

		// Token: 0x0602F319 RID: 193305 RVA: 0x00671A50 File Offset: 0x0066FC50
		public QuestStateValue Var2AsQuestStateValue()
		{
			return this.Var2<QuestStateValue>().Value;
		}

		// Token: 0x0602F31A RID: 193306 RVA: 0x00671A6C File Offset: 0x0066FC6C
		public EntityValue Var2AsEntityValue()
		{
			return this.Var2<EntityValue>().Value;
		}

		// Token: 0x0602F31B RID: 193307 RVA: 0x00671A88 File Offset: 0x0066FC88
		public QuestValue Var2AsQuestValue()
		{
			return this.Var2<QuestValue>().Value;
		}

		// Token: 0x0602F31C RID: 193308 RVA: 0x00671AA4 File Offset: 0x0066FCA4
		public PrefabValue Var2AsPrefabValue()
		{
			return this.Var2<PrefabValue>().Value;
		}

		// Token: 0x0602F31D RID: 193309 RVA: 0x00671AC0 File Offset: 0x0066FCC0
		public TransformValue Var2AsTransformValue()
		{
			return this.Var2<TransformValue>().Value;
		}

		// Token: 0x1700C973 RID: 51571
		// (get) Token: 0x0602F31E RID: 193310 RVA: 0x00671ADC File Offset: 0x0066FCDC
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

		// Token: 0x0602F31F RID: 193311 RVA: 0x00671B14 File Offset: 0x0066FD14
		public Span<byte> GetCompareBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602F320 RID: 193312 RVA: 0x00671B24 File Offset: 0x0066FD24
		public byte[] GetCompareArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0602F321 RID: 193313 RVA: 0x00671B33 File Offset: 0x0066FD33
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

		// Token: 0x0602F322 RID: 193314 RVA: 0x00671B67 File Offset: 0x0066FD67
		public static void StartICondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F323 RID: 193315 RVA: 0x00671B70 File Offset: 0x0066FD70
		public static void AddVar1Type(FlatBufferBuilder builder, TVarValue var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0602F324 RID: 193316 RVA: 0x00671B7B File Offset: 0x0066FD7B
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0602F325 RID: 193317 RVA: 0x00671B86 File Offset: 0x0066FD86
		public static void AddVar2Type(FlatBufferBuilder builder, TVarValue var2Type)
		{
			builder.AddByte(2, (byte)var2Type, 0);
		}

		// Token: 0x0602F326 RID: 193318 RVA: 0x00671B91 File Offset: 0x0066FD91
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(3, var2Offset, 0);
		}

		// Token: 0x0602F327 RID: 193319 RVA: 0x00671B9C File Offset: 0x0066FD9C
		public static void AddCompare(FlatBufferBuilder builder, StringOffset compareOffset)
		{
			builder.AddOffset(4, compareOffset.Value, 0);
		}

		// Token: 0x0602F328 RID: 193320 RVA: 0x00671BAC File Offset: 0x0066FDAC
		public static Offset<ICondition> EndICondition(FlatBufferBuilder builder)
		{
			return new Offset<ICondition>(builder.EndTable());
		}

		// Token: 0x0602F329 RID: 193321 RVA: 0x00671BBC File Offset: 0x0066FDBC
		public IConditionT UnPack()
		{
			IConditionT conditionT = new IConditionT();
			this.UnPackTo(conditionT);
			return conditionT;
		}

		// Token: 0x0602F32A RID: 193322 RVA: 0x00671BD8 File Offset: 0x0066FDD8
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

		// Token: 0x0602F32B RID: 193323 RVA: 0x006720B4 File Offset: 0x006702B4
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

		// Token: 0x04011904 RID: 71940
		private Table __p;
	}
}
