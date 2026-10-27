using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EB RID: 747
	public sealed class ConsumptiveTaskReward : IMessage<ConsumptiveTaskReward>, IMessage, IEquatable<ConsumptiveTaskReward>, IDeepCloneable<ConsumptiveTaskReward>, IBufferMessage
	{
		// Token: 0x06004BE3 RID: 19427 RVA: 0x000B8D77 File Offset: 0x000B6F77
		[NullableContext(1)]
		public static ConsumptiveTaskReward Create()
		{
			return new ConsumptiveTaskReward();
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x000B8D7E File Offset: 0x000B6F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x000B8D81 File Offset: 0x000B6F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTaskReward.Descriptor;
			}
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x000B8D88 File Offset: 0x000B6F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskReward()
		{
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x000B8D90 File Offset: 0x000B6F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskReward(ConsumptiveTaskReward other) : this()
		{
			this.rewarded_ = other.rewarded_;
			this.waitReward_ = other.waitReward_;
			this.maxReward_ = other.maxReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x000B8DCD File Offset: 0x000B6FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskReward Clone()
		{
			return new ConsumptiveTaskReward(this);
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x000B8DD5 File Offset: 0x000B6FD5
		// (set) Token: 0x06004BEA RID: 19434 RVA: 0x000B8DDD File Offset: 0x000B6FDD
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

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x000B8DE6 File Offset: 0x000B6FE6
		// (set) Token: 0x06004BEC RID: 19436 RVA: 0x000B8DEE File Offset: 0x000B6FEE
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

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x000B8DF7 File Offset: 0x000B6FF7
		// (set) Token: 0x06004BEE RID: 19438 RVA: 0x000B8DFF File Offset: 0x000B6FFF
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

		// Token: 0x06004BEF RID: 19439 RVA: 0x000B8E08 File Offset: 0x000B7008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTaskReward);
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x000B8E18 File Offset: 0x000B7018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTaskReward other)
		{
			return other != null && (other == this || (this.Rewarded == other.Rewarded && this.WaitReward == other.WaitReward && this.MaxReward == other.MaxReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x000B8E74 File Offset: 0x000B7074
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

		// Token: 0x06004BF2 RID: 19442 RVA: 0x000B8EE5 File Offset: 0x000B70E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x000B8EF2 File Offset: 0x000B70F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x000B8EFC File Offset: 0x000B70FC
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

		// Token: 0x06004BF5 RID: 19445 RVA: 0x000B8F70 File Offset: 0x000B7170
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

		// Token: 0x06004BF6 RID: 19446 RVA: 0x000B8FE0 File Offset: 0x000B71E0
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

		// Token: 0x06004BF7 RID: 19447 RVA: 0x000B9044 File Offset: 0x000B7244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x000B9050 File Offset: 0x000B7250
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

		// Token: 0x040030D5 RID: 12501
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030D6 RID: 12502
		public const int RewardedFieldNumber = 1;

		// Token: 0x040030D7 RID: 12503
		private int rewarded_;

		// Token: 0x040030D8 RID: 12504
		public const int WaitRewardFieldNumber = 2;

		// Token: 0x040030D9 RID: 12505
		private int waitReward_;

		// Token: 0x040030DA RID: 12506
		public const int MaxRewardFieldNumber = 3;

		// Token: 0x040030DB RID: 12507
		private int maxReward_;
	}
}
