using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F7 RID: 4599
	public sealed class ShopItemInfoNew : IMessage<ShopItemInfoNew>, IMessage, IEquatable<ShopItemInfoNew>, IDeepCloneable<ShopItemInfoNew>, IBufferMessage
	{
		// Token: 0x0601883D RID: 100413 RVA: 0x00390806 File Offset: 0x0038EA06
		[NullableContext(1)]
		public static ShopItemInfoNew Create()
		{
			return new ShopItemInfoNew();
		}

		// Token: 0x1700528E RID: 21134
		// (get) Token: 0x0601883E RID: 100414 RVA: 0x0039080D File Offset: 0x0038EA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShopItemInfoNew> Parser
		{
			get
			{
				return ShopItemInfoNew._parser;
			}
		}

		// Token: 0x1700528F RID: 21135
		// (get) Token: 0x0601883F RID: 100415 RVA: 0x00390814 File Offset: 0x0038EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005290 RID: 21136
		// (get) Token: 0x06018840 RID: 100416 RVA: 0x00390817 File Offset: 0x0038EA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopItemInfoNew.Descriptor;
			}
		}

		// Token: 0x06018841 RID: 100417 RVA: 0x00390820 File Offset: 0x0038EA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfoNew()
		{
		}

		// Token: 0x06018842 RID: 100418 RVA: 0x00390878 File Offset: 0x0038EA78
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

		// Token: 0x06018843 RID: 100419 RVA: 0x00390966 File Offset: 0x0038EB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfoNew Clone()
		{
			return new ShopItemInfoNew(this);
		}

		// Token: 0x17005291 RID: 21137
		// (get) Token: 0x06018844 RID: 100420 RVA: 0x0039096E File Offset: 0x0038EB6E
		// (set) Token: 0x06018845 RID: 100421 RVA: 0x00390976 File Offset: 0x0038EB76
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

		// Token: 0x17005292 RID: 21138
		// (get) Token: 0x06018846 RID: 100422 RVA: 0x0039097F File Offset: 0x0038EB7F
		// (set) Token: 0x06018847 RID: 100423 RVA: 0x00390987 File Offset: 0x0038EB87
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

		// Token: 0x17005293 RID: 21139
		// (get) Token: 0x06018848 RID: 100424 RVA: 0x00390990 File Offset: 0x0038EB90
		// (set) Token: 0x06018849 RID: 100425 RVA: 0x00390998 File Offset: 0x0038EB98
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

		// Token: 0x17005294 RID: 21140
		// (get) Token: 0x0601884A RID: 100426 RVA: 0x003909A1 File Offset: 0x0038EBA1
		// (set) Token: 0x0601884B RID: 100427 RVA: 0x003909A9 File Offset: 0x0038EBA9
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

		// Token: 0x17005295 RID: 21141
		// (get) Token: 0x0601884C RID: 100428 RVA: 0x003909B2 File Offset: 0x0038EBB2
		// (set) Token: 0x0601884D RID: 100429 RVA: 0x003909BA File Offset: 0x0038EBBA
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

		// Token: 0x17005296 RID: 21142
		// (get) Token: 0x0601884E RID: 100430 RVA: 0x003909C3 File Offset: 0x0038EBC3
		// (set) Token: 0x0601884F RID: 100431 RVA: 0x003909CB File Offset: 0x0038EBCB
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

		// Token: 0x17005297 RID: 21143
		// (get) Token: 0x06018850 RID: 100432 RVA: 0x003909DE File Offset: 0x0038EBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShoppMoneyInfo> MoneyList
		{
			get
			{
				return this.moneyList_;
			}
		}

		// Token: 0x17005298 RID: 21144
		// (get) Token: 0x06018851 RID: 100433 RVA: 0x003909E6 File Offset: 0x0038EBE6
		// (set) Token: 0x06018852 RID: 100434 RVA: 0x003909EE File Offset: 0x0038EBEE
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

		// Token: 0x17005299 RID: 21145
		// (get) Token: 0x06018853 RID: 100435 RVA: 0x003909F7 File Offset: 0x0038EBF7
		// (set) Token: 0x06018854 RID: 100436 RVA: 0x003909FF File Offset: 0x0038EBFF
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

		// Token: 0x1700529A RID: 21146
		// (get) Token: 0x06018855 RID: 100437 RVA: 0x00390A08 File Offset: 0x0038EC08
		// (set) Token: 0x06018856 RID: 100438 RVA: 0x00390A10 File Offset: 0x0038EC10
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

		// Token: 0x1700529B RID: 21147
		// (get) Token: 0x06018857 RID: 100439 RVA: 0x00390A19 File Offset: 0x0038EC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShoppMoneyInfo> OriginalMoneyList
		{
			get
			{
				return this.originalMoneyList_;
			}
		}

		// Token: 0x1700529C RID: 21148
		// (get) Token: 0x06018858 RID: 100440 RVA: 0x00390A21 File Offset: 0x0038EC21
		// (set) Token: 0x06018859 RID: 100441 RVA: 0x00390A29 File Offset: 0x0038EC29
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

		// Token: 0x1700529D RID: 21149
		// (get) Token: 0x0601885A RID: 100442 RVA: 0x00390A3C File Offset: 0x0038EC3C
		// (set) Token: 0x0601885B RID: 100443 RVA: 0x00390A44 File Offset: 0x0038EC44
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

		// Token: 0x1700529E RID: 21150
		// (get) Token: 0x0601885C RID: 100444 RVA: 0x00390A57 File Offset: 0x0038EC57
		// (set) Token: 0x0601885D RID: 100445 RVA: 0x00390A5F File Offset: 0x0038EC5F
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

		// Token: 0x1700529F RID: 21151
		// (get) Token: 0x0601885E RID: 100446 RVA: 0x00390A72 File Offset: 0x0038EC72
		// (set) Token: 0x0601885F RID: 100447 RVA: 0x00390A7A File Offset: 0x0038EC7A
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

		// Token: 0x170052A0 RID: 21152
		// (get) Token: 0x06018860 RID: 100448 RVA: 0x00390A83 File Offset: 0x0038EC83
		// (set) Token: 0x06018861 RID: 100449 RVA: 0x00390A8B File Offset: 0x0038EC8B
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

		// Token: 0x06018862 RID: 100450 RVA: 0x00390A94 File Offset: 0x0038EC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopItemInfoNew);
		}

		// Token: 0x06018863 RID: 100451 RVA: 0x00390AA4 File Offset: 0x0038ECA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopItemInfoNew other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BoughtCount == other.BoughtCount && this.Lock == other.Lock && this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && !(this.CondText != other.CondText) && this.moneyList_.Equals(other.moneyList_) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.LimitNum == other.LimitNum && this.originalMoneyList_.Equals(other.originalMoneyList_) && !(this.Label != other.Label) && !(this.SwitchText != other.SwitchText) && !(this.PurchaseText != other.PurchaseText) && this.UnlockConditionId == other.UnlockConditionId && this.SortIndex == other.SortIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018864 RID: 100452 RVA: 0x00390BEC File Offset: 0x0038EDEC
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

		// Token: 0x06018865 RID: 100453 RVA: 0x00390D94 File Offset: 0x0038EF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018866 RID: 100454 RVA: 0x00390DA1 File Offset: 0x0038EFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018867 RID: 100455 RVA: 0x00390DAC File Offset: 0x0038EFAC
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

		// Token: 0x06018868 RID: 100456 RVA: 0x00390F90 File Offset: 0x0038F190
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

		// Token: 0x06018869 RID: 100457 RVA: 0x00391134 File Offset: 0x0038F334
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

		// Token: 0x0601886A RID: 100458 RVA: 0x003912AA File Offset: 0x0038F4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601886B RID: 100459 RVA: 0x003912B4 File Offset: 0x0038F4B4
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

		// Token: 0x040090E1 RID: 37089
		private static readonly MessageParser<ShopItemInfoNew> _parser = new MessageParser<ShopItemInfoNew>(() => new ShopItemInfoNew());

		// Token: 0x040090E2 RID: 37090
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090E3 RID: 37091
		public const int IdFieldNumber = 1;

		// Token: 0x040090E4 RID: 37092
		private int id_;

		// Token: 0x040090E5 RID: 37093
		public const int BoughtCountFieldNumber = 2;

		// Token: 0x040090E6 RID: 37094
		private int boughtCount_;

		// Token: 0x040090E7 RID: 37095
		public const int LockFieldNumber = 3;

		// Token: 0x040090E8 RID: 37096
		private bool lock_;

		// Token: 0x040090E9 RID: 37097
		public const int ItemIdFieldNumber = 4;

		// Token: 0x040090EA RID: 37098
		private int itemId_;

		// Token: 0x040090EB RID: 37099
		public const int ItemNumFieldNumber = 5;

		// Token: 0x040090EC RID: 37100
		private int itemNum_;

		// Token: 0x040090ED RID: 37101
		public const int CondTextFieldNumber = 6;

		// Token: 0x040090EE RID: 37102
		private string condText_ = "";

		// Token: 0x040090EF RID: 37103
		public const int MoneyListFieldNumber = 7;

		// Token: 0x040090F0 RID: 37104
		private static readonly FieldCodec<ShoppMoneyInfo> _repeated_moneyList_codec = FieldCodec.ForMessage<ShoppMoneyInfo>(58U, ShoppMoneyInfo.Parser);

		// Token: 0x040090F1 RID: 37105
		private readonly RepeatedField<ShoppMoneyInfo> moneyList_ = new RepeatedField<ShoppMoneyInfo>();

		// Token: 0x040090F2 RID: 37106
		public const int BeginTimeFieldNumber = 8;

		// Token: 0x040090F3 RID: 37107
		private uint beginTime_;

		// Token: 0x040090F4 RID: 37108
		public const int EndTimeFieldNumber = 9;

		// Token: 0x040090F5 RID: 37109
		private uint endTime_;

		// Token: 0x040090F6 RID: 37110
		public const int LimitNumFieldNumber = 10;

		// Token: 0x040090F7 RID: 37111
		private int limitNum_;

		// Token: 0x040090F8 RID: 37112
		public const int OriginalMoneyListFieldNumber = 11;

		// Token: 0x040090F9 RID: 37113
		private static readonly FieldCodec<ShoppMoneyInfo> _repeated_originalMoneyList_codec = FieldCodec.ForMessage<ShoppMoneyInfo>(90U, ShoppMoneyInfo.Parser);

		// Token: 0x040090FA RID: 37114
		private readonly RepeatedField<ShoppMoneyInfo> originalMoneyList_ = new RepeatedField<ShoppMoneyInfo>();

		// Token: 0x040090FB RID: 37115
		public const int LabelFieldNumber = 12;

		// Token: 0x040090FC RID: 37116
		private string label_ = "";

		// Token: 0x040090FD RID: 37117
		public const int SwitchTextFieldNumber = 13;

		// Token: 0x040090FE RID: 37118
		private string switchText_ = "";

		// Token: 0x040090FF RID: 37119
		public const int PurchaseTextFieldNumber = 14;

		// Token: 0x04009100 RID: 37120
		private string purchaseText_ = "";

		// Token: 0x04009101 RID: 37121
		public const int UnlockConditionIdFieldNumber = 15;

		// Token: 0x04009102 RID: 37122
		private int unlockConditionId_;

		// Token: 0x04009103 RID: 37123
		public const int SortIndexFieldNumber = 16;

		// Token: 0x04009104 RID: 37124
		private int sortIndex_;
	}
}
