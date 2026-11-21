using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E12 RID: 3602
	public sealed class QuestRecallInstCtx : IMessage<QuestRecallInstCtx>, IMessage, IEquatable<QuestRecallInstCtx>, IDeepCloneable<QuestRecallInstCtx>, IBufferMessage
	{
		// Token: 0x06013600 RID: 79360 RVA: 0x002D1C49 File Offset: 0x002CFE49
		[NullableContext(1)]
		public static QuestRecallInstCtx Create()
		{
			return new QuestRecallInstCtx();
		}

		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x06013601 RID: 79361 RVA: 0x002D1C50 File Offset: 0x002CFE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x06013602 RID: 79362 RVA: 0x002D1C53 File Offset: 0x002CFE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRecallInstCtx.Descriptor;
			}
		}

		// Token: 0x06013603 RID: 79363 RVA: 0x002D1C5A File Offset: 0x002CFE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstCtx()
		{
		}

		// Token: 0x06013604 RID: 79364 RVA: 0x002D1C62 File Offset: 0x002CFE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstCtx(QuestRecallInstCtx other) : this()
		{
			this.continue_ = other.continue_;
			this.recallId_ = other.recallId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013605 RID: 79365 RVA: 0x002D1C93 File Offset: 0x002CFE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstCtx Clone()
		{
			return new QuestRecallInstCtx(this);
		}

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x06013606 RID: 79366 RVA: 0x002D1C9B File Offset: 0x002CFE9B
		// (set) Token: 0x06013607 RID: 79367 RVA: 0x002D1CA3 File Offset: 0x002CFEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Continue
		{
			get
			{
				return this.continue_;
			}
			set
			{
				this.continue_ = value;
			}
		}

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x06013608 RID: 79368 RVA: 0x002D1CAC File Offset: 0x002CFEAC
		// (set) Token: 0x06013609 RID: 79369 RVA: 0x002D1CB4 File Offset: 0x002CFEB4
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

		// Token: 0x0601360A RID: 79370 RVA: 0x002D1CBD File Offset: 0x002CFEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRecallInstCtx);
		}

		// Token: 0x0601360B RID: 79371 RVA: 0x002D1CCB File Offset: 0x002CFECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRecallInstCtx other)
		{
			return other != null && (other == this || (this.Continue == other.Continue && this.RecallId == other.RecallId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601360C RID: 79372 RVA: 0x002D1D0C File Offset: 0x002CFF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Continue)
			{
				num ^= this.Continue.GetHashCode();
			}
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601360D RID: 79373 RVA: 0x002D1D64 File Offset: 0x002CFF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601360E RID: 79374 RVA: 0x002D1D71 File Offset: 0x002CFF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601360F RID: 79375 RVA: 0x002D1D7C File Offset: 0x002CFF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Continue)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Continue);
			}
			if (this.RecallId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013610 RID: 79376 RVA: 0x002D1DD4 File Offset: 0x002CFFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Continue)
			{
				num += 2;
			}
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013611 RID: 79377 RVA: 0x002D1E20 File Offset: 0x002D0020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRecallInstCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Continue)
			{
				this.Continue = other.Continue;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013612 RID: 79378 RVA: 0x002D1E70 File Offset: 0x002D0070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013613 RID: 79379 RVA: 0x002D1E7C File Offset: 0x002D007C
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
						this.RecallId = input.ReadInt32();
					}
				}
				else
				{
					this.Continue = input.ReadBool();
				}
			}
		}

		// Token: 0x04007748 RID: 30536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007749 RID: 30537
		public const int ContinueFieldNumber = 1;

		// Token: 0x0400774A RID: 30538
		private bool continue_;

		// Token: 0x0400774B RID: 30539
		public const int RecallIdFieldNumber = 2;

		// Token: 0x0400774C RID: 30540
		private int recallId_;
	}
}
