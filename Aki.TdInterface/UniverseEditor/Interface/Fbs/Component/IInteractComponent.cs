using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C6 RID: 22982
	public struct IInteractComponent : IFlatbufferObject
	{
		// Token: 0x1700A6D8 RID: 42712
		// (get) Token: 0x060257A9 RID: 153513 RVA: 0x00523CE8 File Offset: 0x00521EE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060257AA RID: 153514 RVA: 0x00523CF5 File Offset: 0x00521EF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060257AB RID: 153515 RVA: 0x00523CFC File Offset: 0x00521EFC
		public static IInteractComponent GetRootAsIInteractComponent(ByteBuffer _bb)
		{
			return IInteractComponent.GetRootAsIInteractComponent(_bb, default(IInteractComponent));
		}

		// Token: 0x060257AC RID: 153516 RVA: 0x00523D18 File Offset: 0x00521F18
		public static IInteractComponent GetRootAsIInteractComponent(ByteBuffer _bb, IInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060257AD RID: 153517 RVA: 0x00523D35 File Offset: 0x00521F35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060257AE RID: 153518 RVA: 0x00523D44 File Offset: 0x00521F44
		public IInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6D9 RID: 42713
		// (get) Token: 0x060257AF RID: 153519 RVA: 0x00523D54 File Offset: 0x00521F54
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060257B0 RID: 153520 RVA: 0x00523D94 File Offset: 0x00521F94
		public int QuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A6DA RID: 42714
		// (get) Token: 0x060257B1 RID: 153521 RVA: 0x00523DD4 File Offset: 0x00521FD4
		public int QuestIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060257B2 RID: 153522 RVA: 0x00523DFF File Offset: 0x00521FFF
		public Span<int> GetQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060257B3 RID: 153523 RVA: 0x00523E0E File Offset: 0x0052200E
		public int[] GetQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700A6DB RID: 42715
		// (get) Token: 0x060257B4 RID: 153524 RVA: 0x00523E1C File Offset: 0x0052201C
		public float Range
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

		// Token: 0x1700A6DC RID: 42716
		// (get) Token: 0x060257B5 RID: 153525 RVA: 0x00523E5C File Offset: 0x0052205C
		public float ExitRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6DD RID: 42717
		// (get) Token: 0x060257B6 RID: 153526 RVA: 0x00523EA0 File Offset: 0x005220A0
		public float ForbiddenRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6DE RID: 42718
		// (get) Token: 0x060257B7 RID: 153527 RVA: 0x00523EE4 File Offset: 0x005220E4
		public IInteractScreenDetectShapeCircle? ScreenDetectLimit
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IInteractScreenDetectShapeCircle?(default(IInteractScreenDetectShapeCircle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060257B8 RID: 153528 RVA: 0x00523F44 File Offset: 0x00522144
		public IRangeByTag? RangesByTags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IRangeByTag?(default(IRangeByTag).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A6DF RID: 42719
		// (get) Token: 0x060257B9 RID: 153529 RVA: 0x00523FA8 File Offset: 0x005221A8
		public int RangesByTagsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A6E0 RID: 42720
		// (get) Token: 0x060257BA RID: 153530 RVA: 0x00523FD4 File Offset: 0x005221D4
		public EDoInteract DoIntactType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return EDoInteract.Direct;
				}
				return (EDoInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6E1 RID: 42721
		// (get) Token: 0x060257BB RID: 153531 RVA: 0x00524014 File Offset: 0x00522214
		public IInteractSectorRange? SectorRange
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IInteractSectorRange?(default(IInteractSectorRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A6E2 RID: 42722
		// (get) Token: 0x060257BC RID: 153532 RVA: 0x00524074 File Offset: 0x00522274
		public TInteractPlayerDiractionOption SectorRangeFromPlayerToEntityType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return TInteractPlayerDiractionOption.NONE;
				}
				return (TInteractPlayerDiractionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060257BD RID: 153533 RVA: 0x005240B4 File Offset: 0x005222B4
		public TTable? SectorRangeFromPlayerToEntity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060257BE RID: 153534 RVA: 0x005240FC File Offset: 0x005222FC
		public IInteractPlayerDiractionToLeisure SectorRangeFromPlayerToEntityAsIInteractPlayerDiractionToLeisure()
		{
			return this.SectorRangeFromPlayerToEntity<IInteractPlayerDiractionToLeisure>().Value;
		}

		// Token: 0x060257BF RID: 153535 RVA: 0x00524118 File Offset: 0x00522318
		public IInteractPlayerDiractionToNpc SectorRangeFromPlayerToEntityAsIInteractPlayerDiractionToNpc()
		{
			return this.SectorRangeFromPlayerToEntity<IInteractPlayerDiractionToNpc>().Value;
		}

		// Token: 0x060257C0 RID: 153536 RVA: 0x00524134 File Offset: 0x00522334
		public IInteractOption? Options(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IInteractOption?(default(IInteractOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A6E3 RID: 42723
		// (get) Token: 0x060257C1 RID: 153537 RVA: 0x00524198 File Offset: 0x00522398
		public int OptionsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A6E4 RID: 42724
		// (get) Token: 0x060257C2 RID: 153538 RVA: 0x005241C4 File Offset: 0x005223C4
		public IRandomInteract? RandomInteract
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new IRandomInteract?(default(IRandomInteract).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A6E5 RID: 42725
		// (get) Token: 0x060257C3 RID: 153539 RVA: 0x00524224 File Offset: 0x00522424
		public EInteractDefaultIcon InteractDefaultIcon
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return EInteractDefaultIcon.Collect;
				}
				return (EInteractDefaultIcon)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6E6 RID: 42726
		// (get) Token: 0x060257C4 RID: 153540 RVA: 0x00524264 File Offset: 0x00522464
		public EInteractIcon InteractIcon
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return EInteractIcon.Dialog;
				}
				return (EInteractIcon)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6E7 RID: 42727
		// (get) Token: 0x060257C5 RID: 153541 RVA: 0x005242A4 File Offset: 0x005224A4
		public EInteractTurnAround TurnAroundType
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return EInteractTurnAround.FaceEachOther;
				}
				return (EInteractTurnAround)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6E8 RID: 42728
		// (get) Token: 0x060257C6 RID: 153542 RVA: 0x005242E4 File Offset: 0x005224E4
		public bool IsWaitForTurnAroundComplete
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A6E9 RID: 42729
		// (get) Token: 0x060257C7 RID: 153543 RVA: 0x00524324 File Offset: 0x00522524
		public bool IsWaitForInteractComplete
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A6EA RID: 42730
		// (get) Token: 0x060257C8 RID: 153544 RVA: 0x00524364 File Offset: 0x00522564
		public IPlayFlow? PreFlow
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A6EB RID: 42731
		// (get) Token: 0x060257C9 RID: 153545 RVA: 0x005243C4 File Offset: 0x005225C4
		public string TidContent
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060257CA RID: 153546 RVA: 0x005243FC File Offset: 0x005225FC
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060257CB RID: 153547 RVA: 0x0052440C File Offset: 0x0052260C
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(42);
		}

		// Token: 0x1700A6EC RID: 42732
		// (get) Token: 0x060257CC RID: 153548 RVA: 0x0052441C File Offset: 0x0052261C
		public IVectorInfo? InteractPointOffset
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060257CD RID: 153549 RVA: 0x0052447C File Offset: 0x0052267C
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A6ED RID: 42733
		// (get) Token: 0x060257CE RID: 153550 RVA: 0x005244BC File Offset: 0x005226BC
		public int MatchRoleOptionTypeLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060257CF RID: 153551 RVA: 0x005244E8 File Offset: 0x005226E8
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(46, 1);
		}

		// Token: 0x060257D0 RID: 153552 RVA: 0x005244F8 File Offset: 0x005226F8
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060257D1 RID: 153553 RVA: 0x00524564 File Offset: 0x00522764
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A6EE RID: 42734
		// (get) Token: 0x060257D2 RID: 153554 RVA: 0x005245AC File Offset: 0x005227AC
		public int MatchRoleOptionLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A6EF RID: 42735
		// (get) Token: 0x060257D3 RID: 153555 RVA: 0x005245D8 File Offset: 0x005227D8
		public IFishingPointAdditionalInfo? InteractAdditionalInfo
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return new IFishingPointAdditionalInfo?(default(IFishingPointAdditionalInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A6F0 RID: 42736
		// (get) Token: 0x060257D4 RID: 153556 RVA: 0x00524638 File Offset: 0x00522838
		public IInteractPointIconConfig? PointIconConfig
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return new IInteractPointIconConfig?(default(IInteractPointIconConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A6F1 RID: 42737
		// (get) Token: 0x060257D5 RID: 153557 RVA: 0x00524698 File Offset: 0x00522898
		public IInteractCameraOffsetConfig? InteractCameraOffsetConfig
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new IInteractCameraOffsetConfig?(default(IInteractCameraOffsetConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A6F2 RID: 42738
		// (get) Token: 0x060257D6 RID: 153558 RVA: 0x005246F8 File Offset: 0x005228F8
		public TInteractStyle InteractStyleTypeType
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return TInteractStyle.NONE;
				}
				return (TInteractStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060257D7 RID: 153559 RVA: 0x00524738 File Offset: 0x00522938
		public TTable? InteractStyleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060257D8 RID: 153560 RVA: 0x00524780 File Offset: 0x00522980
		public IInteractStyleEntityPart InteractStyleTypeAsIInteractStyleEntityPart()
		{
			return this.InteractStyleType<IInteractStyleEntityPart>().Value;
		}

		// Token: 0x060257D9 RID: 153561 RVA: 0x0052479C File Offset: 0x0052299C
		public IInteractStylePanorama InteractStyleTypeAsIInteractStylePanorama()
		{
			return this.InteractStyleType<IInteractStylePanorama>().Value;
		}

		// Token: 0x1700A6F3 RID: 42739
		// (get) Token: 0x060257DA RID: 153562 RVA: 0x005247B8 File Offset: 0x005229B8
		public EInterruptMontageType InterruptMontageType
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return EInterruptMontageType.InterruptAtEnd;
				}
				return (EInterruptMontageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6F4 RID: 42740
		// (get) Token: 0x060257DB RID: 153563 RVA: 0x005247F8 File Offset: 0x005229F8
		public bool NotInterruptPlotModeLevelD
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A6F5 RID: 42741
		// (get) Token: 0x060257DC RID: 153564 RVA: 0x00524838 File Offset: 0x00522A38
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060257DD RID: 153565 RVA: 0x00524878 File Offset: 0x00522A78
		public static Offset<IInteractComponent> CreateIInteractComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset QuestIdsOffset = default(VectorOffset), float Range = 0f, float ExitRange = 0f, float ForbiddenRange = 0f, Offset<IInteractScreenDetectShapeCircle> ScreenDetectLimitOffset = default(Offset<IInteractScreenDetectShapeCircle>), VectorOffset RangesByTagsOffset = default(VectorOffset), EDoInteract DoIntactType = EDoInteract.Direct, Offset<IInteractSectorRange> SectorRangeOffset = default(Offset<IInteractSectorRange>), TInteractPlayerDiractionOption SectorRangeFromPlayerToEntity_type = TInteractPlayerDiractionOption.NONE, int SectorRangeFromPlayerToEntityOffset = 0, VectorOffset OptionsOffset = default(VectorOffset), Offset<IRandomInteract> RandomInteractOffset = default(Offset<IRandomInteract>), EInteractDefaultIcon InteractDefaultIcon = EInteractDefaultIcon.Collect, EInteractIcon InteractIcon = EInteractIcon.Dialog, EInteractTurnAround TurnAroundType = EInteractTurnAround.FaceEachOther, bool IsWaitForTurnAroundComplete = false, bool IsWaitForInteractComplete = false, Offset<IPlayFlow> PreFlowOffset = default(Offset<IPlayFlow>), StringOffset TidContentOffset = default(StringOffset), Offset<IVectorInfo> InteractPointOffsetOffset = default(Offset<IVectorInfo>), VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), Offset<IFishingPointAdditionalInfo> InteractAdditionalInfoOffset = default(Offset<IFishingPointAdditionalInfo>), Offset<IInteractPointIconConfig> PointIconConfigOffset = default(Offset<IInteractPointIconConfig>), Offset<IInteractCameraOffsetConfig> InteractCameraOffsetConfigOffset = default(Offset<IInteractCameraOffsetConfig>), TInteractStyle InteractStyleType_type = TInteractStyle.NONE, int InteractStyleTypeOffset = 0, EInterruptMontageType InterruptMontageType = EInterruptMontageType.InterruptAtEnd, bool NotInterruptPlotModeLevelD = false, ushort NullMask = 0)
		{
			builder.StartTable(31);
			IInteractComponent.AddInteractStyleType(builder, InteractStyleTypeOffset);
			IInteractComponent.AddInteractCameraOffsetConfig(builder, InteractCameraOffsetConfigOffset);
			IInteractComponent.AddPointIconConfig(builder, PointIconConfigOffset);
			IInteractComponent.AddInteractAdditionalInfo(builder, InteractAdditionalInfoOffset);
			IInteractComponent.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IInteractComponent.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IInteractComponent.AddInteractPointOffset(builder, InteractPointOffsetOffset);
			IInteractComponent.AddTidContent(builder, TidContentOffset);
			IInteractComponent.AddPreFlow(builder, PreFlowOffset);
			IInteractComponent.AddRandomInteract(builder, RandomInteractOffset);
			IInteractComponent.AddOptions(builder, OptionsOffset);
			IInteractComponent.AddSectorRangeFromPlayerToEntity(builder, SectorRangeFromPlayerToEntityOffset);
			IInteractComponent.AddSectorRange(builder, SectorRangeOffset);
			IInteractComponent.AddRangesByTags(builder, RangesByTagsOffset);
			IInteractComponent.AddScreenDetectLimit(builder, ScreenDetectLimitOffset);
			IInteractComponent.AddForbiddenRange(builder, ForbiddenRange);
			IInteractComponent.AddExitRange(builder, ExitRange);
			IInteractComponent.AddRange(builder, Range);
			IInteractComponent.AddQuestIds(builder, QuestIdsOffset);
			IInteractComponent.AddNullMask(builder, NullMask);
			IInteractComponent.AddNotInterruptPlotModeLevelD(builder, NotInterruptPlotModeLevelD);
			IInteractComponent.AddInterruptMontageType(builder, InterruptMontageType);
			IInteractComponent.AddInteractStyleTypeType(builder, InteractStyleType_type);
			IInteractComponent.AddIsWaitForInteractComplete(builder, IsWaitForInteractComplete);
			IInteractComponent.AddIsWaitForTurnAroundComplete(builder, IsWaitForTurnAroundComplete);
			IInteractComponent.AddTurnAroundType(builder, TurnAroundType);
			IInteractComponent.AddInteractIcon(builder, InteractIcon);
			IInteractComponent.AddInteractDefaultIcon(builder, InteractDefaultIcon);
			IInteractComponent.AddSectorRangeFromPlayerToEntityType(builder, SectorRangeFromPlayerToEntity_type);
			IInteractComponent.AddDoIntactType(builder, DoIntactType);
			IInteractComponent.AddDisabled(builder, Disabled);
			return IInteractComponent.EndIInteractComponent(builder);
		}

		// Token: 0x060257DE RID: 153566 RVA: 0x00524988 File Offset: 0x00522B88
		public static void StartIInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(31);
		}

		// Token: 0x060257DF RID: 153567 RVA: 0x00524992 File Offset: 0x00522B92
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060257E0 RID: 153568 RVA: 0x0052499D File Offset: 0x00522B9D
		public static void AddQuestIds(FlatBufferBuilder builder, VectorOffset questIdsOffset)
		{
			builder.AddOffset(1, questIdsOffset.Value, 0);
		}

		// Token: 0x060257E1 RID: 153569 RVA: 0x005249B0 File Offset: 0x00522BB0
		public static VectorOffset CreateQuestIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060257E2 RID: 153570 RVA: 0x005249E7 File Offset: 0x00522BE7
		public static VectorOffset CreateQuestIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060257E3 RID: 153571 RVA: 0x00524A01 File Offset: 0x00522C01
		public static VectorOffset CreateQuestIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060257E4 RID: 153572 RVA: 0x00524A1F File Offset: 0x00522C1F
		public static VectorOffset CreateQuestIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060257E5 RID: 153573 RVA: 0x00524A38 File Offset: 0x00522C38
		public static void StartQuestIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060257E6 RID: 153574 RVA: 0x00524A43 File Offset: 0x00522C43
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(2, range, 0.0);
		}

		// Token: 0x060257E7 RID: 153575 RVA: 0x00524A56 File Offset: 0x00522C56
		public static void AddExitRange(FlatBufferBuilder builder, float exitRange)
		{
			builder.AddFloat(3, exitRange, 0.0);
		}

		// Token: 0x060257E8 RID: 153576 RVA: 0x00524A69 File Offset: 0x00522C69
		public static void AddForbiddenRange(FlatBufferBuilder builder, float forbiddenRange)
		{
			builder.AddFloat(4, forbiddenRange, 0.0);
		}

		// Token: 0x060257E9 RID: 153577 RVA: 0x00524A7C File Offset: 0x00522C7C
		public static void AddScreenDetectLimit(FlatBufferBuilder builder, Offset<IInteractScreenDetectShapeCircle> screenDetectLimitOffset)
		{
			builder.AddOffset(5, screenDetectLimitOffset.Value, 0);
		}

		// Token: 0x060257EA RID: 153578 RVA: 0x00524A8C File Offset: 0x00522C8C
		public static void AddRangesByTags(FlatBufferBuilder builder, VectorOffset rangesByTagsOffset)
		{
			builder.AddOffset(6, rangesByTagsOffset.Value, 0);
		}

		// Token: 0x060257EB RID: 153579 RVA: 0x00524A9C File Offset: 0x00522C9C
		public static VectorOffset CreateRangesByTagsVector(FlatBufferBuilder builder, Offset<IRangeByTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060257EC RID: 153580 RVA: 0x00524ADC File Offset: 0x00522CDC
		public static VectorOffset CreateRangesByTagsVectorBlock(FlatBufferBuilder builder, Offset<IRangeByTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRangeByTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x060257ED RID: 153581 RVA: 0x00524AF6 File Offset: 0x00522CF6
		public static VectorOffset CreateRangesByTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRangeByTag>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRangeByTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x060257EE RID: 153582 RVA: 0x00524B14 File Offset: 0x00522D14
		public static VectorOffset CreateRangesByTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRangeByTag>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060257EF RID: 153583 RVA: 0x00524B2D File Offset: 0x00522D2D
		public static void StartRangesByTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060257F0 RID: 153584 RVA: 0x00524B38 File Offset: 0x00522D38
		public static void AddDoIntactType(FlatBufferBuilder builder, EDoInteract doIntactType)
		{
			builder.AddByte(7, (byte)doIntactType, 0);
		}

		// Token: 0x060257F1 RID: 153585 RVA: 0x00524B43 File Offset: 0x00522D43
		public static void AddSectorRange(FlatBufferBuilder builder, Offset<IInteractSectorRange> sectorRangeOffset)
		{
			builder.AddOffset(8, sectorRangeOffset.Value, 0);
		}

		// Token: 0x060257F2 RID: 153586 RVA: 0x00524B53 File Offset: 0x00522D53
		public static void AddSectorRangeFromPlayerToEntityType(FlatBufferBuilder builder, TInteractPlayerDiractionOption sectorRangeFromPlayerToEntityType)
		{
			builder.AddByte(9, (byte)sectorRangeFromPlayerToEntityType, 0);
		}

		// Token: 0x060257F3 RID: 153587 RVA: 0x00524B5F File Offset: 0x00522D5F
		public static void AddSectorRangeFromPlayerToEntity(FlatBufferBuilder builder, int sectorRangeFromPlayerToEntityOffset)
		{
			builder.AddOffset(10, sectorRangeFromPlayerToEntityOffset, 0);
		}

		// Token: 0x060257F4 RID: 153588 RVA: 0x00524B6B File Offset: 0x00522D6B
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(11, optionsOffset.Value, 0);
		}

		// Token: 0x060257F5 RID: 153589 RVA: 0x00524B7C File Offset: 0x00522D7C
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<IInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060257F6 RID: 153590 RVA: 0x00524BBC File Offset: 0x00522DBC
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<IInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060257F7 RID: 153591 RVA: 0x00524BD6 File Offset: 0x00522DD6
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInteractOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060257F8 RID: 153592 RVA: 0x00524BF4 File Offset: 0x00522DF4
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInteractOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060257F9 RID: 153593 RVA: 0x00524C0D File Offset: 0x00522E0D
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060257FA RID: 153594 RVA: 0x00524C18 File Offset: 0x00522E18
		public static void AddRandomInteract(FlatBufferBuilder builder, Offset<IRandomInteract> randomInteractOffset)
		{
			builder.AddOffset(12, randomInteractOffset.Value, 0);
		}

		// Token: 0x060257FB RID: 153595 RVA: 0x00524C29 File Offset: 0x00522E29
		public static void AddInteractDefaultIcon(FlatBufferBuilder builder, EInteractDefaultIcon interactDefaultIcon)
		{
			builder.AddByte(13, (byte)interactDefaultIcon, 0);
		}

		// Token: 0x060257FC RID: 153596 RVA: 0x00524C35 File Offset: 0x00522E35
		public static void AddInteractIcon(FlatBufferBuilder builder, EInteractIcon interactIcon)
		{
			builder.AddByte(14, (byte)interactIcon, 0);
		}

		// Token: 0x060257FD RID: 153597 RVA: 0x00524C41 File Offset: 0x00522E41
		public static void AddTurnAroundType(FlatBufferBuilder builder, EInteractTurnAround turnAroundType)
		{
			builder.AddByte(15, (byte)turnAroundType, 0);
		}

		// Token: 0x060257FE RID: 153598 RVA: 0x00524C4D File Offset: 0x00522E4D
		public static void AddIsWaitForTurnAroundComplete(FlatBufferBuilder builder, bool isWaitForTurnAroundComplete)
		{
			builder.AddBool(16, isWaitForTurnAroundComplete, false);
		}

		// Token: 0x060257FF RID: 153599 RVA: 0x00524C59 File Offset: 0x00522E59
		public static void AddIsWaitForInteractComplete(FlatBufferBuilder builder, bool isWaitForInteractComplete)
		{
			builder.AddBool(17, isWaitForInteractComplete, false);
		}

		// Token: 0x06025800 RID: 153600 RVA: 0x00524C65 File Offset: 0x00522E65
		public static void AddPreFlow(FlatBufferBuilder builder, Offset<IPlayFlow> preFlowOffset)
		{
			builder.AddOffset(18, preFlowOffset.Value, 0);
		}

		// Token: 0x06025801 RID: 153601 RVA: 0x00524C76 File Offset: 0x00522E76
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(19, tidContentOffset.Value, 0);
		}

		// Token: 0x06025802 RID: 153602 RVA: 0x00524C87 File Offset: 0x00522E87
		public static void AddInteractPointOffset(FlatBufferBuilder builder, Offset<IVectorInfo> interactPointOffsetOffset)
		{
			builder.AddOffset(20, interactPointOffsetOffset.Value, 0);
		}

		// Token: 0x06025803 RID: 153603 RVA: 0x00524C98 File Offset: 0x00522E98
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(21, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06025804 RID: 153604 RVA: 0x00524CAC File Offset: 0x00522EAC
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06025805 RID: 153605 RVA: 0x00524CE3 File Offset: 0x00522EE3
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06025806 RID: 153606 RVA: 0x00524CFD File Offset: 0x00522EFD
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06025807 RID: 153607 RVA: 0x00524D1B File Offset: 0x00522F1B
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025808 RID: 153608 RVA: 0x00524D34 File Offset: 0x00522F34
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06025809 RID: 153609 RVA: 0x00524D3F File Offset: 0x00522F3F
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(22, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x0602580A RID: 153610 RVA: 0x00524D50 File Offset: 0x00522F50
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602580B RID: 153611 RVA: 0x00524D87 File Offset: 0x00522F87
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602580C RID: 153612 RVA: 0x00524DA1 File Offset: 0x00522FA1
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602580D RID: 153613 RVA: 0x00524DBF File Offset: 0x00522FBF
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602580E RID: 153614 RVA: 0x00524DD8 File Offset: 0x00522FD8
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602580F RID: 153615 RVA: 0x00524DE3 File Offset: 0x00522FE3
		public static void AddInteractAdditionalInfo(FlatBufferBuilder builder, Offset<IFishingPointAdditionalInfo> interactAdditionalInfoOffset)
		{
			builder.AddOffset(23, interactAdditionalInfoOffset.Value, 0);
		}

		// Token: 0x06025810 RID: 153616 RVA: 0x00524DF4 File Offset: 0x00522FF4
		public static void AddPointIconConfig(FlatBufferBuilder builder, Offset<IInteractPointIconConfig> pointIconConfigOffset)
		{
			builder.AddOffset(24, pointIconConfigOffset.Value, 0);
		}

		// Token: 0x06025811 RID: 153617 RVA: 0x00524E05 File Offset: 0x00523005
		public static void AddInteractCameraOffsetConfig(FlatBufferBuilder builder, Offset<IInteractCameraOffsetConfig> interactCameraOffsetConfigOffset)
		{
			builder.AddOffset(25, interactCameraOffsetConfigOffset.Value, 0);
		}

		// Token: 0x06025812 RID: 153618 RVA: 0x00524E16 File Offset: 0x00523016
		public static void AddInteractStyleTypeType(FlatBufferBuilder builder, TInteractStyle interactStyleTypeType)
		{
			builder.AddByte(26, (byte)interactStyleTypeType, 0);
		}

		// Token: 0x06025813 RID: 153619 RVA: 0x00524E22 File Offset: 0x00523022
		public static void AddInteractStyleType(FlatBufferBuilder builder, int interactStyleTypeOffset)
		{
			builder.AddOffset(27, interactStyleTypeOffset, 0);
		}

		// Token: 0x06025814 RID: 153620 RVA: 0x00524E2E File Offset: 0x0052302E
		public static void AddInterruptMontageType(FlatBufferBuilder builder, EInterruptMontageType interruptMontageType)
		{
			builder.AddByte(28, (byte)interruptMontageType, 0);
		}

		// Token: 0x06025815 RID: 153621 RVA: 0x00524E3A File Offset: 0x0052303A
		public static void AddNotInterruptPlotModeLevelD(FlatBufferBuilder builder, bool notInterruptPlotModeLevelD)
		{
			builder.AddBool(29, notInterruptPlotModeLevelD, false);
		}

		// Token: 0x06025816 RID: 153622 RVA: 0x00524E46 File Offset: 0x00523046
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(30, nullMask, 0);
		}

		// Token: 0x06025817 RID: 153623 RVA: 0x00524E52 File Offset: 0x00523052
		public static Offset<IInteractComponent> EndIInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInteractComponent>(builder.EndTable());
		}

		// Token: 0x06025818 RID: 153624 RVA: 0x00524E60 File Offset: 0x00523060
		public IInteractComponentT UnPack()
		{
			IInteractComponentT interactComponentT = new IInteractComponentT();
			this.UnPackTo(interactComponentT);
			return interactComponentT;
		}

		// Token: 0x06025819 RID: 153625 RVA: 0x00524E7C File Offset: 0x0052307C
		public void UnPackTo(IInteractComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.QuestIds = new List<int>();
			for (int i = 0; i < this.QuestIdsLength; i++)
			{
				_o.QuestIds.Add(this.QuestIds(i));
			}
			_o.Range = this.Range;
			_o.ExitRange = this.ExitRange;
			_o.ForbiddenRange = this.ForbiddenRange;
			_o.ScreenDetectLimit = ((this.ScreenDetectLimit != null) ? this.ScreenDetectLimit.Value.UnPack() : null);
			_o.RangesByTags = new List<IRangeByTagT>();
			for (int j = 0; j < this.RangesByTagsLength; j++)
			{
				_o.RangesByTags.Add((this.RangesByTags(j) != null) ? this.RangesByTags(j).Value.UnPack() : null);
			}
			_o.DoIntactType = this.DoIntactType;
			_o.SectorRange = ((this.SectorRange != null) ? this.SectorRange.Value.UnPack() : null);
			_o.SectorRangeFromPlayerToEntity = new TInteractPlayerDiractionOptionUnion();
			_o.SectorRangeFromPlayerToEntity.Type = this.SectorRangeFromPlayerToEntityType;
			TInteractPlayerDiractionOption sectorRangeFromPlayerToEntityType = this.SectorRangeFromPlayerToEntityType;
			if (sectorRangeFromPlayerToEntityType != TInteractPlayerDiractionOption.IInteractPlayerDiractionToLeisure)
			{
				if (sectorRangeFromPlayerToEntityType == TInteractPlayerDiractionOption.IInteractPlayerDiractionToNpc)
				{
					_o.SectorRangeFromPlayerToEntity.Value = ((this.SectorRangeFromPlayerToEntity<IInteractPlayerDiractionToNpc>() != null) ? this.SectorRangeFromPlayerToEntity<IInteractPlayerDiractionToNpc>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SectorRangeFromPlayerToEntity.Value = ((this.SectorRangeFromPlayerToEntity<IInteractPlayerDiractionToLeisure>() != null) ? this.SectorRangeFromPlayerToEntity<IInteractPlayerDiractionToLeisure>().Value.UnPack() : null);
			}
			_o.Options = new List<IInteractOptionT>();
			for (int k = 0; k < this.OptionsLength; k++)
			{
				_o.Options.Add((this.Options(k) != null) ? this.Options(k).Value.UnPack() : null);
			}
			_o.RandomInteract = ((this.RandomInteract != null) ? this.RandomInteract.Value.UnPack() : null);
			_o.InteractDefaultIcon = this.InteractDefaultIcon;
			_o.InteractIcon = this.InteractIcon;
			_o.TurnAroundType = this.TurnAroundType;
			_o.IsWaitForTurnAroundComplete = this.IsWaitForTurnAroundComplete;
			_o.IsWaitForInteractComplete = this.IsWaitForInteractComplete;
			_o.PreFlow = ((this.PreFlow != null) ? this.PreFlow.Value.UnPack() : null);
			_o.TidContent = this.TidContent;
			_o.InteractPointOffset = ((this.InteractPointOffset != null) ? this.InteractPointOffset.Value.UnPack() : null);
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int l = 0; l < this.MatchRoleOptionLength; l++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(l);
				switch (this.MatchRoleOptionType(l))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(l) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(l).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(l) != null) ? this.MatchRoleOption<IMatchPhantomRole>(l).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(l) != null) ? this.MatchRoleOption<IMatchPlayerRole>(l).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.InteractAdditionalInfo = ((this.InteractAdditionalInfo != null) ? this.InteractAdditionalInfo.Value.UnPack() : null);
			_o.PointIconConfig = ((this.PointIconConfig != null) ? this.PointIconConfig.Value.UnPack() : null);
			_o.InteractCameraOffsetConfig = ((this.InteractCameraOffsetConfig != null) ? this.InteractCameraOffsetConfig.Value.UnPack() : null);
			_o.InteractStyleType = new TInteractStyleUnion();
			_o.InteractStyleType.Type = this.InteractStyleTypeType;
			TInteractStyle interactStyleTypeType = this.InteractStyleTypeType;
			if (interactStyleTypeType != TInteractStyle.IInteractStyleEntityPart)
			{
				if (interactStyleTypeType == TInteractStyle.IInteractStylePanorama)
				{
					_o.InteractStyleType.Value = ((this.InteractStyleType<IInteractStylePanorama>() != null) ? this.InteractStyleType<IInteractStylePanorama>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.InteractStyleType.Value = ((this.InteractStyleType<IInteractStyleEntityPart>() != null) ? this.InteractStyleType<IInteractStyleEntityPart>().Value.UnPack() : null);
			}
			_o.InterruptMontageType = this.InterruptMontageType;
			_o.NotInterruptPlotModeLevelD = this.NotInterruptPlotModeLevelD;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602581A RID: 153626 RVA: 0x005253F4 File Offset: 0x005235F4
		public static Offset<IInteractComponent> Pack(FlatBufferBuilder builder, IInteractComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractComponent>);
			}
			VectorOffset questIdsOffset = default(VectorOffset);
			if (_o.QuestIds != null)
			{
				int[] data = _o.QuestIds.ToArray();
				questIdsOffset = IInteractComponent.CreateQuestIdsVector(builder, data);
			}
			Offset<IInteractScreenDetectShapeCircle> screenDetectLimitOffset = (_o.ScreenDetectLimit == null) ? default(Offset<IInteractScreenDetectShapeCircle>) : IInteractScreenDetectShapeCircle.Pack(builder, _o.ScreenDetectLimit);
			VectorOffset rangesByTagsOffset = default(VectorOffset);
			if (_o.RangesByTags != null)
			{
				Offset<IRangeByTag>[] array = new Offset<IRangeByTag>[_o.RangesByTags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRangeByTag.Pack(builder, _o.RangesByTags[i]);
				}
				rangesByTagsOffset = IInteractComponent.CreateRangesByTagsVector(builder, array);
			}
			Offset<IInteractSectorRange> sectorRangeOffset = (_o.SectorRange == null) ? default(Offset<IInteractSectorRange>) : IInteractSectorRange.Pack(builder, _o.SectorRange);
			TInteractPlayerDiractionOption sectorRangeFromPlayerToEntity_type = (_o.SectorRangeFromPlayerToEntity == null) ? TInteractPlayerDiractionOption.NONE : _o.SectorRangeFromPlayerToEntity.Type;
			int sectorRangeFromPlayerToEntityOffset = (_o.SectorRangeFromPlayerToEntity == null) ? 0 : TInteractPlayerDiractionOptionUnion.Pack(builder, _o.SectorRangeFromPlayerToEntity);
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<IInteractOption>[] array2 = new Offset<IInteractOption>[_o.Options.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IInteractOption.Pack(builder, _o.Options[j]);
				}
				optionsOffset = IInteractComponent.CreateOptionsVector(builder, array2);
			}
			Offset<IRandomInteract> randomInteractOffset = (_o.RandomInteract == null) ? default(Offset<IRandomInteract>) : IRandomInteract.Pack(builder, _o.RandomInteract);
			Offset<IPlayFlow> preFlowOffset = (_o.PreFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.PreFlow);
			StringOffset tidContentOffset = (_o.TidContent == null) ? default(StringOffset) : builder.CreateString(_o.TidContent);
			Offset<IVectorInfo> interactPointOffsetOffset = (_o.InteractPointOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.InteractPointOffset);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array3 = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.MatchRoleOption[k].Type;
				}
				matchRoleOption_typeOffset = IInteractComponent.CreateMatchRoleOptionTypeVector(builder, array3);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array4 = new int[_o.MatchRoleOption.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[l]);
				}
				matchRoleOptionOffset = IInteractComponent.CreateMatchRoleOptionVector(builder, array4);
			}
			Offset<IFishingPointAdditionalInfo> interactAdditionalInfoOffset = (_o.InteractAdditionalInfo == null) ? default(Offset<IFishingPointAdditionalInfo>) : IFishingPointAdditionalInfo.Pack(builder, _o.InteractAdditionalInfo);
			Offset<IInteractPointIconConfig> pointIconConfigOffset = (_o.PointIconConfig == null) ? default(Offset<IInteractPointIconConfig>) : IInteractPointIconConfig.Pack(builder, _o.PointIconConfig);
			Offset<IInteractCameraOffsetConfig> interactCameraOffsetConfigOffset = (_o.InteractCameraOffsetConfig == null) ? default(Offset<IInteractCameraOffsetConfig>) : IInteractCameraOffsetConfig.Pack(builder, _o.InteractCameraOffsetConfig);
			TInteractStyle interactStyleType_type = (_o.InteractStyleType == null) ? TInteractStyle.NONE : _o.InteractStyleType.Type;
			int interactStyleTypeOffset = (_o.InteractStyleType == null) ? 0 : TInteractStyleUnion.Pack(builder, _o.InteractStyleType);
			return IInteractComponent.CreateIInteractComponent(builder, _o.Disabled, questIdsOffset, _o.Range, _o.ExitRange, _o.ForbiddenRange, screenDetectLimitOffset, rangesByTagsOffset, _o.DoIntactType, sectorRangeOffset, sectorRangeFromPlayerToEntity_type, sectorRangeFromPlayerToEntityOffset, optionsOffset, randomInteractOffset, _o.InteractDefaultIcon, _o.InteractIcon, _o.TurnAroundType, _o.IsWaitForTurnAroundComplete, _o.IsWaitForInteractComplete, preFlowOffset, tidContentOffset, interactPointOffsetOffset, matchRoleOption_typeOffset, matchRoleOptionOffset, interactAdditionalInfoOffset, pointIconConfigOffset, interactCameraOffsetConfigOffset, interactStyleType_type, interactStyleTypeOffset, _o.InterruptMontageType, _o.NotInterruptPlotModeLevelD, _o.NullMask);
		}

		// Token: 0x0400F2C9 RID: 62153
		private Table __p;
	}
}
