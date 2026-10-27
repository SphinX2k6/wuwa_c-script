using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110F RID: 4367
	public sealed class RoverRogueLootEntry : IMessage<RoverRogueLootEntry>, IMessage, IEquatable<RoverRogueLootEntry>, IDeepCloneable<RoverRogueLootEntry>, IBufferMessage
	{
		// Token: 0x060174A8 RID: 95400 RVA: 0x00361BD5 File Offset: 0x0035FDD5
		[NullableContext(1)]
		public static RoverRogueLootEntry Create()
		{
			return new RoverRogueLootEntry();
		}

		// Token: 0x17004E1B RID: 19995
		// (get) Token: 0x060174A9 RID: 95401 RVA: 0x00361BDC File Offset: 0x0035FDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueLootEntry> Parser
		{
			get
			{
				return RoverRogueLootEntry._parser;
			}
		}

		// Token: 0x17004E1C RID: 19996
		// (get) Token: 0x060174AA RID: 95402 RVA: 0x00361BE3 File Offset: 0x0035FDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E1D RID: 19997
		// (get) Token: 0x060174AB RID: 95403 RVA: 0x00361BE6 File Offset: 0x0035FDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootEntry.Descriptor;
			}
		}

		// Token: 0x060174AC RID: 95404 RVA: 0x00361BED File Offset: 0x0035FDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootEntry()
		{
		}

		// Token: 0x060174AD RID: 95405 RVA: 0x00361BF5 File Offset: 0x0035FDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootEntry(RoverRogueLootEntry other) : this()
		{
			this.lootId_ = other.lootId_;
			this.level_ = other.level_;
			this.roomPassedCount_ = other.roomPassedCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174AE RID: 95406 RVA: 0x00361C32 File Offset: 0x0035FE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootEntry Clone()
		{
			return new RoverRogueLootEntry(this);
		}

		// Token: 0x17004E1E RID: 19998
		// (get) Token: 0x060174AF RID: 95407 RVA: 0x00361C3A File Offset: 0x0035FE3A
		// (set) Token: 0x060174B0 RID: 95408 RVA: 0x00361C42 File Offset: 0x0035FE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LootId
		{
			get
			{
				return this.lootId_;
			}
			set
			{
				this.lootId_ = value;
			}
		}

		// Token: 0x17004E1F RID: 19999
		// (get) Token: 0x060174B1 RID: 95409 RVA: 0x00361C4B File Offset: 0x0035FE4B
		// (set) Token: 0x060174B2 RID: 95410 RVA: 0x00361C53 File Offset: 0x0035FE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004E20 RID: 20000
		// (get) Token: 0x060174B3 RID: 95411 RVA: 0x00361C5C File Offset: 0x0035FE5C
		// (set) Token: 0x060174B4 RID: 95412 RVA: 0x00361C64 File Offset: 0x0035FE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomPassedCount
		{
			get
			{
				return this.roomPassedCount_;
			}
			set
			{
				this.roomPassedCount_ = value;
			}
		}

		// Token: 0x060174B5 RID: 95413 RVA: 0x00361C6D File Offset: 0x0035FE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootEntry);
		}

		// Token: 0x060174B6 RID: 95414 RVA: 0x00361C7C File Offset: 0x0035FE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootEntry other)
		{
			return other != null && (other == this || (this.LootId == other.LootId && this.Level == other.Level && this.RoomPassedCount == other.RoomPassedCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060174B7 RID: 95415 RVA: 0x00361CD8 File Offset: 0x0035FED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LootId != 0)
			{
				num ^= this.LootId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.RoomPassedCount != 0)
			{
				num ^= this.RoomPassedCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060174B8 RID: 95416 RVA: 0x00361D49 File Offset: 0x0035FF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174B9 RID: 95417 RVA: 0x00361D56 File Offset: 0x0035FF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174BA RID: 95418 RVA: 0x00361D60 File Offset: 0x0035FF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LootId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LootId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.RoomPassedCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoomPassedCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060174BB RID: 95419 RVA: 0x00361DD4 File Offset: 0x0035FFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LootId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LootId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.RoomPassedCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomPassedCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060174BC RID: 95420 RVA: 0x00361E44 File Offset: 0x00360044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LootId != 0)
			{
				this.LootId = other.LootId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.RoomPassedCount != 0)
			{
				this.RoomPassedCount = other.RoomPassedCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060174BD RID: 95421 RVA: 0x00361EA8 File Offset: 0x003600A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174BE RID: 95422 RVA: 0x00361EB4 File Offset: 0x003600B4
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
							this.RoomPassedCount = input.ReadInt32();
						}
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.LootId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A8B RID: 35467
		private static readonly MessageParser<RoverRogueLootEntry> _parser = new MessageParser<RoverRogueLootEntry>(() => new RoverRogueLootEntry());

		// Token: 0x04008A8C RID: 35468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A8D RID: 35469
		public const int LootIdFieldNumber = 1;

		// Token: 0x04008A8E RID: 35470
		private int lootId_;

		// Token: 0x04008A8F RID: 35471
		public const int LevelFieldNumber = 2;

		// Token: 0x04008A90 RID: 35472
		private int level_;

		// Token: 0x04008A91 RID: 35473
		public const int RoomPassedCountFieldNumber = 3;

		// Token: 0x04008A92 RID: 35474
		private int roomPassedCount_;
	}
}
