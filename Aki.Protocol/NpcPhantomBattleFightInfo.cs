using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B73 RID: 2931
	public sealed class NpcPhantomBattleFightInfo : IMessage<NpcPhantomBattleFightInfo>, IMessage, IEquatable<NpcPhantomBattleFightInfo>, IDeepCloneable<NpcPhantomBattleFightInfo>, IBufferMessage
	{
		// Token: 0x0600FDF6 RID: 65014 RVA: 0x0024FEFB File Offset: 0x0024E0FB
		[NullableContext(1)]
		public static NpcPhantomBattleFightInfo Create()
		{
			return new NpcPhantomBattleFightInfo();
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600FDF7 RID: 65015 RVA: 0x0024FF02 File Offset: 0x0024E102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcPhantomBattleFightInfo> Parser
		{
			get
			{
				return NpcPhantomBattleFightInfo._parser;
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600FDF8 RID: 65016 RVA: 0x0024FF09 File Offset: 0x0024E109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600FDF9 RID: 65017 RVA: 0x0024FF0C File Offset: 0x0024E10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleFightInfo.Descriptor;
			}
		}

		// Token: 0x0600FDFA RID: 65018 RVA: 0x0024FF13 File Offset: 0x0024E113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfo()
		{
		}

		// Token: 0x0600FDFB RID: 65019 RVA: 0x0024FF1C File Offset: 0x0024E11C
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

		// Token: 0x0600FDFC RID: 65020 RVA: 0x00250115 File Offset: 0x0024E315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfo Clone()
		{
			return new NpcPhantomBattleFightInfo(this);
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600FDFD RID: 65021 RVA: 0x0025011D File Offset: 0x0024E31D
		// (set) Token: 0x0600FDFE RID: 65022 RVA: 0x00250135 File Offset: 0x0024E335
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

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600FDFF RID: 65023 RVA: 0x0025014B File Offset: 0x0024E34B
		// (set) Token: 0x0600FE00 RID: 65024 RVA: 0x00250163 File Offset: 0x0024E363
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

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600FE01 RID: 65025 RVA: 0x00250179 File Offset: 0x0024E379
		// (set) Token: 0x0600FE02 RID: 65026 RVA: 0x00250191 File Offset: 0x0024E391
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

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600FE03 RID: 65027 RVA: 0x002501A7 File Offset: 0x0024E3A7
		// (set) Token: 0x0600FE04 RID: 65028 RVA: 0x002501BF File Offset: 0x0024E3BF
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

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600FE05 RID: 65029 RVA: 0x002501D5 File Offset: 0x0024E3D5
		// (set) Token: 0x0600FE06 RID: 65030 RVA: 0x002501ED File Offset: 0x0024E3ED
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

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600FE07 RID: 65031 RVA: 0x00250203 File Offset: 0x0024E403
		// (set) Token: 0x0600FE08 RID: 65032 RVA: 0x0025021B File Offset: 0x0024E41B
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

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600FE09 RID: 65033 RVA: 0x00250231 File Offset: 0x0024E431
		// (set) Token: 0x0600FE0A RID: 65034 RVA: 0x00250249 File Offset: 0x0024E449
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

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600FE0B RID: 65035 RVA: 0x0025025F File Offset: 0x0024E45F
		// (set) Token: 0x0600FE0C RID: 65036 RVA: 0x00250277 File Offset: 0x0024E477
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

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600FE0D RID: 65037 RVA: 0x0025028D File Offset: 0x0024E48D
		// (set) Token: 0x0600FE0E RID: 65038 RVA: 0x002502A6 File Offset: 0x0024E4A6
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

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600FE0F RID: 65039 RVA: 0x002502BD File Offset: 0x0024E4BD
		// (set) Token: 0x0600FE10 RID: 65040 RVA: 0x002502D6 File Offset: 0x0024E4D6
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

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600FE11 RID: 65041 RVA: 0x002502ED File Offset: 0x0024E4ED
		// (set) Token: 0x0600FE12 RID: 65042 RVA: 0x00250306 File Offset: 0x0024E506
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

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600FE13 RID: 65043 RVA: 0x0025031D File Offset: 0x0024E51D
		// (set) Token: 0x0600FE14 RID: 65044 RVA: 0x00250336 File Offset: 0x0024E536
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

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600FE15 RID: 65045 RVA: 0x0025034D File Offset: 0x0024E54D
		// (set) Token: 0x0600FE16 RID: 65046 RVA: 0x00250366 File Offset: 0x0024E566
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

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600FE17 RID: 65047 RVA: 0x0025037D File Offset: 0x0024E57D
		// (set) Token: 0x0600FE18 RID: 65048 RVA: 0x00250396 File Offset: 0x0024E596
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

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600FE19 RID: 65049 RVA: 0x002503AD File Offset: 0x0024E5AD
		// (set) Token: 0x0600FE1A RID: 65050 RVA: 0x002503C6 File Offset: 0x0024E5C6
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

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600FE1B RID: 65051 RVA: 0x002503DD File Offset: 0x0024E5DD
		// (set) Token: 0x0600FE1C RID: 65052 RVA: 0x002503F6 File Offset: 0x0024E5F6
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

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600FE1D RID: 65053 RVA: 0x0025040D File Offset: 0x0024E60D
		// (set) Token: 0x0600FE1E RID: 65054 RVA: 0x00250426 File Offset: 0x0024E626
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

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600FE1F RID: 65055 RVA: 0x0025043D File Offset: 0x0024E63D
		// (set) Token: 0x0600FE20 RID: 65056 RVA: 0x00250456 File Offset: 0x0024E656
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

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600FE21 RID: 65057 RVA: 0x0025046D File Offset: 0x0024E66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase NpcPhantomBattleFightInfoCtxCase
		{
			get
			{
				return this.npcPhantomBattleFightInfoCtxCase_;
			}
		}

		// Token: 0x0600FE22 RID: 65058 RVA: 0x00250475 File Offset: 0x0024E675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNpcPhantomBattleFightInfoCtx()
		{
			this.npcPhantomBattleFightInfoCtxCase_ = NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase.None;
			this.npcPhantomBattleFightInfoCtx_ = null;
		}

		// Token: 0x0600FE23 RID: 65059 RVA: 0x00250485 File Offset: 0x0024E685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleFightInfo);
		}

		// Token: 0x0600FE24 RID: 65060 RVA: 0x00250494 File Offset: 0x0024E694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleFightInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleEvolveInfo, other.PhantomBattleEvolveInfo) && object.Equals(this.PhantomBattleSlotInsteadInfo, other.PhantomBattleSlotInsteadInfo) && object.Equals(this.PhantomBattleSkillTriggerInfo, other.PhantomBattleSkillTriggerInfo) && object.Equals(this.PhantomBattleBuffTriggerInfo, other.PhantomBattleBuffTriggerInfo) && object.Equals(this.NpcPhantomBattleCardSkillInfo, other.NpcPhantomBattleCardSkillInfo) && object.Equals(this.NpcPhantomBattleCardRoleSkillInfo, other.NpcPhantomBattleCardRoleSkillInfo) && object.Equals(this.NpcPhantomBattleGamerStatusInfo, other.NpcPhantomBattleGamerStatusInfo) && object.Equals(this.NpcPhantomBattleCardAttrInfo, other.NpcPhantomBattleCardAttrInfo) && object.Equals(this.NpcPhantomBattleEnterSlotInfo, other.NpcPhantomBattleEnterSlotInfo) && object.Equals(this.NpcPhantomBattleBackCardLibrary, other.NpcPhantomBattleBackCardLibrary) && object.Equals(this.NpcPhantomBattleDiscardInfo, other.NpcPhantomBattleDiscardInfo) && object.Equals(this.NpcPhantomFourCTaskDealCardInfo, other.NpcPhantomFourCTaskDealCardInfo) && object.Equals(this.NpcPhantomLeaveSlot, other.NpcPhantomLeaveSlot) && object.Equals(this.NpcPhantomBattleBackSlotCardLibrary, other.NpcPhantomBattleBackSlotCardLibrary) && object.Equals(this.NpcPhantomBattleReserveCardInfo, other.NpcPhantomBattleReserveCardInfo) && object.Equals(this.PhantomBattleNpcCardUpdateInfo, other.PhantomBattleNpcCardUpdateInfo) && object.Equals(this.NpcPhantomBattleDurableEmptyInfo, other.NpcPhantomBattleDurableEmptyInfo) && object.Equals(this.NpcPhantomBattleCardDurableSkillInfo, other.NpcPhantomBattleCardDurableSkillInfo) && this.NpcPhantomBattleFightInfoCtxCase == other.NpcPhantomBattleFightInfoCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE25 RID: 65061 RVA: 0x00250648 File Offset: 0x0024E848
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

		// Token: 0x0600FE26 RID: 65062 RVA: 0x0025081F File Offset: 0x0024EA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE27 RID: 65063 RVA: 0x0025082C File Offset: 0x0024EA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE28 RID: 65064 RVA: 0x00250838 File Offset: 0x0024EA38
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

		// Token: 0x0600FE29 RID: 65065 RVA: 0x00250A7C File Offset: 0x0024EC7C
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

		// Token: 0x0600FE2A RID: 65066 RVA: 0x00250C70 File Offset: 0x0024EE70
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

		// Token: 0x0600FE2B RID: 65067 RVA: 0x00250FCC File Offset: 0x0024F1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE2C RID: 65068 RVA: 0x00250FD8 File Offset: 0x0024F1D8
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

		// Token: 0x04006546 RID: 25926
		private static readonly MessageParser<NpcPhantomBattleFightInfo> _parser = new MessageParser<NpcPhantomBattleFightInfo>(() => new NpcPhantomBattleFightInfo());

		// Token: 0x04006547 RID: 25927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006548 RID: 25928
		public const int PhantomBattleEvolveInfoFieldNumber = 1;

		// Token: 0x04006549 RID: 25929
		public const int PhantomBattleSlotInsteadInfoFieldNumber = 2;

		// Token: 0x0400654A RID: 25930
		public const int PhantomBattleSkillTriggerInfoFieldNumber = 3;

		// Token: 0x0400654B RID: 25931
		public const int PhantomBattleBuffTriggerInfoFieldNumber = 4;

		// Token: 0x0400654C RID: 25932
		public const int NpcPhantomBattleCardSkillInfoFieldNumber = 5;

		// Token: 0x0400654D RID: 25933
		public const int NpcPhantomBattleCardRoleSkillInfoFieldNumber = 6;

		// Token: 0x0400654E RID: 25934
		public const int NpcPhantomBattleGamerStatusInfoFieldNumber = 7;

		// Token: 0x0400654F RID: 25935
		public const int NpcPhantomBattleCardAttrInfoFieldNumber = 8;

		// Token: 0x04006550 RID: 25936
		public const int NpcPhantomBattleEnterSlotInfoFieldNumber = 9;

		// Token: 0x04006551 RID: 25937
		public const int NpcPhantomBattleBackCardLibraryFieldNumber = 10;

		// Token: 0x04006552 RID: 25938
		public const int NpcPhantomBattleDiscardInfoFieldNumber = 11;

		// Token: 0x04006553 RID: 25939
		public const int NpcPhantomFourCTaskDealCardInfoFieldNumber = 12;

		// Token: 0x04006554 RID: 25940
		public const int NpcPhantomLeaveSlotFieldNumber = 13;

		// Token: 0x04006555 RID: 25941
		public const int NpcPhantomBattleBackSlotCardLibraryFieldNumber = 14;

		// Token: 0x04006556 RID: 25942
		public const int NpcPhantomBattleReserveCardInfoFieldNumber = 15;

		// Token: 0x04006557 RID: 25943
		public const int PhantomBattleNpcCardUpdateInfoFieldNumber = 17;

		// Token: 0x04006558 RID: 25944
		public const int NpcPhantomBattleDurableEmptyInfoFieldNumber = 18;

		// Token: 0x04006559 RID: 25945
		public const int NpcPhantomBattleCardDurableSkillInfoFieldNumber = 19;

		// Token: 0x0400655A RID: 25946
		private object npcPhantomBattleFightInfoCtx_;

		// Token: 0x0400655B RID: 25947
		private NpcPhantomBattleFightInfo.NpcPhantomBattleFightInfoCtxOneofCase npcPhantomBattleFightInfoCtxCase_;

		// Token: 0x0200186B RID: 6251
		public enum NpcPhantomBattleFightInfoCtxOneofCase
		{
			// Token: 0x0400C848 RID: 51272
			None,
			// Token: 0x0400C849 RID: 51273
			PhantomBattleEvolveInfo,
			// Token: 0x0400C84A RID: 51274
			PhantomBattleSlotInsteadInfo,
			// Token: 0x0400C84B RID: 51275
			PhantomBattleSkillTriggerInfo,
			// Token: 0x0400C84C RID: 51276
			PhantomBattleBuffTriggerInfo,
			// Token: 0x0400C84D RID: 51277
			NpcPhantomBattleCardSkillInfo,
			// Token: 0x0400C84E RID: 51278
			NpcPhantomBattleCardRoleSkillInfo,
			// Token: 0x0400C84F RID: 51279
			NpcPhantomBattleGamerStatusInfo,
			// Token: 0x0400C850 RID: 51280
			NpcPhantomBattleCardAttrInfo,
			// Token: 0x0400C851 RID: 51281
			NpcPhantomBattleEnterSlotInfo,
			// Token: 0x0400C852 RID: 51282
			NpcPhantomBattleBackCardLibrary,
			// Token: 0x0400C853 RID: 51283
			NpcPhantomBattleDiscardInfo,
			// Token: 0x0400C854 RID: 51284
			NpcPhantomFourCTaskDealCardInfo,
			// Token: 0x0400C855 RID: 51285
			NpcPhantomLeaveSlot,
			// Token: 0x0400C856 RID: 51286
			NpcPhantomBattleBackSlotCardLibrary,
			// Token: 0x0400C857 RID: 51287
			NpcPhantomBattleReserveCardInfo,
			// Token: 0x0400C858 RID: 51288
			PhantomBattleNpcCardUpdateInfo = 17,
			// Token: 0x0400C859 RID: 51289
			NpcPhantomBattleDurableEmptyInfo,
			// Token: 0x0400C85A RID: 51290
			NpcPhantomBattleCardDurableSkillInfo
		}
	}
}
