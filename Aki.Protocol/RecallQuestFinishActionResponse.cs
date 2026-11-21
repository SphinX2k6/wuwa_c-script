using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAE RID: 3758
	[NetMessage(EMessageId.RecallQuestFinishActionResponse)]
	public sealed class RecallQuestFinishActionResponse : IMessage<RecallQuestFinishActionResponse>, IMessage, IEquatable<RecallQuestFinishActionResponse>, IDeepCloneable<RecallQuestFinishActionResponse>, IBufferMessage
	{
		// Token: 0x060142FC RID: 82684 RVA: 0x002F0261 File Offset: 0x002EE461
		[NullableContext(1)]
		public static RecallQuestFinishActionResponse Create()
		{
			return new RecallQuestFinishActionResponse();
		}

		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x060142FD RID: 82685 RVA: 0x002F0268 File Offset: 0x002EE468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x060142FE RID: 82686 RVA: 0x002F026B File Offset: 0x002EE46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionResponse.Descriptor;
			}
		}

		// Token: 0x060142FF RID: 82687 RVA: 0x002F0272 File Offset: 0x002EE472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionResponse()
		{
		}

		// Token: 0x06014300 RID: 82688 RVA: 0x002F027A File Offset: 0x002EE47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionResponse(RecallQuestFinishActionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014301 RID: 82689 RVA: 0x002F029F File Offset: 0x002EE49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionResponse Clone()
		{
			return new RecallQuestFinishActionResponse(this);
		}

		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x06014302 RID: 82690 RVA: 0x002F02A7 File Offset: 0x002EE4A7
		// (set) Token: 0x06014303 RID: 82691 RVA: 0x002F02AF File Offset: 0x002EE4AF
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

		// Token: 0x06014304 RID: 82692 RVA: 0x002F02B8 File Offset: 0x002EE4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionResponse);
		}

		// Token: 0x06014305 RID: 82693 RVA: 0x002F02C6 File Offset: 0x002EE4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014306 RID: 82694 RVA: 0x002F02F4 File Offset: 0x002EE4F4
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

		// Token: 0x06014307 RID: 82695 RVA: 0x002F0339 File Offset: 0x002EE539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014308 RID: 82696 RVA: 0x002F0346 File Offset: 0x002EE546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014309 RID: 82697 RVA: 0x002F034F File Offset: 0x002EE54F
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

		// Token: 0x0601430A RID: 82698 RVA: 0x002F0384 File Offset: 0x002EE584
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

		// Token: 0x0601430B RID: 82699 RVA: 0x002F03C2 File Offset: 0x002EE5C2
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

		// Token: 0x0601430C RID: 82700 RVA: 0x002F03F3 File Offset: 0x002EE5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601430D RID: 82701 RVA: 0x002F03FC File Offset: 0x002EE5FC
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

		// Token: 0x04007B47 RID: 31559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B48 RID: 31560
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x04007B49 RID: 31561
		private ErrorCode errorId_;
	}
}
