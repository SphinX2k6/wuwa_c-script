using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001233 RID: 4659
	public sealed class ShopItemInfoNew : IMessage<ShopItemInfoNew>, IMessage, IEquatable<ShopItemInfoNew>, IDeepCloneable<ShopItemInfoNew>, IBufferMessage
	{
		// Token: 0x06018E17 RID: 101911 RVA: 0x003A06AA File Offset: 0x0039E8AA
		[NullableContext(1)]
		public static ShopItemInfoNew Create()
		{
			return new ShopItemInfoNew();
		}

		// Token: 0x1700540B RID: 21515
		// (get) Token: 0x06018E18 RID: 101912 RVA: 0x003A06B1 File Offset: 0x0039E8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShopItemInfoNew> Parser
		{
			get
			{
				return ShopItemInfoNew._parser;
			}
		}

		// Token: 0x1700540C RID: 21516
		// (get) Token: 0x06018E19 RID: 101913 RVA: 0x003A06B8 File Offset: 0x0039E8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700540D RID: 21517
		// (get) Token: 0x06018E1A RID: 101914 RVA: 0x003A06BB File Offset: 0x0039E8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopItemInfoNew.Descriptor;
			}
		}

		// Token: 0x06018E1B RID: 101915 RVA: 0x003A06C4 File Offset: 0x0039E8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfoNew()
		{
		}

		// Token: 0x06018E1C RID: 101916 RVA: 0x003A071C File Offset: 0x0039E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfoNew(ShopItemInfoNew other) : this()
		{
			this.id_ = other.id_;
			this.boughtCount_ = other.boughtCount_;
			this.lock_ = other.lock_;
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this.condText_ = other.condText_;
			this.moneyList_ = other.moneyList_.Clone();
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.limitNum_ = other.limitNum_;
			this.originalMoneyList_ = other.originalMoneyList_.Clone();
			this.label_ = other.label_;
			this.switchText_ = other.switchText_;
			this.purchaseText_ = other.purchaseText_;
			this.unlockConditionId_ = other.unlockConditionId_;
			this.sortIndex_ = other.sortIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E1D RID: 101917 RVA: 0x003A080A File Offset: 0x0039EA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfoNew Clone()
		{
			return new ShopItemInfoNew(this);
		}

		// Token: 0x1700540E RID: 21518
		// (get) Token: 0x06018E1E RID: 101918 RVA: 0x003A0812 File Offset: 0x0039EA12
		// (set) Token: 0x06018E1F RID: 101919 RVA: 0x003A081A File Offset: 0x0039EA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700540F RID: 21519
		// (get) Token: 0x06018E20 RID: 101920 RVA: 0x003A0823 File Offset: 0x0039EA23
		// (set) Token: 0x06018E21 RID: 101921 RVA: 0x003A082B File Offset: 0x0039EA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoughtCount
		{
			get
			{
				return this.boughtCount_;
			}
			set
			{
				this.boughtCount_ = value;
			}
		}

		// Token: 0x17005410 RID: 21520
		// (get) Token: 0x06018E22 RID: 101922 RVA: 0x003A0834 File Offset: 0x0039EA34
		// (set) Token: 0x06018E23 RID: 101923 RVA: 0x003A083C File Offset: 0x0039EA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Lock
		{
			get
			{
				return this.lock_;
			}
			set
			{
				this.lock_ = value;
			}
		}

		// Token: 0x17005411 RID: 21521
		// (get) Token: 0x06018E24 RID: 101924 RVA: 0x003A0845 File Offset: 0x0039EA45
		// (set) Token: 0x06018E25 RID: 101925 RVA: 0x003A084D File Offset: 0x0039EA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17005412 RID: 21522
		// (get) Token: 0x06018E26 RID: 101926 RVA: 0x003A0856 File Offset: 0x0039EA56
		// (set) Token: 0x06018E27 RID: 101927 RVA: 0x003A085E File Offset: 0x0039EA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemNum
		{
			get
			{
				return this.itemNum_;
			}
			set
			{
				this.itemNum_ = value;
			}
		}

		// Token: 0x17005413 RID: 21523
		// (get) Token: 0x06018E28 RID: 101928 RVA: 0x003A0867 File Offset: 0x0039EA67
		// (set) Token: 0x06018E29 RID: 101929 RVA: 0x003A086F File Offset: 0x0039EA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CondText
		{
			get
			{
				return this.condText_;
			}
			set
			{
				this.condText_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005414 RID: 21524
		// (get) Token: 0x06018E2A RID: 101930 RVA: 0x003A0882 File Offset: 0x0039EA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShoppMoneyInfo> MoneyList
		{
			get
			{
				return this.moneyList_;
			}
		}

		// Token: 0x17005415 RID: 21525
		// (get) Token: 0x06018E2B RID: 101931 RVA: 0x003A088A File Offset: 0x0039EA8A
		// (set) Token: 0x06018E2C RID: 101932 RVA: 0x003A0892 File Offset: 0x0039EA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x17005416 RID: 21526
		// (get) Token: 0x06018E2D RID: 101933 RVA: 0x003A089B File Offset: 0x0039EA9B
		// (set) Token: 0x06018E2E RID: 101934 RVA: 0x003A08A3 File Offset: 0x0039EAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17005417 RID: 21527
		// (get) Token: 0x06018E2F RID: 101935 RVA: 0x003A08AC File Offset: 0x0039EAAC
		// (set) Token: 0x06018E30 RID: 101936 RVA: 0x003A08B4 File Offset: 0x0039EAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitNum
		{
			get
			{
				return this.limitNum_;
			}
			set
			{
				this.limitNum_ = value;
			}
		}

		// Token: 0x17005418 RID: 21528
		// (get) Token: 0x06018E31 RID: 101937 RVA: 0x003A08BD File Offset: 0x0039EABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShoppMoneyInfo> OriginalMoneyList
		{
			get
			{
				return this.originalMoneyList_;
			}
		}

		// Token: 0x17005419 RID: 21529
		// (get) Token: 0x06018E32 RID: 101938 RVA: 0x003A08C5 File Offset: 0x0039EAC5
		// (set) Token: 0x06018E33 RID: 101939 RVA: 0x003A08CD File Offset: 0x0039EACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Label
		{
			get
			{
				return this.label_;
			}
			set
			{
				this.label_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700541A RID: 21530
		// (get) Token: 0x06018E34 RID: 101940 RVA: 0x003A08E0 File Offset: 0x0039EAE0
		// (set) Token: 0x06018E35 RID: 101941 RVA: 0x003A08E8 File Offset: 0x0039EAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SwitchText
		{
			get
			{
				return this.switchText_;
			}
			set
			{
				this.switchText_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700541B RID: 21531
		// (get) Token: 0x06018E36 RID: 101942 RVA: 0x003A08FB File Offset: 0x0039EAFB
		// (set) Token: 0x06018E37 RID: 101943 RVA: 0x003A0903 File Offset: 0x0039EB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PurchaseText
		{
			get
			{
				return this.purchaseText_;
			}
			set
			{
				this.purchaseText_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700541C RID: 21532
		// (get) Token: 0x06018E38 RID: 101944 RVA: 0x003A0916 File Offset: 0x0039EB16
		// (set) Token: 0x06018E39 RID: 101945 RVA: 0x003A091E File Offset: 0x0039EB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockConditionId
		{
			get
			{
				return this.unlockConditionId_;
			}
			set
			{
				this.unlockConditionId_ = value;
			}
		}

		// Token: 0x1700541D RID: 21533
		// (get) Token: 0x06018E3A RID: 101946 RVA: 0x003A0927 File Offset: 0x0039EB27
		// (set) Token: 0x06018E3B RID: 101947 RVA: 0x003A092F File Offset: 0x0039EB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SortIndex
		{
			get
			{
				return this.sortIndex_;
			}
			set
			{
				this.sortIndex_ = value;
			}
		}

		// Token: 0x06018E3C RID: 101948 RVA: 0x003A0938 File Offset: 0x0039EB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopItemInfoNew);
		}

		// Token: 0x06018E3D RID: 101949 RVA: 0x003A0948 File Offset: 0x0039EB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopItemInfoNew other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BoughtCount == other.BoughtCount && this.Lock == other.Lock && this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && !(this.CondText != other.CondText) && this.moneyList_.Equals(other.moneyList_) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.LimitNum == other.LimitNum && this.originalMoneyList_.Equals(other.originalMoneyList_) && !(this.Label != other.Label) && !(this.SwitchText != other.SwitchText) && !(this.PurchaseText != other.PurchaseText) && this.UnlockConditionId == other.UnlockConditionId && this.SortIndex == other.SortIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E3E RID: 101950 RVA: 0x003A0A90 File Offset: 0x0039EC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BoughtCount != 0)
			{
				num ^= this.BoughtCount.GetHashCode();
			}
			if (this.Lock)
			{
				num ^= this.Lock.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemNum != 0)
			{
				num ^= this.ItemNum.GetHashCode();
			}
			if (this.CondText.Length != 0)
			{
				num ^= this.CondText.GetHashCode();
			}
			num ^= this.moneyList_.GetHashCode();
			if (this.BeginTime != 0U)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0U)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.LimitNum != 0)
			{
				num ^= this.LimitNum.GetHashCode();
			}
			num ^= this.originalMoneyList_.GetHashCode();
			if (this.Label.Length != 0)
			{
				num ^= this.Label.GetHashCode();
			}
			if (this.SwitchText.Length != 0)
			{
				num ^= this.SwitchText.GetHashCode();
			}
			if (this.PurchaseText.Length != 0)
			{
				num ^= this.PurchaseText.GetHashCode();
			}
			if (this.UnlockConditionId != 0)
			{
				num ^= this.UnlockConditionId.GetHashCode();
			}
			if (this.SortIndex != 0)
			{
				num ^= this.SortIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E3F RID: 101951 RVA: 0x003A0C38 File Offset: 0x0039EE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E40 RID: 101952 RVA: 0x003A0C45 File Offset: 0x0039EE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E41 RID: 101953 RVA: 0x003A0C50 File Offset: 0x0039EE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.BoughtCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BoughtCount);
			}
			if (this.Lock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Lock);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ItemNum);
			}
			if (this.CondText.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.CondText);
			}
			this.moneyList_.WriteTo(ref output, ShopItemInfoNew._repeated_moneyList_codec);
			if (this.BeginTime != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.BeginTime);
			}
			if (this.EndTime != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EndTime);
			}
			if (this.LimitNum != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LimitNum);
			}
			this.originalMoneyList_.WriteTo(ref output, ShopItemInfoNew._repeated_originalMoneyList_codec);
			if (this.Label.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Label);
			}
			if (this.SwitchText.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.SwitchText);
			}
			if (this.PurchaseText.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.PurchaseText);
			}
			if (this.UnlockConditionId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.UnlockConditionId);
			}
			if (this.SortIndex != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.SortIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E42 RID: 101954 RVA: 0x003A0E34 File Offset: 0x0039F034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.BoughtCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoughtCount);
			}
			if (this.Lock)
			{
				num += 2;
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemNum);
			}
			if (this.CondText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CondText);
			}
			num += this.moneyList_.CalculateSize(ShopItemInfoNew._repeated_moneyList_codec);
			if (this.BeginTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BeginTime);
			}
			if (this.EndTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EndTime);
			}
			if (this.LimitNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitNum);
			}
			num += this.originalMoneyList_.CalculateSize(ShopItemInfoNew._repeated_originalMoneyList_codec);
			if (this.Label.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Label);
			}
			if (this.SwitchText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SwitchText);
			}
			if (this.PurchaseText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PurchaseText);
			}
			if (this.UnlockConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockConditionId);
			}
			if (this.SortIndex != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SortIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E43 RID: 101955 RVA: 0x003A0FD8 File Offset: 0x0039F1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopItemInfoNew other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BoughtCount != 0)
			{
				this.BoughtCount = other.BoughtCount;
			}
			if (other.Lock)
			{
				this.Lock = other.Lock;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemNum != 0)
			{
				this.ItemNum = other.ItemNum;
			}
			if (other.CondText.Length != 0)
			{
				this.CondText = other.CondText;
			}
			this.moneyList_.Add(other.moneyList_);
			if (other.BeginTime != 0U)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0U)
			{
				this.EndTime = other.EndTime;
			}
			if (other.LimitNum != 0)
			{
				this.LimitNum = other.LimitNum;
			}
			this.originalMoneyList_.Add(other.originalMoneyList_);
			if (other.Label.Length != 0)
			{
				this.Label = other.Label;
			}
			if (other.SwitchText.Length != 0)
			{
				this.SwitchText = other.SwitchText;
			}
			if (other.PurchaseText.Length != 0)
			{
				this.PurchaseText = other.PurchaseText;
			}
			if (other.UnlockConditionId != 0)
			{
				this.UnlockConditionId = other.UnlockConditionId;
			}
			if (other.SortIndex != 0)
			{
				this.SortIndex = other.SortIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E44 RID: 101956 RVA: 0x003A114E File Offset: 0x0039F34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E45 RID: 101957 RVA: 0x003A1158 File Offset: 0x0039F358
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
					if (num <= 32U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.Id = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.BoughtCount = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.Lock = input.ReadBool();
								continue;
							}
							if (num == 32U)
							{
								this.ItemId = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 40U)
						{
							this.ItemNum = input.ReadInt32();
							continue;
						}
						if (num == 50U)
						{
							this.CondText = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							this.moneyList_.AddEntriesFrom(ref input, ShopItemInfoNew._repeated_moneyList_codec);
							continue;
						}
						if (num == 64U)
						{
							this.BeginTime = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num <= 80U)
					{
						if (num == 72U)
						{
							this.EndTime = input.ReadUInt32();
							continue;
						}
						if (num == 80U)
						{
							this.LimitNum = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							this.originalMoneyList_.AddEntriesFrom(ref input, ShopItemInfoNew._repeated_originalMoneyList_codec);
							continue;
						}
						if (num == 98U)
						{
							this.Label = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 114U)
				{
					if (num == 106U)
					{
						this.SwitchText = input.ReadString();
						continue;
					}
					if (num == 114U)
					{
						this.PurchaseText = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 120U)
					{
						this.UnlockConditionId = input.ReadInt32();
						continue;
					}
					if (num == 128U)
					{
						this.SortIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009392 RID: 37778
		private static readonly MessageParser<ShopItemInfoNew> _parser = new MessageParser<ShopItemInfoNew>(() => new ShopItemInfoNew());

		// Token: 0x04009393 RID: 37779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009394 RID: 37780
		public const int IdFieldNumber = 1;

		// Token: 0x04009395 RID: 37781
		private int id_;

		// Token: 0x04009396 RID: 37782
		public const int BoughtCountFieldNumber = 2;

		// Token: 0x04009397 RID: 37783
		private int boughtCount_;

		// Token: 0x04009398 RID: 37784
		public const int LockFieldNumber = 3;

		// Token: 0x04009399 RID: 37785
		private bool lock_;

		// Token: 0x0400939A RID: 37786
		public const int ItemIdFieldNumber = 4;

		// Token: 0x0400939B RID: 37787
		private int itemId_;

		// Token: 0x0400939C RID: 37788
		public const int ItemNumFieldNumber = 5;

		// Token: 0x0400939D RID: 37789
		private int itemNum_;

		// Token: 0x0400939E RID: 37790
		public const int CondTextFieldNumber = 6;

		// Token: 0x0400939F RID: 37791
		private string condText_ = "";

		// Token: 0x040093A0 RID: 37792
		public const int MoneyListFieldNumber = 7;

		// Token: 0x040093A1 RID: 37793
		private static readonly FieldCodec<ShoppMoneyInfo> _repeated_moneyList_codec = FieldCodec.ForMessage<ShoppMoneyInfo>(58U, ShoppMoneyInfo.Parser);

		// Token: 0x040093A2 RID: 37794
		private readonly RepeatedField<ShoppMoneyInfo> moneyList_ = new RepeatedField<ShoppMoneyInfo>();

		// Token: 0x040093A3 RID: 37795
		public const int BeginTimeFieldNumber = 8;

		// Token: 0x040093A4 RID: 37796
		private uint beginTime_;

		// Token: 0x040093A5 RID: 37797
		public const int EndTimeFieldNumber = 9;

		// Token: 0x040093A6 RID: 37798
		private uint endTime_;

		// Token: 0x040093A7 RID: 37799
		public const int LimitNumFieldNumber = 10;

		// Token: 0x040093A8 RID: 37800
		private int limitNum_;

		// Token: 0x040093A9 RID: 37801
		public const int OriginalMoneyListFieldNumber = 11;

		// Token: 0x040093AA RID: 37802
		private static readonly FieldCodec<ShoppMoneyInfo> _repeated_originalMoneyList_codec = FieldCodec.ForMessage<ShoppMoneyInfo>(90U, ShoppMoneyInfo.Parser);

		// Token: 0x040093AB RID: 37803
		private readonly RepeatedField<ShoppMoneyInfo> originalMoneyList_ = new RepeatedField<ShoppMoneyInfo>();

		// Token: 0x040093AC RID: 37804
		public const int LabelFieldNumber = 12;

		// Token: 0x040093AD RID: 37805
		private string label_ = "";

		// Token: 0x040093AE RID: 37806
		public const int SwitchTextFieldNumber = 13;

		// Token: 0x040093AF RID: 37807
		private string switchText_ = "";

		// Token: 0x040093B0 RID: 37808
		public const int PurchaseTextFieldNumber = 14;

		// Token: 0x040093B1 RID: 37809
		private string purchaseText_ = "";

		// Token: 0x040093B2 RID: 37810
		public const int UnlockConditionIdFieldNumber = 15;

		// Token: 0x040093B3 RID: 37811
		private int unlockConditionId_;

		// Token: 0x040093B4 RID: 37812
		public const int SortIndexFieldNumber = 16;

		// Token: 0x040093B5 RID: 37813
		private int sortIndex_;
	}
}
