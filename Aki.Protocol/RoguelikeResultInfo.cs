using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAD RID: 4013
	public sealed class RoguelikeResultInfo : IMessage<RoguelikeResultInfo>, IMessage, IEquatable<RoguelikeResultInfo>, IDeepCloneable<RoguelikeResultInfo>, IBufferMessage
	{
		// Token: 0x0601574B RID: 87883 RVA: 0x0031D20D File Offset: 0x0031B40D
		[NullableContext(1)]
		public static RoguelikeResultInfo Create()
		{
			return new RoguelikeResultInfo();
		}

		// Token: 0x17004784 RID: 18308
		// (get) Token: 0x0601574C RID: 87884 RVA: 0x0031D214 File Offset: 0x0031B414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004785 RID: 18309
		// (get) Token: 0x0601574D RID: 87885 RVA: 0x0031D217 File Offset: 0x0031B417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeResultInfo.Descriptor;
			}
		}

		// Token: 0x0601574E RID: 87886 RVA: 0x0031D21E File Offset: 0x0031B41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultInfo()
		{
		}

		// Token: 0x0601574F RID: 87887 RVA: 0x0031D234 File Offset: 0x0031B434
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

		// Token: 0x06015750 RID: 87888 RVA: 0x0031D34D File Offset: 0x0031B54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultInfo Clone()
		{
			return new RoguelikeResultInfo(this);
		}

		// Token: 0x17004786 RID: 18310
		// (get) Token: 0x06015751 RID: 87889 RVA: 0x0031D355 File Offset: 0x0031B555
		// (set) Token: 0x06015752 RID: 87890 RVA: 0x0031D35D File Offset: 0x0031B55D
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

		// Token: 0x17004787 RID: 18311
		// (get) Token: 0x06015753 RID: 87891 RVA: 0x0031D366 File Offset: 0x0031B566
		// (set) Token: 0x06015754 RID: 87892 RVA: 0x0031D36E File Offset: 0x0031B56E
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

		// Token: 0x17004788 RID: 18312
		// (get) Token: 0x06015755 RID: 87893 RVA: 0x0031D377 File Offset: 0x0031B577
		// (set) Token: 0x06015756 RID: 87894 RVA: 0x0031D37F File Offset: 0x0031B57F
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

		// Token: 0x17004789 RID: 18313
		// (get) Token: 0x06015757 RID: 87895 RVA: 0x0031D388 File Offset: 0x0031B588
		// (set) Token: 0x06015758 RID: 87896 RVA: 0x0031D390 File Offset: 0x0031B590
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

		// Token: 0x1700478A RID: 18314
		// (get) Token: 0x06015759 RID: 87897 RVA: 0x0031D399 File Offset: 0x0031B599
		// (set) Token: 0x0601575A RID: 87898 RVA: 0x0031D3A1 File Offset: 0x0031B5A1
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

		// Token: 0x1700478B RID: 18315
		// (get) Token: 0x0601575B RID: 87899 RVA: 0x0031D3AA File Offset: 0x0031B5AA
		// (set) Token: 0x0601575C RID: 87900 RVA: 0x0031D3B2 File Offset: 0x0031B5B2
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

		// Token: 0x1700478C RID: 18316
		// (get) Token: 0x0601575D RID: 87901 RVA: 0x0031D3BB File Offset: 0x0031B5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x1700478D RID: 18317
		// (get) Token: 0x0601575E RID: 87902 RVA: 0x0031D3C3 File Offset: 0x0031B5C3
		// (set) Token: 0x0601575F RID: 87903 RVA: 0x0031D3CB File Offset: 0x0031B5CB
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

		// Token: 0x1700478E RID: 18318
		// (get) Token: 0x06015760 RID: 87904 RVA: 0x0031D3D4 File Offset: 0x0031B5D4
		// (set) Token: 0x06015761 RID: 87905 RVA: 0x0031D3DC File Offset: 0x0031B5DC
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

		// Token: 0x1700478F RID: 18319
		// (get) Token: 0x06015762 RID: 87906 RVA: 0x0031D3E5 File Offset: 0x0031B5E5
		// (set) Token: 0x06015763 RID: 87907 RVA: 0x0031D3ED File Offset: 0x0031B5ED
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

		// Token: 0x17004790 RID: 18320
		// (get) Token: 0x06015764 RID: 87908 RVA: 0x0031D3F6 File Offset: 0x0031B5F6
		// (set) Token: 0x06015765 RID: 87909 RVA: 0x0031D3FE File Offset: 0x0031B5FE
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

		// Token: 0x17004791 RID: 18321
		// (get) Token: 0x06015766 RID: 87910 RVA: 0x0031D407 File Offset: 0x0031B607
		// (set) Token: 0x06015767 RID: 87911 RVA: 0x0031D40F File Offset: 0x0031B60F
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

		// Token: 0x17004792 RID: 18322
		// (get) Token: 0x06015768 RID: 87912 RVA: 0x0031D418 File Offset: 0x0031B618
		// (set) Token: 0x06015769 RID: 87913 RVA: 0x0031D420 File Offset: 0x0031B620
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

		// Token: 0x17004793 RID: 18323
		// (get) Token: 0x0601576A RID: 87914 RVA: 0x0031D429 File Offset: 0x0031B629
		// (set) Token: 0x0601576B RID: 87915 RVA: 0x0031D431 File Offset: 0x0031B631
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

		// Token: 0x17004794 RID: 18324
		// (get) Token: 0x0601576C RID: 87916 RVA: 0x0031D43A File Offset: 0x0031B63A
		// (set) Token: 0x0601576D RID: 87917 RVA: 0x0031D442 File Offset: 0x0031B642
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

		// Token: 0x17004795 RID: 18325
		// (get) Token: 0x0601576E RID: 87918 RVA: 0x0031D44B File Offset: 0x0031B64B
		// (set) Token: 0x0601576F RID: 87919 RVA: 0x0031D453 File Offset: 0x0031B653
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

		// Token: 0x06015770 RID: 87920 RVA: 0x0031D45C File Offset: 0x0031B65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeResultInfo);
		}

		// Token: 0x06015771 RID: 87921 RVA: 0x0031D46C File Offset: 0x0031B66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeResultInfo other)
		{
			return other != null && (other == this || (this.IsNewRecord == other.IsNewRecord && this.Time == other.Time && this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.KillEnemyCount == other.KillEnemyCount && this.GetGainCount == other.GetGainCount && this.Rewards.Equals(other.Rewards) && object.Equals(this.RoleEntry, other.RoleEntry) && object.Equals(this.PhantomEntry, other.PhantomEntry) && this.IsDeadTrigger == other.IsDeadTrigger && this.InstId == other.InstId && this.TotalCostTime == other.TotalCostTime && this.Rate == other.Rate && this.SelectHotEntryGroupId == other.SelectHotEntryGroupId && this.RogueArchiveState == other.RogueArchiveState && object.Equals(this.RogueArchiveInfo, other.RogueArchiveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015772 RID: 87922 RVA: 0x0031D5AC File Offset: 0x0031B7AC
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

		// Token: 0x06015773 RID: 87923 RVA: 0x0031D755 File Offset: 0x0031B955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015774 RID: 87924 RVA: 0x0031D762 File Offset: 0x0031B962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015775 RID: 87925 RVA: 0x0031D76C File Offset: 0x0031B96C
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

		// Token: 0x06015776 RID: 87926 RVA: 0x0031D94C File Offset: 0x0031BB4C
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

		// Token: 0x06015777 RID: 87927 RVA: 0x0031DAD8 File Offset: 0x0031BCD8
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

		// Token: 0x06015778 RID: 87928 RVA: 0x0031DC85 File Offset: 0x0031BE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015779 RID: 87929 RVA: 0x0031DC90 File Offset: 0x0031BE90
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

		// Token: 0x040080FF RID: 33023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008100 RID: 33024
		public const int IsNewRecordFieldNumber = 1;

		// Token: 0x04008101 RID: 33025
		private bool isNewRecord_;

		// Token: 0x04008102 RID: 33026
		public const int TimeFieldNumber = 2;

		// Token: 0x04008103 RID: 33027
		private uint time_;

		// Token: 0x04008104 RID: 33028
		public const int CurLayerFieldNumber = 3;

		// Token: 0x04008105 RID: 33029
		private int curLayer_;

		// Token: 0x04008106 RID: 33030
		public const int MaxLayerFieldNumber = 4;

		// Token: 0x04008107 RID: 33031
		private int maxLayer_;

		// Token: 0x04008108 RID: 33032
		public const int KillEnemyCountFieldNumber = 5;

		// Token: 0x04008109 RID: 33033
		private int killEnemyCount_;

		// Token: 0x0400810A RID: 33034
		public const int GetGainCountFieldNumber = 6;

		// Token: 0x0400810B RID: 33035
		private int getGainCount_;

		// Token: 0x0400810C RID: 33036
		public const int RewardsFieldNumber = 8;

		// Token: 0x0400810D RID: 33037
		private static readonly MapField<int, int>.Codec _map_rewards_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x0400810E RID: 33038
		private readonly MapField<int, int> rewards_ = new MapField<int, int>();

		// Token: 0x0400810F RID: 33039
		public const int RoleEntryFieldNumber = 9;

		// Token: 0x04008110 RID: 33040
		private RogueGainEntry roleEntry_;

		// Token: 0x04008111 RID: 33041
		public const int PhantomEntryFieldNumber = 10;

		// Token: 0x04008112 RID: 33042
		private RogueGainEntry phantomEntry_;

		// Token: 0x04008113 RID: 33043
		public const int IsDeadTriggerFieldNumber = 11;

		// Token: 0x04008114 RID: 33044
		private bool isDeadTrigger_;

		// Token: 0x04008115 RID: 33045
		public const int InstIdFieldNumber = 12;

		// Token: 0x04008116 RID: 33046
		private int instId_;

		// Token: 0x04008117 RID: 33047
		public const int TotalCostTimeFieldNumber = 13;

		// Token: 0x04008118 RID: 33048
		private int totalCostTime_;

		// Token: 0x04008119 RID: 33049
		public const int RateFieldNumber = 14;

		// Token: 0x0400811A RID: 33050
		private int rate_;

		// Token: 0x0400811B RID: 33051
		public const int SelectHotEntryGroupIdFieldNumber = 15;

		// Token: 0x0400811C RID: 33052
		private int selectHotEntryGroupId_;

		// Token: 0x0400811D RID: 33053
		public const int RogueArchiveStateFieldNumber = 16;

		// Token: 0x0400811E RID: 33054
		private RogueArchiveState rogueArchiveState_;

		// Token: 0x0400811F RID: 33055
		public const int RogueArchiveInfoFieldNumber = 17;

		// Token: 0x04008120 RID: 33056
		private RogueArchiveInfo rogueArchiveInfo_;
	}
}
