using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005A RID: 90
	public sealed class AchievementEntry : IMessage<AchievementEntry>, IMessage, IEquatable<AchievementEntry>, IDeepCloneable<AchievementEntry>, IBufferMessage
	{
		// Token: 0x0600159C RID: 5532 RVA: 0x0003940C File Offset: 0x0003760C
		[NullableContext(1)]
		public static AchievementEntry Create()
		{
			return new AchievementEntry();
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00039413 File Offset: 0x00037613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementEntry> Parser
		{
			get
			{
				return AchievementEntry._parser;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x0003941A File Offset: 0x0003761A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x0003941D File Offset: 0x0003761D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementEntry.Descriptor;
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00039424 File Offset: 0x00037624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementEntry()
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0003942C File Offset: 0x0003762C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementEntry(AchievementEntry other) : this()
		{
			this.id_ = other.id_;
			this.finishTime_ = other.finishTime_;
			this.isReceive_ = other.isReceive_;
			this.progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00039490 File Offset: 0x00037690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementEntry Clone()
		{
			return new AchievementEntry(this);
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00039498 File Offset: 0x00037698
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x000394A0 File Offset: 0x000376A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000394A9 File Offset: 0x000376A9
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x000394B1 File Offset: 0x000376B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FinishTime
		{
			get
			{
				return this.finishTime_;
			}
			set
			{
				this.finishTime_ = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000394BA File Offset: 0x000376BA
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x000394C2 File Offset: 0x000376C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceive
		{
			get
			{
				return this.isReceive_;
			}
			set
			{
				this.isReceive_ = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x000394CB File Offset: 0x000376CB
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x000394D3 File Offset: 0x000376D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgress Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000394DC File Offset: 0x000376DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementEntry);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000394EC File Offset: 0x000376EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.FinishTime == other.FinishTime && this.IsReceive == other.IsReceive && object.Equals(this.Progress, other.Progress) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0003955C File Offset: 0x0003775C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.FinishTime != 0U)
			{
				num ^= this.FinishTime.GetHashCode();
			}
			if (this.IsReceive)
			{
				num ^= this.IsReceive.GetHashCode();
			}
			if (this.progress_ != null)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000395E3 File Offset: 0x000377E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000395F0 File Offset: 0x000377F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000395FC File Offset: 0x000377FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.FinishTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FinishTime);
			}
			if (this.IsReceive)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsReceive);
			}
			if (this.progress_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0003968C File Offset: 0x0003788C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.FinishTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FinishTime);
			}
			if (this.IsReceive)
			{
				num += 2;
			}
			if (this.progress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00039708 File Offset: 0x00037908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.FinishTime != 0U)
			{
				this.FinishTime = other.FinishTime;
			}
			if (other.IsReceive)
			{
				this.IsReceive = other.IsReceive;
			}
			if (other.progress_ != null)
			{
				if (this.progress_ == null)
				{
					this.Progress = new AchievementProgress();
				}
				this.Progress.MergeFrom(other.Progress);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00039798 File Offset: 0x00037998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000397A4 File Offset: 0x000379A4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.FinishTime = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsReceive = input.ReadBool();
						continue;
					}
					if (num == 34U)
					{
						if (this.progress_ == null)
						{
							this.Progress = new AchievementProgress();
						}
						input.ReadMessage(this.Progress);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020AB RID: 8363
		private static readonly MessageParser<AchievementEntry> _parser = new MessageParser<AchievementEntry>(() => new AchievementEntry());

		// Token: 0x040020AC RID: 8364
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020AD RID: 8365
		public const int IdFieldNumber = 1;

		// Token: 0x040020AE RID: 8366
		private int id_;

		// Token: 0x040020AF RID: 8367
		public const int FinishTimeFieldNumber = 2;

		// Token: 0x040020B0 RID: 8368
		private uint finishTime_;

		// Token: 0x040020B1 RID: 8369
		public const int IsReceiveFieldNumber = 3;

		// Token: 0x040020B2 RID: 8370
		private bool isReceive_;

		// Token: 0x040020B3 RID: 8371
		public const int ProgressFieldNumber = 4;

		// Token: 0x040020B4 RID: 8372
		private AchievementProgress progress_;
	}
}
