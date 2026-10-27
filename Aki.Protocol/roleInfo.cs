using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001088 RID: 4232
	public sealed class roleInfo : IMessage<roleInfo>, IMessage, IEquatable<roleInfo>, IDeepCloneable<roleInfo>, IBufferMessage
	{
		// Token: 0x060169A1 RID: 92577 RVA: 0x0034897E File Offset: 0x00346B7E
		[NullableContext(1)]
		public static roleInfo Create()
		{
			return new roleInfo();
		}

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x060169A2 RID: 92578 RVA: 0x00348985 File Offset: 0x00346B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<roleInfo> Parser
		{
			get
			{
				return roleInfo._parser;
			}
		}

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x060169A3 RID: 92579 RVA: 0x0034898C File Offset: 0x00346B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x060169A4 RID: 92580 RVA: 0x0034898F File Offset: 0x00346B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return roleInfo.Descriptor;
			}
		}

		// Token: 0x060169A5 RID: 92581 RVA: 0x00348998 File Offset: 0x00346B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo()
		{
		}

		// Token: 0x060169A6 RID: 92582 RVA: 0x00348A04 File Offset: 0x00346C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo(roleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.name_ = other.name_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.breakthrough_ = other.breakthrough_;
			this.skills_ = other.skills_.Clone();
			this.phantom_ = other.phantom_.Clone();
			this.star_ = other.star_;
			this.favor_ = other.favor_;
			this.reson_ = other.reson_.Clone();
			this.curModel_ = other.curModel_;
			this.models_ = other.models_.Clone();
			this.baseProp_ = other.baseProp_.Clone();
			this.addProp_ = other.addProp_.Clone();
			this.createTime_ = other.createTime_;
			this.skillNodeState_ = other.skillNodeState_.Clone();
			this.resonantChainGroupIndex_ = other.resonantChainGroupIndex_;
			this.skinId_ = other.skinId_;
			this.enableSelfBgm_ = other.enableSelfBgm_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060169A7 RID: 92583 RVA: 0x00348B2F File Offset: 0x00346D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo Clone()
		{
			return new roleInfo(this);
		}

		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x060169A8 RID: 92584 RVA: 0x00348B37 File Offset: 0x00346D37
		// (set) Token: 0x060169A9 RID: 92585 RVA: 0x00348B3F File Offset: 0x00346D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004BAB RID: 19371
		// (get) Token: 0x060169AA RID: 92586 RVA: 0x00348B48 File Offset: 0x00346D48
		// (set) Token: 0x060169AB RID: 92587 RVA: 0x00348B50 File Offset: 0x00346D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004BAC RID: 19372
		// (get) Token: 0x060169AC RID: 92588 RVA: 0x00348B63 File Offset: 0x00346D63
		// (set) Token: 0x060169AD RID: 92589 RVA: 0x00348B6B File Offset: 0x00346D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004BAD RID: 19373
		// (get) Token: 0x060169AE RID: 92590 RVA: 0x00348B74 File Offset: 0x00346D74
		// (set) Token: 0x060169AF RID: 92591 RVA: 0x00348B7C File Offset: 0x00346D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17004BAE RID: 19374
		// (get) Token: 0x060169B0 RID: 92592 RVA: 0x00348B85 File Offset: 0x00346D85
		// (set) Token: 0x060169B1 RID: 92593 RVA: 0x00348B8D File Offset: 0x00346D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Breakthrough
		{
			get
			{
				return this.breakthrough_;
			}
			set
			{
				this.breakthrough_ = value;
			}
		}

		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x060169B2 RID: 92594 RVA: 0x00348B96 File Offset: 0x00346D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> Skills
		{
			get
			{
				return this.skills_;
			}
		}

		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x060169B3 RID: 92595 RVA: 0x00348B9E File Offset: 0x00346D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> Phantom
		{
			get
			{
				return this.phantom_;
			}
		}

		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x060169B4 RID: 92596 RVA: 0x00348BA6 File Offset: 0x00346DA6
		// (set) Token: 0x060169B5 RID: 92597 RVA: 0x00348BAE File Offset: 0x00346DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x060169B6 RID: 92598 RVA: 0x00348BB7 File Offset: 0x00346DB7
		// (set) Token: 0x060169B7 RID: 92599 RVA: 0x00348BBF File Offset: 0x00346DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Favor
		{
			get
			{
				return this.favor_;
			}
			set
			{
				this.favor_ = value;
			}
		}

		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x060169B8 RID: 92600 RVA: 0x00348BC8 File Offset: 0x00346DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ResonInfo> Reson
		{
			get
			{
				return this.reson_;
			}
		}

		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x060169B9 RID: 92601 RVA: 0x00348BD0 File Offset: 0x00346DD0
		// (set) Token: 0x060169BA RID: 92602 RVA: 0x00348BD8 File Offset: 0x00346DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurModel
		{
			get
			{
				return this.curModel_;
			}
			set
			{
				this.curModel_ = value;
			}
		}

		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x060169BB RID: 92603 RVA: 0x00348BE1 File Offset: 0x00346DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Models
		{
			get
			{
				return this.models_;
			}
		}

		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x060169BC RID: 92604 RVA: 0x00348BE9 File Offset: 0x00346DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x060169BD RID: 92605 RVA: 0x00348BF1 File Offset: 0x00346DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x17004BB8 RID: 19384
		// (get) Token: 0x060169BE RID: 92606 RVA: 0x00348BF9 File Offset: 0x00346DF9
		// (set) Token: 0x060169BF RID: 92607 RVA: 0x00348C01 File Offset: 0x00346E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x17004BB9 RID: 19385
		// (get) Token: 0x060169C0 RID: 92608 RVA: 0x00348C0A File Offset: 0x00346E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArraySkillNode> SkillNodeState
		{
			get
			{
				return this.skillNodeState_;
			}
		}

		// Token: 0x17004BBA RID: 19386
		// (get) Token: 0x060169C1 RID: 92609 RVA: 0x00348C12 File Offset: 0x00346E12
		// (set) Token: 0x060169C2 RID: 92610 RVA: 0x00348C1A File Offset: 0x00346E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResonantChainGroupIndex
		{
			get
			{
				return this.resonantChainGroupIndex_;
			}
			set
			{
				this.resonantChainGroupIndex_ = value;
			}
		}

		// Token: 0x17004BBB RID: 19387
		// (get) Token: 0x060169C3 RID: 92611 RVA: 0x00348C23 File Offset: 0x00346E23
		// (set) Token: 0x060169C4 RID: 92612 RVA: 0x00348C2B File Offset: 0x00346E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17004BBC RID: 19388
		// (get) Token: 0x060169C5 RID: 92613 RVA: 0x00348C34 File Offset: 0x00346E34
		// (set) Token: 0x060169C6 RID: 92614 RVA: 0x00348C3C File Offset: 0x00346E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableSelfBgm
		{
			get
			{
				return this.enableSelfBgm_;
			}
			set
			{
				this.enableSelfBgm_ = value;
			}
		}

		// Token: 0x060169C7 RID: 92615 RVA: 0x00348C45 File Offset: 0x00346E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as roleInfo);
		}

		// Token: 0x060169C8 RID: 92616 RVA: 0x00348C54 File Offset: 0x00346E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(roleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && !(this.Name != other.Name) && this.Level == other.Level && this.Exp == other.Exp && this.Breakthrough == other.Breakthrough && this.skills_.Equals(other.skills_) && this.phantom_.Equals(other.phantom_) && this.Star == other.Star && this.Favor == other.Favor && this.reson_.Equals(other.reson_) && this.CurModel == other.CurModel && this.models_.Equals(other.models_) && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && this.CreateTime == other.CreateTime && this.skillNodeState_.Equals(other.skillNodeState_) && this.ResonantChainGroupIndex == other.ResonantChainGroupIndex && this.SkinId == other.SkinId && this.EnableSelfBgm == other.EnableSelfBgm && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060169C9 RID: 92617 RVA: 0x00348DD8 File Offset: 0x00346FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Breakthrough != 0)
			{
				num ^= this.Breakthrough.GetHashCode();
			}
			num ^= this.skills_.GetHashCode();
			num ^= this.phantom_.GetHashCode();
			if (this.Star != 0)
			{
				num ^= this.Star.GetHashCode();
			}
			if (this.Favor != 0)
			{
				num ^= this.Favor.GetHashCode();
			}
			num ^= this.reson_.GetHashCode();
			if (this.CurModel != 0)
			{
				num ^= this.CurModel.GetHashCode();
			}
			num ^= this.models_.GetHashCode();
			num ^= this.baseProp_.GetHashCode();
			num ^= this.addProp_.GetHashCode();
			if (this.CreateTime != 0U)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			num ^= this.skillNodeState_.GetHashCode();
			if (this.ResonantChainGroupIndex != 0)
			{
				num ^= this.ResonantChainGroupIndex.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this.EnableSelfBgm)
			{
				num ^= this.EnableSelfBgm.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060169CA RID: 92618 RVA: 0x00348F8E File Offset: 0x0034718E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060169CB RID: 92619 RVA: 0x00348F9B File Offset: 0x0034719B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060169CC RID: 92620 RVA: 0x00348FA4 File Offset: 0x003471A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Exp);
			}
			if (this.Breakthrough != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Breakthrough);
			}
			this.skills_.WriteTo(ref output, roleInfo._repeated_skills_codec);
			this.phantom_.WriteTo(ref output, roleInfo._repeated_phantom_codec);
			if (this.Star != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Star);
			}
			if (this.Favor != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Favor);
			}
			this.reson_.WriteTo(ref output, roleInfo._repeated_reson_codec);
			if (this.CurModel != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CurModel);
			}
			this.models_.WriteTo(ref output, roleInfo._repeated_models_codec);
			this.baseProp_.WriteTo(ref output, roleInfo._repeated_baseProp_codec);
			this.addProp_.WriteTo(ref output, roleInfo._repeated_addProp_codec);
			if (this.CreateTime != 0U)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.CreateTime);
			}
			this.skillNodeState_.WriteTo(ref output, roleInfo._repeated_skillNodeState_codec);
			if (this.ResonantChainGroupIndex != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.ResonantChainGroupIndex);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.SkinId);
			}
			if (this.EnableSelfBgm)
			{
				output.WriteRawTag(176, 1);
				output.WriteBool(this.EnableSelfBgm);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060169CD RID: 92621 RVA: 0x003491A0 File Offset: 0x003473A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.Breakthrough != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Breakthrough);
			}
			num += this.skills_.CalculateSize(roleInfo._repeated_skills_codec);
			num += this.phantom_.CalculateSize(roleInfo._repeated_phantom_codec);
			if (this.Star != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Star);
			}
			if (this.Favor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Favor);
			}
			num += this.reson_.CalculateSize(roleInfo._repeated_reson_codec);
			if (this.CurModel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurModel);
			}
			num += this.models_.CalculateSize(roleInfo._repeated_models_codec);
			num += this.baseProp_.CalculateSize(roleInfo._repeated_baseProp_codec);
			num += this.addProp_.CalculateSize(roleInfo._repeated_addProp_codec);
			if (this.CreateTime != 0U)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.CreateTime);
			}
			num += this.skillNodeState_.CalculateSize(roleInfo._repeated_skillNodeState_codec);
			if (this.ResonantChainGroupIndex != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ResonantChainGroupIndex);
			}
			if (this.SkinId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this.EnableSelfBgm)
			{
				num += 3;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060169CE RID: 92622 RVA: 0x00349364 File Offset: 0x00347564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(roleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.Breakthrough != 0)
			{
				this.Breakthrough = other.Breakthrough;
			}
			this.skills_.Add(other.skills_);
			this.phantom_.Add(other.phantom_);
			if (other.Star != 0)
			{
				this.Star = other.Star;
			}
			if (other.Favor != 0)
			{
				this.Favor = other.Favor;
			}
			this.reson_.Add(other.reson_);
			if (other.CurModel != 0)
			{
				this.CurModel = other.CurModel;
			}
			this.models_.Add(other.models_);
			this.baseProp_.Add(other.baseProp_);
			this.addProp_.Add(other.addProp_);
			if (other.CreateTime != 0U)
			{
				this.CreateTime = other.CreateTime;
			}
			this.skillNodeState_.Add(other.skillNodeState_);
			if (other.ResonantChainGroupIndex != 0)
			{
				this.ResonantChainGroupIndex = other.ResonantChainGroupIndex;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			if (other.EnableSelfBgm)
			{
				this.EnableSelfBgm = other.EnableSelfBgm;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060169CF RID: 92623 RVA: 0x003494F8 File Offset: 0x003476F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060169D0 RID: 92624 RVA: 0x00349504 File Offset: 0x00347704
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
				if (num <= 90U)
				{
					if (num <= 40U)
					{
						if (num <= 18U)
						{
							if (num == 8U)
							{
								this.RoleId = input.ReadInt32();
								continue;
							}
							if (num == 18U)
							{
								this.Name = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.Level = input.ReadInt32();
								continue;
							}
							if (num == 32U)
							{
								this.Exp = input.ReadInt32();
								continue;
							}
							if (num == 40U)
							{
								this.Breakthrough = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 58U)
					{
						if (num == 50U)
						{
							this.skills_.AddEntriesFrom(ref input, roleInfo._repeated_skills_codec);
							continue;
						}
						if (num == 58U)
						{
							this.phantom_.AddEntriesFrom(ref input, roleInfo._repeated_phantom_codec);
							continue;
						}
					}
					else
					{
						if (num == 64U)
						{
							this.Star = input.ReadInt32();
							continue;
						}
						if (num == 80U)
						{
							this.Favor = input.ReadInt32();
							continue;
						}
						if (num == 90U)
						{
							this.reson_.AddEntriesFrom(ref input, roleInfo._repeated_reson_codec);
							continue;
						}
					}
				}
				else
				{
					if (num <= 122U)
					{
						if (num <= 104U)
						{
							if (num == 96U)
							{
								this.CurModel = input.ReadInt32();
								continue;
							}
							if (num != 104U)
							{
								goto IL_F7;
							}
						}
						else if (num != 106U)
						{
							if (num == 114U)
							{
								this.baseProp_.AddEntriesFrom(ref input, roleInfo._repeated_baseProp_codec);
								continue;
							}
							if (num != 122U)
							{
								goto IL_F7;
							}
							this.addProp_.AddEntriesFrom(ref input, roleInfo._repeated_addProp_codec);
							continue;
						}
						this.models_.AddEntriesFrom(ref input, roleInfo._repeated_models_codec);
						continue;
					}
					if (num <= 154U)
					{
						if (num == 136U)
						{
							this.CreateTime = input.ReadUInt32();
							continue;
						}
						if (num == 154U)
						{
							this.skillNodeState_.AddEntriesFrom(ref input, roleInfo._repeated_skillNodeState_codec);
							continue;
						}
					}
					else
					{
						if (num == 160U)
						{
							this.ResonantChainGroupIndex = input.ReadInt32();
							continue;
						}
						if (num == 168U)
						{
							this.SkinId = input.ReadInt32();
							continue;
						}
						if (num == 176U)
						{
							this.EnableSelfBgm = input.ReadBool();
							continue;
						}
					}
				}
				IL_F7:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040086F7 RID: 34551
		private static readonly MessageParser<roleInfo> _parser = new MessageParser<roleInfo>(() => new roleInfo());

		// Token: 0x040086F8 RID: 34552
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086F9 RID: 34553
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040086FA RID: 34554
		private int roleId_;

		// Token: 0x040086FB RID: 34555
		public const int NameFieldNumber = 2;

		// Token: 0x040086FC RID: 34556
		private string name_ = "";

		// Token: 0x040086FD RID: 34557
		public const int LevelFieldNumber = 3;

		// Token: 0x040086FE RID: 34558
		private int level_;

		// Token: 0x040086FF RID: 34559
		public const int ExpFieldNumber = 4;

		// Token: 0x04008700 RID: 34560
		private int exp_;

		// Token: 0x04008701 RID: 34561
		public const int BreakthroughFieldNumber = 5;

		// Token: 0x04008702 RID: 34562
		private int breakthrough_;

		// Token: 0x04008703 RID: 34563
		public const int SkillsFieldNumber = 6;

		// Token: 0x04008704 RID: 34564
		private static readonly FieldCodec<ArrayIntInt> _repeated_skills_codec = FieldCodec.ForMessage<ArrayIntInt>(50U, ArrayIntInt.Parser);

		// Token: 0x04008705 RID: 34565
		private readonly RepeatedField<ArrayIntInt> skills_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008706 RID: 34566
		public const int PhantomFieldNumber = 7;

		// Token: 0x04008707 RID: 34567
		private static readonly FieldCodec<ArrayIntInt> _repeated_phantom_codec = FieldCodec.ForMessage<ArrayIntInt>(58U, ArrayIntInt.Parser);

		// Token: 0x04008708 RID: 34568
		private readonly RepeatedField<ArrayIntInt> phantom_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008709 RID: 34569
		public const int StarFieldNumber = 8;

		// Token: 0x0400870A RID: 34570
		private int star_;

		// Token: 0x0400870B RID: 34571
		public const int FavorFieldNumber = 10;

		// Token: 0x0400870C RID: 34572
		private int favor_;

		// Token: 0x0400870D RID: 34573
		public const int ResonFieldNumber = 11;

		// Token: 0x0400870E RID: 34574
		private static readonly FieldCodec<ResonInfo> _repeated_reson_codec = FieldCodec.ForMessage<ResonInfo>(90U, ResonInfo.Parser);

		// Token: 0x0400870F RID: 34575
		private readonly RepeatedField<ResonInfo> reson_ = new RepeatedField<ResonInfo>();

		// Token: 0x04008710 RID: 34576
		public const int CurModelFieldNumber = 12;

		// Token: 0x04008711 RID: 34577
		private int curModel_;

		// Token: 0x04008712 RID: 34578
		public const int ModelsFieldNumber = 13;

		// Token: 0x04008713 RID: 34579
		private static readonly FieldCodec<int> _repeated_models_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04008714 RID: 34580
		private readonly RepeatedField<int> models_ = new RepeatedField<int>();

		// Token: 0x04008715 RID: 34581
		public const int BasePropFieldNumber = 14;

		// Token: 0x04008716 RID: 34582
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(114U, ArrayIntInt.Parser);

		// Token: 0x04008717 RID: 34583
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008718 RID: 34584
		public const int AddPropFieldNumber = 15;

		// Token: 0x04008719 RID: 34585
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(122U, ArrayIntInt.Parser);

		// Token: 0x0400871A RID: 34586
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x0400871B RID: 34587
		public const int CreateTimeFieldNumber = 17;

		// Token: 0x0400871C RID: 34588
		private uint createTime_;

		// Token: 0x0400871D RID: 34589
		public const int SkillNodeStateFieldNumber = 19;

		// Token: 0x0400871E RID: 34590
		private static readonly FieldCodec<ArraySkillNode> _repeated_skillNodeState_codec = FieldCodec.ForMessage<ArraySkillNode>(154U, ArraySkillNode.Parser);

		// Token: 0x0400871F RID: 34591
		private readonly RepeatedField<ArraySkillNode> skillNodeState_ = new RepeatedField<ArraySkillNode>();

		// Token: 0x04008720 RID: 34592
		public const int ResonantChainGroupIndexFieldNumber = 20;

		// Token: 0x04008721 RID: 34593
		private int resonantChainGroupIndex_;

		// Token: 0x04008722 RID: 34594
		public const int SkinIdFieldNumber = 21;

		// Token: 0x04008723 RID: 34595
		private int skinId_;

		// Token: 0x04008724 RID: 34596
		public const int EnableSelfBgmFieldNumber = 22;

		// Token: 0x04008725 RID: 34597
		private bool enableSelfBgm_;
	}
}
