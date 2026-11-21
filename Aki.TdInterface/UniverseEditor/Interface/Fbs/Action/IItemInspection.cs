using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007079 RID: 28793
	public struct IItemInspection : IFlatbufferObject
	{
		// Token: 0x1700D2DD RID: 53981
		// (get) Token: 0x06031EEB RID: 204523 RVA: 0x006C2071 File Offset: 0x006C0271
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031EEC RID: 204524 RVA: 0x006C207E File Offset: 0x006C027E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031EED RID: 204525 RVA: 0x006C2088 File Offset: 0x006C0288
		public static IItemInspection GetRootAsIItemInspection(ByteBuffer _bb)
		{
			return IItemInspection.GetRootAsIItemInspection(_bb, default(IItemInspection));
		}

		// Token: 0x06031EEE RID: 204526 RVA: 0x006C20A4 File Offset: 0x006C02A4
		public static IItemInspection GetRootAsIItemInspection(ByteBuffer _bb, IItemInspection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031EEF RID: 204527 RVA: 0x006C20C1 File Offset: 0x006C02C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031EF0 RID: 204528 RVA: 0x006C20D0 File Offset: 0x006C02D0
		public IItemInspection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2DE RID: 53982
		// (get) Token: 0x06031EF1 RID: 204529 RVA: 0x006C20E0 File Offset: 0x006C02E0
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2DF RID: 53983
		// (get) Token: 0x06031EF2 RID: 204530 RVA: 0x006C211C File Offset: 0x006C031C
		public string PrefabPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031EF3 RID: 204531 RVA: 0x006C2153 File Offset: 0x006C0353
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031EF4 RID: 204532 RVA: 0x006C2162 File Offset: 0x006C0362
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D2E0 RID: 53984
		// (get) Token: 0x06031EF5 RID: 204533 RVA: 0x006C2170 File Offset: 0x006C0370
		public float RotateSpeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2E1 RID: 53985
		// (get) Token: 0x06031EF6 RID: 204534 RVA: 0x006C21B0 File Offset: 0x006C03B0
		public ISequenceUnlockPoints? InteractPointsConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISequenceUnlockPoints?(default(ISequenceUnlockPoints).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D2E2 RID: 53986
		// (get) Token: 0x06031EF7 RID: 204535 RVA: 0x006C2210 File Offset: 0x006C0410
		public IConeRangeCheck? RangeCheckConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IConeRangeCheck?(default(IConeRangeCheck).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D2E3 RID: 53987
		// (get) Token: 0x06031EF8 RID: 204536 RVA: 0x006C2270 File Offset: 0x006C0470
		public IAstrologyTextUiConfig? TextUiConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IAstrologyTextUiConfig?(default(IAstrologyTextUiConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D2E4 RID: 53988
		// (get) Token: 0x06031EF9 RID: 204537 RVA: 0x006C22D0 File Offset: 0x006C04D0
		public bool CanExit
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D2E5 RID: 53989
		// (get) Token: 0x06031EFA RID: 204538 RVA: 0x006C2310 File Offset: 0x006C0510
		public float ItemOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2E6 RID: 53990
		// (get) Token: 0x06031EFB RID: 204539 RVA: 0x006C2354 File Offset: 0x006C0554
		public IItemInspectFinishEffect? ItemInteractFinishEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IItemInspectFinishEffect?(default(IItemInspectFinishEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D2E7 RID: 53991
		// (get) Token: 0x06031EFC RID: 204540 RVA: 0x006C23B4 File Offset: 0x006C05B4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031EFD RID: 204541 RVA: 0x006C23F4 File Offset: 0x006C05F4
		public static Offset<IItemInspection> CreateIItemInspection(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset PrefabPathOffset = default(StringOffset), float RotateSpeed = 0f, Offset<ISequenceUnlockPoints> InteractPointsConfigOffset = default(Offset<ISequenceUnlockPoints>), Offset<IConeRangeCheck> RangeCheckConfigOffset = default(Offset<IConeRangeCheck>), Offset<IAstrologyTextUiConfig> TextUiConfigOffset = default(Offset<IAstrologyTextUiConfig>), bool CanExit = false, float ItemOffsetDistance = 0f, Offset<IItemInspectFinishEffect> ItemInteractFinishEffectOffset = default(Offset<IItemInspectFinishEffect>), byte NullMask = 0)
		{
			builder.StartTable(10);
			IItemInspection.AddItemInteractFinishEffect(builder, ItemInteractFinishEffectOffset);
			IItemInspection.AddItemOffsetDistance(builder, ItemOffsetDistance);
			IItemInspection.AddTextUiConfig(builder, TextUiConfigOffset);
			IItemInspection.AddRangeCheckConfig(builder, RangeCheckConfigOffset);
			IItemInspection.AddInteractPointsConfig(builder, InteractPointsConfigOffset);
			IItemInspection.AddRotateSpeed(builder, RotateSpeed);
			IItemInspection.AddPrefabPath(builder, PrefabPathOffset);
			IItemInspection.AddNullMask(builder, NullMask);
			IItemInspection.AddCanExit(builder, CanExit);
			IItemInspection.AddType(builder, Type);
			return IItemInspection.EndIItemInspection(builder);
		}

		// Token: 0x06031EFE RID: 204542 RVA: 0x006C245C File Offset: 0x006C065C
		public static void StartIItemInspection(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06031EFF RID: 204543 RVA: 0x006C2466 File Offset: 0x006C0666
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031F00 RID: 204544 RVA: 0x006C2471 File Offset: 0x006C0671
		public static void AddPrefabPath(FlatBufferBuilder builder, StringOffset prefabPathOffset)
		{
			builder.AddOffset(1, prefabPathOffset.Value, 0);
		}

		// Token: 0x06031F01 RID: 204545 RVA: 0x006C2481 File Offset: 0x006C0681
		public static void AddRotateSpeed(FlatBufferBuilder builder, float rotateSpeed)
		{
			builder.AddFloat(2, rotateSpeed, 0.0);
		}

		// Token: 0x06031F02 RID: 204546 RVA: 0x006C2494 File Offset: 0x006C0694
		public static void AddInteractPointsConfig(FlatBufferBuilder builder, Offset<ISequenceUnlockPoints> interactPointsConfigOffset)
		{
			builder.AddOffset(3, interactPointsConfigOffset.Value, 0);
		}

		// Token: 0x06031F03 RID: 204547 RVA: 0x006C24A4 File Offset: 0x006C06A4
		public static void AddRangeCheckConfig(FlatBufferBuilder builder, Offset<IConeRangeCheck> rangeCheckConfigOffset)
		{
			builder.AddOffset(4, rangeCheckConfigOffset.Value, 0);
		}

		// Token: 0x06031F04 RID: 204548 RVA: 0x006C24B4 File Offset: 0x006C06B4
		public static void AddTextUiConfig(FlatBufferBuilder builder, Offset<IAstrologyTextUiConfig> textUiConfigOffset)
		{
			builder.AddOffset(5, textUiConfigOffset.Value, 0);
		}

		// Token: 0x06031F05 RID: 204549 RVA: 0x006C24C4 File Offset: 0x006C06C4
		public static void AddCanExit(FlatBufferBuilder builder, bool canExit)
		{
			builder.AddBool(6, canExit, false);
		}

		// Token: 0x06031F06 RID: 204550 RVA: 0x006C24CF File Offset: 0x006C06CF
		public static void AddItemOffsetDistance(FlatBufferBuilder builder, float itemOffsetDistance)
		{
			builder.AddFloat(7, itemOffsetDistance, 0.0);
		}

		// Token: 0x06031F07 RID: 204551 RVA: 0x006C24E2 File Offset: 0x006C06E2
		public static void AddItemInteractFinishEffect(FlatBufferBuilder builder, Offset<IItemInspectFinishEffect> itemInteractFinishEffectOffset)
		{
			builder.AddOffset(8, itemInteractFinishEffectOffset.Value, 0);
		}

		// Token: 0x06031F08 RID: 204552 RVA: 0x006C24F2 File Offset: 0x006C06F2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06031F09 RID: 204553 RVA: 0x006C24FE File Offset: 0x006C06FE
		public static Offset<IItemInspection> EndIItemInspection(FlatBufferBuilder builder)
		{
			return new Offset<IItemInspection>(builder.EndTable());
		}

		// Token: 0x06031F0A RID: 204554 RVA: 0x006C250C File Offset: 0x006C070C
		public IItemInspectionT UnPack()
		{
			IItemInspectionT itemInspectionT = new IItemInspectionT();
			this.UnPackTo(itemInspectionT);
			return itemInspectionT;
		}

		// Token: 0x06031F0B RID: 204555 RVA: 0x006C2528 File Offset: 0x006C0728
		public void UnPackTo(IItemInspectionT _o)
		{
			_o.Type = this.Type;
			_o.PrefabPath = this.PrefabPath;
			_o.RotateSpeed = this.RotateSpeed;
			_o.InteractPointsConfig = ((this.InteractPointsConfig != null) ? this.InteractPointsConfig.Value.UnPack() : null);
			_o.RangeCheckConfig = ((this.RangeCheckConfig != null) ? this.RangeCheckConfig.Value.UnPack() : null);
			_o.TextUiConfig = ((this.TextUiConfig != null) ? this.TextUiConfig.Value.UnPack() : null);
			_o.CanExit = this.CanExit;
			_o.ItemOffsetDistance = this.ItemOffsetDistance;
			_o.ItemInteractFinishEffect = ((this.ItemInteractFinishEffect != null) ? this.ItemInteractFinishEffect.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031F0C RID: 204556 RVA: 0x006C2640 File Offset: 0x006C0840
		public static Offset<IItemInspection> Pack(FlatBufferBuilder builder, IItemInspectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemInspection>);
			}
			StringOffset prefabPathOffset = (_o.PrefabPath == null) ? default(StringOffset) : builder.CreateString(_o.PrefabPath);
			Offset<ISequenceUnlockPoints> interactPointsConfigOffset = (_o.InteractPointsConfig == null) ? default(Offset<ISequenceUnlockPoints>) : ISequenceUnlockPoints.Pack(builder, _o.InteractPointsConfig);
			Offset<IConeRangeCheck> rangeCheckConfigOffset = (_o.RangeCheckConfig == null) ? default(Offset<IConeRangeCheck>) : IConeRangeCheck.Pack(builder, _o.RangeCheckConfig);
			Offset<IAstrologyTextUiConfig> textUiConfigOffset = (_o.TextUiConfig == null) ? default(Offset<IAstrologyTextUiConfig>) : IAstrologyTextUiConfig.Pack(builder, _o.TextUiConfig);
			Offset<IItemInspectFinishEffect> itemInteractFinishEffectOffset = (_o.ItemInteractFinishEffect == null) ? default(Offset<IItemInspectFinishEffect>) : IItemInspectFinishEffect.Pack(builder, _o.ItemInteractFinishEffect);
			return IItemInspection.CreateIItemInspection(builder, _o.Type, prefabPathOffset, _o.RotateSpeed, interactPointsConfigOffset, rangeCheckConfigOffset, textUiConfigOffset, _o.CanExit, _o.ItemOffsetDistance, itemInteractFinishEffectOffset, _o.NullMask);
		}

		// Token: 0x04011FE5 RID: 73701
		private Table __p;
	}
}
