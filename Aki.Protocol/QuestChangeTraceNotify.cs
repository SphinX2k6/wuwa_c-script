using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFC RID: 3580
	[NetMessage(EMessageId.QuestChangeTraceNotify)]
	public sealed class QuestChangeTraceNotify : IMessage<QuestChangeTraceNotify>, IMessage, IEquatable<QuestChangeTraceNotify>, IDeepCloneable<QuestChangeTraceNotify>, IBufferMessage
	{
		// Token: 0x06013458 RID: 78936 RVA: 0x002CEAEB File Offset: 0x002CCCEB
		[NullableContext(1)]
		public static QuestChangeTraceNotify Create()
		{
			return new QuestChangeTraceNotify();
		}

		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x06013459 RID: 78937 RVA: 0x002CEAF2 File Offset: 0x002CCCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x0601345A RID: 78938 RVA: 0x002CEAF5 File Offset: 0x002CCCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestChangeTraceNotify.Descriptor;
			}
		}

		// Token: 0x0601345B RID: 78939 RVA: 0x002CEAFC File Offset: 0x002CCCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestChangeTraceNotify()
		{
		}

		// Token: 0x0601345C RID: 78940 RVA: 0x002CEB0F File Offset: 0x002CCD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestChangeTraceNotify(QuestChangeTraceNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601345D RID: 78941 RVA: 0x002CEB39 File Offset: 0x002CCD39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestChangeTraceNotify Clone()
		{
			return new QuestChangeTraceNotify(this);
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x0601345E RID: 78942 RVA: 0x002CEB41 File Offset: 0x002CCD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x0601345F RID: 78943 RVA: 0x002CEB49 File Offset: 0x002CCD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestChangeTraceNotify);
		}

		// Token: 0x06013460 RID: 78944 RVA: 0x002CEB57 File Offset: 0x002CCD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestChangeTraceNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013461 RID: 78945 RVA: 0x002CEB8C File Offset: 0x002CCD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013462 RID: 78946 RVA: 0x002CEBC0 File Offset: 0x002CCDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013463 RID: 78947 RVA: 0x002CEBCD File Offset: 0x002CCDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013464 RID: 78948 RVA: 0x002CEBD6 File Offset: 0x002CCDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, QuestChangeTraceNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013465 RID: 78949 RVA: 0x002CEC00 File Offset: 0x002CCE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(QuestChangeTraceNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013466 RID: 78950 RVA: 0x002CEC39 File Offset: 0x002CCE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestChangeTraceNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013467 RID: 78951 RVA: 0x002CEC67 File Offset: 0x002CCE67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013468 RID: 78952 RVA: 0x002CEC70 File Offset: 0x002CCE70
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
					this.questIds_.AddEntriesFrom(ref input, QuestChangeTraceNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040076E6 RID: 30438
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076E7 RID: 30439
		public const int QuestIdsFieldNumber = 4;

		// Token: 0x040076E8 RID: 30440
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040076E9 RID: 30441
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
