using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057E RID: 1406
	public sealed class FlagChallengeActivityInfo : IMessage<FlagChallengeActivityInfo>, IMessage, IEquatable<FlagChallengeActivityInfo>, IDeepCloneable<FlagChallengeActivityInfo>, IBufferMessage
	{
		// Token: 0x060082CA RID: 33482 RVA: 0x0013B4EC File Offset: 0x001396EC
		[NullableContext(1)]
		public static FlagChallengeActivityInfo Create()
		{
			return new FlagChallengeActivityInfo();
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060082CB RID: 33483 RVA: 0x0013B4F3 File Offset: 0x001396F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x060082CC RID: 33484 RVA: 0x0013B4F6 File Offset: 0x001396F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeActivityInfo.Descriptor;
			}
		}

		// Token: 0x060082CD RID: 33485 RVA: 0x0013B4FD File Offset: 0x001396FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeActivityInfo()
		{
		}

		// Token: 0x060082CE RID: 33486 RVA: 0x0013B534 File Offset: 0x00139734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeActivityInfo(FlagChallengeActivityInfo other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.flagChallengeLevelInfos_ = other.flagChallengeLevelInfos_.Clone();
			this.flagStrongholdInfos_ = other.flagStrongholdInfos_.Clone();
			this.flagChallengeRoleLevelInfo_ = ((other.flagChallengeRoleLevelInfo_ != null) ? other.flagChallengeRoleLevelInfo_.Clone() : null);
			this.unlockTeleporterId_ = other.unlockTeleporterId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082CF RID: 33487 RVA: 0x0013B5B8 File Offset: 0x001397B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeActivityInfo Clone()
		{
			return new FlagChallengeActivityInfo(this);
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060082D0 RID: 33488 RVA: 0x0013B5C0 File Offset: 0x001397C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060082D1 RID: 33489 RVA: 0x0013B5C8 File Offset: 0x001397C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagChallengeLevelInfo> FlagChallengeLevelInfos
		{
			get
			{
				return this.flagChallengeLevelInfos_;
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x060082D2 RID: 33490 RVA: 0x0013B5D0 File Offset: 0x001397D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagStrongholdInfo> FlagStrongholdInfos
		{
			get
			{
				return this.flagStrongholdInfos_;
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060082D3 RID: 33491 RVA: 0x0013B5D8 File Offset: 0x001397D8
		// (set) Token: 0x060082D4 RID: 33492 RVA: 0x0013B5E0 File Offset: 0x001397E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengeRoleLevelInfo
		{
			get
			{
				return this.flagChallengeRoleLevelInfo_;
			}
			set
			{
				this.flagChallengeRoleLevelInfo_ = value;
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060082D5 RID: 33493 RVA: 0x0013B5E9 File Offset: 0x001397E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTeleporterId
		{
			get
			{
				return this.unlockTeleporterId_;
			}
		}

		// Token: 0x060082D6 RID: 33494 RVA: 0x0013B5F1 File Offset: 0x001397F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeActivityInfo);
		}

		// Token: 0x060082D7 RID: 33495 RVA: 0x0013B600 File Offset: 0x00139800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeActivityInfo other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && this.flagChallengeLevelInfos_.Equals(other.flagChallengeLevelInfos_) && this.flagStrongholdInfos_.Equals(other.flagStrongholdInfos_) && object.Equals(this.FlagChallengeRoleLevelInfo, other.FlagChallengeRoleLevelInfo) && this.unlockTeleporterId_.Equals(other.unlockTeleporterId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082D8 RID: 33496 RVA: 0x0013B694 File Offset: 0x00139894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.flagChallengeLevelInfos_.GetHashCode();
			num ^= this.flagStrongholdInfos_.GetHashCode();
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengeRoleLevelInfo.GetHashCode();
			}
			num ^= this.unlockTeleporterId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060082D9 RID: 33497 RVA: 0x0013B708 File Offset: 0x00139908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060082DA RID: 33498 RVA: 0x0013B715 File Offset: 0x00139915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082DB RID: 33499 RVA: 0x0013B720 File Offset: 0x00139920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, FlagChallengeActivityInfo._repeated_conditionTasks_codec);
			this.flagChallengeLevelInfos_.WriteTo(ref output, FlagChallengeActivityInfo._repeated_flagChallengeLevelInfos_codec);
			this.flagStrongholdInfos_.WriteTo(ref output, FlagChallengeActivityInfo._repeated_flagStrongholdInfos_codec);
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.FlagChallengeRoleLevelInfo);
			}
			this.unlockTeleporterId_.WriteTo(ref output, FlagChallengeActivityInfo._repeated_unlockTeleporterId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082DC RID: 33500 RVA: 0x0013B7A4 File Offset: 0x001399A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(FlagChallengeActivityInfo._repeated_conditionTasks_codec);
			num += this.flagChallengeLevelInfos_.CalculateSize(FlagChallengeActivityInfo._repeated_flagChallengeLevelInfos_codec);
			num += this.flagStrongholdInfos_.CalculateSize(FlagChallengeActivityInfo._repeated_flagStrongholdInfos_codec);
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeRoleLevelInfo);
			}
			num += this.unlockTeleporterId_.CalculateSize(FlagChallengeActivityInfo._repeated_unlockTeleporterId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060082DD RID: 33501 RVA: 0x0013B830 File Offset: 0x00139A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this.flagChallengeLevelInfos_.Add(other.flagChallengeLevelInfos_);
			this.flagStrongholdInfos_.Add(other.flagStrongholdInfos_);
			if (other.flagChallengeRoleLevelInfo_ != null)
			{
				if (this.flagChallengeRoleLevelInfo_ == null)
				{
					this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengeRoleLevelInfo.MergeFrom(other.FlagChallengeRoleLevelInfo);
			}
			this.unlockTeleporterId_.Add(other.unlockTeleporterId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060082DE RID: 33502 RVA: 0x0013B8C8 File Offset: 0x00139AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082DF RID: 33503 RVA: 0x0013B8D4 File Offset: 0x00139AD4
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.conditionTasks_.AddEntriesFrom(ref input, FlagChallengeActivityInfo._repeated_conditionTasks_codec);
						continue;
					}
					if (num == 18U)
					{
						this.flagChallengeLevelInfos_.AddEntriesFrom(ref input, FlagChallengeActivityInfo._repeated_flagChallengeLevelInfos_codec);
						continue;
					}
					if (num == 26U)
					{
						this.flagStrongholdInfos_.AddEntriesFrom(ref input, FlagChallengeActivityInfo._repeated_flagStrongholdInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.flagChallengeRoleLevelInfo_ == null)
						{
							this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
						}
						input.ReadMessage(this.FlagChallengeRoleLevelInfo);
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.unlockTeleporterId_.AddEntriesFrom(ref input, FlagChallengeActivityInfo._repeated_unlockTeleporterId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004197 RID: 16791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004198 RID: 16792
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04004199 RID: 16793
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x0400419A RID: 16794
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400419B RID: 16795
		public const int FlagChallengeLevelInfosFieldNumber = 2;

		// Token: 0x0400419C RID: 16796
		private static readonly FieldCodec<FlagChallengeLevelInfo> _repeated_flagChallengeLevelInfos_codec = FieldCodec.ForMessage<FlagChallengeLevelInfo>(18U, FlagChallengeLevelInfo.Parser);

		// Token: 0x0400419D RID: 16797
		private readonly RepeatedField<FlagChallengeLevelInfo> flagChallengeLevelInfos_ = new RepeatedField<FlagChallengeLevelInfo>();

		// Token: 0x0400419E RID: 16798
		public const int FlagStrongholdInfosFieldNumber = 3;

		// Token: 0x0400419F RID: 16799
		private static readonly FieldCodec<FlagStrongholdInfo> _repeated_flagStrongholdInfos_codec = FieldCodec.ForMessage<FlagStrongholdInfo>(26U, FlagStrongholdInfo.Parser);

		// Token: 0x040041A0 RID: 16800
		private readonly RepeatedField<FlagStrongholdInfo> flagStrongholdInfos_ = new RepeatedField<FlagStrongholdInfo>();

		// Token: 0x040041A1 RID: 16801
		public const int FlagChallengeRoleLevelInfoFieldNumber = 4;

		// Token: 0x040041A2 RID: 16802
		private FlagChallengeRoleLevelInfo flagChallengeRoleLevelInfo_;

		// Token: 0x040041A3 RID: 16803
		public const int UnlockTeleporterIdFieldNumber = 5;

		// Token: 0x040041A4 RID: 16804
		private static readonly FieldCodec<int> _repeated_unlockTeleporterId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040041A5 RID: 16805
		private readonly RepeatedField<int> unlockTeleporterId_ = new RepeatedField<int>();
	}
}
