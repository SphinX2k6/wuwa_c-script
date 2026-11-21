using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E11 RID: 3601
	[NetMessage(EMessageId.QuestReadyListNotify)]
	public sealed class QuestReadyListNotify : IMessage<QuestReadyListNotify>, IMessage, IEquatable<QuestReadyListNotify>, IDeepCloneable<QuestReadyListNotify>, IBufferMessage
	{
		// Token: 0x060135EE RID: 79342 RVA: 0x002D1A69 File Offset: 0x002CFC69
		[NullableContext(1)]
		public static QuestReadyListNotify Create()
		{
			return new QuestReadyListNotify();
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x060135EF RID: 79343 RVA: 0x002D1A70 File Offset: 0x002CFC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x060135F0 RID: 79344 RVA: 0x002D1A73 File Offset: 0x002CFC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReadyListNotify.Descriptor;
			}
		}

		// Token: 0x060135F1 RID: 79345 RVA: 0x002D1A7A File Offset: 0x002CFC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyListNotify()
		{
		}

		// Token: 0x060135F2 RID: 79346 RVA: 0x002D1A8D File Offset: 0x002CFC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyListNotify(QuestReadyListNotify other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135F3 RID: 79347 RVA: 0x002D1AB7 File Offset: 0x002CFCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyListNotify Clone()
		{
			return new QuestReadyListNotify(this);
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x060135F4 RID: 79348 RVA: 0x002D1ABF File Offset: 0x002CFCBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x060135F5 RID: 79349 RVA: 0x002D1AC7 File Offset: 0x002CFCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReadyListNotify);
		}

		// Token: 0x060135F6 RID: 79350 RVA: 0x002D1AD5 File Offset: 0x002CFCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReadyListNotify other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135F7 RID: 79351 RVA: 0x002D1B08 File Offset: 0x002CFD08
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

		// Token: 0x060135F8 RID: 79352 RVA: 0x002D1B3C File Offset: 0x002CFD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135F9 RID: 79353 RVA: 0x002D1B49 File Offset: 0x002CFD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135FA RID: 79354 RVA: 0x002D1B52 File Offset: 0x002CFD52
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

		// Token: 0x060135FB RID: 79355 RVA: 0x002D1B7C File Offset: 0x002CFD7C
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

		// Token: 0x060135FC RID: 79356 RVA: 0x002D1BB5 File Offset: 0x002CFDB5
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

		// Token: 0x060135FD RID: 79357 RVA: 0x002D1BE3 File Offset: 0x002CFDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135FE RID: 79358 RVA: 0x002D1BEC File Offset: 0x002CFDEC
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestReadyListNotify._repeated_questId_codec);
				}
			}
		}

		// Token: 0x04007744 RID: 30532
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007745 RID: 30533
		public const int QuestIdFieldNumber = 15;

		// Token: 0x04007746 RID: 30534
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04007747 RID: 30535
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
