using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005440 RID: 21568
	public struct IInteractComponent : IFlatbufferObject
	{
		// Token: 0x17009E9E RID: 40606
		// (get) Token: 0x060236F1 RID: 145137 RVA: 0x004E6CBC File Offset: 0x004E4EBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060236F2 RID: 145138 RVA: 0x004E6CC9 File Offset: 0x004E4EC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060236F3 RID: 145139 RVA: 0x004E6CD0 File Offset: 0x004E4ED0
		public static IInteractComponent GetRootAsIInteractComponent(ByteBuffer _bb)
		{
			return IInteractComponent.GetRootAsIInteractComponent(_bb, default(IInteractComponent));
		}

		// Token: 0x060236F4 RID: 145140 RVA: 0x004E6CEC File Offset: 0x004E4EEC
		public static IInteractComponent GetRootAsIInteractComponent(ByteBuffer _bb, IInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060236F5 RID: 145141 RVA: 0x004E6D09 File Offset: 0x004E4F09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060236F6 RID: 145142 RVA: 0x004E6D18 File Offset: 0x004E4F18
		public IInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E9F RID: 40607
		// (get) Token: 0x060236F7 RID: 145143 RVA: 0x004E6D28 File Offset: 0x004E4F28
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060236F8 RID: 145144 RVA: 0x004E6D68 File Offset: 0x004E4F68
		public int QuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009EA0 RID: 40608
		// (get) Token: 0x060236F9 RID: 145145 RVA: 0x004E6DA8 File Offset: 0x004E4FA8
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

		// Token: 0x060236FA RID: 145146 RVA: 0x004E6DD3 File Offset: 0x004E4FD3
		public Span<int> GetQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060236FB RID: 145147 RVA: 0x004E6DE2 File Offset: 0x004E4FE2
		public int[] GetQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009EA1 RID: 40609
		// (get) Token: 0x060236FC RID: 145148 RVA: 0x004E6DF0 File Offset: 0x004E4FF0
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

		// Token: 0x17009EA2 RID: 40610
		// (get) Token: 0x060236FD RID: 145149 RVA: 0x004E6E30 File Offset: 0x004E5030
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

		// Token: 0x17009EA3 RID: 40611
		// (get) Token: 0x060236FE RID: 145150 RVA: 0x004E6E74 File Offset: 0x004E5074
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

		// Token: 0x17009EA4 RID: 40612
		// (get) Token: 0x060236FF RID: 145151 RVA: 0x004E6EB8 File Offset: 0x004E50B8
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

		// Token: 0x06023700 RID: 145152 RVA: 0x004E6F18 File Offset: 0x004E5118
		public IRangeByTag? RangesByTags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IRangeByTag?(default(IRangeByTag).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009EA5 RID: 40613
		// (get) Token: 0x06023701 RID: 145153 RVA: 0x004E6F7C File Offset: 0x004E517C
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

		// Token: 0x17009EA6 RID: 40614
		// (get) Token: 0x06023702 RID: 145154 RVA: 0x004E6FA8 File Offset: 0x004E51A8
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

		// Token: 0x17009EA7 RID: 40615
		// (get) Token: 0x06023703 RID: 145155 RVA: 0x004E6FE8 File Offset: 0x004E51E8
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

		// Token: 0x17009EA8 RID: 40616
		// (get) Token: 0x06023704 RID: 145156 RVA: 0x004E7048 File Offset: 0x004E5248
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

		// Token: 0x06023705 RID: 145157 RVA: 0x004E7088 File Offset: 0x004E5288
		public TTable? SectorRangeFromPlayerToEntity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023706 RID: 145158 RVA: 0x004E70D0 File Offset: 0x004E52D0
		public IInteractPlayerDiractionToLeisure SectorRangeFromPlayerToEntityAsIInteractPlayerDiractionToLeisure()
		{
			return this.SectorRangeFromPlayerToEntity<IInteractPlayerDiractionToLeisure>().Value;
		}

		// Token: 0x06023707 RID: 145159 RVA: 0x004E70EC File Offset: 0x004E52EC
		public IInteractPlayerDiractionToNpc SectorRangeFromPlayerToEntityAsIInteractPlayerDiractionToNpc()
		{
			return this.SectorRangeFromPlayerToEntity<IInteractPlayerDiractionToNpc>().Value;
		}

		// Token: 0x06023708 RID: 145160 RVA: 0x004E7108 File Offset: 0x004E5308
		public IInteractOption? Options(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IInteractOption?(default(IInteractOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009EA9 RID: 40617
		// (get) Token: 0x06023709 RID: 145161 RVA: 0x004E716C File Offset: 0x004E536C
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

		// Token: 0x17009EAA RID: 40618
		// (get) Token: 0x0602370A RID: 145162 RVA: 0x004E7198 File Offset: 0x004E5398
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

		// Token: 0x17009EAB RID: 40619
		// (get) Token: 0x0602370B RID: 145163 RVA: 0x004E71F8 File Offset: 0x004E53F8
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

		// Token: 0x17009EAC RID: 40620
		// (get) Token: 0x0602370C RID: 145164 RVA: 0x004E7238 File Offset: 0x004E5438
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

		// Token: 0x17009EAD RID: 40621
		// (get) Token: 0x0602370D RID: 145165 RVA: 0x004E7278 File Offset: 0x004E5478
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

		// Token: 0x17009EAE RID: 40622
		// (get) Token: 0x0602370E RID: 145166 RVA: 0x004E72B8 File Offset: 0x004E54B8
		public bool IsWaitForTurnAroundComplete
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009EAF RID: 40623
		// (get) Token: 0x0602370F RID: 145167 RVA: 0x004E72F8 File Offset: 0x004E54F8
		public bool IsWaitForInteractComplete
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009EB0 RID: 40624
		// (get) Token: 0x06023710 RID: 145168 RVA: 0x004E7338 File Offset: 0x004E5538
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

		// Token: 0x17009EB1 RID: 40625
		// (get) Token: 0x06023711 RID: 145169 RVA: 0x004E7398 File Offset: 0x004E5598
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

		// Token: 0x06023712 RID: 145170 RVA: 0x004E73D0 File Offset: 0x004E55D0
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06023713 RID: 145171 RVA: 0x004E73E0 File Offset: 0x004E55E0
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(42);
		}

		// Token: 0x17009EB2 RID: 40626
		// (get) Token: 0x06023714 RID: 145172 RVA: 0x004E73F0 File Offset: 0x004E55F0
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

		// Token: 0x06023715 RID: 145173 RVA: 0x004E7450 File Offset: 0x004E5650
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009EB3 RID: 40627
		// (get) Token: 0x06023716 RID: 145174 RVA: 0x004E7490 File Offset: 0x004E5690
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

		// Token: 0x06023717 RID: 145175 RVA: 0x004E74BC File Offset: 0x004E56BC
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(46, 1);
		}

		// Token: 0x06023718 RID: 145176 RVA: 0x004E74CC File Offset: 0x004E56CC
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

		// Token: 0x06023719 RID: 145177 RVA: 0x004E7538 File Offset: 0x004E5738
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009EB4 RID: 40628
		// (get) Token: 0x0602371A RID: 145178 RVA: 0x004E7580 File Offset: 0x004E5780
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

		// Token: 0x17009EB5 RID: 40629
		// (get) Token: 0x0602371B RID: 145179 RVA: 0x004E75AC File Offset: 0x004E57AC
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

		// Token: 0x17009EB6 RID: 40630
		// (get) Token: 0x0602371C RID: 145180 RVA: 0x004E760C File Offset: 0x004E580C
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

		// Token: 0x17009EB7 RID: 40631
		// (get) Token: 0x0602371D RID: 145181 RVA: 0x004E766C File Offset: 0x004E586C
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

		// Token: 0x17009EB8 RID: 40632
		// (get) Token: 0x0602371E RID: 145182 RVA: 0x004E76CC File Offset: 0x004E58CC
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

		// Token: 0x0602371F RID: 145183 RVA: 0x004E770C File Offset: 0x004E590C
		public TTable? InteractStyleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023720 RID: 145184 RVA: 0x004E7754 File Offset: 0x004E5954
		public IInteractStyleEntityPart InteractStyleTypeAsIInteractStyleEntityPart()
		{
			return this.InteractStyleType<IInteractStyleEntityPart>().Value;
		}

		// Token: 0x06023721 RID: 145185 RVA: 0x004E7770 File Offset: 0x004E5970
		public IInteractStylePanorama InteractStyleTypeAsIInteractStylePanorama()
		{
			return this.InteractStyleType<IInteractStylePanorama>().Value;
		}

		// Token: 0x17009EB9 RID: 40633
		// (get) Token: 0x06023722 RID: 145186 RVA: 0x004E778C File Offset: 0x004E598C
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

		// Token: 0x17009EBA RID: 40634
		// (get) Token: 0x06023723 RID: 145187 RVA: 0x004E77CC File Offset: 0x004E59CC
		public bool NotInterruptPlotModeLevelD
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009EBB RID: 40635
		// (get) Token: 0x06023724 RID: 145188 RVA: 0x004E780C File Offset: 0x004E5A0C
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

		// Token: 0x06023725 RID: 145189 RVA: 0x004E784C File Offset: 0x004E5A4C
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

		// Token: 0x06023726 RID: 145190 RVA: 0x004E795C File Offset: 0x004E5B5C
		public static void StartIInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(31);
		}

		// Token: 0x06023727 RID: 145191 RVA: 0x004E7966 File Offset: 0x004E5B66
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023728 RID: 145192 RVA: 0x004E7971 File Offset: 0x004E5B71
		public static void AddQuestIds(FlatBufferBuilder builder, VectorOffset questIdsOffset)
		{
			builder.AddOffset(1, questIdsOffset.Value, 0);
		}

		// Token: 0x06023729 RID: 145193 RVA: 0x004E7984 File Offset: 0x004E5B84
		public static VectorOffset CreateQuestIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602372A RID: 145194 RVA: 0x004E79BB File Offset: 0x004E5BBB
		public static VectorOffset CreateQuestIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602372B RID: 145195 RVA: 0x004E79D5 File Offset: 0x004E5BD5
		public static VectorOffset CreateQuestIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602372C RID: 145196 RVA: 0x004E79F3 File Offset: 0x004E5BF3
		public static VectorOffset CreateQuestIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602372D RID: 145197 RVA: 0x004E7A0C File Offset: 0x004E5C0C
		public static void StartQuestIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602372E RID: 145198 RVA: 0x004E7A17 File Offset: 0x004E5C17
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(2, range, 0.0);
		}

		// Token: 0x0602372F RID: 145199 RVA: 0x004E7A2A File Offset: 0x004E5C2A
		public static void AddExitRange(FlatBufferBuilder builder, float exitRange)
		{
			builder.AddFloat(3, exitRange, 0.0);
		}

		// Token: 0x06023730 RID: 145200 RVA: 0x004E7A3D File Offset: 0x004E5C3D
		public static void AddForbiddenRange(FlatBufferBuilder builder, float forbiddenRange)
		{
			builder.AddFloat(4, forbiddenRange, 0.0);
		}

		// Token: 0x06023731 RID: 145201 RVA: 0x004E7A50 File Offset: 0x004E5C50
		public static void AddScreenDetectLimit(FlatBufferBuilder builder, Offset<IInteractScreenDetectShapeCircle> screenDetectLimitOffset)
		{
			builder.AddOffset(5, screenDetectLimitOffset.Value, 0);
		}

		// Token: 0x06023732 RID: 145202 RVA: 0x004E7A60 File Offset: 0x004E5C60
		public static void AddRangesByTags(FlatBufferBuilder builder, VectorOffset rangesByTagsOffset)
		{
			builder.AddOffset(6, rangesByTagsOffset.Value, 0);
		}

		// Token: 0x06023733 RID: 145203 RVA: 0x004E7A70 File Offset: 0x004E5C70
		public static VectorOffset CreateRangesByTagsVector(FlatBufferBuilder builder, Offset<IRangeByTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023734 RID: 145204 RVA: 0x004E7AB0 File Offset: 0x004E5CB0
		public static VectorOffset CreateRangesByTagsVectorBlock(FlatBufferBuilder builder, Offset<IRangeByTag>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRangeByTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023735 RID: 145205 RVA: 0x004E7ACA File Offset: 0x004E5CCA
		public static VectorOffset CreateRangesByTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRangeByTag>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRangeByTag>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023736 RID: 145206 RVA: 0x004E7AE8 File Offset: 0x004E5CE8
		public static VectorOffset CreateRangesByTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRangeByTag>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023737 RID: 145207 RVA: 0x004E7B01 File Offset: 0x004E5D01
		public static void StartRangesByTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023738 RID: 145208 RVA: 0x004E7B0C File Offset: 0x004E5D0C
		public static void AddDoIntactType(FlatBufferBuilder builder, EDoInteract doIntactType)
		{
			builder.AddByte(7, (byte)doIntactType, 0);
		}

		// Token: 0x06023739 RID: 145209 RVA: 0x004E7B17 File Offset: 0x004E5D17
		public static void AddSectorRange(FlatBufferBuilder builder, Offset<IInteractSectorRange> sectorRangeOffset)
		{
			builder.AddOffset(8, sectorRangeOffset.Value, 0);
		}

		// Token: 0x0602373A RID: 145210 RVA: 0x004E7B27 File Offset: 0x004E5D27
		public static void AddSectorRangeFromPlayerToEntityType(FlatBufferBuilder builder, TInteractPlayerDiractionOption sectorRangeFromPlayerToEntityType)
		{
			builder.AddByte(9, (byte)sectorRangeFromPlayerToEntityType, 0);
		}

		// Token: 0x0602373B RID: 145211 RVA: 0x004E7B33 File Offset: 0x004E5D33
		public static void AddSectorRangeFromPlayerToEntity(FlatBufferBuilder builder, int sectorRangeFromPlayerToEntityOffset)
		{
			builder.AddOffset(10, sectorRangeFromPlayerToEntityOffset, 0);
		}

		// Token: 0x0602373C RID: 145212 RVA: 0x004E7B3F File Offset: 0x004E5D3F
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(11, optionsOffset.Value, 0);
		}

		// Token: 0x0602373D RID: 145213 RVA: 0x004E7B50 File Offset: 0x004E5D50
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<IInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602373E RID: 145214 RVA: 0x004E7B90 File Offset: 0x004E5D90
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<IInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602373F RID: 145215 RVA: 0x004E7BAA File Offset: 0x004E5DAA
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInteractOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023740 RID: 145216 RVA: 0x004E7BC8 File Offset: 0x004E5DC8
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInteractOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023741 RID: 145217 RVA: 0x004E7BE1 File Offset: 0x004E5DE1
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023742 RID: 145218 RVA: 0x004E7BEC File Offset: 0x004E5DEC
		public static void AddRandomInteract(FlatBufferBuilder builder, Offset<IRandomInteract> randomInteractOffset)
		{
			builder.AddOffset(12, randomInteractOffset.Value, 0);
		}

		// Token: 0x06023743 RID: 145219 RVA: 0x004E7BFD File Offset: 0x004E5DFD
		public static void AddInteractDefaultIcon(FlatBufferBuilder builder, EInteractDefaultIcon interactDefaultIcon)
		{
			builder.AddByte(13, (byte)interactDefaultIcon, 0);
		}

		// Token: 0x06023744 RID: 145220 RVA: 0x004E7C09 File Offset: 0x004E5E09
		public static void AddInteractIcon(FlatBufferBuilder builder, EInteractIcon interactIcon)
		{
			builder.AddByte(14, (byte)interactIcon, 0);
		}

		// Token: 0x06023745 RID: 145221 RVA: 0x004E7C15 File Offset: 0x004E5E15
		public static void AddTurnAroundType(FlatBufferBuilder builder, EInteractTurnAround turnAroundType)
		{
			builder.AddByte(15, (byte)turnAroundType, 0);
		}

		// Token: 0x06023746 RID: 145222 RVA: 0x004E7C21 File Offset: 0x004E5E21
		public static void AddIsWaitForTurnAroundComplete(FlatBufferBuilder builder, bool isWaitForTurnAroundComplete)
		{
			builder.AddBool(16, isWaitForTurnAroundComplete, false);
		}

		// Token: 0x06023747 RID: 145223 RVA: 0x004E7C2D File Offset: 0x004E5E2D
		public static void AddIsWaitForInteractComplete(FlatBufferBuilder builder, bool isWaitForInteractComplete)
		{
			builder.AddBool(17, isWaitForInteractComplete, false);
		}

		// Token: 0x06023748 RID: 145224 RVA: 0x004E7C39 File Offset: 0x004E5E39
		public static void AddPreFlow(FlatBufferBuilder builder, Offset<IPlayFlow> preFlowOffset)
		{
			builder.AddOffset(18, preFlowOffset.Value, 0);
		}

		// Token: 0x06023749 RID: 145225 RVA: 0x004E7C4A File Offset: 0x004E5E4A
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(19, tidContentOffset.Value, 0);
		}

		// Token: 0x0602374A RID: 145226 RVA: 0x004E7C5B File Offset: 0x004E5E5B
		public static void AddInteractPointOffset(FlatBufferBuilder builder, Offset<IVectorInfo> interactPointOffsetOffset)
		{
			builder.AddOffset(20, interactPointOffsetOffset.Value, 0);
		}

		// Token: 0x0602374B RID: 145227 RVA: 0x004E7C6C File Offset: 0x004E5E6C
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(21, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x0602374C RID: 145228 RVA: 0x004E7C80 File Offset: 0x004E5E80
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602374D RID: 145229 RVA: 0x004E7CB7 File Offset: 0x004E5EB7
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602374E RID: 145230 RVA: 0x004E7CD1 File Offset: 0x004E5ED1
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602374F RID: 145231 RVA: 0x004E7CEF File Offset: 0x004E5EEF
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023750 RID: 145232 RVA: 0x004E7D08 File Offset: 0x004E5F08
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06023751 RID: 145233 RVA: 0x004E7D13 File Offset: 0x004E5F13
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(22, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06023752 RID: 145234 RVA: 0x004E7D24 File Offset: 0x004E5F24
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023753 RID: 145235 RVA: 0x004E7D5B File Offset: 0x004E5F5B
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023754 RID: 145236 RVA: 0x004E7D75 File Offset: 0x004E5F75
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023755 RID: 145237 RVA: 0x004E7D93 File Offset: 0x004E5F93
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023756 RID: 145238 RVA: 0x004E7DAC File Offset: 0x004E5FAC
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023757 RID: 145239 RVA: 0x004E7DB7 File Offset: 0x004E5FB7
		public static void AddInteractAdditionalInfo(FlatBufferBuilder builder, Offset<IFishingPointAdditionalInfo> interactAdditionalInfoOffset)
		{
			builder.AddOffset(23, interactAdditionalInfoOffset.Value, 0);
		}

		// Token: 0x06023758 RID: 145240 RVA: 0x004E7DC8 File Offset: 0x004E5FC8
		public static void AddPointIconConfig(FlatBufferBuilder builder, Offset<IInteractPointIconConfig> pointIconConfigOffset)
		{
			builder.AddOffset(24, pointIconConfigOffset.Value, 0);
		}

		// Token: 0x06023759 RID: 145241 RVA: 0x004E7DD9 File Offset: 0x004E5FD9
		public static void AddInteractCameraOffsetConfig(FlatBufferBuilder builder, Offset<IInteractCameraOffsetConfig> interactCameraOffsetConfigOffset)
		{
			builder.AddOffset(25, interactCameraOffsetConfigOffset.Value, 0);
		}

		// Token: 0x0602375A RID: 145242 RVA: 0x004E7DEA File Offset: 0x004E5FEA
		public static void AddInteractStyleTypeType(FlatBufferBuilder builder, TInteractStyle interactStyleTypeType)
		{
			builder.AddByte(26, (byte)interactStyleTypeType, 0);
		}

		// Token: 0x0602375B RID: 145243 RVA: 0x004E7DF6 File Offset: 0x004E5FF6
		public static void AddInteractStyleType(FlatBufferBuilder builder, int interactStyleTypeOffset)
		{
			builder.AddOffset(27, interactStyleTypeOffset, 0);
		}

		// Token: 0x0602375C RID: 145244 RVA: 0x004E7E02 File Offset: 0x004E6002
		public static void AddInterruptMontageType(FlatBufferBuilder builder, EInterruptMontageType interruptMontageType)
		{
			builder.AddByte(28, (byte)interruptMontageType, 0);
		}

		// Token: 0x0602375D RID: 145245 RVA: 0x004E7E0E File Offset: 0x004E600E
		public static void AddNotInterruptPlotModeLevelD(FlatBufferBuilder builder, bool notInterruptPlotModeLevelD)
		{
			builder.AddBool(29, notInterruptPlotModeLevelD, false);
		}

		// Token: 0x0602375E RID: 145246 RVA: 0x004E7E1A File Offset: 0x004E601A
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(30, nullMask, 0);
		}

		// Token: 0x0602375F RID: 145247 RVA: 0x004E7E26 File Offset: 0x004E6026
		public static Offset<IInteractComponent> EndIInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInteractComponent>(builder.EndTable());
		}

		// Token: 0x06023760 RID: 145248 RVA: 0x004E7E34 File Offset: 0x004E6034
		public IInteractComponentT UnPack()
		{
			IInteractComponentT interactComponentT = new IInteractComponentT();
			this.UnPackTo(interactComponentT);
			return interactComponentT;
		}

		// Token: 0x06023761 RID: 145249 RVA: 0x004E7E50 File Offset: 0x004E6050
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
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(l);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(l) != null) ? this.MatchRoleOption<IMatchPlayerRole>(l).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(l) != null) ? this.MatchRoleOption<IMatchPhantomRole>(l).Value.UnPack() : null);
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

		// Token: 0x06023762 RID: 145250 RVA: 0x004E8380 File Offset: 0x004E6580
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

		// Token: 0x0400E698 RID: 59032
		private Table __p;
	}
}
