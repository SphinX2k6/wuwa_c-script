using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A0 RID: 416
	[NetMessage(EMessageId.BirthdayInitResponse)]
	public sealed class BirthdayInitResponse : IMessage<BirthdayInitResponse>, IMessage, IEquatable<BirthdayInitResponse>, IDeepCloneable<BirthdayInitResponse>, IBufferMessage
	{
		// Token: 0x0600313C RID: 12604 RVA: 0x0007D959 File Offset: 0x0007BB59
		[NullableContext(1)]
		public static BirthdayInitResponse Create()
		{
			return new BirthdayInitResponse();
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x0007D960 File Offset: 0x0007BB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x0007D963 File Offset: 0x0007BB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthdayInitResponse.Descriptor;
			}
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x0007D96A File Offset: 0x0007BB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitResponse()
		{
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x0007D972 File Offset: 0x0007BB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitResponse(BirthdayInitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x0007D997 File Offset: 0x0007BB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitResponse Clone()
		{
			return new BirthdayInitResponse(this);
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x0007D99F File Offset: 0x0007BB9F
		// (set) Token: 0x06003143 RID: 12611 RVA: 0x0007D9A7 File Offset: 0x0007BBA7
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

		// Token: 0x06003144 RID: 12612 RVA: 0x0007D9B0 File Offset: 0x0007BBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthdayInitResponse);
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x0007D9BE File Offset: 0x0007BBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthdayInitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0007D9EC File Offset: 0x0007BBEC
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

		// Token: 0x06003147 RID: 12615 RVA: 0x0007DA31 File Offset: 0x0007BC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x0007DA3E File Offset: 0x0007BC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x0007DA47 File Offset: 0x0007BC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x0007DA7C File Offset: 0x0007BC7C
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

		// Token: 0x0600314B RID: 12619 RVA: 0x0007DABA File Offset: 0x0007BCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthdayInitResponse other)
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

		// Token: 0x0600314C RID: 12620 RVA: 0x0007DAEB File Offset: 0x0007BCEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x0007DAF4 File Offset: 0x0007BCF4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400297E RID: 10622
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400297F RID: 10623
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002980 RID: 10624
		private ErrorCode errorCode_;
	}
}
