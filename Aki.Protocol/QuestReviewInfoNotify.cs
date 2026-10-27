using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E28 RID: 3624
	[NetMessage(EMessageId.QuestReviewInfoNotify)]
	public sealed class QuestReviewInfoNotify : IMessage<QuestReviewInfoNotify>, IMessage, IEquatable<QuestReviewInfoNotify>, IDeepCloneable<QuestReviewInfoNotify>, IBufferMessage
	{
		// Token: 0x0601375D RID: 79709 RVA: 0x002D41D6 File Offset: 0x002D23D6
		[NullableContext(1)]
		public static QuestReviewInfoNotify Create()
		{
			return new QuestReviewInfoNotify();
		}

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x0601375E RID: 79710 RVA: 0x002D41DD File Offset: 0x002D23DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x0601375F RID: 79711 RVA: 0x002D41E0 File Offset: 0x002D23E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewInfoNotify.Descriptor;
			}
		}

		// Token: 0x06013760 RID: 79712 RVA: 0x002D41E7 File Offset: 0x002D23E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoNotify()
		{
		}

		// Token: 0x06013761 RID: 79713 RVA: 0x002D421C File Offset: 0x002D241C
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

		// Token: 0x06013762 RID: 79714 RVA: 0x002D4284 File Offset: 0x002D2484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoNotify Clone()
		{
			return new QuestReviewInfoNotify(this);
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x06013763 RID: 79715 RVA: 0x002D428C File Offset: 0x002D248C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestReviewNodeInfo> NodeInfos
		{
			get
			{
				return this.nodeInfos_;
			}
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x06013764 RID: 79716 RVA: 0x002D4294 File Offset: 0x002D2494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestReviewLineInfo> LineInfos
		{
			get
			{
				return this.lineInfos_;
			}
		}

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x06013765 RID: 79717 RVA: 0x002D429C File Offset: 0x002D249C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestReviewTabInfo> TabInfos
		{
			get
			{
				return this.tabInfos_;
			}
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x06013766 RID: 79718 RVA: 0x002D42A4 File Offset: 0x002D24A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestReviewEntryInfo> EntryInfos
		{
			get
			{
				return this.entryInfos_;
			}
		}

		// Token: 0x06013767 RID: 79719 RVA: 0x002D42AC File Offset: 0x002D24AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewInfoNotify);
		}

		// Token: 0x06013768 RID: 79720 RVA: 0x002D42BC File Offset: 0x002D24BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewInfoNotify other)
		{
			return other != null && (other == this || (this.nodeInfos_.Equals(other.nodeInfos_) && this.lineInfos_.Equals(other.lineInfos_) && this.tabInfos_.Equals(other.tabInfos_) && this.entryInfos_.Equals(other.entryInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013769 RID: 79721 RVA: 0x002D433C File Offset: 0x002D253C
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

		// Token: 0x0601376A RID: 79722 RVA: 0x002D439A File Offset: 0x002D259A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601376B RID: 79723 RVA: 0x002D43A7 File Offset: 0x002D25A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601376C RID: 79724 RVA: 0x002D43B0 File Offset: 0x002D25B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nodeInfos_.WriteTo(ref output, QuestReviewInfoNotify._repeated_nodeInfos_codec);
			this.lineInfos_.WriteTo(ref output, QuestReviewInfoNotify._repeated_lineInfos_codec);
			this.entryInfos_.WriteTo(ref output, QuestReviewInfoNotify._repeated_entryInfos_codec);
			this.tabInfos_.WriteTo(ref output, QuestReviewInfoNotify._repeated_tabInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601376D RID: 79725 RVA: 0x002D4418 File Offset: 0x002D2618
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

		// Token: 0x0601376E RID: 79726 RVA: 0x002D448C File Offset: 0x002D268C
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

		// Token: 0x0601376F RID: 79727 RVA: 0x002D44F8 File Offset: 0x002D26F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013770 RID: 79728 RVA: 0x002D4504 File Offset: 0x002D2704
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
				if (num <= 90U)
				{
					if (num == 18U)
					{
						this.nodeInfos_.AddEntriesFrom(ref input, QuestReviewInfoNotify._repeated_nodeInfos_codec);
						continue;
					}
					if (num == 90U)
					{
						this.lineInfos_.AddEntriesFrom(ref input, QuestReviewInfoNotify._repeated_lineInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.entryInfos_.AddEntriesFrom(ref input, QuestReviewInfoNotify._repeated_entryInfos_codec);
						continue;
					}
					if (num == 122U)
					{
						this.tabInfos_.AddEntriesFrom(ref input, QuestReviewInfoNotify._repeated_tabInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400773C RID: 30524
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400773D RID: 30525
		public const int NodeInfosFieldNumber = 2;

		// Token: 0x0400773E RID: 30526
		private static readonly FieldCodec<QuestReviewNodeInfo> _repeated_nodeInfos_codec = FieldCodec.ForMessage<QuestReviewNodeInfo>(18U, QuestReviewNodeInfo.Parser);

		// Token: 0x0400773F RID: 30527
		private readonly RepeatedField<QuestReviewNodeInfo> nodeInfos_ = new RepeatedField<QuestReviewNodeInfo>();

		// Token: 0x04007740 RID: 30528
		public const int LineInfosFieldNumber = 11;

		// Token: 0x04007741 RID: 30529
		private static readonly FieldCodec<QuestReviewLineInfo> _repeated_lineInfos_codec = FieldCodec.ForMessage<QuestReviewLineInfo>(90U, QuestReviewLineInfo.Parser);

		// Token: 0x04007742 RID: 30530
		private readonly RepeatedField<QuestReviewLineInfo> lineInfos_ = new RepeatedField<QuestReviewLineInfo>();

		// Token: 0x04007743 RID: 30531
		public const int TabInfosFieldNumber = 15;

		// Token: 0x04007744 RID: 30532
		private static readonly FieldCodec<QuestReviewTabInfo> _repeated_tabInfos_codec = FieldCodec.ForMessage<QuestReviewTabInfo>(122U, QuestReviewTabInfo.Parser);

		// Token: 0x04007745 RID: 30533
		private readonly RepeatedField<QuestReviewTabInfo> tabInfos_ = new RepeatedField<QuestReviewTabInfo>();

		// Token: 0x04007746 RID: 30534
		public const int EntryInfosFieldNumber = 13;

		// Token: 0x04007747 RID: 30535
		private static readonly FieldCodec<QuestReviewEntryInfo> _repeated_entryInfos_codec = FieldCodec.ForMessage<QuestReviewEntryInfo>(106U, QuestReviewEntryInfo.Parser);

		// Token: 0x04007748 RID: 30536
		private readonly RepeatedField<QuestReviewEntryInfo> entryInfos_ = new RepeatedField<QuestReviewEntryInfo>();
	}
}
