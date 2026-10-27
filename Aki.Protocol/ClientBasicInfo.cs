using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000297 RID: 663
	public sealed class ClientBasicInfo : IMessage<ClientBasicInfo>, IMessage, IEquatable<ClientBasicInfo>, IDeepCloneable<ClientBasicInfo>, IBufferMessage
	{
		// Token: 0x0600450E RID: 17678 RVA: 0x000A9644 File Offset: 0x000A7844
		[NullableContext(1)]
		public static ClientBasicInfo Create()
		{
			return new ClientBasicInfo();
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x000A964B File Offset: 0x000A784B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06004510 RID: 17680 RVA: 0x000A964E File Offset: 0x000A784E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientBasicInfo.Descriptor;
			}
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x000A9658 File Offset: 0x000A7858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfo()
		{
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x000A9710 File Offset: 0x000A7910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfo(ClientBasicInfo other) : this()
		{
			this.platform_ = other.platform_;
			this.deviceId_ = other.deviceId_;
			this.netStatus_ = other.netStatus_;
			this.model_ = other.model_;
			this.cPU_ = other.cPU_;
			this.deviceLevel_ = other.deviceLevel_;
			this.language_ = other.language_;
			this.distinctId_ = other.distinctId_;
			this.macAddress_ = other.macAddress_;
			this.pkgId_ = other.pkgId_;
			this.serverTag_ = other.serverTag_;
			this.systemLanguage_ = other.systemLanguage_;
			this.oS_ = other.oS_;
			this.deviceId2ShuShu_ = other.deviceId2ShuShu_;
			this.screenHeight_ = other.screenHeight_;
			this.screenWidth_ = other.screenWidth_;
			this.deviceInfo_ = other.deviceInfo_;
			this.driverDate_ = other.driverDate_;
			this.clientVersion_ = other.clientVersion_;
			this.oSVersion_ = other.oSVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x000A9824 File Offset: 0x000A7A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfo Clone()
		{
			return new ClientBasicInfo(this);
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06004514 RID: 17684 RVA: 0x000A982C File Offset: 0x000A7A2C
		// (set) Token: 0x06004515 RID: 17685 RVA: 0x000A9834 File Offset: 0x000A7A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Platform
		{
			get
			{
				return this.platform_;
			}
			set
			{
				this.platform_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06004516 RID: 17686 RVA: 0x000A9847 File Offset: 0x000A7A47
		// (set) Token: 0x06004517 RID: 17687 RVA: 0x000A984F File Offset: 0x000A7A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceId
		{
			get
			{
				return this.deviceId_;
			}
			set
			{
				this.deviceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x000A9862 File Offset: 0x000A7A62
		// (set) Token: 0x06004519 RID: 17689 RVA: 0x000A986A File Offset: 0x000A7A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetStatusType NetStatus
		{
			get
			{
				return this.netStatus_;
			}
			set
			{
				this.netStatus_ = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x000A9873 File Offset: 0x000A7A73
		// (set) Token: 0x0600451B RID: 17691 RVA: 0x000A987B File Offset: 0x000A7A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Model
		{
			get
			{
				return this.model_;
			}
			set
			{
				this.model_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x000A988E File Offset: 0x000A7A8E
		// (set) Token: 0x0600451D RID: 17693 RVA: 0x000A9896 File Offset: 0x000A7A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CPU
		{
			get
			{
				return this.cPU_;
			}
			set
			{
				this.cPU_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x0600451E RID: 17694 RVA: 0x000A98A9 File Offset: 0x000A7AA9
		// (set) Token: 0x0600451F RID: 17695 RVA: 0x000A98B1 File Offset: 0x000A7AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDeviceLevel DeviceLevel
		{
			get
			{
				return this.deviceLevel_;
			}
			set
			{
				this.deviceLevel_ = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x000A98BA File Offset: 0x000A7ABA
		// (set) Token: 0x06004521 RID: 17697 RVA: 0x000A98C2 File Offset: 0x000A7AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Language
		{
			get
			{
				return this.language_;
			}
			set
			{
				this.language_ = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x000A98CB File Offset: 0x000A7ACB
		// (set) Token: 0x06004523 RID: 17699 RVA: 0x000A98D3 File Offset: 0x000A7AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DistinctId
		{
			get
			{
				return this.distinctId_;
			}
			set
			{
				this.distinctId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06004524 RID: 17700 RVA: 0x000A98E6 File Offset: 0x000A7AE6
		// (set) Token: 0x06004525 RID: 17701 RVA: 0x000A98EE File Offset: 0x000A7AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MacAddress
		{
			get
			{
				return this.macAddress_;
			}
			set
			{
				this.macAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06004526 RID: 17702 RVA: 0x000A9901 File Offset: 0x000A7B01
		// (set) Token: 0x06004527 RID: 17703 RVA: 0x000A9909 File Offset: 0x000A7B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PkgId
		{
			get
			{
				return this.pkgId_;
			}
			set
			{
				this.pkgId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x000A991C File Offset: 0x000A7B1C
		// (set) Token: 0x06004529 RID: 17705 RVA: 0x000A9924 File Offset: 0x000A7B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ServerTag
		{
			get
			{
				return this.serverTag_;
			}
			set
			{
				this.serverTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600452A RID: 17706 RVA: 0x000A9937 File Offset: 0x000A7B37
		// (set) Token: 0x0600452B RID: 17707 RVA: 0x000A993F File Offset: 0x000A7B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SystemLanguage
		{
			get
			{
				return this.systemLanguage_;
			}
			set
			{
				this.systemLanguage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x000A9952 File Offset: 0x000A7B52
		// (set) Token: 0x0600452D RID: 17709 RVA: 0x000A995A File Offset: 0x000A7B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OS
		{
			get
			{
				return this.oS_;
			}
			set
			{
				this.oS_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x0600452E RID: 17710 RVA: 0x000A996D File Offset: 0x000A7B6D
		// (set) Token: 0x0600452F RID: 17711 RVA: 0x000A9975 File Offset: 0x000A7B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceId2ShuShu
		{
			get
			{
				return this.deviceId2ShuShu_;
			}
			set
			{
				this.deviceId2ShuShu_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06004530 RID: 17712 RVA: 0x000A9988 File Offset: 0x000A7B88
		// (set) Token: 0x06004531 RID: 17713 RVA: 0x000A9990 File Offset: 0x000A7B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScreenHeight
		{
			get
			{
				return this.screenHeight_;
			}
			set
			{
				this.screenHeight_ = value;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06004532 RID: 17714 RVA: 0x000A9999 File Offset: 0x000A7B99
		// (set) Token: 0x06004533 RID: 17715 RVA: 0x000A99A1 File Offset: 0x000A7BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScreenWidth
		{
			get
			{
				return this.screenWidth_;
			}
			set
			{
				this.screenWidth_ = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06004534 RID: 17716 RVA: 0x000A99AA File Offset: 0x000A7BAA
		// (set) Token: 0x06004535 RID: 17717 RVA: 0x000A99B2 File Offset: 0x000A7BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceInfo
		{
			get
			{
				return this.deviceInfo_;
			}
			set
			{
				this.deviceInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x000A99C5 File Offset: 0x000A7BC5
		// (set) Token: 0x06004537 RID: 17719 RVA: 0x000A99CD File Offset: 0x000A7BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DriverDate
		{
			get
			{
				return this.driverDate_;
			}
			set
			{
				this.driverDate_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x000A99E0 File Offset: 0x000A7BE0
		// (set) Token: 0x06004539 RID: 17721 RVA: 0x000A99E8 File Offset: 0x000A7BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientVersion
		{
			get
			{
				return this.clientVersion_;
			}
			set
			{
				this.clientVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x000A99FB File Offset: 0x000A7BFB
		// (set) Token: 0x0600453B RID: 17723 RVA: 0x000A9A03 File Offset: 0x000A7C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OSVersion
		{
			get
			{
				return this.oSVersion_;
			}
			set
			{
				this.oSVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x000A9A16 File Offset: 0x000A7C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientBasicInfo);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x000A9A24 File Offset: 0x000A7C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientBasicInfo other)
		{
			return other != null && (other == this || (!(this.Platform != other.Platform) && !(this.DeviceId != other.DeviceId) && this.NetStatus == other.NetStatus && !(this.Model != other.Model) && !(this.CPU != other.CPU) && this.DeviceLevel == other.DeviceLevel && this.Language == other.Language && !(this.DistinctId != other.DistinctId) && !(this.MacAddress != other.MacAddress) && !(this.PkgId != other.PkgId) && !(this.ServerTag != other.ServerTag) && !(this.SystemLanguage != other.SystemLanguage) && !(this.OS != other.OS) && !(this.DeviceId2ShuShu != other.DeviceId2ShuShu) && this.ScreenHeight == other.ScreenHeight && this.ScreenWidth == other.ScreenWidth && !(this.DeviceInfo != other.DeviceInfo) && !(this.DriverDate != other.DriverDate) && !(this.ClientVersion != other.ClientVersion) && !(this.OSVersion != other.OSVersion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x000A9BD8 File Offset: 0x000A7DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Platform.Length != 0)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.DeviceId.Length != 0)
			{
				num ^= this.DeviceId.GetHashCode();
			}
			if (this.NetStatus != NetStatusType.Wifi)
			{
				num ^= this.NetStatus.GetHashCode();
			}
			if (this.Model.Length != 0)
			{
				num ^= this.Model.GetHashCode();
			}
			if (this.CPU.Length != 0)
			{
				num ^= this.CPU.GetHashCode();
			}
			if (this.DeviceLevel != ClientDeviceLevel.Low)
			{
				num ^= this.DeviceLevel.GetHashCode();
			}
			if (this.Language != 0)
			{
				num ^= this.Language.GetHashCode();
			}
			if (this.DistinctId.Length != 0)
			{
				num ^= this.DistinctId.GetHashCode();
			}
			if (this.MacAddress.Length != 0)
			{
				num ^= this.MacAddress.GetHashCode();
			}
			if (this.PkgId.Length != 0)
			{
				num ^= this.PkgId.GetHashCode();
			}
			if (this.ServerTag.Length != 0)
			{
				num ^= this.ServerTag.GetHashCode();
			}
			if (this.SystemLanguage.Length != 0)
			{
				num ^= this.SystemLanguage.GetHashCode();
			}
			if (this.OS.Length != 0)
			{
				num ^= this.OS.GetHashCode();
			}
			if (this.DeviceId2ShuShu.Length != 0)
			{
				num ^= this.DeviceId2ShuShu.GetHashCode();
			}
			if (this.ScreenHeight != 0)
			{
				num ^= this.ScreenHeight.GetHashCode();
			}
			if (this.ScreenWidth != 0)
			{
				num ^= this.ScreenWidth.GetHashCode();
			}
			if (this.DeviceInfo.Length != 0)
			{
				num ^= this.DeviceInfo.GetHashCode();
			}
			if (this.DriverDate.Length != 0)
			{
				num ^= this.DriverDate.GetHashCode();
			}
			if (this.ClientVersion.Length != 0)
			{
				num ^= this.ClientVersion.GetHashCode();
			}
			if (this.OSVersion.Length != 0)
			{
				num ^= this.OSVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x000A9E1C File Offset: 0x000A801C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x000A9E29 File Offset: 0x000A8029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x000A9E34 File Offset: 0x000A8034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Platform.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Platform);
			}
			if (this.DeviceId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.DeviceId);
			}
			if (this.NetStatus != NetStatusType.Wifi)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.NetStatus);
			}
			if (this.Model.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Model);
			}
			if (this.CPU.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.CPU);
			}
			if (this.DeviceLevel != ClientDeviceLevel.Low)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.DeviceLevel);
			}
			if (this.Language != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Language);
			}
			if (this.DistinctId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.DistinctId);
			}
			if (this.MacAddress.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.MacAddress);
			}
			if (this.PkgId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.PkgId);
			}
			if (this.ServerTag.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ServerTag);
			}
			if (this.SystemLanguage.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.SystemLanguage);
			}
			if (this.OS.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.OS);
			}
			if (this.DeviceId2ShuShu.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.DeviceId2ShuShu);
			}
			if (this.ScreenHeight != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ScreenHeight);
			}
			if (this.ScreenWidth != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.ScreenWidth);
			}
			if (this.DeviceInfo.Length != 0)
			{
				output.WriteRawTag(138, 1);
				output.WriteString(this.DeviceInfo);
			}
			if (this.DriverDate.Length != 0)
			{
				output.WriteRawTag(146, 1);
				output.WriteString(this.DriverDate);
			}
			if (this.ClientVersion.Length != 0)
			{
				output.WriteRawTag(154, 1);
				output.WriteString(this.ClientVersion);
			}
			if (this.OSVersion.Length != 0)
			{
				output.WriteRawTag(162, 1);
				output.WriteString(this.OSVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x000AA0E4 File Offset: 0x000A82E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Platform.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Platform);
			}
			if (this.DeviceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DeviceId);
			}
			if (this.NetStatus != NetStatusType.Wifi)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NetStatus);
			}
			if (this.Model.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Model);
			}
			if (this.CPU.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CPU);
			}
			if (this.DeviceLevel != ClientDeviceLevel.Low)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DeviceLevel);
			}
			if (this.Language != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Language);
			}
			if (this.DistinctId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DistinctId);
			}
			if (this.MacAddress.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MacAddress);
			}
			if (this.PkgId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PkgId);
			}
			if (this.ServerTag.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerTag);
			}
			if (this.SystemLanguage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SystemLanguage);
			}
			if (this.OS.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OS);
			}
			if (this.DeviceId2ShuShu.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DeviceId2ShuShu);
			}
			if (this.ScreenHeight != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScreenHeight);
			}
			if (this.ScreenWidth != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ScreenWidth);
			}
			if (this.DeviceInfo.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.DeviceInfo);
			}
			if (this.DriverDate.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.DriverDate);
			}
			if (this.ClientVersion.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ClientVersion);
			}
			if (this.OSVersion.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.OSVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x000AA338 File Offset: 0x000A8538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientBasicInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Platform.Length != 0)
			{
				this.Platform = other.Platform;
			}
			if (other.DeviceId.Length != 0)
			{
				this.DeviceId = other.DeviceId;
			}
			if (other.NetStatus != NetStatusType.Wifi)
			{
				this.NetStatus = other.NetStatus;
			}
			if (other.Model.Length != 0)
			{
				this.Model = other.Model;
			}
			if (other.CPU.Length != 0)
			{
				this.CPU = other.CPU;
			}
			if (other.DeviceLevel != ClientDeviceLevel.Low)
			{
				this.DeviceLevel = other.DeviceLevel;
			}
			if (other.Language != 0)
			{
				this.Language = other.Language;
			}
			if (other.DistinctId.Length != 0)
			{
				this.DistinctId = other.DistinctId;
			}
			if (other.MacAddress.Length != 0)
			{
				this.MacAddress = other.MacAddress;
			}
			if (other.PkgId.Length != 0)
			{
				this.PkgId = other.PkgId;
			}
			if (other.ServerTag.Length != 0)
			{
				this.ServerTag = other.ServerTag;
			}
			if (other.SystemLanguage.Length != 0)
			{
				this.SystemLanguage = other.SystemLanguage;
			}
			if (other.OS.Length != 0)
			{
				this.OS = other.OS;
			}
			if (other.DeviceId2ShuShu.Length != 0)
			{
				this.DeviceId2ShuShu = other.DeviceId2ShuShu;
			}
			if (other.ScreenHeight != 0)
			{
				this.ScreenHeight = other.ScreenHeight;
			}
			if (other.ScreenWidth != 0)
			{
				this.ScreenWidth = other.ScreenWidth;
			}
			if (other.DeviceInfo.Length != 0)
			{
				this.DeviceInfo = other.DeviceInfo;
			}
			if (other.DriverDate.Length != 0)
			{
				this.DriverDate = other.DriverDate;
			}
			if (other.ClientVersion.Length != 0)
			{
				this.ClientVersion = other.ClientVersion;
			}
			if (other.OSVersion.Length != 0)
			{
				this.OSVersion = other.OSVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x000AA53B File Offset: 0x000A873B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x000AA544 File Offset: 0x000A8744
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
				if (num <= 82U)
				{
					if (num <= 42U)
					{
						if (num <= 18U)
						{
							if (num == 10U)
							{
								this.Platform = input.ReadString();
								continue;
							}
							if (num == 18U)
							{
								this.DeviceId = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.NetStatus = (NetStatusType)input.ReadEnum();
								continue;
							}
							if (num == 34U)
							{
								this.Model = input.ReadString();
								continue;
							}
							if (num == 42U)
							{
								this.CPU = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 56U)
					{
						if (num == 48U)
						{
							this.DeviceLevel = (ClientDeviceLevel)input.ReadEnum();
							continue;
						}
						if (num == 56U)
						{
							this.Language = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 66U)
						{
							this.DistinctId = input.ReadString();
							continue;
						}
						if (num == 74U)
						{
							this.MacAddress = input.ReadString();
							continue;
						}
						if (num == 82U)
						{
							this.PkgId = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num <= 98U)
					{
						if (num == 90U)
						{
							this.ServerTag = input.ReadString();
							continue;
						}
						if (num == 98U)
						{
							this.SystemLanguage = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 106U)
						{
							this.OS = input.ReadString();
							continue;
						}
						if (num == 114U)
						{
							this.DeviceId2ShuShu = input.ReadString();
							continue;
						}
						if (num == 120U)
						{
							this.ScreenHeight = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 138U)
				{
					if (num == 128U)
					{
						this.ScreenWidth = input.ReadInt32();
						continue;
					}
					if (num == 138U)
					{
						this.DeviceInfo = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 146U)
					{
						this.DriverDate = input.ReadString();
						continue;
					}
					if (num == 154U)
					{
						this.ClientVersion = input.ReadString();
						continue;
					}
					if (num == 162U)
					{
						this.OSVersion = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002EDB RID: 11995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EDC RID: 11996
		public const int PlatformFieldNumber = 1;

		// Token: 0x04002EDD RID: 11997
		private string platform_ = "";

		// Token: 0x04002EDE RID: 11998
		public const int DeviceIdFieldNumber = 2;

		// Token: 0x04002EDF RID: 11999
		private string deviceId_ = "";

		// Token: 0x04002EE0 RID: 12000
		public const int NetStatusFieldNumber = 3;

		// Token: 0x04002EE1 RID: 12001
		private NetStatusType netStatus_;

		// Token: 0x04002EE2 RID: 12002
		public const int ModelFieldNumber = 4;

		// Token: 0x04002EE3 RID: 12003
		private string model_ = "";

		// Token: 0x04002EE4 RID: 12004
		public const int CPUFieldNumber = 5;

		// Token: 0x04002EE5 RID: 12005
		private string cPU_ = "";

		// Token: 0x04002EE6 RID: 12006
		public const int DeviceLevelFieldNumber = 6;

		// Token: 0x04002EE7 RID: 12007
		private ClientDeviceLevel deviceLevel_;

		// Token: 0x04002EE8 RID: 12008
		public const int LanguageFieldNumber = 7;

		// Token: 0x04002EE9 RID: 12009
		private int language_;

		// Token: 0x04002EEA RID: 12010
		public const int DistinctIdFieldNumber = 8;

		// Token: 0x04002EEB RID: 12011
		private string distinctId_ = "";

		// Token: 0x04002EEC RID: 12012
		public const int MacAddressFieldNumber = 9;

		// Token: 0x04002EED RID: 12013
		private string macAddress_ = "";

		// Token: 0x04002EEE RID: 12014
		public const int PkgIdFieldNumber = 10;

		// Token: 0x04002EEF RID: 12015
		private string pkgId_ = "";

		// Token: 0x04002EF0 RID: 12016
		public const int ServerTagFieldNumber = 11;

		// Token: 0x04002EF1 RID: 12017
		private string serverTag_ = "";

		// Token: 0x04002EF2 RID: 12018
		public const int SystemLanguageFieldNumber = 12;

		// Token: 0x04002EF3 RID: 12019
		private string systemLanguage_ = "";

		// Token: 0x04002EF4 RID: 12020
		public const int OSFieldNumber = 13;

		// Token: 0x04002EF5 RID: 12021
		private string oS_ = "";

		// Token: 0x04002EF6 RID: 12022
		public const int DeviceId2ShuShuFieldNumber = 14;

		// Token: 0x04002EF7 RID: 12023
		private string deviceId2ShuShu_ = "";

		// Token: 0x04002EF8 RID: 12024
		public const int ScreenHeightFieldNumber = 15;

		// Token: 0x04002EF9 RID: 12025
		private int screenHeight_;

		// Token: 0x04002EFA RID: 12026
		public const int ScreenWidthFieldNumber = 16;

		// Token: 0x04002EFB RID: 12027
		private int screenWidth_;

		// Token: 0x04002EFC RID: 12028
		public const int DeviceInfoFieldNumber = 17;

		// Token: 0x04002EFD RID: 12029
		private string deviceInfo_ = "";

		// Token: 0x04002EFE RID: 12030
		public const int DriverDateFieldNumber = 18;

		// Token: 0x04002EFF RID: 12031
		private string driverDate_ = "";

		// Token: 0x04002F00 RID: 12032
		public const int ClientVersionFieldNumber = 19;

		// Token: 0x04002F01 RID: 12033
		private string clientVersion_ = "";

		// Token: 0x04002F02 RID: 12034
		public const int OSVersionFieldNumber = 20;

		// Token: 0x04002F03 RID: 12035
		private string oSVersion_ = "";
	}
}
