using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EF RID: 4335
	public sealed class RoverRogueActivityData : IMessage<RoverRogueActivityData>, IMessage, IEquatable<RoverRogueActivityData>, IDeepCloneable<RoverRogueActivityData>, IBufferMessage
	{
		// Token: 0x060171D7 RID: 94679 RVA: 0x0035A7B1 File Offset: 0x003589B1
		[NullableContext(1)]
		public static RoverRogueActivityData Create()
		{
			return new RoverRogueActivityData();
		}

		// Token: 0x17004D68 RID: 19816
		// (get) Token: 0x060171D8 RID: 94680 RVA: 0x0035A7B8 File Offset: 0x003589B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D69 RID: 19817
		// (get) Token: 0x060171D9 RID: 94681 RVA: 0x0035A7BB File Offset: 0x003589BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueActivityData.Descriptor;
			}
		}

		// Token: 0x060171DA RID: 94682 RVA: 0x0035A7C4 File Offset: 0x003589C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueActivityData()
		{
		}

		// Token: 0x060171DB RID: 94683 RVA: 0x0035A848 File Offset: 0x00358A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueActivityData(RoverRogueActivityData other) : this()
		{
			this.activityId_ = other.activityId_;
			this.historyInsInfo_ = ((other.historyInsInfo_ != null) ? other.historyInsInfo_.Clone() : null);
			this.unlockRoleIdList_ = other.unlockRoleIdList_.Clone();
			this.unlockBlessRoleIdList_ = other.unlockBlessRoleIdList_.Clone();
			this.unlockBlessIdList_ = other.unlockBlessIdList_.Clone();
			this.unlockTalentIdList_ = other.unlockTalentIdList_.Clone();
			this.unlockItemIdList_ = other.unlockItemIdList_.Clone();
			this.unlockLootIdList_ = other.unlockLootIdList_.Clone();
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.activeTalentIdList_ = other.activeTalentIdList_.Clone();
			this.tokenItem_ = other.tokenItem_;
			this.talentItem_ = other.talentItem_;
			this.unlockRoleType_ = other.unlockRoleType_.Clone();
			this.equippedLoot_ = other.equippedLoot_;
			this.insInfoList_ = other.insInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171DC RID: 94684 RVA: 0x0035A962 File Offset: 0x00358B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueActivityData Clone()
		{
			return new RoverRogueActivityData(this);
		}

		// Token: 0x17004D6A RID: 19818
		// (get) Token: 0x060171DD RID: 94685 RVA: 0x0035A96A File Offset: 0x00358B6A
		// (set) Token: 0x060171DE RID: 94686 RVA: 0x0035A972 File Offset: 0x00358B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004D6B RID: 19819
		// (get) Token: 0x060171DF RID: 94687 RVA: 0x0035A97B File Offset: 0x00358B7B
		// (set) Token: 0x060171E0 RID: 94688 RVA: 0x0035A983 File Offset: 0x00358B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueHistoryInsInfo HistoryInsInfo
		{
			get
			{
				return this.historyInsInfo_;
			}
			set
			{
				this.historyInsInfo_ = value;
			}
		}

		// Token: 0x17004D6C RID: 19820
		// (get) Token: 0x060171E1 RID: 94689 RVA: 0x0035A98C File Offset: 0x00358B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleIdList
		{
			get
			{
				return this.unlockRoleIdList_;
			}
		}

		// Token: 0x17004D6D RID: 19821
		// (get) Token: 0x060171E2 RID: 94690 RVA: 0x0035A994 File Offset: 0x00358B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBlessRoleIdList
		{
			get
			{
				return this.unlockBlessRoleIdList_;
			}
		}

		// Token: 0x17004D6E RID: 19822
		// (get) Token: 0x060171E3 RID: 94691 RVA: 0x0035A99C File Offset: 0x00358B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBlessIdList
		{
			get
			{
				return this.unlockBlessIdList_;
			}
		}

		// Token: 0x17004D6F RID: 19823
		// (get) Token: 0x060171E4 RID: 94692 RVA: 0x0035A9A4 File Offset: 0x00358BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTalentIdList
		{
			get
			{
				return this.unlockTalentIdList_;
			}
		}

		// Token: 0x17004D70 RID: 19824
		// (get) Token: 0x060171E5 RID: 94693 RVA: 0x0035A9AC File Offset: 0x00358BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemIdList
		{
			get
			{
				return this.unlockItemIdList_;
			}
		}

		// Token: 0x17004D71 RID: 19825
		// (get) Token: 0x060171E6 RID: 94694 RVA: 0x0035A9B4 File Offset: 0x00358BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockLootIdList
		{
			get
			{
				return this.unlockLootIdList_;
			}
		}

		// Token: 0x17004D72 RID: 19826
		// (get) Token: 0x060171E7 RID: 94695 RVA: 0x0035A9BC File Offset: 0x00358BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17004D73 RID: 19827
		// (get) Token: 0x060171E8 RID: 94696 RVA: 0x0035A9C4 File Offset: 0x00358BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveTalentIdList
		{
			get
			{
				return this.activeTalentIdList_;
			}
		}

		// Token: 0x17004D74 RID: 19828
		// (get) Token: 0x060171E9 RID: 94697 RVA: 0x0035A9CC File Offset: 0x00358BCC
		// (set) Token: 0x060171EA RID: 94698 RVA: 0x0035A9D4 File Offset: 0x00358BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TokenItem
		{
			get
			{
				return this.tokenItem_;
			}
			set
			{
				this.tokenItem_ = value;
			}
		}

		// Token: 0x17004D75 RID: 19829
		// (get) Token: 0x060171EB RID: 94699 RVA: 0x0035A9DD File Offset: 0x00358BDD
		// (set) Token: 0x060171EC RID: 94700 RVA: 0x0035A9E5 File Offset: 0x00358BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentItem
		{
			get
			{
				return this.talentItem_;
			}
			set
			{
				this.talentItem_ = value;
			}
		}

		// Token: 0x17004D76 RID: 19830
		// (get) Token: 0x060171ED RID: 94701 RVA: 0x0035A9EE File Offset: 0x00358BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleType
		{
			get
			{
				return this.unlockRoleType_;
			}
		}

		// Token: 0x17004D77 RID: 19831
		// (get) Token: 0x060171EE RID: 94702 RVA: 0x0035A9F6 File Offset: 0x00358BF6
		// (set) Token: 0x060171EF RID: 94703 RVA: 0x0035A9FE File Offset: 0x00358BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EquippedLoot
		{
			get
			{
				return this.equippedLoot_;
			}
			set
			{
				this.equippedLoot_ = value;
			}
		}

		// Token: 0x17004D78 RID: 19832
		// (get) Token: 0x060171F0 RID: 94704 RVA: 0x0035AA07 File Offset: 0x00358C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueInsEntry> InsInfoList
		{
			get
			{
				return this.insInfoList_;
			}
		}

		// Token: 0x060171F1 RID: 94705 RVA: 0x0035AA0F File Offset: 0x00358C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueActivityData);
		}

		// Token: 0x060171F2 RID: 94706 RVA: 0x0035AA20 File Offset: 0x00358C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueActivityData other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.HistoryInsInfo, other.HistoryInsInfo) && this.unlockRoleIdList_.Equals(other.unlockRoleIdList_) && this.unlockBlessRoleIdList_.Equals(other.unlockBlessRoleIdList_) && this.unlockBlessIdList_.Equals(other.unlockBlessIdList_) && this.unlockTalentIdList_.Equals(other.unlockTalentIdList_) && this.unlockItemIdList_.Equals(other.unlockItemIdList_) && this.unlockLootIdList_.Equals(other.unlockLootIdList_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.activeTalentIdList_.Equals(other.activeTalentIdList_) && this.TokenItem == other.TokenItem && this.TalentItem == other.TalentItem && this.unlockRoleType_.Equals(other.unlockRoleType_) && this.EquippedLoot == other.EquippedLoot && this.insInfoList_.Equals(other.insInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060171F3 RID: 94707 RVA: 0x0035AB70 File Offset: 0x00358D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.historyInsInfo_ != null)
			{
				num ^= this.HistoryInsInfo.GetHashCode();
			}
			num ^= this.unlockRoleIdList_.GetHashCode();
			num ^= this.unlockBlessRoleIdList_.GetHashCode();
			num ^= this.unlockBlessIdList_.GetHashCode();
			num ^= this.unlockTalentIdList_.GetHashCode();
			num ^= this.unlockItemIdList_.GetHashCode();
			num ^= this.unlockLootIdList_.GetHashCode();
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.activeTalentIdList_.GetHashCode();
			if (this.TokenItem != 0)
			{
				num ^= this.TokenItem.GetHashCode();
			}
			if (this.TalentItem != 0)
			{
				num ^= this.TalentItem.GetHashCode();
			}
			num ^= this.unlockRoleType_.GetHashCode();
			if (this.EquippedLoot != 0)
			{
				num ^= this.EquippedLoot.GetHashCode();
			}
			num ^= this.insInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060171F4 RID: 94708 RVA: 0x0035AC9C File Offset: 0x00358E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060171F5 RID: 94709 RVA: 0x0035ACA9 File Offset: 0x00358EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060171F6 RID: 94710 RVA: 0x0035ACB4 File Offset: 0x00358EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.historyInsInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HistoryInsInfo);
			}
			this.unlockRoleIdList_.WriteTo(ref output, RoverRogueActivityData._repeated_unlockRoleIdList_codec);
			this.unlockBlessRoleIdList_.WriteTo(ref output, RoverRogueActivityData._repeated_unlockBlessRoleIdList_codec);
			this.unlockBlessIdList_.WriteTo(ref output, RoverRogueActivityData._repeated_unlockBlessIdList_codec);
			this.unlockTalentIdList_.WriteTo(ref output, RoverRogueActivityData._repeated_unlockTalentIdList_codec);
			this.unlockItemIdList_.WriteTo(ref output, RoverRogueActivityData._repeated_unlockItemIdList_codec);
			this.unlockLootIdList_.WriteTo(ref output, RoverRogueActivityData._repeated_unlockLootIdList_codec);
			this.conditionTasks_.WriteTo(ref output, RoverRogueActivityData._repeated_conditionTasks_codec);
			this.activeTalentIdList_.WriteTo(ref output, RoverRogueActivityData._repeated_activeTalentIdList_codec);
			if (this.TokenItem != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TokenItem);
			}
			if (this.TalentItem != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TalentItem);
			}
			this.unlockRoleType_.WriteTo(ref output, RoverRogueActivityData._repeated_unlockRoleType_codec);
			if (this.EquippedLoot != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.EquippedLoot);
			}
			this.insInfoList_.WriteTo(ref output, RoverRogueActivityData._repeated_insInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060171F7 RID: 94711 RVA: 0x0035AE0C File Offset: 0x0035900C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.historyInsInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HistoryInsInfo);
			}
			num += this.unlockRoleIdList_.CalculateSize(RoverRogueActivityData._repeated_unlockRoleIdList_codec);
			num += this.unlockBlessRoleIdList_.CalculateSize(RoverRogueActivityData._repeated_unlockBlessRoleIdList_codec);
			num += this.unlockBlessIdList_.CalculateSize(RoverRogueActivityData._repeated_unlockBlessIdList_codec);
			num += this.unlockTalentIdList_.CalculateSize(RoverRogueActivityData._repeated_unlockTalentIdList_codec);
			num += this.unlockItemIdList_.CalculateSize(RoverRogueActivityData._repeated_unlockItemIdList_codec);
			num += this.unlockLootIdList_.CalculateSize(RoverRogueActivityData._repeated_unlockLootIdList_codec);
			num += this.conditionTasks_.CalculateSize(RoverRogueActivityData._repeated_conditionTasks_codec);
			num += this.activeTalentIdList_.CalculateSize(RoverRogueActivityData._repeated_activeTalentIdList_codec);
			if (this.TokenItem != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TokenItem);
			}
			if (this.TalentItem != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentItem);
			}
			num += this.unlockRoleType_.CalculateSize(RoverRogueActivityData._repeated_unlockRoleType_codec);
			if (this.EquippedLoot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EquippedLoot);
			}
			num += this.insInfoList_.CalculateSize(RoverRogueActivityData._repeated_insInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060171F8 RID: 94712 RVA: 0x0035AF68 File Offset: 0x00359168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.historyInsInfo_ != null)
			{
				if (this.historyInsInfo_ == null)
				{
					this.HistoryInsInfo = new RoverRogueHistoryInsInfo();
				}
				this.HistoryInsInfo.MergeFrom(other.HistoryInsInfo);
			}
			this.unlockRoleIdList_.Add(other.unlockRoleIdList_);
			this.unlockBlessRoleIdList_.Add(other.unlockBlessRoleIdList_);
			this.unlockBlessIdList_.Add(other.unlockBlessIdList_);
			this.unlockTalentIdList_.Add(other.unlockTalentIdList_);
			this.unlockItemIdList_.Add(other.unlockItemIdList_);
			this.unlockLootIdList_.Add(other.unlockLootIdList_);
			this.conditionTasks_.Add(other.conditionTasks_);
			this.activeTalentIdList_.Add(other.activeTalentIdList_);
			if (other.TokenItem != 0)
			{
				this.TokenItem = other.TokenItem;
			}
			if (other.TalentItem != 0)
			{
				this.TalentItem = other.TalentItem;
			}
			this.unlockRoleType_.Add(other.unlockRoleType_);
			if (other.EquippedLoot != 0)
			{
				this.EquippedLoot = other.EquippedLoot;
			}
			this.insInfoList_.Add(other.insInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060171F9 RID: 94713 RVA: 0x0035B0B6 File Offset: 0x003592B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060171FA RID: 94714 RVA: 0x0035B0C0 File Offset: 0x003592C0
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
				if (num <= 56U)
				{
					if (num <= 32U)
					{
						if (num <= 18U)
						{
							if (num == 8U)
							{
								this.ActivityId = input.ReadInt32();
								continue;
							}
							if (num != 18U)
							{
								goto IL_FD;
							}
							if (this.historyInsInfo_ == null)
							{
								this.HistoryInsInfo = new RoverRogueHistoryInsInfo();
							}
							input.ReadMessage(this.HistoryInsInfo);
							continue;
						}
						else
						{
							if (num == 24U || num == 26U)
							{
								this.unlockRoleIdList_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_unlockRoleIdList_codec);
								continue;
							}
							if (num != 32U)
							{
								goto IL_FD;
							}
						}
					}
					else if (num <= 42U)
					{
						if (num != 34U)
						{
							if (num != 40U && num != 42U)
							{
								goto IL_FD;
							}
							this.unlockBlessIdList_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_unlockBlessIdList_codec);
							continue;
						}
					}
					else
					{
						if (num == 48U || num == 50U)
						{
							this.unlockTalentIdList_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_unlockTalentIdList_codec);
							continue;
						}
						if (num != 56U)
						{
							goto IL_FD;
						}
						goto IL_1A1;
					}
					this.unlockBlessRoleIdList_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_unlockBlessRoleIdList_codec);
					continue;
				}
				if (num > 82U)
				{
					if (num <= 104U)
					{
						if (num == 88U)
						{
							this.TokenItem = input.ReadInt32();
							continue;
						}
						if (num == 96U)
						{
							this.TalentItem = input.ReadInt32();
							continue;
						}
						if (num != 104U)
						{
							goto IL_FD;
						}
					}
					else if (num != 106U)
					{
						if (num == 112U)
						{
							this.EquippedLoot = input.ReadInt32();
							continue;
						}
						if (num != 122U)
						{
							goto IL_FD;
						}
						this.insInfoList_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_insInfoList_codec);
						continue;
					}
					this.unlockRoleType_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_unlockRoleType_codec);
					continue;
				}
				if (num <= 66U)
				{
					if (num == 58U)
					{
						goto IL_1A1;
					}
					if (num == 64U || num == 66U)
					{
						this.unlockLootIdList_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_unlockLootIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.conditionTasks_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_conditionTasks_codec);
						continue;
					}
					if (num == 80U || num == 82U)
					{
						this.activeTalentIdList_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_activeTalentIdList_codec);
						continue;
					}
				}
				IL_FD:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_1A1:
				this.unlockItemIdList_.AddEntriesFrom(ref input, RoverRogueActivityData._repeated_unlockItemIdList_codec);
			}
		}

		// Token: 0x0400896B RID: 35179
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400896C RID: 35180
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400896D RID: 35181
		private int activityId_;

		// Token: 0x0400896E RID: 35182
		public const int HistoryInsInfoFieldNumber = 2;

		// Token: 0x0400896F RID: 35183
		private RoverRogueHistoryInsInfo historyInsInfo_;

		// Token: 0x04008970 RID: 35184
		public const int UnlockRoleIdListFieldNumber = 3;

		// Token: 0x04008971 RID: 35185
		private static readonly FieldCodec<int> _repeated_unlockRoleIdList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008972 RID: 35186
		private readonly RepeatedField<int> unlockRoleIdList_ = new RepeatedField<int>();

		// Token: 0x04008973 RID: 35187
		public const int UnlockBlessRoleIdListFieldNumber = 4;

		// Token: 0x04008974 RID: 35188
		private static readonly FieldCodec<int> _repeated_unlockBlessRoleIdList_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008975 RID: 35189
		private readonly RepeatedField<int> unlockBlessRoleIdList_ = new RepeatedField<int>();

		// Token: 0x04008976 RID: 35190
		public const int UnlockBlessIdListFieldNumber = 5;

		// Token: 0x04008977 RID: 35191
		private static readonly FieldCodec<int> _repeated_unlockBlessIdList_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008978 RID: 35192
		private readonly RepeatedField<int> unlockBlessIdList_ = new RepeatedField<int>();

		// Token: 0x04008979 RID: 35193
		public const int UnlockTalentIdListFieldNumber = 6;

		// Token: 0x0400897A RID: 35194
		private static readonly FieldCodec<int> _repeated_unlockTalentIdList_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400897B RID: 35195
		private readonly RepeatedField<int> unlockTalentIdList_ = new RepeatedField<int>();

		// Token: 0x0400897C RID: 35196
		public const int UnlockItemIdListFieldNumber = 7;

		// Token: 0x0400897D RID: 35197
		private static readonly FieldCodec<int> _repeated_unlockItemIdList_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400897E RID: 35198
		private readonly RepeatedField<int> unlockItemIdList_ = new RepeatedField<int>();

		// Token: 0x0400897F RID: 35199
		public const int UnlockLootIdListFieldNumber = 8;

		// Token: 0x04008980 RID: 35200
		private static readonly FieldCodec<int> _repeated_unlockLootIdList_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04008981 RID: 35201
		private readonly RepeatedField<int> unlockLootIdList_ = new RepeatedField<int>();

		// Token: 0x04008982 RID: 35202
		public const int ConditionTasksFieldNumber = 9;

		// Token: 0x04008983 RID: 35203
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(74U, ConditionTask.Parser);

		// Token: 0x04008984 RID: 35204
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04008985 RID: 35205
		public const int ActiveTalentIdListFieldNumber = 10;

		// Token: 0x04008986 RID: 35206
		private static readonly FieldCodec<int> _repeated_activeTalentIdList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04008987 RID: 35207
		private readonly RepeatedField<int> activeTalentIdList_ = new RepeatedField<int>();

		// Token: 0x04008988 RID: 35208
		public const int TokenItemFieldNumber = 11;

		// Token: 0x04008989 RID: 35209
		private int tokenItem_;

		// Token: 0x0400898A RID: 35210
		public const int TalentItemFieldNumber = 12;

		// Token: 0x0400898B RID: 35211
		private int talentItem_;

		// Token: 0x0400898C RID: 35212
		public const int UnlockRoleTypeFieldNumber = 13;

		// Token: 0x0400898D RID: 35213
		private static readonly FieldCodec<int> _repeated_unlockRoleType_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400898E RID: 35214
		private readonly RepeatedField<int> unlockRoleType_ = new RepeatedField<int>();

		// Token: 0x0400898F RID: 35215
		public const int EquippedLootFieldNumber = 14;

		// Token: 0x04008990 RID: 35216
		private int equippedLoot_;

		// Token: 0x04008991 RID: 35217
		public const int InsInfoListFieldNumber = 15;

		// Token: 0x04008992 RID: 35218
		private static readonly FieldCodec<RoverRogueInsEntry> _repeated_insInfoList_codec = FieldCodec.ForMessage<RoverRogueInsEntry>(122U, RoverRogueInsEntry.Parser);

		// Token: 0x04008993 RID: 35219
		private readonly RepeatedField<RoverRogueInsEntry> insInfoList_ = new RepeatedField<RoverRogueInsEntry>();
	}
}
