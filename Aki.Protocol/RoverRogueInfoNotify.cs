using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001140 RID: 4416
	[NetMessage(EMessageId.RoverRogueInfoNotify)]
	public sealed class RoverRogueInfoNotify : IMessage<RoverRogueInfoNotify>, IMessage, IEquatable<RoverRogueInfoNotify>, IDeepCloneable<RoverRogueInfoNotify>, IBufferMessage
	{
		// Token: 0x06017968 RID: 96616 RVA: 0x0036E72C File Offset: 0x0036C92C
		[NullableContext(1)]
		public static RoverRogueInfoNotify Create()
		{
			return new RoverRogueInfoNotify();
		}

		// Token: 0x17004F4A RID: 20298
		// (get) Token: 0x06017969 RID: 96617 RVA: 0x0036E733 File Offset: 0x0036C933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F4B RID: 20299
		// (get) Token: 0x0601796A RID: 96618 RVA: 0x0036E736 File Offset: 0x0036C936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601796B RID: 96619 RVA: 0x0036E740 File Offset: 0x0036C940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInfoNotify()
		{
		}

		// Token: 0x0601796C RID: 96620 RVA: 0x0036E798 File Offset: 0x0036C998
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

		// Token: 0x0601796D RID: 96621 RVA: 0x0036E8BE File Offset: 0x0036CABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInfoNotify Clone()
		{
			return new RoverRogueInfoNotify(this);
		}

		// Token: 0x17004F4C RID: 20300
		// (get) Token: 0x0601796E RID: 96622 RVA: 0x0036E8C6 File Offset: 0x0036CAC6
		// (set) Token: 0x0601796F RID: 96623 RVA: 0x0036E8CE File Offset: 0x0036CACE
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

		// Token: 0x17004F4D RID: 20301
		// (get) Token: 0x06017970 RID: 96624 RVA: 0x0036E8D7 File Offset: 0x0036CAD7
		// (set) Token: 0x06017971 RID: 96625 RVA: 0x0036E8DF File Offset: 0x0036CADF
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

		// Token: 0x17004F4E RID: 20302
		// (get) Token: 0x06017972 RID: 96626 RVA: 0x0036E8E8 File Offset: 0x0036CAE8
		// (set) Token: 0x06017973 RID: 96627 RVA: 0x0036E8F0 File Offset: 0x0036CAF0
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

		// Token: 0x17004F4F RID: 20303
		// (get) Token: 0x06017974 RID: 96628 RVA: 0x0036E8F9 File Offset: 0x0036CAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Bless
		{
			get
			{
				return this.bless_;
			}
		}

		// Token: 0x17004F50 RID: 20304
		// (get) Token: 0x06017975 RID: 96629 RVA: 0x0036E901 File Offset: 0x0036CB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> RoleEnhance
		{
			get
			{
				return this.roleEnhance_;
			}
		}

		// Token: 0x17004F51 RID: 20305
		// (get) Token: 0x06017976 RID: 96630 RVA: 0x0036E909 File Offset: 0x0036CB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> LootItem
		{
			get
			{
				return this.lootItem_;
			}
		}

		// Token: 0x17004F52 RID: 20306
		// (get) Token: 0x06017977 RID: 96631 RVA: 0x0036E911 File Offset: 0x0036CB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Item
		{
			get
			{
				return this.item_;
			}
		}

		// Token: 0x17004F53 RID: 20307
		// (get) Token: 0x06017978 RID: 96632 RVA: 0x0036E919 File Offset: 0x0036CB19
		// (set) Token: 0x06017979 RID: 96633 RVA: 0x0036E921 File Offset: 0x0036CB21
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

		// Token: 0x17004F54 RID: 20308
		// (get) Token: 0x0601797A RID: 96634 RVA: 0x0036E92A File Offset: 0x0036CB2A
		// (set) Token: 0x0601797B RID: 96635 RVA: 0x0036E932 File Offset: 0x0036CB32
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

		// Token: 0x17004F55 RID: 20309
		// (get) Token: 0x0601797C RID: 96636 RVA: 0x0036E93B File Offset: 0x0036CB3B
		// (set) Token: 0x0601797D RID: 96637 RVA: 0x0036E943 File Offset: 0x0036CB43
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

		// Token: 0x17004F56 RID: 20310
		// (get) Token: 0x0601797E RID: 96638 RVA: 0x0036E94C File Offset: 0x0036CB4C
		// (set) Token: 0x0601797F RID: 96639 RVA: 0x0036E954 File Offset: 0x0036CB54
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

		// Token: 0x17004F57 RID: 20311
		// (get) Token: 0x06017980 RID: 96640 RVA: 0x0036E95D File Offset: 0x0036CB5D
		// (set) Token: 0x06017981 RID: 96641 RVA: 0x0036E965 File Offset: 0x0036CB65
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

		// Token: 0x17004F58 RID: 20312
		// (get) Token: 0x06017982 RID: 96642 RVA: 0x0036E96E File Offset: 0x0036CB6E
		// (set) Token: 0x06017983 RID: 96643 RVA: 0x0036E976 File Offset: 0x0036CB76
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

		// Token: 0x17004F59 RID: 20313
		// (get) Token: 0x06017984 RID: 96644 RVA: 0x0036E97F File Offset: 0x0036CB7F
		// (set) Token: 0x06017985 RID: 96645 RVA: 0x0036E987 File Offset: 0x0036CB87
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

		// Token: 0x17004F5A RID: 20314
		// (get) Token: 0x06017986 RID: 96646 RVA: 0x0036E990 File Offset: 0x0036CB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueLootEntry> LootDict
		{
			get
			{
				return this.lootDict_;
			}
		}

		// Token: 0x17004F5B RID: 20315
		// (get) Token: 0x06017987 RID: 96647 RVA: 0x0036E998 File Offset: 0x0036CB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueItemCurrencyData> ItemData
		{
			get
			{
				return this.itemData_;
			}
		}

		// Token: 0x17004F5C RID: 20316
		// (get) Token: 0x06017988 RID: 96648 RVA: 0x0036E9A0 File Offset: 0x0036CBA0
		// (set) Token: 0x06017989 RID: 96649 RVA: 0x0036E9A8 File Offset: 0x0036CBA8
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

		// Token: 0x17004F5D RID: 20317
		// (get) Token: 0x0601798A RID: 96650 RVA: 0x0036E9B1 File Offset: 0x0036CBB1
		// (set) Token: 0x0601798B RID: 96651 RVA: 0x0036E9B9 File Offset: 0x0036CBB9
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

		// Token: 0x17004F5E RID: 20318
		// (get) Token: 0x0601798C RID: 96652 RVA: 0x0036E9C2 File Offset: 0x0036CBC2
		// (set) Token: 0x0601798D RID: 96653 RVA: 0x0036E9CA File Offset: 0x0036CBCA
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

		// Token: 0x0601798E RID: 96654 RVA: 0x0036E9D3 File Offset: 0x0036CBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInfoNotify);
		}

		// Token: 0x0601798F RID: 96655 RVA: 0x0036E9E4 File Offset: 0x0036CBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInfoNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstState == other.InstState && this.InstId == other.InstId && this.bless_.Equals(other.bless_) && this.roleEnhance_.Equals(other.roleEnhance_) && this.lootItem_.Equals(other.lootItem_) && this.item_.Equals(other.item_) && this.Gold == other.Gold && this.TalentPoint == other.TalentPoint && this.ResurrectionRest == other.ResurrectionRest && this.ResurrectionMax == other.ResurrectionMax && this.RoverHp == other.RoverHp && this.RoverMaxHp == other.RoverMaxHp && this.RoverEnergy == other.RoverEnergy && this.lootDict_.Equals(other.lootDict_) && this.itemData_.Equals(other.itemData_) && this.RoverRogueRoadType == other.RoverRogueRoadType && this.RoverRogueCoinId == other.RoverRogueCoinId && this.RoverType == other.RoverType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017990 RID: 96656 RVA: 0x0036EB5C File Offset: 0x0036CD5C
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

		// Token: 0x06017991 RID: 96657 RVA: 0x0036ED21 File Offset: 0x0036CF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017992 RID: 96658 RVA: 0x0036ED2E File Offset: 0x0036CF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017993 RID: 96659 RVA: 0x0036ED38 File Offset: 0x0036CF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.bless_.WriteTo(ref output, RoverRogueInfoNotify._repeated_bless_codec);
			if (this.RoverRogueRoadType != 0)
			{
				output.WriteRawTag(232, 1);
				output.WriteInt32(this.RoverRogueRoadType);
			}
			this.lootDict_.WriteTo(ref output, RoverRogueInfoNotify._repeated_lootDict_codec);
			if (this.RoverMaxHp != 0)
			{
				output.WriteRawTag(192, 3);
				output.WriteInt32(this.RoverMaxHp);
			}
			if (this.TalentPoint != 0)
			{
				output.WriteRawTag(152, 6);
				output.WriteInt32(this.TalentPoint);
			}
			if (this.RoverType != 0)
			{
				output.WriteRawTag(208, 6);
				output.WriteInt32(this.RoverType);
			}
			if (this.RoverEnergy != 0)
			{
				output.WriteRawTag(232, 6);
				output.WriteInt32(this.RoverEnergy);
			}
			if (this.ResurrectionRest != 0)
			{
				output.WriteRawTag(208, 7);
				output.WriteInt32(this.ResurrectionRest);
			}
			if (this.Gold != 0)
			{
				output.WriteRawTag(192, 8);
				output.WriteInt32(this.Gold);
			}
			if (this.RoverHp != 0)
			{
				output.WriteRawTag(224, 8);
				output.WriteInt32(this.RoverHp);
			}
			if (this.ResurrectionMax != 0)
			{
				output.WriteRawTag(128, 10);
				output.WriteInt32(this.ResurrectionMax);
			}
			this.roleEnhance_.WriteTo(ref output, RoverRogueInfoNotify._repeated_roleEnhance_codec);
			this.item_.WriteTo(ref output, RoverRogueInfoNotify._repeated_item_codec);
			if (this.RoverRogueCoinId != 0)
			{
				output.WriteRawTag(200, 11);
				output.WriteInt32(this.RoverRogueCoinId);
			}
			if (this.InstState != RoverRogueInstState.RoverRogueInstNotStart)
			{
				output.WriteRawTag(232, 11);
				output.WriteEnum((int)this.InstState);
			}
			this.itemData_.WriteTo(ref output, RoverRogueInfoNotify._repeated_itemData_codec);
			this.lootItem_.WriteTo(ref output, RoverRogueInfoNotify._repeated_lootItem_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(200, 14);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017994 RID: 96660 RVA: 0x0036EF60 File Offset: 0x0036D160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
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
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ResurrectionMax);
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

		// Token: 0x06017995 RID: 96661 RVA: 0x0036F130 File Offset: 0x0036D330
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

		// Token: 0x06017996 RID: 96662 RVA: 0x0036F2C2 File Offset: 0x0036D4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017997 RID: 96663 RVA: 0x0036F2CC File Offset: 0x0036D4CC
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
				if (num <= 976U)
				{
					if (num <= 410U)
					{
						if (num <= 82U)
						{
							if (num == 24U)
							{
								this.ActivityId = input.ReadInt32();
								continue;
							}
							if (num == 82U)
							{
								this.bless_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_bless_codec);
								continue;
							}
						}
						else
						{
							if (num == 232U)
							{
								this.RoverRogueRoadType = input.ReadInt32();
								continue;
							}
							if (num == 410U)
							{
								this.lootDict_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_lootDict_codec);
								continue;
							}
						}
					}
					else if (num <= 792U)
					{
						if (num == 448U)
						{
							this.RoverMaxHp = input.ReadInt32();
							continue;
						}
						if (num == 792U)
						{
							this.TalentPoint = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 848U)
						{
							this.RoverType = input.ReadInt32();
							continue;
						}
						if (num == 872U)
						{
							this.RoverEnergy = input.ReadInt32();
							continue;
						}
						if (num == 976U)
						{
							this.ResurrectionRest = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1466U)
				{
					if (num <= 1120U)
					{
						if (num == 1088U)
						{
							this.Gold = input.ReadInt32();
							continue;
						}
						if (num == 1120U)
						{
							this.RoverHp = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 1280U)
						{
							this.ResurrectionMax = input.ReadInt32();
							continue;
						}
						if (num == 1306U)
						{
							this.roleEnhance_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_roleEnhance_codec);
							continue;
						}
						if (num == 1466U)
						{
							this.item_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_item_codec);
							continue;
						}
					}
				}
				else if (num <= 1512U)
				{
					if (num == 1480U)
					{
						this.RoverRogueCoinId = input.ReadInt32();
						continue;
					}
					if (num == 1512U)
					{
						this.InstState = (RoverRogueInstState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 1706U)
					{
						this.itemData_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_itemData_codec);
						continue;
					}
					if (num == 1834U)
					{
						this.lootItem_.AddEntriesFrom(ref input, RoverRogueInfoNotify._repeated_lootItem_codec);
						continue;
					}
					if (num == 1864U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008CB8 RID: 36024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CB9 RID: 36025
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04008CBA RID: 36026
		private int activityId_;

		// Token: 0x04008CBB RID: 36027
		public const int InstStateFieldNumber = 189;

		// Token: 0x04008CBC RID: 36028
		private RoverRogueInstState instState_;

		// Token: 0x04008CBD RID: 36029
		public const int InstIdFieldNumber = 233;

		// Token: 0x04008CBE RID: 36030
		private int instId_;

		// Token: 0x04008CBF RID: 36031
		public const int BlessFieldNumber = 10;

		// Token: 0x04008CC0 RID: 36032
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_bless_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(82U, RoverRogueGainEntry.Parser);

		// Token: 0x04008CC1 RID: 36033
		private readonly RepeatedField<RoverRogueGainEntry> bless_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008CC2 RID: 36034
		public const int RoleEnhanceFieldNumber = 163;

		// Token: 0x04008CC3 RID: 36035
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_roleEnhance_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(1306U, RoverRogueGainEntry.Parser);

		// Token: 0x04008CC4 RID: 36036
		private readonly RepeatedField<RoverRogueGainEntry> roleEnhance_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008CC5 RID: 36037
		public const int LootItemFieldNumber = 229;

		// Token: 0x04008CC6 RID: 36038
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_lootItem_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(1834U, RoverRogueGainEntry.Parser);

		// Token: 0x04008CC7 RID: 36039
		private readonly RepeatedField<RoverRogueGainEntry> lootItem_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008CC8 RID: 36040
		public const int ItemFieldNumber = 183;

		// Token: 0x04008CC9 RID: 36041
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_item_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(1466U, RoverRogueGainEntry.Parser);

		// Token: 0x04008CCA RID: 36042
		private readonly RepeatedField<RoverRogueGainEntry> item_ = new RepeatedField<RoverRogueGainEntry>();

		// Token: 0x04008CCB RID: 36043
		public const int GoldFieldNumber = 136;

		// Token: 0x04008CCC RID: 36044
		private int gold_;

		// Token: 0x04008CCD RID: 36045
		public const int TalentPointFieldNumber = 99;

		// Token: 0x04008CCE RID: 36046
		private int talentPoint_;

		// Token: 0x04008CCF RID: 36047
		public const int ResurrectionRestFieldNumber = 122;

		// Token: 0x04008CD0 RID: 36048
		private int resurrectionRest_;

		// Token: 0x04008CD1 RID: 36049
		public const int ResurrectionMaxFieldNumber = 160;

		// Token: 0x04008CD2 RID: 36050
		private int resurrectionMax_;

		// Token: 0x04008CD3 RID: 36051
		public const int RoverHpFieldNumber = 140;

		// Token: 0x04008CD4 RID: 36052
		private int roverHp_;

		// Token: 0x04008CD5 RID: 36053
		public const int RoverMaxHpFieldNumber = 56;

		// Token: 0x04008CD6 RID: 36054
		private int roverMaxHp_;

		// Token: 0x04008CD7 RID: 36055
		public const int RoverEnergyFieldNumber = 109;

		// Token: 0x04008CD8 RID: 36056
		private int roverEnergy_;

		// Token: 0x04008CD9 RID: 36057
		public const int LootDictFieldNumber = 51;

		// Token: 0x04008CDA RID: 36058
		private static readonly FieldCodec<RoverRogueLootEntry> _repeated_lootDict_codec = FieldCodec.ForMessage<RoverRogueLootEntry>(410U, RoverRogueLootEntry.Parser);

		// Token: 0x04008CDB RID: 36059
		private readonly RepeatedField<RoverRogueLootEntry> lootDict_ = new RepeatedField<RoverRogueLootEntry>();

		// Token: 0x04008CDC RID: 36060
		public const int ItemDataFieldNumber = 213;

		// Token: 0x04008CDD RID: 36061
		private static readonly FieldCodec<RoverRogueItemCurrencyData> _repeated_itemData_codec = FieldCodec.ForMessage<RoverRogueItemCurrencyData>(1706U, RoverRogueItemCurrencyData.Parser);

		// Token: 0x04008CDE RID: 36062
		private readonly RepeatedField<RoverRogueItemCurrencyData> itemData_ = new RepeatedField<RoverRogueItemCurrencyData>();

		// Token: 0x04008CDF RID: 36063
		public const int RoverRogueRoadTypeFieldNumber = 29;

		// Token: 0x04008CE0 RID: 36064
		private int roverRogueRoadType_;

		// Token: 0x04008CE1 RID: 36065
		public const int RoverRogueCoinIdFieldNumber = 185;

		// Token: 0x04008CE2 RID: 36066
		private int roverRogueCoinId_;

		// Token: 0x04008CE3 RID: 36067
		public const int RoverTypeFieldNumber = 106;

		// Token: 0x04008CE4 RID: 36068
		private int roverType_;
	}
}
