using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B66 RID: 15206
	public class TVarValueUnion
	{
		// Token: 0x1700682E RID: 26670
		// (get) Token: 0x06014CCB RID: 85195 RVA: 0x00305744 File Offset: 0x00303944
		// (set) Token: 0x06014CCC RID: 85196 RVA: 0x0030574C File Offset: 0x0030394C
		public TVarValue Type { get; set; }

		// Token: 0x1700682F RID: 26671
		// (get) Token: 0x06014CCD RID: 85197 RVA: 0x00305755 File Offset: 0x00303955
		// (set) Token: 0x06014CCE RID: 85198 RVA: 0x0030575D File Offset: 0x0030395D
		public object Value { get; set; }

		// Token: 0x06014CCF RID: 85199 RVA: 0x00305766 File Offset: 0x00303966
		public TVarValueUnion()
		{
			this.Type = TVarValue.NONE;
			this.Value = null;
		}

		// Token: 0x06014CD0 RID: 85200 RVA: 0x0030577C File Offset: 0x0030397C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014CD1 RID: 85201 RVA: 0x0030578E File Offset: 0x0030398E
		public BooleanValueT AsBooleanValue()
		{
			return this.As<BooleanValueT>();
		}

		// Token: 0x06014CD2 RID: 85202 RVA: 0x00305796 File Offset: 0x00303996
		public static TVarValueUnion FromBooleanValue(BooleanValueT _booleanvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.BooleanValue,
				Value = _booleanvalue
			};
		}

		// Token: 0x06014CD3 RID: 85203 RVA: 0x003057AB File Offset: 0x003039AB
		public IntValueT AsIntValue()
		{
			return this.As<IntValueT>();
		}

		// Token: 0x06014CD4 RID: 85204 RVA: 0x003057B3 File Offset: 0x003039B3
		public static TVarValueUnion FromIntValue(IntValueT _intvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.IntValue,
				Value = _intvalue
			};
		}

		// Token: 0x06014CD5 RID: 85205 RVA: 0x003057C8 File Offset: 0x003039C8
		public FloatValueT AsFloatValue()
		{
			return this.As<FloatValueT>();
		}

		// Token: 0x06014CD6 RID: 85206 RVA: 0x003057D0 File Offset: 0x003039D0
		public static TVarValueUnion FromFloatValue(FloatValueT _floatvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.FloatValue,
				Value = _floatvalue
			};
		}

		// Token: 0x06014CD7 RID: 85207 RVA: 0x003057E5 File Offset: 0x003039E5
		public StringValueT AsStringValue()
		{
			return this.As<StringValueT>();
		}

		// Token: 0x06014CD8 RID: 85208 RVA: 0x003057ED File Offset: 0x003039ED
		public static TVarValueUnion FromStringValue(StringValueT _stringvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.StringValue,
				Value = _stringvalue
			};
		}

		// Token: 0x06014CD9 RID: 85209 RVA: 0x00305802 File Offset: 0x00303A02
		public QuestStateValueT AsQuestStateValue()
		{
			return this.As<QuestStateValueT>();
		}

		// Token: 0x06014CDA RID: 85210 RVA: 0x0030580A File Offset: 0x00303A0A
		public static TVarValueUnion FromQuestStateValue(QuestStateValueT _queststatevalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.QuestStateValue,
				Value = _queststatevalue
			};
		}

		// Token: 0x06014CDB RID: 85211 RVA: 0x0030581F File Offset: 0x00303A1F
		public EntityValueT AsEntityValue()
		{
			return this.As<EntityValueT>();
		}

		// Token: 0x06014CDC RID: 85212 RVA: 0x00305827 File Offset: 0x00303A27
		public static TVarValueUnion FromEntityValue(EntityValueT _entityvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.EntityValue,
				Value = _entityvalue
			};
		}

		// Token: 0x06014CDD RID: 85213 RVA: 0x0030583C File Offset: 0x00303A3C
		public QuestValueT AsQuestValue()
		{
			return this.As<QuestValueT>();
		}

		// Token: 0x06014CDE RID: 85214 RVA: 0x00305844 File Offset: 0x00303A44
		public static TVarValueUnion FromQuestValue(QuestValueT _questvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.QuestValue,
				Value = _questvalue
			};
		}

		// Token: 0x06014CDF RID: 85215 RVA: 0x00305859 File Offset: 0x00303A59
		public PrefabValueT AsPrefabValue()
		{
			return this.As<PrefabValueT>();
		}

		// Token: 0x06014CE0 RID: 85216 RVA: 0x00305861 File Offset: 0x00303A61
		public static TVarValueUnion FromPrefabValue(PrefabValueT _prefabvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.PrefabValue,
				Value = _prefabvalue
			};
		}

		// Token: 0x06014CE1 RID: 85217 RVA: 0x00305876 File Offset: 0x00303A76
		public TransformValueT AsTransformValue()
		{
			return this.As<TransformValueT>();
		}

		// Token: 0x06014CE2 RID: 85218 RVA: 0x0030587E File Offset: 0x00303A7E
		public static TVarValueUnion FromTransformValue(TransformValueT _transformvalue)
		{
			return new TVarValueUnion
			{
				Type = TVarValue.TransformValue,
				Value = _transformvalue
			};
		}

		// Token: 0x06014CE3 RID: 85219 RVA: 0x00305894 File Offset: 0x00303A94
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
