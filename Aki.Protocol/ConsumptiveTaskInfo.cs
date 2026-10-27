using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E8 RID: 744
	public sealed class ConsumptiveTaskInfo : IMessage<ConsumptiveTaskInfo>, IMessage, IEquatable<ConsumptiveTaskInfo>, IDeepCloneable<ConsumptiveTaskInfo>, IBufferMessage
	{
		// Token: 0x06004BA3 RID: 19363 RVA: 0x000B8422 File Offset: 0x000B6622
		[NullableContext(1)]
		public static ConsumptiveTaskInfo Create()
		{
			return new ConsumptiveTaskInfo();
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06004BA4 RID: 19364 RVA: 0x000B8429 File Offset: 0x000B6629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConsumptiveTaskInfo> Parser
		{
			get
			{
				return ConsumptiveTaskInfo._parser;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x000B8430 File Offset: 0x000B6630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x000B8433 File Offset: 0x000B6633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTaskInfo.Descriptor;
			}
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x000B843A File Offset: 0x000B663A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfo()
		{
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x000B8444 File Offset: 0x000B6644
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

		// Token: 0x06004BA9 RID: 19369 RVA: 0x000B84B8 File Offset: 0x000B66B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfo Clone()
		{
			return new ConsumptiveTaskInfo(this);
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x000B84C0 File Offset: 0x000B66C0
		// (set) Token: 0x06004BAB RID: 19371 RVA: 0x000B84C8 File Offset: 0x000B66C8
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

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06004BAC RID: 19372 RVA: 0x000B84D1 File Offset: 0x000B66D1
		// (set) Token: 0x06004BAD RID: 19373 RVA: 0x000B84D9 File Offset: 0x000B66D9
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

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06004BAE RID: 19374 RVA: 0x000B84E2 File Offset: 0x000B66E2
		// (set) Token: 0x06004BAF RID: 19375 RVA: 0x000B84EA File Offset: 0x000B66EA
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

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06004BB0 RID: 19376 RVA: 0x000B84F3 File Offset: 0x000B66F3
		// (set) Token: 0x06004BB1 RID: 19377 RVA: 0x000B84FB File Offset: 0x000B66FB
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

		// Token: 0x06004BB2 RID: 19378 RVA: 0x000B8504 File Offset: 0x000B6704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTaskInfo);
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x000B8514 File Offset: 0x000B6714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTaskInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this.Process, other.Process) && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x000B8588 File Offset: 0x000B6788
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

		// Token: 0x06004BB5 RID: 19381 RVA: 0x000B8612 File Offset: 0x000B6812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x000B861F File Offset: 0x000B681F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x000B8628 File Offset: 0x000B6828
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

		// Token: 0x06004BB8 RID: 19384 RVA: 0x000B86B8 File Offset: 0x000B68B8
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

		// Token: 0x06004BB9 RID: 19385 RVA: 0x000B8740 File Offset: 0x000B6940
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

		// Token: 0x06004BBA RID: 19386 RVA: 0x000B87E8 File Offset: 0x000B69E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x000B87F4 File Offset: 0x000B69F4
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

		// Token: 0x040030C3 RID: 12483
		private static readonly MessageParser<ConsumptiveTaskInfo> _parser = new MessageParser<ConsumptiveTaskInfo>(() => new ConsumptiveTaskInfo());

		// Token: 0x040030C4 RID: 12484
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030C5 RID: 12485
		public const int IdFieldNumber = 1;

		// Token: 0x040030C6 RID: 12486
		private int id_;

		// Token: 0x040030C7 RID: 12487
		public const int TypeFieldNumber = 2;

		// Token: 0x040030C8 RID: 12488
		private ConsumptiveTaskType type_;

		// Token: 0x040030C9 RID: 12489
		public const int ProcessFieldNumber = 3;

		// Token: 0x040030CA RID: 12490
		private ConsumptiveTaskProcess process_;

		// Token: 0x040030CB RID: 12491
		public const int RewardFieldNumber = 4;

		// Token: 0x040030CC RID: 12492
		private ConsumptiveTaskReward reward_;
	}
}
