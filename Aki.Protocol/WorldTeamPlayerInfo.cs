using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151F RID: 5407
	public sealed class WorldTeamPlayerInfo : IMessage<WorldTeamPlayerInfo>, IMessage, IEquatable<WorldTeamPlayerInfo>, IDeepCloneable<WorldTeamPlayerInfo>, IBufferMessage
	{
		// Token: 0x0601C917 RID: 117015 RVA: 0x0041FDA4 File Offset: 0x0041DFA4
		[NullableContext(1)]
		public static WorldTeamPlayerInfo Create()
		{
			return new WorldTeamPlayerInfo();
		}

		// Token: 0x17006048 RID: 24648
		// (get) Token: 0x0601C918 RID: 117016 RVA: 0x0041FDAB File Offset: 0x0041DFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorldTeamPlayerInfo> Parser
		{
			get
			{
				return WorldTeamPlayerInfo._parser;
			}
		}

		// Token: 0x17006049 RID: 24649
		// (get) Token: 0x0601C919 RID: 117017 RVA: 0x0041FDB2 File Offset: 0x0041DFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700604A RID: 24650
		// (get) Token: 0x0601C91A RID: 117018 RVA: 0x0041FDB5 File Offset: 0x0041DFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldTeamPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0601C91B RID: 117019 RVA: 0x0041FDBC File Offset: 0x0041DFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfo()
		{
		}

		// Token: 0x0601C91C RID: 117020 RVA: 0x0041FDDC File Offset: 0x0041DFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfo(WorldTeamPlayerInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.playerName_ = other.playerName_;
			this.headId_ = other.headId_;
			this.level_ = other.level_;
			this.signature_ = other.signature_;
			this.fightInfo_ = ((other.fightInfo_ != null) ? other.fightInfo_.Clone() : null);
			this.pingState_ = other.pingState_;
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this.playerTitleId_ = other.playerTitleId_;
			this.playerTitleExtraParam_ = other.playerTitleExtraParam_;
			this.sex_ = other.sex_;
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C91D RID: 117021 RVA: 0x0041FEB0 File Offset: 0x0041E0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfo Clone()
		{
			return new WorldTeamPlayerInfo(this);
		}

		// Token: 0x1700604B RID: 24651
		// (get) Token: 0x0601C91E RID: 117022 RVA: 0x0041FEB8 File Offset: 0x0041E0B8
		// (set) Token: 0x0601C91F RID: 117023 RVA: 0x0041FEC0 File Offset: 0x0041E0C0
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

		// Token: 0x1700604C RID: 24652
		// (get) Token: 0x0601C920 RID: 117024 RVA: 0x0041FEC9 File Offset: 0x0041E0C9
		// (set) Token: 0x0601C921 RID: 117025 RVA: 0x0041FED1 File Offset: 0x0041E0D1
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

		// Token: 0x1700604D RID: 24653
		// (get) Token: 0x0601C922 RID: 117026 RVA: 0x0041FEE4 File Offset: 0x0041E0E4
		// (set) Token: 0x0601C923 RID: 117027 RVA: 0x0041FEEC File Offset: 0x0041E0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadId
		{
			get
			{
				return this.headId_;
			}
			set
			{
				this.headId_ = value;
			}
		}

		// Token: 0x1700604E RID: 24654
		// (get) Token: 0x0601C924 RID: 117028 RVA: 0x0041FEF5 File Offset: 0x0041E0F5
		// (set) Token: 0x0601C925 RID: 117029 RVA: 0x0041FEFD File Offset: 0x0041E0FD
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

		// Token: 0x1700604F RID: 24655
		// (get) Token: 0x0601C926 RID: 117030 RVA: 0x0041FF06 File Offset: 0x0041E106
		// (set) Token: 0x0601C927 RID: 117031 RVA: 0x0041FF0E File Offset: 0x0041E10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17006050 RID: 24656
		// (get) Token: 0x0601C928 RID: 117032 RVA: 0x0041FF21 File Offset: 0x0041E121
		// (set) Token: 0x0601C929 RID: 117033 RVA: 0x0041FF29 File Offset: 0x0041E129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo FightInfo
		{
			get
			{
				return this.fightInfo_;
			}
			set
			{
				this.fightInfo_ = value;
			}
		}

		// Token: 0x17006051 RID: 24657
		// (get) Token: 0x0601C92A RID: 117034 RVA: 0x0041FF32 File Offset: 0x0041E132
		// (set) Token: 0x0601C92B RID: 117035 RVA: 0x0041FF3A File Offset: 0x0041E13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENetPingState PingState
		{
			get
			{
				return this.pingState_;
			}
			set
			{
				this.pingState_ = value;
			}
		}

		// Token: 0x17006052 RID: 24658
		// (get) Token: 0x0601C92C RID: 117036 RVA: 0x0041FF43 File Offset: 0x0041E143
		// (set) Token: 0x0601C92D RID: 117037 RVA: 0x0041FF4B File Offset: 0x0041E14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Item
		{
			get
			{
				return this.item_;
			}
			set
			{
				this.item_ = value;
			}
		}

		// Token: 0x17006053 RID: 24659
		// (get) Token: 0x0601C92E RID: 117038 RVA: 0x0041FF54 File Offset: 0x0041E154
		// (set) Token: 0x0601C92F RID: 117039 RVA: 0x0041FF5C File Offset: 0x0041E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleId
		{
			get
			{
				return this.playerTitleId_;
			}
			set
			{
				this.playerTitleId_ = value;
			}
		}

		// Token: 0x17006054 RID: 24660
		// (get) Token: 0x0601C930 RID: 117040 RVA: 0x0041FF65 File Offset: 0x0041E165
		// (set) Token: 0x0601C931 RID: 117041 RVA: 0x0041FF6D File Offset: 0x0041E16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleExtraParam
		{
			get
			{
				return this.playerTitleExtraParam_;
			}
			set
			{
				this.playerTitleExtraParam_ = value;
			}
		}

		// Token: 0x17006055 RID: 24661
		// (get) Token: 0x0601C932 RID: 117042 RVA: 0x0041FF76 File Offset: 0x0041E176
		// (set) Token: 0x0601C933 RID: 117043 RVA: 0x0041FF7E File Offset: 0x0041E17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sex
		{
			get
			{
				return this.sex_;
			}
			set
			{
				this.sex_ = value;
			}
		}

		// Token: 0x17006056 RID: 24662
		// (get) Token: 0x0601C934 RID: 117044 RVA: 0x0041FF87 File Offset: 0x0041E187
		// (set) Token: 0x0601C935 RID: 117045 RVA: 0x0041FF8F File Offset: 0x0041E18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x0601C936 RID: 117046 RVA: 0x0041FF98 File Offset: 0x0041E198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldTeamPlayerInfo);
		}

		// Token: 0x0601C937 RID: 117047 RVA: 0x0041FFA8 File Offset: 0x0041E1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTeamPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.PlayerName != other.PlayerName) && this.HeadId == other.HeadId && this.Level == other.Level && !(this.Signature != other.Signature) && object.Equals(this.FightInfo, other.FightInfo) && this.PingState == other.PingState && object.Equals(this.Item, other.Item) && this.PlayerTitleId == other.PlayerTitleId && this.PlayerTitleExtraParam == other.PlayerTitleExtraParam && this.Sex == other.Sex && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C938 RID: 117048 RVA: 0x004200A8 File Offset: 0x0041E2A8
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
			if (this.HeadId != 0)
			{
				num ^= this.HeadId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this.fightInfo_ != null)
			{
				num ^= this.FightInfo.GetHashCode();
			}
			if (this.PingState != ENetPingState.Unknown)
			{
				num ^= this.PingState.GetHashCode();
			}
			if (this.item_ != null)
			{
				num ^= this.Item.GetHashCode();
			}
			if (this.PlayerTitleId != 0)
			{
				num ^= this.PlayerTitleId.GetHashCode();
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				num ^= this.PlayerTitleExtraParam.GetHashCode();
			}
			if (this.Sex != 0)
			{
				num ^= this.Sex.GetHashCode();
			}
			if (this.WorldLevel != 0)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C939 RID: 117049 RVA: 0x004201FE File Offset: 0x0041E3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C93A RID: 117050 RVA: 0x0042020B File Offset: 0x0041E40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C93B RID: 117051 RVA: 0x00420214 File Offset: 0x0041E414
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
			if (this.HeadId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HeadId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Signature);
			}
			if (this.fightInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FightInfo);
			}
			if (this.PingState != ENetPingState.Unknown)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.PingState);
			}
			if (this.item_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Item);
			}
			if (this.PlayerTitleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerTitleId);
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerTitleExtraParam);
			}
			if (this.Sex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Sex);
			}
			if (this.WorldLevel != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C93C RID: 117052 RVA: 0x00420390 File Offset: 0x0041E590
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
			if (this.HeadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this.fightInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FightInfo);
			}
			if (this.PingState != ENetPingState.Unknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PingState);
			}
			if (this.item_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			if (this.PlayerTitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleId);
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleExtraParam);
			}
			if (this.Sex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sex);
			}
			if (this.WorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C93D RID: 117053 RVA: 0x004204E0 File Offset: 0x0041E6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldTeamPlayerInfo other)
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
			if (other.HeadId != 0)
			{
				this.HeadId = other.HeadId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			if (other.fightInfo_ != null)
			{
				if (this.fightInfo_ == null)
				{
					this.FightInfo = new WorldTeamPlayerFightInfo();
				}
				this.FightInfo.MergeFrom(other.FightInfo);
			}
			if (other.PingState != ENetPingState.Unknown)
			{
				this.PingState = other.PingState;
			}
			if (other.item_ != null)
			{
				if (this.item_ == null)
				{
					this.Item = new PlayerDetails();
				}
				this.Item.MergeFrom(other.Item);
			}
			if (other.PlayerTitleId != 0)
			{
				this.PlayerTitleId = other.PlayerTitleId;
			}
			if (other.PlayerTitleExtraParam != 0)
			{
				this.PlayerTitleExtraParam = other.PlayerTitleExtraParam;
			}
			if (other.Sex != 0)
			{
				this.Sex = other.Sex;
			}
			if (other.WorldLevel != 0)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C93E RID: 117054 RVA: 0x00420632 File Offset: 0x0041E832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C93F RID: 117055 RVA: 0x0042063C File Offset: 0x0041E83C
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
				if (num <= 50U)
				{
					if (num <= 24U)
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
						if (num == 24U)
						{
							this.HeadId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							this.Signature = input.ReadString();
							continue;
						}
						if (num == 50U)
						{
							if (this.fightInfo_ == null)
							{
								this.FightInfo = new WorldTeamPlayerFightInfo();
							}
							input.ReadMessage(this.FightInfo);
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.PingState = (ENetPingState)input.ReadEnum();
						continue;
					}
					if (num == 66U)
					{
						if (this.item_ == null)
						{
							this.Item = new PlayerDetails();
						}
						input.ReadMessage(this.Item);
						continue;
					}
					if (num == 72U)
					{
						this.PlayerTitleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.PlayerTitleExtraParam = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Sex = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.WorldLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A357 RID: 41815
		private static readonly MessageParser<WorldTeamPlayerInfo> _parser = new MessageParser<WorldTeamPlayerInfo>(() => new WorldTeamPlayerInfo());

		// Token: 0x0400A358 RID: 41816
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A359 RID: 41817
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400A35A RID: 41818
		private int playerId_;

		// Token: 0x0400A35B RID: 41819
		public const int PlayerNameFieldNumber = 2;

		// Token: 0x0400A35C RID: 41820
		private string playerName_ = "";

		// Token: 0x0400A35D RID: 41821
		public const int HeadIdFieldNumber = 3;

		// Token: 0x0400A35E RID: 41822
		private int headId_;

		// Token: 0x0400A35F RID: 41823
		public const int LevelFieldNumber = 4;

		// Token: 0x0400A360 RID: 41824
		private int level_;

		// Token: 0x0400A361 RID: 41825
		public const int SignatureFieldNumber = 5;

		// Token: 0x0400A362 RID: 41826
		private string signature_ = "";

		// Token: 0x0400A363 RID: 41827
		public const int FightInfoFieldNumber = 6;

		// Token: 0x0400A364 RID: 41828
		private WorldTeamPlayerFightInfo fightInfo_;

		// Token: 0x0400A365 RID: 41829
		public const int PingStateFieldNumber = 7;

		// Token: 0x0400A366 RID: 41830
		private ENetPingState pingState_;

		// Token: 0x0400A367 RID: 41831
		public const int ItemFieldNumber = 8;

		// Token: 0x0400A368 RID: 41832
		private PlayerDetails item_;

		// Token: 0x0400A369 RID: 41833
		public const int PlayerTitleIdFieldNumber = 9;

		// Token: 0x0400A36A RID: 41834
		private int playerTitleId_;

		// Token: 0x0400A36B RID: 41835
		public const int PlayerTitleExtraParamFieldNumber = 10;

		// Token: 0x0400A36C RID: 41836
		private int playerTitleExtraParam_;

		// Token: 0x0400A36D RID: 41837
		public const int SexFieldNumber = 11;

		// Token: 0x0400A36E RID: 41838
		private int sex_;

		// Token: 0x0400A36F RID: 41839
		public const int WorldLevelFieldNumber = 12;

		// Token: 0x0400A370 RID: 41840
		private int worldLevel_;
	}
}
