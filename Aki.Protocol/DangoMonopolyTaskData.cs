using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000390 RID: 912
	public sealed class DangoMonopolyTaskData : IMessage<DangoMonopolyTaskData>, IMessage, IEquatable<DangoMonopolyTaskData>, IDeepCloneable<DangoMonopolyTaskData>, IBufferMessage
	{
		// Token: 0x06005A15 RID: 23061 RVA: 0x000DB460 File Offset: 0x000D9660
		[NullableContext(1)]
		public static DangoMonopolyTaskData Create()
		{
			return new DangoMonopolyTaskData();
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06005A16 RID: 23062 RVA: 0x000DB467 File Offset: 0x000D9667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoMonopolyTaskData> Parser
		{
			get
			{
				return DangoMonopolyTaskData._parser;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06005A17 RID: 23063 RVA: 0x000DB46E File Offset: 0x000D966E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06005A18 RID: 23064 RVA: 0x000DB471 File Offset: 0x000D9671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskData.Descriptor;
			}
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x000DB478 File Offset: 0x000D9678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskData()
		{
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x000DB480 File Offset: 0x000D9680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskData(DangoMonopolyTaskData other) : this()
		{
			this.taskId_ = other.taskId_;
			this.state_ = other.state_;
			this.progress_ = other.progress_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x000DB4D4 File Offset: 0x000D96D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskData Clone()
		{
			return new DangoMonopolyTaskData(this);
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06005A1C RID: 23068 RVA: 0x000DB4DC File Offset: 0x000D96DC
		// (set) Token: 0x06005A1D RID: 23069 RVA: 0x000DB4E4 File Offset: 0x000D96E4
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

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06005A1E RID: 23070 RVA: 0x000DB4ED File Offset: 0x000D96ED
		// (set) Token: 0x06005A1F RID: 23071 RVA: 0x000DB4F5 File Offset: 0x000D96F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskState State
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

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06005A20 RID: 23072 RVA: 0x000DB4FE File Offset: 0x000D96FE
		// (set) Token: 0x06005A21 RID: 23073 RVA: 0x000DB506 File Offset: 0x000D9706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06005A22 RID: 23074 RVA: 0x000DB50F File Offset: 0x000D970F
		// (set) Token: 0x06005A23 RID: 23075 RVA: 0x000DB517 File Offset: 0x000D9717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x000DB520 File Offset: 0x000D9720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskData);
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x000DB530 File Offset: 0x000D9730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskData other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.State == other.State && this.Progress == other.Progress && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x000DB59C File Offset: 0x000D979C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.State != DangoMonopolyTaskState.NotCompleted)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x000DB62C File Offset: 0x000D982C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x000DB639 File Offset: 0x000D9839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x000DB644 File Offset: 0x000D9844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this.State != DangoMonopolyTaskState.NotCompleted)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Progress);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Target);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x000DB6D4 File Offset: 0x000D98D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.State != DangoMonopolyTaskState.NotCompleted)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x000DB75C File Offset: 0x000D995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.State != DangoMonopolyTaskState.NotCompleted)
			{
				this.State = other.State;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x000DB7D4 File Offset: 0x000D99D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x000DB7E0 File Offset: 0x000D99E0
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
					if (num == 8U)
					{
						this.TaskId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.State = (DangoMonopolyTaskState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Progress = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003598 RID: 13720
		private static readonly MessageParser<DangoMonopolyTaskData> _parser = new MessageParser<DangoMonopolyTaskData>(() => new DangoMonopolyTaskData());

		// Token: 0x04003599 RID: 13721
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400359A RID: 13722
		public const int TaskIdFieldNumber = 1;

		// Token: 0x0400359B RID: 13723
		private int taskId_;

		// Token: 0x0400359C RID: 13724
		public const int StateFieldNumber = 2;

		// Token: 0x0400359D RID: 13725
		private DangoMonopolyTaskState state_;

		// Token: 0x0400359E RID: 13726
		public const int ProgressFieldNumber = 3;

		// Token: 0x0400359F RID: 13727
		private int progress_;

		// Token: 0x040035A0 RID: 13728
		public const int TargetFieldNumber = 4;

		// Token: 0x040035A1 RID: 13729
		private int target_;
	}
}
