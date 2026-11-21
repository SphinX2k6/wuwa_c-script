using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001595 RID: 5525
	public sealed class WorldTeamPlayerInfo : IMessage<WorldTeamPlayerInfo>, IMessage, IEquatable<WorldTeamPlayerInfo>, IDeepCloneable<WorldTeamPlayerInfo>, IBufferMessage
	{
		// Token: 0x0601D3DE RID: 119774 RVA: 0x0043B860 File Offset: 0x00439A60
		[NullableContext(1)]
		public static WorldTeamPlayerInfo Create()
		{
			return new WorldTeamPlayerInfo();
		}

		// Token: 0x170062E9 RID: 25321
		// (get) Token: 0x0601D3DF RID: 119775 RVA: 0x0043B867 File Offset: 0x00439A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorldTeamPlayerInfo> Parser
		{
			get
			{
				return WorldTeamPlayerInfo._parser;
			}
		}

		// Token: 0x170062EA RID: 25322
		// (get) Token: 0x0601D3E0 RID: 119776 RVA: 0x0043B86E File Offset: 0x00439A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062EB RID: 25323
		// (get) Token: 0x0601D3E1 RID: 119777 RVA: 0x0043B871 File Offset: 0x00439A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldTeamPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0601D3E2 RID: 119778 RVA: 0x0043B878 File Offset: 0x00439A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfo()
		{
		}

		// Token: 0x0601D3E3 RID: 119779 RVA: 0x0043B898 File Offset: 0x00439A98
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

		// Token: 0x0601D3E4 RID: 119780 RVA: 0x0043B96C File Offset: 0x00439B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerInfo Clone()
		{
			return new WorldTeamPlayerInfo(this);
		}

		// Token: 0x170062EC RID: 25324
		// (get) Token: 0x0601D3E5 RID: 119781 RVA: 0x0043B974 File Offset: 0x00439B74
		// (set) Token: 0x0601D3E6 RID: 119782 RVA: 0x0043B97C File Offset: 0x00439B7C
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

		// Token: 0x170062ED RID: 25325
		// (get) Token: 0x0601D3E7 RID: 119783 RVA: 0x0043B985 File Offset: 0x00439B85
		// (set) Token: 0x0601D3E8 RID: 119784 RVA: 0x0043B98D File Offset: 0x00439B8D
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

		// Token: 0x170062EE RID: 25326
		// (get) Token: 0x0601D3E9 RID: 119785 RVA: 0x0043B9A0 File Offset: 0x00439BA0
		// (set) Token: 0x0601D3EA RID: 119786 RVA: 0x0043B9A8 File Offset: 0x00439BA8
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

		// Token: 0x170062EF RID: 25327
		// (get) Token: 0x0601D3EB RID: 119787 RVA: 0x0043B9B1 File Offset: 0x00439BB1
		// (set) Token: 0x0601D3EC RID: 119788 RVA: 0x0043B9B9 File Offset: 0x00439BB9
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

		// Token: 0x170062F0 RID: 25328
		// (get) Token: 0x0601D3ED RID: 119789 RVA: 0x0043B9C2 File Offset: 0x00439BC2
		// (set) Token: 0x0601D3EE RID: 119790 RVA: 0x0043B9CA File Offset: 0x00439BCA
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

		// Token: 0x170062F1 RID: 25329
		// (get) Token: 0x0601D3EF RID: 119791 RVA: 0x0043B9DD File Offset: 0x00439BDD
		// (set) Token: 0x0601D3F0 RID: 119792 RVA: 0x0043B9E5 File Offset: 0x00439BE5
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

		// Token: 0x170062F2 RID: 25330
		// (get) Token: 0x0601D3F1 RID: 119793 RVA: 0x0043B9EE File Offset: 0x00439BEE
		// (set) Token: 0x0601D3F2 RID: 119794 RVA: 0x0043B9F6 File Offset: 0x00439BF6
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

		// Token: 0x170062F3 RID: 25331
		// (get) Token: 0x0601D3F3 RID: 119795 RVA: 0x0043B9FF File Offset: 0x00439BFF
		// (set) Token: 0x0601D3F4 RID: 119796 RVA: 0x0043BA07 File Offset: 0x00439C07
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

		// Token: 0x170062F4 RID: 25332
		// (get) Token: 0x0601D3F5 RID: 119797 RVA: 0x0043BA10 File Offset: 0x00439C10
		// (set) Token: 0x0601D3F6 RID: 119798 RVA: 0x0043BA18 File Offset: 0x00439C18
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

		// Token: 0x170062F5 RID: 25333
		// (get) Token: 0x0601D3F7 RID: 119799 RVA: 0x0043BA21 File Offset: 0x00439C21
		// (set) Token: 0x0601D3F8 RID: 119800 RVA: 0x0043BA29 File Offset: 0x00439C29
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

		// Token: 0x170062F6 RID: 25334
		// (get) Token: 0x0601D3F9 RID: 119801 RVA: 0x0043BA32 File Offset: 0x00439C32
		// (set) Token: 0x0601D3FA RID: 119802 RVA: 0x0043BA3A File Offset: 0x00439C3A
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

		// Token: 0x170062F7 RID: 25335
		// (get) Token: 0x0601D3FB RID: 119803 RVA: 0x0043BA43 File Offset: 0x00439C43
		// (set) Token: 0x0601D3FC RID: 119804 RVA: 0x0043BA4B File Offset: 0x00439C4B
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

		// Token: 0x0601D3FD RID: 119805 RVA: 0x0043BA54 File Offset: 0x00439C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldTeamPlayerInfo);
		}

		// Token: 0x0601D3FE RID: 119806 RVA: 0x0043BA64 File Offset: 0x00439C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTeamPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.PlayerName != other.PlayerName) && this.HeadId == other.HeadId && this.Level == other.Level && !(this.Signature != other.Signature) && object.Equals(this.FightInfo, other.FightInfo) && this.PingState == other.PingState && object.Equals(this.Item, other.Item) && this.PlayerTitleId == other.PlayerTitleId && this.PlayerTitleExtraParam == other.PlayerTitleExtraParam && this.Sex == other.Sex && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D3FF RID: 119807 RVA: 0x0043BB64 File Offset: 0x00439D64
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

		// Token: 0x0601D400 RID: 119808 RVA: 0x0043BCBA File Offset: 0x00439EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D401 RID: 119809 RVA: 0x0043BCC7 File Offset: 0x00439EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D402 RID: 119810 RVA: 0x0043BCD0 File Offset: 0x00439ED0
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

		// Token: 0x0601D403 RID: 119811 RVA: 0x0043BE4C File Offset: 0x0043A04C
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

		// Token: 0x0601D404 RID: 119812 RVA: 0x0043BF9C File Offset: 0x0043A19C
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

		// Token: 0x0601D405 RID: 119813 RVA: 0x0043C0EE File Offset: 0x0043A2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D406 RID: 119814 RVA: 0x0043C0F8 File Offset: 0x0043A2F8
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

		// Token: 0x0400A7B0 RID: 42928
		private static readonly MessageParser<WorldTeamPlayerInfo> _parser = new MessageParser<WorldTeamPlayerInfo>(() => new WorldTeamPlayerInfo());

		// Token: 0x0400A7B1 RID: 42929
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7B2 RID: 42930
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400A7B3 RID: 42931
		private int playerId_;

		// Token: 0x0400A7B4 RID: 42932
		public const int PlayerNameFieldNumber = 2;

		// Token: 0x0400A7B5 RID: 42933
		private string playerName_ = "";

		// Token: 0x0400A7B6 RID: 42934
		public const int HeadIdFieldNumber = 3;

		// Token: 0x0400A7B7 RID: 42935
		private int headId_;

		// Token: 0x0400A7B8 RID: 42936
		public const int LevelFieldNumber = 4;

		// Token: 0x0400A7B9 RID: 42937
		private int level_;

		// Token: 0x0400A7BA RID: 42938
		public const int SignatureFieldNumber = 5;

		// Token: 0x0400A7BB RID: 42939
		private string signature_ = "";

		// Token: 0x0400A7BC RID: 42940
		public const int FightInfoFieldNumber = 6;

		// Token: 0x0400A7BD RID: 42941
		private WorldTeamPlayerFightInfo fightInfo_;

		// Token: 0x0400A7BE RID: 42942
		public const int PingStateFieldNumber = 7;

		// Token: 0x0400A7BF RID: 42943
		private ENetPingState pingState_;

		// Token: 0x0400A7C0 RID: 42944
		public const int ItemFieldNumber = 8;

		// Token: 0x0400A7C1 RID: 42945
		private PlayerDetails item_;

		// Token: 0x0400A7C2 RID: 42946
		public const int PlayerTitleIdFieldNumber = 9;

		// Token: 0x0400A7C3 RID: 42947
		private int playerTitleId_;

		// Token: 0x0400A7C4 RID: 42948
		public const int PlayerTitleExtraParamFieldNumber = 10;

		// Token: 0x0400A7C5 RID: 42949
		private int playerTitleExtraParam_;

		// Token: 0x0400A7C6 RID: 42950
		public const int SexFieldNumber = 11;

		// Token: 0x0400A7C7 RID: 42951
		private int sex_;

		// Token: 0x0400A7C8 RID: 42952
		public const int WorldLevelFieldNumber = 12;

		// Token: 0x0400A7C9 RID: 42953
		private int worldLevel_;
	}
}
