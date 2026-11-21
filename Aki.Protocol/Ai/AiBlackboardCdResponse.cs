using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001722 RID: 5922
	[NetMessage(EMessageId.AiBlackboardCdResponse)]
	public sealed class AiBlackboardCdResponse : IMessage<AiBlackboardCdResponse>, IMessage, IEquatable<AiBlackboardCdResponse>, IDeepCloneable<AiBlackboardCdResponse>, IBufferMessage
	{
		// Token: 0x0601DBAC RID: 121772 RVA: 0x0045C836 File Offset: 0x0045AA36
		[NullableContext(1)]
		public static AiBlackboardCdResponse Create()
		{
			return new AiBlackboardCdResponse();
		}

		// Token: 0x1700653C RID: 25916
		// (get) Token: 0x0601DBAD RID: 121773 RVA: 0x0045C83D File Offset: 0x0045AA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700653D RID: 25917
		// (get) Token: 0x0601DBAE RID: 121774 RVA: 0x0045C840 File Offset: 0x0045AA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardCdResponse.Descriptor;
			}
		}

		// Token: 0x0601DBAF RID: 121775 RVA: 0x0045C847 File Offset: 0x0045AA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdResponse()
		{
		}

		// Token: 0x0601DBB0 RID: 121776 RVA: 0x0045C84F File Offset: 0x0045AA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdResponse(AiBlackboardCdResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DBB1 RID: 121777 RVA: 0x0045C874 File Offset: 0x0045AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdResponse Clone()
		{
			return new AiBlackboardCdResponse(this);
		}

		// Token: 0x1700653E RID: 25918
		// (get) Token: 0x0601DBB2 RID: 121778 RVA: 0x0045C87C File Offset: 0x0045AA7C
		// (set) Token: 0x0601DBB3 RID: 121779 RVA: 0x0045C884 File Offset: 0x0045AA84
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

		// Token: 0x0601DBB4 RID: 121780 RVA: 0x0045C88D File Offset: 0x0045AA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardCdResponse);
		}

		// Token: 0x0601DBB5 RID: 121781 RVA: 0x0045C89B File Offset: 0x0045AA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardCdResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DBB6 RID: 121782 RVA: 0x0045C8CC File Offset: 0x0045AACC
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

		// Token: 0x0601DBB7 RID: 121783 RVA: 0x0045C911 File Offset: 0x0045AB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DBB8 RID: 121784 RVA: 0x0045C91E File Offset: 0x0045AB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DBB9 RID: 121785 RVA: 0x0045C927 File Offset: 0x0045AB27
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

		// Token: 0x0601DBBA RID: 121786 RVA: 0x0045C95C File Offset: 0x0045AB5C
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

		// Token: 0x0601DBBB RID: 121787 RVA: 0x0045C99A File Offset: 0x0045AB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardCdResponse other)
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

		// Token: 0x0601DBBC RID: 121788 RVA: 0x0045C9CB File Offset: 0x0045ABCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DBBD RID: 121789 RVA: 0x0045C9D4 File Offset: 0x0045ABD4
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

		// Token: 0x0400C949 RID: 51529
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C94A RID: 51530
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400C94B RID: 51531
		private ErrorCode errorCode_;
	}
}
