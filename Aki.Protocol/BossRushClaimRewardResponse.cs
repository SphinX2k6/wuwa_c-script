using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D9 RID: 473
	[NetMessage(EMessageId.BossRushClaimRewardResponse)]
	public sealed class BossRushClaimRewardResponse : IMessage<BossRushClaimRewardResponse>, IMessage, IEquatable<BossRushClaimRewardResponse>, IDeepCloneable<BossRushClaimRewardResponse>, IBufferMessage
	{
		// Token: 0x060035C1 RID: 13761 RVA: 0x0008740F File Offset: 0x0008560F
		[NullableContext(1)]
		public static BossRushClaimRewardResponse Create()
		{
			return new BossRushClaimRewardResponse();
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x00087416 File Offset: 0x00085616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x00087419 File Offset: 0x00085619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushClaimRewardResponse.Descriptor;
			}
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00087420 File Offset: 0x00085620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardResponse()
		{
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00087428 File Offset: 0x00085628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardResponse(BossRushClaimRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0008744D File Offset: 0x0008564D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardResponse Clone()
		{
			return new BossRushClaimRewardResponse(this);
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x00087455 File Offset: 0x00085655
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x0008745D File Offset: 0x0008565D
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

		// Token: 0x060035C9 RID: 13769 RVA: 0x00087466 File Offset: 0x00085666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushClaimRewardResponse);
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00087474 File Offset: 0x00085674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushClaimRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x000874A4 File Offset: 0x000856A4
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

		// Token: 0x060035CC RID: 13772 RVA: 0x000874E9 File Offset: 0x000856E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x000874F6 File Offset: 0x000856F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x000874FF File Offset: 0x000856FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x00087534 File Offset: 0x00085734
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

		// Token: 0x060035D0 RID: 13776 RVA: 0x00087572 File Offset: 0x00085772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushClaimRewardResponse other)
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

		// Token: 0x060035D1 RID: 13777 RVA: 0x000875A3 File Offset: 0x000857A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x000875AC File Offset: 0x000857AC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002AB4 RID: 10932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AB5 RID: 10933
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04002AB6 RID: 10934
		private ErrorCode errorCode_;
	}
}
