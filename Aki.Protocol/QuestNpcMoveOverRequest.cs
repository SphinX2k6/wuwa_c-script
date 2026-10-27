using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1D RID: 3613
	[NetMessage(EMessageId.QuestNpcMoveOverRequest)]
	public sealed class QuestNpcMoveOverRequest : IMessage<QuestNpcMoveOverRequest>, IMessage, IEquatable<QuestNpcMoveOverRequest>, IDeepCloneable<QuestNpcMoveOverRequest>, IBufferMessage
	{
		// Token: 0x0601368B RID: 79499 RVA: 0x002D29BD File Offset: 0x002D0BBD
		[NullableContext(1)]
		public static QuestNpcMoveOverRequest Create()
		{
			return new QuestNpcMoveOverRequest();
		}

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x0601368C RID: 79500 RVA: 0x002D29C4 File Offset: 0x002D0BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x0601368D RID: 79501 RVA: 0x002D29C7 File Offset: 0x002D0BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestNpcMoveOverRequest.Descriptor;
			}
		}

		// Token: 0x0601368E RID: 79502 RVA: 0x002D29CE File Offset: 0x002D0BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverRequest()
		{
		}

		// Token: 0x0601368F RID: 79503 RVA: 0x002D29D6 File Offset: 0x002D0BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverRequest(QuestNpcMoveOverRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013690 RID: 79504 RVA: 0x002D29FB File Offset: 0x002D0BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverRequest Clone()
		{
			return new QuestNpcMoveOverRequest(this);
		}

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x06013691 RID: 79505 RVA: 0x002D2A03 File Offset: 0x002D0C03
		// (set) Token: 0x06013692 RID: 79506 RVA: 0x002D2A0B File Offset: 0x002D0C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06013693 RID: 79507 RVA: 0x002D2A14 File Offset: 0x002D0C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestNpcMoveOverRequest);
		}

		// Token: 0x06013694 RID: 79508 RVA: 0x002D2A22 File Offset: 0x002D0C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestNpcMoveOverRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013695 RID: 79509 RVA: 0x002D2A50 File Offset: 0x002D0C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013696 RID: 79510 RVA: 0x002D2A8F File Offset: 0x002D0C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013697 RID: 79511 RVA: 0x002D2A9C File Offset: 0x002D0C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013698 RID: 79512 RVA: 0x002D2AA5 File Offset: 0x002D0CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013699 RID: 79513 RVA: 0x002D2AD8 File Offset: 0x002D0CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601369A RID: 79514 RVA: 0x002D2B16 File Offset: 0x002D0D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestNpcMoveOverRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601369B RID: 79515 RVA: 0x002D2B47 File Offset: 0x002D0D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601369C RID: 79516 RVA: 0x002D2B50 File Offset: 0x002D0D50
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400770E RID: 30478
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400770F RID: 30479
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04007710 RID: 30480
		private long entityId_;
	}
}
