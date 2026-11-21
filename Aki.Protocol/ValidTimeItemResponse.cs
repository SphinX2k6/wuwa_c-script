using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001539 RID: 5433
	[NetMessage(EMessageId.ValidTimeItemResponse)]
	public sealed class ValidTimeItemResponse : IMessage<ValidTimeItemResponse>, IMessage, IEquatable<ValidTimeItemResponse>, IDeepCloneable<ValidTimeItemResponse>, IBufferMessage
	{
		// Token: 0x0601CC74 RID: 117876 RVA: 0x0042BAEA File Offset: 0x00429CEA
		[NullableContext(1)]
		public static ValidTimeItemResponse Create()
		{
			return new ValidTimeItemResponse();
		}

		// Token: 0x1700615A RID: 24922
		// (get) Token: 0x0601CC75 RID: 117877 RVA: 0x0042BAF1 File Offset: 0x00429CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700615B RID: 24923
		// (get) Token: 0x0601CC76 RID: 117878 RVA: 0x0042BAF4 File Offset: 0x00429CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemResponse.Descriptor;
			}
		}

		// Token: 0x0601CC77 RID: 117879 RVA: 0x0042BAFB File Offset: 0x00429CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemResponse()
		{
		}

		// Token: 0x0601CC78 RID: 117880 RVA: 0x0042BB0E File Offset: 0x00429D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemResponse(ValidTimeItemResponse other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC79 RID: 117881 RVA: 0x0042BB38 File Offset: 0x00429D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemResponse Clone()
		{
			return new ValidTimeItemResponse(this);
		}

		// Token: 0x1700615C RID: 24924
		// (get) Token: 0x0601CC7A RID: 117882 RVA: 0x0042BB40 File Offset: 0x00429D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ValidTimeItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0601CC7B RID: 117883 RVA: 0x0042BB48 File Offset: 0x00429D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemResponse);
		}

		// Token: 0x0601CC7C RID: 117884 RVA: 0x0042BB56 File Offset: 0x00429D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemResponse other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CC7D RID: 117885 RVA: 0x0042BB8C File Offset: 0x00429D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CC7E RID: 117886 RVA: 0x0042BBC0 File Offset: 0x00429DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC7F RID: 117887 RVA: 0x0042BBCD File Offset: 0x00429DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC80 RID: 117888 RVA: 0x0042BBD6 File Offset: 0x00429DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ValidTimeItemResponse._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC81 RID: 117889 RVA: 0x0042BC00 File Offset: 0x00429E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ValidTimeItemResponse._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CC82 RID: 117890 RVA: 0x0042BC39 File Offset: 0x00429E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ValidTimeItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CC83 RID: 117891 RVA: 0x0042BC67 File Offset: 0x00429E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC84 RID: 117892 RVA: 0x0042BC70 File Offset: 0x00429E70
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ValidTimeItemResponse._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x0400A5B0 RID: 42416
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5B1 RID: 42417
		public const int ItemListFieldNumber = 12;

		// Token: 0x0400A5B2 RID: 42418
		private static readonly FieldCodec<ValidTimeItem> _repeated_itemList_codec = FieldCodec.ForMessage<ValidTimeItem>(98U, ValidTimeItem.Parser);

		// Token: 0x0400A5B3 RID: 42419
		private readonly RepeatedField<ValidTimeItem> itemList_ = new RepeatedField<ValidTimeItem>();
	}
}
