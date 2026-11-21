using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000914 RID: 2324
	[NetMessage(EMessageId.LineCrossChallengeStartResponse)]
	public sealed class LineCrossChallengeStartResponse : IMessage<LineCrossChallengeStartResponse>, IMessage, IEquatable<LineCrossChallengeStartResponse>, IDeepCloneable<LineCrossChallengeStartResponse>, IBufferMessage
	{
		// Token: 0x0600CD68 RID: 52584 RVA: 0x001E4919 File Offset: 0x001E2B19
		[NullableContext(1)]
		public static LineCrossChallengeStartResponse Create()
		{
			return new LineCrossChallengeStartResponse();
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x0600CD69 RID: 52585 RVA: 0x001E4920 File Offset: 0x001E2B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x0600CD6A RID: 52586 RVA: 0x001E4923 File Offset: 0x001E2B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossChallengeStartResponse.Descriptor;
			}
		}

		// Token: 0x0600CD6B RID: 52587 RVA: 0x001E492A File Offset: 0x001E2B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartResponse()
		{
		}

		// Token: 0x0600CD6C RID: 52588 RVA: 0x001E4932 File Offset: 0x001E2B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartResponse(LineCrossChallengeStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD6D RID: 52589 RVA: 0x001E4957 File Offset: 0x001E2B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartResponse Clone()
		{
			return new LineCrossChallengeStartResponse(this);
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x0600CD6E RID: 52590 RVA: 0x001E495F File Offset: 0x001E2B5F
		// (set) Token: 0x0600CD6F RID: 52591 RVA: 0x001E4967 File Offset: 0x001E2B67
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

		// Token: 0x0600CD70 RID: 52592 RVA: 0x001E4970 File Offset: 0x001E2B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossChallengeStartResponse);
		}

		// Token: 0x0600CD71 RID: 52593 RVA: 0x001E497E File Offset: 0x001E2B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossChallengeStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD72 RID: 52594 RVA: 0x001E49AC File Offset: 0x001E2BAC
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

		// Token: 0x0600CD73 RID: 52595 RVA: 0x001E49F1 File Offset: 0x001E2BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD74 RID: 52596 RVA: 0x001E49FE File Offset: 0x001E2BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD75 RID: 52597 RVA: 0x001E4A07 File Offset: 0x001E2C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD76 RID: 52598 RVA: 0x001E4A3C File Offset: 0x001E2C3C
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

		// Token: 0x0600CD77 RID: 52599 RVA: 0x001E4A7A File Offset: 0x001E2C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineCrossChallengeStartResponse other)
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

		// Token: 0x0600CD78 RID: 52600 RVA: 0x001E4AAB File Offset: 0x001E2CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD79 RID: 52601 RVA: 0x001E4AB4 File Offset: 0x001E2CB4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400574C RID: 22348
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400574D RID: 22349
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400574E RID: 22350
		private ErrorCode errorCode_;
	}
}
