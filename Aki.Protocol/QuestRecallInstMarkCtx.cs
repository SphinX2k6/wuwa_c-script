using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E13 RID: 3603
	public sealed class QuestRecallInstMarkCtx : IMessage<QuestRecallInstMarkCtx>, IMessage, IEquatable<QuestRecallInstMarkCtx>, IDeepCloneable<QuestRecallInstMarkCtx>, IBufferMessage
	{
		// Token: 0x06013614 RID: 79380 RVA: 0x002D1ED3 File Offset: 0x002D00D3
		[NullableContext(1)]
		public static QuestRecallInstMarkCtx Create()
		{
			return new QuestRecallInstMarkCtx();
		}

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x06013615 RID: 79381 RVA: 0x002D1EDA File Offset: 0x002D00DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x06013616 RID: 79382 RVA: 0x002D1EDD File Offset: 0x002D00DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRecallInstMarkCtx.Descriptor;
			}
		}

		// Token: 0x06013617 RID: 79383 RVA: 0x002D1EE4 File Offset: 0x002D00E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstMarkCtx()
		{
		}

		// Token: 0x06013618 RID: 79384 RVA: 0x002D1EEC File Offset: 0x002D00EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstMarkCtx(QuestRecallInstMarkCtx other) : this()
		{
			this.recallId_ = other.recallId_;
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013619 RID: 79385 RVA: 0x002D1F1D File Offset: 0x002D011D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstMarkCtx Clone()
		{
			return new QuestRecallInstMarkCtx(this);
		}

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x0601361A RID: 79386 RVA: 0x002D1F25 File Offset: 0x002D0125
		// (set) Token: 0x0601361B RID: 79387 RVA: 0x002D1F2D File Offset: 0x002D012D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x0601361C RID: 79388 RVA: 0x002D1F36 File Offset: 0x002D0136
		// (set) Token: 0x0601361D RID: 79389 RVA: 0x002D1F3E File Offset: 0x002D013E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0601361E RID: 79390 RVA: 0x002D1F47 File Offset: 0x002D0147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRecallInstMarkCtx);
		}

		// Token: 0x0601361F RID: 79391 RVA: 0x002D1F55 File Offset: 0x002D0155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRecallInstMarkCtx other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013620 RID: 79392 RVA: 0x002D1F94 File Offset: 0x002D0194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013621 RID: 79393 RVA: 0x002D1FEC File Offset: 0x002D01EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013622 RID: 79394 RVA: 0x002D1FF9 File Offset: 0x002D01F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013623 RID: 79395 RVA: 0x002D2004 File Offset: 0x002D0204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallId);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013624 RID: 79396 RVA: 0x002D205C File Offset: 0x002D025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013625 RID: 79397 RVA: 0x002D20B4 File Offset: 0x002D02B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRecallInstMarkCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013626 RID: 79398 RVA: 0x002D2104 File Offset: 0x002D0304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013627 RID: 79399 RVA: 0x002D2110 File Offset: 0x002D0310
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MarkId = input.ReadInt32();
					}
				}
				else
				{
					this.RecallId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400774D RID: 30541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400774E RID: 30542
		public const int RecallIdFieldNumber = 1;

		// Token: 0x0400774F RID: 30543
		private int recallId_;

		// Token: 0x04007750 RID: 30544
		public const int MarkIdFieldNumber = 2;

		// Token: 0x04007751 RID: 30545
		private int markId_;
	}
}
