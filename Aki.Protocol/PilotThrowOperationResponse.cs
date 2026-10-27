using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3E RID: 3390
	[NetMessage(EMessageId.PilotThrowOperationResponse)]
	public sealed class PilotThrowOperationResponse : IMessage<PilotThrowOperationResponse>, IMessage, IEquatable<PilotThrowOperationResponse>, IDeepCloneable<PilotThrowOperationResponse>, IBufferMessage
	{
		// Token: 0x060124B1 RID: 74929 RVA: 0x002AB6F1 File Offset: 0x002A98F1
		[NullableContext(1)]
		public static PilotThrowOperationResponse Create()
		{
			return new PilotThrowOperationResponse();
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x060124B2 RID: 74930 RVA: 0x002AB6F8 File Offset: 0x002A98F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x060124B3 RID: 74931 RVA: 0x002AB6FB File Offset: 0x002A98FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PilotThrowOperationResponse.Descriptor;
			}
		}

		// Token: 0x060124B4 RID: 74932 RVA: 0x002AB702 File Offset: 0x002A9902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationResponse()
		{
		}

		// Token: 0x060124B5 RID: 74933 RVA: 0x002AB70A File Offset: 0x002A990A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationResponse(PilotThrowOperationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124B6 RID: 74934 RVA: 0x002AB72F File Offset: 0x002A992F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationResponse Clone()
		{
			return new PilotThrowOperationResponse(this);
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x060124B7 RID: 74935 RVA: 0x002AB737 File Offset: 0x002A9937
		// (set) Token: 0x060124B8 RID: 74936 RVA: 0x002AB73F File Offset: 0x002A993F
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

		// Token: 0x060124B9 RID: 74937 RVA: 0x002AB748 File Offset: 0x002A9948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PilotThrowOperationResponse);
		}

		// Token: 0x060124BA RID: 74938 RVA: 0x002AB756 File Offset: 0x002A9956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PilotThrowOperationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124BB RID: 74939 RVA: 0x002AB784 File Offset: 0x002A9984
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

		// Token: 0x060124BC RID: 74940 RVA: 0x002AB7C9 File Offset: 0x002A99C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124BD RID: 74941 RVA: 0x002AB7D6 File Offset: 0x002A99D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124BE RID: 74942 RVA: 0x002AB7DF File Offset: 0x002A99DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060124BF RID: 74943 RVA: 0x002AB814 File Offset: 0x002A9A14
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

		// Token: 0x060124C0 RID: 74944 RVA: 0x002AB852 File Offset: 0x002A9A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PilotThrowOperationResponse other)
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

		// Token: 0x060124C1 RID: 74945 RVA: 0x002AB883 File Offset: 0x002A9A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124C2 RID: 74946 RVA: 0x002AB88C File Offset: 0x002A9A8C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400720B RID: 29195
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400720C RID: 29196
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400720D RID: 29197
		private ErrorCode errorCode_;
	}
}
