using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015D RID: 349
	[NetMessage(EMessageId.BasicInfoNotify)]
	public sealed class BasicInfoNotify : IMessage<BasicInfoNotify>, IMessage, IEquatable<BasicInfoNotify>, IDeepCloneable<BasicInfoNotify>, IBufferMessage
	{
		// Token: 0x06002C08 RID: 11272 RVA: 0x00072C87 File Offset: 0x00070E87
		[NullableContext(1)]
		public static BasicInfoNotify Create()
		{
			return new BasicInfoNotify();
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x00072C8E File Offset: 0x00070E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x00072C91 File Offset: 0x00070E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BasicInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00072C98 File Offset: 0x00070E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicInfoNotify()
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00072CF0 File Offset: 0x00070EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicInfoNotify(BasicInfoNotify other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this.mingSuGenInfos_ = other.mingSuGenInfos_.Clone();
			this.dragonPoolInfos_ = other.dragonPoolInfos_.Clone();
			this.roleShowList_ = other.roleShowList_.Clone();
			this.curCardId_ = other.curCardId_;
			this.birthday_ = other.birthday_;
			this.cardUnlockList_ = other.cardUnlockList_.Clone();
			this.randomSeed_ = other.randomSeed_;
			this.displayBirthDay_ = other.displayBirthDay_;
			this.lastModifyNameTime_ = other.lastModifyNameTime_;
			this.modifyName_ = other.modifyName_;
			this.businessCompliance_ = other.businessCompliance_;
			this.newbieGuideV2_ = other.newbieGuideV2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00072DD5 File Offset: 0x00070FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicInfoNotify Clone()
		{
			return new BasicInfoNotify(this);
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x00072DDD File Offset: 0x00070FDD
		// (set) Token: 0x06002C0F RID: 11279 RVA: 0x00072DE5 File Offset: 0x00070FE5
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x00072DEE File Offset: 0x00070FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerAttr> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x00072DF6 File Offset: 0x00070FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MingSuGenInfo> MingSuGenInfos
		{
			get
			{
				return this.mingSuGenInfos_;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x00072DFE File Offset: 0x00070FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DragonPoolInfo> DragonPoolInfos
		{
			get
			{
				return this.dragonPoolInfos_;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x00072E06 File Offset: 0x00071006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleShowEntry> RoleShowList
		{
			get
			{
				return this.roleShowList_;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x00072E0E File Offset: 0x0007100E
		// (set) Token: 0x06002C15 RID: 11285 RVA: 0x00072E16 File Offset: 0x00071016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardId
		{
			get
			{
				return this.curCardId_;
			}
			set
			{
				this.curCardId_ = value;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x00072E1F File Offset: 0x0007101F
		// (set) Token: 0x06002C17 RID: 11287 RVA: 0x00072E27 File Offset: 0x00071027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Birthday
		{
			get
			{
				return this.birthday_;
			}
			set
			{
				this.birthday_ = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x00072E30 File Offset: 0x00071030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CardShowEntry> CardUnlockList
		{
			get
			{
				return this.cardUnlockList_;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x00072E38 File Offset: 0x00071038
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x00072E40 File Offset: 0x00071040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RandomSeed
		{
			get
			{
				return this.randomSeed_;
			}
			set
			{
				this.randomSeed_ = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x00072E49 File Offset: 0x00071049
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x00072E51 File Offset: 0x00071051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DisplayBirthDay
		{
			get
			{
				return this.displayBirthDay_;
			}
			set
			{
				this.displayBirthDay_ = value;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x00072E5A File Offset: 0x0007105A
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x00072E62 File Offset: 0x00071062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastModifyNameTime
		{
			get
			{
				return this.lastModifyNameTime_;
			}
			set
			{
				this.lastModifyNameTime_ = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x00072E6B File Offset: 0x0007106B
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00072E73 File Offset: 0x00071073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ModifyName
		{
			get
			{
				return this.modifyName_;
			}
			set
			{
				this.modifyName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x00072E86 File Offset: 0x00071086
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00072E8E File Offset: 0x0007108E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BusinessCompliance
		{
			get
			{
				return this.businessCompliance_;
			}
			set
			{
				this.businessCompliance_ = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x00072E97 File Offset: 0x00071097
		// (set) Token: 0x06002C24 RID: 11300 RVA: 0x00072E9F File Offset: 0x0007109F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NewbieGuideV2
		{
			get
			{
				return this.newbieGuideV2_;
			}
			set
			{
				this.newbieGuideV2_ = value;
			}
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00072EA8 File Offset: 0x000710A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BasicInfoNotify);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00072EB8 File Offset: 0x000710B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BasicInfoNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.attributes_.Equals(other.attributes_) && this.mingSuGenInfos_.Equals(other.mingSuGenInfos_) && this.dragonPoolInfos_.Equals(other.dragonPoolInfos_) && this.roleShowList_.Equals(other.roleShowList_) && this.CurCardId == other.CurCardId && this.Birthday == other.Birthday && this.cardUnlockList_.Equals(other.cardUnlockList_) && this.RandomSeed == other.RandomSeed && this.DisplayBirthDay == other.DisplayBirthDay && this.LastModifyNameTime == other.LastModifyNameTime && !(this.ModifyName != other.ModifyName) && this.BusinessCompliance == other.BusinessCompliance && this.NewbieGuideV2 == other.NewbieGuideV2 && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00072FE0 File Offset: 0x000711E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.attributes_.GetHashCode();
			num ^= this.mingSuGenInfos_.GetHashCode();
			num ^= this.dragonPoolInfos_.GetHashCode();
			num ^= this.roleShowList_.GetHashCode();
			if (this.CurCardId != 0)
			{
				num ^= this.CurCardId.GetHashCode();
			}
			if (this.Birthday != 0)
			{
				num ^= this.Birthday.GetHashCode();
			}
			num ^= this.cardUnlockList_.GetHashCode();
			if (this.RandomSeed != 0)
			{
				num ^= this.RandomSeed.GetHashCode();
			}
			if (this.DisplayBirthDay)
			{
				num ^= this.DisplayBirthDay.GetHashCode();
			}
			if (this.LastModifyNameTime != 0L)
			{
				num ^= this.LastModifyNameTime.GetHashCode();
			}
			if (this.ModifyName.Length != 0)
			{
				num ^= this.ModifyName.GetHashCode();
			}
			if (this.BusinessCompliance)
			{
				num ^= this.BusinessCompliance.GetHashCode();
			}
			if (this.NewbieGuideV2)
			{
				num ^= this.NewbieGuideV2.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x0007312F File Offset: 0x0007132F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0007313C File Offset: 0x0007133C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00073148 File Offset: 0x00071348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisplayBirthDay)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.DisplayBirthDay);
			}
			if (this.CurCardId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurCardId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this.BusinessCompliance)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.BusinessCompliance);
			}
			this.dragonPoolInfos_.WriteTo(ref output, BasicInfoNotify._repeated_dragonPoolInfos_codec);
			if (this.Birthday != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Birthday);
			}
			this.cardUnlockList_.WriteTo(ref output, BasicInfoNotify._repeated_cardUnlockList_codec);
			this.attributes_.WriteTo(ref output, BasicInfoNotify._repeated_attributes_codec);
			if (this.LastModifyNameTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.LastModifyNameTime);
			}
			this.roleShowList_.WriteTo(ref output, BasicInfoNotify._repeated_roleShowList_codec);
			if (this.RandomSeed != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RandomSeed);
			}
			if (this.NewbieGuideV2)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.NewbieGuideV2);
			}
			if (this.ModifyName.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.ModifyName);
			}
			this.mingSuGenInfos_.WriteTo(ref output, BasicInfoNotify._repeated_mingSuGenInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000732C0 File Offset: 0x000714C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.attributes_.CalculateSize(BasicInfoNotify._repeated_attributes_codec);
			num += this.mingSuGenInfos_.CalculateSize(BasicInfoNotify._repeated_mingSuGenInfos_codec);
			num += this.dragonPoolInfos_.CalculateSize(BasicInfoNotify._repeated_dragonPoolInfos_codec);
			num += this.roleShowList_.CalculateSize(BasicInfoNotify._repeated_roleShowList_codec);
			if (this.CurCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardId);
			}
			if (this.Birthday != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Birthday);
			}
			num += this.cardUnlockList_.CalculateSize(BasicInfoNotify._repeated_cardUnlockList_codec);
			if (this.RandomSeed != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RandomSeed);
			}
			if (this.DisplayBirthDay)
			{
				num += 2;
			}
			if (this.LastModifyNameTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastModifyNameTime);
			}
			if (this.ModifyName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ModifyName);
			}
			if (this.BusinessCompliance)
			{
				num += 2;
			}
			if (this.NewbieGuideV2)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00073400 File Offset: 0x00071600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BasicInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.attributes_.Add(other.attributes_);
			this.mingSuGenInfos_.Add(other.mingSuGenInfos_);
			this.dragonPoolInfos_.Add(other.dragonPoolInfos_);
			this.roleShowList_.Add(other.roleShowList_);
			if (other.CurCardId != 0)
			{
				this.CurCardId = other.CurCardId;
			}
			if (other.Birthday != 0)
			{
				this.Birthday = other.Birthday;
			}
			this.cardUnlockList_.Add(other.cardUnlockList_);
			if (other.RandomSeed != 0)
			{
				this.RandomSeed = other.RandomSeed;
			}
			if (other.DisplayBirthDay)
			{
				this.DisplayBirthDay = other.DisplayBirthDay;
			}
			if (other.LastModifyNameTime != 0L)
			{
				this.LastModifyNameTime = other.LastModifyNameTime;
			}
			if (other.ModifyName.Length != 0)
			{
				this.ModifyName = other.ModifyName;
			}
			if (other.BusinessCompliance)
			{
				this.BusinessCompliance = other.BusinessCompliance;
			}
			if (other.NewbieGuideV2)
			{
				this.NewbieGuideV2 = other.NewbieGuideV2;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x00073536 File Offset: 0x00071736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x00073540 File Offset: 0x00071740
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
				if (num <= 66U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.DisplayBirthDay = input.ReadBool();
							continue;
						}
						if (num == 16U)
						{
							this.CurCardId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 50U)
					{
						if (num == 40U)
						{
							this.BusinessCompliance = input.ReadBool();
							continue;
						}
						if (num == 50U)
						{
							this.dragonPoolInfos_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_dragonPoolInfos_codec);
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.Birthday = input.ReadInt32();
							continue;
						}
						if (num == 66U)
						{
							this.cardUnlockList_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_cardUnlockList_codec);
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 74U)
					{
						this.attributes_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_attributes_codec);
						continue;
					}
					if (num == 80U)
					{
						this.LastModifyNameTime = input.ReadInt64();
						continue;
					}
					if (num == 90U)
					{
						this.roleShowList_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_roleShowList_codec);
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.RandomSeed = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.NewbieGuideV2 = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.ModifyName = input.ReadString();
						continue;
					}
					if (num == 122U)
					{
						this.mingSuGenInfos_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_mingSuGenInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400281B RID: 10267
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400281C RID: 10268
		public const int IdFieldNumber = 4;

		// Token: 0x0400281D RID: 10269
		private int id_;

		// Token: 0x0400281E RID: 10270
		public const int AttributesFieldNumber = 9;

		// Token: 0x0400281F RID: 10271
		private static readonly FieldCodec<PlayerAttr> _repeated_attributes_codec = FieldCodec.ForMessage<PlayerAttr>(74U, PlayerAttr.Parser);

		// Token: 0x04002820 RID: 10272
		private readonly RepeatedField<PlayerAttr> attributes_ = new RepeatedField<PlayerAttr>();

		// Token: 0x04002821 RID: 10273
		public const int MingSuGenInfosFieldNumber = 15;

		// Token: 0x04002822 RID: 10274
		private static readonly FieldCodec<MingSuGenInfo> _repeated_mingSuGenInfos_codec = FieldCodec.ForMessage<MingSuGenInfo>(122U, MingSuGenInfo.Parser);

		// Token: 0x04002823 RID: 10275
		private readonly RepeatedField<MingSuGenInfo> mingSuGenInfos_ = new RepeatedField<MingSuGenInfo>();

		// Token: 0x04002824 RID: 10276
		public const int DragonPoolInfosFieldNumber = 6;

		// Token: 0x04002825 RID: 10277
		private static readonly FieldCodec<DragonPoolInfo> _repeated_dragonPoolInfos_codec = FieldCodec.ForMessage<DragonPoolInfo>(50U, DragonPoolInfo.Parser);

		// Token: 0x04002826 RID: 10278
		private readonly RepeatedField<DragonPoolInfo> dragonPoolInfos_ = new RepeatedField<DragonPoolInfo>();

		// Token: 0x04002827 RID: 10279
		public const int RoleShowListFieldNumber = 11;

		// Token: 0x04002828 RID: 10280
		private static readonly FieldCodec<RoleShowEntry> _repeated_roleShowList_codec = FieldCodec.ForMessage<RoleShowEntry>(90U, RoleShowEntry.Parser);

		// Token: 0x04002829 RID: 10281
		private readonly RepeatedField<RoleShowEntry> roleShowList_ = new RepeatedField<RoleShowEntry>();

		// Token: 0x0400282A RID: 10282
		public const int CurCardIdFieldNumber = 2;

		// Token: 0x0400282B RID: 10283
		private int curCardId_;

		// Token: 0x0400282C RID: 10284
		public const int BirthdayFieldNumber = 7;

		// Token: 0x0400282D RID: 10285
		private int birthday_;

		// Token: 0x0400282E RID: 10286
		public const int CardUnlockListFieldNumber = 8;

		// Token: 0x0400282F RID: 10287
		private static readonly FieldCodec<CardShowEntry> _repeated_cardUnlockList_codec = FieldCodec.ForMessage<CardShowEntry>(66U, CardShowEntry.Parser);

		// Token: 0x04002830 RID: 10288
		private readonly RepeatedField<CardShowEntry> cardUnlockList_ = new RepeatedField<CardShowEntry>();

		// Token: 0x04002831 RID: 10289
		public const int RandomSeedFieldNumber = 12;

		// Token: 0x04002832 RID: 10290
		private int randomSeed_;

		// Token: 0x04002833 RID: 10291
		public const int DisplayBirthDayFieldNumber = 1;

		// Token: 0x04002834 RID: 10292
		private bool displayBirthDay_;

		// Token: 0x04002835 RID: 10293
		public const int LastModifyNameTimeFieldNumber = 10;

		// Token: 0x04002836 RID: 10294
		private long lastModifyNameTime_;

		// Token: 0x04002837 RID: 10295
		public const int ModifyNameFieldNumber = 14;

		// Token: 0x04002838 RID: 10296
		private string modifyName_ = "";

		// Token: 0x04002839 RID: 10297
		public const int BusinessComplianceFieldNumber = 5;

		// Token: 0x0400283A RID: 10298
		private bool businessCompliance_;

		// Token: 0x0400283B RID: 10299
		public const int NewbieGuideV2FieldNumber = 13;

		// Token: 0x0400283C RID: 10300
		private bool newbieGuideV2_;
	}
}
