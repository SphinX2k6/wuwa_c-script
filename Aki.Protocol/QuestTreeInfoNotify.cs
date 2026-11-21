using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E23 RID: 3619
	[NetMessage(EMessageId.QuestTreeInfoNotify)]
	public sealed class QuestTreeInfoNotify : IMessage<QuestTreeInfoNotify>, IMessage, IEquatable<QuestTreeInfoNotify>, IDeepCloneable<QuestTreeInfoNotify>, IBufferMessage
	{
		// Token: 0x06013759 RID: 79705 RVA: 0x002D47F7 File Offset: 0x002D29F7
		[NullableContext(1)]
		public static QuestTreeInfoNotify Create()
		{
			return new QuestTreeInfoNotify();
		}

		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x0601375A RID: 79706 RVA: 0x002D47FE File Offset: 0x002D29FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x0601375B RID: 79707 RVA: 0x002D4801 File Offset: 0x002D2A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTreeInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601375C RID: 79708 RVA: 0x002D4808 File Offset: 0x002D2A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoNotify()
		{
		}

		// Token: 0x0601375D RID: 79709 RVA: 0x002D4826 File Offset: 0x002D2A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoNotify(QuestTreeInfoNotify other) : this()
		{
			this.unlockChapterIds_ = other.unlockChapterIds_.Clone();
			this.unlockChapterNodeIds_ = other.unlockChapterNodeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601375E RID: 79710 RVA: 0x002D4861 File Offset: 0x002D2A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoNotify Clone()
		{
			return new QuestTreeInfoNotify(this);
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x0601375F RID: 79711 RVA: 0x002D4869 File Offset: 0x002D2A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockChapterIds
		{
			get
			{
				return this.unlockChapterIds_;
			}
		}

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x06013760 RID: 79712 RVA: 0x002D4871 File Offset: 0x002D2A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockChapterNodeIds
		{
			get
			{
				return this.unlockChapterNodeIds_;
			}
		}

		// Token: 0x06013761 RID: 79713 RVA: 0x002D4879 File Offset: 0x002D2A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTreeInfoNotify);
		}

		// Token: 0x06013762 RID: 79714 RVA: 0x002D4888 File Offset: 0x002D2A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTreeInfoNotify other)
		{
			return other != null && (other == this || (this.unlockChapterIds_.Equals(other.unlockChapterIds_) && this.unlockChapterNodeIds_.Equals(other.unlockChapterNodeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013763 RID: 79715 RVA: 0x002D48DC File Offset: 0x002D2ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockChapterIds_.GetHashCode();
			num ^= this.unlockChapterNodeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013764 RID: 79716 RVA: 0x002D491E File Offset: 0x002D2B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013765 RID: 79717 RVA: 0x002D492B File Offset: 0x002D2B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013766 RID: 79718 RVA: 0x002D4934 File Offset: 0x002D2B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockChapterNodeIds_.WriteTo(ref output, QuestTreeInfoNotify._repeated_unlockChapterNodeIds_codec);
			this.unlockChapterIds_.WriteTo(ref output, QuestTreeInfoNotify._repeated_unlockChapterIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013767 RID: 79719 RVA: 0x002D496C File Offset: 0x002D2B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockChapterIds_.CalculateSize(QuestTreeInfoNotify._repeated_unlockChapterIds_codec);
			num += this.unlockChapterNodeIds_.CalculateSize(QuestTreeInfoNotify._repeated_unlockChapterNodeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013768 RID: 79720 RVA: 0x002D49B8 File Offset: 0x002D2BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestTreeInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockChapterIds_.Add(other.unlockChapterIds_);
			this.unlockChapterNodeIds_.Add(other.unlockChapterNodeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013769 RID: 79721 RVA: 0x002D49F7 File Offset: 0x002D2BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601376A RID: 79722 RVA: 0x002D4A00 File Offset: 0x002D2C00
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
				if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.unlockChapterNodeIds_.AddEntriesFrom(ref input, QuestTreeInfoNotify._repeated_unlockChapterNodeIds_codec);
						continue;
					}
				}
				else if (num == 96U || num == 98U)
				{
					this.unlockChapterIds_.AddEntriesFrom(ref input, QuestTreeInfoNotify._repeated_unlockChapterIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040077A7 RID: 30631
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077A8 RID: 30632
		public const int UnlockChapterIdsFieldNumber = 12;

		// Token: 0x040077A9 RID: 30633
		private static readonly FieldCodec<int> _repeated_unlockChapterIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040077AA RID: 30634
		private readonly RepeatedField<int> unlockChapterIds_ = new RepeatedField<int>();

		// Token: 0x040077AB RID: 30635
		public const int UnlockChapterNodeIdsFieldNumber = 10;

		// Token: 0x040077AC RID: 30636
		private static readonly FieldCodec<int> _repeated_unlockChapterNodeIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040077AD RID: 30637
		private readonly RepeatedField<int> unlockChapterNodeIds_ = new RepeatedField<int>();
	}
}
