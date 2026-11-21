using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124D RID: 4685
	[NetMessage(EMessageId.ShowInvalidItemResponse)]
	public sealed class ShowInvalidItemResponse : IMessage<ShowInvalidItemResponse>, IMessage, IEquatable<ShowInvalidItemResponse>, IDeepCloneable<ShowInvalidItemResponse>, IBufferMessage
	{
		// Token: 0x06019038 RID: 102456 RVA: 0x003A564E File Offset: 0x003A384E
		[NullableContext(1)]
		public static ShowInvalidItemResponse Create()
		{
			return new ShowInvalidItemResponse();
		}

		// Token: 0x17005486 RID: 21638
		// (get) Token: 0x06019039 RID: 102457 RVA: 0x003A5655 File Offset: 0x003A3855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005487 RID: 21639
		// (get) Token: 0x0601903A RID: 102458 RVA: 0x003A5658 File Offset: 0x003A3858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowInvalidItemResponse.Descriptor;
			}
		}

		// Token: 0x0601903B RID: 102459 RVA: 0x003A565F File Offset: 0x003A385F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemResponse()
		{
		}

		// Token: 0x0601903C RID: 102460 RVA: 0x003A567D File Offset: 0x003A387D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemResponse(ShowInvalidItemResponse other) : this()
		{
			this.invalidItemList_ = other.invalidItemList_.Clone();
			this.expireConvertItemInfoList_ = other.expireConvertItemInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601903D RID: 102461 RVA: 0x003A56B8 File Offset: 0x003A38B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemResponse Clone()
		{
			return new ShowInvalidItemResponse(this);
		}

		// Token: 0x17005488 RID: 21640
		// (get) Token: 0x0601903E RID: 102462 RVA: 0x003A56C0 File Offset: 0x003A38C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InvalidItem> InvalidItemList
		{
			get
			{
				return this.invalidItemList_;
			}
		}

		// Token: 0x17005489 RID: 21641
		// (get) Token: 0x0601903F RID: 102463 RVA: 0x003A56C8 File Offset: 0x003A38C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExpireConvertItemInfo> ExpireConvertItemInfoList
		{
			get
			{
				return this.expireConvertItemInfoList_;
			}
		}

		// Token: 0x06019040 RID: 102464 RVA: 0x003A56D0 File Offset: 0x003A38D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowInvalidItemResponse);
		}

		// Token: 0x06019041 RID: 102465 RVA: 0x003A56E0 File Offset: 0x003A38E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowInvalidItemResponse other)
		{
			return other != null && (other == this || (this.invalidItemList_.Equals(other.invalidItemList_) && this.expireConvertItemInfoList_.Equals(other.expireConvertItemInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019042 RID: 102466 RVA: 0x003A5734 File Offset: 0x003A3934
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

		// Token: 0x06019043 RID: 102467 RVA: 0x003A5776 File Offset: 0x003A3976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019044 RID: 102468 RVA: 0x003A5783 File Offset: 0x003A3983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019045 RID: 102469 RVA: 0x003A578C File Offset: 0x003A398C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.invalidItemList_.WriteTo(ref output, ShowInvalidItemResponse._repeated_invalidItemList_codec);
			this.expireConvertItemInfoList_.WriteTo(ref output, ShowInvalidItemResponse._repeated_expireConvertItemInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019046 RID: 102470 RVA: 0x003A57C4 File Offset: 0x003A39C4
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

		// Token: 0x06019047 RID: 102471 RVA: 0x003A5810 File Offset: 0x003A3A10
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

		// Token: 0x06019048 RID: 102472 RVA: 0x003A584F File Offset: 0x003A3A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019049 RID: 102473 RVA: 0x003A5858 File Offset: 0x003A3A58
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
				if (num != 10U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.expireConvertItemInfoList_.AddEntriesFrom(ref input, ShowInvalidItemResponse._repeated_expireConvertItemInfoList_codec);
					}
				}
				else
				{
					this.invalidItemList_.AddEntriesFrom(ref input, ShowInvalidItemResponse._repeated_invalidItemList_codec);
				}
			}
		}

		// Token: 0x04009448 RID: 37960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009449 RID: 37961
		public const int InvalidItemListFieldNumber = 1;

		// Token: 0x0400944A RID: 37962
		private static readonly FieldCodec<InvalidItem> _repeated_invalidItemList_codec = FieldCodec.ForMessage<InvalidItem>(10U, InvalidItem.Parser);

		// Token: 0x0400944B RID: 37963
		private readonly RepeatedField<InvalidItem> invalidItemList_ = new RepeatedField<InvalidItem>();

		// Token: 0x0400944C RID: 37964
		public const int ExpireConvertItemInfoListFieldNumber = 13;

		// Token: 0x0400944D RID: 37965
		private static readonly FieldCodec<ExpireConvertItemInfo> _repeated_expireConvertItemInfoList_codec = FieldCodec.ForMessage<ExpireConvertItemInfo>(106U, ExpireConvertItemInfo.Parser);

		// Token: 0x0400944E RID: 37966
		private readonly RepeatedField<ExpireConvertItemInfo> expireConvertItemInfoList_ = new RepeatedField<ExpireConvertItemInfo>();
	}
}
