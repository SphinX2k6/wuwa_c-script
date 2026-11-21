using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB4 RID: 3764
	[NetMessage(EMessageId.RecallQuestNpcMoveOverResponse)]
	public sealed class RecallQuestNpcMoveOverResponse : IMessage<RecallQuestNpcMoveOverResponse>, IMessage, IEquatable<RecallQuestNpcMoveOverResponse>, IDeepCloneable<RecallQuestNpcMoveOverResponse>, IBufferMessage
	{
		// Token: 0x06014370 RID: 82800 RVA: 0x002F0FF9 File Offset: 0x002EF1F9
		[NullableContext(1)]
		public static RecallQuestNpcMoveOverResponse Create()
		{
			return new RecallQuestNpcMoveOverResponse();
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x06014371 RID: 82801 RVA: 0x002F1000 File Offset: 0x002EF200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x06014372 RID: 82802 RVA: 0x002F1003 File Offset: 0x002EF203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestNpcMoveOverResponse.Descriptor;
			}
		}

		// Token: 0x06014373 RID: 82803 RVA: 0x002F100A File Offset: 0x002EF20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverResponse()
		{
		}

		// Token: 0x06014374 RID: 82804 RVA: 0x002F1012 File Offset: 0x002EF212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverResponse(RecallQuestNpcMoveOverResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014375 RID: 82805 RVA: 0x002F1037 File Offset: 0x002EF237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverResponse Clone()
		{
			return new RecallQuestNpcMoveOverResponse(this);
		}

		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x06014376 RID: 82806 RVA: 0x002F103F File Offset: 0x002EF23F
		// (set) Token: 0x06014377 RID: 82807 RVA: 0x002F1047 File Offset: 0x002EF247
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

		// Token: 0x06014378 RID: 82808 RVA: 0x002F1050 File Offset: 0x002EF250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestNpcMoveOverResponse);
		}

		// Token: 0x06014379 RID: 82809 RVA: 0x002F105E File Offset: 0x002EF25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestNpcMoveOverResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601437A RID: 82810 RVA: 0x002F108C File Offset: 0x002EF28C
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

		// Token: 0x0601437B RID: 82811 RVA: 0x002F10D1 File Offset: 0x002EF2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601437C RID: 82812 RVA: 0x002F10DE File Offset: 0x002EF2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601437D RID: 82813 RVA: 0x002F10E7 File Offset: 0x002EF2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601437E RID: 82814 RVA: 0x002F1118 File Offset: 0x002EF318
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

		// Token: 0x0601437F RID: 82815 RVA: 0x002F1156 File Offset: 0x002EF356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestNpcMoveOverResponse other)
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

		// Token: 0x06014380 RID: 82816 RVA: 0x002F1187 File Offset: 0x002EF387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014381 RID: 82817 RVA: 0x002F1190 File Offset: 0x002EF390
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B63 RID: 31587
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B64 RID: 31588
		public const int ErrorIdFieldNumber = 1;

		// Token: 0x04007B65 RID: 31589
		private ErrorCode errorId_;
	}
}
