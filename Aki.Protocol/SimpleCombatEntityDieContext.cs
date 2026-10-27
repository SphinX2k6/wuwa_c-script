using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001224 RID: 4644
	public sealed class SimpleCombatEntityDieContext : IMessage<SimpleCombatEntityDieContext>, IMessage, IEquatable<SimpleCombatEntityDieContext>, IDeepCloneable<SimpleCombatEntityDieContext>, IBufferMessage
	{
		// Token: 0x06018BE5 RID: 101349 RVA: 0x00399046 File Offset: 0x00397246
		[NullableContext(1)]
		public static SimpleCombatEntityDieContext Create()
		{
			return new SimpleCombatEntityDieContext();
		}

		// Token: 0x1700535D RID: 21341
		// (get) Token: 0x06018BE6 RID: 101350 RVA: 0x0039904D File Offset: 0x0039724D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SimpleCombatEntityDieContext> Parser
		{
			get
			{
				return SimpleCombatEntityDieContext._parser;
			}
		}

		// Token: 0x1700535E RID: 21342
		// (get) Token: 0x06018BE7 RID: 101351 RVA: 0x00399054 File Offset: 0x00397254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700535F RID: 21343
		// (get) Token: 0x06018BE8 RID: 101352 RVA: 0x00399057 File Offset: 0x00397257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityDieContext.Descriptor;
			}
		}

		// Token: 0x06018BE9 RID: 101353 RVA: 0x0039905E File Offset: 0x0039725E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieContext()
		{
		}

		// Token: 0x06018BEA RID: 101354 RVA: 0x00399068 File Offset: 0x00397268
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

		// Token: 0x06018BEB RID: 101355 RVA: 0x00399279 File Offset: 0x00397479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieContext Clone()
		{
			return new SimpleCombatEntityDieContext(this);
		}

		// Token: 0x17005360 RID: 21344
		// (get) Token: 0x06018BEC RID: 101356 RVA: 0x00399281 File Offset: 0x00397481
		// (set) Token: 0x06018BED RID: 101357 RVA: 0x00399289 File Offset: 0x00397489
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

		// Token: 0x17005361 RID: 21345
		// (get) Token: 0x06018BEE RID: 101358 RVA: 0x00399292 File Offset: 0x00397492
		// (set) Token: 0x06018BEF RID: 101359 RVA: 0x003992AA File Offset: 0x003974AA
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

		// Token: 0x17005362 RID: 21346
		// (get) Token: 0x06018BF0 RID: 101360 RVA: 0x003992C0 File Offset: 0x003974C0
		// (set) Token: 0x06018BF1 RID: 101361 RVA: 0x003992D8 File Offset: 0x003974D8
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

		// Token: 0x17005363 RID: 21347
		// (get) Token: 0x06018BF2 RID: 101362 RVA: 0x003992EE File Offset: 0x003974EE
		// (set) Token: 0x06018BF3 RID: 101363 RVA: 0x00399306 File Offset: 0x00397506
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

		// Token: 0x17005364 RID: 21348
		// (get) Token: 0x06018BF4 RID: 101364 RVA: 0x0039931C File Offset: 0x0039751C
		// (set) Token: 0x06018BF5 RID: 101365 RVA: 0x00399334 File Offset: 0x00397534
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

		// Token: 0x17005365 RID: 21349
		// (get) Token: 0x06018BF6 RID: 101366 RVA: 0x0039934A File Offset: 0x0039754A
		// (set) Token: 0x06018BF7 RID: 101367 RVA: 0x00399362 File Offset: 0x00397562
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

		// Token: 0x17005366 RID: 21350
		// (get) Token: 0x06018BF8 RID: 101368 RVA: 0x00399378 File Offset: 0x00397578
		// (set) Token: 0x06018BF9 RID: 101369 RVA: 0x00399390 File Offset: 0x00397590
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

		// Token: 0x17005367 RID: 21351
		// (get) Token: 0x06018BFA RID: 101370 RVA: 0x003993A6 File Offset: 0x003975A6
		// (set) Token: 0x06018BFB RID: 101371 RVA: 0x003993BF File Offset: 0x003975BF
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

		// Token: 0x17005368 RID: 21352
		// (get) Token: 0x06018BFC RID: 101372 RVA: 0x003993D6 File Offset: 0x003975D6
		// (set) Token: 0x06018BFD RID: 101373 RVA: 0x003993EF File Offset: 0x003975EF
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

		// Token: 0x17005369 RID: 21353
		// (get) Token: 0x06018BFE RID: 101374 RVA: 0x00399406 File Offset: 0x00397606
		// (set) Token: 0x06018BFF RID: 101375 RVA: 0x0039941F File Offset: 0x0039761F
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

		// Token: 0x1700536A RID: 21354
		// (get) Token: 0x06018C00 RID: 101376 RVA: 0x00399436 File Offset: 0x00397636
		// (set) Token: 0x06018C01 RID: 101377 RVA: 0x0039944F File Offset: 0x0039764F
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

		// Token: 0x1700536B RID: 21355
		// (get) Token: 0x06018C02 RID: 101378 RVA: 0x00399466 File Offset: 0x00397666
		// (set) Token: 0x06018C03 RID: 101379 RVA: 0x0039947F File Offset: 0x0039767F
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

		// Token: 0x1700536C RID: 21356
		// (get) Token: 0x06018C04 RID: 101380 RVA: 0x00399496 File Offset: 0x00397696
		// (set) Token: 0x06018C05 RID: 101381 RVA: 0x003994AF File Offset: 0x003976AF
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

		// Token: 0x1700536D RID: 21357
		// (get) Token: 0x06018C06 RID: 101382 RVA: 0x003994C6 File Offset: 0x003976C6
		// (set) Token: 0x06018C07 RID: 101383 RVA: 0x003994DF File Offset: 0x003976DF
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

		// Token: 0x1700536E RID: 21358
		// (get) Token: 0x06018C08 RID: 101384 RVA: 0x003994F6 File Offset: 0x003976F6
		// (set) Token: 0x06018C09 RID: 101385 RVA: 0x0039950F File Offset: 0x0039770F
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

		// Token: 0x1700536F RID: 21359
		// (get) Token: 0x06018C0A RID: 101386 RVA: 0x00399526 File Offset: 0x00397726
		// (set) Token: 0x06018C0B RID: 101387 RVA: 0x0039953F File Offset: 0x0039773F
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

		// Token: 0x17005370 RID: 21360
		// (get) Token: 0x06018C0C RID: 101388 RVA: 0x00399556 File Offset: 0x00397756
		// (set) Token: 0x06018C0D RID: 101389 RVA: 0x0039956F File Offset: 0x0039776F
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

		// Token: 0x17005371 RID: 21361
		// (get) Token: 0x06018C0E RID: 101390 RVA: 0x00399586 File Offset: 0x00397786
		// (set) Token: 0x06018C0F RID: 101391 RVA: 0x0039959F File Offset: 0x0039779F
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

		// Token: 0x17005372 RID: 21362
		// (get) Token: 0x06018C10 RID: 101392 RVA: 0x003995B6 File Offset: 0x003977B6
		// (set) Token: 0x06018C11 RID: 101393 RVA: 0x003995CF File Offset: 0x003977CF
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

		// Token: 0x17005373 RID: 21363
		// (get) Token: 0x06018C12 RID: 101394 RVA: 0x003995E6 File Offset: 0x003977E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieContext.ContextOneofCase ContextCase
		{
			get
			{
				return this.contextCase_;
			}
		}

		// Token: 0x06018C13 RID: 101395 RVA: 0x003995EE File Offset: 0x003977EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearContext()
		{
			this.contextCase_ = SimpleCombatEntityDieContext.ContextOneofCase.None;
			this.context_ = null;
		}

		// Token: 0x06018C14 RID: 101396 RVA: 0x003995FE File Offset: 0x003977FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityDieContext);
		}

		// Token: 0x06018C15 RID: 101397 RVA: 0x0039960C File Offset: 0x0039780C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityDieContext other)
		{
			return other != null && (other == this || (object.Equals(this.DiePos, other.DiePos) && object.Equals(this.TrapDefenseTrapKillCtx, other.TrapDefenseTrapKillCtx) && object.Equals(this.TrapDefenseTrapSelfDestructCtx, other.TrapDefenseTrapSelfDestructCtx) && object.Equals(this.TrapDefenseGoldenCoinAbosorbedCtx, other.TrapDefenseGoldenCoinAbosorbedCtx) && object.Equals(this.TrapDefenseReachInstEndpointCtx, other.TrapDefenseReachInstEndpointCtx) && object.Equals(this.TrapDefenseEnvironmentalKillCtx, other.TrapDefenseEnvironmentalKillCtx) && object.Equals(this.TrapDefenseMonsterKilledCtx, other.TrapDefenseMonsterKilledCtx) && object.Equals(this.TrapDefenseSpcecialCellDestructCtx, other.TrapDefenseSpcecialCellDestructCtx) && object.Equals(this.SurvivorsMonsterKilledCtx, other.SurvivorsMonsterKilledCtx) && object.Equals(this.SurvivorsGoldenCoinAbosorbedCtx, other.SurvivorsGoldenCoinAbosorbedCtx) && object.Equals(this.SurvivorsRoleKilledCtx, other.SurvivorsRoleKilledCtx) && object.Equals(this.KurotatoMonsterKilledCtxPb, other.KurotatoMonsterKilledCtxPb) && object.Equals(this.KurotatoDropAbsorbedCtxPb, other.KurotatoDropAbsorbedCtxPb) && object.Equals(this.KurotatoRoleKilledCtxPb, other.KurotatoRoleKilledCtxPb) && object.Equals(this.KurotatoStructureKilledCtxPb, other.KurotatoStructureKilledCtxPb) && object.Equals(this.PinballMonsterKilledCtx, other.PinballMonsterKilledCtx) && object.Equals(this.PinballEntityKilledCtx, other.PinballEntityKilledCtx) && object.Equals(this.GPUMonsterKilledCtx, other.GPUMonsterKilledCtx) && object.Equals(this.GPURoleKilledCtx, other.GPURoleKilledCtx) && this.ContextCase == other.ContextCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C16 RID: 101398 RVA: 0x003997D4 File Offset: 0x003979D4
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

		// Token: 0x06018C17 RID: 101399 RVA: 0x003999C3 File Offset: 0x00397BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C18 RID: 101400 RVA: 0x003999D0 File Offset: 0x00397BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C19 RID: 101401 RVA: 0x003999DC File Offset: 0x00397BDC
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

		// Token: 0x06018C1A RID: 101402 RVA: 0x00399C44 File Offset: 0x00397E44
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

		// Token: 0x06018C1B RID: 101403 RVA: 0x00399E50 File Offset: 0x00398050
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

		// Token: 0x06018C1C RID: 101404 RVA: 0x0039A1D4 File Offset: 0x003983D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C1D RID: 101405 RVA: 0x0039A1E0 File Offset: 0x003983E0
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

		// Token: 0x04009209 RID: 37385
		private static readonly MessageParser<SimpleCombatEntityDieContext> _parser = new MessageParser<SimpleCombatEntityDieContext>(() => new SimpleCombatEntityDieContext());

		// Token: 0x0400920A RID: 37386
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400920B RID: 37387
		public const int DiePosFieldNumber = 1;

		// Token: 0x0400920C RID: 37388
		private Vector diePos_;

		// Token: 0x0400920D RID: 37389
		public const int TrapDefenseTrapKillCtxFieldNumber = 3;

		// Token: 0x0400920E RID: 37390
		public const int TrapDefenseTrapSelfDestructCtxFieldNumber = 4;

		// Token: 0x0400920F RID: 37391
		public const int TrapDefenseGoldenCoinAbosorbedCtxFieldNumber = 5;

		// Token: 0x04009210 RID: 37392
		public const int TrapDefenseReachInstEndpointCtxFieldNumber = 6;

		// Token: 0x04009211 RID: 37393
		public const int TrapDefenseEnvironmentalKillCtxFieldNumber = 7;

		// Token: 0x04009212 RID: 37394
		public const int TrapDefenseMonsterKilledCtxFieldNumber = 8;

		// Token: 0x04009213 RID: 37395
		public const int TrapDefenseSpcecialCellDestructCtxFieldNumber = 9;

		// Token: 0x04009214 RID: 37396
		public const int SurvivorsMonsterKilledCtxFieldNumber = 10;

		// Token: 0x04009215 RID: 37397
		public const int SurvivorsGoldenCoinAbosorbedCtxFieldNumber = 11;

		// Token: 0x04009216 RID: 37398
		public const int SurvivorsRoleKilledCtxFieldNumber = 12;

		// Token: 0x04009217 RID: 37399
		public const int KurotatoMonsterKilledCtxPbFieldNumber = 13;

		// Token: 0x04009218 RID: 37400
		public const int KurotatoDropAbsorbedCtxPbFieldNumber = 14;

		// Token: 0x04009219 RID: 37401
		public const int KurotatoRoleKilledCtxPbFieldNumber = 15;

		// Token: 0x0400921A RID: 37402
		public const int KurotatoStructureKilledCtxPbFieldNumber = 18;

		// Token: 0x0400921B RID: 37403
		public const int PinballMonsterKilledCtxFieldNumber = 16;

		// Token: 0x0400921C RID: 37404
		public const int PinballEntityKilledCtxFieldNumber = 17;

		// Token: 0x0400921D RID: 37405
		public const int GPUMonsterKilledCtxFieldNumber = 19;

		// Token: 0x0400921E RID: 37406
		public const int GPURoleKilledCtxFieldNumber = 20;

		// Token: 0x0400921F RID: 37407
		private object context_;

		// Token: 0x04009220 RID: 37408
		private SimpleCombatEntityDieContext.ContextOneofCase contextCase_;

		// Token: 0x02001995 RID: 6549
		public enum ContextOneofCase
		{
			// Token: 0x0400CA14 RID: 51732
			None,
			// Token: 0x0400CA15 RID: 51733
			TrapDefenseTrapKillCtx = 3,
			// Token: 0x0400CA16 RID: 51734
			TrapDefenseTrapSelfDestructCtx,
			// Token: 0x0400CA17 RID: 51735
			TrapDefenseGoldenCoinAbosorbedCtx,
			// Token: 0x0400CA18 RID: 51736
			TrapDefenseReachInstEndpointCtx,
			// Token: 0x0400CA19 RID: 51737
			TrapDefenseEnvironmentalKillCtx,
			// Token: 0x0400CA1A RID: 51738
			TrapDefenseMonsterKilledCtx,
			// Token: 0x0400CA1B RID: 51739
			TrapDefenseSpcecialCellDestructCtx,
			// Token: 0x0400CA1C RID: 51740
			SurvivorsMonsterKilledCtx,
			// Token: 0x0400CA1D RID: 51741
			SurvivorsGoldenCoinAbosorbedCtx,
			// Token: 0x0400CA1E RID: 51742
			SurvivorsRoleKilledCtx,
			// Token: 0x0400CA1F RID: 51743
			KurotatoMonsterKilledCtxPb,
			// Token: 0x0400CA20 RID: 51744
			KurotatoDropAbsorbedCtxPb,
			// Token: 0x0400CA21 RID: 51745
			KurotatoRoleKilledCtxPb,
			// Token: 0x0400CA22 RID: 51746
			KurotatoStructureKilledCtxPb = 18,
			// Token: 0x0400CA23 RID: 51747
			PinballMonsterKilledCtx = 16,
			// Token: 0x0400CA24 RID: 51748
			PinballEntityKilledCtx,
			// Token: 0x0400CA25 RID: 51749
			GPUMonsterKilledCtx = 19,
			// Token: 0x0400CA26 RID: 51750
			GPURoleKilledCtx
		}
	}
}
