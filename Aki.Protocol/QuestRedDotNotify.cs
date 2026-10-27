using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E24 RID: 3620
	[NetMessage(EMessageId.QuestRedDotNotify)]
	public sealed class QuestRedDotNotify : IMessage<QuestRedDotNotify>, IMessage, IEquatable<QuestRedDotNotify>, IDeepCloneable<QuestRedDotNotify>, IBufferMessage
	{
		// Token: 0x0601370D RID: 79629 RVA: 0x002D382B File Offset: 0x002D1A2B
		[NullableContext(1)]
		public static QuestRedDotNotify Create()
		{
			return new QuestRedDotNotify();
		}

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x0601370E RID: 79630 RVA: 0x002D3832 File Offset: 0x002D1A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x0601370F RID: 79631 RVA: 0x002D3835 File Offset: 0x002D1A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRedDotNotify.Descriptor;
			}
		}

		// Token: 0x06013710 RID: 79632 RVA: 0x002D383C File Offset: 0x002D1A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotNotify()
		{
		}

		// Token: 0x06013711 RID: 79633 RVA: 0x002D384F File Offset: 0x002D1A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotNotify(QuestRedDotNotify other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013712 RID: 79634 RVA: 0x002D3879 File Offset: 0x002D1A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotNotify Clone()
		{
			return new QuestRedDotNotify(this);
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x06013713 RID: 79635 RVA: 0x002D3881 File Offset: 0x002D1A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x06013714 RID: 79636 RVA: 0x002D3889 File Offset: 0x002D1A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRedDotNotify);
		}

		// Token: 0x06013715 RID: 79637 RVA: 0x002D3897 File Offset: 0x002D1A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRedDotNotify other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013716 RID: 79638 RVA: 0x002D38CC File Offset: 0x002D1ACC
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

		// Token: 0x06013717 RID: 79639 RVA: 0x002D3900 File Offset: 0x002D1B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013718 RID: 79640 RVA: 0x002D390D File Offset: 0x002D1B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013719 RID: 79641 RVA: 0x002D3916 File Offset: 0x002D1B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questId_.WriteTo(ref output, QuestRedDotNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601371A RID: 79642 RVA: 0x002D3940 File Offset: 0x002D1B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questId_.CalculateSize(QuestRedDotNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601371B RID: 79643 RVA: 0x002D3979 File Offset: 0x002D1B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRedDotNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questId_.Add(other.questId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601371C RID: 79644 RVA: 0x002D39A7 File Offset: 0x002D1BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601371D RID: 79645 RVA: 0x002D39B0 File Offset: 0x002D1BB0
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestRedDotNotify._repeated_questId_codec);
				}
			}
		}

		// Token: 0x04007728 RID: 30504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007729 RID: 30505
		public const int QuestIdFieldNumber = 11;

		// Token: 0x0400772A RID: 30506
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400772B RID: 30507
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
