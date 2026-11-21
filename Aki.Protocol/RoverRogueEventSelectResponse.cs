using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001136 RID: 4406
	[NetMessage(EMessageId.RoverRogueEventSelectResponse)]
	public sealed class RoverRogueEventSelectResponse : IMessage<RoverRogueEventSelectResponse>, IMessage, IEquatable<RoverRogueEventSelectResponse>, IDeepCloneable<RoverRogueEventSelectResponse>, IBufferMessage
	{
		// Token: 0x06017898 RID: 96408 RVA: 0x0036C964 File Offset: 0x0036AB64
		[NullableContext(1)]
		public static RoverRogueEventSelectResponse Create()
		{
			return new RoverRogueEventSelectResponse();
		}

		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x06017899 RID: 96409 RVA: 0x0036C96B File Offset: 0x0036AB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x0601789A RID: 96410 RVA: 0x0036C96E File Offset: 0x0036AB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueEventSelectResponse.Descriptor;
			}
		}

		// Token: 0x0601789B RID: 96411 RVA: 0x0036C975 File Offset: 0x0036AB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectResponse()
		{
		}

		// Token: 0x0601789C RID: 96412 RVA: 0x0036C97D File Offset: 0x0036AB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectResponse(RoverRogueEventSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601789D RID: 96413 RVA: 0x0036C9A2 File Offset: 0x0036ABA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectResponse Clone()
		{
			return new RoverRogueEventSelectResponse(this);
		}

		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x0601789E RID: 96414 RVA: 0x0036C9AA File Offset: 0x0036ABAA
		// (set) Token: 0x0601789F RID: 96415 RVA: 0x0036C9B2 File Offset: 0x0036ABB2
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

		// Token: 0x060178A0 RID: 96416 RVA: 0x0036C9BB File Offset: 0x0036ABBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueEventSelectResponse);
		}

		// Token: 0x060178A1 RID: 96417 RVA: 0x0036C9C9 File Offset: 0x0036ABC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueEventSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178A2 RID: 96418 RVA: 0x0036C9F8 File Offset: 0x0036ABF8
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

		// Token: 0x060178A3 RID: 96419 RVA: 0x0036CA3D File Offset: 0x0036AC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178A4 RID: 96420 RVA: 0x0036CA4A File Offset: 0x0036AC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178A5 RID: 96421 RVA: 0x0036CA53 File Offset: 0x0036AC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178A6 RID: 96422 RVA: 0x0036CA88 File Offset: 0x0036AC88
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

		// Token: 0x060178A7 RID: 96423 RVA: 0x0036CAC6 File Offset: 0x0036ACC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueEventSelectResponse other)
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

		// Token: 0x060178A8 RID: 96424 RVA: 0x0036CAF7 File Offset: 0x0036ACF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178A9 RID: 96425 RVA: 0x0036CB00 File Offset: 0x0036AD00
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008C72 RID: 35954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C73 RID: 35955
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04008C74 RID: 35956
		private ErrorCode errorCode_;
	}
}
