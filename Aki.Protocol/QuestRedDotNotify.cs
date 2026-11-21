using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E14 RID: 3604
	[NetMessage(EMessageId.QuestRedDotNotify)]
	public sealed class QuestRedDotNotify : IMessage<QuestRedDotNotify>, IMessage, IEquatable<QuestRedDotNotify>, IDeepCloneable<QuestRedDotNotify>, IBufferMessage
	{
		// Token: 0x06013628 RID: 79400 RVA: 0x002D2167 File Offset: 0x002D0367
		[NullableContext(1)]
		public static QuestRedDotNotify Create()
		{
			return new QuestRedDotNotify();
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x06013629 RID: 79401 RVA: 0x002D216E File Offset: 0x002D036E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x0601362A RID: 79402 RVA: 0x002D2171 File Offset: 0x002D0371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRedDotNotify.Descriptor;
			}
		}

		// Token: 0x0601362B RID: 79403 RVA: 0x002D2178 File Offset: 0x002D0378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotNotify()
		{
		}

		// Token: 0x0601362C RID: 79404 RVA: 0x002D218B File Offset: 0x002D038B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotNotify(QuestRedDotNotify other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601362D RID: 79405 RVA: 0x002D21B5 File Offset: 0x002D03B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotNotify Clone()
		{
			return new QuestRedDotNotify(this);
		}

		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x0601362E RID: 79406 RVA: 0x002D21BD File Offset: 0x002D03BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x0601362F RID: 79407 RVA: 0x002D21C5 File Offset: 0x002D03C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRedDotNotify);
		}

		// Token: 0x06013630 RID: 79408 RVA: 0x002D21D3 File Offset: 0x002D03D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRedDotNotify other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013631 RID: 79409 RVA: 0x002D2208 File Offset: 0x002D0408
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

		// Token: 0x06013632 RID: 79410 RVA: 0x002D223C File Offset: 0x002D043C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013633 RID: 79411 RVA: 0x002D2249 File Offset: 0x002D0449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013634 RID: 79412 RVA: 0x002D2252 File Offset: 0x002D0452
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

		// Token: 0x06013635 RID: 79413 RVA: 0x002D227C File Offset: 0x002D047C
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

		// Token: 0x06013636 RID: 79414 RVA: 0x002D22B5 File Offset: 0x002D04B5
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

		// Token: 0x06013637 RID: 79415 RVA: 0x002D22E3 File Offset: 0x002D04E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013638 RID: 79416 RVA: 0x002D22EC File Offset: 0x002D04EC
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
					this.questId_.AddEntriesFrom(ref input, QuestRedDotNotify._repeated_questId_codec);
				}
			}
		}

		// Token: 0x04007752 RID: 30546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007753 RID: 30547
		public const int QuestIdFieldNumber = 12;

		// Token: 0x04007754 RID: 30548
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04007755 RID: 30549
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
