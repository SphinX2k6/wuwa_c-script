using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E22 RID: 3618
	public sealed class QuestTimerNotify : IMessage<QuestTimerNotify>, IMessage, IEquatable<QuestTimerNotify>, IDeepCloneable<QuestTimerNotify>, IBufferMessage
	{
		// Token: 0x06013747 RID: 79687 RVA: 0x002D4607 File Offset: 0x002D2807
		[NullableContext(1)]
		public static QuestTimerNotify Create()
		{
			return new QuestTimerNotify();
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x06013748 RID: 79688 RVA: 0x002D460E File Offset: 0x002D280E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x06013749 RID: 79689 RVA: 0x002D4611 File Offset: 0x002D2811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTimerNotify.Descriptor;
			}
		}

		// Token: 0x0601374A RID: 79690 RVA: 0x002D4618 File Offset: 0x002D2818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimerNotify()
		{
		}

		// Token: 0x0601374B RID: 79691 RVA: 0x002D462B File Offset: 0x002D282B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimerNotify(QuestTimerNotify other) : this()
		{
			this.questTimers_ = other.questTimers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601374C RID: 79692 RVA: 0x002D4655 File Offset: 0x002D2855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimerNotify Clone()
		{
			return new QuestTimerNotify(this);
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x0601374D RID: 79693 RVA: 0x002D465D File Offset: 0x002D285D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, QuestTimer> QuestTimers
		{
			get
			{
				return this.questTimers_;
			}
		}

		// Token: 0x0601374E RID: 79694 RVA: 0x002D4665 File Offset: 0x002D2865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTimerNotify);
		}

		// Token: 0x0601374F RID: 79695 RVA: 0x002D4673 File Offset: 0x002D2873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTimerNotify other)
		{
			return other != null && (other == this || (this.QuestTimers.Equals(other.QuestTimers) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013750 RID: 79696 RVA: 0x002D46A8 File Offset: 0x002D28A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.QuestTimers.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013751 RID: 79697 RVA: 0x002D46DC File Offset: 0x002D28DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013752 RID: 79698 RVA: 0x002D46E9 File Offset: 0x002D28E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013753 RID: 79699 RVA: 0x002D46F2 File Offset: 0x002D28F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questTimers_.WriteTo(ref output, QuestTimerNotify._map_questTimers_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013754 RID: 79700 RVA: 0x002D471C File Offset: 0x002D291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questTimers_.CalculateSize(QuestTimerNotify._map_questTimers_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013755 RID: 79701 RVA: 0x002D4755 File Offset: 0x002D2955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestTimerNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questTimers_.MergeFrom(other.questTimers_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013756 RID: 79702 RVA: 0x002D4783 File Offset: 0x002D2983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013757 RID: 79703 RVA: 0x002D478C File Offset: 0x002D298C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questTimers_.AddEntriesFrom(ref input, QuestTimerNotify._map_questTimers_codec);
				}
			}
		}

		// Token: 0x040077A3 RID: 30627
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077A4 RID: 30628
		public const int QuestTimersFieldNumber = 1;

		// Token: 0x040077A5 RID: 30629
		private static readonly MapField<int, QuestTimer>.Codec _map_questTimers_codec = new MapField<int, QuestTimer>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<QuestTimer>(18U, QuestTimer.Parser), 10U);

		// Token: 0x040077A6 RID: 30630
		private readonly MapField<int, QuestTimer> questTimers_ = new MapField<int, QuestTimer>();
	}
}
