using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087D RID: 2173
	[NetMessage(EMessageId.KcpConvRequest)]
	public sealed class KcpConvRequest : IMessage<KcpConvRequest>, IMessage, IEquatable<KcpConvRequest>, IDeepCloneable<KcpConvRequest>, IBufferMessage
	{
		// Token: 0x0600C174 RID: 49524 RVA: 0x001CB80D File Offset: 0x001C9A0D
		[NullableContext(1)]
		public static KcpConvRequest Create()
		{
			return new KcpConvRequest();
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x0600C175 RID: 49525 RVA: 0x001CB814 File Offset: 0x001C9A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x0600C176 RID: 49526 RVA: 0x001CB817 File Offset: 0x001C9A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KcpConvRequest.Descriptor;
			}
		}

		// Token: 0x0600C177 RID: 49527 RVA: 0x001CB81E File Offset: 0x001C9A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvRequest()
		{
		}

		// Token: 0x0600C178 RID: 49528 RVA: 0x001CB848 File Offset: 0x001C9A48
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

		// Token: 0x0600C179 RID: 49529 RVA: 0x001CB8A8 File Offset: 0x001C9AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KcpConvRequest Clone()
		{
			return new KcpConvRequest(this);
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600C17A RID: 49530 RVA: 0x001CB8B0 File Offset: 0x001C9AB0
		// (set) Token: 0x0600C17B RID: 49531 RVA: 0x001CB8B8 File Offset: 0x001C9AB8
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

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600C17C RID: 49532 RVA: 0x001CB8CB File Offset: 0x001C9ACB
		// (set) Token: 0x0600C17D RID: 49533 RVA: 0x001CB8D3 File Offset: 0x001C9AD3
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

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x0600C17E RID: 49534 RVA: 0x001CB8E6 File Offset: 0x001C9AE6
		// (set) Token: 0x0600C17F RID: 49535 RVA: 0x001CB8EE File Offset: 0x001C9AEE
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

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x0600C180 RID: 49536 RVA: 0x001CB8F7 File Offset: 0x001C9AF7
		// (set) Token: 0x0600C181 RID: 49537 RVA: 0x001CB8FF File Offset: 0x001C9AFF
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

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x0600C182 RID: 49538 RVA: 0x001CB912 File Offset: 0x001C9B12
		// (set) Token: 0x0600C183 RID: 49539 RVA: 0x001CB91A File Offset: 0x001C9B1A
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

		// Token: 0x0600C184 RID: 49540 RVA: 0x001CB923 File Offset: 0x001C9B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KcpConvRequest);
		}

		// Token: 0x0600C185 RID: 49541 RVA: 0x001CB934 File Offset: 0x001C9B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KcpConvRequest other)
		{
			return other != null && (other == this || (!(this.LoginTraceId != other.LoginTraceId) && !(this.DeviceId != other.DeviceId) && this.UdpPort == other.UdpPort && !(this.Token != other.Token) && this.DisableCrc == other.DisableCrc && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C186 RID: 49542 RVA: 0x001CB9BC File Offset: 0x001C9BBC
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

		// Token: 0x0600C187 RID: 49543 RVA: 0x001CBA65 File Offset: 0x001C9C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C188 RID: 49544 RVA: 0x001CBA72 File Offset: 0x001C9C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C189 RID: 49545 RVA: 0x001CBA7C File Offset: 0x001C9C7C
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

		// Token: 0x0600C18A RID: 49546 RVA: 0x001CBB38 File Offset: 0x001C9D38
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

		// Token: 0x0600C18B RID: 49547 RVA: 0x001CBBDC File Offset: 0x001C9DDC
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

		// Token: 0x0600C18C RID: 49548 RVA: 0x001CBC77 File Offset: 0x001C9E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C18D RID: 49549 RVA: 0x001CBC80 File Offset: 0x001C9E80
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

		// Token: 0x040053E6 RID: 21478
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053E7 RID: 21479
		public const int LoginTraceIdFieldNumber = 1;

		// Token: 0x040053E8 RID: 21480
		private string loginTraceId_ = "";

		// Token: 0x040053E9 RID: 21481
		public const int DeviceIdFieldNumber = 2;

		// Token: 0x040053EA RID: 21482
		private string deviceId_ = "";

		// Token: 0x040053EB RID: 21483
		public const int UdpPortFieldNumber = 3;

		// Token: 0x040053EC RID: 21484
		private int udpPort_;

		// Token: 0x040053ED RID: 21485
		public const int TokenFieldNumber = 4;

		// Token: 0x040053EE RID: 21486
		private string token_ = "";

		// Token: 0x040053EF RID: 21487
		public const int DisableCrcFieldNumber = 5;

		// Token: 0x040053F0 RID: 21488
		private bool disableCrc_;
	}
}
