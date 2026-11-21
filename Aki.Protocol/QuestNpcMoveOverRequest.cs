using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0D RID: 3597
	[NetMessage(EMessageId.QuestNpcMoveOverRequest)]
	public sealed class QuestNpcMoveOverRequest : IMessage<QuestNpcMoveOverRequest>, IMessage, IEquatable<QuestNpcMoveOverRequest>, IDeepCloneable<QuestNpcMoveOverRequest>, IBufferMessage
	{
		// Token: 0x060135A6 RID: 79270 RVA: 0x002D12F9 File Offset: 0x002CF4F9
		[NullableContext(1)]
		public static QuestNpcMoveOverRequest Create()
		{
			return new QuestNpcMoveOverRequest();
		}

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x060135A7 RID: 79271 RVA: 0x002D1300 File Offset: 0x002CF500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x060135A8 RID: 79272 RVA: 0x002D1303 File Offset: 0x002CF503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestNpcMoveOverRequest.Descriptor;
			}
		}

		// Token: 0x060135A9 RID: 79273 RVA: 0x002D130A File Offset: 0x002CF50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverRequest()
		{
		}

		// Token: 0x060135AA RID: 79274 RVA: 0x002D1312 File Offset: 0x002CF512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverRequest(QuestNpcMoveOverRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135AB RID: 79275 RVA: 0x002D1337 File Offset: 0x002CF537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestNpcMoveOverRequest Clone()
		{
			return new QuestNpcMoveOverRequest(this);
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x060135AC RID: 79276 RVA: 0x002D133F File Offset: 0x002CF53F
		// (set) Token: 0x060135AD RID: 79277 RVA: 0x002D1347 File Offset: 0x002CF547
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

		// Token: 0x060135AE RID: 79278 RVA: 0x002D1350 File Offset: 0x002CF550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestNpcMoveOverRequest);
		}

		// Token: 0x060135AF RID: 79279 RVA: 0x002D135E File Offset: 0x002CF55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestNpcMoveOverRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135B0 RID: 79280 RVA: 0x002D138C File Offset: 0x002CF58C
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

		// Token: 0x060135B1 RID: 79281 RVA: 0x002D13CB File Offset: 0x002CF5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135B2 RID: 79282 RVA: 0x002D13D8 File Offset: 0x002CF5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135B3 RID: 79283 RVA: 0x002D13E1 File Offset: 0x002CF5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060135B4 RID: 79284 RVA: 0x002D1414 File Offset: 0x002CF614
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

		// Token: 0x060135B5 RID: 79285 RVA: 0x002D1452 File Offset: 0x002CF652
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

		// Token: 0x060135B6 RID: 79286 RVA: 0x002D1483 File Offset: 0x002CF683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135B7 RID: 79287 RVA: 0x002D148C File Offset: 0x002CF68C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007738 RID: 30520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007739 RID: 30521
		public const int EntityIdFieldNumber = 9;

		// Token: 0x0400773A RID: 30522
		private long entityId_;
	}
}
