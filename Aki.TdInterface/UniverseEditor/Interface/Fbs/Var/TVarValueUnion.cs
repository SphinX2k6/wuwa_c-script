using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F6E RID: 16238
	public class TVarValueUnion
	{
		// Token: 0x17006DCD RID: 28109
		// (get) Token: 0x06016195 RID: 90517 RVA: 0x0032BCDC File Offset: 0x00329EDC
		// (set) Token: 0x06016196 RID: 90518 RVA: 0x0032BCE4 File Offset: 0x00329EE4
		public TVarValue Type { get; set; }

		// Token: 0x17006DCE RID: 28110
		// (get) Token: 0x06016197 RID: 90519 RVA: 0x0032BCED File Offset: 0x00329EED
		// (set) Token: 0x06016198 RID: 90520 RVA: 0x0032BCF5 File Offset: 0x00329EF5
		public object Value { get; set; }

		// Token: 0x06016199 RID: 90521 RVA: 0x0032BCFE File Offset: 0x00329EFE
		public TVarValueUnion()
		{
			this.Type = TVarValue.NONE;
			this.Value = null;
		}

		// Token: 0x0601619A RID: 90522 RVA: 0x0032BD14 File Offset: 0x00329F14
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601619B RID: 90523 RVA: 0x0032BD26 File Offset: 0x00329F26
		public BooleanValueT AsBooleanValue()
		{
			return this.As<BooleanValueT>();
		}

		// Token: 0x0601619C RID: 90524 RVA: 0x0032BD2E File Offset: 0x00329F2E
		public static TVarValueUnion FromBooleanValue(BooleanValueT _booleanvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.BooleanValue,
				Value = _booleanvalue
			};
		}

		// Token: 0x0601619D RID: 90525 RVA: 0x0032BD43 File Offset: 0x00329F43
		public IntValueT AsIntValue()
		{
			return this.As<IntValueT>();
		}

		// Token: 0x0601619E RID: 90526 RVA: 0x0032BD4B File Offset: 0x00329F4B
		public static TVarValueUnion FromIntValue(IntValueT _intvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.IntValue,
				Value = _intvalue
			};
		}

		// Token: 0x0601619F RID: 90527 RVA: 0x0032BD60 File Offset: 0x00329F60
		public FloatValueT AsFloatValue()
		{
			return this.As<FloatValueT>();
		}

		// Token: 0x060161A0 RID: 90528 RVA: 0x0032BD68 File Offset: 0x00329F68
		public static TVarValueUnion FromFloatValue(FloatValueT _floatvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.FloatValue,
				Value = _floatvalue
			};
		}

		// Token: 0x060161A1 RID: 90529 RVA: 0x0032BD7D File Offset: 0x00329F7D
		public StringValueT AsStringValue()
		{
			return this.As<StringValueT>();
		}

		// Token: 0x060161A2 RID: 90530 RVA: 0x0032BD85 File Offset: 0x00329F85
		public static TVarValueUnion FromStringValue(StringValueT _stringvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.StringValue,
				Value = _stringvalue
			};
		}

		// Token: 0x060161A3 RID: 90531 RVA: 0x0032BD9A File Offset: 0x00329F9A
		public QuestStateValueT AsQuestStateValue()
		{
			return this.As<QuestStateValueT>();
		}

		// Token: 0x060161A4 RID: 90532 RVA: 0x0032BDA2 File Offset: 0x00329FA2
		public static TVarValueUnion FromQuestStateValue(QuestStateValueT _queststatevalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.QuestStateValue,
				Value = _queststatevalue
			};
		}

		// Token: 0x060161A5 RID: 90533 RVA: 0x0032BDB7 File Offset: 0x00329FB7
		public EntityValueT AsEntityValue()
		{
			return this.As<EntityValueT>();
		}

		// Token: 0x060161A6 RID: 90534 RVA: 0x0032BDBF File Offset: 0x00329FBF
		public static TVarValueUnion FromEntityValue(EntityValueT _entityvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.EntityValue,
				Value = _entityvalue
			};
		}

		// Token: 0x060161A7 RID: 90535 RVA: 0x0032BDD4 File Offset: 0x00329FD4
		public QuestValueT AsQuestValue()
		{
			return this.As<QuestValueT>();
		}

		// Token: 0x060161A8 RID: 90536 RVA: 0x0032BDDC File Offset: 0x00329FDC
		public static TVarValueUnion FromQuestValue(QuestValueT _questvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.QuestValue,
				Value = _questvalue
			};
		}

		// Token: 0x060161A9 RID: 90537 RVA: 0x0032BDF1 File Offset: 0x00329FF1
		public PrefabValueT AsPrefabValue()
		{
			return this.As<PrefabValueT>();
		}

		// Token: 0x060161AA RID: 90538 RVA: 0x0032BDF9 File Offset: 0x00329FF9
		public static TVarValueUnion FromPrefabValue(PrefabValueT _prefabvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.PrefabValue,
				Value = _prefabvalue
			};
		}

		// Token: 0x060161AB RID: 90539 RVA: 0x0032BE0E File Offset: 0x0032A00E
		public TransformValueT AsTransformValue()
		{
			return this.As<TransformValueT>();
		}

		// Token: 0x060161AC RID: 90540 RVA: 0x0032BE16 File Offset: 0x0032A016
		public static TVarValueUnion FromTransformValue(TransformValueT _transformvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.TransformValue,
				Value = _transformvalue
			};
		}

		// Token: 0x060161AD RID: 90541 RVA: 0x0032BE2C File Offset: 0x0032A02C
		public static int Pack(FlatBufferBuilder builder, TVarValueUnion _o)
		{
			switch (_o.Type)
			{
			case TVarValue.BooleanValue:
				return BooleanValue.Pack(builder, _o.AsBooleanValue()).Value;
			case TVarValue.IntValue:
				return IntValue.Pack(builder, _o.AsIntValue()).Value;
			case TVarValue.FloatValue:
				return FloatValue.Pack(builder, _o.AsFloatValue()).Value;
			case TVarValue.StringValue:
				return StringValue.Pack(builder, _o.AsStringValue()).Value;
			case TVarValue.QuestStateValue:
				return QuestStateValue.Pack(builder, _o.AsQuestStateValue()).Value;
			case TVarValue.EntityValue:
				return EntityValue.Pack(builder, _o.AsEntityValue()).Value;
			case TVarValue.QuestValue:
				return QuestValue.Pack(builder, _o.AsQuestValue()).Value;
			case TVarValue.PrefabValue:
				return PrefabValue.Pack(builder, _o.AsPrefabValue()).Value;
			case TVarValue.TransformValue:
				return TransformValue.Pack(builder, _o.AsTransformValue()).Value;
			default:
				return 0;
			}
		}
	}
}
