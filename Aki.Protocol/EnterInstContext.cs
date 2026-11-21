using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043D RID: 1085
	public sealed class EnterInstContext : IMessage<EnterInstContext>, IMessage, IEquatable<EnterInstContext>, IDeepCloneable<EnterInstContext>, IBufferMessage
	{
		// Token: 0x0600682F RID: 26671 RVA: 0x000FA850 File Offset: 0x000F8A50
		[NullableContext(1)]
		public static EnterInstContext Create()
		{
			return new EnterInstContext();
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06006830 RID: 26672 RVA: 0x000FA857 File Offset: 0x000F8A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06006831 RID: 26673 RVA: 0x000FA85A File Offset: 0x000F8A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterInstContext.Descriptor;
			}
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x000FA861 File Offset: 0x000F8A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext()
		{
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x000FA86C File Offset: 0x000F8A6C
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
			case EnterInstContext.EnterCtxOneofCase.RoleTowerCtx:
				this.RoleTowerCtx = other.RoleTowerCtx.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x000FAC35 File Offset: 0x000F8E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext Clone()
		{
			return new EnterInstContext(this);
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06006835 RID: 26677 RVA: 0x000FAC3D File Offset: 0x000F8E3D
		// (set) Token: 0x06006836 RID: 26678 RVA: 0x000FAC55 File Offset: 0x000F8E55
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

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06006837 RID: 26679 RVA: 0x000FAC6B File Offset: 0x000F8E6B
		// (set) Token: 0x06006838 RID: 26680 RVA: 0x000FAC83 File Offset: 0x000F8E83
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

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06006839 RID: 26681 RVA: 0x000FAC99 File Offset: 0x000F8E99
		// (set) Token: 0x0600683A RID: 26682 RVA: 0x000FACB1 File Offset: 0x000F8EB1
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

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x0600683B RID: 26683 RVA: 0x000FACC7 File Offset: 0x000F8EC7
		// (set) Token: 0x0600683C RID: 26684 RVA: 0x000FACDF File Offset: 0x000F8EDF
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

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x0600683D RID: 26685 RVA: 0x000FACF5 File Offset: 0x000F8EF5
		// (set) Token: 0x0600683E RID: 26686 RVA: 0x000FAD0D File Offset: 0x000F8F0D
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

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600683F RID: 26687 RVA: 0x000FAD23 File Offset: 0x000F8F23
		// (set) Token: 0x06006840 RID: 26688 RVA: 0x000FAD3B File Offset: 0x000F8F3B
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

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06006841 RID: 26689 RVA: 0x000FAD51 File Offset: 0x000F8F51
		// (set) Token: 0x06006842 RID: 26690 RVA: 0x000FAD69 File Offset: 0x000F8F69
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

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06006843 RID: 26691 RVA: 0x000FAD7F File Offset: 0x000F8F7F
		// (set) Token: 0x06006844 RID: 26692 RVA: 0x000FAD97 File Offset: 0x000F8F97
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

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06006845 RID: 26693 RVA: 0x000FADAD File Offset: 0x000F8FAD
		// (set) Token: 0x06006846 RID: 26694 RVA: 0x000FADC6 File Offset: 0x000F8FC6
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

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06006847 RID: 26695 RVA: 0x000FADDD File Offset: 0x000F8FDD
		// (set) Token: 0x06006848 RID: 26696 RVA: 0x000FADF6 File Offset: 0x000F8FF6
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

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06006849 RID: 26697 RVA: 0x000FAE0D File Offset: 0x000F900D
		// (set) Token: 0x0600684A RID: 26698 RVA: 0x000FAE26 File Offset: 0x000F9026
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

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x0600684B RID: 26699 RVA: 0x000FAE3D File Offset: 0x000F903D
		// (set) Token: 0x0600684C RID: 26700 RVA: 0x000FAE56 File Offset: 0x000F9056
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

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x0600684D RID: 26701 RVA: 0x000FAE6D File Offset: 0x000F906D
		// (set) Token: 0x0600684E RID: 26702 RVA: 0x000FAE86 File Offset: 0x000F9086
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

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x0600684F RID: 26703 RVA: 0x000FAE9D File Offset: 0x000F909D
		// (set) Token: 0x06006850 RID: 26704 RVA: 0x000FAEB6 File Offset: 0x000F90B6
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

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06006851 RID: 26705 RVA: 0x000FAECD File Offset: 0x000F90CD
		// (set) Token: 0x06006852 RID: 26706 RVA: 0x000FAEE6 File Offset: 0x000F90E6
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

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06006853 RID: 26707 RVA: 0x000FAEFD File Offset: 0x000F90FD
		// (set) Token: 0x06006854 RID: 26708 RVA: 0x000FAF16 File Offset: 0x000F9116
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

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06006855 RID: 26709 RVA: 0x000FAF2D File Offset: 0x000F912D
		// (set) Token: 0x06006856 RID: 26710 RVA: 0x000FAF46 File Offset: 0x000F9146
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

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06006857 RID: 26711 RVA: 0x000FAF5D File Offset: 0x000F915D
		// (set) Token: 0x06006858 RID: 26712 RVA: 0x000FAF76 File Offset: 0x000F9176
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

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06006859 RID: 26713 RVA: 0x000FAF8D File Offset: 0x000F918D
		// (set) Token: 0x0600685A RID: 26714 RVA: 0x000FAFA6 File Offset: 0x000F91A6
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

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x0600685B RID: 26715 RVA: 0x000FAFBD File Offset: 0x000F91BD
		// (set) Token: 0x0600685C RID: 26716 RVA: 0x000FAFD6 File Offset: 0x000F91D6
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

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x0600685D RID: 26717 RVA: 0x000FAFED File Offset: 0x000F91ED
		// (set) Token: 0x0600685E RID: 26718 RVA: 0x000FB006 File Offset: 0x000F9206
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

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600685F RID: 26719 RVA: 0x000FB01D File Offset: 0x000F921D
		// (set) Token: 0x06006860 RID: 26720 RVA: 0x000FB036 File Offset: 0x000F9236
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

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06006861 RID: 26721 RVA: 0x000FB04D File Offset: 0x000F924D
		// (set) Token: 0x06006862 RID: 26722 RVA: 0x000FB066 File Offset: 0x000F9266
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

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06006863 RID: 26723 RVA: 0x000FB07D File Offset: 0x000F927D
		// (set) Token: 0x06006864 RID: 26724 RVA: 0x000FB096 File Offset: 0x000F9296
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

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06006865 RID: 26725 RVA: 0x000FB0AD File Offset: 0x000F92AD
		// (set) Token: 0x06006866 RID: 26726 RVA: 0x000FB0C6 File Offset: 0x000F92C6
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

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06006867 RID: 26727 RVA: 0x000FB0DD File Offset: 0x000F92DD
		// (set) Token: 0x06006868 RID: 26728 RVA: 0x000FB0F6 File Offset: 0x000F92F6
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

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06006869 RID: 26729 RVA: 0x000FB10D File Offset: 0x000F930D
		// (set) Token: 0x0600686A RID: 26730 RVA: 0x000FB126 File Offset: 0x000F9326
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

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x000FB13D File Offset: 0x000F933D
		// (set) Token: 0x0600686C RID: 26732 RVA: 0x000FB156 File Offset: 0x000F9356
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

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x000FB16D File Offset: 0x000F936D
		// (set) Token: 0x0600686E RID: 26734 RVA: 0x000FB186 File Offset: 0x000F9386
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

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x0600686F RID: 26735 RVA: 0x000FB19D File Offset: 0x000F939D
		// (set) Token: 0x06006870 RID: 26736 RVA: 0x000FB1B6 File Offset: 0x000F93B6
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

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x000FB1CD File Offset: 0x000F93CD
		// (set) Token: 0x06006872 RID: 26738 RVA: 0x000FB1E6 File Offset: 0x000F93E6
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

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x000FB1FD File Offset: 0x000F93FD
		// (set) Token: 0x06006874 RID: 26740 RVA: 0x000FB216 File Offset: 0x000F9416
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

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06006875 RID: 26741 RVA: 0x000FB22D File Offset: 0x000F942D
		// (set) Token: 0x06006876 RID: 26742 RVA: 0x000FB246 File Offset: 0x000F9446
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

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06006877 RID: 26743 RVA: 0x000FB25D File Offset: 0x000F945D
		// (set) Token: 0x06006878 RID: 26744 RVA: 0x000FB276 File Offset: 0x000F9476
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

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06006879 RID: 26745 RVA: 0x000FB28D File Offset: 0x000F948D
		// (set) Token: 0x0600687A RID: 26746 RVA: 0x000FB2A6 File Offset: 0x000F94A6
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

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x0600687B RID: 26747 RVA: 0x000FB2BD File Offset: 0x000F94BD
		// (set) Token: 0x0600687C RID: 26748 RVA: 0x000FB2D6 File Offset: 0x000F94D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerCtx RoleTowerCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterInstContext.EnterCtxOneofCase.RoleTowerCtx)
				{
					return null;
				}
				return (RoleTowerCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterInstContext.EnterCtxOneofCase.None : EnterInstContext.EnterCtxOneofCase.RoleTowerCtx);
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x0600687D RID: 26749 RVA: 0x000FB2ED File Offset: 0x000F94ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext.EnterCtxOneofCase EnterCtxCase
		{
			get
			{
				return this.enterCtxCase_;
			}
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x000FB2F5 File Offset: 0x000F94F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEnterCtx()
		{
			this.enterCtxCase_ = EnterInstContext.EnterCtxOneofCase.None;
			this.enterCtx_ = null;
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x000FB305 File Offset: 0x000F9505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterInstContext);
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x000FB314 File Offset: 0x000F9514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterInstContext other)
		{
			return other != null && (other == this || (object.Equals(this.RoleTrialCtx, other.RoleTrialCtx) && object.Equals(this.RoleTeachCtx, other.RoleTeachCtx) && object.Equals(this.AdventureGuideCtx, other.AdventureGuideCtx) && object.Equals(this.RogueWhiteCatCtx, other.RogueWhiteCatCtx) && object.Equals(this.BossRushCtx, other.BossRushCtx) && object.Equals(this.MowTowerCtx, other.MowTowerCtx) && object.Equals(this.RoleSkinTrialEnterCtx, other.RoleSkinTrialEnterCtx) && object.Equals(this.SlashAndTowerCtx, other.SlashAndTowerCtx) && object.Equals(this.BabelTowerCtx, other.BabelTowerCtx) && object.Equals(this.PreOpenDetectionCtx, other.PreOpenDetectionCtx) && object.Equals(this.AbyssInstCtx, other.AbyssInstCtx) && object.Equals(this.DangoMonopolyCtx, other.DangoMonopolyCtx) && object.Equals(this.PhantomBattleEnterCtx, other.PhantomBattleEnterCtx) && object.Equals(this.TrapDefenseCtx, other.TrapDefenseCtx) && object.Equals(this.FunPlayCtx, other.FunPlayCtx) && object.Equals(this.HonamiStoryEnterCtx, other.HonamiStoryEnterCtx) && object.Equals(this.SurvivorsCtx, other.SurvivorsCtx) && object.Equals(this.PhotoFightCtx, other.PhotoFightCtx) && object.Equals(this.NewTowerClimbingCtx, other.NewTowerClimbingCtx) && object.Equals(this.MotorParkourCtx, other.MotorParkourCtx) && object.Equals(this.GachaRoleDevelopInsCtx, other.GachaRoleDevelopInsCtx) && object.Equals(this.MotorFightCtx, other.MotorFightCtx) && object.Equals(this.FlagChallengeCtx, other.FlagChallengeCtx) && object.Equals(this.RhythmCtx, other.RhythmCtx) && object.Equals(this.PinballCtx, other.PinballCtx) && object.Equals(this.BossPilingCtx, other.BossPilingCtx) && object.Equals(this.KurotatoCtx, other.KurotatoCtx) && object.Equals(this.EdgeRunnerLordGymCtx, other.EdgeRunnerLordGymCtx) && object.Equals(this.QuestRecallInstCtx, other.QuestRecallInstCtx) && object.Equals(this.AdventureSilentCtx, other.AdventureSilentCtx) && object.Equals(this.RoverRogueInsCtx, other.RoverRogueInsCtx) && object.Equals(this.DangoBrawlEnterCtx, other.DangoBrawlEnterCtx) && object.Equals(this.DarkTideCtx, other.DarkTideCtx) && object.Equals(this.RecallInstMarkCtx, other.RecallInstMarkCtx) && object.Equals(this.FarmGoldCtx, other.FarmGoldCtx) && object.Equals(this.RoleTowerCtx, other.RoleTowerCtx) && this.EnterCtxCase == other.EnterCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x000FB644 File Offset: 0x000F9844
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
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTowerCtx)
			{
				num ^= this.RoleTowerCtx.GetHashCode();
			}
			num ^= (int)this.enterCtxCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x000FB9CB File Offset: 0x000F9BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x000FB9D8 File Offset: 0x000F9BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x000FB9E4 File Offset: 0x000F9BE4
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
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTowerCtx)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.RoleTowerCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x000FBE8C File Offset: 0x000FA08C
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
			if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTowerCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoleTowerCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x000FC254 File Offset: 0x000FA454
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
			case EnterInstContext.EnterCtxOneofCase.RoleTowerCtx:
				if (this.RoleTowerCtx == null)
				{
					this.RoleTowerCtx = new RoleTowerCtx();
				}
				this.RoleTowerCtx.MergeFrom(other.RoleTowerCtx);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x000FC8D6 File Offset: 0x000FAAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x000FC8E0 File Offset: 0x000FAAE0
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
				if (num <= 146U)
				{
					if (num <= 74U)
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
						}
					}
					else if (num <= 106U)
					{
						if (num <= 90U)
						{
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
						}
						else
						{
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
						}
					}
					else if (num <= 122U)
					{
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
					}
					else
					{
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
					}
				}
				else if (num <= 218U)
				{
					if (num <= 178U)
					{
						if (num <= 162U)
						{
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
						}
						else
						{
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
						}
					}
					else if (num <= 194U)
					{
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
					}
					else
					{
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
					}
				}
				else if (num <= 250U)
				{
					if (num <= 234U)
					{
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
					}
					else
					{
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
					}
				}
				else if (num <= 266U)
				{
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
				}
				else
				{
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
					if (num == 290U)
					{
						RoleTowerCtx roleTowerCtx = new RoleTowerCtx();
						if (this.enterCtxCase_ == EnterInstContext.EnterCtxOneofCase.RoleTowerCtx)
						{
							roleTowerCtx.MergeFrom(this.RoleTowerCtx);
						}
						input.ReadMessage(roleTowerCtx);
						this.RoleTowerCtx = roleTowerCtx;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040039F8 RID: 14840
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039F9 RID: 14841
		public const int RoleTrialCtxFieldNumber = 1;

		// Token: 0x040039FA RID: 14842
		public const int RoleTeachCtxFieldNumber = 2;

		// Token: 0x040039FB RID: 14843
		public const int AdventureGuideCtxFieldNumber = 3;

		// Token: 0x040039FC RID: 14844
		public const int RogueWhiteCatCtxFieldNumber = 4;

		// Token: 0x040039FD RID: 14845
		public const int BossRushCtxFieldNumber = 5;

		// Token: 0x040039FE RID: 14846
		public const int MowTowerCtxFieldNumber = 6;

		// Token: 0x040039FF RID: 14847
		public const int RoleSkinTrialEnterCtxFieldNumber = 7;

		// Token: 0x04003A00 RID: 14848
		public const int SlashAndTowerCtxFieldNumber = 8;

		// Token: 0x04003A01 RID: 14849
		public const int BabelTowerCtxFieldNumber = 9;

		// Token: 0x04003A02 RID: 14850
		public const int PreOpenDetectionCtxFieldNumber = 10;

		// Token: 0x04003A03 RID: 14851
		public const int AbyssInstCtxFieldNumber = 11;

		// Token: 0x04003A04 RID: 14852
		public const int DangoMonopolyCtxFieldNumber = 12;

		// Token: 0x04003A05 RID: 14853
		public const int PhantomBattleEnterCtxFieldNumber = 13;

		// Token: 0x04003A06 RID: 14854
		public const int TrapDefenseCtxFieldNumber = 14;

		// Token: 0x04003A07 RID: 14855
		public const int FunPlayCtxFieldNumber = 15;

		// Token: 0x04003A08 RID: 14856
		public const int HonamiStoryEnterCtxFieldNumber = 16;

		// Token: 0x04003A09 RID: 14857
		public const int SurvivorsCtxFieldNumber = 17;

		// Token: 0x04003A0A RID: 14858
		public const int PhotoFightCtxFieldNumber = 18;

		// Token: 0x04003A0B RID: 14859
		public const int NewTowerClimbingCtxFieldNumber = 19;

		// Token: 0x04003A0C RID: 14860
		public const int MotorParkourCtxFieldNumber = 20;

		// Token: 0x04003A0D RID: 14861
		public const int GachaRoleDevelopInsCtxFieldNumber = 21;

		// Token: 0x04003A0E RID: 14862
		public const int MotorFightCtxFieldNumber = 22;

		// Token: 0x04003A0F RID: 14863
		public const int FlagChallengeCtxFieldNumber = 23;

		// Token: 0x04003A10 RID: 14864
		public const int RhythmCtxFieldNumber = 24;

		// Token: 0x04003A11 RID: 14865
		public const int PinballCtxFieldNumber = 25;

		// Token: 0x04003A12 RID: 14866
		public const int BossPilingCtxFieldNumber = 26;

		// Token: 0x04003A13 RID: 14867
		public const int KurotatoCtxFieldNumber = 27;

		// Token: 0x04003A14 RID: 14868
		public const int EdgeRunnerLordGymCtxFieldNumber = 28;

		// Token: 0x04003A15 RID: 14869
		public const int QuestRecallInstCtxFieldNumber = 29;

		// Token: 0x04003A16 RID: 14870
		public const int AdventureSilentCtxFieldNumber = 30;

		// Token: 0x04003A17 RID: 14871
		public const int RoverRogueInsCtxFieldNumber = 31;

		// Token: 0x04003A18 RID: 14872
		public const int DangoBrawlEnterCtxFieldNumber = 32;

		// Token: 0x04003A19 RID: 14873
		public const int DarkTideCtxFieldNumber = 33;

		// Token: 0x04003A1A RID: 14874
		public const int RecallInstMarkCtxFieldNumber = 34;

		// Token: 0x04003A1B RID: 14875
		public const int FarmGoldCtxFieldNumber = 35;

		// Token: 0x04003A1C RID: 14876
		public const int RoleTowerCtxFieldNumber = 36;

		// Token: 0x04003A1D RID: 14877
		private object enterCtx_;

		// Token: 0x04003A1E RID: 14878
		private EnterInstContext.EnterCtxOneofCase enterCtxCase_;

		// Token: 0x020017E2 RID: 6114
		public enum EnterCtxOneofCase
		{
			// Token: 0x0400CB1A RID: 51994
			None,
			// Token: 0x0400CB1B RID: 51995
			RoleTrialCtx,
			// Token: 0x0400CB1C RID: 51996
			RoleTeachCtx,
			// Token: 0x0400CB1D RID: 51997
			AdventureGuideCtx,
			// Token: 0x0400CB1E RID: 51998
			RogueWhiteCatCtx,
			// Token: 0x0400CB1F RID: 51999
			BossRushCtx,
			// Token: 0x0400CB20 RID: 52000
			MowTowerCtx,
			// Token: 0x0400CB21 RID: 52001
			RoleSkinTrialEnterCtx,
			// Token: 0x0400CB22 RID: 52002
			SlashAndTowerCtx,
			// Token: 0x0400CB23 RID: 52003
			BabelTowerCtx,
			// Token: 0x0400CB24 RID: 52004
			PreOpenDetectionCtx,
			// Token: 0x0400CB25 RID: 52005
			AbyssInstCtx,
			// Token: 0x0400CB26 RID: 52006
			DangoMonopolyCtx,
			// Token: 0x0400CB27 RID: 52007
			PhantomBattleEnterCtx,
			// Token: 0x0400CB28 RID: 52008
			TrapDefenseCtx,
			// Token: 0x0400CB29 RID: 52009
			FunPlayCtx,
			// Token: 0x0400CB2A RID: 52010
			HonamiStoryEnterCtx,
			// Token: 0x0400CB2B RID: 52011
			SurvivorsCtx,
			// Token: 0x0400CB2C RID: 52012
			PhotoFightCtx,
			// Token: 0x0400CB2D RID: 52013
			NewTowerClimbingCtx,
			// Token: 0x0400CB2E RID: 52014
			MotorParkourCtx,
			// Token: 0x0400CB2F RID: 52015
			GachaRoleDevelopInsCtx,
			// Token: 0x0400CB30 RID: 52016
			MotorFightCtx,
			// Token: 0x0400CB31 RID: 52017
			FlagChallengeCtx,
			// Token: 0x0400CB32 RID: 52018
			RhythmCtx,
			// Token: 0x0400CB33 RID: 52019
			PinballCtx,
			// Token: 0x0400CB34 RID: 52020
			BossPilingCtx,
			// Token: 0x0400CB35 RID: 52021
			KurotatoCtx,
			// Token: 0x0400CB36 RID: 52022
			EdgeRunnerLordGymCtx,
			// Token: 0x0400CB37 RID: 52023
			QuestRecallInstCtx,
			// Token: 0x0400CB38 RID: 52024
			AdventureSilentCtx,
			// Token: 0x0400CB39 RID: 52025
			RoverRogueInsCtx,
			// Token: 0x0400CB3A RID: 52026
			DangoBrawlEnterCtx,
			// Token: 0x0400CB3B RID: 52027
			DarkTideCtx,
			// Token: 0x0400CB3C RID: 52028
			RecallInstMarkCtx,
			// Token: 0x0400CB3D RID: 52029
			FarmGoldCtx,
			// Token: 0x0400CB3E RID: 52030
			RoleTowerCtx
		}
	}
}
