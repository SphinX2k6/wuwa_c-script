using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAA RID: 2986
	[NetMessage(EMessageId.OrderRemoveBuffByTagsResponse)]
	public sealed class OrderRemoveBuffByTagsResponse : IMessage<OrderRemoveBuffByTagsResponse>, IMessage, IEquatable<OrderRemoveBuffByTagsResponse>, IDeepCloneable<OrderRemoveBuffByTagsResponse>, IBufferMessage
	{
		// Token: 0x0601031E RID: 66334 RVA: 0x0025D6E4 File Offset: 0x0025B8E4
		[NullableContext(1)]
		public static OrderRemoveBuffByTagsResponse Create()
		{
			return new OrderRemoveBuffByTagsResponse();
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0601031F RID: 66335 RVA: 0x0025D6EB File Offset: 0x0025B8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x06010320 RID: 66336 RVA: 0x0025D6EE File Offset: 0x0025B8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffByTagsResponse.Descriptor;
			}
		}

		// Token: 0x06010321 RID: 66337 RVA: 0x0025D6F5 File Offset: 0x0025B8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsResponse()
		{
		}

		// Token: 0x06010322 RID: 66338 RVA: 0x0025D6FD File Offset: 0x0025B8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsResponse(OrderRemoveBuffByTagsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010323 RID: 66339 RVA: 0x0025D722 File Offset: 0x0025B922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsResponse Clone()
		{
			return new OrderRemoveBuffByTagsResponse(this);
		}

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x06010324 RID: 66340 RVA: 0x0025D72A File Offset: 0x0025B92A
		// (set) Token: 0x06010325 RID: 66341 RVA: 0x0025D732 File Offset: 0x0025B932
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

		// Token: 0x06010326 RID: 66342 RVA: 0x0025D73B File Offset: 0x0025B93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffByTagsResponse);
		}

		// Token: 0x06010327 RID: 66343 RVA: 0x0025D749 File Offset: 0x0025B949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffByTagsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010328 RID: 66344 RVA: 0x0025D778 File Offset: 0x0025B978
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

		// Token: 0x06010329 RID: 66345 RVA: 0x0025D7BD File Offset: 0x0025B9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601032A RID: 66346 RVA: 0x0025D7CA File Offset: 0x0025B9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601032B RID: 66347 RVA: 0x0025D7D3 File Offset: 0x0025B9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601032C RID: 66348 RVA: 0x0025D808 File Offset: 0x0025BA08
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

		// Token: 0x0601032D RID: 66349 RVA: 0x0025D846 File Offset: 0x0025BA46
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

		// Token: 0x0601032E RID: 66350 RVA: 0x0025D877 File Offset: 0x0025BA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601032F RID: 66351 RVA: 0x0025D880 File Offset: 0x0025BA80
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400672D RID: 26413
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400672E RID: 26414
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400672F RID: 26415
		private ErrorCode errorCode_;
	}
}
