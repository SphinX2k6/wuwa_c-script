using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E17 RID: 3607
	[NetMessage(EMessageId.QuestGiveUpNotify)]
	public sealed class QuestGiveUpNotify : IMessage<QuestGiveUpNotify>, IMessage, IEquatable<QuestGiveUpNotify>, IDeepCloneable<QuestGiveUpNotify>, IBufferMessage
	{
		// Token: 0x0601360D RID: 79373 RVA: 0x002D19BD File Offset: 0x002CFBBD
		[NullableContext(1)]
		public static QuestGiveUpNotify Create()
		{
			return new QuestGiveUpNotify();
		}

		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x0601360E RID: 79374 RVA: 0x002D19C4 File Offset: 0x002CFBC4
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
		// (get) Token: 0x0601360F RID: 79375 RVA: 0x002D19C7 File Offset: 0x002CFBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestGiveUpNotify.Descriptor;
			}
		}

		// Token: 0x06013610 RID: 79376 RVA: 0x002D19CE File Offset: 0x002CFBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestGiveUpNotify()
		{
		}

		// Token: 0x06013611 RID: 79377 RVA: 0x002D19E4 File Offset: 0x002CFBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestGiveUpNotify(QuestGiveUpNotify other) : this()
		{
			this.questId_ = other.questId_;
			this.treeIncId_ = other.treeIncId_;
			this.flowIncIds_ = other.flowIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013612 RID: 79378 RVA: 0x002D1A31 File Offset: 0x002CFC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestGiveUpNotify Clone()
		{
			return new QuestGiveUpNotify(this);
		}

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x06013613 RID: 79379 RVA: 0x002D1A39 File Offset: 0x002CFC39
		// (set) Token: 0x06013614 RID: 79380 RVA: 0x002D1A41 File Offset: 0x002CFC41
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

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x06013615 RID: 79381 RVA: 0x002D1A4A File Offset: 0x002CFC4A
		// (set) Token: 0x06013616 RID: 79382 RVA: 0x002D1A52 File Offset: 0x002CFC52
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

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x06013617 RID: 79383 RVA: 0x002D1A5B File Offset: 0x002CFC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> FlowIncIds
		{
			get
			{
				return this.flowIncIds_;
			}
		}

		// Token: 0x06013618 RID: 79384 RVA: 0x002D1A63 File Offset: 0x002CFC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestGiveUpNotify);
		}

		// Token: 0x06013619 RID: 79385 RVA: 0x002D1A74 File Offset: 0x002CFC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestGiveUpNotify other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.TreeIncId == other.TreeIncId && this.flowIncIds_.Equals(other.flowIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601361A RID: 79386 RVA: 0x002D1AD4 File Offset: 0x002CFCD4
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
			num ^= this.flowIncIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601361B RID: 79387 RVA: 0x002D1B3A File Offset: 0x002CFD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601361C RID: 79388 RVA: 0x002D1B47 File Offset: 0x002CFD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601361D RID: 79389 RVA: 0x002D1B50 File Offset: 0x002CFD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.QuestId);
			}
			this.flowIncIds_.WriteTo(ref output, QuestGiveUpNotify._repeated_flowIncIds_codec);
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601361E RID: 79390 RVA: 0x002D1BBC File Offset: 0x002CFDBC
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
			num += this.flowIncIds_.CalculateSize(QuestGiveUpNotify._repeated_flowIncIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601361F RID: 79391 RVA: 0x002D1C28 File Offset: 0x002CFE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestGiveUpNotify other)
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
			this.flowIncIds_.Add(other.flowIncIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013620 RID: 79392 RVA: 0x002D1C89 File Offset: 0x002CFE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013621 RID: 79393 RVA: 0x002D1C94 File Offset: 0x002CFE94
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
				if (num <= 96U)
				{
					if (num == 56U)
					{
						this.QuestId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_46;
					}
					if (num == 104U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.flowIncIds_.AddEntriesFrom(ref input, QuestGiveUpNotify._repeated_flowIncIds_codec);
			}
		}

		// Token: 0x040076EA RID: 30442
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076EB RID: 30443
		public const int QuestIdFieldNumber = 7;

		// Token: 0x040076EC RID: 30444
		private int questId_;

		// Token: 0x040076ED RID: 30445
		public const int TreeIncIdFieldNumber = 13;

		// Token: 0x040076EE RID: 30446
		private long treeIncId_;

		// Token: 0x040076EF RID: 30447
		public const int FlowIncIdsFieldNumber = 12;

		// Token: 0x040076F0 RID: 30448
		private static readonly FieldCodec<long> _repeated_flowIncIds_codec = FieldCodec.ForInt64(98U);

		// Token: 0x040076F1 RID: 30449
		private readonly RepeatedField<long> flowIncIds_ = new RepeatedField<long>();
	}
}
