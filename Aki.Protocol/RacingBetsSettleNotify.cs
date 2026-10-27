using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E77 RID: 3703
	[NetMessage(EMessageId.RacingBetsSettleNotify)]
	public sealed class RacingBetsSettleNotify : IMessage<RacingBetsSettleNotify>, IMessage, IEquatable<RacingBetsSettleNotify>, IDeepCloneable<RacingBetsSettleNotify>, IBufferMessage
	{
		// Token: 0x06013E3F RID: 81471 RVA: 0x002E57D7 File Offset: 0x002E39D7
		[NullableContext(1)]
		public static RacingBetsSettleNotify Create()
		{
			return new RacingBetsSettleNotify();
		}

		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x06013E40 RID: 81472 RVA: 0x002E57DE File Offset: 0x002E39DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x06013E41 RID: 81473 RVA: 0x002E57E1 File Offset: 0x002E39E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsSettleNotify.Descriptor;
			}
		}

		// Token: 0x06013E42 RID: 81474 RVA: 0x002E57E8 File Offset: 0x002E39E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsSettleNotify()
		{
		}

		// Token: 0x06013E43 RID: 81475 RVA: 0x002E57FC File Offset: 0x002E39FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsSettleNotify(RacingBetsSettleNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.dangoRank_ = other.dangoRank_.Clone();
			this.selfOddsDangoId_ = other.selfOddsDangoId_;
			this.rewardFunds_ = other.rewardFunds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E44 RID: 81476 RVA: 0x002E5861 File Offset: 0x002E3A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsSettleNotify Clone()
		{
			return new RacingBetsSettleNotify(this);
		}

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x06013E45 RID: 81477 RVA: 0x002E5869 File Offset: 0x002E3A69
		// (set) Token: 0x06013E46 RID: 81478 RVA: 0x002E5871 File Offset: 0x002E3A71
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

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x06013E47 RID: 81479 RVA: 0x002E587A File Offset: 0x002E3A7A
		// (set) Token: 0x06013E48 RID: 81480 RVA: 0x002E5882 File Offset: 0x002E3A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x06013E49 RID: 81481 RVA: 0x002E588B File Offset: 0x002E3A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoRank
		{
			get
			{
				return this.dangoRank_;
			}
		}

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x06013E4A RID: 81482 RVA: 0x002E5893 File Offset: 0x002E3A93
		// (set) Token: 0x06013E4B RID: 81483 RVA: 0x002E589B File Offset: 0x002E3A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelfOddsDangoId
		{
			get
			{
				return this.selfOddsDangoId_;
			}
			set
			{
				this.selfOddsDangoId_ = value;
			}
		}

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x06013E4C RID: 81484 RVA: 0x002E58A4 File Offset: 0x002E3AA4
		// (set) Token: 0x06013E4D RID: 81485 RVA: 0x002E58AC File Offset: 0x002E3AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardFunds
		{
			get
			{
				return this.rewardFunds_;
			}
			set
			{
				this.rewardFunds_ = value;
			}
		}

		// Token: 0x06013E4E RID: 81486 RVA: 0x002E58B5 File Offset: 0x002E3AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsSettleNotify);
		}

		// Token: 0x06013E4F RID: 81487 RVA: 0x002E58C4 File Offset: 0x002E3AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsSettleNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.dangoRank_.Equals(other.dangoRank_) && this.SelfOddsDangoId == other.SelfOddsDangoId && this.RewardFunds == other.RewardFunds && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E50 RID: 81488 RVA: 0x002E5944 File Offset: 0x002E3B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			num ^= this.dangoRank_.GetHashCode();
			if (this.SelfOddsDangoId != 0)
			{
				num ^= this.SelfOddsDangoId.GetHashCode();
			}
			if (this.RewardFunds != 0)
			{
				num ^= this.RewardFunds.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013E51 RID: 81489 RVA: 0x002E59DC File Offset: 0x002E3BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E52 RID: 81490 RVA: 0x002E59E9 File Offset: 0x002E3BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E53 RID: 81491 RVA: 0x002E59F4 File Offset: 0x002E3BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelfOddsDangoId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SelfOddsDangoId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RewardFunds != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RewardFunds);
			}
			this.dangoRank_.WriteTo(ref output, RacingBetsSettleNotify._repeated_dangoRank_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E54 RID: 81492 RVA: 0x002E5A98 File Offset: 0x002E3C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			num += this.dangoRank_.CalculateSize(RacingBetsSettleNotify._repeated_dangoRank_codec);
			if (this.SelfOddsDangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelfOddsDangoId);
			}
			if (this.RewardFunds != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardFunds);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013E55 RID: 81493 RVA: 0x002E5B34 File Offset: 0x002E3D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this.dangoRank_.Add(other.dangoRank_);
			if (other.SelfOddsDangoId != 0)
			{
				this.SelfOddsDangoId = other.SelfOddsDangoId;
			}
			if (other.RewardFunds != 0)
			{
				this.RewardFunds = other.RewardFunds;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013E56 RID: 81494 RVA: 0x002E5BBD File Offset: 0x002E3DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E57 RID: 81495 RVA: 0x002E5BC8 File Offset: 0x002E3DC8
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
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.SelfOddsDangoId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.RewardFunds = input.ReadInt32();
						continue;
					}
					if (num == 64U || num == 66U)
					{
						this.dangoRank_.AddEntriesFrom(ref input, RacingBetsSettleNotify._repeated_dangoRank_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400799A RID: 31130
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400799B RID: 31131
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x0400799C RID: 31132
		private int activityId_;

		// Token: 0x0400799D RID: 31133
		public const int LegMatchIdFieldNumber = 3;

		// Token: 0x0400799E RID: 31134
		private int legMatchId_;

		// Token: 0x0400799F RID: 31135
		public const int DangoRankFieldNumber = 8;

		// Token: 0x040079A0 RID: 31136
		private static readonly FieldCodec<int> _repeated_dangoRank_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040079A1 RID: 31137
		private readonly RepeatedField<int> dangoRank_ = new RepeatedField<int>();

		// Token: 0x040079A2 RID: 31138
		public const int SelfOddsDangoIdFieldNumber = 2;

		// Token: 0x040079A3 RID: 31139
		private int selfOddsDangoId_;

		// Token: 0x040079A4 RID: 31140
		public const int RewardFundsFieldNumber = 7;

		// Token: 0x040079A5 RID: 31141
		private int rewardFunds_;
	}
}
