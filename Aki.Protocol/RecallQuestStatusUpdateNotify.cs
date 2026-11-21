using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB8 RID: 3768
	[NetMessage(EMessageId.RecallQuestStatusUpdateNotify)]
	public sealed class RecallQuestStatusUpdateNotify : IMessage<RecallQuestStatusUpdateNotify>, IMessage, IEquatable<RecallQuestStatusUpdateNotify>, IDeepCloneable<RecallQuestStatusUpdateNotify>, IBufferMessage
	{
		// Token: 0x060143BA RID: 82874 RVA: 0x002F1828 File Offset: 0x002EFA28
		[NullableContext(1)]
		public static RecallQuestStatusUpdateNotify Create()
		{
			return new RecallQuestStatusUpdateNotify();
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x060143BB RID: 82875 RVA: 0x002F182F File Offset: 0x002EFA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x060143BC RID: 82876 RVA: 0x002F1832 File Offset: 0x002EFA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestStatusUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060143BD RID: 82877 RVA: 0x002F1839 File Offset: 0x002EFA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatusUpdateNotify()
		{
		}

		// Token: 0x060143BE RID: 82878 RVA: 0x002F1841 File Offset: 0x002EFA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatusUpdateNotify(RecallQuestStatusUpdateNotify other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143BF RID: 82879 RVA: 0x002F1872 File Offset: 0x002EFA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatusUpdateNotify Clone()
		{
			return new RecallQuestStatusUpdateNotify(this);
		}

		// Token: 0x1700434A RID: 17226
		// (get) Token: 0x060143C0 RID: 82880 RVA: 0x002F187A File Offset: 0x002EFA7A
		// (set) Token: 0x060143C1 RID: 82881 RVA: 0x002F1882 File Offset: 0x002EFA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x1700434B RID: 17227
		// (get) Token: 0x060143C2 RID: 82882 RVA: 0x002F188B File Offset: 0x002EFA8B
		// (set) Token: 0x060143C3 RID: 82883 RVA: 0x002F1893 File Offset: 0x002EFA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x060143C4 RID: 82884 RVA: 0x002F189C File Offset: 0x002EFA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestStatusUpdateNotify);
		}

		// Token: 0x060143C5 RID: 82885 RVA: 0x002F18AA File Offset: 0x002EFAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestStatusUpdateNotify other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143C6 RID: 82886 RVA: 0x002F18E8 File Offset: 0x002EFAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060143C7 RID: 82887 RVA: 0x002F1946 File Offset: 0x002EFB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143C8 RID: 82888 RVA: 0x002F1953 File Offset: 0x002EFB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143C9 RID: 82889 RVA: 0x002F195C File Offset: 0x002EFB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != RecallQuestStatus.InActive)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Status);
			}
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060143CA RID: 82890 RVA: 0x002F19B8 File Offset: 0x002EFBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060143CB RID: 82891 RVA: 0x002F1A10 File Offset: 0x002EFC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestStatusUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			if (other.Status != RecallQuestStatus.InActive)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060143CC RID: 82892 RVA: 0x002F1A60 File Offset: 0x002EFC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143CD RID: 82893 RVA: 0x002F1A6C File Offset: 0x002EFC6C
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
				if (num != 72U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RecallQuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Status = (RecallQuestStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B71 RID: 31601
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B72 RID: 31602
		public const int RecallQuestIdFieldNumber = 13;

		// Token: 0x04007B73 RID: 31603
		private int recallQuestId_;

		// Token: 0x04007B74 RID: 31604
		public const int StatusFieldNumber = 9;

		// Token: 0x04007B75 RID: 31605
		private RecallQuestStatus status_;
	}
}
