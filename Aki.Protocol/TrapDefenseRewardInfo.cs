using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001441 RID: 5185
	public sealed class TrapDefenseRewardInfo : IMessage<TrapDefenseRewardInfo>, IMessage, IEquatable<TrapDefenseRewardInfo>, IDeepCloneable<TrapDefenseRewardInfo>, IBufferMessage
	{
		// Token: 0x0601B76E RID: 112494 RVA: 0x003FA10C File Offset: 0x003F830C
		[NullableContext(1)]
		public static TrapDefenseRewardInfo Create()
		{
			return new TrapDefenseRewardInfo();
		}

		// Token: 0x17005C9D RID: 23709
		// (get) Token: 0x0601B76F RID: 112495 RVA: 0x003FA113 File Offset: 0x003F8313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseRewardInfo> Parser
		{
			get
			{
				return TrapDefenseRewardInfo._parser;
			}
		}

		// Token: 0x17005C9E RID: 23710
		// (get) Token: 0x0601B770 RID: 112496 RVA: 0x003FA11A File Offset: 0x003F831A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C9F RID: 23711
		// (get) Token: 0x0601B771 RID: 112497 RVA: 0x003FA11D File Offset: 0x003F831D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRewardInfo.Descriptor;
			}
		}

		// Token: 0x0601B772 RID: 112498 RVA: 0x003FA124 File Offset: 0x003F8324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardInfo()
		{
		}

		// Token: 0x0601B773 RID: 112499 RVA: 0x003FA12C File Offset: 0x003F832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardInfo(TrapDefenseRewardInfo other) : this()
		{
			this.taskInfo_ = ((other.taskInfo_ != null) ? other.taskInfo_.Clone() : null);
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B774 RID: 112500 RVA: 0x003FA184 File Offset: 0x003F8384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardInfo Clone()
		{
			return new TrapDefenseRewardInfo(this);
		}

		// Token: 0x17005CA0 RID: 23712
		// (get) Token: 0x0601B775 RID: 112501 RVA: 0x003FA18C File Offset: 0x003F838C
		// (set) Token: 0x0601B776 RID: 112502 RVA: 0x003FA194 File Offset: 0x003F8394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask TaskInfo
		{
			get
			{
				return this.taskInfo_;
			}
			set
			{
				this.taskInfo_ = value;
			}
		}

		// Token: 0x17005CA1 RID: 23713
		// (get) Token: 0x0601B777 RID: 112503 RVA: 0x003FA19D File Offset: 0x003F839D
		// (set) Token: 0x0601B778 RID: 112504 RVA: 0x003FA1A5 File Offset: 0x003F83A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17005CA2 RID: 23714
		// (get) Token: 0x0601B779 RID: 112505 RVA: 0x003FA1AE File Offset: 0x003F83AE
		// (set) Token: 0x0601B77A RID: 112506 RVA: 0x003FA1B6 File Offset: 0x003F83B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x0601B77B RID: 112507 RVA: 0x003FA1BF File Offset: 0x003F83BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRewardInfo);
		}

		// Token: 0x0601B77C RID: 112508 RVA: 0x003FA1D0 File Offset: 0x003F83D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRewardInfo other)
		{
			return other != null && (other == this || (object.Equals(this.TaskInfo, other.TaskInfo) && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B77D RID: 112509 RVA: 0x003FA230 File Offset: 0x003F8430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.taskInfo_ != null)
			{
				num ^= this.TaskInfo.GetHashCode();
			}
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B77E RID: 112510 RVA: 0x003FA29E File Offset: 0x003F849E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B77F RID: 112511 RVA: 0x003FA2AB File Offset: 0x003F84AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B780 RID: 112512 RVA: 0x003FA2B4 File Offset: 0x003F84B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.taskInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TaskInfo);
			}
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B781 RID: 112513 RVA: 0x003FA32C File Offset: 0x003F852C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.taskInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TaskInfo);
			}
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B782 RID: 112514 RVA: 0x003FA39C File Offset: 0x003F859C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.taskInfo_ != null)
			{
				if (this.taskInfo_ == null)
				{
					this.TaskInfo = new ConditionTask();
				}
				this.TaskInfo.MergeFrom(other.TaskInfo);
			}
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B783 RID: 112515 RVA: 0x003FA418 File Offset: 0x003F8618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B784 RID: 112516 RVA: 0x003FA424 File Offset: 0x003F8624
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LimitEndTime = input.ReadInt64();
						}
					}
					else
					{
						this.LimitBeginTime = input.ReadInt64();
					}
				}
				else
				{
					if (this.taskInfo_ == null)
					{
						this.TaskInfo = new ConditionTask();
					}
					input.ReadMessage(this.TaskInfo);
				}
			}
		}

		// Token: 0x04009E7D RID: 40573
		private static readonly MessageParser<TrapDefenseRewardInfo> _parser = new MessageParser<TrapDefenseRewardInfo>(() => new TrapDefenseRewardInfo());

		// Token: 0x04009E7E RID: 40574
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E7F RID: 40575
		public const int TaskInfoFieldNumber = 1;

		// Token: 0x04009E80 RID: 40576
		private ConditionTask taskInfo_;

		// Token: 0x04009E81 RID: 40577
		public const int LimitBeginTimeFieldNumber = 2;

		// Token: 0x04009E82 RID: 40578
		private long limitBeginTime_;

		// Token: 0x04009E83 RID: 40579
		public const int LimitEndTimeFieldNumber = 3;

		// Token: 0x04009E84 RID: 40580
		private long limitEndTime_;
	}
}
