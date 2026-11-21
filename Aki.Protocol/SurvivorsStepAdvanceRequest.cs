using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001356 RID: 4950
	[NetMessage(EMessageId.SurvivorsStepAdvanceRequest)]
	public sealed class SurvivorsStepAdvanceRequest : IMessage<SurvivorsStepAdvanceRequest>, IMessage, IEquatable<SurvivorsStepAdvanceRequest>, IDeepCloneable<SurvivorsStepAdvanceRequest>, IBufferMessage
	{
		// Token: 0x0601A5F4 RID: 108020 RVA: 0x003D7DE1 File Offset: 0x003D5FE1
		[NullableContext(1)]
		public static SurvivorsStepAdvanceRequest Create()
		{
			return new SurvivorsStepAdvanceRequest();
		}

		// Token: 0x1700594D RID: 22861
		// (get) Token: 0x0601A5F5 RID: 108021 RVA: 0x003D7DE8 File Offset: 0x003D5FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700594E RID: 22862
		// (get) Token: 0x0601A5F6 RID: 108022 RVA: 0x003D7DEB File Offset: 0x003D5FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsStepAdvanceRequest.Descriptor;
			}
		}

		// Token: 0x0601A5F7 RID: 108023 RVA: 0x003D7DF2 File Offset: 0x003D5FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceRequest()
		{
		}

		// Token: 0x0601A5F8 RID: 108024 RVA: 0x003D7DFC File Offset: 0x003D5FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceRequest(SurvivorsStepAdvanceRequest other) : this()
		{
			SurvivorsStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase <= SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
			{
				if (stepPbDataCase != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
				{
					if (stepPbDataCase == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
					{
						this.CombatStepPbData = other.CombatStepPbData.Clone();
					}
				}
				else
				{
					this.PrepareStepPbData = other.PrepareStepPbData.Clone();
				}
			}
			else if (stepPbDataCase != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				if (stepPbDataCase == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
				{
					this.RewardStepPbData = other.RewardStepPbData.Clone();
				}
			}
			else
			{
				this.EndStepPbData = other.EndStepPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5F9 RID: 108025 RVA: 0x003D7E8D File Offset: 0x003D608D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceRequest Clone()
		{
			return new SurvivorsStepAdvanceRequest(this);
		}

		// Token: 0x1700594F RID: 22863
		// (get) Token: 0x0601A5FA RID: 108026 RVA: 0x003D7E95 File Offset: 0x003D6095
		// (set) Token: 0x0601A5FB RID: 108027 RVA: 0x003D7EAD File Offset: 0x003D60AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPrepareStepPbData PrepareStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
				{
					return null;
				}
				return (SurvivorsPrepareStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? SurvivorsStepAdvanceRequest.StepPbDataOneofCase.None : SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData);
			}
		}

		// Token: 0x17005950 RID: 22864
		// (get) Token: 0x0601A5FC RID: 108028 RVA: 0x003D7EC3 File Offset: 0x003D60C3
		// (set) Token: 0x0601A5FD RID: 108029 RVA: 0x003D7EDC File Offset: 0x003D60DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCombatStepPbData CombatStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
				{
					return null;
				}
				return (SurvivorsCombatStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? SurvivorsStepAdvanceRequest.StepPbDataOneofCase.None : SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData);
			}
		}

		// Token: 0x17005951 RID: 22865
		// (get) Token: 0x0601A5FE RID: 108030 RVA: 0x003D7EF3 File Offset: 0x003D60F3
		// (set) Token: 0x0601A5FF RID: 108031 RVA: 0x003D7F0C File Offset: 0x003D610C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsEndStepPbData EndStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
				{
					return null;
				}
				return (SurvivorsEndStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? SurvivorsStepAdvanceRequest.StepPbDataOneofCase.None : SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData);
			}
		}

		// Token: 0x17005952 RID: 22866
		// (get) Token: 0x0601A600 RID: 108032 RVA: 0x003D7F23 File Offset: 0x003D6123
		// (set) Token: 0x0601A601 RID: 108033 RVA: 0x003D7F3C File Offset: 0x003D613C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRewardStepPbData RewardStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
				{
					return null;
				}
				return (SurvivorsRewardStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? SurvivorsStepAdvanceRequest.StepPbDataOneofCase.None : SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData);
			}
		}

		// Token: 0x17005953 RID: 22867
		// (get) Token: 0x0601A602 RID: 108034 RVA: 0x003D7F53 File Offset: 0x003D6153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceRequest.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x0601A603 RID: 108035 RVA: 0x003D7F5B File Offset: 0x003D615B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = SurvivorsStepAdvanceRequest.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0601A604 RID: 108036 RVA: 0x003D7F6B File Offset: 0x003D616B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsStepAdvanceRequest);
		}

		// Token: 0x0601A605 RID: 108037 RVA: 0x003D7F7C File Offset: 0x003D617C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsStepAdvanceRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PrepareStepPbData, other.PrepareStepPbData) && object.Equals(this.CombatStepPbData, other.CombatStepPbData) && object.Equals(this.EndStepPbData, other.EndStepPbData) && object.Equals(this.RewardStepPbData, other.RewardStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A606 RID: 108038 RVA: 0x003D800C File Offset: 0x003D620C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
			{
				num ^= this.PrepareStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
			{
				num ^= this.CombatStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				num ^= this.EndStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
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

		// Token: 0x0601A607 RID: 108039 RVA: 0x003D809A File Offset: 0x003D629A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A608 RID: 108040 RVA: 0x003D80A7 File Offset: 0x003D62A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A609 RID: 108041 RVA: 0x003D80B0 File Offset: 0x003D62B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CombatStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.EndStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RewardStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A60A RID: 108042 RVA: 0x003D8148 File Offset: 0x003D6348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardStepPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A60B RID: 108043 RVA: 0x003D81D8 File Offset: 0x003D63D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsStepAdvanceRequest other)
		{
			if (other == null)
			{
				return;
			}
			SurvivorsStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase <= SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
			{
				if (stepPbDataCase != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
				{
					if (stepPbDataCase == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
					{
						if (this.CombatStepPbData == null)
						{
							this.CombatStepPbData = new SurvivorsCombatStepPbData();
						}
						this.CombatStepPbData.MergeFrom(other.CombatStepPbData);
					}
				}
				else
				{
					if (this.PrepareStepPbData == null)
					{
						this.PrepareStepPbData = new SurvivorsPrepareStepPbData();
					}
					this.PrepareStepPbData.MergeFrom(other.PrepareStepPbData);
				}
			}
			else if (stepPbDataCase != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				if (stepPbDataCase == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
				{
					if (this.RewardStepPbData == null)
					{
						this.RewardStepPbData = new SurvivorsRewardStepPbData();
					}
					this.RewardStepPbData.MergeFrom(other.RewardStepPbData);
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

		// Token: 0x0601A60C RID: 108044 RVA: 0x003D82BF File Offset: 0x003D64BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A60D RID: 108045 RVA: 0x003D82C8 File Offset: 0x003D64C8
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
				if (num <= 82U)
				{
					if (num == 18U)
					{
						SurvivorsPrepareStepPbData survivorsPrepareStepPbData = new SurvivorsPrepareStepPbData();
						if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
						{
							survivorsPrepareStepPbData.MergeFrom(this.PrepareStepPbData);
						}
						input.ReadMessage(survivorsPrepareStepPbData);
						this.PrepareStepPbData = survivorsPrepareStepPbData;
						continue;
					}
					if (num == 82U)
					{
						SurvivorsCombatStepPbData survivorsCombatStepPbData = new SurvivorsCombatStepPbData();
						if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
						{
							survivorsCombatStepPbData.MergeFrom(this.CombatStepPbData);
						}
						input.ReadMessage(survivorsCombatStepPbData);
						this.CombatStepPbData = survivorsCombatStepPbData;
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						SurvivorsEndStepPbData survivorsEndStepPbData = new SurvivorsEndStepPbData();
						if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
						{
							survivorsEndStepPbData.MergeFrom(this.EndStepPbData);
						}
						input.ReadMessage(survivorsEndStepPbData);
						this.EndStepPbData = survivorsEndStepPbData;
						continue;
					}
					if (num == 122U)
					{
						SurvivorsRewardStepPbData survivorsRewardStepPbData = new SurvivorsRewardStepPbData();
						if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
						{
							survivorsRewardStepPbData.MergeFrom(this.RewardStepPbData);
						}
						input.ReadMessage(survivorsRewardStepPbData);
						this.RewardStepPbData = survivorsRewardStepPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009AE2 RID: 39650
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AE3 RID: 39651
		public const int PrepareStepPbDataFieldNumber = 2;

		// Token: 0x04009AE4 RID: 39652
		public const int CombatStepPbDataFieldNumber = 10;

		// Token: 0x04009AE5 RID: 39653
		public const int EndStepPbDataFieldNumber = 11;

		// Token: 0x04009AE6 RID: 39654
		public const int RewardStepPbDataFieldNumber = 15;

		// Token: 0x04009AE7 RID: 39655
		private object stepPbData_;

		// Token: 0x04009AE8 RID: 39656
		private SurvivorsStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x02001A50 RID: 6736
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CFC2 RID: 53186
			None,
			// Token: 0x0400CFC3 RID: 53187
			PrepareStepPbData = 2,
			// Token: 0x0400CFC4 RID: 53188
			CombatStepPbData = 10,
			// Token: 0x0400CFC5 RID: 53189
			EndStepPbData,
			// Token: 0x0400CFC6 RID: 53190
			RewardStepPbData = 15
		}
	}
}
