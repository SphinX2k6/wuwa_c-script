using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E34 RID: 3636
	[NetMessage(EMessageId.QuestTreeInfoRequest)]
	public sealed class QuestTreeInfoRequest : IMessage<QuestTreeInfoRequest>, IMessage, IEquatable<QuestTreeInfoRequest>, IDeepCloneable<QuestTreeInfoRequest>, IBufferMessage
	{
		// Token: 0x06013851 RID: 79953 RVA: 0x002D6154 File Offset: 0x002D4354
		[NullableContext(1)]
		public static QuestTreeInfoRequest Create()
		{
			return new QuestTreeInfoRequest();
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x06013852 RID: 79954 RVA: 0x002D615B File Offset: 0x002D435B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x06013853 RID: 79955 RVA: 0x002D615E File Offset: 0x002D435E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTreeInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013854 RID: 79956 RVA: 0x002D6165 File Offset: 0x002D4365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoRequest()
		{
		}

		// Token: 0x06013855 RID: 79957 RVA: 0x002D616D File Offset: 0x002D436D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoRequest(QuestTreeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013856 RID: 79958 RVA: 0x002D6186 File Offset: 0x002D4386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTreeInfoRequest Clone()
		{
			return new QuestTreeInfoRequest(this);
		}

		// Token: 0x06013857 RID: 79959 RVA: 0x002D618E File Offset: 0x002D438E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTreeInfoRequest);
		}

		// Token: 0x06013858 RID: 79960 RVA: 0x002D619C File Offset: 0x002D439C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTreeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06013859 RID: 79961 RVA: 0x002D61BC File Offset: 0x002D43BC
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

		// Token: 0x0601385A RID: 79962 RVA: 0x002D61E2 File Offset: 0x002D43E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601385B RID: 79963 RVA: 0x002D61EF File Offset: 0x002D43EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601385C RID: 79964 RVA: 0x002D61F8 File Offset: 0x002D43F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601385D RID: 79965 RVA: 0x002D6210 File Offset: 0x002D4410
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

		// Token: 0x0601385E RID: 79966 RVA: 0x002D6236 File Offset: 0x002D4436
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

		// Token: 0x0601385F RID: 79967 RVA: 0x002D6253 File Offset: 0x002D4453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013860 RID: 79968 RVA: 0x002D625C File Offset: 0x002D445C
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

		// Token: 0x04007784 RID: 30596
		private UnknownFieldSet _unknownFields;
	}
}
