using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E07 RID: 3591
	[NetMessage(EMessageId.QuestGiveUpNotify)]
	public sealed class QuestGiveUpNotify : IMessage<QuestGiveUpNotify>, IMessage, IEquatable<QuestGiveUpNotify>, IDeepCloneable<QuestGiveUpNotify>, IBufferMessage
	{
		// Token: 0x06013528 RID: 79144 RVA: 0x002D02FD File Offset: 0x002CE4FD
		[NullableContext(1)]
		public static QuestGiveUpNotify Create()
		{
			return new QuestGiveUpNotify();
		}

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x06013529 RID: 79145 RVA: 0x002D0304 File Offset: 0x002CE504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x0601352A RID: 79146 RVA: 0x002D0307 File Offset: 0x002CE507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestGiveUpNotify.Descriptor;
			}
		}

		// Token: 0x0601352B RID: 79147 RVA: 0x002D030E File Offset: 0x002CE50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestGiveUpNotify()
		{
		}

		// Token: 0x0601352C RID: 79148 RVA: 0x002D0324 File Offset: 0x002CE524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestGiveUpNotify(QuestGiveUpNotify other) : this()
		{
			this.questId_ = other.questId_;
			this.treeIncId_ = other.treeIncId_;
			this.flowIncIds_ = other.flowIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601352D RID: 79149 RVA: 0x002D0371 File Offset: 0x002CE571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestGiveUpNotify Clone()
		{
			return new QuestGiveUpNotify(this);
		}

		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x0601352E RID: 79150 RVA: 0x002D0379 File Offset: 0x002CE579
		// (set) Token: 0x0601352F RID: 79151 RVA: 0x002D0381 File Offset: 0x002CE581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x06013530 RID: 79152 RVA: 0x002D038A File Offset: 0x002CE58A
		// (set) Token: 0x06013531 RID: 79153 RVA: 0x002D0392 File Offset: 0x002CE592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x06013532 RID: 79154 RVA: 0x002D039B File Offset: 0x002CE59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> FlowIncIds
		{
			get
			{
				return this.flowIncIds_;
			}
		}

		// Token: 0x06013533 RID: 79155 RVA: 0x002D03A3 File Offset: 0x002CE5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestGiveUpNotify);
		}

		// Token: 0x06013534 RID: 79156 RVA: 0x002D03B4 File Offset: 0x002CE5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestGiveUpNotify other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.TreeIncId == other.TreeIncId && this.flowIncIds_.Equals(other.flowIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013535 RID: 79157 RVA: 0x002D0414 File Offset: 0x002CE614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			num ^= this.flowIncIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013536 RID: 79158 RVA: 0x002D047A File Offset: 0x002CE67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013537 RID: 79159 RVA: 0x002D0487 File Offset: 0x002CE687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013538 RID: 79160 RVA: 0x002D0490 File Offset: 0x002CE690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flowIncIds_.WriteTo(ref output, QuestGiveUpNotify._repeated_flowIncIds_codec);
			if (this.QuestId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.QuestId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013539 RID: 79161 RVA: 0x002D04FC File Offset: 0x002CE6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			num += this.flowIncIds_.CalculateSize(QuestGiveUpNotify._repeated_flowIncIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601353A RID: 79162 RVA: 0x002D0568 File Offset: 0x002CE768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestGiveUpNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this.flowIncIds_.Add(other.flowIncIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601353B RID: 79163 RVA: 0x002D05C9 File Offset: 0x002CE7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601353C RID: 79164 RVA: 0x002D05D4 File Offset: 0x002CE7D4
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.flowIncIds_.AddEntriesFrom(ref input, QuestGiveUpNotify._repeated_flowIncIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.QuestId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007714 RID: 30484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007715 RID: 30485
		public const int QuestIdFieldNumber = 12;

		// Token: 0x04007716 RID: 30486
		private int questId_;

		// Token: 0x04007717 RID: 30487
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x04007718 RID: 30488
		private long treeIncId_;

		// Token: 0x04007719 RID: 30489
		public const int FlowIncIdsFieldNumber = 1;

		// Token: 0x0400771A RID: 30490
		private static readonly FieldCodec<long> _repeated_flowIncIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x0400771B RID: 30491
		private readonly RepeatedField<long> flowIncIds_ = new RepeatedField<long>();
	}
}
