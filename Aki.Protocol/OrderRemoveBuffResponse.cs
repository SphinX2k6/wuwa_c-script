using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAD RID: 2989
	[NetMessage(EMessageId.OrderRemoveBuffResponse)]
	public sealed class OrderRemoveBuffResponse : IMessage<OrderRemoveBuffResponse>, IMessage, IEquatable<OrderRemoveBuffResponse>, IDeepCloneable<OrderRemoveBuffResponse>, IBufferMessage
	{
		// Token: 0x0601035C RID: 66396 RVA: 0x0025DF81 File Offset: 0x0025C181
		[NullableContext(1)]
		public static OrderRemoveBuffResponse Create()
		{
			return new OrderRemoveBuffResponse();
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0601035D RID: 66397 RVA: 0x0025DF88 File Offset: 0x0025C188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0601035E RID: 66398 RVA: 0x0025DF8B File Offset: 0x0025C18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffResponse.Descriptor;
			}
		}

		// Token: 0x0601035F RID: 66399 RVA: 0x0025DF92 File Offset: 0x0025C192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffResponse()
		{
		}

		// Token: 0x06010360 RID: 66400 RVA: 0x0025DF9A File Offset: 0x0025C19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffResponse(OrderRemoveBuffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010361 RID: 66401 RVA: 0x0025DFBF File Offset: 0x0025C1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffResponse Clone()
		{
			return new OrderRemoveBuffResponse(this);
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x06010362 RID: 66402 RVA: 0x0025DFC7 File Offset: 0x0025C1C7
		// (set) Token: 0x06010363 RID: 66403 RVA: 0x0025DFCF File Offset: 0x0025C1CF
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

		// Token: 0x06010364 RID: 66404 RVA: 0x0025DFD8 File Offset: 0x0025C1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffResponse);
		}

		// Token: 0x06010365 RID: 66405 RVA: 0x0025DFE6 File Offset: 0x0025C1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010366 RID: 66406 RVA: 0x0025E014 File Offset: 0x0025C214
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

		// Token: 0x06010367 RID: 66407 RVA: 0x0025E059 File Offset: 0x0025C259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010368 RID: 66408 RVA: 0x0025E066 File Offset: 0x0025C266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010369 RID: 66409 RVA: 0x0025E06F File Offset: 0x0025C26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601036A RID: 66410 RVA: 0x0025E0A4 File Offset: 0x0025C2A4
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

		// Token: 0x0601036B RID: 66411 RVA: 0x0025E0E2 File Offset: 0x0025C2E2
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

		// Token: 0x0601036C RID: 66412 RVA: 0x0025E113 File Offset: 0x0025C313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601036D RID: 66413 RVA: 0x0025E11C File Offset: 0x0025C31C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400673E RID: 26430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400673F RID: 26431
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04006740 RID: 26432
		private ErrorCode errorCode_;
	}
}
