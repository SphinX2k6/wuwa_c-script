using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093A RID: 2362
	[NetMessage(EMessageId.LoginRequest)]
	public sealed class LoginRequest : IMessage<LoginRequest>, IMessage, IEquatable<LoginRequest>, IDeepCloneable<LoginRequest>, IBufferMessage
	{
		// Token: 0x0600D060 RID: 53344 RVA: 0x001EAD7C File Offset: 0x001E8F7C
		[NullableContext(1)]
		public static LoginRequest Create()
		{
			return new LoginRequest();
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x0600D061 RID: 53345 RVA: 0x001EAD83 File Offset: 0x001E8F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x0600D062 RID: 53346 RVA: 0x001EAD86 File Offset: 0x001E8F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginRequest.Descriptor;
			}
		}

		// Token: 0x0600D063 RID: 53347 RVA: 0x001EAD90 File Offset: 0x001E8F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginRequest()
		{
		}

		// Token: 0x0600D064 RID: 53348 RVA: 0x001EAE60 File Offset: 0x001E9060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginRequest(LoginRequest other) : this()
		{
			this.id_ = other.id_;
			this.account_ = other.account_;
			this.loginTraceId_ = other.loginTraceId_;
			this.token_ = other.token_;
			this.appVersion_ = other.appVersion_;
			this.launcherVersion_ = other.launcherVersion_;
			this.resourceVersion_ = other.resourceVersion_;
			this.clientBasicInfo_ = ((other.clientBasicInfo_ != null) ? other.clientBasicInfo_.Clone() : null);
			this.devLoginCheckData_ = ((other.devLoginCheckData_ != null) ? other.devLoginCheckData_.Clone() : null);
			this.publicResourceVersionInfo_ = ((other.publicResourceVersionInfo_ != null) ? other.publicResourceVersionInfo_.Clone() : null);
			this.aceBlackProductAccountInfo_ = ((other.aceBlackProductAccountInfo_ != null) ? other.aceBlackProductAccountInfo_.Clone() : null);
			this.pushIsOpen_ = other.pushIsOpen_;
			this.geTuiDeviceId_ = other.geTuiDeviceId_;
			this.psnUserId_ = other.psnUserId_;
			this.psnOnlineId_ = other.psnOnlineId_;
			this.psnAccountId_ = other.psnAccountId_;
			this.fightDataDigest_ = other.fightDataDigest_;
			this.psnSocialState_ = other.psnSocialState_;
			this.fsmVersion_ = other.fsmVersion_;
			this.confirmQuestResource_ = other.confirmQuestResource_;
			this.questResourceState_ = other.questResourceState_;
			this.isLowMemoryPlatform_ = other.isLowMemoryPlatform_;
			this.switchState_ = other.switchState_;
			this.downloadResourceQuestId_ = other.downloadResourceQuestId_.Clone();
			this.xboxUserId_ = other.xboxUserId_;
			this.xboxOnlineId_ = other.xboxOnlineId_;
			this.xboxAccountId_ = other.xboxAccountId_;
			this.xboxSocialState_ = other.xboxSocialState_;
			this.xstsToken_ = other.xstsToken_;
			this.gradedResourceVersion_ = other.gradedResourceVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D065 RID: 53349 RVA: 0x001EB031 File Offset: 0x001E9231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginRequest Clone()
		{
			return new LoginRequest(this);
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x0600D066 RID: 53350 RVA: 0x001EB039 File Offset: 0x001E9239
		// (set) Token: 0x0600D067 RID: 53351 RVA: 0x001EB041 File Offset: 0x001E9241
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

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x0600D068 RID: 53352 RVA: 0x001EB04A File Offset: 0x001E924A
		// (set) Token: 0x0600D069 RID: 53353 RVA: 0x001EB052 File Offset: 0x001E9252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x0600D06A RID: 53354 RVA: 0x001EB065 File Offset: 0x001E9265
		// (set) Token: 0x0600D06B RID: 53355 RVA: 0x001EB06D File Offset: 0x001E926D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LoginTraceId
		{
			get
			{
				return this.loginTraceId_;
			}
			set
			{
				this.loginTraceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0600D06C RID: 53356 RVA: 0x001EB080 File Offset: 0x001E9280
		// (set) Token: 0x0600D06D RID: 53357 RVA: 0x001EB088 File Offset: 0x001E9288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Token
		{
			get
			{
				return this.token_;
			}
			set
			{
				this.token_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x0600D06E RID: 53358 RVA: 0x001EB09B File Offset: 0x001E929B
		// (set) Token: 0x0600D06F RID: 53359 RVA: 0x001EB0A3 File Offset: 0x001E92A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AppVersion
		{
			get
			{
				return this.appVersion_;
			}
			set
			{
				this.appVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x0600D070 RID: 53360 RVA: 0x001EB0B6 File Offset: 0x001E92B6
		// (set) Token: 0x0600D071 RID: 53361 RVA: 0x001EB0BE File Offset: 0x001E92BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LauncherVersion
		{
			get
			{
				return this.launcherVersion_;
			}
			set
			{
				this.launcherVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x0600D072 RID: 53362 RVA: 0x001EB0D1 File Offset: 0x001E92D1
		// (set) Token: 0x0600D073 RID: 53363 RVA: 0x001EB0D9 File Offset: 0x001E92D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ResourceVersion
		{
			get
			{
				return this.resourceVersion_;
			}
			set
			{
				this.resourceVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x0600D074 RID: 53364 RVA: 0x001EB0EC File Offset: 0x001E92EC
		// (set) Token: 0x0600D075 RID: 53365 RVA: 0x001EB0F4 File Offset: 0x001E92F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfo ClientBasicInfo
		{
			get
			{
				return this.clientBasicInfo_;
			}
			set
			{
				this.clientBasicInfo_ = value;
			}
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x0600D076 RID: 53366 RVA: 0x001EB0FD File Offset: 0x001E92FD
		// (set) Token: 0x0600D077 RID: 53367 RVA: 0x001EB105 File Offset: 0x001E9305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DevLoginCheckData DevLoginCheckData
		{
			get
			{
				return this.devLoginCheckData_;
			}
			set
			{
				this.devLoginCheckData_ = value;
			}
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x0600D078 RID: 53368 RVA: 0x001EB10E File Offset: 0x001E930E
		// (set) Token: 0x0600D079 RID: 53369 RVA: 0x001EB116 File Offset: 0x001E9316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicResourceVersionInfo PublicResourceVersionInfo
		{
			get
			{
				return this.publicResourceVersionInfo_;
			}
			set
			{
				this.publicResourceVersionInfo_ = value;
			}
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x0600D07A RID: 53370 RVA: 0x001EB11F File Offset: 0x001E931F
		// (set) Token: 0x0600D07B RID: 53371 RVA: 0x001EB127 File Offset: 0x001E9327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceBlackProductAccountInfo AceBlackProductAccountInfo
		{
			get
			{
				return this.aceBlackProductAccountInfo_;
			}
			set
			{
				this.aceBlackProductAccountInfo_ = value;
			}
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x0600D07C RID: 53372 RVA: 0x001EB130 File Offset: 0x001E9330
		// (set) Token: 0x0600D07D RID: 53373 RVA: 0x001EB138 File Offset: 0x001E9338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PushIsOpen
		{
			get
			{
				return this.pushIsOpen_;
			}
			set
			{
				this.pushIsOpen_ = value;
			}
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x0600D07E RID: 53374 RVA: 0x001EB141 File Offset: 0x001E9341
		// (set) Token: 0x0600D07F RID: 53375 RVA: 0x001EB149 File Offset: 0x001E9349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GeTuiDeviceId
		{
			get
			{
				return this.geTuiDeviceId_;
			}
			set
			{
				this.geTuiDeviceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x0600D080 RID: 53376 RVA: 0x001EB15C File Offset: 0x001E935C
		// (set) Token: 0x0600D081 RID: 53377 RVA: 0x001EB164 File Offset: 0x001E9364
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

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x0600D082 RID: 53378 RVA: 0x001EB177 File Offset: 0x001E9377
		// (set) Token: 0x0600D083 RID: 53379 RVA: 0x001EB17F File Offset: 0x001E937F
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

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x0600D084 RID: 53380 RVA: 0x001EB192 File Offset: 0x001E9392
		// (set) Token: 0x0600D085 RID: 53381 RVA: 0x001EB19A File Offset: 0x001E939A
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

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x0600D086 RID: 53382 RVA: 0x001EB1AD File Offset: 0x001E93AD
		// (set) Token: 0x0600D087 RID: 53383 RVA: 0x001EB1B5 File Offset: 0x001E93B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FightDataDigest
		{
			get
			{
				return this.fightDataDigest_;
			}
			set
			{
				this.fightDataDigest_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x0600D088 RID: 53384 RVA: 0x001EB1C8 File Offset: 0x001E93C8
		// (set) Token: 0x0600D089 RID: 53385 RVA: 0x001EB1D0 File Offset: 0x001E93D0
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

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x0600D08A RID: 53386 RVA: 0x001EB1D9 File Offset: 0x001E93D9
		// (set) Token: 0x0600D08B RID: 53387 RVA: 0x001EB1E1 File Offset: 0x001E93E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmVersion
		{
			get
			{
				return this.fsmVersion_;
			}
			set
			{
				this.fsmVersion_ = value;
			}
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x0600D08C RID: 53388 RVA: 0x001EB1EA File Offset: 0x001E93EA
		// (set) Token: 0x0600D08D RID: 53389 RVA: 0x001EB1F2 File Offset: 0x001E93F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ConfirmQuestResource
		{
			get
			{
				return this.confirmQuestResource_;
			}
			set
			{
				this.confirmQuestResource_ = value;
			}
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x0600D08E RID: 53390 RVA: 0x001EB1FB File Offset: 0x001E93FB
		// (set) Token: 0x0600D08F RID: 53391 RVA: 0x001EB203 File Offset: 0x001E9403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestResourceState
		{
			get
			{
				return this.questResourceState_;
			}
			set
			{
				this.questResourceState_ = value;
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x0600D090 RID: 53392 RVA: 0x001EB20C File Offset: 0x001E940C
		// (set) Token: 0x0600D091 RID: 53393 RVA: 0x001EB214 File Offset: 0x001E9414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLowMemoryPlatform
		{
			get
			{
				return this.isLowMemoryPlatform_;
			}
			set
			{
				this.isLowMemoryPlatform_ = value;
			}
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x0600D092 RID: 53394 RVA: 0x001EB21D File Offset: 0x001E941D
		// (set) Token: 0x0600D093 RID: 53395 RVA: 0x001EB225 File Offset: 0x001E9425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ESceneBlockSwithState SwitchState
		{
			get
			{
				return this.switchState_;
			}
			set
			{
				this.switchState_ = value;
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x0600D094 RID: 53396 RVA: 0x001EB22E File Offset: 0x001E942E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadResourceQuestId
		{
			get
			{
				return this.downloadResourceQuestId_;
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x0600D095 RID: 53397 RVA: 0x001EB236 File Offset: 0x001E9436
		// (set) Token: 0x0600D096 RID: 53398 RVA: 0x001EB23E File Offset: 0x001E943E
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

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x0600D097 RID: 53399 RVA: 0x001EB251 File Offset: 0x001E9451
		// (set) Token: 0x0600D098 RID: 53400 RVA: 0x001EB259 File Offset: 0x001E9459
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

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x0600D099 RID: 53401 RVA: 0x001EB26C File Offset: 0x001E946C
		// (set) Token: 0x0600D09A RID: 53402 RVA: 0x001EB274 File Offset: 0x001E9474
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

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x0600D09B RID: 53403 RVA: 0x001EB287 File Offset: 0x001E9487
		// (set) Token: 0x0600D09C RID: 53404 RVA: 0x001EB28F File Offset: 0x001E948F
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

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0600D09D RID: 53405 RVA: 0x001EB298 File Offset: 0x001E9498
		// (set) Token: 0x0600D09E RID: 53406 RVA: 0x001EB2A0 File Offset: 0x001E94A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XstsToken
		{
			get
			{
				return this.xstsToken_;
			}
			set
			{
				this.xstsToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x0600D09F RID: 53407 RVA: 0x001EB2B3 File Offset: 0x001E94B3
		// (set) Token: 0x0600D0A0 RID: 53408 RVA: 0x001EB2BB File Offset: 0x001E94BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GradedResourceVersion
		{
			get
			{
				return this.gradedResourceVersion_;
			}
			set
			{
				this.gradedResourceVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600D0A1 RID: 53409 RVA: 0x001EB2CE File Offset: 0x001E94CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginRequest);
		}

		// Token: 0x0600D0A2 RID: 53410 RVA: 0x001EB2DC File Offset: 0x001E94DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoginRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Account != other.Account) && !(this.LoginTraceId != other.LoginTraceId) && !(this.Token != other.Token) && !(this.AppVersion != other.AppVersion) && !(this.LauncherVersion != other.LauncherVersion) && !(this.ResourceVersion != other.ResourceVersion) && object.Equals(this.ClientBasicInfo, other.ClientBasicInfo) && object.Equals(this.DevLoginCheckData, other.DevLoginCheckData) && object.Equals(this.PublicResourceVersionInfo, other.PublicResourceVersionInfo) && object.Equals(this.AceBlackProductAccountInfo, other.AceBlackProductAccountInfo) && this.PushIsOpen == other.PushIsOpen && !(this.GeTuiDeviceId != other.GeTuiDeviceId) && !(this.PsnUserId != other.PsnUserId) && !(this.PsnOnlineId != other.PsnOnlineId) && !(this.PsnAccountId != other.PsnAccountId) && !(this.FightDataDigest != other.FightDataDigest) && this.PsnSocialState == other.PsnSocialState && this.FsmVersion == other.FsmVersion && this.ConfirmQuestResource == other.ConfirmQuestResource && this.QuestResourceState == other.QuestResourceState && this.IsLowMemoryPlatform == other.IsLowMemoryPlatform && this.SwitchState == other.SwitchState && this.downloadResourceQuestId_.Equals(other.downloadResourceQuestId_) && !(this.XboxUserId != other.XboxUserId) && !(this.XboxOnlineId != other.XboxOnlineId) && !(this.XboxAccountId != other.XboxAccountId) && this.XboxSocialState == other.XboxSocialState && !(this.XstsToken != other.XstsToken) && !(this.GradedResourceVersion != other.GradedResourceVersion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0A3 RID: 53411 RVA: 0x001EB550 File Offset: 0x001E9750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Account.Length != 0)
			{
				num ^= this.Account.GetHashCode();
			}
			if (this.LoginTraceId.Length != 0)
			{
				num ^= this.LoginTraceId.GetHashCode();
			}
			if (this.Token.Length != 0)
			{
				num ^= this.Token.GetHashCode();
			}
			if (this.AppVersion.Length != 0)
			{
				num ^= this.AppVersion.GetHashCode();
			}
			if (this.LauncherVersion.Length != 0)
			{
				num ^= this.LauncherVersion.GetHashCode();
			}
			if (this.ResourceVersion.Length != 0)
			{
				num ^= this.ResourceVersion.GetHashCode();
			}
			if (this.clientBasicInfo_ != null)
			{
				num ^= this.ClientBasicInfo.GetHashCode();
			}
			if (this.devLoginCheckData_ != null)
			{
				num ^= this.DevLoginCheckData.GetHashCode();
			}
			if (this.publicResourceVersionInfo_ != null)
			{
				num ^= this.PublicResourceVersionInfo.GetHashCode();
			}
			if (this.aceBlackProductAccountInfo_ != null)
			{
				num ^= this.AceBlackProductAccountInfo.GetHashCode();
			}
			if (this.PushIsOpen)
			{
				num ^= this.PushIsOpen.GetHashCode();
			}
			if (this.GeTuiDeviceId.Length != 0)
			{
				num ^= this.GeTuiDeviceId.GetHashCode();
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
			if (this.FightDataDigest.Length != 0)
			{
				num ^= this.FightDataDigest.GetHashCode();
			}
			if (this.PsnSocialState != 0)
			{
				num ^= this.PsnSocialState.GetHashCode();
			}
			if (this.FsmVersion != 0)
			{
				num ^= this.FsmVersion.GetHashCode();
			}
			if (this.ConfirmQuestResource)
			{
				num ^= this.ConfirmQuestResource.GetHashCode();
			}
			if (this.QuestResourceState != 0)
			{
				num ^= this.QuestResourceState.GetHashCode();
			}
			if (this.IsLowMemoryPlatform)
			{
				num ^= this.IsLowMemoryPlatform.GetHashCode();
			}
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				num ^= this.SwitchState.GetHashCode();
			}
			num ^= this.downloadResourceQuestId_.GetHashCode();
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
			if (this.XboxSocialState != 0)
			{
				num ^= this.XboxSocialState.GetHashCode();
			}
			if (this.XstsToken.Length != 0)
			{
				num ^= this.XstsToken.GetHashCode();
			}
			if (this.GradedResourceVersion.Length != 0)
			{
				num ^= this.GradedResourceVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0A4 RID: 53412 RVA: 0x001EB873 File Offset: 0x001E9A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0A5 RID: 53413 RVA: 0x001EB880 File Offset: 0x001E9A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x001EB88C File Offset: 0x001E9A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Account.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Account);
			}
			if (this.LoginTraceId.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.LoginTraceId);
			}
			if (this.Token.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Token);
			}
			if (this.AppVersion.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.AppVersion);
			}
			if (this.LauncherVersion.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.LauncherVersion);
			}
			if (this.ResourceVersion.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.ResourceVersion);
			}
			if (this.clientBasicInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ClientBasicInfo);
			}
			if (this.devLoginCheckData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.DevLoginCheckData);
			}
			if (this.publicResourceVersionInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PublicResourceVersionInfo);
			}
			if (this.aceBlackProductAccountInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.AceBlackProductAccountInfo);
			}
			if (this.PushIsOpen)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.PushIsOpen);
			}
			if (this.GeTuiDeviceId.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.GeTuiDeviceId);
			}
			if (this.PsnUserId.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.PsnUserId);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.PsnOnlineId);
			}
			if (this.PsnAccountId.Length != 0)
			{
				output.WriteRawTag(130, 1);
				output.WriteString(this.PsnAccountId);
			}
			if (this.FightDataDigest.Length != 0)
			{
				output.WriteRawTag(138, 1);
				output.WriteString(this.FightDataDigest);
			}
			if (this.PsnSocialState != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.PsnSocialState);
			}
			if (this.FsmVersion != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.FsmVersion);
			}
			if (this.ConfirmQuestResource)
			{
				output.WriteRawTag(160, 1);
				output.WriteBool(this.ConfirmQuestResource);
			}
			if (this.QuestResourceState != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.QuestResourceState);
			}
			if (this.IsLowMemoryPlatform)
			{
				output.WriteRawTag(176, 1);
				output.WriteBool(this.IsLowMemoryPlatform);
			}
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				output.WriteRawTag(184, 1);
				output.WriteEnum((int)this.SwitchState);
			}
			this.downloadResourceQuestId_.WriteTo(ref output, LoginRequest._repeated_downloadResourceQuestId_codec);
			if (this.XboxUserId.Length != 0)
			{
				output.WriteRawTag(202, 1);
				output.WriteString(this.XboxUserId);
			}
			if (this.XboxOnlineId.Length != 0)
			{
				output.WriteRawTag(210, 1);
				output.WriteString(this.XboxOnlineId);
			}
			if (this.XboxAccountId.Length != 0)
			{
				output.WriteRawTag(218, 1);
				output.WriteString(this.XboxAccountId);
			}
			if (this.XboxSocialState != 0)
			{
				output.WriteRawTag(224, 1);
				output.WriteInt32(this.XboxSocialState);
			}
			if (this.XstsToken.Length != 0)
			{
				output.WriteRawTag(242, 1);
				output.WriteString(this.XstsToken);
			}
			if (this.GradedResourceVersion.Length != 0)
			{
				output.WriteRawTag(250, 1);
				output.WriteString(this.GradedResourceVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0A7 RID: 53415 RVA: 0x001EBC74 File Offset: 0x001E9E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Account.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Account);
			}
			if (this.LoginTraceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LoginTraceId);
			}
			if (this.Token.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Token);
			}
			if (this.AppVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AppVersion);
			}
			if (this.LauncherVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LauncherVersion);
			}
			if (this.ResourceVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ResourceVersion);
			}
			if (this.clientBasicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientBasicInfo);
			}
			if (this.devLoginCheckData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DevLoginCheckData);
			}
			if (this.publicResourceVersionInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PublicResourceVersionInfo);
			}
			if (this.aceBlackProductAccountInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AceBlackProductAccountInfo);
			}
			if (this.PushIsOpen)
			{
				num += 2;
			}
			if (this.GeTuiDeviceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GeTuiDeviceId);
			}
			if (this.PsnUserId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnUserId);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnOnlineId);
			}
			if (this.PsnAccountId.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PsnAccountId);
			}
			if (this.FightDataDigest.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.FightDataDigest);
			}
			if (this.PsnSocialState != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PsnSocialState);
			}
			if (this.FsmVersion != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FsmVersion);
			}
			if (this.ConfirmQuestResource)
			{
				num += 3;
			}
			if (this.QuestResourceState != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.QuestResourceState);
			}
			if (this.IsLowMemoryPlatform)
			{
				num += 3;
			}
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.SwitchState);
			}
			num += this.downloadResourceQuestId_.CalculateSize(LoginRequest._repeated_downloadResourceQuestId_codec);
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
			if (this.XboxSocialState != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.XboxSocialState);
			}
			if (this.XstsToken.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.XstsToken);
			}
			if (this.GradedResourceVersion.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.GradedResourceVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0A8 RID: 53416 RVA: 0x001EBF94 File Offset: 0x001EA194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoginRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Account.Length != 0)
			{
				this.Account = other.Account;
			}
			if (other.LoginTraceId.Length != 0)
			{
				this.LoginTraceId = other.LoginTraceId;
			}
			if (other.Token.Length != 0)
			{
				this.Token = other.Token;
			}
			if (other.AppVersion.Length != 0)
			{
				this.AppVersion = other.AppVersion;
			}
			if (other.LauncherVersion.Length != 0)
			{
				this.LauncherVersion = other.LauncherVersion;
			}
			if (other.ResourceVersion.Length != 0)
			{
				this.ResourceVersion = other.ResourceVersion;
			}
			if (other.clientBasicInfo_ != null)
			{
				if (this.clientBasicInfo_ == null)
				{
					this.ClientBasicInfo = new ClientBasicInfo();
				}
				this.ClientBasicInfo.MergeFrom(other.ClientBasicInfo);
			}
			if (other.devLoginCheckData_ != null)
			{
				if (this.devLoginCheckData_ == null)
				{
					this.DevLoginCheckData = new DevLoginCheckData();
				}
				this.DevLoginCheckData.MergeFrom(other.DevLoginCheckData);
			}
			if (other.publicResourceVersionInfo_ != null)
			{
				if (this.publicResourceVersionInfo_ == null)
				{
					this.PublicResourceVersionInfo = new PublicResourceVersionInfo();
				}
				this.PublicResourceVersionInfo.MergeFrom(other.PublicResourceVersionInfo);
			}
			if (other.aceBlackProductAccountInfo_ != null)
			{
				if (this.aceBlackProductAccountInfo_ == null)
				{
					this.AceBlackProductAccountInfo = new AceBlackProductAccountInfo();
				}
				this.AceBlackProductAccountInfo.MergeFrom(other.AceBlackProductAccountInfo);
			}
			if (other.PushIsOpen)
			{
				this.PushIsOpen = other.PushIsOpen;
			}
			if (other.GeTuiDeviceId.Length != 0)
			{
				this.GeTuiDeviceId = other.GeTuiDeviceId;
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
			if (other.FightDataDigest.Length != 0)
			{
				this.FightDataDigest = other.FightDataDigest;
			}
			if (other.PsnSocialState != 0)
			{
				this.PsnSocialState = other.PsnSocialState;
			}
			if (other.FsmVersion != 0)
			{
				this.FsmVersion = other.FsmVersion;
			}
			if (other.ConfirmQuestResource)
			{
				this.ConfirmQuestResource = other.ConfirmQuestResource;
			}
			if (other.QuestResourceState != 0)
			{
				this.QuestResourceState = other.QuestResourceState;
			}
			if (other.IsLowMemoryPlatform)
			{
				this.IsLowMemoryPlatform = other.IsLowMemoryPlatform;
			}
			if (other.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				this.SwitchState = other.SwitchState;
			}
			this.downloadResourceQuestId_.Add(other.downloadResourceQuestId_);
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
			if (other.XboxSocialState != 0)
			{
				this.XboxSocialState = other.XboxSocialState;
			}
			if (other.XstsToken.Length != 0)
			{
				this.XstsToken = other.XstsToken;
			}
			if (other.GradedResourceVersion.Length != 0)
			{
				this.GradedResourceVersion = other.GradedResourceVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x001EC2C1 File Offset: 0x001EA4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0AA RID: 53418 RVA: 0x001EC2CC File Offset: 0x001EA4CC
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
				if (num <= 122U)
				{
					if (num <= 58U)
					{
						if (num <= 26U)
						{
							if (num == 8U)
							{
								this.Id = input.ReadInt32();
								continue;
							}
							if (num == 18U)
							{
								this.Account = input.ReadString();
								continue;
							}
							if (num == 26U)
							{
								this.LoginTraceId = input.ReadString();
								continue;
							}
						}
						else if (num <= 42U)
						{
							if (num == 34U)
							{
								this.Token = input.ReadString();
								continue;
							}
							if (num == 42U)
							{
								this.AppVersion = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 50U)
							{
								this.LauncherVersion = input.ReadString();
								continue;
							}
							if (num == 58U)
							{
								this.ResourceVersion = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 90U)
					{
						if (num <= 74U)
						{
							if (num == 66U)
							{
								if (this.clientBasicInfo_ == null)
								{
									this.ClientBasicInfo = new ClientBasicInfo();
								}
								input.ReadMessage(this.ClientBasicInfo);
								continue;
							}
							if (num == 74U)
							{
								if (this.devLoginCheckData_ == null)
								{
									this.DevLoginCheckData = new DevLoginCheckData();
								}
								input.ReadMessage(this.DevLoginCheckData);
								continue;
							}
						}
						else
						{
							if (num == 82U)
							{
								if (this.publicResourceVersionInfo_ == null)
								{
									this.PublicResourceVersionInfo = new PublicResourceVersionInfo();
								}
								input.ReadMessage(this.PublicResourceVersionInfo);
								continue;
							}
							if (num == 90U)
							{
								if (this.aceBlackProductAccountInfo_ == null)
								{
									this.AceBlackProductAccountInfo = new AceBlackProductAccountInfo();
								}
								input.ReadMessage(this.AceBlackProductAccountInfo);
								continue;
							}
						}
					}
					else if (num <= 106U)
					{
						if (num == 96U)
						{
							this.PushIsOpen = input.ReadBool();
							continue;
						}
						if (num == 106U)
						{
							this.GeTuiDeviceId = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 114U)
						{
							this.PsnUserId = input.ReadString();
							continue;
						}
						if (num == 122U)
						{
							this.PsnOnlineId = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 184U)
				{
					if (num <= 152U)
					{
						if (num <= 138U)
						{
							if (num == 130U)
							{
								this.PsnAccountId = input.ReadString();
								continue;
							}
							if (num == 138U)
							{
								this.FightDataDigest = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 144U)
							{
								this.PsnSocialState = input.ReadInt32();
								continue;
							}
							if (num == 152U)
							{
								this.FsmVersion = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 168U)
					{
						if (num == 160U)
						{
							this.ConfirmQuestResource = input.ReadBool();
							continue;
						}
						if (num == 168U)
						{
							this.QuestResourceState = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 176U)
						{
							this.IsLowMemoryPlatform = input.ReadBool();
							continue;
						}
						if (num == 184U)
						{
							this.SwitchState = (ESceneBlockSwithState)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 210U)
				{
					if (num <= 194U)
					{
						if (num == 192U || num == 194U)
						{
							this.downloadResourceQuestId_.AddEntriesFrom(ref input, LoginRequest._repeated_downloadResourceQuestId_codec);
							continue;
						}
					}
					else
					{
						if (num == 202U)
						{
							this.XboxUserId = input.ReadString();
							continue;
						}
						if (num == 210U)
						{
							this.XboxOnlineId = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 224U)
				{
					if (num == 218U)
					{
						this.XboxAccountId = input.ReadString();
						continue;
					}
					if (num == 224U)
					{
						this.XboxSocialState = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 242U)
					{
						this.XstsToken = input.ReadString();
						continue;
					}
					if (num == 250U)
					{
						this.GradedResourceVersion = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005817 RID: 22551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005818 RID: 22552
		public const int IdFieldNumber = 1;

		// Token: 0x04005819 RID: 22553
		private int id_;

		// Token: 0x0400581A RID: 22554
		public const int AccountFieldNumber = 2;

		// Token: 0x0400581B RID: 22555
		private string account_ = "";

		// Token: 0x0400581C RID: 22556
		public const int LoginTraceIdFieldNumber = 3;

		// Token: 0x0400581D RID: 22557
		private string loginTraceId_ = "";

		// Token: 0x0400581E RID: 22558
		public const int TokenFieldNumber = 4;

		// Token: 0x0400581F RID: 22559
		private string token_ = "";

		// Token: 0x04005820 RID: 22560
		public const int AppVersionFieldNumber = 5;

		// Token: 0x04005821 RID: 22561
		private string appVersion_ = "";

		// Token: 0x04005822 RID: 22562
		public const int LauncherVersionFieldNumber = 6;

		// Token: 0x04005823 RID: 22563
		private string launcherVersion_ = "";

		// Token: 0x04005824 RID: 22564
		public const int ResourceVersionFieldNumber = 7;

		// Token: 0x04005825 RID: 22565
		private string resourceVersion_ = "";

		// Token: 0x04005826 RID: 22566
		public const int ClientBasicInfoFieldNumber = 8;

		// Token: 0x04005827 RID: 22567
		private ClientBasicInfo clientBasicInfo_;

		// Token: 0x04005828 RID: 22568
		public const int DevLoginCheckDataFieldNumber = 9;

		// Token: 0x04005829 RID: 22569
		private DevLoginCheckData devLoginCheckData_;

		// Token: 0x0400582A RID: 22570
		public const int PublicResourceVersionInfoFieldNumber = 10;

		// Token: 0x0400582B RID: 22571
		private PublicResourceVersionInfo publicResourceVersionInfo_;

		// Token: 0x0400582C RID: 22572
		public const int AceBlackProductAccountInfoFieldNumber = 11;

		// Token: 0x0400582D RID: 22573
		private AceBlackProductAccountInfo aceBlackProductAccountInfo_;

		// Token: 0x0400582E RID: 22574
		public const int PushIsOpenFieldNumber = 12;

		// Token: 0x0400582F RID: 22575
		private bool pushIsOpen_;

		// Token: 0x04005830 RID: 22576
		public const int GeTuiDeviceIdFieldNumber = 13;

		// Token: 0x04005831 RID: 22577
		private string geTuiDeviceId_ = "";

		// Token: 0x04005832 RID: 22578
		public const int PsnUserIdFieldNumber = 14;

		// Token: 0x04005833 RID: 22579
		private string psnUserId_ = "";

		// Token: 0x04005834 RID: 22580
		public const int PsnOnlineIdFieldNumber = 15;

		// Token: 0x04005835 RID: 22581
		private string psnOnlineId_ = "";

		// Token: 0x04005836 RID: 22582
		public const int PsnAccountIdFieldNumber = 16;

		// Token: 0x04005837 RID: 22583
		private string psnAccountId_ = "";

		// Token: 0x04005838 RID: 22584
		public const int FightDataDigestFieldNumber = 17;

		// Token: 0x04005839 RID: 22585
		private string fightDataDigest_ = "";

		// Token: 0x0400583A RID: 22586
		public const int PsnSocialStateFieldNumber = 18;

		// Token: 0x0400583B RID: 22587
		private int psnSocialState_;

		// Token: 0x0400583C RID: 22588
		public const int FsmVersionFieldNumber = 19;

		// Token: 0x0400583D RID: 22589
		private int fsmVersion_;

		// Token: 0x0400583E RID: 22590
		public const int ConfirmQuestResourceFieldNumber = 20;

		// Token: 0x0400583F RID: 22591
		private bool confirmQuestResource_;

		// Token: 0x04005840 RID: 22592
		public const int QuestResourceStateFieldNumber = 21;

		// Token: 0x04005841 RID: 22593
		private int questResourceState_;

		// Token: 0x04005842 RID: 22594
		public const int IsLowMemoryPlatformFieldNumber = 22;

		// Token: 0x04005843 RID: 22595
		private bool isLowMemoryPlatform_;

		// Token: 0x04005844 RID: 22596
		public const int SwitchStateFieldNumber = 23;

		// Token: 0x04005845 RID: 22597
		private ESceneBlockSwithState switchState_;

		// Token: 0x04005846 RID: 22598
		public const int DownloadResourceQuestIdFieldNumber = 24;

		// Token: 0x04005847 RID: 22599
		private static readonly FieldCodec<int> _repeated_downloadResourceQuestId_codec = FieldCodec.ForInt32(194U);

		// Token: 0x04005848 RID: 22600
		private readonly RepeatedField<int> downloadResourceQuestId_ = new RepeatedField<int>();

		// Token: 0x04005849 RID: 22601
		public const int XboxUserIdFieldNumber = 25;

		// Token: 0x0400584A RID: 22602
		private string xboxUserId_ = "";

		// Token: 0x0400584B RID: 22603
		public const int XboxOnlineIdFieldNumber = 26;

		// Token: 0x0400584C RID: 22604
		private string xboxOnlineId_ = "";

		// Token: 0x0400584D RID: 22605
		public const int XboxAccountIdFieldNumber = 27;

		// Token: 0x0400584E RID: 22606
		private string xboxAccountId_ = "";

		// Token: 0x0400584F RID: 22607
		public const int XboxSocialStateFieldNumber = 28;

		// Token: 0x04005850 RID: 22608
		private int xboxSocialState_;

		// Token: 0x04005851 RID: 22609
		public const int XstsTokenFieldNumber = 30;

		// Token: 0x04005852 RID: 22610
		private string xstsToken_ = "";

		// Token: 0x04005853 RID: 22611
		public const int GradedResourceVersionFieldNumber = 31;

		// Token: 0x04005854 RID: 22612
		private string gradedResourceVersion_ = "";
	}
}
