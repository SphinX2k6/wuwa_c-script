using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC6 RID: 3782
	[NetMessage(EMessageId.RecallQuestReadyForGiveUpResponse)]
	public sealed class RecallQuestReadyForGiveUpResponse : IMessage<RecallQuestReadyForGiveUpResponse>, IMessage, IEquatable<RecallQuestReadyForGiveUpResponse>, IDeepCloneable<RecallQuestReadyForGiveUpResponse>, IBufferMessage
	{
		// Token: 0x06014479 RID: 83065 RVA: 0x002F2A60 File Offset: 0x002F0C60
		[NullableContext(1)]
		public static RecallQuestReadyForGiveUpResponse Create()
		{
			return new RecallQuestReadyForGiveUpResponse();
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x0601447A RID: 83066 RVA: 0x002F2A67 File Offset: 0x002F0C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x0601447B RID: 83067 RVA: 0x002F2A6A File Offset: 0x002F0C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestReadyForGiveUpResponse.Descriptor;
			}
		}

		// Token: 0x0601447C RID: 83068 RVA: 0x002F2A71 File Offset: 0x002F0C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpResponse()
		{
		}

		// Token: 0x0601447D RID: 83069 RVA: 0x002F2A79 File Offset: 0x002F0C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpResponse(RecallQuestReadyForGiveUpResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601447E RID: 83070 RVA: 0x002F2A9E File Offset: 0x002F0C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpResponse Clone()
		{
			return new RecallQuestReadyForGiveUpResponse(this);
		}

		// Token: 0x1700436D RID: 17261
		// (get) Token: 0x0601447F RID: 83071 RVA: 0x002F2AA6 File Offset: 0x002F0CA6
		// (set) Token: 0x06014480 RID: 83072 RVA: 0x002F2AAE File Offset: 0x002F0CAE
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

		// Token: 0x06014481 RID: 83073 RVA: 0x002F2AB7 File Offset: 0x002F0CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestReadyForGiveUpResponse);
		}

		// Token: 0x06014482 RID: 83074 RVA: 0x002F2AC5 File Offset: 0x002F0CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestReadyForGiveUpResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014483 RID: 83075 RVA: 0x002F2AF4 File Offset: 0x002F0CF4
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

		// Token: 0x06014484 RID: 83076 RVA: 0x002F2B39 File Offset: 0x002F0D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014485 RID: 83077 RVA: 0x002F2B46 File Offset: 0x002F0D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014486 RID: 83078 RVA: 0x002F2B4F File Offset: 0x002F0D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014487 RID: 83079 RVA: 0x002F2B84 File Offset: 0x002F0D84
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

		// Token: 0x06014488 RID: 83080 RVA: 0x002F2BC2 File Offset: 0x002F0DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestReadyForGiveUpResponse other)
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

		// Token: 0x06014489 RID: 83081 RVA: 0x002F2BF3 File Offset: 0x002F0DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601448A RID: 83082 RVA: 0x002F2BFC File Offset: 0x002F0DFC
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B3F RID: 31551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B40 RID: 31552
		public const int ErrorIdFieldNumber = 7;

		// Token: 0x04007B41 RID: 31553
		private ErrorCode errorId_;
	}
}
