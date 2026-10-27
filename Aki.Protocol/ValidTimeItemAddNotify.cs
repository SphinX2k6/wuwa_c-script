using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C0 RID: 5312
	[NetMessage(EMessageId.ValidTimeItemAddNotify)]
	public sealed class ValidTimeItemAddNotify : IMessage<ValidTimeItemAddNotify>, IMessage, IEquatable<ValidTimeItemAddNotify>, IDeepCloneable<ValidTimeItemAddNotify>, IBufferMessage
	{
		// Token: 0x0601C177 RID: 115063 RVA: 0x0040FA69 File Offset: 0x0040DC69
		[NullableContext(1)]
		public static ValidTimeItemAddNotify Create()
		{
			return new ValidTimeItemAddNotify();
		}

		// Token: 0x17005EB0 RID: 24240
		// (get) Token: 0x0601C178 RID: 115064 RVA: 0x0040FA70 File Offset: 0x0040DC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB1 RID: 24241
		// (get) Token: 0x0601C179 RID: 115065 RVA: 0x0040FA73 File Offset: 0x0040DC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemAddNotify.Descriptor;
			}
		}

		// Token: 0x0601C17A RID: 115066 RVA: 0x0040FA7A File Offset: 0x0040DC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemAddNotify()
		{
		}

		// Token: 0x0601C17B RID: 115067 RVA: 0x0040FA8D File Offset: 0x0040DC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemAddNotify(ValidTimeItemAddNotify other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C17C RID: 115068 RVA: 0x0040FAC3 File Offset: 0x0040DCC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemAddNotify Clone()
		{
			return new ValidTimeItemAddNotify(this);
		}

		// Token: 0x17005EB2 RID: 24242
		// (get) Token: 0x0601C17D RID: 115069 RVA: 0x0040FACB File Offset: 0x0040DCCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ValidTimeItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x17005EB3 RID: 24243
		// (get) Token: 0x0601C17E RID: 115070 RVA: 0x0040FAD3 File Offset: 0x0040DCD3
		// (set) Token: 0x0601C17F RID: 115071 RVA: 0x0040FADB File Offset: 0x0040DCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0601C180 RID: 115072 RVA: 0x0040FAE4 File Offset: 0x0040DCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemAddNotify);
		}

		// Token: 0x0601C181 RID: 115073 RVA: 0x0040FAF4 File Offset: 0x0040DCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemAddNotify other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C182 RID: 115074 RVA: 0x0040FB44 File Offset: 0x0040DD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C183 RID: 115075 RVA: 0x0040FB91 File Offset: 0x0040DD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C184 RID: 115076 RVA: 0x0040FB9E File Offset: 0x0040DD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C185 RID: 115077 RVA: 0x0040FBA8 File Offset: 0x0040DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ValidTimeItemAddNotify._repeated_itemList_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C186 RID: 115078 RVA: 0x0040FBF8 File Offset: 0x0040DDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ValidTimeItemAddNotify._repeated_itemList_codec);
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C187 RID: 115079 RVA: 0x0040FC4C File Offset: 0x0040DE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ValidTimeItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C188 RID: 115080 RVA: 0x0040FC99 File Offset: 0x0040DE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C189 RID: 115081 RVA: 0x0040FCA4 File Offset: 0x0040DEA4
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = input.ReadInt32();
					}
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ValidTimeItemAddNotify._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x0400A14C RID: 41292
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A14D RID: 41293
		public const int ItemListFieldNumber = 12;

		// Token: 0x0400A14E RID: 41294
		private static readonly FieldCodec<ValidTimeItem> _repeated_itemList_codec = FieldCodec.ForMessage<ValidTimeItem>(98U, ValidTimeItem.Parser);

		// Token: 0x0400A14F RID: 41295
		private readonly RepeatedField<ValidTimeItem> itemList_ = new RepeatedField<ValidTimeItem>();

		// Token: 0x0400A150 RID: 41296
		public const int ReasonFieldNumber = 14;

		// Token: 0x0400A151 RID: 41297
		private int reason_;
	}
}
