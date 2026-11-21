using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0E RID: 3598
	[NetMessage(EMessageId.QuestNpcMoveOverResponse)]
	public sealed class QuestNpcMoveOverResponse : IMessage<QuestNpcMoveOverResponse>, IMessage, IEquatable<QuestNpcMoveOverResponse>, IDeepCloneable<QuestNpcMoveOverResponse>, IBufferMessage
	{
		// Token: 0x060135B8 RID: 79288 RVA: 0x002D14D1 File Offset: 0x002CF6D1
		[NullableContext(1)]
		public static QuestNpcMoveOverResponse Create()
		{
			return new QuestNpcMoveOverResponse();
		}

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x060135B9 RID: 79289 RVA: 0x002D14D8 File Offset: 0x002CF6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x060135BA RID: 79290 RVA: 0x002D14DB File Offset: 0x002CF6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestNpcMoveOverResponse.Descriptor;
			}
		}

		// Token: 0x060135BB RID: 79291 RVA: 0x002D14E2 File Offset: 0x002CF6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverResponse()
		{
		}

		// Token: 0x060135BC RID: 79292 RVA: 0x002D14EA File Offset: 0x002CF6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverResponse(QuestNpcMoveOverResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135BD RID: 79293 RVA: 0x002D150F File Offset: 0x002CF70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverResponse Clone()
		{
			return new QuestNpcMoveOverResponse(this);
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x060135BE RID: 79294 RVA: 0x002D1517 File Offset: 0x002CF717
		// (set) Token: 0x060135BF RID: 79295 RVA: 0x002D151F File Offset: 0x002CF71F
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

		// Token: 0x060135C0 RID: 79296 RVA: 0x002D1528 File Offset: 0x002CF728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestNpcMoveOverResponse);
		}

		// Token: 0x060135C1 RID: 79297 RVA: 0x002D1536 File Offset: 0x002CF736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestNpcMoveOverResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135C2 RID: 79298 RVA: 0x002D1564 File Offset: 0x002CF764
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

		// Token: 0x060135C3 RID: 79299 RVA: 0x002D15A9 File Offset: 0x002CF7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135C4 RID: 79300 RVA: 0x002D15B6 File Offset: 0x002CF7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135C5 RID: 79301 RVA: 0x002D15BF File Offset: 0x002CF7BF
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

		// Token: 0x060135C6 RID: 79302 RVA: 0x002D15F4 File Offset: 0x002CF7F4
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

		// Token: 0x060135C7 RID: 79303 RVA: 0x002D1632 File Offset: 0x002CF832
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

		// Token: 0x060135C8 RID: 79304 RVA: 0x002D1663 File Offset: 0x002CF863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135C9 RID: 79305 RVA: 0x002D166C File Offset: 0x002CF86C
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

		// Token: 0x0400773B RID: 30523
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400773C RID: 30524
		public const int ErrorIdFieldNumber = 13;

		// Token: 0x0400773D RID: 30525
		private ErrorCode errorId_;
	}
}
