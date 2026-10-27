using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015A RID: 346
	[NetMessage(EMessageId.BasicInfoNotify)]
	public sealed class BasicInfoNotify : IMessage<BasicInfoNotify>, IMessage, IEquatable<BasicInfoNotify>, IDeepCloneable<BasicInfoNotify>, IBufferMessage
	{
		// Token: 0x06002B91 RID: 11153 RVA: 0x00071857 File Offset: 0x0006FA57
		[NullableContext(1)]
		public static BasicInfoNotify Create()
		{
			return new BasicInfoNotify();
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x0007185E File Offset: 0x0006FA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x00071861 File Offset: 0x0006FA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BasicInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00071868 File Offset: 0x0006FA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicInfoNotify()
		{
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x000718C0 File Offset: 0x0006FAC0
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

		// Token: 0x06002B96 RID: 11158 RVA: 0x000719A5 File Offset: 0x0006FBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicInfoNotify Clone()
		{
			return new BasicInfoNotify(this);
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x000719AD File Offset: 0x0006FBAD
		// (set) Token: 0x06002B98 RID: 11160 RVA: 0x000719B5 File Offset: 0x0006FBB5
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

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x000719BE File Offset: 0x0006FBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerAttr> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000719C6 File Offset: 0x0006FBC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MingSuGenInfo> MingSuGenInfos
		{
			get
			{
				return this.mingSuGenInfos_;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000719CE File Offset: 0x0006FBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DragonPoolInfo> DragonPoolInfos
		{
			get
			{
				return this.dragonPoolInfos_;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x000719D6 File Offset: 0x0006FBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleShowEntry> RoleShowList
		{
			get
			{
				return this.roleShowList_;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x000719DE File Offset: 0x0006FBDE
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x000719E6 File Offset: 0x0006FBE6
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

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000719EF File Offset: 0x0006FBEF
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x000719F7 File Offset: 0x0006FBF7
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

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x00071A00 File Offset: 0x0006FC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CardShowEntry> CardUnlockList
		{
			get
			{
				return this.cardUnlockList_;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x00071A08 File Offset: 0x0006FC08
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x00071A10 File Offset: 0x0006FC10
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

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x00071A19 File Offset: 0x0006FC19
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x00071A21 File Offset: 0x0006FC21
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

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x00071A2A File Offset: 0x0006FC2A
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x00071A32 File Offset: 0x0006FC32
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

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x00071A3B File Offset: 0x0006FC3B
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x00071A43 File Offset: 0x0006FC43
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

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x00071A56 File Offset: 0x0006FC56
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00071A5E File Offset: 0x0006FC5E
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

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x00071A67 File Offset: 0x0006FC67
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x00071A6F File Offset: 0x0006FC6F
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

		// Token: 0x06002BAE RID: 11182 RVA: 0x00071A78 File Offset: 0x0006FC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BasicInfoNotify);
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00071A88 File Offset: 0x0006FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BasicInfoNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.attributes_.Equals(other.attributes_) && this.mingSuGenInfos_.Equals(other.mingSuGenInfos_) && this.dragonPoolInfos_.Equals(other.dragonPoolInfos_) && this.roleShowList_.Equals(other.roleShowList_) && this.CurCardId == other.CurCardId && this.Birthday == other.Birthday && this.cardUnlockList_.Equals(other.cardUnlockList_) && this.RandomSeed == other.RandomSeed && this.DisplayBirthDay == other.DisplayBirthDay && this.LastModifyNameTime == other.LastModifyNameTime && !(this.ModifyName != other.ModifyName) && this.BusinessCompliance == other.BusinessCompliance && this.NewbieGuideV2 == other.NewbieGuideV2 && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00071BB0 File Offset: 0x0006FDB0
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

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00071CFF File Offset: 0x0006FEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00071D0C File Offset: 0x0006FF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00071D18 File Offset: 0x0006FF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Birthday != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Birthday);
			}
			if (this.ModifyName.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ModifyName);
			}
			this.dragonPoolInfos_.WriteTo(ref output, BasicInfoNotify._repeated_dragonPoolInfos_codec);
			this.mingSuGenInfos_.WriteTo(ref output, BasicInfoNotify._repeated_mingSuGenInfos_codec);
			if (this.NewbieGuideV2)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NewbieGuideV2);
			}
			if (this.LastModifyNameTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LastModifyNameTime);
			}
			if (this.CurCardId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurCardId);
			}
			if (this.BusinessCompliance)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.BusinessCompliance);
			}
			if (this.RandomSeed != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RandomSeed);
			}
			if (this.DisplayBirthDay)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.DisplayBirthDay);
			}
			this.roleShowList_.WriteTo(ref output, BasicInfoNotify._repeated_roleShowList_codec);
			this.cardUnlockList_.WriteTo(ref output, BasicInfoNotify._repeated_cardUnlockList_codec);
			this.attributes_.WriteTo(ref output, BasicInfoNotify._repeated_attributes_codec);
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00071E90 File Offset: 0x00070090
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

		// Token: 0x06002BB5 RID: 11189 RVA: 0x00071FD0 File Offset: 0x000701D0
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

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00072106 File Offset: 0x00070306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00072110 File Offset: 0x00070310
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
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.Birthday = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							this.ModifyName = input.ReadString();
							continue;
						}
						if (num == 26U)
						{
							this.dragonPoolInfos_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_dragonPoolInfos_codec);
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 34U)
						{
							this.mingSuGenInfos_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_mingSuGenInfos_codec);
							continue;
						}
						if (num == 40U)
						{
							this.NewbieGuideV2 = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.LastModifyNameTime = input.ReadInt64();
							continue;
						}
						if (num == 64U)
						{
							this.CurCardId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.BusinessCompliance = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.RandomSeed = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.DisplayBirthDay = input.ReadBool();
						continue;
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						this.roleShowList_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_roleShowList_codec);
						continue;
					}
					if (num == 106U)
					{
						this.cardUnlockList_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_cardUnlockList_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.attributes_.AddEntriesFrom(ref input, BasicInfoNotify._repeated_attributes_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027A7 RID: 10151
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027A8 RID: 10152
		public const int IdFieldNumber = 15;

		// Token: 0x040027A9 RID: 10153
		private int id_;

		// Token: 0x040027AA RID: 10154
		public const int AttributesFieldNumber = 14;

		// Token: 0x040027AB RID: 10155
		private static readonly FieldCodec<PlayerAttr> _repeated_attributes_codec = FieldCodec.ForMessage<PlayerAttr>(114U, PlayerAttr.Parser);

		// Token: 0x040027AC RID: 10156
		private readonly RepeatedField<PlayerAttr> attributes_ = new RepeatedField<PlayerAttr>();

		// Token: 0x040027AD RID: 10157
		public const int MingSuGenInfosFieldNumber = 4;

		// Token: 0x040027AE RID: 10158
		private static readonly FieldCodec<MingSuGenInfo> _repeated_mingSuGenInfos_codec = FieldCodec.ForMessage<MingSuGenInfo>(34U, MingSuGenInfo.Parser);

		// Token: 0x040027AF RID: 10159
		private readonly RepeatedField<MingSuGenInfo> mingSuGenInfos_ = new RepeatedField<MingSuGenInfo>();

		// Token: 0x040027B0 RID: 10160
		public const int DragonPoolInfosFieldNumber = 3;

		// Token: 0x040027B1 RID: 10161
		private static readonly FieldCodec<DragonPoolInfo> _repeated_dragonPoolInfos_codec = FieldCodec.ForMessage<DragonPoolInfo>(26U, DragonPoolInfo.Parser);

		// Token: 0x040027B2 RID: 10162
		private readonly RepeatedField<DragonPoolInfo> dragonPoolInfos_ = new RepeatedField<DragonPoolInfo>();

		// Token: 0x040027B3 RID: 10163
		public const int RoleShowListFieldNumber = 12;

		// Token: 0x040027B4 RID: 10164
		private static readonly FieldCodec<RoleShowEntry> _repeated_roleShowList_codec = FieldCodec.ForMessage<RoleShowEntry>(98U, RoleShowEntry.Parser);

		// Token: 0x040027B5 RID: 10165
		private readonly RepeatedField<RoleShowEntry> roleShowList_ = new RepeatedField<RoleShowEntry>();

		// Token: 0x040027B6 RID: 10166
		public const int CurCardIdFieldNumber = 8;

		// Token: 0x040027B7 RID: 10167
		private int curCardId_;

		// Token: 0x040027B8 RID: 10168
		public const int BirthdayFieldNumber = 1;

		// Token: 0x040027B9 RID: 10169
		private int birthday_;

		// Token: 0x040027BA RID: 10170
		public const int CardUnlockListFieldNumber = 13;

		// Token: 0x040027BB RID: 10171
		private static readonly FieldCodec<CardShowEntry> _repeated_cardUnlockList_codec = FieldCodec.ForMessage<CardShowEntry>(106U, CardShowEntry.Parser);

		// Token: 0x040027BC RID: 10172
		private readonly RepeatedField<CardShowEntry> cardUnlockList_ = new RepeatedField<CardShowEntry>();

		// Token: 0x040027BD RID: 10173
		public const int RandomSeedFieldNumber = 10;

		// Token: 0x040027BE RID: 10174
		private int randomSeed_;

		// Token: 0x040027BF RID: 10175
		public const int DisplayBirthDayFieldNumber = 11;

		// Token: 0x040027C0 RID: 10176
		private bool displayBirthDay_;

		// Token: 0x040027C1 RID: 10177
		public const int LastModifyNameTimeFieldNumber = 6;

		// Token: 0x040027C2 RID: 10178
		private long lastModifyNameTime_;

		// Token: 0x040027C3 RID: 10179
		public const int ModifyNameFieldNumber = 2;

		// Token: 0x040027C4 RID: 10180
		private string modifyName_ = "";

		// Token: 0x040027C5 RID: 10181
		public const int BusinessComplianceFieldNumber = 9;

		// Token: 0x040027C6 RID: 10182
		private bool businessCompliance_;

		// Token: 0x040027C7 RID: 10183
		public const int NewbieGuideV2FieldNumber = 5;

		// Token: 0x040027C8 RID: 10184
		private bool newbieGuideV2_;
	}
}
