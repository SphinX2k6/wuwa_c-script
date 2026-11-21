using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001138 RID: 4408
	public sealed class RoverRogueGainEntry : IMessage<RoverRogueGainEntry>, IMessage, IEquatable<RoverRogueGainEntry>, IDeepCloneable<RoverRogueGainEntry>, IBufferMessage
	{
		// Token: 0x060178C0 RID: 96448 RVA: 0x0036CF53 File Offset: 0x0036B153
		[NullableContext(1)]
		public static RoverRogueGainEntry Create()
		{
			return new RoverRogueGainEntry();
		}

		// Token: 0x17004F24 RID: 20260
		// (get) Token: 0x060178C1 RID: 96449 RVA: 0x0036CF5A File Offset: 0x0036B15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueGainEntry> Parser
		{
			get
			{
				return RoverRogueGainEntry._parser;
			}
		}

		// Token: 0x17004F25 RID: 20261
		// (get) Token: 0x060178C2 RID: 96450 RVA: 0x0036CF61 File Offset: 0x0036B161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F26 RID: 20262
		// (get) Token: 0x060178C3 RID: 96451 RVA: 0x0036CF64 File Offset: 0x0036B164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGainEntry.Descriptor;
			}
		}

		// Token: 0x060178C4 RID: 96452 RVA: 0x0036CF6B File Offset: 0x0036B16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainEntry()
		{
		}

		// Token: 0x060178C5 RID: 96453 RVA: 0x0036CF74 File Offset: 0x0036B174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainEntry(RoverRogueGainEntry other) : this()
		{
			this.type_ = other.type_;
			this.configId_ = other.configId_;
			this.incId_ = other.incId_;
			this.itemRemainingRooms_ = other.itemRemainingRooms_;
			this.lootInfo_ = ((other.lootInfo_ != null) ? other.lootInfo_.Clone() : null);
			this.expire_ = other.expire_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060178C6 RID: 96454 RVA: 0x0036CFF0 File Offset: 0x0036B1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainEntry Clone()
		{
			return new RoverRogueGainEntry(this);
		}

		// Token: 0x17004F27 RID: 20263
		// (get) Token: 0x060178C7 RID: 96455 RVA: 0x0036CFF8 File Offset: 0x0036B1F8
		// (set) Token: 0x060178C8 RID: 96456 RVA: 0x0036D000 File Offset: 0x0036B200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainDataType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17004F28 RID: 20264
		// (get) Token: 0x060178C9 RID: 96457 RVA: 0x0036D009 File Offset: 0x0036B209
		// (set) Token: 0x060178CA RID: 96458 RVA: 0x0036D011 File Offset: 0x0036B211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004F29 RID: 20265
		// (get) Token: 0x060178CB RID: 96459 RVA: 0x0036D01A File Offset: 0x0036B21A
		// (set) Token: 0x060178CC RID: 96460 RVA: 0x0036D022 File Offset: 0x0036B222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004F2A RID: 20266
		// (get) Token: 0x060178CD RID: 96461 RVA: 0x0036D02B File Offset: 0x0036B22B
		// (set) Token: 0x060178CE RID: 96462 RVA: 0x0036D033 File Offset: 0x0036B233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemRemainingRooms
		{
			get
			{
				return this.itemRemainingRooms_;
			}
			set
			{
				this.itemRemainingRooms_ = value;
			}
		}

		// Token: 0x17004F2B RID: 20267
		// (get) Token: 0x060178CF RID: 96463 RVA: 0x0036D03C File Offset: 0x0036B23C
		// (set) Token: 0x060178D0 RID: 96464 RVA: 0x0036D044 File Offset: 0x0036B244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfo LootInfo
		{
			get
			{
				return this.lootInfo_;
			}
			set
			{
				this.lootInfo_ = value;
			}
		}

		// Token: 0x17004F2C RID: 20268
		// (get) Token: 0x060178D1 RID: 96465 RVA: 0x0036D04D File Offset: 0x0036B24D
		// (set) Token: 0x060178D2 RID: 96466 RVA: 0x0036D055 File Offset: 0x0036B255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Expire
		{
			get
			{
				return this.expire_;
			}
			set
			{
				this.expire_ = value;
			}
		}

		// Token: 0x060178D3 RID: 96467 RVA: 0x0036D05E File Offset: 0x0036B25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGainEntry);
		}

		// Token: 0x060178D4 RID: 96468 RVA: 0x0036D06C File Offset: 0x0036B26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGainEntry other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.ConfigId == other.ConfigId && this.IncId == other.IncId && this.ItemRemainingRooms == other.ItemRemainingRooms && object.Equals(this.LootInfo, other.LootInfo) && this.Expire == other.Expire && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178D5 RID: 96469 RVA: 0x0036D0FC File Offset: 0x0036B2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.ItemRemainingRooms != 0)
			{
				num ^= this.ItemRemainingRooms.GetHashCode();
			}
			if (this.lootInfo_ != null)
			{
				num ^= this.LootInfo.GetHashCode();
			}
			if (this.Expire)
			{
				num ^= this.Expire.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060178D6 RID: 96470 RVA: 0x0036D1BB File Offset: 0x0036B3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178D7 RID: 96471 RVA: 0x0036D1C8 File Offset: 0x0036B3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178D8 RID: 96472 RVA: 0x0036D1D4 File Offset: 0x0036B3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.ItemRemainingRooms != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ItemRemainingRooms);
			}
			if (this.lootInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.LootInfo);
			}
			if (this.Expire)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Expire);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178D9 RID: 96473 RVA: 0x0036D2A0 File Offset: 0x0036B4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.ItemRemainingRooms != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemRemainingRooms);
			}
			if (this.lootInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LootInfo);
			}
			if (this.Expire)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060178DA RID: 96474 RVA: 0x0036D34C File Offset: 0x0036B54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueGainEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != RoverRogueGainDataType.RoverRogueGainUnknown)
			{
				this.Type = other.Type;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.ItemRemainingRooms != 0)
			{
				this.ItemRemainingRooms = other.ItemRemainingRooms;
			}
			if (other.lootInfo_ != null)
			{
				if (this.lootInfo_ == null)
				{
					this.LootInfo = new RoverRogueLootInfo();
				}
				this.LootInfo.MergeFrom(other.LootInfo);
			}
			if (other.Expire)
			{
				this.Expire = other.Expire;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060178DB RID: 96475 RVA: 0x0036D404 File Offset: 0x0036B604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178DC RID: 96476 RVA: 0x0036D410 File Offset: 0x0036B610
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.Type = (RoverRogueGainDataType)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.ItemRemainingRooms = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						if (this.lootInfo_ == null)
						{
							this.LootInfo = new RoverRogueLootInfo();
						}
						input.ReadMessage(this.LootInfo);
						continue;
					}
					if (num == 56U)
					{
						this.Expire = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008C81 RID: 35969
		private static readonly MessageParser<RoverRogueGainEntry> _parser = new MessageParser<RoverRogueGainEntry>(() => new RoverRogueGainEntry());

		// Token: 0x04008C82 RID: 35970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C83 RID: 35971
		public const int TypeFieldNumber = 2;

		// Token: 0x04008C84 RID: 35972
		private RoverRogueGainDataType type_;

		// Token: 0x04008C85 RID: 35973
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x04008C86 RID: 35974
		private int configId_;

		// Token: 0x04008C87 RID: 35975
		public const int IncIdFieldNumber = 4;

		// Token: 0x04008C88 RID: 35976
		private int incId_;

		// Token: 0x04008C89 RID: 35977
		public const int ItemRemainingRoomsFieldNumber = 5;

		// Token: 0x04008C8A RID: 35978
		private int itemRemainingRooms_;

		// Token: 0x04008C8B RID: 35979
		public const int LootInfoFieldNumber = 6;

		// Token: 0x04008C8C RID: 35980
		private RoverRogueLootInfo lootInfo_;

		// Token: 0x04008C8D RID: 35981
		public const int ExpireFieldNumber = 7;

		// Token: 0x04008C8E RID: 35982
		private bool expire_;
	}
}
