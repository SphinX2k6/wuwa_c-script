using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E18 RID: 3608
	[NetMessage(EMessageId.QuestReviewInfoNotify)]
	public sealed class QuestReviewInfoNotify : IMessage<QuestReviewInfoNotify>, IMessage, IEquatable<QuestReviewInfoNotify>, IDeepCloneable<QuestReviewInfoNotify>, IBufferMessage
	{
		// Token: 0x06013678 RID: 79480 RVA: 0x002D2B12 File Offset: 0x002D0D12
		[NullableContext(1)]
		public static QuestReviewInfoNotify Create()
		{
			return new QuestReviewInfoNotify();
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x06013679 RID: 79481 RVA: 0x002D2B19 File Offset: 0x002D0D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x0601367A RID: 79482 RVA: 0x002D2B1C File Offset: 0x002D0D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601367B RID: 79483 RVA: 0x002D2B23 File Offset: 0x002D0D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoNotify()
		{
		}

		// Token: 0x0601367C RID: 79484 RVA: 0x002D2B58 File Offset: 0x002D0D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoNotify(QuestReviewInfoNotify other) : this()
		{
			this.nodeInfos_ = other.nodeInfos_.Clone();
			this.lineInfos_ = other.lineInfos_.Clone();
			this.tabInfos_ = other.tabInfos_.Clone();
			this.entryInfos_ = other.entryInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601367D RID: 79485 RVA: 0x002D2BC0 File Offset: 0x002D0DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoNotify Clone()
		{
			return new QuestReviewInfoNotify(this);
		}

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x0601367E RID: 79486 RVA: 0x002D2BC8 File Offset: 0x002D0DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestReviewNodeInfo> NodeInfos
		{
			get
			{
				return this.nodeInfos_;
			}
		}

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x0601367F RID: 79487 RVA: 0x002D2BD0 File Offset: 0x002D0DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestReviewLineInfo> LineInfos
		{
			get
			{
				return this.lineInfos_;
			}
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x06013680 RID: 79488 RVA: 0x002D2BD8 File Offset: 0x002D0DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestReviewTabInfo> TabInfos
		{
			get
			{
				return this.tabInfos_;
			}
		}

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x06013681 RID: 79489 RVA: 0x002D2BE0 File Offset: 0x002D0DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestReviewEntryInfo> EntryInfos
		{
			get
			{
				return this.entryInfos_;
			}
		}

		// Token: 0x06013682 RID: 79490 RVA: 0x002D2BE8 File Offset: 0x002D0DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewInfoNotify);
		}

		// Token: 0x06013683 RID: 79491 RVA: 0x002D2BF8 File Offset: 0x002D0DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewInfoNotify other)
		{
			return other != null && (other == this || (this.nodeInfos_.Equals(other.nodeInfos_) && this.lineInfos_.Equals(other.lineInfos_) && this.tabInfos_.Equals(other.tabInfos_) && this.entryInfos_.Equals(other.entryInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013684 RID: 79492 RVA: 0x002D2C78 File Offset: 0x002D0E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nodeInfos_.GetHashCode();
			num ^= this.lineInfos_.GetHashCode();
			num ^= this.tabInfos_.GetHashCode();
			num ^= this.entryInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013685 RID: 79493 RVA: 0x002D2CD6 File Offset: 0x002D0ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013686 RID: 79494 RVA: 0x002D2CE3 File Offset: 0x002D0EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013687 RID: 79495 RVA: 0x002D2CEC File Offset: 0x002D0EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entryInfos_.WriteTo(ref output, QuestReviewInfoNotify._repeated_entryInfos_codec);
			this.tabInfos_.WriteTo(ref output, QuestReviewInfoNotify._repeated_tabInfos_codec);
			this.nodeInfos_.WriteTo(ref output, QuestReviewInfoNotify._repeated_nodeInfos_codec);
			this.lineInfos_.WriteTo(ref output, QuestReviewInfoNotify._repeated_lineInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013688 RID: 79496 RVA: 0x002D2D54 File Offset: 0x002D0F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nodeInfos_.CalculateSize(QuestReviewInfoNotify._repeated_nodeInfos_codec);
			num += this.lineInfos_.CalculateSize(QuestReviewInfoNotify._repeated_lineInfos_codec);
			num += this.tabInfos_.CalculateSize(QuestReviewInfoNotify._repeated_tabInfos_codec);
			num += this.entryInfos_.CalculateSize(QuestReviewInfoNotify._repeated_entryInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013689 RID: 79497 RVA: 0x002D2DC8 File Offset: 0x002D0FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.nodeInfos_.Add(other.nodeInfos_);
			this.lineInfos_.Add(other.lineInfos_);
			this.tabInfos_.Add(other.tabInfos_);
			this.entryInfos_.Add(other.entryInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601368A RID: 79498 RVA: 0x002D2E34 File Offset: 0x002D1034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601368B RID: 79499 RVA: 0x002D2E40 File Offset: 0x002D1040
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.entryInfos_.AddEntriesFrom(ref input, QuestReviewInfoNotify._repeated_entryInfos_codec);
						continue;
					}
					if (num == 18U)
					{
						this.tabInfos_.AddEntriesFrom(ref input, QuestReviewInfoNotify._repeated_tabInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.nodeInfos_.AddEntriesFrom(ref input, QuestReviewInfoNotify._repeated_nodeInfos_codec);
						continue;
					}
					if (num == 122U)
					{
						this.lineInfos_.AddEntriesFrom(ref input, QuestReviewInfoNotify._repeated_lineInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007766 RID: 30566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007767 RID: 30567
		public const int NodeInfosFieldNumber = 14;

		// Token: 0x04007768 RID: 30568
		private static readonly FieldCodec<QuestReviewNodeInfo> _repeated_nodeInfos_codec = FieldCodec.ForMessage<QuestReviewNodeInfo>(114U, QuestReviewNodeInfo.Parser);

		// Token: 0x04007769 RID: 30569
		private readonly RepeatedField<QuestReviewNodeInfo> nodeInfos_ = new RepeatedField<QuestReviewNodeInfo>();

		// Token: 0x0400776A RID: 30570
		public const int LineInfosFieldNumber = 15;

		// Token: 0x0400776B RID: 30571
		private static readonly FieldCodec<QuestReviewLineInfo> _repeated_lineInfos_codec = FieldCodec.ForMessage<QuestReviewLineInfo>(122U, QuestReviewLineInfo.Parser);

		// Token: 0x0400776C RID: 30572
		private readonly RepeatedField<QuestReviewLineInfo> lineInfos_ = new RepeatedField<QuestReviewLineInfo>();

		// Token: 0x0400776D RID: 30573
		public const int TabInfosFieldNumber = 2;

		// Token: 0x0400776E RID: 30574
		private static readonly FieldCodec<QuestReviewTabInfo> _repeated_tabInfos_codec = FieldCodec.ForMessage<QuestReviewTabInfo>(18U, QuestReviewTabInfo.Parser);

		// Token: 0x0400776F RID: 30575
		private readonly RepeatedField<QuestReviewTabInfo> tabInfos_ = new RepeatedField<QuestReviewTabInfo>();

		// Token: 0x04007770 RID: 30576
		public const int EntryInfosFieldNumber = 1;

		// Token: 0x04007771 RID: 30577
		private static readonly FieldCodec<QuestReviewEntryInfo> _repeated_entryInfos_codec = FieldCodec.ForMessage<QuestReviewEntryInfo>(10U, QuestReviewEntryInfo.Parser);

		// Token: 0x04007772 RID: 30578
		private readonly RepeatedField<QuestReviewEntryInfo> entryInfos_ = new RepeatedField<QuestReviewEntryInfo>();
	}
}
