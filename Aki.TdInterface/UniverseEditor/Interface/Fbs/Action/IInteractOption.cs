using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006993 RID: 27027
	public struct IInteractOption : IFlatbufferObject
	{
		// Token: 0x1700C867 RID: 51303
		// (get) Token: 0x0602F32E RID: 193326 RVA: 0x0066DB1A File Offset: 0x0066BD1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F32F RID: 193327 RVA: 0x0066DB27 File Offset: 0x0066BD27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F330 RID: 193328 RVA: 0x0066DB30 File Offset: 0x0066BD30
		public static IInteractOption GetRootAsIInteractOption(ByteBuffer _bb)
		{
			return IInteractOption.GetRootAsIInteractOption(_bb, default(IInteractOption));
		}

		// Token: 0x0602F331 RID: 193329 RVA: 0x0066DB4C File Offset: 0x0066BD4C
		public static IInteractOption GetRootAsIInteractOption(ByteBuffer _bb, IInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F332 RID: 193330 RVA: 0x0066DB69 File Offset: 0x0066BD69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F333 RID: 193331 RVA: 0x0066DB78 File Offset: 0x0066BD78
		public IInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C868 RID: 51304
		// (get) Token: 0x0602F334 RID: 193332 RVA: 0x0066DB88 File Offset: 0x0066BD88
		public string Guid
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

		// Token: 0x0602F335 RID: 193333 RVA: 0x0066DBBF File Offset: 0x0066BDBF
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F336 RID: 193334 RVA: 0x0066DBCE File Offset: 0x0066BDCE
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C869 RID: 51305
		// (get) Token: 0x0602F337 RID: 193335 RVA: 0x0066DBDC File Offset: 0x0066BDDC
		public TInteractOption TypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TInteractOption.NONE;
				}
				return (TInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F338 RID: 193336 RVA: 0x0066DC18 File Offset: 0x0066BE18
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F339 RID: 193337 RVA: 0x0066DC5C File Offset: 0x0066BE5C
		public IInteractActions TypeAsIInteractActions()
		{
			return this.Type<IInteractActions>().Value;
		}

		// Token: 0x0602F33A RID: 193338 RVA: 0x0066DC78 File Offset: 0x0066BE78
		public IInteractFlow TypeAsIInteractFlow()
		{
			return this.Type<IInteractFlow>().Value;
		}

		// Token: 0x1700C86A RID: 51306
		// (get) Token: 0x0602F33B RID: 193339 RVA: 0x0066DC94 File Offset: 0x0066BE94
		public EInteractIcon Icon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EInteractIcon.Dialog;
				}
				return (EInteractIcon)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C86B RID: 51307
		// (get) Token: 0x0602F33C RID: 193340 RVA: 0x0066DCD4 File Offset: 0x0066BED4
		public string TidContent
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

		// Token: 0x0602F33D RID: 193341 RVA: 0x0066DD0C File Offset: 0x0066BF0C
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602F33E RID: 193342 RVA: 0x0066DD1C File Offset: 0x0066BF1C
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700C86C RID: 51308
		// (get) Token: 0x0602F33F RID: 193343 RVA: 0x0066DD2C File Offset: 0x0066BF2C
		public IVectorInfo? InteractPointOffset
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C86D RID: 51309
		// (get) Token: 0x0602F340 RID: 193344 RVA: 0x0066DD8C File Offset: 0x0066BF8C
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C86E RID: 51310
		// (get) Token: 0x0602F341 RID: 193345 RVA: 0x0066DDEC File Offset: 0x0066BFEC
		public IInteractOptionConfirmBox? ConfirmBox
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IInteractOptionConfirmBox?(default(IInteractOptionConfirmBox).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C86F RID: 51311
		// (get) Token: 0x0602F342 RID: 193346 RVA: 0x0066DE4C File Offset: 0x0066C04C
		public EInteractUniqueness UniquenessTest
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return EInteractUniqueness.Closest;
				}
				return (EInteractUniqueness)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C870 RID: 51312
		// (get) Token: 0x0602F343 RID: 193347 RVA: 0x0066DE8C File Offset: 0x0066C08C
		public EDoInteract DoIntactType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return EDoInteract.Direct;
				}
				return (EDoInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C871 RID: 51313
		// (get) Token: 0x0602F344 RID: 193348 RVA: 0x0066DECC File Offset: 0x0066C0CC
		public float Range
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C872 RID: 51314
		// (get) Token: 0x0602F345 RID: 193349 RVA: 0x0066DF10 File Offset: 0x0066C110
		public IDurationInteract? Duration
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IDurationInteract?(default(IDurationInteract).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C873 RID: 51315
		// (get) Token: 0x0602F346 RID: 193350 RVA: 0x0066DF70 File Offset: 0x0066C170
		public IOptionLockTip? OptionLockTip
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new IOptionLockTip?(default(IOptionLockTip).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602F347 RID: 193351 RVA: 0x0066DFD0 File Offset: 0x0066C1D0
		public EOptionLockType OptionLockTypeList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return EOptionLockType.OnMotor;
			}
			return (EOptionLockType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700C874 RID: 51316
		// (get) Token: 0x0602F348 RID: 193352 RVA: 0x0066E010 File Offset: 0x0066C210
		public int OptionLockTypeListLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602F349 RID: 193353 RVA: 0x0066E03C File Offset: 0x0066C23C
		public Span<EOptionLockType> GetOptionLockTypeListBytes()
		{
			return this.__p.__vector_as_span<EOptionLockType>(30, 1);
		}

		// Token: 0x0602F34A RID: 193354 RVA: 0x0066E04C File Offset: 0x0066C24C
		public EOptionLockType[] GetOptionLockTypeListArray()
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EOptionLockType[] array = new EOptionLockType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EOptionLockType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700C875 RID: 51317
		// (get) Token: 0x0602F34B RID: 193355 RVA: 0x0066E0B8 File Offset: 0x0066C2B8
		public ILongPressInteractConfig? LongPressInteractConfig
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new ILongPressInteractConfig?(default(ILongPressInteractConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C876 RID: 51318
		// (get) Token: 0x0602F34C RID: 193356 RVA: 0x0066E118 File Offset: 0x0066C318
		public bool KeepInRecall
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C877 RID: 51319
		// (get) Token: 0x0602F34D RID: 193357 RVA: 0x0066E158 File Offset: 0x0066C358
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F34E RID: 193358 RVA: 0x0066E198 File Offset: 0x0066C398
		public static Offset<IInteractOption> CreateIInteractOption(FlatBufferBuilder builder, StringOffset GuidOffset = default(StringOffset), TInteractOption Type_type = TInteractOption.NONE, int TypeOffset = 0, EInteractIcon Icon = EInteractIcon.Dialog, StringOffset TidContentOffset = default(StringOffset), Offset<IVectorInfo> InteractPointOffsetOffset = default(Offset<IVectorInfo>), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IInteractOptionConfirmBox> ConfirmBoxOffset = default(Offset<IInteractOptionConfirmBox>), EInteractUniqueness UniquenessTest = EInteractUniqueness.Closest, EDoInteract DoIntactType = EDoInteract.Direct, float Range = 0f, Offset<IDurationInteract> DurationOffset = default(Offset<IDurationInteract>), Offset<IOptionLockTip> OptionLockTipOffset = default(Offset<IOptionLockTip>), VectorOffset OptionLockTypeListOffset = default(VectorOffset), Offset<ILongPressInteractConfig> LongPressInteractConfigOffset = default(Offset<ILongPressInteractConfig>), bool KeepInRecall = false, byte NullMask = 0)
		{
			builder.StartTable(17);
			IInteractOption.AddLongPressInteractConfig(builder, LongPressInteractConfigOffset);
			IInteractOption.AddOptionLockTypeList(builder, OptionLockTypeListOffset);
			IInteractOption.AddOptionLockTip(builder, OptionLockTipOffset);
			IInteractOption.AddDuration(builder, DurationOffset);
			IInteractOption.AddRange(builder, Range);
			IInteractOption.AddConfirmBox(builder, ConfirmBoxOffset);
			IInteractOption.AddCondition(builder, ConditionOffset);
			IInteractOption.AddInteractPointOffset(builder, InteractPointOffsetOffset);
			IInteractOption.AddTidContent(builder, TidContentOffset);
			IInteractOption.AddType(builder, TypeOffset);
			IInteractOption.AddGuid(builder, GuidOffset);
			IInteractOption.AddNullMask(builder, NullMask);
			IInteractOption.AddKeepInRecall(builder, KeepInRecall);
			IInteractOption.AddDoIntactType(builder, DoIntactType);
			IInteractOption.AddUniquenessTest(builder, UniquenessTest);
			IInteractOption.AddIcon(builder, Icon);
			IInteractOption.AddTypeType(builder, Type_type);
			return IInteractOption.EndIInteractOption(builder);
		}

		// Token: 0x0602F34F RID: 193359 RVA: 0x0066E238 File Offset: 0x0066C438
		public static void StartIInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x0602F350 RID: 193360 RVA: 0x0066E242 File Offset: 0x0066C442
		public static void AddGuid(FlatBufferBuilder builder, StringOffset guidOffset)
		{
			builder.AddOffset(0, guidOffset.Value, 0);
		}

		// Token: 0x0602F351 RID: 193361 RVA: 0x0066E252 File Offset: 0x0066C452
		public static void AddTypeType(FlatBufferBuilder builder, TInteractOption typeType)
		{
			builder.AddByte(1, (byte)typeType, 0);
		}

		// Token: 0x0602F352 RID: 193362 RVA: 0x0066E25D File Offset: 0x0066C45D
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(2, typeOffset, 0);
		}

		// Token: 0x0602F353 RID: 193363 RVA: 0x0066E268 File Offset: 0x0066C468
		public static void AddIcon(FlatBufferBuilder builder, EInteractIcon icon)
		{
			builder.AddByte(3, (byte)icon, 0);
		}

		// Token: 0x0602F354 RID: 193364 RVA: 0x0066E273 File Offset: 0x0066C473
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(4, tidContentOffset.Value, 0);
		}

		// Token: 0x0602F355 RID: 193365 RVA: 0x0066E283 File Offset: 0x0066C483
		public static void AddInteractPointOffset(FlatBufferBuilder builder, Offset<IVectorInfo> interactPointOffsetOffset)
		{
			builder.AddOffset(5, interactPointOffsetOffset.Value, 0);
		}

		// Token: 0x0602F356 RID: 193366 RVA: 0x0066E293 File Offset: 0x0066C493
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(6, conditionOffset.Value, 0);
		}

		// Token: 0x0602F357 RID: 193367 RVA: 0x0066E2A3 File Offset: 0x0066C4A3
		public static void AddConfirmBox(FlatBufferBuilder builder, Offset<IInteractOptionConfirmBox> confirmBoxOffset)
		{
			builder.AddOffset(7, confirmBoxOffset.Value, 0);
		}

		// Token: 0x0602F358 RID: 193368 RVA: 0x0066E2B3 File Offset: 0x0066C4B3
		public static void AddUniquenessTest(FlatBufferBuilder builder, EInteractUniqueness uniquenessTest)
		{
			builder.AddByte(8, (byte)uniquenessTest, 0);
		}

		// Token: 0x0602F359 RID: 193369 RVA: 0x0066E2BE File Offset: 0x0066C4BE
		public static void AddDoIntactType(FlatBufferBuilder builder, EDoInteract doIntactType)
		{
			builder.AddByte(9, (byte)doIntactType, 0);
		}

		// Token: 0x0602F35A RID: 193370 RVA: 0x0066E2CA File Offset: 0x0066C4CA
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(10, range, 0.0);
		}

		// Token: 0x0602F35B RID: 193371 RVA: 0x0066E2DE File Offset: 0x0066C4DE
		public static void AddDuration(FlatBufferBuilder builder, Offset<IDurationInteract> durationOffset)
		{
			builder.AddOffset(11, durationOffset.Value, 0);
		}

		// Token: 0x0602F35C RID: 193372 RVA: 0x0066E2EF File Offset: 0x0066C4EF
		public static void AddOptionLockTip(FlatBufferBuilder builder, Offset<IOptionLockTip> optionLockTipOffset)
		{
			builder.AddOffset(12, optionLockTipOffset.Value, 0);
		}

		// Token: 0x0602F35D RID: 193373 RVA: 0x0066E300 File Offset: 0x0066C500
		public static void AddOptionLockTypeList(FlatBufferBuilder builder, VectorOffset optionLockTypeListOffset)
		{
			builder.AddOffset(13, optionLockTypeListOffset.Value, 0);
		}

		// Token: 0x0602F35E RID: 193374 RVA: 0x0066E314 File Offset: 0x0066C514
		public static VectorOffset CreateOptionLockTypeListVector(FlatBufferBuilder builder, EOptionLockType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F35F RID: 193375 RVA: 0x0066E34B File Offset: 0x0066C54B
		public static VectorOffset CreateOptionLockTypeListVectorBlock(FlatBufferBuilder builder, EOptionLockType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EOptionLockType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F360 RID: 193376 RVA: 0x0066E365 File Offset: 0x0066C565
		public static VectorOffset CreateOptionLockTypeListVectorBlock(FlatBufferBuilder builder, ArraySegment<EOptionLockType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EOptionLockType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F361 RID: 193377 RVA: 0x0066E383 File Offset: 0x0066C583
		public static VectorOffset CreateOptionLockTypeListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EOptionLockType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F362 RID: 193378 RVA: 0x0066E39C File Offset: 0x0066C59C
		public static void StartOptionLockTypeListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602F363 RID: 193379 RVA: 0x0066E3A7 File Offset: 0x0066C5A7
		public static void AddLongPressInteractConfig(FlatBufferBuilder builder, Offset<ILongPressInteractConfig> longPressInteractConfigOffset)
		{
			builder.AddOffset(14, longPressInteractConfigOffset.Value, 0);
		}

		// Token: 0x0602F364 RID: 193380 RVA: 0x0066E3B8 File Offset: 0x0066C5B8
		public static void AddKeepInRecall(FlatBufferBuilder builder, bool keepInRecall)
		{
			builder.AddBool(15, keepInRecall, false);
		}

		// Token: 0x0602F365 RID: 193381 RVA: 0x0066E3C4 File Offset: 0x0066C5C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(16, nullMask, 0);
		}

		// Token: 0x0602F366 RID: 193382 RVA: 0x0066E3D0 File Offset: 0x0066C5D0
		public static Offset<IInteractOption> EndIInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IInteractOption>(builder.EndTable());
		}

		// Token: 0x0602F367 RID: 193383 RVA: 0x0066E3E0 File Offset: 0x0066C5E0
		public IInteractOptionT UnPack()
		{
			IInteractOptionT interactOptionT = new IInteractOptionT();
			this.UnPackTo(interactOptionT);
			return interactOptionT;
		}

		// Token: 0x0602F368 RID: 193384 RVA: 0x0066E3FC File Offset: 0x0066C5FC
		public void UnPackTo(IInteractOptionT _o)
		{
			_o.Guid = this.Guid;
			_o.Type = new TInteractOptionUnion();
			_o.Type.Type = this.TypeType;
			TInteractOption typeType = this.TypeType;
			if (typeType != TInteractOption.IInteractActions)
			{
				if (typeType == TInteractOption.IInteractFlow)
				{
					_o.Type.Value = ((this.Type<IInteractFlow>() != null) ? this.Type<IInteractFlow>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Type.Value = ((this.Type<IInteractActions>() != null) ? this.Type<IInteractActions>().Value.UnPack() : null);
			}
			_o.Icon = this.Icon;
			_o.TidContent = this.TidContent;
			_o.InteractPointOffset = ((this.InteractPointOffset != null) ? this.InteractPointOffset.Value.UnPack() : null);
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.ConfirmBox = ((this.ConfirmBox != null) ? this.ConfirmBox.Value.UnPack() : null);
			_o.UniquenessTest = this.UniquenessTest;
			_o.DoIntactType = this.DoIntactType;
			_o.Range = this.Range;
			_o.Duration = ((this.Duration != null) ? this.Duration.Value.UnPack() : null);
			_o.OptionLockTip = ((this.OptionLockTip != null) ? this.OptionLockTip.Value.UnPack() : null);
			_o.OptionLockTypeList = new List<EOptionLockType>();
			for (int i = 0; i < this.OptionLockTypeListLength; i++)
			{
				_o.OptionLockTypeList.Add(this.OptionLockTypeList(i));
			}
			_o.LongPressInteractConfig = ((this.LongPressInteractConfig != null) ? this.LongPressInteractConfig.Value.UnPack() : null);
			_o.KeepInRecall = this.KeepInRecall;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F369 RID: 193385 RVA: 0x0066E660 File Offset: 0x0066C860
		public static Offset<IInteractOption> Pack(FlatBufferBuilder builder, IInteractOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractOption>);
			}
			StringOffset guidOffset = (_o.Guid == null) ? default(StringOffset) : builder.CreateString(_o.Guid);
			TInteractOption type_type = (_o.Type == null) ? TInteractOption.NONE : _o.Type.Type;
			int typeOffset = (_o.Type == null) ? 0 : TInteractOptionUnion.Pack(builder, _o.Type);
			StringOffset tidContentOffset = (_o.TidContent == null) ? default(StringOffset) : builder.CreateString(_o.TidContent);
			Offset<IVectorInfo> interactPointOffsetOffset = (_o.InteractPointOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.InteractPointOffset);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			Offset<IInteractOptionConfirmBox> confirmBoxOffset = (_o.ConfirmBox == null) ? default(Offset<IInteractOptionConfirmBox>) : IInteractOptionConfirmBox.Pack(builder, _o.ConfirmBox);
			Offset<IDurationInteract> durationOffset = (_o.Duration == null) ? default(Offset<IDurationInteract>) : IDurationInteract.Pack(builder, _o.Duration);
			Offset<IOptionLockTip> optionLockTipOffset = (_o.OptionLockTip == null) ? default(Offset<IOptionLockTip>) : IOptionLockTip.Pack(builder, _o.OptionLockTip);
			VectorOffset optionLockTypeListOffset = default(VectorOffset);
			if (_o.OptionLockTypeList != null)
			{
				EOptionLockType[] data = _o.OptionLockTypeList.ToArray();
				optionLockTypeListOffset = IInteractOption.CreateOptionLockTypeListVector(builder, data);
			}
			Offset<ILongPressInteractConfig> longPressInteractConfigOffset = (_o.LongPressInteractConfig == null) ? default(Offset<ILongPressInteractConfig>) : ILongPressInteractConfig.Pack(builder, _o.LongPressInteractConfig);
			return IInteractOption.CreateIInteractOption(builder, guidOffset, type_type, typeOffset, _o.Icon, tidContentOffset, interactPointOffsetOffset, conditionOffset, confirmBoxOffset, _o.UniquenessTest, _o.DoIntactType, _o.Range, durationOffset, optionLockTipOffset, optionLockTypeListOffset, longPressInteractConfigOffset, _o.KeepInRecall, _o.NullMask);
		}

		// Token: 0x04011125 RID: 69925
		private Table __p;
	}
}
