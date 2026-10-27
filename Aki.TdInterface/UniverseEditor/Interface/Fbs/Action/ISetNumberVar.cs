using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007046 RID: 28742
	public struct ISetNumberVar : IFlatbufferObject
	{
		// Token: 0x1700D57C RID: 54652
		// (get) Token: 0x06032DB2 RID: 208306 RVA: 0x006DC0A2 File Offset: 0x006DA2A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032DB3 RID: 208307 RVA: 0x006DC0AF File Offset: 0x006DA2AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032DB4 RID: 208308 RVA: 0x006DC0B8 File Offset: 0x006DA2B8
		public static ISetNumberVar GetRootAsISetNumberVar(ByteBuffer _bb)
		{
			return ISetNumberVar.GetRootAsISetNumberVar(_bb, default(ISetNumberVar));
		}

		// Token: 0x06032DB5 RID: 208309 RVA: 0x006DC0D4 File Offset: 0x006DA2D4
		public static ISetNumberVar GetRootAsISetNumberVar(ByteBuffer _bb, ISetNumberVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032DB6 RID: 208310 RVA: 0x006DC0F1 File Offset: 0x006DA2F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032DB7 RID: 208311 RVA: 0x006DC100 File Offset: 0x006DA300
		public ISetNumberVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D57D RID: 54653
		// (get) Token: 0x06032DB8 RID: 208312 RVA: 0x006DC110 File Offset: 0x006DA310
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032DB9 RID: 208313 RVA: 0x006DC147 File Offset: 0x006DA347
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06032DBA RID: 208314 RVA: 0x006DC156 File Offset: 0x006DA356
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D57E RID: 54654
		// (get) Token: 0x06032DBB RID: 208315 RVA: 0x006DC164 File Offset: 0x006DA364
		public TVarValue ValueType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarValue.NONE;
				}
				return (TVarValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032DBC RID: 208316 RVA: 0x006DC1A0 File Offset: 0x006DA3A0
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032DBD RID: 208317 RVA: 0x006DC1E4 File Offset: 0x006DA3E4
		public BooleanValue ValueAsBooleanValue()
		{
			return this.Value<BooleanValue>().Value;
		}

		// Token: 0x06032DBE RID: 208318 RVA: 0x006DC200 File Offset: 0x006DA400
		public IntValue ValueAsIntValue()
		{
			return this.Value<IntValue>().Value;
		}

		// Token: 0x06032DBF RID: 208319 RVA: 0x006DC21C File Offset: 0x006DA41C
		public FloatValue ValueAsFloatValue()
		{
			return this.Value<FloatValue>().Value;
		}

		// Token: 0x06032DC0 RID: 208320 RVA: 0x006DC238 File Offset: 0x006DA438
		public StringValue ValueAsStringValue()
		{
			return this.Value<StringValue>().Value;
		}

		// Token: 0x06032DC1 RID: 208321 RVA: 0x006DC254 File Offset: 0x006DA454
		public QuestStateValue ValueAsQuestStateValue()
		{
			return this.Value<QuestStateValue>().Value;
		}

		// Token: 0x06032DC2 RID: 208322 RVA: 0x006DC270 File Offset: 0x006DA470
		public EntityValue ValueAsEntityValue()
		{
			return this.Value<EntityValue>().Value;
		}

		// Token: 0x06032DC3 RID: 208323 RVA: 0x006DC28C File Offset: 0x006DA48C
		public QuestValue ValueAsQuestValue()
		{
			return this.Value<QuestValue>().Value;
		}

		// Token: 0x06032DC4 RID: 208324 RVA: 0x006DC2A8 File Offset: 0x006DA4A8
		public PrefabValue ValueAsPrefabValue()
		{
			return this.Value<PrefabValue>().Value;
		}

		// Token: 0x06032DC5 RID: 208325 RVA: 0x006DC2C4 File Offset: 0x006DA4C4
		public TransformValue ValueAsTransformValue()
		{
			return this.Value<TransformValue>().Value;
		}

		// Token: 0x06032DC6 RID: 208326 RVA: 0x006DC2DF File Offset: 0x006DA4DF
		public static Offset<ISetNumberVar> CreateISetNumberVar(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), TVarValue Value_type = TVarValue.NONE, int ValueOffset = 0)
		{
			builder.StartTable(3);
			ISetNumberVar.AddValue(builder, ValueOffset);
			ISetNumberVar.AddName(builder, NameOffset);
			ISetNumberVar.AddValueType(builder, Value_type);
			return ISetNumberVar.EndISetNumberVar(builder);
		}

		// Token: 0x06032DC7 RID: 208327 RVA: 0x006DC303 File Offset: 0x006DA503
		public static void StartISetNumberVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032DC8 RID: 208328 RVA: 0x006DC30C File Offset: 0x006DA50C
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06032DC9 RID: 208329 RVA: 0x006DC31C File Offset: 0x006DA51C
		public static void AddValueType(FlatBufferBuilder builder, TVarValue valueType)
		{
			builder.AddByte(1, (byte)valueType, 0);
		}

		// Token: 0x06032DCA RID: 208330 RVA: 0x006DC327 File Offset: 0x006DA527
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(2, valueOffset, 0);
		}

		// Token: 0x06032DCB RID: 208331 RVA: 0x006DC332 File Offset: 0x006DA532
		public static Offset<ISetNumberVar> EndISetNumberVar(FlatBufferBuilder builder)
		{
			return new Offset<ISetNumberVar>(builder.EndTable());
		}

		// Token: 0x06032DCC RID: 208332 RVA: 0x006DC340 File Offset: 0x006DA540
		public ISetNumberVarT UnPack()
		{
			ISetNumberVarT setNumberVarT = new ISetNumberVarT();
			this.UnPackTo(setNumberVarT);
			return setNumberVarT;
		}

		// Token: 0x06032DCD RID: 208333 RVA: 0x006DC35C File Offset: 0x006DA55C
		public void UnPackTo(ISetNumberVarT _o)
		{
			_o.Name = this.Name;
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

		// Token: 0x06032DCE RID: 208334 RVA: 0x006DC5B8 File Offset: 0x006DA7B8
		public static Offset<ISetNumberVar> Pack(FlatBufferBuilder builder, ISetNumberVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNumberVar>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			TVarValue value_type = (_o.Value == null) ? TVarValue.NONE : _o.Value.Type;
			int valueOffset = (_o.Value == null) ? 0 : TVarValueUnion.Pack(builder, _o.Value);
			return ISetNumberVar.CreateISetNumberVar(builder, nameOffset, value_type, valueOffset);
		}

		// Token: 0x04011A88 RID: 72328
		private Table __p;
	}
}
