using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C9 RID: 27081
	public struct IItemInspection : IFlatbufferObject
	{
		// Token: 0x1700C8DD RID: 51421
		// (get) Token: 0x0602F52B RID: 193835 RVA: 0x00671D19 File Offset: 0x0066FF19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F52C RID: 193836 RVA: 0x00671D26 File Offset: 0x0066FF26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F52D RID: 193837 RVA: 0x00671D30 File Offset: 0x0066FF30
		public static IItemInspection GetRootAsIItemInspection(ByteBuffer _bb)
		{
			return IItemInspection.GetRootAsIItemInspection(_bb, default(IItemInspection));
		}

		// Token: 0x0602F52E RID: 193838 RVA: 0x00671D4C File Offset: 0x0066FF4C
		public static IItemInspection GetRootAsIItemInspection(ByteBuffer _bb, IItemInspection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F52F RID: 193839 RVA: 0x00671D69 File Offset: 0x0066FF69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F530 RID: 193840 RVA: 0x00671D78 File Offset: 0x0066FF78
		public IItemInspection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8DE RID: 51422
		// (get) Token: 0x0602F531 RID: 193841 RVA: 0x00671D88 File Offset: 0x0066FF88
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

		// Token: 0x1700C8DF RID: 51423
		// (get) Token: 0x0602F532 RID: 193842 RVA: 0x00671DC4 File Offset: 0x0066FFC4
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

		// Token: 0x0602F533 RID: 193843 RVA: 0x00671DFB File Offset: 0x0066FFFB
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F534 RID: 193844 RVA: 0x00671E0A File Offset: 0x0067000A
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C8E0 RID: 51424
		// (get) Token: 0x0602F535 RID: 193845 RVA: 0x00671E18 File Offset: 0x00670018
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

		// Token: 0x1700C8E1 RID: 51425
		// (get) Token: 0x0602F536 RID: 193846 RVA: 0x00671E58 File Offset: 0x00670058
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

		// Token: 0x1700C8E2 RID: 51426
		// (get) Token: 0x0602F537 RID: 193847 RVA: 0x00671EB8 File Offset: 0x006700B8
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

		// Token: 0x1700C8E3 RID: 51427
		// (get) Token: 0x0602F538 RID: 193848 RVA: 0x00671F18 File Offset: 0x00670118
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

		// Token: 0x1700C8E4 RID: 51428
		// (get) Token: 0x0602F539 RID: 193849 RVA: 0x00671F78 File Offset: 0x00670178
		public bool CanExit
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C8E5 RID: 51429
		// (get) Token: 0x0602F53A RID: 193850 RVA: 0x00671FB8 File Offset: 0x006701B8
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

		// Token: 0x1700C8E6 RID: 51430
		// (get) Token: 0x0602F53B RID: 193851 RVA: 0x00671FFC File Offset: 0x006701FC
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

		// Token: 0x1700C8E7 RID: 51431
		// (get) Token: 0x0602F53C RID: 193852 RVA: 0x0067205C File Offset: 0x0067025C
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

		// Token: 0x0602F53D RID: 193853 RVA: 0x0067209C File Offset: 0x0067029C
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

		// Token: 0x0602F53E RID: 193854 RVA: 0x00672104 File Offset: 0x00670304
		public static void StartIItemInspection(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0602F53F RID: 193855 RVA: 0x0067210E File Offset: 0x0067030E
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F540 RID: 193856 RVA: 0x00672119 File Offset: 0x00670319
		public static void AddPrefabPath(FlatBufferBuilder builder, StringOffset prefabPathOffset)
		{
			builder.AddOffset(1, prefabPathOffset.Value, 0);
		}

		// Token: 0x0602F541 RID: 193857 RVA: 0x00672129 File Offset: 0x00670329
		public static void AddRotateSpeed(FlatBufferBuilder builder, float rotateSpeed)
		{
			builder.AddFloat(2, rotateSpeed, 0.0);
		}

		// Token: 0x0602F542 RID: 193858 RVA: 0x0067213C File Offset: 0x0067033C
		public static void AddInteractPointsConfig(FlatBufferBuilder builder, Offset<ISequenceUnlockPoints> interactPointsConfigOffset)
		{
			builder.AddOffset(3, interactPointsConfigOffset.Value, 0);
		}

		// Token: 0x0602F543 RID: 193859 RVA: 0x0067214C File Offset: 0x0067034C
		public static void AddRangeCheckConfig(FlatBufferBuilder builder, Offset<IConeRangeCheck> rangeCheckConfigOffset)
		{
			builder.AddOffset(4, rangeCheckConfigOffset.Value, 0);
		}

		// Token: 0x0602F544 RID: 193860 RVA: 0x0067215C File Offset: 0x0067035C
		public static void AddTextUiConfig(FlatBufferBuilder builder, Offset<IAstrologyTextUiConfig> textUiConfigOffset)
		{
			builder.AddOffset(5, textUiConfigOffset.Value, 0);
		}

		// Token: 0x0602F545 RID: 193861 RVA: 0x0067216C File Offset: 0x0067036C
		public static void AddCanExit(FlatBufferBuilder builder, bool canExit)
		{
			builder.AddBool(6, canExit, false);
		}

		// Token: 0x0602F546 RID: 193862 RVA: 0x00672177 File Offset: 0x00670377
		public static void AddItemOffsetDistance(FlatBufferBuilder builder, float itemOffsetDistance)
		{
			builder.AddFloat(7, itemOffsetDistance, 0.0);
		}

		// Token: 0x0602F547 RID: 193863 RVA: 0x0067218A File Offset: 0x0067038A
		public static void AddItemInteractFinishEffect(FlatBufferBuilder builder, Offset<IItemInspectFinishEffect> itemInteractFinishEffectOffset)
		{
			builder.AddOffset(8, itemInteractFinishEffectOffset.Value, 0);
		}

		// Token: 0x0602F548 RID: 193864 RVA: 0x0067219A File Offset: 0x0067039A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0602F549 RID: 193865 RVA: 0x006721A6 File Offset: 0x006703A6
		public static Offset<IItemInspection> EndIItemInspection(FlatBufferBuilder builder)
		{
			return new Offset<IItemInspection>(builder.EndTable());
		}

		// Token: 0x0602F54A RID: 193866 RVA: 0x006721B4 File Offset: 0x006703B4
		public IItemInspectionT UnPack()
		{
			IItemInspectionT itemInspectionT = new IItemInspectionT();
			this.UnPackTo(itemInspectionT);
			return itemInspectionT;
		}

		// Token: 0x0602F54B RID: 193867 RVA: 0x006721D0 File Offset: 0x006703D0
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

		// Token: 0x0602F54C RID: 193868 RVA: 0x006722E8 File Offset: 0x006704E8
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

		// Token: 0x0401117B RID: 70011
		private Table __p;
	}
}
