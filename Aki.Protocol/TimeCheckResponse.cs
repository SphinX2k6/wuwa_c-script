using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E1 RID: 5089
	[NetMessage(EMessageId.TimeCheckResponse)]
	public sealed class TimeCheckResponse : IMessage<TimeCheckResponse>, IMessage, IEquatable<TimeCheckResponse>, IDeepCloneable<TimeCheckResponse>, IBufferMessage
	{
		// Token: 0x0601B11F RID: 110879 RVA: 0x003F0C8F File Offset: 0x003EEE8F
		[NullableContext(1)]
		public static TimeCheckResponse Create()
		{
			return new TimeCheckResponse();
		}

		// Token: 0x17005BA9 RID: 23465
		// (get) Token: 0x0601B120 RID: 110880 RVA: 0x003F0C96 File Offset: 0x003EEE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BAA RID: 23466
		// (get) Token: 0x0601B121 RID: 110881 RVA: 0x003F0C99 File Offset: 0x003EEE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeCheckResponse.Descriptor;
			}
		}

		// Token: 0x0601B122 RID: 110882 RVA: 0x003F0CA0 File Offset: 0x003EEEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckResponse()
		{
		}

		// Token: 0x0601B123 RID: 110883 RVA: 0x003F0CA8 File Offset: 0x003EEEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckResponse(TimeCheckResponse other) : this()
		{
			this.code_ = other.code_;
			this.clientTime_ = other.clientTime_;
			this.serverTime_ = other.serverTime_;
			this.serverStopTime_ = other.serverStopTime_;
			this.sceneStopTime_ = other.sceneStopTime_;
			this.flowTime_ = other.flowTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B124 RID: 110884 RVA: 0x003F0D14 File Offset: 0x003EEF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckResponse Clone()
		{
			return new TimeCheckResponse(this);
		}

		// Token: 0x17005BAB RID: 23467
		// (get) Token: 0x0601B125 RID: 110885 RVA: 0x003F0D1C File Offset: 0x003EEF1C
		// (set) Token: 0x0601B126 RID: 110886 RVA: 0x003F0D24 File Offset: 0x003EEF24
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

		// Token: 0x17005BAC RID: 23468
		// (get) Token: 0x0601B127 RID: 110887 RVA: 0x003F0D2D File Offset: 0x003EEF2D
		// (set) Token: 0x0601B128 RID: 110888 RVA: 0x003F0D35 File Offset: 0x003EEF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ClientTime
		{
			get
			{
				return this.clientTime_;
			}
			set
			{
				this.clientTime_ = value;
			}
		}

		// Token: 0x17005BAD RID: 23469
		// (get) Token: 0x0601B129 RID: 110889 RVA: 0x003F0D3E File Offset: 0x003EEF3E
		// (set) Token: 0x0601B12A RID: 110890 RVA: 0x003F0D46 File Offset: 0x003EEF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ServerTime
		{
			get
			{
				return this.serverTime_;
			}
			set
			{
				this.serverTime_ = value;
			}
		}

		// Token: 0x17005BAE RID: 23470
		// (get) Token: 0x0601B12B RID: 110891 RVA: 0x003F0D4F File Offset: 0x003EEF4F
		// (set) Token: 0x0601B12C RID: 110892 RVA: 0x003F0D57 File Offset: 0x003EEF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ServerStopTime
		{
			get
			{
				return this.serverStopTime_;
			}
			set
			{
				this.serverStopTime_ = value;
			}
		}

		// Token: 0x17005BAF RID: 23471
		// (get) Token: 0x0601B12D RID: 110893 RVA: 0x003F0D60 File Offset: 0x003EEF60
		// (set) Token: 0x0601B12E RID: 110894 RVA: 0x003F0D68 File Offset: 0x003EEF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SceneStopTime
		{
			get
			{
				return this.sceneStopTime_;
			}
			set
			{
				this.sceneStopTime_ = value;
			}
		}

		// Token: 0x17005BB0 RID: 23472
		// (get) Token: 0x0601B12F RID: 110895 RVA: 0x003F0D71 File Offset: 0x003EEF71
		// (set) Token: 0x0601B130 RID: 110896 RVA: 0x003F0D79 File Offset: 0x003EEF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowTime
		{
			get
			{
				return this.flowTime_;
			}
			set
			{
				this.flowTime_ = value;
			}
		}

		// Token: 0x0601B131 RID: 110897 RVA: 0x003F0D82 File Offset: 0x003EEF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeCheckResponse);
		}

		// Token: 0x0601B132 RID: 110898 RVA: 0x003F0D90 File Offset: 0x003EEF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeCheckResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.ClientTime == other.ClientTime && this.ServerTime == other.ServerTime && this.ServerStopTime == other.ServerStopTime && this.SceneStopTime == other.SceneStopTime && this.FlowTime == other.FlowTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B133 RID: 110899 RVA: 0x003F0E1C File Offset: 0x003EF01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.ClientTime != 0L)
			{
				num ^= this.ClientTime.GetHashCode();
			}
			if (this.ServerTime != 0L)
			{
				num ^= this.ServerTime.GetHashCode();
			}
			if (this.ServerStopTime != 0L)
			{
				num ^= this.ServerStopTime.GetHashCode();
			}
			if (this.SceneStopTime != 0L)
			{
				num ^= this.SceneStopTime.GetHashCode();
			}
			if (this.FlowTime != 0L)
			{
				num ^= this.FlowTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B134 RID: 110900 RVA: 0x003F0EDE File Offset: 0x003EF0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B135 RID: 110901 RVA: 0x003F0EEB File Offset: 0x003EF0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B136 RID: 110902 RVA: 0x003F0EF4 File Offset: 0x003EF0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ServerTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ServerTime);
			}
			if (this.ServerStopTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.ServerStopTime);
			}
			if (this.FlowTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.FlowTime);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this.SceneStopTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.SceneStopTime);
			}
			if (this.ClientTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.ClientTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B137 RID: 110903 RVA: 0x003F0FBC File Offset: 0x003EF1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.ClientTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ClientTime);
			}
			if (this.ServerTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ServerTime);
			}
			if (this.ServerStopTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ServerStopTime);
			}
			if (this.SceneStopTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SceneStopTime);
			}
			if (this.FlowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B138 RID: 110904 RVA: 0x003F1074 File Offset: 0x003EF274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeCheckResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.ClientTime != 0L)
			{
				this.ClientTime = other.ClientTime;
			}
			if (other.ServerTime != 0L)
			{
				this.ServerTime = other.ServerTime;
			}
			if (other.ServerStopTime != 0L)
			{
				this.ServerStopTime = other.ServerStopTime;
			}
			if (other.SceneStopTime != 0L)
			{
				this.SceneStopTime = other.SceneStopTime;
			}
			if (other.FlowTime != 0L)
			{
				this.FlowTime = other.FlowTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B139 RID: 110905 RVA: 0x003F1114 File Offset: 0x003EF314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B13A RID: 110906 RVA: 0x003F1120 File Offset: 0x003EF320
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
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.ServerTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.ServerStopTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.FlowTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.SceneStopTime = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.ClientTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009E11 RID: 40465
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E12 RID: 40466
		public const int CodeFieldNumber = 10;

		// Token: 0x04009E13 RID: 40467
		private ErrorCode code_;

		// Token: 0x04009E14 RID: 40468
		public const int ClientTimeFieldNumber = 15;

		// Token: 0x04009E15 RID: 40469
		private long clientTime_;

		// Token: 0x04009E16 RID: 40470
		public const int ServerTimeFieldNumber = 1;

		// Token: 0x04009E17 RID: 40471
		private long serverTime_;

		// Token: 0x04009E18 RID: 40472
		public const int ServerStopTimeFieldNumber = 4;

		// Token: 0x04009E19 RID: 40473
		private long serverStopTime_;

		// Token: 0x04009E1A RID: 40474
		public const int SceneStopTimeFieldNumber = 13;

		// Token: 0x04009E1B RID: 40475
		private long sceneStopTime_;

		// Token: 0x04009E1C RID: 40476
		public const int FlowTimeFieldNumber = 7;

		// Token: 0x04009E1D RID: 40477
		private long flowTime_;
	}
}
