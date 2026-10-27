using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E21 RID: 3617
	[NetMessage(EMessageId.QuestReadyListNotify)]
	public sealed class QuestReadyListNotify : IMessage<QuestReadyListNotify>, IMessage, IEquatable<QuestReadyListNotify>, IDeepCloneable<QuestReadyListNotify>, IBufferMessage
	{
		// Token: 0x060136D3 RID: 79571 RVA: 0x002D312D File Offset: 0x002D132D
		[NullableContext(1)]
		public static QuestReadyListNotify Create()
		{
			return new QuestReadyListNotify();
		}

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x060136D4 RID: 79572 RVA: 0x002D3134 File Offset: 0x002D1334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x060136D5 RID: 79573 RVA: 0x002D3137 File Offset: 0x002D1337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReadyListNotify.Descriptor;
			}
		}

		// Token: 0x060136D6 RID: 79574 RVA: 0x002D313E File Offset: 0x002D133E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyListNotify()
		{
		}

		// Token: 0x060136D7 RID: 79575 RVA: 0x002D3151 File Offset: 0x002D1351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyListNotify(QuestReadyListNotify other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136D8 RID: 79576 RVA: 0x002D317B File Offset: 0x002D137B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyListNotify Clone()
		{
			return new QuestReadyListNotify(this);
		}

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x060136D9 RID: 79577 RVA: 0x002D3183 File Offset: 0x002D1383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x060136DA RID: 79578 RVA: 0x002D318B File Offset: 0x002D138B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReadyListNotify);
		}

		// Token: 0x060136DB RID: 79579 RVA: 0x002D3199 File Offset: 0x002D1399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReadyListNotify other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136DC RID: 79580 RVA: 0x002D31CC File Offset: 0x002D13CC
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

		// Token: 0x060136DD RID: 79581 RVA: 0x002D3200 File Offset: 0x002D1400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136DE RID: 79582 RVA: 0x002D320D File Offset: 0x002D140D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136DF RID: 79583 RVA: 0x002D3216 File Offset: 0x002D1416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questId_.WriteTo(ref output, QuestReadyListNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060136E0 RID: 79584 RVA: 0x002D3240 File Offset: 0x002D1440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questId_.CalculateSize(QuestReadyListNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060136E1 RID: 79585 RVA: 0x002D3279 File Offset: 0x002D1479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReadyListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questId_.Add(other.questId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060136E2 RID: 79586 RVA: 0x002D32A7 File Offset: 0x002D14A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136E3 RID: 79587 RVA: 0x002D32B0 File Offset: 0x002D14B0
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestReadyListNotify._repeated_questId_codec);
				}
			}
		}

		// Token: 0x0400771A RID: 30490
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400771B RID: 30491
		public const int QuestIdFieldNumber = 8;

		// Token: 0x0400771C RID: 30492
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400771D RID: 30493
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
