using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000593 RID: 1427
	public sealed class FlagChallengeActivityInfo : IMessage<FlagChallengeActivityInfo>, IMessage, IEquatable<FlagChallengeActivityInfo>, IDeepCloneable<FlagChallengeActivityInfo>, IBufferMessage
	{
		// Token: 0x06008432 RID: 33842 RVA: 0x0013E0F8 File Offset: 0x0013C2F8
		[NullableContext(1)]
		public static FlagChallengeActivityInfo Create()
		{
			return new FlagChallengeActivityInfo();
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06008433 RID: 33843 RVA: 0x0013E0FF File Offset: 0x0013C2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06008434 RID: 33844 RVA: 0x0013E102 File Offset: 0x0013C302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeActivityInfo.Descriptor;
			}
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x0013E109 File Offset: 0x0013C309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeActivityInfo()
		{
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x0013E140 File Offset: 0x0013C340
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

		// Token: 0x06008437 RID: 33847 RVA: 0x0013E1C4 File Offset: 0x0013C3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeActivityInfo Clone()
		{
			return new FlagChallengeActivityInfo(this);
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06008438 RID: 33848 RVA: 0x0013E1CC File Offset: 0x0013C3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06008439 RID: 33849 RVA: 0x0013E1D4 File Offset: 0x0013C3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagChallengeLevelInfo> FlagChallengeLevelInfos
		{
			get
			{
				return this.flagChallengeLevelInfos_;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x0600843A RID: 33850 RVA: 0x0013E1DC File Offset: 0x0013C3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagStrongholdInfo> FlagStrongholdInfos
		{
			get
			{
				return this.flagStrongholdInfos_;
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x0013E1E4 File Offset: 0x0013C3E4
		// (set) Token: 0x0600843C RID: 33852 RVA: 0x0013E1EC File Offset: 0x0013C3EC
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

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x0013E1F5 File Offset: 0x0013C3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTeleporterId
		{
			get
			{
				return this.unlockTeleporterId_;
			}
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x0013E1FD File Offset: 0x0013C3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeActivityInfo);
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x0013E20C File Offset: 0x0013C40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeActivityInfo other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && this.flagChallengeLevelInfos_.Equals(other.flagChallengeLevelInfos_) && this.flagStrongholdInfos_.Equals(other.flagStrongholdInfos_) && object.Equals(this.FlagChallengeRoleLevelInfo, other.FlagChallengeRoleLevelInfo) && this.unlockTeleporterId_.Equals(other.unlockTeleporterId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x0013E2A0 File Offset: 0x0013C4A0
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

		// Token: 0x06008441 RID: 33857 RVA: 0x0013E314 File Offset: 0x0013C514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x0013E321 File Offset: 0x0013C521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x0013E32C File Offset: 0x0013C52C
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

		// Token: 0x06008444 RID: 33860 RVA: 0x0013E3B0 File Offset: 0x0013C5B0
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

		// Token: 0x06008445 RID: 33861 RVA: 0x0013E43C File Offset: 0x0013C63C
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

		// Token: 0x06008446 RID: 33862 RVA: 0x0013E4D4 File Offset: 0x0013C6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x0013E4E0 File Offset: 0x0013C6E0
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

		// Token: 0x040041A1 RID: 16801
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041A2 RID: 16802
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x040041A3 RID: 16803
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x040041A4 RID: 16804
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x040041A5 RID: 16805
		public const int FlagChallengeLevelInfosFieldNumber = 2;

		// Token: 0x040041A6 RID: 16806
		private static readonly FieldCodec<FlagChallengeLevelInfo> _repeated_flagChallengeLevelInfos_codec = FieldCodec.ForMessage<FlagChallengeLevelInfo>(18U, FlagChallengeLevelInfo.Parser);

		// Token: 0x040041A7 RID: 16807
		private readonly RepeatedField<FlagChallengeLevelInfo> flagChallengeLevelInfos_ = new RepeatedField<FlagChallengeLevelInfo>();

		// Token: 0x040041A8 RID: 16808
		public const int FlagStrongholdInfosFieldNumber = 3;

		// Token: 0x040041A9 RID: 16809
		private static readonly FieldCodec<FlagStrongholdInfo> _repeated_flagStrongholdInfos_codec = FieldCodec.ForMessage<FlagStrongholdInfo>(26U, FlagStrongholdInfo.Parser);

		// Token: 0x040041AA RID: 16810
		private readonly RepeatedField<FlagStrongholdInfo> flagStrongholdInfos_ = new RepeatedField<FlagStrongholdInfo>();

		// Token: 0x040041AB RID: 16811
		public const int FlagChallengeRoleLevelInfoFieldNumber = 4;

		// Token: 0x040041AC RID: 16812
		private FlagChallengeRoleLevelInfo flagChallengeRoleLevelInfo_;

		// Token: 0x040041AD RID: 16813
		public const int UnlockTeleporterIdFieldNumber = 5;

		// Token: 0x040041AE RID: 16814
		private static readonly FieldCodec<int> _repeated_unlockTeleporterId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040041AF RID: 16815
		private readonly RepeatedField<int> unlockTeleporterId_ = new RepeatedField<int>();
	}
}
