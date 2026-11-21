using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BE RID: 4542
	public sealed class ScenePlayerInformation : IMessage<ScenePlayerInformation>, IMessage, IEquatable<ScenePlayerInformation>, IDeepCloneable<ScenePlayerInformation>, IBufferMessage
	{
		// Token: 0x060183EC RID: 99308 RVA: 0x003872B2 File Offset: 0x003854B2
		[NullableContext(1)]
		public static ScenePlayerInformation Create()
		{
			return new ScenePlayerInformation();
		}

		// Token: 0x170051A8 RID: 20904
		// (get) Token: 0x060183ED RID: 99309 RVA: 0x003872B9 File Offset: 0x003854B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScenePlayerInformation> Parser
		{
			get
			{
				return ScenePlayerInformation._parser;
			}
		}

		// Token: 0x170051A9 RID: 20905
		// (get) Token: 0x060183EE RID: 99310 RVA: 0x003872C0 File Offset: 0x003854C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051AA RID: 20906
		// (get) Token: 0x060183EF RID: 99311 RVA: 0x003872C3 File Offset: 0x003854C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScenePlayerInformation.Descriptor;
			}
		}

		// Token: 0x060183F0 RID: 99312 RVA: 0x003872CA File Offset: 0x003854CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerInformation()
		{
		}

		// Token: 0x060183F1 RID: 99313 RVA: 0x00387300 File Offset: 0x00385500
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

		// Token: 0x060183F2 RID: 99314 RVA: 0x00387435 File Offset: 0x00385635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerInformation Clone()
		{
			return new ScenePlayerInformation(this);
		}

		// Token: 0x170051AB RID: 20907
		// (get) Token: 0x060183F3 RID: 99315 RVA: 0x0038743D File Offset: 0x0038563D
		// (set) Token: 0x060183F4 RID: 99316 RVA: 0x00387445 File Offset: 0x00385645
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

		// Token: 0x170051AC RID: 20908
		// (get) Token: 0x060183F5 RID: 99317 RVA: 0x0038744E File Offset: 0x0038564E
		// (set) Token: 0x060183F6 RID: 99318 RVA: 0x00387456 File Offset: 0x00385656
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

		// Token: 0x170051AD RID: 20909
		// (get) Token: 0x060183F7 RID: 99319 RVA: 0x00387469 File Offset: 0x00385669
		// (set) Token: 0x060183F8 RID: 99320 RVA: 0x00387471 File Offset: 0x00385671
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

		// Token: 0x170051AE RID: 20910
		// (get) Token: 0x060183F9 RID: 99321 RVA: 0x0038747A File Offset: 0x0038567A
		// (set) Token: 0x060183FA RID: 99322 RVA: 0x00387482 File Offset: 0x00385682
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

		// Token: 0x170051AF RID: 20911
		// (get) Token: 0x060183FB RID: 99323 RVA: 0x0038748B File Offset: 0x0038568B
		// (set) Token: 0x060183FC RID: 99324 RVA: 0x00387493 File Offset: 0x00385693
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

		// Token: 0x170051B0 RID: 20912
		// (get) Token: 0x060183FD RID: 99325 RVA: 0x003874A6 File Offset: 0x003856A6
		// (set) Token: 0x060183FE RID: 99326 RVA: 0x003874AE File Offset: 0x003856AE
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

		// Token: 0x170051B1 RID: 20913
		// (get) Token: 0x060183FF RID: 99327 RVA: 0x003874C1 File Offset: 0x003856C1
		// (set) Token: 0x06018400 RID: 99328 RVA: 0x003874C9 File Offset: 0x003856C9
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

		// Token: 0x170051B2 RID: 20914
		// (get) Token: 0x06018401 RID: 99329 RVA: 0x003874D2 File Offset: 0x003856D2
		// (set) Token: 0x06018402 RID: 99330 RVA: 0x003874DA File Offset: 0x003856DA
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

		// Token: 0x170051B3 RID: 20915
		// (get) Token: 0x06018403 RID: 99331 RVA: 0x003874E3 File Offset: 0x003856E3
		// (set) Token: 0x06018404 RID: 99332 RVA: 0x003874EB File Offset: 0x003856EB
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

		// Token: 0x170051B4 RID: 20916
		// (get) Token: 0x06018405 RID: 99333 RVA: 0x003874F4 File Offset: 0x003856F4
		// (set) Token: 0x06018406 RID: 99334 RVA: 0x003874FC File Offset: 0x003856FC
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

		// Token: 0x170051B5 RID: 20917
		// (get) Token: 0x06018407 RID: 99335 RVA: 0x00387505 File Offset: 0x00385705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSceneGroupData> PlayerSceneGroupData
		{
			get
			{
				return this.playerSceneGroupData_;
			}
		}

		// Token: 0x170051B6 RID: 20918
		// (get) Token: 0x06018408 RID: 99336 RVA: 0x0038750D File Offset: 0x0038570D
		// (set) Token: 0x06018409 RID: 99337 RVA: 0x00387515 File Offset: 0x00385715
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

		// Token: 0x170051B7 RID: 20919
		// (get) Token: 0x0601840A RID: 99338 RVA: 0x0038751E File Offset: 0x0038571E
		// (set) Token: 0x0601840B RID: 99339 RVA: 0x00387526 File Offset: 0x00385726
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

		// Token: 0x170051B8 RID: 20920
		// (get) Token: 0x0601840C RID: 99340 RVA: 0x0038752F File Offset: 0x0038572F
		// (set) Token: 0x0601840D RID: 99341 RVA: 0x00387537 File Offset: 0x00385737
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

		// Token: 0x170051B9 RID: 20921
		// (get) Token: 0x0601840E RID: 99342 RVA: 0x00387540 File Offset: 0x00385740
		// (set) Token: 0x0601840F RID: 99343 RVA: 0x00387548 File Offset: 0x00385748
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

		// Token: 0x170051BA RID: 20922
		// (get) Token: 0x06018410 RID: 99344 RVA: 0x00387551 File Offset: 0x00385751
		// (set) Token: 0x06018411 RID: 99345 RVA: 0x00387559 File Offset: 0x00385759
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

		// Token: 0x170051BB RID: 20923
		// (get) Token: 0x06018412 RID: 99346 RVA: 0x00387562 File Offset: 0x00385762
		// (set) Token: 0x06018413 RID: 99347 RVA: 0x0038756A File Offset: 0x0038576A
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

		// Token: 0x06018414 RID: 99348 RVA: 0x00387573 File Offset: 0x00385773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScenePlayerInformation);
		}

		// Token: 0x06018415 RID: 99349 RVA: 0x00387584 File Offset: 0x00385784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScenePlayerInformation other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.PlayerName != other.PlayerName) && this.PlayerIcon == other.PlayerIcon && this.Level == other.Level && !(this.GuildName != other.GuildName) && !(this.GuildIntro != other.GuildIntro) && object.Equals(this.Location, other.Location) && this.IsOffline == other.IsOffline && this.PlayerPrefix == other.PlayerPrefix && this.PlayerGEIncHandle == other.PlayerGEIncHandle && this.playerSceneGroupData_.Equals(other.playerSceneGroupData_) && object.Equals(this.Rotation, other.Rotation) && this.Group == other.Group && this.CurRole == other.CurRole && object.Equals(this.VehicleInfoPb, other.VehicleInfoPb) && object.Equals(this.GravityDirection, other.GravityDirection) && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018416 RID: 99350 RVA: 0x003876E8 File Offset: 0x003858E8
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

		// Token: 0x06018417 RID: 99351 RVA: 0x003878A6 File Offset: 0x00385AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018418 RID: 99352 RVA: 0x003878B3 File Offset: 0x00385AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018419 RID: 99353 RVA: 0x003878BC File Offset: 0x00385ABC
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

		// Token: 0x0601841A RID: 99354 RVA: 0x00387AC8 File Offset: 0x00385CC8
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

		// Token: 0x0601841B RID: 99355 RVA: 0x00387C84 File Offset: 0x00385E84
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

		// Token: 0x0601841C RID: 99356 RVA: 0x00387E6C File Offset: 0x0038606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601841D RID: 99357 RVA: 0x00387E78 File Offset: 0x00386078
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

		// Token: 0x04009013 RID: 36883
		private static readonly MessageParser<ScenePlayerInformation> _parser = new MessageParser<ScenePlayerInformation>(() => new ScenePlayerInformation());

		// Token: 0x04009014 RID: 36884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009015 RID: 36885
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04009016 RID: 36886
		private int playerId_;

		// Token: 0x04009017 RID: 36887
		public const int PlayerNameFieldNumber = 2;

		// Token: 0x04009018 RID: 36888
		private string playerName_ = "";

		// Token: 0x04009019 RID: 36889
		public const int PlayerIconFieldNumber = 3;

		// Token: 0x0400901A RID: 36890
		private int playerIcon_;

		// Token: 0x0400901B RID: 36891
		public const int LevelFieldNumber = 4;

		// Token: 0x0400901C RID: 36892
		private int level_;

		// Token: 0x0400901D RID: 36893
		public const int GuildNameFieldNumber = 5;

		// Token: 0x0400901E RID: 36894
		private string guildName_ = "";

		// Token: 0x0400901F RID: 36895
		public const int GuildIntroFieldNumber = 6;

		// Token: 0x04009020 RID: 36896
		private string guildIntro_ = "";

		// Token: 0x04009021 RID: 36897
		public const int LocationFieldNumber = 7;

		// Token: 0x04009022 RID: 36898
		private Vector location_;

		// Token: 0x04009023 RID: 36899
		public const int IsOfflineFieldNumber = 8;

		// Token: 0x04009024 RID: 36900
		private bool isOffline_;

		// Token: 0x04009025 RID: 36901
		public const int PlayerPrefixFieldNumber = 9;

		// Token: 0x04009026 RID: 36902
		private int playerPrefix_;

		// Token: 0x04009027 RID: 36903
		public const int PlayerGEIncHandleFieldNumber = 10;

		// Token: 0x04009028 RID: 36904
		private int playerGEIncHandle_;

		// Token: 0x04009029 RID: 36905
		public const int PlayerSceneGroupDataFieldNumber = 11;

		// Token: 0x0400902A RID: 36906
		private static readonly FieldCodec<PlayerSceneGroupData> _repeated_playerSceneGroupData_codec = FieldCodec.ForMessage<PlayerSceneGroupData>(90U, Aki.Protocol.PlayerSceneGroupData.Parser);

		// Token: 0x0400902B RID: 36907
		private readonly RepeatedField<PlayerSceneGroupData> playerSceneGroupData_ = new RepeatedField<PlayerSceneGroupData>();

		// Token: 0x0400902C RID: 36908
		public const int RotationFieldNumber = 13;

		// Token: 0x0400902D RID: 36909
		private Rotator rotation_;

		// Token: 0x0400902E RID: 36910
		public const int GroupFieldNumber = 14;

		// Token: 0x0400902F RID: 36911
		private int group_;

		// Token: 0x04009030 RID: 36912
		public const int CurRoleFieldNumber = 15;

		// Token: 0x04009031 RID: 36913
		private int curRole_;

		// Token: 0x04009032 RID: 36914
		public const int VehicleInfoPbFieldNumber = 16;

		// Token: 0x04009033 RID: 36915
		private VehicleInfoPb vehicleInfoPb_;

		// Token: 0x04009034 RID: 36916
		public const int GravityDirectionFieldNumber = 17;

		// Token: 0x04009035 RID: 36917
		private Vector gravityDirection_;

		// Token: 0x04009036 RID: 36918
		public const int AreaIdFieldNumber = 18;

		// Token: 0x04009037 RID: 36919
		private int areaId_;
	}
}
