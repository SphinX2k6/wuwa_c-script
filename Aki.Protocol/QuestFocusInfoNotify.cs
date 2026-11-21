using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E06 RID: 3590
	[NetMessage(EMessageId.QuestFocusInfoNotify)]
	public sealed class QuestFocusInfoNotify : IMessage<QuestFocusInfoNotify>, IMessage, IEquatable<QuestFocusInfoNotify>, IDeepCloneable<QuestFocusInfoNotify>, IBufferMessage
	{
		// Token: 0x06013516 RID: 79126 RVA: 0x002D0125 File Offset: 0x002CE325
		[NullableContext(1)]
		public static QuestFocusInfoNotify Create()
		{
			return new QuestFocusInfoNotify();
		}

		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x06013517 RID: 79127 RVA: 0x002D012C File Offset: 0x002CE32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x06013518 RID: 79128 RVA: 0x002D012F File Offset: 0x002CE32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFocusInfoNotify.Descriptor;
			}
		}

		// Token: 0x06013519 RID: 79129 RVA: 0x002D0136 File Offset: 0x002CE336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFocusInfoNotify()
		{
		}

		// Token: 0x0601351A RID: 79130 RVA: 0x002D013E File Offset: 0x002CE33E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFocusInfoNotify(QuestFocusInfoNotify other) : this()
		{
			this.focusQuestId_ = other.focusQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601351B RID: 79131 RVA: 0x002D0163 File Offset: 0x002CE363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFocusInfoNotify Clone()
		{
			return new QuestFocusInfoNotify(this);
		}

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x0601351C RID: 79132 RVA: 0x002D016B File Offset: 0x002CE36B
		// (set) Token: 0x0601351D RID: 79133 RVA: 0x002D0173 File Offset: 0x002CE373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FocusQuestId
		{
			get
			{
				return this.focusQuestId_;
			}
			set
			{
				this.focusQuestId_ = value;
			}
		}

		// Token: 0x0601351E RID: 79134 RVA: 0x002D017C File Offset: 0x002CE37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFocusInfoNotify);
		}

		// Token: 0x0601351F RID: 79135 RVA: 0x002D018A File Offset: 0x002CE38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFocusInfoNotify other)
		{
			return other != null && (other == this || (this.FocusQuestId == other.FocusQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013520 RID: 79136 RVA: 0x002D01B8 File Offset: 0x002CE3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FocusQuestId != 0)
			{
				num ^= this.FocusQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013521 RID: 79137 RVA: 0x002D01F7 File Offset: 0x002CE3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013522 RID: 79138 RVA: 0x002D0204 File Offset: 0x002CE404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013523 RID: 79139 RVA: 0x002D020D File Offset: 0x002CE40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FocusQuestId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FocusQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013524 RID: 79140 RVA: 0x002D0240 File Offset: 0x002CE440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FocusQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FocusQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013525 RID: 79141 RVA: 0x002D027E File Offset: 0x002CE47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFocusInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FocusQuestId != 0)
			{
				this.FocusQuestId = other.FocusQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013526 RID: 79142 RVA: 0x002D02AF File Offset: 0x002CE4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013527 RID: 79143 RVA: 0x002D02B8 File Offset: 0x002CE4B8
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
					this.FocusQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007711 RID: 30481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007712 RID: 30482
		public const int FocusQuestIdFieldNumber = 9;

		// Token: 0x04007713 RID: 30483
		private int focusQuestId_;
	}
}
