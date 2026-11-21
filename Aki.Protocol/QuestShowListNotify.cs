using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1F RID: 3615
	[NetMessage(EMessageId.QuestShowListNotify)]
	public sealed class QuestShowListNotify : IMessage<QuestShowListNotify>, IMessage, IEquatable<QuestShowListNotify>, IDeepCloneable<QuestShowListNotify>, IBufferMessage
	{
		// Token: 0x0601370B RID: 79627 RVA: 0x002D3ECF File Offset: 0x002D20CF
		[NullableContext(1)]
		public static QuestShowListNotify Create()
		{
			return new QuestShowListNotify();
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x0601370C RID: 79628 RVA: 0x002D3ED6 File Offset: 0x002D20D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x0601370D RID: 79629 RVA: 0x002D3ED9 File Offset: 0x002D20D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestShowListNotify.Descriptor;
			}
		}

		// Token: 0x0601370E RID: 79630 RVA: 0x002D3EE0 File Offset: 0x002D20E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestShowListNotify()
		{
		}

		// Token: 0x0601370F RID: 79631 RVA: 0x002D3EF3 File Offset: 0x002D20F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestShowListNotify(QuestShowListNotify other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013710 RID: 79632 RVA: 0x002D3F1D File Offset: 0x002D211D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestShowListNotify Clone()
		{
			return new QuestShowListNotify(this);
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x06013711 RID: 79633 RVA: 0x002D3F25 File Offset: 0x002D2125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x06013712 RID: 79634 RVA: 0x002D3F2D File Offset: 0x002D212D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestShowListNotify);
		}

		// Token: 0x06013713 RID: 79635 RVA: 0x002D3F3B File Offset: 0x002D213B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestShowListNotify other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013714 RID: 79636 RVA: 0x002D3F70 File Offset: 0x002D2170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013715 RID: 79637 RVA: 0x002D3FA4 File Offset: 0x002D21A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013716 RID: 79638 RVA: 0x002D3FB1 File Offset: 0x002D21B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013717 RID: 79639 RVA: 0x002D3FBA File Offset: 0x002D21BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questId_.WriteTo(ref output, QuestShowListNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013718 RID: 79640 RVA: 0x002D3FE4 File Offset: 0x002D21E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questId_.CalculateSize(QuestShowListNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013719 RID: 79641 RVA: 0x002D401D File Offset: 0x002D221D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestShowListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questId_.Add(other.questId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601371A RID: 79642 RVA: 0x002D404B File Offset: 0x002D224B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601371B RID: 79643 RVA: 0x002D4054 File Offset: 0x002D2254
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestShowListNotify._repeated_questId_codec);
				}
			}
		}

		// Token: 0x04007794 RID: 30612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007795 RID: 30613
		public const int QuestIdFieldNumber = 4;

		// Token: 0x04007796 RID: 30614
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007797 RID: 30615
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
