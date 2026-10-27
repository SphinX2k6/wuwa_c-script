using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE4 RID: 3812
	[NetMessage(EMessageId.RegressRepeatedTaskResponse)]
	public sealed class RegressRepeatedTaskResponse : IMessage<RegressRepeatedTaskResponse>, IMessage, IEquatable<RegressRepeatedTaskResponse>, IDeepCloneable<RegressRepeatedTaskResponse>, IBufferMessage
	{
		// Token: 0x060146E4 RID: 83684 RVA: 0x002F80DC File Offset: 0x002F62DC
		[NullableContext(1)]
		public static RegressRepeatedTaskResponse Create()
		{
			return new RegressRepeatedTaskResponse();
		}

		// Token: 0x170043F1 RID: 17393
		// (get) Token: 0x060146E5 RID: 83685 RVA: 0x002F80E3 File Offset: 0x002F62E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043F2 RID: 17394
		// (get) Token: 0x060146E6 RID: 83686 RVA: 0x002F80E6 File Offset: 0x002F62E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressRepeatedTaskResponse.Descriptor;
			}
		}

		// Token: 0x060146E7 RID: 83687 RVA: 0x002F80ED File Offset: 0x002F62ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskResponse()
		{
		}

		// Token: 0x060146E8 RID: 83688 RVA: 0x002F80F5 File Offset: 0x002F62F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskResponse(RegressRepeatedTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146E9 RID: 83689 RVA: 0x002F811A File Offset: 0x002F631A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskResponse Clone()
		{
			return new RegressRepeatedTaskResponse(this);
		}

		// Token: 0x170043F3 RID: 17395
		// (get) Token: 0x060146EA RID: 83690 RVA: 0x002F8122 File Offset: 0x002F6322
		// (set) Token: 0x060146EB RID: 83691 RVA: 0x002F812A File Offset: 0x002F632A
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

		// Token: 0x060146EC RID: 83692 RVA: 0x002F8133 File Offset: 0x002F6333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressRepeatedTaskResponse);
		}

		// Token: 0x060146ED RID: 83693 RVA: 0x002F8141 File Offset: 0x002F6341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressRepeatedTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146EE RID: 83694 RVA: 0x002F8170 File Offset: 0x002F6370
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

		// Token: 0x060146EF RID: 83695 RVA: 0x002F81B5 File Offset: 0x002F63B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146F0 RID: 83696 RVA: 0x002F81C2 File Offset: 0x002F63C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146F1 RID: 83697 RVA: 0x002F81CB File Offset: 0x002F63CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060146F2 RID: 83698 RVA: 0x002F8200 File Offset: 0x002F6400
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

		// Token: 0x060146F3 RID: 83699 RVA: 0x002F823E File Offset: 0x002F643E
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

		// Token: 0x060146F4 RID: 83700 RVA: 0x002F826F File Offset: 0x002F646F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146F5 RID: 83701 RVA: 0x002F8278 File Offset: 0x002F6478
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007BFF RID: 31743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C00 RID: 31744
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04007C01 RID: 31745
		private ErrorCode errorCode_;
	}
}
