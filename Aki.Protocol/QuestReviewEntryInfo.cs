using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E17 RID: 3607
	public sealed class QuestReviewEntryInfo : IMessage<QuestReviewEntryInfo>, IMessage, IEquatable<QuestReviewEntryInfo>, IDeepCloneable<QuestReviewEntryInfo>, IBufferMessage
	{
		// Token: 0x06013660 RID: 79456 RVA: 0x002D27C5 File Offset: 0x002D09C5
		[NullableContext(1)]
		public static QuestReviewEntryInfo Create()
		{
			return new QuestReviewEntryInfo();
		}

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x06013661 RID: 79457 RVA: 0x002D27CC File Offset: 0x002D09CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestReviewEntryInfo> Parser
		{
			get
			{
				return QuestReviewEntryInfo._parser;
			}
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x06013662 RID: 79458 RVA: 0x002D27D3 File Offset: 0x002D09D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x06013663 RID: 79459 RVA: 0x002D27D6 File Offset: 0x002D09D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewEntryInfo.Descriptor;
			}
		}

		// Token: 0x06013664 RID: 79460 RVA: 0x002D27DD File Offset: 0x002D09DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewEntryInfo()
		{
		}

		// Token: 0x06013665 RID: 79461 RVA: 0x002D27E5 File Offset: 0x002D09E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewEntryInfo(QuestReviewEntryInfo other) : this()
		{
			this.entryId_ = other.entryId_;
			this.showCondition_ = other.showCondition_;
			this.hideCondition_ = other.hideCondition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013666 RID: 79462 RVA: 0x002D2822 File Offset: 0x002D0A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewEntryInfo Clone()
		{
			return new QuestReviewEntryInfo(this);
		}

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x06013667 RID: 79463 RVA: 0x002D282A File Offset: 0x002D0A2A
		// (set) Token: 0x06013668 RID: 79464 RVA: 0x002D2832 File Offset: 0x002D0A32
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

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x06013669 RID: 79465 RVA: 0x002D283B File Offset: 0x002D0A3B
		// (set) Token: 0x0601366A RID: 79466 RVA: 0x002D2843 File Offset: 0x002D0A43
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

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x0601366B RID: 79467 RVA: 0x002D284C File Offset: 0x002D0A4C
		// (set) Token: 0x0601366C RID: 79468 RVA: 0x002D2854 File Offset: 0x002D0A54
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

		// Token: 0x0601366D RID: 79469 RVA: 0x002D285D File Offset: 0x002D0A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewEntryInfo);
		}

		// Token: 0x0601366E RID: 79470 RVA: 0x002D286C File Offset: 0x002D0A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewEntryInfo other)
		{
			return other != null && (other == this || (this.EntryId == other.EntryId && this.ShowCondition == other.ShowCondition && this.HideCondition == other.HideCondition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601366F RID: 79471 RVA: 0x002D28C8 File Offset: 0x002D0AC8
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

		// Token: 0x06013670 RID: 79472 RVA: 0x002D2939 File Offset: 0x002D0B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013671 RID: 79473 RVA: 0x002D2946 File Offset: 0x002D0B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013672 RID: 79474 RVA: 0x002D2950 File Offset: 0x002D0B50
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

		// Token: 0x06013673 RID: 79475 RVA: 0x002D29C4 File Offset: 0x002D0BC4
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

		// Token: 0x06013674 RID: 79476 RVA: 0x002D2A1C File Offset: 0x002D0C1C
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

		// Token: 0x06013675 RID: 79477 RVA: 0x002D2A80 File Offset: 0x002D0C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013676 RID: 79478 RVA: 0x002D2A8C File Offset: 0x002D0C8C
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

		// Token: 0x0400775E RID: 30558
		private static readonly MessageParser<QuestReviewEntryInfo> _parser = new MessageParser<QuestReviewEntryInfo>(() => new QuestReviewEntryInfo());

		// Token: 0x0400775F RID: 30559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007760 RID: 30560
		public const int EntryIdFieldNumber = 1;

		// Token: 0x04007761 RID: 30561
		private int entryId_;

		// Token: 0x04007762 RID: 30562
		public const int ShowConditionFieldNumber = 2;

		// Token: 0x04007763 RID: 30563
		private bool showCondition_;

		// Token: 0x04007764 RID: 30564
		public const int HideConditionFieldNumber = 3;

		// Token: 0x04007765 RID: 30565
		private bool hideCondition_;
	}
}
