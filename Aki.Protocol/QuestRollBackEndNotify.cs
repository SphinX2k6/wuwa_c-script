using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2E RID: 3630
	[NetMessage(EMessageId.QuestRollBackEndNotify)]
	public sealed class QuestRollBackEndNotify : IMessage<QuestRollBackEndNotify>, IMessage, IEquatable<QuestRollBackEndNotify>, IDeepCloneable<QuestRollBackEndNotify>, IBufferMessage
	{
		// Token: 0x060137DC RID: 79836 RVA: 0x002D52FF File Offset: 0x002D34FF
		[NullableContext(1)]
		public static QuestRollBackEndNotify Create()
		{
			return new QuestRollBackEndNotify();
		}

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x060137DD RID: 79837 RVA: 0x002D5306 File Offset: 0x002D3506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x060137DE RID: 79838 RVA: 0x002D5309 File Offset: 0x002D3509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRollBackEndNotify.Descriptor;
			}
		}

		// Token: 0x060137DF RID: 79839 RVA: 0x002D5310 File Offset: 0x002D3510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRollBackEndNotify()
		{
		}

		// Token: 0x060137E0 RID: 79840 RVA: 0x002D5318 File Offset: 0x002D3518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRollBackEndNotify(QuestRollBackEndNotify other) : this()
		{
			this.questId_ = other.questId_;
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060137E1 RID: 79841 RVA: 0x002D5349 File Offset: 0x002D3549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRollBackEndNotify Clone()
		{
			return new QuestRollBackEndNotify(this);
		}

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x060137E2 RID: 79842 RVA: 0x002D5351 File Offset: 0x002D3551
		// (set) Token: 0x060137E3 RID: 79843 RVA: 0x002D5359 File Offset: 0x002D3559
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

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x060137E4 RID: 79844 RVA: 0x002D5362 File Offset: 0x002D3562
		// (set) Token: 0x060137E5 RID: 79845 RVA: 0x002D536A File Offset: 0x002D356A
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

		// Token: 0x060137E6 RID: 79846 RVA: 0x002D5373 File Offset: 0x002D3573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRollBackEndNotify);
		}

		// Token: 0x060137E7 RID: 79847 RVA: 0x002D5381 File Offset: 0x002D3581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRollBackEndNotify other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137E8 RID: 79848 RVA: 0x002D53C0 File Offset: 0x002D35C0
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

		// Token: 0x060137E9 RID: 79849 RVA: 0x002D5418 File Offset: 0x002D3618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137EA RID: 79850 RVA: 0x002D5425 File Offset: 0x002D3625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137EB RID: 79851 RVA: 0x002D5430 File Offset: 0x002D3630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060137EC RID: 79852 RVA: 0x002D548C File Offset: 0x002D368C
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

		// Token: 0x060137ED RID: 79853 RVA: 0x002D54E4 File Offset: 0x002D36E4
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

		// Token: 0x060137EE RID: 79854 RVA: 0x002D5534 File Offset: 0x002D3734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060137EF RID: 79855 RVA: 0x002D5540 File Offset: 0x002D3740
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
				if (num != 56U)
				{
					if (num != 80U)
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

		// Token: 0x04007765 RID: 30565
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007766 RID: 30566
		public const int QuestIdFieldNumber = 10;

		// Token: 0x04007767 RID: 30567
		private int questId_;

		// Token: 0x04007768 RID: 30568
		public const int TreeIncIdFieldNumber = 7;

		// Token: 0x04007769 RID: 30569
		private long treeIncId_;
	}
}
