using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F2 RID: 754
	public sealed class ConsumptiveTaskReward : IMessage<ConsumptiveTaskReward>, IMessage, IEquatable<ConsumptiveTaskReward>, IDeepCloneable<ConsumptiveTaskReward>, IBufferMessage
	{
		// Token: 0x06004CBC RID: 19644 RVA: 0x000BB15F File Offset: 0x000B935F
		[NullableContext(1)]
		public static ConsumptiveTaskReward Create()
		{
			return new ConsumptiveTaskReward();
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06004CBD RID: 19645 RVA: 0x000BB166 File Offset: 0x000B9366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x000BB169 File Offset: 0x000B9369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTaskReward.Descriptor;
			}
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x000BB170 File Offset: 0x000B9370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskReward()
		{
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x000BB178 File Offset: 0x000B9378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskReward(ConsumptiveTaskReward other) : this()
		{
			this.rewarded_ = other.rewarded_;
			this.waitReward_ = other.waitReward_;
			this.maxReward_ = other.maxReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x000BB1B5 File Offset: 0x000B93B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskReward Clone()
		{
			return new ConsumptiveTaskReward(this);
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x000BB1BD File Offset: 0x000B93BD
		// (set) Token: 0x06004CC3 RID: 19651 RVA: 0x000BB1C5 File Offset: 0x000B93C5
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

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x000BB1CE File Offset: 0x000B93CE
		// (set) Token: 0x06004CC5 RID: 19653 RVA: 0x000BB1D6 File Offset: 0x000B93D6
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

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x000BB1DF File Offset: 0x000B93DF
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x000BB1E7 File Offset: 0x000B93E7
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

		// Token: 0x06004CC8 RID: 19656 RVA: 0x000BB1F0 File Offset: 0x000B93F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTaskReward);
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x000BB200 File Offset: 0x000B9400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTaskReward other)
		{
			return other != null && (other == this || (this.Rewarded == other.Rewarded && this.WaitReward == other.WaitReward && this.MaxReward == other.MaxReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x000BB25C File Offset: 0x000B945C
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

		// Token: 0x06004CCB RID: 19659 RVA: 0x000BB2CD File Offset: 0x000B94CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x000BB2DA File Offset: 0x000B94DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x000BB2E4 File Offset: 0x000B94E4
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

		// Token: 0x06004CCE RID: 19662 RVA: 0x000BB358 File Offset: 0x000B9558
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

		// Token: 0x06004CCF RID: 19663 RVA: 0x000BB3C8 File Offset: 0x000B95C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveTaskReward other)
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

		// Token: 0x06004CD0 RID: 19664 RVA: 0x000BB42C File Offset: 0x000B962C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x000BB438 File Offset: 0x000B9638
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

		// Token: 0x0400316C RID: 12652
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400316D RID: 12653
		public const int RewardedFieldNumber = 1;

		// Token: 0x0400316E RID: 12654
		private int rewarded_;

		// Token: 0x0400316F RID: 12655
		public const int WaitRewardFieldNumber = 2;

		// Token: 0x04003170 RID: 12656
		private int waitReward_;

		// Token: 0x04003171 RID: 12657
		public const int MaxRewardFieldNumber = 3;

		// Token: 0x04003172 RID: 12658
		private int maxReward_;
	}
}
