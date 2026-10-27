using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E2 RID: 482
	[NetMessage(EMessageId.BossRushTaskRewardResponse)]
	public sealed class BossRushTaskRewardResponse : IMessage<BossRushTaskRewardResponse>, IMessage, IEquatable<BossRushTaskRewardResponse>, IDeepCloneable<BossRushTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06003647 RID: 13895 RVA: 0x000884E1 File Offset: 0x000866E1
		[NullableContext(1)]
		public static BossRushTaskRewardResponse Create()
		{
			return new BossRushTaskRewardResponse();
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06003648 RID: 13896 RVA: 0x000884E8 File Offset: 0x000866E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x000884EB File Offset: 0x000866EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x000884F2 File Offset: 0x000866F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardResponse()
		{
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x000884FA File Offset: 0x000866FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardResponse(BossRushTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x0008851F File Offset: 0x0008671F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskRewardResponse Clone()
		{
			return new BossRushTaskRewardResponse(this);
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x00088527 File Offset: 0x00086727
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x0008852F File Offset: 0x0008672F
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

		// Token: 0x0600364F RID: 13903 RVA: 0x00088538 File Offset: 0x00086738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushTaskRewardResponse);
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00088546 File Offset: 0x00086746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00088574 File Offset: 0x00086774
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

		// Token: 0x06003652 RID: 13906 RVA: 0x000885B9 File Offset: 0x000867B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x000885C6 File Offset: 0x000867C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x000885CF File Offset: 0x000867CF
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

		// Token: 0x06003655 RID: 13909 RVA: 0x00088604 File Offset: 0x00086804
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

		// Token: 0x06003656 RID: 13910 RVA: 0x00088642 File Offset: 0x00086842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushTaskRewardResponse other)
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

		// Token: 0x06003657 RID: 13911 RVA: 0x00088673 File Offset: 0x00086873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x0008867C File Offset: 0x0008687C
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

		// Token: 0x04002A98 RID: 10904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A99 RID: 10905
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04002A9A RID: 10906
		private ErrorCode errorCode_;
	}
}
