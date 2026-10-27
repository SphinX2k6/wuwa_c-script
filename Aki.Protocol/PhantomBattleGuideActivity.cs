using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8F RID: 3215
	public sealed class PhantomBattleGuideActivity : IMessage<PhantomBattleGuideActivity>, IMessage, IEquatable<PhantomBattleGuideActivity>, IDeepCloneable<PhantomBattleGuideActivity>, IBufferMessage
	{
		// Token: 0x060116DE RID: 71390 RVA: 0x0028DF02 File Offset: 0x0028C102
		[NullableContext(1)]
		public static PhantomBattleGuideActivity Create()
		{
			return new PhantomBattleGuideActivity();
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x060116DF RID: 71391 RVA: 0x0028DF09 File Offset: 0x0028C109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x060116E0 RID: 71392 RVA: 0x0028DF0C File Offset: 0x0028C10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGuideActivity.Descriptor;
			}
		}

		// Token: 0x060116E1 RID: 71393 RVA: 0x0028DF13 File Offset: 0x0028C113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideActivity()
		{
		}

		// Token: 0x060116E2 RID: 71394 RVA: 0x0028DF1C File Offset: 0x0028C11C
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

		// Token: 0x060116E3 RID: 71395 RVA: 0x0028DF7C File Offset: 0x0028C17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideActivity Clone()
		{
			return new PhantomBattleGuideActivity(this);
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x060116E4 RID: 71396 RVA: 0x0028DF84 File Offset: 0x0028C184
		// (set) Token: 0x060116E5 RID: 71397 RVA: 0x0028DF8C File Offset: 0x0028C18C
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

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x060116E6 RID: 71398 RVA: 0x0028DF95 File Offset: 0x0028C195
		// (set) Token: 0x060116E7 RID: 71399 RVA: 0x0028DF9D File Offset: 0x0028C19D
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

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x060116E8 RID: 71400 RVA: 0x0028DFA6 File Offset: 0x0028C1A6
		// (set) Token: 0x060116E9 RID: 71401 RVA: 0x0028DFAE File Offset: 0x0028C1AE
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

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x060116EA RID: 71402 RVA: 0x0028DFB7 File Offset: 0x0028C1B7
		// (set) Token: 0x060116EB RID: 71403 RVA: 0x0028DFBF File Offset: 0x0028C1BF
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

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x060116EC RID: 71404 RVA: 0x0028DFC8 File Offset: 0x0028C1C8
		// (set) Token: 0x060116ED RID: 71405 RVA: 0x0028DFD0 File Offset: 0x0028C1D0
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

		// Token: 0x060116EE RID: 71406 RVA: 0x0028DFD9 File Offset: 0x0028C1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGuideActivity);
		}

		// Token: 0x060116EF RID: 71407 RVA: 0x0028DFE8 File Offset: 0x0028C1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGuideActivity other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.DropId == other.DropId && this.RewardTotalNum == other.RewardTotalNum && this.SendReward == other.SendReward && this.RecordActId == other.RecordActId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060116F0 RID: 71408 RVA: 0x0028E064 File Offset: 0x0028C264
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

		// Token: 0x060116F1 RID: 71409 RVA: 0x0028E107 File Offset: 0x0028C307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116F2 RID: 71410 RVA: 0x0028E114 File Offset: 0x0028C314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116F3 RID: 71411 RVA: 0x0028E120 File Offset: 0x0028C320
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

		// Token: 0x060116F4 RID: 71412 RVA: 0x0028E1CC File Offset: 0x0028C3CC
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

		// Token: 0x060116F5 RID: 71413 RVA: 0x0028E260 File Offset: 0x0028C460
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

		// Token: 0x060116F6 RID: 71414 RVA: 0x0028E2EC File Offset: 0x0028C4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116F7 RID: 71415 RVA: 0x0028E2F8 File Offset: 0x0028C4F8
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

		// Token: 0x04006E11 RID: 28177
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E12 RID: 28178
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04006E13 RID: 28179
		private int questId_;

		// Token: 0x04006E14 RID: 28180
		public const int DropIdFieldNumber = 2;

		// Token: 0x04006E15 RID: 28181
		private int dropId_;

		// Token: 0x04006E16 RID: 28182
		public const int RewardTotalNumFieldNumber = 3;

		// Token: 0x04006E17 RID: 28183
		private int rewardTotalNum_;

		// Token: 0x04006E18 RID: 28184
		public const int SendRewardFieldNumber = 4;

		// Token: 0x04006E19 RID: 28185
		private bool sendReward_;

		// Token: 0x04006E1A RID: 28186
		public const int RecordActIdFieldNumber = 5;

		// Token: 0x04006E1B RID: 28187
		private int recordActId_;
	}
}
