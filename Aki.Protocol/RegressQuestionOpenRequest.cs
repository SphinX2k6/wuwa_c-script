using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED1 RID: 3793
	[NetMessage(EMessageId.RegressQuestionOpenRequest)]
	public sealed class RegressQuestionOpenRequest : IMessage<RegressQuestionOpenRequest>, IMessage, IEquatable<RegressQuestionOpenRequest>, IDeepCloneable<RegressQuestionOpenRequest>, IBufferMessage
	{
		// Token: 0x060145C7 RID: 83399 RVA: 0x002F63CD File Offset: 0x002F45CD
		[NullableContext(1)]
		public static RegressQuestionOpenRequest Create()
		{
			return new RegressQuestionOpenRequest();
		}

		// Token: 0x170043BD RID: 17341
		// (get) Token: 0x060145C8 RID: 83400 RVA: 0x002F63D4 File Offset: 0x002F45D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043BE RID: 17342
		// (get) Token: 0x060145C9 RID: 83401 RVA: 0x002F63D7 File Offset: 0x002F45D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressQuestionOpenRequest.Descriptor;
			}
		}

		// Token: 0x060145CA RID: 83402 RVA: 0x002F63DE File Offset: 0x002F45DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenRequest()
		{
		}

		// Token: 0x060145CB RID: 83403 RVA: 0x002F63E6 File Offset: 0x002F45E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenRequest(RegressQuestionOpenRequest other) : this()
		{
			this.questionId_ = other.questionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145CC RID: 83404 RVA: 0x002F640B File Offset: 0x002F460B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenRequest Clone()
		{
			return new RegressQuestionOpenRequest(this);
		}

		// Token: 0x170043BF RID: 17343
		// (get) Token: 0x060145CD RID: 83405 RVA: 0x002F6413 File Offset: 0x002F4613
		// (set) Token: 0x060145CE RID: 83406 RVA: 0x002F641B File Offset: 0x002F461B
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

		// Token: 0x060145CF RID: 83407 RVA: 0x002F6424 File Offset: 0x002F4624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressQuestionOpenRequest);
		}

		// Token: 0x060145D0 RID: 83408 RVA: 0x002F6432 File Offset: 0x002F4632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressQuestionOpenRequest other)
		{
			return other != null && (other == this || (this.QuestionId == other.QuestionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060145D1 RID: 83409 RVA: 0x002F6460 File Offset: 0x002F4660
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

		// Token: 0x060145D2 RID: 83410 RVA: 0x002F649F File Offset: 0x002F469F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145D3 RID: 83411 RVA: 0x002F64AC File Offset: 0x002F46AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145D4 RID: 83412 RVA: 0x002F64B5 File Offset: 0x002F46B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestionId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.QuestionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145D5 RID: 83413 RVA: 0x002F64E8 File Offset: 0x002F46E8
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

		// Token: 0x060145D6 RID: 83414 RVA: 0x002F6526 File Offset: 0x002F4726
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

		// Token: 0x060145D7 RID: 83415 RVA: 0x002F6557 File Offset: 0x002F4757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145D8 RID: 83416 RVA: 0x002F6560 File Offset: 0x002F4760
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C1D RID: 31773
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C1E RID: 31774
		public const int QuestionIdFieldNumber = 4;

		// Token: 0x04007C1F RID: 31775
		private int questionId_;
	}
}
