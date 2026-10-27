using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E07 RID: 3591
	[NetMessage(EMessageId.QuestBranchRequest)]
	public sealed class QuestBranchRequest : IMessage<QuestBranchRequest>, IMessage, IEquatable<QuestBranchRequest>, IDeepCloneable<QuestBranchRequest>, IBufferMessage
	{
		// Token: 0x060134DD RID: 79069 RVA: 0x002CF4FA File Offset: 0x002CD6FA
		[NullableContext(1)]
		public static QuestBranchRequest Create()
		{
			return new QuestBranchRequest();
		}

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x060134DE RID: 79070 RVA: 0x002CF501 File Offset: 0x002CD701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x060134DF RID: 79071 RVA: 0x002CF504 File Offset: 0x002CD704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchRequest.Descriptor;
			}
		}

		// Token: 0x060134E0 RID: 79072 RVA: 0x002CF50B File Offset: 0x002CD70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchRequest()
		{
		}

		// Token: 0x060134E1 RID: 79073 RVA: 0x002CF513 File Offset: 0x002CD713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchRequest(QuestBranchRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134E2 RID: 79074 RVA: 0x002CF52C File Offset: 0x002CD72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchRequest Clone()
		{
			return new QuestBranchRequest(this);
		}

		// Token: 0x060134E3 RID: 79075 RVA: 0x002CF534 File Offset: 0x002CD734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchRequest);
		}

		// Token: 0x060134E4 RID: 79076 RVA: 0x002CF542 File Offset: 0x002CD742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060134E5 RID: 79077 RVA: 0x002CF560 File Offset: 0x002CD760
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

		// Token: 0x060134E6 RID: 79078 RVA: 0x002CF586 File Offset: 0x002CD786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134E7 RID: 79079 RVA: 0x002CF593 File Offset: 0x002CD793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134E8 RID: 79080 RVA: 0x002CF59C File Offset: 0x002CD79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134E9 RID: 79081 RVA: 0x002CF5B4 File Offset: 0x002CD7B4
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

		// Token: 0x060134EA RID: 79082 RVA: 0x002CF5DA File Offset: 0x002CD7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060134EB RID: 79083 RVA: 0x002CF5F7 File Offset: 0x002CD7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134EC RID: 79084 RVA: 0x002CF600 File Offset: 0x002CD800
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

		// Token: 0x040076A7 RID: 30375
		private UnknownFieldSet _unknownFields;
	}
}
