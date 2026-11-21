using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093B RID: 2363
	[NetMessage(EMessageId.LoginResponse)]
	public sealed class LoginResponse : IMessage<LoginResponse>, IMessage, IEquatable<LoginResponse>, IDeepCloneable<LoginResponse>, IBufferMessage
	{
		// Token: 0x0600D0AC RID: 53420 RVA: 0x001EC70E File Offset: 0x001EA90E
		[NullableContext(1)]
		public static LoginResponse Create()
		{
			return new LoginResponse();
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x0600D0AD RID: 53421 RVA: 0x001EC715 File Offset: 0x001EA915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x0600D0AE RID: 53422 RVA: 0x001EC718 File Offset: 0x001EA918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginResponse.Descriptor;
			}
		}

		// Token: 0x0600D0AF RID: 53423 RVA: 0x001EC71F File Offset: 0x001EA91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginResponse()
		{
		}

		// Token: 0x0600D0B0 RID: 53424 RVA: 0x001EC740 File Offset: 0x001EA940
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

		// Token: 0x0600D0B1 RID: 53425 RVA: 0x001EC7C4 File Offset: 0x001EA9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginResponse Clone()
		{
			return new LoginResponse(this);
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x0600D0B2 RID: 53426 RVA: 0x001EC7CC File Offset: 0x001EA9CC
		// (set) Token: 0x0600D0B3 RID: 53427 RVA: 0x001EC7D4 File Offset: 0x001EA9D4
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

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x0600D0B4 RID: 53428 RVA: 0x001EC7DD File Offset: 0x001EA9DD
		// (set) Token: 0x0600D0B5 RID: 53429 RVA: 0x001EC7E5 File Offset: 0x001EA9E5
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

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x0600D0B6 RID: 53430 RVA: 0x001EC7F8 File Offset: 0x001EA9F8
		// (set) Token: 0x0600D0B7 RID: 53431 RVA: 0x001EC800 File Offset: 0x001EAA00
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

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x0600D0B8 RID: 53432 RVA: 0x001EC809 File Offset: 0x001EAA09
		// (set) Token: 0x0600D0B9 RID: 53433 RVA: 0x001EC811 File Offset: 0x001EAA11
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

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x0600D0BA RID: 53434 RVA: 0x001EC824 File Offset: 0x001EAA24
		// (set) Token: 0x0600D0BB RID: 53435 RVA: 0x001EC82C File Offset: 0x001EAA2C
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

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x0600D0BC RID: 53436 RVA: 0x001EC835 File Offset: 0x001EAA35
		// (set) Token: 0x0600D0BD RID: 53437 RVA: 0x001EC83D File Offset: 0x001EAA3D
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

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x0600D0BE RID: 53438 RVA: 0x001EC846 File Offset: 0x001EAA46
		// (set) Token: 0x0600D0BF RID: 53439 RVA: 0x001EC84E File Offset: 0x001EAA4E
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

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x0600D0C0 RID: 53440 RVA: 0x001EC857 File Offset: 0x001EAA57
		// (set) Token: 0x0600D0C1 RID: 53441 RVA: 0x001EC85F File Offset: 0x001EAA5F
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

		// Token: 0x0600D0C2 RID: 53442 RVA: 0x001EC868 File Offset: 0x001EAA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginResponse);
		}

		// Token: 0x0600D0C3 RID: 53443 RVA: 0x001EC878 File Offset: 0x001EAA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoginResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.ReconnectToken != other.ReconnectToken) && this.Timestamp == other.Timestamp && !(this.Platform != other.Platform) && this.ClientWaitingMode == other.ClientWaitingMode && this.ClientWaitingTime == other.ClientWaitingTime && this.ClientAutoInInterval == other.ClientAutoInInterval && this.ClientDisplayTime == other.ClientDisplayTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x001EC92C File Offset: 0x001EAB2C
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

		// Token: 0x0600D0C5 RID: 53445 RVA: 0x001ECA24 File Offset: 0x001EAC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0C6 RID: 53446 RVA: 0x001ECA31 File Offset: 0x001EAC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0C7 RID: 53447 RVA: 0x001ECA3C File Offset: 0x001EAC3C
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

		// Token: 0x0600D0C8 RID: 53448 RVA: 0x001ECB48 File Offset: 0x001EAD48
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

		// Token: 0x0600D0C9 RID: 53449 RVA: 0x001ECC38 File Offset: 0x001EAE38
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

		// Token: 0x0600D0CA RID: 53450 RVA: 0x001ECD0A File Offset: 0x001EAF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0CB RID: 53451 RVA: 0x001ECD14 File Offset: 0x001EAF14
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

		// Token: 0x04005855 RID: 22613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005856 RID: 22614
		public const int CodeFieldNumber = 1;

		// Token: 0x04005857 RID: 22615
		private ErrorCode code_;

		// Token: 0x04005858 RID: 22616
		public const int ReconnectTokenFieldNumber = 2;

		// Token: 0x04005859 RID: 22617
		private string reconnectToken_ = "";

		// Token: 0x0400585A RID: 22618
		public const int TimestampFieldNumber = 3;

		// Token: 0x0400585B RID: 22619
		private long timestamp_;

		// Token: 0x0400585C RID: 22620
		public const int PlatformFieldNumber = 4;

		// Token: 0x0400585D RID: 22621
		private string platform_ = "";

		// Token: 0x0400585E RID: 22622
		public const int ClientWaitingModeFieldNumber = 5;

		// Token: 0x0400585F RID: 22623
		private int clientWaitingMode_;

		// Token: 0x04005860 RID: 22624
		public const int ClientWaitingTimeFieldNumber = 6;

		// Token: 0x04005861 RID: 22625
		private int clientWaitingTime_;

		// Token: 0x04005862 RID: 22626
		public const int ClientAutoInIntervalFieldNumber = 7;

		// Token: 0x04005863 RID: 22627
		private int clientAutoInInterval_;

		// Token: 0x04005864 RID: 22628
		public const int ClientDisplayTimeFieldNumber = 8;

		// Token: 0x04005865 RID: 22629
		private int clientDisplayTime_;
	}
}
