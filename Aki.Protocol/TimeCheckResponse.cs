using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136E RID: 4974
	[NetMessage(EMessageId.TimeCheckResponse)]
	public sealed class TimeCheckResponse : IMessage<TimeCheckResponse>, IMessage, IEquatable<TimeCheckResponse>, IDeepCloneable<TimeCheckResponse>, IBufferMessage
	{
		// Token: 0x0601A696 RID: 108182 RVA: 0x003D5A7F File Offset: 0x003D3C7F
		[NullableContext(1)]
		public static TimeCheckResponse Create()
		{
			return new TimeCheckResponse();
		}

		// Token: 0x17005915 RID: 22805
		// (get) Token: 0x0601A697 RID: 108183 RVA: 0x003D5A86 File Offset: 0x003D3C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005916 RID: 22806
		// (get) Token: 0x0601A698 RID: 108184 RVA: 0x003D5A89 File Offset: 0x003D3C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeCheckResponse.Descriptor;
			}
		}

		// Token: 0x0601A699 RID: 108185 RVA: 0x003D5A90 File Offset: 0x003D3C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckResponse()
		{
		}

		// Token: 0x0601A69A RID: 108186 RVA: 0x003D5A98 File Offset: 0x003D3C98
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

		// Token: 0x0601A69B RID: 108187 RVA: 0x003D5B04 File Offset: 0x003D3D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckResponse Clone()
		{
			return new TimeCheckResponse(this);
		}

		// Token: 0x17005917 RID: 22807
		// (get) Token: 0x0601A69C RID: 108188 RVA: 0x003D5B0C File Offset: 0x003D3D0C
		// (set) Token: 0x0601A69D RID: 108189 RVA: 0x003D5B14 File Offset: 0x003D3D14
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

		// Token: 0x17005918 RID: 22808
		// (get) Token: 0x0601A69E RID: 108190 RVA: 0x003D5B1D File Offset: 0x003D3D1D
		// (set) Token: 0x0601A69F RID: 108191 RVA: 0x003D5B25 File Offset: 0x003D3D25
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

		// Token: 0x17005919 RID: 22809
		// (get) Token: 0x0601A6A0 RID: 108192 RVA: 0x003D5B2E File Offset: 0x003D3D2E
		// (set) Token: 0x0601A6A1 RID: 108193 RVA: 0x003D5B36 File Offset: 0x003D3D36
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

		// Token: 0x1700591A RID: 22810
		// (get) Token: 0x0601A6A2 RID: 108194 RVA: 0x003D5B3F File Offset: 0x003D3D3F
		// (set) Token: 0x0601A6A3 RID: 108195 RVA: 0x003D5B47 File Offset: 0x003D3D47
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

		// Token: 0x1700591B RID: 22811
		// (get) Token: 0x0601A6A4 RID: 108196 RVA: 0x003D5B50 File Offset: 0x003D3D50
		// (set) Token: 0x0601A6A5 RID: 108197 RVA: 0x003D5B58 File Offset: 0x003D3D58
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

		// Token: 0x1700591C RID: 22812
		// (get) Token: 0x0601A6A6 RID: 108198 RVA: 0x003D5B61 File Offset: 0x003D3D61
		// (set) Token: 0x0601A6A7 RID: 108199 RVA: 0x003D5B69 File Offset: 0x003D3D69
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

		// Token: 0x0601A6A8 RID: 108200 RVA: 0x003D5B72 File Offset: 0x003D3D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeCheckResponse);
		}

		// Token: 0x0601A6A9 RID: 108201 RVA: 0x003D5B80 File Offset: 0x003D3D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeCheckResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.ClientTime == other.ClientTime && this.ServerTime == other.ServerTime && this.ServerStopTime == other.ServerStopTime && this.SceneStopTime == other.SceneStopTime && this.FlowTime == other.FlowTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A6AA RID: 108202 RVA: 0x003D5C0C File Offset: 0x003D3E0C
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

		// Token: 0x0601A6AB RID: 108203 RVA: 0x003D5CCE File Offset: 0x003D3ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6AC RID: 108204 RVA: 0x003D5CDB File Offset: 0x003D3EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6AD RID: 108205 RVA: 0x003D5CE4 File Offset: 0x003D3EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.FlowTime);
			}
			if (this.ClientTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ClientTime);
			}
			if (this.SceneStopTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.SceneStopTime);
			}
			if (this.ServerTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.ServerTime);
			}
			if (this.ServerStopTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.ServerStopTime);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A6AE RID: 108206 RVA: 0x003D5DAC File Offset: 0x003D3FAC
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

		// Token: 0x0601A6AF RID: 108207 RVA: 0x003D5E64 File Offset: 0x003D4064
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

		// Token: 0x0601A6B0 RID: 108208 RVA: 0x003D5F04 File Offset: 0x003D4104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6B1 RID: 108209 RVA: 0x003D5F10 File Offset: 0x003D4110
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
						this.FlowTime = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.ClientTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.SceneStopTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ServerTime = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.ServerStopTime = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040099CC RID: 39372
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099CD RID: 39373
		public const int CodeFieldNumber = 14;

		// Token: 0x040099CE RID: 39374
		private ErrorCode code_;

		// Token: 0x040099CF RID: 39375
		public const int ClientTimeFieldNumber = 2;

		// Token: 0x040099D0 RID: 39376
		private long clientTime_;

		// Token: 0x040099D1 RID: 39377
		public const int ServerTimeFieldNumber = 10;

		// Token: 0x040099D2 RID: 39378
		private long serverTime_;

		// Token: 0x040099D3 RID: 39379
		public const int ServerStopTimeFieldNumber = 11;

		// Token: 0x040099D4 RID: 39380
		private long serverStopTime_;

		// Token: 0x040099D5 RID: 39381
		public const int SceneStopTimeFieldNumber = 7;

		// Token: 0x040099D6 RID: 39382
		private long sceneStopTime_;

		// Token: 0x040099D7 RID: 39383
		public const int FlowTimeFieldNumber = 1;

		// Token: 0x040099D8 RID: 39384
		private long flowTime_;
	}
}
