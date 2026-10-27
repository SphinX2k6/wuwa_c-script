using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085E RID: 2142
	[NetMessage(EMessageId.ItemUseResponse)]
	public sealed class ItemUseResponse : IMessage<ItemUseResponse>, IMessage, IEquatable<ItemUseResponse>, IDeepCloneable<ItemUseResponse>, IBufferMessage
	{
		// Token: 0x0600BEF1 RID: 48881 RVA: 0x001C5AA0 File Offset: 0x001C3CA0
		[NullableContext(1)]
		public static ItemUseResponse Create()
		{
			return new ItemUseResponse();
		}

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x0600BEF2 RID: 48882 RVA: 0x001C5AA7 File Offset: 0x001C3CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x0600BEF3 RID: 48883 RVA: 0x001C5AAA File Offset: 0x001C3CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemUseResponse.Descriptor;
			}
		}

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x001C5AB1 File Offset: 0x001C3CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseResponse()
		{
		}

		// Token: 0x0600BEF5 RID: 48885 RVA: 0x001C5AB9 File Offset: 0x001C3CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseResponse(ItemUseResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BEF6 RID: 48886 RVA: 0x001C5ADE File Offset: 0x001C3CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseResponse Clone()
		{
			return new ItemUseResponse(this);
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x0600BEF7 RID: 48887 RVA: 0x001C5AE6 File Offset: 0x001C3CE6
		// (set) Token: 0x0600BEF8 RID: 48888 RVA: 0x001C5AEE File Offset: 0x001C3CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600BEF9 RID: 48889 RVA: 0x001C5AF7 File Offset: 0x001C3CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemUseResponse);
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x001C5B05 File Offset: 0x001C3D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemUseResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEFB RID: 48891 RVA: 0x001C5B34 File Offset: 0x001C3D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BEFC RID: 48892 RVA: 0x001C5B79 File Offset: 0x001C3D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BEFD RID: 48893 RVA: 0x001C5B86 File Offset: 0x001C3D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEFE RID: 48894 RVA: 0x001C5B8F File Offset: 0x001C3D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEFF RID: 48895 RVA: 0x001C5BC4 File Offset: 0x001C3DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x001C5C02 File Offset: 0x001C3E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemUseResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF01 RID: 48897 RVA: 0x001C5C33 File Offset: 0x001C3E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x001C5C3C File Offset: 0x001C3E3C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005338 RID: 21304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005339 RID: 21305
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x0400533A RID: 21306
		private ErrorCode errCode_;
	}
}
