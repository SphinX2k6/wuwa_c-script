using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8E RID: 2958
	public sealed class OnlineMotorTask : IMessage<OnlineMotorTask>, IMessage, IEquatable<OnlineMotorTask>, IDeepCloneable<OnlineMotorTask>, IBufferMessage
	{
		// Token: 0x06010103 RID: 65795 RVA: 0x00258C15 File Offset: 0x00256E15
		[NullableContext(1)]
		public static OnlineMotorTask Create()
		{
			return new OnlineMotorTask();
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x06010104 RID: 65796 RVA: 0x00258C1C File Offset: 0x00256E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnlineMotorTask> Parser
		{
			get
			{
				return OnlineMotorTask._parser;
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x06010105 RID: 65797 RVA: 0x00258C23 File Offset: 0x00256E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x06010106 RID: 65798 RVA: 0x00258C26 File Offset: 0x00256E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorTask.Descriptor;
			}
		}

		// Token: 0x06010107 RID: 65799 RVA: 0x00258C2D File Offset: 0x00256E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTask()
		{
		}

		// Token: 0x06010108 RID: 65800 RVA: 0x00258C38 File Offset: 0x00256E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTask(OnlineMotorTask other) : this()
		{
			this.taskId_ = other.taskId_;
			this.state_ = other.state_;
			this.playCount_ = other.playCount_;
			this.champion_ = other.champion_;
			this.speedLap_ = other.speedLap_;
			this.firstRunner_ = other.firstRunner_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010109 RID: 65801 RVA: 0x00258CA4 File Offset: 0x00256EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTask Clone()
		{
			return new OnlineMotorTask(this);
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0601010A RID: 65802 RVA: 0x00258CAC File Offset: 0x00256EAC
		// (set) Token: 0x0601010B RID: 65803 RVA: 0x00258CB4 File Offset: 0x00256EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0601010C RID: 65804 RVA: 0x00258CBD File Offset: 0x00256EBD
		// (set) Token: 0x0601010D RID: 65805 RVA: 0x00258CC5 File Offset: 0x00256EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0601010E RID: 65806 RVA: 0x00258CCE File Offset: 0x00256ECE
		// (set) Token: 0x0601010F RID: 65807 RVA: 0x00258CD6 File Offset: 0x00256ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayCount
		{
			get
			{
				return this.playCount_;
			}
			set
			{
				this.playCount_ = value;
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x06010110 RID: 65808 RVA: 0x00258CDF File Offset: 0x00256EDF
		// (set) Token: 0x06010111 RID: 65809 RVA: 0x00258CE7 File Offset: 0x00256EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Champion
		{
			get
			{
				return this.champion_;
			}
			set
			{
				this.champion_ = value;
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x06010112 RID: 65810 RVA: 0x00258CF0 File Offset: 0x00256EF0
		// (set) Token: 0x06010113 RID: 65811 RVA: 0x00258CF8 File Offset: 0x00256EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpeedLap
		{
			get
			{
				return this.speedLap_;
			}
			set
			{
				this.speedLap_ = value;
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x06010114 RID: 65812 RVA: 0x00258D01 File Offset: 0x00256F01
		// (set) Token: 0x06010115 RID: 65813 RVA: 0x00258D09 File Offset: 0x00256F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstRunner
		{
			get
			{
				return this.firstRunner_;
			}
			set
			{
				this.firstRunner_ = value;
			}
		}

		// Token: 0x06010116 RID: 65814 RVA: 0x00258D12 File Offset: 0x00256F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorTask);
		}

		// Token: 0x06010117 RID: 65815 RVA: 0x00258D20 File Offset: 0x00256F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorTask other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.State == other.State && this.PlayCount == other.PlayCount && this.Champion == other.Champion && this.SpeedLap == other.SpeedLap && this.FirstRunner == other.FirstRunner && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010118 RID: 65816 RVA: 0x00258DAC File Offset: 0x00256FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.State != ActivityTaskState.ActivityTaskRunning)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.PlayCount != 0)
			{
				num ^= this.PlayCount.GetHashCode();
			}
			if (this.Champion != 0)
			{
				num ^= this.Champion.GetHashCode();
			}
			if (this.SpeedLap != 0)
			{
				num ^= this.SpeedLap.GetHashCode();
			}
			if (this.FirstRunner != 0)
			{
				num ^= this.FirstRunner.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010119 RID: 65817 RVA: 0x00258E6E File Offset: 0x0025706E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601011A RID: 65818 RVA: 0x00258E7B File Offset: 0x0025707B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601011B RID: 65819 RVA: 0x00258E84 File Offset: 0x00257084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this.State != ActivityTaskState.ActivityTaskRunning)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.PlayCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayCount);
			}
			if (this.Champion != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Champion);
			}
			if (this.SpeedLap != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SpeedLap);
			}
			if (this.FirstRunner != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FirstRunner);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601011C RID: 65820 RVA: 0x00258F4C File Offset: 0x0025714C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.State != ActivityTaskState.ActivityTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.PlayCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayCount);
			}
			if (this.Champion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Champion);
			}
			if (this.SpeedLap != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpeedLap);
			}
			if (this.FirstRunner != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstRunner);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601011D RID: 65821 RVA: 0x00259004 File Offset: 0x00257204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.State != ActivityTaskState.ActivityTaskRunning)
			{
				this.State = other.State;
			}
			if (other.PlayCount != 0)
			{
				this.PlayCount = other.PlayCount;
			}
			if (other.Champion != 0)
			{
				this.Champion = other.Champion;
			}
			if (other.SpeedLap != 0)
			{
				this.SpeedLap = other.SpeedLap;
			}
			if (other.FirstRunner != 0)
			{
				this.FirstRunner = other.FirstRunner;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601011E RID: 65822 RVA: 0x002590A4 File Offset: 0x002572A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601011F RID: 65823 RVA: 0x002590B0 File Offset: 0x002572B0
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.TaskId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.State = (ActivityTaskState)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.PlayCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Champion = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.SpeedLap = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.FirstRunner = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040066D8 RID: 26328
		private static readonly MessageParser<OnlineMotorTask> _parser = new MessageParser<OnlineMotorTask>(() => new OnlineMotorTask());

		// Token: 0x040066D9 RID: 26329
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066DA RID: 26330
		public const int TaskIdFieldNumber = 1;

		// Token: 0x040066DB RID: 26331
		private int taskId_;

		// Token: 0x040066DC RID: 26332
		public const int StateFieldNumber = 2;

		// Token: 0x040066DD RID: 26333
		private ActivityTaskState state_;

		// Token: 0x040066DE RID: 26334
		public const int PlayCountFieldNumber = 3;

		// Token: 0x040066DF RID: 26335
		private int playCount_;

		// Token: 0x040066E0 RID: 26336
		public const int ChampionFieldNumber = 4;

		// Token: 0x040066E1 RID: 26337
		private int champion_;

		// Token: 0x040066E2 RID: 26338
		public const int SpeedLapFieldNumber = 5;

		// Token: 0x040066E3 RID: 26339
		private int speedLap_;

		// Token: 0x040066E4 RID: 26340
		public const int FirstRunnerFieldNumber = 6;

		// Token: 0x040066E5 RID: 26341
		private int firstRunner_;
	}
}
