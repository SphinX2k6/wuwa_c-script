using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FF RID: 2047
	[NetMessage(EMessageId.InfrV2ManualCancelTraceTreeResponse)]
	public sealed class InfrV2ManualCancelTraceTreeResponse : IMessage<InfrV2ManualCancelTraceTreeResponse>, IMessage, IEquatable<InfrV2ManualCancelTraceTreeResponse>, IDeepCloneable<InfrV2ManualCancelTraceTreeResponse>, IBufferMessage
	{
		// Token: 0x0600B74C RID: 46924 RVA: 0x001B50CA File Offset: 0x001B32CA
		[NullableContext(1)]
		public static InfrV2ManualCancelTraceTreeResponse Create()
		{
			return new InfrV2ManualCancelTraceTreeResponse();
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x0600B74D RID: 46925 RVA: 0x001B50D1 File Offset: 0x001B32D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x0600B74E RID: 46926 RVA: 0x001B50D4 File Offset: 0x001B32D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ManualCancelTraceTreeResponse.Descriptor;
			}
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x001B50DB File Offset: 0x001B32DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeResponse()
		{
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x001B50E3 File Offset: 0x001B32E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeResponse(InfrV2ManualCancelTraceTreeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B751 RID: 46929 RVA: 0x001B5108 File Offset: 0x001B3308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeResponse Clone()
		{
			return new InfrV2ManualCancelTraceTreeResponse(this);
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x0600B752 RID: 46930 RVA: 0x001B5110 File Offset: 0x001B3310
		// (set) Token: 0x0600B753 RID: 46931 RVA: 0x001B5118 File Offset: 0x001B3318
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

		// Token: 0x0600B754 RID: 46932 RVA: 0x001B5121 File Offset: 0x001B3321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ManualCancelTraceTreeResponse);
		}

		// Token: 0x0600B755 RID: 46933 RVA: 0x001B512F File Offset: 0x001B332F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ManualCancelTraceTreeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x001B5160 File Offset: 0x001B3360
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

		// Token: 0x0600B757 RID: 46935 RVA: 0x001B51A5 File Offset: 0x001B33A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x001B51B2 File Offset: 0x001B33B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x001B51BB File Offset: 0x001B33BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x001B51F0 File Offset: 0x001B33F0
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

		// Token: 0x0600B75B RID: 46939 RVA: 0x001B522E File Offset: 0x001B342E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ManualCancelTraceTreeResponse other)
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

		// Token: 0x0600B75C RID: 46940 RVA: 0x001B525F File Offset: 0x001B345F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x001B5268 File Offset: 0x001B3468
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040050F4 RID: 20724
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050F5 RID: 20725
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040050F6 RID: 20726
		private ErrorCode errorCode_;
	}
}
