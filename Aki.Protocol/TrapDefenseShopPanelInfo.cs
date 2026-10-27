using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001448 RID: 5192
	public sealed class TrapDefenseShopPanelInfo : IMessage<TrapDefenseShopPanelInfo>, IMessage, IEquatable<TrapDefenseShopPanelInfo>, IDeepCloneable<TrapDefenseShopPanelInfo>, IBufferMessage
	{
		// Token: 0x0601B7F4 RID: 112628 RVA: 0x003FB0AF File Offset: 0x003F92AF
		[NullableContext(1)]
		public static TrapDefenseShopPanelInfo Create()
		{
			return new TrapDefenseShopPanelInfo();
		}

		// Token: 0x17005CB6 RID: 23734
		// (get) Token: 0x0601B7F5 RID: 112629 RVA: 0x003FB0B6 File Offset: 0x003F92B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CB7 RID: 23735
		// (get) Token: 0x0601B7F6 RID: 112630 RVA: 0x003FB0B9 File Offset: 0x003F92B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseShopPanelInfo.Descriptor;
			}
		}

		// Token: 0x0601B7F7 RID: 112631 RVA: 0x003FB0C0 File Offset: 0x003F92C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopPanelInfo()
		{
		}

		// Token: 0x0601B7F8 RID: 112632 RVA: 0x003FB0D4 File Offset: 0x003F92D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopPanelInfo(TrapDefenseShopPanelInfo other) : this()
		{
			this.remainRefreshTimes_ = other.remainRefreshTimes_;
			this.totalRefreshTimes_ = other.totalRefreshTimes_;
			this.refreshCost_ = other.refreshCost_;
			this.shopProductPbInfos_ = other.shopProductPbInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7F9 RID: 112633 RVA: 0x003FB12D File Offset: 0x003F932D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopPanelInfo Clone()
		{
			return new TrapDefenseShopPanelInfo(this);
		}

		// Token: 0x17005CB8 RID: 23736
		// (get) Token: 0x0601B7FA RID: 112634 RVA: 0x003FB135 File Offset: 0x003F9335
		// (set) Token: 0x0601B7FB RID: 112635 RVA: 0x003FB13D File Offset: 0x003F933D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainRefreshTimes
		{
			get
			{
				return this.remainRefreshTimes_;
			}
			set
			{
				this.remainRefreshTimes_ = value;
			}
		}

		// Token: 0x17005CB9 RID: 23737
		// (get) Token: 0x0601B7FC RID: 112636 RVA: 0x003FB146 File Offset: 0x003F9346
		// (set) Token: 0x0601B7FD RID: 112637 RVA: 0x003FB14E File Offset: 0x003F934E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalRefreshTimes
		{
			get
			{
				return this.totalRefreshTimes_;
			}
			set
			{
				this.totalRefreshTimes_ = value;
			}
		}

		// Token: 0x17005CBA RID: 23738
		// (get) Token: 0x0601B7FE RID: 112638 RVA: 0x003FB157 File Offset: 0x003F9357
		// (set) Token: 0x0601B7FF RID: 112639 RVA: 0x003FB15F File Offset: 0x003F935F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCost
		{
			get
			{
				return this.refreshCost_;
			}
			set
			{
				this.refreshCost_ = value;
			}
		}

		// Token: 0x17005CBB RID: 23739
		// (get) Token: 0x0601B800 RID: 112640 RVA: 0x003FB168 File Offset: 0x003F9368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseShopProductPbInfo> ShopProductPbInfos
		{
			get
			{
				return this.shopProductPbInfos_;
			}
		}

		// Token: 0x0601B801 RID: 112641 RVA: 0x003FB170 File Offset: 0x003F9370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseShopPanelInfo);
		}

		// Token: 0x0601B802 RID: 112642 RVA: 0x003FB180 File Offset: 0x003F9380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseShopPanelInfo other)
		{
			return other != null && (other == this || (this.RemainRefreshTimes == other.RemainRefreshTimes && this.TotalRefreshTimes == other.TotalRefreshTimes && this.RefreshCost == other.RefreshCost && this.shopProductPbInfos_.Equals(other.shopProductPbInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B803 RID: 112643 RVA: 0x003FB1F0 File Offset: 0x003F93F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RemainRefreshTimes != 0)
			{
				num ^= this.RemainRefreshTimes.GetHashCode();
			}
			if (this.TotalRefreshTimes != 0)
			{
				num ^= this.TotalRefreshTimes.GetHashCode();
			}
			if (this.RefreshCost != 0)
			{
				num ^= this.RefreshCost.GetHashCode();
			}
			num ^= this.shopProductPbInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B804 RID: 112644 RVA: 0x003FB26F File Offset: 0x003F946F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B805 RID: 112645 RVA: 0x003FB27C File Offset: 0x003F947C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B806 RID: 112646 RVA: 0x003FB288 File Offset: 0x003F9488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RemainRefreshTimes != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RemainRefreshTimes);
			}
			if (this.TotalRefreshTimes != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalRefreshTimes);
			}
			if (this.RefreshCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RefreshCost);
			}
			this.shopProductPbInfos_.WriteTo(ref output, TrapDefenseShopPanelInfo._repeated_shopProductPbInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B807 RID: 112647 RVA: 0x003FB310 File Offset: 0x003F9510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RemainRefreshTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainRefreshTimes);
			}
			if (this.TotalRefreshTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalRefreshTimes);
			}
			if (this.RefreshCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCost);
			}
			num += this.shopProductPbInfos_.CalculateSize(TrapDefenseShopPanelInfo._repeated_shopProductPbInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B808 RID: 112648 RVA: 0x003FB394 File Offset: 0x003F9594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseShopPanelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RemainRefreshTimes != 0)
			{
				this.RemainRefreshTimes = other.RemainRefreshTimes;
			}
			if (other.TotalRefreshTimes != 0)
			{
				this.TotalRefreshTimes = other.TotalRefreshTimes;
			}
			if (other.RefreshCost != 0)
			{
				this.RefreshCost = other.RefreshCost;
			}
			this.shopProductPbInfos_.Add(other.shopProductPbInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B809 RID: 112649 RVA: 0x003FB409 File Offset: 0x003F9609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B80A RID: 112650 RVA: 0x003FB414 File Offset: 0x003F9614
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
						this.RemainRefreshTimes = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TotalRefreshTimes = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RefreshCost = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.shopProductPbInfos_.AddEntriesFrom(ref input, TrapDefenseShopPanelInfo._repeated_shopProductPbInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009E9A RID: 40602
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E9B RID: 40603
		public const int RemainRefreshTimesFieldNumber = 1;

		// Token: 0x04009E9C RID: 40604
		private int remainRefreshTimes_;

		// Token: 0x04009E9D RID: 40605
		public const int TotalRefreshTimesFieldNumber = 2;

		// Token: 0x04009E9E RID: 40606
		private int totalRefreshTimes_;

		// Token: 0x04009E9F RID: 40607
		public const int RefreshCostFieldNumber = 3;

		// Token: 0x04009EA0 RID: 40608
		private int refreshCost_;

		// Token: 0x04009EA1 RID: 40609
		public const int ShopProductPbInfosFieldNumber = 4;

		// Token: 0x04009EA2 RID: 40610
		private static readonly FieldCodec<TrapDefenseShopProductPbInfo> _repeated_shopProductPbInfos_codec = FieldCodec.ForMessage<TrapDefenseShopProductPbInfo>(34U, TrapDefenseShopProductPbInfo.Parser);

		// Token: 0x04009EA3 RID: 40611
		private readonly RepeatedField<TrapDefenseShopProductPbInfo> shopProductPbInfos_ = new RepeatedField<TrapDefenseShopProductPbInfo>();
	}
}
