using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2C RID: 3628
	public sealed class QuestReviewNodeInfo : IMessage<QuestReviewNodeInfo>, IMessage, IEquatable<QuestReviewNodeInfo>, IDeepCloneable<QuestReviewNodeInfo>, IBufferMessage
	{
		// Token: 0x060137AC RID: 79788 RVA: 0x002D4C5E File Offset: 0x002D2E5E
		[NullableContext(1)]
		public static QuestReviewNodeInfo Create()
		{
			return new QuestReviewNodeInfo();
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x060137AD RID: 79789 RVA: 0x002D4C65 File Offset: 0x002D2E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestReviewNodeInfo> Parser
		{
			get
			{
				return QuestReviewNodeInfo._parser;
			}
		}

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x060137AE RID: 79790 RVA: 0x002D4C6C File Offset: 0x002D2E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x060137AF RID: 79791 RVA: 0x002D4C6F File Offset: 0x002D2E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewNodeInfo.Descriptor;
			}
		}

		// Token: 0x060137B0 RID: 79792 RVA: 0x002D4C76 File Offset: 0x002D2E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewNodeInfo()
		{
		}

		// Token: 0x060137B1 RID: 79793 RVA: 0x002D4C80 File Offset: 0x002D2E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewNodeInfo(QuestReviewNodeInfo other) : this()
		{
			this.nodeId_ = other.nodeId_;
			this.unlockCondition_ = other.unlockCondition_;
			this.inProgressCondition_ = other.inProgressCondition_;
			this.finishCondition_ = other.finishCondition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060137B2 RID: 79794 RVA: 0x002D4CD4 File Offset: 0x002D2ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewNodeInfo Clone()
		{
			return new QuestReviewNodeInfo(this);
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x060137B3 RID: 79795 RVA: 0x002D4CDC File Offset: 0x002D2EDC
		// (set) Token: 0x060137B4 RID: 79796 RVA: 0x002D4CE4 File Offset: 0x002D2EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x060137B5 RID: 79797 RVA: 0x002D4CED File Offset: 0x002D2EED
		// (set) Token: 0x060137B6 RID: 79798 RVA: 0x002D4CF5 File Offset: 0x002D2EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnlockCondition
		{
			get
			{
				return this.unlockCondition_;
			}
			set
			{
				this.unlockCondition_ = value;
			}
		}

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x060137B7 RID: 79799 RVA: 0x002D4CFE File Offset: 0x002D2EFE
		// (set) Token: 0x060137B8 RID: 79800 RVA: 0x002D4D06 File Offset: 0x002D2F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InProgressCondition
		{
			get
			{
				return this.inProgressCondition_;
			}
			set
			{
				this.inProgressCondition_ = value;
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x060137B9 RID: 79801 RVA: 0x002D4D0F File Offset: 0x002D2F0F
		// (set) Token: 0x060137BA RID: 79802 RVA: 0x002D4D17 File Offset: 0x002D2F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FinishCondition
		{
			get
			{
				return this.finishCondition_;
			}
			set
			{
				this.finishCondition_ = value;
			}
		}

		// Token: 0x060137BB RID: 79803 RVA: 0x002D4D20 File Offset: 0x002D2F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewNodeInfo);
		}

		// Token: 0x060137BC RID: 79804 RVA: 0x002D4D30 File Offset: 0x002D2F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewNodeInfo other)
		{
			return other != null && (other == this || (this.NodeId == other.NodeId && this.UnlockCondition == other.UnlockCondition && this.InProgressCondition == other.InProgressCondition && this.FinishCondition == other.FinishCondition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137BD RID: 79805 RVA: 0x002D4D9C File Offset: 0x002D2F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.UnlockCondition)
			{
				num ^= this.UnlockCondition.GetHashCode();
			}
			if (this.InProgressCondition)
			{
				num ^= this.InProgressCondition.GetHashCode();
			}
			if (this.FinishCondition)
			{
				num ^= this.FinishCondition.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060137BE RID: 79806 RVA: 0x002D4E26 File Offset: 0x002D3026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137BF RID: 79807 RVA: 0x002D4E33 File Offset: 0x002D3033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137C0 RID: 79808 RVA: 0x002D4E3C File Offset: 0x002D303C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NodeId);
			}
			if (this.UnlockCondition)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.UnlockCondition);
			}
			if (this.InProgressCondition)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.InProgressCondition);
			}
			if (this.FinishCondition)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.FinishCondition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060137C1 RID: 79809 RVA: 0x002D4ECC File Offset: 0x002D30CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.UnlockCondition)
			{
				num += 2;
			}
			if (this.InProgressCondition)
			{
				num += 2;
			}
			if (this.FinishCondition)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060137C2 RID: 79810 RVA: 0x002D4F30 File Offset: 0x002D3130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewNodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.UnlockCondition)
			{
				this.UnlockCondition = other.UnlockCondition;
			}
			if (other.InProgressCondition)
			{
				this.InProgressCondition = other.InProgressCondition;
			}
			if (other.FinishCondition)
			{
				this.FinishCondition = other.FinishCondition;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060137C3 RID: 79811 RVA: 0x002D4FA8 File Offset: 0x002D31A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060137C4 RID: 79812 RVA: 0x002D4FB4 File Offset: 0x002D31B4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UnlockCondition = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.InProgressCondition = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.FinishCondition = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007755 RID: 30549
		private static readonly MessageParser<QuestReviewNodeInfo> _parser = new MessageParser<QuestReviewNodeInfo>(() => new QuestReviewNodeInfo());

		// Token: 0x04007756 RID: 30550
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007757 RID: 30551
		public const int NodeIdFieldNumber = 1;

		// Token: 0x04007758 RID: 30552
		private int nodeId_;

		// Token: 0x04007759 RID: 30553
		public const int UnlockConditionFieldNumber = 2;

		// Token: 0x0400775A RID: 30554
		private bool unlockCondition_;

		// Token: 0x0400775B RID: 30555
		public const int InProgressConditionFieldNumber = 3;

		// Token: 0x0400775C RID: 30556
		private bool inProgressCondition_;

		// Token: 0x0400775D RID: 30557
		public const int FinishConditionFieldNumber = 4;

		// Token: 0x0400775E RID: 30558
		private bool finishCondition_;
	}
}
