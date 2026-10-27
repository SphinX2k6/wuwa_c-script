using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005D RID: 93
	public sealed class AchievementGroupEntry : IMessage<AchievementGroupEntry>, IMessage, IEquatable<AchievementGroupEntry>, IDeepCloneable<AchievementGroupEntry>, IBufferMessage
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x00039C15 File Offset: 0x00037E15
		[NullableContext(1)]
		public static AchievementGroupEntry Create()
		{
			return new AchievementGroupEntry();
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00039C1C File Offset: 0x00037E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x00039C1F File Offset: 0x00037E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementGroupEntry.Descriptor;
			}
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00039C26 File Offset: 0x00037E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry()
		{
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00039C2E File Offset: 0x00037E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry(AchievementGroupEntry other) : this()
		{
			this.id_ = other.id_;
			this.finishTime_ = other.finishTime_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00039C6B File Offset: 0x00037E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry Clone()
		{
			return new AchievementGroupEntry(this);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00039C73 File Offset: 0x00037E73
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x00039C7B File Offset: 0x00037E7B
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00039C84 File Offset: 0x00037E84
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x00039C8C File Offset: 0x00037E8C
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x00039C95 File Offset: 0x00037E95
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x00039C9D File Offset: 0x00037E9D
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

		// Token: 0x060015E6 RID: 5606 RVA: 0x00039CA6 File Offset: 0x00037EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementGroupEntry);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00039CB4 File Offset: 0x00037EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementGroupEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.FinishTime == other.FinishTime && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00039D10 File Offset: 0x00037F10
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

		// Token: 0x060015E9 RID: 5609 RVA: 0x00039D81 File Offset: 0x00037F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00039D8E File Offset: 0x00037F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00039D98 File Offset: 0x00037F98
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

		// Token: 0x060015EC RID: 5612 RVA: 0x00039E0C File Offset: 0x0003800C
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

		// Token: 0x060015ED RID: 5613 RVA: 0x00039E70 File Offset: 0x00038070
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

		// Token: 0x060015EE RID: 5614 RVA: 0x00039ED4 File Offset: 0x000380D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00039EE0 File Offset: 0x000380E0
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

		// Token: 0x040020BB RID: 8379
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020BC RID: 8380
		public const int IdFieldNumber = 1;

		// Token: 0x040020BD RID: 8381
		private int id_;

		// Token: 0x040020BE RID: 8382
		public const int FinishTimeFieldNumber = 2;

		// Token: 0x040020BF RID: 8383
		private uint finishTime_;

		// Token: 0x040020C0 RID: 8384
		public const int IsReceiveFieldNumber = 3;

		// Token: 0x040020C1 RID: 8385
		private bool isReceive_;
	}
}
