using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055E RID: 1374
	[NetMessage(EMessageId.FishingQuickSellPreviewResponse)]
	public sealed class FishingQuickSellPreviewResponse : IMessage<FishingQuickSellPreviewResponse>, IMessage, IEquatable<FishingQuickSellPreviewResponse>, IDeepCloneable<FishingQuickSellPreviewResponse>, IBufferMessage
	{
		// Token: 0x0600806B RID: 32875 RVA: 0x00136C2A File Offset: 0x00134E2A
		[NullableContext(1)]
		public static FishingQuickSellPreviewResponse Create()
		{
			return new FishingQuickSellPreviewResponse();
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x0600806C RID: 32876 RVA: 0x00136C31 File Offset: 0x00134E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600806D RID: 32877 RVA: 0x00136C34 File Offset: 0x00134E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingQuickSellPreviewResponse.Descriptor;
			}
		}

		// Token: 0x0600806E RID: 32878 RVA: 0x00136C3B File Offset: 0x00134E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewResponse()
		{
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x00136C5C File Offset: 0x00134E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewResponse(FishingQuickSellPreviewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this.sellItems_ = other.sellItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x00136CAE File Offset: 0x00134EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewResponse Clone()
		{
			return new FishingQuickSellPreviewResponse(this);
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x06008071 RID: 32881 RVA: 0x00136CB6 File Offset: 0x00134EB6
		// (set) Token: 0x06008072 RID: 32882 RVA: 0x00136CBE File Offset: 0x00134EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x06008073 RID: 32883 RVA: 0x00136CC7 File Offset: 0x00134EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06008074 RID: 32884 RVA: 0x00136CCF File Offset: 0x00134ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> SellItems
		{
			get
			{
				return this.sellItems_;
			}
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x00136CD7 File Offset: 0x00134ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingQuickSellPreviewResponse);
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x00136CE8 File Offset: 0x00134EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingQuickSellPreviewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RewardItems.Equals(other.RewardItems) && this.sellItems_.Equals(other.sellItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008077 RID: 32887 RVA: 0x00136D4C File Offset: 0x00134F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.RewardItems.GetHashCode();
			num ^= this.sellItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x00136DAD File Offset: 0x00134FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008079 RID: 32889 RVA: 0x00136DBA File Offset: 0x00134FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600807A RID: 32890 RVA: 0x00136DC4 File Offset: 0x00134FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rewardItems_.WriteTo(ref output, FishingQuickSellPreviewResponse._map_rewardItems_codec);
			this.sellItems_.WriteTo(ref output, FishingQuickSellPreviewResponse._repeated_sellItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600807B RID: 32891 RVA: 0x00136E24 File Offset: 0x00135024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rewardItems_.CalculateSize(FishingQuickSellPreviewResponse._map_rewardItems_codec);
			num += this.sellItems_.CalculateSize(FishingQuickSellPreviewResponse._repeated_sellItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600807C RID: 32892 RVA: 0x00136E88 File Offset: 0x00135088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingQuickSellPreviewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rewardItems_.MergeFrom(other.rewardItems_);
			this.sellItems_.Add(other.sellItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600807D RID: 32893 RVA: 0x00136EE6 File Offset: 0x001350E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600807E RID: 32894 RVA: 0x00136EF0 File Offset: 0x001350F0
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
				if (num != 40U)
				{
					if (num != 66U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.sellItems_.AddEntriesFrom(ref input, FishingQuickSellPreviewResponse._repeated_sellItems_codec);
						}
					}
					else
					{
						this.rewardItems_.AddEntriesFrom(ref input, FishingQuickSellPreviewResponse._map_rewardItems_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004111 RID: 16657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004112 RID: 16658
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004113 RID: 16659
		private ErrorCode errorCode_;

		// Token: 0x04004114 RID: 16660
		public const int RewardItemsFieldNumber = 8;

		// Token: 0x04004115 RID: 16661
		private static readonly MapField<int, int>.Codec _map_rewardItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x04004116 RID: 16662
		private readonly MapField<int, int> rewardItems_ = new MapField<int, int>();

		// Token: 0x04004117 RID: 16663
		public const int SellItemsFieldNumber = 10;

		// Token: 0x04004118 RID: 16664
		private static readonly FieldCodec<FishingItemInfo> _repeated_sellItems_codec = FieldCodec.ForMessage<FishingItemInfo>(82U, FishingItemInfo.Parser);

		// Token: 0x04004119 RID: 16665
		private readonly RepeatedField<FishingItemInfo> sellItems_ = new RepeatedField<FishingItemInfo>();
	}
}
