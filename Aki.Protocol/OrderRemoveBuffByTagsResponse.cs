using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9A RID: 2970
	[NetMessage(EMessageId.OrderRemoveBuffByTagsResponse)]
	public sealed class OrderRemoveBuffByTagsResponse : IMessage<OrderRemoveBuffByTagsResponse>, IMessage, IEquatable<OrderRemoveBuffByTagsResponse>, IDeepCloneable<OrderRemoveBuffByTagsResponse>, IBufferMessage
	{
		// Token: 0x0601021A RID: 66074 RVA: 0x0025B82C File Offset: 0x00259A2C
		[NullableContext(1)]
		public static OrderRemoveBuffByTagsResponse Create()
		{
			return new OrderRemoveBuffByTagsResponse();
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0601021B RID: 66075 RVA: 0x0025B833 File Offset: 0x00259A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0601021C RID: 66076 RVA: 0x0025B836 File Offset: 0x00259A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffByTagsResponse.Descriptor;
			}
		}

		// Token: 0x0601021D RID: 66077 RVA: 0x0025B83D File Offset: 0x00259A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsResponse()
		{
		}

		// Token: 0x0601021E RID: 66078 RVA: 0x0025B845 File Offset: 0x00259A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsResponse(OrderRemoveBuffByTagsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601021F RID: 66079 RVA: 0x0025B86A File Offset: 0x00259A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsResponse Clone()
		{
			return new OrderRemoveBuffByTagsResponse(this);
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x06010220 RID: 66080 RVA: 0x0025B872 File Offset: 0x00259A72
		// (set) Token: 0x06010221 RID: 66081 RVA: 0x0025B87A File Offset: 0x00259A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06010222 RID: 66082 RVA: 0x0025B883 File Offset: 0x00259A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffByTagsResponse);
		}

		// Token: 0x06010223 RID: 66083 RVA: 0x0025B891 File Offset: 0x00259A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffByTagsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010224 RID: 66084 RVA: 0x0025B8C0 File Offset: 0x00259AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010225 RID: 66085 RVA: 0x0025B905 File Offset: 0x00259B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010226 RID: 66086 RVA: 0x0025B912 File Offset: 0x00259B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010227 RID: 66087 RVA: 0x0025B91B File Offset: 0x00259B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010228 RID: 66088 RVA: 0x0025B950 File Offset: 0x00259B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010229 RID: 66089 RVA: 0x0025B98E File Offset: 0x00259B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderRemoveBuffByTagsResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601022A RID: 66090 RVA: 0x0025B9BF File Offset: 0x00259BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601022B RID: 66091 RVA: 0x0025B9C8 File Offset: 0x00259BC8
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400673D RID: 26429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400673E RID: 26430
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400673F RID: 26431
		private ErrorCode errorCode_;
	}
}
