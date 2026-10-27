using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DA RID: 4826
	public sealed class SurvivorsOption : IMessage<SurvivorsOption>, IMessage, IEquatable<SurvivorsOption>, IDeepCloneable<SurvivorsOption>, IBufferMessage
	{
		// Token: 0x06019AC5 RID: 105157 RVA: 0x003BB7C5 File Offset: 0x003B99C5
		[NullableContext(1)]
		public static SurvivorsOption Create()
		{
			return new SurvivorsOption();
		}

		// Token: 0x1700569D RID: 22173
		// (get) Token: 0x06019AC6 RID: 105158 RVA: 0x003BB7CC File Offset: 0x003B99CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700569E RID: 22174
		// (get) Token: 0x06019AC7 RID: 105159 RVA: 0x003BB7CF File Offset: 0x003B99CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOption.Descriptor;
			}
		}

		// Token: 0x06019AC8 RID: 105160 RVA: 0x003BB7D6 File Offset: 0x003B99D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption()
		{
		}

		// Token: 0x06019AC9 RID: 105161 RVA: 0x003BB7EC File Offset: 0x003B99EC
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

		// Token: 0x06019ACA RID: 105162 RVA: 0x003BB881 File Offset: 0x003B9A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption Clone()
		{
			return new SurvivorsOption(this);
		}

		// Token: 0x1700569F RID: 22175
		// (get) Token: 0x06019ACB RID: 105163 RVA: 0x003BB889 File Offset: 0x003B9A89
		// (set) Token: 0x06019ACC RID: 105164 RVA: 0x003BB891 File Offset: 0x003B9A91
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

		// Token: 0x170056A0 RID: 22176
		// (get) Token: 0x06019ACD RID: 105165 RVA: 0x003BB89A File Offset: 0x003B9A9A
		// (set) Token: 0x06019ACE RID: 105166 RVA: 0x003BB8A2 File Offset: 0x003B9AA2
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

		// Token: 0x170056A1 RID: 22177
		// (get) Token: 0x06019ACF RID: 105167 RVA: 0x003BB8AB File Offset: 0x003B9AAB
		// (set) Token: 0x06019AD0 RID: 105168 RVA: 0x003BB8B3 File Offset: 0x003B9AB3
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

		// Token: 0x170056A2 RID: 22178
		// (get) Token: 0x06019AD1 RID: 105169 RVA: 0x003BB8BC File Offset: 0x003B9ABC
		// (set) Token: 0x06019AD2 RID: 105170 RVA: 0x003BB8C4 File Offset: 0x003B9AC4
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

		// Token: 0x170056A3 RID: 22179
		// (get) Token: 0x06019AD3 RID: 105171 RVA: 0x003BB8CD File Offset: 0x003B9ACD
		// (set) Token: 0x06019AD4 RID: 105172 RVA: 0x003BB8D5 File Offset: 0x003B9AD5
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

		// Token: 0x170056A4 RID: 22180
		// (get) Token: 0x06019AD5 RID: 105173 RVA: 0x003BB8DE File Offset: 0x003B9ADE
		// (set) Token: 0x06019AD6 RID: 105174 RVA: 0x003BB8E6 File Offset: 0x003B9AE6
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

		// Token: 0x170056A5 RID: 22181
		// (get) Token: 0x06019AD7 RID: 105175 RVA: 0x003BB8EF File Offset: 0x003B9AEF
		// (set) Token: 0x06019AD8 RID: 105176 RVA: 0x003BB8F7 File Offset: 0x003B9AF7
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

		// Token: 0x170056A6 RID: 22182
		// (get) Token: 0x06019AD9 RID: 105177 RVA: 0x003BB900 File Offset: 0x003B9B00
		// (set) Token: 0x06019ADA RID: 105178 RVA: 0x003BB908 File Offset: 0x003B9B08
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

		// Token: 0x170056A7 RID: 22183
		// (get) Token: 0x06019ADB RID: 105179 RVA: 0x003BB911 File Offset: 0x003B9B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GoodsDetail> GoodsDetails
		{
			get
			{
				return this.goodsDetails_;
			}
		}

		// Token: 0x06019ADC RID: 105180 RVA: 0x003BB919 File Offset: 0x003B9B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOption);
		}

		// Token: 0x06019ADD RID: 105181 RVA: 0x003BB928 File Offset: 0x003B9B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOption other)
		{
			return other != null && (other == this || (this.IsSelect == other.IsSelect && this.CanGiveUp == other.CanGiveUp && this.CanMultiSelect == other.CanMultiSelect && this.MaxSelectCount == other.MaxSelectCount && this.UseSelectCount == other.UseSelectCount && this.UseRefreshCount == other.UseRefreshCount && this.RefreshItem == other.RefreshItem && this.RefreshCost == other.RefreshCost && this.goodsDetails_.Equals(other.goodsDetails_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019ADE RID: 105182 RVA: 0x003BB9E8 File Offset: 0x003B9BE8
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

		// Token: 0x06019ADF RID: 105183 RVA: 0x003BBAE4 File Offset: 0x003B9CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019AE0 RID: 105184 RVA: 0x003BBAF1 File Offset: 0x003B9CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019AE1 RID: 105185 RVA: 0x003BBAFC File Offset: 0x003B9CFC
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

		// Token: 0x06019AE2 RID: 105186 RVA: 0x003BBC38 File Offset: 0x003B9E38
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

		// Token: 0x06019AE3 RID: 105187 RVA: 0x003BBD10 File Offset: 0x003B9F10
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

		// Token: 0x06019AE4 RID: 105188 RVA: 0x003BBDE9 File Offset: 0x003B9FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019AE5 RID: 105189 RVA: 0x003BBDF4 File Offset: 0x003B9FF4
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

		// Token: 0x0400967D RID: 38525
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400967E RID: 38526
		public const int IsSelectFieldNumber = 1001;

		// Token: 0x0400967F RID: 38527
		private bool isSelect_;

		// Token: 0x04009680 RID: 38528
		public const int CanGiveUpFieldNumber = 1002;

		// Token: 0x04009681 RID: 38529
		private bool canGiveUp_;

		// Token: 0x04009682 RID: 38530
		public const int CanMultiSelectFieldNumber = 1003;

		// Token: 0x04009683 RID: 38531
		private bool canMultiSelect_;

		// Token: 0x04009684 RID: 38532
		public const int MaxSelectCountFieldNumber = 1004;

		// Token: 0x04009685 RID: 38533
		private int maxSelectCount_;

		// Token: 0x04009686 RID: 38534
		public const int UseSelectCountFieldNumber = 1005;

		// Token: 0x04009687 RID: 38535
		private int useSelectCount_;

		// Token: 0x04009688 RID: 38536
		public const int UseRefreshCountFieldNumber = 1007;

		// Token: 0x04009689 RID: 38537
		private int useRefreshCount_;

		// Token: 0x0400968A RID: 38538
		public const int RefreshItemFieldNumber = 1008;

		// Token: 0x0400968B RID: 38539
		private int refreshItem_;

		// Token: 0x0400968C RID: 38540
		public const int RefreshCostFieldNumber = 1009;

		// Token: 0x0400968D RID: 38541
		private int refreshCost_;

		// Token: 0x0400968E RID: 38542
		public const int GoodsDetailsFieldNumber = 1;

		// Token: 0x0400968F RID: 38543
		private static readonly FieldCodec<GoodsDetail> _repeated_goodsDetails_codec = FieldCodec.ForMessage<GoodsDetail>(10U, GoodsDetail.Parser);

		// Token: 0x04009690 RID: 38544
		private readonly RepeatedField<GoodsDetail> goodsDetails_ = new RepeatedField<GoodsDetail>();
	}
}
