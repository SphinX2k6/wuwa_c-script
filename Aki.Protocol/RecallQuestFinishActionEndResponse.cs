using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAC RID: 3756
	[NetMessage(EMessageId.RecallQuestFinishActionEndResponse)]
	public sealed class RecallQuestFinishActionEndResponse : IMessage<RecallQuestFinishActionEndResponse>, IMessage, IEquatable<RecallQuestFinishActionEndResponse>, IDeepCloneable<RecallQuestFinishActionEndResponse>, IBufferMessage
	{
		// Token: 0x060142D2 RID: 82642 RVA: 0x002EFC7D File Offset: 0x002EDE7D
		[NullableContext(1)]
		public static RecallQuestFinishActionEndResponse Create()
		{
			return new RecallQuestFinishActionEndResponse();
		}

		// Token: 0x1700431C RID: 17180
		// (get) Token: 0x060142D3 RID: 82643 RVA: 0x002EFC84 File Offset: 0x002EDE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700431D RID: 17181
		// (get) Token: 0x060142D4 RID: 82644 RVA: 0x002EFC87 File Offset: 0x002EDE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionEndResponse.Descriptor;
			}
		}

		// Token: 0x060142D5 RID: 82645 RVA: 0x002EFC8E File Offset: 0x002EDE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndResponse()
		{
		}

		// Token: 0x060142D6 RID: 82646 RVA: 0x002EFC96 File Offset: 0x002EDE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndResponse(RecallQuestFinishActionEndResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142D7 RID: 82647 RVA: 0x002EFCBB File Offset: 0x002EDEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndResponse Clone()
		{
			return new RecallQuestFinishActionEndResponse(this);
		}

		// Token: 0x1700431E RID: 17182
		// (get) Token: 0x060142D8 RID: 82648 RVA: 0x002EFCC3 File Offset: 0x002EDEC3
		// (set) Token: 0x060142D9 RID: 82649 RVA: 0x002EFCCB File Offset: 0x002EDECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060142DA RID: 82650 RVA: 0x002EFCD4 File Offset: 0x002EDED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionEndResponse);
		}

		// Token: 0x060142DB RID: 82651 RVA: 0x002EFCE2 File Offset: 0x002EDEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionEndResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142DC RID: 82652 RVA: 0x002EFD10 File Offset: 0x002EDF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060142DD RID: 82653 RVA: 0x002EFD55 File Offset: 0x002EDF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142DE RID: 82654 RVA: 0x002EFD62 File Offset: 0x002EDF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142DF RID: 82655 RVA: 0x002EFD6B File Offset: 0x002EDF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142E0 RID: 82656 RVA: 0x002EFDA0 File Offset: 0x002EDFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060142E1 RID: 82657 RVA: 0x002EFDDE File Offset: 0x002EDFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestFinishActionEndResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060142E2 RID: 82658 RVA: 0x002EFE0F File Offset: 0x002EE00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142E3 RID: 82659 RVA: 0x002EFE18 File Offset: 0x002EE018
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B3B RID: 31547
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B3C RID: 31548
		public const int ErrorIdFieldNumber = 2;

		// Token: 0x04007B3D RID: 31549
		private ErrorCode errorId_;
	}
}
