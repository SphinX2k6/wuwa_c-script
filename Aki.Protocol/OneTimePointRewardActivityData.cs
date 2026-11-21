using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B82 RID: 2946
	public sealed class OneTimePointRewardActivityData : IMessage<OneTimePointRewardActivityData>, IMessage, IEquatable<OneTimePointRewardActivityData>, IDeepCloneable<OneTimePointRewardActivityData>, IBufferMessage
	{
		// Token: 0x0600FFEA RID: 65514 RVA: 0x0025607A File Offset: 0x0025427A
		[NullableContext(1)]
		public static OneTimePointRewardActivityData Create()
		{
			return new OneTimePointRewardActivityData();
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600FFEB RID: 65515 RVA: 0x00256081 File Offset: 0x00254281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneTimePointRewardActivityData> Parser
		{
			get
			{
				return OneTimePointRewardActivityData._parser;
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600FFEC RID: 65516 RVA: 0x00256088 File Offset: 0x00254288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600FFED RID: 65517 RVA: 0x0025608B File Offset: 0x0025428B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneTimePointRewardActivityData.Descriptor;
			}
		}

		// Token: 0x0600FFEE RID: 65518 RVA: 0x00256092 File Offset: 0x00254292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTimePointRewardActivityData()
		{
		}

		// Token: 0x0600FFEF RID: 65519 RVA: 0x0025609C File Offset: 0x0025429C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTimePointRewardActivityData(OneTimePointRewardActivityData other) : this()
		{
			this.id_ = other.id_;
			this.rewardTime_ = other.rewardTime_;
			this.rewarded_ = other.rewarded_;
			this.canGetReward_ = other.canGetReward_;
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FFF0 RID: 65520 RVA: 0x0025610C File Offset: 0x0025430C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTimePointRewardActivityData Clone()
		{
			return new OneTimePointRewardActivityData(this);
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600FFF1 RID: 65521 RVA: 0x00256114 File Offset: 0x00254314
		// (set) Token: 0x0600FFF2 RID: 65522 RVA: 0x0025611C File Offset: 0x0025431C
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

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600FFF3 RID: 65523 RVA: 0x00256125 File Offset: 0x00254325
		// (set) Token: 0x0600FFF4 RID: 65524 RVA: 0x0025612D File Offset: 0x0025432D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RewardTime
		{
			get
			{
				return this.rewardTime_;
			}
			set
			{
				this.rewardTime_ = value;
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600FFF5 RID: 65525 RVA: 0x00256136 File Offset: 0x00254336
		// (set) Token: 0x0600FFF6 RID: 65526 RVA: 0x0025613E File Offset: 0x0025433E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
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

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600FFF7 RID: 65527 RVA: 0x00256147 File Offset: 0x00254347
		// (set) Token: 0x0600FFF8 RID: 65528 RVA: 0x0025614F File Offset: 0x0025434F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanGetReward
		{
			get
			{
				return this.canGetReward_;
			}
			set
			{
				this.canGetReward_ = value;
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600FFF9 RID: 65529 RVA: 0x00256158 File Offset: 0x00254358
		// (set) Token: 0x0600FFFA RID: 65530 RVA: 0x00256160 File Offset: 0x00254360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x0600FFFB RID: 65531 RVA: 0x00256169 File Offset: 0x00254369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneTimePointRewardActivityData);
		}

		// Token: 0x0600FFFC RID: 65532 RVA: 0x00256178 File Offset: 0x00254378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneTimePointRewardActivityData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RewardTime == other.RewardTime && this.Rewarded == other.Rewarded && this.CanGetReward == other.CanGetReward && object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FFFD RID: 65533 RVA: 0x002561F8 File Offset: 0x002543F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.RewardTime != 0L)
			{
				num ^= this.RewardTime.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this.CanGetReward)
			{
				num ^= this.CanGetReward.GetHashCode();
			}
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FFFE RID: 65534 RVA: 0x00256298 File Offset: 0x00254498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FFFF RID: 65535 RVA: 0x002562A5 File Offset: 0x002544A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010000 RID: 65536 RVA: 0x002562B0 File Offset: 0x002544B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.RewardTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.RewardTime);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Rewarded);
			}
			if (this.CanGetReward)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.CanGetReward);
			}
			if (this.task_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010001 RID: 65537 RVA: 0x0025635C File Offset: 0x0025455C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.RewardTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RewardTime);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this.CanGetReward)
			{
				num += 2;
			}
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010002 RID: 65538 RVA: 0x002563E4 File Offset: 0x002545E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneTimePointRewardActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.RewardTime != 0L)
			{
				this.RewardTime = other.RewardTime;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			if (other.CanGetReward)
			{
				this.CanGetReward = other.CanGetReward;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010003 RID: 65539 RVA: 0x00256488 File Offset: 0x00254688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010004 RID: 65540 RVA: 0x00256494 File Offset: 0x00254694
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
						this.RewardTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Rewarded = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.CanGetReward = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						if (this.task_ == null)
						{
							this.Task = new ConditionTask();
						}
						input.ReadMessage(this.Task);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006670 RID: 26224
		private static readonly MessageParser<OneTimePointRewardActivityData> _parser = new MessageParser<OneTimePointRewardActivityData>(() => new OneTimePointRewardActivityData());

		// Token: 0x04006671 RID: 26225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006672 RID: 26226
		public const int IdFieldNumber = 1;

		// Token: 0x04006673 RID: 26227
		private int id_;

		// Token: 0x04006674 RID: 26228
		public const int RewardTimeFieldNumber = 2;

		// Token: 0x04006675 RID: 26229
		private long rewardTime_;

		// Token: 0x04006676 RID: 26230
		public const int RewardedFieldNumber = 3;

		// Token: 0x04006677 RID: 26231
		private bool rewarded_;

		// Token: 0x04006678 RID: 26232
		public const int CanGetRewardFieldNumber = 4;

		// Token: 0x04006679 RID: 26233
		private bool canGetReward_;

		// Token: 0x0400667A RID: 26234
		public const int TaskFieldNumber = 5;

		// Token: 0x0400667B RID: 26235
		private ConditionTask task_;
	}
}
