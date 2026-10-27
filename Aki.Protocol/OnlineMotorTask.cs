using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9E RID: 2974
	public sealed class OnlineMotorTask : IMessage<OnlineMotorTask>, IMessage, IEquatable<OnlineMotorTask>, IDeepCloneable<OnlineMotorTask>, IBufferMessage
	{
		// Token: 0x06010207 RID: 66055 RVA: 0x0025AAE1 File Offset: 0x00258CE1
		[NullableContext(1)]
		public static OnlineMotorTask Create()
		{
			return new OnlineMotorTask();
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x06010208 RID: 66056 RVA: 0x0025AAE8 File Offset: 0x00258CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnlineMotorTask> Parser
		{
			get
			{
				return OnlineMotorTask._parser;
			}
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x06010209 RID: 66057 RVA: 0x0025AAEF File Offset: 0x00258CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0601020A RID: 66058 RVA: 0x0025AAF2 File Offset: 0x00258CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorTask.Descriptor;
			}
		}

		// Token: 0x0601020B RID: 66059 RVA: 0x0025AAF9 File Offset: 0x00258CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTask()
		{
		}

		// Token: 0x0601020C RID: 66060 RVA: 0x0025AB04 File Offset: 0x00258D04
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

		// Token: 0x0601020D RID: 66061 RVA: 0x0025AB70 File Offset: 0x00258D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTask Clone()
		{
			return new OnlineMotorTask(this);
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0601020E RID: 66062 RVA: 0x0025AB78 File Offset: 0x00258D78
		// (set) Token: 0x0601020F RID: 66063 RVA: 0x0025AB80 File Offset: 0x00258D80
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

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x06010210 RID: 66064 RVA: 0x0025AB89 File Offset: 0x00258D89
		// (set) Token: 0x06010211 RID: 66065 RVA: 0x0025AB91 File Offset: 0x00258D91
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

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x06010212 RID: 66066 RVA: 0x0025AB9A File Offset: 0x00258D9A
		// (set) Token: 0x06010213 RID: 66067 RVA: 0x0025ABA2 File Offset: 0x00258DA2
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

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x06010214 RID: 66068 RVA: 0x0025ABAB File Offset: 0x00258DAB
		// (set) Token: 0x06010215 RID: 66069 RVA: 0x0025ABB3 File Offset: 0x00258DB3
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

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x06010216 RID: 66070 RVA: 0x0025ABBC File Offset: 0x00258DBC
		// (set) Token: 0x06010217 RID: 66071 RVA: 0x0025ABC4 File Offset: 0x00258DC4
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

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x06010218 RID: 66072 RVA: 0x0025ABCD File Offset: 0x00258DCD
		// (set) Token: 0x06010219 RID: 66073 RVA: 0x0025ABD5 File Offset: 0x00258DD5
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

		// Token: 0x0601021A RID: 66074 RVA: 0x0025ABDE File Offset: 0x00258DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorTask);
		}

		// Token: 0x0601021B RID: 66075 RVA: 0x0025ABEC File Offset: 0x00258DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorTask other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.State == other.State && this.PlayCount == other.PlayCount && this.Champion == other.Champion && this.SpeedLap == other.SpeedLap && this.FirstRunner == other.FirstRunner && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601021C RID: 66076 RVA: 0x0025AC78 File Offset: 0x00258E78
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

		// Token: 0x0601021D RID: 66077 RVA: 0x0025AD3A File Offset: 0x00258F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601021E RID: 66078 RVA: 0x0025AD47 File Offset: 0x00258F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601021F RID: 66079 RVA: 0x0025AD50 File Offset: 0x00258F50
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

		// Token: 0x06010220 RID: 66080 RVA: 0x0025AE18 File Offset: 0x00259018
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

		// Token: 0x06010221 RID: 66081 RVA: 0x0025AED0 File Offset: 0x002590D0
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

		// Token: 0x06010222 RID: 66082 RVA: 0x0025AF70 File Offset: 0x00259170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010223 RID: 66083 RVA: 0x0025AF7C File Offset: 0x0025917C
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

		// Token: 0x040066C8 RID: 26312
		private static readonly MessageParser<OnlineMotorTask> _parser = new MessageParser<OnlineMotorTask>(() => new OnlineMotorTask());

		// Token: 0x040066C9 RID: 26313
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066CA RID: 26314
		public const int TaskIdFieldNumber = 1;

		// Token: 0x040066CB RID: 26315
		private int taskId_;

		// Token: 0x040066CC RID: 26316
		public const int StateFieldNumber = 2;

		// Token: 0x040066CD RID: 26317
		private ActivityTaskState state_;

		// Token: 0x040066CE RID: 26318
		public const int PlayCountFieldNumber = 3;

		// Token: 0x040066CF RID: 26319
		private int playCount_;

		// Token: 0x040066D0 RID: 26320
		public const int ChampionFieldNumber = 4;

		// Token: 0x040066D1 RID: 26321
		private int champion_;

		// Token: 0x040066D2 RID: 26322
		public const int SpeedLapFieldNumber = 5;

		// Token: 0x040066D3 RID: 26323
		private int speedLap_;

		// Token: 0x040066D4 RID: 26324
		public const int FirstRunnerFieldNumber = 6;

		// Token: 0x040066D5 RID: 26325
		private int firstRunner_;
	}
}
