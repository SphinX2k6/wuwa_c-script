using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA8 RID: 2728
	public sealed class MotorTaskRewardPb : IMessage<MotorTaskRewardPb>, IMessage, IEquatable<MotorTaskRewardPb>, IDeepCloneable<MotorTaskRewardPb>, IBufferMessage
	{
		// Token: 0x0600ED79 RID: 60793 RVA: 0x0022AA73 File Offset: 0x00228C73
		[NullableContext(1)]
		public static MotorTaskRewardPb Create()
		{
			return new MotorTaskRewardPb();
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0600ED7A RID: 60794 RVA: 0x0022AA7A File Offset: 0x00228C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0600ED7B RID: 60795 RVA: 0x0022AA7D File Offset: 0x00228C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskRewardPb.Descriptor;
			}
		}

		// Token: 0x0600ED7C RID: 60796 RVA: 0x0022AA84 File Offset: 0x00228C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskRewardPb()
		{
		}

		// Token: 0x0600ED7D RID: 60797 RVA: 0x0022AA8C File Offset: 0x00228C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskRewardPb(MotorTaskRewardPb other) : this()
		{
			this.rewarded_ = other.rewarded_;
			this.waitReward_ = other.waitReward_;
			this.maxReward_ = other.maxReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED7E RID: 60798 RVA: 0x0022AAC9 File Offset: 0x00228CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskRewardPb Clone()
		{
			return new MotorTaskRewardPb(this);
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x0600ED7F RID: 60799 RVA: 0x0022AAD1 File Offset: 0x00228CD1
		// (set) Token: 0x0600ED80 RID: 60800 RVA: 0x0022AAD9 File Offset: 0x00228CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0600ED81 RID: 60801 RVA: 0x0022AAE2 File Offset: 0x00228CE2
		// (set) Token: 0x0600ED82 RID: 60802 RVA: 0x0022AAEA File Offset: 0x00228CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaitReward
		{
			get
			{
				return this.waitReward_;
			}
			set
			{
				this.waitReward_ = value;
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x0600ED83 RID: 60803 RVA: 0x0022AAF3 File Offset: 0x00228CF3
		// (set) Token: 0x0600ED84 RID: 60804 RVA: 0x0022AAFB File Offset: 0x00228CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxReward
		{
			get
			{
				return this.maxReward_;
			}
			set
			{
				this.maxReward_ = value;
			}
		}

		// Token: 0x0600ED85 RID: 60805 RVA: 0x0022AB04 File Offset: 0x00228D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskRewardPb);
		}

		// Token: 0x0600ED86 RID: 60806 RVA: 0x0022AB14 File Offset: 0x00228D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskRewardPb other)
		{
			return other != null && (other == this || (this.Rewarded == other.Rewarded && this.WaitReward == other.WaitReward && this.MaxReward == other.MaxReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED87 RID: 60807 RVA: 0x0022AB70 File Offset: 0x00228D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Rewarded != 0)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this.WaitReward != 0)
			{
				num ^= this.WaitReward.GetHashCode();
			}
			if (this.MaxReward != 0)
			{
				num ^= this.MaxReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED88 RID: 60808 RVA: 0x0022ABE1 File Offset: 0x00228DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED89 RID: 60809 RVA: 0x0022ABEE File Offset: 0x00228DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED8A RID: 60810 RVA: 0x0022ABF8 File Offset: 0x00228DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Rewarded != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Rewarded);
			}
			if (this.WaitReward != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WaitReward);
			}
			if (this.MaxReward != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED8B RID: 60811 RVA: 0x0022AC6C File Offset: 0x00228E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Rewarded != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rewarded);
			}
			if (this.WaitReward != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaitReward);
			}
			if (this.MaxReward != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxReward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED8C RID: 60812 RVA: 0x0022ACDC File Offset: 0x00228EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskRewardPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Rewarded != 0)
			{
				this.Rewarded = other.Rewarded;
			}
			if (other.WaitReward != 0)
			{
				this.WaitReward = other.WaitReward;
			}
			if (other.MaxReward != 0)
			{
				this.MaxReward = other.MaxReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED8D RID: 60813 RVA: 0x0022AD40 File Offset: 0x00228F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED8E RID: 60814 RVA: 0x0022AD4C File Offset: 0x00228F4C
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
							this.MaxReward = input.ReadInt32();
						}
					}
					else
					{
						this.WaitReward = input.ReadInt32();
					}
				}
				else
				{
					this.Rewarded = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400602D RID: 24621
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400602E RID: 24622
		public const int RewardedFieldNumber = 1;

		// Token: 0x0400602F RID: 24623
		private int rewarded_;

		// Token: 0x04006030 RID: 24624
		public const int WaitRewardFieldNumber = 2;

		// Token: 0x04006031 RID: 24625
		private int waitReward_;

		// Token: 0x04006032 RID: 24626
		public const int MaxRewardFieldNumber = 3;

		// Token: 0x04006033 RID: 24627
		private int maxReward_;
	}
}
