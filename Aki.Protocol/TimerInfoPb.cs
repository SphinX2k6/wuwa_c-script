using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001382 RID: 4994
	public sealed class TimerInfoPb : IMessage<TimerInfoPb>, IMessage, IEquatable<TimerInfoPb>, IDeepCloneable<TimerInfoPb>, IBufferMessage
	{
		// Token: 0x0601A825 RID: 108581 RVA: 0x003D8DE5 File Offset: 0x003D6FE5
		[NullableContext(1)]
		public static TimerInfoPb Create()
		{
			return new TimerInfoPb();
		}

		// Token: 0x17005965 RID: 22885
		// (get) Token: 0x0601A826 RID: 108582 RVA: 0x003D8DEC File Offset: 0x003D6FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TimerInfoPb> Parser
		{
			get
			{
				return TimerInfoPb._parser;
			}
		}

		// Token: 0x17005966 RID: 22886
		// (get) Token: 0x0601A827 RID: 108583 RVA: 0x003D8DF3 File Offset: 0x003D6FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005967 RID: 22887
		// (get) Token: 0x0601A828 RID: 108584 RVA: 0x003D8DF6 File Offset: 0x003D6FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimerInfoPb.Descriptor;
			}
		}

		// Token: 0x0601A829 RID: 108585 RVA: 0x003D8DFD File Offset: 0x003D6FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerInfoPb()
		{
		}

		// Token: 0x0601A82A RID: 108586 RVA: 0x003D8E10 File Offset: 0x003D7010
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

		// Token: 0x0601A82B RID: 108587 RVA: 0x003D8E64 File Offset: 0x003D7064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerInfoPb Clone()
		{
			return new TimerInfoPb(this);
		}

		// Token: 0x17005968 RID: 22888
		// (get) Token: 0x0601A82C RID: 108588 RVA: 0x003D8E6C File Offset: 0x003D706C
		// (set) Token: 0x0601A82D RID: 108589 RVA: 0x003D8E74 File Offset: 0x003D7074
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

		// Token: 0x17005969 RID: 22889
		// (get) Token: 0x0601A82E RID: 108590 RVA: 0x003D8E87 File Offset: 0x003D7087
		// (set) Token: 0x0601A82F RID: 108591 RVA: 0x003D8E8F File Offset: 0x003D708F
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

		// Token: 0x1700596A RID: 22890
		// (get) Token: 0x0601A830 RID: 108592 RVA: 0x003D8E98 File Offset: 0x003D7098
		// (set) Token: 0x0601A831 RID: 108593 RVA: 0x003D8EA0 File Offset: 0x003D70A0
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

		// Token: 0x1700596B RID: 22891
		// (get) Token: 0x0601A832 RID: 108594 RVA: 0x003D8EA9 File Offset: 0x003D70A9
		// (set) Token: 0x0601A833 RID: 108595 RVA: 0x003D8EB1 File Offset: 0x003D70B1
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

		// Token: 0x0601A834 RID: 108596 RVA: 0x003D8EBA File Offset: 0x003D70BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimerInfoPb);
		}

		// Token: 0x0601A835 RID: 108597 RVA: 0x003D8EC8 File Offset: 0x003D70C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimerInfoPb other)
		{
			return other != null && (other == this || (!(this.TimerType != other.TimerType) && this.NodeId == other.NodeId && this.EndTime == other.EndTime && this.PauseTime == other.PauseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A836 RID: 108598 RVA: 0x003D8F38 File Offset: 0x003D7138
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

		// Token: 0x0601A837 RID: 108599 RVA: 0x003D8FC4 File Offset: 0x003D71C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A838 RID: 108600 RVA: 0x003D8FD1 File Offset: 0x003D71D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A839 RID: 108601 RVA: 0x003D8FDC File Offset: 0x003D71DC
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

		// Token: 0x0601A83A RID: 108602 RVA: 0x003D9074 File Offset: 0x003D7274
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

		// Token: 0x0601A83B RID: 108603 RVA: 0x003D9100 File Offset: 0x003D7300
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

		// Token: 0x0601A83C RID: 108604 RVA: 0x003D917D File Offset: 0x003D737D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A83D RID: 108605 RVA: 0x003D9188 File Offset: 0x003D7388
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

		// Token: 0x04009A34 RID: 39476
		private static readonly MessageParser<TimerInfoPb> _parser = new MessageParser<TimerInfoPb>(() => new TimerInfoPb());

		// Token: 0x04009A35 RID: 39477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A36 RID: 39478
		public const int TimerTypeFieldNumber = 1;

		// Token: 0x04009A37 RID: 39479
		private string timerType_ = "";

		// Token: 0x04009A38 RID: 39480
		public const int NodeIdFieldNumber = 2;

		// Token: 0x04009A39 RID: 39481
		private int nodeId_;

		// Token: 0x04009A3A RID: 39482
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04009A3B RID: 39483
		private long endTime_;

		// Token: 0x04009A3C RID: 39484
		public const int PauseTimeFieldNumber = 4;

		// Token: 0x04009A3D RID: 39485
		private long pauseTime_;
	}
}
