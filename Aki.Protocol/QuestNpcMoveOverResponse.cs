using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1E RID: 3614
	[NetMessage(EMessageId.QuestNpcMoveOverResponse)]
	public sealed class QuestNpcMoveOverResponse : IMessage<QuestNpcMoveOverResponse>, IMessage, IEquatable<QuestNpcMoveOverResponse>, IDeepCloneable<QuestNpcMoveOverResponse>, IBufferMessage
	{
		// Token: 0x0601369D RID: 79517 RVA: 0x002D2B95 File Offset: 0x002D0D95
		[NullableContext(1)]
		public static QuestNpcMoveOverResponse Create()
		{
			return new QuestNpcMoveOverResponse();
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x0601369E RID: 79518 RVA: 0x002D2B9C File Offset: 0x002D0D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x0601369F RID: 79519 RVA: 0x002D2B9F File Offset: 0x002D0D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestNpcMoveOverResponse.Descriptor;
			}
		}

		// Token: 0x060136A0 RID: 79520 RVA: 0x002D2BA6 File Offset: 0x002D0DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverResponse()
		{
		}

		// Token: 0x060136A1 RID: 79521 RVA: 0x002D2BAE File Offset: 0x002D0DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverResponse(QuestNpcMoveOverResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136A2 RID: 79522 RVA: 0x002D2BD3 File Offset: 0x002D0DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverResponse Clone()
		{
			return new QuestNpcMoveOverResponse(this);
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x060136A3 RID: 79523 RVA: 0x002D2BDB File Offset: 0x002D0DDB
		// (set) Token: 0x060136A4 RID: 79524 RVA: 0x002D2BE3 File Offset: 0x002D0DE3
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

		// Token: 0x060136A5 RID: 79525 RVA: 0x002D2BEC File Offset: 0x002D0DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestNpcMoveOverResponse);
		}

		// Token: 0x060136A6 RID: 79526 RVA: 0x002D2BFA File Offset: 0x002D0DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestNpcMoveOverResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136A7 RID: 79527 RVA: 0x002D2C28 File Offset: 0x002D0E28
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

		// Token: 0x060136A8 RID: 79528 RVA: 0x002D2C6D File Offset: 0x002D0E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136A9 RID: 79529 RVA: 0x002D2C7A File Offset: 0x002D0E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136AA RID: 79530 RVA: 0x002D2C83 File Offset: 0x002D0E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060136AB RID: 79531 RVA: 0x002D2CB8 File Offset: 0x002D0EB8
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

		// Token: 0x060136AC RID: 79532 RVA: 0x002D2CF6 File Offset: 0x002D0EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestNpcMoveOverResponse other)
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

		// Token: 0x060136AD RID: 79533 RVA: 0x002D2D27 File Offset: 0x002D0F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136AE RID: 79534 RVA: 0x002D2D30 File Offset: 0x002D0F30
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007711 RID: 30481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007712 RID: 30482
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04007713 RID: 30483
		private ErrorCode errorId_;
	}
}
