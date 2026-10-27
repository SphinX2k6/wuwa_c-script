using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111B RID: 4379
	public sealed class RoverRogueResultInfo : IMessage<RoverRogueResultInfo>, IMessage, IEquatable<RoverRogueResultInfo>, IDeepCloneable<RoverRogueResultInfo>, IBufferMessage
	{
		// Token: 0x060175A9 RID: 95657 RVA: 0x00363F81 File Offset: 0x00362181
		[NullableContext(1)]
		public static RoverRogueResultInfo Create()
		{
			return new RoverRogueResultInfo();
		}

		// Token: 0x17004E54 RID: 20052
		// (get) Token: 0x060175AA RID: 95658 RVA: 0x00363F88 File Offset: 0x00362188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E55 RID: 20053
		// (get) Token: 0x060175AB RID: 95659 RVA: 0x00363F8B File Offset: 0x0036218B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResultInfo.Descriptor;
			}
		}

		// Token: 0x060175AC RID: 95660 RVA: 0x00363F94 File Offset: 0x00362194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo()
		{
		}

		// Token: 0x060175AD RID: 95661 RVA: 0x00363FEC File Offset: 0x003621EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo(RoverRogueResultInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.grade_ = other.grade_;
			this.totalCostTime_ = other.totalCostTime_;
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.roverId_ = other.roverId_;
			this.isDeadTrigger_ = other.isDeadTrigger_;
			this.gainCount_ = other.gainCount_;
			this.roomPassedCount_ = other.roomPassedCount_;
			this.rewards_ = other.rewards_.Clone();
			this.bossRoom_ = other.bossRoom_;
			this.eliteRoom_ = other.eliteRoom_;
			this.totalGold_ = other.totalGold_;
			this.gainBlessConfId_ = other.gainBlessConfId_.Clone();
			this.gainRoleConfId_ = other.gainRoleConfId_.Clone();
			this.gainItemConfId_ = other.gainItemConfId_.Clone();
			this.gainLootConfId_ = other.gainLootConfId_.Clone();
			this.roleType_ = other.roleType_;
			this.gainLootInfo_ = other.gainLootInfo_.Clone();
			this.settleType_ = other.settleType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060175AE RID: 95662 RVA: 0x0036411E File Offset: 0x0036231E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo Clone()
		{
			return new RoverRogueResultInfo(this);
		}

		// Token: 0x17004E56 RID: 20054
		// (get) Token: 0x060175AF RID: 95663 RVA: 0x00364126 File Offset: 0x00362326
		// (set) Token: 0x060175B0 RID: 95664 RVA: 0x0036412E File Offset: 0x0036232E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17004E57 RID: 20055
		// (get) Token: 0x060175B1 RID: 95665 RVA: 0x00364137 File Offset: 0x00362337
		// (set) Token: 0x060175B2 RID: 95666 RVA: 0x0036413F File Offset: 0x0036233F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGrade Grade
		{
			get
			{
				return this.grade_;
			}
			set
			{
				this.grade_ = value;
			}
		}

		// Token: 0x17004E58 RID: 20056
		// (get) Token: 0x060175B3 RID: 95667 RVA: 0x00364148 File Offset: 0x00362348
		// (set) Token: 0x060175B4 RID: 95668 RVA: 0x00364150 File Offset: 0x00362350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalCostTime
		{
			get
			{
				return this.totalCostTime_;
			}
			set
			{
				this.totalCostTime_ = value;
			}
		}

		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x060175B5 RID: 95669 RVA: 0x00364159 File Offset: 0x00362359
		// (set) Token: 0x060175B6 RID: 95670 RVA: 0x00364161 File Offset: 0x00362361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLayer
		{
			get
			{
				return this.curLayer_;
			}
			set
			{
				this.curLayer_ = value;
			}
		}

		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x060175B7 RID: 95671 RVA: 0x0036416A File Offset: 0x0036236A
		// (set) Token: 0x060175B8 RID: 95672 RVA: 0x00364172 File Offset: 0x00362372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLayer
		{
			get
			{
				return this.maxLayer_;
			}
			set
			{
				this.maxLayer_ = value;
			}
		}

		// Token: 0x17004E5B RID: 20059
		// (get) Token: 0x060175B9 RID: 95673 RVA: 0x0036417B File Offset: 0x0036237B
		// (set) Token: 0x060175BA RID: 95674 RVA: 0x00364183 File Offset: 0x00362383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverId
		{
			get
			{
				return this.roverId_;
			}
			set
			{
				this.roverId_ = value;
			}
		}

		// Token: 0x17004E5C RID: 20060
		// (get) Token: 0x060175BB RID: 95675 RVA: 0x0036418C File Offset: 0x0036238C
		// (set) Token: 0x060175BC RID: 95676 RVA: 0x00364194 File Offset: 0x00362394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDeadTrigger
		{
			get
			{
				return this.isDeadTrigger_;
			}
			set
			{
				this.isDeadTrigger_ = value;
			}
		}

		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x060175BD RID: 95677 RVA: 0x0036419D File Offset: 0x0036239D
		// (set) Token: 0x060175BE RID: 95678 RVA: 0x003641A5 File Offset: 0x003623A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GainCount
		{
			get
			{
				return this.gainCount_;
			}
			set
			{
				this.gainCount_ = value;
			}
		}

		// Token: 0x17004E5E RID: 20062
		// (get) Token: 0x060175BF RID: 95679 RVA: 0x003641AE File Offset: 0x003623AE
		// (set) Token: 0x060175C0 RID: 95680 RVA: 0x003641B6 File Offset: 0x003623B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomPassedCount
		{
			get
			{
				return this.roomPassedCount_;
			}
			set
			{
				this.roomPassedCount_ = value;
			}
		}

		// Token: 0x17004E5F RID: 20063
		// (get) Token: 0x060175C1 RID: 95681 RVA: 0x003641BF File Offset: 0x003623BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueSettleReward> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x17004E60 RID: 20064
		// (get) Token: 0x060175C2 RID: 95682 RVA: 0x003641C7 File Offset: 0x003623C7
		// (set) Token: 0x060175C3 RID: 95683 RVA: 0x003641CF File Offset: 0x003623CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossRoom
		{
			get
			{
				return this.bossRoom_;
			}
			set
			{
				this.bossRoom_ = value;
			}
		}

		// Token: 0x17004E61 RID: 20065
		// (get) Token: 0x060175C4 RID: 95684 RVA: 0x003641D8 File Offset: 0x003623D8
		// (set) Token: 0x060175C5 RID: 95685 RVA: 0x003641E0 File Offset: 0x003623E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EliteRoom
		{
			get
			{
				return this.eliteRoom_;
			}
			set
			{
				this.eliteRoom_ = value;
			}
		}

		// Token: 0x17004E62 RID: 20066
		// (get) Token: 0x060175C6 RID: 95686 RVA: 0x003641E9 File Offset: 0x003623E9
		// (set) Token: 0x060175C7 RID: 95687 RVA: 0x003641F1 File Offset: 0x003623F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalGold
		{
			get
			{
				return this.totalGold_;
			}
			set
			{
				this.totalGold_ = value;
			}
		}

		// Token: 0x17004E63 RID: 20067
		// (get) Token: 0x060175C8 RID: 95688 RVA: 0x003641FA File Offset: 0x003623FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainBlessConfId
		{
			get
			{
				return this.gainBlessConfId_;
			}
		}

		// Token: 0x17004E64 RID: 20068
		// (get) Token: 0x060175C9 RID: 95689 RVA: 0x00364202 File Offset: 0x00362402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainRoleConfId
		{
			get
			{
				return this.gainRoleConfId_;
			}
		}

		// Token: 0x17004E65 RID: 20069
		// (get) Token: 0x060175CA RID: 95690 RVA: 0x0036420A File Offset: 0x0036240A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainItemConfId
		{
			get
			{
				return this.gainItemConfId_;
			}
		}

		// Token: 0x17004E66 RID: 20070
		// (get) Token: 0x060175CB RID: 95691 RVA: 0x00364212 File Offset: 0x00362412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainLootConfId
		{
			get
			{
				return this.gainLootConfId_;
			}
		}

		// Token: 0x17004E67 RID: 20071
		// (get) Token: 0x060175CC RID: 95692 RVA: 0x0036421A File Offset: 0x0036241A
		// (set) Token: 0x060175CD RID: 95693 RVA: 0x00364222 File Offset: 0x00362422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleType
		{
			get
			{
				return this.roleType_;
			}
			set
			{
				this.roleType_ = value;
			}
		}

		// Token: 0x17004E68 RID: 20072
		// (get) Token: 0x060175CE RID: 95694 RVA: 0x0036422B File Offset: 0x0036242B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> GainLootInfo
		{
			get
			{
				return this.gainLootInfo_;
			}
		}

		// Token: 0x17004E69 RID: 20073
		// (get) Token: 0x060175CF RID: 95695 RVA: 0x00364233 File Offset: 0x00362433
		// (set) Token: 0x060175D0 RID: 95696 RVA: 0x0036423B File Offset: 0x0036243B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInstState SettleType
		{
			get
			{
				return this.settleType_;
			}
			set
			{
				this.settleType_ = value;
			}
		}

		// Token: 0x060175D1 RID: 95697 RVA: 0x00364244 File Offset: 0x00362444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResultInfo);
		}

		// Token: 0x060175D2 RID: 95698 RVA: 0x00364254 File Offset: 0x00362454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResultInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.Grade == other.Grade && this.TotalCostTime == other.TotalCostTime && this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoverId == other.RoverId && this.IsDeadTrigger == other.IsDeadTrigger && this.GainCount == other.GainCount && this.RoomPassedCount == other.RoomPassedCount && this.rewards_.Equals(other.rewards_) && this.BossRoom == other.BossRoom && this.EliteRoom == other.EliteRoom && this.TotalGold == other.TotalGold && this.gainBlessConfId_.Equals(other.gainBlessConfId_) && this.gainRoleConfId_.Equals(other.gainRoleConfId_) && this.gainItemConfId_.Equals(other.gainItemConfId_) && this.gainLootConfId_.Equals(other.gainLootConfId_) && this.RoleType == other.RoleType && this.gainLootInfo_.Equals(other.gainLootInfo_) && this.SettleType == other.SettleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060175D3 RID: 95699 RVA: 0x003643DC File Offset: 0x003625DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.Grade != RoverRogueGrade.B)
			{
				num ^= this.Grade.GetHashCode();
			}
			if (this.TotalCostTime != 0L)
			{
				num ^= this.TotalCostTime.GetHashCode();
			}
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.MaxLayer != 0)
			{
				num ^= this.MaxLayer.GetHashCode();
			}
			if (this.RoverId != 0)
			{
				num ^= this.RoverId.GetHashCode();
			}
			if (this.IsDeadTrigger)
			{
				num ^= this.IsDeadTrigger.GetHashCode();
			}
			if (this.GainCount != 0)
			{
				num ^= this.GainCount.GetHashCode();
			}
			if (this.RoomPassedCount != 0)
			{
				num ^= this.RoomPassedCount.GetHashCode();
			}
			num ^= this.rewards_.GetHashCode();
			if (this.BossRoom != 0)
			{
				num ^= this.BossRoom.GetHashCode();
			}
			if (this.EliteRoom != 0)
			{
				num ^= this.EliteRoom.GetHashCode();
			}
			if (this.TotalGold != 0)
			{
				num ^= this.TotalGold.GetHashCode();
			}
			num ^= this.gainBlessConfId_.GetHashCode();
			num ^= this.gainRoleConfId_.GetHashCode();
			num ^= this.gainItemConfId_.GetHashCode();
			num ^= this.gainLootConfId_.GetHashCode();
			if (this.RoleType != 0)
			{
				num ^= this.RoleType.GetHashCode();
			}
			num ^= this.gainLootInfo_.GetHashCode();
			if (this.SettleType != RoverRogueInstState.RoverRogueInstNotStart)
			{
				num ^= this.SettleType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060175D4 RID: 95700 RVA: 0x003645C2 File Offset: 0x003627C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060175D5 RID: 95701 RVA: 0x003645CF File Offset: 0x003627CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060175D6 RID: 95702 RVA: 0x003645D8 File Offset: 0x003627D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.Grade != RoverRogueGrade.B)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Grade);
			}
			if (this.TotalCostTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TotalCostTime);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.RoverId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoverId);
			}
			if (this.IsDeadTrigger)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsDeadTrigger);
			}
			if (this.GainCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GainCount);
			}
			if (this.RoomPassedCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoomPassedCount);
			}
			this.rewards_.WriteTo(ref output, RoverRogueResultInfo._repeated_rewards_codec);
			if (this.BossRoom != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BossRoom);
			}
			if (this.EliteRoom != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EliteRoom);
			}
			if (this.TotalGold != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TotalGold);
			}
			this.gainBlessConfId_.WriteTo(ref output, RoverRogueResultInfo._repeated_gainBlessConfId_codec);
			this.gainRoleConfId_.WriteTo(ref output, RoverRogueResultInfo._repeated_gainRoleConfId_codec);
			this.gainItemConfId_.WriteTo(ref output, RoverRogueResultInfo._repeated_gainItemConfId_codec);
			this.gainLootConfId_.WriteTo(ref output, RoverRogueResultInfo._repeated_gainLootConfId_codec);
			if (this.RoleType != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.RoleType);
			}
			this.gainLootInfo_.WriteTo(ref output, RoverRogueResultInfo._repeated_gainLootInfo_codec);
			if (this.SettleType != RoverRogueInstState.RoverRogueInstNotStart)
			{
				output.WriteRawTag(168, 1);
				output.WriteEnum((int)this.SettleType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060175D7 RID: 95703 RVA: 0x003647F0 File Offset: 0x003629F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.Grade != RoverRogueGrade.B)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Grade);
			}
			if (this.TotalCostTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalCostTime);
			}
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLayer);
			}
			if (this.RoverId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoverId);
			}
			if (this.IsDeadTrigger)
			{
				num += 2;
			}
			if (this.GainCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GainCount);
			}
			if (this.RoomPassedCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomPassedCount);
			}
			num += this.rewards_.CalculateSize(RoverRogueResultInfo._repeated_rewards_codec);
			if (this.BossRoom != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossRoom);
			}
			if (this.EliteRoom != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EliteRoom);
			}
			if (this.TotalGold != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalGold);
			}
			num += this.gainBlessConfId_.CalculateSize(RoverRogueResultInfo._repeated_gainBlessConfId_codec);
			num += this.gainRoleConfId_.CalculateSize(RoverRogueResultInfo._repeated_gainRoleConfId_codec);
			num += this.gainItemConfId_.CalculateSize(RoverRogueResultInfo._repeated_gainItemConfId_codec);
			num += this.gainLootConfId_.CalculateSize(RoverRogueResultInfo._repeated_gainLootConfId_codec);
			if (this.RoleType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoleType);
			}
			num += this.gainLootInfo_.CalculateSize(RoverRogueResultInfo._repeated_gainLootInfo_codec);
			if (this.SettleType != RoverRogueInstState.RoverRogueInstNotStart)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.SettleType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060175D8 RID: 95704 RVA: 0x003649CC File Offset: 0x00362BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.Grade != RoverRogueGrade.B)
			{
				this.Grade = other.Grade;
			}
			if (other.TotalCostTime != 0L)
			{
				this.TotalCostTime = other.TotalCostTime;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.MaxLayer != 0)
			{
				this.MaxLayer = other.MaxLayer;
			}
			if (other.RoverId != 0)
			{
				this.RoverId = other.RoverId;
			}
			if (other.IsDeadTrigger)
			{
				this.IsDeadTrigger = other.IsDeadTrigger;
			}
			if (other.GainCount != 0)
			{
				this.GainCount = other.GainCount;
			}
			if (other.RoomPassedCount != 0)
			{
				this.RoomPassedCount = other.RoomPassedCount;
			}
			this.rewards_.Add(other.rewards_);
			if (other.BossRoom != 0)
			{
				this.BossRoom = other.BossRoom;
			}
			if (other.EliteRoom != 0)
			{
				this.EliteRoom = other.EliteRoom;
			}
			if (other.TotalGold != 0)
			{
				this.TotalGold = other.TotalGold;
			}
			this.gainBlessConfId_.Add(other.gainBlessConfId_);
			this.gainRoleConfId_.Add(other.gainRoleConfId_);
			this.gainItemConfId_.Add(other.gainItemConfId_);
			this.gainLootConfId_.Add(other.gainLootConfId_);
			if (other.RoleType != 0)
			{
				this.RoleType = other.RoleType;
			}
			this.gainLootInfo_.Add(other.gainLootInfo_);
			if (other.SettleType != RoverRogueInstState.RoverRogueInstNotStart)
			{
				this.SettleType = other.SettleType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060175D9 RID: 95705 RVA: 0x00364B72 File Offset: 0x00362D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060175DA RID: 95706 RVA: 0x00364B7C File Offset: 0x00362D7C
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
				if (num > 104U)
				{
					if (num <= 136U)
					{
						if (num <= 122U)
						{
							if (num == 112U)
							{
								this.TotalGold = input.ReadInt32();
								continue;
							}
							if (num != 120U && num != 122U)
							{
								goto IL_12C;
							}
							this.gainBlessConfId_.AddEntriesFrom(ref input, RoverRogueResultInfo._repeated_gainBlessConfId_codec);
							continue;
						}
						else
						{
							if (num == 128U || num == 130U)
							{
								this.gainRoleConfId_.AddEntriesFrom(ref input, RoverRogueResultInfo._repeated_gainRoleConfId_codec);
								continue;
							}
							if (num != 136U)
							{
								goto IL_12C;
							}
						}
					}
					else if (num <= 146U)
					{
						if (num != 138U)
						{
							if (num != 144U && num != 146U)
							{
								goto IL_12C;
							}
							this.gainLootConfId_.AddEntriesFrom(ref input, RoverRogueResultInfo._repeated_gainLootConfId_codec);
							continue;
						}
					}
					else
					{
						if (num == 152U)
						{
							this.RoleType = input.ReadInt32();
							continue;
						}
						if (num == 162U)
						{
							this.gainLootInfo_.AddEntriesFrom(ref input, RoverRogueResultInfo._repeated_gainLootInfo_codec);
							continue;
						}
						if (num != 168U)
						{
							goto IL_12C;
						}
						this.SettleType = (RoverRogueInstState)input.ReadEnum();
						continue;
					}
					this.gainItemConfId_.AddEntriesFrom(ref input, RoverRogueResultInfo._repeated_gainItemConfId_codec);
					continue;
				}
				if (num <= 56U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.InstId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.Grade = (RoverRogueGrade)input.ReadEnum();
							continue;
						}
						if (num == 32U)
						{
							this.TotalCostTime = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.CurLayer = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.MaxLayer = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.RoverId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.IsDeadTrigger = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.GainCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RoomPassedCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.rewards_.AddEntriesFrom(ref input, RoverRogueResultInfo._repeated_rewards_codec);
						continue;
					}
					if (num == 96U)
					{
						this.BossRoom = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.EliteRoom = input.ReadInt32();
						continue;
					}
				}
				IL_12C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008AD9 RID: 35545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ADA RID: 35546
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008ADB RID: 35547
		private int instId_;

		// Token: 0x04008ADC RID: 35548
		public const int GradeFieldNumber = 3;

		// Token: 0x04008ADD RID: 35549
		private RoverRogueGrade grade_;

		// Token: 0x04008ADE RID: 35550
		public const int TotalCostTimeFieldNumber = 4;

		// Token: 0x04008ADF RID: 35551
		private long totalCostTime_;

		// Token: 0x04008AE0 RID: 35552
		public const int CurLayerFieldNumber = 5;

		// Token: 0x04008AE1 RID: 35553
		private int curLayer_;

		// Token: 0x04008AE2 RID: 35554
		public const int MaxLayerFieldNumber = 6;

		// Token: 0x04008AE3 RID: 35555
		private int maxLayer_;

		// Token: 0x04008AE4 RID: 35556
		public const int RoverIdFieldNumber = 7;

		// Token: 0x04008AE5 RID: 35557
		private int roverId_;

		// Token: 0x04008AE6 RID: 35558
		public const int IsDeadTriggerFieldNumber = 8;

		// Token: 0x04008AE7 RID: 35559
		private bool isDeadTrigger_;

		// Token: 0x04008AE8 RID: 35560
		public const int GainCountFieldNumber = 9;

		// Token: 0x04008AE9 RID: 35561
		private int gainCount_;

		// Token: 0x04008AEA RID: 35562
		public const int RoomPassedCountFieldNumber = 10;

		// Token: 0x04008AEB RID: 35563
		private int roomPassedCount_;

		// Token: 0x04008AEC RID: 35564
		public const int RewardsFieldNumber = 11;

		// Token: 0x04008AED RID: 35565
		private static readonly FieldCodec<RoverRogueSettleReward> _repeated_rewards_codec = FieldCodec.ForMessage<RoverRogueSettleReward>(90U, RoverRogueSettleReward.Parser);

		// Token: 0x04008AEE RID: 35566
		private readonly RepeatedField<RoverRogueSettleReward> rewards_ = new RepeatedField<RoverRogueSettleReward>();

		// Token: 0x04008AEF RID: 35567
		public const int BossRoomFieldNumber = 12;

		// Token: 0x04008AF0 RID: 35568
		private int bossRoom_;

		// Token: 0x04008AF1 RID: 35569
		public const int EliteRoomFieldNumber = 13;

		// Token: 0x04008AF2 RID: 35570
		private int eliteRoom_;

		// Token: 0x04008AF3 RID: 35571
		public const int TotalGoldFieldNumber = 14;

		// Token: 0x04008AF4 RID: 35572
		private int totalGold_;

		// Token: 0x04008AF5 RID: 35573
		public const int GainBlessConfIdFieldNumber = 15;

		// Token: 0x04008AF6 RID: 35574
		private static readonly FieldCodec<int> _repeated_gainBlessConfId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008AF7 RID: 35575
		private readonly RepeatedField<int> gainBlessConfId_ = new RepeatedField<int>();

		// Token: 0x04008AF8 RID: 35576
		public const int GainRoleConfIdFieldNumber = 16;

		// Token: 0x04008AF9 RID: 35577
		private static readonly FieldCodec<int> _repeated_gainRoleConfId_codec = FieldCodec.ForInt32(130U);

		// Token: 0x04008AFA RID: 35578
		private readonly RepeatedField<int> gainRoleConfId_ = new RepeatedField<int>();

		// Token: 0x04008AFB RID: 35579
		public const int GainItemConfIdFieldNumber = 17;

		// Token: 0x04008AFC RID: 35580
		private static readonly FieldCodec<int> _repeated_gainItemConfId_codec = FieldCodec.ForInt32(138U);

		// Token: 0x04008AFD RID: 35581
		private readonly RepeatedField<int> gainItemConfId_ = new RepeatedField<int>();

		// Token: 0x04008AFE RID: 35582
		public const int GainLootConfIdFieldNumber = 18;

		// Token: 0x04008AFF RID: 35583
		private static readonly FieldCodec<int> _repeated_gainLootConfId_codec = FieldCodec.ForInt32(146U);

		// Token: 0x04008B00 RID: 35584
		private readonly RepeatedField<int> gainLootConfId_ = new RepeatedField<int>();

		// Token: 0x04008B01 RID: 35585
		public const int RoleTypeFieldNumber = 19;

		// Token: 0x04008B02 RID: 35586
		private int roleType_;

		// Token: 0x04008B03 RID: 35587
		public const int GainLootInfoFieldNumber = 20;

		// Token: 0x04008B04 RID: 35588
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_gainLootInfo_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(162U, RoverRogueGainEntry.Parser);

		// Token: 0x04008B05 RID: 35589
		private readonly RepeatedField<RoverRogueGainEntry> gainLootInfo_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008B06 RID: 35590
		public const int SettleTypeFieldNumber = 21;

		// Token: 0x04008B07 RID: 35591
		private RoverRogueInstState settleType_;
	}
}
