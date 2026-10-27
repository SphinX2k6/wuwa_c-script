using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000794 RID: 1940
	public sealed class HonamiStoryPlayerBagInfo : IMessage<HonamiStoryPlayerBagInfo>, IMessage, IEquatable<HonamiStoryPlayerBagInfo>, IDeepCloneable<HonamiStoryPlayerBagInfo>, IBufferMessage
	{
		// Token: 0x0600AF0D RID: 44813 RVA: 0x001A43C9 File Offset: 0x001A25C9
		[NullableContext(1)]
		public static HonamiStoryPlayerBagInfo Create()
		{
			return new HonamiStoryPlayerBagInfo();
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x0600AF0E RID: 44814 RVA: 0x001A43D0 File Offset: 0x001A25D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x0600AF0F RID: 44815 RVA: 0x001A43D3 File Offset: 0x001A25D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPlayerBagInfo.Descriptor;
			}
		}

		// Token: 0x0600AF10 RID: 44816 RVA: 0x001A43DA File Offset: 0x001A25DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPlayerBagInfo()
		{
		}

		// Token: 0x0600AF11 RID: 44817 RVA: 0x001A43F8 File Offset: 0x001A25F8
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

		// Token: 0x0600AF12 RID: 44818 RVA: 0x001A4476 File Offset: 0x001A2676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPlayerBagInfo Clone()
		{
			return new HonamiStoryPlayerBagInfo(this);
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600AF13 RID: 44819 RVA: 0x001A447E File Offset: 0x001A267E
		// (set) Token: 0x0600AF14 RID: 44820 RVA: 0x001A4486 File Offset: 0x001A2686
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

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x0600AF15 RID: 44821 RVA: 0x001A448F File Offset: 0x001A268F
		// (set) Token: 0x0600AF16 RID: 44822 RVA: 0x001A4497 File Offset: 0x001A2697
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

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x0600AF17 RID: 44823 RVA: 0x001A44A0 File Offset: 0x001A26A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryRackInfo> HonamiStoryRackInfos
		{
			get
			{
				return this.honamiStoryRackInfos_;
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x0600AF18 RID: 44824 RVA: 0x001A44A8 File Offset: 0x001A26A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeapon
		{
			get
			{
				return this.unlockWeapon_;
			}
		}

		// Token: 0x0600AF19 RID: 44825 RVA: 0x001A44B0 File Offset: 0x001A26B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPlayerBagInfo);
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x001A44C0 File Offset: 0x001A26C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPlayerBagInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Warehouse, other.Warehouse) && object.Equals(this.EquipRack, other.EquipRack) && this.honamiStoryRackInfos_.Equals(other.honamiStoryRackInfos_) && this.unlockWeapon_.Equals(other.unlockWeapon_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF1B RID: 44827 RVA: 0x001A4540 File Offset: 0x001A2740
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

		// Token: 0x0600AF1C RID: 44828 RVA: 0x001A45AE File Offset: 0x001A27AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF1D RID: 44829 RVA: 0x001A45BB File Offset: 0x001A27BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x001A45C4 File Offset: 0x001A27C4
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

		// Token: 0x0600AF1F RID: 44831 RVA: 0x001A4640 File Offset: 0x001A2840
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

		// Token: 0x0600AF20 RID: 44832 RVA: 0x001A46BC File Offset: 0x001A28BC
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

		// Token: 0x0600AF21 RID: 44833 RVA: 0x001A475E File Offset: 0x001A295E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF22 RID: 44834 RVA: 0x001A4768 File Offset: 0x001A2968
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

		// Token: 0x04004EDC RID: 20188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EDD RID: 20189
		public const int WarehouseFieldNumber = 1;

		// Token: 0x04004EDE RID: 20190
		private HonamiStoryBagInfo warehouse_;

		// Token: 0x04004EDF RID: 20191
		public const int EquipRackFieldNumber = 2;

		// Token: 0x04004EE0 RID: 20192
		private HonamiStoryBagInfo equipRack_;

		// Token: 0x04004EE1 RID: 20193
		public const int HonamiStoryRackInfosFieldNumber = 3;

		// Token: 0x04004EE2 RID: 20194
		private static readonly FieldCodec<HonamiStoryRackInfo> _repeated_honamiStoryRackInfos_codec = FieldCodec.ForMessage<HonamiStoryRackInfo>(26U, HonamiStoryRackInfo.Parser);

		// Token: 0x04004EE3 RID: 20195
		private readonly RepeatedField<HonamiStoryRackInfo> honamiStoryRackInfos_ = new RepeatedField<HonamiStoryRackInfo>();

		// Token: 0x04004EE4 RID: 20196
		public const int UnlockWeaponFieldNumber = 4;

		// Token: 0x04004EE5 RID: 20197
		private static readonly FieldCodec<int> _repeated_unlockWeapon_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004EE6 RID: 20198
		private readonly RepeatedField<int> unlockWeapon_ = new RepeatedField<int>();
	}
}
