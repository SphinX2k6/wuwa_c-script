using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000193 RID: 403
	[NetMessage(EMessageId.BeControlledShowResponse)]
	public sealed class BeControlledShowResponse : IMessage<BeControlledShowResponse>, IMessage, IEquatable<BeControlledShowResponse>, IDeepCloneable<BeControlledShowResponse>, IBufferMessage
	{
		// Token: 0x06003038 RID: 12344 RVA: 0x0007B79C File Offset: 0x0007999C
		[NullableContext(1)]
		public static BeControlledShowResponse Create()
		{
			return new BeControlledShowResponse();
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x0007B7A3 File Offset: 0x000799A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x0007B7A6 File Offset: 0x000799A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledShowResponse.Descriptor;
			}
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x0007B7AD File Offset: 0x000799AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowResponse()
		{
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x0007B7B5 File Offset: 0x000799B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowResponse(BeControlledShowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x0007B7DA File Offset: 0x000799DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowResponse Clone()
		{
			return new BeControlledShowResponse(this);
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x0007B7E2 File Offset: 0x000799E2
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x0007B7EA File Offset: 0x000799EA
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

		// Token: 0x06003040 RID: 12352 RVA: 0x0007B7F3 File Offset: 0x000799F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledShowResponse);
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0007B801 File Offset: 0x00079A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledShowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0007B830 File Offset: 0x00079A30
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

		// Token: 0x06003043 RID: 12355 RVA: 0x0007B875 File Offset: 0x00079A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x0007B882 File Offset: 0x00079A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0007B88B File Offset: 0x00079A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0007B8C0 File Offset: 0x00079AC0
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

		// Token: 0x06003047 RID: 12359 RVA: 0x0007B8FE File Offset: 0x00079AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledShowResponse other)
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

		// Token: 0x06003048 RID: 12360 RVA: 0x0007B92F File Offset: 0x00079B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0007B938 File Offset: 0x00079B38
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400293A RID: 10554
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400293B RID: 10555
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400293C RID: 10556
		private ErrorCode errorCode_;
	}
}
