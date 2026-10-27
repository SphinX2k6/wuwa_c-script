using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000884 RID: 2180
	public sealed class KujiAwardGroupPb : IMessage<KujiAwardGroupPb>, IMessage, IEquatable<KujiAwardGroupPb>, IDeepCloneable<KujiAwardGroupPb>, IBufferMessage
	{
		// Token: 0x0600C206 RID: 49670 RVA: 0x001CCC8C File Offset: 0x001CAE8C
		[NullableContext(1)]
		public static KujiAwardGroupPb Create()
		{
			return new KujiAwardGroupPb();
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x0600C207 RID: 49671 RVA: 0x001CCC93 File Offset: 0x001CAE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KujiAwardGroupPb> Parser
		{
			get
			{
				return KujiAwardGroupPb._parser;
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x0600C208 RID: 49672 RVA: 0x001CCC9A File Offset: 0x001CAE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x0600C209 RID: 49673 RVA: 0x001CCC9D File Offset: 0x001CAE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KujiAwardGroupPb.Descriptor;
			}
		}

		// Token: 0x0600C20A RID: 49674 RVA: 0x001CCCA4 File Offset: 0x001CAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KujiAwardGroupPb()
		{
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x001CCCB8 File Offset: 0x001CAEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KujiAwardGroupPb(KujiAwardGroupPb other) : this()
		{
			this.id_ = other.id_;
			this.groupRank_ = other.groupRank_;
			this.rewardedAmount_ = other.rewardedAmount_;
			this.allAmount_ = other.allAmount_;
			this.preItemMap_ = other.preItemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C20C RID: 49676 RVA: 0x001CCD1D File Offset: 0x001CAF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KujiAwardGroupPb Clone()
		{
			return new KujiAwardGroupPb(this);
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x0600C20D RID: 49677 RVA: 0x001CCD25 File Offset: 0x001CAF25
		// (set) Token: 0x0600C20E RID: 49678 RVA: 0x001CCD2D File Offset: 0x001CAF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x0600C20F RID: 49679 RVA: 0x001CCD36 File Offset: 0x001CAF36
		// (set) Token: 0x0600C210 RID: 49680 RVA: 0x001CCD3E File Offset: 0x001CAF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupRank
		{
			get
			{
				return this.groupRank_;
			}
			set
			{
				this.groupRank_ = value;
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x0600C211 RID: 49681 RVA: 0x001CCD47 File Offset: 0x001CAF47
		// (set) Token: 0x0600C212 RID: 49682 RVA: 0x001CCD4F File Offset: 0x001CAF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardedAmount
		{
			get
			{
				return this.rewardedAmount_;
			}
			set
			{
				this.rewardedAmount_ = value;
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x0600C213 RID: 49683 RVA: 0x001CCD58 File Offset: 0x001CAF58
		// (set) Token: 0x0600C214 RID: 49684 RVA: 0x001CCD60 File Offset: 0x001CAF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AllAmount
		{
			get
			{
				return this.allAmount_;
			}
			set
			{
				this.allAmount_ = value;
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x0600C215 RID: 49685 RVA: 0x001CCD69 File Offset: 0x001CAF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PreItemMap
		{
			get
			{
				return this.preItemMap_;
			}
		}

		// Token: 0x0600C216 RID: 49686 RVA: 0x001CCD71 File Offset: 0x001CAF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KujiAwardGroupPb);
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x001CCD80 File Offset: 0x001CAF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KujiAwardGroupPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.GroupRank == other.GroupRank && this.RewardedAmount == other.RewardedAmount && this.AllAmount == other.AllAmount && this.PreItemMap.Equals(other.PreItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C218 RID: 49688 RVA: 0x001CCE00 File Offset: 0x001CB000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GroupRank != 0)
			{
				num ^= this.GroupRank.GetHashCode();
			}
			if (this.RewardedAmount != 0)
			{
				num ^= this.RewardedAmount.GetHashCode();
			}
			if (this.AllAmount != 0)
			{
				num ^= this.AllAmount.GetHashCode();
			}
			num ^= this.PreItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x001CCE98 File Offset: 0x001CB098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x001CCEA5 File Offset: 0x001CB0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x001CCEB0 File Offset: 0x001CB0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.GroupRank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupRank);
			}
			if (this.RewardedAmount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardedAmount);
			}
			if (this.AllAmount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AllAmount);
			}
			this.preItemMap_.WriteTo(ref output, KujiAwardGroupPb._map_preItemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x001CCF54 File Offset: 0x001CB154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.GroupRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupRank);
			}
			if (this.RewardedAmount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardedAmount);
			}
			if (this.AllAmount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AllAmount);
			}
			num += this.preItemMap_.CalculateSize(KujiAwardGroupPb._map_preItemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C21D RID: 49693 RVA: 0x001CCFF0 File Offset: 0x001CB1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KujiAwardGroupPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.GroupRank != 0)
			{
				this.GroupRank = other.GroupRank;
			}
			if (other.RewardedAmount != 0)
			{
				this.RewardedAmount = other.RewardedAmount;
			}
			if (other.AllAmount != 0)
			{
				this.AllAmount = other.AllAmount;
			}
			this.preItemMap_.MergeFrom(other.preItemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C21E RID: 49694 RVA: 0x001CD079 File Offset: 0x001CB279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C21F RID: 49695 RVA: 0x001CD084 File Offset: 0x001CB284
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.GroupRank = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RewardedAmount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.AllAmount = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.preItemMap_.AddEntriesFrom(ref input, KujiAwardGroupPb._map_preItemMap_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005410 RID: 21520
		private static readonly MessageParser<KujiAwardGroupPb> _parser = new MessageParser<KujiAwardGroupPb>(() => new KujiAwardGroupPb());

		// Token: 0x04005411 RID: 21521
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005412 RID: 21522
		public const int IdFieldNumber = 1;

		// Token: 0x04005413 RID: 21523
		private int id_;

		// Token: 0x04005414 RID: 21524
		public const int GroupRankFieldNumber = 2;

		// Token: 0x04005415 RID: 21525
		private int groupRank_;

		// Token: 0x04005416 RID: 21526
		public const int RewardedAmountFieldNumber = 3;

		// Token: 0x04005417 RID: 21527
		private int rewardedAmount_;

		// Token: 0x04005418 RID: 21528
		public const int AllAmountFieldNumber = 4;

		// Token: 0x04005419 RID: 21529
		private int allAmount_;

		// Token: 0x0400541A RID: 21530
		public const int PreItemMapFieldNumber = 5;

		// Token: 0x0400541B RID: 21531
		private static readonly MapField<int, int>.Codec _map_preItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x0400541C RID: 21532
		private readonly MapField<int, int> preItemMap_ = new MapField<int, int>();
	}
}
