using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000573 RID: 1395
	[NetMessage(EMessageId.FishingQuickSellPreviewResponse)]
	public sealed class FishingQuickSellPreviewResponse : IMessage<FishingQuickSellPreviewResponse>, IMessage, IEquatable<FishingQuickSellPreviewResponse>, IDeepCloneable<FishingQuickSellPreviewResponse>, IBufferMessage
	{
		// Token: 0x060081D3 RID: 33235 RVA: 0x0013982A File Offset: 0x00137A2A
		[NullableContext(1)]
		public static FishingQuickSellPreviewResponse Create()
		{
			return new FishingQuickSellPreviewResponse();
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x060081D4 RID: 33236 RVA: 0x00139831 File Offset: 0x00137A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x060081D5 RID: 33237 RVA: 0x00139834 File Offset: 0x00137A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingQuickSellPreviewResponse.Descriptor;
			}
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x0013983B File Offset: 0x00137A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewResponse()
		{
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x0013985C File Offset: 0x00137A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewResponse(FishingQuickSellPreviewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this.sellItems_ = other.sellItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x001398AE File Offset: 0x00137AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellPreviewResponse Clone()
		{
			return new FishingQuickSellPreviewResponse(this);
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x060081D9 RID: 33241 RVA: 0x001398B6 File Offset: 0x00137AB6
		// (set) Token: 0x060081DA RID: 33242 RVA: 0x001398BE File Offset: 0x00137ABE
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

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x060081DB RID: 33243 RVA: 0x001398C7 File Offset: 0x00137AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x060081DC RID: 33244 RVA: 0x001398CF File Offset: 0x00137ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> SellItems
		{
			get
			{
				return this.sellItems_;
			}
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x001398D7 File Offset: 0x00137AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingQuickSellPreviewResponse);
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x001398E8 File Offset: 0x00137AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingQuickSellPreviewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RewardItems.Equals(other.RewardItems) && this.sellItems_.Equals(other.sellItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x0013994C File Offset: 0x00137B4C
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

		// Token: 0x060081E0 RID: 33248 RVA: 0x001399AD File Offset: 0x00137BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x001399BA File Offset: 0x00137BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x001399C4 File Offset: 0x00137BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sellItems_.WriteTo(ref output, FishingQuickSellPreviewResponse._repeated_sellItems_codec);
			this.rewardItems_.WriteTo(ref output, FishingQuickSellPreviewResponse._map_rewardItems_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x00139A24 File Offset: 0x00137C24
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

		// Token: 0x060081E4 RID: 33252 RVA: 0x00139A88 File Offset: 0x00137C88
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

		// Token: 0x060081E5 RID: 33253 RVA: 0x00139AE6 File Offset: 0x00137CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x00139AF0 File Offset: 0x00137CF0
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
				if (num != 42U)
				{
					if (num != 66U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.rewardItems_.AddEntriesFrom(ref input, FishingQuickSellPreviewResponse._map_rewardItems_codec);
					}
				}
				else
				{
					this.sellItems_.AddEntriesFrom(ref input, FishingQuickSellPreviewResponse._repeated_sellItems_codec);
				}
			}
		}

		// Token: 0x0400411B RID: 16667
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400411C RID: 16668
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400411D RID: 16669
		private ErrorCode errorCode_;

		// Token: 0x0400411E RID: 16670
		public const int RewardItemsFieldNumber = 8;

		// Token: 0x0400411F RID: 16671
		private static readonly MapField<int, int>.Codec _map_rewardItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x04004120 RID: 16672
		private readonly MapField<int, int> rewardItems_ = new MapField<int, int>();

		// Token: 0x04004121 RID: 16673
		public const int SellItemsFieldNumber = 5;

		// Token: 0x04004122 RID: 16674
		private static readonly FieldCodec<FishingItemInfo> _repeated_sellItems_codec = FieldCodec.ForMessage<FishingItemInfo>(42U, FishingItemInfo.Parser);

		// Token: 0x04004123 RID: 16675
		private readonly RepeatedField<FishingItemInfo> sellItems_ = new RepeatedField<FishingItemInfo>();
	}
}
