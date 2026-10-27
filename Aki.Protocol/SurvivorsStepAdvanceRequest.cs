using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E7 RID: 4839
	[NetMessage(EMessageId.SurvivorsStepAdvanceRequest)]
	public sealed class SurvivorsStepAdvanceRequest : IMessage<SurvivorsStepAdvanceRequest>, IMessage, IEquatable<SurvivorsStepAdvanceRequest>, IDeepCloneable<SurvivorsStepAdvanceRequest>, IBufferMessage
	{
		// Token: 0x06019BBE RID: 105406 RVA: 0x003BD6B1 File Offset: 0x003BB8B1
		[NullableContext(1)]
		public static SurvivorsStepAdvanceRequest Create()
		{
			return new SurvivorsStepAdvanceRequest();
		}

		// Token: 0x170056CC RID: 22220
		// (get) Token: 0x06019BBF RID: 105407 RVA: 0x003BD6B8 File Offset: 0x003BB8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056CD RID: 22221
		// (get) Token: 0x06019BC0 RID: 105408 RVA: 0x003BD6BB File Offset: 0x003BB8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsStepAdvanceRequest.Descriptor;
			}
		}

		// Token: 0x06019BC1 RID: 105409 RVA: 0x003BD6C2 File Offset: 0x003BB8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceRequest()
		{
		}

		// Token: 0x06019BC2 RID: 105410 RVA: 0x003BD6CC File Offset: 0x003BB8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceRequest(SurvivorsStepAdvanceRequest other) : this()
		{
			SurvivorsStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
			{
				switch (stepPbDataCase)
				{
				case SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData:
					this.CombatStepPbData = other.CombatStepPbData.Clone();
					break;
				case SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData:
					this.EndStepPbData = other.EndStepPbData.Clone();
					break;
				case SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData:
					this.PrepareStepPbData = other.PrepareStepPbData.Clone();
					break;
				}
			}
			else
			{
				this.RewardStepPbData = other.RewardStepPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BC3 RID: 105411 RVA: 0x003BD763 File Offset: 0x003BB963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceRequest Clone()
		{
			return new SurvivorsStepAdvanceRequest(this);
		}

		// Token: 0x170056CE RID: 22222
		// (get) Token: 0x06019BC4 RID: 105412 RVA: 0x003BD76B File Offset: 0x003BB96B
		// (set) Token: 0x06019BC5 RID: 105413 RVA: 0x003BD784 File Offset: 0x003BB984
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

		// Token: 0x170056CF RID: 22223
		// (get) Token: 0x06019BC6 RID: 105414 RVA: 0x003BD79B File Offset: 0x003BB99B
		// (set) Token: 0x06019BC7 RID: 105415 RVA: 0x003BD7B3 File Offset: 0x003BB9B3
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

		// Token: 0x170056D0 RID: 22224
		// (get) Token: 0x06019BC8 RID: 105416 RVA: 0x003BD7C9 File Offset: 0x003BB9C9
		// (set) Token: 0x06019BC9 RID: 105417 RVA: 0x003BD7E2 File Offset: 0x003BB9E2
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

		// Token: 0x170056D1 RID: 22225
		// (get) Token: 0x06019BCA RID: 105418 RVA: 0x003BD7F9 File Offset: 0x003BB9F9
		// (set) Token: 0x06019BCB RID: 105419 RVA: 0x003BD811 File Offset: 0x003BBA11
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

		// Token: 0x170056D2 RID: 22226
		// (get) Token: 0x06019BCC RID: 105420 RVA: 0x003BD827 File Offset: 0x003BBA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceRequest.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x06019BCD RID: 105421 RVA: 0x003BD82F File Offset: 0x003BBA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = SurvivorsStepAdvanceRequest.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x06019BCE RID: 105422 RVA: 0x003BD83F File Offset: 0x003BBA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsStepAdvanceRequest);
		}

		// Token: 0x06019BCF RID: 105423 RVA: 0x003BD850 File Offset: 0x003BBA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsStepAdvanceRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PrepareStepPbData, other.PrepareStepPbData) && object.Equals(this.CombatStepPbData, other.CombatStepPbData) && object.Equals(this.EndStepPbData, other.EndStepPbData) && object.Equals(this.RewardStepPbData, other.RewardStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BD0 RID: 105424 RVA: 0x003BD8E0 File Offset: 0x003BBAE0
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

		// Token: 0x06019BD1 RID: 105425 RVA: 0x003BD96D File Offset: 0x003BBB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BD2 RID: 105426 RVA: 0x003BD97A File Offset: 0x003BBB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BD3 RID: 105427 RVA: 0x003BD984 File Offset: 0x003BBB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RewardStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EndStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PrepareStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019BD4 RID: 105428 RVA: 0x003BDA1C File Offset: 0x003BBC1C
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

		// Token: 0x06019BD5 RID: 105429 RVA: 0x003BDAA8 File Offset: 0x003BBCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsStepAdvanceRequest other)
		{
			if (other == null)
			{
				return;
			}
			SurvivorsStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase != SurvivorsStepAdvanceRequest.StepPbDataOneofCase.RewardStepPbData)
			{
				switch (stepPbDataCase)
				{
				case SurvivorsStepAdvanceRequest.StepPbDataOneofCase.CombatStepPbData:
					if (this.CombatStepPbData == null)
					{
						this.CombatStepPbData = new SurvivorsCombatStepPbData();
					}
					this.CombatStepPbData.MergeFrom(other.CombatStepPbData);
					break;
				case SurvivorsStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData:
					if (this.EndStepPbData == null)
					{
						this.EndStepPbData = new SurvivorsEndStepPbData();
					}
					this.EndStepPbData.MergeFrom(other.EndStepPbData);
					break;
				case SurvivorsStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData:
					if (this.PrepareStepPbData == null)
					{
						this.PrepareStepPbData = new SurvivorsPrepareStepPbData();
					}
					this.PrepareStepPbData.MergeFrom(other.PrepareStepPbData);
					break;
				}
			}
			else
			{
				if (this.RewardStepPbData == null)
				{
					this.RewardStepPbData = new SurvivorsRewardStepPbData();
				}
				this.RewardStepPbData.MergeFrom(other.RewardStepPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019BD6 RID: 105430 RVA: 0x003BDB95 File Offset: 0x003BBD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BD7 RID: 105431 RVA: 0x003BDBA0 File Offset: 0x003BBDA0
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
				if (num <= 66U)
				{
					if (num == 42U)
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
					if (num == 66U)
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
					if (num == 82U)
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
					if (num == 98U)
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040096B8 RID: 38584
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096B9 RID: 38585
		public const int PrepareStepPbDataFieldNumber = 12;

		// Token: 0x040096BA RID: 38586
		public const int CombatStepPbDataFieldNumber = 8;

		// Token: 0x040096BB RID: 38587
		public const int EndStepPbDataFieldNumber = 10;

		// Token: 0x040096BC RID: 38588
		public const int RewardStepPbDataFieldNumber = 5;

		// Token: 0x040096BD RID: 38589
		private object stepPbData_;

		// Token: 0x040096BE RID: 38590
		private SurvivorsStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x020019B2 RID: 6578
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CA5B RID: 51803
			None,
			// Token: 0x0400CA5C RID: 51804
			PrepareStepPbData = 12,
			// Token: 0x0400CA5D RID: 51805
			CombatStepPbData = 8,
			// Token: 0x0400CA5E RID: 51806
			EndStepPbData = 10,
			// Token: 0x0400CA5F RID: 51807
			RewardStepPbData = 5
		}
	}
}
