using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1E RID: 3614
	[NetMessage(EMessageId.QuestRollBackEndNotify)]
	public sealed class QuestRollBackEndNotify : IMessage<QuestRollBackEndNotify>, IMessage, IEquatable<QuestRollBackEndNotify>, IDeepCloneable<QuestRollBackEndNotify>, IBufferMessage
	{
		// Token: 0x060136F7 RID: 79607 RVA: 0x002D3C3B File Offset: 0x002D1E3B
		[NullableContext(1)]
		public static QuestRollBackEndNotify Create()
		{
			return new QuestRollBackEndNotify();
		}

		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x060136F8 RID: 79608 RVA: 0x002D3C42 File Offset: 0x002D1E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x060136F9 RID: 79609 RVA: 0x002D3C45 File Offset: 0x002D1E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRollBackEndNotify.Descriptor;
			}
		}

		// Token: 0x060136FA RID: 79610 RVA: 0x002D3C4C File Offset: 0x002D1E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRollBackEndNotify()
		{
		}

		// Token: 0x060136FB RID: 79611 RVA: 0x002D3C54 File Offset: 0x002D1E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRollBackEndNotify(QuestRollBackEndNotify other) : this()
		{
			this.questId_ = other.questId_;
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136FC RID: 79612 RVA: 0x002D3C85 File Offset: 0x002D1E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRollBackEndNotify Clone()
		{
			return new QuestRollBackEndNotify(this);
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x060136FD RID: 79613 RVA: 0x002D3C8D File Offset: 0x002D1E8D
		// (set) Token: 0x060136FE RID: 79614 RVA: 0x002D3C95 File Offset: 0x002D1E95
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

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x060136FF RID: 79615 RVA: 0x002D3C9E File Offset: 0x002D1E9E
		// (set) Token: 0x06013700 RID: 79616 RVA: 0x002D3CA6 File Offset: 0x002D1EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x06013701 RID: 79617 RVA: 0x002D3CAF File Offset: 0x002D1EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRollBackEndNotify);
		}

		// Token: 0x06013702 RID: 79618 RVA: 0x002D3CBD File Offset: 0x002D1EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRollBackEndNotify other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013703 RID: 79619 RVA: 0x002D3CFC File Offset: 0x002D1EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013704 RID: 79620 RVA: 0x002D3D54 File Offset: 0x002D1F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013705 RID: 79621 RVA: 0x002D3D61 File Offset: 0x002D1F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013706 RID: 79622 RVA: 0x002D3D6C File Offset: 0x002D1F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013707 RID: 79623 RVA: 0x002D3DC4 File Offset: 0x002D1FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013708 RID: 79624 RVA: 0x002D3E1C File Offset: 0x002D201C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRollBackEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013709 RID: 79625 RVA: 0x002D3E6C File Offset: 0x002D206C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601370A RID: 79626 RVA: 0x002D3E78 File Offset: 0x002D2078
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.QuestId = input.ReadInt32();
					}
				}
				else
				{
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400778F RID: 30607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007790 RID: 30608
		public const int QuestIdFieldNumber = 5;

		// Token: 0x04007791 RID: 30609
		private int questId_;

		// Token: 0x04007792 RID: 30610
		public const int TreeIncIdFieldNumber = 1;

		// Token: 0x04007793 RID: 30611
		private long treeIncId_;
	}
}
