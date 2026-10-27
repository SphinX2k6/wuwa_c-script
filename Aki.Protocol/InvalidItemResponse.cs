using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083D RID: 2109
	[NetMessage(EMessageId.InvalidItemResponse)]
	public sealed class InvalidItemResponse : IMessage<InvalidItemResponse>, IMessage, IEquatable<InvalidItemResponse>, IDeepCloneable<InvalidItemResponse>, IBufferMessage
	{
		// Token: 0x0600BC52 RID: 48210 RVA: 0x001C031E File Offset: 0x001BE51E
		[NullableContext(1)]
		public static InvalidItemResponse Create()
		{
			return new InvalidItemResponse();
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x0600BC53 RID: 48211 RVA: 0x001C0325 File Offset: 0x001BE525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x0600BC54 RID: 48212 RVA: 0x001C0328 File Offset: 0x001BE528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvalidItemResponse.Descriptor;
			}
		}

		// Token: 0x0600BC55 RID: 48213 RVA: 0x001C032F File Offset: 0x001BE52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemResponse()
		{
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x001C0337 File Offset: 0x001BE537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemResponse(InvalidItemResponse other) : this()
		{
			this.hasInvalidItem_ = other.hasInvalidItem_;
			this.hasExpireConvertItem_ = other.hasExpireConvertItem_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC57 RID: 48215 RVA: 0x001C0368 File Offset: 0x001BE568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemResponse Clone()
		{
			return new InvalidItemResponse(this);
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x001C0370 File Offset: 0x001BE570
		// (set) Token: 0x0600BC59 RID: 48217 RVA: 0x001C0378 File Offset: 0x001BE578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasInvalidItem
		{
			get
			{
				return this.hasInvalidItem_;
			}
			set
			{
				this.hasInvalidItem_ = value;
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x0600BC5A RID: 48218 RVA: 0x001C0381 File Offset: 0x001BE581
		// (set) Token: 0x0600BC5B RID: 48219 RVA: 0x001C0389 File Offset: 0x001BE589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasExpireConvertItem
		{
			get
			{
				return this.hasExpireConvertItem_;
			}
			set
			{
				this.hasExpireConvertItem_ = value;
			}
		}

		// Token: 0x0600BC5C RID: 48220 RVA: 0x001C0392 File Offset: 0x001BE592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvalidItemResponse);
		}

		// Token: 0x0600BC5D RID: 48221 RVA: 0x001C03A0 File Offset: 0x001BE5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvalidItemResponse other)
		{
			return other != null && (other == this || (this.HasInvalidItem == other.HasInvalidItem && this.HasExpireConvertItem == other.HasExpireConvertItem && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC5E RID: 48222 RVA: 0x001C03E0 File Offset: 0x001BE5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasInvalidItem)
			{
				num ^= this.HasInvalidItem.GetHashCode();
			}
			if (this.HasExpireConvertItem)
			{
				num ^= this.HasExpireConvertItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC5F RID: 48223 RVA: 0x001C0438 File Offset: 0x001BE638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC60 RID: 48224 RVA: 0x001C0445 File Offset: 0x001BE645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC61 RID: 48225 RVA: 0x001C0450 File Offset: 0x001BE650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasExpireConvertItem)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.HasExpireConvertItem);
			}
			if (this.HasInvalidItem)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.HasInvalidItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x001C04A8 File Offset: 0x001BE6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasInvalidItem)
			{
				num += 2;
			}
			if (this.HasExpireConvertItem)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC63 RID: 48227 RVA: 0x001C04E8 File Offset: 0x001BE6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InvalidItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasInvalidItem)
			{
				this.HasInvalidItem = other.HasInvalidItem;
			}
			if (other.HasExpireConvertItem)
			{
				this.HasExpireConvertItem = other.HasExpireConvertItem;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x001C0538 File Offset: 0x001BE738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x001C0544 File Offset: 0x001BE744
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
				if (num != 8U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HasInvalidItem = input.ReadBool();
					}
				}
				else
				{
					this.HasExpireConvertItem = input.ReadBool();
				}
			}
		}

		// Token: 0x0400527C RID: 21116
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400527D RID: 21117
		public const int HasInvalidItemFieldNumber = 8;

		// Token: 0x0400527E RID: 21118
		private bool hasInvalidItem_;

		// Token: 0x0400527F RID: 21119
		public const int HasExpireConvertItemFieldNumber = 1;

		// Token: 0x04005280 RID: 21120
		private bool hasExpireConvertItem_;
	}
}
