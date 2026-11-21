using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000109 RID: 265
	[NetMessage(EMessageId.ApplyRechallengeResponse)]
	public sealed class ApplyRechallengeResponse : IMessage<ApplyRechallengeResponse>, IMessage, IEquatable<ApplyRechallengeResponse>, IDeepCloneable<ApplyRechallengeResponse>, IBufferMessage
	{
		// Token: 0x0600252D RID: 9517 RVA: 0x0006385D File Offset: 0x00061A5D
		[NullableContext(1)]
		public static ApplyRechallengeResponse Create()
		{
			return new ApplyRechallengeResponse();
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x00063864 File Offset: 0x00061A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00063867 File Offset: 0x00061A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyRechallengeResponse.Descriptor;
			}
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x0006386E File Offset: 0x00061A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeResponse()
		{
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00063876 File Offset: 0x00061A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeResponse(ApplyRechallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0006389B File Offset: 0x00061A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyRechallengeResponse Clone()
		{
			return new ApplyRechallengeResponse(this);
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x000638A3 File Offset: 0x00061AA3
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x000638AB File Offset: 0x00061AAB
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

		// Token: 0x06002535 RID: 9525 RVA: 0x000638B4 File Offset: 0x00061AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyRechallengeResponse);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000638C2 File Offset: 0x00061AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyRechallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000638F0 File Offset: 0x00061AF0
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

		// Token: 0x06002538 RID: 9528 RVA: 0x00063935 File Offset: 0x00061B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00063942 File Offset: 0x00061B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0006394B File Offset: 0x00061B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00063980 File Offset: 0x00061B80
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

		// Token: 0x0600253C RID: 9532 RVA: 0x000639BE File Offset: 0x00061BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyRechallengeResponse other)
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

		// Token: 0x0600253D RID: 9533 RVA: 0x000639EF File Offset: 0x00061BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000639F8 File Offset: 0x00061BF8
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040025FF RID: 9727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002600 RID: 9728
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002601 RID: 9729
		private ErrorCode errorCode_;
	}
}
