using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E21 RID: 3617
	public sealed class QuestTimer : IMessage<QuestTimer>, IMessage, IEquatable<QuestTimer>, IDeepCloneable<QuestTimer>, IBufferMessage
	{
		// Token: 0x06013731 RID: 79665 RVA: 0x002D4350 File Offset: 0x002D2550
		[NullableContext(1)]
		public static QuestTimer Create()
		{
			return new QuestTimer();
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x06013732 RID: 79666 RVA: 0x002D4357 File Offset: 0x002D2557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestTimer> Parser
		{
			get
			{
				return QuestTimer._parser;
			}
		}

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x06013733 RID: 79667 RVA: 0x002D435E File Offset: 0x002D255E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x06013734 RID: 79668 RVA: 0x002D4361 File Offset: 0x002D2561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTimer.Descriptor;
			}
		}

		// Token: 0x06013735 RID: 79669 RVA: 0x002D4368 File Offset: 0x002D2568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimer()
		{
		}

		// Token: 0x06013736 RID: 79670 RVA: 0x002D4370 File Offset: 0x002D2570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimer(QuestTimer other) : this()
		{
			this.status_ = other.status_;
			this.remainTick_ = other.remainTick_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013737 RID: 79671 RVA: 0x002D43A1 File Offset: 0x002D25A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimer Clone()
		{
			return new QuestTimer(this);
		}

		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x06013738 RID: 79672 RVA: 0x002D43A9 File Offset: 0x002D25A9
		// (set) Token: 0x06013739 RID: 79673 RVA: 0x002D43B1 File Offset: 0x002D25B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x0601373A RID: 79674 RVA: 0x002D43BA File Offset: 0x002D25BA
		// (set) Token: 0x0601373B RID: 79675 RVA: 0x002D43C2 File Offset: 0x002D25C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainTick
		{
			get
			{
				return this.remainTick_;
			}
			set
			{
				this.remainTick_ = value;
			}
		}

		// Token: 0x0601373C RID: 79676 RVA: 0x002D43CB File Offset: 0x002D25CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTimer);
		}

		// Token: 0x0601373D RID: 79677 RVA: 0x002D43D9 File Offset: 0x002D25D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTimer other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.RemainTick == other.RemainTick && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601373E RID: 79678 RVA: 0x002D4418 File Offset: 0x002D2618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.RemainTick != 0)
			{
				num ^= this.RemainTick.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601373F RID: 79679 RVA: 0x002D4470 File Offset: 0x002D2670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013740 RID: 79680 RVA: 0x002D447D File Offset: 0x002D267D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013741 RID: 79681 RVA: 0x002D4488 File Offset: 0x002D2688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Status);
			}
			if (this.RemainTick != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RemainTick);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013742 RID: 79682 RVA: 0x002D44E0 File Offset: 0x002D26E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this.RemainTick != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainTick);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013743 RID: 79683 RVA: 0x002D4538 File Offset: 0x002D2738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestTimer other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			if (other.RemainTick != 0)
			{
				this.RemainTick = other.RemainTick;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013744 RID: 79684 RVA: 0x002D4588 File Offset: 0x002D2788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013745 RID: 79685 RVA: 0x002D4594 File Offset: 0x002D2794
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
						this.RemainTick = input.ReadInt32();
					}
				}
				else
				{
					this.Status = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400779D RID: 30621
		private static readonly MessageParser<QuestTimer> _parser = new MessageParser<QuestTimer>(() => new QuestTimer());

		// Token: 0x0400779E RID: 30622
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400779F RID: 30623
		public const int StatusFieldNumber = 1;

		// Token: 0x040077A0 RID: 30624
		private int status_;

		// Token: 0x040077A1 RID: 30625
		public const int RemainTickFieldNumber = 2;

		// Token: 0x040077A2 RID: 30626
		private int remainTick_;
	}
}
