using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E16 RID: 3606
	[NetMessage(EMessageId.QuestRedDotResponse)]
	public sealed class QuestRedDotResponse : IMessage<QuestRedDotResponse>, IMessage, IEquatable<QuestRedDotResponse>, IDeepCloneable<QuestRedDotResponse>, IBufferMessage
	{
		// Token: 0x0601364E RID: 79438 RVA: 0x002D25E4 File Offset: 0x002D07E4
		[NullableContext(1)]
		public static QuestRedDotResponse Create()
		{
			return new QuestRedDotResponse();
		}

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x0601364F RID: 79439 RVA: 0x002D25EB File Offset: 0x002D07EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x06013650 RID: 79440 RVA: 0x002D25EE File Offset: 0x002D07EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRedDotResponse.Descriptor;
			}
		}

		// Token: 0x06013651 RID: 79441 RVA: 0x002D25F5 File Offset: 0x002D07F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotResponse()
		{
		}

		// Token: 0x06013652 RID: 79442 RVA: 0x002D25FD File Offset: 0x002D07FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotResponse(QuestRedDotResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013653 RID: 79443 RVA: 0x002D2622 File Offset: 0x002D0822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRedDotResponse Clone()
		{
			return new QuestRedDotResponse(this);
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x06013654 RID: 79444 RVA: 0x002D262A File Offset: 0x002D082A
		// (set) Token: 0x06013655 RID: 79445 RVA: 0x002D2632 File Offset: 0x002D0832
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

		// Token: 0x06013656 RID: 79446 RVA: 0x002D263B File Offset: 0x002D083B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRedDotResponse);
		}

		// Token: 0x06013657 RID: 79447 RVA: 0x002D2649 File Offset: 0x002D0849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRedDotResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013658 RID: 79448 RVA: 0x002D2678 File Offset: 0x002D0878
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

		// Token: 0x06013659 RID: 79449 RVA: 0x002D26BD File Offset: 0x002D08BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601365A RID: 79450 RVA: 0x002D26CA File Offset: 0x002D08CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601365B RID: 79451 RVA: 0x002D26D3 File Offset: 0x002D08D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601365C RID: 79452 RVA: 0x002D2708 File Offset: 0x002D0908
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

		// Token: 0x0601365D RID: 79453 RVA: 0x002D2746 File Offset: 0x002D0946
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

		// Token: 0x0601365E RID: 79454 RVA: 0x002D2777 File Offset: 0x002D0977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601365F RID: 79455 RVA: 0x002D2780 File Offset: 0x002D0980
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400775B RID: 30555
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400775C RID: 30556
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x0400775D RID: 30557
		private ErrorCode errorId_;
	}
}
