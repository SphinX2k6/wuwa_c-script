using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E16 RID: 3606
	[NetMessage(EMessageId.QuestFocusInfoNotify)]
	public sealed class QuestFocusInfoNotify : IMessage<QuestFocusInfoNotify>, IMessage, IEquatable<QuestFocusInfoNotify>, IDeepCloneable<QuestFocusInfoNotify>, IBufferMessage
	{
		// Token: 0x060135FB RID: 79355 RVA: 0x002D17E5 File Offset: 0x002CF9E5
		[NullableContext(1)]
		public static QuestFocusInfoNotify Create()
		{
			return new QuestFocusInfoNotify();
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x060135FC RID: 79356 RVA: 0x002D17EC File Offset: 0x002CF9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x060135FD RID: 79357 RVA: 0x002D17EF File Offset: 0x002CF9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFocusInfoNotify.Descriptor;
			}
		}

		// Token: 0x060135FE RID: 79358 RVA: 0x002D17F6 File Offset: 0x002CF9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFocusInfoNotify()
		{
		}

		// Token: 0x060135FF RID: 79359 RVA: 0x002D17FE File Offset: 0x002CF9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFocusInfoNotify(QuestFocusInfoNotify other) : this()
		{
			this.focusQuestId_ = other.focusQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013600 RID: 79360 RVA: 0x002D1823 File Offset: 0x002CFA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFocusInfoNotify Clone()
		{
			return new QuestFocusInfoNotify(this);
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x06013601 RID: 79361 RVA: 0x002D182B File Offset: 0x002CFA2B
		// (set) Token: 0x06013602 RID: 79362 RVA: 0x002D1833 File Offset: 0x002CFA33
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

		// Token: 0x06013603 RID: 79363 RVA: 0x002D183C File Offset: 0x002CFA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFocusInfoNotify);
		}

		// Token: 0x06013604 RID: 79364 RVA: 0x002D184A File Offset: 0x002CFA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFocusInfoNotify other)
		{
			return other != null && (other == this || (this.FocusQuestId == other.FocusQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013605 RID: 79365 RVA: 0x002D1878 File Offset: 0x002CFA78
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

		// Token: 0x06013606 RID: 79366 RVA: 0x002D18B7 File Offset: 0x002CFAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013607 RID: 79367 RVA: 0x002D18C4 File Offset: 0x002CFAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013608 RID: 79368 RVA: 0x002D18CD File Offset: 0x002CFACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FocusQuestId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FocusQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013609 RID: 79369 RVA: 0x002D1900 File Offset: 0x002CFB00
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

		// Token: 0x0601360A RID: 79370 RVA: 0x002D193E File Offset: 0x002CFB3E
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

		// Token: 0x0601360B RID: 79371 RVA: 0x002D196F File Offset: 0x002CFB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601360C RID: 79372 RVA: 0x002D1978 File Offset: 0x002CFB78
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FocusQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040076E7 RID: 30439
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076E8 RID: 30440
		public const int FocusQuestIdFieldNumber = 13;

		// Token: 0x040076E9 RID: 30441
		private int focusQuestId_;
	}
}
