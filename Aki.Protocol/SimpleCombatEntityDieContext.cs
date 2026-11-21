using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001260 RID: 4704
	public sealed class SimpleCombatEntityDieContext : IMessage<SimpleCombatEntityDieContext>, IMessage, IEquatable<SimpleCombatEntityDieContext>, IDeepCloneable<SimpleCombatEntityDieContext>, IBufferMessage
	{
		// Token: 0x060191BF RID: 102847 RVA: 0x003A8EEF File Offset: 0x003A70EF
		[NullableContext(1)]
		public static SimpleCombatEntityDieContext Create()
		{
			return new SimpleCombatEntityDieContext();
		}

		// Token: 0x170054DA RID: 21722
		// (get) Token: 0x060191C0 RID: 102848 RVA: 0x003A8EF6 File Offset: 0x003A70F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SimpleCombatEntityDieContext> Parser
		{
			get
			{
				return SimpleCombatEntityDieContext._parser;
			}
		}

		// Token: 0x170054DB RID: 21723
		// (get) Token: 0x060191C1 RID: 102849 RVA: 0x003A8EFD File Offset: 0x003A70FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054DC RID: 21724
		// (get) Token: 0x060191C2 RID: 102850 RVA: 0x003A8F00 File Offset: 0x003A7100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityDieContext.Descriptor;
			}
		}

		// Token: 0x060191C3 RID: 102851 RVA: 0x003A8F07 File Offset: 0x003A7107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieContext()
		{
		}

		// Token: 0x060191C4 RID: 102852 RVA: 0x003A8F10 File Offset: 0x003A7110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieContext(SimpleCombatEntityDieContext other) : this()
		{
			this.diePos_ = ((other.diePos_ != null) ? other.diePos_.Clone() : null);
			switch (other.ContextCase)
			{
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapKillCtx:
				this.TrapDefenseTrapKillCtx = other.TrapDefenseTrapKillCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapSelfDestructCtx:
				this.TrapDefenseTrapSelfDestructCtx = other.TrapDefenseTrapSelfDestructCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseGoldenCoinAbosorbedCtx:
				this.TrapDefenseGoldenCoinAbosorbedCtx = other.TrapDefenseGoldenCoinAbosorbedCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseReachInstEndpointCtx:
				this.TrapDefenseReachInstEndpointCtx = other.TrapDefenseReachInstEndpointCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseEnvironmentalKillCtx:
				this.TrapDefenseEnvironmentalKillCtx = other.TrapDefenseEnvironmentalKillCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseMonsterKilledCtx:
				this.TrapDefenseMonsterKilledCtx = other.TrapDefenseMonsterKilledCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseSpcecialCellDestructCtx:
				this.TrapDefenseSpcecialCellDestructCtx = other.TrapDefenseSpcecialCellDestructCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsMonsterKilledCtx:
				this.SurvivorsMonsterKilledCtx = other.SurvivorsMonsterKilledCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsGoldenCoinAbosorbedCtx:
				this.SurvivorsGoldenCoinAbosorbedCtx = other.SurvivorsGoldenCoinAbosorbedCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsRoleKilledCtx:
				this.SurvivorsRoleKilledCtx = other.SurvivorsRoleKilledCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.KurotatoMonsterKilledCtxPb:
				this.KurotatoMonsterKilledCtxPb = other.KurotatoMonsterKilledCtxPb.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.KurotatoDropAbsorbedCtxPb:
				this.KurotatoDropAbsorbedCtxPb = other.KurotatoDropAbsorbedCtxPb.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.KurotatoRoleKilledCtxPb:
				this.KurotatoRoleKilledCtxPb = other.KurotatoRoleKilledCtxPb.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.PinballMonsterKilledCtx:
				this.PinballMonsterKilledCtx = other.PinballMonsterKilledCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.PinballEntityKilledCtx:
				this.PinballEntityKilledCtx = other.PinballEntityKilledCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.KurotatoStructureKilledCtxPb:
				this.KurotatoStructureKilledCtxPb = other.KurotatoStructureKilledCtxPb.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.GPUMonsterKilledCtx:
				this.GPUMonsterKilledCtx = other.GPUMonsterKilledCtx.Clone();
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.GPURoleKilledCtx:
				this.GPURoleKilledCtx = other.GPURoleKilledCtx.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060191C5 RID: 102853 RVA: 0x003A9121 File Offset: 0x003A7321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieContext Clone()
		{
			return new SimpleCombatEntityDieContext(this);
		}

		// Token: 0x170054DD RID: 21725
		// (get) Token: 0x060191C6 RID: 102854 RVA: 0x003A9129 File Offset: 0x003A7329
		// (set) Token: 0x060191C7 RID: 102855 RVA: 0x003A9131 File Offset: 0x003A7331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector DiePos
		{
			get
			{
				return this.diePos_;
			}
			set
			{
				this.diePos_ = value;
			}
		}

		// Token: 0x170054DE RID: 21726
		// (get) Token: 0x060191C8 RID: 102856 RVA: 0x003A913A File Offset: 0x003A733A
		// (set) Token: 0x060191C9 RID: 102857 RVA: 0x003A9152 File Offset: 0x003A7352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapKillCtxPb TrapDefenseTrapKillCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapKillCtx)
				{
					return null;
				}
				return (TrapDefenseTrapKillCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapKillCtx);
			}
		}

		// Token: 0x170054DF RID: 21727
		// (get) Token: 0x060191CA RID: 102858 RVA: 0x003A9168 File Offset: 0x003A7368
		// (set) Token: 0x060191CB RID: 102859 RVA: 0x003A9180 File Offset: 0x003A7380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapSelfDestructCtxPb TrapDefenseTrapSelfDestructCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapSelfDestructCtx)
				{
					return null;
				}
				return (TrapDefenseTrapSelfDestructCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapSelfDestructCtx);
			}
		}

		// Token: 0x170054E0 RID: 21728
		// (get) Token: 0x060191CC RID: 102860 RVA: 0x003A9196 File Offset: 0x003A7396
		// (set) Token: 0x060191CD RID: 102861 RVA: 0x003A91AE File Offset: 0x003A73AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinAbosorbedCtxPb TrapDefenseGoldenCoinAbosorbedCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseGoldenCoinAbosorbedCtx)
				{
					return null;
				}
				return (TrapDefenseGoldenCoinAbosorbedCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseGoldenCoinAbosorbedCtx);
			}
		}

		// Token: 0x170054E1 RID: 21729
		// (get) Token: 0x060191CE RID: 102862 RVA: 0x003A91C4 File Offset: 0x003A73C4
		// (set) Token: 0x060191CF RID: 102863 RVA: 0x003A91DC File Offset: 0x003A73DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseReachInstEndpointCtxPb TrapDefenseReachInstEndpointCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseReachInstEndpointCtx)
				{
					return null;
				}
				return (TrapDefenseReachInstEndpointCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseReachInstEndpointCtx);
			}
		}

		// Token: 0x170054E2 RID: 21730
		// (get) Token: 0x060191D0 RID: 102864 RVA: 0x003A91F2 File Offset: 0x003A73F2
		// (set) Token: 0x060191D1 RID: 102865 RVA: 0x003A920A File Offset: 0x003A740A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEnvironmentalKillCtxPb TrapDefenseEnvironmentalKillCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseEnvironmentalKillCtx)
				{
					return null;
				}
				return (TrapDefenseEnvironmentalKillCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseEnvironmentalKillCtx);
			}
		}

		// Token: 0x170054E3 RID: 21731
		// (get) Token: 0x060191D2 RID: 102866 RVA: 0x003A9220 File Offset: 0x003A7420
		// (set) Token: 0x060191D3 RID: 102867 RVA: 0x003A9238 File Offset: 0x003A7438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterKilledCtxPb TrapDefenseMonsterKilledCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseMonsterKilledCtx)
				{
					return null;
				}
				return (TrapDefenseMonsterKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseMonsterKilledCtx);
			}
		}

		// Token: 0x170054E4 RID: 21732
		// (get) Token: 0x060191D4 RID: 102868 RVA: 0x003A924E File Offset: 0x003A744E
		// (set) Token: 0x060191D5 RID: 102869 RVA: 0x003A9267 File Offset: 0x003A7467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpcecialCellDestructCtxPb TrapDefenseSpcecialCellDestructCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseSpcecialCellDestructCtx)
				{
					return null;
				}
				return (TrapDefenseSpcecialCellDestructCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseSpcecialCellDestructCtx);
			}
		}

		// Token: 0x170054E5 RID: 21733
		// (get) Token: 0x060191D6 RID: 102870 RVA: 0x003A927E File Offset: 0x003A747E
		// (set) Token: 0x060191D7 RID: 102871 RVA: 0x003A9297 File Offset: 0x003A7497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterKilledCtxPb SurvivorsMonsterKilledCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsMonsterKilledCtx)
				{
					return null;
				}
				return (SurvivorsMonsterKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsMonsterKilledCtx);
			}
		}

		// Token: 0x170054E6 RID: 21734
		// (get) Token: 0x060191D8 RID: 102872 RVA: 0x003A92AE File Offset: 0x003A74AE
		// (set) Token: 0x060191D9 RID: 102873 RVA: 0x003A92C7 File Offset: 0x003A74C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinAbosorbedCtxPb SurvivorsGoldenCoinAbosorbedCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsGoldenCoinAbosorbedCtx)
				{
					return null;
				}
				return (SurvivorsGoldenCoinAbosorbedCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsGoldenCoinAbosorbedCtx);
			}
		}

		// Token: 0x170054E7 RID: 21735
		// (get) Token: 0x060191DA RID: 102874 RVA: 0x003A92DE File Offset: 0x003A74DE
		// (set) Token: 0x060191DB RID: 102875 RVA: 0x003A92F7 File Offset: 0x003A74F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleKilledCtxPb SurvivorsRoleKilledCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsRoleKilledCtx)
				{
					return null;
				}
				return (SurvivorsRoleKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsRoleKilledCtx);
			}
		}

		// Token: 0x170054E8 RID: 21736
		// (get) Token: 0x060191DC RID: 102876 RVA: 0x003A930E File Offset: 0x003A750E
		// (set) Token: 0x060191DD RID: 102877 RVA: 0x003A9327 File Offset: 0x003A7527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterKilledCtxPb KurotatoMonsterKilledCtxPb
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.KurotatoMonsterKilledCtxPb)
				{
					return null;
				}
				return (KurotatoMonsterKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.KurotatoMonsterKilledCtxPb);
			}
		}

		// Token: 0x170054E9 RID: 21737
		// (get) Token: 0x060191DE RID: 102878 RVA: 0x003A933E File Offset: 0x003A753E
		// (set) Token: 0x060191DF RID: 102879 RVA: 0x003A9357 File Offset: 0x003A7557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropAbsorbedCtxPb KurotatoDropAbsorbedCtxPb
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.KurotatoDropAbsorbedCtxPb)
				{
					return null;
				}
				return (KurotatoDropAbsorbedCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.KurotatoDropAbsorbedCtxPb);
			}
		}

		// Token: 0x170054EA RID: 21738
		// (get) Token: 0x060191E0 RID: 102880 RVA: 0x003A936E File Offset: 0x003A756E
		// (set) Token: 0x060191E1 RID: 102881 RVA: 0x003A9387 File Offset: 0x003A7587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleKilledCtxPb KurotatoRoleKilledCtxPb
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.KurotatoRoleKilledCtxPb)
				{
					return null;
				}
				return (KurotatoRoleKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.KurotatoRoleKilledCtxPb);
			}
		}

		// Token: 0x170054EB RID: 21739
		// (get) Token: 0x060191E2 RID: 102882 RVA: 0x003A939E File Offset: 0x003A759E
		// (set) Token: 0x060191E3 RID: 102883 RVA: 0x003A93B7 File Offset: 0x003A75B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureKilledCtxPb KurotatoStructureKilledCtxPb
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.KurotatoStructureKilledCtxPb)
				{
					return null;
				}
				return (KurotatoStructureKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.KurotatoStructureKilledCtxPb);
			}
		}

		// Token: 0x170054EC RID: 21740
		// (get) Token: 0x060191E4 RID: 102884 RVA: 0x003A93CE File Offset: 0x003A75CE
		// (set) Token: 0x060191E5 RID: 102885 RVA: 0x003A93E7 File Offset: 0x003A75E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballMonsterKilledCtxPb PinballMonsterKilledCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.PinballMonsterKilledCtx)
				{
					return null;
				}
				return (PinballMonsterKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.PinballMonsterKilledCtx);
			}
		}

		// Token: 0x170054ED RID: 21741
		// (get) Token: 0x060191E6 RID: 102886 RVA: 0x003A93FE File Offset: 0x003A75FE
		// (set) Token: 0x060191E7 RID: 102887 RVA: 0x003A9417 File Offset: 0x003A7617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballEntityKilledCtxPb PinballEntityKilledCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.PinballEntityKilledCtx)
				{
					return null;
				}
				return (PinballEntityKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.PinballEntityKilledCtx);
			}
		}

		// Token: 0x170054EE RID: 21742
		// (get) Token: 0x060191E8 RID: 102888 RVA: 0x003A942E File Offset: 0x003A762E
		// (set) Token: 0x060191E9 RID: 102889 RVA: 0x003A9447 File Offset: 0x003A7647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPUMonsterKilledCtxPb GPUMonsterKilledCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.GPUMonsterKilledCtx)
				{
					return null;
				}
				return (GPUMonsterKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.GPUMonsterKilledCtx);
			}
		}

		// Token: 0x170054EF RID: 21743
		// (get) Token: 0x060191EA RID: 102890 RVA: 0x003A945E File Offset: 0x003A765E
		// (set) Token: 0x060191EB RID: 102891 RVA: 0x003A9477 File Offset: 0x003A7677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPURoleKilledCtxPb GPURoleKilledCtx
		{
			get
			{
				if (this.contextCase_ != SimpleCombatEntityDieContext.ContextOneofCase.GPURoleKilledCtx)
				{
					return null;
				}
				return (GPURoleKilledCtxPb)this.context_;
			}
			set
			{
				this.context_ = value;
				this.contextCase_ = ((value == null) ? SimpleCombatEntityDieContext.ContextOneofCase.None : SimpleCombatEntityDieContext.ContextOneofCase.GPURoleKilledCtx);
			}
		}

		// Token: 0x170054F0 RID: 21744
		// (get) Token: 0x060191EC RID: 102892 RVA: 0x003A948E File Offset: 0x003A768E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieContext.ContextOneofCase ContextCase
		{
			get
			{
				return this.contextCase_;
			}
		}

		// Token: 0x060191ED RID: 102893 RVA: 0x003A9496 File Offset: 0x003A7696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearContext()
		{
			this.contextCase_ = SimpleCombatEntityDieContext.ContextOneofCase.None;
			this.context_ = null;
		}

		// Token: 0x060191EE RID: 102894 RVA: 0x003A94A6 File Offset: 0x003A76A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityDieContext);
		}

		// Token: 0x060191EF RID: 102895 RVA: 0x003A94B4 File Offset: 0x003A76B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityDieContext other)
		{
			return other != null && (other == this || (object.Equals(this.DiePos, other.DiePos) && object.Equals(this.TrapDefenseTrapKillCtx, other.TrapDefenseTrapKillCtx) && object.Equals(this.TrapDefenseTrapSelfDestructCtx, other.TrapDefenseTrapSelfDestructCtx) && object.Equals(this.TrapDefenseGoldenCoinAbosorbedCtx, other.TrapDefenseGoldenCoinAbosorbedCtx) && object.Equals(this.TrapDefenseReachInstEndpointCtx, other.TrapDefenseReachInstEndpointCtx) && object.Equals(this.TrapDefenseEnvironmentalKillCtx, other.TrapDefenseEnvironmentalKillCtx) && object.Equals(this.TrapDefenseMonsterKilledCtx, other.TrapDefenseMonsterKilledCtx) && object.Equals(this.TrapDefenseSpcecialCellDestructCtx, other.TrapDefenseSpcecialCellDestructCtx) && object.Equals(this.SurvivorsMonsterKilledCtx, other.SurvivorsMonsterKilledCtx) && object.Equals(this.SurvivorsGoldenCoinAbosorbedCtx, other.SurvivorsGoldenCoinAbosorbedCtx) && object.Equals(this.SurvivorsRoleKilledCtx, other.SurvivorsRoleKilledCtx) && object.Equals(this.KurotatoMonsterKilledCtxPb, other.KurotatoMonsterKilledCtxPb) && object.Equals(this.KurotatoDropAbsorbedCtxPb, other.KurotatoDropAbsorbedCtxPb) && object.Equals(this.KurotatoRoleKilledCtxPb, other.KurotatoRoleKilledCtxPb) && object.Equals(this.KurotatoStructureKilledCtxPb, other.KurotatoStructureKilledCtxPb) && object.Equals(this.PinballMonsterKilledCtx, other.PinballMonsterKilledCtx) && object.Equals(this.PinballEntityKilledCtx, other.PinballEntityKilledCtx) && object.Equals(this.GPUMonsterKilledCtx, other.GPUMonsterKilledCtx) && object.Equals(this.GPURoleKilledCtx, other.GPURoleKilledCtx) && this.ContextCase == other.ContextCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060191F0 RID: 102896 RVA: 0x003A967C File Offset: 0x003A787C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.diePos_ != null)
			{
				num ^= this.DiePos.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapKillCtx)
			{
				num ^= this.TrapDefenseTrapKillCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapSelfDestructCtx)
			{
				num ^= this.TrapDefenseTrapSelfDestructCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseGoldenCoinAbosorbedCtx)
			{
				num ^= this.TrapDefenseGoldenCoinAbosorbedCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseReachInstEndpointCtx)
			{
				num ^= this.TrapDefenseReachInstEndpointCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseEnvironmentalKillCtx)
			{
				num ^= this.TrapDefenseEnvironmentalKillCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseMonsterKilledCtx)
			{
				num ^= this.TrapDefenseMonsterKilledCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseSpcecialCellDestructCtx)
			{
				num ^= this.TrapDefenseSpcecialCellDestructCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsMonsterKilledCtx)
			{
				num ^= this.SurvivorsMonsterKilledCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsGoldenCoinAbosorbedCtx)
			{
				num ^= this.SurvivorsGoldenCoinAbosorbedCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsRoleKilledCtx)
			{
				num ^= this.SurvivorsRoleKilledCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoMonsterKilledCtxPb)
			{
				num ^= this.KurotatoMonsterKilledCtxPb.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoDropAbsorbedCtxPb)
			{
				num ^= this.KurotatoDropAbsorbedCtxPb.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoRoleKilledCtxPb)
			{
				num ^= this.KurotatoRoleKilledCtxPb.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoStructureKilledCtxPb)
			{
				num ^= this.KurotatoStructureKilledCtxPb.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.PinballMonsterKilledCtx)
			{
				num ^= this.PinballMonsterKilledCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.PinballEntityKilledCtx)
			{
				num ^= this.PinballEntityKilledCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.GPUMonsterKilledCtx)
			{
				num ^= this.GPUMonsterKilledCtx.GetHashCode();
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.GPURoleKilledCtx)
			{
				num ^= this.GPURoleKilledCtx.GetHashCode();
			}
			num ^= (int)this.contextCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060191F1 RID: 102897 RVA: 0x003A986B File Offset: 0x003A7A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191F2 RID: 102898 RVA: 0x003A9878 File Offset: 0x003A7A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191F3 RID: 102899 RVA: 0x003A9884 File Offset: 0x003A7A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.diePos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.DiePos);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapKillCtx)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TrapDefenseTrapKillCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapSelfDestructCtx)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TrapDefenseTrapSelfDestructCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseGoldenCoinAbosorbedCtx)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TrapDefenseGoldenCoinAbosorbedCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseReachInstEndpointCtx)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TrapDefenseReachInstEndpointCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseEnvironmentalKillCtx)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TrapDefenseEnvironmentalKillCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseMonsterKilledCtx)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TrapDefenseMonsterKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseSpcecialCellDestructCtx)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TrapDefenseSpcecialCellDestructCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsMonsterKilledCtx)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SurvivorsMonsterKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsGoldenCoinAbosorbedCtx)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SurvivorsGoldenCoinAbosorbedCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsRoleKilledCtx)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.SurvivorsRoleKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoMonsterKilledCtxPb)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.KurotatoMonsterKilledCtxPb);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoDropAbsorbedCtxPb)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.KurotatoDropAbsorbedCtxPb);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoRoleKilledCtxPb)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.KurotatoRoleKilledCtxPb);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.PinballMonsterKilledCtx)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.PinballMonsterKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.PinballEntityKilledCtx)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.PinballEntityKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoStructureKilledCtxPb)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.KurotatoStructureKilledCtxPb);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.GPUMonsterKilledCtx)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.GPUMonsterKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.GPURoleKilledCtx)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.GPURoleKilledCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060191F4 RID: 102900 RVA: 0x003A9AEC File Offset: 0x003A7CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.diePos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DiePos);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapKillCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseTrapKillCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapSelfDestructCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseTrapSelfDestructCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseGoldenCoinAbosorbedCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseGoldenCoinAbosorbedCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseReachInstEndpointCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseReachInstEndpointCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseEnvironmentalKillCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseEnvironmentalKillCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseMonsterKilledCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseMonsterKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseSpcecialCellDestructCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseSpcecialCellDestructCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsMonsterKilledCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsMonsterKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsGoldenCoinAbosorbedCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsGoldenCoinAbosorbedCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsRoleKilledCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsRoleKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoMonsterKilledCtxPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoMonsterKilledCtxPb);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoDropAbsorbedCtxPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoDropAbsorbedCtxPb);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoRoleKilledCtxPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoRoleKilledCtxPb);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoStructureKilledCtxPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KurotatoStructureKilledCtxPb);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.PinballMonsterKilledCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PinballMonsterKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.PinballEntityKilledCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PinballEntityKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.GPUMonsterKilledCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GPUMonsterKilledCtx);
			}
			if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.GPURoleKilledCtx)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GPURoleKilledCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060191F5 RID: 102901 RVA: 0x003A9CF8 File Offset: 0x003A7EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityDieContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.diePos_ != null)
			{
				if (this.diePos_ == null)
				{
					this.DiePos = new Vector();
				}
				this.DiePos.MergeFrom(other.DiePos);
			}
			switch (other.ContextCase)
			{
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapKillCtx:
				if (this.TrapDefenseTrapKillCtx == null)
				{
					this.TrapDefenseTrapKillCtx = new TrapDefenseTrapKillCtxPb();
				}
				this.TrapDefenseTrapKillCtx.MergeFrom(other.TrapDefenseTrapKillCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapSelfDestructCtx:
				if (this.TrapDefenseTrapSelfDestructCtx == null)
				{
					this.TrapDefenseTrapSelfDestructCtx = new TrapDefenseTrapSelfDestructCtxPb();
				}
				this.TrapDefenseTrapSelfDestructCtx.MergeFrom(other.TrapDefenseTrapSelfDestructCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseGoldenCoinAbosorbedCtx:
				if (this.TrapDefenseGoldenCoinAbosorbedCtx == null)
				{
					this.TrapDefenseGoldenCoinAbosorbedCtx = new TrapDefenseGoldenCoinAbosorbedCtxPb();
				}
				this.TrapDefenseGoldenCoinAbosorbedCtx.MergeFrom(other.TrapDefenseGoldenCoinAbosorbedCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseReachInstEndpointCtx:
				if (this.TrapDefenseReachInstEndpointCtx == null)
				{
					this.TrapDefenseReachInstEndpointCtx = new TrapDefenseReachInstEndpointCtxPb();
				}
				this.TrapDefenseReachInstEndpointCtx.MergeFrom(other.TrapDefenseReachInstEndpointCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseEnvironmentalKillCtx:
				if (this.TrapDefenseEnvironmentalKillCtx == null)
				{
					this.TrapDefenseEnvironmentalKillCtx = new TrapDefenseEnvironmentalKillCtxPb();
				}
				this.TrapDefenseEnvironmentalKillCtx.MergeFrom(other.TrapDefenseEnvironmentalKillCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseMonsterKilledCtx:
				if (this.TrapDefenseMonsterKilledCtx == null)
				{
					this.TrapDefenseMonsterKilledCtx = new TrapDefenseMonsterKilledCtxPb();
				}
				this.TrapDefenseMonsterKilledCtx.MergeFrom(other.TrapDefenseMonsterKilledCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseSpcecialCellDestructCtx:
				if (this.TrapDefenseSpcecialCellDestructCtx == null)
				{
					this.TrapDefenseSpcecialCellDestructCtx = new TrapDefenseSpcecialCellDestructCtxPb();
				}
				this.TrapDefenseSpcecialCellDestructCtx.MergeFrom(other.TrapDefenseSpcecialCellDestructCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsMonsterKilledCtx:
				if (this.SurvivorsMonsterKilledCtx == null)
				{
					this.SurvivorsMonsterKilledCtx = new SurvivorsMonsterKilledCtxPb();
				}
				this.SurvivorsMonsterKilledCtx.MergeFrom(other.SurvivorsMonsterKilledCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsGoldenCoinAbosorbedCtx:
				if (this.SurvivorsGoldenCoinAbosorbedCtx == null)
				{
					this.SurvivorsGoldenCoinAbosorbedCtx = new SurvivorsGoldenCoinAbosorbedCtxPb();
				}
				this.SurvivorsGoldenCoinAbosorbedCtx.MergeFrom(other.SurvivorsGoldenCoinAbosorbedCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsRoleKilledCtx:
				if (this.SurvivorsRoleKilledCtx == null)
				{
					this.SurvivorsRoleKilledCtx = new SurvivorsRoleKilledCtxPb();
				}
				this.SurvivorsRoleKilledCtx.MergeFrom(other.SurvivorsRoleKilledCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.KurotatoMonsterKilledCtxPb:
				if (this.KurotatoMonsterKilledCtxPb == null)
				{
					this.KurotatoMonsterKilledCtxPb = new KurotatoMonsterKilledCtxPb();
				}
				this.KurotatoMonsterKilledCtxPb.MergeFrom(other.KurotatoMonsterKilledCtxPb);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.KurotatoDropAbsorbedCtxPb:
				if (this.KurotatoDropAbsorbedCtxPb == null)
				{
					this.KurotatoDropAbsorbedCtxPb = new KurotatoDropAbsorbedCtxPb();
				}
				this.KurotatoDropAbsorbedCtxPb.MergeFrom(other.KurotatoDropAbsorbedCtxPb);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.KurotatoRoleKilledCtxPb:
				if (this.KurotatoRoleKilledCtxPb == null)
				{
					this.KurotatoRoleKilledCtxPb = new KurotatoRoleKilledCtxPb();
				}
				this.KurotatoRoleKilledCtxPb.MergeFrom(other.KurotatoRoleKilledCtxPb);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.PinballMonsterKilledCtx:
				if (this.PinballMonsterKilledCtx == null)
				{
					this.PinballMonsterKilledCtx = new PinballMonsterKilledCtxPb();
				}
				this.PinballMonsterKilledCtx.MergeFrom(other.PinballMonsterKilledCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.PinballEntityKilledCtx:
				if (this.PinballEntityKilledCtx == null)
				{
					this.PinballEntityKilledCtx = new PinballEntityKilledCtxPb();
				}
				this.PinballEntityKilledCtx.MergeFrom(other.PinballEntityKilledCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.KurotatoStructureKilledCtxPb:
				if (this.KurotatoStructureKilledCtxPb == null)
				{
					this.KurotatoStructureKilledCtxPb = new KurotatoStructureKilledCtxPb();
				}
				this.KurotatoStructureKilledCtxPb.MergeFrom(other.KurotatoStructureKilledCtxPb);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.GPUMonsterKilledCtx:
				if (this.GPUMonsterKilledCtx == null)
				{
					this.GPUMonsterKilledCtx = new GPUMonsterKilledCtxPb();
				}
				this.GPUMonsterKilledCtx.MergeFrom(other.GPUMonsterKilledCtx);
				break;
			case SimpleCombatEntityDieContext.ContextOneofCase.GPURoleKilledCtx:
				if (this.GPURoleKilledCtx == null)
				{
					this.GPURoleKilledCtx = new GPURoleKilledCtxPb();
				}
				this.GPURoleKilledCtx.MergeFrom(other.GPURoleKilledCtx);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060191F6 RID: 102902 RVA: 0x003AA07C File Offset: 0x003A827C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060191F7 RID: 102903 RVA: 0x003AA088 File Offset: 0x003A8288
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
				if (num <= 82U)
				{
					if (num <= 42U)
					{
						if (num <= 26U)
						{
							if (num == 10U)
							{
								if (this.diePos_ == null)
								{
									this.DiePos = new Vector();
								}
								input.ReadMessage(this.DiePos);
								continue;
							}
							if (num == 26U)
							{
								TrapDefenseTrapKillCtxPb trapDefenseTrapKillCtxPb = new TrapDefenseTrapKillCtxPb();
								if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapKillCtx)
								{
									trapDefenseTrapKillCtxPb.MergeFrom(this.TrapDefenseTrapKillCtx);
								}
								input.ReadMessage(trapDefenseTrapKillCtxPb);
								this.TrapDefenseTrapKillCtx = trapDefenseTrapKillCtxPb;
								continue;
							}
						}
						else
						{
							if (num == 34U)
							{
								TrapDefenseTrapSelfDestructCtxPb trapDefenseTrapSelfDestructCtxPb = new TrapDefenseTrapSelfDestructCtxPb();
								if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseTrapSelfDestructCtx)
								{
									trapDefenseTrapSelfDestructCtxPb.MergeFrom(this.TrapDefenseTrapSelfDestructCtx);
								}
								input.ReadMessage(trapDefenseTrapSelfDestructCtxPb);
								this.TrapDefenseTrapSelfDestructCtx = trapDefenseTrapSelfDestructCtxPb;
								continue;
							}
							if (num == 42U)
							{
								TrapDefenseGoldenCoinAbosorbedCtxPb trapDefenseGoldenCoinAbosorbedCtxPb = new TrapDefenseGoldenCoinAbosorbedCtxPb();
								if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseGoldenCoinAbosorbedCtx)
								{
									trapDefenseGoldenCoinAbosorbedCtxPb.MergeFrom(this.TrapDefenseGoldenCoinAbosorbedCtx);
								}
								input.ReadMessage(trapDefenseGoldenCoinAbosorbedCtxPb);
								this.TrapDefenseGoldenCoinAbosorbedCtx = trapDefenseGoldenCoinAbosorbedCtxPb;
								continue;
							}
						}
					}
					else if (num <= 58U)
					{
						if (num == 50U)
						{
							TrapDefenseReachInstEndpointCtxPb trapDefenseReachInstEndpointCtxPb = new TrapDefenseReachInstEndpointCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseReachInstEndpointCtx)
							{
								trapDefenseReachInstEndpointCtxPb.MergeFrom(this.TrapDefenseReachInstEndpointCtx);
							}
							input.ReadMessage(trapDefenseReachInstEndpointCtxPb);
							this.TrapDefenseReachInstEndpointCtx = trapDefenseReachInstEndpointCtxPb;
							continue;
						}
						if (num == 58U)
						{
							TrapDefenseEnvironmentalKillCtxPb trapDefenseEnvironmentalKillCtxPb = new TrapDefenseEnvironmentalKillCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseEnvironmentalKillCtx)
							{
								trapDefenseEnvironmentalKillCtxPb.MergeFrom(this.TrapDefenseEnvironmentalKillCtx);
							}
							input.ReadMessage(trapDefenseEnvironmentalKillCtxPb);
							this.TrapDefenseEnvironmentalKillCtx = trapDefenseEnvironmentalKillCtxPb;
							continue;
						}
					}
					else
					{
						if (num == 66U)
						{
							TrapDefenseMonsterKilledCtxPb trapDefenseMonsterKilledCtxPb = new TrapDefenseMonsterKilledCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseMonsterKilledCtx)
							{
								trapDefenseMonsterKilledCtxPb.MergeFrom(this.TrapDefenseMonsterKilledCtx);
							}
							input.ReadMessage(trapDefenseMonsterKilledCtxPb);
							this.TrapDefenseMonsterKilledCtx = trapDefenseMonsterKilledCtxPb;
							continue;
						}
						if (num == 74U)
						{
							TrapDefenseSpcecialCellDestructCtxPb trapDefenseSpcecialCellDestructCtxPb = new TrapDefenseSpcecialCellDestructCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.TrapDefenseSpcecialCellDestructCtx)
							{
								trapDefenseSpcecialCellDestructCtxPb.MergeFrom(this.TrapDefenseSpcecialCellDestructCtx);
							}
							input.ReadMessage(trapDefenseSpcecialCellDestructCtxPb);
							this.TrapDefenseSpcecialCellDestructCtx = trapDefenseSpcecialCellDestructCtxPb;
							continue;
						}
						if (num == 82U)
						{
							SurvivorsMonsterKilledCtxPb survivorsMonsterKilledCtxPb = new SurvivorsMonsterKilledCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsMonsterKilledCtx)
							{
								survivorsMonsterKilledCtxPb.MergeFrom(this.SurvivorsMonsterKilledCtx);
							}
							input.ReadMessage(survivorsMonsterKilledCtxPb);
							this.SurvivorsMonsterKilledCtx = survivorsMonsterKilledCtxPb;
							continue;
						}
					}
				}
				else if (num <= 122U)
				{
					if (num <= 98U)
					{
						if (num == 90U)
						{
							SurvivorsGoldenCoinAbosorbedCtxPb survivorsGoldenCoinAbosorbedCtxPb = new SurvivorsGoldenCoinAbosorbedCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsGoldenCoinAbosorbedCtx)
							{
								survivorsGoldenCoinAbosorbedCtxPb.MergeFrom(this.SurvivorsGoldenCoinAbosorbedCtx);
							}
							input.ReadMessage(survivorsGoldenCoinAbosorbedCtxPb);
							this.SurvivorsGoldenCoinAbosorbedCtx = survivorsGoldenCoinAbosorbedCtxPb;
							continue;
						}
						if (num == 98U)
						{
							SurvivorsRoleKilledCtxPb survivorsRoleKilledCtxPb = new SurvivorsRoleKilledCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.SurvivorsRoleKilledCtx)
							{
								survivorsRoleKilledCtxPb.MergeFrom(this.SurvivorsRoleKilledCtx);
							}
							input.ReadMessage(survivorsRoleKilledCtxPb);
							this.SurvivorsRoleKilledCtx = survivorsRoleKilledCtxPb;
							continue;
						}
					}
					else
					{
						if (num == 106U)
						{
							KurotatoMonsterKilledCtxPb kurotatoMonsterKilledCtxPb = new KurotatoMonsterKilledCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoMonsterKilledCtxPb)
							{
								kurotatoMonsterKilledCtxPb.MergeFrom(this.KurotatoMonsterKilledCtxPb);
							}
							input.ReadMessage(kurotatoMonsterKilledCtxPb);
							this.KurotatoMonsterKilledCtxPb = kurotatoMonsterKilledCtxPb;
							continue;
						}
						if (num == 114U)
						{
							KurotatoDropAbsorbedCtxPb kurotatoDropAbsorbedCtxPb = new KurotatoDropAbsorbedCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoDropAbsorbedCtxPb)
							{
								kurotatoDropAbsorbedCtxPb.MergeFrom(this.KurotatoDropAbsorbedCtxPb);
							}
							input.ReadMessage(kurotatoDropAbsorbedCtxPb);
							this.KurotatoDropAbsorbedCtxPb = kurotatoDropAbsorbedCtxPb;
							continue;
						}
						if (num == 122U)
						{
							KurotatoRoleKilledCtxPb kurotatoRoleKilledCtxPb = new KurotatoRoleKilledCtxPb();
							if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoRoleKilledCtxPb)
							{
								kurotatoRoleKilledCtxPb.MergeFrom(this.KurotatoRoleKilledCtxPb);
							}
							input.ReadMessage(kurotatoRoleKilledCtxPb);
							this.KurotatoRoleKilledCtxPb = kurotatoRoleKilledCtxPb;
							continue;
						}
					}
				}
				else if (num <= 138U)
				{
					if (num == 130U)
					{
						PinballMonsterKilledCtxPb pinballMonsterKilledCtxPb = new PinballMonsterKilledCtxPb();
						if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.PinballMonsterKilledCtx)
						{
							pinballMonsterKilledCtxPb.MergeFrom(this.PinballMonsterKilledCtx);
						}
						input.ReadMessage(pinballMonsterKilledCtxPb);
						this.PinballMonsterKilledCtx = pinballMonsterKilledCtxPb;
						continue;
					}
					if (num == 138U)
					{
						PinballEntityKilledCtxPb pinballEntityKilledCtxPb = new PinballEntityKilledCtxPb();
						if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.PinballEntityKilledCtx)
						{
							pinballEntityKilledCtxPb.MergeFrom(this.PinballEntityKilledCtx);
						}
						input.ReadMessage(pinballEntityKilledCtxPb);
						this.PinballEntityKilledCtx = pinballEntityKilledCtxPb;
						continue;
					}
				}
				else
				{
					if (num == 146U)
					{
						KurotatoStructureKilledCtxPb kurotatoStructureKilledCtxPb = new KurotatoStructureKilledCtxPb();
						if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.KurotatoStructureKilledCtxPb)
						{
							kurotatoStructureKilledCtxPb.MergeFrom(this.KurotatoStructureKilledCtxPb);
						}
						input.ReadMessage(kurotatoStructureKilledCtxPb);
						this.KurotatoStructureKilledCtxPb = kurotatoStructureKilledCtxPb;
						continue;
					}
					if (num == 154U)
					{
						GPUMonsterKilledCtxPb gpumonsterKilledCtxPb = new GPUMonsterKilledCtxPb();
						if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.GPUMonsterKilledCtx)
						{
							gpumonsterKilledCtxPb.MergeFrom(this.GPUMonsterKilledCtx);
						}
						input.ReadMessage(gpumonsterKilledCtxPb);
						this.GPUMonsterKilledCtx = gpumonsterKilledCtxPb;
						continue;
					}
					if (num == 162U)
					{
						GPURoleKilledCtxPb gpuroleKilledCtxPb = new GPURoleKilledCtxPb();
						if (this.contextCase_ == SimpleCombatEntityDieContext.ContextOneofCase.GPURoleKilledCtx)
						{
							gpuroleKilledCtxPb.MergeFrom(this.GPURoleKilledCtx);
						}
						input.ReadMessage(gpuroleKilledCtxPb);
						this.GPURoleKilledCtx = gpuroleKilledCtxPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040094BA RID: 38074
		private static readonly MessageParser<SimpleCombatEntityDieContext> _parser = new MessageParser<SimpleCombatEntityDieContext>(() => new SimpleCombatEntityDieContext());

		// Token: 0x040094BB RID: 38075
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094BC RID: 38076
		public const int DiePosFieldNumber = 1;

		// Token: 0x040094BD RID: 38077
		private Vector diePos_;

		// Token: 0x040094BE RID: 38078
		public const int TrapDefenseTrapKillCtxFieldNumber = 3;

		// Token: 0x040094BF RID: 38079
		public const int TrapDefenseTrapSelfDestructCtxFieldNumber = 4;

		// Token: 0x040094C0 RID: 38080
		public const int TrapDefenseGoldenCoinAbosorbedCtxFieldNumber = 5;

		// Token: 0x040094C1 RID: 38081
		public const int TrapDefenseReachInstEndpointCtxFieldNumber = 6;

		// Token: 0x040094C2 RID: 38082
		public const int TrapDefenseEnvironmentalKillCtxFieldNumber = 7;

		// Token: 0x040094C3 RID: 38083
		public const int TrapDefenseMonsterKilledCtxFieldNumber = 8;

		// Token: 0x040094C4 RID: 38084
		public const int TrapDefenseSpcecialCellDestructCtxFieldNumber = 9;

		// Token: 0x040094C5 RID: 38085
		public const int SurvivorsMonsterKilledCtxFieldNumber = 10;

		// Token: 0x040094C6 RID: 38086
		public const int SurvivorsGoldenCoinAbosorbedCtxFieldNumber = 11;

		// Token: 0x040094C7 RID: 38087
		public const int SurvivorsRoleKilledCtxFieldNumber = 12;

		// Token: 0x040094C8 RID: 38088
		public const int KurotatoMonsterKilledCtxPbFieldNumber = 13;

		// Token: 0x040094C9 RID: 38089
		public const int KurotatoDropAbsorbedCtxPbFieldNumber = 14;

		// Token: 0x040094CA RID: 38090
		public const int KurotatoRoleKilledCtxPbFieldNumber = 15;

		// Token: 0x040094CB RID: 38091
		public const int KurotatoStructureKilledCtxPbFieldNumber = 18;

		// Token: 0x040094CC RID: 38092
		public const int PinballMonsterKilledCtxFieldNumber = 16;

		// Token: 0x040094CD RID: 38093
		public const int PinballEntityKilledCtxFieldNumber = 17;

		// Token: 0x040094CE RID: 38094
		public const int GPUMonsterKilledCtxFieldNumber = 19;

		// Token: 0x040094CF RID: 38095
		public const int GPURoleKilledCtxFieldNumber = 20;

		// Token: 0x040094D0 RID: 38096
		private object context_;

		// Token: 0x040094D1 RID: 38097
		private SimpleCombatEntityDieContext.ContextOneofCase contextCase_;

		// Token: 0x02001A21 RID: 6689
		public enum ContextOneofCase
		{
			// Token: 0x0400CF5F RID: 53087
			None,
			// Token: 0x0400CF60 RID: 53088
			TrapDefenseTrapKillCtx = 3,
			// Token: 0x0400CF61 RID: 53089
			TrapDefenseTrapSelfDestructCtx,
			// Token: 0x0400CF62 RID: 53090
			TrapDefenseGoldenCoinAbosorbedCtx,
			// Token: 0x0400CF63 RID: 53091
			TrapDefenseReachInstEndpointCtx,
			// Token: 0x0400CF64 RID: 53092
			TrapDefenseEnvironmentalKillCtx,
			// Token: 0x0400CF65 RID: 53093
			TrapDefenseMonsterKilledCtx,
			// Token: 0x0400CF66 RID: 53094
			TrapDefenseSpcecialCellDestructCtx,
			// Token: 0x0400CF67 RID: 53095
			SurvivorsMonsterKilledCtx,
			// Token: 0x0400CF68 RID: 53096
			SurvivorsGoldenCoinAbosorbedCtx,
			// Token: 0x0400CF69 RID: 53097
			SurvivorsRoleKilledCtx,
			// Token: 0x0400CF6A RID: 53098
			KurotatoMonsterKilledCtxPb,
			// Token: 0x0400CF6B RID: 53099
			KurotatoDropAbsorbedCtxPb,
			// Token: 0x0400CF6C RID: 53100
			KurotatoRoleKilledCtxPb,
			// Token: 0x0400CF6D RID: 53101
			KurotatoStructureKilledCtxPb = 18,
			// Token: 0x0400CF6E RID: 53102
			PinballMonsterKilledCtx = 16,
			// Token: 0x0400CF6F RID: 53103
			PinballEntityKilledCtx,
			// Token: 0x0400CF70 RID: 53104
			GPUMonsterKilledCtx = 19,
			// Token: 0x0400CF71 RID: 53105
			GPURoleKilledCtx
		}
	}
}
