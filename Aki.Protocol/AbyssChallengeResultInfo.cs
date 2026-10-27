using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200001A RID: 26
	public sealed class AbyssChallengeResultInfo : IMessage<AbyssChallengeResultInfo>, IMessage, IEquatable<AbyssChallengeResultInfo>, IDeepCloneable<AbyssChallengeResultInfo>, IBufferMessage
	{
		// Token: 0x0600106D RID: 4205 RVA: 0x0002DD85 File Offset: 0x0002BF85
		[NullableContext(1)]
		public static AbyssChallengeResultInfo Create()
		{
			return new AbyssChallengeResultInfo();
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x0002DD8C File Offset: 0x0002BF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0002DD8F File Offset: 0x0002BF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeResultInfo.Descriptor;
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0002DD96 File Offset: 0x0002BF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultInfo()
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0002DDC0 File Offset: 0x0002BFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultInfo(AbyssChallengeResultInfo other) : this()
		{
			this.passTime_ = other.passTime_;
			this.minPassTime_ = other.minPassTime_;
			this.playerInfos_ = other.playerInfos_.Clone();
			this.success_ = other.success_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this.likeRecord_ = other.likeRecord_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0002DE3B File Offset: 0x0002C03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultInfo Clone()
		{
			return new AbyssChallengeResultInfo(this);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0002DE43 File Offset: 0x0002C043
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x0002DE4B File Offset: 0x0002C04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0002DE54 File Offset: 0x0002C054
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x0002DE5C File Offset: 0x0002C05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinPassTime
		{
			get
			{
				return this.minPassTime_;
			}
			set
			{
				this.minPassTime_ = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x0002DE65 File Offset: 0x0002C065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeResultPlayerInfo> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0002DE6D File Offset: 0x0002C06D
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x0002DE75 File Offset: 0x0002C075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0002DE7E File Offset: 0x0002C07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItem> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x0002DE86 File Offset: 0x0002C086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssLikeRecord> LikeRecord
		{
			get
			{
				return this.likeRecord_;
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0002DE8E File Offset: 0x0002C08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeResultInfo);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0002DE9C File Offset: 0x0002C09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeResultInfo other)
		{
			return other != null && (other == this || (this.PassTime == other.PassTime && this.MinPassTime == other.MinPassTime && this.playerInfos_.Equals(other.playerInfos_) && this.Success == other.Success && this.rewardItems_.Equals(other.rewardItems_) && this.likeRecord_.Equals(other.likeRecord_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002DF34 File Offset: 0x0002C134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this.MinPassTime != 0)
			{
				num ^= this.MinPassTime.GetHashCode();
			}
			num ^= this.playerInfos_.GetHashCode();
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			num ^= this.rewardItems_.GetHashCode();
			num ^= this.likeRecord_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0002DFCF File Offset: 0x0002C1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0002DFDC File Offset: 0x0002C1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PassTime != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PassTime);
			}
			if (this.MinPassTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MinPassTime);
			}
			this.playerInfos_.WriteTo(ref output, AbyssChallengeResultInfo._repeated_playerInfos_codec);
			if (this.Success)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Success);
			}
			this.rewardItems_.WriteTo(ref output, AbyssChallengeResultInfo._repeated_rewardItems_codec);
			this.likeRecord_.WriteTo(ref output, AbyssChallengeResultInfo._repeated_likeRecord_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0002E090 File Offset: 0x0002C290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this.MinPassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinPassTime);
			}
			num += this.playerInfos_.CalculateSize(AbyssChallengeResultInfo._repeated_playerInfos_codec);
			if (this.Success)
			{
				num += 2;
			}
			num += this.rewardItems_.CalculateSize(AbyssChallengeResultInfo._repeated_rewardItems_codec);
			num += this.likeRecord_.CalculateSize(AbyssChallengeResultInfo._repeated_likeRecord_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0002E12C File Offset: 0x0002C32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			if (other.MinPassTime != 0)
			{
				this.MinPassTime = other.MinPassTime;
			}
			this.playerInfos_.Add(other.playerInfos_);
			if (other.Success)
			{
				this.Success = other.Success;
			}
			this.rewardItems_.Add(other.rewardItems_);
			this.likeRecord_.Add(other.likeRecord_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0002E1C3 File Offset: 0x0002C3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0002E1CC File Offset: 0x0002C3CC
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
					if (num == 8U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MinPassTime = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.playerInfos_.AddEntriesFrom(ref input, AbyssChallengeResultInfo._repeated_playerInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Success = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, AbyssChallengeResultInfo._repeated_rewardItems_codec);
						continue;
					}
					if (num == 50U)
					{
						this.likeRecord_.AddEntriesFrom(ref input, AbyssChallengeResultInfo._repeated_likeRecord_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F0A RID: 7946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F0B RID: 7947
		public const int PassTimeFieldNumber = 1;

		// Token: 0x04001F0C RID: 7948
		private int passTime_;

		// Token: 0x04001F0D RID: 7949
		public const int MinPassTimeFieldNumber = 2;

		// Token: 0x04001F0E RID: 7950
		private int minPassTime_;

		// Token: 0x04001F0F RID: 7951
		public const int PlayerInfosFieldNumber = 3;

		// Token: 0x04001F10 RID: 7952
		private static readonly FieldCodec<AbyssChallengeResultPlayerInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<AbyssChallengeResultPlayerInfo>(26U, AbyssChallengeResultPlayerInfo.Parser);

		// Token: 0x04001F11 RID: 7953
		private readonly RepeatedField<AbyssChallengeResultPlayerInfo> playerInfos_ = new RepeatedField<AbyssChallengeResultPlayerInfo>();

		// Token: 0x04001F12 RID: 7954
		public const int SuccessFieldNumber = 4;

		// Token: 0x04001F13 RID: 7955
		private bool success_;

		// Token: 0x04001F14 RID: 7956
		public const int RewardItemsFieldNumber = 5;

		// Token: 0x04001F15 RID: 7957
		private static readonly FieldCodec<RewardItem> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItem>(42U, RewardItem.Parser);

		// Token: 0x04001F16 RID: 7958
		private readonly RepeatedField<RewardItem> rewardItems_ = new RepeatedField<RewardItem>();

		// Token: 0x04001F17 RID: 7959
		public const int LikeRecordFieldNumber = 6;

		// Token: 0x04001F18 RID: 7960
		private static readonly FieldCodec<AbyssLikeRecord> _repeated_likeRecord_codec = FieldCodec.ForMessage<AbyssLikeRecord>(50U, AbyssLikeRecord.Parser);

		// Token: 0x04001F19 RID: 7961
		private readonly RepeatedField<AbyssLikeRecord> likeRecord_ = new RepeatedField<AbyssLikeRecord>();
	}
}
