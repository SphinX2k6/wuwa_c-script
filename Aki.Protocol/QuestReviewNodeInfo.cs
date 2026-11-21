using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1C RID: 3612
	public sealed class QuestReviewNodeInfo : IMessage<QuestReviewNodeInfo>, IMessage, IEquatable<QuestReviewNodeInfo>, IDeepCloneable<QuestReviewNodeInfo>, IBufferMessage
	{
		// Token: 0x060136C7 RID: 79559 RVA: 0x002D359A File Offset: 0x002D179A
		[NullableContext(1)]
		public static QuestReviewNodeInfo Create()
		{
			return new QuestReviewNodeInfo();
		}

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x060136C8 RID: 79560 RVA: 0x002D35A1 File Offset: 0x002D17A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestReviewNodeInfo> Parser
		{
			get
			{
				return QuestReviewNodeInfo._parser;
			}
		}

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x060136C9 RID: 79561 RVA: 0x002D35A8 File Offset: 0x002D17A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x060136CA RID: 79562 RVA: 0x002D35AB File Offset: 0x002D17AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewNodeInfo.Descriptor;
			}
		}

		// Token: 0x060136CB RID: 79563 RVA: 0x002D35B2 File Offset: 0x002D17B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewNodeInfo()
		{
		}

		// Token: 0x060136CC RID: 79564 RVA: 0x002D35BC File Offset: 0x002D17BC
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

		// Token: 0x060136CD RID: 79565 RVA: 0x002D3610 File Offset: 0x002D1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewNodeInfo Clone()
		{
			return new QuestReviewNodeInfo(this);
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x060136CE RID: 79566 RVA: 0x002D3618 File Offset: 0x002D1818
		// (set) Token: 0x060136CF RID: 79567 RVA: 0x002D3620 File Offset: 0x002D1820
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

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x060136D0 RID: 79568 RVA: 0x002D3629 File Offset: 0x002D1829
		// (set) Token: 0x060136D1 RID: 79569 RVA: 0x002D3631 File Offset: 0x002D1831
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

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x060136D2 RID: 79570 RVA: 0x002D363A File Offset: 0x002D183A
		// (set) Token: 0x060136D3 RID: 79571 RVA: 0x002D3642 File Offset: 0x002D1842
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

		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x060136D4 RID: 79572 RVA: 0x002D364B File Offset: 0x002D184B
		// (set) Token: 0x060136D5 RID: 79573 RVA: 0x002D3653 File Offset: 0x002D1853
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

		// Token: 0x060136D6 RID: 79574 RVA: 0x002D365C File Offset: 0x002D185C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewNodeInfo);
		}

		// Token: 0x060136D7 RID: 79575 RVA: 0x002D366C File Offset: 0x002D186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewNodeInfo other)
		{
			return other != null && (other == this || (this.NodeId == other.NodeId && this.UnlockCondition == other.UnlockCondition && this.InProgressCondition == other.InProgressCondition && this.FinishCondition == other.FinishCondition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136D8 RID: 79576 RVA: 0x002D36D8 File Offset: 0x002D18D8
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

		// Token: 0x060136D9 RID: 79577 RVA: 0x002D3762 File Offset: 0x002D1962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136DA RID: 79578 RVA: 0x002D376F File Offset: 0x002D196F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136DB RID: 79579 RVA: 0x002D3778 File Offset: 0x002D1978
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

		// Token: 0x060136DC RID: 79580 RVA: 0x002D3808 File Offset: 0x002D1A08
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

		// Token: 0x060136DD RID: 79581 RVA: 0x002D386C File Offset: 0x002D1A6C
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

		// Token: 0x060136DE RID: 79582 RVA: 0x002D38E4 File Offset: 0x002D1AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136DF RID: 79583 RVA: 0x002D38F0 File Offset: 0x002D1AF0
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

		// Token: 0x0400777F RID: 30591
		private static readonly MessageParser<QuestReviewNodeInfo> _parser = new MessageParser<QuestReviewNodeInfo>(() => new QuestReviewNodeInfo());

		// Token: 0x04007780 RID: 30592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007781 RID: 30593
		public const int NodeIdFieldNumber = 1;

		// Token: 0x04007782 RID: 30594
		private int nodeId_;

		// Token: 0x04007783 RID: 30595
		public const int UnlockConditionFieldNumber = 2;

		// Token: 0x04007784 RID: 30596
		private bool unlockCondition_;

		// Token: 0x04007785 RID: 30597
		public const int InProgressConditionFieldNumber = 3;

		// Token: 0x04007786 RID: 30598
		private bool inProgressCondition_;

		// Token: 0x04007787 RID: 30599
		public const int FinishConditionFieldNumber = 4;

		// Token: 0x04007788 RID: 30600
		private bool finishCondition_;
	}
}
