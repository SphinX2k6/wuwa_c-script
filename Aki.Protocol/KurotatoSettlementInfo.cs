using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BF RID: 2239
	public sealed class KurotatoSettlementInfo : IMessage<KurotatoSettlementInfo>, IMessage, IEquatable<KurotatoSettlementInfo>, IDeepCloneable<KurotatoSettlementInfo>, IBufferMessage
	{
		// Token: 0x0600C685 RID: 50821 RVA: 0x001D5BC7 File Offset: 0x001D3DC7
		[NullableContext(1)]
		public static KurotatoSettlementInfo Create()
		{
			return new KurotatoSettlementInfo();
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x0600C686 RID: 50822 RVA: 0x001D5BCE File Offset: 0x001D3DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x0600C687 RID: 50823 RVA: 0x001D5BD1 File Offset: 0x001D3DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSettlementInfo.Descriptor;
			}
		}

		// Token: 0x0600C688 RID: 50824 RVA: 0x001D5BD8 File Offset: 0x001D3DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementInfo()
		{
		}

		// Token: 0x0600C689 RID: 50825 RVA: 0x001D5C0C File Offset: 0x001D3E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementInfo(KurotatoSettlementInfo other) : this()
		{
			this.isPass_ = other.isPass_;
			this.completionTime_ = other.completionTime_;
			this.itemPanelPbData_ = ((other.itemPanelPbData_ != null) ? other.itemPanelPbData_.Clone() : null);
			this.weaponPanelPbData_ = ((other.weaponPanelPbData_ != null) ? other.weaponPanelPbData_.Clone() : null);
			this.passWaveCount_ = other.passWaveCount_;
			this.cumulativeKills_ = other.cumulativeKills_;
			this.propertyMap_ = other.propertyMap_.Clone();
			this.unlockWeapons_ = other.unlockWeapons_.Clone();
			this.unlockItems_ = other.unlockItems_.Clone();
			this.unlockRoles_ = other.unlockRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C68A RID: 50826 RVA: 0x001D5CDC File Offset: 0x001D3EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementInfo Clone()
		{
			return new KurotatoSettlementInfo(this);
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x0600C68B RID: 50827 RVA: 0x001D5CE4 File Offset: 0x001D3EE4
		// (set) Token: 0x0600C68C RID: 50828 RVA: 0x001D5CEC File Offset: 0x001D3EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPass
		{
			get
			{
				return this.isPass_;
			}
			set
			{
				this.isPass_ = value;
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x0600C68D RID: 50829 RVA: 0x001D5CF5 File Offset: 0x001D3EF5
		// (set) Token: 0x0600C68E RID: 50830 RVA: 0x001D5CFD File Offset: 0x001D3EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CompletionTime
		{
			get
			{
				return this.completionTime_;
			}
			set
			{
				this.completionTime_ = value;
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x0600C68F RID: 50831 RVA: 0x001D5D06 File Offset: 0x001D3F06
		// (set) Token: 0x0600C690 RID: 50832 RVA: 0x001D5D0E File Offset: 0x001D3F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData ItemPanelPbData
		{
			get
			{
				return this.itemPanelPbData_;
			}
			set
			{
				this.itemPanelPbData_ = value;
			}
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x0600C691 RID: 50833 RVA: 0x001D5D17 File Offset: 0x001D3F17
		// (set) Token: 0x0600C692 RID: 50834 RVA: 0x001D5D1F File Offset: 0x001D3F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData WeaponPanelPbData
		{
			get
			{
				return this.weaponPanelPbData_;
			}
			set
			{
				this.weaponPanelPbData_ = value;
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x0600C693 RID: 50835 RVA: 0x001D5D28 File Offset: 0x001D3F28
		// (set) Token: 0x0600C694 RID: 50836 RVA: 0x001D5D30 File Offset: 0x001D3F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassWaveCount
		{
			get
			{
				return this.passWaveCount_;
			}
			set
			{
				this.passWaveCount_ = value;
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x0600C695 RID: 50837 RVA: 0x001D5D39 File Offset: 0x001D3F39
		// (set) Token: 0x0600C696 RID: 50838 RVA: 0x001D5D41 File Offset: 0x001D3F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CumulativeKills
		{
			get
			{
				return this.cumulativeKills_;
			}
			set
			{
				this.cumulativeKills_ = value;
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x0600C697 RID: 50839 RVA: 0x001D5D4A File Offset: 0x001D3F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyMap
		{
			get
			{
				return this.propertyMap_;
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x0600C698 RID: 50840 RVA: 0x001D5D52 File Offset: 0x001D3F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeapons
		{
			get
			{
				return this.unlockWeapons_;
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x0600C699 RID: 50841 RVA: 0x001D5D5A File Offset: 0x001D3F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItems
		{
			get
			{
				return this.unlockItems_;
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x0600C69A RID: 50842 RVA: 0x001D5D62 File Offset: 0x001D3F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoles
		{
			get
			{
				return this.unlockRoles_;
			}
		}

		// Token: 0x0600C69B RID: 50843 RVA: 0x001D5D6A File Offset: 0x001D3F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSettlementInfo);
		}

		// Token: 0x0600C69C RID: 50844 RVA: 0x001D5D78 File Offset: 0x001D3F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSettlementInfo other)
		{
			return other != null && (other == this || (this.IsPass == other.IsPass && this.CompletionTime == other.CompletionTime && object.Equals(this.ItemPanelPbData, other.ItemPanelPbData) && object.Equals(this.WeaponPanelPbData, other.WeaponPanelPbData) && this.PassWaveCount == other.PassWaveCount && this.CumulativeKills == other.CumulativeKills && this.PropertyMap.Equals(other.PropertyMap) && this.unlockWeapons_.Equals(other.unlockWeapons_) && this.unlockItems_.Equals(other.unlockItems_) && this.unlockRoles_.Equals(other.unlockRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C69D RID: 50845 RVA: 0x001D5E60 File Offset: 0x001D4060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsPass)
			{
				num ^= this.IsPass.GetHashCode();
			}
			if (this.CompletionTime != 0)
			{
				num ^= this.CompletionTime.GetHashCode();
			}
			if (this.itemPanelPbData_ != null)
			{
				num ^= this.ItemPanelPbData.GetHashCode();
			}
			if (this.weaponPanelPbData_ != null)
			{
				num ^= this.WeaponPanelPbData.GetHashCode();
			}
			if (this.PassWaveCount != 0)
			{
				num ^= this.PassWaveCount.GetHashCode();
			}
			if (this.CumulativeKills != 0)
			{
				num ^= this.CumulativeKills.GetHashCode();
			}
			num ^= this.PropertyMap.GetHashCode();
			num ^= this.unlockWeapons_.GetHashCode();
			num ^= this.unlockItems_.GetHashCode();
			num ^= this.unlockRoles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C69E RID: 50846 RVA: 0x001D5F4E File Offset: 0x001D414E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C69F RID: 50847 RVA: 0x001D5F5B File Offset: 0x001D415B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x001D5F64 File Offset: 0x001D4164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsPass)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsPass);
			}
			if (this.CompletionTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CompletionTime);
			}
			if (this.itemPanelPbData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ItemPanelPbData);
			}
			if (this.weaponPanelPbData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.WeaponPanelPbData);
			}
			if (this.PassWaveCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PassWaveCount);
			}
			if (this.CumulativeKills != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CumulativeKills);
			}
			this.propertyMap_.WriteTo(ref output, KurotatoSettlementInfo._map_propertyMap_codec);
			this.unlockWeapons_.WriteTo(ref output, KurotatoSettlementInfo._repeated_unlockWeapons_codec);
			this.unlockItems_.WriteTo(ref output, KurotatoSettlementInfo._repeated_unlockItems_codec);
			this.unlockRoles_.WriteTo(ref output, KurotatoSettlementInfo._repeated_unlockRoles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x001D6074 File Offset: 0x001D4274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsPass)
			{
				num += 2;
			}
			if (this.CompletionTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompletionTime);
			}
			if (this.itemPanelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemPanelPbData);
			}
			if (this.weaponPanelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WeaponPanelPbData);
			}
			if (this.PassWaveCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassWaveCount);
			}
			if (this.CumulativeKills != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CumulativeKills);
			}
			num += this.propertyMap_.CalculateSize(KurotatoSettlementInfo._map_propertyMap_codec);
			num += this.unlockWeapons_.CalculateSize(KurotatoSettlementInfo._repeated_unlockWeapons_codec);
			num += this.unlockItems_.CalculateSize(KurotatoSettlementInfo._repeated_unlockItems_codec);
			num += this.unlockRoles_.CalculateSize(KurotatoSettlementInfo._repeated_unlockRoles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6A2 RID: 50850 RVA: 0x001D616C File Offset: 0x001D436C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSettlementInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsPass)
			{
				this.IsPass = other.IsPass;
			}
			if (other.CompletionTime != 0)
			{
				this.CompletionTime = other.CompletionTime;
			}
			if (other.itemPanelPbData_ != null)
			{
				if (this.itemPanelPbData_ == null)
				{
					this.ItemPanelPbData = new KurotatoItemPanelPbData();
				}
				this.ItemPanelPbData.MergeFrom(other.ItemPanelPbData);
			}
			if (other.weaponPanelPbData_ != null)
			{
				if (this.weaponPanelPbData_ == null)
				{
					this.WeaponPanelPbData = new KurotatoWeaponPanelPbData();
				}
				this.WeaponPanelPbData.MergeFrom(other.WeaponPanelPbData);
			}
			if (other.PassWaveCount != 0)
			{
				this.PassWaveCount = other.PassWaveCount;
			}
			if (other.CumulativeKills != 0)
			{
				this.CumulativeKills = other.CumulativeKills;
			}
			this.propertyMap_.MergeFrom(other.propertyMap_);
			this.unlockWeapons_.Add(other.unlockWeapons_);
			this.unlockItems_.Add(other.unlockItems_);
			this.unlockRoles_.Add(other.unlockRoles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x001D6280 File Offset: 0x001D4480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6A4 RID: 50852 RVA: 0x001D628C File Offset: 0x001D448C
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
				if (num <= 64U)
				{
					if (num <= 34U)
					{
						if (num == 16U)
						{
							this.IsPass = input.ReadBool();
							continue;
						}
						if (num == 24U)
						{
							this.CompletionTime = input.ReadInt32();
							continue;
						}
						if (num == 34U)
						{
							if (this.itemPanelPbData_ == null)
							{
								this.ItemPanelPbData = new KurotatoItemPanelPbData();
							}
							input.ReadMessage(this.ItemPanelPbData);
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							if (this.weaponPanelPbData_ == null)
							{
								this.WeaponPanelPbData = new KurotatoWeaponPanelPbData();
							}
							input.ReadMessage(this.WeaponPanelPbData);
							continue;
						}
						if (num == 56U)
						{
							this.PassWaveCount = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.CumulativeKills = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 74U)
					{
						this.propertyMap_.AddEntriesFrom(ref input, KurotatoSettlementInfo._map_propertyMap_codec);
						continue;
					}
					if (num == 80U || num == 82U)
					{
						this.unlockWeapons_.AddEntriesFrom(ref input, KurotatoSettlementInfo._repeated_unlockWeapons_codec);
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num == 88U || num == 90U)
					{
						this.unlockItems_.AddEntriesFrom(ref input, KurotatoSettlementInfo._repeated_unlockItems_codec);
						continue;
					}
				}
				else if (num == 96U || num == 98U)
				{
					this.unlockRoles_.AddEntriesFrom(ref input, KurotatoSettlementInfo._repeated_unlockRoles_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005534 RID: 21812
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005535 RID: 21813
		public const int IsPassFieldNumber = 2;

		// Token: 0x04005536 RID: 21814
		private bool isPass_;

		// Token: 0x04005537 RID: 21815
		public const int CompletionTimeFieldNumber = 3;

		// Token: 0x04005538 RID: 21816
		private int completionTime_;

		// Token: 0x04005539 RID: 21817
		public const int ItemPanelPbDataFieldNumber = 4;

		// Token: 0x0400553A RID: 21818
		private KurotatoItemPanelPbData itemPanelPbData_;

		// Token: 0x0400553B RID: 21819
		public const int WeaponPanelPbDataFieldNumber = 5;

		// Token: 0x0400553C RID: 21820
		private KurotatoWeaponPanelPbData weaponPanelPbData_;

		// Token: 0x0400553D RID: 21821
		public const int PassWaveCountFieldNumber = 7;

		// Token: 0x0400553E RID: 21822
		private int passWaveCount_;

		// Token: 0x0400553F RID: 21823
		public const int CumulativeKillsFieldNumber = 8;

		// Token: 0x04005540 RID: 21824
		private int cumulativeKills_;

		// Token: 0x04005541 RID: 21825
		public const int PropertyMapFieldNumber = 9;

		// Token: 0x04005542 RID: 21826
		private static readonly MapField<int, int>.Codec _map_propertyMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04005543 RID: 21827
		private readonly MapField<int, int> propertyMap_ = new MapField<int, int>();

		// Token: 0x04005544 RID: 21828
		public const int UnlockWeaponsFieldNumber = 10;

		// Token: 0x04005545 RID: 21829
		private static readonly FieldCodec<int> _repeated_unlockWeapons_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005546 RID: 21830
		private readonly RepeatedField<int> unlockWeapons_ = new RepeatedField<int>();

		// Token: 0x04005547 RID: 21831
		public const int UnlockItemsFieldNumber = 11;

		// Token: 0x04005548 RID: 21832
		private static readonly FieldCodec<int> _repeated_unlockItems_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005549 RID: 21833
		private readonly RepeatedField<int> unlockItems_ = new RepeatedField<int>();

		// Token: 0x0400554A RID: 21834
		public const int UnlockRolesFieldNumber = 12;

		// Token: 0x0400554B RID: 21835
		private static readonly FieldCodec<int> _repeated_unlockRoles_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400554C RID: 21836
		private readonly RepeatedField<int> unlockRoles_ = new RepeatedField<int>();
	}
}
