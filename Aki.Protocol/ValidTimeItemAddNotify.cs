using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001536 RID: 5430
	[NetMessage(EMessageId.ValidTimeItemAddNotify)]
	public sealed class ValidTimeItemAddNotify : IMessage<ValidTimeItemAddNotify>, IMessage, IEquatable<ValidTimeItemAddNotify>, IDeepCloneable<ValidTimeItemAddNotify>, IBufferMessage
	{
		// Token: 0x0601CC3E RID: 117822 RVA: 0x0042B525 File Offset: 0x00429725
		[NullableContext(1)]
		public static ValidTimeItemAddNotify Create()
		{
			return new ValidTimeItemAddNotify();
		}

		// Token: 0x17006151 RID: 24913
		// (get) Token: 0x0601CC3F RID: 117823 RVA: 0x0042B52C File Offset: 0x0042972C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006152 RID: 24914
		// (get) Token: 0x0601CC40 RID: 117824 RVA: 0x0042B52F File Offset: 0x0042972F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemAddNotify.Descriptor;
			}
		}

		// Token: 0x0601CC41 RID: 117825 RVA: 0x0042B536 File Offset: 0x00429736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemAddNotify()
		{
		}

		// Token: 0x0601CC42 RID: 117826 RVA: 0x0042B549 File Offset: 0x00429749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemAddNotify(ValidTimeItemAddNotify other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC43 RID: 117827 RVA: 0x0042B57F File Offset: 0x0042977F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemAddNotify Clone()
		{
			return new ValidTimeItemAddNotify(this);
		}

		// Token: 0x17006153 RID: 24915
		// (get) Token: 0x0601CC44 RID: 117828 RVA: 0x0042B587 File Offset: 0x00429787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ValidTimeItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x17006154 RID: 24916
		// (get) Token: 0x0601CC45 RID: 117829 RVA: 0x0042B58F File Offset: 0x0042978F
		// (set) Token: 0x0601CC46 RID: 117830 RVA: 0x0042B597 File Offset: 0x00429797
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

		// Token: 0x0601CC47 RID: 117831 RVA: 0x0042B5A0 File Offset: 0x004297A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemAddNotify);
		}

		// Token: 0x0601CC48 RID: 117832 RVA: 0x0042B5B0 File Offset: 0x004297B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemAddNotify other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CC49 RID: 117833 RVA: 0x0042B600 File Offset: 0x00429800
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

		// Token: 0x0601CC4A RID: 117834 RVA: 0x0042B64D File Offset: 0x0042984D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC4B RID: 117835 RVA: 0x0042B65A File Offset: 0x0042985A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC4C RID: 117836 RVA: 0x0042B664 File Offset: 0x00429864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ValidTimeItemAddNotify._repeated_itemList_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC4D RID: 117837 RVA: 0x0042B6B4 File Offset: 0x004298B4
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

		// Token: 0x0601CC4E RID: 117838 RVA: 0x0042B708 File Offset: 0x00429908
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

		// Token: 0x0601CC4F RID: 117839 RVA: 0x0042B755 File Offset: 0x00429955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC50 RID: 117840 RVA: 0x0042B760 File Offset: 0x00429960
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
				if (num != 74U)
				{
					if (num != 96U)
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

		// Token: 0x0400A5A5 RID: 42405
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5A6 RID: 42406
		public const int ItemListFieldNumber = 9;

		// Token: 0x0400A5A7 RID: 42407
		private static readonly FieldCodec<ValidTimeItem> _repeated_itemList_codec = FieldCodec.ForMessage<ValidTimeItem>(74U, ValidTimeItem.Parser);

		// Token: 0x0400A5A8 RID: 42408
		private readonly RepeatedField<ValidTimeItem> itemList_ = new RepeatedField<ValidTimeItem>();

		// Token: 0x0400A5A9 RID: 42409
		public const int ReasonFieldNumber = 12;

		// Token: 0x0400A5AA RID: 42410
		private int reason_;
	}
}
