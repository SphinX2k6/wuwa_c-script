using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AE RID: 2222
	public sealed class KurotatoSettlementInfo : IMessage<KurotatoSettlementInfo>, IMessage, IEquatable<KurotatoSettlementInfo>, IDeepCloneable<KurotatoSettlementInfo>, IBufferMessage
	{
		// Token: 0x0600C569 RID: 50537 RVA: 0x001D38DF File Offset: 0x001D1ADF
		[NullableContext(1)]
		public static KurotatoSettlementInfo Create()
		{
			return new KurotatoSettlementInfo();
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x0600C56A RID: 50538 RVA: 0x001D38E6 File Offset: 0x001D1AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x0600C56B RID: 50539 RVA: 0x001D38E9 File Offset: 0x001D1AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSettlementInfo.Descriptor;
			}
		}

		// Token: 0x0600C56C RID: 50540 RVA: 0x001D38F0 File Offset: 0x001D1AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementInfo()
		{
		}

		// Token: 0x0600C56D RID: 50541 RVA: 0x001D3924 File Offset: 0x001D1B24
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

		// Token: 0x0600C56E RID: 50542 RVA: 0x001D39F4 File Offset: 0x001D1BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementInfo Clone()
		{
			return new KurotatoSettlementInfo(this);
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x0600C56F RID: 50543 RVA: 0x001D39FC File Offset: 0x001D1BFC
		// (set) Token: 0x0600C570 RID: 50544 RVA: 0x001D3A04 File Offset: 0x001D1C04
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

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x0600C571 RID: 50545 RVA: 0x001D3A0D File Offset: 0x001D1C0D
		// (set) Token: 0x0600C572 RID: 50546 RVA: 0x001D3A15 File Offset: 0x001D1C15
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

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x0600C573 RID: 50547 RVA: 0x001D3A1E File Offset: 0x001D1C1E
		// (set) Token: 0x0600C574 RID: 50548 RVA: 0x001D3A26 File Offset: 0x001D1C26
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

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x0600C575 RID: 50549 RVA: 0x001D3A2F File Offset: 0x001D1C2F
		// (set) Token: 0x0600C576 RID: 50550 RVA: 0x001D3A37 File Offset: 0x001D1C37
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

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x0600C577 RID: 50551 RVA: 0x001D3A40 File Offset: 0x001D1C40
		// (set) Token: 0x0600C578 RID: 50552 RVA: 0x001D3A48 File Offset: 0x001D1C48
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

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x0600C579 RID: 50553 RVA: 0x001D3A51 File Offset: 0x001D1C51
		// (set) Token: 0x0600C57A RID: 50554 RVA: 0x001D3A59 File Offset: 0x001D1C59
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

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x0600C57B RID: 50555 RVA: 0x001D3A62 File Offset: 0x001D1C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyMap
		{
			get
			{
				return this.propertyMap_;
			}
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x0600C57C RID: 50556 RVA: 0x001D3A6A File Offset: 0x001D1C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeapons
		{
			get
			{
				return this.unlockWeapons_;
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x0600C57D RID: 50557 RVA: 0x001D3A72 File Offset: 0x001D1C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItems
		{
			get
			{
				return this.unlockItems_;
			}
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x0600C57E RID: 50558 RVA: 0x001D3A7A File Offset: 0x001D1C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoles
		{
			get
			{
				return this.unlockRoles_;
			}
		}

		// Token: 0x0600C57F RID: 50559 RVA: 0x001D3A82 File Offset: 0x001D1C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSettlementInfo);
		}

		// Token: 0x0600C580 RID: 50560 RVA: 0x001D3A90 File Offset: 0x001D1C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSettlementInfo other)
		{
			return other != null && (other == this || (this.IsPass == other.IsPass && this.CompletionTime == other.CompletionTime && object.Equals(this.ItemPanelPbData, other.ItemPanelPbData) && object.Equals(this.WeaponPanelPbData, other.WeaponPanelPbData) && this.PassWaveCount == other.PassWaveCount && this.CumulativeKills == other.CumulativeKills && this.PropertyMap.Equals(other.PropertyMap) && this.unlockWeapons_.Equals(other.unlockWeapons_) && this.unlockItems_.Equals(other.unlockItems_) && this.unlockRoles_.Equals(other.unlockRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C581 RID: 50561 RVA: 0x001D3B78 File Offset: 0x001D1D78
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

		// Token: 0x0600C582 RID: 50562 RVA: 0x001D3C66 File Offset: 0x001D1E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C583 RID: 50563 RVA: 0x001D3C73 File Offset: 0x001D1E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C584 RID: 50564 RVA: 0x001D3C7C File Offset: 0x001D1E7C
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

		// Token: 0x0600C585 RID: 50565 RVA: 0x001D3D8C File Offset: 0x001D1F8C
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

		// Token: 0x0600C586 RID: 50566 RVA: 0x001D3E84 File Offset: 0x001D2084
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

		// Token: 0x0600C587 RID: 50567 RVA: 0x001D3F98 File Offset: 0x001D2198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C588 RID: 50568 RVA: 0x001D3FA4 File Offset: 0x001D21A4
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

		// Token: 0x0400553B RID: 21819
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400553C RID: 21820
		public const int IsPassFieldNumber = 2;

		// Token: 0x0400553D RID: 21821
		private bool isPass_;

		// Token: 0x0400553E RID: 21822
		public const int CompletionTimeFieldNumber = 3;

		// Token: 0x0400553F RID: 21823
		private int completionTime_;

		// Token: 0x04005540 RID: 21824
		public const int ItemPanelPbDataFieldNumber = 4;

		// Token: 0x04005541 RID: 21825
		private KurotatoItemPanelPbData itemPanelPbData_;

		// Token: 0x04005542 RID: 21826
		public const int WeaponPanelPbDataFieldNumber = 5;

		// Token: 0x04005543 RID: 21827
		private KurotatoWeaponPanelPbData weaponPanelPbData_;

		// Token: 0x04005544 RID: 21828
		public const int PassWaveCountFieldNumber = 7;

		// Token: 0x04005545 RID: 21829
		private int passWaveCount_;

		// Token: 0x04005546 RID: 21830
		public const int CumulativeKillsFieldNumber = 8;

		// Token: 0x04005547 RID: 21831
		private int cumulativeKills_;

		// Token: 0x04005548 RID: 21832
		public const int PropertyMapFieldNumber = 9;

		// Token: 0x04005549 RID: 21833
		private static readonly MapField<int, int>.Codec _map_propertyMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x0400554A RID: 21834
		private readonly MapField<int, int> propertyMap_ = new MapField<int, int>();

		// Token: 0x0400554B RID: 21835
		public const int UnlockWeaponsFieldNumber = 10;

		// Token: 0x0400554C RID: 21836
		private static readonly FieldCodec<int> _repeated_unlockWeapons_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400554D RID: 21837
		private readonly RepeatedField<int> unlockWeapons_ = new RepeatedField<int>();

		// Token: 0x0400554E RID: 21838
		public const int UnlockItemsFieldNumber = 11;

		// Token: 0x0400554F RID: 21839
		private static readonly FieldCodec<int> _repeated_unlockItems_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005550 RID: 21840
		private readonly RepeatedField<int> unlockItems_ = new RepeatedField<int>();

		// Token: 0x04005551 RID: 21841
		public const int UnlockRolesFieldNumber = 12;

		// Token: 0x04005552 RID: 21842
		private static readonly FieldCodec<int> _repeated_unlockRoles_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04005553 RID: 21843
		private readonly RepeatedField<int> unlockRoles_ = new RepeatedField<int>();
	}
}
