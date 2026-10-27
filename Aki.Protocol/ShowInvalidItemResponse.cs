using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001211 RID: 4625
	[NetMessage(EMessageId.ShowInvalidItemResponse)]
	public sealed class ShowInvalidItemResponse : IMessage<ShowInvalidItemResponse>, IMessage, IEquatable<ShowInvalidItemResponse>, IDeepCloneable<ShowInvalidItemResponse>, IBufferMessage
	{
		// Token: 0x06018A5E RID: 100958 RVA: 0x003957A6 File Offset: 0x003939A6
		[NullableContext(1)]
		public static ShowInvalidItemResponse Create()
		{
			return new ShowInvalidItemResponse();
		}

		// Token: 0x17005309 RID: 21257
		// (get) Token: 0x06018A5F RID: 100959 RVA: 0x003957AD File Offset: 0x003939AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700530A RID: 21258
		// (get) Token: 0x06018A60 RID: 100960 RVA: 0x003957B0 File Offset: 0x003939B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowInvalidItemResponse.Descriptor;
			}
		}

		// Token: 0x06018A61 RID: 100961 RVA: 0x003957B7 File Offset: 0x003939B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemResponse()
		{
		}

		// Token: 0x06018A62 RID: 100962 RVA: 0x003957D5 File Offset: 0x003939D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemResponse(ShowInvalidItemResponse other) : this()
		{
			this.invalidItemList_ = other.invalidItemList_.Clone();
			this.expireConvertItemInfoList_ = other.expireConvertItemInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A63 RID: 100963 RVA: 0x00395810 File Offset: 0x00393A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemResponse Clone()
		{
			return new ShowInvalidItemResponse(this);
		}

		// Token: 0x1700530B RID: 21259
		// (get) Token: 0x06018A64 RID: 100964 RVA: 0x00395818 File Offset: 0x00393A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InvalidItem> InvalidItemList
		{
			get
			{
				return this.invalidItemList_;
			}
		}

		// Token: 0x1700530C RID: 21260
		// (get) Token: 0x06018A65 RID: 100965 RVA: 0x00395820 File Offset: 0x00393A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExpireConvertItemInfo> ExpireConvertItemInfoList
		{
			get
			{
				return this.expireConvertItemInfoList_;
			}
		}

		// Token: 0x06018A66 RID: 100966 RVA: 0x00395828 File Offset: 0x00393A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowInvalidItemResponse);
		}

		// Token: 0x06018A67 RID: 100967 RVA: 0x00395838 File Offset: 0x00393A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowInvalidItemResponse other)
		{
			return other != null && (other == this || (this.invalidItemList_.Equals(other.invalidItemList_) && this.expireConvertItemInfoList_.Equals(other.expireConvertItemInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A68 RID: 100968 RVA: 0x0039588C File Offset: 0x00393A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.invalidItemList_.GetHashCode();
			num ^= this.expireConvertItemInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A69 RID: 100969 RVA: 0x003958CE File Offset: 0x00393ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A6A RID: 100970 RVA: 0x003958DB File Offset: 0x00393ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A6B RID: 100971 RVA: 0x003958E4 File Offset: 0x00393AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.expireConvertItemInfoList_.WriteTo(ref output, ShowInvalidItemResponse._repeated_expireConvertItemInfoList_codec);
			this.invalidItemList_.WriteTo(ref output, ShowInvalidItemResponse._repeated_invalidItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A6C RID: 100972 RVA: 0x0039591C File Offset: 0x00393B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.invalidItemList_.CalculateSize(ShowInvalidItemResponse._repeated_invalidItemList_codec);
			num += this.expireConvertItemInfoList_.CalculateSize(ShowInvalidItemResponse._repeated_expireConvertItemInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A6D RID: 100973 RVA: 0x00395968 File Offset: 0x00393B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShowInvalidItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.invalidItemList_.Add(other.invalidItemList_);
			this.expireConvertItemInfoList_.Add(other.expireConvertItemInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A6E RID: 100974 RVA: 0x003959A7 File Offset: 0x00393BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A6F RID: 100975 RVA: 0x003959B0 File Offset: 0x00393BB0
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
				if (num != 50U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.invalidItemList_.AddEntriesFrom(ref input, ShowInvalidItemResponse._repeated_invalidItemList_codec);
					}
				}
				else
				{
					this.expireConvertItemInfoList_.AddEntriesFrom(ref input, ShowInvalidItemResponse._repeated_expireConvertItemInfoList_codec);
				}
			}
		}

		// Token: 0x04009197 RID: 37271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009198 RID: 37272
		public const int InvalidItemListFieldNumber = 7;

		// Token: 0x04009199 RID: 37273
		private static readonly FieldCodec<InvalidItem> _repeated_invalidItemList_codec = FieldCodec.ForMessage<InvalidItem>(58U, InvalidItem.Parser);

		// Token: 0x0400919A RID: 37274
		private readonly RepeatedField<InvalidItem> invalidItemList_ = new RepeatedField<InvalidItem>();

		// Token: 0x0400919B RID: 37275
		public const int ExpireConvertItemInfoListFieldNumber = 6;

		// Token: 0x0400919C RID: 37276
		private static readonly FieldCodec<ExpireConvertItemInfo> _repeated_expireConvertItemInfoList_codec = FieldCodec.ForMessage<ExpireConvertItemInfo>(50U, ExpireConvertItemInfo.Parser);

		// Token: 0x0400919D RID: 37277
		private readonly RepeatedField<ExpireConvertItemInfo> expireConvertItemInfoList_ = new RepeatedField<ExpireConvertItemInfo>();
	}
}
