using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000293 RID: 659
	public sealed class CiacconaScheduleRewardPbData : IMessage<CiacconaScheduleRewardPbData>, IMessage, IEquatable<CiacconaScheduleRewardPbData>, IDeepCloneable<CiacconaScheduleRewardPbData>, IBufferMessage
	{
		// Token: 0x060044B4 RID: 17588 RVA: 0x000A886F File Offset: 0x000A6A6F
		[NullableContext(1)]
		public static CiacconaScheduleRewardPbData Create()
		{
			return new CiacconaScheduleRewardPbData();
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x000A8876 File Offset: 0x000A6A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaScheduleRewardPbData> Parser
		{
			get
			{
				return CiacconaScheduleRewardPbData._parser;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x000A887D File Offset: 0x000A6A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x000A8880 File Offset: 0x000A6A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaScheduleRewardPbData.Descriptor;
			}
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x000A8887 File Offset: 0x000A6A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaScheduleRewardPbData()
		{
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x000A888F File Offset: 0x000A6A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaScheduleRewardPbData(CiacconaScheduleRewardPbData other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this.canReward_ = other.canReward_;
			this.takeReward_ = other.takeReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x000A88CC File Offset: 0x000A6ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaScheduleRewardPbData Clone()
		{
			return new CiacconaScheduleRewardPbData(this);
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060044BB RID: 17595 RVA: 0x000A88D4 File Offset: 0x000A6AD4
		// (set) Token: 0x060044BC RID: 17596 RVA: 0x000A88DC File Offset: 0x000A6ADC
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

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060044BD RID: 17597 RVA: 0x000A88E5 File Offset: 0x000A6AE5
		// (set) Token: 0x060044BE RID: 17598 RVA: 0x000A88ED File Offset: 0x000A6AED
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

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060044BF RID: 17599 RVA: 0x000A88F6 File Offset: 0x000A6AF6
		// (set) Token: 0x060044C0 RID: 17600 RVA: 0x000A88FE File Offset: 0x000A6AFE
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

		// Token: 0x060044C1 RID: 17601 RVA: 0x000A8907 File Offset: 0x000A6B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaScheduleRewardPbData);
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x000A8918 File Offset: 0x000A6B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaScheduleRewardPbData other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && this.CanReward == other.CanReward && this.TakeReward == other.TakeReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x000A8974 File Offset: 0x000A6B74
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

		// Token: 0x060044C4 RID: 17604 RVA: 0x000A89E5 File Offset: 0x000A6BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x000A89F2 File Offset: 0x000A6BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x000A89FC File Offset: 0x000A6BFC
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

		// Token: 0x060044C7 RID: 17607 RVA: 0x000A8A70 File Offset: 0x000A6C70
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

		// Token: 0x060044C8 RID: 17608 RVA: 0x000A8AC8 File Offset: 0x000A6CC8
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

		// Token: 0x060044C9 RID: 17609 RVA: 0x000A8B2C File Offset: 0x000A6D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x000A8B38 File Offset: 0x000A6D38
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

		// Token: 0x04002EB8 RID: 11960
		private static readonly MessageParser<CiacconaScheduleRewardPbData> _parser = new MessageParser<CiacconaScheduleRewardPbData>(() => new CiacconaScheduleRewardPbData());

		// Token: 0x04002EB9 RID: 11961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EBA RID: 11962
		public const int RewardIdFieldNumber = 1;

		// Token: 0x04002EBB RID: 11963
		private int rewardId_;

		// Token: 0x04002EBC RID: 11964
		public const int CanRewardFieldNumber = 2;

		// Token: 0x04002EBD RID: 11965
		private bool canReward_;

		// Token: 0x04002EBE RID: 11966
		public const int TakeRewardFieldNumber = 3;

		// Token: 0x04002EBF RID: 11967
		private bool takeReward_;
	}
}
