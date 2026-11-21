using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E05 RID: 3589
	[NetMessage(EMessageId.QuestFinishListNotify)]
	public sealed class QuestFinishListNotify : IMessage<QuestFinishListNotify>, IMessage, IEquatable<QuestFinishListNotify>, IDeepCloneable<QuestFinishListNotify>, IBufferMessage
	{
		// Token: 0x06013504 RID: 79108 RVA: 0x002CFF45 File Offset: 0x002CE145
		[NullableContext(1)]
		public static QuestFinishListNotify Create()
		{
			return new QuestFinishListNotify();
		}

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x06013505 RID: 79109 RVA: 0x002CFF4C File Offset: 0x002CE14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x06013506 RID: 79110 RVA: 0x002CFF4F File Offset: 0x002CE14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishListNotify.Descriptor;
			}
		}

		// Token: 0x06013507 RID: 79111 RVA: 0x002CFF56 File Offset: 0x002CE156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishListNotify()
		{
		}

		// Token: 0x06013508 RID: 79112 RVA: 0x002CFF69 File Offset: 0x002CE169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishListNotify(QuestFinishListNotify other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013509 RID: 79113 RVA: 0x002CFF93 File Offset: 0x002CE193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishListNotify Clone()
		{
			return new QuestFinishListNotify(this);
		}

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x0601350A RID: 79114 RVA: 0x002CFF9B File Offset: 0x002CE19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x0601350B RID: 79115 RVA: 0x002CFFA3 File Offset: 0x002CE1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishListNotify);
		}

		// Token: 0x0601350C RID: 79116 RVA: 0x002CFFB1 File Offset: 0x002CE1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishListNotify other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601350D RID: 79117 RVA: 0x002CFFE4 File Offset: 0x002CE1E4
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

		// Token: 0x0601350E RID: 79118 RVA: 0x002D0018 File Offset: 0x002CE218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601350F RID: 79119 RVA: 0x002D0025 File Offset: 0x002CE225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013510 RID: 79120 RVA: 0x002D002E File Offset: 0x002CE22E
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

		// Token: 0x06013511 RID: 79121 RVA: 0x002D0058 File Offset: 0x002CE258
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

		// Token: 0x06013512 RID: 79122 RVA: 0x002D0091 File Offset: 0x002CE291
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

		// Token: 0x06013513 RID: 79123 RVA: 0x002D00BF File Offset: 0x002CE2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013514 RID: 79124 RVA: 0x002D00C8 File Offset: 0x002CE2C8
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestFinishListNotify._repeated_questId_codec);
				}
			}
		}

		// Token: 0x0400770D RID: 30477
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400770E RID: 30478
		public const int QuestIdFieldNumber = 2;

		// Token: 0x0400770F RID: 30479
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007710 RID: 30480
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
