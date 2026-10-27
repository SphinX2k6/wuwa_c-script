using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CF RID: 463
	[NetMessage(EMessageId.BossRushBatchClaimRewardResponse)]
	public sealed class BossRushBatchClaimRewardResponse : IMessage<BossRushBatchClaimRewardResponse>, IMessage, IEquatable<BossRushBatchClaimRewardResponse>, IDeepCloneable<BossRushBatchClaimRewardResponse>, IBufferMessage
	{
		// Token: 0x060034C4 RID: 13508 RVA: 0x00084FC8 File Offset: 0x000831C8
		[NullableContext(1)]
		public static BossRushBatchClaimRewardResponse Create()
		{
			return new BossRushBatchClaimRewardResponse();
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x00084FCF File Offset: 0x000831CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x00084FD2 File Offset: 0x000831D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushBatchClaimRewardResponse.Descriptor;
			}
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00084FD9 File Offset: 0x000831D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardResponse()
		{
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00084FE1 File Offset: 0x000831E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardResponse(BossRushBatchClaimRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00085006 File Offset: 0x00083206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardResponse Clone()
		{
			return new BossRushBatchClaimRewardResponse(this);
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x0008500E File Offset: 0x0008320E
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x00085016 File Offset: 0x00083216
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

		// Token: 0x060034CC RID: 13516 RVA: 0x0008501F File Offset: 0x0008321F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushBatchClaimRewardResponse);
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x0008502D File Offset: 0x0008322D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushBatchClaimRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x0008505C File Offset: 0x0008325C
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

		// Token: 0x060034CF RID: 13519 RVA: 0x000850A1 File Offset: 0x000832A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x000850AE File Offset: 0x000832AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000850B7 File Offset: 0x000832B7
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

		// Token: 0x060034D2 RID: 13522 RVA: 0x000850EC File Offset: 0x000832EC
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

		// Token: 0x060034D3 RID: 13523 RVA: 0x0008512A File Offset: 0x0008332A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushBatchClaimRewardResponse other)
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

		// Token: 0x060034D4 RID: 13524 RVA: 0x0008515B File Offset: 0x0008335B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00085164 File Offset: 0x00083364
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

		// Token: 0x04002A22 RID: 10786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A23 RID: 10787
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04002A24 RID: 10788
		private ErrorCode errorCode_;
	}
}
