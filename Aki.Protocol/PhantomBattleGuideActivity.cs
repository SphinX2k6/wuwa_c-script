using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7F RID: 3199
	public sealed class PhantomBattleGuideActivity : IMessage<PhantomBattleGuideActivity>, IMessage, IEquatable<PhantomBattleGuideActivity>, IDeepCloneable<PhantomBattleGuideActivity>, IBufferMessage
	{
		// Token: 0x060115DE RID: 71134 RVA: 0x0028C195 File Offset: 0x0028A395
		[NullableContext(1)]
		public static PhantomBattleGuideActivity Create()
		{
			return new PhantomBattleGuideActivity();
		}

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x060115DF RID: 71135 RVA: 0x0028C19C File Offset: 0x0028A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x060115E0 RID: 71136 RVA: 0x0028C19F File Offset: 0x0028A39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGuideActivity.Descriptor;
			}
		}

		// Token: 0x060115E1 RID: 71137 RVA: 0x0028C1A6 File Offset: 0x0028A3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideActivity()
		{
		}

		// Token: 0x060115E2 RID: 71138 RVA: 0x0028C1B0 File Offset: 0x0028A3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideActivity(PhantomBattleGuideActivity other) : this()
		{
			this.questId_ = other.questId_;
			this.dropId_ = other.dropId_;
			this.rewardTotalNum_ = other.rewardTotalNum_;
			this.sendReward_ = other.sendReward_;
			this.recordActId_ = other.recordActId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060115E3 RID: 71139 RVA: 0x0028C210 File Offset: 0x0028A410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideActivity Clone()
		{
			return new PhantomBattleGuideActivity(this);
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x060115E4 RID: 71140 RVA: 0x0028C218 File Offset: 0x0028A418
		// (set) Token: 0x060115E5 RID: 71141 RVA: 0x0028C220 File Offset: 0x0028A420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x060115E6 RID: 71142 RVA: 0x0028C229 File Offset: 0x0028A429
		// (set) Token: 0x060115E7 RID: 71143 RVA: 0x0028C231 File Offset: 0x0028A431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropId
		{
			get
			{
				return this.dropId_;
			}
			set
			{
				this.dropId_ = value;
			}
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x060115E8 RID: 71144 RVA: 0x0028C23A File Offset: 0x0028A43A
		// (set) Token: 0x060115E9 RID: 71145 RVA: 0x0028C242 File Offset: 0x0028A442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardTotalNum
		{
			get
			{
				return this.rewardTotalNum_;
			}
			set
			{
				this.rewardTotalNum_ = value;
			}
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x060115EA RID: 71146 RVA: 0x0028C24B File Offset: 0x0028A44B
		// (set) Token: 0x060115EB RID: 71147 RVA: 0x0028C253 File Offset: 0x0028A453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SendReward
		{
			get
			{
				return this.sendReward_;
			}
			set
			{
				this.sendReward_ = value;
			}
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x060115EC RID: 71148 RVA: 0x0028C25C File Offset: 0x0028A45C
		// (set) Token: 0x060115ED RID: 71149 RVA: 0x0028C264 File Offset: 0x0028A464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecordActId
		{
			get
			{
				return this.recordActId_;
			}
			set
			{
				this.recordActId_ = value;
			}
		}

		// Token: 0x060115EE RID: 71150 RVA: 0x0028C26D File Offset: 0x0028A46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGuideActivity);
		}

		// Token: 0x060115EF RID: 71151 RVA: 0x0028C27C File Offset: 0x0028A47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGuideActivity other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.DropId == other.DropId && this.RewardTotalNum == other.RewardTotalNum && this.SendReward == other.SendReward && this.RecordActId == other.RecordActId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060115F0 RID: 71152 RVA: 0x0028C2F8 File Offset: 0x0028A4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.DropId != 0)
			{
				num ^= this.DropId.GetHashCode();
			}
			if (this.RewardTotalNum != 0)
			{
				num ^= this.RewardTotalNum.GetHashCode();
			}
			if (this.SendReward)
			{
				num ^= this.SendReward.GetHashCode();
			}
			if (this.RecordActId != 0)
			{
				num ^= this.RecordActId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060115F1 RID: 71153 RVA: 0x0028C39B File Offset: 0x0028A59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060115F2 RID: 71154 RVA: 0x0028C3A8 File Offset: 0x0028A5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060115F3 RID: 71155 RVA: 0x0028C3B4 File Offset: 0x0028A5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this.DropId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DropId);
			}
			if (this.RewardTotalNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardTotalNum);
			}
			if (this.SendReward)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.SendReward);
			}
			if (this.RecordActId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RecordActId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060115F4 RID: 71156 RVA: 0x0028C460 File Offset: 0x0028A660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.DropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropId);
			}
			if (this.RewardTotalNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardTotalNum);
			}
			if (this.SendReward)
			{
				num += 2;
			}
			if (this.RecordActId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecordActId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060115F5 RID: 71157 RVA: 0x0028C4F4 File Offset: 0x0028A6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleGuideActivity other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.DropId != 0)
			{
				this.DropId = other.DropId;
			}
			if (other.RewardTotalNum != 0)
			{
				this.RewardTotalNum = other.RewardTotalNum;
			}
			if (other.SendReward)
			{
				this.SendReward = other.SendReward;
			}
			if (other.RecordActId != 0)
			{
				this.RecordActId = other.RecordActId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060115F6 RID: 71158 RVA: 0x0028C580 File Offset: 0x0028A780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060115F7 RID: 71159 RVA: 0x0028C58C File Offset: 0x0028A78C
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
						this.QuestId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DropId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RewardTotalNum = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SendReward = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.RecordActId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E25 RID: 28197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E26 RID: 28198
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04006E27 RID: 28199
		private int questId_;

		// Token: 0x04006E28 RID: 28200
		public const int DropIdFieldNumber = 2;

		// Token: 0x04006E29 RID: 28201
		private int dropId_;

		// Token: 0x04006E2A RID: 28202
		public const int RewardTotalNumFieldNumber = 3;

		// Token: 0x04006E2B RID: 28203
		private int rewardTotalNum_;

		// Token: 0x04006E2C RID: 28204
		public const int SendRewardFieldNumber = 4;

		// Token: 0x04006E2D RID: 28205
		private bool sendReward_;

		// Token: 0x04006E2E RID: 28206
		public const int RecordActIdFieldNumber = 5;

		// Token: 0x04006E2F RID: 28207
		private int recordActId_;
	}
}
