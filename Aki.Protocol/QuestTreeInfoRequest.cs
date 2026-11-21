using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E24 RID: 3620
	[NetMessage(EMessageId.QuestTreeInfoRequest)]
	public sealed class QuestTreeInfoRequest : IMessage<QuestTreeInfoRequest>, IMessage, IEquatable<QuestTreeInfoRequest>, IDeepCloneable<QuestTreeInfoRequest>, IBufferMessage
	{
		// Token: 0x0601376C RID: 79724 RVA: 0x002D4A8D File Offset: 0x002D2C8D
		[NullableContext(1)]
		public static QuestTreeInfoRequest Create()
		{
			return new QuestTreeInfoRequest();
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x0601376D RID: 79725 RVA: 0x002D4A94 File Offset: 0x002D2C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x0601376E RID: 79726 RVA: 0x002D4A97 File Offset: 0x002D2C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTreeInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601376F RID: 79727 RVA: 0x002D4A9E File Offset: 0x002D2C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoRequest()
		{
		}

		// Token: 0x06013770 RID: 79728 RVA: 0x002D4AA6 File Offset: 0x002D2CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoRequest(QuestTreeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013771 RID: 79729 RVA: 0x002D4ABF File Offset: 0x002D2CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoRequest Clone()
		{
			return new QuestTreeInfoRequest(this);
		}

		// Token: 0x06013772 RID: 79730 RVA: 0x002D4AC7 File Offset: 0x002D2CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTreeInfoRequest);
		}

		// Token: 0x06013773 RID: 79731 RVA: 0x002D4AD5 File Offset: 0x002D2CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTreeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06013774 RID: 79732 RVA: 0x002D4AF4 File Offset: 0x002D2CF4
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

		// Token: 0x06013775 RID: 79733 RVA: 0x002D4B1A File Offset: 0x002D2D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013776 RID: 79734 RVA: 0x002D4B27 File Offset: 0x002D2D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013777 RID: 79735 RVA: 0x002D4B30 File Offset: 0x002D2D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013778 RID: 79736 RVA: 0x002D4B48 File Offset: 0x002D2D48
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

		// Token: 0x06013779 RID: 79737 RVA: 0x002D4B6E File Offset: 0x002D2D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestTreeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601377A RID: 79738 RVA: 0x002D4B8B File Offset: 0x002D2D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601377B RID: 79739 RVA: 0x002D4B94 File Offset: 0x002D2D94
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

		// Token: 0x040077AE RID: 30638
		private UnknownFieldSet _unknownFields;
	}
}
