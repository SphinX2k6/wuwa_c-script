using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F01 RID: 16129
	public struct IVarDefine : IFlatbufferObject
	{
		// Token: 0x17006D27 RID: 27943
		// (get) Token: 0x06015DFD RID: 89597 RVA: 0x003252B9 File Offset: 0x003234B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015DFE RID: 89598 RVA: 0x003252C6 File Offset: 0x003234C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015DFF RID: 89599 RVA: 0x003252D0 File Offset: 0x003234D0
		public static IVarDefine GetRootAsIVarDefine(ByteBuffer _bb)
		{
			return IVarDefine.GetRootAsIVarDefine(_bb, default(IVarDefine));
		}

		// Token: 0x06015E00 RID: 89600 RVA: 0x003252EC File Offset: 0x003234EC
		public static IVarDefine GetRootAsIVarDefine(ByteBuffer _bb, IVarDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E01 RID: 89601 RVA: 0x00325309 File Offset: 0x00323509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E02 RID: 89602 RVA: 0x00325318 File Offset: 0x00323518
		public IVarDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D28 RID: 27944
		// (get) Token: 0x06015E03 RID: 89603 RVA: 0x00325328 File Offset: 0x00323528
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

		// Token: 0x06015E04 RID: 89604 RVA: 0x0032535F File Offset: 0x0032355F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06015E05 RID: 89605 RVA: 0x0032536E File Offset: 0x0032356E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006D29 RID: 27945
		// (get) Token: 0x06015E06 RID: 89606 RVA: 0x0032537C File Offset: 0x0032357C
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D2A RID: 27946
		// (get) Token: 0x06015E07 RID: 89607 RVA: 0x003253B8 File Offset: 0x003235B8
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

		// Token: 0x06015E08 RID: 89608 RVA: 0x003253F4 File Offset: 0x003235F4
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015E09 RID: 89609 RVA: 0x0032543C File Offset: 0x0032363C
		public BooleanValue ValueAsBooleanValue()
		{
			return this.Value<BooleanValue>().Value;
		}

		// Token: 0x06015E0A RID: 89610 RVA: 0x00325458 File Offset: 0x00323658
		public IntValue ValueAsIntValue()
		{
			return this.Value<IntValue>().Value;
		}

		// Token: 0x06015E0B RID: 89611 RVA: 0x00325474 File Offset: 0x00323674
		public FloatValue ValueAsFloatValue()
		{
			return this.Value<FloatValue>().Value;
		}

		// Token: 0x06015E0C RID: 89612 RVA: 0x00325490 File Offset: 0x00323690
		public StringValue ValueAsStringValue()
		{
			return this.Value<StringValue>().Value;
		}

		// Token: 0x06015E0D RID: 89613 RVA: 0x003254AC File Offset: 0x003236AC
		public QuestStateValue ValueAsQuestStateValue()
		{
			return this.Value<QuestStateValue>().Value;
		}

		// Token: 0x06015E0E RID: 89614 RVA: 0x003254C8 File Offset: 0x003236C8
		public EntityValue ValueAsEntityValue()
		{
			return this.Value<EntityValue>().Value;
		}

		// Token: 0x06015E0F RID: 89615 RVA: 0x003254E4 File Offset: 0x003236E4
		public QuestValue ValueAsQuestValue()
		{
			return this.Value<QuestValue>().Value;
		}

		// Token: 0x06015E10 RID: 89616 RVA: 0x00325500 File Offset: 0x00323700
		public PrefabValue ValueAsPrefabValue()
		{
			return this.Value<PrefabValue>().Value;
		}

		// Token: 0x06015E11 RID: 89617 RVA: 0x0032551C File Offset: 0x0032371C
		public TransformValue ValueAsTransformValue()
		{
			return this.Value<TransformValue>().Value;
		}

		// Token: 0x17006D2B RID: 27947
		// (get) Token: 0x06015E12 RID: 89618 RVA: 0x00325538 File Offset: 0x00323738
		public EVarAccess Access
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EVarAccess.Private;
				}
				return (EVarAccess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D2C RID: 27948
		// (get) Token: 0x06015E13 RID: 89619 RVA: 0x00325578 File Offset: 0x00323778
		public bool IsIgnoreOnRollBack
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006D2D RID: 27949
		// (get) Token: 0x06015E14 RID: 89620 RVA: 0x003255B8 File Offset: 0x003237B8
		public bool IsClient
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006D2E RID: 27950
		// (get) Token: 0x06015E15 RID: 89621 RVA: 0x003255F8 File Offset: 0x003237F8
		public TVarValidateConfig ValidateConfigType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return TVarValidateConfig.NONE;
				}
				return (TVarValidateConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015E16 RID: 89622 RVA: 0x00325638 File Offset: 0x00323838
		public TTable? ValidateConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015E17 RID: 89623 RVA: 0x00325680 File Offset: 0x00323880
		public IVarBooleanValidateConfig ValidateConfigAsIVarBooleanValidateConfig()
		{
			return this.ValidateConfig<IVarBooleanValidateConfig>().Value;
		}

		// Token: 0x06015E18 RID: 89624 RVA: 0x0032569C File Offset: 0x0032389C
		public IVarEntityValidateConfig ValidateConfigAsIVarEntityValidateConfig()
		{
			return this.ValidateConfig<IVarEntityValidateConfig>().Value;
		}

		// Token: 0x06015E19 RID: 89625 RVA: 0x003256B8 File Offset: 0x003238B8
		public IVarFloatValidateConfig ValidateConfigAsIVarFloatValidateConfig()
		{
			return this.ValidateConfig<IVarFloatValidateConfig>().Value;
		}

		// Token: 0x06015E1A RID: 89626 RVA: 0x003256D4 File Offset: 0x003238D4
		public IVarIntValidateConfig ValidateConfigAsIVarIntValidateConfig()
		{
			return this.ValidateConfig<IVarIntValidateConfig>().Value;
		}

		// Token: 0x06015E1B RID: 89627 RVA: 0x003256F0 File Offset: 0x003238F0
		public IVarPrefabValidateConfig ValidateConfigAsIVarPrefabValidateConfig()
		{
			return this.ValidateConfig<IVarPrefabValidateConfig>().Value;
		}

		// Token: 0x06015E1C RID: 89628 RVA: 0x0032570C File Offset: 0x0032390C
		public IVarQuestStateValidateConfig ValidateConfigAsIVarQuestStateValidateConfig()
		{
			return this.ValidateConfig<IVarQuestStateValidateConfig>().Value;
		}

		// Token: 0x06015E1D RID: 89629 RVA: 0x00325728 File Offset: 0x00323928
		public IVarQuestValidateConfig ValidateConfigAsIVarQuestValidateConfig()
		{
			return this.ValidateConfig<IVarQuestValidateConfig>().Value;
		}

		// Token: 0x06015E1E RID: 89630 RVA: 0x00325744 File Offset: 0x00323944
		public IVarStringValidateConfig ValidateConfigAsIVarStringValidateConfig()
		{
			return this.ValidateConfig<IVarStringValidateConfig>().Value;
		}

		// Token: 0x06015E1F RID: 89631 RVA: 0x00325760 File Offset: 0x00323960
		public IVarTransformValidateConfig ValidateConfigAsIVarTransformValidateConfig()
		{
			return this.ValidateConfig<IVarTransformValidateConfig>().Value;
		}

		// Token: 0x17006D2F RID: 27951
		// (get) Token: 0x06015E20 RID: 89632 RVA: 0x0032577C File Offset: 0x0032397C
		public bool IsClientEditable
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006D30 RID: 27952
		// (get) Token: 0x06015E21 RID: 89633 RVA: 0x003257BC File Offset: 0x003239BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015E22 RID: 89634 RVA: 0x003257FC File Offset: 0x003239FC
		public static Offset<IVarDefine> CreateIVarDefine(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), EVar Type = EVar.Boolean, TVarValue Value_type = TVarValue.NONE, int ValueOffset = 0, EVarAccess Access = EVarAccess.Private, bool IsIgnoreOnRollBack = false, bool IsClient = false, TVarValidateConfig ValidateConfig_type = TVarValidateConfig.NONE, int ValidateConfigOffset = 0, bool IsClientEditable = false, byte NullMask = 0)
		{
			builder.StartTable(11);
			IVarDefine.AddValidateConfig(builder, ValidateConfigOffset);
			IVarDefine.AddValue(builder, ValueOffset);
			IVarDefine.AddName(builder, NameOffset);
			IVarDefine.AddNullMask(builder, NullMask);
			IVarDefine.AddIsClientEditable(builder, IsClientEditable);
			IVarDefine.AddValidateConfigType(builder, ValidateConfig_type);
			IVarDefine.AddIsClient(builder, IsClient);
			IVarDefine.AddIsIgnoreOnRollBack(builder, IsIgnoreOnRollBack);
			IVarDefine.AddAccess(builder, Access);
			IVarDefine.AddValueType(builder, Value_type);
			IVarDefine.AddType(builder, Type);
			return IVarDefine.EndIVarDefine(builder);
		}

		// Token: 0x06015E23 RID: 89635 RVA: 0x0032586C File Offset: 0x00323A6C
		public static void StartIVarDefine(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06015E24 RID: 89636 RVA: 0x00325876 File Offset: 0x00323A76
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06015E25 RID: 89637 RVA: 0x00325886 File Offset: 0x00323A86
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x06015E26 RID: 89638 RVA: 0x00325891 File Offset: 0x00323A91
		public static void AddValueType(FlatBufferBuilder builder, TVarValue valueType)
		{
			builder.AddByte(2, (byte)valueType, 0);
		}

		// Token: 0x06015E27 RID: 89639 RVA: 0x0032589C File Offset: 0x00323A9C
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(3, valueOffset, 0);
		}

		// Token: 0x06015E28 RID: 89640 RVA: 0x003258A7 File Offset: 0x00323AA7
		public static void AddAccess(FlatBufferBuilder builder, EVarAccess access)
		{
			builder.AddByte(4, (byte)access, 0);
		}

		// Token: 0x06015E29 RID: 89641 RVA: 0x003258B2 File Offset: 0x00323AB2
		public static void AddIsIgnoreOnRollBack(FlatBufferBuilder builder, bool isIgnoreOnRollBack)
		{
			builder.AddBool(5, isIgnoreOnRollBack, false);
		}

		// Token: 0x06015E2A RID: 89642 RVA: 0x003258BD File Offset: 0x00323ABD
		public static void AddIsClient(FlatBufferBuilder builder, bool isClient)
		{
			builder.AddBool(6, isClient, false);
		}

		// Token: 0x06015E2B RID: 89643 RVA: 0x003258C8 File Offset: 0x00323AC8
		public static void AddValidateConfigType(FlatBufferBuilder builder, TVarValidateConfig validateConfigType)
		{
			builder.AddByte(7, (byte)validateConfigType, 0);
		}

		// Token: 0x06015E2C RID: 89644 RVA: 0x003258D3 File Offset: 0x00323AD3
		public static void AddValidateConfig(FlatBufferBuilder builder, int validateConfigOffset)
		{
			builder.AddOffset(8, validateConfigOffset, 0);
		}

		// Token: 0x06015E2D RID: 89645 RVA: 0x003258DE File Offset: 0x00323ADE
		public static void AddIsClientEditable(FlatBufferBuilder builder, bool isClientEditable)
		{
			builder.AddBool(9, isClientEditable, false);
		}

		// Token: 0x06015E2E RID: 89646 RVA: 0x003258EA File Offset: 0x00323AEA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06015E2F RID: 89647 RVA: 0x003258F6 File Offset: 0x00323AF6
		public static Offset<IVarDefine> EndIVarDefine(FlatBufferBuilder builder)
		{
			return new Offset<IVarDefine>(builder.EndTable());
		}

		// Token: 0x06015E30 RID: 89648 RVA: 0x00325904 File Offset: 0x00323B04
		public IVarDefineT UnPack()
		{
			IVarDefineT varDefineT = new IVarDefineT();
			this.UnPackTo(varDefineT);
			return varDefineT;
		}

		// Token: 0x06015E31 RID: 89649 RVA: 0x00325920 File Offset: 0x00323B20
		public void UnPackTo(IVarDefineT _o)
		{
			_o.Name = this.Name;
			_o.Type = this.Type;
			_o.Value = new TVarValueUnion();
			_o.Value.Type = this.ValueType;
			switch (this.ValueType)
			{
			case TVarValue.BooleanValue:
				_o.Value.Value = ((this.Value<BooleanValue>() != null) ? this.Value<BooleanValue>().Value.UnPack() : null);
				break;
			case TVarValue.IntValue:
				_o.Value.Value = ((this.Value<IntValue>() != null) ? this.Value<IntValue>().Value.UnPack() : null);
				break;
			case TVarValue.FloatValue:
				_o.Value.Value = ((this.Value<FloatValue>() != null) ? this.Value<FloatValue>().Value.UnPack() : null);
				break;
			case TVarValue.StringValue:
				_o.Value.Value = ((this.Value<StringValue>() != null) ? this.Value<StringValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestStateValue:
				_o.Value.Value = ((this.Value<QuestStateValue>() != null) ? this.Value<QuestStateValue>().Value.UnPack() : null);
				break;
			case TVarValue.EntityValue:
				_o.Value.Value = ((this.Value<EntityValue>() != null) ? this.Value<EntityValue>().Value.UnPack() : null);
				break;
			case TVarValue.QuestValue:
				_o.Value.Value = ((this.Value<QuestValue>() != null) ? this.Value<QuestValue>().Value.UnPack() : null);
				break;
			case TVarValue.PrefabValue:
				_o.Value.Value = ((this.Value<PrefabValue>() != null) ? this.Value<PrefabValue>().Value.UnPack() : null);
				break;
			case TVarValue.TransformValue:
				_o.Value.Value = ((this.Value<TransformValue>() != null) ? this.Value<TransformValue>().Value.UnPack() : null);
				break;
			}
			_o.Access = this.Access;
			_o.IsIgnoreOnRollBack = this.IsIgnoreOnRollBack;
			_o.IsClient = this.IsClient;
			_o.ValidateConfig = new TVarValidateConfigUnion();
			_o.ValidateConfig.Type = this.ValidateConfigType;
			switch (this.ValidateConfigType)
			{
			case TVarValidateConfig.IVarBooleanValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarBooleanValidateConfig>() != null) ? this.ValidateConfig<IVarBooleanValidateConfig>().Value.UnPack() : null);
				break;
			case TVarValidateConfig.IVarEntityValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarEntityValidateConfig>() != null) ? this.ValidateConfig<IVarEntityValidateConfig>().Value.UnPack() : null);
				break;
			case TVarValidateConfig.IVarFloatValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarFloatValidateConfig>() != null) ? this.ValidateConfig<IVarFloatValidateConfig>().Value.UnPack() : null);
				break;
			case TVarValidateConfig.IVarIntValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarIntValidateConfig>() != null) ? this.ValidateConfig<IVarIntValidateConfig>().Value.UnPack() : null);
				break;
			case TVarValidateConfig.IVarPrefabValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarPrefabValidateConfig>() != null) ? this.ValidateConfig<IVarPrefabValidateConfig>().Value.UnPack() : null);
				break;
			case TVarValidateConfig.IVarQuestStateValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarQuestStateValidateConfig>() != null) ? this.ValidateConfig<IVarQuestStateValidateConfig>().Value.UnPack() : null);
				break;
			case TVarValidateConfig.IVarQuestValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarQuestValidateConfig>() != null) ? this.ValidateConfig<IVarQuestValidateConfig>().Value.UnPack() : null);
				break;
			case TVarValidateConfig.IVarStringValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarStringValidateConfig>() != null) ? this.ValidateConfig<IVarStringValidateConfig>().Value.UnPack() : null);
				break;
			case TVarValidateConfig.IVarTransformValidateConfig:
				_o.ValidateConfig.Value = ((this.ValidateConfig<IVarTransformValidateConfig>() != null) ? this.ValidateConfig<IVarTransformValidateConfig>().Value.UnPack() : null);
				break;
			}
			_o.IsClientEditable = this.IsClientEditable;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015E32 RID: 89650 RVA: 0x00325E48 File Offset: 0x00324048
		public static Offset<IVarDefine> Pack(FlatBufferBuilder builder, IVarDefineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarDefine>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			TVarValue value_type = (_o.Value == null) ? TVarValue.NONE : _o.Value.Type;
			int valueOffset = (_o.Value == null) ? 0 : TVarValueUnion.Pack(builder, _o.Value);
			TVarValidateConfig validateConfig_type = (_o.ValidateConfig == null) ? TVarValidateConfig.NONE : _o.ValidateConfig.Type;
			int validateConfigOffset = (_o.ValidateConfig == null) ? 0 : TVarValidateConfigUnion.Pack(builder, _o.ValidateConfig);
			return IVarDefine.CreateIVarDefine(builder, nameOffset, _o.Type, value_type, valueOffset, _o.Access, _o.IsIgnoreOnRollBack, _o.IsClient, validateConfig_type, validateConfigOffset, _o.IsClientEditable, _o.NullMask);
		}

		// Token: 0x0400B931 RID: 47409
		private Table __p;
	}
}
