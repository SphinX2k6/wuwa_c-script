using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EF RID: 751
	public sealed class ConsumptiveTaskInfo : IMessage<ConsumptiveTaskInfo>, IMessage, IEquatable<ConsumptiveTaskInfo>, IDeepCloneable<ConsumptiveTaskInfo>, IBufferMessage
	{
		// Token: 0x06004C7C RID: 19580 RVA: 0x000BA80A File Offset: 0x000B8A0A
		[NullableContext(1)]
		public static ConsumptiveTaskInfo Create()
		{
			return new ConsumptiveTaskInfo();
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x000BA811 File Offset: 0x000B8A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConsumptiveTaskInfo> Parser
		{
			get
			{
				return ConsumptiveTaskInfo._parser;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x000BA818 File Offset: 0x000B8A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x000BA81B File Offset: 0x000B8A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTaskInfo.Descriptor;
			}
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x000BA822 File Offset: 0x000B8A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfo()
		{
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x000BA82C File Offset: 0x000B8A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfo(ConsumptiveTaskInfo other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.process_ = ((other.process_ != null) ? other.process_.Clone() : null);
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x000BA8A0 File Offset: 0x000B8AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfo Clone()
		{
			return new ConsumptiveTaskInfo(this);
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x000BA8A8 File Offset: 0x000B8AA8
		// (set) Token: 0x06004C84 RID: 19588 RVA: 0x000BA8B0 File Offset: 0x000B8AB0
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

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06004C85 RID: 19589 RVA: 0x000BA8B9 File Offset: 0x000B8AB9
		// (set) Token: 0x06004C86 RID: 19590 RVA: 0x000BA8C1 File Offset: 0x000B8AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskType Type
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

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x000BA8CA File Offset: 0x000B8ACA
		// (set) Token: 0x06004C88 RID: 19592 RVA: 0x000BA8D2 File Offset: 0x000B8AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskProcess Process
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

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x000BA8DB File Offset: 0x000B8ADB
		// (set) Token: 0x06004C8A RID: 19594 RVA: 0x000BA8E3 File Offset: 0x000B8AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskReward Reward
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

		// Token: 0x06004C8B RID: 19595 RVA: 0x000BA8EC File Offset: 0x000B8AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTaskInfo);
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x000BA8FC File Offset: 0x000B8AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTaskInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this.Process, other.Process) && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x000BA970 File Offset: 0x000B8B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != ConsumptiveTaskType.Unknown)
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x000BA9FA File Offset: 0x000B8BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x000BAA07 File Offset: 0x000B8C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x000BAA10 File Offset: 0x000B8C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != ConsumptiveTaskType.Unknown)
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x000BAAA0 File Offset: 0x000B8CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != ConsumptiveTaskType.Unknown)
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x000BAB28 File Offset: 0x000B8D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveTaskInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != ConsumptiveTaskType.Unknown)
			{
				this.Type = other.Type;
			}
			if (other.process_ != null)
			{
				if (this.process_ == null)
				{
					this.Process = new ConsumptiveTaskProcess();
				}
				this.Process.MergeFrom(other.Process);
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ConsumptiveTaskReward();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x000BABD0 File Offset: 0x000B8DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x000BABDC File Offset: 0x000B8DDC
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
						this.Type = (ConsumptiveTaskType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.process_ == null)
						{
							this.Process = new ConsumptiveTaskProcess();
						}
						input.ReadMessage(this.Process);
						continue;
					}
					if (num == 34U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ConsumptiveTaskReward();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400315A RID: 12634
		private static readonly MessageParser<ConsumptiveTaskInfo> _parser = new MessageParser<ConsumptiveTaskInfo>(() => new ConsumptiveTaskInfo());

		// Token: 0x0400315B RID: 12635
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400315C RID: 12636
		public const int IdFieldNumber = 1;

		// Token: 0x0400315D RID: 12637
		private int id_;

		// Token: 0x0400315E RID: 12638
		public const int TypeFieldNumber = 2;

		// Token: 0x0400315F RID: 12639
		private ConsumptiveTaskType type_;

		// Token: 0x04003160 RID: 12640
		public const int ProcessFieldNumber = 3;

		// Token: 0x04003161 RID: 12641
		private ConsumptiveTaskProcess process_;

		// Token: 0x04003162 RID: 12642
		public const int RewardFieldNumber = 4;

		// Token: 0x04003163 RID: 12643
		private ConsumptiveTaskReward reward_;
	}
}
