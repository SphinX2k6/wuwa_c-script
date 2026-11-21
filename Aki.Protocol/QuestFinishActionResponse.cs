using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E04 RID: 3588
	[NetMessage(EMessageId.QuestFinishActionResponse)]
	public sealed class QuestFinishActionResponse : IMessage<QuestFinishActionResponse>, IMessage, IEquatable<QuestFinishActionResponse>, IDeepCloneable<QuestFinishActionResponse>, IBufferMessage
	{
		// Token: 0x060134F2 RID: 79090 RVA: 0x002CFD65 File Offset: 0x002CDF65
		[NullableContext(1)]
		public static QuestFinishActionResponse Create()
		{
			return new QuestFinishActionResponse();
		}

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x060134F3 RID: 79091 RVA: 0x002CFD6C File Offset: 0x002CDF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x060134F4 RID: 79092 RVA: 0x002CFD6F File Offset: 0x002CDF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionResponse.Descriptor;
			}
		}

		// Token: 0x060134F5 RID: 79093 RVA: 0x002CFD76 File Offset: 0x002CDF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionResponse()
		{
		}

		// Token: 0x060134F6 RID: 79094 RVA: 0x002CFD7E File Offset: 0x002CDF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionResponse(QuestFinishActionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134F7 RID: 79095 RVA: 0x002CFDA3 File Offset: 0x002CDFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionResponse Clone()
		{
			return new QuestFinishActionResponse(this);
		}

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x060134F8 RID: 79096 RVA: 0x002CFDAB File Offset: 0x002CDFAB
		// (set) Token: 0x060134F9 RID: 79097 RVA: 0x002CFDB3 File Offset: 0x002CDFB3
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

		// Token: 0x060134FA RID: 79098 RVA: 0x002CFDBC File Offset: 0x002CDFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionResponse);
		}

		// Token: 0x060134FB RID: 79099 RVA: 0x002CFDCA File Offset: 0x002CDFCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134FC RID: 79100 RVA: 0x002CFDF8 File Offset: 0x002CDFF8
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

		// Token: 0x060134FD RID: 79101 RVA: 0x002CFE3D File Offset: 0x002CE03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134FE RID: 79102 RVA: 0x002CFE4A File Offset: 0x002CE04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134FF RID: 79103 RVA: 0x002CFE53 File Offset: 0x002CE053
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

		// Token: 0x06013500 RID: 79104 RVA: 0x002CFE88 File Offset: 0x002CE088
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

		// Token: 0x06013501 RID: 79105 RVA: 0x002CFEC6 File Offset: 0x002CE0C6
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

		// Token: 0x06013502 RID: 79106 RVA: 0x002CFEF7 File Offset: 0x002CE0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013503 RID: 79107 RVA: 0x002CFF00 File Offset: 0x002CE100
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

		// Token: 0x0400770A RID: 30474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400770B RID: 30475
		public const int ErrorIdFieldNumber = 7;

		// Token: 0x0400770C RID: 30476
		private ErrorCode errorId_;
	}
}
