using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA9 RID: 3753
	public sealed class RecallQuestDestroyActionCtxPb : IMessage<RecallQuestDestroyActionCtxPb>, IMessage, IEquatable<RecallQuestDestroyActionCtxPb>, IDeepCloneable<RecallQuestDestroyActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601429C RID: 82588 RVA: 0x002EF6ED File Offset: 0x002ED8ED
		[NullableContext(1)]
		public static RecallQuestDestroyActionCtxPb Create()
		{
			return new RecallQuestDestroyActionCtxPb();
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x0601429D RID: 82589 RVA: 0x002EF6F4 File Offset: 0x002ED8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x0601429E RID: 82590 RVA: 0x002EF6F7 File Offset: 0x002ED8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestDestroyActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601429F RID: 82591 RVA: 0x002EF6FE File Offset: 0x002ED8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestDestroyActionCtxPb()
		{
		}

		// Token: 0x060142A0 RID: 82592 RVA: 0x002EF706 File Offset: 0x002ED906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestDestroyActionCtxPb(RecallQuestDestroyActionCtxPb other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142A1 RID: 82593 RVA: 0x002EF72B File Offset: 0x002ED92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestDestroyActionCtxPb Clone()
		{
			return new RecallQuestDestroyActionCtxPb(this);
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x060142A2 RID: 82594 RVA: 0x002EF733 File Offset: 0x002ED933
		// (set) Token: 0x060142A3 RID: 82595 RVA: 0x002EF73B File Offset: 0x002ED93B
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

		// Token: 0x060142A4 RID: 82596 RVA: 0x002EF744 File Offset: 0x002ED944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestDestroyActionCtxPb);
		}

		// Token: 0x060142A5 RID: 82597 RVA: 0x002EF752 File Offset: 0x002ED952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestDestroyActionCtxPb other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142A6 RID: 82598 RVA: 0x002EF780 File Offset: 0x002ED980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060142A7 RID: 82599 RVA: 0x002EF7BF File Offset: 0x002ED9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142A8 RID: 82600 RVA: 0x002EF7CC File Offset: 0x002ED9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142A9 RID: 82601 RVA: 0x002EF7D5 File Offset: 0x002ED9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142AA RID: 82602 RVA: 0x002EF808 File Offset: 0x002EDA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060142AB RID: 82603 RVA: 0x002EF846 File Offset: 0x002EDA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestDestroyActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060142AC RID: 82604 RVA: 0x002EF877 File Offset: 0x002EDA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142AD RID: 82605 RVA: 0x002EF880 File Offset: 0x002EDA80
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B31 RID: 31537
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B32 RID: 31538
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B33 RID: 31539
		private int recallQuestId_;
	}
}
