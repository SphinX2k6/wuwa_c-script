using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA6 RID: 3750
	[NetMessage(EMessageId.RecallQuestActionResponse)]
	public sealed class RecallQuestActionResponse : IMessage<RecallQuestActionResponse>, IMessage, IEquatable<RecallQuestActionResponse>, IDeepCloneable<RecallQuestActionResponse>, IBufferMessage
	{
		// Token: 0x06014266 RID: 82534 RVA: 0x002EF154 File Offset: 0x002ED354
		[NullableContext(1)]
		public static RecallQuestActionResponse Create()
		{
			return new RecallQuestActionResponse();
		}

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x06014267 RID: 82535 RVA: 0x002EF15B File Offset: 0x002ED35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x06014268 RID: 82536 RVA: 0x002EF15E File Offset: 0x002ED35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestActionResponse.Descriptor;
			}
		}

		// Token: 0x06014269 RID: 82537 RVA: 0x002EF165 File Offset: 0x002ED365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionResponse()
		{
		}

		// Token: 0x0601426A RID: 82538 RVA: 0x002EF16D File Offset: 0x002ED36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionResponse(RecallQuestActionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601426B RID: 82539 RVA: 0x002EF192 File Offset: 0x002ED392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionResponse Clone()
		{
			return new RecallQuestActionResponse(this);
		}

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x0601426C RID: 82540 RVA: 0x002EF19A File Offset: 0x002ED39A
		// (set) Token: 0x0601426D RID: 82541 RVA: 0x002EF1A2 File Offset: 0x002ED3A2
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

		// Token: 0x0601426E RID: 82542 RVA: 0x002EF1AB File Offset: 0x002ED3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestActionResponse);
		}

		// Token: 0x0601426F RID: 82543 RVA: 0x002EF1B9 File Offset: 0x002ED3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestActionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014270 RID: 82544 RVA: 0x002EF1E8 File Offset: 0x002ED3E8
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

		// Token: 0x06014271 RID: 82545 RVA: 0x002EF22D File Offset: 0x002ED42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014272 RID: 82546 RVA: 0x002EF23A File Offset: 0x002ED43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014273 RID: 82547 RVA: 0x002EF243 File Offset: 0x002ED443
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

		// Token: 0x06014274 RID: 82548 RVA: 0x002EF278 File Offset: 0x002ED478
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

		// Token: 0x06014275 RID: 82549 RVA: 0x002EF2B6 File Offset: 0x002ED4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestActionResponse other)
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

		// Token: 0x06014276 RID: 82550 RVA: 0x002EF2E7 File Offset: 0x002ED4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014277 RID: 82551 RVA: 0x002EF2F0 File Offset: 0x002ED4F0
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

		// Token: 0x04007B27 RID: 31527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B28 RID: 31528
		public const int ErrorIdFieldNumber = 2;

		// Token: 0x04007B29 RID: 31529
		private ErrorCode errorId_;
	}
}
