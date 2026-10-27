using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000888 RID: 2184
	[NetMessage(EMessageId.KurotatoChestRewardNotify)]
	public sealed class KurotatoChestRewardNotify : IMessage<KurotatoChestRewardNotify>, IMessage, IEquatable<KurotatoChestRewardNotify>, IDeepCloneable<KurotatoChestRewardNotify>, IBufferMessage
	{
		// Token: 0x0600C25B RID: 49755 RVA: 0x001CDAE6 File Offset: 0x001CBCE6
		[NullableContext(1)]
		public static KurotatoChestRewardNotify Create()
		{
			return new KurotatoChestRewardNotify();
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x0600C25C RID: 49756 RVA: 0x001CDAED File Offset: 0x001CBCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x0600C25D RID: 49757 RVA: 0x001CDAF0 File Offset: 0x001CBCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoChestRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600C25E RID: 49758 RVA: 0x001CDAF7 File Offset: 0x001CBCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardNotify()
		{
		}

		// Token: 0x0600C25F RID: 49759 RVA: 0x001CDB00 File Offset: 0x001CBD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardNotify(KurotatoChestRewardNotify other) : this()
		{
			this.itemId_ = other.itemId_;
			this.soldPrice_ = other.soldPrice_;
			this.rewardIndex_ = other.rewardIndex_;
			this.totalRewardCount_ = other.totalRewardCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C260 RID: 49760 RVA: 0x001CDB54 File Offset: 0x001CBD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardNotify Clone()
		{
			return new KurotatoChestRewardNotify(this);
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x0600C261 RID: 49761 RVA: 0x001CDB5C File Offset: 0x001CBD5C
		// (set) Token: 0x0600C262 RID: 49762 RVA: 0x001CDB64 File Offset: 0x001CBD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x0600C263 RID: 49763 RVA: 0x001CDB6D File Offset: 0x001CBD6D
		// (set) Token: 0x0600C264 RID: 49764 RVA: 0x001CDB75 File Offset: 0x001CBD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SoldPrice
		{
			get
			{
				return this.soldPrice_;
			}
			set
			{
				this.soldPrice_ = value;
			}
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x0600C265 RID: 49765 RVA: 0x001CDB7E File Offset: 0x001CBD7E
		// (set) Token: 0x0600C266 RID: 49766 RVA: 0x001CDB86 File Offset: 0x001CBD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardIndex
		{
			get
			{
				return this.rewardIndex_;
			}
			set
			{
				this.rewardIndex_ = value;
			}
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x0600C267 RID: 49767 RVA: 0x001CDB8F File Offset: 0x001CBD8F
		// (set) Token: 0x0600C268 RID: 49768 RVA: 0x001CDB97 File Offset: 0x001CBD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalRewardCount
		{
			get
			{
				return this.totalRewardCount_;
			}
			set
			{
				this.totalRewardCount_ = value;
			}
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x001CDBA0 File Offset: 0x001CBDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoChestRewardNotify);
		}

		// Token: 0x0600C26A RID: 49770 RVA: 0x001CDBB0 File Offset: 0x001CBDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoChestRewardNotify other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.SoldPrice == other.SoldPrice && this.RewardIndex == other.RewardIndex && this.TotalRewardCount == other.TotalRewardCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C26B RID: 49771 RVA: 0x001CDC1C File Offset: 0x001CBE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.SoldPrice != 0)
			{
				num ^= this.SoldPrice.GetHashCode();
			}
			if (this.RewardIndex != 0)
			{
				num ^= this.RewardIndex.GetHashCode();
			}
			if (this.TotalRewardCount != 0)
			{
				num ^= this.TotalRewardCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C26C RID: 49772 RVA: 0x001CDCA6 File Offset: 0x001CBEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C26D RID: 49773 RVA: 0x001CDCB3 File Offset: 0x001CBEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C26E RID: 49774 RVA: 0x001CDCBC File Offset: 0x001CBEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.RewardIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RewardIndex);
			}
			if (this.TotalRewardCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TotalRewardCount);
			}
			if (this.SoldPrice != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SoldPrice);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C26F RID: 49775 RVA: 0x001CDD50 File Offset: 0x001CBF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.SoldPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SoldPrice);
			}
			if (this.RewardIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardIndex);
			}
			if (this.TotalRewardCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalRewardCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x001CDDD8 File Offset: 0x001CBFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoChestRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.SoldPrice != 0)
			{
				this.SoldPrice = other.SoldPrice;
			}
			if (other.RewardIndex != 0)
			{
				this.RewardIndex = other.RewardIndex;
			}
			if (other.TotalRewardCount != 0)
			{
				this.TotalRewardCount = other.TotalRewardCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x001CDE50 File Offset: 0x001CC050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C272 RID: 49778 RVA: 0x001CDE5C File Offset: 0x001CC05C
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
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.RewardIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.TotalRewardCount = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.SoldPrice = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005437 RID: 21559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005438 RID: 21560
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04005439 RID: 21561
		private int itemId_;

		// Token: 0x0400543A RID: 21562
		public const int SoldPriceFieldNumber = 11;

		// Token: 0x0400543B RID: 21563
		private int soldPrice_;

		// Token: 0x0400543C RID: 21564
		public const int RewardIndexFieldNumber = 7;

		// Token: 0x0400543D RID: 21565
		private int rewardIndex_;

		// Token: 0x0400543E RID: 21566
		public const int TotalRewardCountFieldNumber = 8;

		// Token: 0x0400543F RID: 21567
		private int totalRewardCount_;
	}
}
