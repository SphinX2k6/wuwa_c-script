using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D5 RID: 725
	public sealed class ConditionTask : IMessage<ConditionTask>, IMessage, IEquatable<ConditionTask>, IDeepCloneable<ConditionTask>, IBufferMessage
	{
		// Token: 0x06004A75 RID: 19061 RVA: 0x000B64B1 File Offset: 0x000B46B1
		[NullableContext(1)]
		public static ConditionTask Create()
		{
			return new ConditionTask();
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06004A76 RID: 19062 RVA: 0x000B64B8 File Offset: 0x000B46B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionTask> Parser
		{
			get
			{
				return ConditionTask._parser;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x000B64BF File Offset: 0x000B46BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06004A78 RID: 19064 RVA: 0x000B64C2 File Offset: 0x000B46C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionTask.Descriptor;
			}
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x000B64C9 File Offset: 0x000B46C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask()
		{
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x000B64D4 File Offset: 0x000B46D4
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

		// Token: 0x06004A7B RID: 19067 RVA: 0x000B6528 File Offset: 0x000B4728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Clone()
		{
			return new ConditionTask(this);
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x000B6530 File Offset: 0x000B4730
		// (set) Token: 0x06004A7D RID: 19069 RVA: 0x000B6538 File Offset: 0x000B4738
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

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x000B6541 File Offset: 0x000B4741
		// (set) Token: 0x06004A7F RID: 19071 RVA: 0x000B6549 File Offset: 0x000B4749
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

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x000B6552 File Offset: 0x000B4752
		// (set) Token: 0x06004A81 RID: 19073 RVA: 0x000B655A File Offset: 0x000B475A
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x000B6563 File Offset: 0x000B4763
		// (set) Token: 0x06004A83 RID: 19075 RVA: 0x000B656B File Offset: 0x000B476B
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

		// Token: 0x06004A84 RID: 19076 RVA: 0x000B6574 File Offset: 0x000B4774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionTask);
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x000B6584 File Offset: 0x000B4784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x000B65F0 File Offset: 0x000B47F0
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

		// Token: 0x06004A87 RID: 19079 RVA: 0x000B6680 File Offset: 0x000B4880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x000B668D File Offset: 0x000B488D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x000B6698 File Offset: 0x000B4898
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

		// Token: 0x06004A8A RID: 19082 RVA: 0x000B6728 File Offset: 0x000B4928
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

		// Token: 0x06004A8B RID: 19083 RVA: 0x000B67B0 File Offset: 0x000B49B0
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

		// Token: 0x06004A8C RID: 19084 RVA: 0x000B6828 File Offset: 0x000B4A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x000B6834 File Offset: 0x000B4A34
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

		// Token: 0x040030D1 RID: 12497
		private static readonly MessageParser<ConditionTask> _parser = new MessageParser<ConditionTask>(() => new ConditionTask());

		// Token: 0x040030D2 RID: 12498
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030D3 RID: 12499
		public const int IdFieldNumber = 1;

		// Token: 0x040030D4 RID: 12500
		private int id_;

		// Token: 0x040030D5 RID: 12501
		public const int CurrentFieldNumber = 2;

		// Token: 0x040030D6 RID: 12502
		private int current_;

		// Token: 0x040030D7 RID: 12503
		public const int TargetFieldNumber = 3;

		// Token: 0x040030D8 RID: 12504
		private int target_;

		// Token: 0x040030D9 RID: 12505
		public const int StatusFieldNumber = 4;

		// Token: 0x040030DA RID: 12506
		private ConditionTaskState status_;
	}
}
