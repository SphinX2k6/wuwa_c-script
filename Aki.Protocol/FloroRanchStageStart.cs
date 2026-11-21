using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D1 RID: 1489
	public sealed class FloroRanchStageStart : IMessage<FloroRanchStageStart>, IMessage, IEquatable<FloroRanchStageStart>, IDeepCloneable<FloroRanchStageStart>, IBufferMessage
	{
		// Token: 0x06008A54 RID: 35412 RVA: 0x0014F526 File Offset: 0x0014D726
		[NullableContext(1)]
		public static FloroRanchStageStart Create()
		{
			return new FloroRanchStageStart();
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06008A55 RID: 35413 RVA: 0x0014F52D File Offset: 0x0014D72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06008A56 RID: 35414 RVA: 0x0014F530 File Offset: 0x0014D730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchStageStart.Descriptor;
			}
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x0014F537 File Offset: 0x0014D737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageStart()
		{
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x0014F53F File Offset: 0x0014D73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageStart(FloroRanchStageStart other) : this()
		{
			this.target_ = other.target_;
			this.dayCount_ = other.dayCount_;
			this.reward_ = other.reward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x0014F57C File Offset: 0x0014D77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageStart Clone()
		{
			return new FloroRanchStageStart(this);
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06008A5A RID: 35418 RVA: 0x0014F584 File Offset: 0x0014D784
		// (set) Token: 0x06008A5B RID: 35419 RVA: 0x0014F58C File Offset: 0x0014D78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Target
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

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06008A5C RID: 35420 RVA: 0x0014F595 File Offset: 0x0014D795
		// (set) Token: 0x06008A5D RID: 35421 RVA: 0x0014F59D File Offset: 0x0014D79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DayCount
		{
			get
			{
				return this.dayCount_;
			}
			set
			{
				this.dayCount_ = value;
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06008A5E RID: 35422 RVA: 0x0014F5A6 File Offset: 0x0014D7A6
		// (set) Token: 0x06008A5F RID: 35423 RVA: 0x0014F5AE File Offset: 0x0014D7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Reward
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

		// Token: 0x06008A60 RID: 35424 RVA: 0x0014F5B7 File Offset: 0x0014D7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchStageStart);
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x0014F5C8 File Offset: 0x0014D7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchStageStart other)
		{
			return other != null && (other == this || (this.Target == other.Target && this.DayCount == other.DayCount && this.Reward == other.Reward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x0014F624 File Offset: 0x0014D824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Target != 0L)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.DayCount != 0)
			{
				num ^= this.DayCount.GetHashCode();
			}
			if (this.Reward != 0L)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x0014F695 File Offset: 0x0014D895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x0014F6A2 File Offset: 0x0014D8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x0014F6AC File Offset: 0x0014D8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Target != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Target);
			}
			if (this.DayCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DayCount);
			}
			if (this.Reward != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x0014F720 File Offset: 0x0014D920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Target != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Target);
			}
			if (this.DayCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DayCount);
			}
			if (this.Reward != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x0014F790 File Offset: 0x0014D990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchStageStart other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Target != 0L)
			{
				this.Target = other.Target;
			}
			if (other.DayCount != 0)
			{
				this.DayCount = other.DayCount;
			}
			if (other.Reward != 0L)
			{
				this.Reward = other.Reward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x0014F7F4 File Offset: 0x0014D9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x0014F800 File Offset: 0x0014DA00
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reward = input.ReadInt64();
						}
					}
					else
					{
						this.DayCount = input.ReadInt32();
					}
				}
				else
				{
					this.Target = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004476 RID: 17526
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004477 RID: 17527
		public const int TargetFieldNumber = 1;

		// Token: 0x04004478 RID: 17528
		private long target_;

		// Token: 0x04004479 RID: 17529
		public const int DayCountFieldNumber = 2;

		// Token: 0x0400447A RID: 17530
		private int dayCount_;

		// Token: 0x0400447B RID: 17531
		public const int RewardFieldNumber = 3;

		// Token: 0x0400447C RID: 17532
		private long reward_;
	}
}
