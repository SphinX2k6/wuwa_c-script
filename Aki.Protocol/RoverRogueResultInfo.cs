using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001155 RID: 4437
	public sealed class RoverRogueResultInfo : IMessage<RoverRogueResultInfo>, IMessage, IEquatable<RoverRogueResultInfo>, IDeepCloneable<RoverRogueResultInfo>, IBufferMessage
	{
		// Token: 0x06017B4A RID: 97098 RVA: 0x003732D1 File Offset: 0x003714D1
		[NullableContext(1)]
		public static RoverRogueResultInfo Create()
		{
			return new RoverRogueResultInfo();
		}

		// Token: 0x17004FC0 RID: 20416
		// (get) Token: 0x06017B4B RID: 97099 RVA: 0x003732D8 File Offset: 0x003714D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FC1 RID: 20417
		// (get) Token: 0x06017B4C RID: 97100 RVA: 0x003732DB File Offset: 0x003714DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResultInfo.Descriptor;
			}
		}

		// Token: 0x06017B4D RID: 97101 RVA: 0x003732E4 File Offset: 0x003714E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo()
		{
		}

		// Token: 0x06017B4E RID: 97102 RVA: 0x0037333C File Offset: 0x0037153C
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

		// Token: 0x06017B4F RID: 97103 RVA: 0x0037346E File Offset: 0x0037166E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo Clone()
		{
			return new RoverRogueResultInfo(this);
		}

		// Token: 0x17004FC2 RID: 20418
		// (get) Token: 0x06017B50 RID: 97104 RVA: 0x00373476 File Offset: 0x00371676
		// (set) Token: 0x06017B51 RID: 97105 RVA: 0x0037347E File Offset: 0x0037167E
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

		// Token: 0x17004FC3 RID: 20419
		// (get) Token: 0x06017B52 RID: 97106 RVA: 0x00373487 File Offset: 0x00371687
		// (set) Token: 0x06017B53 RID: 97107 RVA: 0x0037348F File Offset: 0x0037168F
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

		// Token: 0x17004FC4 RID: 20420
		// (get) Token: 0x06017B54 RID: 97108 RVA: 0x00373498 File Offset: 0x00371698
		// (set) Token: 0x06017B55 RID: 97109 RVA: 0x003734A0 File Offset: 0x003716A0
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

		// Token: 0x17004FC5 RID: 20421
		// (get) Token: 0x06017B56 RID: 97110 RVA: 0x003734A9 File Offset: 0x003716A9
		// (set) Token: 0x06017B57 RID: 97111 RVA: 0x003734B1 File Offset: 0x003716B1
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

		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x06017B58 RID: 97112 RVA: 0x003734BA File Offset: 0x003716BA
		// (set) Token: 0x06017B59 RID: 97113 RVA: 0x003734C2 File Offset: 0x003716C2
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

		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x06017B5A RID: 97114 RVA: 0x003734CB File Offset: 0x003716CB
		// (set) Token: 0x06017B5B RID: 97115 RVA: 0x003734D3 File Offset: 0x003716D3
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

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x06017B5C RID: 97116 RVA: 0x003734DC File Offset: 0x003716DC
		// (set) Token: 0x06017B5D RID: 97117 RVA: 0x003734E4 File Offset: 0x003716E4
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

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x06017B5E RID: 97118 RVA: 0x003734ED File Offset: 0x003716ED
		// (set) Token: 0x06017B5F RID: 97119 RVA: 0x003734F5 File Offset: 0x003716F5
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

		// Token: 0x17004FCA RID: 20426
		// (get) Token: 0x06017B60 RID: 97120 RVA: 0x003734FE File Offset: 0x003716FE
		// (set) Token: 0x06017B61 RID: 97121 RVA: 0x00373506 File Offset: 0x00371706
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

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x06017B62 RID: 97122 RVA: 0x0037350F File Offset: 0x0037170F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueSettleReward> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x06017B63 RID: 97123 RVA: 0x00373517 File Offset: 0x00371717
		// (set) Token: 0x06017B64 RID: 97124 RVA: 0x0037351F File Offset: 0x0037171F
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

		// Token: 0x17004FCD RID: 20429
		// (get) Token: 0x06017B65 RID: 97125 RVA: 0x00373528 File Offset: 0x00371728
		// (set) Token: 0x06017B66 RID: 97126 RVA: 0x00373530 File Offset: 0x00371730
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

		// Token: 0x17004FCE RID: 20430
		// (get) Token: 0x06017B67 RID: 97127 RVA: 0x00373539 File Offset: 0x00371739
		// (set) Token: 0x06017B68 RID: 97128 RVA: 0x00373541 File Offset: 0x00371741
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

		// Token: 0x17004FCF RID: 20431
		// (get) Token: 0x06017B69 RID: 97129 RVA: 0x0037354A File Offset: 0x0037174A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainBlessConfId
		{
			get
			{
				return this.gainBlessConfId_;
			}
		}

		// Token: 0x17004FD0 RID: 20432
		// (get) Token: 0x06017B6A RID: 97130 RVA: 0x00373552 File Offset: 0x00371752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainRoleConfId
		{
			get
			{
				return this.gainRoleConfId_;
			}
		}

		// Token: 0x17004FD1 RID: 20433
		// (get) Token: 0x06017B6B RID: 97131 RVA: 0x0037355A File Offset: 0x0037175A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainItemConfId
		{
			get
			{
				return this.gainItemConfId_;
			}
		}

		// Token: 0x17004FD2 RID: 20434
		// (get) Token: 0x06017B6C RID: 97132 RVA: 0x00373562 File Offset: 0x00371762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GainLootConfId
		{
			get
			{
				return this.gainLootConfId_;
			}
		}

		// Token: 0x17004FD3 RID: 20435
		// (get) Token: 0x06017B6D RID: 97133 RVA: 0x0037356A File Offset: 0x0037176A
		// (set) Token: 0x06017B6E RID: 97134 RVA: 0x00373572 File Offset: 0x00371772
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

		// Token: 0x17004FD4 RID: 20436
		// (get) Token: 0x06017B6F RID: 97135 RVA: 0x0037357B File Offset: 0x0037177B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> GainLootInfo
		{
			get
			{
				return this.gainLootInfo_;
			}
		}

		// Token: 0x17004FD5 RID: 20437
		// (get) Token: 0x06017B70 RID: 97136 RVA: 0x00373583 File Offset: 0x00371783
		// (set) Token: 0x06017B71 RID: 97137 RVA: 0x0037358B File Offset: 0x0037178B
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

		// Token: 0x06017B72 RID: 97138 RVA: 0x00373594 File Offset: 0x00371794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResultInfo);
		}

		// Token: 0x06017B73 RID: 97139 RVA: 0x003735A4 File Offset: 0x003717A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResultInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.Grade == other.Grade && this.TotalCostTime == other.TotalCostTime && this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoverId == other.RoverId && this.IsDeadTrigger == other.IsDeadTrigger && this.GainCount == other.GainCount && this.RoomPassedCount == other.RoomPassedCount && this.rewards_.Equals(other.rewards_) && this.BossRoom == other.BossRoom && this.EliteRoom == other.EliteRoom && this.TotalGold == other.TotalGold && this.gainBlessConfId_.Equals(other.gainBlessConfId_) && this.gainRoleConfId_.Equals(other.gainRoleConfId_) && this.gainItemConfId_.Equals(other.gainItemConfId_) && this.gainLootConfId_.Equals(other.gainLootConfId_) && this.RoleType == other.RoleType && this.gainLootInfo_.Equals(other.gainLootInfo_) && this.SettleType == other.SettleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B74 RID: 97140 RVA: 0x0037372C File Offset: 0x0037192C
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

		// Token: 0x06017B75 RID: 97141 RVA: 0x00373912 File Offset: 0x00371B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B76 RID: 97142 RVA: 0x0037391F File Offset: 0x00371B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B77 RID: 97143 RVA: 0x00373928 File Offset: 0x00371B28
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

		// Token: 0x06017B78 RID: 97144 RVA: 0x00373B40 File Offset: 0x00371D40
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

		// Token: 0x06017B79 RID: 97145 RVA: 0x00373D1C File Offset: 0x00371F1C
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

		// Token: 0x06017B7A RID: 97146 RVA: 0x00373EC2 File Offset: 0x003720C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B7B RID: 97147 RVA: 0x00373ECC File Offset: 0x003720CC
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

		// Token: 0x04008D6C RID: 36204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D6D RID: 36205
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008D6E RID: 36206
		private int instId_;

		// Token: 0x04008D6F RID: 36207
		public const int GradeFieldNumber = 3;

		// Token: 0x04008D70 RID: 36208
		private RoverRogueGrade grade_;

		// Token: 0x04008D71 RID: 36209
		public const int TotalCostTimeFieldNumber = 4;

		// Token: 0x04008D72 RID: 36210
		private long totalCostTime_;

		// Token: 0x04008D73 RID: 36211
		public const int CurLayerFieldNumber = 5;

		// Token: 0x04008D74 RID: 36212
		private int curLayer_;

		// Token: 0x04008D75 RID: 36213
		public const int MaxLayerFieldNumber = 6;

		// Token: 0x04008D76 RID: 36214
		private int maxLayer_;

		// Token: 0x04008D77 RID: 36215
		public const int RoverIdFieldNumber = 7;

		// Token: 0x04008D78 RID: 36216
		private int roverId_;

		// Token: 0x04008D79 RID: 36217
		public const int IsDeadTriggerFieldNumber = 8;

		// Token: 0x04008D7A RID: 36218
		private bool isDeadTrigger_;

		// Token: 0x04008D7B RID: 36219
		public const int GainCountFieldNumber = 9;

		// Token: 0x04008D7C RID: 36220
		private int gainCount_;

		// Token: 0x04008D7D RID: 36221
		public const int RoomPassedCountFieldNumber = 10;

		// Token: 0x04008D7E RID: 36222
		private int roomPassedCount_;

		// Token: 0x04008D7F RID: 36223
		public const int RewardsFieldNumber = 11;

		// Token: 0x04008D80 RID: 36224
		private static readonly FieldCodec<RoverRogueSettleReward> _repeated_rewards_codec = FieldCodec.ForMessage<RoverRogueSettleReward>(90U, RoverRogueSettleReward.Parser);

		// Token: 0x04008D81 RID: 36225
		private readonly RepeatedField<RoverRogueSettleReward> rewards_ = new RepeatedField<RoverRogueSettleReward>();

		// Token: 0x04008D82 RID: 36226
		public const int BossRoomFieldNumber = 12;

		// Token: 0x04008D83 RID: 36227
		private int bossRoom_;

		// Token: 0x04008D84 RID: 36228
		public const int EliteRoomFieldNumber = 13;

		// Token: 0x04008D85 RID: 36229
		private int eliteRoom_;

		// Token: 0x04008D86 RID: 36230
		public const int TotalGoldFieldNumber = 14;

		// Token: 0x04008D87 RID: 36231
		private int totalGold_;

		// Token: 0x04008D88 RID: 36232
		public const int GainBlessConfIdFieldNumber = 15;

		// Token: 0x04008D89 RID: 36233
		private static readonly FieldCodec<int> _repeated_gainBlessConfId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008D8A RID: 36234
		private readonly RepeatedField<int> gainBlessConfId_ = new RepeatedField<int>();

		// Token: 0x04008D8B RID: 36235
		public const int GainRoleConfIdFieldNumber = 16;

		// Token: 0x04008D8C RID: 36236
		private static readonly FieldCodec<int> _repeated_gainRoleConfId_codec = FieldCodec.ForInt32(130U);

		// Token: 0x04008D8D RID: 36237
		private readonly RepeatedField<int> gainRoleConfId_ = new RepeatedField<int>();

		// Token: 0x04008D8E RID: 36238
		public const int GainItemConfIdFieldNumber = 17;

		// Token: 0x04008D8F RID: 36239
		private static readonly FieldCodec<int> _repeated_gainItemConfId_codec = FieldCodec.ForInt32(138U);

		// Token: 0x04008D90 RID: 36240
		private readonly RepeatedField<int> gainItemConfId_ = new RepeatedField<int>();

		// Token: 0x04008D91 RID: 36241
		public const int GainLootConfIdFieldNumber = 18;

		// Token: 0x04008D92 RID: 36242
		private static readonly FieldCodec<int> _repeated_gainLootConfId_codec = FieldCodec.ForInt32(146U);

		// Token: 0x04008D93 RID: 36243
		private readonly RepeatedField<int> gainLootConfId_ = new RepeatedField<int>();

		// Token: 0x04008D94 RID: 36244
		public const int RoleTypeFieldNumber = 19;

		// Token: 0x04008D95 RID: 36245
		private int roleType_;

		// Token: 0x04008D96 RID: 36246
		public const int GainLootInfoFieldNumber = 20;

		// Token: 0x04008D97 RID: 36247
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_gainLootInfo_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(162U, RoverRogueGainEntry.Parser);

		// Token: 0x04008D98 RID: 36248
		private readonly RepeatedField<RoverRogueGainEntry> gainLootInfo_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008D99 RID: 36249
		public const int SettleTypeFieldNumber = 21;

		// Token: 0x04008D9A RID: 36250
		private RoverRogueInstState settleType_;
	}
}
