using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B92 RID: 2962
	public sealed class OneTimePointRewardActivityData : IMessage<OneTimePointRewardActivityData>, IMessage, IEquatable<OneTimePointRewardActivityData>, IDeepCloneable<OneTimePointRewardActivityData>, IBufferMessage
	{
		// Token: 0x060100EE RID: 65774 RVA: 0x00257F4A File Offset: 0x0025614A
		[NullableContext(1)]
		public static OneTimePointRewardActivityData Create()
		{
			return new OneTimePointRewardActivityData();
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x060100EF RID: 65775 RVA: 0x00257F51 File Offset: 0x00256151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneTimePointRewardActivityData> Parser
		{
			get
			{
				return OneTimePointRewardActivityData._parser;
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x060100F0 RID: 65776 RVA: 0x00257F58 File Offset: 0x00256158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x060100F1 RID: 65777 RVA: 0x00257F5B File Offset: 0x0025615B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneTimePointRewardActivityData.Descriptor;
			}
		}

		// Token: 0x060100F2 RID: 65778 RVA: 0x00257F62 File Offset: 0x00256162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTimePointRewardActivityData()
		{
		}

		// Token: 0x060100F3 RID: 65779 RVA: 0x00257F6C File Offset: 0x0025616C
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

		// Token: 0x060100F4 RID: 65780 RVA: 0x00257FDC File Offset: 0x002561DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneTimePointRewardActivityData Clone()
		{
			return new OneTimePointRewardActivityData(this);
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x060100F5 RID: 65781 RVA: 0x00257FE4 File Offset: 0x002561E4
		// (set) Token: 0x060100F6 RID: 65782 RVA: 0x00257FEC File Offset: 0x002561EC
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

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x060100F7 RID: 65783 RVA: 0x00257FF5 File Offset: 0x002561F5
		// (set) Token: 0x060100F8 RID: 65784 RVA: 0x00257FFD File Offset: 0x002561FD
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

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x060100F9 RID: 65785 RVA: 0x00258006 File Offset: 0x00256206
		// (set) Token: 0x060100FA RID: 65786 RVA: 0x0025800E File Offset: 0x0025620E
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

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x060100FB RID: 65787 RVA: 0x00258017 File Offset: 0x00256217
		// (set) Token: 0x060100FC RID: 65788 RVA: 0x0025801F File Offset: 0x0025621F
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

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x060100FD RID: 65789 RVA: 0x00258028 File Offset: 0x00256228
		// (set) Token: 0x060100FE RID: 65790 RVA: 0x00258030 File Offset: 0x00256230
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

		// Token: 0x060100FF RID: 65791 RVA: 0x00258039 File Offset: 0x00256239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneTimePointRewardActivityData);
		}

		// Token: 0x06010100 RID: 65792 RVA: 0x00258048 File Offset: 0x00256248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneTimePointRewardActivityData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RewardTime == other.RewardTime && this.Rewarded == other.Rewarded && this.CanGetReward == other.CanGetReward && object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010101 RID: 65793 RVA: 0x002580C8 File Offset: 0x002562C8
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

		// Token: 0x06010102 RID: 65794 RVA: 0x00258168 File Offset: 0x00256368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010103 RID: 65795 RVA: 0x00258175 File Offset: 0x00256375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010104 RID: 65796 RVA: 0x00258180 File Offset: 0x00256380
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

		// Token: 0x06010105 RID: 65797 RVA: 0x0025822C File Offset: 0x0025642C
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

		// Token: 0x06010106 RID: 65798 RVA: 0x002582B4 File Offset: 0x002564B4
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

		// Token: 0x06010107 RID: 65799 RVA: 0x00258358 File Offset: 0x00256558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010108 RID: 65800 RVA: 0x00258364 File Offset: 0x00256564
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

		// Token: 0x04006660 RID: 26208
		private static readonly MessageParser<OneTimePointRewardActivityData> _parser = new MessageParser<OneTimePointRewardActivityData>(() => new OneTimePointRewardActivityData());

		// Token: 0x04006661 RID: 26209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006662 RID: 26210
		public const int IdFieldNumber = 1;

		// Token: 0x04006663 RID: 26211
		private int id_;

		// Token: 0x04006664 RID: 26212
		public const int RewardTimeFieldNumber = 2;

		// Token: 0x04006665 RID: 26213
		private long rewardTime_;

		// Token: 0x04006666 RID: 26214
		public const int RewardedFieldNumber = 3;

		// Token: 0x04006667 RID: 26215
		private bool rewarded_;

		// Token: 0x04006668 RID: 26216
		public const int CanGetRewardFieldNumber = 4;

		// Token: 0x04006669 RID: 26217
		private bool canGetReward_;

		// Token: 0x0400666A RID: 26218
		public const int TaskFieldNumber = 5;

		// Token: 0x0400666B RID: 26219
		private ConditionTask task_;
	}
}
