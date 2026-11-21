using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D79 RID: 3449
	public sealed class PlayerDetails : IMessage<PlayerDetails>, IMessage, IEquatable<PlayerDetails>, IDeepCloneable<PlayerDetails>, IBufferMessage
	{
		// Token: 0x060129CE RID: 76238 RVA: 0x002B7647 File Offset: 0x002B5847
		[NullableContext(1)]
		public static PlayerDetails Create()
		{
			return new PlayerDetails();
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x060129CF RID: 76239 RVA: 0x002B764E File Offset: 0x002B584E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerDetails> Parser
		{
			get
			{
				return PlayerDetails._parser;
			}
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x060129D0 RID: 76240 RVA: 0x002B7655 File Offset: 0x002B5855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x060129D1 RID: 76241 RVA: 0x002B7658 File Offset: 0x002B5858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerDetails.Descriptor;
			}
		}

		// Token: 0x060129D2 RID: 76242 RVA: 0x002B7660 File Offset: 0x002B5860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails()
		{
		}

		// Token: 0x060129D3 RID: 76243 RVA: 0x002B76E4 File Offset: 0x002B58E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails(PlayerDetails other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.level_ = other.level_;
			this.originWorldLevel_ = other.originWorldLevel_;
			this.curWorldLevel_ = other.curWorldLevel_;
			this.headId_ = other.headId_;
			this.headFrameId_ = other.headFrameId_;
			this.signature_ = other.signature_;
			this.isOnline_ = other.isOnline_;
			this.isCanLobbyOnline_ = other.isCanLobbyOnline_;
			this.lastOfflineTime_ = other.lastOfflineTime_;
			this.teamMemberCount_ = other.teamMemberCount_;
			this.levelGap_ = other.levelGap_;
			this.birthday_ = other.birthday_;
			this.roleShowList_ = other.roleShowList_.Clone();
			this.cardShowList_ = other.cardShowList_.Clone();
			this.curCard_ = other.curCard_;
			this.displayBirthday_ = other.displayBirthday_;
			this.lastEnterMultiWillTime_ = other.lastEnterMultiWillTime_;
			this.psnUserId_ = other.psnUserId_;
			this.psnOnlineId_ = other.psnOnlineId_;
			this.psnAccountId_ = other.psnAccountId_;
			this.matchPsnUser_ = other.matchPsnUser_;
			this.psnSocialState_ = other.psnSocialState_;
			this.playerTitleId_ = other.playerTitleId_;
			this.playerTitleExtraParam_ = other.playerTitleExtraParam_;
			this.sex_ = other.sex_;
			this.deactivation_ = other.deactivation_;
			this.xboxUserId_ = other.xboxUserId_;
			this.xboxOnlineId_ = other.xboxOnlineId_;
			this.xboxAccountId_ = other.xboxAccountId_;
			this.matchXboxUser_ = other.matchXboxUser_;
			this.xboxSocialState_ = other.xboxSocialState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060129D4 RID: 76244 RVA: 0x002B789E File Offset: 0x002B5A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Clone()
		{
			return new PlayerDetails(this);
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x060129D5 RID: 76245 RVA: 0x002B78A6 File Offset: 0x002B5AA6
		// (set) Token: 0x060129D6 RID: 76246 RVA: 0x002B78AE File Offset: 0x002B5AAE
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

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x060129D7 RID: 76247 RVA: 0x002B78B7 File Offset: 0x002B5AB7
		// (set) Token: 0x060129D8 RID: 76248 RVA: 0x002B78BF File Offset: 0x002B5ABF
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

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x060129D9 RID: 76249 RVA: 0x002B78D2 File Offset: 0x002B5AD2
		// (set) Token: 0x060129DA RID: 76250 RVA: 0x002B78DA File Offset: 0x002B5ADA
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

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x060129DB RID: 76251 RVA: 0x002B78E3 File Offset: 0x002B5AE3
		// (set) Token: 0x060129DC RID: 76252 RVA: 0x002B78EB File Offset: 0x002B5AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OriginWorldLevel
		{
			get
			{
				return this.originWorldLevel_;
			}
			set
			{
				this.originWorldLevel_ = value;
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x060129DD RID: 76253 RVA: 0x002B78F4 File Offset: 0x002B5AF4
		// (set) Token: 0x060129DE RID: 76254 RVA: 0x002B78FC File Offset: 0x002B5AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWorldLevel
		{
			get
			{
				return this.curWorldLevel_;
			}
			set
			{
				this.curWorldLevel_ = value;
			}
		}

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x060129DF RID: 76255 RVA: 0x002B7905 File Offset: 0x002B5B05
		// (set) Token: 0x060129E0 RID: 76256 RVA: 0x002B790D File Offset: 0x002B5B0D
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

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x060129E1 RID: 76257 RVA: 0x002B7916 File Offset: 0x002B5B16
		// (set) Token: 0x060129E2 RID: 76258 RVA: 0x002B791E File Offset: 0x002B5B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadFrameId
		{
			get
			{
				return this.headFrameId_;
			}
			set
			{
				this.headFrameId_ = value;
			}
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x060129E3 RID: 76259 RVA: 0x002B7927 File Offset: 0x002B5B27
		// (set) Token: 0x060129E4 RID: 76260 RVA: 0x002B792F File Offset: 0x002B5B2F
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

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x060129E5 RID: 76261 RVA: 0x002B7942 File Offset: 0x002B5B42
		// (set) Token: 0x060129E6 RID: 76262 RVA: 0x002B794A File Offset: 0x002B5B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOnline
		{
			get
			{
				return this.isOnline_;
			}
			set
			{
				this.isOnline_ = value;
			}
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x060129E7 RID: 76263 RVA: 0x002B7953 File Offset: 0x002B5B53
		// (set) Token: 0x060129E8 RID: 76264 RVA: 0x002B795B File Offset: 0x002B5B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCanLobbyOnline
		{
			get
			{
				return this.isCanLobbyOnline_;
			}
			set
			{
				this.isCanLobbyOnline_ = value;
			}
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x060129E9 RID: 76265 RVA: 0x002B7964 File Offset: 0x002B5B64
		// (set) Token: 0x060129EA RID: 76266 RVA: 0x002B796C File Offset: 0x002B5B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastOfflineTime
		{
			get
			{
				return this.lastOfflineTime_;
			}
			set
			{
				this.lastOfflineTime_ = value;
			}
		}

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x060129EB RID: 76267 RVA: 0x002B7975 File Offset: 0x002B5B75
		// (set) Token: 0x060129EC RID: 76268 RVA: 0x002B797D File Offset: 0x002B5B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeamMemberCount
		{
			get
			{
				return this.teamMemberCount_;
			}
			set
			{
				this.teamMemberCount_ = value;
			}
		}

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x060129ED RID: 76269 RVA: 0x002B7986 File Offset: 0x002B5B86
		// (set) Token: 0x060129EE RID: 76270 RVA: 0x002B798E File Offset: 0x002B5B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelGap
		{
			get
			{
				return this.levelGap_;
			}
			set
			{
				this.levelGap_ = value;
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x060129EF RID: 76271 RVA: 0x002B7997 File Offset: 0x002B5B97
		// (set) Token: 0x060129F0 RID: 76272 RVA: 0x002B799F File Offset: 0x002B5B9F
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

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x060129F1 RID: 76273 RVA: 0x002B79A8 File Offset: 0x002B5BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleShowEntry> RoleShowList
		{
			get
			{
				return this.roleShowList_;
			}
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x060129F2 RID: 76274 RVA: 0x002B79B0 File Offset: 0x002B5BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardShowList
		{
			get
			{
				return this.cardShowList_;
			}
		}

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x060129F3 RID: 76275 RVA: 0x002B79B8 File Offset: 0x002B5BB8
		// (set) Token: 0x060129F4 RID: 76276 RVA: 0x002B79C0 File Offset: 0x002B5BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCard
		{
			get
			{
				return this.curCard_;
			}
			set
			{
				this.curCard_ = value;
			}
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x060129F5 RID: 76277 RVA: 0x002B79C9 File Offset: 0x002B5BC9
		// (set) Token: 0x060129F6 RID: 76278 RVA: 0x002B79D1 File Offset: 0x002B5BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DisplayBirthday
		{
			get
			{
				return this.displayBirthday_;
			}
			set
			{
				this.displayBirthday_ = value;
			}
		}

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x060129F7 RID: 76279 RVA: 0x002B79DA File Offset: 0x002B5BDA
		// (set) Token: 0x060129F8 RID: 76280 RVA: 0x002B79E2 File Offset: 0x002B5BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastEnterMultiWillTime
		{
			get
			{
				return this.lastEnterMultiWillTime_;
			}
			set
			{
				this.lastEnterMultiWillTime_ = value;
			}
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x060129F9 RID: 76281 RVA: 0x002B79EB File Offset: 0x002B5BEB
		// (set) Token: 0x060129FA RID: 76282 RVA: 0x002B79F3 File Offset: 0x002B5BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnUserId
		{
			get
			{
				return this.psnUserId_;
			}
			set
			{
				this.psnUserId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x060129FB RID: 76283 RVA: 0x002B7A06 File Offset: 0x002B5C06
		// (set) Token: 0x060129FC RID: 76284 RVA: 0x002B7A0E File Offset: 0x002B5C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnOnlineId
		{
			get
			{
				return this.psnOnlineId_;
			}
			set
			{
				this.psnOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x060129FD RID: 76285 RVA: 0x002B7A21 File Offset: 0x002B5C21
		// (set) Token: 0x060129FE RID: 76286 RVA: 0x002B7A29 File Offset: 0x002B5C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnAccountId
		{
			get
			{
				return this.psnAccountId_;
			}
			set
			{
				this.psnAccountId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x060129FF RID: 76287 RVA: 0x002B7A3C File Offset: 0x002B5C3C
		// (set) Token: 0x06012A00 RID: 76288 RVA: 0x002B7A44 File Offset: 0x002B5C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MatchPsnUser
		{
			get
			{
				return this.matchPsnUser_;
			}
			set
			{
				this.matchPsnUser_ = value;
			}
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x06012A01 RID: 76289 RVA: 0x002B7A4D File Offset: 0x002B5C4D
		// (set) Token: 0x06012A02 RID: 76290 RVA: 0x002B7A55 File Offset: 0x002B5C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PsnSocialState
		{
			get
			{
				return this.psnSocialState_;
			}
			set
			{
				this.psnSocialState_ = value;
			}
		}

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x06012A03 RID: 76291 RVA: 0x002B7A5E File Offset: 0x002B5C5E
		// (set) Token: 0x06012A04 RID: 76292 RVA: 0x002B7A66 File Offset: 0x002B5C66
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

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x06012A05 RID: 76293 RVA: 0x002B7A6F File Offset: 0x002B5C6F
		// (set) Token: 0x06012A06 RID: 76294 RVA: 0x002B7A77 File Offset: 0x002B5C77
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

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x06012A07 RID: 76295 RVA: 0x002B7A80 File Offset: 0x002B5C80
		// (set) Token: 0x06012A08 RID: 76296 RVA: 0x002B7A88 File Offset: 0x002B5C88
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

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x06012A09 RID: 76297 RVA: 0x002B7A91 File Offset: 0x002B5C91
		// (set) Token: 0x06012A0A RID: 76298 RVA: 0x002B7A99 File Offset: 0x002B5C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deactivation
		{
			get
			{
				return this.deactivation_;
			}
			set
			{
				this.deactivation_ = value;
			}
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x06012A0B RID: 76299 RVA: 0x002B7AA2 File Offset: 0x002B5CA2
		// (set) Token: 0x06012A0C RID: 76300 RVA: 0x002B7AAA File Offset: 0x002B5CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxUserId
		{
			get
			{
				return this.xboxUserId_;
			}
			set
			{
				this.xboxUserId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x06012A0D RID: 76301 RVA: 0x002B7ABD File Offset: 0x002B5CBD
		// (set) Token: 0x06012A0E RID: 76302 RVA: 0x002B7AC5 File Offset: 0x002B5CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxOnlineId
		{
			get
			{
				return this.xboxOnlineId_;
			}
			set
			{
				this.xboxOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x06012A0F RID: 76303 RVA: 0x002B7AD8 File Offset: 0x002B5CD8
		// (set) Token: 0x06012A10 RID: 76304 RVA: 0x002B7AE0 File Offset: 0x002B5CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxAccountId
		{
			get
			{
				return this.xboxAccountId_;
			}
			set
			{
				this.xboxAccountId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x06012A11 RID: 76305 RVA: 0x002B7AF3 File Offset: 0x002B5CF3
		// (set) Token: 0x06012A12 RID: 76306 RVA: 0x002B7AFB File Offset: 0x002B5CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MatchXboxUser
		{
			get
			{
				return this.matchXboxUser_;
			}
			set
			{
				this.matchXboxUser_ = value;
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x06012A13 RID: 76307 RVA: 0x002B7B04 File Offset: 0x002B5D04
		// (set) Token: 0x06012A14 RID: 76308 RVA: 0x002B7B0C File Offset: 0x002B5D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int XboxSocialState
		{
			get
			{
				return this.xboxSocialState_;
			}
			set
			{
				this.xboxSocialState_ = value;
			}
		}

		// Token: 0x06012A15 RID: 76309 RVA: 0x002B7B15 File Offset: 0x002B5D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerDetails);
		}

		// Token: 0x06012A16 RID: 76310 RVA: 0x002B7B24 File Offset: 0x002B5D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerDetails other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.Level == other.Level && this.OriginWorldLevel == other.OriginWorldLevel && this.CurWorldLevel == other.CurWorldLevel && this.HeadId == other.HeadId && this.HeadFrameId == other.HeadFrameId && !(this.Signature != other.Signature) && this.IsOnline == other.IsOnline && this.IsCanLobbyOnline == other.IsCanLobbyOnline && this.LastOfflineTime == other.LastOfflineTime && this.TeamMemberCount == other.TeamMemberCount && this.LevelGap == other.LevelGap && this.Birthday == other.Birthday && this.roleShowList_.Equals(other.roleShowList_) && this.cardShowList_.Equals(other.cardShowList_) && this.CurCard == other.CurCard && this.DisplayBirthday == other.DisplayBirthday && this.LastEnterMultiWillTime == other.LastEnterMultiWillTime && !(this.PsnUserId != other.PsnUserId) && !(this.PsnOnlineId != other.PsnOnlineId) && !(this.PsnAccountId != other.PsnAccountId) && this.MatchPsnUser == other.MatchPsnUser && this.PsnSocialState == other.PsnSocialState && this.PlayerTitleId == other.PlayerTitleId && this.PlayerTitleExtraParam == other.PlayerTitleExtraParam && this.Sex == other.Sex && this.Deactivation == other.Deactivation && !(this.XboxUserId != other.XboxUserId) && !(this.XboxOnlineId != other.XboxOnlineId) && !(this.XboxAccountId != other.XboxAccountId) && this.MatchXboxUser == other.MatchXboxUser && this.XboxSocialState == other.XboxSocialState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A17 RID: 76311 RVA: 0x002B7D90 File Offset: 0x002B5F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.OriginWorldLevel != 0)
			{
				num ^= this.OriginWorldLevel.GetHashCode();
			}
			if (this.CurWorldLevel != 0)
			{
				num ^= this.CurWorldLevel.GetHashCode();
			}
			if (this.HeadId != 0)
			{
				num ^= this.HeadId.GetHashCode();
			}
			if (this.HeadFrameId != 0)
			{
				num ^= this.HeadFrameId.GetHashCode();
			}
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this.IsOnline)
			{
				num ^= this.IsOnline.GetHashCode();
			}
			if (this.IsCanLobbyOnline)
			{
				num ^= this.IsCanLobbyOnline.GetHashCode();
			}
			if (this.LastOfflineTime != 0L)
			{
				num ^= this.LastOfflineTime.GetHashCode();
			}
			if (this.TeamMemberCount != 0)
			{
				num ^= this.TeamMemberCount.GetHashCode();
			}
			if (this.LevelGap != 0)
			{
				num ^= this.LevelGap.GetHashCode();
			}
			if (this.Birthday != 0)
			{
				num ^= this.Birthday.GetHashCode();
			}
			num ^= this.roleShowList_.GetHashCode();
			num ^= this.cardShowList_.GetHashCode();
			if (this.CurCard != 0)
			{
				num ^= this.CurCard.GetHashCode();
			}
			if (this.DisplayBirthday)
			{
				num ^= this.DisplayBirthday.GetHashCode();
			}
			if (this.LastEnterMultiWillTime != 0L)
			{
				num ^= this.LastEnterMultiWillTime.GetHashCode();
			}
			if (this.PsnUserId.Length != 0)
			{
				num ^= this.PsnUserId.GetHashCode();
			}
			if (this.PsnOnlineId.Length != 0)
			{
				num ^= this.PsnOnlineId.GetHashCode();
			}
			if (this.PsnAccountId.Length != 0)
			{
				num ^= this.PsnAccountId.GetHashCode();
			}
			if (this.MatchPsnUser)
			{
				num ^= this.MatchPsnUser.GetHashCode();
			}
			if (this.PsnSocialState != 0)
			{
				num ^= this.PsnSocialState.GetHashCode();
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
			if (this.Deactivation)
			{
				num ^= this.Deactivation.GetHashCode();
			}
			if (this.XboxUserId.Length != 0)
			{
				num ^= this.XboxUserId.GetHashCode();
			}
			if (this.XboxOnlineId.Length != 0)
			{
				num ^= this.XboxOnlineId.GetHashCode();
			}
			if (this.XboxAccountId.Length != 0)
			{
				num ^= this.XboxAccountId.GetHashCode();
			}
			if (this.MatchXboxUser)
			{
				num ^= this.MatchXboxUser.GetHashCode();
			}
			if (this.XboxSocialState != 0)
			{
				num ^= this.XboxSocialState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012A18 RID: 76312 RVA: 0x002B80E9 File Offset: 0x002B62E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A19 RID: 76313 RVA: 0x002B80F6 File Offset: 0x002B62F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A1A RID: 76314 RVA: 0x002B8100 File Offset: 0x002B6300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
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
			if (this.OriginWorldLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OriginWorldLevel);
			}
			if (this.CurWorldLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurWorldLevel);
			}
			if (this.HeadId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.HeadId);
			}
			if (this.HeadFrameId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HeadFrameId);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Signature);
			}
			if (this.IsOnline)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsOnline);
			}
			if (this.IsCanLobbyOnline)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsCanLobbyOnline);
			}
			if (this.LastOfflineTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.LastOfflineTime);
			}
			if (this.TeamMemberCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TeamMemberCount);
			}
			if (this.LevelGap != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LevelGap);
			}
			if (this.Birthday != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Birthday);
			}
			this.roleShowList_.WriteTo(ref output, PlayerDetails._repeated_roleShowList_codec);
			this.cardShowList_.WriteTo(ref output, PlayerDetails._repeated_cardShowList_codec);
			if (this.CurCard != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.CurCard);
			}
			if (this.DisplayBirthday)
			{
				output.WriteRawTag(144, 1);
				output.WriteBool(this.DisplayBirthday);
			}
			if (this.LastEnterMultiWillTime != 0L)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt64(this.LastEnterMultiWillTime);
			}
			if (this.PsnUserId.Length != 0)
			{
				output.WriteRawTag(162, 1);
				output.WriteString(this.PsnUserId);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				output.WriteRawTag(170, 1);
				output.WriteString(this.PsnOnlineId);
			}
			if (this.PsnAccountId.Length != 0)
			{
				output.WriteRawTag(178, 1);
				output.WriteString(this.PsnAccountId);
			}
			if (this.MatchPsnUser)
			{
				output.WriteRawTag(184, 1);
				output.WriteBool(this.MatchPsnUser);
			}
			if (this.PsnSocialState != 0)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt32(this.PsnSocialState);
			}
			if (this.PlayerTitleId != 0)
			{
				output.WriteRawTag(200, 1);
				output.WriteInt32(this.PlayerTitleId);
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				output.WriteRawTag(208, 1);
				output.WriteInt32(this.PlayerTitleExtraParam);
			}
			if (this.Sex != 0)
			{
				output.WriteRawTag(216, 1);
				output.WriteInt32(this.Sex);
			}
			if (this.Deactivation)
			{
				output.WriteRawTag(224, 1);
				output.WriteBool(this.Deactivation);
			}
			if (this.XboxUserId.Length != 0)
			{
				output.WriteRawTag(234, 1);
				output.WriteString(this.XboxUserId);
			}
			if (this.XboxOnlineId.Length != 0)
			{
				output.WriteRawTag(242, 1);
				output.WriteString(this.XboxOnlineId);
			}
			if (this.XboxAccountId.Length != 0)
			{
				output.WriteRawTag(250, 1);
				output.WriteString(this.XboxAccountId);
			}
			if (this.MatchXboxUser)
			{
				output.WriteRawTag(128, 2);
				output.WriteBool(this.MatchXboxUser);
			}
			if (this.XboxSocialState != 0)
			{
				output.WriteRawTag(136, 2);
				output.WriteInt32(this.XboxSocialState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A1B RID: 76315 RVA: 0x002B8514 File Offset: 0x002B6714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.OriginWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginWorldLevel);
			}
			if (this.CurWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWorldLevel);
			}
			if (this.HeadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadId);
			}
			if (this.HeadFrameId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadFrameId);
			}
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this.IsOnline)
			{
				num += 2;
			}
			if (this.IsCanLobbyOnline)
			{
				num += 2;
			}
			if (this.LastOfflineTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastOfflineTime);
			}
			if (this.TeamMemberCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TeamMemberCount);
			}
			if (this.LevelGap != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGap);
			}
			if (this.Birthday != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Birthday);
			}
			num += this.roleShowList_.CalculateSize(PlayerDetails._repeated_roleShowList_codec);
			num += this.cardShowList_.CalculateSize(PlayerDetails._repeated_cardShowList_codec);
			if (this.CurCard != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CurCard);
			}
			if (this.DisplayBirthday)
			{
				num += 3;
			}
			if (this.LastEnterMultiWillTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LastEnterMultiWillTime);
			}
			if (this.PsnUserId.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PsnUserId);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PsnOnlineId);
			}
			if (this.PsnAccountId.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PsnAccountId);
			}
			if (this.MatchPsnUser)
			{
				num += 3;
			}
			if (this.PsnSocialState != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PsnSocialState);
			}
			if (this.PlayerTitleId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleId);
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleExtraParam);
			}
			if (this.Sex != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Sex);
			}
			if (this.Deactivation)
			{
				num += 3;
			}
			if (this.XboxUserId.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.XboxUserId);
			}
			if (this.XboxOnlineId.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.XboxOnlineId);
			}
			if (this.XboxAccountId.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.XboxAccountId);
			}
			if (this.MatchXboxUser)
			{
				num += 3;
			}
			if (this.XboxSocialState != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.XboxSocialState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012A1C RID: 76316 RVA: 0x002B8828 File Offset: 0x002B6A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerDetails other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.OriginWorldLevel != 0)
			{
				this.OriginWorldLevel = other.OriginWorldLevel;
			}
			if (other.CurWorldLevel != 0)
			{
				this.CurWorldLevel = other.CurWorldLevel;
			}
			if (other.HeadId != 0)
			{
				this.HeadId = other.HeadId;
			}
			if (other.HeadFrameId != 0)
			{
				this.HeadFrameId = other.HeadFrameId;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			if (other.IsOnline)
			{
				this.IsOnline = other.IsOnline;
			}
			if (other.IsCanLobbyOnline)
			{
				this.IsCanLobbyOnline = other.IsCanLobbyOnline;
			}
			if (other.LastOfflineTime != 0L)
			{
				this.LastOfflineTime = other.LastOfflineTime;
			}
			if (other.TeamMemberCount != 0)
			{
				this.TeamMemberCount = other.TeamMemberCount;
			}
			if (other.LevelGap != 0)
			{
				this.LevelGap = other.LevelGap;
			}
			if (other.Birthday != 0)
			{
				this.Birthday = other.Birthday;
			}
			this.roleShowList_.Add(other.roleShowList_);
			this.cardShowList_.Add(other.cardShowList_);
			if (other.CurCard != 0)
			{
				this.CurCard = other.CurCard;
			}
			if (other.DisplayBirthday)
			{
				this.DisplayBirthday = other.DisplayBirthday;
			}
			if (other.LastEnterMultiWillTime != 0L)
			{
				this.LastEnterMultiWillTime = other.LastEnterMultiWillTime;
			}
			if (other.PsnUserId.Length != 0)
			{
				this.PsnUserId = other.PsnUserId;
			}
			if (other.PsnOnlineId.Length != 0)
			{
				this.PsnOnlineId = other.PsnOnlineId;
			}
			if (other.PsnAccountId.Length != 0)
			{
				this.PsnAccountId = other.PsnAccountId;
			}
			if (other.MatchPsnUser)
			{
				this.MatchPsnUser = other.MatchPsnUser;
			}
			if (other.PsnSocialState != 0)
			{
				this.PsnSocialState = other.PsnSocialState;
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
			if (other.Deactivation)
			{
				this.Deactivation = other.Deactivation;
			}
			if (other.XboxUserId.Length != 0)
			{
				this.XboxUserId = other.XboxUserId;
			}
			if (other.XboxOnlineId.Length != 0)
			{
				this.XboxOnlineId = other.XboxOnlineId;
			}
			if (other.XboxAccountId.Length != 0)
			{
				this.XboxAccountId = other.XboxAccountId;
			}
			if (other.MatchXboxUser)
			{
				this.MatchXboxUser = other.MatchXboxUser;
			}
			if (other.XboxSocialState != 0)
			{
				this.XboxSocialState = other.XboxSocialState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012A1D RID: 76317 RVA: 0x002B8B06 File Offset: 0x002B6D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A1E RID: 76318 RVA: 0x002B8B10 File Offset: 0x002B6D10
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
				if (num <= 130U)
				{
					if (num <= 66U)
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
									this.OriginWorldLevel = input.ReadInt32();
									continue;
								}
							}
						}
						else if (num <= 48U)
						{
							if (num == 40U)
							{
								this.CurWorldLevel = input.ReadInt32();
								continue;
							}
							if (num == 48U)
							{
								this.HeadId = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 56U)
							{
								this.HeadFrameId = input.ReadInt32();
								continue;
							}
							if (num == 66U)
							{
								this.Signature = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 96U)
					{
						if (num <= 80U)
						{
							if (num == 72U)
							{
								this.IsOnline = input.ReadBool();
								continue;
							}
							if (num == 80U)
							{
								this.IsCanLobbyOnline = input.ReadBool();
								continue;
							}
						}
						else
						{
							if (num == 88U)
							{
								this.LastOfflineTime = input.ReadInt64();
								continue;
							}
							if (num == 96U)
							{
								this.TeamMemberCount = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 112U)
					{
						if (num == 104U)
						{
							this.LevelGap = input.ReadInt32();
							continue;
						}
						if (num == 112U)
						{
							this.Birthday = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 122U)
						{
							this.roleShowList_.AddEntriesFrom(ref input, PlayerDetails._repeated_roleShowList_codec);
							continue;
						}
						if (num == 128U || num == 130U)
						{
							this.cardShowList_.AddEntriesFrom(ref input, PlayerDetails._repeated_cardShowList_codec);
							continue;
						}
					}
				}
				else if (num <= 192U)
				{
					if (num <= 162U)
					{
						if (num <= 144U)
						{
							if (num == 136U)
							{
								this.CurCard = input.ReadInt32();
								continue;
							}
							if (num == 144U)
							{
								this.DisplayBirthday = input.ReadBool();
								continue;
							}
						}
						else
						{
							if (num == 152U)
							{
								this.LastEnterMultiWillTime = input.ReadInt64();
								continue;
							}
							if (num == 162U)
							{
								this.PsnUserId = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 178U)
					{
						if (num == 170U)
						{
							this.PsnOnlineId = input.ReadString();
							continue;
						}
						if (num == 178U)
						{
							this.PsnAccountId = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 184U)
						{
							this.MatchPsnUser = input.ReadBool();
							continue;
						}
						if (num == 192U)
						{
							this.PsnSocialState = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 224U)
				{
					if (num <= 208U)
					{
						if (num == 200U)
						{
							this.PlayerTitleId = input.ReadInt32();
							continue;
						}
						if (num == 208U)
						{
							this.PlayerTitleExtraParam = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 216U)
						{
							this.Sex = input.ReadInt32();
							continue;
						}
						if (num == 224U)
						{
							this.Deactivation = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 242U)
				{
					if (num == 234U)
					{
						this.XboxUserId = input.ReadString();
						continue;
					}
					if (num == 242U)
					{
						this.XboxOnlineId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 250U)
					{
						this.XboxAccountId = input.ReadString();
						continue;
					}
					if (num == 256U)
					{
						this.MatchXboxUser = input.ReadBool();
						continue;
					}
					if (num == 264U)
					{
						this.XboxSocialState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040073DD RID: 29661
		private static readonly MessageParser<PlayerDetails> _parser = new MessageParser<PlayerDetails>(() => new PlayerDetails());

		// Token: 0x040073DE RID: 29662
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073DF RID: 29663
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040073E0 RID: 29664
		private int playerId_;

		// Token: 0x040073E1 RID: 29665
		public const int NameFieldNumber = 2;

		// Token: 0x040073E2 RID: 29666
		private string name_ = "";

		// Token: 0x040073E3 RID: 29667
		public const int LevelFieldNumber = 3;

		// Token: 0x040073E4 RID: 29668
		private int level_;

		// Token: 0x040073E5 RID: 29669
		public const int OriginWorldLevelFieldNumber = 4;

		// Token: 0x040073E6 RID: 29670
		private int originWorldLevel_;

		// Token: 0x040073E7 RID: 29671
		public const int CurWorldLevelFieldNumber = 5;

		// Token: 0x040073E8 RID: 29672
		private int curWorldLevel_;

		// Token: 0x040073E9 RID: 29673
		public const int HeadIdFieldNumber = 6;

		// Token: 0x040073EA RID: 29674
		private int headId_;

		// Token: 0x040073EB RID: 29675
		public const int HeadFrameIdFieldNumber = 7;

		// Token: 0x040073EC RID: 29676
		private int headFrameId_;

		// Token: 0x040073ED RID: 29677
		public const int SignatureFieldNumber = 8;

		// Token: 0x040073EE RID: 29678
		private string signature_ = "";

		// Token: 0x040073EF RID: 29679
		public const int IsOnlineFieldNumber = 9;

		// Token: 0x040073F0 RID: 29680
		private bool isOnline_;

		// Token: 0x040073F1 RID: 29681
		public const int IsCanLobbyOnlineFieldNumber = 10;

		// Token: 0x040073F2 RID: 29682
		private bool isCanLobbyOnline_;

		// Token: 0x040073F3 RID: 29683
		public const int LastOfflineTimeFieldNumber = 11;

		// Token: 0x040073F4 RID: 29684
		private long lastOfflineTime_;

		// Token: 0x040073F5 RID: 29685
		public const int TeamMemberCountFieldNumber = 12;

		// Token: 0x040073F6 RID: 29686
		private int teamMemberCount_;

		// Token: 0x040073F7 RID: 29687
		public const int LevelGapFieldNumber = 13;

		// Token: 0x040073F8 RID: 29688
		private int levelGap_;

		// Token: 0x040073F9 RID: 29689
		public const int BirthdayFieldNumber = 14;

		// Token: 0x040073FA RID: 29690
		private int birthday_;

		// Token: 0x040073FB RID: 29691
		public const int RoleShowListFieldNumber = 15;

		// Token: 0x040073FC RID: 29692
		private static readonly FieldCodec<RoleShowEntry> _repeated_roleShowList_codec = FieldCodec.ForMessage<RoleShowEntry>(122U, RoleShowEntry.Parser);

		// Token: 0x040073FD RID: 29693
		private readonly RepeatedField<RoleShowEntry> roleShowList_ = new RepeatedField<RoleShowEntry>();

		// Token: 0x040073FE RID: 29694
		public const int CardShowListFieldNumber = 16;

		// Token: 0x040073FF RID: 29695
		private static readonly FieldCodec<int> _repeated_cardShowList_codec = FieldCodec.ForInt32(130U);

		// Token: 0x04007400 RID: 29696
		private readonly RepeatedField<int> cardShowList_ = new RepeatedField<int>();

		// Token: 0x04007401 RID: 29697
		public const int CurCardFieldNumber = 17;

		// Token: 0x04007402 RID: 29698
		private int curCard_;

		// Token: 0x04007403 RID: 29699
		public const int DisplayBirthdayFieldNumber = 18;

		// Token: 0x04007404 RID: 29700
		private bool displayBirthday_;

		// Token: 0x04007405 RID: 29701
		public const int LastEnterMultiWillTimeFieldNumber = 19;

		// Token: 0x04007406 RID: 29702
		private long lastEnterMultiWillTime_;

		// Token: 0x04007407 RID: 29703
		public const int PsnUserIdFieldNumber = 20;

		// Token: 0x04007408 RID: 29704
		private string psnUserId_ = "";

		// Token: 0x04007409 RID: 29705
		public const int PsnOnlineIdFieldNumber = 21;

		// Token: 0x0400740A RID: 29706
		private string psnOnlineId_ = "";

		// Token: 0x0400740B RID: 29707
		public const int PsnAccountIdFieldNumber = 22;

		// Token: 0x0400740C RID: 29708
		private string psnAccountId_ = "";

		// Token: 0x0400740D RID: 29709
		public const int MatchPsnUserFieldNumber = 23;

		// Token: 0x0400740E RID: 29710
		private bool matchPsnUser_;

		// Token: 0x0400740F RID: 29711
		public const int PsnSocialStateFieldNumber = 24;

		// Token: 0x04007410 RID: 29712
		private int psnSocialState_;

		// Token: 0x04007411 RID: 29713
		public const int PlayerTitleIdFieldNumber = 25;

		// Token: 0x04007412 RID: 29714
		private int playerTitleId_;

		// Token: 0x04007413 RID: 29715
		public const int PlayerTitleExtraParamFieldNumber = 26;

		// Token: 0x04007414 RID: 29716
		private int playerTitleExtraParam_;

		// Token: 0x04007415 RID: 29717
		public const int SexFieldNumber = 27;

		// Token: 0x04007416 RID: 29718
		private int sex_;

		// Token: 0x04007417 RID: 29719
		public const int DeactivationFieldNumber = 28;

		// Token: 0x04007418 RID: 29720
		private bool deactivation_;

		// Token: 0x04007419 RID: 29721
		public const int XboxUserIdFieldNumber = 29;

		// Token: 0x0400741A RID: 29722
		private string xboxUserId_ = "";

		// Token: 0x0400741B RID: 29723
		public const int XboxOnlineIdFieldNumber = 30;

		// Token: 0x0400741C RID: 29724
		private string xboxOnlineId_ = "";

		// Token: 0x0400741D RID: 29725
		public const int XboxAccountIdFieldNumber = 31;

		// Token: 0x0400741E RID: 29726
		private string xboxAccountId_ = "";

		// Token: 0x0400741F RID: 29727
		public const int MatchXboxUserFieldNumber = 32;

		// Token: 0x04007420 RID: 29728
		private bool matchXboxUser_;

		// Token: 0x04007421 RID: 29729
		public const int XboxSocialStateFieldNumber = 33;

		// Token: 0x04007422 RID: 29730
		private int xboxSocialState_;
	}
}
