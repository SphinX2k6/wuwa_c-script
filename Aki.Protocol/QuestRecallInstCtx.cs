using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E22 RID: 3618
	public sealed class QuestRecallInstCtx : IMessage<QuestRecallInstCtx>, IMessage, IEquatable<QuestRecallInstCtx>, IDeepCloneable<QuestRecallInstCtx>, IBufferMessage
	{
		// Token: 0x060136E5 RID: 79589 RVA: 0x002D330D File Offset: 0x002D150D
		[NullableContext(1)]
		public static QuestRecallInstCtx Create()
		{
			return new QuestRecallInstCtx();
		}

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x060136E6 RID: 79590 RVA: 0x002D3314 File Offset: 0x002D1514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x060136E7 RID: 79591 RVA: 0x002D3317 File Offset: 0x002D1517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRecallInstCtx.Descriptor;
			}
		}

		// Token: 0x060136E8 RID: 79592 RVA: 0x002D331E File Offset: 0x002D151E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstCtx()
		{
		}

		// Token: 0x060136E9 RID: 79593 RVA: 0x002D3326 File Offset: 0x002D1526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstCtx(QuestRecallInstCtx other) : this()
		{
			this.continue_ = other.continue_;
			this.recallId_ = other.recallId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136EA RID: 79594 RVA: 0x002D3357 File Offset: 0x002D1557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecallInstCtx Clone()
		{
			return new QuestRecallInstCtx(this);
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x060136EB RID: 79595 RVA: 0x002D335F File Offset: 0x002D155F
		// (set) Token: 0x060136EC RID: 79596 RVA: 0x002D3367 File Offset: 0x002D1567
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

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x060136ED RID: 79597 RVA: 0x002D3370 File Offset: 0x002D1570
		// (set) Token: 0x060136EE RID: 79598 RVA: 0x002D3378 File Offset: 0x002D1578
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

		// Token: 0x060136EF RID: 79599 RVA: 0x002D3381 File Offset: 0x002D1581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRecallInstCtx);
		}

		// Token: 0x060136F0 RID: 79600 RVA: 0x002D338F File Offset: 0x002D158F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRecallInstCtx other)
		{
			return other != null && (other == this || (this.Continue == other.Continue && this.RecallId == other.RecallId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136F1 RID: 79601 RVA: 0x002D33D0 File Offset: 0x002D15D0
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

		// Token: 0x060136F2 RID: 79602 RVA: 0x002D3428 File Offset: 0x002D1628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136F3 RID: 79603 RVA: 0x002D3435 File Offset: 0x002D1635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136F4 RID: 79604 RVA: 0x002D3440 File Offset: 0x002D1640
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

		// Token: 0x060136F5 RID: 79605 RVA: 0x002D3498 File Offset: 0x002D1698
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

		// Token: 0x060136F6 RID: 79606 RVA: 0x002D34E4 File Offset: 0x002D16E4
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

		// Token: 0x060136F7 RID: 79607 RVA: 0x002D3534 File Offset: 0x002D1734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136F8 RID: 79608 RVA: 0x002D3540 File Offset: 0x002D1740
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

		// Token: 0x0400771E RID: 30494
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400771F RID: 30495
		public const int ContinueFieldNumber = 1;

		// Token: 0x04007720 RID: 30496
		private bool continue_;

		// Token: 0x04007721 RID: 30497
		public const int RecallIdFieldNumber = 2;

		// Token: 0x04007722 RID: 30498
		private int recallId_;
	}
}
