using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000975 RID: 2421
	[NetMessage(EMessageId.MailBindRewardResponse)]
	public sealed class MailBindRewardResponse : IMessage<MailBindRewardResponse>, IMessage, IEquatable<MailBindRewardResponse>, IDeepCloneable<MailBindRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D508 RID: 54536 RVA: 0x001F592A File Offset: 0x001F3B2A
		[NullableContext(1)]
		public static MailBindRewardResponse Create()
		{
			return new MailBindRewardResponse();
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x0600D509 RID: 54537 RVA: 0x001F5931 File Offset: 0x001F3B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0600D50A RID: 54538 RVA: 0x001F5934 File Offset: 0x001F3B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D50B RID: 54539 RVA: 0x001F593B File Offset: 0x001F3B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardResponse()
		{
		}

		// Token: 0x0600D50C RID: 54540 RVA: 0x001F5943 File Offset: 0x001F3B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardResponse(MailBindRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D50D RID: 54541 RVA: 0x001F5968 File Offset: 0x001F3B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardResponse Clone()
		{
			return new MailBindRewardResponse(this);
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x0600D50E RID: 54542 RVA: 0x001F5970 File Offset: 0x001F3B70
		// (set) Token: 0x0600D50F RID: 54543 RVA: 0x001F5978 File Offset: 0x001F3B78
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

		// Token: 0x0600D510 RID: 54544 RVA: 0x001F5981 File Offset: 0x001F3B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindRewardResponse);
		}

		// Token: 0x0600D511 RID: 54545 RVA: 0x001F598F File Offset: 0x001F3B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D512 RID: 54546 RVA: 0x001F59C0 File Offset: 0x001F3BC0
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

		// Token: 0x0600D513 RID: 54547 RVA: 0x001F5A05 File Offset: 0x001F3C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D514 RID: 54548 RVA: 0x001F5A12 File Offset: 0x001F3C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D515 RID: 54549 RVA: 0x001F5A1B File Offset: 0x001F3C1B
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

		// Token: 0x0600D516 RID: 54550 RVA: 0x001F5A50 File Offset: 0x001F3C50
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

		// Token: 0x0600D517 RID: 54551 RVA: 0x001F5A8E File Offset: 0x001F3C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindRewardResponse other)
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

		// Token: 0x0600D518 RID: 54552 RVA: 0x001F5ABF File Offset: 0x001F3CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D519 RID: 54553 RVA: 0x001F5AC8 File Offset: 0x001F3CC8
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

		// Token: 0x0400593D RID: 22845
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400593E RID: 22846
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400593F RID: 22847
		private ErrorCode errorCode_;
	}
}
