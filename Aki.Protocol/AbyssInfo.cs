using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000025 RID: 37
	public sealed class AbyssInfo : IMessage<AbyssInfo>, IMessage, IEquatable<AbyssInfo>, IDeepCloneable<AbyssInfo>, IBufferMessage
	{
		// Token: 0x0600119D RID: 4509 RVA: 0x00030E5F File Offset: 0x0002F05F
		[NullableContext(1)]
		public static AbyssInfo Create()
		{
			return new AbyssInfo();
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x00030E66 File Offset: 0x0002F066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00030E69 File Offset: 0x0002F069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssInfo.Descriptor;
			}
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00030E70 File Offset: 0x0002F070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInfo()
		{
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00030EB0 File Offset: 0x0002F0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInfo(AbyssInfo other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this.pluginItems_ = other.pluginItems_.Clone();
			this.rewardInfo_ = other.rewardInfo_.Clone();
			this.unlockChallengeIds_ = other.unlockChallengeIds_.Clone();
			this.likeCount_ = other.likeCount_;
			this.challengeInfos_ = other.challengeInfos_.Clone();
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00030F4D File Offset: 0x0002F14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInfo Clone()
		{
			return new AbyssInfo(this);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00030F55 File Offset: 0x0002F155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRoleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00030F5D File Offset: 0x0002F15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssPluginItemInfo> PluginItems
		{
			get
			{
				return this.pluginItems_;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00030F65 File Offset: 0x0002F165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRewardInfo> RewardInfo
		{
			get
			{
				return this.rewardInfo_;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00030F6D File Offset: 0x0002F16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockChallengeIds
		{
			get
			{
				return this.unlockChallengeIds_;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00030F75 File Offset: 0x0002F175
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00030F7D File Offset: 0x0002F17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LikeCount
		{
			get
			{
				return this.likeCount_;
			}
			set
			{
				this.likeCount_ = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00030F86 File Offset: 0x0002F186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallenge> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00030F8E File Offset: 0x0002F18E
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x00030F96 File Offset: 0x0002F196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00030F9F File Offset: 0x0002F19F
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x00030FA7 File Offset: 0x0002F1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00030FB0 File Offset: 0x0002F1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssInfo);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00030FC0 File Offset: 0x0002F1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssInfo other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && this.pluginItems_.Equals(other.pluginItems_) && this.rewardInfo_.Equals(other.rewardInfo_) && this.unlockChallengeIds_.Equals(other.unlockChallengeIds_) && this.LikeCount == other.LikeCount && this.challengeInfos_.Equals(other.challengeInfos_) && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00031084 File Offset: 0x0002F284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleList_.GetHashCode();
			num ^= this.pluginItems_.GetHashCode();
			num ^= this.rewardInfo_.GetHashCode();
			num ^= this.unlockChallengeIds_.GetHashCode();
			if (this.LikeCount != 0)
			{
				num ^= this.LikeCount.GetHashCode();
			}
			num ^= this.challengeInfos_.GetHashCode();
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0003113B File Offset: 0x0002F33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00031148 File Offset: 0x0002F348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00031154 File Offset: 0x0002F354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, AbyssInfo._repeated_roleList_codec);
			this.pluginItems_.WriteTo(ref output, AbyssInfo._repeated_pluginItems_codec);
			this.rewardInfo_.WriteTo(ref output, AbyssInfo._repeated_rewardInfo_codec);
			this.unlockChallengeIds_.WriteTo(ref output, AbyssInfo._repeated_unlockChallengeIds_codec);
			if (this.LikeCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LikeCount);
			}
			this.challengeInfos_.WriteTo(ref output, AbyssInfo._repeated_challengeInfos_codec);
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00031220 File Offset: 0x0002F420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(AbyssInfo._repeated_roleList_codec);
			num += this.pluginItems_.CalculateSize(AbyssInfo._repeated_pluginItems_codec);
			num += this.rewardInfo_.CalculateSize(AbyssInfo._repeated_rewardInfo_codec);
			num += this.unlockChallengeIds_.CalculateSize(AbyssInfo._repeated_unlockChallengeIds_codec);
			if (this.LikeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LikeCount);
			}
			num += this.challengeInfos_.CalculateSize(AbyssInfo._repeated_challengeInfos_codec);
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x000312F0 File Offset: 0x0002F4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			this.pluginItems_.Add(other.pluginItems_);
			this.rewardInfo_.Add(other.rewardInfo_);
			this.unlockChallengeIds_.Add(other.unlockChallengeIds_);
			if (other.LikeCount != 0)
			{
				this.LikeCount = other.LikeCount;
			}
			this.challengeInfos_.Add(other.challengeInfos_);
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x000313A9 File Offset: 0x0002F5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x000313B4 File Offset: 0x0002F5B4
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
				if (num <= 32U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							this.roleList_.AddEntriesFrom(ref input, AbyssInfo._repeated_roleList_codec);
							continue;
						}
						if (num == 18U)
						{
							this.pluginItems_.AddEntriesFrom(ref input, AbyssInfo._repeated_pluginItems_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.rewardInfo_.AddEntriesFrom(ref input, AbyssInfo._repeated_rewardInfo_codec);
							continue;
						}
						if (num == 32U)
						{
							goto IL_A7;
						}
					}
				}
				else if (num <= 40U)
				{
					if (num == 34U)
					{
						goto IL_A7;
					}
					if (num == 40U)
					{
						this.LikeCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.challengeInfos_.AddEntriesFrom(ref input, AbyssInfo._repeated_challengeInfos_codec);
						continue;
					}
					if (num == 56U)
					{
						this.LimitBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.LimitEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_A7:
				this.unlockChallengeIds_.AddEntriesFrom(ref input, AbyssInfo._repeated_unlockChallengeIds_codec);
			}
		}

		// Token: 0x04001FCE RID: 8142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FCF RID: 8143
		public const int RoleListFieldNumber = 1;

		// Token: 0x04001FD0 RID: 8144
		private static readonly FieldCodec<AbyssRoleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<AbyssRoleInfo>(10U, AbyssRoleInfo.Parser);

		// Token: 0x04001FD1 RID: 8145
		private readonly RepeatedField<AbyssRoleInfo> roleList_ = new RepeatedField<AbyssRoleInfo>();

		// Token: 0x04001FD2 RID: 8146
		public const int PluginItemsFieldNumber = 2;

		// Token: 0x04001FD3 RID: 8147
		private static readonly FieldCodec<AbyssPluginItemInfo> _repeated_pluginItems_codec = FieldCodec.ForMessage<AbyssPluginItemInfo>(18U, AbyssPluginItemInfo.Parser);

		// Token: 0x04001FD4 RID: 8148
		private readonly RepeatedField<AbyssPluginItemInfo> pluginItems_ = new RepeatedField<AbyssPluginItemInfo>();

		// Token: 0x04001FD5 RID: 8149
		public const int RewardInfoFieldNumber = 3;

		// Token: 0x04001FD6 RID: 8150
		private static readonly FieldCodec<AbyssRewardInfo> _repeated_rewardInfo_codec = FieldCodec.ForMessage<AbyssRewardInfo>(26U, AbyssRewardInfo.Parser);

		// Token: 0x04001FD7 RID: 8151
		private readonly RepeatedField<AbyssRewardInfo> rewardInfo_ = new RepeatedField<AbyssRewardInfo>();

		// Token: 0x04001FD8 RID: 8152
		public const int UnlockChallengeIdsFieldNumber = 4;

		// Token: 0x04001FD9 RID: 8153
		private static readonly FieldCodec<int> _repeated_unlockChallengeIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04001FDA RID: 8154
		private readonly RepeatedField<int> unlockChallengeIds_ = new RepeatedField<int>();

		// Token: 0x04001FDB RID: 8155
		public const int LikeCountFieldNumber = 5;

		// Token: 0x04001FDC RID: 8156
		private int likeCount_;

		// Token: 0x04001FDD RID: 8157
		public const int ChallengeInfosFieldNumber = 6;

		// Token: 0x04001FDE RID: 8158
		private static readonly FieldCodec<AbyssChallenge> _repeated_challengeInfos_codec = FieldCodec.ForMessage<AbyssChallenge>(50U, AbyssChallenge.Parser);

		// Token: 0x04001FDF RID: 8159
		private readonly RepeatedField<AbyssChallenge> challengeInfos_ = new RepeatedField<AbyssChallenge>();

		// Token: 0x04001FE0 RID: 8160
		public const int LimitBeginTimeFieldNumber = 7;

		// Token: 0x04001FE1 RID: 8161
		private long limitBeginTime_;

		// Token: 0x04001FE2 RID: 8162
		public const int LimitEndTimeFieldNumber = 8;

		// Token: 0x04001FE3 RID: 8163
		private long limitEndTime_;
	}
}
