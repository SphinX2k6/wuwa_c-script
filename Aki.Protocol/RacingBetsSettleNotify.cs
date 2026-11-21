using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E67 RID: 3687
	[NetMessage(EMessageId.RacingBetsSettleNotify)]
	public sealed class RacingBetsSettleNotify : IMessage<RacingBetsSettleNotify>, IMessage, IEquatable<RacingBetsSettleNotify>, IDeepCloneable<RacingBetsSettleNotify>, IBufferMessage
	{
		// Token: 0x06013D5A RID: 81242 RVA: 0x002E4117 File Offset: 0x002E2317
		[NullableContext(1)]
		public static RacingBetsSettleNotify Create()
		{
			return new RacingBetsSettleNotify();
		}

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x06013D5B RID: 81243 RVA: 0x002E411E File Offset: 0x002E231E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x06013D5C RID: 81244 RVA: 0x002E4121 File Offset: 0x002E2321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsSettleNotify.Descriptor;
			}
		}

		// Token: 0x06013D5D RID: 81245 RVA: 0x002E4128 File Offset: 0x002E2328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsSettleNotify()
		{
		}

		// Token: 0x06013D5E RID: 81246 RVA: 0x002E413C File Offset: 0x002E233C
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

		// Token: 0x06013D5F RID: 81247 RVA: 0x002E41A1 File Offset: 0x002E23A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsSettleNotify Clone()
		{
			return new RacingBetsSettleNotify(this);
		}

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x06013D60 RID: 81248 RVA: 0x002E41A9 File Offset: 0x002E23A9
		// (set) Token: 0x06013D61 RID: 81249 RVA: 0x002E41B1 File Offset: 0x002E23B1
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

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x06013D62 RID: 81250 RVA: 0x002E41BA File Offset: 0x002E23BA
		// (set) Token: 0x06013D63 RID: 81251 RVA: 0x002E41C2 File Offset: 0x002E23C2
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

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x06013D64 RID: 81252 RVA: 0x002E41CB File Offset: 0x002E23CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoRank
		{
			get
			{
				return this.dangoRank_;
			}
		}

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x06013D65 RID: 81253 RVA: 0x002E41D3 File Offset: 0x002E23D3
		// (set) Token: 0x06013D66 RID: 81254 RVA: 0x002E41DB File Offset: 0x002E23DB
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

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x06013D67 RID: 81255 RVA: 0x002E41E4 File Offset: 0x002E23E4
		// (set) Token: 0x06013D68 RID: 81256 RVA: 0x002E41EC File Offset: 0x002E23EC
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

		// Token: 0x06013D69 RID: 81257 RVA: 0x002E41F5 File Offset: 0x002E23F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsSettleNotify);
		}

		// Token: 0x06013D6A RID: 81258 RVA: 0x002E4204 File Offset: 0x002E2404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsSettleNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.dangoRank_.Equals(other.dangoRank_) && this.SelfOddsDangoId == other.SelfOddsDangoId && this.RewardFunds == other.RewardFunds && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D6B RID: 81259 RVA: 0x002E4284 File Offset: 0x002E2484
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

		// Token: 0x06013D6C RID: 81260 RVA: 0x002E431C File Offset: 0x002E251C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D6D RID: 81261 RVA: 0x002E4329 File Offset: 0x002E2529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D6E RID: 81262 RVA: 0x002E4334 File Offset: 0x002E2534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.SelfOddsDangoId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SelfOddsDangoId);
			}
			if (this.RewardFunds != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RewardFunds);
			}
			this.dangoRank_.WriteTo(ref output, RacingBetsSettleNotify._repeated_dangoRank_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D6F RID: 81263 RVA: 0x002E43D8 File Offset: 0x002E25D8
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

		// Token: 0x06013D70 RID: 81264 RVA: 0x002E4474 File Offset: 0x002E2674
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

		// Token: 0x06013D71 RID: 81265 RVA: 0x002E44FD File Offset: 0x002E26FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D72 RID: 81266 RVA: 0x002E4508 File Offset: 0x002E2708
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
				if (num <= 80U)
				{
					if (num == 16U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.SelfOddsDangoId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.RewardFunds = input.ReadInt32();
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.dangoRank_.AddEntriesFrom(ref input, RacingBetsSettleNotify._repeated_dangoRank_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040079C4 RID: 31172
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079C5 RID: 31173
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x040079C6 RID: 31174
		private int activityId_;

		// Token: 0x040079C7 RID: 31175
		public const int LegMatchIdFieldNumber = 9;

		// Token: 0x040079C8 RID: 31176
		private int legMatchId_;

		// Token: 0x040079C9 RID: 31177
		public const int DangoRankFieldNumber = 14;

		// Token: 0x040079CA RID: 31178
		private static readonly FieldCodec<int> _repeated_dangoRank_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040079CB RID: 31179
		private readonly RepeatedField<int> dangoRank_ = new RepeatedField<int>();

		// Token: 0x040079CC RID: 31180
		public const int SelfOddsDangoIdFieldNumber = 10;

		// Token: 0x040079CD RID: 31181
		private int selfOddsDangoId_;

		// Token: 0x040079CE RID: 31182
		public const int RewardFundsFieldNumber = 13;

		// Token: 0x040079CF RID: 31183
		private int rewardFunds_;
	}
}
