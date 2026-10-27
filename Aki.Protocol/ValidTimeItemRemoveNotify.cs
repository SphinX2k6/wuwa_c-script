using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C1 RID: 5313
	[NetMessage(EMessageId.ValidTimeItemRemoveNotify)]
	public sealed class ValidTimeItemRemoveNotify : IMessage<ValidTimeItemRemoveNotify>, IMessage, IEquatable<ValidTimeItemRemoveNotify>, IDeepCloneable<ValidTimeItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x0601C18B RID: 115083 RVA: 0x0040FD14 File Offset: 0x0040DF14
		[NullableContext(1)]
		public static ValidTimeItemRemoveNotify Create()
		{
			return new ValidTimeItemRemoveNotify();
		}

		// Token: 0x17005EB4 RID: 24244
		// (get) Token: 0x0601C18C RID: 115084 RVA: 0x0040FD1B File Offset: 0x0040DF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB5 RID: 24245
		// (get) Token: 0x0601C18D RID: 115085 RVA: 0x0040FD1E File Offset: 0x0040DF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0601C18E RID: 115086 RVA: 0x0040FD25 File Offset: 0x0040DF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRemoveNotify()
		{
		}

		// Token: 0x0601C18F RID: 115087 RVA: 0x0040FD38 File Offset: 0x0040DF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRemoveNotify(ValidTimeItemRemoveNotify other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C190 RID: 115088 RVA: 0x0040FD62 File Offset: 0x0040DF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRemoveNotify Clone()
		{
			return new ValidTimeItemRemoveNotify(this);
		}

		// Token: 0x17005EB6 RID: 24246
		// (get) Token: 0x0601C191 RID: 115089 RVA: 0x0040FD6A File Offset: 0x0040DF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RemoveValidTimeItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0601C192 RID: 115090 RVA: 0x0040FD72 File Offset: 0x0040DF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemRemoveNotify);
		}

		// Token: 0x0601C193 RID: 115091 RVA: 0x0040FD80 File Offset: 0x0040DF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemRemoveNotify other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C194 RID: 115092 RVA: 0x0040FDB4 File Offset: 0x0040DFB4
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

		// Token: 0x0601C195 RID: 115093 RVA: 0x0040FDE8 File Offset: 0x0040DFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C196 RID: 115094 RVA: 0x0040FDF5 File Offset: 0x0040DFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C197 RID: 115095 RVA: 0x0040FDFE File Offset: 0x0040DFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ValidTimeItemRemoveNotify._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C198 RID: 115096 RVA: 0x0040FE28 File Offset: 0x0040E028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ValidTimeItemRemoveNotify._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C199 RID: 115097 RVA: 0x0040FE61 File Offset: 0x0040E061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ValidTimeItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C19A RID: 115098 RVA: 0x0040FE8F File Offset: 0x0040E08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C19B RID: 115099 RVA: 0x0040FE98 File Offset: 0x0040E098
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
					this.itemList_.AddEntriesFrom(ref input, ValidTimeItemRemoveNotify._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x0400A152 RID: 41298
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A153 RID: 41299
		public const int ItemListFieldNumber = 8;

		// Token: 0x0400A154 RID: 41300
		private static readonly FieldCodec<RemoveValidTimeItem> _repeated_itemList_codec = FieldCodec.ForMessage<RemoveValidTimeItem>(66U, RemoveValidTimeItem.Parser);

		// Token: 0x0400A155 RID: 41301
		private readonly RepeatedField<RemoveValidTimeItem> itemList_ = new RepeatedField<RemoveValidTimeItem>();
	}
}
