using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E08 RID: 3592
	[NetMessage(EMessageId.QuestBranchResponse)]
	public sealed class QuestBranchResponse : IMessage<QuestBranchResponse>, IMessage, IEquatable<QuestBranchResponse>, IDeepCloneable<QuestBranchResponse>, IBufferMessage
	{
		// Token: 0x060134ED RID: 79085 RVA: 0x002CF632 File Offset: 0x002CD832
		[NullableContext(1)]
		public static QuestBranchResponse Create()
		{
			return new QuestBranchResponse();
		}

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x060134EE RID: 79086 RVA: 0x002CF639 File Offset: 0x002CD839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x060134EF RID: 79087 RVA: 0x002CF63C File Offset: 0x002CD83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchResponse.Descriptor;
			}
		}

		// Token: 0x060134F0 RID: 79088 RVA: 0x002CF643 File Offset: 0x002CD843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchResponse()
		{
		}

		// Token: 0x060134F1 RID: 79089 RVA: 0x002CF64C File Offset: 0x002CD84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchResponse(QuestBranchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.questBranchInfo_ = ((other.questBranchInfo_ != null) ? other.questBranchInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134F2 RID: 79090 RVA: 0x002CF698 File Offset: 0x002CD898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchResponse Clone()
		{
			return new QuestBranchResponse(this);
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x060134F3 RID: 79091 RVA: 0x002CF6A0 File Offset: 0x002CD8A0
		// (set) Token: 0x060134F4 RID: 79092 RVA: 0x002CF6A8 File Offset: 0x002CD8A8
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

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x060134F5 RID: 79093 RVA: 0x002CF6B1 File Offset: 0x002CD8B1
		// (set) Token: 0x060134F6 RID: 79094 RVA: 0x002CF6B9 File Offset: 0x002CD8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchInfo QuestBranchInfo
		{
			get
			{
				return this.questBranchInfo_;
			}
			set
			{
				this.questBranchInfo_ = value;
			}
		}

		// Token: 0x060134F7 RID: 79095 RVA: 0x002CF6C2 File Offset: 0x002CD8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchResponse);
		}

		// Token: 0x060134F8 RID: 79096 RVA: 0x002CF6D0 File Offset: 0x002CD8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.QuestBranchInfo, other.QuestBranchInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134F9 RID: 79097 RVA: 0x002CF720 File Offset: 0x002CD920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.questBranchInfo_ != null)
			{
				num ^= this.QuestBranchInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060134FA RID: 79098 RVA: 0x002CF77B File Offset: 0x002CD97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134FB RID: 79099 RVA: 0x002CF788 File Offset: 0x002CD988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134FC RID: 79100 RVA: 0x002CF794 File Offset: 0x002CD994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.questBranchInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.QuestBranchInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134FD RID: 79101 RVA: 0x002CF7EC File Offset: 0x002CD9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.questBranchInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QuestBranchInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060134FE RID: 79102 RVA: 0x002CF844 File Offset: 0x002CDA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.questBranchInfo_ != null)
			{
				if (this.questBranchInfo_ == null)
				{
					this.QuestBranchInfo = new QuestBranchInfo();
				}
				this.QuestBranchInfo.MergeFrom(other.QuestBranchInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060134FF RID: 79103 RVA: 0x002CF8AC File Offset: 0x002CDAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013500 RID: 79104 RVA: 0x002CF8B8 File Offset: 0x002CDAB8
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
				if (num != 8U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.questBranchInfo_ == null)
						{
							this.QuestBranchInfo = new QuestBranchInfo();
						}
						input.ReadMessage(this.QuestBranchInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076A8 RID: 30376
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076A9 RID: 30377
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040076AA RID: 30378
		private ErrorCode errorCode_;

		// Token: 0x040076AB RID: 30379
		public const int QuestBranchInfoFieldNumber = 6;

		// Token: 0x040076AC RID: 30380
		private QuestBranchInfo questBranchInfo_;
	}
}
