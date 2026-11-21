using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000298 RID: 664
	public sealed class CiacconaScheduleRewardPbData : IMessage<CiacconaScheduleRewardPbData>, IMessage, IEquatable<CiacconaScheduleRewardPbData>, IDeepCloneable<CiacconaScheduleRewardPbData>, IBufferMessage
	{
		// Token: 0x0600455B RID: 17755 RVA: 0x000AA537 File Offset: 0x000A8737
		[NullableContext(1)]
		public static CiacconaScheduleRewardPbData Create()
		{
			return new CiacconaScheduleRewardPbData();
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x000AA53E File Offset: 0x000A873E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaScheduleRewardPbData> Parser
		{
			get
			{
				return CiacconaScheduleRewardPbData._parser;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x000AA545 File Offset: 0x000A8745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x000AA548 File Offset: 0x000A8748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaScheduleRewardPbData.Descriptor;
			}
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x000AA54F File Offset: 0x000A874F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaScheduleRewardPbData()
		{
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x000AA557 File Offset: 0x000A8757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaScheduleRewardPbData(CiacconaScheduleRewardPbData other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this.canReward_ = other.canReward_;
			this.takeReward_ = other.takeReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x000AA594 File Offset: 0x000A8794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaScheduleRewardPbData Clone()
		{
			return new CiacconaScheduleRewardPbData(this);
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x000AA59C File Offset: 0x000A879C
		// (set) Token: 0x06004563 RID: 17763 RVA: 0x000AA5A4 File Offset: 0x000A87A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x000AA5AD File Offset: 0x000A87AD
		// (set) Token: 0x06004565 RID: 17765 RVA: 0x000AA5B5 File Offset: 0x000A87B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanReward
		{
			get
			{
				return this.canReward_;
			}
			set
			{
				this.canReward_ = value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x000AA5BE File Offset: 0x000A87BE
		// (set) Token: 0x06004567 RID: 17767 RVA: 0x000AA5C6 File Offset: 0x000A87C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TakeReward
		{
			get
			{
				return this.takeReward_;
			}
			set
			{
				this.takeReward_ = value;
			}
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x000AA5CF File Offset: 0x000A87CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaScheduleRewardPbData);
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x000AA5E0 File Offset: 0x000A87E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaScheduleRewardPbData other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && this.CanReward == other.CanReward && this.TakeReward == other.TakeReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x000AA63C File Offset: 0x000A883C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this.CanReward)
			{
				num ^= this.CanReward.GetHashCode();
			}
			if (this.TakeReward)
			{
				num ^= this.TakeReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x000AA6AD File Offset: 0x000A88AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x000AA6BA File Offset: 0x000A88BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x000AA6C4 File Offset: 0x000A88C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RewardId);
			}
			if (this.CanReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.CanReward);
			}
			if (this.TakeReward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.TakeReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x000AA738 File Offset: 0x000A8938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this.CanReward)
			{
				num += 2;
			}
			if (this.TakeReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x000AA790 File Offset: 0x000A8990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaScheduleRewardPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			if (other.CanReward)
			{
				this.CanReward = other.CanReward;
			}
			if (other.TakeReward)
			{
				this.TakeReward = other.TakeReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x000AA7F4 File Offset: 0x000A89F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x000AA800 File Offset: 0x000A8A00
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
							this.TakeReward = input.ReadBool();
						}
					}
					else
					{
						this.CanReward = input.ReadBool();
					}
				}
				else
				{
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F3C RID: 12092
		private static readonly MessageParser<CiacconaScheduleRewardPbData> _parser = new MessageParser<CiacconaScheduleRewardPbData>(() => new CiacconaScheduleRewardPbData());

		// Token: 0x04002F3D RID: 12093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F3E RID: 12094
		public const int RewardIdFieldNumber = 1;

		// Token: 0x04002F3F RID: 12095
		private int rewardId_;

		// Token: 0x04002F40 RID: 12096
		public const int CanRewardFieldNumber = 2;

		// Token: 0x04002F41 RID: 12097
		private bool canReward_;

		// Token: 0x04002F42 RID: 12098
		public const int TakeRewardFieldNumber = 3;

		// Token: 0x04002F43 RID: 12099
		private bool takeReward_;
	}
}
