using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E14 RID: 3604
	[NetMessage(EMessageId.QuestFinishActionResponse)]
	public sealed class QuestFinishActionResponse : IMessage<QuestFinishActionResponse>, IMessage, IEquatable<QuestFinishActionResponse>, IDeepCloneable<QuestFinishActionResponse>, IBufferMessage
	{
		// Token: 0x060135D7 RID: 79319 RVA: 0x002D1425 File Offset: 0x002CF625
		[NullableContext(1)]
		public static QuestFinishActionResponse Create()
		{
			return new QuestFinishActionResponse();
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x060135D8 RID: 79320 RVA: 0x002D142C File Offset: 0x002CF62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x060135D9 RID: 79321 RVA: 0x002D142F File Offset: 0x002CF62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionResponse.Descriptor;
			}
		}

		// Token: 0x060135DA RID: 79322 RVA: 0x002D1436 File Offset: 0x002CF636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionResponse()
		{
		}

		// Token: 0x060135DB RID: 79323 RVA: 0x002D143E File Offset: 0x002CF63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionResponse(QuestFinishActionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135DC RID: 79324 RVA: 0x002D1463 File Offset: 0x002CF663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionResponse Clone()
		{
			return new QuestFinishActionResponse(this);
		}

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x060135DD RID: 79325 RVA: 0x002D146B File Offset: 0x002CF66B
		// (set) Token: 0x060135DE RID: 79326 RVA: 0x002D1473 File Offset: 0x002CF673
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

		// Token: 0x060135DF RID: 79327 RVA: 0x002D147C File Offset: 0x002CF67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionResponse);
		}

		// Token: 0x060135E0 RID: 79328 RVA: 0x002D148A File Offset: 0x002CF68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135E1 RID: 79329 RVA: 0x002D14B8 File Offset: 0x002CF6B8
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

		// Token: 0x060135E2 RID: 79330 RVA: 0x002D14FD File Offset: 0x002CF6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135E3 RID: 79331 RVA: 0x002D150A File Offset: 0x002CF70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135E4 RID: 79332 RVA: 0x002D1513 File Offset: 0x002CF713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060135E5 RID: 79333 RVA: 0x002D1548 File Offset: 0x002CF748
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

		// Token: 0x060135E6 RID: 79334 RVA: 0x002D1586 File Offset: 0x002CF786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFinishActionResponse other)
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

		// Token: 0x060135E7 RID: 79335 RVA: 0x002D15B7 File Offset: 0x002CF7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135E8 RID: 79336 RVA: 0x002D15C0 File Offset: 0x002CF7C0
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076E0 RID: 30432
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076E1 RID: 30433
		public const int ErrorIdFieldNumber = 15;

		// Token: 0x040076E2 RID: 30434
		private ErrorCode errorId_;
	}
}
