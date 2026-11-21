using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086C RID: 2156
	[NetMessage(EMessageId.KcpConvRequest)]
	public sealed class KcpConvRequest : IMessage<KcpConvRequest>, IMessage, IEquatable<KcpConvRequest>, IDeepCloneable<KcpConvRequest>, IBufferMessage
	{
		// Token: 0x0600C058 RID: 49240 RVA: 0x001C9525 File Offset: 0x001C7725
		[NullableContext(1)]
		public static KcpConvRequest Create()
		{
			return new KcpConvRequest();
		}

		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x0600C059 RID: 49241 RVA: 0x001C952C File Offset: 0x001C772C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x0600C05A RID: 49242 RVA: 0x001C952F File Offset: 0x001C772F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KcpConvRequest.Descriptor;
			}
		}

		// Token: 0x0600C05B RID: 49243 RVA: 0x001C9536 File Offset: 0x001C7736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvRequest()
		{
		}

		// Token: 0x0600C05C RID: 49244 RVA: 0x001C9560 File Offset: 0x001C7760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvRequest(KcpConvRequest other) : this()
		{
			this.loginTraceId_ = other.loginTraceId_;
			this.deviceId_ = other.deviceId_;
			this.udpPort_ = other.udpPort_;
			this.token_ = other.token_;
			this.disableCrc_ = other.disableCrc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C05D RID: 49245 RVA: 0x001C95C0 File Offset: 0x001C77C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvRequest Clone()
		{
			return new KcpConvRequest(this);
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x0600C05E RID: 49246 RVA: 0x001C95C8 File Offset: 0x001C77C8
		// (set) Token: 0x0600C05F RID: 49247 RVA: 0x001C95D0 File Offset: 0x001C77D0
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

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x0600C060 RID: 49248 RVA: 0x001C95E3 File Offset: 0x001C77E3
		// (set) Token: 0x0600C061 RID: 49249 RVA: 0x001C95EB File Offset: 0x001C77EB
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

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x0600C062 RID: 49250 RVA: 0x001C95FE File Offset: 0x001C77FE
		// (set) Token: 0x0600C063 RID: 49251 RVA: 0x001C9606 File Offset: 0x001C7806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UdpPort
		{
			get
			{
				return this.udpPort_;
			}
			set
			{
				this.udpPort_ = value;
			}
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x0600C064 RID: 49252 RVA: 0x001C960F File Offset: 0x001C780F
		// (set) Token: 0x0600C065 RID: 49253 RVA: 0x001C9617 File Offset: 0x001C7817
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

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x0600C066 RID: 49254 RVA: 0x001C962A File Offset: 0x001C782A
		// (set) Token: 0x0600C067 RID: 49255 RVA: 0x001C9632 File Offset: 0x001C7832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DisableCrc
		{
			get
			{
				return this.disableCrc_;
			}
			set
			{
				this.disableCrc_ = value;
			}
		}

		// Token: 0x0600C068 RID: 49256 RVA: 0x001C963B File Offset: 0x001C783B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KcpConvRequest);
		}

		// Token: 0x0600C069 RID: 49257 RVA: 0x001C964C File Offset: 0x001C784C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KcpConvRequest other)
		{
			return other != null && (other == this || (!(this.LoginTraceId != other.LoginTraceId) && !(this.DeviceId != other.DeviceId) && this.UdpPort == other.UdpPort && !(this.Token != other.Token) && this.DisableCrc == other.DisableCrc && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C06A RID: 49258 RVA: 0x001C96D4 File Offset: 0x001C78D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoginTraceId.Length != 0)
			{
				num ^= this.LoginTraceId.GetHashCode();
			}
			if (this.DeviceId.Length != 0)
			{
				num ^= this.DeviceId.GetHashCode();
			}
			if (this.UdpPort != 0)
			{
				num ^= this.UdpPort.GetHashCode();
			}
			if (this.Token.Length != 0)
			{
				num ^= this.Token.GetHashCode();
			}
			if (this.DisableCrc)
			{
				num ^= this.DisableCrc.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x001C977D File Offset: 0x001C797D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C06C RID: 49260 RVA: 0x001C978A File Offset: 0x001C798A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C06D RID: 49261 RVA: 0x001C9794 File Offset: 0x001C7994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoginTraceId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.LoginTraceId);
			}
			if (this.DeviceId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.DeviceId);
			}
			if (this.UdpPort != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.UdpPort);
			}
			if (this.Token.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Token);
			}
			if (this.DisableCrc)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.DisableCrc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C06E RID: 49262 RVA: 0x001C9850 File Offset: 0x001C7A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoginTraceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LoginTraceId);
			}
			if (this.DeviceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DeviceId);
			}
			if (this.UdpPort != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UdpPort);
			}
			if (this.Token.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Token);
			}
			if (this.DisableCrc)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C06F RID: 49263 RVA: 0x001C98F4 File Offset: 0x001C7AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KcpConvRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoginTraceId.Length != 0)
			{
				this.LoginTraceId = other.LoginTraceId;
			}
			if (other.DeviceId.Length != 0)
			{
				this.DeviceId = other.DeviceId;
			}
			if (other.UdpPort != 0)
			{
				this.UdpPort = other.UdpPort;
			}
			if (other.Token.Length != 0)
			{
				this.Token = other.Token;
			}
			if (other.DisableCrc)
			{
				this.DisableCrc = other.DisableCrc;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C070 RID: 49264 RVA: 0x001C998F File Offset: 0x001C7B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C071 RID: 49265 RVA: 0x001C9998 File Offset: 0x001C7B98
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.LoginTraceId = input.ReadString();
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
						this.UdpPort = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.Token = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.DisableCrc = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040053ED RID: 21485
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053EE RID: 21486
		public const int LoginTraceIdFieldNumber = 1;

		// Token: 0x040053EF RID: 21487
		private string loginTraceId_ = "";

		// Token: 0x040053F0 RID: 21488
		public const int DeviceIdFieldNumber = 2;

		// Token: 0x040053F1 RID: 21489
		private string deviceId_ = "";

		// Token: 0x040053F2 RID: 21490
		public const int UdpPortFieldNumber = 3;

		// Token: 0x040053F3 RID: 21491
		private int udpPort_;

		// Token: 0x040053F4 RID: 21492
		public const int TokenFieldNumber = 4;

		// Token: 0x040053F5 RID: 21493
		private string token_ = "";

		// Token: 0x040053F6 RID: 21494
		public const int DisableCrcFieldNumber = 5;

		// Token: 0x040053F7 RID: 21495
		private bool disableCrc_;
	}
}
