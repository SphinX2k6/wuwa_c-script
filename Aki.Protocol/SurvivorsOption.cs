using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001349 RID: 4937
	public sealed class SurvivorsOption : IMessage<SurvivorsOption>, IMessage, IEquatable<SurvivorsOption>, IDeepCloneable<SurvivorsOption>, IBufferMessage
	{
		// Token: 0x0601A4FB RID: 107771 RVA: 0x003D5EF5 File Offset: 0x003D40F5
		[NullableContext(1)]
		public static SurvivorsOption Create()
		{
			return new SurvivorsOption();
		}

		// Token: 0x1700591E RID: 22814
		// (get) Token: 0x0601A4FC RID: 107772 RVA: 0x003D5EFC File Offset: 0x003D40FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700591F RID: 22815
		// (get) Token: 0x0601A4FD RID: 107773 RVA: 0x003D5EFF File Offset: 0x003D40FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOption.Descriptor;
			}
		}

		// Token: 0x0601A4FE RID: 107774 RVA: 0x003D5F06 File Offset: 0x003D4106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption()
		{
		}

		// Token: 0x0601A4FF RID: 107775 RVA: 0x003D5F1C File Offset: 0x003D411C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption(SurvivorsOption other) : this()
		{
			this.isSelect_ = other.isSelect_;
			this.canGiveUp_ = other.canGiveUp_;
			this.canMultiSelect_ = other.canMultiSelect_;
			this.maxSelectCount_ = other.maxSelectCount_;
			this.useSelectCount_ = other.useSelectCount_;
			this.useRefreshCount_ = other.useRefreshCount_;
			this.refreshItem_ = other.refreshItem_;
			this.refreshCost_ = other.refreshCost_;
			this.goodsDetails_ = other.goodsDetails_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A500 RID: 107776 RVA: 0x003D5FB1 File Offset: 0x003D41B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption Clone()
		{
			return new SurvivorsOption(this);
		}

		// Token: 0x17005920 RID: 22816
		// (get) Token: 0x0601A501 RID: 107777 RVA: 0x003D5FB9 File Offset: 0x003D41B9
		// (set) Token: 0x0601A502 RID: 107778 RVA: 0x003D5FC1 File Offset: 0x003D41C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x17005921 RID: 22817
		// (get) Token: 0x0601A503 RID: 107779 RVA: 0x003D5FCA File Offset: 0x003D41CA
		// (set) Token: 0x0601A504 RID: 107780 RVA: 0x003D5FD2 File Offset: 0x003D41D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanGiveUp
		{
			get
			{
				return this.canGiveUp_;
			}
			set
			{
				this.canGiveUp_ = value;
			}
		}

		// Token: 0x17005922 RID: 22818
		// (get) Token: 0x0601A505 RID: 107781 RVA: 0x003D5FDB File Offset: 0x003D41DB
		// (set) Token: 0x0601A506 RID: 107782 RVA: 0x003D5FE3 File Offset: 0x003D41E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanMultiSelect
		{
			get
			{
				return this.canMultiSelect_;
			}
			set
			{
				this.canMultiSelect_ = value;
			}
		}

		// Token: 0x17005923 RID: 22819
		// (get) Token: 0x0601A507 RID: 107783 RVA: 0x003D5FEC File Offset: 0x003D41EC
		// (set) Token: 0x0601A508 RID: 107784 RVA: 0x003D5FF4 File Offset: 0x003D41F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSelectCount
		{
			get
			{
				return this.maxSelectCount_;
			}
			set
			{
				this.maxSelectCount_ = value;
			}
		}

		// Token: 0x17005924 RID: 22820
		// (get) Token: 0x0601A509 RID: 107785 RVA: 0x003D5FFD File Offset: 0x003D41FD
		// (set) Token: 0x0601A50A RID: 107786 RVA: 0x003D6005 File Offset: 0x003D4205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseSelectCount
		{
			get
			{
				return this.useSelectCount_;
			}
			set
			{
				this.useSelectCount_ = value;
			}
		}

		// Token: 0x17005925 RID: 22821
		// (get) Token: 0x0601A50B RID: 107787 RVA: 0x003D600E File Offset: 0x003D420E
		// (set) Token: 0x0601A50C RID: 107788 RVA: 0x003D6016 File Offset: 0x003D4216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseRefreshCount
		{
			get
			{
				return this.useRefreshCount_;
			}
			set
			{
				this.useRefreshCount_ = value;
			}
		}

		// Token: 0x17005926 RID: 22822
		// (get) Token: 0x0601A50D RID: 107789 RVA: 0x003D601F File Offset: 0x003D421F
		// (set) Token: 0x0601A50E RID: 107790 RVA: 0x003D6027 File Offset: 0x003D4227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshItem
		{
			get
			{
				return this.refreshItem_;
			}
			set
			{
				this.refreshItem_ = value;
			}
		}

		// Token: 0x17005927 RID: 22823
		// (get) Token: 0x0601A50F RID: 107791 RVA: 0x003D6030 File Offset: 0x003D4230
		// (set) Token: 0x0601A510 RID: 107792 RVA: 0x003D6038 File Offset: 0x003D4238
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

		// Token: 0x17005928 RID: 22824
		// (get) Token: 0x0601A511 RID: 107793 RVA: 0x003D6041 File Offset: 0x003D4241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GoodsDetail> GoodsDetails
		{
			get
			{
				return this.goodsDetails_;
			}
		}

		// Token: 0x0601A512 RID: 107794 RVA: 0x003D6049 File Offset: 0x003D4249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOption);
		}

		// Token: 0x0601A513 RID: 107795 RVA: 0x003D6058 File Offset: 0x003D4258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOption other)
		{
			return other != null && (other == this || (this.IsSelect == other.IsSelect && this.CanGiveUp == other.CanGiveUp && this.CanMultiSelect == other.CanMultiSelect && this.MaxSelectCount == other.MaxSelectCount && this.UseSelectCount == other.UseSelectCount && this.UseRefreshCount == other.UseRefreshCount && this.RefreshItem == other.RefreshItem && this.RefreshCost == other.RefreshCost && this.goodsDetails_.Equals(other.goodsDetails_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A514 RID: 107796 RVA: 0x003D6118 File Offset: 0x003D4318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this.CanGiveUp)
			{
				num ^= this.CanGiveUp.GetHashCode();
			}
			if (this.CanMultiSelect)
			{
				num ^= this.CanMultiSelect.GetHashCode();
			}
			if (this.MaxSelectCount != 0)
			{
				num ^= this.MaxSelectCount.GetHashCode();
			}
			if (this.UseSelectCount != 0)
			{
				num ^= this.UseSelectCount.GetHashCode();
			}
			if (this.UseRefreshCount != 0)
			{
				num ^= this.UseRefreshCount.GetHashCode();
			}
			if (this.RefreshItem != 0)
			{
				num ^= this.RefreshItem.GetHashCode();
			}
			if (this.RefreshCost != 0)
			{
				num ^= this.RefreshCost.GetHashCode();
			}
			num ^= this.goodsDetails_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A515 RID: 107797 RVA: 0x003D6214 File Offset: 0x003D4414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A516 RID: 107798 RVA: 0x003D6221 File Offset: 0x003D4421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A517 RID: 107799 RVA: 0x003D622C File Offset: 0x003D442C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.goodsDetails_.WriteTo(ref output, SurvivorsOption._repeated_goodsDetails_codec);
			if (this.IsSelect)
			{
				output.WriteRawTag(200, 62);
				output.WriteBool(this.IsSelect);
			}
			if (this.CanGiveUp)
			{
				output.WriteRawTag(208, 62);
				output.WriteBool(this.CanGiveUp);
			}
			if (this.CanMultiSelect)
			{
				output.WriteRawTag(216, 62);
				output.WriteBool(this.CanMultiSelect);
			}
			if (this.MaxSelectCount != 0)
			{
				output.WriteRawTag(224, 62);
				output.WriteInt32(this.MaxSelectCount);
			}
			if (this.UseSelectCount != 0)
			{
				output.WriteRawTag(232, 62);
				output.WriteInt32(this.UseSelectCount);
			}
			if (this.UseRefreshCount != 0)
			{
				output.WriteRawTag(248, 62);
				output.WriteInt32(this.UseRefreshCount);
			}
			if (this.RefreshItem != 0)
			{
				output.WriteRawTag(128, 63);
				output.WriteInt32(this.RefreshItem);
			}
			if (this.RefreshCost != 0)
			{
				output.WriteRawTag(136, 63);
				output.WriteInt32(this.RefreshCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A518 RID: 107800 RVA: 0x003D6368 File Offset: 0x003D4568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSelect)
			{
				num += 3;
			}
			if (this.CanGiveUp)
			{
				num += 3;
			}
			if (this.CanMultiSelect)
			{
				num += 3;
			}
			if (this.MaxSelectCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxSelectCount);
			}
			if (this.UseSelectCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.UseSelectCount);
			}
			if (this.UseRefreshCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.UseRefreshCount);
			}
			if (this.RefreshItem != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RefreshItem);
			}
			if (this.RefreshCost != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RefreshCost);
			}
			num += this.goodsDetails_.CalculateSize(SurvivorsOption._repeated_goodsDetails_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A519 RID: 107801 RVA: 0x003D6440 File Offset: 0x003D4640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOption other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			if (other.CanGiveUp)
			{
				this.CanGiveUp = other.CanGiveUp;
			}
			if (other.CanMultiSelect)
			{
				this.CanMultiSelect = other.CanMultiSelect;
			}
			if (other.MaxSelectCount != 0)
			{
				this.MaxSelectCount = other.MaxSelectCount;
			}
			if (other.UseSelectCount != 0)
			{
				this.UseSelectCount = other.UseSelectCount;
			}
			if (other.UseRefreshCount != 0)
			{
				this.UseRefreshCount = other.UseRefreshCount;
			}
			if (other.RefreshItem != 0)
			{
				this.RefreshItem = other.RefreshItem;
			}
			if (other.RefreshCost != 0)
			{
				this.RefreshCost = other.RefreshCost;
			}
			this.goodsDetails_.Add(other.goodsDetails_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A51A RID: 107802 RVA: 0x003D6519 File Offset: 0x003D4719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A51B RID: 107803 RVA: 0x003D6524 File Offset: 0x003D4724
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
				if (num <= 8024U)
				{
					if (num <= 8008U)
					{
						if (num == 10U)
						{
							this.goodsDetails_.AddEntriesFrom(ref input, SurvivorsOption._repeated_goodsDetails_codec);
							continue;
						}
						if (num == 8008U)
						{
							this.IsSelect = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 8016U)
						{
							this.CanGiveUp = input.ReadBool();
							continue;
						}
						if (num == 8024U)
						{
							this.CanMultiSelect = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 8040U)
				{
					if (num == 8032U)
					{
						this.MaxSelectCount = input.ReadInt32();
						continue;
					}
					if (num == 8040U)
					{
						this.UseSelectCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 8056U)
					{
						this.UseRefreshCount = input.ReadInt32();
						continue;
					}
					if (num == 8064U)
					{
						this.RefreshItem = input.ReadInt32();
						continue;
					}
					if (num == 8072U)
					{
						this.RefreshCost = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009AA7 RID: 39591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AA8 RID: 39592
		public const int IsSelectFieldNumber = 1001;

		// Token: 0x04009AA9 RID: 39593
		private bool isSelect_;

		// Token: 0x04009AAA RID: 39594
		public const int CanGiveUpFieldNumber = 1002;

		// Token: 0x04009AAB RID: 39595
		private bool canGiveUp_;

		// Token: 0x04009AAC RID: 39596
		public const int CanMultiSelectFieldNumber = 1003;

		// Token: 0x04009AAD RID: 39597
		private bool canMultiSelect_;

		// Token: 0x04009AAE RID: 39598
		public const int MaxSelectCountFieldNumber = 1004;

		// Token: 0x04009AAF RID: 39599
		private int maxSelectCount_;

		// Token: 0x04009AB0 RID: 39600
		public const int UseSelectCountFieldNumber = 1005;

		// Token: 0x04009AB1 RID: 39601
		private int useSelectCount_;

		// Token: 0x04009AB2 RID: 39602
		public const int UseRefreshCountFieldNumber = 1007;

		// Token: 0x04009AB3 RID: 39603
		private int useRefreshCount_;

		// Token: 0x04009AB4 RID: 39604
		public const int RefreshItemFieldNumber = 1008;

		// Token: 0x04009AB5 RID: 39605
		private int refreshItem_;

		// Token: 0x04009AB6 RID: 39606
		public const int RefreshCostFieldNumber = 1009;

		// Token: 0x04009AB7 RID: 39607
		private int refreshCost_;

		// Token: 0x04009AB8 RID: 39608
		public const int GoodsDetailsFieldNumber = 1;

		// Token: 0x04009AB9 RID: 39609
		private static readonly FieldCodec<GoodsDetail> _repeated_goodsDetails_codec = FieldCodec.ForMessage<GoodsDetail>(10U, GoodsDetail.Parser);

		// Token: 0x04009ABA RID: 39610
		private readonly RepeatedField<GoodsDetail> goodsDetails_ = new RepeatedField<GoodsDetail>();
	}
}
