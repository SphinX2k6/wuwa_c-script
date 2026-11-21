using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED4 RID: 3796
	[NetMessage(EMessageId.RegressRepeatedTaskResponse)]
	public sealed class RegressRepeatedTaskResponse : IMessage<RegressRepeatedTaskResponse>, IMessage, IEquatable<RegressRepeatedTaskResponse>, IDeepCloneable<RegressRepeatedTaskResponse>, IBufferMessage
	{
		// Token: 0x060145FF RID: 83455 RVA: 0x002F6A30 File Offset: 0x002F4C30
		[NullableContext(1)]
		public static RegressRepeatedTaskResponse Create()
		{
			return new RegressRepeatedTaskResponse();
		}

		// Token: 0x170043C7 RID: 17351
		// (get) Token: 0x06014600 RID: 83456 RVA: 0x002F6A37 File Offset: 0x002F4C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043C8 RID: 17352
		// (get) Token: 0x06014601 RID: 83457 RVA: 0x002F6A3A File Offset: 0x002F4C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressRepeatedTaskResponse.Descriptor;
			}
		}

		// Token: 0x06014602 RID: 83458 RVA: 0x002F6A41 File Offset: 0x002F4C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskResponse()
		{
		}

		// Token: 0x06014603 RID: 83459 RVA: 0x002F6A49 File Offset: 0x002F4C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskResponse(RegressRepeatedTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014604 RID: 83460 RVA: 0x002F6A6E File Offset: 0x002F4C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskResponse Clone()
		{
			return new RegressRepeatedTaskResponse(this);
		}

		// Token: 0x170043C9 RID: 17353
		// (get) Token: 0x06014605 RID: 83461 RVA: 0x002F6A76 File Offset: 0x002F4C76
		// (set) Token: 0x06014606 RID: 83462 RVA: 0x002F6A7E File Offset: 0x002F4C7E
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

		// Token: 0x06014607 RID: 83463 RVA: 0x002F6A87 File Offset: 0x002F4C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressRepeatedTaskResponse);
		}

		// Token: 0x06014608 RID: 83464 RVA: 0x002F6A95 File Offset: 0x002F4C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressRepeatedTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014609 RID: 83465 RVA: 0x002F6AC4 File Offset: 0x002F4CC4
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

		// Token: 0x0601460A RID: 83466 RVA: 0x002F6B09 File Offset: 0x002F4D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601460B RID: 83467 RVA: 0x002F6B16 File Offset: 0x002F4D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601460C RID: 83468 RVA: 0x002F6B1F File Offset: 0x002F4D1F
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

		// Token: 0x0601460D RID: 83469 RVA: 0x002F6B54 File Offset: 0x002F4D54
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

		// Token: 0x0601460E RID: 83470 RVA: 0x002F6B92 File Offset: 0x002F4D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressRepeatedTaskResponse other)
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

		// Token: 0x0601460F RID: 83471 RVA: 0x002F6BC3 File Offset: 0x002F4DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014610 RID: 83472 RVA: 0x002F6BCC File Offset: 0x002F4DCC
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

		// Token: 0x04007C29 RID: 31785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C2A RID: 31786
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007C2B RID: 31787
		private ErrorCode errorCode_;
	}
}
