using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000780 RID: 1920
	public sealed class HonamiStoryPlayerBagInfo : IMessage<HonamiStoryPlayerBagInfo>, IMessage, IEquatable<HonamiStoryPlayerBagInfo>, IDeepCloneable<HonamiStoryPlayerBagInfo>, IBufferMessage
	{
		// Token: 0x0600ADB7 RID: 44471 RVA: 0x001A19A1 File Offset: 0x0019FBA1
		[NullableContext(1)]
		public static HonamiStoryPlayerBagInfo Create()
		{
			return new HonamiStoryPlayerBagInfo();
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x0600ADB8 RID: 44472 RVA: 0x001A19A8 File Offset: 0x0019FBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x0600ADB9 RID: 44473 RVA: 0x001A19AB File Offset: 0x0019FBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPlayerBagInfo.Descriptor;
			}
		}

		// Token: 0x0600ADBA RID: 44474 RVA: 0x001A19B2 File Offset: 0x0019FBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPlayerBagInfo()
		{
		}

		// Token: 0x0600ADBB RID: 44475 RVA: 0x001A19D0 File Offset: 0x0019FBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPlayerBagInfo(HonamiStoryPlayerBagInfo other) : this()
		{
			this.warehouse_ = ((other.warehouse_ != null) ? other.warehouse_.Clone() : null);
			this.equipRack_ = ((other.equipRack_ != null) ? other.equipRack_.Clone() : null);
			this.honamiStoryRackInfos_ = other.honamiStoryRackInfos_.Clone();
			this.unlockWeapon_ = other.unlockWeapon_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x001A1A4E File Offset: 0x0019FC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPlayerBagInfo Clone()
		{
			return new HonamiStoryPlayerBagInfo(this);
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x0600ADBD RID: 44477 RVA: 0x001A1A56 File Offset: 0x0019FC56
		// (set) Token: 0x0600ADBE RID: 44478 RVA: 0x001A1A5E File Offset: 0x0019FC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo Warehouse
		{
			get
			{
				return this.warehouse_;
			}
			set
			{
				this.warehouse_ = value;
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x0600ADBF RID: 44479 RVA: 0x001A1A67 File Offset: 0x0019FC67
		// (set) Token: 0x0600ADC0 RID: 44480 RVA: 0x001A1A6F File Offset: 0x0019FC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo EquipRack
		{
			get
			{
				return this.equipRack_;
			}
			set
			{
				this.equipRack_ = value;
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600ADC1 RID: 44481 RVA: 0x001A1A78 File Offset: 0x0019FC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryRackInfo> HonamiStoryRackInfos
		{
			get
			{
				return this.honamiStoryRackInfos_;
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x001A1A80 File Offset: 0x0019FC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeapon
		{
			get
			{
				return this.unlockWeapon_;
			}
		}

		// Token: 0x0600ADC3 RID: 44483 RVA: 0x001A1A88 File Offset: 0x0019FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPlayerBagInfo);
		}

		// Token: 0x0600ADC4 RID: 44484 RVA: 0x001A1A98 File Offset: 0x0019FC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPlayerBagInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Warehouse, other.Warehouse) && object.Equals(this.EquipRack, other.EquipRack) && this.honamiStoryRackInfos_.Equals(other.honamiStoryRackInfos_) && this.unlockWeapon_.Equals(other.unlockWeapon_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x001A1B18 File Offset: 0x0019FD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.warehouse_ != null)
			{
				num ^= this.Warehouse.GetHashCode();
			}
			if (this.equipRack_ != null)
			{
				num ^= this.EquipRack.GetHashCode();
			}
			num ^= this.honamiStoryRackInfos_.GetHashCode();
			num ^= this.unlockWeapon_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x001A1B86 File Offset: 0x0019FD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADC7 RID: 44487 RVA: 0x001A1B93 File Offset: 0x0019FD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADC8 RID: 44488 RVA: 0x001A1B9C File Offset: 0x0019FD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.warehouse_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Warehouse);
			}
			if (this.equipRack_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EquipRack);
			}
			this.honamiStoryRackInfos_.WriteTo(ref output, HonamiStoryPlayerBagInfo._repeated_honamiStoryRackInfos_codec);
			this.unlockWeapon_.WriteTo(ref output, HonamiStoryPlayerBagInfo._repeated_unlockWeapon_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x001A1C18 File Offset: 0x0019FE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.warehouse_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Warehouse);
			}
			if (this.equipRack_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EquipRack);
			}
			num += this.honamiStoryRackInfos_.CalculateSize(HonamiStoryPlayerBagInfo._repeated_honamiStoryRackInfos_codec);
			num += this.unlockWeapon_.CalculateSize(HonamiStoryPlayerBagInfo._repeated_unlockWeapon_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x001A1C94 File Offset: 0x0019FE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryPlayerBagInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.warehouse_ != null)
			{
				if (this.warehouse_ == null)
				{
					this.Warehouse = new HonamiStoryBagInfo();
				}
				this.Warehouse.MergeFrom(other.Warehouse);
			}
			if (other.equipRack_ != null)
			{
				if (this.equipRack_ == null)
				{
					this.EquipRack = new HonamiStoryBagInfo();
				}
				this.EquipRack.MergeFrom(other.EquipRack);
			}
			this.honamiStoryRackInfos_.Add(other.honamiStoryRackInfos_);
			this.unlockWeapon_.Add(other.unlockWeapon_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADCB RID: 44491 RVA: 0x001A1D36 File Offset: 0x0019FF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADCC RID: 44492 RVA: 0x001A1D40 File Offset: 0x0019FF40
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.warehouse_ == null)
						{
							this.Warehouse = new HonamiStoryBagInfo();
						}
						input.ReadMessage(this.Warehouse);
						continue;
					}
					if (num == 18U)
					{
						if (this.equipRack_ == null)
						{
							this.EquipRack = new HonamiStoryBagInfo();
						}
						input.ReadMessage(this.EquipRack);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.honamiStoryRackInfos_.AddEntriesFrom(ref input, HonamiStoryPlayerBagInfo._repeated_honamiStoryRackInfos_codec);
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.unlockWeapon_.AddEntriesFrom(ref input, HonamiStoryPlayerBagInfo._repeated_unlockWeapon_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004ED5 RID: 20181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ED6 RID: 20182
		public const int WarehouseFieldNumber = 1;

		// Token: 0x04004ED7 RID: 20183
		private HonamiStoryBagInfo warehouse_;

		// Token: 0x04004ED8 RID: 20184
		public const int EquipRackFieldNumber = 2;

		// Token: 0x04004ED9 RID: 20185
		private HonamiStoryBagInfo equipRack_;

		// Token: 0x04004EDA RID: 20186
		public const int HonamiStoryRackInfosFieldNumber = 3;

		// Token: 0x04004EDB RID: 20187
		private static readonly FieldCodec<HonamiStoryRackInfo> _repeated_honamiStoryRackInfos_codec = FieldCodec.ForMessage<HonamiStoryRackInfo>(26U, HonamiStoryRackInfo.Parser);

		// Token: 0x04004EDC RID: 20188
		private readonly RepeatedField<HonamiStoryRackInfo> honamiStoryRackInfos_ = new RepeatedField<HonamiStoryRackInfo>();

		// Token: 0x04004EDD RID: 20189
		public const int UnlockWeaponFieldNumber = 4;

		// Token: 0x04004EDE RID: 20190
		private static readonly FieldCodec<int> _repeated_unlockWeapon_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004EDF RID: 20191
		private readonly RepeatedField<int> unlockWeapon_ = new RepeatedField<int>();
	}
}
