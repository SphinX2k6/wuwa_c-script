using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054F RID: 1359
	[NetMessage(EMessageId.FishingCompleteResponse)]
	public sealed class FishingCompleteResponse : IMessage<FishingCompleteResponse>, IMessage, IEquatable<FishingCompleteResponse>, IDeepCloneable<FishingCompleteResponse>, IBufferMessage
	{
		// Token: 0x06007F01 RID: 32513 RVA: 0x001334CC File Offset: 0x001316CC
		[NullableContext(1)]
		public static FishingCompleteResponse Create()
		{
			return new FishingCompleteResponse();
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06007F02 RID: 32514 RVA: 0x001334D3 File Offset: 0x001316D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06007F03 RID: 32515 RVA: 0x001334D6 File Offset: 0x001316D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCompleteResponse.Descriptor;
			}
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x001334DD File Offset: 0x001316DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteResponse()
		{
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x00133508 File Offset: 0x00131708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteResponse(FishingCompleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this.extraItems_ = other.extraItems_.Clone();
			this.doubleItems_ = other.doubleItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0013356B File Offset: 0x0013176B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteResponse Clone()
		{
			return new FishingCompleteResponse(this);
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06007F07 RID: 32519 RVA: 0x00133573 File Offset: 0x00131773
		// (set) Token: 0x06007F08 RID: 32520 RVA: 0x0013357B File Offset: 0x0013177B
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

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06007F09 RID: 32521 RVA: 0x00133584 File Offset: 0x00131784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06007F0A RID: 32522 RVA: 0x0013358C File Offset: 0x0013178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> ExtraItems
		{
			get
			{
				return this.extraItems_;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06007F0B RID: 32523 RVA: 0x00133594 File Offset: 0x00131794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> DoubleItems
		{
			get
			{
				return this.doubleItems_;
			}
		}

		// Token: 0x06007F0C RID: 32524 RVA: 0x0013359C File Offset: 0x0013179C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCompleteResponse);
		}

		// Token: 0x06007F0D RID: 32525 RVA: 0x001335AC File Offset: 0x001317AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCompleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && this.extraItems_.Equals(other.extraItems_) && this.doubleItems_.Equals(other.doubleItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x00133624 File Offset: 0x00131824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			num ^= this.extraItems_.GetHashCode();
			num ^= this.doubleItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x00133693 File Offset: 0x00131893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x001336A0 File Offset: 0x001318A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F11 RID: 32529 RVA: 0x001336AC File Offset: 0x001318AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.doubleItems_.WriteTo(ref output, FishingCompleteResponse._repeated_doubleItems_codec);
			this.extraItems_.WriteTo(ref output, FishingCompleteResponse._repeated_extraItems_codec);
			this.items_.WriteTo(ref output, FishingCompleteResponse._repeated_items_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x0013371C File Offset: 0x0013191C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.items_.CalculateSize(FishingCompleteResponse._repeated_items_codec);
			num += this.extraItems_.CalculateSize(FishingCompleteResponse._repeated_extraItems_codec);
			num += this.doubleItems_.CalculateSize(FishingCompleteResponse._repeated_doubleItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F13 RID: 32531 RVA: 0x00133794 File Offset: 0x00131994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCompleteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.items_.Add(other.items_);
			this.extraItems_.Add(other.extraItems_);
			this.doubleItems_.Add(other.doubleItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F14 RID: 32532 RVA: 0x00133803 File Offset: 0x00131A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x0013380C File Offset: 0x00131A0C
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
				if (num <= 82U)
				{
					if (num == 34U)
					{
						this.doubleItems_.AddEntriesFrom(ref input, FishingCompleteResponse._repeated_doubleItems_codec);
						continue;
					}
					if (num == 82U)
					{
						this.extraItems_.AddEntriesFrom(ref input, FishingCompleteResponse._repeated_extraItems_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.items_.AddEntriesFrom(ref input, FishingCompleteResponse._repeated_items_codec);
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004041 RID: 16449
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004042 RID: 16450
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004043 RID: 16451
		private ErrorCode errorCode_;

		// Token: 0x04004044 RID: 16452
		public const int ItemsFieldNumber = 14;

		// Token: 0x04004045 RID: 16453
		private static readonly FieldCodec<FishingItemInfo> _repeated_items_codec = FieldCodec.ForMessage<FishingItemInfo>(114U, FishingItemInfo.Parser);

		// Token: 0x04004046 RID: 16454
		private readonly RepeatedField<FishingItemInfo> items_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04004047 RID: 16455
		public const int ExtraItemsFieldNumber = 10;

		// Token: 0x04004048 RID: 16456
		private static readonly FieldCodec<FishingItemInfo> _repeated_extraItems_codec = FieldCodec.ForMessage<FishingItemInfo>(82U, FishingItemInfo.Parser);

		// Token: 0x04004049 RID: 16457
		private readonly RepeatedField<FishingItemInfo> extraItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x0400404A RID: 16458
		public const int DoubleItemsFieldNumber = 4;

		// Token: 0x0400404B RID: 16459
		private static readonly FieldCodec<FishingItemInfo> _repeated_doubleItems_codec = FieldCodec.ForMessage<FishingItemInfo>(34U, FishingItemInfo.Parser);

		// Token: 0x0400404C RID: 16460
		private readonly RepeatedField<FishingItemInfo> doubleItems_ = new RepeatedField<FishingItemInfo>();
	}
}
