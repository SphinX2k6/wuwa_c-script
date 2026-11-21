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
		// Token: 0x06001098 RID: 4248 RVA: 0x0002E339 File Offset: 0x0002C539
		[NullableContext(1)]
		public static AbyssChallengeResultInfo Create()
		{
			return new AbyssChallengeResultInfo();
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0002E340 File Offset: 0x0002C540
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
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0002E343 File Offset: 0x0002C543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeResultInfo.Descriptor;
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0002E34A File Offset: 0x0002C54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultInfo()
		{
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0002E374 File Offset: 0x0002C574
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

		// Token: 0x0600109D RID: 4253 RVA: 0x0002E3EF File Offset: 0x0002C5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultInfo Clone()
		{
			return new AbyssChallengeResultInfo(this);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x0002E3F7 File Offset: 0x0002C5F7
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x0002E3FF File Offset: 0x0002C5FF
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
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0002E408 File Offset: 0x0002C608
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0002E410 File Offset: 0x0002C610
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
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0002E419 File Offset: 0x0002C619
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
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0002E421 File Offset: 0x0002C621
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x0002E429 File Offset: 0x0002C629
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
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0002E432 File Offset: 0x0002C632
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
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0002E43A File Offset: 0x0002C63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssLikeRecord> LikeRecord
		{
			get
			{
				return this.likeRecord_;
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0002E442 File Offset: 0x0002C642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeResultInfo);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0002E450 File Offset: 0x0002C650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeResultInfo other)
		{
			return other != null && (other == this || (this.PassTime == other.PassTime && this.MinPassTime == other.MinPassTime && this.playerInfos_.Equals(other.playerInfos_) && this.Success == other.Success && this.rewardItems_.Equals(other.rewardItems_) && this.likeRecord_.Equals(other.likeRecord_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
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

		// Token: 0x060010AA RID: 4266 RVA: 0x0002E583 File Offset: 0x0002C783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0002E590 File Offset: 0x0002C790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0002E59C File Offset: 0x0002C79C
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

		// Token: 0x060010AD RID: 4269 RVA: 0x0002E644 File Offset: 0x0002C844
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

		// Token: 0x060010AE RID: 4270 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
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

		// Token: 0x060010AF RID: 4271 RVA: 0x0002E777 File Offset: 0x0002C977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0002E780 File Offset: 0x0002C980
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

		// Token: 0x04001F60 RID: 8032
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F61 RID: 8033
		public const int PassTimeFieldNumber = 1;

		// Token: 0x04001F62 RID: 8034
		private int passTime_;

		// Token: 0x04001F63 RID: 8035
		public const int MinPassTimeFieldNumber = 2;

		// Token: 0x04001F64 RID: 8036
		private int minPassTime_;

		// Token: 0x04001F65 RID: 8037
		public const int PlayerInfosFieldNumber = 3;

		// Token: 0x04001F66 RID: 8038
		private static readonly FieldCodec<AbyssChallengeResultPlayerInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<AbyssChallengeResultPlayerInfo>(26U, AbyssChallengeResultPlayerInfo.Parser);

		// Token: 0x04001F67 RID: 8039
		private readonly RepeatedField<AbyssChallengeResultPlayerInfo> playerInfos_ = new RepeatedField<AbyssChallengeResultPlayerInfo>();

		// Token: 0x04001F68 RID: 8040
		public const int SuccessFieldNumber = 4;

		// Token: 0x04001F69 RID: 8041
		private bool success_;

		// Token: 0x04001F6A RID: 8042
		public const int RewardItemsFieldNumber = 5;

		// Token: 0x04001F6B RID: 8043
		private static readonly FieldCodec<RewardItem> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItem>(42U, RewardItem.Parser);

		// Token: 0x04001F6C RID: 8044
		private readonly RepeatedField<RewardItem> rewardItems_ = new RepeatedField<RewardItem>();

		// Token: 0x04001F6D RID: 8045
		public const int LikeRecordFieldNumber = 6;

		// Token: 0x04001F6E RID: 8046
		private static readonly FieldCodec<AbyssLikeRecord> _repeated_likeRecord_codec = FieldCodec.ForMessage<AbyssLikeRecord>(50U, AbyssLikeRecord.Parser);

		// Token: 0x04001F6F RID: 8047
		private readonly RepeatedField<AbyssLikeRecord> likeRecord_ = new RepeatedField<AbyssLikeRecord>();
	}
}
