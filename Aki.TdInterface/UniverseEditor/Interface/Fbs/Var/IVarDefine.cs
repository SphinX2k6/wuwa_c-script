using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AFF RID: 15103
	public struct IVarDefine : IFlatbufferObject
	{
		// Token: 0x1700678C RID: 26508
		// (get) Token: 0x06014953 RID: 84307 RVA: 0x002FF029 File Offset: 0x002FD229
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014954 RID: 84308 RVA: 0x002FF036 File Offset: 0x002FD236
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014955 RID: 84309 RVA: 0x002FF040 File Offset: 0x002FD240
		public static IVarDefine GetRootAsIVarDefine(ByteBuffer _bb)
		{
			return IVarDefine.GetRootAsIVarDefine(_bb, default(IVarDefine));
		}

		// Token: 0x06014956 RID: 84310 RVA: 0x002FF05C File Offset: 0x002FD25C
		public static IVarDefine GetRootAsIVarDefine(ByteBuffer _bb, IVarDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014957 RID: 84311 RVA: 0x002FF079 File Offset: 0x002FD279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014958 RID: 84312 RVA: 0x002FF088 File Offset: 0x002FD288
		public IVarDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700678D RID: 26509
		// (get) Token: 0x06014959 RID: 84313 RVA: 0x002FF098 File Offset: 0x002FD298
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

		// Token: 0x0601495A RID: 84314 RVA: 0x002FF0CF File Offset: 0x002FD2CF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601495B RID: 84315 RVA: 0x002FF0DE File Offset: 0x002FD2DE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700678E RID: 26510
		// (get) Token: 0x0601495C RID: 84316 RVA: 0x002FF0EC File Offset: 0x002FD2EC
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

		// Token: 0x1700678F RID: 26511
		// (get) Token: 0x0601495D RID: 84317 RVA: 0x002FF128 File Offset: 0x002FD328
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

		// Token: 0x0601495E RID: 84318 RVA: 0x002FF164 File Offset: 0x002FD364
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601495F RID: 84319 RVA: 0x002FF1AC File Offset: 0x002FD3AC
		public BooleanValue ValueAsBooleanValue()
		{
			return this.Value<BooleanValue>().Value;
		}

		// Token: 0x06014960 RID: 84320 RVA: 0x002FF1C8 File Offset: 0x002FD3C8
		public IntValue ValueAsIntValue()
		{
			return this.Value<IntValue>().Value;
		}

		// Token: 0x06014961 RID: 84321 RVA: 0x002FF1E4 File Offset: 0x002FD3E4
		public FloatValue ValueAsFloatValue()
		{
			return this.Value<FloatValue>().Value;
		}

		// Token: 0x06014962 RID: 84322 RVA: 0x002FF200 File Offset: 0x002FD400
		public StringValue ValueAsStringValue()
		{
			return this.Value<StringValue>().Value;
		}

		// Token: 0x06014963 RID: 84323 RVA: 0x002FF21C File Offset: 0x002FD41C
		public QuestStateValue ValueAsQuestStateValue()
		{
			return this.Value<QuestStateValue>().Value;
		}

		// Token: 0x06014964 RID: 84324 RVA: 0x002FF238 File Offset: 0x002FD438
		public EntityValue ValueAsEntityValue()
		{
			return this.Value<EntityValue>().Value;
		}

		// Token: 0x06014965 RID: 84325 RVA: 0x002FF254 File Offset: 0x002FD454
		public QuestValue ValueAsQuestValue()
		{
			return this.Value<QuestValue>().Value;
		}

		// Token: 0x06014966 RID: 84326 RVA: 0x002FF270 File Offset: 0x002FD470
		public PrefabValue ValueAsPrefabValue()
		{
			return this.Value<PrefabValue>().Value;
		}

		// Token: 0x06014967 RID: 84327 RVA: 0x002FF28C File Offset: 0x002FD48C
		public TransformValue ValueAsTransformValue()
		{
			return this.Value<TransformValue>().Value;
		}

		// Token: 0x17006790 RID: 26512
		// (get) Token: 0x06014968 RID: 84328 RVA: 0x002FF2A8 File Offset: 0x002FD4A8
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

		// Token: 0x17006791 RID: 26513
		// (get) Token: 0x06014969 RID: 84329 RVA: 0x002FF2E8 File Offset: 0x002FD4E8
		public bool IsIgnoreOnRollBack
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006792 RID: 26514
		// (get) Token: 0x0601496A RID: 84330 RVA: 0x002FF328 File Offset: 0x002FD528
		public bool IsClient
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006793 RID: 26515
		// (get) Token: 0x0601496B RID: 84331 RVA: 0x002FF368 File Offset: 0x002FD568
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

		// Token: 0x0601496C RID: 84332 RVA: 0x002FF3A8 File Offset: 0x002FD5A8
		public TTable? ValidateConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601496D RID: 84333 RVA: 0x002FF3F0 File Offset: 0x002FD5F0
		public IVarBooleanValidateConfig ValidateConfigAsIVarBooleanValidateConfig()
		{
			return this.ValidateConfig<IVarBooleanValidateConfig>().Value;
		}

		// Token: 0x0601496E RID: 84334 RVA: 0x002FF40C File Offset: 0x002FD60C
		public IVarEntityValidateConfig ValidateConfigAsIVarEntityValidateConfig()
		{
			return this.ValidateConfig<IVarEntityValidateConfig>().Value;
		}

		// Token: 0x0601496F RID: 84335 RVA: 0x002FF428 File Offset: 0x002FD628
		public IVarFloatValidateConfig ValidateConfigAsIVarFloatValidateConfig()
		{
			return this.ValidateConfig<IVarFloatValidateConfig>().Value;
		}

		// Token: 0x06014970 RID: 84336 RVA: 0x002FF444 File Offset: 0x002FD644
		public IVarIntValidateConfig ValidateConfigAsIVarIntValidateConfig()
		{
			return this.ValidateConfig<IVarIntValidateConfig>().Value;
		}

		// Token: 0x06014971 RID: 84337 RVA: 0x002FF460 File Offset: 0x002FD660
		public IVarPrefabValidateConfig ValidateConfigAsIVarPrefabValidateConfig()
		{
			return this.ValidateConfig<IVarPrefabValidateConfig>().Value;
		}

		// Token: 0x06014972 RID: 84338 RVA: 0x002FF47C File Offset: 0x002FD67C
		public IVarQuestStateValidateConfig ValidateConfigAsIVarQuestStateValidateConfig()
		{
			return this.ValidateConfig<IVarQuestStateValidateConfig>().Value;
		}

		// Token: 0x06014973 RID: 84339 RVA: 0x002FF498 File Offset: 0x002FD698
		public IVarQuestValidateConfig ValidateConfigAsIVarQuestValidateConfig()
		{
			return this.ValidateConfig<IVarQuestValidateConfig>().Value;
		}

		// Token: 0x06014974 RID: 84340 RVA: 0x002FF4B4 File Offset: 0x002FD6B4
		public IVarStringValidateConfig ValidateConfigAsIVarStringValidateConfig()
		{
			return this.ValidateConfig<IVarStringValidateConfig>().Value;
		}

		// Token: 0x06014975 RID: 84341 RVA: 0x002FF4D0 File Offset: 0x002FD6D0
		public IVarTransformValidateConfig ValidateConfigAsIVarTransformValidateConfig()
		{
			return this.ValidateConfig<IVarTransformValidateConfig>().Value;
		}

		// Token: 0x17006794 RID: 26516
		// (get) Token: 0x06014976 RID: 84342 RVA: 0x002FF4EC File Offset: 0x002FD6EC
		public bool IsClientEditable
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006795 RID: 26517
		// (get) Token: 0x06014977 RID: 84343 RVA: 0x002FF52C File Offset: 0x002FD72C
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

		// Token: 0x06014978 RID: 84344 RVA: 0x002FF56C File Offset: 0x002FD76C
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

		// Token: 0x06014979 RID: 84345 RVA: 0x002FF5DC File Offset: 0x002FD7DC
		public static void StartIVarDefine(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0601497A RID: 84346 RVA: 0x002FF5E6 File Offset: 0x002FD7E6
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0601497B RID: 84347 RVA: 0x002FF5F6 File Offset: 0x002FD7F6
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601497C RID: 84348 RVA: 0x002FF601 File Offset: 0x002FD801
		public static void AddValueType(FlatBufferBuilder builder, TVarValue valueType)
		{
			builder.AddByte(2, (byte)valueType, 0);
		}

		// Token: 0x0601497D RID: 84349 RVA: 0x002FF60C File Offset: 0x002FD80C
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(3, valueOffset, 0);
		}

		// Token: 0x0601497E RID: 84350 RVA: 0x002FF617 File Offset: 0x002FD817
		public static void AddAccess(FlatBufferBuilder builder, EVarAccess access)
		{
			builder.AddByte(4, (byte)access, 0);
		}

		// Token: 0x0601497F RID: 84351 RVA: 0x002FF622 File Offset: 0x002FD822
		public static void AddIsIgnoreOnRollBack(FlatBufferBuilder builder, bool isIgnoreOnRollBack)
		{
			builder.AddBool(5, isIgnoreOnRollBack, false);
		}

		// Token: 0x06014980 RID: 84352 RVA: 0x002FF62D File Offset: 0x002FD82D
		public static void AddIsClient(FlatBufferBuilder builder, bool isClient)
		{
			builder.AddBool(6, isClient, false);
		}

		// Token: 0x06014981 RID: 84353 RVA: 0x002FF638 File Offset: 0x002FD838
		public static void AddValidateConfigType(FlatBufferBuilder builder, TVarValidateConfig validateConfigType)
		{
			builder.AddByte(7, (byte)validateConfigType, 0);
		}

		// Token: 0x06014982 RID: 84354 RVA: 0x002FF643 File Offset: 0x002FD843
		public static void AddValidateConfig(FlatBufferBuilder builder, int validateConfigOffset)
		{
			builder.AddOffset(8, validateConfigOffset, 0);
		}

		// Token: 0x06014983 RID: 84355 RVA: 0x002FF64E File Offset: 0x002FD84E
		public static void AddIsClientEditable(FlatBufferBuilder builder, bool isClientEditable)
		{
			builder.AddBool(9, isClientEditable, false);
		}

		// Token: 0x06014984 RID: 84356 RVA: 0x002FF65A File Offset: 0x002FD85A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06014985 RID: 84357 RVA: 0x002FF666 File Offset: 0x002FD866
		public static Offset<IVarDefine> EndIVarDefine(FlatBufferBuilder builder)
		{
			return new Offset<IVarDefine>(builder.EndTable());
		}

		// Token: 0x06014986 RID: 84358 RVA: 0x002FF674 File Offset: 0x002FD874
		public IVarDefineT UnPack()
		{
			IVarDefineT varDefineT = new IVarDefineT();
			this.UnPackTo(varDefineT);
			return varDefineT;
		}

		// Token: 0x06014987 RID: 84359 RVA: 0x002FF690 File Offset: 0x002FD890
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

		// Token: 0x06014988 RID: 84360 RVA: 0x002FFBB8 File Offset: 0x002FDDB8
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

		// Token: 0x0400AFC4 RID: 44996
		private Table __p;
	}
}
