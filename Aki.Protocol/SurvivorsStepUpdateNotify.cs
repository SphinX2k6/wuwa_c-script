using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001358 RID: 4952
	[NetMessage(EMessageId.SurvivorsStepUpdateNotify)]
	public sealed class SurvivorsStepUpdateNotify : IMessage<SurvivorsStepUpdateNotify>, IMessage, IEquatable<SurvivorsStepUpdateNotify>, IDeepCloneable<SurvivorsStepUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A620 RID: 108064 RVA: 0x003D85B9 File Offset: 0x003D67B9
		[NullableContext(1)]
		public static SurvivorsStepUpdateNotify Create()
		{
			return new SurvivorsStepUpdateNotify();
		}

		// Token: 0x17005957 RID: 22871
		// (get) Token: 0x0601A621 RID: 108065 RVA: 0x003D85C0 File Offset: 0x003D67C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005958 RID: 22872
		// (get) Token: 0x0601A622 RID: 108066 RVA: 0x003D85C3 File Offset: 0x003D67C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsStepUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A623 RID: 108067 RVA: 0x003D85CA File Offset: 0x003D67CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepUpdateNotify()
		{
		}

		// Token: 0x0601A624 RID: 108068 RVA: 0x003D85D4 File Offset: 0x003D67D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepUpdateNotify(SurvivorsStepUpdateNotify other) : this()
		{
			SurvivorsStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase != SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				switch (stepPbDataCase)
				{
				case SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData:
					this.RewardStepPbData = other.RewardStepPbData.Clone();
					break;
				case SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData:
					this.PrepareStepPbData = other.PrepareStepPbData.Clone();
					break;
				case SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData:
					this.CombatStepPbData = other.CombatStepPbData.Clone();
					break;
				}
			}
			else
			{
				this.EndStepPbData = other.EndStepPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A625 RID: 108069 RVA: 0x003D8668 File Offset: 0x003D6868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepUpdateNotify Clone()
		{
			return new SurvivorsStepUpdateNotify(this);
		}

		// Token: 0x17005959 RID: 22873
		// (get) Token: 0x0601A626 RID: 108070 RVA: 0x003D8670 File Offset: 0x003D6870
		// (set) Token: 0x0601A627 RID: 108071 RVA: 0x003D8689 File Offset: 0x003D6889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPrepareStepPbData PrepareStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
				{
					return null;
				}
				return (SurvivorsPrepareStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? SurvivorsStepUpdateNotify.StepPbDataOneofCase.None : SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData);
			}
		}

		// Token: 0x1700595A RID: 22874
		// (get) Token: 0x0601A628 RID: 108072 RVA: 0x003D86A0 File Offset: 0x003D68A0
		// (set) Token: 0x0601A629 RID: 108073 RVA: 0x003D86B9 File Offset: 0x003D68B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCombatStepPbData CombatStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
				{
					return null;
				}
				return (SurvivorsCombatStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? SurvivorsStepUpdateNotify.StepPbDataOneofCase.None : SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData);
			}
		}

		// Token: 0x1700595B RID: 22875
		// (get) Token: 0x0601A62A RID: 108074 RVA: 0x003D86D0 File Offset: 0x003D68D0
		// (set) Token: 0x0601A62B RID: 108075 RVA: 0x003D86E8 File Offset: 0x003D68E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsEndStepPbData EndStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
				{
					return null;
				}
				return (SurvivorsEndStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? SurvivorsStepUpdateNotify.StepPbDataOneofCase.None : SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData);
			}
		}

		// Token: 0x1700595C RID: 22876
		// (get) Token: 0x0601A62C RID: 108076 RVA: 0x003D86FE File Offset: 0x003D68FE
		// (set) Token: 0x0601A62D RID: 108077 RVA: 0x003D8717 File Offset: 0x003D6917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRewardStepPbData RewardStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
				{
					return null;
				}
				return (SurvivorsRewardStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? SurvivorsStepUpdateNotify.StepPbDataOneofCase.None : SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData);
			}
		}

		// Token: 0x1700595D RID: 22877
		// (get) Token: 0x0601A62E RID: 108078 RVA: 0x003D872E File Offset: 0x003D692E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepUpdateNotify.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x0601A62F RID: 108079 RVA: 0x003D8736 File Offset: 0x003D6936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = SurvivorsStepUpdateNotify.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0601A630 RID: 108080 RVA: 0x003D8746 File Offset: 0x003D6946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsStepUpdateNotify);
		}

		// Token: 0x0601A631 RID: 108081 RVA: 0x003D8754 File Offset: 0x003D6954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsStepUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PrepareStepPbData, other.PrepareStepPbData) && object.Equals(this.CombatStepPbData, other.CombatStepPbData) && object.Equals(this.EndStepPbData, other.EndStepPbData) && object.Equals(this.RewardStepPbData, other.RewardStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A632 RID: 108082 RVA: 0x003D87E4 File Offset: 0x003D69E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				num ^= this.PrepareStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
			{
				num ^= this.CombatStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				num ^= this.EndStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				num ^= this.RewardStepPbData.GetHashCode();
			}
			num ^= (int)this.stepPbDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A633 RID: 108083 RVA: 0x003D8872 File Offset: 0x003D6A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A634 RID: 108084 RVA: 0x003D887F File Offset: 0x003D6A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A635 RID: 108085 RVA: 0x003D8888 File Offset: 0x003D6A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EndStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RewardStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CombatStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A636 RID: 108086 RVA: 0x003D8920 File Offset: 0x003D6B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardStepPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A637 RID: 108087 RVA: 0x003D89B0 File Offset: 0x003D6BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsStepUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			SurvivorsStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase != SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				switch (stepPbDataCase)
				{
				case SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData:
					if (this.RewardStepPbData == null)
					{
						this.RewardStepPbData = new SurvivorsRewardStepPbData();
					}
					this.RewardStepPbData.MergeFrom(other.RewardStepPbData);
					break;
				case SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData:
					if (this.PrepareStepPbData == null)
					{
						this.PrepareStepPbData = new SurvivorsPrepareStepPbData();
					}
					this.PrepareStepPbData.MergeFrom(other.PrepareStepPbData);
					break;
				case SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData:
					if (this.CombatStepPbData == null)
					{
						this.CombatStepPbData = new SurvivorsCombatStepPbData();
					}
					this.CombatStepPbData.MergeFrom(other.CombatStepPbData);
					break;
				}
			}
			else
			{
				if (this.EndStepPbData == null)
				{
					this.EndStepPbData = new SurvivorsEndStepPbData();
				}
				this.EndStepPbData.MergeFrom(other.EndStepPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A638 RID: 108088 RVA: 0x003D8A97 File Offset: 0x003D6C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A639 RID: 108089 RVA: 0x003D8AA0 File Offset: 0x003D6CA0
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
				if (num <= 98U)
				{
					if (num == 10U)
					{
						SurvivorsEndStepPbData survivorsEndStepPbData = new SurvivorsEndStepPbData();
						if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
						{
							survivorsEndStepPbData.MergeFrom(this.EndStepPbData);
						}
						input.ReadMessage(survivorsEndStepPbData);
						this.EndStepPbData = survivorsEndStepPbData;
						continue;
					}
					if (num == 98U)
					{
						SurvivorsRewardStepPbData survivorsRewardStepPbData = new SurvivorsRewardStepPbData();
						if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
						{
							survivorsRewardStepPbData.MergeFrom(this.RewardStepPbData);
						}
						input.ReadMessage(survivorsRewardStepPbData);
						this.RewardStepPbData = survivorsRewardStepPbData;
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						SurvivorsPrepareStepPbData survivorsPrepareStepPbData = new SurvivorsPrepareStepPbData();
						if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
						{
							survivorsPrepareStepPbData.MergeFrom(this.PrepareStepPbData);
						}
						input.ReadMessage(survivorsPrepareStepPbData);
						this.PrepareStepPbData = survivorsPrepareStepPbData;
						continue;
					}
					if (num == 122U)
					{
						SurvivorsCombatStepPbData survivorsCombatStepPbData = new SurvivorsCombatStepPbData();
						if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
						{
							survivorsCombatStepPbData.MergeFrom(this.CombatStepPbData);
						}
						input.ReadMessage(survivorsCombatStepPbData);
						this.CombatStepPbData = survivorsCombatStepPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009AEC RID: 39660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AED RID: 39661
		public const int PrepareStepPbDataFieldNumber = 14;

		// Token: 0x04009AEE RID: 39662
		public const int CombatStepPbDataFieldNumber = 15;

		// Token: 0x04009AEF RID: 39663
		public const int EndStepPbDataFieldNumber = 1;

		// Token: 0x04009AF0 RID: 39664
		public const int RewardStepPbDataFieldNumber = 12;

		// Token: 0x04009AF1 RID: 39665
		private object stepPbData_;

		// Token: 0x04009AF2 RID: 39666
		private SurvivorsStepUpdateNotify.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x02001A51 RID: 6737
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CFC8 RID: 53192
			None,
			// Token: 0x0400CFC9 RID: 53193
			PrepareStepPbData = 14,
			// Token: 0x0400CFCA RID: 53194
			CombatStepPbData,
			// Token: 0x0400CFCB RID: 53195
			EndStepPbData = 1,
			// Token: 0x0400CFCC RID: 53196
			RewardStepPbData = 12
		}
	}
}
