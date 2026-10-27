using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E15 RID: 3605
	[NetMessage(EMessageId.QuestFinishListNotify)]
	public sealed class QuestFinishListNotify : IMessage<QuestFinishListNotify>, IMessage, IEquatable<QuestFinishListNotify>, IDeepCloneable<QuestFinishListNotify>, IBufferMessage
	{
		// Token: 0x060135E9 RID: 79337 RVA: 0x002D1605 File Offset: 0x002CF805
		[NullableContext(1)]
		public static QuestFinishListNotify Create()
		{
			return new QuestFinishListNotify();
		}

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x060135EA RID: 79338 RVA: 0x002D160C File Offset: 0x002CF80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x060135EB RID: 79339 RVA: 0x002D160F File Offset: 0x002CF80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishListNotify.Descriptor;
			}
		}

		// Token: 0x060135EC RID: 79340 RVA: 0x002D1616 File Offset: 0x002CF816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishListNotify()
		{
		}

		// Token: 0x060135ED RID: 79341 RVA: 0x002D1629 File Offset: 0x002CF829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishListNotify(QuestFinishListNotify other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135EE RID: 79342 RVA: 0x002D1653 File Offset: 0x002CF853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishListNotify Clone()
		{
			return new QuestFinishListNotify(this);
		}

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x060135EF RID: 79343 RVA: 0x002D165B File Offset: 0x002CF85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x060135F0 RID: 79344 RVA: 0x002D1663 File Offset: 0x002CF863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishListNotify);
		}

		// Token: 0x060135F1 RID: 79345 RVA: 0x002D1671 File Offset: 0x002CF871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishListNotify other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135F2 RID: 79346 RVA: 0x002D16A4 File Offset: 0x002CF8A4
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

		// Token: 0x060135F3 RID: 79347 RVA: 0x002D16D8 File Offset: 0x002CF8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135F4 RID: 79348 RVA: 0x002D16E5 File Offset: 0x002CF8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135F5 RID: 79349 RVA: 0x002D16EE File Offset: 0x002CF8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questId_.WriteTo(ref output, QuestFinishListNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060135F6 RID: 79350 RVA: 0x002D1718 File Offset: 0x002CF918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questId_.CalculateSize(QuestFinishListNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060135F7 RID: 79351 RVA: 0x002D1751 File Offset: 0x002CF951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFinishListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questId_.Add(other.questId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060135F8 RID: 79352 RVA: 0x002D177F File Offset: 0x002CF97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135F9 RID: 79353 RVA: 0x002D1788 File Offset: 0x002CF988
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestFinishListNotify._repeated_questId_codec);
				}
			}
		}

		// Token: 0x040076E3 RID: 30435
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076E4 RID: 30436
		public const int QuestIdFieldNumber = 12;

		// Token: 0x040076E5 RID: 30437
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040076E6 RID: 30438
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
