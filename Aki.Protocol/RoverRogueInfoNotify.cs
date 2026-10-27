using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001106 RID: 4358
	[NetMessage(EMessageId.RoverRogueInfoNotify)]
	public sealed class RoverRogueInfoNotify : IMessage<RoverRogueInfoNotify>, IMessage, IEquatable<RoverRogueInfoNotify>, IDeepCloneable<RoverRogueInfoNotify>, IBufferMessage
	{
		// Token: 0x060173C7 RID: 95175 RVA: 0x0035F3DC File Offset: 0x0035D5DC
		[NullableContext(1)]
		public static RoverRogueInfoNotify Create()
		{
			return new RoverRogueInfoNotify();
		}

		// Token: 0x17004DDE RID: 19934
		// (get) Token: 0x060173C8 RID: 95176 RVA: 0x0035F3E3 File Offset: 0x0035D5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DDF RID: 19935
		// (get) Token: 0x060173C9 RID: 95177 RVA: 0x0035F3E6 File Offset: 0x0035D5E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInfoNotify.Descriptor;
			}
		}

		// Token: 0x060173CA RID: 95178 RVA: 0x0035F3F0 File Offset: 0x0035D5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInfoNotify()
		{
		}

		// Token: 0x060173CB RID: 95179 RVA: 0x0035F448 File Offset: 0x0035D648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInfoNotify(RoverRogueInfoNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instState_ = other.instState_;
			this.instId_ = other.instId_;
			this.bless_ = other.bless_.Clone();
			this.roleEnhance_ = other.roleEnhance_.Clone();
			this.lootItem_ = other.lootItem_.Clone();
			this.item_ = other.item_.Clone();
			this.gold_ = other.gold_;
			this.talentPoint_ = other.talentPoint_;
			this.resurrectionRest_ = other.resurrectionRest_;
			this.resurrectionMax_ = other.resurrectionMax_;
			this.roverHp_ = other.roverHp_;
			this.roverMaxHp_ = other.roverMaxHp_;
			this.roverEnergy_ = other.roverEnergy_;
			this.lootDict_ = other.lootDict_.Clone();
			this.itemData_ = other.itemData_.Clone();
			this.roverRogueRoadType_ = other.roverRogueRoadType_;
			this.roverRogueCoinId_ = other.roverRogueCoinId_;
			this.roverType_ = other.roverType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060173CC RID: 95180 RVA: 0x0035F56E File Offset: 0x0035D76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInfoNotify Clone()
		{
			return new RoverRogueInfoNotify(this);
		}

		// Token: 0x17004DE0 RID: 19936
		// (get) Token: 0x060173CD RID: 95181 RVA: 0x0035F576 File Offset: 0x0035D776
		// (set) Token: 0x060173CE RID: 95182 RVA: 0x0035F57E File Offset: 0x0035D77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004DE1 RID: 19937
		// (get) Token: 0x060173CF RID: 95183 RVA: 0x0035F587 File Offset: 0x0035D787
		// (set) Token: 0x060173D0 RID: 95184 RVA: 0x0035F58F File Offset: 0x0035D78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInstState InstState
		{
			get
			{
				return this.instState_;
			}
			set
			{
				this.instState_ = value;
			}
		}

		// Token: 0x17004DE2 RID: 19938
		// (get) Token: 0x060173D1 RID: 95185 RVA: 0x0035F598 File Offset: 0x0035D798
		// (set) Token: 0x060173D2 RID: 95186 RVA: 0x0035F5A0 File Offset: 0x0035D7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17004DE3 RID: 19939
		// (get) Token: 0x060173D3 RID: 95187 RVA: 0x0035F5A9 File Offset: 0x0035D7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Bless
		{
			get
			{
				return this.bless_;
			}
		}

		// Token: 0x17004DE4 RID: 19940
		// (get) Token: 0x060173D4 RID: 95188 RVA: 0x0035F5B1 File Offset: 0x0035D7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoleEnhance
		{
			get
			{
				return this.roleEnhance_;
			}
		}

		// Token: 0x17004DE5 RID: 19941
		// (get) Token: 0x060173D5 RID: 95189 RVA: 0x0035F5B9 File Offset: 0x0035D7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> LootItem
		{
			get
			{
				return this.lootItem_;
			}
		}

		// Token: 0x17004DE6 RID: 19942
		// (get) Token: 0x060173D6 RID: 95190 RVA: 0x0035F5C1 File Offset: 0x0035D7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Item
		{
			get
			{
				return this.item_;
			}
		}

		// Token: 0x17004DE7 RID: 19943
		// (get) Token: 0x060173D7 RID: 95191 RVA: 0x0035F5C9 File Offset: 0x0035D7C9
		// (set) Token: 0x060173D8 RID: 95192 RVA: 0x0035F5D1 File Offset: 0x0035D7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Gold
		{
			get
			{
				return this.gold_;
			}
			set
			{
				this.gold_ = value;
			}
		}

		// Token: 0x17004DE8 RID: 19944
		// (get) Token: 0x060173D9 RID: 95193 RVA: 0x0035F5DA File Offset: 0x0035D7DA
		// (set) Token: 0x060173DA RID: 95194 RVA: 0x0035F5E2 File Offset: 0x0035D7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentPoint
		{
			get
			{
				return this.talentPoint_;
			}
			set
			{
				this.talentPoint_ = value;
			}
		}

		// Token: 0x17004DE9 RID: 19945
		// (get) Token: 0x060173DB RID: 95195 RVA: 0x0035F5EB File Offset: 0x0035D7EB
		// (set) Token: 0x060173DC RID: 95196 RVA: 0x0035F5F3 File Offset: 0x0035D7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResurrectionRest
		{
			get
			{
				return this.resurrectionRest_;
			}
			set
			{
				this.resurrectionRest_ = value;
			}
		}

		// Token: 0x17004DEA RID: 19946
		// (get) Token: 0x060173DD RID: 95197 RVA: 0x0035F5FC File Offset: 0x0035D7FC
		// (set) Token: 0x060173DE RID: 95198 RVA: 0x0035F604 File Offset: 0x0035D804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResurrectionMax
		{
			get
			{
				return this.resurrectionMax_;
			}
			set
			{
				this.resurrectionMax_ = value;
			}
		}

		// Token: 0x17004DEB RID: 19947
		// (get) Token: 0x060173DF RID: 95199 RVA: 0x0035F60D File Offset: 0x0035D80D
		// (set) Token: 0x060173E0 RID: 95200 RVA: 0x0035F615 File Offset: 0x0035D815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverHp
		{
			get
			{
				return this.roverHp_;
			}
			set
			{
				this.roverHp_ = value;
			}
		}

		// Token: 0x17004DEC RID: 19948
		// (get) Token: 0x060173E1 RID: 95201 RVA: 0x0035F61E File Offset: 0x0035D81E
		// (set) Token: 0x060173E2 RID: 95202 RVA: 0x0035F626 File Offset: 0x0035D826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverMaxHp
		{
			get
			{
				return this.roverMaxHp_;
			}
			set
			{
				this.roverMaxHp_ = value;
			}
		}

		// Token: 0x17004DED RID: 19949
		// (get) Token: 0x060173E3 RID: 95203 RVA: 0x0035F62F File Offset: 0x0035D82F
		// (set) Token: 0x060173E4 RID: 95204 RVA: 0x0035F637 File Offset: 0x0035D837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverEnergy
		{
			get
			{
				return this.roverEnergy_;
			}
			set
			{
				this.roverEnergy_ = value;
			}
		}

		// Token: 0x17004DEE RID: 19950
		// (get) Token: 0x060173E5 RID: 95205 RVA: 0x0035F640 File Offset: 0x0035D840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueLootEntry> LootDict
		{
			get
			{
				return this.lootDict_;
			}
		}

		// Token: 0x17004DEF RID: 19951
		// (get) Token: 0x060173E6 RID: 95206 RVA: 0x0035F648 File Offset: 0x0035D848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueItemCurrencyData> ItemData
		{
			get
			{
				return this.itemData_;
			}
		}

		// Token: 0x17004DF0 RID: 19952
		// (get) Token: 0x060173E7 RID: 95207 RVA: 0x0035F650 File Offset: 0x0035D850
		// (set) Token: 0x060173E8 RID: 95208 RVA: 0x0035F658 File Offset: 0x0035D858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverRogueRoadType
		{
			get
			{
				return this.roverRogueRoadType_;
			}
			set
			{
				this.roverRogueRoadType_ = value;
			}
		}

		// Token: 0x17004DF1 RID: 19953
		// (get) Token: 0x060173E9 RID: 95209 RVA: 0x0035F661 File Offset: 0x0035D861
		// (set) Token: 0x060173EA RID: 95210 RVA: 0x0035F669 File Offset: 0x0035D869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverRogueCoinId
		{
			get
			{
				return this.roverRogueCoinId_;
			}
			set
			{
				this.roverRogueCoinId_ = value;
			}
		}

		// Token: 0x17004DF2 RID: 19954
		// (get) Token: 0x060173EB RID: 95211 RVA: 0x0035F672 File Offset: 0x0035D872
		// (set) Token: 0x060173EC RID: 95212 RVA: 0x0035F67A File Offset: 0x0035D87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverType
		{
			get
			{
				return this.roverType_;
			}
			set
			{
				this.roverType_ = value;
			}
		}

		// Token: 0x060173ED RID: 95213 RVA: 0x0035F683 File Offset: 0x0035D883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInfoNotify);
		}

		// Token: 0x060173EE RID: 95214 RVA: 0x0035F694 File Offset: 0x0035D894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInfoNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstState == other.InstState && this.InstId == other.InstId && this.bless_.Equals(other.bless_) && this.roleEnhance_.Equals(other.roleEnhance_) && this.lootItem_.Equals(other.lootItem_) && this.item_.Equals(other.item_) && this.Gold == other.Gold && this.TalentPoint == other.TalentPoint && this.ResurrectionRest == other.ResurrectionRest && this.ResurrectionMax == other.ResurrectionMax && this.RoverHp == other.RoverHp && this.RoverMaxHp == other.RoverMaxHp && this.RoverEnergy == other.RoverEnergy && this.lootDict_.Equals(other.lootDict_) && this.itemData_.Equals(other.itemData_) && this.RoverRogueRoadType == other.RoverRogueRoadType && this.RoverRogueCoinId == other.RoverRogueCoinId && this.RoverType == other.RoverType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060173EF RID: 95215 RVA: 0x0035F80C File Offset: 0x0035DA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstState != RoverRogueInstState.RoverRogueInstNotStart)
			{
				num ^= this.InstState.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.bless_.GetHashCode();
			num ^= this.roleEnhance_.GetHashCode();
			num ^= this.lootItem_.GetHashCode();
			num ^= this.item_.GetHashCode();
			if (this.Gold != 0)
			{
				num ^= this.Gold.GetHashCode();
			}
			if (this.TalentPoint != 0)
			{
				num ^= this.TalentPoint.GetHashCode();
			}
			if (this.ResurrectionRest != 0)
			{
				num ^= this.ResurrectionRest.GetHashCode();
			}
			if (this.ResurrectionMax != 0)
			{
				num ^= this.ResurrectionMax.GetHashCode();
			}
			if (this.RoverHp != 0)
			{
				num ^= this.RoverHp.GetHashCode();
			}
			if (this.RoverMaxHp != 0)
			{
				num ^= this.RoverMaxHp.GetHashCode();
			}
			if (this.RoverEnergy != 0)
			{
				num ^= this.RoverEnergy.GetHashCode();
			}
			num ^= this.lootDict_.GetHashCode();
			num ^= this.itemData_.GetHashCode();
			if (this.RoverRogueRoadType != 0)
			{
				num ^= this.RoverRogueRoadType.GetHashCode();
			}
			if (this.RoverRogueCoinId != 0)
			{
				num ^= this.RoverRogueCoinId.GetHashCode();
			}
			if (this.RoverType != 0)
			{
				num ^= this.RoverType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060173F0 RID: 95216 RVA: 0x0035F9D1 File Offset: 0x0035DBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060173F1 RID: 95217 RVA: 0x0035F9DE File Offset: 0x0035DBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060173F2 RID: 95218 RVA: 0x0035F9E8 File Offset: 0x0035DBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResurrectionMax != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ResurrectionMax);
			}
			this.roleEnhance_.WriteTo(ref output, RoverRogueInfoNotify._repeated_roleEnhance_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(192, 3);
				output.WriteInt32(this.ActivityId);
			}
			this.item_.WriteTo(ref output, RoverRogueInfoNotify._repeated_item_codec);
			if (this.RoverHp != 0)
			{
				output.WriteRawTag(248, 4);
				output.WriteInt32(this.RoverHp);
			}
			this.lootDict_.WriteTo(ref output, RoverRogueInfoNotify._repeated_lootDict_codec);
			if (this.ResurrectionRest != 0)
			{
				output.WriteRawTag(184, 6);
				output.WriteInt32(this.ResurrectionRest);
			}
			if (this.Gold != 0)
			{
				output.WriteRawTag(240, 6);
				output.WriteInt32(this.Gold);
			}
			if (this.RoverMaxHp != 0)
			{
				output.WriteRawTag(200, 7);
				output.WriteInt32(this.RoverMaxHp);
			}
			this.bless_.WriteTo(ref output, RoverRogueInfoNotify._repeated_bless_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(144, 8);
				output.WriteInt32(this.InstId);
			}
			if (this.InstState != RoverRogueInstState.RoverRogueInstNotStart)
			{
				output.WriteRawTag(152, 8);
				output.WriteEnum((int)this.InstState);
			}
			this.lootItem_.WriteTo(ref output, RoverRogueInfoNotify._repeated_lootItem_codec);
			if (this.RoverType != 0)
			{
				output.WriteRawTag(136, 12);
				output.WriteInt32(this.RoverType);
			}
			if (this.RoverRogueRoadType != 0)
			{
				output.WriteRawTag(168, 12);
				output.WriteInt32(this.RoverRogueRoadType);
			}
			this.itemData_.WriteTo(ref output, RoverRogueInfoNotify._repeated_itemData_codec);
			if (this.TalentPoint != 0)
			{
				output.WriteRawTag(240, 13);
				output.WriteInt32(this.TalentPoint);
			}
			if (this.RoverEnergy != 0)
			{
				output.WriteRawTag(128, 14);
				output.WriteInt32(this.RoverEnergy);
			}
			if (this.RoverRogueCoinId != 0)
			{
				output.WriteRawTag(232, 15);
				output.WriteInt32(this.RoverRogueCoinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060173F3 RID: 95219 RVA: 0x0035FC10 File Offset: 0x0035DE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstState != RoverRogueInstState.RoverRogueInstNotStart)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.InstState);
			}
			if (this.InstId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.bless_.CalculateSize(RoverRogueInfoNotify._repeated_bless_codec);
			num += this.roleEnhance_.CalculateSize(RoverRogueInfoNotify._repeated_roleEnhance_codec);
			num += this.lootItem_.CalculateSize(RoverRogueInfoNotify._repeated_lootItem_codec);
			num += this.item_.CalculateSize(RoverRogueInfoNotify._repeated_item_codec);
			if (this.Gold != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Gold);
			}
			if (this.TalentPoint != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TalentPoint);
			}
			if (this.ResurrectionRest != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ResurrectionRest);
			}
			if (this.ResurrectionMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResurrectionMax);
			}
			if (this.RoverHp != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoverHp);
			}
			if (this.RoverMaxHp != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoverMaxHp);
			}
			if (this.RoverEnergy != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoverEnergy);
			}
			num += this.lootDict_.CalculateSize(RoverRogueInfoNotify._repeated_lootDict_codec);
			num += this.itemData_.CalculateSize(RoverRogueInfoNotify._repeated_itemData_codec);
			if (this.RoverRogueRoadType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoverRogueRoadType);
			}
			if (this.RoverRogueCoinId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoverRogueCoinId);
			}
			if (this.RoverType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoverType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060173F4 RID: 95220 RVA: 0x0035FDE0 File Offset: 0x0035DFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstState != RoverRogueInstState.RoverRogueInstNotStart)
			{
				this.InstState = other.InstState;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.bless_.Add(other.bless_);
			this.roleEnhance_.Add(other.roleEnhance_);
			this.lootItem_.Add(other.lootItem_);
			this.item_.Add(other.item_);
			if (other.Gold != 0)
			{
				this.Gold = other.Gold;
			}
			if (other.TalentPoint != 0)
			{
				this.TalentPoint = other.TalentPoint;
			}
			if (other.ResurrectionRest != 0)
			{
				this.ResurrectionRest = other.ResurrectionRest;
			}
			if (other.ResurrectionMax != 0)
			{
				this.ResurrectionMax = other.ResurrectionMax;
			}
			if (other.RoverHp != 0)
			{
				this.RoverHp = other.RoverHp;
			}
			if (other.RoverMaxHp != 0)
			{
				this.RoverMaxHp = other.RoverMaxHp;
			}
			if (other.RoverEnergy != 0)
			{
				this.RoverEnergy = other.RoverEnergy;
			}
			this.lootDict_.Add(other.lootDict_);
			this.itemData_.Add(other.itemData_);
			if (other.RoverRogueRoadType != 0)
			{
				this.RoverRogueRoadType = other.RoverRogueRoadType;
			}
			if (other.RoverRogueCoinId != 0)
			{
				this.RoverRogueCoinId = other.RoverRogueCoinId;
			}
			if (other.RoverType != 0)
			{
				this.RoverType = other.RoverType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060173F5 RID: 95221 RVA: 0x0035FF72 File Offset: 0x0035E172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060173F6 RID: 95222 RVA: 0x0035FF7C File Offset: 0x0035E17C
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
				if (num <= 968U)
				{
					if (num <= 578U)
					{
						if (num <= 306U)
						{
							if (num == 112U)
							{
								this.ResurrectionMax = input.ReadInt32();
								continue;
							}
							if (num == 306U)
							{
								this.roleEnhance_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_roleEnhance_codec);
								continue;
							}
						}
						else
						{
							if (num == 448U)
							{
								this.ActivityId = input.ReadInt32();
								continue;
							}
							if (num == 578U)
							{
								this.item_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_item_codec);
								continue;
							}
						}
					}
					else if (num <= 706U)
					{
						if (num == 632U)
						{
							this.RoverHp = input.ReadInt32();
							continue;
						}
						if (num == 706U)
						{
							this.lootDict_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_lootDict_codec);
							continue;
						}
					}
					else
					{
						if (num == 824U)
						{
							this.ResurrectionRest = input.ReadInt32();
							continue;
						}
						if (num == 880U)
						{
							this.Gold = input.ReadInt32();
							continue;
						}
						if (num == 968U)
						{
							this.RoverMaxHp = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1544U)
				{
					if (num <= 1040U)
					{
						if (num == 1018U)
						{
							this.bless_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_bless_codec);
							continue;
						}
						if (num == 1040U)
						{
							this.InstId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 1048U)
						{
							this.InstState = (RoverRogueInstState)input.ReadEnum();
							continue;
						}
						if (num == 1274U)
						{
							this.lootItem_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_lootItem_codec);
							continue;
						}
						if (num == 1544U)
						{
							this.RoverType = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1754U)
				{
					if (num == 1576U)
					{
						this.RoverRogueRoadType = input.ReadInt32();
						continue;
					}
					if (num == 1754U)
					{
						this.itemData_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_itemData_codec);
						continue;
					}
				}
				else
				{
					if (num == 1776U)
					{
						this.TalentPoint = input.ReadInt32();
						continue;
					}
					if (num == 1792U)
					{
						this.RoverEnergy = input.ReadInt32();
						continue;
					}
					if (num == 2024U)
					{
						this.RoverRogueCoinId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A25 RID: 35365
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A26 RID: 35366
		public const int ActivityIdFieldNumber = 56;

		// Token: 0x04008A27 RID: 35367
		private int activityId_;

		// Token: 0x04008A28 RID: 35368
		public const int InstStateFieldNumber = 131;

		// Token: 0x04008A29 RID: 35369
		private RoverRogueInstState instState_;

		// Token: 0x04008A2A RID: 35370
		public const int InstIdFieldNumber = 130;

		// Token: 0x04008A2B RID: 35371
		private int instId_;

		// Token: 0x04008A2C RID: 35372
		public const int BlessFieldNumber = 127;

		// Token: 0x04008A2D RID: 35373
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_bless_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(1018U, RoverRogueGainEntry.Parser);

		// Token: 0x04008A2E RID: 35374
		private readonly RepeatedField<RoverRogueGainEntry> bless_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008A2F RID: 35375
		public const int RoleEnhanceFieldNumber = 38;

		// Token: 0x04008A30 RID: 35376
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roleEnhance_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(306U, RoverRogueGainEntry.Parser);

		// Token: 0x04008A31 RID: 35377
		private readonly RepeatedField<RoverRogueGainEntry> roleEnhance_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008A32 RID: 35378
		public const int LootItemFieldNumber = 159;

		// Token: 0x04008A33 RID: 35379
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_lootItem_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(1274U, RoverRogueGainEntry.Parser);

		// Token: 0x04008A34 RID: 35380
		private readonly RepeatedField<RoverRogueGainEntry> lootItem_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008A35 RID: 35381
		public const int ItemFieldNumber = 72;

		// Token: 0x04008A36 RID: 35382
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_item_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(578U, RoverRogueGainEntry.Parser);

		// Token: 0x04008A37 RID: 35383
		private readonly RepeatedField<RoverRogueGainEntry> item_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008A38 RID: 35384
		public const int GoldFieldNumber = 110;

		// Token: 0x04008A39 RID: 35385
		private int gold_;

		// Token: 0x04008A3A RID: 35386
		public const int TalentPointFieldNumber = 222;

		// Token: 0x04008A3B RID: 35387
		private int talentPoint_;

		// Token: 0x04008A3C RID: 35388
		public const int ResurrectionRestFieldNumber = 103;

		// Token: 0x04008A3D RID: 35389
		private int resurrectionRest_;

		// Token: 0x04008A3E RID: 35390
		public const int ResurrectionMaxFieldNumber = 14;

		// Token: 0x04008A3F RID: 35391
		private int resurrectionMax_;

		// Token: 0x04008A40 RID: 35392
		public const int RoverHpFieldNumber = 79;

		// Token: 0x04008A41 RID: 35393
		private int roverHp_;

		// Token: 0x04008A42 RID: 35394
		public const int RoverMaxHpFieldNumber = 121;

		// Token: 0x04008A43 RID: 35395
		private int roverMaxHp_;

		// Token: 0x04008A44 RID: 35396
		public const int RoverEnergyFieldNumber = 224;

		// Token: 0x04008A45 RID: 35397
		private int roverEnergy_;

		// Token: 0x04008A46 RID: 35398
		public const int LootDictFieldNumber = 88;

		// Token: 0x04008A47 RID: 35399
		private static readonly FieldCodec<RoverRogueLootEntry> _repeated_lootDict_codec = FieldCodec.ForMessage<RoverRogueLootEntry>(706U, RoverRogueLootEntry.Parser);

		// Token: 0x04008A48 RID: 35400
		private readonly RepeatedField<RoverRogueLootEntry> lootDict_ = new RepeatedField<RoverRogueLootEntry>();

		// Token: 0x04008A49 RID: 35401
		public const int ItemDataFieldNumber = 219;

		// Token: 0x04008A4A RID: 35402
		private static readonly FieldCodec<RoverRogueItemCurrencyData> _repeated_itemData_codec = FieldCodec.ForMessage<RoverRogueItemCurrencyData>(1754U, RoverRogueItemCurrencyData.Parser);

		// Token: 0x04008A4B RID: 35403
		private readonly RepeatedField<RoverRogueItemCurrencyData> itemData_ = new RepeatedField<RoverRogueItemCurrencyData>();

		// Token: 0x04008A4C RID: 35404
		public const int RoverRogueRoadTypeFieldNumber = 197;

		// Token: 0x04008A4D RID: 35405
		private int roverRogueRoadType_;

		// Token: 0x04008A4E RID: 35406
		public const int RoverRogueCoinIdFieldNumber = 253;

		// Token: 0x04008A4F RID: 35407
		private int roverRogueCoinId_;

		// Token: 0x04008A50 RID: 35408
		public const int RoverTypeFieldNumber = 193;

		// Token: 0x04008A51 RID: 35409
		private int roverType_;
	}
}
