using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E12 RID: 3602
	[NetMessage(EMessageId.QuestFinishActionEndResponse)]
	public sealed class QuestFinishActionEndResponse : IMessage<QuestFinishActionEndResponse>, IMessage, IEquatable<QuestFinishActionEndResponse>, IDeepCloneable<QuestFinishActionEndResponse>, IBufferMessage
	{
		// Token: 0x060135AD RID: 79277 RVA: 0x002D0E40 File Offset: 0x002CF040
		[NullableContext(1)]
		public static QuestFinishActionEndResponse Create()
		{
			return new QuestFinishActionEndResponse();
		}

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x060135AE RID: 79278 RVA: 0x002D0E47 File Offset: 0x002CF047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x060135AF RID: 79279 RVA: 0x002D0E4A File Offset: 0x002CF04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionEndResponse.Descriptor;
			}
		}

		// Token: 0x060135B0 RID: 79280 RVA: 0x002D0E51 File Offset: 0x002CF051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndResponse()
		{
		}

		// Token: 0x060135B1 RID: 79281 RVA: 0x002D0E59 File Offset: 0x002CF059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndResponse(QuestFinishActionEndResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135B2 RID: 79282 RVA: 0x002D0E7E File Offset: 0x002CF07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionEndResponse Clone()
		{
			return new QuestFinishActionEndResponse(this);
		}

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x060135B3 RID: 79283 RVA: 0x002D0E86 File Offset: 0x002CF086
		// (set) Token: 0x060135B4 RID: 79284 RVA: 0x002D0E8E File Offset: 0x002CF08E
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

		// Token: 0x060135B5 RID: 79285 RVA: 0x002D0E97 File Offset: 0x002CF097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionEndResponse);
		}

		// Token: 0x060135B6 RID: 79286 RVA: 0x002D0EA5 File Offset: 0x002CF0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionEndResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135B7 RID: 79287 RVA: 0x002D0ED4 File Offset: 0x002CF0D4
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

		// Token: 0x060135B8 RID: 79288 RVA: 0x002D0F19 File Offset: 0x002CF119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135B9 RID: 79289 RVA: 0x002D0F26 File Offset: 0x002CF126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135BA RID: 79290 RVA: 0x002D0F2F File Offset: 0x002CF12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060135BB RID: 79291 RVA: 0x002D0F64 File Offset: 0x002CF164
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

		// Token: 0x060135BC RID: 79292 RVA: 0x002D0FA2 File Offset: 0x002CF1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFinishActionEndResponse other)
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

		// Token: 0x060135BD RID: 79293 RVA: 0x002D0FD3 File Offset: 0x002CF1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135BE RID: 79294 RVA: 0x002D0FDC File Offset: 0x002CF1DC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076D4 RID: 30420
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076D5 RID: 30421
		public const int ErrorIdFieldNumber = 13;

		// Token: 0x040076D6 RID: 30422
		private ErrorCode errorId_;
	}
}
