using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA6 RID: 2726
	public sealed class MotorTaskPb : IMessage<MotorTaskPb>, IMessage, IEquatable<MotorTaskPb>, IDeepCloneable<MotorTaskPb>, IBufferMessage
	{
		// Token: 0x0600ED47 RID: 60743 RVA: 0x0022A1F9 File Offset: 0x002283F9
		[NullableContext(1)]
		public static MotorTaskPb Create()
		{
			return new MotorTaskPb();
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x0600ED48 RID: 60744 RVA: 0x0022A200 File Offset: 0x00228400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorTaskPb> Parser
		{
			get
			{
				return MotorTaskPb._parser;
			}
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x0600ED49 RID: 60745 RVA: 0x0022A207 File Offset: 0x00228407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x0600ED4A RID: 60746 RVA: 0x0022A20A File Offset: 0x0022840A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskPb.Descriptor;
			}
		}

		// Token: 0x0600ED4B RID: 60747 RVA: 0x0022A211 File Offset: 0x00228411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskPb()
		{
		}

		// Token: 0x0600ED4C RID: 60748 RVA: 0x0022A21C File Offset: 0x0022841C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskPb(MotorTaskPb other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.process_ = ((other.process_ != null) ? other.process_.Clone() : null);
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.endTime_ = other.endTime_;
			this.startTime_ = other.startTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED4D RID: 60749 RVA: 0x0022A2A8 File Offset: 0x002284A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskPb Clone()
		{
			return new MotorTaskPb(this);
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0600ED4E RID: 60750 RVA: 0x0022A2B0 File Offset: 0x002284B0
		// (set) Token: 0x0600ED4F RID: 60751 RVA: 0x0022A2B8 File Offset: 0x002284B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0600ED50 RID: 60752 RVA: 0x0022A2C1 File Offset: 0x002284C1
		// (set) Token: 0x0600ED51 RID: 60753 RVA: 0x0022A2C9 File Offset: 0x002284C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskTypePb Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0600ED52 RID: 60754 RVA: 0x0022A2D2 File Offset: 0x002284D2
		// (set) Token: 0x0600ED53 RID: 60755 RVA: 0x0022A2DA File Offset: 0x002284DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskProcessPb Process
		{
			get
			{
				return this.process_;
			}
			set
			{
				this.process_ = value;
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0600ED54 RID: 60756 RVA: 0x0022A2E3 File Offset: 0x002284E3
		// (set) Token: 0x0600ED55 RID: 60757 RVA: 0x0022A2EB File Offset: 0x002284EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskRewardPb Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x0600ED56 RID: 60758 RVA: 0x0022A2F4 File Offset: 0x002284F4
		// (set) Token: 0x0600ED57 RID: 60759 RVA: 0x0022A2FC File Offset: 0x002284FC
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

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0600ED58 RID: 60760 RVA: 0x0022A305 File Offset: 0x00228505
		// (set) Token: 0x0600ED59 RID: 60761 RVA: 0x0022A30D File Offset: 0x0022850D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x0600ED5A RID: 60762 RVA: 0x0022A316 File Offset: 0x00228516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskPb);
		}

		// Token: 0x0600ED5B RID: 60763 RVA: 0x0022A324 File Offset: 0x00228524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this.Process, other.Process) && object.Equals(this.Reward, other.Reward) && this.EndTime == other.EndTime && this.StartTime == other.StartTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED5C RID: 60764 RVA: 0x0022A3B8 File Offset: 0x002285B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != MotorTaskTypePb.Unknown)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.process_ != null)
			{
				num ^= this.Process.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED5D RID: 60765 RVA: 0x0022A474 File Offset: 0x00228674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED5E RID: 60766 RVA: 0x0022A481 File Offset: 0x00228681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED5F RID: 60767 RVA: 0x0022A48C File Offset: 0x0022868C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != MotorTaskTypePb.Unknown)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.process_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Process);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EndTime);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.StartTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED60 RID: 60768 RVA: 0x0022A554 File Offset: 0x00228754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != MotorTaskTypePb.Unknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.process_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Process);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED61 RID: 60769 RVA: 0x0022A60C File Offset: 0x0022880C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != MotorTaskTypePb.Unknown)
			{
				this.Type = other.Type;
			}
			if (other.process_ != null)
			{
				if (this.process_ == null)
				{
					this.Process = new MotorTaskProcessPb();
				}
				this.Process.MergeFrom(other.Process);
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new MotorTaskRewardPb();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED62 RID: 60770 RVA: 0x0022A6DC File Offset: 0x002288DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED63 RID: 60771 RVA: 0x0022A6E8 File Offset: 0x002288E8
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Type = (MotorTaskTypePb)input.ReadEnum();
						continue;
					}
					if (num == 26U)
					{
						if (this.process_ == null)
						{
							this.Process = new MotorTaskProcessPb();
						}
						input.ReadMessage(this.Process);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new MotorTaskRewardPb();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 40U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400601A RID: 24602
		private static readonly MessageParser<MotorTaskPb> _parser = new MessageParser<MotorTaskPb>(() => new MotorTaskPb());

		// Token: 0x0400601B RID: 24603
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400601C RID: 24604
		public const int IdFieldNumber = 1;

		// Token: 0x0400601D RID: 24605
		private int id_;

		// Token: 0x0400601E RID: 24606
		public const int TypeFieldNumber = 2;

		// Token: 0x0400601F RID: 24607
		private MotorTaskTypePb type_;

		// Token: 0x04006020 RID: 24608
		public const int ProcessFieldNumber = 3;

		// Token: 0x04006021 RID: 24609
		private MotorTaskProcessPb process_;

		// Token: 0x04006022 RID: 24610
		public const int RewardFieldNumber = 4;

		// Token: 0x04006023 RID: 24611
		private MotorTaskRewardPb reward_;

		// Token: 0x04006024 RID: 24612
		public const int EndTimeFieldNumber = 5;

		// Token: 0x04006025 RID: 24613
		private long endTime_;

		// Token: 0x04006026 RID: 24614
		public const int StartTimeFieldNumber = 6;

		// Token: 0x04006027 RID: 24615
		private long startTime_;
	}
}
