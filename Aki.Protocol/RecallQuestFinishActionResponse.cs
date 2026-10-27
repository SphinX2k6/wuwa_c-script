using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBE RID: 3774
	[NetMessage(EMessageId.RecallQuestFinishActionResponse)]
	public sealed class RecallQuestFinishActionResponse : IMessage<RecallQuestFinishActionResponse>, IMessage, IEquatable<RecallQuestFinishActionResponse>, IDeepCloneable<RecallQuestFinishActionResponse>, IBufferMessage
	{
		// Token: 0x060143E1 RID: 82913 RVA: 0x002F1911 File Offset: 0x002EFB11
		[NullableContext(1)]
		public static RecallQuestFinishActionResponse Create()
		{
			return new RecallQuestFinishActionResponse();
		}

		// Token: 0x1700434F RID: 17231
		// (get) Token: 0x060143E2 RID: 82914 RVA: 0x002F1918 File Offset: 0x002EFB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004350 RID: 17232
		// (get) Token: 0x060143E3 RID: 82915 RVA: 0x002F191B File Offset: 0x002EFB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionResponse.Descriptor;
			}
		}

		// Token: 0x060143E4 RID: 82916 RVA: 0x002F1922 File Offset: 0x002EFB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionResponse()
		{
		}

		// Token: 0x060143E5 RID: 82917 RVA: 0x002F192A File Offset: 0x002EFB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionResponse(RecallQuestFinishActionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143E6 RID: 82918 RVA: 0x002F194F File Offset: 0x002EFB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionResponse Clone()
		{
			return new RecallQuestFinishActionResponse(this);
		}

		// Token: 0x17004351 RID: 17233
		// (get) Token: 0x060143E7 RID: 82919 RVA: 0x002F1957 File Offset: 0x002EFB57
		// (set) Token: 0x060143E8 RID: 82920 RVA: 0x002F195F File Offset: 0x002EFB5F
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

		// Token: 0x060143E9 RID: 82921 RVA: 0x002F1968 File Offset: 0x002EFB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionResponse);
		}

		// Token: 0x060143EA RID: 82922 RVA: 0x002F1976 File Offset: 0x002EFB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143EB RID: 82923 RVA: 0x002F19A4 File Offset: 0x002EFBA4
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

		// Token: 0x060143EC RID: 82924 RVA: 0x002F19E9 File Offset: 0x002EFBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143ED RID: 82925 RVA: 0x002F19F6 File Offset: 0x002EFBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143EE RID: 82926 RVA: 0x002F19FF File Offset: 0x002EFBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060143EF RID: 82927 RVA: 0x002F1A34 File Offset: 0x002EFC34
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

		// Token: 0x060143F0 RID: 82928 RVA: 0x002F1A72 File Offset: 0x002EFC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestFinishActionResponse other)
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

		// Token: 0x060143F1 RID: 82929 RVA: 0x002F1AA3 File Offset: 0x002EFCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143F2 RID: 82930 RVA: 0x002F1AAC File Offset: 0x002EFCAC
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B1D RID: 31517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B1E RID: 31518
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x04007B1F RID: 31519
		private ErrorCode errorId_;
	}
}
