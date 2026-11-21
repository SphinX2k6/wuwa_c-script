using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001129 RID: 4393
	public sealed class RoverRogueActivityData : IMessage<RoverRogueActivityData>, IMessage, IEquatable<RoverRogueActivityData>, IDeepCloneable<RoverRogueActivityData>, IBufferMessage
	{
		// Token: 0x06017778 RID: 96120 RVA: 0x00369B09 File Offset: 0x00367D09
		[NullableContext(1)]
		public static RoverRogueActivityData Create()
		{
			return new RoverRogueActivityData();
		}

		// Token: 0x17004ED4 RID: 20180
		// (get) Token: 0x06017779 RID: 96121 RVA: 0x00369B10 File Offset: 0x00367D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ED5 RID: 20181
		// (get) Token: 0x0601777A RID: 96122 RVA: 0x00369B13 File Offset: 0x00367D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueActivityData.Descriptor;
			}
		}

		// Token: 0x0601777B RID: 96123 RVA: 0x00369B1C File Offset: 0x00367D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueActivityData()
		{
		}

		// Token: 0x0601777C RID: 96124 RVA: 0x00369BA0 File Offset: 0x00367DA0
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

		// Token: 0x0601777D RID: 96125 RVA: 0x00369CBA File Offset: 0x00367EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueActivityData Clone()
		{
			return new RoverRogueActivityData(this);
		}

		// Token: 0x17004ED6 RID: 20182
		// (get) Token: 0x0601777E RID: 96126 RVA: 0x00369CC2 File Offset: 0x00367EC2
		// (set) Token: 0x0601777F RID: 96127 RVA: 0x00369CCA File Offset: 0x00367ECA
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

		// Token: 0x17004ED7 RID: 20183
		// (get) Token: 0x06017780 RID: 96128 RVA: 0x00369CD3 File Offset: 0x00367ED3
		// (set) Token: 0x06017781 RID: 96129 RVA: 0x00369CDB File Offset: 0x00367EDB
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

		// Token: 0x17004ED8 RID: 20184
		// (get) Token: 0x06017782 RID: 96130 RVA: 0x00369CE4 File Offset: 0x00367EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleIdList
		{
			get
			{
				return this.unlockRoleIdList_;
			}
		}

		// Token: 0x17004ED9 RID: 20185
		// (get) Token: 0x06017783 RID: 96131 RVA: 0x00369CEC File Offset: 0x00367EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBlessRoleIdList
		{
			get
			{
				return this.unlockBlessRoleIdList_;
			}
		}

		// Token: 0x17004EDA RID: 20186
		// (get) Token: 0x06017784 RID: 96132 RVA: 0x00369CF4 File Offset: 0x00367EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBlessIdList
		{
			get
			{
				return this.unlockBlessIdList_;
			}
		}

		// Token: 0x17004EDB RID: 20187
		// (get) Token: 0x06017785 RID: 96133 RVA: 0x00369CFC File Offset: 0x00367EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTalentIdList
		{
			get
			{
				return this.unlockTalentIdList_;
			}
		}

		// Token: 0x17004EDC RID: 20188
		// (get) Token: 0x06017786 RID: 96134 RVA: 0x00369D04 File Offset: 0x00367F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemIdList
		{
			get
			{
				return this.unlockItemIdList_;
			}
		}

		// Token: 0x17004EDD RID: 20189
		// (get) Token: 0x06017787 RID: 96135 RVA: 0x00369D0C File Offset: 0x00367F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockLootIdList
		{
			get
			{
				return this.unlockLootIdList_;
			}
		}

		// Token: 0x17004EDE RID: 20190
		// (get) Token: 0x06017788 RID: 96136 RVA: 0x00369D14 File Offset: 0x00367F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17004EDF RID: 20191
		// (get) Token: 0x06017789 RID: 96137 RVA: 0x00369D1C File Offset: 0x00367F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveTalentIdList
		{
			get
			{
				return this.activeTalentIdList_;
			}
		}

		// Token: 0x17004EE0 RID: 20192
		// (get) Token: 0x0601778A RID: 96138 RVA: 0x00369D24 File Offset: 0x00367F24
		// (set) Token: 0x0601778B RID: 96139 RVA: 0x00369D2C File Offset: 0x00367F2C
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

		// Token: 0x17004EE1 RID: 20193
		// (get) Token: 0x0601778C RID: 96140 RVA: 0x00369D35 File Offset: 0x00367F35
		// (set) Token: 0x0601778D RID: 96141 RVA: 0x00369D3D File Offset: 0x00367F3D
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

		// Token: 0x17004EE2 RID: 20194
		// (get) Token: 0x0601778E RID: 96142 RVA: 0x00369D46 File Offset: 0x00367F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleType
		{
			get
			{
				return this.unlockRoleType_;
			}
		}

		// Token: 0x17004EE3 RID: 20195
		// (get) Token: 0x0601778F RID: 96143 RVA: 0x00369D4E File Offset: 0x00367F4E
		// (set) Token: 0x06017790 RID: 96144 RVA: 0x00369D56 File Offset: 0x00367F56
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

		// Token: 0x17004EE4 RID: 20196
		// (get) Token: 0x06017791 RID: 96145 RVA: 0x00369D5F File Offset: 0x00367F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueInsEntry> InsInfoList
		{
			get
			{
				return this.insInfoList_;
			}
		}

		// Token: 0x06017792 RID: 96146 RVA: 0x00369D67 File Offset: 0x00367F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueActivityData);
		}

		// Token: 0x06017793 RID: 96147 RVA: 0x00369D78 File Offset: 0x00367F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueActivityData other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.HistoryInsInfo, other.HistoryInsInfo) && this.unlockRoleIdList_.Equals(other.unlockRoleIdList_) && this.unlockBlessRoleIdList_.Equals(other.unlockBlessRoleIdList_) && this.unlockBlessIdList_.Equals(other.unlockBlessIdList_) && this.unlockTalentIdList_.Equals(other.unlockTalentIdList_) && this.unlockItemIdList_.Equals(other.unlockItemIdList_) && this.unlockLootIdList_.Equals(other.unlockLootIdList_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.activeTalentIdList_.Equals(other.activeTalentIdList_) && this.TokenItem == other.TokenItem && this.TalentItem == other.TalentItem && this.unlockRoleType_.Equals(other.unlockRoleType_) && this.EquippedLoot == other.EquippedLoot && this.insInfoList_.Equals(other.insInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017794 RID: 96148 RVA: 0x00369EC8 File Offset: 0x003680C8
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

		// Token: 0x06017795 RID: 96149 RVA: 0x00369FF4 File Offset: 0x003681F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017796 RID: 96150 RVA: 0x0036A001 File Offset: 0x00368201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017797 RID: 96151 RVA: 0x0036A00C File Offset: 0x0036820C
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

		// Token: 0x06017798 RID: 96152 RVA: 0x0036A164 File Offset: 0x00368364
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

		// Token: 0x06017799 RID: 96153 RVA: 0x0036A2C0 File Offset: 0x003684C0
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

		// Token: 0x0601779A RID: 96154 RVA: 0x0036A40E File Offset: 0x0036860E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601779B RID: 96155 RVA: 0x0036A418 File Offset: 0x00368618
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

		// Token: 0x04008BFE RID: 35838
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BFF RID: 35839
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04008C00 RID: 35840
		private int activityId_;

		// Token: 0x04008C01 RID: 35841
		public const int HistoryInsInfoFieldNumber = 2;

		// Token: 0x04008C02 RID: 35842
		private RoverRogueHistoryInsInfo historyInsInfo_;

		// Token: 0x04008C03 RID: 35843
		public const int UnlockRoleIdListFieldNumber = 3;

		// Token: 0x04008C04 RID: 35844
		private static readonly FieldCodec<int> _repeated_unlockRoleIdList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008C05 RID: 35845
		private readonly RepeatedField<int> unlockRoleIdList_ = new RepeatedField<int>();

		// Token: 0x04008C06 RID: 35846
		public const int UnlockBlessRoleIdListFieldNumber = 4;

		// Token: 0x04008C07 RID: 35847
		private static readonly FieldCodec<int> _repeated_unlockBlessRoleIdList_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008C08 RID: 35848
		private readonly RepeatedField<int> unlockBlessRoleIdList_ = new RepeatedField<int>();

		// Token: 0x04008C09 RID: 35849
		public const int UnlockBlessIdListFieldNumber = 5;

		// Token: 0x04008C0A RID: 35850
		private static readonly FieldCodec<int> _repeated_unlockBlessIdList_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008C0B RID: 35851
		private readonly RepeatedField<int> unlockBlessIdList_ = new RepeatedField<int>();

		// Token: 0x04008C0C RID: 35852
		public const int UnlockTalentIdListFieldNumber = 6;

		// Token: 0x04008C0D RID: 35853
		private static readonly FieldCodec<int> _repeated_unlockTalentIdList_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04008C0E RID: 35854
		private readonly RepeatedField<int> unlockTalentIdList_ = new RepeatedField<int>();

		// Token: 0x04008C0F RID: 35855
		public const int UnlockItemIdListFieldNumber = 7;

		// Token: 0x04008C10 RID: 35856
		private static readonly FieldCodec<int> _repeated_unlockItemIdList_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04008C11 RID: 35857
		private readonly RepeatedField<int> unlockItemIdList_ = new RepeatedField<int>();

		// Token: 0x04008C12 RID: 35858
		public const int UnlockLootIdListFieldNumber = 8;

		// Token: 0x04008C13 RID: 35859
		private static readonly FieldCodec<int> _repeated_unlockLootIdList_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04008C14 RID: 35860
		private readonly RepeatedField<int> unlockLootIdList_ = new RepeatedField<int>();

		// Token: 0x04008C15 RID: 35861
		public const int ConditionTasksFieldNumber = 9;

		// Token: 0x04008C16 RID: 35862
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(74U, ConditionTask.Parser);

		// Token: 0x04008C17 RID: 35863
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04008C18 RID: 35864
		public const int ActiveTalentIdListFieldNumber = 10;

		// Token: 0x04008C19 RID: 35865
		private static readonly FieldCodec<int> _repeated_activeTalentIdList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04008C1A RID: 35866
		private readonly RepeatedField<int> activeTalentIdList_ = new RepeatedField<int>();

		// Token: 0x04008C1B RID: 35867
		public const int TokenItemFieldNumber = 11;

		// Token: 0x04008C1C RID: 35868
		private int tokenItem_;

		// Token: 0x04008C1D RID: 35869
		public const int TalentItemFieldNumber = 12;

		// Token: 0x04008C1E RID: 35870
		private int talentItem_;

		// Token: 0x04008C1F RID: 35871
		public const int UnlockRoleTypeFieldNumber = 13;

		// Token: 0x04008C20 RID: 35872
		private static readonly FieldCodec<int> _repeated_unlockRoleType_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04008C21 RID: 35873
		private readonly RepeatedField<int> unlockRoleType_ = new RepeatedField<int>();

		// Token: 0x04008C22 RID: 35874
		public const int EquippedLootFieldNumber = 14;

		// Token: 0x04008C23 RID: 35875
		private int equippedLoot_;

		// Token: 0x04008C24 RID: 35876
		public const int InsInfoListFieldNumber = 15;

		// Token: 0x04008C25 RID: 35877
		private static readonly FieldCodec<RoverRogueInsEntry> _repeated_insInfoList_codec = FieldCodec.ForMessage<RoverRogueInsEntry>(122U, RoverRogueInsEntry.Parser);

		// Token: 0x04008C26 RID: 35878
		private readonly RepeatedField<RoverRogueInsEntry> insInfoList_ = new RepeatedField<RoverRogueInsEntry>();
	}
}
