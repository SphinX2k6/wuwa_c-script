using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E33 RID: 3635
	[NetMessage(EMessageId.QuestTreeInfoNotify)]
	public sealed class QuestTreeInfoNotify : IMessage<QuestTreeInfoNotify>, IMessage, IEquatable<QuestTreeInfoNotify>, IDeepCloneable<QuestTreeInfoNotify>, IBufferMessage
	{
		// Token: 0x0601383E RID: 79934 RVA: 0x002D5EBF File Offset: 0x002D40BF
		[NullableContext(1)]
		public static QuestTreeInfoNotify Create()
		{
			return new QuestTreeInfoNotify();
		}

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x0601383F RID: 79935 RVA: 0x002D5EC6 File Offset: 0x002D40C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x06013840 RID: 79936 RVA: 0x002D5EC9 File Offset: 0x002D40C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTreeInfoNotify.Descriptor;
			}
		}

		// Token: 0x06013841 RID: 79937 RVA: 0x002D5ED0 File Offset: 0x002D40D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoNotify()
		{
		}

		// Token: 0x06013842 RID: 79938 RVA: 0x002D5EEE File Offset: 0x002D40EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoNotify(QuestTreeInfoNotify other) : this()
		{
			this.unlockChapterIds_ = other.unlockChapterIds_.Clone();
			this.unlockChapterNodeIds_ = other.unlockChapterNodeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013843 RID: 79939 RVA: 0x002D5F29 File Offset: 0x002D4129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoNotify Clone()
		{
			return new QuestTreeInfoNotify(this);
		}

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x06013844 RID: 79940 RVA: 0x002D5F31 File Offset: 0x002D4131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockChapterIds
		{
			get
			{
				return this.unlockChapterIds_;
			}
		}

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x06013845 RID: 79941 RVA: 0x002D5F39 File Offset: 0x002D4139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockChapterNodeIds
		{
			get
			{
				return this.unlockChapterNodeIds_;
			}
		}

		// Token: 0x06013846 RID: 79942 RVA: 0x002D5F41 File Offset: 0x002D4141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTreeInfoNotify);
		}

		// Token: 0x06013847 RID: 79943 RVA: 0x002D5F50 File Offset: 0x002D4150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTreeInfoNotify other)
		{
			return other != null && (other == this || (this.unlockChapterIds_.Equals(other.unlockChapterIds_) && this.unlockChapterNodeIds_.Equals(other.unlockChapterNodeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013848 RID: 79944 RVA: 0x002D5FA4 File Offset: 0x002D41A4
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

		// Token: 0x06013849 RID: 79945 RVA: 0x002D5FE6 File Offset: 0x002D41E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601384A RID: 79946 RVA: 0x002D5FF3 File Offset: 0x002D41F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601384B RID: 79947 RVA: 0x002D5FFC File Offset: 0x002D41FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockChapterIds_.WriteTo(ref output, QuestTreeInfoNotify._repeated_unlockChapterIds_codec);
			this.unlockChapterNodeIds_.WriteTo(ref output, QuestTreeInfoNotify._repeated_unlockChapterNodeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601384C RID: 79948 RVA: 0x002D6034 File Offset: 0x002D4234
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

		// Token: 0x0601384D RID: 79949 RVA: 0x002D6080 File Offset: 0x002D4280
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

		// Token: 0x0601384E RID: 79950 RVA: 0x002D60BF File Offset: 0x002D42BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601384F RID: 79951 RVA: 0x002D60C8 File Offset: 0x002D42C8
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
						this.unlockChapterIds_.AddEntriesFrom(ref input, QuestTreeInfoNotify._repeated_unlockChapterIds_codec);
						continue;
					}
				}
				else if (num == 48U || num == 50U)
				{
					this.unlockChapterNodeIds_.AddEntriesFrom(ref input, QuestTreeInfoNotify._repeated_unlockChapterNodeIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400777D RID: 30589
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400777E RID: 30590
		public const int UnlockChapterIdsFieldNumber = 1;

		// Token: 0x0400777F RID: 30591
		private static readonly FieldCodec<int> _repeated_unlockChapterIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007780 RID: 30592
		private readonly RepeatedField<int> unlockChapterIds_ = new RepeatedField<int>();

		// Token: 0x04007781 RID: 30593
		public const int UnlockChapterNodeIdsFieldNumber = 6;

		// Token: 0x04007782 RID: 30594
		private static readonly FieldCodec<int> _repeated_unlockChapterNodeIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007783 RID: 30595
		private readonly RepeatedField<int> unlockChapterNodeIds_ = new RepeatedField<int>();
	}
}
