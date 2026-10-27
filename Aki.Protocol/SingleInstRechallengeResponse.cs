using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001230 RID: 4656
	[NetMessage(EMessageId.SingleInstRechallengeResponse)]
	public sealed class SingleInstRechallengeResponse : IMessage<SingleInstRechallengeResponse>, IMessage, IEquatable<SingleInstRechallengeResponse>, IDeepCloneable<SingleInstRechallengeResponse>, IBufferMessage
	{
		// Token: 0x06018D03 RID: 101635 RVA: 0x0039C5C5 File Offset: 0x0039A7C5
		[NullableContext(1)]
		public static SingleInstRechallengeResponse Create()
		{
			return new SingleInstRechallengeResponse();
		}

		// Token: 0x170053A5 RID: 21413
		// (get) Token: 0x06018D04 RID: 101636 RVA: 0x0039C5CC File Offset: 0x0039A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053A6 RID: 21414
		// (get) Token: 0x06018D05 RID: 101637 RVA: 0x0039C5CF File Offset: 0x0039A7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleInstRechallengeResponse.Descriptor;
			}
		}

		// Token: 0x06018D06 RID: 101638 RVA: 0x0039C5D6 File Offset: 0x0039A7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeResponse()
		{
		}

		// Token: 0x06018D07 RID: 101639 RVA: 0x0039C5DE File Offset: 0x0039A7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeResponse(SingleInstRechallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D08 RID: 101640 RVA: 0x0039C603 File Offset: 0x0039A803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeResponse Clone()
		{
			return new SingleInstRechallengeResponse(this);
		}

		// Token: 0x170053A7 RID: 21415
		// (get) Token: 0x06018D09 RID: 101641 RVA: 0x0039C60B File Offset: 0x0039A80B
		// (set) Token: 0x06018D0A RID: 101642 RVA: 0x0039C613 File Offset: 0x0039A813
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

		// Token: 0x06018D0B RID: 101643 RVA: 0x0039C61C File Offset: 0x0039A81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleInstRechallengeResponse);
		}

		// Token: 0x06018D0C RID: 101644 RVA: 0x0039C62A File Offset: 0x0039A82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleInstRechallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D0D RID: 101645 RVA: 0x0039C658 File Offset: 0x0039A858
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

		// Token: 0x06018D0E RID: 101646 RVA: 0x0039C69D File Offset: 0x0039A89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D0F RID: 101647 RVA: 0x0039C6AA File Offset: 0x0039A8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D10 RID: 101648 RVA: 0x0039C6B3 File Offset: 0x0039A8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D11 RID: 101649 RVA: 0x0039C6E8 File Offset: 0x0039A8E8
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

		// Token: 0x06018D12 RID: 101650 RVA: 0x0039C726 File Offset: 0x0039A926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleInstRechallengeResponse other)
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

		// Token: 0x06018D13 RID: 101651 RVA: 0x0039C757 File Offset: 0x0039A957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D14 RID: 101652 RVA: 0x0039C760 File Offset: 0x0039A960
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009265 RID: 37477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009266 RID: 37478
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009267 RID: 37479
		private ErrorCode errorCode_;
	}
}
