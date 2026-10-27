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
	[NetMessage(EMessageId.QuestFinishActionEndRequest)]
	public sealed class QuestFinishActionEndRequest : IMessage<QuestFinishActionEndRequest>, IMessage, IEquatable<QuestFinishActionEndRequest>, IDeepCloneable<QuestFinishActionEndRequest>, IBufferMessage
	{
		// Token: 0x0601359B RID: 79259 RVA: 0x002D0C60 File Offset: 0x002CEE60
		[NullableContext(1)]
		public static QuestFinishActionEndRequest Create()
		{
			return new QuestFinishActionEndRequest();
		}

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x0601359C RID: 79260 RVA: 0x002D0C67 File Offset: 0x002CEE67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x0601359D RID: 79261 RVA: 0x002D0C6A File Offset: 0x002CEE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionEndRequest.Descriptor;
			}
		}

		// Token: 0x0601359E RID: 79262 RVA: 0x002D0C71 File Offset: 0x002CEE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndRequest()
		{
		}

		// Token: 0x0601359F RID: 79263 RVA: 0x002D0C84 File Offset: 0x002CEE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndRequest(QuestFinishActionEndRequest other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135A0 RID: 79264 RVA: 0x002D0CAE File Offset: 0x002CEEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndRequest Clone()
		{
			return new QuestFinishActionEndRequest(this);
		}

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x060135A1 RID: 79265 RVA: 0x002D0CB6 File Offset: 0x002CEEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x060135A2 RID: 79266 RVA: 0x002D0CBE File Offset: 0x002CEEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionEndRequest);
		}

		// Token: 0x060135A3 RID: 79267 RVA: 0x002D0CCC File Offset: 0x002CEECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionEndRequest other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135A4 RID: 79268 RVA: 0x002D0D00 File Offset: 0x002CEF00
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

		// Token: 0x060135A5 RID: 79269 RVA: 0x002D0D34 File Offset: 0x002CEF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135A6 RID: 79270 RVA: 0x002D0D41 File Offset: 0x002CEF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135A7 RID: 79271 RVA: 0x002D0D4A File Offset: 0x002CEF4A
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

		// Token: 0x060135A8 RID: 79272 RVA: 0x002D0D74 File Offset: 0x002CEF74
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

		// Token: 0x060135A9 RID: 79273 RVA: 0x002D0DAD File Offset: 0x002CEFAD
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

		// Token: 0x060135AA RID: 79274 RVA: 0x002D0DDB File Offset: 0x002CEFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135AB RID: 79275 RVA: 0x002D0DE4 File Offset: 0x002CEFE4
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestFinishActionEndRequest._repeated_questId_codec);
				}
			}
		}

		// Token: 0x040076D0 RID: 30416
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076D1 RID: 30417
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040076D2 RID: 30418
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040076D3 RID: 30419
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
