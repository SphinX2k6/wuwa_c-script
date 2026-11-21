using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F5 RID: 5109
	public sealed class TimerInfoPb : IMessage<TimerInfoPb>, IMessage, IEquatable<TimerInfoPb>, IDeepCloneable<TimerInfoPb>, IBufferMessage
	{
		// Token: 0x0601B2AE RID: 111278 RVA: 0x003F3FF9 File Offset: 0x003F21F9
		[NullableContext(1)]
		public static TimerInfoPb Create()
		{
			return new TimerInfoPb();
		}

		// Token: 0x17005BF9 RID: 23545
		// (get) Token: 0x0601B2AF RID: 111279 RVA: 0x003F4000 File Offset: 0x003F2200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TimerInfoPb> Parser
		{
			get
			{
				return TimerInfoPb._parser;
			}
		}

		// Token: 0x17005BFA RID: 23546
		// (get) Token: 0x0601B2B0 RID: 111280 RVA: 0x003F4007 File Offset: 0x003F2207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BFB RID: 23547
		// (get) Token: 0x0601B2B1 RID: 111281 RVA: 0x003F400A File Offset: 0x003F220A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimerInfoPb.Descriptor;
			}
		}

		// Token: 0x0601B2B2 RID: 111282 RVA: 0x003F4011 File Offset: 0x003F2211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerInfoPb()
		{
		}

		// Token: 0x0601B2B3 RID: 111283 RVA: 0x003F4024 File Offset: 0x003F2224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerInfoPb(TimerInfoPb other) : this()
		{
			this.timerType_ = other.timerType_;
			this.nodeId_ = other.nodeId_;
			this.endTime_ = other.endTime_;
			this.pauseTime_ = other.pauseTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2B4 RID: 111284 RVA: 0x003F4078 File Offset: 0x003F2278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerInfoPb Clone()
		{
			return new TimerInfoPb(this);
		}

		// Token: 0x17005BFC RID: 23548
		// (get) Token: 0x0601B2B5 RID: 111285 RVA: 0x003F4080 File Offset: 0x003F2280
		// (set) Token: 0x0601B2B6 RID: 111286 RVA: 0x003F4088 File Offset: 0x003F2288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TimerType
		{
			get
			{
				return this.timerType_;
			}
			set
			{
				this.timerType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005BFD RID: 23549
		// (get) Token: 0x0601B2B7 RID: 111287 RVA: 0x003F409B File Offset: 0x003F229B
		// (set) Token: 0x0601B2B8 RID: 111288 RVA: 0x003F40A3 File Offset: 0x003F22A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x17005BFE RID: 23550
		// (get) Token: 0x0601B2B9 RID: 111289 RVA: 0x003F40AC File Offset: 0x003F22AC
		// (set) Token: 0x0601B2BA RID: 111290 RVA: 0x003F40B4 File Offset: 0x003F22B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17005BFF RID: 23551
		// (get) Token: 0x0601B2BB RID: 111291 RVA: 0x003F40BD File Offset: 0x003F22BD
		// (set) Token: 0x0601B2BC RID: 111292 RVA: 0x003F40C5 File Offset: 0x003F22C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PauseTime
		{
			get
			{
				return this.pauseTime_;
			}
			set
			{
				this.pauseTime_ = value;
			}
		}

		// Token: 0x0601B2BD RID: 111293 RVA: 0x003F40CE File Offset: 0x003F22CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimerInfoPb);
		}

		// Token: 0x0601B2BE RID: 111294 RVA: 0x003F40DC File Offset: 0x003F22DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimerInfoPb other)
		{
			return other != null && (other == this || (!(this.TimerType != other.TimerType) && this.NodeId == other.NodeId && this.EndTime == other.EndTime && this.PauseTime == other.PauseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2BF RID: 111295 RVA: 0x003F414C File Offset: 0x003F234C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimerType.Length != 0)
			{
				num ^= this.TimerType.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.PauseTime != 0L)
			{
				num ^= this.PauseTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B2C0 RID: 111296 RVA: 0x003F41D8 File Offset: 0x003F23D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2C1 RID: 111297 RVA: 0x003F41E5 File Offset: 0x003F23E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2C2 RID: 111298 RVA: 0x003F41F0 File Offset: 0x003F23F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimerType.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TimerType);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NodeId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			if (this.PauseTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.PauseTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2C3 RID: 111299 RVA: 0x003F4288 File Offset: 0x003F2488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimerType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TimerType);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.PauseTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PauseTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B2C4 RID: 111300 RVA: 0x003F4314 File Offset: 0x003F2514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimerInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimerType.Length != 0)
			{
				this.TimerType = other.TimerType;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.PauseTime != 0L)
			{
				this.PauseTime = other.PauseTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B2C5 RID: 111301 RVA: 0x003F4391 File Offset: 0x003F2591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2C6 RID: 111302 RVA: 0x003F439C File Offset: 0x003F259C
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.TimerType = input.ReadString();
						continue;
					}
					if (num == 16U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.PauseTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009E79 RID: 40569
		private static readonly MessageParser<TimerInfoPb> _parser = new MessageParser<TimerInfoPb>(() => new TimerInfoPb());

		// Token: 0x04009E7A RID: 40570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E7B RID: 40571
		public const int TimerTypeFieldNumber = 1;

		// Token: 0x04009E7C RID: 40572
		private string timerType_ = "";

		// Token: 0x04009E7D RID: 40573
		public const int NodeIdFieldNumber = 2;

		// Token: 0x04009E7E RID: 40574
		private int nodeId_;

		// Token: 0x04009E7F RID: 40575
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04009E80 RID: 40576
		private long endTime_;

		// Token: 0x04009E81 RID: 40577
		public const int PauseTimeFieldNumber = 4;

		// Token: 0x04009E82 RID: 40578
		private long pauseTime_;
	}
}
