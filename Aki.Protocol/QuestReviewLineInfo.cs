using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2B RID: 3627
	public sealed class QuestReviewLineInfo : IMessage<QuestReviewLineInfo>, IMessage, IEquatable<QuestReviewLineInfo>, IDeepCloneable<QuestReviewLineInfo>, IBufferMessage
	{
		// Token: 0x06013794 RID: 79764 RVA: 0x002D4911 File Offset: 0x002D2B11
		[NullableContext(1)]
		public static QuestReviewLineInfo Create()
		{
			return new QuestReviewLineInfo();
		}

		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x06013795 RID: 79765 RVA: 0x002D4918 File Offset: 0x002D2B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestReviewLineInfo> Parser
		{
			get
			{
				return QuestReviewLineInfo._parser;
			}
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x06013796 RID: 79766 RVA: 0x002D491F File Offset: 0x002D2B1F
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
		// (get) Token: 0x06013797 RID: 79767 RVA: 0x002D4922 File Offset: 0x002D2B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewLineInfo.Descriptor;
			}
		}

		// Token: 0x06013798 RID: 79768 RVA: 0x002D4929 File Offset: 0x002D2B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewLineInfo()
		{
		}

		// Token: 0x06013799 RID: 79769 RVA: 0x002D4931 File Offset: 0x002D2B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewLineInfo(QuestReviewLineInfo other) : this()
		{
			this.lineId_ = other.lineId_;
			this.showCondition_ = other.showCondition_;
			this.destroyCondition_ = other.destroyCondition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601379A RID: 79770 RVA: 0x002D496E File Offset: 0x002D2B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewLineInfo Clone()
		{
			return new QuestReviewLineInfo(this);
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x0601379B RID: 79771 RVA: 0x002D4976 File Offset: 0x002D2B76
		// (set) Token: 0x0601379C RID: 79772 RVA: 0x002D497E File Offset: 0x002D2B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LineId
		{
			get
			{
				return this.lineId_;
			}
			set
			{
				this.lineId_ = value;
			}
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x0601379D RID: 79773 RVA: 0x002D4987 File Offset: 0x002D2B87
		// (set) Token: 0x0601379E RID: 79774 RVA: 0x002D498F File Offset: 0x002D2B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowCondition
		{
			get
			{
				return this.showCondition_;
			}
			set
			{
				this.showCondition_ = value;
			}
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x0601379F RID: 79775 RVA: 0x002D4998 File Offset: 0x002D2B98
		// (set) Token: 0x060137A0 RID: 79776 RVA: 0x002D49A0 File Offset: 0x002D2BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DestroyCondition
		{
			get
			{
				return this.destroyCondition_;
			}
			set
			{
				this.destroyCondition_ = value;
			}
		}

		// Token: 0x060137A1 RID: 79777 RVA: 0x002D49A9 File Offset: 0x002D2BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewLineInfo);
		}

		// Token: 0x060137A2 RID: 79778 RVA: 0x002D49B8 File Offset: 0x002D2BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewLineInfo other)
		{
			return other != null && (other == this || (this.LineId == other.LineId && this.ShowCondition == other.ShowCondition && this.DestroyCondition == other.DestroyCondition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137A3 RID: 79779 RVA: 0x002D4A14 File Offset: 0x002D2C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LineId != 0)
			{
				num ^= this.LineId.GetHashCode();
			}
			if (this.ShowCondition)
			{
				num ^= this.ShowCondition.GetHashCode();
			}
			if (this.DestroyCondition)
			{
				num ^= this.DestroyCondition.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060137A4 RID: 79780 RVA: 0x002D4A85 File Offset: 0x002D2C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137A5 RID: 79781 RVA: 0x002D4A92 File Offset: 0x002D2C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137A6 RID: 79782 RVA: 0x002D4A9C File Offset: 0x002D2C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LineId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LineId);
			}
			if (this.ShowCondition)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShowCondition);
			}
			if (this.DestroyCondition)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.DestroyCondition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060137A7 RID: 79783 RVA: 0x002D4B10 File Offset: 0x002D2D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LineId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LineId);
			}
			if (this.ShowCondition)
			{
				num += 2;
			}
			if (this.DestroyCondition)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060137A8 RID: 79784 RVA: 0x002D4B68 File Offset: 0x002D2D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewLineInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LineId != 0)
			{
				this.LineId = other.LineId;
			}
			if (other.ShowCondition)
			{
				this.ShowCondition = other.ShowCondition;
			}
			if (other.DestroyCondition)
			{
				this.DestroyCondition = other.DestroyCondition;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060137A9 RID: 79785 RVA: 0x002D4BCC File Offset: 0x002D2DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060137AA RID: 79786 RVA: 0x002D4BD8 File Offset: 0x002D2DD8
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DestroyCondition = input.ReadBool();
						}
					}
					else
					{
						this.ShowCondition = input.ReadBool();
					}
				}
				else
				{
					this.LineId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400774D RID: 30541
		private static readonly MessageParser<QuestReviewLineInfo> _parser = new MessageParser<QuestReviewLineInfo>(() => new QuestReviewLineInfo());

		// Token: 0x0400774E RID: 30542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400774F RID: 30543
		public const int LineIdFieldNumber = 1;

		// Token: 0x04007750 RID: 30544
		private int lineId_;

		// Token: 0x04007751 RID: 30545
		public const int ShowConditionFieldNumber = 2;

		// Token: 0x04007752 RID: 30546
		private bool showCondition_;

		// Token: 0x04007753 RID: 30547
		public const int DestroyConditionFieldNumber = 3;

		// Token: 0x04007754 RID: 30548
		private bool destroyCondition_;
	}
}
