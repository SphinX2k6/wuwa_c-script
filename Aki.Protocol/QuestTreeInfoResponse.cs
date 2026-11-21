using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E25 RID: 3621
	[NetMessage(EMessageId.QuestTreeInfoResponse)]
	public sealed class QuestTreeInfoResponse : IMessage<QuestTreeInfoResponse>, IMessage, IEquatable<QuestTreeInfoResponse>, IDeepCloneable<QuestTreeInfoResponse>, IBufferMessage
	{
		// Token: 0x0601377C RID: 79740 RVA: 0x002D4BC6 File Offset: 0x002D2DC6
		[NullableContext(1)]
		public static QuestTreeInfoResponse Create()
		{
			return new QuestTreeInfoResponse();
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x0601377D RID: 79741 RVA: 0x002D4BCD File Offset: 0x002D2DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x0601377E RID: 79742 RVA: 0x002D4BD0 File Offset: 0x002D2DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTreeInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601377F RID: 79743 RVA: 0x002D4BD7 File Offset: 0x002D2DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoResponse()
		{
		}

		// Token: 0x06013780 RID: 79744 RVA: 0x002D4BDF File Offset: 0x002D2DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoResponse(QuestTreeInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013781 RID: 79745 RVA: 0x002D4C04 File Offset: 0x002D2E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoResponse Clone()
		{
			return new QuestTreeInfoResponse(this);
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x06013782 RID: 79746 RVA: 0x002D4C0C File Offset: 0x002D2E0C
		// (set) Token: 0x06013783 RID: 79747 RVA: 0x002D4C14 File Offset: 0x002D2E14
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

		// Token: 0x06013784 RID: 79748 RVA: 0x002D4C1D File Offset: 0x002D2E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTreeInfoResponse);
		}

		// Token: 0x06013785 RID: 79749 RVA: 0x002D4C2B File Offset: 0x002D2E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTreeInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013786 RID: 79750 RVA: 0x002D4C5C File Offset: 0x002D2E5C
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

		// Token: 0x06013787 RID: 79751 RVA: 0x002D4CA1 File Offset: 0x002D2EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013788 RID: 79752 RVA: 0x002D4CAE File Offset: 0x002D2EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013789 RID: 79753 RVA: 0x002D4CB7 File Offset: 0x002D2EB7
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

		// Token: 0x0601378A RID: 79754 RVA: 0x002D4CEC File Offset: 0x002D2EEC
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

		// Token: 0x0601378B RID: 79755 RVA: 0x002D4D2A File Offset: 0x002D2F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestTreeInfoResponse other)
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

		// Token: 0x0601378C RID: 79756 RVA: 0x002D4D5B File Offset: 0x002D2F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601378D RID: 79757 RVA: 0x002D4D64 File Offset: 0x002D2F64
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

		// Token: 0x040077AF RID: 30639
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077B0 RID: 30640
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040077B1 RID: 30641
		private ErrorCode errorCode_;
	}
}
