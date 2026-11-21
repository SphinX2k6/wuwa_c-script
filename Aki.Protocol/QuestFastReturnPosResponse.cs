using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFF RID: 3583
	[NetMessage(EMessageId.QuestFastReturnPosResponse)]
	public sealed class QuestFastReturnPosResponse : IMessage<QuestFastReturnPosResponse>, IMessage, IEquatable<QuestFastReturnPosResponse>, IDeepCloneable<QuestFastReturnPosResponse>, IBufferMessage
	{
		// Token: 0x06013492 RID: 78994 RVA: 0x002CF1EB File Offset: 0x002CD3EB
		[NullableContext(1)]
		public static QuestFastReturnPosResponse Create()
		{
			return new QuestFastReturnPosResponse();
		}

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x06013493 RID: 78995 RVA: 0x002CF1F2 File Offset: 0x002CD3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x06013494 RID: 78996 RVA: 0x002CF1F5 File Offset: 0x002CD3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFastReturnPosResponse.Descriptor;
			}
		}

		// Token: 0x06013495 RID: 78997 RVA: 0x002CF1FC File Offset: 0x002CD3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosResponse()
		{
		}

		// Token: 0x06013496 RID: 78998 RVA: 0x002CF204 File Offset: 0x002CD404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosResponse(QuestFastReturnPosResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013497 RID: 78999 RVA: 0x002CF229 File Offset: 0x002CD429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosResponse Clone()
		{
			return new QuestFastReturnPosResponse(this);
		}

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x06013498 RID: 79000 RVA: 0x002CF231 File Offset: 0x002CD431
		// (set) Token: 0x06013499 RID: 79001 RVA: 0x002CF239 File Offset: 0x002CD439
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

		// Token: 0x0601349A RID: 79002 RVA: 0x002CF242 File Offset: 0x002CD442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFastReturnPosResponse);
		}

		// Token: 0x0601349B RID: 79003 RVA: 0x002CF250 File Offset: 0x002CD450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFastReturnPosResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601349C RID: 79004 RVA: 0x002CF280 File Offset: 0x002CD480
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

		// Token: 0x0601349D RID: 79005 RVA: 0x002CF2C5 File Offset: 0x002CD4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601349E RID: 79006 RVA: 0x002CF2D2 File Offset: 0x002CD4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601349F RID: 79007 RVA: 0x002CF2DB File Offset: 0x002CD4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134A0 RID: 79008 RVA: 0x002CF30C File Offset: 0x002CD50C
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

		// Token: 0x060134A1 RID: 79009 RVA: 0x002CF34A File Offset: 0x002CD54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFastReturnPosResponse other)
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

		// Token: 0x060134A2 RID: 79010 RVA: 0x002CF37B File Offset: 0x002CD57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134A3 RID: 79011 RVA: 0x002CF384 File Offset: 0x002CD584
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076F4 RID: 30452
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076F5 RID: 30453
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040076F6 RID: 30454
		private ErrorCode errorCode_;
	}
}
