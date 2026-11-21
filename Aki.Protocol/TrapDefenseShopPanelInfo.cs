using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BB RID: 5307
	public sealed class TrapDefenseShopPanelInfo : IMessage<TrapDefenseShopPanelInfo>, IMessage, IEquatable<TrapDefenseShopPanelInfo>, IDeepCloneable<TrapDefenseShopPanelInfo>, IBufferMessage
	{
		// Token: 0x0601C27F RID: 115327 RVA: 0x00416383 File Offset: 0x00414583
		[NullableContext(1)]
		public static TrapDefenseShopPanelInfo Create()
		{
			return new TrapDefenseShopPanelInfo();
		}

		// Token: 0x17005F4B RID: 24395
		// (get) Token: 0x0601C280 RID: 115328 RVA: 0x0041638A File Offset: 0x0041458A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F4C RID: 24396
		// (get) Token: 0x0601C281 RID: 115329 RVA: 0x0041638D File Offset: 0x0041458D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseShopPanelInfo.Descriptor;
			}
		}

		// Token: 0x0601C282 RID: 115330 RVA: 0x00416394 File Offset: 0x00414594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopPanelInfo()
		{
		}

		// Token: 0x0601C283 RID: 115331 RVA: 0x004163A8 File Offset: 0x004145A8
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

		// Token: 0x0601C284 RID: 115332 RVA: 0x00416401 File Offset: 0x00414601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopPanelInfo Clone()
		{
			return new TrapDefenseShopPanelInfo(this);
		}

		// Token: 0x17005F4D RID: 24397
		// (get) Token: 0x0601C285 RID: 115333 RVA: 0x00416409 File Offset: 0x00414609
		// (set) Token: 0x0601C286 RID: 115334 RVA: 0x00416411 File Offset: 0x00414611
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

		// Token: 0x17005F4E RID: 24398
		// (get) Token: 0x0601C287 RID: 115335 RVA: 0x0041641A File Offset: 0x0041461A
		// (set) Token: 0x0601C288 RID: 115336 RVA: 0x00416422 File Offset: 0x00414622
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

		// Token: 0x17005F4F RID: 24399
		// (get) Token: 0x0601C289 RID: 115337 RVA: 0x0041642B File Offset: 0x0041462B
		// (set) Token: 0x0601C28A RID: 115338 RVA: 0x00416433 File Offset: 0x00414633
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

		// Token: 0x17005F50 RID: 24400
		// (get) Token: 0x0601C28B RID: 115339 RVA: 0x0041643C File Offset: 0x0041463C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseShopProductPbInfo> ShopProductPbInfos
		{
			get
			{
				return this.shopProductPbInfos_;
			}
		}

		// Token: 0x0601C28C RID: 115340 RVA: 0x00416444 File Offset: 0x00414644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseShopPanelInfo);
		}

		// Token: 0x0601C28D RID: 115341 RVA: 0x00416454 File Offset: 0x00414654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseShopPanelInfo other)
		{
			return other != null && (other == this || (this.RemainRefreshTimes == other.RemainRefreshTimes && this.TotalRefreshTimes == other.TotalRefreshTimes && this.RefreshCost == other.RefreshCost && this.shopProductPbInfos_.Equals(other.shopProductPbInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C28E RID: 115342 RVA: 0x004164C4 File Offset: 0x004146C4
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

		// Token: 0x0601C28F RID: 115343 RVA: 0x00416543 File Offset: 0x00414743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C290 RID: 115344 RVA: 0x00416550 File Offset: 0x00414750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C291 RID: 115345 RVA: 0x0041655C File Offset: 0x0041475C
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

		// Token: 0x0601C292 RID: 115346 RVA: 0x004165E4 File Offset: 0x004147E4
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

		// Token: 0x0601C293 RID: 115347 RVA: 0x00416668 File Offset: 0x00414868
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

		// Token: 0x0601C294 RID: 115348 RVA: 0x004166DD File Offset: 0x004148DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C295 RID: 115349 RVA: 0x004166E8 File Offset: 0x004148E8
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

		// Token: 0x0400A2E1 RID: 41697
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2E2 RID: 41698
		public const int RemainRefreshTimesFieldNumber = 1;

		// Token: 0x0400A2E3 RID: 41699
		private int remainRefreshTimes_;

		// Token: 0x0400A2E4 RID: 41700
		public const int TotalRefreshTimesFieldNumber = 2;

		// Token: 0x0400A2E5 RID: 41701
		private int totalRefreshTimes_;

		// Token: 0x0400A2E6 RID: 41702
		public const int RefreshCostFieldNumber = 3;

		// Token: 0x0400A2E7 RID: 41703
		private int refreshCost_;

		// Token: 0x0400A2E8 RID: 41704
		public const int ShopProductPbInfosFieldNumber = 4;

		// Token: 0x0400A2E9 RID: 41705
		private static readonly FieldCodec<TrapDefenseShopProductPbInfo> _repeated_shopProductPbInfos_codec = FieldCodec.ForMessage<TrapDefenseShopProductPbInfo>(34U, TrapDefenseShopProductPbInfo.Parser);

		// Token: 0x0400A2EA RID: 41706
		private readonly RepeatedField<TrapDefenseShopProductPbInfo> shopProductPbInfos_ = new RepeatedField<TrapDefenseShopProductPbInfo>();
	}
}
