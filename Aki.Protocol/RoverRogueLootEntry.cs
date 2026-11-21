using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001149 RID: 4425
	public sealed class RoverRogueLootEntry : IMessage<RoverRogueLootEntry>, IMessage, IEquatable<RoverRogueLootEntry>, IDeepCloneable<RoverRogueLootEntry>, IBufferMessage
	{
		// Token: 0x06017A49 RID: 96841 RVA: 0x00370F21 File Offset: 0x0036F121
		[NullableContext(1)]
		public static RoverRogueLootEntry Create()
		{
			return new RoverRogueLootEntry();
		}

		// Token: 0x17004F87 RID: 20359
		// (get) Token: 0x06017A4A RID: 96842 RVA: 0x00370F28 File Offset: 0x0036F128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueLootEntry> Parser
		{
			get
			{
				return RoverRogueLootEntry._parser;
			}
		}

		// Token: 0x17004F88 RID: 20360
		// (get) Token: 0x06017A4B RID: 96843 RVA: 0x00370F2F File Offset: 0x0036F12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F89 RID: 20361
		// (get) Token: 0x06017A4C RID: 96844 RVA: 0x00370F32 File Offset: 0x0036F132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootEntry.Descriptor;
			}
		}

		// Token: 0x06017A4D RID: 96845 RVA: 0x00370F39 File Offset: 0x0036F139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootEntry()
		{
		}

		// Token: 0x06017A4E RID: 96846 RVA: 0x00370F41 File Offset: 0x0036F141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootEntry(RoverRogueLootEntry other) : this()
		{
			this.lootId_ = other.lootId_;
			this.level_ = other.level_;
			this.roomPassedCount_ = other.roomPassedCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A4F RID: 96847 RVA: 0x00370F7E File Offset: 0x0036F17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootEntry Clone()
		{
			return new RoverRogueLootEntry(this);
		}

		// Token: 0x17004F8A RID: 20362
		// (get) Token: 0x06017A50 RID: 96848 RVA: 0x00370F86 File Offset: 0x0036F186
		// (set) Token: 0x06017A51 RID: 96849 RVA: 0x00370F8E File Offset: 0x0036F18E
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

		// Token: 0x17004F8B RID: 20363
		// (get) Token: 0x06017A52 RID: 96850 RVA: 0x00370F97 File Offset: 0x0036F197
		// (set) Token: 0x06017A53 RID: 96851 RVA: 0x00370F9F File Offset: 0x0036F19F
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

		// Token: 0x17004F8C RID: 20364
		// (get) Token: 0x06017A54 RID: 96852 RVA: 0x00370FA8 File Offset: 0x0036F1A8
		// (set) Token: 0x06017A55 RID: 96853 RVA: 0x00370FB0 File Offset: 0x0036F1B0
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

		// Token: 0x06017A56 RID: 96854 RVA: 0x00370FB9 File Offset: 0x0036F1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootEntry);
		}

		// Token: 0x06017A57 RID: 96855 RVA: 0x00370FC8 File Offset: 0x0036F1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootEntry other)
		{
			return other != null && (other == this || (this.LootId == other.LootId && this.Level == other.Level && this.RoomPassedCount == other.RoomPassedCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A58 RID: 96856 RVA: 0x00371024 File Offset: 0x0036F224
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

		// Token: 0x06017A59 RID: 96857 RVA: 0x00371095 File Offset: 0x0036F295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A5A RID: 96858 RVA: 0x003710A2 File Offset: 0x0036F2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A5B RID: 96859 RVA: 0x003710AC File Offset: 0x0036F2AC
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

		// Token: 0x06017A5C RID: 96860 RVA: 0x00371120 File Offset: 0x0036F320
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

		// Token: 0x06017A5D RID: 96861 RVA: 0x00371190 File Offset: 0x0036F390
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

		// Token: 0x06017A5E RID: 96862 RVA: 0x003711F4 File Offset: 0x0036F3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A5F RID: 96863 RVA: 0x00371200 File Offset: 0x0036F400
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

		// Token: 0x04008D1E RID: 36126
		private static readonly MessageParser<RoverRogueLootEntry> _parser = new MessageParser<RoverRogueLootEntry>(() => new RoverRogueLootEntry());

		// Token: 0x04008D1F RID: 36127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D20 RID: 36128
		public const int LootIdFieldNumber = 1;

		// Token: 0x04008D21 RID: 36129
		private int lootId_;

		// Token: 0x04008D22 RID: 36130
		public const int LevelFieldNumber = 2;

		// Token: 0x04008D23 RID: 36131
		private int level_;

		// Token: 0x04008D24 RID: 36132
		public const int RoomPassedCountFieldNumber = 3;

		// Token: 0x04008D25 RID: 36133
		private int roomPassedCount_;
	}
}
