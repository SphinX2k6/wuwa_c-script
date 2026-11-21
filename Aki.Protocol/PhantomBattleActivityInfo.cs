using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C14 RID: 3092
	public sealed class PhantomBattleActivityInfo : IMessage<PhantomBattleActivityInfo>, IMessage, IEquatable<PhantomBattleActivityInfo>, IDeepCloneable<PhantomBattleActivityInfo>, IBufferMessage
	{
		// Token: 0x06010CDC RID: 68828 RVA: 0x00276848 File Offset: 0x00274A48
		[NullableContext(1)]
		public static PhantomBattleActivityInfo Create()
		{
			return new PhantomBattleActivityInfo();
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x06010CDD RID: 68829 RVA: 0x0027684F File Offset: 0x00274A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x06010CDE RID: 68830 RVA: 0x00276852 File Offset: 0x00274A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleActivityInfo.Descriptor;
			}
		}

		// Token: 0x06010CDF RID: 68831 RVA: 0x0027685C File Offset: 0x00274A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleActivityInfo()
		{
		}

		// Token: 0x06010CE0 RID: 68832 RVA: 0x002768C8 File Offset: 0x00274AC8
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

		// Token: 0x06010CE1 RID: 68833 RVA: 0x0027699C File Offset: 0x00274B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleActivityInfo Clone()
		{
			return new PhantomBattleActivityInfo(this);
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x06010CE2 RID: 68834 RVA: 0x002769A4 File Offset: 0x00274BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleChallengeInfo> PhantomBattleChallengeInfos
		{
			get
			{
				return this.phantomBattleChallengeInfos_;
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x06010CE3 RID: 68835 RVA: 0x002769AC File Offset: 0x00274BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x06010CE4 RID: 68836 RVA: 0x002769B4 File Offset: 0x00274BB4
		// (set) Token: 0x06010CE5 RID: 68837 RVA: 0x002769BC File Offset: 0x00274BBC
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

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x06010CE6 RID: 68838 RVA: 0x002769C5 File Offset: 0x00274BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBadgeInfo> PhantomBattleBadgeInfos
		{
			get
			{
				return this.phantomBattleBadgeInfos_;
			}
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x06010CE7 RID: 68839 RVA: 0x002769CD File Offset: 0x00274BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleBadgeRewardInfo> PhantomBattleBadgeRewardInfos
		{
			get
			{
				return this.phantomBattleBadgeRewardInfos_;
			}
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x06010CE8 RID: 68840 RVA: 0x002769D5 File Offset: 0x00274BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardInfo> PhantomBattleCardInfos
		{
			get
			{
				return this.phantomBattleCardInfos_;
			}
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x06010CE9 RID: 68841 RVA: 0x002769DD File Offset: 0x00274BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardRewardInfo> PhantomBattleCardRewardInfos
		{
			get
			{
				return this.phantomBattleCardRewardInfos_;
			}
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x06010CEA RID: 68842 RVA: 0x002769E5 File Offset: 0x00274BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleRoleInfo> PhantomBattleRoleInfos
		{
			get
			{
				return this.phantomBattleRoleInfos_;
			}
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x06010CEB RID: 68843 RVA: 0x002769ED File Offset: 0x00274BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardGroupInfo> PhantomBattleCardGroupInfos
		{
			get
			{
				return this.phantomBattleCardGroupInfos_;
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x06010CEC RID: 68844 RVA: 0x002769F5 File Offset: 0x00274BF5
		// (set) Token: 0x06010CED RID: 68845 RVA: 0x002769FD File Offset: 0x00274BFD
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

		// Token: 0x06010CEE RID: 68846 RVA: 0x00276A06 File Offset: 0x00274C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleActivityInfo);
		}

		// Token: 0x06010CEF RID: 68847 RVA: 0x00276A14 File Offset: 0x00274C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleActivityInfo other)
		{
			return other != null && (other == this || (this.phantomBattleChallengeInfos_.Equals(other.phantomBattleChallengeInfos_) && this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this.PhantomBattleMasterInfo, other.PhantomBattleMasterInfo) && this.phantomBattleBadgeInfos_.Equals(other.phantomBattleBadgeInfos_) && this.phantomBattleBadgeRewardInfos_.Equals(other.phantomBattleBadgeRewardInfos_) && this.phantomBattleCardInfos_.Equals(other.phantomBattleCardInfos_) && this.phantomBattleCardRewardInfos_.Equals(other.phantomBattleCardRewardInfos_) && this.phantomBattleRoleInfos_.Equals(other.phantomBattleRoleInfos_) && this.phantomBattleCardGroupInfos_.Equals(other.phantomBattleCardGroupInfos_) && this.TimeLimitShopEndTime == other.TimeLimitShopEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010CF0 RID: 68848 RVA: 0x00276B0C File Offset: 0x00274D0C
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

		// Token: 0x06010CF1 RID: 68849 RVA: 0x00276BD1 File Offset: 0x00274DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010CF2 RID: 68850 RVA: 0x00276BDE File Offset: 0x00274DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010CF3 RID: 68851 RVA: 0x00276BE8 File Offset: 0x00274DE8
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

		// Token: 0x06010CF4 RID: 68852 RVA: 0x00276CCC File Offset: 0x00274ECC
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

		// Token: 0x06010CF5 RID: 68853 RVA: 0x00276DBC File Offset: 0x00274FBC
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

		// Token: 0x06010CF6 RID: 68854 RVA: 0x00276EAC File Offset: 0x002750AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CF7 RID: 68855 RVA: 0x00276EB8 File Offset: 0x002750B8
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

		// Token: 0x04006B25 RID: 27429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B26 RID: 27430
		public const int PhantomBattleChallengeInfosFieldNumber = 1;

		// Token: 0x04006B27 RID: 27431
		private static readonly FieldCodec<PhantomBattleChallengeInfo> _repeated_phantomBattleChallengeInfos_codec = FieldCodec.ForMessage<PhantomBattleChallengeInfo>(10U, PhantomBattleChallengeInfo.Parser);

		// Token: 0x04006B28 RID: 27432
		private readonly RepeatedField<PhantomBattleChallengeInfo> phantomBattleChallengeInfos_ = new RepeatedField<PhantomBattleChallengeInfo>();

		// Token: 0x04006B29 RID: 27433
		public const int ActivityTasksFieldNumber = 2;

		// Token: 0x04006B2A RID: 27434
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(18U, ActivityTask.Parser);

		// Token: 0x04006B2B RID: 27435
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04006B2C RID: 27436
		public const int PhantomBattleMasterInfoFieldNumber = 3;

		// Token: 0x04006B2D RID: 27437
		private PhantomBattleMasterInfo phantomBattleMasterInfo_;

		// Token: 0x04006B2E RID: 27438
		public const int PhantomBattleBadgeInfosFieldNumber = 4;

		// Token: 0x04006B2F RID: 27439
		private static readonly FieldCodec<PhantomBattleBadgeInfo> _repeated_phantomBattleBadgeInfos_codec = FieldCodec.ForMessage<PhantomBattleBadgeInfo>(34U, PhantomBattleBadgeInfo.Parser);

		// Token: 0x04006B30 RID: 27440
		private readonly RepeatedField<PhantomBattleBadgeInfo> phantomBattleBadgeInfos_ = new RepeatedField<PhantomBattleBadgeInfo>();

		// Token: 0x04006B31 RID: 27441
		public const int PhantomBattleBadgeRewardInfosFieldNumber = 5;

		// Token: 0x04006B32 RID: 27442
		private static readonly FieldCodec<PhantomBattleBadgeRewardInfo> _repeated_phantomBattleBadgeRewardInfos_codec = FieldCodec.ForMessage<PhantomBattleBadgeRewardInfo>(42U, PhantomBattleBadgeRewardInfo.Parser);

		// Token: 0x04006B33 RID: 27443
		private readonly RepeatedField<PhantomBattleBadgeRewardInfo> phantomBattleBadgeRewardInfos_ = new RepeatedField<PhantomBattleBadgeRewardInfo>();

		// Token: 0x04006B34 RID: 27444
		public const int PhantomBattleCardInfosFieldNumber = 6;

		// Token: 0x04006B35 RID: 27445
		private static readonly FieldCodec<PhantomBattleCardInfo> _repeated_phantomBattleCardInfos_codec = FieldCodec.ForMessage<PhantomBattleCardInfo>(50U, PhantomBattleCardInfo.Parser);

		// Token: 0x04006B36 RID: 27446
		private readonly RepeatedField<PhantomBattleCardInfo> phantomBattleCardInfos_ = new RepeatedField<PhantomBattleCardInfo>();

		// Token: 0x04006B37 RID: 27447
		public const int PhantomBattleCardRewardInfosFieldNumber = 7;

		// Token: 0x04006B38 RID: 27448
		private static readonly FieldCodec<PhantomBattleCardRewardInfo> _repeated_phantomBattleCardRewardInfos_codec = FieldCodec.ForMessage<PhantomBattleCardRewardInfo>(58U, PhantomBattleCardRewardInfo.Parser);

		// Token: 0x04006B39 RID: 27449
		private readonly RepeatedField<PhantomBattleCardRewardInfo> phantomBattleCardRewardInfos_ = new RepeatedField<PhantomBattleCardRewardInfo>();

		// Token: 0x04006B3A RID: 27450
		public const int PhantomBattleRoleInfosFieldNumber = 8;

		// Token: 0x04006B3B RID: 27451
		private static readonly FieldCodec<PhantomBattleRoleInfo> _repeated_phantomBattleRoleInfos_codec = FieldCodec.ForMessage<PhantomBattleRoleInfo>(66U, PhantomBattleRoleInfo.Parser);

		// Token: 0x04006B3C RID: 27452
		private readonly RepeatedField<PhantomBattleRoleInfo> phantomBattleRoleInfos_ = new RepeatedField<PhantomBattleRoleInfo>();

		// Token: 0x04006B3D RID: 27453
		public const int PhantomBattleCardGroupInfosFieldNumber = 9;

		// Token: 0x04006B3E RID: 27454
		private static readonly FieldCodec<PhantomBattleCardGroupInfo> _repeated_phantomBattleCardGroupInfos_codec = FieldCodec.ForMessage<PhantomBattleCardGroupInfo>(74U, PhantomBattleCardGroupInfo.Parser);

		// Token: 0x04006B3F RID: 27455
		private readonly RepeatedField<PhantomBattleCardGroupInfo> phantomBattleCardGroupInfos_ = new RepeatedField<PhantomBattleCardGroupInfo>();

		// Token: 0x04006B40 RID: 27456
		public const int TimeLimitShopEndTimeFieldNumber = 10;

		// Token: 0x04006B41 RID: 27457
		private long timeLimitShopEndTime_;
	}
}
