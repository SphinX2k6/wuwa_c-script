using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9D RID: 3997
	public sealed class RoguelikeResultInfo : IMessage<RoguelikeResultInfo>, IMessage, IEquatable<RoguelikeResultInfo>, IDeepCloneable<RoguelikeResultInfo>, IBufferMessage
	{
		// Token: 0x06015666 RID: 87654 RVA: 0x0031BB61 File Offset: 0x00319D61
		[NullableContext(1)]
		public static RoguelikeResultInfo Create()
		{
			return new RoguelikeResultInfo();
		}

		// Token: 0x1700475A RID: 18266
		// (get) Token: 0x06015667 RID: 87655 RVA: 0x0031BB68 File Offset: 0x00319D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700475B RID: 18267
		// (get) Token: 0x06015668 RID: 87656 RVA: 0x0031BB6B File Offset: 0x00319D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeResultInfo.Descriptor;
			}
		}

		// Token: 0x06015669 RID: 87657 RVA: 0x0031BB72 File Offset: 0x00319D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultInfo()
		{
		}

		// Token: 0x0601566A RID: 87658 RVA: 0x0031BB88 File Offset: 0x00319D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultInfo(RoguelikeResultInfo other) : this()
		{
			this.isNewRecord_ = other.isNewRecord_;
			this.time_ = other.time_;
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.killEnemyCount_ = other.killEnemyCount_;
			this.getGainCount_ = other.getGainCount_;
			this.rewards_ = other.rewards_.Clone();
			this.roleEntry_ = ((other.roleEntry_ != null) ? other.roleEntry_.Clone() : null);
			this.phantomEntry_ = ((other.phantomEntry_ != null) ? other.phantomEntry_.Clone() : null);
			this.isDeadTrigger_ = other.isDeadTrigger_;
			this.instId_ = other.instId_;
			this.totalCostTime_ = other.totalCostTime_;
			this.rate_ = other.rate_;
			this.selectHotEntryGroupId_ = other.selectHotEntryGroupId_;
			this.rogueArchiveState_ = other.rogueArchiveState_;
			this.rogueArchiveInfo_ = ((other.rogueArchiveInfo_ != null) ? other.rogueArchiveInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601566B RID: 87659 RVA: 0x0031BCA1 File Offset: 0x00319EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultInfo Clone()
		{
			return new RoguelikeResultInfo(this);
		}

		// Token: 0x1700475C RID: 18268
		// (get) Token: 0x0601566C RID: 87660 RVA: 0x0031BCA9 File Offset: 0x00319EA9
		// (set) Token: 0x0601566D RID: 87661 RVA: 0x0031BCB1 File Offset: 0x00319EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewRecord
		{
			get
			{
				return this.isNewRecord_;
			}
			set
			{
				this.isNewRecord_ = value;
			}
		}

		// Token: 0x1700475D RID: 18269
		// (get) Token: 0x0601566E RID: 87662 RVA: 0x0031BCBA File Offset: 0x00319EBA
		// (set) Token: 0x0601566F RID: 87663 RVA: 0x0031BCC2 File Offset: 0x00319EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Time
		{
			get
			{
				return this.time_;
			}
			set
			{
				this.time_ = value;
			}
		}

		// Token: 0x1700475E RID: 18270
		// (get) Token: 0x06015670 RID: 87664 RVA: 0x0031BCCB File Offset: 0x00319ECB
		// (set) Token: 0x06015671 RID: 87665 RVA: 0x0031BCD3 File Offset: 0x00319ED3
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

		// Token: 0x1700475F RID: 18271
		// (get) Token: 0x06015672 RID: 87666 RVA: 0x0031BCDC File Offset: 0x00319EDC
		// (set) Token: 0x06015673 RID: 87667 RVA: 0x0031BCE4 File Offset: 0x00319EE4
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

		// Token: 0x17004760 RID: 18272
		// (get) Token: 0x06015674 RID: 87668 RVA: 0x0031BCED File Offset: 0x00319EED
		// (set) Token: 0x06015675 RID: 87669 RVA: 0x0031BCF5 File Offset: 0x00319EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KillEnemyCount
		{
			get
			{
				return this.killEnemyCount_;
			}
			set
			{
				this.killEnemyCount_ = value;
			}
		}

		// Token: 0x17004761 RID: 18273
		// (get) Token: 0x06015676 RID: 87670 RVA: 0x0031BCFE File Offset: 0x00319EFE
		// (set) Token: 0x06015677 RID: 87671 RVA: 0x0031BD06 File Offset: 0x00319F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GetGainCount
		{
			get
			{
				return this.getGainCount_;
			}
			set
			{
				this.getGainCount_ = value;
			}
		}

		// Token: 0x17004762 RID: 18274
		// (get) Token: 0x06015678 RID: 87672 RVA: 0x0031BD0F File Offset: 0x00319F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x17004763 RID: 18275
		// (get) Token: 0x06015679 RID: 87673 RVA: 0x0031BD17 File Offset: 0x00319F17
		// (set) Token: 0x0601567A RID: 87674 RVA: 0x0031BD1F File Offset: 0x00319F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry RoleEntry
		{
			get
			{
				return this.roleEntry_;
			}
			set
			{
				this.roleEntry_ = value;
			}
		}

		// Token: 0x17004764 RID: 18276
		// (get) Token: 0x0601567B RID: 87675 RVA: 0x0031BD28 File Offset: 0x00319F28
		// (set) Token: 0x0601567C RID: 87676 RVA: 0x0031BD30 File Offset: 0x00319F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry PhantomEntry
		{
			get
			{
				return this.phantomEntry_;
			}
			set
			{
				this.phantomEntry_ = value;
			}
		}

		// Token: 0x17004765 RID: 18277
		// (get) Token: 0x0601567D RID: 87677 RVA: 0x0031BD39 File Offset: 0x00319F39
		// (set) Token: 0x0601567E RID: 87678 RVA: 0x0031BD41 File Offset: 0x00319F41
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

		// Token: 0x17004766 RID: 18278
		// (get) Token: 0x0601567F RID: 87679 RVA: 0x0031BD4A File Offset: 0x00319F4A
		// (set) Token: 0x06015680 RID: 87680 RVA: 0x0031BD52 File Offset: 0x00319F52
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

		// Token: 0x17004767 RID: 18279
		// (get) Token: 0x06015681 RID: 87681 RVA: 0x0031BD5B File Offset: 0x00319F5B
		// (set) Token: 0x06015682 RID: 87682 RVA: 0x0031BD63 File Offset: 0x00319F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCostTime
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

		// Token: 0x17004768 RID: 18280
		// (get) Token: 0x06015683 RID: 87683 RVA: 0x0031BD6C File Offset: 0x00319F6C
		// (set) Token: 0x06015684 RID: 87684 RVA: 0x0031BD74 File Offset: 0x00319F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rate
		{
			get
			{
				return this.rate_;
			}
			set
			{
				this.rate_ = value;
			}
		}

		// Token: 0x17004769 RID: 18281
		// (get) Token: 0x06015685 RID: 87685 RVA: 0x0031BD7D File Offset: 0x00319F7D
		// (set) Token: 0x06015686 RID: 87686 RVA: 0x0031BD85 File Offset: 0x00319F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectHotEntryGroupId
		{
			get
			{
				return this.selectHotEntryGroupId_;
			}
			set
			{
				this.selectHotEntryGroupId_ = value;
			}
		}

		// Token: 0x1700476A RID: 18282
		// (get) Token: 0x06015687 RID: 87687 RVA: 0x0031BD8E File Offset: 0x00319F8E
		// (set) Token: 0x06015688 RID: 87688 RVA: 0x0031BD96 File Offset: 0x00319F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveState RogueArchiveState
		{
			get
			{
				return this.rogueArchiveState_;
			}
			set
			{
				this.rogueArchiveState_ = value;
			}
		}

		// Token: 0x1700476B RID: 18283
		// (get) Token: 0x06015689 RID: 87689 RVA: 0x0031BD9F File Offset: 0x00319F9F
		// (set) Token: 0x0601568A RID: 87690 RVA: 0x0031BDA7 File Offset: 0x00319FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveInfo RogueArchiveInfo
		{
			get
			{
				return this.rogueArchiveInfo_;
			}
			set
			{
				this.rogueArchiveInfo_ = value;
			}
		}

		// Token: 0x0601568B RID: 87691 RVA: 0x0031BDB0 File Offset: 0x00319FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeResultInfo);
		}

		// Token: 0x0601568C RID: 87692 RVA: 0x0031BDC0 File Offset: 0x00319FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeResultInfo other)
		{
			return other != null && (other == this || (this.IsNewRecord == other.IsNewRecord && this.Time == other.Time && this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.KillEnemyCount == other.KillEnemyCount && this.GetGainCount == other.GetGainCount && this.Rewards.Equals(other.Rewards) && object.Equals(this.RoleEntry, other.RoleEntry) && object.Equals(this.PhantomEntry, other.PhantomEntry) && this.IsDeadTrigger == other.IsDeadTrigger && this.InstId == other.InstId && this.TotalCostTime == other.TotalCostTime && this.Rate == other.Rate && this.SelectHotEntryGroupId == other.SelectHotEntryGroupId && this.RogueArchiveState == other.RogueArchiveState && object.Equals(this.RogueArchiveInfo, other.RogueArchiveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601568D RID: 87693 RVA: 0x0031BF00 File Offset: 0x0031A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsNewRecord)
			{
				num ^= this.IsNewRecord.GetHashCode();
			}
			if (this.Time != 0U)
			{
				num ^= this.Time.GetHashCode();
			}
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.MaxLayer != 0)
			{
				num ^= this.MaxLayer.GetHashCode();
			}
			if (this.KillEnemyCount != 0)
			{
				num ^= this.KillEnemyCount.GetHashCode();
			}
			if (this.GetGainCount != 0)
			{
				num ^= this.GetGainCount.GetHashCode();
			}
			num ^= this.Rewards.GetHashCode();
			if (this.roleEntry_ != null)
			{
				num ^= this.RoleEntry.GetHashCode();
			}
			if (this.phantomEntry_ != null)
			{
				num ^= this.PhantomEntry.GetHashCode();
			}
			if (this.IsDeadTrigger)
			{
				num ^= this.IsDeadTrigger.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.TotalCostTime != 0)
			{
				num ^= this.TotalCostTime.GetHashCode();
			}
			if (this.Rate != 0)
			{
				num ^= this.Rate.GetHashCode();
			}
			if (this.SelectHotEntryGroupId != 0)
			{
				num ^= this.SelectHotEntryGroupId.GetHashCode();
			}
			if (this.RogueArchiveState != RogueArchiveState.CantSave)
			{
				num ^= this.RogueArchiveState.GetHashCode();
			}
			if (this.rogueArchiveInfo_ != null)
			{
				num ^= this.RogueArchiveInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601568E RID: 87694 RVA: 0x0031C0A9 File Offset: 0x0031A2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601568F RID: 87695 RVA: 0x0031C0B6 File Offset: 0x0031A2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015690 RID: 87696 RVA: 0x0031C0C0 File Offset: 0x0031A2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNewRecord)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNewRecord);
			}
			if (this.Time != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Time);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.KillEnemyCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.KillEnemyCount);
			}
			if (this.GetGainCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GetGainCount);
			}
			this.rewards_.WriteTo(ref output, RoguelikeResultInfo._map_rewards_codec);
			if (this.roleEntry_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RoleEntry);
			}
			if (this.phantomEntry_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PhantomEntry);
			}
			if (this.IsDeadTrigger)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsDeadTrigger);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstId);
			}
			if (this.TotalCostTime != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TotalCostTime);
			}
			if (this.Rate != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Rate);
			}
			if (this.SelectHotEntryGroupId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SelectHotEntryGroupId);
			}
			if (this.RogueArchiveState != RogueArchiveState.CantSave)
			{
				output.WriteRawTag(128, 1);
				output.WriteEnum((int)this.RogueArchiveState);
			}
			if (this.rogueArchiveInfo_ != null)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.RogueArchiveInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015691 RID: 87697 RVA: 0x0031C2A0 File Offset: 0x0031A4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsNewRecord)
			{
				num += 2;
			}
			if (this.Time != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Time);
			}
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLayer);
			}
			if (this.KillEnemyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KillEnemyCount);
			}
			if (this.GetGainCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GetGainCount);
			}
			num += this.rewards_.CalculateSize(RoguelikeResultInfo._map_rewards_codec);
			if (this.roleEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleEntry);
			}
			if (this.phantomEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomEntry);
			}
			if (this.IsDeadTrigger)
			{
				num += 2;
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.TotalCostTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCostTime);
			}
			if (this.Rate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rate);
			}
			if (this.SelectHotEntryGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectHotEntryGroupId);
			}
			if (this.RogueArchiveState != RogueArchiveState.CantSave)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.RogueArchiveState);
			}
			if (this.rogueArchiveInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueArchiveInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015692 RID: 87698 RVA: 0x0031C42C File Offset: 0x0031A62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsNewRecord)
			{
				this.IsNewRecord = other.IsNewRecord;
			}
			if (other.Time != 0U)
			{
				this.Time = other.Time;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.MaxLayer != 0)
			{
				this.MaxLayer = other.MaxLayer;
			}
			if (other.KillEnemyCount != 0)
			{
				this.KillEnemyCount = other.KillEnemyCount;
			}
			if (other.GetGainCount != 0)
			{
				this.GetGainCount = other.GetGainCount;
			}
			this.rewards_.MergeFrom(other.rewards_);
			if (other.roleEntry_ != null)
			{
				if (this.roleEntry_ == null)
				{
					this.RoleEntry = new RogueGainEntry();
				}
				this.RoleEntry.MergeFrom(other.RoleEntry);
			}
			if (other.phantomEntry_ != null)
			{
				if (this.phantomEntry_ == null)
				{
					this.PhantomEntry = new RogueGainEntry();
				}
				this.PhantomEntry.MergeFrom(other.PhantomEntry);
			}
			if (other.IsDeadTrigger)
			{
				this.IsDeadTrigger = other.IsDeadTrigger;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.TotalCostTime != 0)
			{
				this.TotalCostTime = other.TotalCostTime;
			}
			if (other.Rate != 0)
			{
				this.Rate = other.Rate;
			}
			if (other.SelectHotEntryGroupId != 0)
			{
				this.SelectHotEntryGroupId = other.SelectHotEntryGroupId;
			}
			if (other.RogueArchiveState != RogueArchiveState.CantSave)
			{
				this.RogueArchiveState = other.RogueArchiveState;
			}
			if (other.rogueArchiveInfo_ != null)
			{
				if (this.rogueArchiveInfo_ == null)
				{
					this.RogueArchiveInfo = new RogueArchiveInfo();
				}
				this.RogueArchiveInfo.MergeFrom(other.RogueArchiveInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015693 RID: 87699 RVA: 0x0031C5D9 File Offset: 0x0031A7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015694 RID: 87700 RVA: 0x0031C5E4 File Offset: 0x0031A7E4
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
					if (num <= 32U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.IsNewRecord = input.ReadBool();
								continue;
							}
							if (num == 16U)
							{
								this.Time = input.ReadUInt32();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.CurLayer = input.ReadInt32();
								continue;
							}
							if (num == 32U)
							{
								this.MaxLayer = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num == 40U)
						{
							this.KillEnemyCount = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.GetGainCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 66U)
						{
							this.rewards_.AddEntriesFrom(ref input, RoguelikeResultInfo._map_rewards_codec);
							continue;
						}
						if (num == 74U)
						{
							if (this.roleEntry_ == null)
							{
								this.RoleEntry = new RogueGainEntry();
							}
							input.ReadMessage(this.RoleEntry);
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num <= 88U)
					{
						if (num == 82U)
						{
							if (this.phantomEntry_ == null)
							{
								this.PhantomEntry = new RogueGainEntry();
							}
							input.ReadMessage(this.PhantomEntry);
							continue;
						}
						if (num == 88U)
						{
							this.IsDeadTrigger = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 96U)
						{
							this.InstId = input.ReadInt32();
							continue;
						}
						if (num == 104U)
						{
							this.TotalCostTime = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num == 112U)
					{
						this.Rate = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.SelectHotEntryGroupId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 128U)
					{
						this.RogueArchiveState = (RogueArchiveState)input.ReadEnum();
						continue;
					}
					if (num == 138U)
					{
						if (this.rogueArchiveInfo_ == null)
						{
							this.RogueArchiveInfo = new RogueArchiveInfo();
						}
						input.ReadMessage(this.RogueArchiveInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008129 RID: 33065
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400812A RID: 33066
		public const int IsNewRecordFieldNumber = 1;

		// Token: 0x0400812B RID: 33067
		private bool isNewRecord_;

		// Token: 0x0400812C RID: 33068
		public const int TimeFieldNumber = 2;

		// Token: 0x0400812D RID: 33069
		private uint time_;

		// Token: 0x0400812E RID: 33070
		public const int CurLayerFieldNumber = 3;

		// Token: 0x0400812F RID: 33071
		private int curLayer_;

		// Token: 0x04008130 RID: 33072
		public const int MaxLayerFieldNumber = 4;

		// Token: 0x04008131 RID: 33073
		private int maxLayer_;

		// Token: 0x04008132 RID: 33074
		public const int KillEnemyCountFieldNumber = 5;

		// Token: 0x04008133 RID: 33075
		private int killEnemyCount_;

		// Token: 0x04008134 RID: 33076
		public const int GetGainCountFieldNumber = 6;

		// Token: 0x04008135 RID: 33077
		private int getGainCount_;

		// Token: 0x04008136 RID: 33078
		public const int RewardsFieldNumber = 8;

		// Token: 0x04008137 RID: 33079
		private static readonly MapField<int, int>.Codec _map_rewards_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x04008138 RID: 33080
		private readonly MapField<int, int> rewards_ = new MapField<int, int>();

		// Token: 0x04008139 RID: 33081
		public const int RoleEntryFieldNumber = 9;

		// Token: 0x0400813A RID: 33082
		private RogueGainEntry roleEntry_;

		// Token: 0x0400813B RID: 33083
		public const int PhantomEntryFieldNumber = 10;

		// Token: 0x0400813C RID: 33084
		private RogueGainEntry phantomEntry_;

		// Token: 0x0400813D RID: 33085
		public const int IsDeadTriggerFieldNumber = 11;

		// Token: 0x0400813E RID: 33086
		private bool isDeadTrigger_;

		// Token: 0x0400813F RID: 33087
		public const int InstIdFieldNumber = 12;

		// Token: 0x04008140 RID: 33088
		private int instId_;

		// Token: 0x04008141 RID: 33089
		public const int TotalCostTimeFieldNumber = 13;

		// Token: 0x04008142 RID: 33090
		private int totalCostTime_;

		// Token: 0x04008143 RID: 33091
		public const int RateFieldNumber = 14;

		// Token: 0x04008144 RID: 33092
		private int rate_;

		// Token: 0x04008145 RID: 33093
		public const int SelectHotEntryGroupIdFieldNumber = 15;

		// Token: 0x04008146 RID: 33094
		private int selectHotEntryGroupId_;

		// Token: 0x04008147 RID: 33095
		public const int RogueArchiveStateFieldNumber = 16;

		// Token: 0x04008148 RID: 33096
		private RogueArchiveState rogueArchiveState_;

		// Token: 0x04008149 RID: 33097
		public const int RogueArchiveInfoFieldNumber = 17;

		// Token: 0x0400814A RID: 33098
		private RogueArchiveInfo rogueArchiveInfo_;
	}
}
