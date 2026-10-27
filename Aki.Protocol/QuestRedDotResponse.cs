using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E26 RID: 3622
	[NetMessage(EMessageId.QuestRedDotResponse)]
	public sealed class QuestRedDotResponse : IMessage<QuestRedDotResponse>, IMessage, IEquatable<QuestRedDotResponse>, IDeepCloneable<QuestRedDotResponse>, IBufferMessage
	{
		// Token: 0x06013733 RID: 79667 RVA: 0x002D3CA8 File Offset: 0x002D1EA8
		[NullableContext(1)]
		public static QuestRedDotResponse Create()
		{
			return new QuestRedDotResponse();
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x06013734 RID: 79668 RVA: 0x002D3CAF File Offset: 0x002D1EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x06013735 RID: 79669 RVA: 0x002D3CB2 File Offset: 0x002D1EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRedDotResponse.Descriptor;
			}
		}

		// Token: 0x06013736 RID: 79670 RVA: 0x002D3CB9 File Offset: 0x002D1EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotResponse()
		{
		}

		// Token: 0x06013737 RID: 79671 RVA: 0x002D3CC1 File Offset: 0x002D1EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotResponse(QuestRedDotResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013738 RID: 79672 RVA: 0x002D3CE6 File Offset: 0x002D1EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotResponse Clone()
		{
			return new QuestRedDotResponse(this);
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x06013739 RID: 79673 RVA: 0x002D3CEE File Offset: 0x002D1EEE
		// (set) Token: 0x0601373A RID: 79674 RVA: 0x002D3CF6 File Offset: 0x002D1EF6
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

		// Token: 0x0601373B RID: 79675 RVA: 0x002D3CFF File Offset: 0x002D1EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRedDotResponse);
		}

		// Token: 0x0601373C RID: 79676 RVA: 0x002D3D0D File Offset: 0x002D1F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRedDotResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601373D RID: 79677 RVA: 0x002D3D3C File Offset: 0x002D1F3C
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

		// Token: 0x0601373E RID: 79678 RVA: 0x002D3D81 File Offset: 0x002D1F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601373F RID: 79679 RVA: 0x002D3D8E File Offset: 0x002D1F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013740 RID: 79680 RVA: 0x002D3D97 File Offset: 0x002D1F97
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

		// Token: 0x06013741 RID: 79681 RVA: 0x002D3DCC File Offset: 0x002D1FCC
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

		// Token: 0x06013742 RID: 79682 RVA: 0x002D3E0A File Offset: 0x002D200A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRedDotResponse other)
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

		// Token: 0x06013743 RID: 79683 RVA: 0x002D3E3B File Offset: 0x002D203B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013744 RID: 79684 RVA: 0x002D3E44 File Offset: 0x002D2044
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

		// Token: 0x04007731 RID: 30513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007732 RID: 30514
		public const int ErrorIdFieldNumber = 15;

		// Token: 0x04007733 RID: 30515
		private ErrorCode errorId_;
	}
}
