using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CF RID: 463
	[NetMessage(EMessageId.BossPilingSettleResponse)]
	public sealed class BossPilingSettleResponse : IMessage<BossPilingSettleResponse>, IMessage, IEquatable<BossPilingSettleResponse>, IDeepCloneable<BossPilingSettleResponse>, IBufferMessage
	{
		// Token: 0x06003504 RID: 13572 RVA: 0x00085CAE File Offset: 0x00083EAE
		[NullableContext(1)]
		public static BossPilingSettleResponse Create()
		{
			return new BossPilingSettleResponse();
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06003505 RID: 13573 RVA: 0x00085CB5 File Offset: 0x00083EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x00085CB8 File Offset: 0x00083EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingSettleResponse.Descriptor;
			}
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00085CBF File Offset: 0x00083EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleResponse()
		{
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00085CC7 File Offset: 0x00083EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleResponse(BossPilingSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00085CEC File Offset: 0x00083EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleResponse Clone()
		{
			return new BossPilingSettleResponse(this);
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x00085CF4 File Offset: 0x00083EF4
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x00085CFC File Offset: 0x00083EFC
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

		// Token: 0x0600350C RID: 13580 RVA: 0x00085D05 File Offset: 0x00083F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingSettleResponse);
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x00085D13 File Offset: 0x00083F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x00085D44 File Offset: 0x00083F44
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

		// Token: 0x0600350F RID: 13583 RVA: 0x00085D89 File Offset: 0x00083F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x00085D96 File Offset: 0x00083F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x00085D9F File Offset: 0x00083F9F
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

		// Token: 0x06003512 RID: 13586 RVA: 0x00085DD4 File Offset: 0x00083FD4
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

		// Token: 0x06003513 RID: 13587 RVA: 0x00085E12 File Offset: 0x00084012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingSettleResponse other)
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

		// Token: 0x06003514 RID: 13588 RVA: 0x00085E43 File Offset: 0x00084043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x00085E4C File Offset: 0x0008404C
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

		// Token: 0x04002A83 RID: 10883
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A84 RID: 10884
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04002A85 RID: 10885
		private ErrorCode errorCode_;
	}
}
