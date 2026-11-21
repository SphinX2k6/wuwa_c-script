using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E20 RID: 3616
	[NetMessage(EMessageId.QuestStateUpdateNotify)]
	public sealed class QuestStateUpdateNotify : IMessage<QuestStateUpdateNotify>, IMessage, IEquatable<QuestStateUpdateNotify>, IDeepCloneable<QuestStateUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601371D RID: 79645 RVA: 0x002D40B1 File Offset: 0x002D22B1
		[NullableContext(1)]
		public static QuestStateUpdateNotify Create()
		{
			return new QuestStateUpdateNotify();
		}

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x0601371E RID: 79646 RVA: 0x002D40B8 File Offset: 0x002D22B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x0601371F RID: 79647 RVA: 0x002D40BB File Offset: 0x002D22BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestStateUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06013720 RID: 79648 RVA: 0x002D40C2 File Offset: 0x002D22C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestStateUpdateNotify()
		{
		}

		// Token: 0x06013721 RID: 79649 RVA: 0x002D40CA File Offset: 0x002D22CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestStateUpdateNotify(QuestStateUpdateNotify other) : this()
		{
			this.questId_ = other.questId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013722 RID: 79650 RVA: 0x002D40FB File Offset: 0x002D22FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestStateUpdateNotify Clone()
		{
			return new QuestStateUpdateNotify(this);
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x06013723 RID: 79651 RVA: 0x002D4103 File Offset: 0x002D2303
		// (set) Token: 0x06013724 RID: 79652 RVA: 0x002D410B File Offset: 0x002D230B
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

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x06013725 RID: 79653 RVA: 0x002D4114 File Offset: 0x002D2314
		// (set) Token: 0x06013726 RID: 79654 RVA: 0x002D411C File Offset: 0x002D231C
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

		// Token: 0x06013727 RID: 79655 RVA: 0x002D4125 File Offset: 0x002D2325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestStateUpdateNotify);
		}

		// Token: 0x06013728 RID: 79656 RVA: 0x002D4133 File Offset: 0x002D2333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestStateUpdateNotify other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013729 RID: 79657 RVA: 0x002D4174 File Offset: 0x002D2374
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

		// Token: 0x0601372A RID: 79658 RVA: 0x002D41D2 File Offset: 0x002D23D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601372B RID: 79659 RVA: 0x002D41DF File Offset: 0x002D23DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601372C RID: 79660 RVA: 0x002D41E8 File Offset: 0x002D23E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != QuestState.InActive)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.State);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601372D RID: 79661 RVA: 0x002D4244 File Offset: 0x002D2444
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

		// Token: 0x0601372E RID: 79662 RVA: 0x002D429C File Offset: 0x002D249C
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

		// Token: 0x0601372F RID: 79663 RVA: 0x002D42EC File Offset: 0x002D24EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013730 RID: 79664 RVA: 0x002D42F8 File Offset: 0x002D24F8
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
				if (num != 32U)
				{
					if (num != 120U)
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

		// Token: 0x04007798 RID: 30616
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007799 RID: 30617
		public const int QuestIdFieldNumber = 15;

		// Token: 0x0400779A RID: 30618
		private int questId_;

		// Token: 0x0400779B RID: 30619
		public const int StateFieldNumber = 4;

		// Token: 0x0400779C RID: 30620
		private QuestState state_;
	}
}
