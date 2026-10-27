using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E23 RID: 3619
	public sealed class QuestRecallInstMarkCtx : IMessage<QuestRecallInstMarkCtx>, IMessage, IEquatable<QuestRecallInstMarkCtx>, IDeepCloneable<QuestRecallInstMarkCtx>, IBufferMessage
	{
		// Token: 0x060136F9 RID: 79609 RVA: 0x002D3597 File Offset: 0x002D1797
		[NullableContext(1)]
		public static QuestRecallInstMarkCtx Create()
		{
			return new QuestRecallInstMarkCtx();
		}

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x060136FA RID: 79610 RVA: 0x002D359E File Offset: 0x002D179E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x060136FB RID: 79611 RVA: 0x002D35A1 File Offset: 0x002D17A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRecallInstMarkCtx.Descriptor;
			}
		}

		// Token: 0x060136FC RID: 79612 RVA: 0x002D35A8 File Offset: 0x002D17A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstMarkCtx()
		{
		}

		// Token: 0x060136FD RID: 79613 RVA: 0x002D35B0 File Offset: 0x002D17B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstMarkCtx(QuestRecallInstMarkCtx other) : this()
		{
			this.recallId_ = other.recallId_;
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136FE RID: 79614 RVA: 0x002D35E1 File Offset: 0x002D17E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstMarkCtx Clone()
		{
			return new QuestRecallInstMarkCtx(this);
		}

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x060136FF RID: 79615 RVA: 0x002D35E9 File Offset: 0x002D17E9
		// (set) Token: 0x06013700 RID: 79616 RVA: 0x002D35F1 File Offset: 0x002D17F1
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

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x06013701 RID: 79617 RVA: 0x002D35FA File Offset: 0x002D17FA
		// (set) Token: 0x06013702 RID: 79618 RVA: 0x002D3602 File Offset: 0x002D1802
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

		// Token: 0x06013703 RID: 79619 RVA: 0x002D360B File Offset: 0x002D180B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRecallInstMarkCtx);
		}

		// Token: 0x06013704 RID: 79620 RVA: 0x002D3619 File Offset: 0x002D1819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRecallInstMarkCtx other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013705 RID: 79621 RVA: 0x002D3658 File Offset: 0x002D1858
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

		// Token: 0x06013706 RID: 79622 RVA: 0x002D36B0 File Offset: 0x002D18B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013707 RID: 79623 RVA: 0x002D36BD File Offset: 0x002D18BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013708 RID: 79624 RVA: 0x002D36C8 File Offset: 0x002D18C8
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

		// Token: 0x06013709 RID: 79625 RVA: 0x002D3720 File Offset: 0x002D1920
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

		// Token: 0x0601370A RID: 79626 RVA: 0x002D3778 File Offset: 0x002D1978
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

		// Token: 0x0601370B RID: 79627 RVA: 0x002D37C8 File Offset: 0x002D19C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601370C RID: 79628 RVA: 0x002D37D4 File Offset: 0x002D19D4
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

		// Token: 0x04007723 RID: 30499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007724 RID: 30500
		public const int RecallIdFieldNumber = 1;

		// Token: 0x04007725 RID: 30501
		private int recallId_;

		// Token: 0x04007726 RID: 30502
		public const int MarkIdFieldNumber = 2;

		// Token: 0x04007727 RID: 30503
		private int markId_;
	}
}
