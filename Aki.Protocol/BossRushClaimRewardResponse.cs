using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D5 RID: 469
	[NetMessage(EMessageId.BossRushClaimRewardResponse)]
	public sealed class BossRushClaimRewardResponse : IMessage<BossRushClaimRewardResponse>, IMessage, IEquatable<BossRushClaimRewardResponse>, IDeepCloneable<BossRushClaimRewardResponse>, IBufferMessage
	{
		// Token: 0x06003534 RID: 13620 RVA: 0x00085C9B File Offset: 0x00083E9B
		[NullableContext(1)]
		public static BossRushClaimRewardResponse Create()
		{
			return new BossRushClaimRewardResponse();
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06003535 RID: 13621 RVA: 0x00085CA2 File Offset: 0x00083EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x00085CA5 File Offset: 0x00083EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushClaimRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00085CAC File Offset: 0x00083EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardResponse()
		{
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00085CB4 File Offset: 0x00083EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardResponse(BossRushClaimRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00085CD9 File Offset: 0x00083ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardResponse Clone()
		{
			return new BossRushClaimRewardResponse(this);
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x00085CE1 File Offset: 0x00083EE1
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x00085CE9 File Offset: 0x00083EE9
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

		// Token: 0x0600353C RID: 13628 RVA: 0x00085CF2 File Offset: 0x00083EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushClaimRewardResponse);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00085D00 File Offset: 0x00083F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushClaimRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00085D30 File Offset: 0x00083F30
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

		// Token: 0x0600353F RID: 13631 RVA: 0x00085D75 File Offset: 0x00083F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x00085D82 File Offset: 0x00083F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00085D8B File Offset: 0x00083F8B
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

		// Token: 0x06003542 RID: 13634 RVA: 0x00085DC0 File Offset: 0x00083FC0
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

		// Token: 0x06003543 RID: 13635 RVA: 0x00085DFE File Offset: 0x00083FFE
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

		// Token: 0x06003544 RID: 13636 RVA: 0x00085E2F File Offset: 0x0008402F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00085E38 File Offset: 0x00084038
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

		// Token: 0x04002A39 RID: 10809
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A3A RID: 10810
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04002A3B RID: 10811
		private ErrorCode errorCode_;
	}
}
