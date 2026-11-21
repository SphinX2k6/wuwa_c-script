using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200153A RID: 5434
	[NetMessage(EMessageId.ValidTimeItemUpdateNotify)]
	public sealed class ValidTimeItemUpdateNotify : IMessage<ValidTimeItemUpdateNotify>, IMessage, IEquatable<ValidTimeItemUpdateNotify>, IDeepCloneable<ValidTimeItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601CC86 RID: 117894 RVA: 0x0042BCCD File Offset: 0x00429ECD
		[NullableContext(1)]
		public static ValidTimeItemUpdateNotify Create()
		{
			return new ValidTimeItemUpdateNotify();
		}

		// Token: 0x1700615D RID: 24925
		// (get) Token: 0x0601CC87 RID: 117895 RVA: 0x0042BCD4 File Offset: 0x00429ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700615E RID: 24926
		// (get) Token: 0x0601CC88 RID: 117896 RVA: 0x0042BCD7 File Offset: 0x00429ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601CC89 RID: 117897 RVA: 0x0042BCDE File Offset: 0x00429EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemUpdateNotify()
		{
		}

		// Token: 0x0601CC8A RID: 117898 RVA: 0x0042BCF1 File Offset: 0x00429EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemUpdateNotify(ValidTimeItemUpdateNotify other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC8B RID: 117899 RVA: 0x0042BD1B File Offset: 0x00429F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemUpdateNotify Clone()
		{
			return new ValidTimeItemUpdateNotify(this);
		}

		// Token: 0x1700615F RID: 24927
		// (get) Token: 0x0601CC8C RID: 117900 RVA: 0x0042BD23 File Offset: 0x00429F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ValidTimeItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0601CC8D RID: 117901 RVA: 0x0042BD2B File Offset: 0x00429F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemUpdateNotify);
		}

		// Token: 0x0601CC8E RID: 117902 RVA: 0x0042BD39 File Offset: 0x00429F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemUpdateNotify other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CC8F RID: 117903 RVA: 0x0042BD6C File Offset: 0x00429F6C
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

		// Token: 0x0601CC90 RID: 117904 RVA: 0x0042BDA0 File Offset: 0x00429FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC91 RID: 117905 RVA: 0x0042BDAD File Offset: 0x00429FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC92 RID: 117906 RVA: 0x0042BDB6 File Offset: 0x00429FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ValidTimeItemUpdateNotify._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC93 RID: 117907 RVA: 0x0042BDE0 File Offset: 0x00429FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ValidTimeItemUpdateNotify._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CC94 RID: 117908 RVA: 0x0042BE19 File Offset: 0x0042A019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ValidTimeItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CC95 RID: 117909 RVA: 0x0042BE47 File Offset: 0x0042A047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC96 RID: 117910 RVA: 0x0042BE50 File Offset: 0x0042A050
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ValidTimeItemUpdateNotify._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x0400A5B4 RID: 42420
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5B5 RID: 42421
		public const int ItemListFieldNumber = 8;

		// Token: 0x0400A5B6 RID: 42422
		private static readonly FieldCodec<ValidTimeItem> _repeated_itemList_codec = FieldCodec.ForMessage<ValidTimeItem>(66U, ValidTimeItem.Parser);

		// Token: 0x0400A5B7 RID: 42423
		private readonly RepeatedField<ValidTimeItem> itemList_ = new RepeatedField<ValidTimeItem>();
	}
}
