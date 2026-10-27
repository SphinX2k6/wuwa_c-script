using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C24 RID: 3108
	public sealed class PhantomBattleActivityInfo : IMessage<PhantomBattleActivityInfo>, IMessage, IEquatable<PhantomBattleActivityInfo>, IDeepCloneable<PhantomBattleActivityInfo>, IBufferMessage
	{
		// Token: 0x06010DDC RID: 69084 RVA: 0x002785AC File Offset: 0x002767AC
		[NullableContext(1)]
		public static PhantomBattleActivityInfo Create()
		{
			return new PhantomBattleActivityInfo();
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x06010DDD RID: 69085 RVA: 0x002785B3 File Offset: 0x002767B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x06010DDE RID: 69086 RVA: 0x002785B6 File Offset: 0x002767B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleActivityInfo.Descriptor;
			}
		}

		// Token: 0x06010DDF RID: 69087 RVA: 0x002785C0 File Offset: 0x002767C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleActivityInfo()
		{
		}

		// Token: 0x06010DE0 RID: 69088 RVA: 0x0027862C File Offset: 0x0027682C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleActivityInfo(PhantomBattleActivityInfo other) : this()
		{
			this.phantomBattleChallengeInfos_ = other.phantomBattleChallengeInfos_.Clone();
			this.activityTasks_ = other.activityTasks_.Clone();
			this.phantomBattleMasterInfo_ = ((other.phantomBattleMasterInfo_ != null) ? other.phantomBattleMasterInfo_.Clone() : null);
			this.phantomBattleBadgeInfos_ = other.phantomBattleBadgeInfos_.Clone();
			this.phantomBattleBadgeRewardInfos_ = other.phantomBattleBadgeRewardInfos_.Clone();
			this.phantomBattleCardInfos_ = other.phantomBattleCardInfos_.Clone();
			this.phantomBattleCardRewardInfos_ = other.phantomBattleCardRewardInfos_.Clone();
			this.phantomBattleRoleInfos_ = other.phantomBattleRoleInfos_.Clone();
			this.phantomBattleCardGroupInfos_ = other.phantomBattleCardGroupInfos_.Clone();
			this.timeLimitShopEndTime_ = other.timeLimitShopEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010DE1 RID: 69089 RVA: 0x00278700 File Offset: 0x00276900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleActivityInfo Clone()
		{
			return new PhantomBattleActivityInfo(this);
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x06010DE2 RID: 69090 RVA: 0x00278708 File Offset: 0x00276908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleChallengeInfo> PhantomBattleChallengeInfos
		{
			get
			{
				return this.phantomBattleChallengeInfos_;
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x06010DE3 RID: 69091 RVA: 0x00278710 File Offset: 0x00276910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x06010DE4 RID: 69092 RVA: 0x00278718 File Offset: 0x00276918
		// (set) Token: 0x06010DE5 RID: 69093 RVA: 0x00278720 File Offset: 0x00276920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfo PhantomBattleMasterInfo
		{
			get
			{
				return this.phantomBattleMasterInfo_;
			}
			set
			{
				this.phantomBattleMasterInfo_ = value;
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x06010DE6 RID: 69094 RVA: 0x00278729 File Offset: 0x00276929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBadgeInfo> PhantomBattleBadgeInfos
		{
			get
			{
				return this.phantomBattleBadgeInfos_;
			}
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x06010DE7 RID: 69095 RVA: 0x00278731 File Offset: 0x00276931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBadgeRewardInfo> PhantomBattleBadgeRewardInfos
		{
			get
			{
				return this.phantomBattleBadgeRewardInfos_;
			}
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x06010DE8 RID: 69096 RVA: 0x00278739 File Offset: 0x00276939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardInfo> PhantomBattleCardInfos
		{
			get
			{
				return this.phantomBattleCardInfos_;
			}
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x06010DE9 RID: 69097 RVA: 0x00278741 File Offset: 0x00276941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardRewardInfo> PhantomBattleCardRewardInfos
		{
			get
			{
				return this.phantomBattleCardRewardInfos_;
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x06010DEA RID: 69098 RVA: 0x00278749 File Offset: 0x00276949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleRoleInfo> PhantomBattleRoleInfos
		{
			get
			{
				return this.phantomBattleRoleInfos_;
			}
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x06010DEB RID: 69099 RVA: 0x00278751 File Offset: 0x00276951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardGroupInfo> PhantomBattleCardGroupInfos
		{
			get
			{
				return this.phantomBattleCardGroupInfos_;
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x06010DEC RID: 69100 RVA: 0x00278759 File Offset: 0x00276959
		// (set) Token: 0x06010DED RID: 69101 RVA: 0x00278761 File Offset: 0x00276961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TimeLimitShopEndTime
		{
			get
			{
				return this.timeLimitShopEndTime_;
			}
			set
			{
				this.timeLimitShopEndTime_ = value;
			}
		}

		// Token: 0x06010DEE RID: 69102 RVA: 0x0027876A File Offset: 0x0027696A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleActivityInfo);
		}

		// Token: 0x06010DEF RID: 69103 RVA: 0x00278778 File Offset: 0x00276978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleActivityInfo other)
		{
			return other != null && (other == this || (this.phantomBattleChallengeInfos_.Equals(other.phantomBattleChallengeInfos_) && this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this.PhantomBattleMasterInfo, other.PhantomBattleMasterInfo) && this.phantomBattleBadgeInfos_.Equals(other.phantomBattleBadgeInfos_) && this.phantomBattleBadgeRewardInfos_.Equals(other.phantomBattleBadgeRewardInfos_) && this.phantomBattleCardInfos_.Equals(other.phantomBattleCardInfos_) && this.phantomBattleCardRewardInfos_.Equals(other.phantomBattleCardRewardInfos_) && this.phantomBattleRoleInfos_.Equals(other.phantomBattleRoleInfos_) && this.phantomBattleCardGroupInfos_.Equals(other.phantomBattleCardGroupInfos_) && this.TimeLimitShopEndTime == other.TimeLimitShopEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010DF0 RID: 69104 RVA: 0x00278870 File Offset: 0x00276A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleChallengeInfos_.GetHashCode();
			num ^= this.activityTasks_.GetHashCode();
			if (this.phantomBattleMasterInfo_ != null)
			{
				num ^= this.PhantomBattleMasterInfo.GetHashCode();
			}
			num ^= this.phantomBattleBadgeInfos_.GetHashCode();
			num ^= this.phantomBattleBadgeRewardInfos_.GetHashCode();
			num ^= this.phantomBattleCardInfos_.GetHashCode();
			num ^= this.phantomBattleCardRewardInfos_.GetHashCode();
			num ^= this.phantomBattleRoleInfos_.GetHashCode();
			num ^= this.phantomBattleCardGroupInfos_.GetHashCode();
			if (this.TimeLimitShopEndTime != 0L)
			{
				num ^= this.TimeLimitShopEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010DF1 RID: 69105 RVA: 0x00278935 File Offset: 0x00276B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010DF2 RID: 69106 RVA: 0x00278942 File Offset: 0x00276B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010DF3 RID: 69107 RVA: 0x0027894C File Offset: 0x00276B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleChallengeInfos_.WriteTo(ref output, PhantomBattleActivityInfo._repeated_phantomBattleChallengeInfos_codec);
			this.activityTasks_.WriteTo(ref output, PhantomBattleActivityInfo._repeated_activityTasks_codec);
			if (this.phantomBattleMasterInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PhantomBattleMasterInfo);
			}
			this.phantomBattleBadgeInfos_.WriteTo(ref output, PhantomBattleActivityInfo._repeated_phantomBattleBadgeInfos_codec);
			this.phantomBattleBadgeRewardInfos_.WriteTo(ref output, PhantomBattleActivityInfo._repeated_phantomBattleBadgeRewardInfos_codec);
			this.phantomBattleCardInfos_.WriteTo(ref output, PhantomBattleActivityInfo._repeated_phantomBattleCardInfos_codec);
			this.phantomBattleCardRewardInfos_.WriteTo(ref output, PhantomBattleActivityInfo._repeated_phantomBattleCardRewardInfos_codec);
			this.phantomBattleRoleInfos_.WriteTo(ref output, PhantomBattleActivityInfo._repeated_phantomBattleRoleInfos_codec);
			this.phantomBattleCardGroupInfos_.WriteTo(ref output, PhantomBattleActivityInfo._repeated_phantomBattleCardGroupInfos_codec);
			if (this.TimeLimitShopEndTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.TimeLimitShopEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010DF4 RID: 69108 RVA: 0x00278A30 File Offset: 0x00276C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleChallengeInfos_.CalculateSize(PhantomBattleActivityInfo._repeated_phantomBattleChallengeInfos_codec);
			num += this.activityTasks_.CalculateSize(PhantomBattleActivityInfo._repeated_activityTasks_codec);
			if (this.phantomBattleMasterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleMasterInfo);
			}
			num += this.phantomBattleBadgeInfos_.CalculateSize(PhantomBattleActivityInfo._repeated_phantomBattleBadgeInfos_codec);
			num += this.phantomBattleBadgeRewardInfos_.CalculateSize(PhantomBattleActivityInfo._repeated_phantomBattleBadgeRewardInfos_codec);
			num += this.phantomBattleCardInfos_.CalculateSize(PhantomBattleActivityInfo._repeated_phantomBattleCardInfos_codec);
			num += this.phantomBattleCardRewardInfos_.CalculateSize(PhantomBattleActivityInfo._repeated_phantomBattleCardRewardInfos_codec);
			num += this.phantomBattleRoleInfos_.CalculateSize(PhantomBattleActivityInfo._repeated_phantomBattleRoleInfos_codec);
			num += this.phantomBattleCardGroupInfos_.CalculateSize(PhantomBattleActivityInfo._repeated_phantomBattleCardGroupInfos_codec);
			if (this.TimeLimitShopEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TimeLimitShopEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010DF5 RID: 69109 RVA: 0x00278B20 File Offset: 0x00276D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleChallengeInfos_.Add(other.phantomBattleChallengeInfos_);
			this.activityTasks_.Add(other.activityTasks_);
			if (other.phantomBattleMasterInfo_ != null)
			{
				if (this.phantomBattleMasterInfo_ == null)
				{
					this.PhantomBattleMasterInfo = new PhantomBattleMasterInfo();
				}
				this.PhantomBattleMasterInfo.MergeFrom(other.PhantomBattleMasterInfo);
			}
			this.phantomBattleBadgeInfos_.Add(other.phantomBattleBadgeInfos_);
			this.phantomBattleBadgeRewardInfos_.Add(other.phantomBattleBadgeRewardInfos_);
			this.phantomBattleCardInfos_.Add(other.phantomBattleCardInfos_);
			this.phantomBattleCardRewardInfos_.Add(other.phantomBattleCardRewardInfos_);
			this.phantomBattleRoleInfos_.Add(other.phantomBattleRoleInfos_);
			this.phantomBattleCardGroupInfos_.Add(other.phantomBattleCardGroupInfos_);
			if (other.TimeLimitShopEndTime != 0L)
			{
				this.TimeLimitShopEndTime = other.TimeLimitShopEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010DF6 RID: 69110 RVA: 0x00278C10 File Offset: 0x00276E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DF7 RID: 69111 RVA: 0x00278C1C File Offset: 0x00276E1C
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
				if (num <= 42U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							this.phantomBattleChallengeInfos_.AddEntriesFrom(ref input, PhantomBattleActivityInfo._repeated_phantomBattleChallengeInfos_codec);
							continue;
						}
						if (num == 18U)
						{
							this.activityTasks_.AddEntriesFrom(ref input, PhantomBattleActivityInfo._repeated_activityTasks_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.phantomBattleMasterInfo_ == null)
							{
								this.PhantomBattleMasterInfo = new PhantomBattleMasterInfo();
							}
							input.ReadMessage(this.PhantomBattleMasterInfo);
							continue;
						}
						if (num == 34U)
						{
							this.phantomBattleBadgeInfos_.AddEntriesFrom(ref input, PhantomBattleActivityInfo._repeated_phantomBattleBadgeInfos_codec);
							continue;
						}
						if (num == 42U)
						{
							this.phantomBattleBadgeRewardInfos_.AddEntriesFrom(ref input, PhantomBattleActivityInfo._repeated_phantomBattleBadgeRewardInfos_codec);
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						this.phantomBattleCardInfos_.AddEntriesFrom(ref input, PhantomBattleActivityInfo._repeated_phantomBattleCardInfos_codec);
						continue;
					}
					if (num == 58U)
					{
						this.phantomBattleCardRewardInfos_.AddEntriesFrom(ref input, PhantomBattleActivityInfo._repeated_phantomBattleCardRewardInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.phantomBattleRoleInfos_.AddEntriesFrom(ref input, PhantomBattleActivityInfo._repeated_phantomBattleRoleInfos_codec);
						continue;
					}
					if (num == 74U)
					{
						this.phantomBattleCardGroupInfos_.AddEntriesFrom(ref input, PhantomBattleActivityInfo._repeated_phantomBattleCardGroupInfos_codec);
						continue;
					}
					if (num == 80U)
					{
						this.TimeLimitShopEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006B11 RID: 27409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B12 RID: 27410
		public const int PhantomBattleChallengeInfosFieldNumber = 1;

		// Token: 0x04006B13 RID: 27411
		private static readonly FieldCodec<PhantomBattleChallengeInfo> _repeated_phantomBattleChallengeInfos_codec = FieldCodec.ForMessage<PhantomBattleChallengeInfo>(10U, PhantomBattleChallengeInfo.Parser);

		// Token: 0x04006B14 RID: 27412
		private readonly RepeatedField<PhantomBattleChallengeInfo> phantomBattleChallengeInfos_ = new RepeatedField<PhantomBattleChallengeInfo>();

		// Token: 0x04006B15 RID: 27413
		public const int ActivityTasksFieldNumber = 2;

		// Token: 0x04006B16 RID: 27414
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(18U, ActivityTask.Parser);

		// Token: 0x04006B17 RID: 27415
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04006B18 RID: 27416
		public const int PhantomBattleMasterInfoFieldNumber = 3;

		// Token: 0x04006B19 RID: 27417
		private PhantomBattleMasterInfo phantomBattleMasterInfo_;

		// Token: 0x04006B1A RID: 27418
		public const int PhantomBattleBadgeInfosFieldNumber = 4;

		// Token: 0x04006B1B RID: 27419
		private static readonly FieldCodec<PhantomBattleBadgeInfo> _repeated_phantomBattleBadgeInfos_codec = FieldCodec.ForMessage<PhantomBattleBadgeInfo>(34U, PhantomBattleBadgeInfo.Parser);

		// Token: 0x04006B1C RID: 27420
		private readonly RepeatedField<PhantomBattleBadgeInfo> phantomBattleBadgeInfos_ = new RepeatedField<PhantomBattleBadgeInfo>();

		// Token: 0x04006B1D RID: 27421
		public const int PhantomBattleBadgeRewardInfosFieldNumber = 5;

		// Token: 0x04006B1E RID: 27422
		private static readonly FieldCodec<PhantomBattleBadgeRewardInfo> _repeated_phantomBattleBadgeRewardInfos_codec = FieldCodec.ForMessage<PhantomBattleBadgeRewardInfo>(42U, PhantomBattleBadgeRewardInfo.Parser);

		// Token: 0x04006B1F RID: 27423
		private readonly RepeatedField<PhantomBattleBadgeRewardInfo> phantomBattleBadgeRewardInfos_ = new RepeatedField<PhantomBattleBadgeRewardInfo>();

		// Token: 0x04006B20 RID: 27424
		public const int PhantomBattleCardInfosFieldNumber = 6;

		// Token: 0x04006B21 RID: 27425
		private static readonly FieldCodec<PhantomBattleCardInfo> _repeated_phantomBattleCardInfos_codec = FieldCodec.ForMessage<PhantomBattleCardInfo>(50U, PhantomBattleCardInfo.Parser);

		// Token: 0x04006B22 RID: 27426
		private readonly RepeatedField<PhantomBattleCardInfo> phantomBattleCardInfos_ = new RepeatedField<PhantomBattleCardInfo>();

		// Token: 0x04006B23 RID: 27427
		public const int PhantomBattleCardRewardInfosFieldNumber = 7;

		// Token: 0x04006B24 RID: 27428
		private static readonly FieldCodec<PhantomBattleCardRewardInfo> _repeated_phantomBattleCardRewardInfos_codec = FieldCodec.ForMessage<PhantomBattleCardRewardInfo>(58U, PhantomBattleCardRewardInfo.Parser);

		// Token: 0x04006B25 RID: 27429
		private readonly RepeatedField<PhantomBattleCardRewardInfo> phantomBattleCardRewardInfos_ = new RepeatedField<PhantomBattleCardRewardInfo>();

		// Token: 0x04006B26 RID: 27430
		public const int PhantomBattleRoleInfosFieldNumber = 8;

		// Token: 0x04006B27 RID: 27431
		private static readonly FieldCodec<PhantomBattleRoleInfo> _repeated_phantomBattleRoleInfos_codec = FieldCodec.ForMessage<PhantomBattleRoleInfo>(66U, PhantomBattleRoleInfo.Parser);

		// Token: 0x04006B28 RID: 27432
		private readonly RepeatedField<PhantomBattleRoleInfo> phantomBattleRoleInfos_ = new RepeatedField<PhantomBattleRoleInfo>();

		// Token: 0x04006B29 RID: 27433
		public const int PhantomBattleCardGroupInfosFieldNumber = 9;

		// Token: 0x04006B2A RID: 27434
		private static readonly FieldCodec<PhantomBattleCardGroupInfo> _repeated_phantomBattleCardGroupInfos_codec = FieldCodec.ForMessage<PhantomBattleCardGroupInfo>(74U, PhantomBattleCardGroupInfo.Parser);

		// Token: 0x04006B2B RID: 27435
		private readonly RepeatedField<PhantomBattleCardGroupInfo> phantomBattleCardGroupInfos_ = new RepeatedField<PhantomBattleCardGroupInfo>();

		// Token: 0x04006B2C RID: 27436
		public const int TimeLimitShopEndTimeFieldNumber = 10;

		// Token: 0x04006B2D RID: 27437
		private long timeLimitShopEndTime_;
	}
}
