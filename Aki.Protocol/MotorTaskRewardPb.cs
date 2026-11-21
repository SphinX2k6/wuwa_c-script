using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A97 RID: 2711
	public sealed class MotorTaskRewardPb : IMessage<MotorTaskRewardPb>, IMessage, IEquatable<MotorTaskRewardPb>, IDeepCloneable<MotorTaskRewardPb>, IBufferMessage
	{
		// Token: 0x0600EC5F RID: 60511 RVA: 0x00228877 File Offset: 0x00226A77
		[NullableContext(1)]
		public static MotorTaskRewardPb Create()
		{
			return new MotorTaskRewardPb();
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x0600EC60 RID: 60512 RVA: 0x0022887E File Offset: 0x00226A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x0600EC61 RID: 60513 RVA: 0x00228881 File Offset: 0x00226A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskRewardPb.Descriptor;
			}
		}

		// Token: 0x0600EC62 RID: 60514 RVA: 0x00228888 File Offset: 0x00226A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskRewardPb()
		{
		}

		// Token: 0x0600EC63 RID: 60515 RVA: 0x00228890 File Offset: 0x00226A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskRewardPb(MotorTaskRewardPb other) : this()
		{
			this.rewarded_ = other.rewarded_;
			this.waitReward_ = other.waitReward_;
			this.maxReward_ = other.maxReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC64 RID: 60516 RVA: 0x002288CD File Offset: 0x00226ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskRewardPb Clone()
		{
			return new MotorTaskRewardPb(this);
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x0600EC65 RID: 60517 RVA: 0x002288D5 File Offset: 0x00226AD5
		// (set) Token: 0x0600EC66 RID: 60518 RVA: 0x002288DD File Offset: 0x00226ADD
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

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x0600EC67 RID: 60519 RVA: 0x002288E6 File Offset: 0x00226AE6
		// (set) Token: 0x0600EC68 RID: 60520 RVA: 0x002288EE File Offset: 0x00226AEE
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

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600EC69 RID: 60521 RVA: 0x002288F7 File Offset: 0x00226AF7
		// (set) Token: 0x0600EC6A RID: 60522 RVA: 0x002288FF File Offset: 0x00226AFF
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

		// Token: 0x0600EC6B RID: 60523 RVA: 0x00228908 File Offset: 0x00226B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskRewardPb);
		}

		// Token: 0x0600EC6C RID: 60524 RVA: 0x00228918 File Offset: 0x00226B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskRewardPb other)
		{
			return other != null && (other == this || (this.Rewarded == other.Rewarded && this.WaitReward == other.WaitReward && this.MaxReward == other.MaxReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC6D RID: 60525 RVA: 0x00228974 File Offset: 0x00226B74
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

		// Token: 0x0600EC6E RID: 60526 RVA: 0x002289E5 File Offset: 0x00226BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC6F RID: 60527 RVA: 0x002289F2 File Offset: 0x00226BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC70 RID: 60528 RVA: 0x002289FC File Offset: 0x00226BFC
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

		// Token: 0x0600EC71 RID: 60529 RVA: 0x00228A70 File Offset: 0x00226C70
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

		// Token: 0x0600EC72 RID: 60530 RVA: 0x00228AE0 File Offset: 0x00226CE0
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

		// Token: 0x0600EC73 RID: 60531 RVA: 0x00228B44 File Offset: 0x00226D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC74 RID: 60532 RVA: 0x00228B50 File Offset: 0x00226D50
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

		// Token: 0x04006036 RID: 24630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006037 RID: 24631
		public const int RewardedFieldNumber = 1;

		// Token: 0x04006038 RID: 24632
		private int rewarded_;

		// Token: 0x04006039 RID: 24633
		public const int WaitRewardFieldNumber = 2;

		// Token: 0x0400603A RID: 24634
		private int waitReward_;

		// Token: 0x0400603B RID: 24635
		public const int MaxRewardFieldNumber = 3;

		// Token: 0x0400603C RID: 24636
		private int maxReward_;
	}
}
