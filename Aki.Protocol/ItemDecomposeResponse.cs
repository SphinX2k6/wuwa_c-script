using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000834 RID: 2100
	[NetMessage(EMessageId.ItemDecomposeResponse)]
	public sealed class ItemDecomposeResponse : IMessage<ItemDecomposeResponse>, IMessage, IEquatable<ItemDecomposeResponse>, IDeepCloneable<ItemDecomposeResponse>, IBufferMessage
	{
		// Token: 0x0600BBD8 RID: 48088 RVA: 0x001BF4ED File Offset: 0x001BD6ED
		[NullableContext(1)]
		public static ItemDecomposeResponse Create()
		{
			return new ItemDecomposeResponse();
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x0600BBD9 RID: 48089 RVA: 0x001BF4F4 File Offset: 0x001BD6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x0600BBDA RID: 48090 RVA: 0x001BF4F7 File Offset: 0x001BD6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDecomposeResponse.Descriptor;
			}
		}

		// Token: 0x0600BBDB RID: 48091 RVA: 0x001BF4FE File Offset: 0x001BD6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeResponse()
		{
		}

		// Token: 0x0600BBDC RID: 48092 RVA: 0x001BF506 File Offset: 0x001BD706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeResponse(ItemDecomposeResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBDD RID: 48093 RVA: 0x001BF52B File Offset: 0x001BD72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeResponse Clone()
		{
			return new ItemDecomposeResponse(this);
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x0600BBDE RID: 48094 RVA: 0x001BF533 File Offset: 0x001BD733
		// (set) Token: 0x0600BBDF RID: 48095 RVA: 0x001BF53B File Offset: 0x001BD73B
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

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x001BF544 File Offset: 0x001BD744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDecomposeResponse);
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x001BF552 File Offset: 0x001BD752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDecomposeResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBE2 RID: 48098 RVA: 0x001BF580 File Offset: 0x001BD780
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

		// Token: 0x0600BBE3 RID: 48099 RVA: 0x001BF5C5 File Offset: 0x001BD7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBE4 RID: 48100 RVA: 0x001BF5D2 File Offset: 0x001BD7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBE5 RID: 48101 RVA: 0x001BF5DB File Offset: 0x001BD7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBE6 RID: 48102 RVA: 0x001BF610 File Offset: 0x001BD810
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

		// Token: 0x0600BBE7 RID: 48103 RVA: 0x001BF64E File Offset: 0x001BD84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDecomposeResponse other)
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

		// Token: 0x0600BBE8 RID: 48104 RVA: 0x001BF67F File Offset: 0x001BD87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBE9 RID: 48105 RVA: 0x001BF688 File Offset: 0x001BD888
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040052AF RID: 21167
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052B0 RID: 21168
		public const int ErrCodeFieldNumber = 3;

		// Token: 0x040052B1 RID: 21169
		private ErrorCode errCode_;
	}
}
