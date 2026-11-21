using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000829 RID: 2089
	[NetMessage(EMessageId.InvalidItemResponse)]
	public sealed class InvalidItemResponse : IMessage<InvalidItemResponse>, IMessage, IEquatable<InvalidItemResponse>, IDeepCloneable<InvalidItemResponse>, IBufferMessage
	{
		// Token: 0x0600BAFC RID: 47868 RVA: 0x001BD8E2 File Offset: 0x001BBAE2
		[NullableContext(1)]
		public static InvalidItemResponse Create()
		{
			return new InvalidItemResponse();
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x0600BAFD RID: 47869 RVA: 0x001BD8E9 File Offset: 0x001BBAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x0600BAFE RID: 47870 RVA: 0x001BD8EC File Offset: 0x001BBAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvalidItemResponse.Descriptor;
			}
		}

		// Token: 0x0600BAFF RID: 47871 RVA: 0x001BD8F3 File Offset: 0x001BBAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemResponse()
		{
		}

		// Token: 0x0600BB00 RID: 47872 RVA: 0x001BD8FB File Offset: 0x001BBAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemResponse(InvalidItemResponse other) : this()
		{
			this.hasInvalidItem_ = other.hasInvalidItem_;
			this.hasExpireConvertItem_ = other.hasExpireConvertItem_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB01 RID: 47873 RVA: 0x001BD92C File Offset: 0x001BBB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemResponse Clone()
		{
			return new InvalidItemResponse(this);
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x0600BB02 RID: 47874 RVA: 0x001BD934 File Offset: 0x001BBB34
		// (set) Token: 0x0600BB03 RID: 47875 RVA: 0x001BD93C File Offset: 0x001BBB3C
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

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x0600BB04 RID: 47876 RVA: 0x001BD945 File Offset: 0x001BBB45
		// (set) Token: 0x0600BB05 RID: 47877 RVA: 0x001BD94D File Offset: 0x001BBB4D
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

		// Token: 0x0600BB06 RID: 47878 RVA: 0x001BD956 File Offset: 0x001BBB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvalidItemResponse);
		}

		// Token: 0x0600BB07 RID: 47879 RVA: 0x001BD964 File Offset: 0x001BBB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvalidItemResponse other)
		{
			return other != null && (other == this || (this.HasInvalidItem == other.HasInvalidItem && this.HasExpireConvertItem == other.HasExpireConvertItem && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB08 RID: 47880 RVA: 0x001BD9A4 File Offset: 0x001BBBA4
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

		// Token: 0x0600BB09 RID: 47881 RVA: 0x001BD9FC File Offset: 0x001BBBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB0A RID: 47882 RVA: 0x001BDA09 File Offset: 0x001BBC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x001BDA14 File Offset: 0x001BBC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasInvalidItem)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.HasInvalidItem);
			}
			if (this.HasExpireConvertItem)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.HasExpireConvertItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB0C RID: 47884 RVA: 0x001BDA70 File Offset: 0x001BBC70
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

		// Token: 0x0600BB0D RID: 47885 RVA: 0x001BDAB0 File Offset: 0x001BBCB0
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

		// Token: 0x0600BB0E RID: 47886 RVA: 0x001BDB00 File Offset: 0x001BBD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB0F RID: 47887 RVA: 0x001BDB0C File Offset: 0x001BBD0C
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
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HasExpireConvertItem = input.ReadBool();
					}
				}
				else
				{
					this.HasInvalidItem = input.ReadBool();
				}
			}
		}

		// Token: 0x04005275 RID: 21109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005276 RID: 21110
		public const int HasInvalidItemFieldNumber = 12;

		// Token: 0x04005277 RID: 21111
		private bool hasInvalidItem_;

		// Token: 0x04005278 RID: 21112
		public const int HasExpireConvertItemFieldNumber = 14;

		// Token: 0x04005279 RID: 21113
		private bool hasExpireConvertItem_;
	}
}
