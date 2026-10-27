using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001184 RID: 4484
	public sealed class ScenePlayerInformation : IMessage<ScenePlayerInformation>, IMessage, IEquatable<ScenePlayerInformation>, IDeepCloneable<ScenePlayerInformation>, IBufferMessage
	{
		// Token: 0x06017E4B RID: 97867 RVA: 0x00377F6E File Offset: 0x0037616E
		[NullableContext(1)]
		public static ScenePlayerInformation Create()
		{
			return new ScenePlayerInformation();
		}

		// Token: 0x1700503C RID: 20540
		// (get) Token: 0x06017E4C RID: 97868 RVA: 0x00377F75 File Offset: 0x00376175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScenePlayerInformation> Parser
		{
			get
			{
				return ScenePlayerInformation._parser;
			}
		}

		// Token: 0x1700503D RID: 20541
		// (get) Token: 0x06017E4D RID: 97869 RVA: 0x00377F7C File Offset: 0x0037617C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700503E RID: 20542
		// (get) Token: 0x06017E4E RID: 97870 RVA: 0x00377F7F File Offset: 0x0037617F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScenePlayerInformation.Descriptor;
			}
		}

		// Token: 0x06017E4F RID: 97871 RVA: 0x00377F86 File Offset: 0x00376186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerInformation()
		{
		}

		// Token: 0x06017E50 RID: 97872 RVA: 0x00377FBC File Offset: 0x003761BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerInformation(ScenePlayerInformation other) : this()
		{
			this.playerId_ = other.playerId_;
			this.playerName_ = other.playerName_;
			this.playerIcon_ = other.playerIcon_;
			this.level_ = other.level_;
			this.guildName_ = other.guildName_;
			this.guildIntro_ = other.guildIntro_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.isOffline_ = other.isOffline_;
			this.playerPrefix_ = other.playerPrefix_;
			this.playerGEIncHandle_ = other.playerGEIncHandle_;
			this.playerSceneGroupData_ = other.playerSceneGroupData_.Clone();
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.group_ = other.group_;
			this.curRole_ = other.curRole_;
			this.vehicleInfoPb_ = ((other.vehicleInfoPb_ != null) ? other.vehicleInfoPb_.Clone() : null);
			this.gravityDirection_ = ((other.gravityDirection_ != null) ? other.gravityDirection_.Clone() : null);
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E51 RID: 97873 RVA: 0x003780F1 File Offset: 0x003762F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerInformation Clone()
		{
			return new ScenePlayerInformation(this);
		}

		// Token: 0x1700503F RID: 20543
		// (get) Token: 0x06017E52 RID: 97874 RVA: 0x003780F9 File Offset: 0x003762F9
		// (set) Token: 0x06017E53 RID: 97875 RVA: 0x00378101 File Offset: 0x00376301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17005040 RID: 20544
		// (get) Token: 0x06017E54 RID: 97876 RVA: 0x0037810A File Offset: 0x0037630A
		// (set) Token: 0x06017E55 RID: 97877 RVA: 0x00378112 File Offset: 0x00376312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerName
		{
			get
			{
				return this.playerName_;
			}
			set
			{
				this.playerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005041 RID: 20545
		// (get) Token: 0x06017E56 RID: 97878 RVA: 0x00378125 File Offset: 0x00376325
		// (set) Token: 0x06017E57 RID: 97879 RVA: 0x0037812D File Offset: 0x0037632D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerIcon
		{
			get
			{
				return this.playerIcon_;
			}
			set
			{
				this.playerIcon_ = value;
			}
		}

		// Token: 0x17005042 RID: 20546
		// (get) Token: 0x06017E58 RID: 97880 RVA: 0x00378136 File Offset: 0x00376336
		// (set) Token: 0x06017E59 RID: 97881 RVA: 0x0037813E File Offset: 0x0037633E
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

		// Token: 0x17005043 RID: 20547
		// (get) Token: 0x06017E5A RID: 97882 RVA: 0x00378147 File Offset: 0x00376347
		// (set) Token: 0x06017E5B RID: 97883 RVA: 0x0037814F File Offset: 0x0037634F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GuildName
		{
			get
			{
				return this.guildName_;
			}
			set
			{
				this.guildName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005044 RID: 20548
		// (get) Token: 0x06017E5C RID: 97884 RVA: 0x00378162 File Offset: 0x00376362
		// (set) Token: 0x06017E5D RID: 97885 RVA: 0x0037816A File Offset: 0x0037636A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GuildIntro
		{
			get
			{
				return this.guildIntro_;
			}
			set
			{
				this.guildIntro_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005045 RID: 20549
		// (get) Token: 0x06017E5E RID: 97886 RVA: 0x0037817D File Offset: 0x0037637D
		// (set) Token: 0x06017E5F RID: 97887 RVA: 0x00378185 File Offset: 0x00376385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17005046 RID: 20550
		// (get) Token: 0x06017E60 RID: 97888 RVA: 0x0037818E File Offset: 0x0037638E
		// (set) Token: 0x06017E61 RID: 97889 RVA: 0x00378196 File Offset: 0x00376396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOffline
		{
			get
			{
				return this.isOffline_;
			}
			set
			{
				this.isOffline_ = value;
			}
		}

		// Token: 0x17005047 RID: 20551
		// (get) Token: 0x06017E62 RID: 97890 RVA: 0x0037819F File Offset: 0x0037639F
		// (set) Token: 0x06017E63 RID: 97891 RVA: 0x003781A7 File Offset: 0x003763A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerPrefix
		{
			get
			{
				return this.playerPrefix_;
			}
			set
			{
				this.playerPrefix_ = value;
			}
		}

		// Token: 0x17005048 RID: 20552
		// (get) Token: 0x06017E64 RID: 97892 RVA: 0x003781B0 File Offset: 0x003763B0
		// (set) Token: 0x06017E65 RID: 97893 RVA: 0x003781B8 File Offset: 0x003763B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerGEIncHandle
		{
			get
			{
				return this.playerGEIncHandle_;
			}
			set
			{
				this.playerGEIncHandle_ = value;
			}
		}

		// Token: 0x17005049 RID: 20553
		// (get) Token: 0x06017E66 RID: 97894 RVA: 0x003781C1 File Offset: 0x003763C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSceneGroupData> PlayerSceneGroupData
		{
			get
			{
				return this.playerSceneGroupData_;
			}
		}

		// Token: 0x1700504A RID: 20554
		// (get) Token: 0x06017E67 RID: 97895 RVA: 0x003781C9 File Offset: 0x003763C9
		// (set) Token: 0x06017E68 RID: 97896 RVA: 0x003781D1 File Offset: 0x003763D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x1700504B RID: 20555
		// (get) Token: 0x06017E69 RID: 97897 RVA: 0x003781DA File Offset: 0x003763DA
		// (set) Token: 0x06017E6A RID: 97898 RVA: 0x003781E2 File Offset: 0x003763E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Group
		{
			get
			{
				return this.group_;
			}
			set
			{
				this.group_ = value;
			}
		}

		// Token: 0x1700504C RID: 20556
		// (get) Token: 0x06017E6B RID: 97899 RVA: 0x003781EB File Offset: 0x003763EB
		// (set) Token: 0x06017E6C RID: 97900 RVA: 0x003781F3 File Offset: 0x003763F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRole
		{
			get
			{
				return this.curRole_;
			}
			set
			{
				this.curRole_ = value;
			}
		}

		// Token: 0x1700504D RID: 20557
		// (get) Token: 0x06017E6D RID: 97901 RVA: 0x003781FC File Offset: 0x003763FC
		// (set) Token: 0x06017E6E RID: 97902 RVA: 0x00378204 File Offset: 0x00376404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleInfoPb VehicleInfoPb
		{
			get
			{
				return this.vehicleInfoPb_;
			}
			set
			{
				this.vehicleInfoPb_ = value;
			}
		}

		// Token: 0x1700504E RID: 20558
		// (get) Token: 0x06017E6F RID: 97903 RVA: 0x0037820D File Offset: 0x0037640D
		// (set) Token: 0x06017E70 RID: 97904 RVA: 0x00378215 File Offset: 0x00376415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector GravityDirection
		{
			get
			{
				return this.gravityDirection_;
			}
			set
			{
				this.gravityDirection_ = value;
			}
		}

		// Token: 0x1700504F RID: 20559
		// (get) Token: 0x06017E71 RID: 97905 RVA: 0x0037821E File Offset: 0x0037641E
		// (set) Token: 0x06017E72 RID: 97906 RVA: 0x00378226 File Offset: 0x00376426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x06017E73 RID: 97907 RVA: 0x0037822F File Offset: 0x0037642F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScenePlayerInformation);
		}

		// Token: 0x06017E74 RID: 97908 RVA: 0x00378240 File Offset: 0x00376440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScenePlayerInformation other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.PlayerName != other.PlayerName) && this.PlayerIcon == other.PlayerIcon && this.Level == other.Level && !(this.GuildName != other.GuildName) && !(this.GuildIntro != other.GuildIntro) && object.Equals(this.Location, other.Location) && this.IsOffline == other.IsOffline && this.PlayerPrefix == other.PlayerPrefix && this.PlayerGEIncHandle == other.PlayerGEIncHandle && this.playerSceneGroupData_.Equals(other.playerSceneGroupData_) && object.Equals(this.Rotation, other.Rotation) && this.Group == other.Group && this.CurRole == other.CurRole && object.Equals(this.VehicleInfoPb, other.VehicleInfoPb) && object.Equals(this.GravityDirection, other.GravityDirection) && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E75 RID: 97909 RVA: 0x003783A4 File Offset: 0x003765A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.PlayerName.Length != 0)
			{
				num ^= this.PlayerName.GetHashCode();
			}
			if (this.PlayerIcon != 0)
			{
				num ^= this.PlayerIcon.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.GuildName.Length != 0)
			{
				num ^= this.GuildName.GetHashCode();
			}
			if (this.GuildIntro.Length != 0)
			{
				num ^= this.GuildIntro.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.IsOffline)
			{
				num ^= this.IsOffline.GetHashCode();
			}
			if (this.PlayerPrefix != 0)
			{
				num ^= this.PlayerPrefix.GetHashCode();
			}
			if (this.PlayerGEIncHandle != 0)
			{
				num ^= this.PlayerGEIncHandle.GetHashCode();
			}
			num ^= this.playerSceneGroupData_.GetHashCode();
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.Group != 0)
			{
				num ^= this.Group.GetHashCode();
			}
			if (this.CurRole != 0)
			{
				num ^= this.CurRole.GetHashCode();
			}
			if (this.vehicleInfoPb_ != null)
			{
				num ^= this.VehicleInfoPb.GetHashCode();
			}
			if (this.gravityDirection_ != null)
			{
				num ^= this.GravityDirection.GetHashCode();
			}
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017E76 RID: 97910 RVA: 0x00378562 File Offset: 0x00376762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E77 RID: 97911 RVA: 0x0037856F File Offset: 0x0037676F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E78 RID: 97912 RVA: 0x00378578 File Offset: 0x00376778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.PlayerName);
			}
			if (this.PlayerIcon != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerIcon);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this.GuildName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.GuildName);
			}
			if (this.GuildIntro.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.GuildIntro);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Location);
			}
			if (this.IsOffline)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsOffline);
			}
			if (this.PlayerPrefix != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerPrefix);
			}
			if (this.PlayerGEIncHandle != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerGEIncHandle);
			}
			this.playerSceneGroupData_.WriteTo(ref output, ScenePlayerInformation._repeated_playerSceneGroupData_codec);
			if (this.rotation_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Rotation);
			}
			if (this.Group != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Group);
			}
			if (this.CurRole != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurRole);
			}
			if (this.vehicleInfoPb_ != null)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.VehicleInfoPb);
			}
			if (this.gravityDirection_ != null)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.GravityDirection);
			}
			if (this.AreaId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E79 RID: 97913 RVA: 0x00378784 File Offset: 0x00376984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.PlayerName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PlayerName);
			}
			if (this.PlayerIcon != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerIcon);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.GuildName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GuildName);
			}
			if (this.GuildIntro.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GuildIntro);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.IsOffline)
			{
				num += 2;
			}
			if (this.PlayerPrefix != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerPrefix);
			}
			if (this.PlayerGEIncHandle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerGEIncHandle);
			}
			num += this.playerSceneGroupData_.CalculateSize(ScenePlayerInformation._repeated_playerSceneGroupData_codec);
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.Group != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Group);
			}
			if (this.CurRole != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRole);
			}
			if (this.vehicleInfoPb_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.VehicleInfoPb);
			}
			if (this.gravityDirection_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GravityDirection);
			}
			if (this.AreaId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017E7A RID: 97914 RVA: 0x00378940 File Offset: 0x00376B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScenePlayerInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.PlayerName.Length != 0)
			{
				this.PlayerName = other.PlayerName;
			}
			if (other.PlayerIcon != 0)
			{
				this.PlayerIcon = other.PlayerIcon;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.GuildName.Length != 0)
			{
				this.GuildName = other.GuildName;
			}
			if (other.GuildIntro.Length != 0)
			{
				this.GuildIntro = other.GuildIntro;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.IsOffline)
			{
				this.IsOffline = other.IsOffline;
			}
			if (other.PlayerPrefix != 0)
			{
				this.PlayerPrefix = other.PlayerPrefix;
			}
			if (other.PlayerGEIncHandle != 0)
			{
				this.PlayerGEIncHandle = other.PlayerGEIncHandle;
			}
			this.playerSceneGroupData_.Add(other.playerSceneGroupData_);
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.Group != 0)
			{
				this.Group = other.Group;
			}
			if (other.CurRole != 0)
			{
				this.CurRole = other.CurRole;
			}
			if (other.vehicleInfoPb_ != null)
			{
				if (this.vehicleInfoPb_ == null)
				{
					this.VehicleInfoPb = new VehicleInfoPb();
				}
				this.VehicleInfoPb.MergeFrom(other.VehicleInfoPb);
			}
			if (other.gravityDirection_ != null)
			{
				if (this.gravityDirection_ == null)
				{
					this.GravityDirection = new Vector();
				}
				this.GravityDirection.MergeFrom(other.GravityDirection);
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E7B RID: 97915 RVA: 0x00378B28 File Offset: 0x00376D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E7C RID: 97916 RVA: 0x00378B34 File Offset: 0x00376D34
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
						if (num <= 18U)
						{
							if (num == 8U)
							{
								this.PlayerId = input.ReadInt32();
								continue;
							}
							if (num == 18U)
							{
								this.PlayerName = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.PlayerIcon = input.ReadInt32();
								continue;
							}
							if (num == 32U)
							{
								this.Level = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 42U)
						{
							this.GuildName = input.ReadString();
							continue;
						}
						if (num == 50U)
						{
							this.GuildIntro = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
							continue;
						}
						if (num == 64U)
						{
							this.IsOffline = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num <= 80U)
					{
						if (num == 72U)
						{
							this.PlayerPrefix = input.ReadInt32();
							continue;
						}
						if (num == 80U)
						{
							this.PlayerGEIncHandle = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							this.playerSceneGroupData_.AddEntriesFrom(ref input, ScenePlayerInformation._repeated_playerSceneGroupData_codec);
							continue;
						}
						if (num == 106U)
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num == 112U)
					{
						this.Group = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.CurRole = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 130U)
					{
						if (this.vehicleInfoPb_ == null)
						{
							this.VehicleInfoPb = new VehicleInfoPb();
						}
						input.ReadMessage(this.VehicleInfoPb);
						continue;
					}
					if (num == 138U)
					{
						if (this.gravityDirection_ == null)
						{
							this.GravityDirection = new Vector();
						}
						input.ReadMessage(this.GravityDirection);
						continue;
					}
					if (num == 144U)
					{
						this.AreaId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008D80 RID: 36224
		private static readonly MessageParser<ScenePlayerInformation> _parser = new MessageParser<ScenePlayerInformation>(() => new ScenePlayerInformation());

		// Token: 0x04008D81 RID: 36225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D82 RID: 36226
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04008D83 RID: 36227
		private int playerId_;

		// Token: 0x04008D84 RID: 36228
		public const int PlayerNameFieldNumber = 2;

		// Token: 0x04008D85 RID: 36229
		private string playerName_ = "";

		// Token: 0x04008D86 RID: 36230
		public const int PlayerIconFieldNumber = 3;

		// Token: 0x04008D87 RID: 36231
		private int playerIcon_;

		// Token: 0x04008D88 RID: 36232
		public const int LevelFieldNumber = 4;

		// Token: 0x04008D89 RID: 36233
		private int level_;

		// Token: 0x04008D8A RID: 36234
		public const int GuildNameFieldNumber = 5;

		// Token: 0x04008D8B RID: 36235
		private string guildName_ = "";

		// Token: 0x04008D8C RID: 36236
		public const int GuildIntroFieldNumber = 6;

		// Token: 0x04008D8D RID: 36237
		private string guildIntro_ = "";

		// Token: 0x04008D8E RID: 36238
		public const int LocationFieldNumber = 7;

		// Token: 0x04008D8F RID: 36239
		private Vector location_;

		// Token: 0x04008D90 RID: 36240
		public const int IsOfflineFieldNumber = 8;

		// Token: 0x04008D91 RID: 36241
		private bool isOffline_;

		// Token: 0x04008D92 RID: 36242
		public const int PlayerPrefixFieldNumber = 9;

		// Token: 0x04008D93 RID: 36243
		private int playerPrefix_;

		// Token: 0x04008D94 RID: 36244
		public const int PlayerGEIncHandleFieldNumber = 10;

		// Token: 0x04008D95 RID: 36245
		private int playerGEIncHandle_;

		// Token: 0x04008D96 RID: 36246
		public const int PlayerSceneGroupDataFieldNumber = 11;

		// Token: 0x04008D97 RID: 36247
		private static readonly FieldCodec<PlayerSceneGroupData> _repeated_playerSceneGroupData_codec = FieldCodec.ForMessage<PlayerSceneGroupData>(90U, Aki.Protocol.PlayerSceneGroupData.Parser);

		// Token: 0x04008D98 RID: 36248
		private readonly RepeatedField<PlayerSceneGroupData> playerSceneGroupData_ = new RepeatedField<PlayerSceneGroupData>();

		// Token: 0x04008D99 RID: 36249
		public const int RotationFieldNumber = 13;

		// Token: 0x04008D9A RID: 36250
		private Rotator rotation_;

		// Token: 0x04008D9B RID: 36251
		public const int GroupFieldNumber = 14;

		// Token: 0x04008D9C RID: 36252
		private int group_;

		// Token: 0x04008D9D RID: 36253
		public const int CurRoleFieldNumber = 15;

		// Token: 0x04008D9E RID: 36254
		private int curRole_;

		// Token: 0x04008D9F RID: 36255
		public const int VehicleInfoPbFieldNumber = 16;

		// Token: 0x04008DA0 RID: 36256
		private VehicleInfoPb vehicleInfoPb_;

		// Token: 0x04008DA1 RID: 36257
		public const int GravityDirectionFieldNumber = 17;

		// Token: 0x04008DA2 RID: 36258
		private Vector gravityDirection_;

		// Token: 0x04008DA3 RID: 36259
		public const int AreaIdFieldNumber = 18;

		// Token: 0x04008DA4 RID: 36260
		private int areaId_;
	}
}
