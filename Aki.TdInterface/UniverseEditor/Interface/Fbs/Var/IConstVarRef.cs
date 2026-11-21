using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E6B RID: 15979
	public struct IConstVarRef : IFlatbufferObject
	{
		// Token: 0x17006BE2 RID: 27618
		// (get) Token: 0x0601587B RID: 88187 RVA: 0x0031AA35 File Offset: 0x00318C35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601587C RID: 88188 RVA: 0x0031AA42 File Offset: 0x00318C42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601587D RID: 88189 RVA: 0x0031AA4C File Offset: 0x00318C4C
		public static IConstVarRef GetRootAsIConstVarRef(ByteBuffer _bb)
		{
			return IConstVarRef.GetRootAsIConstVarRef(_bb, default(IConstVarRef));
		}

		// Token: 0x0601587E RID: 88190 RVA: 0x0031AA68 File Offset: 0x00318C68
		public static IConstVarRef GetRootAsIConstVarRef(ByteBuffer _bb, IConstVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601587F RID: 88191 RVA: 0x0031AA85 File Offset: 0x00318C85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015880 RID: 88192 RVA: 0x0031AA94 File Offset: 0x00318C94
		public IConstVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BE3 RID: 27619
		// (get) Token: 0x06015881 RID: 88193 RVA: 0x0031AAA4 File Offset: 0x00318CA4
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BE4 RID: 27620
		// (get) Token: 0x06015882 RID: 88194 RVA: 0x0031AAE0 File Offset: 0x00318CE0
		public EVarRefSource Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVarRefSource.Constant;
				}
				return (EVarRefSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BE5 RID: 27621
		// (get) Token: 0x06015883 RID: 88195 RVA: 0x0031AB1C File Offset: 0x00318D1C
		public TVarValue ValueType
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

		// Token: 0x06015884 RID: 88196 RVA: 0x0031AB58 File Offset: 0x00318D58
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015885 RID: 88197 RVA: 0x0031ABA0 File Offset: 0x00318DA0
		public BooleanValue ValueAsBooleanValue()
		{
			return this.Value<BooleanValue>().Value;
		}

		// Token: 0x06015886 RID: 88198 RVA: 0x0031ABBC File Offset: 0x00318DBC
		public IntValue ValueAsIntValue()
		{
			return this.Value<IntValue>().Value;
		}

		// Token: 0x06015887 RID: 88199 RVA: 0x0031ABD8 File Offset: 0x00318DD8
		public FloatValue ValueAsFloatValue()
		{
			return this.Value<FloatValue>().Value;
		}

		// Token: 0x06015888 RID: 88200 RVA: 0x0031ABF4 File Offset: 0x00318DF4
		public StringValue ValueAsStringValue()
		{
			return this.Value<StringValue>().Value;
		}

		// Token: 0x06015889 RID: 88201 RVA: 0x0031AC10 File Offset: 0x00318E10
		public QuestStateValue ValueAsQuestStateValue()
		{
			return this.Value<QuestStateValue>().Value;
		}

		// Token: 0x0601588A RID: 88202 RVA: 0x0031AC2C File Offset: 0x00318E2C
		public EntityValue ValueAsEntityValue()
		{
			return this.Value<EntityValue>().Value;
		}

		// Token: 0x0601588B RID: 88203 RVA: 0x0031AC48 File Offset: 0x00318E48
		public QuestValue ValueAsQuestValue()
		{
			return this.Value<QuestValue>().Value;
		}

		// Token: 0x0601588C RID: 88204 RVA: 0x0031AC64 File Offset: 0x00318E64
		public PrefabValue ValueAsPrefabValue()
		{
			return this.Value<PrefabValue>().Value;
		}

		// Token: 0x0601588D RID: 88205 RVA: 0x0031AC80 File Offset: 0x00318E80
		public TransformValue ValueAsTransformValue()
		{
			return this.Value<TransformValue>().Value;
		}

		// Token: 0x0601588E RID: 88206 RVA: 0x0031AC9B File Offset: 0x00318E9B
		public static Offset<IConstVarRef> CreateIConstVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, TVarValue Value_type = TVarValue.NONE, int ValueOffset = 0)
		{
			builder.StartTable(4);
			IConstVarRef.AddValue(builder, ValueOffset);
			IConstVarRef.AddValueType(builder, Value_type);
			IConstVarRef.AddSource(builder, Source);
			IConstVarRef.AddType(builder, Type);
			return IConstVarRef.EndIConstVarRef(builder);
		}

		// Token: 0x0601588F RID: 88207 RVA: 0x0031ACC7 File Offset: 0x00318EC7
		public static void StartIConstVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015890 RID: 88208 RVA: 0x0031ACD0 File Offset: 0x00318ED0
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015891 RID: 88209 RVA: 0x0031ACDB File Offset: 0x00318EDB
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x06015892 RID: 88210 RVA: 0x0031ACE6 File Offset: 0x00318EE6
		public static void AddValueType(FlatBufferBuilder builder, TVarValue valueType)
		{
			builder.AddByte(2, (byte)valueType, 0);
		}

		// Token: 0x06015893 RID: 88211 RVA: 0x0031ACF1 File Offset: 0x00318EF1
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(3, valueOffset, 0);
		}

		// Token: 0x06015894 RID: 88212 RVA: 0x0031ACFC File Offset: 0x00318EFC
		public static Offset<IConstVarRef> EndIConstVarRef(FlatBufferBuilder builder)
		{
			return new Offset<IConstVarRef>(builder.EndTable());
		}

		// Token: 0x06015895 RID: 88213 RVA: 0x0031AD0C File Offset: 0x00318F0C
		public IConstVarRefT UnPack()
		{
			IConstVarRefT constVarRefT = new IConstVarRefT();
			this.UnPackTo(constVarRefT);
			return constVarRefT;
		}

		// Token: 0x06015896 RID: 88214 RVA: 0x0031AD28 File Offset: 0x00318F28
		public void UnPackTo(IConstVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.Value = new TVarValueUnion();
			_o.Value.Type = this.ValueType;
			switch (this.ValueType)
			{
			case TVarValue.BooleanValue:
				_o.Value.Value = ((this.Value<BooleanValue>() != null) ? this.Value<BooleanValue>().Value.UnPack() : null);
				return;
			case TVarValue.IntValue:
				_o.Value.Value = ((this.Value<IntValue>() != null) ? this.Value<IntValue>().Value.UnPack() : null);
				return;
			case TVarValue.FloatValue:
				_o.Value.Value = ((this.Value<FloatValue>() != null) ? this.Value<FloatValue>().Value.UnPack() : null);
				return;
			case TVarValue.StringValue:
				_o.Value.Value = ((this.Value<StringValue>() != null) ? this.Value<StringValue>().Value.UnPack() : null);
				return;
			case TVarValue.QuestStateValue:
				_o.Value.Value = ((this.Value<QuestStateValue>() != null) ? this.Value<QuestStateValue>().Value.UnPack() : null);
				return;
			case TVarValue.EntityValue:
				_o.Value.Value = ((this.Value<EntityValue>() != null) ? this.Value<EntityValue>().Value.UnPack() : null);
				return;
			case TVarValue.QuestValue:
				_o.Value.Value = ((this.Value<QuestValue>() != null) ? this.Value<QuestValue>().Value.UnPack() : null);
				return;
			case TVarValue.PrefabValue:
				_o.Value.Value = ((this.Value<PrefabValue>() != null) ? this.Value<PrefabValue>().Value.UnPack() : null);
				return;
			case TVarValue.TransformValue:
				_o.Value.Value = ((this.Value<TransformValue>() != null) ? this.Value<TransformValue>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06015897 RID: 88215 RVA: 0x0031AF90 File Offset: 0x00319190
		public static Offset<IConstVarRef> Pack(FlatBufferBuilder builder, IConstVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstVarRef>);
			}
			TVarValue value_type = (_o.Value == null) ? TVarValue.NONE : _o.Value.Type;
			int valueOffset = (_o.Value == null) ? 0 : TVarValueUnion.Pack(builder, _o.Value);
			return IConstVarRef.CreateIConstVarRef(builder, _o.Type, _o.Source, value_type, valueOffset);
		}

		// Token: 0x0400B830 RID: 47152
		private Table __p;
	}
}
