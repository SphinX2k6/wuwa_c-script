using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2A RID: 3626
	[NetMessage(EMessageId.QuestReviewInfoResponse)]
	public sealed class QuestReviewInfoResponse : IMessage<QuestReviewInfoResponse>, IMessage, IEquatable<QuestReviewInfoResponse>, IDeepCloneable<QuestReviewInfoResponse>, IBufferMessage
	{
		// Token: 0x06013782 RID: 79746 RVA: 0x002D472E File Offset: 0x002D292E
		[NullableContext(1)]
		public static QuestReviewInfoResponse Create()
		{
			return new QuestReviewInfoResponse();
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x06013783 RID: 79747 RVA: 0x002D4735 File Offset: 0x002D2935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x06013784 RID: 79748 RVA: 0x002D4738 File Offset: 0x002D2938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewInfoResponse.Descriptor;
			}
		}

		// Token: 0x06013785 RID: 79749 RVA: 0x002D473F File Offset: 0x002D293F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoResponse()
		{
		}

		// Token: 0x06013786 RID: 79750 RVA: 0x002D4747 File Offset: 0x002D2947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoResponse(QuestReviewInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013787 RID: 79751 RVA: 0x002D476C File Offset: 0x002D296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoResponse Clone()
		{
			return new QuestReviewInfoResponse(this);
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x06013788 RID: 79752 RVA: 0x002D4774 File Offset: 0x002D2974
		// (set) Token: 0x06013789 RID: 79753 RVA: 0x002D477C File Offset: 0x002D297C
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

		// Token: 0x0601378A RID: 79754 RVA: 0x002D4785 File Offset: 0x002D2985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewInfoResponse);
		}

		// Token: 0x0601378B RID: 79755 RVA: 0x002D4793 File Offset: 0x002D2993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601378C RID: 79756 RVA: 0x002D47C4 File Offset: 0x002D29C4
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

		// Token: 0x0601378D RID: 79757 RVA: 0x002D4809 File Offset: 0x002D2A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601378E RID: 79758 RVA: 0x002D4816 File Offset: 0x002D2A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601378F RID: 79759 RVA: 0x002D481F File Offset: 0x002D2A1F
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

		// Token: 0x06013790 RID: 79760 RVA: 0x002D4854 File Offset: 0x002D2A54
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

		// Token: 0x06013791 RID: 79761 RVA: 0x002D4892 File Offset: 0x002D2A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewInfoResponse other)
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

		// Token: 0x06013792 RID: 79762 RVA: 0x002D48C3 File Offset: 0x002D2AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013793 RID: 79763 RVA: 0x002D48CC File Offset: 0x002D2ACC
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

		// Token: 0x0400774A RID: 30538
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400774B RID: 30539
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400774C RID: 30540
		private ErrorCode errorCode_;
	}
}
