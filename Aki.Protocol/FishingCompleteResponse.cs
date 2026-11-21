using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053A RID: 1338
	[NetMessage(EMessageId.FishingCompleteResponse)]
	public sealed class FishingCompleteResponse : IMessage<FishingCompleteResponse>, IMessage, IEquatable<FishingCompleteResponse>, IDeepCloneable<FishingCompleteResponse>, IBufferMessage
	{
		// Token: 0x06007D99 RID: 32153 RVA: 0x001308C8 File Offset: 0x0012EAC8
		[NullableContext(1)]
		public static FishingCompleteResponse Create()
		{
			return new FishingCompleteResponse();
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06007D9A RID: 32154 RVA: 0x001308CF File Offset: 0x0012EACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x001308D2 File Offset: 0x0012EAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCompleteResponse.Descriptor;
			}
		}

		// Token: 0x06007D9C RID: 32156 RVA: 0x001308D9 File Offset: 0x0012EAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteResponse()
		{
		}

		// Token: 0x06007D9D RID: 32157 RVA: 0x00130904 File Offset: 0x0012EB04
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

		// Token: 0x06007D9E RID: 32158 RVA: 0x00130967 File Offset: 0x0012EB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteResponse Clone()
		{
			return new FishingCompleteResponse(this);
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06007D9F RID: 32159 RVA: 0x0013096F File Offset: 0x0012EB6F
		// (set) Token: 0x06007DA0 RID: 32160 RVA: 0x00130977 File Offset: 0x0012EB77
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

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06007DA1 RID: 32161 RVA: 0x00130980 File Offset: 0x0012EB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06007DA2 RID: 32162 RVA: 0x00130988 File Offset: 0x0012EB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> ExtraItems
		{
			get
			{
				return this.extraItems_;
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06007DA3 RID: 32163 RVA: 0x00130990 File Offset: 0x0012EB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> DoubleItems
		{
			get
			{
				return this.doubleItems_;
			}
		}

		// Token: 0x06007DA4 RID: 32164 RVA: 0x00130998 File Offset: 0x0012EB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCompleteResponse);
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x001309A8 File Offset: 0x0012EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCompleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && this.extraItems_.Equals(other.extraItems_) && this.doubleItems_.Equals(other.doubleItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x00130A20 File Offset: 0x0012EC20
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

		// Token: 0x06007DA7 RID: 32167 RVA: 0x00130A8F File Offset: 0x0012EC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x00130A9C File Offset: 0x0012EC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DA9 RID: 32169 RVA: 0x00130AA8 File Offset: 0x0012ECA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.extraItems_.WriteTo(ref output, FishingCompleteResponse._repeated_extraItems_codec);
			this.items_.WriteTo(ref output, FishingCompleteResponse._repeated_items_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.doubleItems_.WriteTo(ref output, FishingCompleteResponse._repeated_doubleItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x00130B18 File Offset: 0x0012ED18
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

		// Token: 0x06007DAB RID: 32171 RVA: 0x00130B90 File Offset: 0x0012ED90
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

		// Token: 0x06007DAC RID: 32172 RVA: 0x00130BFF File Offset: 0x0012EDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DAD RID: 32173 RVA: 0x00130C08 File Offset: 0x0012EE08
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.extraItems_.AddEntriesFrom(ref input, FishingCompleteResponse._repeated_extraItems_codec);
						continue;
					}
					if (num == 18U)
					{
						this.items_.AddEntriesFrom(ref input, FishingCompleteResponse._repeated_items_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 106U)
					{
						this.doubleItems_.AddEntriesFrom(ref input, FishingCompleteResponse._repeated_doubleItems_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004037 RID: 16439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004038 RID: 16440
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004039 RID: 16441
		private ErrorCode errorCode_;

		// Token: 0x0400403A RID: 16442
		public const int ItemsFieldNumber = 2;

		// Token: 0x0400403B RID: 16443
		private static readonly FieldCodec<FishingItemInfo> _repeated_items_codec = FieldCodec.ForMessage<FishingItemInfo>(18U, FishingItemInfo.Parser);

		// Token: 0x0400403C RID: 16444
		private readonly RepeatedField<FishingItemInfo> items_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x0400403D RID: 16445
		public const int ExtraItemsFieldNumber = 1;

		// Token: 0x0400403E RID: 16446
		private static readonly FieldCodec<FishingItemInfo> _repeated_extraItems_codec = FieldCodec.ForMessage<FishingItemInfo>(10U, FishingItemInfo.Parser);

		// Token: 0x0400403F RID: 16447
		private readonly RepeatedField<FishingItemInfo> extraItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04004040 RID: 16448
		public const int DoubleItemsFieldNumber = 13;

		// Token: 0x04004041 RID: 16449
		private static readonly FieldCodec<FishingItemInfo> _repeated_doubleItems_codec = FieldCodec.ForMessage<FishingItemInfo>(106U, FishingItemInfo.Parser);

		// Token: 0x04004042 RID: 16450
		private readonly RepeatedField<FishingItemInfo> doubleItems_ = new RepeatedField<FishingItemInfo>();
	}
}
