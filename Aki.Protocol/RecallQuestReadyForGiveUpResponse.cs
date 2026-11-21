using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB6 RID: 3766
	[NetMessage(EMessageId.RecallQuestReadyForGiveUpResponse)]
	public sealed class RecallQuestReadyForGiveUpResponse : IMessage<RecallQuestReadyForGiveUpResponse>, IMessage, IEquatable<RecallQuestReadyForGiveUpResponse>, IDeepCloneable<RecallQuestReadyForGiveUpResponse>, IBufferMessage
	{
		// Token: 0x06014394 RID: 82836 RVA: 0x002F13AD File Offset: 0x002EF5AD
		[NullableContext(1)]
		public static RecallQuestReadyForGiveUpResponse Create()
		{
			return new RecallQuestReadyForGiveUpResponse();
		}

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x06014395 RID: 82837 RVA: 0x002F13B4 File Offset: 0x002EF5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x06014396 RID: 82838 RVA: 0x002F13B7 File Offset: 0x002EF5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestReadyForGiveUpResponse.Descriptor;
			}
		}

		// Token: 0x06014397 RID: 82839 RVA: 0x002F13BE File Offset: 0x002EF5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpResponse()
		{
		}

		// Token: 0x06014398 RID: 82840 RVA: 0x002F13C6 File Offset: 0x002EF5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpResponse(RecallQuestReadyForGiveUpResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014399 RID: 82841 RVA: 0x002F13EB File Offset: 0x002EF5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpResponse Clone()
		{
			return new RecallQuestReadyForGiveUpResponse(this);
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x0601439A RID: 82842 RVA: 0x002F13F3 File Offset: 0x002EF5F3
		// (set) Token: 0x0601439B RID: 82843 RVA: 0x002F13FB File Offset: 0x002EF5FB
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

		// Token: 0x0601439C RID: 82844 RVA: 0x002F1404 File Offset: 0x002EF604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestReadyForGiveUpResponse);
		}

		// Token: 0x0601439D RID: 82845 RVA: 0x002F1412 File Offset: 0x002EF612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestReadyForGiveUpResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601439E RID: 82846 RVA: 0x002F1440 File Offset: 0x002EF640
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

		// Token: 0x0601439F RID: 82847 RVA: 0x002F1485 File Offset: 0x002EF685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143A0 RID: 82848 RVA: 0x002F1492 File Offset: 0x002EF692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143A1 RID: 82849 RVA: 0x002F149B File Offset: 0x002EF69B
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

		// Token: 0x060143A2 RID: 82850 RVA: 0x002F14D0 File Offset: 0x002EF6D0
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

		// Token: 0x060143A3 RID: 82851 RVA: 0x002F150E File Offset: 0x002EF70E
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

		// Token: 0x060143A4 RID: 82852 RVA: 0x002F153F File Offset: 0x002EF73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143A5 RID: 82853 RVA: 0x002F1548 File Offset: 0x002EF748
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

		// Token: 0x04007B69 RID: 31593
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B6A RID: 31594
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x04007B6B RID: 31595
		private ErrorCode errorId_;
	}
}
