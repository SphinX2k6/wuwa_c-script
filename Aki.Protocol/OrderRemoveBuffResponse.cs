using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9D RID: 2973
	[NetMessage(EMessageId.OrderRemoveBuffResponse)]
	public sealed class OrderRemoveBuffResponse : IMessage<OrderRemoveBuffResponse>, IMessage, IEquatable<OrderRemoveBuffResponse>, IDeepCloneable<OrderRemoveBuffResponse>, IBufferMessage
	{
		// Token: 0x06010258 RID: 66136 RVA: 0x0025C0C9 File Offset: 0x0025A2C9
		[NullableContext(1)]
		public static OrderRemoveBuffResponse Create()
		{
			return new OrderRemoveBuffResponse();
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x06010259 RID: 66137 RVA: 0x0025C0D0 File Offset: 0x0025A2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0601025A RID: 66138 RVA: 0x0025C0D3 File Offset: 0x0025A2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffResponse.Descriptor;
			}
		}

		// Token: 0x0601025B RID: 66139 RVA: 0x0025C0DA File Offset: 0x0025A2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffResponse()
		{
		}

		// Token: 0x0601025C RID: 66140 RVA: 0x0025C0E2 File Offset: 0x0025A2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffResponse(OrderRemoveBuffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601025D RID: 66141 RVA: 0x0025C107 File Offset: 0x0025A307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffResponse Clone()
		{
			return new OrderRemoveBuffResponse(this);
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0601025E RID: 66142 RVA: 0x0025C10F File Offset: 0x0025A30F
		// (set) Token: 0x0601025F RID: 66143 RVA: 0x0025C117 File Offset: 0x0025A317
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

		// Token: 0x06010260 RID: 66144 RVA: 0x0025C120 File Offset: 0x0025A320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffResponse);
		}

		// Token: 0x06010261 RID: 66145 RVA: 0x0025C12E File Offset: 0x0025A32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010262 RID: 66146 RVA: 0x0025C15C File Offset: 0x0025A35C
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

		// Token: 0x06010263 RID: 66147 RVA: 0x0025C1A1 File Offset: 0x0025A3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010264 RID: 66148 RVA: 0x0025C1AE File Offset: 0x0025A3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010265 RID: 66149 RVA: 0x0025C1B7 File Offset: 0x0025A3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010266 RID: 66150 RVA: 0x0025C1EC File Offset: 0x0025A3EC
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

		// Token: 0x06010267 RID: 66151 RVA: 0x0025C22A File Offset: 0x0025A42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderRemoveBuffResponse other)
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

		// Token: 0x06010268 RID: 66152 RVA: 0x0025C25B File Offset: 0x0025A45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010269 RID: 66153 RVA: 0x0025C264 File Offset: 0x0025A464
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400674E RID: 26446
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400674F RID: 26447
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006750 RID: 26448
		private ErrorCode errorCode_;
	}
}
