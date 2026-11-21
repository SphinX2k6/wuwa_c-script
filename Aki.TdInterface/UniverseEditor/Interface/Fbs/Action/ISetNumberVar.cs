using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007812 RID: 30738
	public struct ISetNumberVar : IFlatbufferObject
	{
		// Token: 0x1700E15D RID: 57693
		// (get) Token: 0x0603604F RID: 221263 RVA: 0x0073C5CA File Offset: 0x0073A7CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036050 RID: 221264 RVA: 0x0073C5D7 File Offset: 0x0073A7D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036051 RID: 221265 RVA: 0x0073C5E0 File Offset: 0x0073A7E0
		public static ISetNumberVar GetRootAsISetNumberVar(ByteBuffer _bb)
		{
			return ISetNumberVar.GetRootAsISetNumberVar(_bb, default(ISetNumberVar));
		}

		// Token: 0x06036052 RID: 221266 RVA: 0x0073C5FC File Offset: 0x0073A7FC
		public static ISetNumberVar GetRootAsISetNumberVar(ByteBuffer _bb, ISetNumberVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036053 RID: 221267 RVA: 0x0073C619 File Offset: 0x0073A819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036054 RID: 221268 RVA: 0x0073C628 File Offset: 0x0073A828
		public ISetNumberVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E15E RID: 57694
		// (get) Token: 0x06036055 RID: 221269 RVA: 0x0073C638 File Offset: 0x0073A838
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

		// Token: 0x06036056 RID: 221270 RVA: 0x0073C66F File Offset: 0x0073A86F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036057 RID: 221271 RVA: 0x0073C67E File Offset: 0x0073A87E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E15F RID: 57695
		// (get) Token: 0x06036058 RID: 221272 RVA: 0x0073C68C File Offset: 0x0073A88C
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

		// Token: 0x06036059 RID: 221273 RVA: 0x0073C6C8 File Offset: 0x0073A8C8
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603605A RID: 221274 RVA: 0x0073C70C File Offset: 0x0073A90C
		public BooleanValue ValueAsBooleanValue()
		{
			return this.Value<BooleanValue>().Value;
		}

		// Token: 0x0603605B RID: 221275 RVA: 0x0073C728 File Offset: 0x0073A928
		public IntValue ValueAsIntValue()
		{
			return this.Value<IntValue>().Value;
		}

		// Token: 0x0603605C RID: 221276 RVA: 0x0073C744 File Offset: 0x0073A944
		public FloatValue ValueAsFloatValue()
		{
			return this.Value<FloatValue>().Value;
		}

		// Token: 0x0603605D RID: 221277 RVA: 0x0073C760 File Offset: 0x0073A960
		public StringValue ValueAsStringValue()
		{
			return this.Value<StringValue>().Value;
		}

		// Token: 0x0603605E RID: 221278 RVA: 0x0073C77C File Offset: 0x0073A97C
		public QuestStateValue ValueAsQuestStateValue()
		{
			return this.Value<QuestStateValue>().Value;
		}

		// Token: 0x0603605F RID: 221279 RVA: 0x0073C798 File Offset: 0x0073A998
		public EntityValue ValueAsEntityValue()
		{
			return this.Value<EntityValue>().Value;
		}

		// Token: 0x06036060 RID: 221280 RVA: 0x0073C7B4 File Offset: 0x0073A9B4
		public QuestValue ValueAsQuestValue()
		{
			return this.Value<QuestValue>().Value;
		}

		// Token: 0x06036061 RID: 221281 RVA: 0x0073C7D0 File Offset: 0x0073A9D0
		public PrefabValue ValueAsPrefabValue()
		{
			return this.Value<PrefabValue>().Value;
		}

		// Token: 0x06036062 RID: 221282 RVA: 0x0073C7EC File Offset: 0x0073A9EC
		public TransformValue ValueAsTransformValue()
		{
			return this.Value<TransformValue>().Value;
		}

		// Token: 0x06036063 RID: 221283 RVA: 0x0073C807 File Offset: 0x0073AA07
		public static Offset<ISetNumberVar> CreateISetNumberVar(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), TVarValue Value_type = TVarValue.NONE, int ValueOffset = 0)
		{
			builder.StartTable(3);
			ISetNumberVar.AddValue(builder, ValueOffset);
			ISetNumberVar.AddName(builder, NameOffset);
			ISetNumberVar.AddValueType(builder, Value_type);
			return ISetNumberVar.EndISetNumberVar(builder);
		}

		// Token: 0x06036064 RID: 221284 RVA: 0x0073C82B File Offset: 0x0073AA2B
		public static void StartISetNumberVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036065 RID: 221285 RVA: 0x0073C834 File Offset: 0x0073AA34
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06036066 RID: 221286 RVA: 0x0073C844 File Offset: 0x0073AA44
		public static void AddValueType(FlatBufferBuilder builder, TVarValue valueType)
		{
			builder.AddByte(1, (byte)valueType, 0);
		}

		// Token: 0x06036067 RID: 221287 RVA: 0x0073C84F File Offset: 0x0073AA4F
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(2, valueOffset, 0);
		}

		// Token: 0x06036068 RID: 221288 RVA: 0x0073C85A File Offset: 0x0073AA5A
		public static Offset<ISetNumberVar> EndISetNumberVar(FlatBufferBuilder builder)
		{
			return new Offset<ISetNumberVar>(builder.EndTable());
		}

		// Token: 0x06036069 RID: 221289 RVA: 0x0073C868 File Offset: 0x0073AA68
		public ISetNumberVarT UnPack()
		{
			ISetNumberVarT setNumberVarT = new ISetNumberVarT();
			this.UnPackTo(setNumberVarT);
			return setNumberVarT;
		}

		// Token: 0x0603606A RID: 221290 RVA: 0x0073C884 File Offset: 0x0073AA84
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

		// Token: 0x0603606B RID: 221291 RVA: 0x0073CAE0 File Offset: 0x0073ACE0
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

		// Token: 0x04012A75 RID: 76405
		private Table __p;
	}
}
