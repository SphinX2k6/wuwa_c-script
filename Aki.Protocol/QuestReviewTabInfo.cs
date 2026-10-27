using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2D RID: 3629
	public sealed class QuestReviewTabInfo : IMessage<QuestReviewTabInfo>, IMessage, IEquatable<QuestReviewTabInfo>, IDeepCloneable<QuestReviewTabInfo>, IBufferMessage
	{
		// Token: 0x060137C6 RID: 79814 RVA: 0x002D5054 File Offset: 0x002D3254
		[NullableContext(1)]
		public static QuestReviewTabInfo Create()
		{
			return new QuestReviewTabInfo();
		}

		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x060137C7 RID: 79815 RVA: 0x002D505B File Offset: 0x002D325B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestReviewTabInfo> Parser
		{
			get
			{
				return QuestReviewTabInfo._parser;
			}
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x060137C8 RID: 79816 RVA: 0x002D5062 File Offset: 0x002D3262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x060137C9 RID: 79817 RVA: 0x002D5065 File Offset: 0x002D3265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewTabInfo.Descriptor;
			}
		}

		// Token: 0x060137CA RID: 79818 RVA: 0x002D506C File Offset: 0x002D326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewTabInfo()
		{
		}

		// Token: 0x060137CB RID: 79819 RVA: 0x002D5074 File Offset: 0x002D3274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewTabInfo(QuestReviewTabInfo other) : this()
		{
			this.tabId_ = other.tabId_;
			this.unlockCondition_ = other.unlockCondition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060137CC RID: 79820 RVA: 0x002D50A5 File Offset: 0x002D32A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewTabInfo Clone()
		{
			return new QuestReviewTabInfo(this);
		}

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x060137CD RID: 79821 RVA: 0x002D50AD File Offset: 0x002D32AD
		// (set) Token: 0x060137CE RID: 79822 RVA: 0x002D50B5 File Offset: 0x002D32B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabId
		{
			get
			{
				return this.tabId_;
			}
			set
			{
				this.tabId_ = value;
			}
		}

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x060137CF RID: 79823 RVA: 0x002D50BE File Offset: 0x002D32BE
		// (set) Token: 0x060137D0 RID: 79824 RVA: 0x002D50C6 File Offset: 0x002D32C6
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

		// Token: 0x060137D1 RID: 79825 RVA: 0x002D50CF File Offset: 0x002D32CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewTabInfo);
		}

		// Token: 0x060137D2 RID: 79826 RVA: 0x002D50DD File Offset: 0x002D32DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewTabInfo other)
		{
			return other != null && (other == this || (this.TabId == other.TabId && this.UnlockCondition == other.UnlockCondition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137D3 RID: 79827 RVA: 0x002D511C File Offset: 0x002D331C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TabId != 0)
			{
				num ^= this.TabId.GetHashCode();
			}
			if (this.UnlockCondition)
			{
				num ^= this.UnlockCondition.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060137D4 RID: 79828 RVA: 0x002D5174 File Offset: 0x002D3374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137D5 RID: 79829 RVA: 0x002D5181 File Offset: 0x002D3381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137D6 RID: 79830 RVA: 0x002D518C File Offset: 0x002D338C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TabId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TabId);
			}
			if (this.UnlockCondition)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.UnlockCondition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060137D7 RID: 79831 RVA: 0x002D51E4 File Offset: 0x002D33E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TabId);
			}
			if (this.UnlockCondition)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060137D8 RID: 79832 RVA: 0x002D5230 File Offset: 0x002D3430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewTabInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TabId != 0)
			{
				this.TabId = other.TabId;
			}
			if (other.UnlockCondition)
			{
				this.UnlockCondition = other.UnlockCondition;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060137D9 RID: 79833 RVA: 0x002D5280 File Offset: 0x002D3480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060137DA RID: 79834 RVA: 0x002D528C File Offset: 0x002D348C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UnlockCondition = input.ReadBool();
					}
				}
				else
				{
					this.TabId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400775F RID: 30559
		private static readonly MessageParser<QuestReviewTabInfo> _parser = new MessageParser<QuestReviewTabInfo>(() => new QuestReviewTabInfo());

		// Token: 0x04007760 RID: 30560
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007761 RID: 30561
		public const int TabIdFieldNumber = 1;

		// Token: 0x04007762 RID: 30562
		private int tabId_;

		// Token: 0x04007763 RID: 30563
		public const int UnlockConditionFieldNumber = 2;

		// Token: 0x04007764 RID: 30564
		private bool unlockCondition_;
	}
}
