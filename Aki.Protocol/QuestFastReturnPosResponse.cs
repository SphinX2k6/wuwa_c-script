using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0F RID: 3599
	[NetMessage(EMessageId.QuestFastReturnPosResponse)]
	public sealed class QuestFastReturnPosResponse : IMessage<QuestFastReturnPosResponse>, IMessage, IEquatable<QuestFastReturnPosResponse>, IDeepCloneable<QuestFastReturnPosResponse>, IBufferMessage
	{
		// Token: 0x06013577 RID: 79223 RVA: 0x002D08A7 File Offset: 0x002CEAA7
		[NullableContext(1)]
		public static QuestFastReturnPosResponse Create()
		{
			return new QuestFastReturnPosResponse();
		}

		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x06013578 RID: 79224 RVA: 0x002D08AE File Offset: 0x002CEAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x06013579 RID: 79225 RVA: 0x002D08B1 File Offset: 0x002CEAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFastReturnPosResponse.Descriptor;
			}
		}

		// Token: 0x0601357A RID: 79226 RVA: 0x002D08B8 File Offset: 0x002CEAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosResponse()
		{
		}

		// Token: 0x0601357B RID: 79227 RVA: 0x002D08C0 File Offset: 0x002CEAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosResponse(QuestFastReturnPosResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601357C RID: 79228 RVA: 0x002D08E5 File Offset: 0x002CEAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFastReturnPosResponse Clone()
		{
			return new QuestFastReturnPosResponse(this);
		}

		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x0601357D RID: 79229 RVA: 0x002D08ED File Offset: 0x002CEAED
		// (set) Token: 0x0601357E RID: 79230 RVA: 0x002D08F5 File Offset: 0x002CEAF5
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

		// Token: 0x0601357F RID: 79231 RVA: 0x002D08FE File Offset: 0x002CEAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFastReturnPosResponse);
		}

		// Token: 0x06013580 RID: 79232 RVA: 0x002D090C File Offset: 0x002CEB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFastReturnPosResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013581 RID: 79233 RVA: 0x002D093C File Offset: 0x002CEB3C
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

		// Token: 0x06013582 RID: 79234 RVA: 0x002D0981 File Offset: 0x002CEB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013583 RID: 79235 RVA: 0x002D098E File Offset: 0x002CEB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013584 RID: 79236 RVA: 0x002D0997 File Offset: 0x002CEB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013585 RID: 79237 RVA: 0x002D09CC File Offset: 0x002CEBCC
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

		// Token: 0x06013586 RID: 79238 RVA: 0x002D0A0A File Offset: 0x002CEC0A
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

		// Token: 0x06013587 RID: 79239 RVA: 0x002D0A3B File Offset: 0x002CEC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013588 RID: 79240 RVA: 0x002D0A44 File Offset: 0x002CEC44
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076CA RID: 30410
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076CB RID: 30411
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040076CC RID: 30412
		private ErrorCode errorCode_;
	}
}
