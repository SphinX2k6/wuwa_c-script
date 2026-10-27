using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE8 RID: 3816
	[NetMessage(EMessageId.RegressTaskResponse)]
	public sealed class RegressTaskResponse : IMessage<RegressTaskResponse>, IMessage, IEquatable<RegressTaskResponse>, IDeepCloneable<RegressTaskResponse>, IBufferMessage
	{
		// Token: 0x06014738 RID: 83768 RVA: 0x002F8CBB File Offset: 0x002F6EBB
		[NullableContext(1)]
		public static RegressTaskResponse Create()
		{
			return new RegressTaskResponse();
		}

		// Token: 0x17004403 RID: 17411
		// (get) Token: 0x06014739 RID: 83769 RVA: 0x002F8CC2 File Offset: 0x002F6EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004404 RID: 17412
		// (get) Token: 0x0601473A RID: 83770 RVA: 0x002F8CC5 File Offset: 0x002F6EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTaskResponse.Descriptor;
			}
		}

		// Token: 0x0601473B RID: 83771 RVA: 0x002F8CCC File Offset: 0x002F6ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskResponse()
		{
		}

		// Token: 0x0601473C RID: 83772 RVA: 0x002F8CD4 File Offset: 0x002F6ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskResponse(RegressTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601473D RID: 83773 RVA: 0x002F8CF9 File Offset: 0x002F6EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskResponse Clone()
		{
			return new RegressTaskResponse(this);
		}

		// Token: 0x17004405 RID: 17413
		// (get) Token: 0x0601473E RID: 83774 RVA: 0x002F8D01 File Offset: 0x002F6F01
		// (set) Token: 0x0601473F RID: 83775 RVA: 0x002F8D09 File Offset: 0x002F6F09
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

		// Token: 0x06014740 RID: 83776 RVA: 0x002F8D12 File Offset: 0x002F6F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTaskResponse);
		}

		// Token: 0x06014741 RID: 83777 RVA: 0x002F8D20 File Offset: 0x002F6F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014742 RID: 83778 RVA: 0x002F8D50 File Offset: 0x002F6F50
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

		// Token: 0x06014743 RID: 83779 RVA: 0x002F8D95 File Offset: 0x002F6F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014744 RID: 83780 RVA: 0x002F8DA2 File Offset: 0x002F6FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014745 RID: 83781 RVA: 0x002F8DAB File Offset: 0x002F6FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014746 RID: 83782 RVA: 0x002F8DE0 File Offset: 0x002F6FE0
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

		// Token: 0x06014747 RID: 83783 RVA: 0x002F8E1E File Offset: 0x002F701E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressTaskResponse other)
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

		// Token: 0x06014748 RID: 83784 RVA: 0x002F8E4F File Offset: 0x002F704F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014749 RID: 83785 RVA: 0x002F8E58 File Offset: 0x002F7058
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C17 RID: 31767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C18 RID: 31768
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007C19 RID: 31769
		private ErrorCode errorCode_;
	}
}
