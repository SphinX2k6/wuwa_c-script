using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000454 RID: 1108
	public sealed class EnterInstContext : IMessage<EnterInstContext>, IMessage, IEquatable<EnterInstContext>, IDeepCloneable<EnterInstContext>, IBufferMessage
	{
		// Token: 0x060069BF RID: 27071 RVA: 0x000FD9DC File Offset: 0x000FBBDC
		[NullableContext(1)]
		public static EnterInstContext Create()
		{
			return new EnterInstContext();
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060069C0 RID: 27072 RVA: 0x000FD9E3 File Offset: 0x000FBBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060069C1 RID: 27073 RVA: 0x000FD9E6 File Offset: 0x000FBBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterInstContext.Descriptor;
			}
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x000FD9ED File Offset: 0x000FBBED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext()
		{
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x000FD9F8 File Offset: 0x000FBBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext(EnterInstContext other) : this()
		{
			switch (other.EnterCtxCase)
			{
			case EnterInstContext.EnterCtxOneofCase.RoleTrialCtx:
				this.RoleTrialCtx = other.RoleTrialCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.RoleTeachCtx:
				this.RoleTeachCtx = other.RoleTeachCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.AdventureGuideCtx:
				this.AdventureGuideCtx = other.AdventureGuideCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.RogueWhiteCatCtx:
				this.RogueWhiteCatCtx = other.RogueWhiteCatCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.BossRushCtx:
				this.BossRushCtx = other.BossRushCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.MowTowerCtx:
				this.MowTowerCtx = other.MowTowerCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.RoleSkinTrialEnterCtx:
				this.RoleSkinTrialEnterCtx = other.RoleSkinTrialEnterCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.SlashAndTowerCtx:
				this.SlashAndTowerCtx = other.SlashAndTowerCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.BabelTowerCtx:
				this.BabelTowerCtx = other.BabelTowerCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.PreOpenDetectionCtx:
				this.PreOpenDetectionCtx = other.PreOpenDetectionCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.AbyssInstCtx:
				this.AbyssInstCtx = other.AbyssInstCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.DangoMonopolyCtx:
				this.DangoMonopolyCtx = other.DangoMonopolyCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.PhantomBattleEnterCtx:
				this.PhantomBattleEnterCtx = other.PhantomBattleEnterCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.TrapDefenseCtx:
				this.TrapDefenseCtx = other.TrapDefenseCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.FunPlayCtx:
				this.FunPlayCtx = other.FunPlayCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.HonamiStoryEnterCtx:
				this.HonamiStoryEnterCtx = other.HonamiStoryEnterCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.SurvivorsCtx:
				this.SurvivorsCtx = other.SurvivorsCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.PhotoFightCtx:
				this.PhotoFightCtx = other.PhotoFightCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.NewTowerClimbingCtx:
				this.NewTowerClimbingCtx = other.NewTowerClimbingCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.MotorParkourCtx:
				this.MotorParkourCtx = other.MotorParkourCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.GachaRoleDevelopInsCtx:
				this.GachaRoleDevelopInsCtx = other.GachaRoleDevelopInsCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.MotorFightCtx:
				this.MotorFightCtx = other.MotorFightCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.FlagChallengeCtx:
				this.FlagChallengeCtx = other.FlagChallengeCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.RhythmCtx:
				this.RhythmCtx = other.RhythmCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.PinballCtx:
				this.PinballCtx = other.PinballCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.BossPilingCtx:
				this.BossPilingCtx = other.BossPilingCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.KurotatoCtx:
				this.KurotatoCtx = other.KurotatoCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.EdgeRunnerLordGymCtx:
				this.EdgeRunnerLordGymCtx = other.EdgeRunnerLordGymCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.QuestRecallInstCtx:
				this.QuestRecallInstCtx = other.QuestRecallInstCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.AdventureSilentCtx:
				this.AdventureSilentCtx = other.AdventureSilentCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.RoverRogueInsCtx:
				this.RoverRogueInsCtx = other.RoverRogueInsCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.DangoBrawlEnterCtx:
				this.DangoBrawlEnterCtx = other.DangoBrawlEnterCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.DarkTideCtx:
				this.DarkTideCtx = other.DarkTideCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.RecallInstMarkCtx:
				this.RecallInstMarkCtx = other.RecallInstMarkCtx.Clone();
				break;
			case EnterInstContext.EnterCtxOneofCase.FarmGoldCtx:
				this.FarmGoldCtx = other.FarmGoldCtx.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x000FDDA7 File Offset: 0x000FBFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext Clone()
		{
			return new EnterInstContext(this);
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060069C5 RID: 27077 RVA: 0x000FDDAF File Offset: 0x000FBFAF
		// (set) Token: 0x060069C6 RID: 27078 RVA: 0x000FDDC7 File Offset: 0x000FBFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialEnterCtx RoleTrialCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.RoleTrialCtx)
				{
					return null;
				}
				return (RoleTrialEnterCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.RoleTrialCtx);
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060069C7 RID: 27079 RVA: 0x000FDDDD File Offset: 0x000FBFDD
		// (set) Token: 0x060069C8 RID: 27080 RVA: 0x000FDDF5 File Offset: 0x000FBFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTeachEnterCtx RoleTeachCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.RoleTeachCtx)
				{
					return null;
				}
				return (RoleTeachEnterCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.RoleTeachCtx);
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060069C9 RID: 27081 RVA: 0x000FDE0B File Offset: 0x000FC00B
		// (set) Token: 0x060069CA RID: 27082 RVA: 0x000FDE23 File Offset: 0x000FC023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureGuideCtx AdventureGuideCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.AdventureGuideCtx)
				{
					return null;
				}
				return (AdventureGuideCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.AdventureGuideCtx);
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060069CB RID: 27083 RVA: 0x000FDE39 File Offset: 0x000FC039
		// (set) Token: 0x060069CC RID: 27084 RVA: 0x000FDE51 File Offset: 0x000FC051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatCtx RogueWhiteCatCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.RogueWhiteCatCtx)
				{
					return null;
				}
				return (RogueWhiteCatCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.RogueWhiteCatCtx);
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060069CD RID: 27085 RVA: 0x000FDE67 File Offset: 0x000FC067
		// (set) Token: 0x060069CE RID: 27086 RVA: 0x000FDE7F File Offset: 0x000FC07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushCtx BossRushCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.BossRushCtx)
				{
					return null;
				}
				return (BossRushCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.BossRushCtx);
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060069CF RID: 27087 RVA: 0x000FDE95 File Offset: 0x000FC095
		// (set) Token: 0x060069D0 RID: 27088 RVA: 0x000FDEAD File Offset: 0x000FC0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerCtx MowTowerCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.MowTowerCtx)
				{
					return null;
				}
				return (MowTowerCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.MowTowerCtx);
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060069D1 RID: 27089 RVA: 0x000FDEC3 File Offset: 0x000FC0C3
		// (set) Token: 0x060069D2 RID: 27090 RVA: 0x000FDEDB File Offset: 0x000FC0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialEnterCtx RoleSkinTrialEnterCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.RoleSkinTrialEnterCtx)
				{
					return null;
				}
				return (RoleSkinTrialEnterCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.RoleSkinTrialEnterCtx);
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060069D3 RID: 27091 RVA: 0x000FDEF1 File Offset: 0x000FC0F1
		// (set) Token: 0x060069D4 RID: 27092 RVA: 0x000FDF09 File Offset: 0x000FC109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerCtx SlashAndTowerCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.SlashAndTowerCtx)
				{
					return null;
				}
				return (SlashAndTowerCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.SlashAndTowerCtx);
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060069D5 RID: 27093 RVA: 0x000FDF1F File Offset: 0x000FC11F
		// (set) Token: 0x060069D6 RID: 27094 RVA: 0x000FDF38 File Offset: 0x000FC138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerCtx BabelTowerCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.BabelTowerCtx)
				{
					return null;
				}
				return (BabelTowerCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.BabelTowerCtx);
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060069D7 RID: 27095 RVA: 0x000FDF4F File Offset: 0x000FC14F
		// (set) Token: 0x060069D8 RID: 27096 RVA: 0x000FDF68 File Offset: 0x000FC168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetectionCtx PreOpenDetectionCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.PreOpenDetectionCtx)
				{
					return null;
				}
				return (PreOpenDetectionCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.PreOpenDetectionCtx);
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060069D9 RID: 27097 RVA: 0x000FDF7F File Offset: 0x000FC17F
		// (set) Token: 0x060069DA RID: 27098 RVA: 0x000FDF98 File Offset: 0x000FC198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInstCtx AbyssInstCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.AbyssInstCtx)
				{
					return null;
				}
				return (AbyssInstCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.AbyssInstCtx);
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060069DB RID: 27099 RVA: 0x000FDFAF File Offset: 0x000FC1AF
		// (set) Token: 0x060069DC RID: 27100 RVA: 0x000FDFC8 File Offset: 0x000FC1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyCtx DangoMonopolyCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.DangoMonopolyCtx)
				{
					return null;
				}
				return (DangoMonopolyCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.DangoMonopolyCtx);
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060069DD RID: 27101 RVA: 0x000FDFDF File Offset: 0x000FC1DF
		// (set) Token: 0x060069DE RID: 27102 RVA: 0x000FDFF8 File Offset: 0x000FC1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterCtx PhantomBattleEnterCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.PhantomBattleEnterCtx)
				{
					return null;
				}
				return (PhantomBattleEnterCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.PhantomBattleEnterCtx);
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060069DF RID: 27103 RVA: 0x000FE00F File Offset: 0x000FC20F
		// (set) Token: 0x060069E0 RID: 27104 RVA: 0x000FE028 File Offset: 0x000FC228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCtx TrapDefenseCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.TrapDefenseCtx)
				{
					return null;
				}
				return (TrapDefenseCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.TrapDefenseCtx);
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x000FE03F File Offset: 0x000FC23F
		// (set) Token: 0x060069E2 RID: 27106 RVA: 0x000FE058 File Offset: 0x000FC258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayCtx FunPlayCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.FunPlayCtx)
				{
					return null;
				}
				return (FunPlayCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.FunPlayCtx);
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060069E3 RID: 27107 RVA: 0x000FE06F File Offset: 0x000FC26F
		// (set) Token: 0x060069E4 RID: 27108 RVA: 0x000FE088 File Offset: 0x000FC288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnterCtx HonamiStoryEnterCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.HonamiStoryEnterCtx)
				{
					return null;
				}
				return (HonamiStoryEnterCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.HonamiStoryEnterCtx);
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060069E5 RID: 27109 RVA: 0x000FE09F File Offset: 0x000FC29F
		// (set) Token: 0x060069E6 RID: 27110 RVA: 0x000FE0B8 File Offset: 0x000FC2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCtx SurvivorsCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.SurvivorsCtx)
				{
					return null;
				}
				return (SurvivorsCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.SurvivorsCtx);
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x000FE0CF File Offset: 0x000FC2CF
		// (set) Token: 0x060069E8 RID: 27112 RVA: 0x000FE0E8 File Offset: 0x000FC2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightCtx PhotoFightCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.PhotoFightCtx)
				{
					return null;
				}
				return (PhotoFightCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.PhotoFightCtx);
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060069E9 RID: 27113 RVA: 0x000FE0FF File Offset: 0x000FC2FF
		// (set) Token: 0x060069EA RID: 27114 RVA: 0x000FE118 File Offset: 0x000FC318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingCtx NewTowerClimbingCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.NewTowerClimbingCtx)
				{
					return null;
				}
				return (NewTowerClimbingCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.NewTowerClimbingCtx);
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x000FE12F File Offset: 0x000FC32F
		// (set) Token: 0x060069EC RID: 27116 RVA: 0x000FE148 File Offset: 0x000FC348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourCtx MotorParkourCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.MotorParkourCtx)
				{
					return null;
				}
				return (MotorParkourCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.MotorParkourCtx);
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060069ED RID: 27117 RVA: 0x000FE15F File Offset: 0x000FC35F
		// (set) Token: 0x060069EE RID: 27118 RVA: 0x000FE178 File Offset: 0x000FC378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRoleDevelopInsCtx GachaRoleDevelopInsCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.GachaRoleDevelopInsCtx)
				{
					return null;
				}
				return (GachaRoleDevelopInsCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.GachaRoleDevelopInsCtx);
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060069EF RID: 27119 RVA: 0x000FE18F File Offset: 0x000FC38F
		// (set) Token: 0x060069F0 RID: 27120 RVA: 0x000FE1A8 File Offset: 0x000FC3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCtx MotorFightCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.MotorFightCtx)
				{
					return null;
				}
				return (MotorFightCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.MotorFightCtx);
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x060069F1 RID: 27121 RVA: 0x000FE1BF File Offset: 0x000FC3BF
		// (set) Token: 0x060069F2 RID: 27122 RVA: 0x000FE1D8 File Offset: 0x000FC3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeCtx FlagChallengeCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.FlagChallengeCtx)
				{
					return null;
				}
				return (FlagChallengeCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.FlagChallengeCtx);
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x060069F3 RID: 27123 RVA: 0x000FE1EF File Offset: 0x000FC3EF
		// (set) Token: 0x060069F4 RID: 27124 RVA: 0x000FE208 File Offset: 0x000FC408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmCtx RhythmCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.RhythmCtx)
				{
					return null;
				}
				return (RhythmCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.RhythmCtx);
			}
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x060069F5 RID: 27125 RVA: 0x000FE21F File Offset: 0x000FC41F
		// (set) Token: 0x060069F6 RID: 27126 RVA: 0x000FE238 File Offset: 0x000FC438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballCtx PinballCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.PinballCtx)
				{
					return null;
				}
				return (PinballCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.PinballCtx);
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x060069F7 RID: 27127 RVA: 0x000FE24F File Offset: 0x000FC44F
		// (set) Token: 0x060069F8 RID: 27128 RVA: 0x000FE268 File Offset: 0x000FC468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingCtx BossPilingCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.BossPilingCtx)
				{
					return null;
				}
				return (BossPilingCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.BossPilingCtx);
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x060069F9 RID: 27129 RVA: 0x000FE27F File Offset: 0x000FC47F
		// (set) Token: 0x060069FA RID: 27130 RVA: 0x000FE298 File Offset: 0x000FC498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCtx KurotatoCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.KurotatoCtx)
				{
					return null;
				}
				return (KurotatoCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.KurotatoCtx);
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x060069FB RID: 27131 RVA: 0x000FE2AF File Offset: 0x000FC4AF
		// (set) Token: 0x060069FC RID: 27132 RVA: 0x000FE2C8 File Offset: 0x000FC4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymCtx EdgeRunnerLordGymCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.EdgeRunnerLordGymCtx)
				{
					return null;
				}
				return (EdgeRunnerLordGymCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.EdgeRunnerLordGymCtx);
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x060069FD RID: 27133 RVA: 0x000FE2DF File Offset: 0x000FC4DF
		// (set) Token: 0x060069FE RID: 27134 RVA: 0x000FE2F8 File Offset: 0x000FC4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstCtx QuestRecallInstCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.QuestRecallInstCtx)
				{
					return null;
				}
				return (QuestRecallInstCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.QuestRecallInstCtx);
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x060069FF RID: 27135 RVA: 0x000FE30F File Offset: 0x000FC50F
		// (set) Token: 0x06006A00 RID: 27136 RVA: 0x000FE328 File Offset: 0x000FC528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureSilentCtx AdventureSilentCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.AdventureSilentCtx)
				{
					return null;
				}
				return (AdventureSilentCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.AdventureSilentCtx);
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06006A01 RID: 27137 RVA: 0x000FE33F File Offset: 0x000FC53F
		// (set) Token: 0x06006A02 RID: 27138 RVA: 0x000FE358 File Offset: 0x000FC558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsCtx RoverRogueInsCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.RoverRogueInsCtx)
				{
					return null;
				}
				return (RoverRogueInsCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.RoverRogueInsCtx);
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06006A03 RID: 27139 RVA: 0x000FE36F File Offset: 0x000FC56F
		// (set) Token: 0x06006A04 RID: 27140 RVA: 0x000FE388 File Offset: 0x000FC588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEnterCtx DangoBrawlEnterCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.DangoBrawlEnterCtx)
				{
					return null;
				}
				return (DangoBrawlEnterCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.DangoBrawlEnterCtx);
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06006A05 RID: 27141 RVA: 0x000FE39F File Offset: 0x000FC59F
		// (set) Token: 0x06006A06 RID: 27142 RVA: 0x000FE3B8 File Offset: 0x000FC5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideEnterCtx DarkTideCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.DarkTideCtx)
				{
					return null;
				}
				return (DarkTideEnterCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.DarkTideCtx);
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x000FE3CF File Offset: 0x000FC5CF
		// (set) Token: 0x06006A08 RID: 27144 RVA: 0x000FE3E8 File Offset: 0x000FC5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstMarkCtx RecallInstMarkCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.RecallInstMarkCtx)
				{
					return null;
				}
				return (QuestRecallInstMarkCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.RecallInstMarkCtx);
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06006A09 RID: 27145 RVA: 0x000FE3FF File Offset: 0x000FC5FF
		// (set) Token: 0x06006A0A RID: 27146 RVA: 0x000FE418 File Offset: 0x000FC618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldCtx FarmGoldCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.FarmGoldCtx)
				{
					return null;
				}
				return (FarmGoldCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.FarmGoldCtx);
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06006A0B RID: 27147 RVA: 0x000FE42F File Offset: 0x000FC62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext.EnterCtxOneofCase EnterCtxCase
		{
			get
			{
				return this.enterCtxCase_;
			}
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x000FE437 File Offset: 0x000FC637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEnterCtx()
		{
			this.enterCtxCase_ = EnterInstContext.EnterCtxOneofCase.None;
			this.enterCtx_ = null;
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x000FE447 File Offset: 0x000FC647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterInstContext);
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x000FE458 File Offset: 0x000FC658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterInstContext other)
		{
			return other != null && (other == this || (object.Equals(this.RoleTrialCtx, other.RoleTrialCtx) && object.Equals(this.RoleTeachCtx, other.RoleTeachCtx) && object.Equals(this.AdventureGuideCtx, other.AdventureGuideCtx) && object.Equals(this.RogueWhiteCatCtx, other.RogueWhiteCatCtx) && object.Equals(this.BossRushCtx, other.BossRushCtx) && object.Equals(this.MowTowerCtx, other.MowTowerCtx) && object.Equals(this.RoleSkinTrialEnterCtx, other.RoleSkinTrialEnterCtx) && object.Equals(this.SlashAndTowerCtx, other.SlashAndTowerCtx) && object.Equals(this.BabelTowerCtx, other.BabelTowerCtx) && object.Equals(this.PreOpenDetectionCtx, other.PreOpenDetectionCtx) && object.Equals(this.AbyssInstCtx, other.AbyssInstCtx) && object.Equals(this.DangoMonopolyCtx, other.DangoMonopolyCtx) && object.Equals(this.PhantomBattleEnterCtx, other.PhantomBattleEnterCtx) && object.Equals(this.TrapDefenseCtx, other.TrapDefenseCtx) && object.Equals(this.FunPlayCtx, other.FunPlayCtx) && object.Equals(this.HonamiStoryEnterCtx, other.HonamiStoryEnterCtx) && object.Equals(this.SurvivorsCtx, other.SurvivorsCtx) && object.Equals(this.PhotoFightCtx, other.PhotoFightCtx) && object.Equals(this.NewTowerClimbingCtx, other.NewTowerClimbingCtx) && object.Equals(this.MotorParkourCtx, other.MotorParkourCtx) && object.Equals(this.GachaRoleDevelopInsCtx, other.GachaRoleDevelopInsCtx) && object.Equals(this.MotorFightCtx, other.MotorFightCtx) && object.Equals(this.FlagChallengeCtx, other.FlagChallengeCtx) && object.Equals(this.RhythmCtx, other.RhythmCtx) && object.Equals(this.PinballCtx, other.PinballCtx) && object.Equals(this.BossPilingCtx, other.BossPilingCtx) && object.Equals(this.KurotatoCtx, other.KurotatoCtx) && object.Equals(this.EdgeRunnerLordGymCtx, other.EdgeRunnerLordGymCtx) && object.Equals(this.QuestRecallInstCtx, other.QuestRecallInstCtx) && object.Equals(this.AdventureSilentCtx, other.AdventureSilentCtx) && object.Equals(this.RoverRogueInsCtx, other.RoverRogueInsCtx) && object.Equals(this.DangoBrawlEnterCtx, other.DangoBrawlEnterCtx) && object.Equals(this.DarkTideCtx, other.DarkTideCtx) && object.Equals(this.RecallInstMarkCtx, other.RecallInstMarkCtx) && object.Equals(this.FarmGoldCtx, other.FarmGoldCtx) && this.EnterCtxCase == other.EnterCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x000FE770 File Offset: 0x000FC970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTrialCtx)
			{
				num ^= this.RoleTrialCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTeachCtx)
			{
				num ^= this.RoleTeachCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AdventureGuideCtx)
			{
				num ^= this.AdventureGuideCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RogueWhiteCatCtx)
			{
				num ^= this.RogueWhiteCatCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BossRushCtx)
			{
				num ^= this.BossRushCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MowTowerCtx)
			{
				num ^= this.MowTowerCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleSkinTrialEnterCtx)
			{
				num ^= this.RoleSkinTrialEnterCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.SlashAndTowerCtx)
			{
				num ^= this.SlashAndTowerCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BabelTowerCtx)
			{
				num ^= this.BabelTowerCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PreOpenDetectionCtx)
			{
				num ^= this.PreOpenDetectionCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AbyssInstCtx)
			{
				num ^= this.AbyssInstCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DangoMonopolyCtx)
			{
				num ^= this.DangoMonopolyCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PhantomBattleEnterCtx)
			{
				num ^= this.PhantomBattleEnterCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.TrapDefenseCtx)
			{
				num ^= this.TrapDefenseCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FunPlayCtx)
			{
				num ^= this.FunPlayCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.HonamiStoryEnterCtx)
			{
				num ^= this.HonamiStoryEnterCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.SurvivorsCtx)
			{
				num ^= this.SurvivorsCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PhotoFightCtx)
			{
				num ^= this.PhotoFightCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.NewTowerClimbingCtx)
			{
				num ^= this.NewTowerClimbingCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MotorParkourCtx)
			{
				num ^= this.MotorParkourCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.GachaRoleDevelopInsCtx)
			{
				num ^= this.GachaRoleDevelopInsCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MotorFightCtx)
			{
				num ^= this.MotorFightCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FlagChallengeCtx)
			{
				num ^= this.FlagChallengeCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RhythmCtx)
			{
				num ^= this.RhythmCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PinballCtx)
			{
				num ^= this.PinballCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BossPilingCtx)
			{
				num ^= this.BossPilingCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.KurotatoCtx)
			{
				num ^= this.KurotatoCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.EdgeRunnerLordGymCtx)
			{
				num ^= this.EdgeRunnerLordGymCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.QuestRecallInstCtx)
			{
				num ^= this.QuestRecallInstCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AdventureSilentCtx)
			{
				num ^= this.AdventureSilentCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoverRogueInsCtx)
			{
				num ^= this.RoverRogueInsCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DangoBrawlEnterCtx)
			{
				num ^= this.DangoBrawlEnterCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DarkTideCtx)
			{
				num ^= this.DarkTideCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RecallInstMarkCtx)
			{
				num ^= this.RecallInstMarkCtx.GetHashCode();
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FarmGoldCtx)
			{
				num ^= this.FarmGoldCtx.GetHashCode();
			}
			num ^= (int)this.enterCtxCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x000FEADF File Offset: 0x000FCCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x000FEAEC File Offset: 0x000FCCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x000FEAF8 File Offset: 0x000FCCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTrialCtx)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoleTrialCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTeachCtx)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RoleTeachCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AdventureGuideCtx)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AdventureGuideCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RogueWhiteCatCtx)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueWhiteCatCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BossRushCtx)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.BossRushCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MowTowerCtx)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MowTowerCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleSkinTrialEnterCtx)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RoleSkinTrialEnterCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.SlashAndTowerCtx)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SlashAndTowerCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BabelTowerCtx)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.BabelTowerCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PreOpenDetectionCtx)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PreOpenDetectionCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AbyssInstCtx)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.AbyssInstCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DangoMonopolyCtx)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.DangoMonopolyCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PhantomBattleEnterCtx)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PhantomBattleEnterCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.TrapDefenseCtx)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.TrapDefenseCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FunPlayCtx)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.FunPlayCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.HonamiStoryEnterCtx)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.HonamiStoryEnterCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.SurvivorsCtx)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.SurvivorsCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PhotoFightCtx)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.PhotoFightCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.NewTowerClimbingCtx)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.NewTowerClimbingCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MotorParkourCtx)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.MotorParkourCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.GachaRoleDevelopInsCtx)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.GachaRoleDevelopInsCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MotorFightCtx)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.MotorFightCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FlagChallengeCtx)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.FlagChallengeCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RhythmCtx)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.RhythmCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PinballCtx)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.PinballCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BossPilingCtx)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.BossPilingCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.KurotatoCtx)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.KurotatoCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.EdgeRunnerLordGymCtx)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.EdgeRunnerLordGymCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.QuestRecallInstCtx)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.QuestRecallInstCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AdventureSilentCtx)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.AdventureSilentCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoverRogueInsCtx)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.RoverRogueInsCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DangoBrawlEnterCtx)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.DangoBrawlEnterCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DarkTideCtx)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.DarkTideCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RecallInstMarkCtx)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.RecallInstMarkCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FarmGoldCtx)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.FarmGoldCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x000FEF7C File Offset: 0x000FD17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTrialCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleTrialCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTeachCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleTeachCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AdventureGuideCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AdventureGuideCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RogueWhiteCatCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueWhiteCatCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BossRushCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BossRushCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MowTowerCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MowTowerCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleSkinTrialEnterCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleSkinTrialEnterCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.SlashAndTowerCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SlashAndTowerCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BabelTowerCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BabelTowerCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PreOpenDetectionCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PreOpenDetectionCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AbyssInstCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AbyssInstCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DangoMonopolyCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DangoMonopolyCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PhantomBattleEnterCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleEnterCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.TrapDefenseCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FunPlayCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FunPlayCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.HonamiStoryEnterCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryEnterCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.SurvivorsCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SurvivorsCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PhotoFightCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PhotoFightCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.NewTowerClimbingCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewTowerClimbingCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MotorParkourCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorParkourCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.GachaRoleDevelopInsCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GachaRoleDevelopInsCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MotorFightCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorFightCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FlagChallengeCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RhythmCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RhythmCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PinballCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PinballCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BossPilingCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BossPilingCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.KurotatoCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KurotatoCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.EdgeRunnerLordGymCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EdgeRunnerLordGymCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.QuestRecallInstCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.QuestRecallInstCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AdventureSilentCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AdventureSilentCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoverRogueInsCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoverRogueInsCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DangoBrawlEnterCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DangoBrawlEnterCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DarkTideCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DarkTideCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RecallInstMarkCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RecallInstMarkCtx);
			}
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FarmGoldCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FarmGoldCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x000FF328 File Offset: 0x000FD528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterInstContext other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.EnterCtxCase)
			{
			case EnterInstContext.EnterCtxOneofCase.RoleTrialCtx:
				if (this.RoleTrialCtx == null)
				{
					this.RoleTrialCtx = new RoleTrialEnterCtx();
				}
				this.RoleTrialCtx.MergeFrom(other.RoleTrialCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.RoleTeachCtx:
				if (this.RoleTeachCtx == null)
				{
					this.RoleTeachCtx = new RoleTeachEnterCtx();
				}
				this.RoleTeachCtx.MergeFrom(other.RoleTeachCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.AdventureGuideCtx:
				if (this.AdventureGuideCtx == null)
				{
					this.AdventureGuideCtx = new AdventureGuideCtx();
				}
				this.AdventureGuideCtx.MergeFrom(other.AdventureGuideCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.RogueWhiteCatCtx:
				if (this.RogueWhiteCatCtx == null)
				{
					this.RogueWhiteCatCtx = new RogueWhiteCatCtx();
				}
				this.RogueWhiteCatCtx.MergeFrom(other.RogueWhiteCatCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.BossRushCtx:
				if (this.BossRushCtx == null)
				{
					this.BossRushCtx = new BossRushCtx();
				}
				this.BossRushCtx.MergeFrom(other.BossRushCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.MowTowerCtx:
				if (this.MowTowerCtx == null)
				{
					this.MowTowerCtx = new MowTowerCtx();
				}
				this.MowTowerCtx.MergeFrom(other.MowTowerCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.RoleSkinTrialEnterCtx:
				if (this.RoleSkinTrialEnterCtx == null)
				{
					this.RoleSkinTrialEnterCtx = new RoleSkinTrialEnterCtx();
				}
				this.RoleSkinTrialEnterCtx.MergeFrom(other.RoleSkinTrialEnterCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.SlashAndTowerCtx:
				if (this.SlashAndTowerCtx == null)
				{
					this.SlashAndTowerCtx = new SlashAndTowerCtx();
				}
				this.SlashAndTowerCtx.MergeFrom(other.SlashAndTowerCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.BabelTowerCtx:
				if (this.BabelTowerCtx == null)
				{
					this.BabelTowerCtx = new BabelTowerCtx();
				}
				this.BabelTowerCtx.MergeFrom(other.BabelTowerCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.PreOpenDetectionCtx:
				if (this.PreOpenDetectionCtx == null)
				{
					this.PreOpenDetectionCtx = new PreOpenDetectionCtx();
				}
				this.PreOpenDetectionCtx.MergeFrom(other.PreOpenDetectionCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.AbyssInstCtx:
				if (this.AbyssInstCtx == null)
				{
					this.AbyssInstCtx = new AbyssInstCtx();
				}
				this.AbyssInstCtx.MergeFrom(other.AbyssInstCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.DangoMonopolyCtx:
				if (this.DangoMonopolyCtx == null)
				{
					this.DangoMonopolyCtx = new DangoMonopolyCtx();
				}
				this.DangoMonopolyCtx.MergeFrom(other.DangoMonopolyCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.PhantomBattleEnterCtx:
				if (this.PhantomBattleEnterCtx == null)
				{
					this.PhantomBattleEnterCtx = new PhantomBattleEnterCtx();
				}
				this.PhantomBattleEnterCtx.MergeFrom(other.PhantomBattleEnterCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.TrapDefenseCtx:
				if (this.TrapDefenseCtx == null)
				{
					this.TrapDefenseCtx = new TrapDefenseCtx();
				}
				this.TrapDefenseCtx.MergeFrom(other.TrapDefenseCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.FunPlayCtx:
				if (this.FunPlayCtx == null)
				{
					this.FunPlayCtx = new FunPlayCtx();
				}
				this.FunPlayCtx.MergeFrom(other.FunPlayCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.HonamiStoryEnterCtx:
				if (this.HonamiStoryEnterCtx == null)
				{
					this.HonamiStoryEnterCtx = new HonamiStoryEnterCtx();
				}
				this.HonamiStoryEnterCtx.MergeFrom(other.HonamiStoryEnterCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.SurvivorsCtx:
				if (this.SurvivorsCtx == null)
				{
					this.SurvivorsCtx = new SurvivorsCtx();
				}
				this.SurvivorsCtx.MergeFrom(other.SurvivorsCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.PhotoFightCtx:
				if (this.PhotoFightCtx == null)
				{
					this.PhotoFightCtx = new PhotoFightCtx();
				}
				this.PhotoFightCtx.MergeFrom(other.PhotoFightCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.NewTowerClimbingCtx:
				if (this.NewTowerClimbingCtx == null)
				{
					this.NewTowerClimbingCtx = new NewTowerClimbingCtx();
				}
				this.NewTowerClimbingCtx.MergeFrom(other.NewTowerClimbingCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.MotorParkourCtx:
				if (this.MotorParkourCtx == null)
				{
					this.MotorParkourCtx = new MotorParkourCtx();
				}
				this.MotorParkourCtx.MergeFrom(other.MotorParkourCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.GachaRoleDevelopInsCtx:
				if (this.GachaRoleDevelopInsCtx == null)
				{
					this.GachaRoleDevelopInsCtx = new GachaRoleDevelopInsCtx();
				}
				this.GachaRoleDevelopInsCtx.MergeFrom(other.GachaRoleDevelopInsCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.MotorFightCtx:
				if (this.MotorFightCtx == null)
				{
					this.MotorFightCtx = new MotorFightCtx();
				}
				this.MotorFightCtx.MergeFrom(other.MotorFightCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.FlagChallengeCtx:
				if (this.FlagChallengeCtx == null)
				{
					this.FlagChallengeCtx = new FlagChallengeCtx();
				}
				this.FlagChallengeCtx.MergeFrom(other.FlagChallengeCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.RhythmCtx:
				if (this.RhythmCtx == null)
				{
					this.RhythmCtx = new RhythmCtx();
				}
				this.RhythmCtx.MergeFrom(other.RhythmCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.PinballCtx:
				if (this.PinballCtx == null)
				{
					this.PinballCtx = new PinballCtx();
				}
				this.PinballCtx.MergeFrom(other.PinballCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.BossPilingCtx:
				if (this.BossPilingCtx == null)
				{
					this.BossPilingCtx = new BossPilingCtx();
				}
				this.BossPilingCtx.MergeFrom(other.BossPilingCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.KurotatoCtx:
				if (this.KurotatoCtx == null)
				{
					this.KurotatoCtx = new KurotatoCtx();
				}
				this.KurotatoCtx.MergeFrom(other.KurotatoCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.EdgeRunnerLordGymCtx:
				if (this.EdgeRunnerLordGymCtx == null)
				{
					this.EdgeRunnerLordGymCtx = new EdgeRunnerLordGymCtx();
				}
				this.EdgeRunnerLordGymCtx.MergeFrom(other.EdgeRunnerLordGymCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.QuestRecallInstCtx:
				if (this.QuestRecallInstCtx == null)
				{
					this.QuestRecallInstCtx = new QuestRecallInstCtx();
				}
				this.QuestRecallInstCtx.MergeFrom(other.QuestRecallInstCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.AdventureSilentCtx:
				if (this.AdventureSilentCtx == null)
				{
					this.AdventureSilentCtx = new AdventureSilentCtx();
				}
				this.AdventureSilentCtx.MergeFrom(other.AdventureSilentCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.RoverRogueInsCtx:
				if (this.RoverRogueInsCtx == null)
				{
					this.RoverRogueInsCtx = new RoverRogueInsCtx();
				}
				this.RoverRogueInsCtx.MergeFrom(other.RoverRogueInsCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.DangoBrawlEnterCtx:
				if (this.DangoBrawlEnterCtx == null)
				{
					this.DangoBrawlEnterCtx = new DangoBrawlEnterCtx();
				}
				this.DangoBrawlEnterCtx.MergeFrom(other.DangoBrawlEnterCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.DarkTideCtx:
				if (this.DarkTideCtx == null)
				{
					this.DarkTideCtx = new DarkTideEnterCtx();
				}
				this.DarkTideCtx.MergeFrom(other.DarkTideCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.RecallInstMarkCtx:
				if (this.RecallInstMarkCtx == null)
				{
					this.RecallInstMarkCtx = new QuestRecallInstMarkCtx();
				}
				this.RecallInstMarkCtx.MergeFrom(other.RecallInstMarkCtx);
				break;
			case EnterInstContext.EnterCtxOneofCase.FarmGoldCtx:
				if (this.FarmGoldCtx == null)
				{
					this.FarmGoldCtx = new FarmGoldCtx();
				}
				this.FarmGoldCtx.MergeFrom(other.FarmGoldCtx);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x000FF97D File Offset: 0x000FDB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x000FF988 File Offset: 0x000FDB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 138U)
				{
					if (num <= 66U)
					{
						if (num <= 34U)
						{
							if (num <= 18U)
							{
								if (num == 10U)
								{
									RoleTrialEnterCtx roleTrialEnterCtx = new RoleTrialEnterCtx();
									if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTrialCtx)
									{
										roleTrialEnterCtx.MergeFrom(this.RoleTrialCtx);
									}
									input.ReadMessage(roleTrialEnterCtx);
									this.RoleTrialCtx = roleTrialEnterCtx;
									continue;
								}
								if (num == 18U)
								{
									RoleTeachEnterCtx roleTeachEnterCtx = new RoleTeachEnterCtx();
									if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTeachCtx)
									{
										roleTeachEnterCtx.MergeFrom(this.RoleTeachCtx);
									}
									input.ReadMessage(roleTeachEnterCtx);
									this.RoleTeachCtx = roleTeachEnterCtx;
									continue;
								}
							}
							else
							{
								if (num == 26U)
								{
									AdventureGuideCtx adventureGuideCtx = new AdventureGuideCtx();
									if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AdventureGuideCtx)
									{
										adventureGuideCtx.MergeFrom(this.AdventureGuideCtx);
									}
									input.ReadMessage(adventureGuideCtx);
									this.AdventureGuideCtx = adventureGuideCtx;
									continue;
								}
								if (num == 34U)
								{
									RogueWhiteCatCtx rogueWhiteCatCtx = new RogueWhiteCatCtx();
									if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RogueWhiteCatCtx)
									{
										rogueWhiteCatCtx.MergeFrom(this.RogueWhiteCatCtx);
									}
									input.ReadMessage(rogueWhiteCatCtx);
									this.RogueWhiteCatCtx = rogueWhiteCatCtx;
									continue;
								}
							}
						}
						else if (num <= 50U)
						{
							if (num == 42U)
							{
								BossRushCtx bossRushCtx = new BossRushCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BossRushCtx)
								{
									bossRushCtx.MergeFrom(this.BossRushCtx);
								}
								input.ReadMessage(bossRushCtx);
								this.BossRushCtx = bossRushCtx;
								continue;
							}
							if (num == 50U)
							{
								MowTowerCtx mowTowerCtx = new MowTowerCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MowTowerCtx)
								{
									mowTowerCtx.MergeFrom(this.MowTowerCtx);
								}
								input.ReadMessage(mowTowerCtx);
								this.MowTowerCtx = mowTowerCtx;
								continue;
							}
						}
						else
						{
							if (num == 58U)
							{
								RoleSkinTrialEnterCtx roleSkinTrialEnterCtx = new RoleSkinTrialEnterCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleSkinTrialEnterCtx)
								{
									roleSkinTrialEnterCtx.MergeFrom(this.RoleSkinTrialEnterCtx);
								}
								input.ReadMessage(roleSkinTrialEnterCtx);
								this.RoleSkinTrialEnterCtx = roleSkinTrialEnterCtx;
								continue;
							}
							if (num == 66U)
							{
								SlashAndTowerCtx slashAndTowerCtx = new SlashAndTowerCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.SlashAndTowerCtx)
								{
									slashAndTowerCtx.MergeFrom(this.SlashAndTowerCtx);
								}
								input.ReadMessage(slashAndTowerCtx);
								this.SlashAndTowerCtx = slashAndTowerCtx;
								continue;
							}
						}
					}
					else if (num <= 98U)
					{
						if (num <= 82U)
						{
							if (num == 74U)
							{
								BabelTowerCtx babelTowerCtx = new BabelTowerCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BabelTowerCtx)
								{
									babelTowerCtx.MergeFrom(this.BabelTowerCtx);
								}
								input.ReadMessage(babelTowerCtx);
								this.BabelTowerCtx = babelTowerCtx;
								continue;
							}
							if (num == 82U)
							{
								PreOpenDetectionCtx preOpenDetectionCtx = new PreOpenDetectionCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PreOpenDetectionCtx)
								{
									preOpenDetectionCtx.MergeFrom(this.PreOpenDetectionCtx);
								}
								input.ReadMessage(preOpenDetectionCtx);
								this.PreOpenDetectionCtx = preOpenDetectionCtx;
								continue;
							}
						}
						else
						{
							if (num == 90U)
							{
								AbyssInstCtx abyssInstCtx = new AbyssInstCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AbyssInstCtx)
								{
									abyssInstCtx.MergeFrom(this.AbyssInstCtx);
								}
								input.ReadMessage(abyssInstCtx);
								this.AbyssInstCtx = abyssInstCtx;
								continue;
							}
							if (num == 98U)
							{
								DangoMonopolyCtx dangoMonopolyCtx = new DangoMonopolyCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DangoMonopolyCtx)
								{
									dangoMonopolyCtx.MergeFrom(this.DangoMonopolyCtx);
								}
								input.ReadMessage(dangoMonopolyCtx);
								this.DangoMonopolyCtx = dangoMonopolyCtx;
								continue;
							}
						}
					}
					else if (num <= 114U)
					{
						if (num == 106U)
						{
							PhantomBattleEnterCtx phantomBattleEnterCtx = new PhantomBattleEnterCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PhantomBattleEnterCtx)
							{
								phantomBattleEnterCtx.MergeFrom(this.PhantomBattleEnterCtx);
							}
							input.ReadMessage(phantomBattleEnterCtx);
							this.PhantomBattleEnterCtx = phantomBattleEnterCtx;
							continue;
						}
						if (num == 114U)
						{
							TrapDefenseCtx trapDefenseCtx = new TrapDefenseCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.TrapDefenseCtx)
							{
								trapDefenseCtx.MergeFrom(this.TrapDefenseCtx);
							}
							input.ReadMessage(trapDefenseCtx);
							this.TrapDefenseCtx = trapDefenseCtx;
							continue;
						}
					}
					else
					{
						if (num == 122U)
						{
							FunPlayCtx funPlayCtx = new FunPlayCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FunPlayCtx)
							{
								funPlayCtx.MergeFrom(this.FunPlayCtx);
							}
							input.ReadMessage(funPlayCtx);
							this.FunPlayCtx = funPlayCtx;
							continue;
						}
						if (num == 130U)
						{
							HonamiStoryEnterCtx honamiStoryEnterCtx = new HonamiStoryEnterCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.HonamiStoryEnterCtx)
							{
								honamiStoryEnterCtx.MergeFrom(this.HonamiStoryEnterCtx);
							}
							input.ReadMessage(honamiStoryEnterCtx);
							this.HonamiStoryEnterCtx = honamiStoryEnterCtx;
							continue;
						}
						if (num == 138U)
						{
							SurvivorsCtx survivorsCtx = new SurvivorsCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.SurvivorsCtx)
							{
								survivorsCtx.MergeFrom(this.SurvivorsCtx);
							}
							input.ReadMessage(survivorsCtx);
							this.SurvivorsCtx = survivorsCtx;
							continue;
						}
					}
				}
				else if (num <= 210U)
				{
					if (num <= 170U)
					{
						if (num <= 154U)
						{
							if (num == 146U)
							{
								PhotoFightCtx photoFightCtx = new PhotoFightCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PhotoFightCtx)
								{
									photoFightCtx.MergeFrom(this.PhotoFightCtx);
								}
								input.ReadMessage(photoFightCtx);
								this.PhotoFightCtx = photoFightCtx;
								continue;
							}
							if (num == 154U)
							{
								NewTowerClimbingCtx newTowerClimbingCtx = new NewTowerClimbingCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.NewTowerClimbingCtx)
								{
									newTowerClimbingCtx.MergeFrom(this.NewTowerClimbingCtx);
								}
								input.ReadMessage(newTowerClimbingCtx);
								this.NewTowerClimbingCtx = newTowerClimbingCtx;
								continue;
							}
						}
						else
						{
							if (num == 162U)
							{
								MotorParkourCtx motorParkourCtx = new MotorParkourCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MotorParkourCtx)
								{
									motorParkourCtx.MergeFrom(this.MotorParkourCtx);
								}
								input.ReadMessage(motorParkourCtx);
								this.MotorParkourCtx = motorParkourCtx;
								continue;
							}
							if (num == 170U)
							{
								GachaRoleDevelopInsCtx gachaRoleDevelopInsCtx = new GachaRoleDevelopInsCtx();
								if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.GachaRoleDevelopInsCtx)
								{
									gachaRoleDevelopInsCtx.MergeFrom(this.GachaRoleDevelopInsCtx);
								}
								input.ReadMessage(gachaRoleDevelopInsCtx);
								this.GachaRoleDevelopInsCtx = gachaRoleDevelopInsCtx;
								continue;
							}
						}
					}
					else if (num <= 186U)
					{
						if (num == 178U)
						{
							MotorFightCtx motorFightCtx = new MotorFightCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.MotorFightCtx)
							{
								motorFightCtx.MergeFrom(this.MotorFightCtx);
							}
							input.ReadMessage(motorFightCtx);
							this.MotorFightCtx = motorFightCtx;
							continue;
						}
						if (num == 186U)
						{
							FlagChallengeCtx flagChallengeCtx = new FlagChallengeCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FlagChallengeCtx)
							{
								flagChallengeCtx.MergeFrom(this.FlagChallengeCtx);
							}
							input.ReadMessage(flagChallengeCtx);
							this.FlagChallengeCtx = flagChallengeCtx;
							continue;
						}
					}
					else
					{
						if (num == 194U)
						{
							RhythmCtx rhythmCtx = new RhythmCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RhythmCtx)
							{
								rhythmCtx.MergeFrom(this.RhythmCtx);
							}
							input.ReadMessage(rhythmCtx);
							this.RhythmCtx = rhythmCtx;
							continue;
						}
						if (num == 202U)
						{
							PinballCtx pinballCtx = new PinballCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.PinballCtx)
							{
								pinballCtx.MergeFrom(this.PinballCtx);
							}
							input.ReadMessage(pinballCtx);
							this.PinballCtx = pinballCtx;
							continue;
						}
						if (num == 210U)
						{
							BossPilingCtx bossPilingCtx = new BossPilingCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.BossPilingCtx)
							{
								bossPilingCtx.MergeFrom(this.BossPilingCtx);
							}
							input.ReadMessage(bossPilingCtx);
							this.BossPilingCtx = bossPilingCtx;
							continue;
						}
					}
				}
				else if (num <= 242U)
				{
					if (num <= 226U)
					{
						if (num == 218U)
						{
							KurotatoCtx kurotatoCtx = new KurotatoCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.KurotatoCtx)
							{
								kurotatoCtx.MergeFrom(this.KurotatoCtx);
							}
							input.ReadMessage(kurotatoCtx);
							this.KurotatoCtx = kurotatoCtx;
							continue;
						}
						if (num == 226U)
						{
							EdgeRunnerLordGymCtx edgeRunnerLordGymCtx = new EdgeRunnerLordGymCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.EdgeRunnerLordGymCtx)
							{
								edgeRunnerLordGymCtx.MergeFrom(this.EdgeRunnerLordGymCtx);
							}
							input.ReadMessage(edgeRunnerLordGymCtx);
							this.EdgeRunnerLordGymCtx = edgeRunnerLordGymCtx;
							continue;
						}
					}
					else
					{
						if (num == 234U)
						{
							QuestRecallInstCtx questRecallInstCtx = new QuestRecallInstCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.QuestRecallInstCtx)
							{
								questRecallInstCtx.MergeFrom(this.QuestRecallInstCtx);
							}
							input.ReadMessage(questRecallInstCtx);
							this.QuestRecallInstCtx = questRecallInstCtx;
							continue;
						}
						if (num == 242U)
						{
							AdventureSilentCtx adventureSilentCtx = new AdventureSilentCtx();
							if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.AdventureSilentCtx)
							{
								adventureSilentCtx.MergeFrom(this.AdventureSilentCtx);
							}
							input.ReadMessage(adventureSilentCtx);
							this.AdventureSilentCtx = adventureSilentCtx;
							continue;
						}
					}
				}
				else if (num <= 258U)
				{
					if (num == 250U)
					{
						RoverRogueInsCtx roverRogueInsCtx = new RoverRogueInsCtx();
						if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoverRogueInsCtx)
						{
							roverRogueInsCtx.MergeFrom(this.RoverRogueInsCtx);
						}
						input.ReadMessage(roverRogueInsCtx);
						this.RoverRogueInsCtx = roverRogueInsCtx;
						continue;
					}
					if (num == 258U)
					{
						DangoBrawlEnterCtx dangoBrawlEnterCtx = new DangoBrawlEnterCtx();
						if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DangoBrawlEnterCtx)
						{
							dangoBrawlEnterCtx.MergeFrom(this.DangoBrawlEnterCtx);
						}
						input.ReadMessage(dangoBrawlEnterCtx);
						this.DangoBrawlEnterCtx = dangoBrawlEnterCtx;
						continue;
					}
				}
				else
				{
					if (num == 266U)
					{
						DarkTideEnterCtx darkTideEnterCtx = new DarkTideEnterCtx();
						if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.DarkTideCtx)
						{
							darkTideEnterCtx.MergeFrom(this.DarkTideCtx);
						}
						input.ReadMessage(darkTideEnterCtx);
						this.DarkTideCtx = darkTideEnterCtx;
						continue;
					}
					if (num == 274U)
					{
						QuestRecallInstMarkCtx questRecallInstMarkCtx = new QuestRecallInstMarkCtx();
						if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RecallInstMarkCtx)
						{
							questRecallInstMarkCtx.MergeFrom(this.RecallInstMarkCtx);
						}
						input.ReadMessage(questRecallInstMarkCtx);
						this.RecallInstMarkCtx = questRecallInstMarkCtx;
						continue;
					}
					if (num == 282U)
					{
						FarmGoldCtx farmGoldCtx = new FarmGoldCtx();
						if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.FarmGoldCtx)
						{
							farmGoldCtx.MergeFrom(this.FarmGoldCtx);
						}
						input.ReadMessage(farmGoldCtx);
						this.FarmGoldCtx = farmGoldCtx;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A0B RID: 14859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A0C RID: 14860
		public const int RoleTrialCtxFieldNumber = 1;

		// Token: 0x04003A0D RID: 14861
		public const int RoleTeachCtxFieldNumber = 2;

		// Token: 0x04003A0E RID: 14862
		public const int AdventureGuideCtxFieldNumber = 3;

		// Token: 0x04003A0F RID: 14863
		public const int RogueWhiteCatCtxFieldNumber = 4;

		// Token: 0x04003A10 RID: 14864
		public const int BossRushCtxFieldNumber = 5;

		// Token: 0x04003A11 RID: 14865
		public const int MowTowerCtxFieldNumber = 6;

		// Token: 0x04003A12 RID: 14866
		public const int RoleSkinTrialEnterCtxFieldNumber = 7;

		// Token: 0x04003A13 RID: 14867
		public const int SlashAndTowerCtxFieldNumber = 8;

		// Token: 0x04003A14 RID: 14868
		public const int BabelTowerCtxFieldNumber = 9;

		// Token: 0x04003A15 RID: 14869
		public const int PreOpenDetectionCtxFieldNumber = 10;

		// Token: 0x04003A16 RID: 14870
		public const int AbyssInstCtxFieldNumber = 11;

		// Token: 0x04003A17 RID: 14871
		public const int DangoMonopolyCtxFieldNumber = 12;

		// Token: 0x04003A18 RID: 14872
		public const int PhantomBattleEnterCtxFieldNumber = 13;

		// Token: 0x04003A19 RID: 14873
		public const int TrapDefenseCtxFieldNumber = 14;

		// Token: 0x04003A1A RID: 14874
		public const int FunPlayCtxFieldNumber = 15;

		// Token: 0x04003A1B RID: 14875
		public const int HonamiStoryEnterCtxFieldNumber = 16;

		// Token: 0x04003A1C RID: 14876
		public const int SurvivorsCtxFieldNumber = 17;

		// Token: 0x04003A1D RID: 14877
		public const int PhotoFightCtxFieldNumber = 18;

		// Token: 0x04003A1E RID: 14878
		public const int NewTowerClimbingCtxFieldNumber = 19;

		// Token: 0x04003A1F RID: 14879
		public const int MotorParkourCtxFieldNumber = 20;

		// Token: 0x04003A20 RID: 14880
		public const int GachaRoleDevelopInsCtxFieldNumber = 21;

		// Token: 0x04003A21 RID: 14881
		public const int MotorFightCtxFieldNumber = 22;

		// Token: 0x04003A22 RID: 14882
		public const int FlagChallengeCtxFieldNumber = 23;

		// Token: 0x04003A23 RID: 14883
		public const int RhythmCtxFieldNumber = 24;

		// Token: 0x04003A24 RID: 14884
		public const int PinballCtxFieldNumber = 25;

		// Token: 0x04003A25 RID: 14885
		public const int BossPilingCtxFieldNumber = 26;

		// Token: 0x04003A26 RID: 14886
		public const int KurotatoCtxFieldNumber = 27;

		// Token: 0x04003A27 RID: 14887
		public const int EdgeRunnerLordGymCtxFieldNumber = 28;

		// Token: 0x04003A28 RID: 14888
		public const int QuestRecallInstCtxFieldNumber = 29;

		// Token: 0x04003A29 RID: 14889
		public const int AdventureSilentCtxFieldNumber = 30;

		// Token: 0x04003A2A RID: 14890
		public const int RoverRogueInsCtxFieldNumber = 31;

		// Token: 0x04003A2B RID: 14891
		public const int DangoBrawlEnterCtxFieldNumber = 32;

		// Token: 0x04003A2C RID: 14892
		public const int DarkTideCtxFieldNumber = 33;

		// Token: 0x04003A2D RID: 14893
		public const int RecallInstMarkCtxFieldNumber = 34;

		// Token: 0x04003A2E RID: 14894
		public const int FarmGoldCtxFieldNumber = 35;

		// Token: 0x04003A2F RID: 14895
		private object enterCtx_;

		// Token: 0x04003A30 RID: 14896
		private EnterInstContext.EnterCtxOneofCase enterCtxCase_;

		// Token: 0x0200176A RID: 5994
		public enum EnterCtxOneofCase
		{
			// Token: 0x0400C5F0 RID: 50672
			None,
			// Token: 0x0400C5F1 RID: 50673
			RoleTrialCtx,
			// Token: 0x0400C5F2 RID: 50674
			RoleTeachCtx,
			// Token: 0x0400C5F3 RID: 50675
			AdventureGuideCtx,
			// Token: 0x0400C5F4 RID: 50676
			RogueWhiteCatCtx,
			// Token: 0x0400C5F5 RID: 50677
			BossRushCtx,
			// Token: 0x0400C5F6 RID: 50678
			MowTowerCtx,
			// Token: 0x0400C5F7 RID: 50679
			RoleSkinTrialEnterCtx,
			// Token: 0x0400C5F8 RID: 50680
			SlashAndTowerCtx,
			// Token: 0x0400C5F9 RID: 50681
			BabelTowerCtx,
			// Token: 0x0400C5FA RID: 50682
			PreOpenDetectionCtx,
			// Token: 0x0400C5FB RID: 50683
			AbyssInstCtx,
			// Token: 0x0400C5FC RID: 50684
			DangoMonopolyCtx,
			// Token: 0x0400C5FD RID: 50685
			PhantomBattleEnterCtx,
			// Token: 0x0400C5FE RID: 50686
			TrapDefenseCtx,
			// Token: 0x0400C5FF RID: 50687
			FunPlayCtx,
			// Token: 0x0400C600 RID: 50688
			HonamiStoryEnterCtx,
			// Token: 0x0400C601 RID: 50689
			SurvivorsCtx,
			// Token: 0x0400C602 RID: 50690
			PhotoFightCtx,
			// Token: 0x0400C603 RID: 50691
			NewTowerClimbingCtx,
			// Token: 0x0400C604 RID: 50692
			MotorParkourCtx,
			// Token: 0x0400C605 RID: 50693
			GachaRoleDevelopInsCtx,
			// Token: 0x0400C606 RID: 50694
			MotorFightCtx,
			// Token: 0x0400C607 RID: 50695
			FlagChallengeCtx,
			// Token: 0x0400C608 RID: 50696
			RhythmCtx,
			// Token: 0x0400C609 RID: 50697
			PinballCtx,
			// Token: 0x0400C60A RID: 50698
			BossPilingCtx,
			// Token: 0x0400C60B RID: 50699
			KurotatoCtx,
			// Token: 0x0400C60C RID: 50700
			EdgeRunnerLordGymCtx,
			// Token: 0x0400C60D RID: 50701
			QuestRecallInstCtx,
			// Token: 0x0400C60E RID: 50702
			AdventureSilentCtx,
			// Token: 0x0400C60F RID: 50703
			RoverRogueInsCtx,
			// Token: 0x0400C610 RID: 50704
			DangoBrawlEnterCtx,
			// Token: 0x0400C611 RID: 50705
			DarkTideCtx,
			// Token: 0x0400C612 RID: 50706
			RecallInstMarkCtx,
			// Token: 0x0400C613 RID: 50707
			FarmGoldCtx
		}
	}
}
