using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E19 RID: 3609
	[NetMessage(EMessageId.QuestReviewInfoRequest)]
	public sealed class QuestReviewInfoRequest : IMessage<QuestReviewInfoRequest>, IMessage, IEquatable<QuestReviewInfoRequest>, IDeepCloneable<QuestReviewInfoRequest>, IBufferMessage
	{
		// Token: 0x0601368D RID: 79501 RVA: 0x002D2F31 File Offset: 0x002D1131
		[NullableContext(1)]
		public static QuestReviewInfoRequest Create()
		{
			return new QuestReviewInfoRequest();
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x0601368E RID: 79502 RVA: 0x002D2F38 File Offset: 0x002D1138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x0601368F RID: 79503 RVA: 0x002D2F3B File Offset: 0x002D113B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013690 RID: 79504 RVA: 0x002D2F42 File Offset: 0x002D1142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoRequest()
		{
		}

		// Token: 0x06013691 RID: 79505 RVA: 0x002D2F4A File Offset: 0x002D114A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoRequest(QuestReviewInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013692 RID: 79506 RVA: 0x002D2F63 File Offset: 0x002D1163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoRequest Clone()
		{
			return new QuestReviewInfoRequest(this);
		}

		// Token: 0x06013693 RID: 79507 RVA: 0x002D2F6B File Offset: 0x002D116B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewInfoRequest);
		}

		// Token: 0x06013694 RID: 79508 RVA: 0x002D2F79 File Offset: 0x002D1179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06013695 RID: 79509 RVA: 0x002D2F98 File Offset: 0x002D1198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013696 RID: 79510 RVA: 0x002D2FBE File Offset: 0x002D11BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013697 RID: 79511 RVA: 0x002D2FCB File Offset: 0x002D11CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013698 RID: 79512 RVA: 0x002D2FD4 File Offset: 0x002D11D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013699 RID: 79513 RVA: 0x002D2FEC File Offset: 0x002D11EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601369A RID: 79514 RVA: 0x002D3012 File Offset: 0x002D1212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601369B RID: 79515 RVA: 0x002D302F File Offset: 0x002D122F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601369C RID: 79516 RVA: 0x002D3038 File Offset: 0x002D1238
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007773 RID: 30579
		private UnknownFieldSet _unknownFields;
	}
}
