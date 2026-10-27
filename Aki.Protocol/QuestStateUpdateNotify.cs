using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E30 RID: 3632
	[NetMessage(EMessageId.QuestStateUpdateNotify)]
	public sealed class QuestStateUpdateNotify : IMessage<QuestStateUpdateNotify>, IMessage, IEquatable<QuestStateUpdateNotify>, IDeepCloneable<QuestStateUpdateNotify>, IBufferMessage
	{
		// Token: 0x06013802 RID: 79874 RVA: 0x002D5779 File Offset: 0x002D3979
		[NullableContext(1)]
		public static QuestStateUpdateNotify Create()
		{
			return new QuestStateUpdateNotify();
		}

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x06013803 RID: 79875 RVA: 0x002D5780 File Offset: 0x002D3980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x06013804 RID: 79876 RVA: 0x002D5783 File Offset: 0x002D3983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestStateUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06013805 RID: 79877 RVA: 0x002D578A File Offset: 0x002D398A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestStateUpdateNotify()
		{
		}

		// Token: 0x06013806 RID: 79878 RVA: 0x002D5792 File Offset: 0x002D3992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestStateUpdateNotify(QuestStateUpdateNotify other) : this()
		{
			this.questId_ = other.questId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013807 RID: 79879 RVA: 0x002D57C3 File Offset: 0x002D39C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestStateUpdateNotify Clone()
		{
			return new QuestStateUpdateNotify(this);
		}

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x06013808 RID: 79880 RVA: 0x002D57CB File Offset: 0x002D39CB
		// (set) Token: 0x06013809 RID: 79881 RVA: 0x002D57D3 File Offset: 0x002D39D3
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

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x0601380A RID: 79882 RVA: 0x002D57DC File Offset: 0x002D39DC
		// (set) Token: 0x0601380B RID: 79883 RVA: 0x002D57E4 File Offset: 0x002D39E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0601380C RID: 79884 RVA: 0x002D57ED File Offset: 0x002D39ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestStateUpdateNotify);
		}

		// Token: 0x0601380D RID: 79885 RVA: 0x002D57FB File Offset: 0x002D39FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestStateUpdateNotify other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601380E RID: 79886 RVA: 0x002D583C File Offset: 0x002D3A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.State != QuestState.InActive)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601380F RID: 79887 RVA: 0x002D589A File Offset: 0x002D3A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013810 RID: 79888 RVA: 0x002D58A7 File Offset: 0x002D3AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013811 RID: 79889 RVA: 0x002D58B0 File Offset: 0x002D3AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != QuestState.InActive)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.State);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013812 RID: 79890 RVA: 0x002D590C File Offset: 0x002D3B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.State != QuestState.InActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013813 RID: 79891 RVA: 0x002D5964 File Offset: 0x002D3B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestStateUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.State != QuestState.InActive)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013814 RID: 79892 RVA: 0x002D59B4 File Offset: 0x002D3BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013815 RID: 79893 RVA: 0x002D59C0 File Offset: 0x002D3BC0
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
				if (num != 24U)
				{
					if (num != 56U)
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
					this.State = (QuestState)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400776E RID: 30574
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400776F RID: 30575
		public const int QuestIdFieldNumber = 7;

		// Token: 0x04007770 RID: 30576
		private int questId_;

		// Token: 0x04007771 RID: 30577
		public const int StateFieldNumber = 3;

		// Token: 0x04007772 RID: 30578
		private QuestState state_;
	}
}
