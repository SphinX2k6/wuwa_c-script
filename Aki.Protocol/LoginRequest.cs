using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094B RID: 2379
	[NetMessage(EMessageId.LoginRequest)]
	public sealed class LoginRequest : IMessage<LoginRequest>, IMessage, IEquatable<LoginRequest>, IDeepCloneable<LoginRequest>, IBufferMessage
	{
		// Token: 0x0600D17C RID: 53628 RVA: 0x001ED050 File Offset: 0x001EB250
		[NullableContext(1)]
		public static LoginRequest Create()
		{
			return new LoginRequest();
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x0600D17D RID: 53629 RVA: 0x001ED057 File Offset: 0x001EB257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x0600D17E RID: 53630 RVA: 0x001ED05A File Offset: 0x001EB25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginRequest.Descriptor;
			}
		}

		// Token: 0x0600D17F RID: 53631 RVA: 0x001ED064 File Offset: 0x001EB264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginRequest()
		{
		}

		// Token: 0x0600D180 RID: 53632 RVA: 0x001ED128 File Offset: 0x001EB328
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
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D181 RID: 53633 RVA: 0x001ED2ED File Offset: 0x001EB4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginRequest Clone()
		{
			return new LoginRequest(this);
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x0600D182 RID: 53634 RVA: 0x001ED2F5 File Offset: 0x001EB4F5
		// (set) Token: 0x0600D183 RID: 53635 RVA: 0x001ED2FD File Offset: 0x001EB4FD
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

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x0600D184 RID: 53636 RVA: 0x001ED306 File Offset: 0x001EB506
		// (set) Token: 0x0600D185 RID: 53637 RVA: 0x001ED30E File Offset: 0x001EB50E
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

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x0600D186 RID: 53638 RVA: 0x001ED321 File Offset: 0x001EB521
		// (set) Token: 0x0600D187 RID: 53639 RVA: 0x001ED329 File Offset: 0x001EB529
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

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x0600D188 RID: 53640 RVA: 0x001ED33C File Offset: 0x001EB53C
		// (set) Token: 0x0600D189 RID: 53641 RVA: 0x001ED344 File Offset: 0x001EB544
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

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x0600D18A RID: 53642 RVA: 0x001ED357 File Offset: 0x001EB557
		// (set) Token: 0x0600D18B RID: 53643 RVA: 0x001ED35F File Offset: 0x001EB55F
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

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x0600D18C RID: 53644 RVA: 0x001ED372 File Offset: 0x001EB572
		// (set) Token: 0x0600D18D RID: 53645 RVA: 0x001ED37A File Offset: 0x001EB57A
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

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x0600D18E RID: 53646 RVA: 0x001ED38D File Offset: 0x001EB58D
		// (set) Token: 0x0600D18F RID: 53647 RVA: 0x001ED395 File Offset: 0x001EB595
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

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x0600D190 RID: 53648 RVA: 0x001ED3A8 File Offset: 0x001EB5A8
		// (set) Token: 0x0600D191 RID: 53649 RVA: 0x001ED3B0 File Offset: 0x001EB5B0
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

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x0600D192 RID: 53650 RVA: 0x001ED3B9 File Offset: 0x001EB5B9
		// (set) Token: 0x0600D193 RID: 53651 RVA: 0x001ED3C1 File Offset: 0x001EB5C1
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

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x0600D194 RID: 53652 RVA: 0x001ED3CA File Offset: 0x001EB5CA
		// (set) Token: 0x0600D195 RID: 53653 RVA: 0x001ED3D2 File Offset: 0x001EB5D2
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

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x0600D196 RID: 53654 RVA: 0x001ED3DB File Offset: 0x001EB5DB
		// (set) Token: 0x0600D197 RID: 53655 RVA: 0x001ED3E3 File Offset: 0x001EB5E3
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

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x0600D198 RID: 53656 RVA: 0x001ED3EC File Offset: 0x001EB5EC
		// (set) Token: 0x0600D199 RID: 53657 RVA: 0x001ED3F4 File Offset: 0x001EB5F4
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

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x0600D19A RID: 53658 RVA: 0x001ED3FD File Offset: 0x001EB5FD
		// (set) Token: 0x0600D19B RID: 53659 RVA: 0x001ED405 File Offset: 0x001EB605
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

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x0600D19C RID: 53660 RVA: 0x001ED418 File Offset: 0x001EB618
		// (set) Token: 0x0600D19D RID: 53661 RVA: 0x001ED420 File Offset: 0x001EB620
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

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x0600D19E RID: 53662 RVA: 0x001ED433 File Offset: 0x001EB633
		// (set) Token: 0x0600D19F RID: 53663 RVA: 0x001ED43B File Offset: 0x001EB63B
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

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600D1A0 RID: 53664 RVA: 0x001ED44E File Offset: 0x001EB64E
		// (set) Token: 0x0600D1A1 RID: 53665 RVA: 0x001ED456 File Offset: 0x001EB656
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

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600D1A2 RID: 53666 RVA: 0x001ED469 File Offset: 0x001EB669
		// (set) Token: 0x0600D1A3 RID: 53667 RVA: 0x001ED471 File Offset: 0x001EB671
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

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x0600D1A4 RID: 53668 RVA: 0x001ED484 File Offset: 0x001EB684
		// (set) Token: 0x0600D1A5 RID: 53669 RVA: 0x001ED48C File Offset: 0x001EB68C
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

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x0600D1A6 RID: 53670 RVA: 0x001ED495 File Offset: 0x001EB695
		// (set) Token: 0x0600D1A7 RID: 53671 RVA: 0x001ED49D File Offset: 0x001EB69D
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

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x0600D1A8 RID: 53672 RVA: 0x001ED4A6 File Offset: 0x001EB6A6
		// (set) Token: 0x0600D1A9 RID: 53673 RVA: 0x001ED4AE File Offset: 0x001EB6AE
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

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x0600D1AA RID: 53674 RVA: 0x001ED4B7 File Offset: 0x001EB6B7
		// (set) Token: 0x0600D1AB RID: 53675 RVA: 0x001ED4BF File Offset: 0x001EB6BF
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

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x0600D1AC RID: 53676 RVA: 0x001ED4C8 File Offset: 0x001EB6C8
		// (set) Token: 0x0600D1AD RID: 53677 RVA: 0x001ED4D0 File Offset: 0x001EB6D0
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

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x0600D1AE RID: 53678 RVA: 0x001ED4D9 File Offset: 0x001EB6D9
		// (set) Token: 0x0600D1AF RID: 53679 RVA: 0x001ED4E1 File Offset: 0x001EB6E1
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

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x0600D1B0 RID: 53680 RVA: 0x001ED4EA File Offset: 0x001EB6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadResourceQuestId
		{
			get
			{
				return this.downloadResourceQuestId_;
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x0600D1B1 RID: 53681 RVA: 0x001ED4F2 File Offset: 0x001EB6F2
		// (set) Token: 0x0600D1B2 RID: 53682 RVA: 0x001ED4FA File Offset: 0x001EB6FA
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

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0600D1B3 RID: 53683 RVA: 0x001ED50D File Offset: 0x001EB70D
		// (set) Token: 0x0600D1B4 RID: 53684 RVA: 0x001ED515 File Offset: 0x001EB715
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

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600D1B5 RID: 53685 RVA: 0x001ED528 File Offset: 0x001EB728
		// (set) Token: 0x0600D1B6 RID: 53686 RVA: 0x001ED530 File Offset: 0x001EB730
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

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0600D1B7 RID: 53687 RVA: 0x001ED543 File Offset: 0x001EB743
		// (set) Token: 0x0600D1B8 RID: 53688 RVA: 0x001ED54B File Offset: 0x001EB74B
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

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x0600D1B9 RID: 53689 RVA: 0x001ED554 File Offset: 0x001EB754
		// (set) Token: 0x0600D1BA RID: 53690 RVA: 0x001ED55C File Offset: 0x001EB75C
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

		// Token: 0x0600D1BB RID: 53691 RVA: 0x001ED56F File Offset: 0x001EB76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginRequest);
		}

		// Token: 0x0600D1BC RID: 53692 RVA: 0x001ED580 File Offset: 0x001EB780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoginRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Account != other.Account) && !(this.LoginTraceId != other.LoginTraceId) && !(this.Token != other.Token) && !(this.AppVersion != other.AppVersion) && !(this.LauncherVersion != other.LauncherVersion) && !(this.ResourceVersion != other.ResourceVersion) && object.Equals(this.ClientBasicInfo, other.ClientBasicInfo) && object.Equals(this.DevLoginCheckData, other.DevLoginCheckData) && object.Equals(this.PublicResourceVersionInfo, other.PublicResourceVersionInfo) && object.Equals(this.AceBlackProductAccountInfo, other.AceBlackProductAccountInfo) && this.PushIsOpen == other.PushIsOpen && !(this.GeTuiDeviceId != other.GeTuiDeviceId) && !(this.PsnUserId != other.PsnUserId) && !(this.PsnOnlineId != other.PsnOnlineId) && !(this.PsnAccountId != other.PsnAccountId) && !(this.FightDataDigest != other.FightDataDigest) && this.PsnSocialState == other.PsnSocialState && this.FsmVersion == other.FsmVersion && this.ConfirmQuestResource == other.ConfirmQuestResource && this.QuestResourceState == other.QuestResourceState && this.IsLowMemoryPlatform == other.IsLowMemoryPlatform && this.SwitchState == other.SwitchState && this.downloadResourceQuestId_.Equals(other.downloadResourceQuestId_) && !(this.XboxUserId != other.XboxUserId) && !(this.XboxOnlineId != other.XboxOnlineId) && !(this.XboxAccountId != other.XboxAccountId) && this.XboxSocialState == other.XboxSocialState && !(this.XstsToken != other.XstsToken) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1BD RID: 53693 RVA: 0x001ED7E0 File Offset: 0x001EB9E0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D1BE RID: 53694 RVA: 0x001EDAE8 File Offset: 0x001EBCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D1BF RID: 53695 RVA: 0x001EDAF5 File Offset: 0x001EBCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1C0 RID: 53696 RVA: 0x001EDB00 File Offset: 0x001EBD00
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1C1 RID: 53697 RVA: 0x001EDEC0 File Offset: 0x001EC0C0
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1C2 RID: 53698 RVA: 0x001EE1C0 File Offset: 0x001EC3C0
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1C3 RID: 53699 RVA: 0x001EE4D4 File Offset: 0x001EC6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1C4 RID: 53700 RVA: 0x001EE4E0 File Offset: 0x001EC6E0
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
				else if (num <= 176U)
				{
					if (num <= 144U)
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
						if (num == 144U)
						{
							this.PsnSocialState = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 160U)
					{
						if (num == 152U)
						{
							this.FsmVersion = input.ReadInt32();
							continue;
						}
						if (num == 160U)
						{
							this.ConfirmQuestResource = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 168U)
						{
							this.QuestResourceState = input.ReadInt32();
							continue;
						}
						if (num == 176U)
						{
							this.IsLowMemoryPlatform = input.ReadBool();
							continue;
						}
					}
				}
				else
				{
					if (num <= 202U)
					{
						if (num <= 192U)
						{
							if (num == 184U)
							{
								this.SwitchState = (ESceneBlockSwithState)input.ReadEnum();
								continue;
							}
							if (num != 192U)
							{
								goto IL_1B3;
							}
						}
						else if (num != 194U)
						{
							if (num != 202U)
							{
								goto IL_1B3;
							}
							this.XboxUserId = input.ReadString();
							continue;
						}
						this.downloadResourceQuestId_.AddEntriesFrom(ref input, LoginRequest._repeated_downloadResourceQuestId_codec);
						continue;
					}
					if (num <= 218U)
					{
						if (num == 210U)
						{
							this.XboxOnlineId = input.ReadString();
							continue;
						}
						if (num == 218U)
						{
							this.XboxAccountId = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 224U)
						{
							this.XboxSocialState = input.ReadInt32();
							continue;
						}
						if (num == 242U)
						{
							this.XstsToken = input.ReadString();
							continue;
						}
					}
				}
				IL_1B3:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005810 RID: 22544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005811 RID: 22545
		public const int IdFieldNumber = 1;

		// Token: 0x04005812 RID: 22546
		private int id_;

		// Token: 0x04005813 RID: 22547
		public const int AccountFieldNumber = 2;

		// Token: 0x04005814 RID: 22548
		private string account_ = "";

		// Token: 0x04005815 RID: 22549
		public const int LoginTraceIdFieldNumber = 3;

		// Token: 0x04005816 RID: 22550
		private string loginTraceId_ = "";

		// Token: 0x04005817 RID: 22551
		public const int TokenFieldNumber = 4;

		// Token: 0x04005818 RID: 22552
		private string token_ = "";

		// Token: 0x04005819 RID: 22553
		public const int AppVersionFieldNumber = 5;

		// Token: 0x0400581A RID: 22554
		private string appVersion_ = "";

		// Token: 0x0400581B RID: 22555
		public const int LauncherVersionFieldNumber = 6;

		// Token: 0x0400581C RID: 22556
		private string launcherVersion_ = "";

		// Token: 0x0400581D RID: 22557
		public const int ResourceVersionFieldNumber = 7;

		// Token: 0x0400581E RID: 22558
		private string resourceVersion_ = "";

		// Token: 0x0400581F RID: 22559
		public const int ClientBasicInfoFieldNumber = 8;

		// Token: 0x04005820 RID: 22560
		private ClientBasicInfo clientBasicInfo_;

		// Token: 0x04005821 RID: 22561
		public const int DevLoginCheckDataFieldNumber = 9;

		// Token: 0x04005822 RID: 22562
		private DevLoginCheckData devLoginCheckData_;

		// Token: 0x04005823 RID: 22563
		public const int PublicResourceVersionInfoFieldNumber = 10;

		// Token: 0x04005824 RID: 22564
		private PublicResourceVersionInfo publicResourceVersionInfo_;

		// Token: 0x04005825 RID: 22565
		public const int AceBlackProductAccountInfoFieldNumber = 11;

		// Token: 0x04005826 RID: 22566
		private AceBlackProductAccountInfo aceBlackProductAccountInfo_;

		// Token: 0x04005827 RID: 22567
		public const int PushIsOpenFieldNumber = 12;

		// Token: 0x04005828 RID: 22568
		private bool pushIsOpen_;

		// Token: 0x04005829 RID: 22569
		public const int GeTuiDeviceIdFieldNumber = 13;

		// Token: 0x0400582A RID: 22570
		private string geTuiDeviceId_ = "";

		// Token: 0x0400582B RID: 22571
		public const int PsnUserIdFieldNumber = 14;

		// Token: 0x0400582C RID: 22572
		private string psnUserId_ = "";

		// Token: 0x0400582D RID: 22573
		public const int PsnOnlineIdFieldNumber = 15;

		// Token: 0x0400582E RID: 22574
		private string psnOnlineId_ = "";

		// Token: 0x0400582F RID: 22575
		public const int PsnAccountIdFieldNumber = 16;

		// Token: 0x04005830 RID: 22576
		private string psnAccountId_ = "";

		// Token: 0x04005831 RID: 22577
		public const int FightDataDigestFieldNumber = 17;

		// Token: 0x04005832 RID: 22578
		private string fightDataDigest_ = "";

		// Token: 0x04005833 RID: 22579
		public const int PsnSocialStateFieldNumber = 18;

		// Token: 0x04005834 RID: 22580
		private int psnSocialState_;

		// Token: 0x04005835 RID: 22581
		public const int FsmVersionFieldNumber = 19;

		// Token: 0x04005836 RID: 22582
		private int fsmVersion_;

		// Token: 0x04005837 RID: 22583
		public const int ConfirmQuestResourceFieldNumber = 20;

		// Token: 0x04005838 RID: 22584
		private bool confirmQuestResource_;

		// Token: 0x04005839 RID: 22585
		public const int QuestResourceStateFieldNumber = 21;

		// Token: 0x0400583A RID: 22586
		private int questResourceState_;

		// Token: 0x0400583B RID: 22587
		public const int IsLowMemoryPlatformFieldNumber = 22;

		// Token: 0x0400583C RID: 22588
		private bool isLowMemoryPlatform_;

		// Token: 0x0400583D RID: 22589
		public const int SwitchStateFieldNumber = 23;

		// Token: 0x0400583E RID: 22590
		private ESceneBlockSwithState switchState_;

		// Token: 0x0400583F RID: 22591
		public const int DownloadResourceQuestIdFieldNumber = 24;

		// Token: 0x04005840 RID: 22592
		private static readonly FieldCodec<int> _repeated_downloadResourceQuestId_codec = FieldCodec.ForInt32(194U);

		// Token: 0x04005841 RID: 22593
		private readonly RepeatedField<int> downloadResourceQuestId_ = new RepeatedField<int>();

		// Token: 0x04005842 RID: 22594
		public const int XboxUserIdFieldNumber = 25;

		// Token: 0x04005843 RID: 22595
		private string xboxUserId_ = "";

		// Token: 0x04005844 RID: 22596
		public const int XboxOnlineIdFieldNumber = 26;

		// Token: 0x04005845 RID: 22597
		private string xboxOnlineId_ = "";

		// Token: 0x04005846 RID: 22598
		public const int XboxAccountIdFieldNumber = 27;

		// Token: 0x04005847 RID: 22599
		private string xboxAccountId_ = "";

		// Token: 0x04005848 RID: 22600
		public const int XboxSocialStateFieldNumber = 28;

		// Token: 0x04005849 RID: 22601
		private int xboxSocialState_;

		// Token: 0x0400584A RID: 22602
		public const int XstsTokenFieldNumber = 30;

		// Token: 0x0400584B RID: 22603
		private string xstsToken_ = "";
	}
}
