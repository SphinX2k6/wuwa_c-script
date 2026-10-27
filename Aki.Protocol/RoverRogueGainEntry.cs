using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FE RID: 4350
	public sealed class RoverRogueGainEntry : IMessage<RoverRogueGainEntry>, IMessage, IEquatable<RoverRogueGainEntry>, IDeepCloneable<RoverRogueGainEntry>, IBufferMessage
	{
		// Token: 0x0601731F RID: 95007 RVA: 0x0035DBFF File Offset: 0x0035BDFF
		[NullableContext(1)]
		public static RoverRogueGainEntry Create()
		{
			return new RoverRogueGainEntry();
		}

		// Token: 0x17004DB8 RID: 19896
		// (get) Token: 0x06017320 RID: 95008 RVA: 0x0035DC06 File Offset: 0x0035BE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueGainEntry> Parser
		{
			get
			{
				return RoverRogueGainEntry._parser;
			}
		}

		// Token: 0x17004DB9 RID: 19897
		// (get) Token: 0x06017321 RID: 95009 RVA: 0x0035DC0D File Offset: 0x0035BE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DBA RID: 19898
		// (get) Token: 0x06017322 RID: 95010 RVA: 0x0035DC10 File Offset: 0x0035BE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueGainEntry.Descriptor;
			}
		}

		// Token: 0x06017323 RID: 95011 RVA: 0x0035DC17 File Offset: 0x0035BE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainEntry()
		{
		}

		// Token: 0x06017324 RID: 95012 RVA: 0x0035DC20 File Offset: 0x0035BE20
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

		// Token: 0x06017325 RID: 95013 RVA: 0x0035DC9C File Offset: 0x0035BE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGainEntry Clone()
		{
			return new RoverRogueGainEntry(this);
		}

		// Token: 0x17004DBB RID: 19899
		// (get) Token: 0x06017326 RID: 95014 RVA: 0x0035DCA4 File Offset: 0x0035BEA4
		// (set) Token: 0x06017327 RID: 95015 RVA: 0x0035DCAC File Offset: 0x0035BEAC
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

		// Token: 0x17004DBC RID: 19900
		// (get) Token: 0x06017328 RID: 95016 RVA: 0x0035DCB5 File Offset: 0x0035BEB5
		// (set) Token: 0x06017329 RID: 95017 RVA: 0x0035DCBD File Offset: 0x0035BEBD
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

		// Token: 0x17004DBD RID: 19901
		// (get) Token: 0x0601732A RID: 95018 RVA: 0x0035DCC6 File Offset: 0x0035BEC6
		// (set) Token: 0x0601732B RID: 95019 RVA: 0x0035DCCE File Offset: 0x0035BECE
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

		// Token: 0x17004DBE RID: 19902
		// (get) Token: 0x0601732C RID: 95020 RVA: 0x0035DCD7 File Offset: 0x0035BED7
		// (set) Token: 0x0601732D RID: 95021 RVA: 0x0035DCDF File Offset: 0x0035BEDF
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

		// Token: 0x17004DBF RID: 19903
		// (get) Token: 0x0601732E RID: 95022 RVA: 0x0035DCE8 File Offset: 0x0035BEE8
		// (set) Token: 0x0601732F RID: 95023 RVA: 0x0035DCF0 File Offset: 0x0035BEF0
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

		// Token: 0x17004DC0 RID: 19904
		// (get) Token: 0x06017330 RID: 95024 RVA: 0x0035DCF9 File Offset: 0x0035BEF9
		// (set) Token: 0x06017331 RID: 95025 RVA: 0x0035DD01 File Offset: 0x0035BF01
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

		// Token: 0x06017332 RID: 95026 RVA: 0x0035DD0A File Offset: 0x0035BF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueGainEntry);
		}

		// Token: 0x06017333 RID: 95027 RVA: 0x0035DD18 File Offset: 0x0035BF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueGainEntry other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.ConfigId == other.ConfigId && this.IncId == other.IncId && this.ItemRemainingRooms == other.ItemRemainingRooms && object.Equals(this.LootInfo, other.LootInfo) && this.Expire == other.Expire && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017334 RID: 95028 RVA: 0x0035DDA8 File Offset: 0x0035BFA8
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

		// Token: 0x06017335 RID: 95029 RVA: 0x0035DE67 File Offset: 0x0035C067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017336 RID: 95030 RVA: 0x0035DE74 File Offset: 0x0035C074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017337 RID: 95031 RVA: 0x0035DE80 File Offset: 0x0035C080
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

		// Token: 0x06017338 RID: 95032 RVA: 0x0035DF4C File Offset: 0x0035C14C
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

		// Token: 0x06017339 RID: 95033 RVA: 0x0035DFF8 File Offset: 0x0035C1F8
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

		// Token: 0x0601733A RID: 95034 RVA: 0x0035E0B0 File Offset: 0x0035C2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601733B RID: 95035 RVA: 0x0035E0BC File Offset: 0x0035C2BC
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

		// Token: 0x040089EE RID: 35310
		private static readonly MessageParser<RoverRogueGainEntry> _parser = new MessageParser<RoverRogueGainEntry>(() => new RoverRogueGainEntry());

		// Token: 0x040089EF RID: 35311
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089F0 RID: 35312
		public const int TypeFieldNumber = 2;

		// Token: 0x040089F1 RID: 35313
		private RoverRogueGainDataType type_;

		// Token: 0x040089F2 RID: 35314
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x040089F3 RID: 35315
		private int configId_;

		// Token: 0x040089F4 RID: 35316
		public const int IncIdFieldNumber = 4;

		// Token: 0x040089F5 RID: 35317
		private int incId_;

		// Token: 0x040089F6 RID: 35318
		public const int ItemRemainingRoomsFieldNumber = 5;

		// Token: 0x040089F7 RID: 35319
		private int itemRemainingRooms_;

		// Token: 0x040089F8 RID: 35320
		public const int LootInfoFieldNumber = 6;

		// Token: 0x040089F9 RID: 35321
		private RoverRogueLootInfo lootInfo_;

		// Token: 0x040089FA RID: 35322
		public const int ExpireFieldNumber = 7;

		// Token: 0x040089FB RID: 35323
		private bool expire_;
	}
}
