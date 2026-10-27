using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E27 RID: 3623
	public sealed class QuestReviewEntryInfo : IMessage<QuestReviewEntryInfo>, IMessage, IEquatable<QuestReviewEntryInfo>, IDeepCloneable<QuestReviewEntryInfo>, IBufferMessage
	{
		// Token: 0x06013745 RID: 79685 RVA: 0x002D3E89 File Offset: 0x002D2089
		[NullableContext(1)]
		public static QuestReviewEntryInfo Create()
		{
			return new QuestReviewEntryInfo();
		}

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x06013746 RID: 79686 RVA: 0x002D3E90 File Offset: 0x002D2090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestReviewEntryInfo> Parser
		{
			get
			{
				return QuestReviewEntryInfo._parser;
			}
		}

		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x06013747 RID: 79687 RVA: 0x002D3E97 File Offset: 0x002D2097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x06013748 RID: 79688 RVA: 0x002D3E9A File Offset: 0x002D209A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewEntryInfo.Descriptor;
			}
		}

		// Token: 0x06013749 RID: 79689 RVA: 0x002D3EA1 File Offset: 0x002D20A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewEntryInfo()
		{
		}

		// Token: 0x0601374A RID: 79690 RVA: 0x002D3EA9 File Offset: 0x002D20A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewEntryInfo(QuestReviewEntryInfo other) : this()
		{
			this.entryId_ = other.entryId_;
			this.showCondition_ = other.showCondition_;
			this.hideCondition_ = other.hideCondition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601374B RID: 79691 RVA: 0x002D3EE6 File Offset: 0x002D20E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewEntryInfo Clone()
		{
			return new QuestReviewEntryInfo(this);
		}

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x0601374C RID: 79692 RVA: 0x002D3EEE File Offset: 0x002D20EE
		// (set) Token: 0x0601374D RID: 79693 RVA: 0x002D3EF6 File Offset: 0x002D20F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x0601374E RID: 79694 RVA: 0x002D3EFF File Offset: 0x002D20FF
		// (set) Token: 0x0601374F RID: 79695 RVA: 0x002D3F07 File Offset: 0x002D2107
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

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x06013750 RID: 79696 RVA: 0x002D3F10 File Offset: 0x002D2110
		// (set) Token: 0x06013751 RID: 79697 RVA: 0x002D3F18 File Offset: 0x002D2118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HideCondition
		{
			get
			{
				return this.hideCondition_;
			}
			set
			{
				this.hideCondition_ = value;
			}
		}

		// Token: 0x06013752 RID: 79698 RVA: 0x002D3F21 File Offset: 0x002D2121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewEntryInfo);
		}

		// Token: 0x06013753 RID: 79699 RVA: 0x002D3F30 File Offset: 0x002D2130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewEntryInfo other)
		{
			return other != null && (other == this || (this.EntryId == other.EntryId && this.ShowCondition == other.ShowCondition && this.HideCondition == other.HideCondition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013754 RID: 79700 RVA: 0x002D3F8C File Offset: 0x002D218C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntryId != 0)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this.ShowCondition)
			{
				num ^= this.ShowCondition.GetHashCode();
			}
			if (this.HideCondition)
			{
				num ^= this.HideCondition.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013755 RID: 79701 RVA: 0x002D3FFD File Offset: 0x002D21FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013756 RID: 79702 RVA: 0x002D400A File Offset: 0x002D220A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013757 RID: 79703 RVA: 0x002D4014 File Offset: 0x002D2214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntryId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntryId);
			}
			if (this.ShowCondition)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShowCondition);
			}
			if (this.HideCondition)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HideCondition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013758 RID: 79704 RVA: 0x002D4088 File Offset: 0x002D2288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntryId);
			}
			if (this.ShowCondition)
			{
				num += 2;
			}
			if (this.HideCondition)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013759 RID: 79705 RVA: 0x002D40E0 File Offset: 0x002D22E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewEntryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntryId != 0)
			{
				this.EntryId = other.EntryId;
			}
			if (other.ShowCondition)
			{
				this.ShowCondition = other.ShowCondition;
			}
			if (other.HideCondition)
			{
				this.HideCondition = other.HideCondition;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601375A RID: 79706 RVA: 0x002D4144 File Offset: 0x002D2344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601375B RID: 79707 RVA: 0x002D4150 File Offset: 0x002D2350
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
							this.HideCondition = input.ReadBool();
						}
					}
					else
					{
						this.ShowCondition = input.ReadBool();
					}
				}
				else
				{
					this.EntryId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007734 RID: 30516
		private static readonly MessageParser<QuestReviewEntryInfo> _parser = new MessageParser<QuestReviewEntryInfo>(() => new QuestReviewEntryInfo());

		// Token: 0x04007735 RID: 30517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007736 RID: 30518
		public const int EntryIdFieldNumber = 1;

		// Token: 0x04007737 RID: 30519
		private int entryId_;

		// Token: 0x04007738 RID: 30520
		public const int ShowConditionFieldNumber = 2;

		// Token: 0x04007739 RID: 30521
		private bool showCondition_;

		// Token: 0x0400773A RID: 30522
		public const int HideConditionFieldNumber = 3;

		// Token: 0x0400773B RID: 30523
		private bool hideCondition_;
	}
}
