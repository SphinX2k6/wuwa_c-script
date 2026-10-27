using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C4 RID: 5316
	[NetMessage(EMessageId.ValidTimeItemUpdateNotify)]
	public sealed class ValidTimeItemUpdateNotify : IMessage<ValidTimeItemUpdateNotify>, IMessage, IEquatable<ValidTimeItemUpdateNotify>, IDeepCloneable<ValidTimeItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C1BF RID: 115135 RVA: 0x00410211 File Offset: 0x0040E411
		[NullableContext(1)]
		public static ValidTimeItemUpdateNotify Create()
		{
			return new ValidTimeItemUpdateNotify();
		}

		// Token: 0x17005EBC RID: 24252
		// (get) Token: 0x0601C1C0 RID: 115136 RVA: 0x00410218 File Offset: 0x0040E418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EBD RID: 24253
		// (get) Token: 0x0601C1C1 RID: 115137 RVA: 0x0041021B File Offset: 0x0040E41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C1C2 RID: 115138 RVA: 0x00410222 File Offset: 0x0040E422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemUpdateNotify()
		{
		}

		// Token: 0x0601C1C3 RID: 115139 RVA: 0x00410235 File Offset: 0x0040E435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemUpdateNotify(ValidTimeItemUpdateNotify other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1C4 RID: 115140 RVA: 0x0041025F File Offset: 0x0040E45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemUpdateNotify Clone()
		{
			return new ValidTimeItemUpdateNotify(this);
		}

		// Token: 0x17005EBE RID: 24254
		// (get) Token: 0x0601C1C5 RID: 115141 RVA: 0x00410267 File Offset: 0x0040E467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ValidTimeItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0601C1C6 RID: 115142 RVA: 0x0041026F File Offset: 0x0040E46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemUpdateNotify);
		}

		// Token: 0x0601C1C7 RID: 115143 RVA: 0x0041027D File Offset: 0x0040E47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemUpdateNotify other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C1C8 RID: 115144 RVA: 0x004102B0 File Offset: 0x0040E4B0
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

		// Token: 0x0601C1C9 RID: 115145 RVA: 0x004102E4 File Offset: 0x0040E4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C1CA RID: 115146 RVA: 0x004102F1 File Offset: 0x0040E4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1CB RID: 115147 RVA: 0x004102FA File Offset: 0x0040E4FA
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

		// Token: 0x0601C1CC RID: 115148 RVA: 0x00410324 File Offset: 0x0040E524
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

		// Token: 0x0601C1CD RID: 115149 RVA: 0x0041035D File Offset: 0x0040E55D
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

		// Token: 0x0601C1CE RID: 115150 RVA: 0x0041038B File Offset: 0x0040E58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1CF RID: 115151 RVA: 0x00410394 File Offset: 0x0040E594
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ValidTimeItemUpdateNotify._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x0400A15B RID: 41307
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A15C RID: 41308
		public const int ItemListFieldNumber = 13;

		// Token: 0x0400A15D RID: 41309
		private static readonly FieldCodec<ValidTimeItem> _repeated_itemList_codec = FieldCodec.ForMessage<ValidTimeItem>(106U, ValidTimeItem.Parser);

		// Token: 0x0400A15E RID: 41310
		private readonly RepeatedField<ValidTimeItem> itemList_ = new RepeatedField<ValidTimeItem>();
	}
}
