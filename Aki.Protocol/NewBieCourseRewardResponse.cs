using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF9 RID: 2809
	[NetMessage(EMessageId.NewBieCourseRewardResponse)]
	public sealed class NewBieCourseRewardResponse : IMessage<NewBieCourseRewardResponse>, IMessage, IEquatable<NewBieCourseRewardResponse>, IDeepCloneable<NewBieCourseRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F46C RID: 62572 RVA: 0x0023B051 File Offset: 0x00239251
		[NullableContext(1)]
		public static NewBieCourseRewardResponse Create()
		{
			return new NewBieCourseRewardResponse();
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600F46D RID: 62573 RVA: 0x0023B058 File Offset: 0x00239258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600F46E RID: 62574 RVA: 0x0023B05B File Offset: 0x0023925B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewBieCourseRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F46F RID: 62575 RVA: 0x0023B062 File Offset: 0x00239262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardResponse()
		{
		}

		// Token: 0x0600F470 RID: 62576 RVA: 0x0023B06A File Offset: 0x0023926A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardResponse(NewBieCourseRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F471 RID: 62577 RVA: 0x0023B08F File Offset: 0x0023928F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardResponse Clone()
		{
			return new NewBieCourseRewardResponse(this);
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600F472 RID: 62578 RVA: 0x0023B097 File Offset: 0x00239297
		// (set) Token: 0x0600F473 RID: 62579 RVA: 0x0023B09F File Offset: 0x0023929F
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

		// Token: 0x0600F474 RID: 62580 RVA: 0x0023B0A8 File Offset: 0x002392A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewBieCourseRewardResponse);
		}

		// Token: 0x0600F475 RID: 62581 RVA: 0x0023B0B6 File Offset: 0x002392B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewBieCourseRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F476 RID: 62582 RVA: 0x0023B0E4 File Offset: 0x002392E4
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

		// Token: 0x0600F477 RID: 62583 RVA: 0x0023B129 File Offset: 0x00239329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F478 RID: 62584 RVA: 0x0023B136 File Offset: 0x00239336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F479 RID: 62585 RVA: 0x0023B13F File Offset: 0x0023933F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F47A RID: 62586 RVA: 0x0023B174 File Offset: 0x00239374
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

		// Token: 0x0600F47B RID: 62587 RVA: 0x0023B1B2 File Offset: 0x002393B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewBieCourseRewardResponse other)
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

		// Token: 0x0600F47C RID: 62588 RVA: 0x0023B1E3 File Offset: 0x002393E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F47D RID: 62589 RVA: 0x0023B1EC File Offset: 0x002393EC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040062C0 RID: 25280
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062C1 RID: 25281
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040062C2 RID: 25282
		private ErrorCode errorCode_;
	}
}
