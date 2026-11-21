using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005E RID: 94
	public sealed class AchievementGroupEntry : IMessage<AchievementGroupEntry>, IMessage, IEquatable<AchievementGroupEntry>, IDeepCloneable<AchievementGroupEntry>, IBufferMessage
	{
		// Token: 0x0600161D RID: 5661 RVA: 0x0003A5B9 File Offset: 0x000387B9
		[NullableContext(1)]
		public static AchievementGroupEntry Create()
		{
			return new AchievementGroupEntry();
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x0003A5C0 File Offset: 0x000387C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0003A5C3 File Offset: 0x000387C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementGroupEntry.Descriptor;
			}
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0003A5CA File Offset: 0x000387CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry()
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0003A5D2 File Offset: 0x000387D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry(AchievementGroupEntry other) : this()
		{
			this.id_ = other.id_;
			this.finishTime_ = other.finishTime_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0003A60F File Offset: 0x0003880F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry Clone()
		{
			return new AchievementGroupEntry(this);
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x0003A617 File Offset: 0x00038817
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x0003A61F File Offset: 0x0003881F
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x0003A628 File Offset: 0x00038828
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x0003A630 File Offset: 0x00038830
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x0003A639 File Offset: 0x00038839
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x0003A641 File Offset: 0x00038841
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

		// Token: 0x06001629 RID: 5673 RVA: 0x0003A64A File Offset: 0x0003884A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementGroupEntry);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0003A658 File Offset: 0x00038858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementGroupEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.FinishTime == other.FinishTime && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0003A6B4 File Offset: 0x000388B4
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0003A725 File Offset: 0x00038925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0003A732 File Offset: 0x00038932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0003A73C File Offset: 0x0003893C
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0003A7B0 File Offset: 0x000389B0
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0003A814 File Offset: 0x00038A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementGroupEntry other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x0003A878 File Offset: 0x00038A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0003A884 File Offset: 0x00038A84
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsReceive = input.ReadBool();
						}
					}
					else
					{
						this.FinishTime = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400211A RID: 8474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400211B RID: 8475
		public const int IdFieldNumber = 1;

		// Token: 0x0400211C RID: 8476
		private int id_;

		// Token: 0x0400211D RID: 8477
		public const int FinishTimeFieldNumber = 2;

		// Token: 0x0400211E RID: 8478
		private uint finishTime_;

		// Token: 0x0400211F RID: 8479
		public const int IsReceiveFieldNumber = 3;

		// Token: 0x04002120 RID: 8480
		private bool isReceive_;
	}
}
