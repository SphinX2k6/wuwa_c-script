using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1A RID: 3610
	[NetMessage(EMessageId.QuestReviewInfoResponse)]
	public sealed class QuestReviewInfoResponse : IMessage<QuestReviewInfoResponse>, IMessage, IEquatable<QuestReviewInfoResponse>, IDeepCloneable<QuestReviewInfoResponse>, IBufferMessage
	{
		// Token: 0x0601369D RID: 79517 RVA: 0x002D306A File Offset: 0x002D126A
		[NullableContext(1)]
		public static QuestReviewInfoResponse Create()
		{
			return new QuestReviewInfoResponse();
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x0601369E RID: 79518 RVA: 0x002D3071 File Offset: 0x002D1271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x0601369F RID: 79519 RVA: 0x002D3074 File Offset: 0x002D1274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewInfoResponse.Descriptor;
			}
		}

		// Token: 0x060136A0 RID: 79520 RVA: 0x002D307B File Offset: 0x002D127B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoResponse()
		{
		}

		// Token: 0x060136A1 RID: 79521 RVA: 0x002D3083 File Offset: 0x002D1283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoResponse(QuestReviewInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136A2 RID: 79522 RVA: 0x002D30A8 File Offset: 0x002D12A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewInfoResponse Clone()
		{
			return new QuestReviewInfoResponse(this);
		}

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x060136A3 RID: 79523 RVA: 0x002D30B0 File Offset: 0x002D12B0
		// (set) Token: 0x060136A4 RID: 79524 RVA: 0x002D30B8 File Offset: 0x002D12B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060136A5 RID: 79525 RVA: 0x002D30C1 File Offset: 0x002D12C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewInfoResponse);
		}

		// Token: 0x060136A6 RID: 79526 RVA: 0x002D30CF File Offset: 0x002D12CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136A7 RID: 79527 RVA: 0x002D3100 File Offset: 0x002D1300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060136A8 RID: 79528 RVA: 0x002D3145 File Offset: 0x002D1345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136A9 RID: 79529 RVA: 0x002D3152 File Offset: 0x002D1352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136AA RID: 79530 RVA: 0x002D315B File Offset: 0x002D135B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060136AB RID: 79531 RVA: 0x002D3190 File Offset: 0x002D1390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060136AC RID: 79532 RVA: 0x002D31CE File Offset: 0x002D13CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060136AD RID: 79533 RVA: 0x002D31FF File Offset: 0x002D13FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136AE RID: 79534 RVA: 0x002D3208 File Offset: 0x002D1408
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007774 RID: 30580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007775 RID: 30581
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007776 RID: 30582
		private ErrorCode errorCode_;
	}
}
