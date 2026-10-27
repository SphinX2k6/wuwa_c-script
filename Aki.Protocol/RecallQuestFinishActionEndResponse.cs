using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBC RID: 3772
	[NetMessage(EMessageId.RecallQuestFinishActionEndResponse)]
	public sealed class RecallQuestFinishActionEndResponse : IMessage<RecallQuestFinishActionEndResponse>, IMessage, IEquatable<RecallQuestFinishActionEndResponse>, IDeepCloneable<RecallQuestFinishActionEndResponse>, IBufferMessage
	{
		// Token: 0x060143B7 RID: 82871 RVA: 0x002F132D File Offset: 0x002EF52D
		[NullableContext(1)]
		public static RecallQuestFinishActionEndResponse Create()
		{
			return new RecallQuestFinishActionEndResponse();
		}

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x060143B8 RID: 82872 RVA: 0x002F1334 File Offset: 0x002EF534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x060143B9 RID: 82873 RVA: 0x002F1337 File Offset: 0x002EF537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionEndResponse.Descriptor;
			}
		}

		// Token: 0x060143BA RID: 82874 RVA: 0x002F133E File Offset: 0x002EF53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndResponse()
		{
		}

		// Token: 0x060143BB RID: 82875 RVA: 0x002F1346 File Offset: 0x002EF546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndResponse(RecallQuestFinishActionEndResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143BC RID: 82876 RVA: 0x002F136B File Offset: 0x002EF56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndResponse Clone()
		{
			return new RecallQuestFinishActionEndResponse(this);
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x060143BD RID: 82877 RVA: 0x002F1373 File Offset: 0x002EF573
		// (set) Token: 0x060143BE RID: 82878 RVA: 0x002F137B File Offset: 0x002EF57B
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

		// Token: 0x060143BF RID: 82879 RVA: 0x002F1384 File Offset: 0x002EF584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionEndResponse);
		}

		// Token: 0x060143C0 RID: 82880 RVA: 0x002F1392 File Offset: 0x002EF592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionEndResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143C1 RID: 82881 RVA: 0x002F13C0 File Offset: 0x002EF5C0
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

		// Token: 0x060143C2 RID: 82882 RVA: 0x002F1405 File Offset: 0x002EF605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143C3 RID: 82883 RVA: 0x002F1412 File Offset: 0x002EF612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143C4 RID: 82884 RVA: 0x002F141B File Offset: 0x002EF61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060143C5 RID: 82885 RVA: 0x002F1450 File Offset: 0x002EF650
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

		// Token: 0x060143C6 RID: 82886 RVA: 0x002F148E File Offset: 0x002EF68E
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

		// Token: 0x060143C7 RID: 82887 RVA: 0x002F14BF File Offset: 0x002EF6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143C8 RID: 82888 RVA: 0x002F14C8 File Offset: 0x002EF6C8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B11 RID: 31505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B12 RID: 31506
		public const int ErrorIdFieldNumber = 9;

		// Token: 0x04007B13 RID: 31507
		private ErrorCode errorId_;
	}
}
