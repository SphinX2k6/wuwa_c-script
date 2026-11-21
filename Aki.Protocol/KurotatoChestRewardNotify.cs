using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000877 RID: 2167
	[NetMessage(EMessageId.KurotatoChestRewardNotify)]
	public sealed class KurotatoChestRewardNotify : IMessage<KurotatoChestRewardNotify>, IMessage, IEquatable<KurotatoChestRewardNotify>, IDeepCloneable<KurotatoChestRewardNotify>, IBufferMessage
	{
		// Token: 0x0600C13F RID: 49471 RVA: 0x001CB7FE File Offset: 0x001C99FE
		[NullableContext(1)]
		public static KurotatoChestRewardNotify Create()
		{
			return new KurotatoChestRewardNotify();
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x0600C140 RID: 49472 RVA: 0x001CB805 File Offset: 0x001C9A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x0600C141 RID: 49473 RVA: 0x001CB808 File Offset: 0x001C9A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoChestRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x001CB80F File Offset: 0x001C9A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardNotify()
		{
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x001CB818 File Offset: 0x001C9A18
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

		// Token: 0x0600C144 RID: 49476 RVA: 0x001CB86C File Offset: 0x001C9A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardNotify Clone()
		{
			return new KurotatoChestRewardNotify(this);
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x0600C145 RID: 49477 RVA: 0x001CB874 File Offset: 0x001C9A74
		// (set) Token: 0x0600C146 RID: 49478 RVA: 0x001CB87C File Offset: 0x001C9A7C
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

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x0600C147 RID: 49479 RVA: 0x001CB885 File Offset: 0x001C9A85
		// (set) Token: 0x0600C148 RID: 49480 RVA: 0x001CB88D File Offset: 0x001C9A8D
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

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x0600C149 RID: 49481 RVA: 0x001CB896 File Offset: 0x001C9A96
		// (set) Token: 0x0600C14A RID: 49482 RVA: 0x001CB89E File Offset: 0x001C9A9E
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

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x0600C14B RID: 49483 RVA: 0x001CB8A7 File Offset: 0x001C9AA7
		// (set) Token: 0x0600C14C RID: 49484 RVA: 0x001CB8AF File Offset: 0x001C9AAF
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

		// Token: 0x0600C14D RID: 49485 RVA: 0x001CB8B8 File Offset: 0x001C9AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoChestRewardNotify);
		}

		// Token: 0x0600C14E RID: 49486 RVA: 0x001CB8C8 File Offset: 0x001C9AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoChestRewardNotify other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.SoldPrice == other.SoldPrice && this.RewardIndex == other.RewardIndex && this.TotalRewardCount == other.TotalRewardCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C14F RID: 49487 RVA: 0x001CB934 File Offset: 0x001C9B34
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

		// Token: 0x0600C150 RID: 49488 RVA: 0x001CB9BE File Offset: 0x001C9BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C151 RID: 49489 RVA: 0x001CB9CB File Offset: 0x001C9BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C152 RID: 49490 RVA: 0x001CB9D4 File Offset: 0x001C9BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this.RewardIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RewardIndex);
			}
			if (this.SoldPrice != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SoldPrice);
			}
			if (this.TotalRewardCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TotalRewardCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x001CBA68 File Offset: 0x001C9C68
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

		// Token: 0x0600C154 RID: 49492 RVA: 0x001CBAF0 File Offset: 0x001C9CF0
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

		// Token: 0x0600C155 RID: 49493 RVA: 0x001CBB68 File Offset: 0x001C9D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C156 RID: 49494 RVA: 0x001CBB74 File Offset: 0x001C9D74
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
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.RewardIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.SoldPrice = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.TotalRewardCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400543E RID: 21566
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400543F RID: 21567
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04005440 RID: 21568
		private int itemId_;

		// Token: 0x04005441 RID: 21569
		public const int SoldPriceFieldNumber = 10;

		// Token: 0x04005442 RID: 21570
		private int soldPrice_;

		// Token: 0x04005443 RID: 21571
		public const int RewardIndexFieldNumber = 6;

		// Token: 0x04005444 RID: 21572
		private int rewardIndex_;

		// Token: 0x04005445 RID: 21573
		public const int TotalRewardCountFieldNumber = 14;

		// Token: 0x04005446 RID: 21574
		private int totalRewardCount_;
	}
}
