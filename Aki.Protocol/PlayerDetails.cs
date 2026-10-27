using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D89 RID: 3465
	public sealed class PlayerDetails : IMessage<PlayerDetails>, IMessage, IEquatable<PlayerDetails>, IDeepCloneable<PlayerDetails>, IBufferMessage
	{
		// Token: 0x06012ACA RID: 76490 RVA: 0x002B9266 File Offset: 0x002B7466
		[NullableContext(1)]
		public static PlayerDetails Create()
		{
			return new PlayerDetails();
		}

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x06012ACB RID: 76491 RVA: 0x002B926D File Offset: 0x002B746D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerDetails> Parser
		{
			get
			{
				return PlayerDetails._parser;
			}
		}

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x06012ACC RID: 76492 RVA: 0x002B9274 File Offset: 0x002B7474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x06012ACD RID: 76493 RVA: 0x002B9277 File Offset: 0x002B7477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerDetails.Descriptor;
			}
		}

		// Token: 0x06012ACE RID: 76494 RVA: 0x002B9280 File Offset: 0x002B7480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails()
		{
		}

		// Token: 0x06012ACF RID: 76495 RVA: 0x002B9304 File Offset: 0x002B7504
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

		// Token: 0x06012AD0 RID: 76496 RVA: 0x002B94BE File Offset: 0x002B76BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Clone()
		{
			return new PlayerDetails(this);
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x06012AD1 RID: 76497 RVA: 0x002B94C6 File Offset: 0x002B76C6
		// (set) Token: 0x06012AD2 RID: 76498 RVA: 0x002B94CE File Offset: 0x002B76CE
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

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x06012AD3 RID: 76499 RVA: 0x002B94D7 File Offset: 0x002B76D7
		// (set) Token: 0x06012AD4 RID: 76500 RVA: 0x002B94DF File Offset: 0x002B76DF
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

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x06012AD5 RID: 76501 RVA: 0x002B94F2 File Offset: 0x002B76F2
		// (set) Token: 0x06012AD6 RID: 76502 RVA: 0x002B94FA File Offset: 0x002B76FA
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

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x06012AD7 RID: 76503 RVA: 0x002B9503 File Offset: 0x002B7703
		// (set) Token: 0x06012AD8 RID: 76504 RVA: 0x002B950B File Offset: 0x002B770B
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

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x06012AD9 RID: 76505 RVA: 0x002B9514 File Offset: 0x002B7714
		// (set) Token: 0x06012ADA RID: 76506 RVA: 0x002B951C File Offset: 0x002B771C
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

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x06012ADB RID: 76507 RVA: 0x002B9525 File Offset: 0x002B7725
		// (set) Token: 0x06012ADC RID: 76508 RVA: 0x002B952D File Offset: 0x002B772D
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

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x06012ADD RID: 76509 RVA: 0x002B9536 File Offset: 0x002B7736
		// (set) Token: 0x06012ADE RID: 76510 RVA: 0x002B953E File Offset: 0x002B773E
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

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x06012ADF RID: 76511 RVA: 0x002B9547 File Offset: 0x002B7747
		// (set) Token: 0x06012AE0 RID: 76512 RVA: 0x002B954F File Offset: 0x002B774F
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

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x06012AE1 RID: 76513 RVA: 0x002B9562 File Offset: 0x002B7762
		// (set) Token: 0x06012AE2 RID: 76514 RVA: 0x002B956A File Offset: 0x002B776A
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

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x06012AE3 RID: 76515 RVA: 0x002B9573 File Offset: 0x002B7773
		// (set) Token: 0x06012AE4 RID: 76516 RVA: 0x002B957B File Offset: 0x002B777B
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

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x06012AE5 RID: 76517 RVA: 0x002B9584 File Offset: 0x002B7784
		// (set) Token: 0x06012AE6 RID: 76518 RVA: 0x002B958C File Offset: 0x002B778C
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

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x06012AE7 RID: 76519 RVA: 0x002B9595 File Offset: 0x002B7795
		// (set) Token: 0x06012AE8 RID: 76520 RVA: 0x002B959D File Offset: 0x002B779D
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

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x06012AE9 RID: 76521 RVA: 0x002B95A6 File Offset: 0x002B77A6
		// (set) Token: 0x06012AEA RID: 76522 RVA: 0x002B95AE File Offset: 0x002B77AE
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

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x06012AEB RID: 76523 RVA: 0x002B95B7 File Offset: 0x002B77B7
		// (set) Token: 0x06012AEC RID: 76524 RVA: 0x002B95BF File Offset: 0x002B77BF
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

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x06012AED RID: 76525 RVA: 0x002B95C8 File Offset: 0x002B77C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleShowEntry> RoleShowList
		{
			get
			{
				return this.roleShowList_;
			}
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x06012AEE RID: 76526 RVA: 0x002B95D0 File Offset: 0x002B77D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardShowList
		{
			get
			{
				return this.cardShowList_;
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x06012AEF RID: 76527 RVA: 0x002B95D8 File Offset: 0x002B77D8
		// (set) Token: 0x06012AF0 RID: 76528 RVA: 0x002B95E0 File Offset: 0x002B77E0
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

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x06012AF1 RID: 76529 RVA: 0x002B95E9 File Offset: 0x002B77E9
		// (set) Token: 0x06012AF2 RID: 76530 RVA: 0x002B95F1 File Offset: 0x002B77F1
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

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x06012AF3 RID: 76531 RVA: 0x002B95FA File Offset: 0x002B77FA
		// (set) Token: 0x06012AF4 RID: 76532 RVA: 0x002B9602 File Offset: 0x002B7802
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

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x06012AF5 RID: 76533 RVA: 0x002B960B File Offset: 0x002B780B
		// (set) Token: 0x06012AF6 RID: 76534 RVA: 0x002B9613 File Offset: 0x002B7813
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

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x06012AF7 RID: 76535 RVA: 0x002B9626 File Offset: 0x002B7826
		// (set) Token: 0x06012AF8 RID: 76536 RVA: 0x002B962E File Offset: 0x002B782E
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

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x06012AF9 RID: 76537 RVA: 0x002B9641 File Offset: 0x002B7841
		// (set) Token: 0x06012AFA RID: 76538 RVA: 0x002B9649 File Offset: 0x002B7849
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

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x06012AFB RID: 76539 RVA: 0x002B965C File Offset: 0x002B785C
		// (set) Token: 0x06012AFC RID: 76540 RVA: 0x002B9664 File Offset: 0x002B7864
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

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x06012AFD RID: 76541 RVA: 0x002B966D File Offset: 0x002B786D
		// (set) Token: 0x06012AFE RID: 76542 RVA: 0x002B9675 File Offset: 0x002B7875
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

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x06012AFF RID: 76543 RVA: 0x002B967E File Offset: 0x002B787E
		// (set) Token: 0x06012B00 RID: 76544 RVA: 0x002B9686 File Offset: 0x002B7886
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

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x06012B01 RID: 76545 RVA: 0x002B968F File Offset: 0x002B788F
		// (set) Token: 0x06012B02 RID: 76546 RVA: 0x002B9697 File Offset: 0x002B7897
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

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x06012B03 RID: 76547 RVA: 0x002B96A0 File Offset: 0x002B78A0
		// (set) Token: 0x06012B04 RID: 76548 RVA: 0x002B96A8 File Offset: 0x002B78A8
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

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x06012B05 RID: 76549 RVA: 0x002B96B1 File Offset: 0x002B78B1
		// (set) Token: 0x06012B06 RID: 76550 RVA: 0x002B96B9 File Offset: 0x002B78B9
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

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x06012B07 RID: 76551 RVA: 0x002B96C2 File Offset: 0x002B78C2
		// (set) Token: 0x06012B08 RID: 76552 RVA: 0x002B96CA File Offset: 0x002B78CA
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

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x06012B09 RID: 76553 RVA: 0x002B96DD File Offset: 0x002B78DD
		// (set) Token: 0x06012B0A RID: 76554 RVA: 0x002B96E5 File Offset: 0x002B78E5
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

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x06012B0B RID: 76555 RVA: 0x002B96F8 File Offset: 0x002B78F8
		// (set) Token: 0x06012B0C RID: 76556 RVA: 0x002B9700 File Offset: 0x002B7900
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

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x06012B0D RID: 76557 RVA: 0x002B9713 File Offset: 0x002B7913
		// (set) Token: 0x06012B0E RID: 76558 RVA: 0x002B971B File Offset: 0x002B791B
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

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x06012B0F RID: 76559 RVA: 0x002B9724 File Offset: 0x002B7924
		// (set) Token: 0x06012B10 RID: 76560 RVA: 0x002B972C File Offset: 0x002B792C
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

		// Token: 0x06012B11 RID: 76561 RVA: 0x002B9735 File Offset: 0x002B7935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerDetails);
		}

		// Token: 0x06012B12 RID: 76562 RVA: 0x002B9744 File Offset: 0x002B7944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerDetails other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.Level == other.Level && this.OriginWorldLevel == other.OriginWorldLevel && this.CurWorldLevel == other.CurWorldLevel && this.HeadId == other.HeadId && this.HeadFrameId == other.HeadFrameId && !(this.Signature != other.Signature) && this.IsOnline == other.IsOnline && this.IsCanLobbyOnline == other.IsCanLobbyOnline && this.LastOfflineTime == other.LastOfflineTime && this.TeamMemberCount == other.TeamMemberCount && this.LevelGap == other.LevelGap && this.Birthday == other.Birthday && this.roleShowList_.Equals(other.roleShowList_) && this.cardShowList_.Equals(other.cardShowList_) && this.CurCard == other.CurCard && this.DisplayBirthday == other.DisplayBirthday && this.LastEnterMultiWillTime == other.LastEnterMultiWillTime && !(this.PsnUserId != other.PsnUserId) && !(this.PsnOnlineId != other.PsnOnlineId) && !(this.PsnAccountId != other.PsnAccountId) && this.MatchPsnUser == other.MatchPsnUser && this.PsnSocialState == other.PsnSocialState && this.PlayerTitleId == other.PlayerTitleId && this.PlayerTitleExtraParam == other.PlayerTitleExtraParam && this.Sex == other.Sex && this.Deactivation == other.Deactivation && !(this.XboxUserId != other.XboxUserId) && !(this.XboxOnlineId != other.XboxOnlineId) && !(this.XboxAccountId != other.XboxAccountId) && this.MatchXboxUser == other.MatchXboxUser && this.XboxSocialState == other.XboxSocialState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B13 RID: 76563 RVA: 0x002B99B0 File Offset: 0x002B7BB0
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

		// Token: 0x06012B14 RID: 76564 RVA: 0x002B9D09 File Offset: 0x002B7F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B15 RID: 76565 RVA: 0x002B9D16 File Offset: 0x002B7F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B16 RID: 76566 RVA: 0x002B9D20 File Offset: 0x002B7F20
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

		// Token: 0x06012B17 RID: 76567 RVA: 0x002BA134 File Offset: 0x002B8334
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

		// Token: 0x06012B18 RID: 76568 RVA: 0x002BA448 File Offset: 0x002B8648
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

		// Token: 0x06012B19 RID: 76569 RVA: 0x002BA726 File Offset: 0x002B8926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B1A RID: 76570 RVA: 0x002BA730 File Offset: 0x002B8930
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

		// Token: 0x040073C5 RID: 29637
		private static readonly MessageParser<PlayerDetails> _parser = new MessageParser<PlayerDetails>(() => new PlayerDetails());

		// Token: 0x040073C6 RID: 29638
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073C7 RID: 29639
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040073C8 RID: 29640
		private int playerId_;

		// Token: 0x040073C9 RID: 29641
		public const int NameFieldNumber = 2;

		// Token: 0x040073CA RID: 29642
		private string name_ = "";

		// Token: 0x040073CB RID: 29643
		public const int LevelFieldNumber = 3;

		// Token: 0x040073CC RID: 29644
		private int level_;

		// Token: 0x040073CD RID: 29645
		public const int OriginWorldLevelFieldNumber = 4;

		// Token: 0x040073CE RID: 29646
		private int originWorldLevel_;

		// Token: 0x040073CF RID: 29647
		public const int CurWorldLevelFieldNumber = 5;

		// Token: 0x040073D0 RID: 29648
		private int curWorldLevel_;

		// Token: 0x040073D1 RID: 29649
		public const int HeadIdFieldNumber = 6;

		// Token: 0x040073D2 RID: 29650
		private int headId_;

		// Token: 0x040073D3 RID: 29651
		public const int HeadFrameIdFieldNumber = 7;

		// Token: 0x040073D4 RID: 29652
		private int headFrameId_;

		// Token: 0x040073D5 RID: 29653
		public const int SignatureFieldNumber = 8;

		// Token: 0x040073D6 RID: 29654
		private string signature_ = "";

		// Token: 0x040073D7 RID: 29655
		public const int IsOnlineFieldNumber = 9;

		// Token: 0x040073D8 RID: 29656
		private bool isOnline_;

		// Token: 0x040073D9 RID: 29657
		public const int IsCanLobbyOnlineFieldNumber = 10;

		// Token: 0x040073DA RID: 29658
		private bool isCanLobbyOnline_;

		// Token: 0x040073DB RID: 29659
		public const int LastOfflineTimeFieldNumber = 11;

		// Token: 0x040073DC RID: 29660
		private long lastOfflineTime_;

		// Token: 0x040073DD RID: 29661
		public const int TeamMemberCountFieldNumber = 12;

		// Token: 0x040073DE RID: 29662
		private int teamMemberCount_;

		// Token: 0x040073DF RID: 29663
		public const int LevelGapFieldNumber = 13;

		// Token: 0x040073E0 RID: 29664
		private int levelGap_;

		// Token: 0x040073E1 RID: 29665
		public const int BirthdayFieldNumber = 14;

		// Token: 0x040073E2 RID: 29666
		private int birthday_;

		// Token: 0x040073E3 RID: 29667
		public const int RoleShowListFieldNumber = 15;

		// Token: 0x040073E4 RID: 29668
		private static readonly FieldCodec<RoleShowEntry> _repeated_roleShowList_codec = FieldCodec.ForMessage<RoleShowEntry>(122U, RoleShowEntry.Parser);

		// Token: 0x040073E5 RID: 29669
		private readonly RepeatedField<RoleShowEntry> roleShowList_ = new RepeatedField<RoleShowEntry>();

		// Token: 0x040073E6 RID: 29670
		public const int CardShowListFieldNumber = 16;

		// Token: 0x040073E7 RID: 29671
		private static readonly FieldCodec<int> _repeated_cardShowList_codec = FieldCodec.ForInt32(130U);

		// Token: 0x040073E8 RID: 29672
		private readonly RepeatedField<int> cardShowList_ = new RepeatedField<int>();

		// Token: 0x040073E9 RID: 29673
		public const int CurCardFieldNumber = 17;

		// Token: 0x040073EA RID: 29674
		private int curCard_;

		// Token: 0x040073EB RID: 29675
		public const int DisplayBirthdayFieldNumber = 18;

		// Token: 0x040073EC RID: 29676
		private bool displayBirthday_;

		// Token: 0x040073ED RID: 29677
		public const int LastEnterMultiWillTimeFieldNumber = 19;

		// Token: 0x040073EE RID: 29678
		private long lastEnterMultiWillTime_;

		// Token: 0x040073EF RID: 29679
		public const int PsnUserIdFieldNumber = 20;

		// Token: 0x040073F0 RID: 29680
		private string psnUserId_ = "";

		// Token: 0x040073F1 RID: 29681
		public const int PsnOnlineIdFieldNumber = 21;

		// Token: 0x040073F2 RID: 29682
		private string psnOnlineId_ = "";

		// Token: 0x040073F3 RID: 29683
		public const int PsnAccountIdFieldNumber = 22;

		// Token: 0x040073F4 RID: 29684
		private string psnAccountId_ = "";

		// Token: 0x040073F5 RID: 29685
		public const int MatchPsnUserFieldNumber = 23;

		// Token: 0x040073F6 RID: 29686
		private bool matchPsnUser_;

		// Token: 0x040073F7 RID: 29687
		public const int PsnSocialStateFieldNumber = 24;

		// Token: 0x040073F8 RID: 29688
		private int psnSocialState_;

		// Token: 0x040073F9 RID: 29689
		public const int PlayerTitleIdFieldNumber = 25;

		// Token: 0x040073FA RID: 29690
		private int playerTitleId_;

		// Token: 0x040073FB RID: 29691
		public const int PlayerTitleExtraParamFieldNumber = 26;

		// Token: 0x040073FC RID: 29692
		private int playerTitleExtraParam_;

		// Token: 0x040073FD RID: 29693
		public const int SexFieldNumber = 27;

		// Token: 0x040073FE RID: 29694
		private int sex_;

		// Token: 0x040073FF RID: 29695
		public const int DeactivationFieldNumber = 28;

		// Token: 0x04007400 RID: 29696
		private bool deactivation_;

		// Token: 0x04007401 RID: 29697
		public const int XboxUserIdFieldNumber = 29;

		// Token: 0x04007402 RID: 29698
		private string xboxUserId_ = "";

		// Token: 0x04007403 RID: 29699
		public const int XboxOnlineIdFieldNumber = 30;

		// Token: 0x04007404 RID: 29700
		private string xboxOnlineId_ = "";

		// Token: 0x04007405 RID: 29701
		public const int XboxAccountIdFieldNumber = 31;

		// Token: 0x04007406 RID: 29702
		private string xboxAccountId_ = "";

		// Token: 0x04007407 RID: 29703
		public const int MatchXboxUserFieldNumber = 32;

		// Token: 0x04007408 RID: 29704
		private bool matchXboxUser_;

		// Token: 0x04007409 RID: 29705
		public const int XboxSocialStateFieldNumber = 33;

		// Token: 0x0400740A RID: 29706
		private int xboxSocialState_;
	}
}
