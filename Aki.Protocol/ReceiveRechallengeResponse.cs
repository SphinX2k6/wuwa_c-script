using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC0 RID: 3776
	[NetMessage(EMessageId.ReceiveRechallengeResponse)]
	public sealed class ReceiveRechallengeResponse : IMessage<ReceiveRechallengeResponse>, IMessage, IEquatable<ReceiveRechallengeResponse>, IDeepCloneable<ReceiveRechallengeResponse>, IBufferMessage
	{
		// Token: 0x06014451 RID: 83025 RVA: 0x002F2A15 File Offset: 0x002F0C15
		[NullableContext(1)]
		public static ReceiveRechallengeResponse Create()
		{
			return new ReceiveRechallengeResponse();
		}

		// Token: 0x17004364 RID: 17252
		// (get) Token: 0x06014452 RID: 83026 RVA: 0x002F2A1C File Offset: 0x002F0C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004365 RID: 17253
		// (get) Token: 0x06014453 RID: 83027 RVA: 0x002F2A1F File Offset: 0x002F0C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceiveRechallengeResponse.Descriptor;
			}
		}

		// Token: 0x06014454 RID: 83028 RVA: 0x002F2A26 File Offset: 0x002F0C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeResponse()
		{
		}

		// Token: 0x06014455 RID: 83029 RVA: 0x002F2A2E File Offset: 0x002F0C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeResponse(ReceiveRechallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014456 RID: 83030 RVA: 0x002F2A53 File Offset: 0x002F0C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeResponse Clone()
		{
			return new ReceiveRechallengeResponse(this);
		}

		// Token: 0x17004366 RID: 17254
		// (get) Token: 0x06014457 RID: 83031 RVA: 0x002F2A5B File Offset: 0x002F0C5B
		// (set) Token: 0x06014458 RID: 83032 RVA: 0x002F2A63 File Offset: 0x002F0C63
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

		// Token: 0x06014459 RID: 83033 RVA: 0x002F2A6C File Offset: 0x002F0C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceiveRechallengeResponse);
		}

		// Token: 0x0601445A RID: 83034 RVA: 0x002F2A7A File Offset: 0x002F0C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceiveRechallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601445B RID: 83035 RVA: 0x002F2AA8 File Offset: 0x002F0CA8
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

		// Token: 0x0601445C RID: 83036 RVA: 0x002F2AED File Offset: 0x002F0CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601445D RID: 83037 RVA: 0x002F2AFA File Offset: 0x002F0CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601445E RID: 83038 RVA: 0x002F2B03 File Offset: 0x002F0D03
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

		// Token: 0x0601445F RID: 83039 RVA: 0x002F2B38 File Offset: 0x002F0D38
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

		// Token: 0x06014460 RID: 83040 RVA: 0x002F2B76 File Offset: 0x002F0D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReceiveRechallengeResponse other)
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

		// Token: 0x06014461 RID: 83041 RVA: 0x002F2BA7 File Offset: 0x002F0DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014462 RID: 83042 RVA: 0x002F2BB0 File Offset: 0x002F0DB0
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

		// Token: 0x04007B94 RID: 31636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B95 RID: 31637
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007B96 RID: 31638
		private ErrorCode errorCode_;
	}
}
