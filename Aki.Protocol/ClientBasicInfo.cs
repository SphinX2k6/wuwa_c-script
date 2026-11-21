using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029C RID: 668
	public sealed class ClientBasicInfo : IMessage<ClientBasicInfo>, IMessage, IEquatable<ClientBasicInfo>, IDeepCloneable<ClientBasicInfo>, IBufferMessage
	{
		// Token: 0x060045B5 RID: 17845 RVA: 0x000AB311 File Offset: 0x000A9511
		[NullableContext(1)]
		public static ClientBasicInfo Create()
		{
			return new ClientBasicInfo();
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x000AB318 File Offset: 0x000A9518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060045B7 RID: 17847 RVA: 0x000AB31B File Offset: 0x000A951B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientBasicInfo.Descriptor;
			}
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x000AB324 File Offset: 0x000A9524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfo()
		{
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x000AB3DC File Offset: 0x000A95DC
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
			this.qualityVersion_ = other.qualityVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x000AB4FC File Offset: 0x000A96FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfo Clone()
		{
			return new ClientBasicInfo(this);
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060045BB RID: 17851 RVA: 0x000AB504 File Offset: 0x000A9704
		// (set) Token: 0x060045BC RID: 17852 RVA: 0x000AB50C File Offset: 0x000A970C
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

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x000AB51F File Offset: 0x000A971F
		// (set) Token: 0x060045BE RID: 17854 RVA: 0x000AB527 File Offset: 0x000A9727
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

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060045BF RID: 17855 RVA: 0x000AB53A File Offset: 0x000A973A
		// (set) Token: 0x060045C0 RID: 17856 RVA: 0x000AB542 File Offset: 0x000A9742
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

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060045C1 RID: 17857 RVA: 0x000AB54B File Offset: 0x000A974B
		// (set) Token: 0x060045C2 RID: 17858 RVA: 0x000AB553 File Offset: 0x000A9753
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

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060045C3 RID: 17859 RVA: 0x000AB566 File Offset: 0x000A9766
		// (set) Token: 0x060045C4 RID: 17860 RVA: 0x000AB56E File Offset: 0x000A976E
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

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060045C5 RID: 17861 RVA: 0x000AB581 File Offset: 0x000A9781
		// (set) Token: 0x060045C6 RID: 17862 RVA: 0x000AB589 File Offset: 0x000A9789
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

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x000AB592 File Offset: 0x000A9792
		// (set) Token: 0x060045C8 RID: 17864 RVA: 0x000AB59A File Offset: 0x000A979A
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

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060045C9 RID: 17865 RVA: 0x000AB5A3 File Offset: 0x000A97A3
		// (set) Token: 0x060045CA RID: 17866 RVA: 0x000AB5AB File Offset: 0x000A97AB
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

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060045CB RID: 17867 RVA: 0x000AB5BE File Offset: 0x000A97BE
		// (set) Token: 0x060045CC RID: 17868 RVA: 0x000AB5C6 File Offset: 0x000A97C6
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

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060045CD RID: 17869 RVA: 0x000AB5D9 File Offset: 0x000A97D9
		// (set) Token: 0x060045CE RID: 17870 RVA: 0x000AB5E1 File Offset: 0x000A97E1
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

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060045CF RID: 17871 RVA: 0x000AB5F4 File Offset: 0x000A97F4
		// (set) Token: 0x060045D0 RID: 17872 RVA: 0x000AB5FC File Offset: 0x000A97FC
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

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x000AB60F File Offset: 0x000A980F
		// (set) Token: 0x060045D2 RID: 17874 RVA: 0x000AB617 File Offset: 0x000A9817
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

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x000AB62A File Offset: 0x000A982A
		// (set) Token: 0x060045D4 RID: 17876 RVA: 0x000AB632 File Offset: 0x000A9832
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

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060045D5 RID: 17877 RVA: 0x000AB645 File Offset: 0x000A9845
		// (set) Token: 0x060045D6 RID: 17878 RVA: 0x000AB64D File Offset: 0x000A984D
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

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060045D7 RID: 17879 RVA: 0x000AB660 File Offset: 0x000A9860
		// (set) Token: 0x060045D8 RID: 17880 RVA: 0x000AB668 File Offset: 0x000A9868
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

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x000AB671 File Offset: 0x000A9871
		// (set) Token: 0x060045DA RID: 17882 RVA: 0x000AB679 File Offset: 0x000A9879
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

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x000AB682 File Offset: 0x000A9882
		// (set) Token: 0x060045DC RID: 17884 RVA: 0x000AB68A File Offset: 0x000A988A
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

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x000AB69D File Offset: 0x000A989D
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x000AB6A5 File Offset: 0x000A98A5
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

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x000AB6B8 File Offset: 0x000A98B8
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x000AB6C0 File Offset: 0x000A98C0
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

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x000AB6D3 File Offset: 0x000A98D3
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x000AB6DB File Offset: 0x000A98DB
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

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x000AB6EE File Offset: 0x000A98EE
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x000AB6F6 File Offset: 0x000A98F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QualityVersion
		{
			get
			{
				return this.qualityVersion_;
			}
			set
			{
				this.qualityVersion_ = value;
			}
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x000AB6FF File Offset: 0x000A98FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientBasicInfo);
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x000AB710 File Offset: 0x000A9910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientBasicInfo other)
		{
			return other != null && (other == this || (!(this.Platform != other.Platform) && !(this.DeviceId != other.DeviceId) && this.NetStatus == other.NetStatus && !(this.Model != other.Model) && !(this.CPU != other.CPU) && this.DeviceLevel == other.DeviceLevel && this.Language == other.Language && !(this.DistinctId != other.DistinctId) && !(this.MacAddress != other.MacAddress) && !(this.PkgId != other.PkgId) && !(this.ServerTag != other.ServerTag) && !(this.SystemLanguage != other.SystemLanguage) && !(this.OS != other.OS) && !(this.DeviceId2ShuShu != other.DeviceId2ShuShu) && this.ScreenHeight == other.ScreenHeight && this.ScreenWidth == other.ScreenWidth && !(this.DeviceInfo != other.DeviceInfo) && !(this.DriverDate != other.DriverDate) && !(this.ClientVersion != other.ClientVersion) && !(this.OSVersion != other.OSVersion) && this.QualityVersion == other.QualityVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x000AB8D4 File Offset: 0x000A9AD4
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
			if (this.QualityVersion != 0)
			{
				num ^= this.QualityVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x000ABB31 File Offset: 0x000A9D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x000ABB3E File Offset: 0x000A9D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x000ABB48 File Offset: 0x000A9D48
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
			if (this.QualityVersion != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.QualityVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x000ABE18 File Offset: 0x000AA018
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
			if (this.QualityVersion != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.QualityVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x000AC084 File Offset: 0x000AA284
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
			if (other.QualityVersion != 0)
			{
				this.QualityVersion = other.QualityVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x000AC29B File Offset: 0x000AA49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x000AC2A4 File Offset: 0x000AA4A4
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
				else if (num <= 146U)
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
					if (num == 146U)
					{
						this.DriverDate = input.ReadString();
						continue;
					}
				}
				else
				{
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
					if (num == 168U)
					{
						this.QualityVersion = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F5F RID: 12127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F60 RID: 12128
		public const int PlatformFieldNumber = 1;

		// Token: 0x04002F61 RID: 12129
		private string platform_ = "";

		// Token: 0x04002F62 RID: 12130
		public const int DeviceIdFieldNumber = 2;

		// Token: 0x04002F63 RID: 12131
		private string deviceId_ = "";

		// Token: 0x04002F64 RID: 12132
		public const int NetStatusFieldNumber = 3;

		// Token: 0x04002F65 RID: 12133
		private NetStatusType netStatus_;

		// Token: 0x04002F66 RID: 12134
		public const int ModelFieldNumber = 4;

		// Token: 0x04002F67 RID: 12135
		private string model_ = "";

		// Token: 0x04002F68 RID: 12136
		public const int CPUFieldNumber = 5;

		// Token: 0x04002F69 RID: 12137
		private string cPU_ = "";

		// Token: 0x04002F6A RID: 12138
		public const int DeviceLevelFieldNumber = 6;

		// Token: 0x04002F6B RID: 12139
		private ClientDeviceLevel deviceLevel_;

		// Token: 0x04002F6C RID: 12140
		public const int LanguageFieldNumber = 7;

		// Token: 0x04002F6D RID: 12141
		private int language_;

		// Token: 0x04002F6E RID: 12142
		public const int DistinctIdFieldNumber = 8;

		// Token: 0x04002F6F RID: 12143
		private string distinctId_ = "";

		// Token: 0x04002F70 RID: 12144
		public const int MacAddressFieldNumber = 9;

		// Token: 0x04002F71 RID: 12145
		private string macAddress_ = "";

		// Token: 0x04002F72 RID: 12146
		public const int PkgIdFieldNumber = 10;

		// Token: 0x04002F73 RID: 12147
		private string pkgId_ = "";

		// Token: 0x04002F74 RID: 12148
		public const int ServerTagFieldNumber = 11;

		// Token: 0x04002F75 RID: 12149
		private string serverTag_ = "";

		// Token: 0x04002F76 RID: 12150
		public const int SystemLanguageFieldNumber = 12;

		// Token: 0x04002F77 RID: 12151
		private string systemLanguage_ = "";

		// Token: 0x04002F78 RID: 12152
		public const int OSFieldNumber = 13;

		// Token: 0x04002F79 RID: 12153
		private string oS_ = "";

		// Token: 0x04002F7A RID: 12154
		public const int DeviceId2ShuShuFieldNumber = 14;

		// Token: 0x04002F7B RID: 12155
		private string deviceId2ShuShu_ = "";

		// Token: 0x04002F7C RID: 12156
		public const int ScreenHeightFieldNumber = 15;

		// Token: 0x04002F7D RID: 12157
		private int screenHeight_;

		// Token: 0x04002F7E RID: 12158
		public const int ScreenWidthFieldNumber = 16;

		// Token: 0x04002F7F RID: 12159
		private int screenWidth_;

		// Token: 0x04002F80 RID: 12160
		public const int DeviceInfoFieldNumber = 17;

		// Token: 0x04002F81 RID: 12161
		private string deviceInfo_ = "";

		// Token: 0x04002F82 RID: 12162
		public const int DriverDateFieldNumber = 18;

		// Token: 0x04002F83 RID: 12163
		private string driverDate_ = "";

		// Token: 0x04002F84 RID: 12164
		public const int ClientVersionFieldNumber = 19;

		// Token: 0x04002F85 RID: 12165
		private string clientVersion_ = "";

		// Token: 0x04002F86 RID: 12166
		public const int OSVersionFieldNumber = 20;

		// Token: 0x04002F87 RID: 12167
		private string oSVersion_ = "";

		// Token: 0x04002F88 RID: 12168
		public const int QualityVersionFieldNumber = 21;

		// Token: 0x04002F89 RID: 12169
		private int qualityVersion_;
	}
}
