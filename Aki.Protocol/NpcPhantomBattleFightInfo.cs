using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B63 RID: 2915
	public sealed class NpcPhantomBattleFightInfo : IMessage<NpcPhantomBattleFightInfo>, IMessage, IEquatable<NpcPhantomBattleFightInfo>, IDeepCloneable<NpcPhantomBattleFightInfo>, IBufferMessage
	{
		// Token: 0x0600FCF2 RID: 64754 RVA: 0x0024E02B File Offset: 0x0024C22B
		[NullableContext(1)]
		public static NpcPhantomBattleFightInfo Create()
		{
			return new NpcPhantomBattleFightInfo();
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600FCF3 RID: 64755 RVA: 0x0024E032 File Offset: 0x0024C232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcPhantomBattleFightInfo> Parser
		{
			get
			{
				return NpcPhantomBattleFightInfo._parser;
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600FCF4 RID: 64756 RVA: 0x0024E039 File Offset: 0x0024C239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600FCF5 RID: 64757 RVA: 0x0024E03C File Offset: 0x0024C23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleFightInfo.Descriptor;
			}
		}

		// Token: 0x0600FCF6 RID: 64758 RVA: 0x0024E043 File Offset: 0x0024C243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfo()
		{
		}

		// Token: 0x0600FCF7 RID: 64759 RVA: 0x0024E04C File Offset: 0x0024C24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfo(NpcPhantomBattleFightInfo other) : this()
		{
			switch (other.NpcPhantomBattleFightInfoCtxCase)
			{
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleEvolveInfo:
				this.PhantomBattleEvolveInfo = other.PhantomBattleEvolveInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSlotInsteadInfo:
				this.PhantomBattleSlotInsteadInfo = other.PhantomBattleSlotInsteadInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSkillTriggerInfo:
				this.PhantomBattleSkillTriggerInfo = other.PhantomBattleSkillTriggerInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleBuffTriggerInfo:
				this.PhantomBattleBuffTriggerInfo = other.PhantomBattleBuffTriggerInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardSkillInfo:
				this.NpcPhantomBattleCardSkillInfo = other.NpcPhantomBattleCardSkillInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardRoleSkillInfo:
				this.NpcPhantomBattleCardRoleSkillInfo = other.NpcPhantomBattleCardRoleSkillInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleGamerStatusInfo:
				this.NpcPhantomBattleGamerStatusInfo = other.NpcPhantomBattleGamerStatusInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardAttrInfo:
				this.NpcPhantomBattleCardAttrInfo = other.NpcPhantomBattleCardAttrInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleEnterSlotInfo:
				this.NpcPhantomBattleEnterSlotInfo = other.NpcPhantomBattleEnterSlotInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackCardLibrary:
				this.NpcPhantomBattleBackCardLibrary = other.NpcPhantomBattleBackCardLibrary.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDiscardInfo:
				this.NpcPhantomBattleDiscardInfo = other.NpcPhantomBattleDiscardInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomFourCTaskDealCardInfo:
				this.NpcPhantomFourCTaskDealCardInfo = other.NpcPhantomFourCTaskDealCardInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomLeaveSlot:
				this.NpcPhantomLeaveSlot = other.NpcPhantomLeaveSlot.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackSlotCardLibrary:
				this.NpcPhantomBattleBackSlotCardLibrary = other.NpcPhantomBattleBackSlotCardLibrary.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleReserveCardInfo:
				this.NpcPhantomBattleReserveCardInfo = other.NpcPhantomBattleReserveCardInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleNpcCardUpdateInfo:
				this.PhantomBattleNpcCardUpdateInfo = other.PhantomBattleNpcCardUpdateInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDurableEmptyInfo:
				this.NpcPhantomBattleDurableEmptyInfo = other.NpcPhantomBattleDurableEmptyInfo.Clone();
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardDurableSkillInfo:
				this.NpcPhantomBattleCardDurableSkillInfo = other.NpcPhantomBattleCardDurableSkillInfo.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FCF8 RID: 64760 RVA: 0x0024E245 File Offset: 0x0024C445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfo Clone()
		{
			return new NpcPhantomBattleFightInfo(this);
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600FCF9 RID: 64761 RVA: 0x0024E24D File Offset: 0x0024C44D
		// (set) Token: 0x0600FCFA RID: 64762 RVA: 0x0024E265 File Offset: 0x0024C465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEvolveInfo PhantomBattleEvolveInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleEvolveInfo)
				{
					return null;
				}
				return (NpcPhantomBattleEvolveInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleEvolveInfo);
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600FCFB RID: 64763 RVA: 0x0024E27B File Offset: 0x0024C47B
		// (set) Token: 0x0600FCFC RID: 64764 RVA: 0x0024E293 File Offset: 0x0024C493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleSlotInsteadInfo PhantomBattleSlotInsteadInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSlotInsteadInfo)
				{
					return null;
				}
				return (NpcPhantomBattleSlotInsteadInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSlotInsteadInfo);
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600FCFD RID: 64765 RVA: 0x0024E2A9 File Offset: 0x0024C4A9
		// (set) Token: 0x0600FCFE RID: 64766 RVA: 0x0024E2C1 File Offset: 0x0024C4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo PhantomBattleSkillTriggerInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSkillTriggerInfo)
				{
					return null;
				}
				return (PhantomBattleSkillTriggerInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSkillTriggerInfo);
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600FCFF RID: 64767 RVA: 0x0024E2D7 File Offset: 0x0024C4D7
		// (set) Token: 0x0600FD00 RID: 64768 RVA: 0x0024E2EF File Offset: 0x0024C4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfo PhantomBattleBuffTriggerInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleBuffTriggerInfo)
				{
					return null;
				}
				return (PhantomBattleBuffTriggerInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleBuffTriggerInfo);
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600FD01 RID: 64769 RVA: 0x0024E305 File Offset: 0x0024C505
		// (set) Token: 0x0600FD02 RID: 64770 RVA: 0x0024E31D File Offset: 0x0024C51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSkillInfo NpcPhantomBattleCardSkillInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardSkillInfo)
				{
					return null;
				}
				return (NpcPhantomBattleCardSkillInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardSkillInfo);
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600FD03 RID: 64771 RVA: 0x0024E333 File Offset: 0x0024C533
		// (set) Token: 0x0600FD04 RID: 64772 RVA: 0x0024E34B File Offset: 0x0024C54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardRoleSkillInfo NpcPhantomBattleCardRoleSkillInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardRoleSkillInfo)
				{
					return null;
				}
				return (NpcPhantomBattleCardRoleSkillInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardRoleSkillInfo);
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600FD05 RID: 64773 RVA: 0x0024E361 File Offset: 0x0024C561
		// (set) Token: 0x0600FD06 RID: 64774 RVA: 0x0024E379 File Offset: 0x0024C579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleGamerStatusInfo NpcPhantomBattleGamerStatusInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleGamerStatusInfo)
				{
					return null;
				}
				return (NpcPhantomBattleGamerStatusInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleGamerStatusInfo);
			}
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600FD07 RID: 64775 RVA: 0x0024E38F File Offset: 0x0024C58F
		// (set) Token: 0x0600FD08 RID: 64776 RVA: 0x0024E3A7 File Offset: 0x0024C5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardAttrInfo NpcPhantomBattleCardAttrInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardAttrInfo)
				{
					return null;
				}
				return (NpcPhantomBattleCardAttrInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardAttrInfo);
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600FD09 RID: 64777 RVA: 0x0024E3BD File Offset: 0x0024C5BD
		// (set) Token: 0x0600FD0A RID: 64778 RVA: 0x0024E3D6 File Offset: 0x0024C5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEnterSlotInfo NpcPhantomBattleEnterSlotInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleEnterSlotInfo)
				{
					return null;
				}
				return (NpcPhantomBattleEnterSlotInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleEnterSlotInfo);
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600FD0B RID: 64779 RVA: 0x0024E3ED File Offset: 0x0024C5ED
		// (set) Token: 0x0600FD0C RID: 64780 RVA: 0x0024E406 File Offset: 0x0024C606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackCardLibrary NpcPhantomBattleBackCardLibrary
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackCardLibrary)
				{
					return null;
				}
				return (NpcPhantomBattleBackCardLibrary)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackCardLibrary);
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600FD0D RID: 64781 RVA: 0x0024E41D File Offset: 0x0024C61D
		// (set) Token: 0x0600FD0E RID: 64782 RVA: 0x0024E436 File Offset: 0x0024C636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDiscardInfo NpcPhantomBattleDiscardInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDiscardInfo)
				{
					return null;
				}
				return (NpcPhantomBattleDiscardInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDiscardInfo);
			}
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600FD0F RID: 64783 RVA: 0x0024E44D File Offset: 0x0024C64D
		// (set) Token: 0x0600FD10 RID: 64784 RVA: 0x0024E466 File Offset: 0x0024C666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomFourCTaskDealCardInfo NpcPhantomFourCTaskDealCardInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomFourCTaskDealCardInfo)
				{
					return null;
				}
				return (NpcPhantomFourCTaskDealCardInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomFourCTaskDealCardInfo);
			}
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600FD11 RID: 64785 RVA: 0x0024E47D File Offset: 0x0024C67D
		// (set) Token: 0x0600FD12 RID: 64786 RVA: 0x0024E496 File Offset: 0x0024C696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomLeaveSlot NpcPhantomLeaveSlot
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomLeaveSlot)
				{
					return null;
				}
				return (NpcPhantomLeaveSlot)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomLeaveSlot);
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600FD13 RID: 64787 RVA: 0x0024E4AD File Offset: 0x0024C6AD
		// (set) Token: 0x0600FD14 RID: 64788 RVA: 0x0024E4C6 File Offset: 0x0024C6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackSlotCardLibrary NpcPhantomBattleBackSlotCardLibrary
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackSlotCardLibrary)
				{
					return null;
				}
				return (NpcPhantomBattleBackSlotCardLibrary)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackSlotCardLibrary);
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600FD15 RID: 64789 RVA: 0x0024E4DD File Offset: 0x0024C6DD
		// (set) Token: 0x0600FD16 RID: 64790 RVA: 0x0024E4F6 File Offset: 0x0024C6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleReserveCardInfo NpcPhantomBattleReserveCardInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleReserveCardInfo)
				{
					return null;
				}
				return (NpcPhantomBattleReserveCardInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleReserveCardInfo);
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600FD17 RID: 64791 RVA: 0x0024E50D File Offset: 0x0024C70D
		// (set) Token: 0x0600FD18 RID: 64792 RVA: 0x0024E526 File Offset: 0x0024C726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcCardUpdateInfo PhantomBattleNpcCardUpdateInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleNpcCardUpdateInfo)
				{
					return null;
				}
				return (PhantomBattleNpcCardUpdateInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleNpcCardUpdateInfo);
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600FD19 RID: 64793 RVA: 0x0024E53D File Offset: 0x0024C73D
		// (set) Token: 0x0600FD1A RID: 64794 RVA: 0x0024E556 File Offset: 0x0024C756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDurableEmptyInfo NpcPhantomBattleDurableEmptyInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDurableEmptyInfo)
				{
					return null;
				}
				return (NpcPhantomBattleDurableEmptyInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDurableEmptyInfo);
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600FD1B RID: 64795 RVA: 0x0024E56D File Offset: 0x0024C76D
		// (set) Token: 0x0600FD1C RID: 64796 RVA: 0x0024E586 File Offset: 0x0024C786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardDurableSkillInfo NpcPhantomBattleCardDurableSkillInfo
		{
			get
			{
				if (this.npcPhantomBattleFightInfoCtxCase_ != NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardDurableSkillInfo)
				{
					return null;
				}
				return (NpcPhantomBattleCardDurableSkillInfo)this.npcPhantomBattleFightInfoCtx_;
			}
			set
			{
				this.npcPhantomBattleFightInfoCtx_ = value;
				this.npcPhantomBattleFightInfoCtxCase_ = ((value == null) ? NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None : NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardDurableSkillInfo);
			}
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600FD1D RID: 64797 RVA: 0x0024E59D File Offset: 0x0024C79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase NpcPhantomBattleFightInfoCtxCase
		{
			get
			{
				return this.npcPhantomBattleFightInfoCtxCase_;
			}
		}

		// Token: 0x0600FD1E RID: 64798 RVA: 0x0024E5A5 File Offset: 0x0024C7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNpcPhantomBattleFightInfoCtx()
		{
			this.npcPhantomBattleFightInfoCtxCase_ = NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None;
			this.npcPhantomBattleFightInfoCtx_ = null;
		}

		// Token: 0x0600FD1F RID: 64799 RVA: 0x0024E5B5 File Offset: 0x0024C7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleFightInfo);
		}

		// Token: 0x0600FD20 RID: 64800 RVA: 0x0024E5C4 File Offset: 0x0024C7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleFightInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleEvolveInfo, other.PhantomBattleEvolveInfo) && object.Equals(this.PhantomBattleSlotInsteadInfo, other.PhantomBattleSlotInsteadInfo) && object.Equals(this.PhantomBattleSkillTriggerInfo, other.PhantomBattleSkillTriggerInfo) && object.Equals(this.PhantomBattleBuffTriggerInfo, other.PhantomBattleBuffTriggerInfo) && object.Equals(this.NpcPhantomBattleCardSkillInfo, other.NpcPhantomBattleCardSkillInfo) && object.Equals(this.NpcPhantomBattleCardRoleSkillInfo, other.NpcPhantomBattleCardRoleSkillInfo) && object.Equals(this.NpcPhantomBattleGamerStatusInfo, other.NpcPhantomBattleGamerStatusInfo) && object.Equals(this.NpcPhantomBattleCardAttrInfo, other.NpcPhantomBattleCardAttrInfo) && object.Equals(this.NpcPhantomBattleEnterSlotInfo, other.NpcPhantomBattleEnterSlotInfo) && object.Equals(this.NpcPhantomBattleBackCardLibrary, other.NpcPhantomBattleBackCardLibrary) && object.Equals(this.NpcPhantomBattleDiscardInfo, other.NpcPhantomBattleDiscardInfo) && object.Equals(this.NpcPhantomFourCTaskDealCardInfo, other.NpcPhantomFourCTaskDealCardInfo) && object.Equals(this.NpcPhantomLeaveSlot, other.NpcPhantomLeaveSlot) && object.Equals(this.NpcPhantomBattleBackSlotCardLibrary, other.NpcPhantomBattleBackSlotCardLibrary) && object.Equals(this.NpcPhantomBattleReserveCardInfo, other.NpcPhantomBattleReserveCardInfo) && object.Equals(this.PhantomBattleNpcCardUpdateInfo, other.PhantomBattleNpcCardUpdateInfo) && object.Equals(this.NpcPhantomBattleDurableEmptyInfo, other.NpcPhantomBattleDurableEmptyInfo) && object.Equals(this.NpcPhantomBattleCardDurableSkillInfo, other.NpcPhantomBattleCardDurableSkillInfo) && this.NpcPhantomBattleFightInfoCtxCase == other.NpcPhantomBattleFightInfoCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD21 RID: 64801 RVA: 0x0024E778 File Offset: 0x0024C978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleEvolveInfo)
			{
				num ^= this.PhantomBattleEvolveInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSlotInsteadInfo)
			{
				num ^= this.PhantomBattleSlotInsteadInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSkillTriggerInfo)
			{
				num ^= this.PhantomBattleSkillTriggerInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleBuffTriggerInfo)
			{
				num ^= this.PhantomBattleBuffTriggerInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardSkillInfo)
			{
				num ^= this.NpcPhantomBattleCardSkillInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardRoleSkillInfo)
			{
				num ^= this.NpcPhantomBattleCardRoleSkillInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleGamerStatusInfo)
			{
				num ^= this.NpcPhantomBattleGamerStatusInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardAttrInfo)
			{
				num ^= this.NpcPhantomBattleCardAttrInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleEnterSlotInfo)
			{
				num ^= this.NpcPhantomBattleEnterSlotInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackCardLibrary)
			{
				num ^= this.NpcPhantomBattleBackCardLibrary.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDiscardInfo)
			{
				num ^= this.NpcPhantomBattleDiscardInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomFourCTaskDealCardInfo)
			{
				num ^= this.NpcPhantomFourCTaskDealCardInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomLeaveSlot)
			{
				num ^= this.NpcPhantomLeaveSlot.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackSlotCardLibrary)
			{
				num ^= this.NpcPhantomBattleBackSlotCardLibrary.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleReserveCardInfo)
			{
				num ^= this.NpcPhantomBattleReserveCardInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleNpcCardUpdateInfo)
			{
				num ^= this.PhantomBattleNpcCardUpdateInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDurableEmptyInfo)
			{
				num ^= this.NpcPhantomBattleDurableEmptyInfo.GetHashCode();
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardDurableSkillInfo)
			{
				num ^= this.NpcPhantomBattleCardDurableSkillInfo.GetHashCode();
			}
			num ^= (int)this.npcPhantomBattleFightInfoCtxCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD22 RID: 64802 RVA: 0x0024E94F File Offset: 0x0024CB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD23 RID: 64803 RVA: 0x0024E95C File Offset: 0x0024CB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD24 RID: 64804 RVA: 0x0024E968 File Offset: 0x0024CB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleEvolveInfo)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleEvolveInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSlotInsteadInfo)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PhantomBattleSlotInsteadInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSkillTriggerInfo)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleBuffTriggerInfo)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PhantomBattleBuffTriggerInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardSkillInfo)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NpcPhantomBattleCardSkillInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardRoleSkillInfo)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.NpcPhantomBattleCardRoleSkillInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleGamerStatusInfo)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.NpcPhantomBattleGamerStatusInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardAttrInfo)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.NpcPhantomBattleCardAttrInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleEnterSlotInfo)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.NpcPhantomBattleEnterSlotInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackCardLibrary)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.NpcPhantomBattleBackCardLibrary);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDiscardInfo)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.NpcPhantomBattleDiscardInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomFourCTaskDealCardInfo)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.NpcPhantomFourCTaskDealCardInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomLeaveSlot)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.NpcPhantomLeaveSlot);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackSlotCardLibrary)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.NpcPhantomBattleBackSlotCardLibrary);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleReserveCardInfo)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.NpcPhantomBattleReserveCardInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleNpcCardUpdateInfo)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.PhantomBattleNpcCardUpdateInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDurableEmptyInfo)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.NpcPhantomBattleDurableEmptyInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardDurableSkillInfo)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.NpcPhantomBattleCardDurableSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FD25 RID: 64805 RVA: 0x0024EBAC File Offset: 0x0024CDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleEvolveInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleEvolveInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSlotInsteadInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleSlotInsteadInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSkillTriggerInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleSkillTriggerInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleBuffTriggerInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleBuffTriggerInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardSkillInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleCardSkillInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardRoleSkillInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleCardRoleSkillInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleGamerStatusInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleGamerStatusInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardAttrInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleCardAttrInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleEnterSlotInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleEnterSlotInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackCardLibrary)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleBackCardLibrary);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDiscardInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleDiscardInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomFourCTaskDealCardInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomFourCTaskDealCardInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomLeaveSlot)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomLeaveSlot);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackSlotCardLibrary)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleBackSlotCardLibrary);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleReserveCardInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleReserveCardInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleNpcCardUpdateInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleNpcCardUpdateInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDurableEmptyInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleDurableEmptyInfo);
			}
			if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardDurableSkillInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleCardDurableSkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FD26 RID: 64806 RVA: 0x0024EDA0 File Offset: 0x0024CFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleFightInfo other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.NpcPhantomBattleFightInfoCtxCase)
			{
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleEvolveInfo:
				if (this.PhantomBattleEvolveInfo == null)
				{
					this.PhantomBattleEvolveInfo = new NpcPhantomBattleEvolveInfo();
				}
				this.PhantomBattleEvolveInfo.MergeFrom(other.PhantomBattleEvolveInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSlotInsteadInfo:
				if (this.PhantomBattleSlotInsteadInfo == null)
				{
					this.PhantomBattleSlotInsteadInfo = new NpcPhantomBattleSlotInsteadInfo();
				}
				this.PhantomBattleSlotInsteadInfo.MergeFrom(other.PhantomBattleSlotInsteadInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSkillTriggerInfo:
				if (this.PhantomBattleSkillTriggerInfo == null)
				{
					this.PhantomBattleSkillTriggerInfo = new PhantomBattleSkillTriggerInfo();
				}
				this.PhantomBattleSkillTriggerInfo.MergeFrom(other.PhantomBattleSkillTriggerInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleBuffTriggerInfo:
				if (this.PhantomBattleBuffTriggerInfo == null)
				{
					this.PhantomBattleBuffTriggerInfo = new PhantomBattleBuffTriggerInfo();
				}
				this.PhantomBattleBuffTriggerInfo.MergeFrom(other.PhantomBattleBuffTriggerInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardSkillInfo:
				if (this.NpcPhantomBattleCardSkillInfo == null)
				{
					this.NpcPhantomBattleCardSkillInfo = new NpcPhantomBattleCardSkillInfo();
				}
				this.NpcPhantomBattleCardSkillInfo.MergeFrom(other.NpcPhantomBattleCardSkillInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardRoleSkillInfo:
				if (this.NpcPhantomBattleCardRoleSkillInfo == null)
				{
					this.NpcPhantomBattleCardRoleSkillInfo = new NpcPhantomBattleCardRoleSkillInfo();
				}
				this.NpcPhantomBattleCardRoleSkillInfo.MergeFrom(other.NpcPhantomBattleCardRoleSkillInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleGamerStatusInfo:
				if (this.NpcPhantomBattleGamerStatusInfo == null)
				{
					this.NpcPhantomBattleGamerStatusInfo = new NpcPhantomBattleGamerStatusInfo();
				}
				this.NpcPhantomBattleGamerStatusInfo.MergeFrom(other.NpcPhantomBattleGamerStatusInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardAttrInfo:
				if (this.NpcPhantomBattleCardAttrInfo == null)
				{
					this.NpcPhantomBattleCardAttrInfo = new NpcPhantomBattleCardAttrInfo();
				}
				this.NpcPhantomBattleCardAttrInfo.MergeFrom(other.NpcPhantomBattleCardAttrInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleEnterSlotInfo:
				if (this.NpcPhantomBattleEnterSlotInfo == null)
				{
					this.NpcPhantomBattleEnterSlotInfo = new NpcPhantomBattleEnterSlotInfo();
				}
				this.NpcPhantomBattleEnterSlotInfo.MergeFrom(other.NpcPhantomBattleEnterSlotInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackCardLibrary:
				if (this.NpcPhantomBattleBackCardLibrary == null)
				{
					this.NpcPhantomBattleBackCardLibrary = new NpcPhantomBattleBackCardLibrary();
				}
				this.NpcPhantomBattleBackCardLibrary.MergeFrom(other.NpcPhantomBattleBackCardLibrary);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDiscardInfo:
				if (this.NpcPhantomBattleDiscardInfo == null)
				{
					this.NpcPhantomBattleDiscardInfo = new NpcPhantomBattleDiscardInfo();
				}
				this.NpcPhantomBattleDiscardInfo.MergeFrom(other.NpcPhantomBattleDiscardInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomFourCTaskDealCardInfo:
				if (this.NpcPhantomFourCTaskDealCardInfo == null)
				{
					this.NpcPhantomFourCTaskDealCardInfo = new NpcPhantomFourCTaskDealCardInfo();
				}
				this.NpcPhantomFourCTaskDealCardInfo.MergeFrom(other.NpcPhantomFourCTaskDealCardInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomLeaveSlot:
				if (this.NpcPhantomLeaveSlot == null)
				{
					this.NpcPhantomLeaveSlot = new NpcPhantomLeaveSlot();
				}
				this.NpcPhantomLeaveSlot.MergeFrom(other.NpcPhantomLeaveSlot);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackSlotCardLibrary:
				if (this.NpcPhantomBattleBackSlotCardLibrary == null)
				{
					this.NpcPhantomBattleBackSlotCardLibrary = new NpcPhantomBattleBackSlotCardLibrary();
				}
				this.NpcPhantomBattleBackSlotCardLibrary.MergeFrom(other.NpcPhantomBattleBackSlotCardLibrary);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleReserveCardInfo:
				if (this.NpcPhantomBattleReserveCardInfo == null)
				{
					this.NpcPhantomBattleReserveCardInfo = new NpcPhantomBattleReserveCardInfo();
				}
				this.NpcPhantomBattleReserveCardInfo.MergeFrom(other.NpcPhantomBattleReserveCardInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleNpcCardUpdateInfo:
				if (this.PhantomBattleNpcCardUpdateInfo == null)
				{
					this.PhantomBattleNpcCardUpdateInfo = new PhantomBattleNpcCardUpdateInfo();
				}
				this.PhantomBattleNpcCardUpdateInfo.MergeFrom(other.PhantomBattleNpcCardUpdateInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDurableEmptyInfo:
				if (this.NpcPhantomBattleDurableEmptyInfo == null)
				{
					this.NpcPhantomBattleDurableEmptyInfo = new NpcPhantomBattleDurableEmptyInfo();
				}
				this.NpcPhantomBattleDurableEmptyInfo.MergeFrom(other.NpcPhantomBattleDurableEmptyInfo);
				break;
			case NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardDurableSkillInfo:
				if (this.NpcPhantomBattleCardDurableSkillInfo == null)
				{
					this.NpcPhantomBattleCardDurableSkillInfo = new NpcPhantomBattleCardDurableSkillInfo();
				}
				this.NpcPhantomBattleCardDurableSkillInfo.MergeFrom(other.NpcPhantomBattleCardDurableSkillInfo);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FD27 RID: 64807 RVA: 0x0024F0FC File Offset: 0x0024D2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD28 RID: 64808 RVA: 0x0024F108 File Offset: 0x0024D308
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
				if (num <= 74U)
				{
					if (num <= 34U)
					{
						if (num <= 18U)
						{
							if (num == 10U)
							{
								NpcPhantomBattleEvolveInfo npcPhantomBattleEvolveInfo = new NpcPhantomBattleEvolveInfo();
								if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleEvolveInfo)
								{
									npcPhantomBattleEvolveInfo.MergeFrom(this.PhantomBattleEvolveInfo);
								}
								input.ReadMessage(npcPhantomBattleEvolveInfo);
								this.PhantomBattleEvolveInfo = npcPhantomBattleEvolveInfo;
								continue;
							}
							if (num == 18U)
							{
								NpcPhantomBattleSlotInsteadInfo npcPhantomBattleSlotInsteadInfo = new NpcPhantomBattleSlotInsteadInfo();
								if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSlotInsteadInfo)
								{
									npcPhantomBattleSlotInsteadInfo.MergeFrom(this.PhantomBattleSlotInsteadInfo);
								}
								input.ReadMessage(npcPhantomBattleSlotInsteadInfo);
								this.PhantomBattleSlotInsteadInfo = npcPhantomBattleSlotInsteadInfo;
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfo = new PhantomBattleSkillTriggerInfo();
								if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleSkillTriggerInfo)
								{
									phantomBattleSkillTriggerInfo.MergeFrom(this.PhantomBattleSkillTriggerInfo);
								}
								input.ReadMessage(phantomBattleSkillTriggerInfo);
								this.PhantomBattleSkillTriggerInfo = phantomBattleSkillTriggerInfo;
								continue;
							}
							if (num == 34U)
							{
								PhantomBattleBuffTriggerInfo phantomBattleBuffTriggerInfo = new PhantomBattleBuffTriggerInfo();
								if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleBuffTriggerInfo)
								{
									phantomBattleBuffTriggerInfo.MergeFrom(this.PhantomBattleBuffTriggerInfo);
								}
								input.ReadMessage(phantomBattleBuffTriggerInfo);
								this.PhantomBattleBuffTriggerInfo = phantomBattleBuffTriggerInfo;
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 42U)
						{
							NpcPhantomBattleCardSkillInfo npcPhantomBattleCardSkillInfo = new NpcPhantomBattleCardSkillInfo();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardSkillInfo)
							{
								npcPhantomBattleCardSkillInfo.MergeFrom(this.NpcPhantomBattleCardSkillInfo);
							}
							input.ReadMessage(npcPhantomBattleCardSkillInfo);
							this.NpcPhantomBattleCardSkillInfo = npcPhantomBattleCardSkillInfo;
							continue;
						}
						if (num == 50U)
						{
							NpcPhantomBattleCardRoleSkillInfo npcPhantomBattleCardRoleSkillInfo = new NpcPhantomBattleCardRoleSkillInfo();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardRoleSkillInfo)
							{
								npcPhantomBattleCardRoleSkillInfo.MergeFrom(this.NpcPhantomBattleCardRoleSkillInfo);
							}
							input.ReadMessage(npcPhantomBattleCardRoleSkillInfo);
							this.NpcPhantomBattleCardRoleSkillInfo = npcPhantomBattleCardRoleSkillInfo;
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							NpcPhantomBattleGamerStatusInfo npcPhantomBattleGamerStatusInfo = new NpcPhantomBattleGamerStatusInfo();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleGamerStatusInfo)
							{
								npcPhantomBattleGamerStatusInfo.MergeFrom(this.NpcPhantomBattleGamerStatusInfo);
							}
							input.ReadMessage(npcPhantomBattleGamerStatusInfo);
							this.NpcPhantomBattleGamerStatusInfo = npcPhantomBattleGamerStatusInfo;
							continue;
						}
						if (num == 66U)
						{
							NpcPhantomBattleCardAttrInfo npcPhantomBattleCardAttrInfo = new NpcPhantomBattleCardAttrInfo();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardAttrInfo)
							{
								npcPhantomBattleCardAttrInfo.MergeFrom(this.NpcPhantomBattleCardAttrInfo);
							}
							input.ReadMessage(npcPhantomBattleCardAttrInfo);
							this.NpcPhantomBattleCardAttrInfo = npcPhantomBattleCardAttrInfo;
							continue;
						}
						if (num == 74U)
						{
							NpcPhantomBattleEnterSlotInfo npcPhantomBattleEnterSlotInfo = new NpcPhantomBattleEnterSlotInfo();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleEnterSlotInfo)
							{
								npcPhantomBattleEnterSlotInfo.MergeFrom(this.NpcPhantomBattleEnterSlotInfo);
							}
							input.ReadMessage(npcPhantomBattleEnterSlotInfo);
							this.NpcPhantomBattleEnterSlotInfo = npcPhantomBattleEnterSlotInfo;
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
							NpcPhantomBattleBackCardLibrary npcPhantomBattleBackCardLibrary = new NpcPhantomBattleBackCardLibrary();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackCardLibrary)
							{
								npcPhantomBattleBackCardLibrary.MergeFrom(this.NpcPhantomBattleBackCardLibrary);
							}
							input.ReadMessage(npcPhantomBattleBackCardLibrary);
							this.NpcPhantomBattleBackCardLibrary = npcPhantomBattleBackCardLibrary;
							continue;
						}
						if (num == 90U)
						{
							NpcPhantomBattleDiscardInfo npcPhantomBattleDiscardInfo = new NpcPhantomBattleDiscardInfo();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDiscardInfo)
							{
								npcPhantomBattleDiscardInfo.MergeFrom(this.NpcPhantomBattleDiscardInfo);
							}
							input.ReadMessage(npcPhantomBattleDiscardInfo);
							this.NpcPhantomBattleDiscardInfo = npcPhantomBattleDiscardInfo;
							continue;
						}
					}
					else
					{
						if (num == 98U)
						{
							NpcPhantomFourCTaskDealCardInfo npcPhantomFourCTaskDealCardInfo = new NpcPhantomFourCTaskDealCardInfo();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomFourCTaskDealCardInfo)
							{
								npcPhantomFourCTaskDealCardInfo.MergeFrom(this.NpcPhantomFourCTaskDealCardInfo);
							}
							input.ReadMessage(npcPhantomFourCTaskDealCardInfo);
							this.NpcPhantomFourCTaskDealCardInfo = npcPhantomFourCTaskDealCardInfo;
							continue;
						}
						if (num == 106U)
						{
							NpcPhantomLeaveSlot npcPhantomLeaveSlot = new NpcPhantomLeaveSlot();
							if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomLeaveSlot)
							{
								npcPhantomLeaveSlot.MergeFrom(this.NpcPhantomLeaveSlot);
							}
							input.ReadMessage(npcPhantomLeaveSlot);
							this.NpcPhantomLeaveSlot = npcPhantomLeaveSlot;
							continue;
						}
					}
				}
				else if (num <= 122U)
				{
					if (num == 114U)
					{
						NpcPhantomBattleBackSlotCardLibrary npcPhantomBattleBackSlotCardLibrary = new NpcPhantomBattleBackSlotCardLibrary();
						if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleBackSlotCardLibrary)
						{
							npcPhantomBattleBackSlotCardLibrary.MergeFrom(this.NpcPhantomBattleBackSlotCardLibrary);
						}
						input.ReadMessage(npcPhantomBattleBackSlotCardLibrary);
						this.NpcPhantomBattleBackSlotCardLibrary = npcPhantomBattleBackSlotCardLibrary;
						continue;
					}
					if (num == 122U)
					{
						NpcPhantomBattleReserveCardInfo npcPhantomBattleReserveCardInfo = new NpcPhantomBattleReserveCardInfo();
						if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleReserveCardInfo)
						{
							npcPhantomBattleReserveCardInfo.MergeFrom(this.NpcPhantomBattleReserveCardInfo);
						}
						input.ReadMessage(npcPhantomBattleReserveCardInfo);
						this.NpcPhantomBattleReserveCardInfo = npcPhantomBattleReserveCardInfo;
						continue;
					}
				}
				else
				{
					if (num == 138U)
					{
						PhantomBattleNpcCardUpdateInfo phantomBattleNpcCardUpdateInfo = new PhantomBattleNpcCardUpdateInfo();
						if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.PhantomBattleNpcCardUpdateInfo)
						{
							phantomBattleNpcCardUpdateInfo.MergeFrom(this.PhantomBattleNpcCardUpdateInfo);
						}
						input.ReadMessage(phantomBattleNpcCardUpdateInfo);
						this.PhantomBattleNpcCardUpdateInfo = phantomBattleNpcCardUpdateInfo;
						continue;
					}
					if (num == 146U)
					{
						NpcPhantomBattleDurableEmptyInfo npcPhantomBattleDurableEmptyInfo = new NpcPhantomBattleDurableEmptyInfo();
						if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleDurableEmptyInfo)
						{
							npcPhantomBattleDurableEmptyInfo.MergeFrom(this.NpcPhantomBattleDurableEmptyInfo);
						}
						input.ReadMessage(npcPhantomBattleDurableEmptyInfo);
						this.NpcPhantomBattleDurableEmptyInfo = npcPhantomBattleDurableEmptyInfo;
						continue;
					}
					if (num == 154U)
					{
						NpcPhantomBattleCardDurableSkillInfo npcPhantomBattleCardDurableSkillInfo = new NpcPhantomBattleCardDurableSkillInfo();
						if (this.npcPhantomBattleFightInfoCtxCase_ == NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.NpcPhantomBattleCardDurableSkillInfo)
						{
							npcPhantomBattleCardDurableSkillInfo.MergeFrom(this.NpcPhantomBattleCardDurableSkillInfo);
						}
						input.ReadMessage(npcPhantomBattleCardDurableSkillInfo);
						this.NpcPhantomBattleCardDurableSkillInfo = npcPhantomBattleCardDurableSkillInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006556 RID: 25942
		private static readonly MessageParser<NpcPhantomBattleFightInfo> _parser = new MessageParser<NpcPhantomBattleFightInfo>(() => new NpcPhantomBattleFightInfo());

		// Token: 0x04006557 RID: 25943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006558 RID: 25944
		public const int PhantomBattleEvolveInfoFieldNumber = 1;

		// Token: 0x04006559 RID: 25945
		public const int PhantomBattleSlotInsteadInfoFieldNumber = 2;

		// Token: 0x0400655A RID: 25946
		public const int PhantomBattleSkillTriggerInfoFieldNumber = 3;

		// Token: 0x0400655B RID: 25947
		public const int PhantomBattleBuffTriggerInfoFieldNumber = 4;

		// Token: 0x0400655C RID: 25948
		public const int NpcPhantomBattleCardSkillInfoFieldNumber = 5;

		// Token: 0x0400655D RID: 25949
		public const int NpcPhantomBattleCardRoleSkillInfoFieldNumber = 6;

		// Token: 0x0400655E RID: 25950
		public const int NpcPhantomBattleGamerStatusInfoFieldNumber = 7;

		// Token: 0x0400655F RID: 25951
		public const int NpcPhantomBattleCardAttrInfoFieldNumber = 8;

		// Token: 0x04006560 RID: 25952
		public const int NpcPhantomBattleEnterSlotInfoFieldNumber = 9;

		// Token: 0x04006561 RID: 25953
		public const int NpcPhantomBattleBackCardLibraryFieldNumber = 10;

		// Token: 0x04006562 RID: 25954
		public const int NpcPhantomBattleDiscardInfoFieldNumber = 11;

		// Token: 0x04006563 RID: 25955
		public const int NpcPhantomFourCTaskDealCardInfoFieldNumber = 12;

		// Token: 0x04006564 RID: 25956
		public const int NpcPhantomLeaveSlotFieldNumber = 13;

		// Token: 0x04006565 RID: 25957
		public const int NpcPhantomBattleBackSlotCardLibraryFieldNumber = 14;

		// Token: 0x04006566 RID: 25958
		public const int NpcPhantomBattleReserveCardInfoFieldNumber = 15;

		// Token: 0x04006567 RID: 25959
		public const int PhantomBattleNpcCardUpdateInfoFieldNumber = 17;

		// Token: 0x04006568 RID: 25960
		public const int NpcPhantomBattleDurableEmptyInfoFieldNumber = 18;

		// Token: 0x04006569 RID: 25961
		public const int NpcPhantomBattleCardDurableSkillInfoFieldNumber = 19;

		// Token: 0x0400656A RID: 25962
		private object npcPhantomBattleFightInfoCtx_;

		// Token: 0x0400656B RID: 25963
		private NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase npcPhantomBattleFightInfoCtxCase_;

		// Token: 0x020018E3 RID: 6371
		public enum NpcPhantomBattleFightInfoCtxOneofCase
		{
			// Token: 0x0400CD73 RID: 52595
			None,
			// Token: 0x0400CD74 RID: 52596
			PhantomBattleEvolveInfo,
			// Token: 0x0400CD75 RID: 52597
			PhantomBattleSlotInsteadInfo,
			// Token: 0x0400CD76 RID: 52598
			PhantomBattleSkillTriggerInfo,
			// Token: 0x0400CD77 RID: 52599
			PhantomBattleBuffTriggerInfo,
			// Token: 0x0400CD78 RID: 52600
			NpcPhantomBattleCardSkillInfo,
			// Token: 0x0400CD79 RID: 52601
			NpcPhantomBattleCardRoleSkillInfo,
			// Token: 0x0400CD7A RID: 52602
			NpcPhantomBattleGamerStatusInfo,
			// Token: 0x0400CD7B RID: 52603
			NpcPhantomBattleCardAttrInfo,
			// Token: 0x0400CD7C RID: 52604
			NpcPhantomBattleEnterSlotInfo,
			// Token: 0x0400CD7D RID: 52605
			NpcPhantomBattleBackCardLibrary,
			// Token: 0x0400CD7E RID: 52606
			NpcPhantomBattleDiscardInfo,
			// Token: 0x0400CD7F RID: 52607
			NpcPhantomFourCTaskDealCardInfo,
			// Token: 0x0400CD80 RID: 52608
			NpcPhantomLeaveSlot,
			// Token: 0x0400CD81 RID: 52609
			NpcPhantomBattleBackSlotCardLibrary,
			// Token: 0x0400CD82 RID: 52610
			NpcPhantomBattleReserveCardInfo,
			// Token: 0x0400CD83 RID: 52611
			PhantomBattleNpcCardUpdateInfo = 17,
			// Token: 0x0400CD84 RID: 52612
			NpcPhantomBattleDurableEmptyInfo,
			// Token: 0x0400CD85 RID: 52613
			NpcPhantomBattleCardDurableSkillInfo
		}
	}
}
