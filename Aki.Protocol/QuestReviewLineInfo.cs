using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1B RID: 3611
	public sealed class QuestReviewLineInfo : IMessage<QuestReviewLineInfo>, IMessage, IEquatable<QuestReviewLineInfo>, IDeepCloneable<QuestReviewLineInfo>, IBufferMessage
	{
		// Token: 0x060136AF RID: 79535 RVA: 0x002D324D File Offset: 0x002D144D
		[NullableContext(1)]
		public static QuestReviewLineInfo Create()
		{
			return new QuestReviewLineInfo();
		}

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x060136B0 RID: 79536 RVA: 0x002D3254 File Offset: 0x002D1454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestReviewLineInfo> Parser
		{
			get
			{
				return QuestReviewLineInfo._parser;
			}
		}

		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x060136B1 RID: 79537 RVA: 0x002D325B File Offset: 0x002D145B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x060136B2 RID: 79538 RVA: 0x002D325E File Offset: 0x002D145E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewLineInfo.Descriptor;
			}
		}

		// Token: 0x060136B3 RID: 79539 RVA: 0x002D3265 File Offset: 0x002D1465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewLineInfo()
		{
		}

		// Token: 0x060136B4 RID: 79540 RVA: 0x002D326D File Offset: 0x002D146D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewLineInfo(QuestReviewLineInfo other) : this()
		{
			this.lineId_ = other.lineId_;
			this.showCondition_ = other.showCondition_;
			this.destroyCondition_ = other.destroyCondition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136B5 RID: 79541 RVA: 0x002D32AA File Offset: 0x002D14AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewLineInfo Clone()
		{
			return new QuestReviewLineInfo(this);
		}

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x060136B6 RID: 79542 RVA: 0x002D32B2 File Offset: 0x002D14B2
		// (set) Token: 0x060136B7 RID: 79543 RVA: 0x002D32BA File Offset: 0x002D14BA
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

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x060136B8 RID: 79544 RVA: 0x002D32C3 File Offset: 0x002D14C3
		// (set) Token: 0x060136B9 RID: 79545 RVA: 0x002D32CB File Offset: 0x002D14CB
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

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x060136BA RID: 79546 RVA: 0x002D32D4 File Offset: 0x002D14D4
		// (set) Token: 0x060136BB RID: 79547 RVA: 0x002D32DC File Offset: 0x002D14DC
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

		// Token: 0x060136BC RID: 79548 RVA: 0x002D32E5 File Offset: 0x002D14E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewLineInfo);
		}

		// Token: 0x060136BD RID: 79549 RVA: 0x002D32F4 File Offset: 0x002D14F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewLineInfo other)
		{
			return other != null && (other == this || (this.LineId == other.LineId && this.ShowCondition == other.ShowCondition && this.DestroyCondition == other.DestroyCondition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136BE RID: 79550 RVA: 0x002D3350 File Offset: 0x002D1550
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

		// Token: 0x060136BF RID: 79551 RVA: 0x002D33C1 File Offset: 0x002D15C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136C0 RID: 79552 RVA: 0x002D33CE File Offset: 0x002D15CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136C1 RID: 79553 RVA: 0x002D33D8 File Offset: 0x002D15D8
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

		// Token: 0x060136C2 RID: 79554 RVA: 0x002D344C File Offset: 0x002D164C
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

		// Token: 0x060136C3 RID: 79555 RVA: 0x002D34A4 File Offset: 0x002D16A4
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

		// Token: 0x060136C4 RID: 79556 RVA: 0x002D3508 File Offset: 0x002D1708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136C5 RID: 79557 RVA: 0x002D3514 File Offset: 0x002D1714
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

		// Token: 0x04007777 RID: 30583
		private static readonly MessageParser<QuestReviewLineInfo> _parser = new MessageParser<QuestReviewLineInfo>(() => new QuestReviewLineInfo());

		// Token: 0x04007778 RID: 30584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007779 RID: 30585
		public const int LineIdFieldNumber = 1;

		// Token: 0x0400777A RID: 30586
		private int lineId_;

		// Token: 0x0400777B RID: 30587
		public const int ShowConditionFieldNumber = 2;

		// Token: 0x0400777C RID: 30588
		private bool showCondition_;

		// Token: 0x0400777D RID: 30589
		public const int DestroyConditionFieldNumber = 3;

		// Token: 0x0400777E RID: 30590
		private bool destroyCondition_;
	}
}
