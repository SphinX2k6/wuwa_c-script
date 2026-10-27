using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CE RID: 718
	public sealed class ConditionTask : IMessage<ConditionTask>, IMessage, IEquatable<ConditionTask>, IDeepCloneable<ConditionTask>, IBufferMessage
	{
		// Token: 0x0600499C RID: 18844 RVA: 0x000B40C9 File Offset: 0x000B22C9
		[NullableContext(1)]
		public static ConditionTask Create()
		{
			return new ConditionTask();
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x000B40D0 File Offset: 0x000B22D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionTask> Parser
		{
			get
			{
				return ConditionTask._parser;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x0600499E RID: 18846 RVA: 0x000B40D7 File Offset: 0x000B22D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x0600499F RID: 18847 RVA: 0x000B40DA File Offset: 0x000B22DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionTask.Descriptor;
			}
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x000B40E1 File Offset: 0x000B22E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask()
		{
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x000B40EC File Offset: 0x000B22EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask(ConditionTask other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x000B4140 File Offset: 0x000B2340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Clone()
		{
			return new ConditionTask(this);
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x000B4148 File Offset: 0x000B2348
		// (set) Token: 0x060049A4 RID: 18852 RVA: 0x000B4150 File Offset: 0x000B2350
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

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x000B4159 File Offset: 0x000B2359
		// (set) Token: 0x060049A6 RID: 18854 RVA: 0x000B4161 File Offset: 0x000B2361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x000B416A File Offset: 0x000B236A
		// (set) Token: 0x060049A8 RID: 18856 RVA: 0x000B4172 File Offset: 0x000B2372
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

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x000B417B File Offset: 0x000B237B
		// (set) Token: 0x060049AA RID: 18858 RVA: 0x000B4183 File Offset: 0x000B2383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTaskState Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x000B418C File Offset: 0x000B238C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionTask);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x000B419C File Offset: 0x000B239C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x000B4208 File Offset: 0x000B2408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.Status != ConditionTaskState.ConditionTaskRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x000B4298 File Offset: 0x000B2498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x000B42A5 File Offset: 0x000B24A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x000B42B0 File Offset: 0x000B24B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this.Status != ConditionTaskState.ConditionTaskRunning)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x000B4340 File Offset: 0x000B2540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.Status != ConditionTaskState.ConditionTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x000B43C8 File Offset: 0x000B25C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.Status != ConditionTaskState.ConditionTaskRunning)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x000B4440 File Offset: 0x000B2640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x000B444C File Offset: 0x000B264C
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Current = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Status = (ConditionTaskState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400303A RID: 12346
		private static readonly MessageParser<ConditionTask> _parser = new MessageParser<ConditionTask>(() => new ConditionTask());

		// Token: 0x0400303B RID: 12347
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400303C RID: 12348
		public const int IdFieldNumber = 1;

		// Token: 0x0400303D RID: 12349
		private int id_;

		// Token: 0x0400303E RID: 12350
		public const int CurrentFieldNumber = 2;

		// Token: 0x0400303F RID: 12351
		private int current_;

		// Token: 0x04003040 RID: 12352
		public const int TargetFieldNumber = 3;

		// Token: 0x04003041 RID: 12353
		private int target_;

		// Token: 0x04003042 RID: 12354
		public const int StatusFieldNumber = 4;

		// Token: 0x04003043 RID: 12355
		private ConditionTaskState status_;
	}
}
