using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001078 RID: 4216
	public sealed class roleInfo : IMessage<roleInfo>, IMessage, IEquatable<roleInfo>, IDeepCloneable<roleInfo>, IBufferMessage
	{
		// Token: 0x060168BC RID: 92348 RVA: 0x003472A6 File Offset: 0x003454A6
		[NullableContext(1)]
		public static roleInfo Create()
		{
			return new roleInfo();
		}

		// Token: 0x17004B7D RID: 19325
		// (get) Token: 0x060168BD RID: 92349 RVA: 0x003472AD File Offset: 0x003454AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<roleInfo> Parser
		{
			get
			{
				return roleInfo._parser;
			}
		}

		// Token: 0x17004B7E RID: 19326
		// (get) Token: 0x060168BE RID: 92350 RVA: 0x003472B4 File Offset: 0x003454B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x060168BF RID: 92351 RVA: 0x003472B7 File Offset: 0x003454B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return roleInfo.Descriptor;
			}
		}

		// Token: 0x060168C0 RID: 92352 RVA: 0x003472C0 File Offset: 0x003454C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo()
		{
		}

		// Token: 0x060168C1 RID: 92353 RVA: 0x0034732C File Offset: 0x0034552C
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

		// Token: 0x060168C2 RID: 92354 RVA: 0x00347457 File Offset: 0x00345657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo Clone()
		{
			return new roleInfo(this);
		}

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x060168C3 RID: 92355 RVA: 0x0034745F File Offset: 0x0034565F
		// (set) Token: 0x060168C4 RID: 92356 RVA: 0x00347467 File Offset: 0x00345667
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

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x060168C5 RID: 92357 RVA: 0x00347470 File Offset: 0x00345670
		// (set) Token: 0x060168C6 RID: 92358 RVA: 0x00347478 File Offset: 0x00345678
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

		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x060168C7 RID: 92359 RVA: 0x0034748B File Offset: 0x0034568B
		// (set) Token: 0x060168C8 RID: 92360 RVA: 0x00347493 File Offset: 0x00345693
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

		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x060168C9 RID: 92361 RVA: 0x0034749C File Offset: 0x0034569C
		// (set) Token: 0x060168CA RID: 92362 RVA: 0x003474A4 File Offset: 0x003456A4
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

		// Token: 0x17004B84 RID: 19332
		// (get) Token: 0x060168CB RID: 92363 RVA: 0x003474AD File Offset: 0x003456AD
		// (set) Token: 0x060168CC RID: 92364 RVA: 0x003474B5 File Offset: 0x003456B5
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

		// Token: 0x17004B85 RID: 19333
		// (get) Token: 0x060168CD RID: 92365 RVA: 0x003474BE File Offset: 0x003456BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> Skills
		{
			get
			{
				return this.skills_;
			}
		}

		// Token: 0x17004B86 RID: 19334
		// (get) Token: 0x060168CE RID: 92366 RVA: 0x003474C6 File Offset: 0x003456C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> Phantom
		{
			get
			{
				return this.phantom_;
			}
		}

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x060168CF RID: 92367 RVA: 0x003474CE File Offset: 0x003456CE
		// (set) Token: 0x060168D0 RID: 92368 RVA: 0x003474D6 File Offset: 0x003456D6
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

		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x060168D1 RID: 92369 RVA: 0x003474DF File Offset: 0x003456DF
		// (set) Token: 0x060168D2 RID: 92370 RVA: 0x003474E7 File Offset: 0x003456E7
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

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x060168D3 RID: 92371 RVA: 0x003474F0 File Offset: 0x003456F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ResonInfo> Reson
		{
			get
			{
				return this.reson_;
			}
		}

		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x060168D4 RID: 92372 RVA: 0x003474F8 File Offset: 0x003456F8
		// (set) Token: 0x060168D5 RID: 92373 RVA: 0x00347500 File Offset: 0x00345700
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

		// Token: 0x17004B8B RID: 19339
		// (get) Token: 0x060168D6 RID: 92374 RVA: 0x00347509 File Offset: 0x00345709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Models
		{
			get
			{
				return this.models_;
			}
		}

		// Token: 0x17004B8C RID: 19340
		// (get) Token: 0x060168D7 RID: 92375 RVA: 0x00347511 File Offset: 0x00345711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x17004B8D RID: 19341
		// (get) Token: 0x060168D8 RID: 92376 RVA: 0x00347519 File Offset: 0x00345719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x17004B8E RID: 19342
		// (get) Token: 0x060168D9 RID: 92377 RVA: 0x00347521 File Offset: 0x00345721
		// (set) Token: 0x060168DA RID: 92378 RVA: 0x00347529 File Offset: 0x00345729
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

		// Token: 0x17004B8F RID: 19343
		// (get) Token: 0x060168DB RID: 92379 RVA: 0x00347532 File Offset: 0x00345732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArraySkillNode> SkillNodeState
		{
			get
			{
				return this.skillNodeState_;
			}
		}

		// Token: 0x17004B90 RID: 19344
		// (get) Token: 0x060168DC RID: 92380 RVA: 0x0034753A File Offset: 0x0034573A
		// (set) Token: 0x060168DD RID: 92381 RVA: 0x00347542 File Offset: 0x00345742
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

		// Token: 0x17004B91 RID: 19345
		// (get) Token: 0x060168DE RID: 92382 RVA: 0x0034754B File Offset: 0x0034574B
		// (set) Token: 0x060168DF RID: 92383 RVA: 0x00347553 File Offset: 0x00345753
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

		// Token: 0x17004B92 RID: 19346
		// (get) Token: 0x060168E0 RID: 92384 RVA: 0x0034755C File Offset: 0x0034575C
		// (set) Token: 0x060168E1 RID: 92385 RVA: 0x00347564 File Offset: 0x00345764
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

		// Token: 0x060168E2 RID: 92386 RVA: 0x0034756D File Offset: 0x0034576D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as roleInfo);
		}

		// Token: 0x060168E3 RID: 92387 RVA: 0x0034757C File Offset: 0x0034577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(roleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && !(this.Name != other.Name) && this.Level == other.Level && this.Exp == other.Exp && this.Breakthrough == other.Breakthrough && this.skills_.Equals(other.skills_) && this.phantom_.Equals(other.phantom_) && this.Star == other.Star && this.Favor == other.Favor && this.reson_.Equals(other.reson_) && this.CurModel == other.CurModel && this.models_.Equals(other.models_) && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && this.CreateTime == other.CreateTime && this.skillNodeState_.Equals(other.skillNodeState_) && this.ResonantChainGroupIndex == other.ResonantChainGroupIndex && this.SkinId == other.SkinId && this.EnableSelfBgm == other.EnableSelfBgm && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060168E4 RID: 92388 RVA: 0x00347700 File Offset: 0x00345900
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

		// Token: 0x060168E5 RID: 92389 RVA: 0x003478B6 File Offset: 0x00345AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168E6 RID: 92390 RVA: 0x003478C3 File Offset: 0x00345AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168E7 RID: 92391 RVA: 0x003478CC File Offset: 0x00345ACC
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

		// Token: 0x060168E8 RID: 92392 RVA: 0x00347AC8 File Offset: 0x00345CC8
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

		// Token: 0x060168E9 RID: 92393 RVA: 0x00347C8C File Offset: 0x00345E8C
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

		// Token: 0x060168EA RID: 92394 RVA: 0x00347E20 File Offset: 0x00346020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060168EB RID: 92395 RVA: 0x00347E2C File Offset: 0x0034602C
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

		// Token: 0x04008721 RID: 34593
		private static readonly MessageParser<roleInfo> _parser = new MessageParser<roleInfo>(() => new roleInfo());

		// Token: 0x04008722 RID: 34594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008723 RID: 34595
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008724 RID: 34596
		private int roleId_;

		// Token: 0x04008725 RID: 34597
		public const int NameFieldNumber = 2;

		// Token: 0x04008726 RID: 34598
		private string name_ = "";

		// Token: 0x04008727 RID: 34599
		public const int LevelFieldNumber = 3;

		// Token: 0x04008728 RID: 34600
		private int level_;

		// Token: 0x04008729 RID: 34601
		public const int ExpFieldNumber = 4;

		// Token: 0x0400872A RID: 34602
		private int exp_;

		// Token: 0x0400872B RID: 34603
		public const int BreakthroughFieldNumber = 5;

		// Token: 0x0400872C RID: 34604
		private int breakthrough_;

		// Token: 0x0400872D RID: 34605
		public const int SkillsFieldNumber = 6;

		// Token: 0x0400872E RID: 34606
		private static readonly FieldCodec<ArrayIntInt> _repeated_skills_codec = FieldCodec.ForMessage<ArrayIntInt>(50U, ArrayIntInt.Parser);

		// Token: 0x0400872F RID: 34607
		private readonly RepeatedField<ArrayIntInt> skills_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008730 RID: 34608
		public const int PhantomFieldNumber = 7;

		// Token: 0x04008731 RID: 34609
		private static readonly FieldCodec<ArrayIntInt> _repeated_phantom_codec = FieldCodec.ForMessage<ArrayIntInt>(58U, ArrayIntInt.Parser);

		// Token: 0x04008732 RID: 34610
		private readonly RepeatedField<ArrayIntInt> phantom_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008733 RID: 34611
		public const int StarFieldNumber = 8;

		// Token: 0x04008734 RID: 34612
		private int star_;

		// Token: 0x04008735 RID: 34613
		public const int FavorFieldNumber = 10;

		// Token: 0x04008736 RID: 34614
		private int favor_;

		// Token: 0x04008737 RID: 34615
		public const int ResonFieldNumber = 11;

		// Token: 0x04008738 RID: 34616
		private static readonly FieldCodec<ResonInfo> _repeated_reson_codec = FieldCodec.ForMessage<ResonInfo>(90U, ResonInfo.Parser);

		// Token: 0x04008739 RID: 34617
		private readonly RepeatedField<ResonInfo> reson_ = new RepeatedField<ResonInfo>();

		// Token: 0x0400873A RID: 34618
		public const int CurModelFieldNumber = 12;

		// Token: 0x0400873B RID: 34619
		private int curModel_;

		// Token: 0x0400873C RID: 34620
		public const int ModelsFieldNumber = 13;

		// Token: 0x0400873D RID: 34621
		private static readonly FieldCodec<int> _repeated_models_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400873E RID: 34622
		private readonly RepeatedField<int> models_ = new RepeatedField<int>();

		// Token: 0x0400873F RID: 34623
		public const int BasePropFieldNumber = 14;

		// Token: 0x04008740 RID: 34624
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(114U, ArrayIntInt.Parser);

		// Token: 0x04008741 RID: 34625
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008742 RID: 34626
		public const int AddPropFieldNumber = 15;

		// Token: 0x04008743 RID: 34627
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(122U, ArrayIntInt.Parser);

		// Token: 0x04008744 RID: 34628
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04008745 RID: 34629
		public const int CreateTimeFieldNumber = 17;

		// Token: 0x04008746 RID: 34630
		private uint createTime_;

		// Token: 0x04008747 RID: 34631
		public const int SkillNodeStateFieldNumber = 19;

		// Token: 0x04008748 RID: 34632
		private static readonly FieldCodec<ArraySkillNode> _repeated_skillNodeState_codec = FieldCodec.ForMessage<ArraySkillNode>(154U, ArraySkillNode.Parser);

		// Token: 0x04008749 RID: 34633
		private readonly RepeatedField<ArraySkillNode> skillNodeState_ = new RepeatedField<ArraySkillNode>();

		// Token: 0x0400874A RID: 34634
		public const int ResonantChainGroupIndexFieldNumber = 20;

		// Token: 0x0400874B RID: 34635
		private int resonantChainGroupIndex_;

		// Token: 0x0400874C RID: 34636
		public const int SkinIdFieldNumber = 21;

		// Token: 0x0400874D RID: 34637
		private int skinId_;

		// Token: 0x0400874E RID: 34638
		public const int EnableSelfBgmFieldNumber = 22;

		// Token: 0x0400874F RID: 34639
		private bool enableSelfBgm_;
	}
}
