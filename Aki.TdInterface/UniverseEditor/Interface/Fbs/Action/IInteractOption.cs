using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007046 RID: 28742
	public struct IInteractOption : IFlatbufferObject
	{
		// Token: 0x1700D26A RID: 53866
		// (get) Token: 0x06031CFE RID: 204030 RVA: 0x006BE002 File Offset: 0x006BC202
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031CFF RID: 204031 RVA: 0x006BE00F File Offset: 0x006BC20F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D00 RID: 204032 RVA: 0x006BE018 File Offset: 0x006BC218
		public static IInteractOption GetRootAsIInteractOption(ByteBuffer _bb)
		{
			return IInteractOption.GetRootAsIInteractOption(_bb, default(IInteractOption));
		}

		// Token: 0x06031D01 RID: 204033 RVA: 0x006BE034 File Offset: 0x006BC234
		public static IInteractOption GetRootAsIInteractOption(ByteBuffer _bb, IInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D02 RID: 204034 RVA: 0x006BE051 File Offset: 0x006BC251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D03 RID: 204035 RVA: 0x006BE060 File Offset: 0x006BC260
		public IInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D26B RID: 53867
		// (get) Token: 0x06031D04 RID: 204036 RVA: 0x006BE070 File Offset: 0x006BC270
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

		// Token: 0x06031D05 RID: 204037 RVA: 0x006BE0A7 File Offset: 0x006BC2A7
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031D06 RID: 204038 RVA: 0x006BE0B6 File Offset: 0x006BC2B6
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D26C RID: 53868
		// (get) Token: 0x06031D07 RID: 204039 RVA: 0x006BE0C4 File Offset: 0x006BC2C4
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

		// Token: 0x06031D08 RID: 204040 RVA: 0x006BE100 File Offset: 0x006BC300
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031D09 RID: 204041 RVA: 0x006BE144 File Offset: 0x006BC344
		public IInteractActions TypeAsIInteractActions()
		{
			return this.Type<IInteractActions>().Value;
		}

		// Token: 0x06031D0A RID: 204042 RVA: 0x006BE160 File Offset: 0x006BC360
		public IInteractFlow TypeAsIInteractFlow()
		{
			return this.Type<IInteractFlow>().Value;
		}

		// Token: 0x1700D26D RID: 53869
		// (get) Token: 0x06031D0B RID: 204043 RVA: 0x006BE17C File Offset: 0x006BC37C
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

		// Token: 0x1700D26E RID: 53870
		// (get) Token: 0x06031D0C RID: 204044 RVA: 0x006BE1BC File Offset: 0x006BC3BC
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

		// Token: 0x06031D0D RID: 204045 RVA: 0x006BE1F4 File Offset: 0x006BC3F4
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06031D0E RID: 204046 RVA: 0x006BE204 File Offset: 0x006BC404
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700D26F RID: 53871
		// (get) Token: 0x06031D0F RID: 204047 RVA: 0x006BE214 File Offset: 0x006BC414
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

		// Token: 0x1700D270 RID: 53872
		// (get) Token: 0x06031D10 RID: 204048 RVA: 0x006BE274 File Offset: 0x006BC474
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

		// Token: 0x1700D271 RID: 53873
		// (get) Token: 0x06031D11 RID: 204049 RVA: 0x006BE2D4 File Offset: 0x006BC4D4
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

		// Token: 0x1700D272 RID: 53874
		// (get) Token: 0x06031D12 RID: 204050 RVA: 0x006BE334 File Offset: 0x006BC534
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

		// Token: 0x1700D273 RID: 53875
		// (get) Token: 0x06031D13 RID: 204051 RVA: 0x006BE374 File Offset: 0x006BC574
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

		// Token: 0x1700D274 RID: 53876
		// (get) Token: 0x06031D14 RID: 204052 RVA: 0x006BE3B4 File Offset: 0x006BC5B4
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

		// Token: 0x1700D275 RID: 53877
		// (get) Token: 0x06031D15 RID: 204053 RVA: 0x006BE3F8 File Offset: 0x006BC5F8
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

		// Token: 0x1700D276 RID: 53878
		// (get) Token: 0x06031D16 RID: 204054 RVA: 0x006BE458 File Offset: 0x006BC658
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

		// Token: 0x06031D17 RID: 204055 RVA: 0x006BE4B8 File Offset: 0x006BC6B8
		public EOptionLockType OptionLockTypeList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return EOptionLockType.OnMotor;
			}
			return (EOptionLockType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D277 RID: 53879
		// (get) Token: 0x06031D18 RID: 204056 RVA: 0x006BE4F8 File Offset: 0x006BC6F8
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

		// Token: 0x06031D19 RID: 204057 RVA: 0x006BE524 File Offset: 0x006BC724
		public Span<EOptionLockType> GetOptionLockTypeListBytes()
		{
			return this.__p.__vector_as_span<EOptionLockType>(30, 1);
		}

		// Token: 0x06031D1A RID: 204058 RVA: 0x006BE534 File Offset: 0x006BC734
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

		// Token: 0x06031D1B RID: 204059 RVA: 0x006BE5A0 File Offset: 0x006BC7A0
		public EOptionUnlockType OptionUnlockTypeList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return EOptionUnlockType.OnMecha;
			}
			return (EOptionUnlockType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D278 RID: 53880
		// (get) Token: 0x06031D1C RID: 204060 RVA: 0x006BE5E0 File Offset: 0x006BC7E0
		public int OptionUnlockTypeListLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06031D1D RID: 204061 RVA: 0x006BE60C File Offset: 0x006BC80C
		public Span<EOptionUnlockType> GetOptionUnlockTypeListBytes()
		{
			return this.__p.__vector_as_span<EOptionUnlockType>(32, 1);
		}

		// Token: 0x06031D1E RID: 204062 RVA: 0x006BE61C File Offset: 0x006BC81C
		public EOptionUnlockType[] GetOptionUnlockTypeListArray()
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EOptionUnlockType[] array = new EOptionUnlockType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EOptionUnlockType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700D279 RID: 53881
		// (get) Token: 0x06031D1F RID: 204063 RVA: 0x006BE688 File Offset: 0x006BC888
		public ILongPressInteractConfig? LongPressInteractConfig
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new ILongPressInteractConfig?(default(ILongPressInteractConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D27A RID: 53882
		// (get) Token: 0x06031D20 RID: 204064 RVA: 0x006BE6E8 File Offset: 0x006BC8E8
		public bool KeepInRecall
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D27B RID: 53883
		// (get) Token: 0x06031D21 RID: 204065 RVA: 0x006BE728 File Offset: 0x006BC928
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031D22 RID: 204066 RVA: 0x006BE768 File Offset: 0x006BC968
		public static Offset<IInteractOption> CreateIInteractOption(FlatBufferBuilder builder, StringOffset GuidOffset = default(StringOffset), TInteractOption Type_type = TInteractOption.NONE, int TypeOffset = 0, EInteractIcon Icon = EInteractIcon.Dialog, StringOffset TidContentOffset = default(StringOffset), Offset<IVectorInfo> InteractPointOffsetOffset = default(Offset<IVectorInfo>), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IInteractOptionConfirmBox> ConfirmBoxOffset = default(Offset<IInteractOptionConfirmBox>), EInteractUniqueness UniquenessTest = EInteractUniqueness.Closest, EDoInteract DoIntactType = EDoInteract.Direct, float Range = 0f, Offset<IDurationInteract> DurationOffset = default(Offset<IDurationInteract>), Offset<IOptionLockTip> OptionLockTipOffset = default(Offset<IOptionLockTip>), VectorOffset OptionLockTypeListOffset = default(VectorOffset), VectorOffset OptionUnlockTypeListOffset = default(VectorOffset), Offset<ILongPressInteractConfig> LongPressInteractConfigOffset = default(Offset<ILongPressInteractConfig>), bool KeepInRecall = false, byte NullMask = 0)
		{
			builder.StartTable(18);
			IInteractOption.AddLongPressInteractConfig(builder, LongPressInteractConfigOffset);
			IInteractOption.AddOptionUnlockTypeList(builder, OptionUnlockTypeListOffset);
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

		// Token: 0x06031D23 RID: 204067 RVA: 0x006BE810 File Offset: 0x006BCA10
		public static void StartIInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(18);
		}

		// Token: 0x06031D24 RID: 204068 RVA: 0x006BE81A File Offset: 0x006BCA1A
		public static void AddGuid(FlatBufferBuilder builder, StringOffset guidOffset)
		{
			builder.AddOffset(0, guidOffset.Value, 0);
		}

		// Token: 0x06031D25 RID: 204069 RVA: 0x006BE82A File Offset: 0x006BCA2A
		public static void AddTypeType(FlatBufferBuilder builder, TInteractOption typeType)
		{
			builder.AddByte(1, (byte)typeType, 0);
		}

		// Token: 0x06031D26 RID: 204070 RVA: 0x006BE835 File Offset: 0x006BCA35
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(2, typeOffset, 0);
		}

		// Token: 0x06031D27 RID: 204071 RVA: 0x006BE840 File Offset: 0x006BCA40
		public static void AddIcon(FlatBufferBuilder builder, EInteractIcon icon)
		{
			builder.AddByte(3, (byte)icon, 0);
		}

		// Token: 0x06031D28 RID: 204072 RVA: 0x006BE84B File Offset: 0x006BCA4B
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(4, tidContentOffset.Value, 0);
		}

		// Token: 0x06031D29 RID: 204073 RVA: 0x006BE85B File Offset: 0x006BCA5B
		public static void AddInteractPointOffset(FlatBufferBuilder builder, Offset<IVectorInfo> interactPointOffsetOffset)
		{
			builder.AddOffset(5, interactPointOffsetOffset.Value, 0);
		}

		// Token: 0x06031D2A RID: 204074 RVA: 0x006BE86B File Offset: 0x006BCA6B
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(6, conditionOffset.Value, 0);
		}

		// Token: 0x06031D2B RID: 204075 RVA: 0x006BE87B File Offset: 0x006BCA7B
		public static void AddConfirmBox(FlatBufferBuilder builder, Offset<IInteractOptionConfirmBox> confirmBoxOffset)
		{
			builder.AddOffset(7, confirmBoxOffset.Value, 0);
		}

		// Token: 0x06031D2C RID: 204076 RVA: 0x006BE88B File Offset: 0x006BCA8B
		public static void AddUniquenessTest(FlatBufferBuilder builder, EInteractUniqueness uniquenessTest)
		{
			builder.AddByte(8, (byte)uniquenessTest, 0);
		}

		// Token: 0x06031D2D RID: 204077 RVA: 0x006BE896 File Offset: 0x006BCA96
		public static void AddDoIntactType(FlatBufferBuilder builder, EDoInteract doIntactType)
		{
			builder.AddByte(9, (byte)doIntactType, 0);
		}

		// Token: 0x06031D2E RID: 204078 RVA: 0x006BE8A2 File Offset: 0x006BCAA2
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(10, range, 0.0);
		}

		// Token: 0x06031D2F RID: 204079 RVA: 0x006BE8B6 File Offset: 0x006BCAB6
		public static void AddDuration(FlatBufferBuilder builder, Offset<IDurationInteract> durationOffset)
		{
			builder.AddOffset(11, durationOffset.Value, 0);
		}

		// Token: 0x06031D30 RID: 204080 RVA: 0x006BE8C7 File Offset: 0x006BCAC7
		public static void AddOptionLockTip(FlatBufferBuilder builder, Offset<IOptionLockTip> optionLockTipOffset)
		{
			builder.AddOffset(12, optionLockTipOffset.Value, 0);
		}

		// Token: 0x06031D31 RID: 204081 RVA: 0x006BE8D8 File Offset: 0x006BCAD8
		public static void AddOptionLockTypeList(FlatBufferBuilder builder, VectorOffset optionLockTypeListOffset)
		{
			builder.AddOffset(13, optionLockTypeListOffset.Value, 0);
		}

		// Token: 0x06031D32 RID: 204082 RVA: 0x006BE8EC File Offset: 0x006BCAEC
		public static VectorOffset CreateOptionLockTypeListVector(FlatBufferBuilder builder, EOptionLockType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031D33 RID: 204083 RVA: 0x006BE923 File Offset: 0x006BCB23
		public static VectorOffset CreateOptionLockTypeListVectorBlock(FlatBufferBuilder builder, EOptionLockType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EOptionLockType>(data);
			return builder.EndVector();
		}

		// Token: 0x06031D34 RID: 204084 RVA: 0x006BE93D File Offset: 0x006BCB3D
		public static VectorOffset CreateOptionLockTypeListVectorBlock(FlatBufferBuilder builder, ArraySegment<EOptionLockType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EOptionLockType>(data);
			return builder.EndVector();
		}

		// Token: 0x06031D35 RID: 204085 RVA: 0x006BE95B File Offset: 0x006BCB5B
		public static VectorOffset CreateOptionLockTypeListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EOptionLockType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031D36 RID: 204086 RVA: 0x006BE974 File Offset: 0x006BCB74
		public static void StartOptionLockTypeListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06031D37 RID: 204087 RVA: 0x006BE97F File Offset: 0x006BCB7F
		public static void AddOptionUnlockTypeList(FlatBufferBuilder builder, VectorOffset optionUnlockTypeListOffset)
		{
			builder.AddOffset(14, optionUnlockTypeListOffset.Value, 0);
		}

		// Token: 0x06031D38 RID: 204088 RVA: 0x006BE990 File Offset: 0x006BCB90
		public static VectorOffset CreateOptionUnlockTypeListVector(FlatBufferBuilder builder, EOptionUnlockType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031D39 RID: 204089 RVA: 0x006BE9C7 File Offset: 0x006BCBC7
		public static VectorOffset CreateOptionUnlockTypeListVectorBlock(FlatBufferBuilder builder, EOptionUnlockType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EOptionUnlockType>(data);
			return builder.EndVector();
		}

		// Token: 0x06031D3A RID: 204090 RVA: 0x006BE9E1 File Offset: 0x006BCBE1
		public static VectorOffset CreateOptionUnlockTypeListVectorBlock(FlatBufferBuilder builder, ArraySegment<EOptionUnlockType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EOptionUnlockType>(data);
			return builder.EndVector();
		}

		// Token: 0x06031D3B RID: 204091 RVA: 0x006BE9FF File Offset: 0x006BCBFF
		public static VectorOffset CreateOptionUnlockTypeListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EOptionUnlockType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031D3C RID: 204092 RVA: 0x006BEA18 File Offset: 0x006BCC18
		public static void StartOptionUnlockTypeListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06031D3D RID: 204093 RVA: 0x006BEA23 File Offset: 0x006BCC23
		public static void AddLongPressInteractConfig(FlatBufferBuilder builder, Offset<ILongPressInteractConfig> longPressInteractConfigOffset)
		{
			builder.AddOffset(15, longPressInteractConfigOffset.Value, 0);
		}

		// Token: 0x06031D3E RID: 204094 RVA: 0x006BEA34 File Offset: 0x006BCC34
		public static void AddKeepInRecall(FlatBufferBuilder builder, bool keepInRecall)
		{
			builder.AddBool(16, keepInRecall, false);
		}

		// Token: 0x06031D3F RID: 204095 RVA: 0x006BEA40 File Offset: 0x006BCC40
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(17, nullMask, 0);
		}

		// Token: 0x06031D40 RID: 204096 RVA: 0x006BEA4C File Offset: 0x006BCC4C
		public static Offset<IInteractOption> EndIInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IInteractOption>(builder.EndTable());
		}

		// Token: 0x06031D41 RID: 204097 RVA: 0x006BEA5C File Offset: 0x006BCC5C
		public IInteractOptionT UnPack()
		{
			IInteractOptionT interactOptionT = new IInteractOptionT();
			this.UnPackTo(interactOptionT);
			return interactOptionT;
		}

		// Token: 0x06031D42 RID: 204098 RVA: 0x006BEA78 File Offset: 0x006BCC78
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
			_o.OptionUnlockTypeList = new List<EOptionUnlockType>();
			for (int j = 0; j < this.OptionUnlockTypeListLength; j++)
			{
				_o.OptionUnlockTypeList.Add(this.OptionUnlockTypeList(j));
			}
			_o.LongPressInteractConfig = ((this.LongPressInteractConfig != null) ? this.LongPressInteractConfig.Value.UnPack() : null);
			_o.KeepInRecall = this.KeepInRecall;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031D43 RID: 204099 RVA: 0x006BED10 File Offset: 0x006BCF10
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
			VectorOffset optionUnlockTypeListOffset = default(VectorOffset);
			if (_o.OptionUnlockTypeList != null)
			{
				EOptionUnlockType[] data2 = _o.OptionUnlockTypeList.ToArray();
				optionUnlockTypeListOffset = IInteractOption.CreateOptionUnlockTypeListVector(builder, data2);
			}
			Offset<ILongPressInteractConfig> longPressInteractConfigOffset = (_o.LongPressInteractConfig == null) ? default(Offset<ILongPressInteractConfig>) : ILongPressInteractConfig.Pack(builder, _o.LongPressInteractConfig);
			return IInteractOption.CreateIInteractOption(builder, guidOffset, type_type, typeOffset, _o.Icon, tidContentOffset, interactPointOffsetOffset, conditionOffset, confirmBoxOffset, _o.UniquenessTest, _o.DoIntactType, _o.Range, durationOffset, optionLockTipOffset, optionLockTypeListOffset, optionUnlockTypeListOffset, longPressInteractConfigOffset, _o.KeepInRecall, _o.NullMask);
		}

		// Token: 0x04011F91 RID: 73617
		private Table __p;
	}
}
