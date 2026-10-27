using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094C RID: 2380
	[NetMessage(EMessageId.LoginResponse)]
	public sealed class LoginResponse : IMessage<LoginResponse>, IMessage, IEquatable<LoginResponse>, IDeepCloneable<LoginResponse>, IBufferMessage
	{
		// Token: 0x0600D1C6 RID: 53702 RVA: 0x001EE8F6 File Offset: 0x001ECAF6
		[NullableContext(1)]
		public static LoginResponse Create()
		{
			return new LoginResponse();
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x0600D1C7 RID: 53703 RVA: 0x001EE8FD File Offset: 0x001ECAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x0600D1C8 RID: 53704 RVA: 0x001EE900 File Offset: 0x001ECB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginResponse.Descriptor;
			}
		}

		// Token: 0x0600D1C9 RID: 53705 RVA: 0x001EE907 File Offset: 0x001ECB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginResponse()
		{
		}

		// Token: 0x0600D1CA RID: 53706 RVA: 0x001EE928 File Offset: 0x001ECB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginResponse(LoginResponse other) : this()
		{
			this.code_ = other.code_;
			this.reconnectToken_ = other.reconnectToken_;
			this.timestamp_ = other.timestamp_;
			this.platform_ = other.platform_;
			this.clientWaitingMode_ = other.clientWaitingMode_;
			this.clientWaitingTime_ = other.clientWaitingTime_;
			this.clientAutoInInterval_ = other.clientAutoInInterval_;
			this.clientDisplayTime_ = other.clientDisplayTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1CB RID: 53707 RVA: 0x001EE9AC File Offset: 0x001ECBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginResponse Clone()
		{
			return new LoginResponse(this);
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x0600D1CC RID: 53708 RVA: 0x001EE9B4 File Offset: 0x001ECBB4
		// (set) Token: 0x0600D1CD RID: 53709 RVA: 0x001EE9BC File Offset: 0x001ECBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0600D1CE RID: 53710 RVA: 0x001EE9C5 File Offset: 0x001ECBC5
		// (set) Token: 0x0600D1CF RID: 53711 RVA: 0x001EE9CD File Offset: 0x001ECBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReconnectToken
		{
			get
			{
				return this.reconnectToken_;
			}
			set
			{
				this.reconnectToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x0600D1D0 RID: 53712 RVA: 0x001EE9E0 File Offset: 0x001ECBE0
		// (set) Token: 0x0600D1D1 RID: 53713 RVA: 0x001EE9E8 File Offset: 0x001ECBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Timestamp
		{
			get
			{
				return this.timestamp_;
			}
			set
			{
				this.timestamp_ = value;
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x0600D1D2 RID: 53714 RVA: 0x001EE9F1 File Offset: 0x001ECBF1
		// (set) Token: 0x0600D1D3 RID: 53715 RVA: 0x001EE9F9 File Offset: 0x001ECBF9
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

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0600D1D4 RID: 53716 RVA: 0x001EEA0C File Offset: 0x001ECC0C
		// (set) Token: 0x0600D1D5 RID: 53717 RVA: 0x001EEA14 File Offset: 0x001ECC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientWaitingMode
		{
			get
			{
				return this.clientWaitingMode_;
			}
			set
			{
				this.clientWaitingMode_ = value;
			}
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0600D1D6 RID: 53718 RVA: 0x001EEA1D File Offset: 0x001ECC1D
		// (set) Token: 0x0600D1D7 RID: 53719 RVA: 0x001EEA25 File Offset: 0x001ECC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientWaitingTime
		{
			get
			{
				return this.clientWaitingTime_;
			}
			set
			{
				this.clientWaitingTime_ = value;
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x0600D1D8 RID: 53720 RVA: 0x001EEA2E File Offset: 0x001ECC2E
		// (set) Token: 0x0600D1D9 RID: 53721 RVA: 0x001EEA36 File Offset: 0x001ECC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientAutoInInterval
		{
			get
			{
				return this.clientAutoInInterval_;
			}
			set
			{
				this.clientAutoInInterval_ = value;
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x0600D1DA RID: 53722 RVA: 0x001EEA3F File Offset: 0x001ECC3F
		// (set) Token: 0x0600D1DB RID: 53723 RVA: 0x001EEA47 File Offset: 0x001ECC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientDisplayTime
		{
			get
			{
				return this.clientDisplayTime_;
			}
			set
			{
				this.clientDisplayTime_ = value;
			}
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x001EEA50 File Offset: 0x001ECC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginResponse);
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x001EEA60 File Offset: 0x001ECC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoginResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.ReconnectToken != other.ReconnectToken) && this.Timestamp == other.Timestamp && !(this.Platform != other.Platform) && this.ClientWaitingMode == other.ClientWaitingMode && this.ClientWaitingTime == other.ClientWaitingTime && this.ClientAutoInInterval == other.ClientAutoInInterval && this.ClientDisplayTime == other.ClientDisplayTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x001EEB14 File Offset: 0x001ECD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.ReconnectToken.Length != 0)
			{
				num ^= this.ReconnectToken.GetHashCode();
			}
			if (this.Timestamp != 0L)
			{
				num ^= this.Timestamp.GetHashCode();
			}
			if (this.Platform.Length != 0)
			{
				num ^= this.Platform.GetHashCode();
			}
			if (this.ClientWaitingMode != 0)
			{
				num ^= this.ClientWaitingMode.GetHashCode();
			}
			if (this.ClientWaitingTime != 0)
			{
				num ^= this.ClientWaitingTime.GetHashCode();
			}
			if (this.ClientAutoInInterval != 0)
			{
				num ^= this.ClientAutoInInterval.GetHashCode();
			}
			if (this.ClientDisplayTime != 0)
			{
				num ^= this.ClientDisplayTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D1DF RID: 53727 RVA: 0x001EEC0C File Offset: 0x001ECE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x001EEC19 File Offset: 0x001ECE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1E1 RID: 53729 RVA: 0x001EEC24 File Offset: 0x001ECE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.ReconnectToken.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ReconnectToken);
			}
			if (this.Timestamp != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Timestamp);
			}
			if (this.Platform.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Platform);
			}
			if (this.ClientWaitingMode != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ClientWaitingMode);
			}
			if (this.ClientWaitingTime != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ClientWaitingTime);
			}
			if (this.ClientAutoInInterval != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ClientAutoInInterval);
			}
			if (this.ClientDisplayTime != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ClientDisplayTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1E2 RID: 53730 RVA: 0x001EED30 File Offset: 0x001ECF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.ReconnectToken.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReconnectToken);
			}
			if (this.Timestamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
			}
			if (this.Platform.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Platform);
			}
			if (this.ClientWaitingMode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientWaitingMode);
			}
			if (this.ClientWaitingTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientWaitingTime);
			}
			if (this.ClientAutoInInterval != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientAutoInInterval);
			}
			if (this.ClientDisplayTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientDisplayTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1E3 RID: 53731 RVA: 0x001EEE20 File Offset: 0x001ED020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoginResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.ReconnectToken.Length != 0)
			{
				this.ReconnectToken = other.ReconnectToken;
			}
			if (other.Timestamp != 0L)
			{
				this.Timestamp = other.Timestamp;
			}
			if (other.Platform.Length != 0)
			{
				this.Platform = other.Platform;
			}
			if (other.ClientWaitingMode != 0)
			{
				this.ClientWaitingMode = other.ClientWaitingMode;
			}
			if (other.ClientWaitingTime != 0)
			{
				this.ClientWaitingTime = other.ClientWaitingTime;
			}
			if (other.ClientAutoInInterval != 0)
			{
				this.ClientAutoInInterval = other.ClientAutoInInterval;
			}
			if (other.ClientDisplayTime != 0)
			{
				this.ClientDisplayTime = other.ClientDisplayTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1E4 RID: 53732 RVA: 0x001EEEF2 File Offset: 0x001ED0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1E5 RID: 53733 RVA: 0x001EEEFC File Offset: 0x001ED0FC
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
				if (num <= 34U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.Code = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 18U)
						{
							this.ReconnectToken = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Timestamp = input.ReadInt64();
							continue;
						}
						if (num == 34U)
						{
							this.Platform = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.ClientWaitingMode = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ClientWaitingTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ClientAutoInInterval = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ClientDisplayTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400584C RID: 22604
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400584D RID: 22605
		public const int CodeFieldNumber = 1;

		// Token: 0x0400584E RID: 22606
		private ErrorCode code_;

		// Token: 0x0400584F RID: 22607
		public const int ReconnectTokenFieldNumber = 2;

		// Token: 0x04005850 RID: 22608
		private string reconnectToken_ = "";

		// Token: 0x04005851 RID: 22609
		public const int TimestampFieldNumber = 3;

		// Token: 0x04005852 RID: 22610
		private long timestamp_;

		// Token: 0x04005853 RID: 22611
		public const int PlatformFieldNumber = 4;

		// Token: 0x04005854 RID: 22612
		private string platform_ = "";

		// Token: 0x04005855 RID: 22613
		public const int ClientWaitingModeFieldNumber = 5;

		// Token: 0x04005856 RID: 22614
		private int clientWaitingMode_;

		// Token: 0x04005857 RID: 22615
		public const int ClientWaitingTimeFieldNumber = 6;

		// Token: 0x04005858 RID: 22616
		private int clientWaitingTime_;

		// Token: 0x04005859 RID: 22617
		public const int ClientAutoInIntervalFieldNumber = 7;

		// Token: 0x0400585A RID: 22618
		private int clientAutoInInterval_;

		// Token: 0x0400585B RID: 22619
		public const int ClientDisplayTimeFieldNumber = 8;

		// Token: 0x0400585C RID: 22620
		private int clientDisplayTime_;
	}
}
