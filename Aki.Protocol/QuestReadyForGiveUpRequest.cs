using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1F RID: 3615
	[NetMessage(EMessageId.QuestReadyForGiveUpRequest)]
	public sealed class QuestReadyForGiveUpRequest : IMessage<QuestReadyForGiveUpRequest>, IMessage, IEquatable<QuestReadyForGiveUpRequest>, IDeepCloneable<QuestReadyForGiveUpRequest>, IBufferMessage
	{
		// Token: 0x060136AF RID: 79535 RVA: 0x002D2D75 File Offset: 0x002D0F75
		[NullableContext(1)]
		public static QuestReadyForGiveUpRequest Create()
		{
			return new QuestReadyForGiveUpRequest();
		}

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x060136B0 RID: 79536 RVA: 0x002D2D7C File Offset: 0x002D0F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x060136B1 RID: 79537 RVA: 0x002D2D7F File Offset: 0x002D0F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReadyForGiveUpRequest.Descriptor;
			}
		}

		// Token: 0x060136B2 RID: 79538 RVA: 0x002D2D86 File Offset: 0x002D0F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpRequest()
		{
		}

		// Token: 0x060136B3 RID: 79539 RVA: 0x002D2D8E File Offset: 0x002D0F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpRequest(QuestReadyForGiveUpRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136B4 RID: 79540 RVA: 0x002D2DB3 File Offset: 0x002D0FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpRequest Clone()
		{
			return new QuestReadyForGiveUpRequest(this);
		}

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x060136B5 RID: 79541 RVA: 0x002D2DBB File Offset: 0x002D0FBB
		// (set) Token: 0x060136B6 RID: 79542 RVA: 0x002D2DC3 File Offset: 0x002D0FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x060136B7 RID: 79543 RVA: 0x002D2DCC File Offset: 0x002D0FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReadyForGiveUpRequest);
		}

		// Token: 0x060136B8 RID: 79544 RVA: 0x002D2DDA File Offset: 0x002D0FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReadyForGiveUpRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136B9 RID: 79545 RVA: 0x002D2E08 File Offset: 0x002D1008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060136BA RID: 79546 RVA: 0x002D2E47 File Offset: 0x002D1047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136BB RID: 79547 RVA: 0x002D2E54 File Offset: 0x002D1054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136BC RID: 79548 RVA: 0x002D2E5D File Offset: 0x002D105D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060136BD RID: 79549 RVA: 0x002D2E90 File Offset: 0x002D1090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060136BE RID: 79550 RVA: 0x002D2ECE File Offset: 0x002D10CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReadyForGiveUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060136BF RID: 79551 RVA: 0x002D2EFF File Offset: 0x002D10FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136C0 RID: 79552 RVA: 0x002D2F08 File Offset: 0x002D1108
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007714 RID: 30484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007715 RID: 30485
		public const int QuestIdFieldNumber = 8;

		// Token: 0x04007716 RID: 30486
		private int questId_;
	}
}
