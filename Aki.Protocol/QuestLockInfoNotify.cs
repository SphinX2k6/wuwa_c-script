using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1C RID: 3612
	[NetMessage(EMessageId.QuestLockInfoNotify)]
	public sealed class QuestLockInfoNotify : IMessage<QuestLockInfoNotify>, IMessage, IEquatable<QuestLockInfoNotify>, IDeepCloneable<QuestLockInfoNotify>, IBufferMessage
	{
		// Token: 0x06013679 RID: 79481 RVA: 0x002D27DA File Offset: 0x002D09DA
		[NullableContext(1)]
		public static QuestLockInfoNotify Create()
		{
			return new QuestLockInfoNotify();
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x0601367A RID: 79482 RVA: 0x002D27E1 File Offset: 0x002D09E1
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
		// (get) Token: 0x0601367B RID: 79483 RVA: 0x002D27E4 File Offset: 0x002D09E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestLockInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601367C RID: 79484 RVA: 0x002D27EB File Offset: 0x002D09EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfoNotify()
		{
		}

		// Token: 0x0601367D RID: 79485 RVA: 0x002D27FE File Offset: 0x002D09FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfoNotify(QuestLockInfoNotify other) : this()
		{
			this.questLockInfos_ = other.questLockInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601367E RID: 79486 RVA: 0x002D2828 File Offset: 0x002D0A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfoNotify Clone()
		{
			return new QuestLockInfoNotify(this);
		}

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x0601367F RID: 79487 RVA: 0x002D2830 File Offset: 0x002D0A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestLockInfo> QuestLockInfos
		{
			get
			{
				return this.questLockInfos_;
			}
		}

		// Token: 0x06013680 RID: 79488 RVA: 0x002D2838 File Offset: 0x002D0A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestLockInfoNotify);
		}

		// Token: 0x06013681 RID: 79489 RVA: 0x002D2846 File Offset: 0x002D0A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestLockInfoNotify other)
		{
			return other != null && (other == this || (this.questLockInfos_.Equals(other.questLockInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013682 RID: 79490 RVA: 0x002D287C File Offset: 0x002D0A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questLockInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013683 RID: 79491 RVA: 0x002D28B0 File Offset: 0x002D0AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013684 RID: 79492 RVA: 0x002D28BD File Offset: 0x002D0ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013685 RID: 79493 RVA: 0x002D28C6 File Offset: 0x002D0AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questLockInfos_.WriteTo(ref output, QuestLockInfoNotify._repeated_questLockInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013686 RID: 79494 RVA: 0x002D28F0 File Offset: 0x002D0AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questLockInfos_.CalculateSize(QuestLockInfoNotify._repeated_questLockInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013687 RID: 79495 RVA: 0x002D2929 File Offset: 0x002D0B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestLockInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questLockInfos_.Add(other.questLockInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013688 RID: 79496 RVA: 0x002D2957 File Offset: 0x002D0B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013689 RID: 79497 RVA: 0x002D2960 File Offset: 0x002D0B60
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questLockInfos_.AddEntriesFrom(ref input, QuestLockInfoNotify._repeated_questLockInfos_codec);
				}
			}
		}

		// Token: 0x0400770A RID: 30474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400770B RID: 30475
		public const int QuestLockInfosFieldNumber = 7;

		// Token: 0x0400770C RID: 30476
		private static readonly FieldCodec<QuestLockInfo> _repeated_questLockInfos_codec = FieldCodec.ForMessage<QuestLockInfo>(58U, QuestLockInfo.Parser);

		// Token: 0x0400770D RID: 30477
		private readonly RepeatedField<QuestLockInfo> questLockInfos_ = new RepeatedField<QuestLockInfo>();
	}
}
