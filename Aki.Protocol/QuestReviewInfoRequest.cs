using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E29 RID: 3625
	[NetMessage(EMessageId.QuestReviewInfoRequest)]
	public sealed class QuestReviewInfoRequest : IMessage<QuestReviewInfoRequest>, IMessage, IEquatable<QuestReviewInfoRequest>, IDeepCloneable<QuestReviewInfoRequest>, IBufferMessage
	{
		// Token: 0x06013772 RID: 79730 RVA: 0x002D45F5 File Offset: 0x002D27F5
		[NullableContext(1)]
		public static QuestReviewInfoRequest Create()
		{
			return new QuestReviewInfoRequest();
		}

		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x06013773 RID: 79731 RVA: 0x002D45FC File Offset: 0x002D27FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x06013774 RID: 79732 RVA: 0x002D45FF File Offset: 0x002D27FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013775 RID: 79733 RVA: 0x002D4606 File Offset: 0x002D2806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoRequest()
		{
		}

		// Token: 0x06013776 RID: 79734 RVA: 0x002D460E File Offset: 0x002D280E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoRequest(QuestReviewInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013777 RID: 79735 RVA: 0x002D4627 File Offset: 0x002D2827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoRequest Clone()
		{
			return new QuestReviewInfoRequest(this);
		}

		// Token: 0x06013778 RID: 79736 RVA: 0x002D462F File Offset: 0x002D282F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewInfoRequest);
		}

		// Token: 0x06013779 RID: 79737 RVA: 0x002D463D File Offset: 0x002D283D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601377A RID: 79738 RVA: 0x002D465C File Offset: 0x002D285C
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

		// Token: 0x0601377B RID: 79739 RVA: 0x002D4682 File Offset: 0x002D2882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601377C RID: 79740 RVA: 0x002D468F File Offset: 0x002D288F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601377D RID: 79741 RVA: 0x002D4698 File Offset: 0x002D2898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601377E RID: 79742 RVA: 0x002D46B0 File Offset: 0x002D28B0
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

		// Token: 0x0601377F RID: 79743 RVA: 0x002D46D6 File Offset: 0x002D28D6
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

		// Token: 0x06013780 RID: 79744 RVA: 0x002D46F3 File Offset: 0x002D28F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013781 RID: 79745 RVA: 0x002D46FC File Offset: 0x002D28FC
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

		// Token: 0x04007749 RID: 30537
		private UnknownFieldSet _unknownFields;
	}
}
