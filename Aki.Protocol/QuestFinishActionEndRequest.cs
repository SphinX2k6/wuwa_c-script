using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E01 RID: 3585
	[NetMessage(EMessageId.QuestFinishActionEndRequest)]
	public sealed class QuestFinishActionEndRequest : IMessage<QuestFinishActionEndRequest>, IMessage, IEquatable<QuestFinishActionEndRequest>, IDeepCloneable<QuestFinishActionEndRequest>, IBufferMessage
	{
		// Token: 0x060134B6 RID: 79030 RVA: 0x002CF5A0 File Offset: 0x002CD7A0
		[NullableContext(1)]
		public static QuestFinishActionEndRequest Create()
		{
			return new QuestFinishActionEndRequest();
		}

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x060134B7 RID: 79031 RVA: 0x002CF5A7 File Offset: 0x002CD7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x060134B8 RID: 79032 RVA: 0x002CF5AA File Offset: 0x002CD7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionEndRequest.Descriptor;
			}
		}

		// Token: 0x060134B9 RID: 79033 RVA: 0x002CF5B1 File Offset: 0x002CD7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndRequest()
		{
		}

		// Token: 0x060134BA RID: 79034 RVA: 0x002CF5C4 File Offset: 0x002CD7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndRequest(QuestFinishActionEndRequest other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134BB RID: 79035 RVA: 0x002CF5EE File Offset: 0x002CD7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndRequest Clone()
		{
			return new QuestFinishActionEndRequest(this);
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x060134BC RID: 79036 RVA: 0x002CF5F6 File Offset: 0x002CD7F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x060134BD RID: 79037 RVA: 0x002CF5FE File Offset: 0x002CD7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionEndRequest);
		}

		// Token: 0x060134BE RID: 79038 RVA: 0x002CF60C File Offset: 0x002CD80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionEndRequest other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134BF RID: 79039 RVA: 0x002CF640 File Offset: 0x002CD840
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

		// Token: 0x060134C0 RID: 79040 RVA: 0x002CF674 File Offset: 0x002CD874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134C1 RID: 79041 RVA: 0x002CF681 File Offset: 0x002CD881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134C2 RID: 79042 RVA: 0x002CF68A File Offset: 0x002CD88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questId_.WriteTo(ref output, QuestFinishActionEndRequest._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134C3 RID: 79043 RVA: 0x002CF6B4 File Offset: 0x002CD8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questId_.CalculateSize(QuestFinishActionEndRequest._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060134C4 RID: 79044 RVA: 0x002CF6ED File Offset: 0x002CD8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFinishActionEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.questId_.Add(other.questId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060134C5 RID: 79045 RVA: 0x002CF71B File Offset: 0x002CD91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134C6 RID: 79046 RVA: 0x002CF724 File Offset: 0x002CD924
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestFinishActionEndRequest._repeated_questId_codec);
				}
			}
		}

		// Token: 0x040076FA RID: 30458
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076FB RID: 30459
		public const int QuestIdFieldNumber = 7;

		// Token: 0x040076FC RID: 30460
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040076FD RID: 30461
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
