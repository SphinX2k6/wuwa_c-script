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
		// Token: 0x06001172 RID: 4466 RVA: 0x000308AB File Offset: 0x0002EAAB
		[NullableContext(1)]
		public static AbyssInfo Create()
		{
			return new AbyssInfo();
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x000308B2 File Offset: 0x0002EAB2
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
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x000308B5 File Offset: 0x0002EAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssInfo.Descriptor;
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x000308BC File Offset: 0x0002EABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInfo()
		{
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000308FC File Offset: 0x0002EAFC
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

		// Token: 0x06001177 RID: 4471 RVA: 0x00030999 File Offset: 0x0002EB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInfo Clone()
		{
			return new AbyssInfo(this);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x000309A1 File Offset: 0x0002EBA1
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
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x000309A9 File Offset: 0x0002EBA9
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
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x000309B1 File Offset: 0x0002EBB1
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
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x000309B9 File Offset: 0x0002EBB9
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
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x000309C1 File Offset: 0x0002EBC1
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x000309C9 File Offset: 0x0002EBC9
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
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x000309D2 File Offset: 0x0002EBD2
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
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000309DA File Offset: 0x0002EBDA
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x000309E2 File Offset: 0x0002EBE2
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
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x000309EB File Offset: 0x0002EBEB
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x000309F3 File Offset: 0x0002EBF3
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

		// Token: 0x06001183 RID: 4483 RVA: 0x000309FC File Offset: 0x0002EBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssInfo);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00030A0C File Offset: 0x0002EC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssInfo other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && this.pluginItems_.Equals(other.pluginItems_) && this.rewardInfo_.Equals(other.rewardInfo_) && this.unlockChallengeIds_.Equals(other.unlockChallengeIds_) && this.LikeCount == other.LikeCount && this.challengeInfos_.Equals(other.challengeInfos_) && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00030AD0 File Offset: 0x0002ECD0
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

		// Token: 0x06001186 RID: 4486 RVA: 0x00030B87 File Offset: 0x0002ED87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00030B94 File Offset: 0x0002ED94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00030BA0 File Offset: 0x0002EDA0
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

		// Token: 0x06001189 RID: 4489 RVA: 0x00030C6C File Offset: 0x0002EE6C
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

		// Token: 0x0600118A RID: 4490 RVA: 0x00030D3C File Offset: 0x0002EF3C
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

		// Token: 0x0600118B RID: 4491 RVA: 0x00030DF5 File Offset: 0x0002EFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00030E00 File Offset: 0x0002F000
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

		// Token: 0x04001F78 RID: 8056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F79 RID: 8057
		public const int RoleListFieldNumber = 1;

		// Token: 0x04001F7A RID: 8058
		private static readonly FieldCodec<AbyssRoleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<AbyssRoleInfo>(10U, AbyssRoleInfo.Parser);

		// Token: 0x04001F7B RID: 8059
		private readonly RepeatedField<AbyssRoleInfo> roleList_ = new RepeatedField<AbyssRoleInfo>();

		// Token: 0x04001F7C RID: 8060
		public const int PluginItemsFieldNumber = 2;

		// Token: 0x04001F7D RID: 8061
		private static readonly FieldCodec<AbyssPluginItemInfo> _repeated_pluginItems_codec = FieldCodec.ForMessage<AbyssPluginItemInfo>(18U, AbyssPluginItemInfo.Parser);

		// Token: 0x04001F7E RID: 8062
		private readonly RepeatedField<AbyssPluginItemInfo> pluginItems_ = new RepeatedField<AbyssPluginItemInfo>();

		// Token: 0x04001F7F RID: 8063
		public const int RewardInfoFieldNumber = 3;

		// Token: 0x04001F80 RID: 8064
		private static readonly FieldCodec<AbyssRewardInfo> _repeated_rewardInfo_codec = FieldCodec.ForMessage<AbyssRewardInfo>(26U, AbyssRewardInfo.Parser);

		// Token: 0x04001F81 RID: 8065
		private readonly RepeatedField<AbyssRewardInfo> rewardInfo_ = new RepeatedField<AbyssRewardInfo>();

		// Token: 0x04001F82 RID: 8066
		public const int UnlockChallengeIdsFieldNumber = 4;

		// Token: 0x04001F83 RID: 8067
		private static readonly FieldCodec<int> _repeated_unlockChallengeIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04001F84 RID: 8068
		private readonly RepeatedField<int> unlockChallengeIds_ = new RepeatedField<int>();

		// Token: 0x04001F85 RID: 8069
		public const int LikeCountFieldNumber = 5;

		// Token: 0x04001F86 RID: 8070
		private int likeCount_;

		// Token: 0x04001F87 RID: 8071
		public const int ChallengeInfosFieldNumber = 6;

		// Token: 0x04001F88 RID: 8072
		private static readonly FieldCodec<AbyssChallenge> _repeated_challengeInfos_codec = FieldCodec.ForMessage<AbyssChallenge>(50U, AbyssChallenge.Parser);

		// Token: 0x04001F89 RID: 8073
		private readonly RepeatedField<AbyssChallenge> challengeInfos_ = new RepeatedField<AbyssChallenge>();

		// Token: 0x04001F8A RID: 8074
		public const int LimitBeginTimeFieldNumber = 7;

		// Token: 0x04001F8B RID: 8075
		private long limitBeginTime_;

		// Token: 0x04001F8C RID: 8076
		public const int LimitEndTimeFieldNumber = 8;

		// Token: 0x04001F8D RID: 8077
		private long limitEndTime_;
	}
}
