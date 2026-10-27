using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C3 RID: 5315
	[NetMessage(EMessageId.ValidTimeItemResponse)]
	public sealed class ValidTimeItemResponse : IMessage<ValidTimeItemResponse>, IMessage, IEquatable<ValidTimeItemResponse>, IDeepCloneable<ValidTimeItemResponse>, IBufferMessage
	{
		// Token: 0x0601C1AD RID: 115117 RVA: 0x0041002E File Offset: 0x0040E22E
		[NullableContext(1)]
		public static ValidTimeItemResponse Create()
		{
			return new ValidTimeItemResponse();
		}

		// Token: 0x17005EB9 RID: 24249
		// (get) Token: 0x0601C1AE RID: 115118 RVA: 0x00410035 File Offset: 0x0040E235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EBA RID: 24250
		// (get) Token: 0x0601C1AF RID: 115119 RVA: 0x00410038 File Offset: 0x0040E238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemResponse.Descriptor;
			}
		}

		// Token: 0x0601C1B0 RID: 115120 RVA: 0x0041003F File Offset: 0x0040E23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemResponse()
		{
		}

		// Token: 0x0601C1B1 RID: 115121 RVA: 0x00410052 File Offset: 0x0040E252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemResponse(ValidTimeItemResponse other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1B2 RID: 115122 RVA: 0x0041007C File Offset: 0x0040E27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemResponse Clone()
		{
			return new ValidTimeItemResponse(this);
		}

		// Token: 0x17005EBB RID: 24251
		// (get) Token: 0x0601C1B3 RID: 115123 RVA: 0x00410084 File Offset: 0x0040E284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ValidTimeItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0601C1B4 RID: 115124 RVA: 0x0041008C File Offset: 0x0040E28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemResponse);
		}

		// Token: 0x0601C1B5 RID: 115125 RVA: 0x0041009A File Offset: 0x0040E29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemResponse other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C1B6 RID: 115126 RVA: 0x004100D0 File Offset: 0x0040E2D0
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

		// Token: 0x0601C1B7 RID: 115127 RVA: 0x00410104 File Offset: 0x0040E304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C1B8 RID: 115128 RVA: 0x00410111 File Offset: 0x0040E311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1B9 RID: 115129 RVA: 0x0041011A File Offset: 0x0040E31A
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

		// Token: 0x0601C1BA RID: 115130 RVA: 0x00410144 File Offset: 0x0040E344
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

		// Token: 0x0601C1BB RID: 115131 RVA: 0x0041017D File Offset: 0x0040E37D
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

		// Token: 0x0601C1BC RID: 115132 RVA: 0x004101AB File Offset: 0x0040E3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1BD RID: 115133 RVA: 0x004101B4 File Offset: 0x0040E3B4
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ValidTimeItemResponse._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x0400A157 RID: 41303
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A158 RID: 41304
		public const int ItemListFieldNumber = 14;

		// Token: 0x0400A159 RID: 41305
		private static readonly FieldCodec<ValidTimeItem> _repeated_itemList_codec = FieldCodec.ForMessage<ValidTimeItem>(114U, ValidTimeItem.Parser);

		// Token: 0x0400A15A RID: 41306
		private readonly RepeatedField<ValidTimeItem> itemList_ = new RepeatedField<ValidTimeItem>();
	}
}
