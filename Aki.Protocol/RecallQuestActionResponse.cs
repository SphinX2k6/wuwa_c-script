using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB6 RID: 3766
	[NetMessage(EMessageId.RecallQuestActionResponse)]
	public sealed class RecallQuestActionResponse : IMessage<RecallQuestActionResponse>, IMessage, IEquatable<RecallQuestActionResponse>, IDeepCloneable<RecallQuestActionResponse>, IBufferMessage
	{
		// Token: 0x0601434B RID: 82763 RVA: 0x002F0805 File Offset: 0x002EEA05
		[NullableContext(1)]
		public static RecallQuestActionResponse Create()
		{
			return new RecallQuestActionResponse();
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x0601434C RID: 82764 RVA: 0x002F080C File Offset: 0x002EEA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x0601434D RID: 82765 RVA: 0x002F080F File Offset: 0x002EEA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestActionResponse.Descriptor;
			}
		}

		// Token: 0x0601434E RID: 82766 RVA: 0x002F0816 File Offset: 0x002EEA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionResponse()
		{
		}

		// Token: 0x0601434F RID: 82767 RVA: 0x002F081E File Offset: 0x002EEA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionResponse(RecallQuestActionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014350 RID: 82768 RVA: 0x002F0843 File Offset: 0x002EEA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionResponse Clone()
		{
			return new RecallQuestActionResponse(this);
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x06014351 RID: 82769 RVA: 0x002F084B File Offset: 0x002EEA4B
		// (set) Token: 0x06014352 RID: 82770 RVA: 0x002F0853 File Offset: 0x002EEA53
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

		// Token: 0x06014353 RID: 82771 RVA: 0x002F085C File Offset: 0x002EEA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestActionResponse);
		}

		// Token: 0x06014354 RID: 82772 RVA: 0x002F086A File Offset: 0x002EEA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestActionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014355 RID: 82773 RVA: 0x002F0898 File Offset: 0x002EEA98
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

		// Token: 0x06014356 RID: 82774 RVA: 0x002F08DD File Offset: 0x002EEADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014357 RID: 82775 RVA: 0x002F08EA File Offset: 0x002EEAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014358 RID: 82776 RVA: 0x002F08F3 File Offset: 0x002EEAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014359 RID: 82777 RVA: 0x002F0928 File Offset: 0x002EEB28
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

		// Token: 0x0601435A RID: 82778 RVA: 0x002F0966 File Offset: 0x002EEB66
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

		// Token: 0x0601435B RID: 82779 RVA: 0x002F0997 File Offset: 0x002EEB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601435C RID: 82780 RVA: 0x002F09A0 File Offset: 0x002EEBA0
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007AFD RID: 31485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AFE RID: 31486
		public const int ErrorIdFieldNumber = 8;

		// Token: 0x04007AFF RID: 31487
		private ErrorCode errorId_;
	}
}
