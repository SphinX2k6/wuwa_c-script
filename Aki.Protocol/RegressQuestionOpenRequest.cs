using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE1 RID: 3809
	[NetMessage(EMessageId.RegressQuestionOpenRequest)]
	public sealed class RegressQuestionOpenRequest : IMessage<RegressQuestionOpenRequest>, IMessage, IEquatable<RegressQuestionOpenRequest>, IDeepCloneable<RegressQuestionOpenRequest>, IBufferMessage
	{
		// Token: 0x060146AC RID: 83628 RVA: 0x002F7A79 File Offset: 0x002F5C79
		[NullableContext(1)]
		public static RegressQuestionOpenRequest Create()
		{
			return new RegressQuestionOpenRequest();
		}

		// Token: 0x170043E7 RID: 17383
		// (get) Token: 0x060146AD RID: 83629 RVA: 0x002F7A80 File Offset: 0x002F5C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043E8 RID: 17384
		// (get) Token: 0x060146AE RID: 83630 RVA: 0x002F7A83 File Offset: 0x002F5C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressQuestionOpenRequest.Descriptor;
			}
		}

		// Token: 0x060146AF RID: 83631 RVA: 0x002F7A8A File Offset: 0x002F5C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenRequest()
		{
		}

		// Token: 0x060146B0 RID: 83632 RVA: 0x002F7A92 File Offset: 0x002F5C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenRequest(RegressQuestionOpenRequest other) : this()
		{
			this.questionId_ = other.questionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146B1 RID: 83633 RVA: 0x002F7AB7 File Offset: 0x002F5CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenRequest Clone()
		{
			return new RegressQuestionOpenRequest(this);
		}

		// Token: 0x170043E9 RID: 17385
		// (get) Token: 0x060146B2 RID: 83634 RVA: 0x002F7ABF File Offset: 0x002F5CBF
		// (set) Token: 0x060146B3 RID: 83635 RVA: 0x002F7AC7 File Offset: 0x002F5CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestionId
		{
			get
			{
				return this.questionId_;
			}
			set
			{
				this.questionId_ = value;
			}
		}

		// Token: 0x060146B4 RID: 83636 RVA: 0x002F7AD0 File Offset: 0x002F5CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressQuestionOpenRequest);
		}

		// Token: 0x060146B5 RID: 83637 RVA: 0x002F7ADE File Offset: 0x002F5CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressQuestionOpenRequest other)
		{
			return other != null && (other == this || (this.QuestionId == other.QuestionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146B6 RID: 83638 RVA: 0x002F7B0C File Offset: 0x002F5D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestionId != 0)
			{
				num ^= this.QuestionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060146B7 RID: 83639 RVA: 0x002F7B4B File Offset: 0x002F5D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146B8 RID: 83640 RVA: 0x002F7B58 File Offset: 0x002F5D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146B9 RID: 83641 RVA: 0x002F7B61 File Offset: 0x002F5D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestionId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.QuestionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060146BA RID: 83642 RVA: 0x002F7B94 File Offset: 0x002F5D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060146BB RID: 83643 RVA: 0x002F7BD2 File Offset: 0x002F5DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressQuestionOpenRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestionId != 0)
			{
				this.QuestionId = other.QuestionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060146BC RID: 83644 RVA: 0x002F7C03 File Offset: 0x002F5E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146BD RID: 83645 RVA: 0x002F7C0C File Offset: 0x002F5E0C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007BF3 RID: 31731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BF4 RID: 31732
		public const int QuestionIdFieldNumber = 13;

		// Token: 0x04007BF5 RID: 31733
		private int questionId_;
	}
}
