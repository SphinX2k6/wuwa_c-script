using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F4 RID: 4340
	[NetMessage(EMessageId.RoleTowerStepAdvanceRequest)]
	public sealed class RoleTowerStepAdvanceRequest : IMessage<RoleTowerStepAdvanceRequest>, IMessage, IEquatable<RoleTowerStepAdvanceRequest>, IDeepCloneable<RoleTowerStepAdvanceRequest>, IBufferMessage
	{
		// Token: 0x06017338 RID: 95032 RVA: 0x00360359 File Offset: 0x0035E559
		[NullableContext(1)]
		public static RoleTowerStepAdvanceRequest Create()
		{
			return new RoleTowerStepAdvanceRequest();
		}

		// Token: 0x17004DEF RID: 19951
		// (get) Token: 0x06017339 RID: 95033 RVA: 0x00360360 File Offset: 0x0035E560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DF0 RID: 19952
		// (get) Token: 0x0601733A RID: 95034 RVA: 0x00360363 File Offset: 0x0035E563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStepAdvanceRequest.Descriptor;
			}
		}

		// Token: 0x0601733B RID: 95035 RVA: 0x0036036A File Offset: 0x0035E56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepAdvanceRequest()
		{
		}

		// Token: 0x0601733C RID: 95036 RVA: 0x00360374 File Offset: 0x0035E574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepAdvanceRequest(RoleTowerStepAdvanceRequest other) : this()
		{
			RoleTowerStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			switch (stepPbDataCase)
			{
			case RoleTowerStepAdvanceRequest.StepPbDataOneofCase.SettleStepPbData:
				this.SettleStepPbData = other.SettleStepPbData.Clone();
				break;
			case (RoleTowerStepAdvanceRequest.StepPbDataOneofCase)5:
			case (RoleTowerStepAdvanceRequest.StepPbDataOneofCase)8:
			case (RoleTowerStepAdvanceRequest.StepPbDataOneofCase)9:
				break;
			case RoleTowerStepAdvanceRequest.StepPbDataOneofCase.TeamUpgradeStepPbData:
				this.TeamUpgradeStepPbData = other.TeamUpgradeStepPbData.Clone();
				break;
			case RoleTowerStepAdvanceRequest.StepPbDataOneofCase.BattleStepPbData:
				this.BattleStepPbData = other.BattleStepPbData.Clone();
				break;
			case RoleTowerStepAdvanceRequest.StepPbDataOneofCase.LoadSubLevelStepPbData:
				this.LoadSubLevelStepPbData = other.LoadSubLevelStepPbData.Clone();
				break;
			default:
				if (stepPbDataCase == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
				{
					this.PrepareStepPbData = other.PrepareStepPbData.Clone();
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601733D RID: 95037 RVA: 0x00360425 File Offset: 0x0035E625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepAdvanceRequest Clone()
		{
			return new RoleTowerStepAdvanceRequest(this);
		}

		// Token: 0x17004DF1 RID: 19953
		// (get) Token: 0x0601733E RID: 95038 RVA: 0x0036042D File Offset: 0x0035E62D
		// (set) Token: 0x0601733F RID: 95039 RVA: 0x00360446 File Offset: 0x0035E646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareStepPbData PrepareStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
				{
					return null;
				}
				return (RoleTowerPrepareStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepAdvanceRequest.StepPbDataOneofCase.None : RoleTowerStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData);
			}
		}

		// Token: 0x17004DF2 RID: 19954
		// (get) Token: 0x06017340 RID: 95040 RVA: 0x0036045D File Offset: 0x0035E65D
		// (set) Token: 0x06017341 RID: 95041 RVA: 0x00360475 File Offset: 0x0035E675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBattleStepPbData BattleStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepAdvanceRequest.StepPbDataOneofCase.BattleStepPbData)
				{
					return null;
				}
				return (RoleTowerBattleStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepAdvanceRequest.StepPbDataOneofCase.None : RoleTowerStepAdvanceRequest.StepPbDataOneofCase.BattleStepPbData);
			}
		}

		// Token: 0x17004DF3 RID: 19955
		// (get) Token: 0x06017342 RID: 95042 RVA: 0x0036048B File Offset: 0x0035E68B
		// (set) Token: 0x06017343 RID: 95043 RVA: 0x003604A3 File Offset: 0x0035E6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSettleStepPbData SettleStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepAdvanceRequest.StepPbDataOneofCase.SettleStepPbData)
				{
					return null;
				}
				return (RoleTowerSettleStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepAdvanceRequest.StepPbDataOneofCase.None : RoleTowerStepAdvanceRequest.StepPbDataOneofCase.SettleStepPbData);
			}
		}

		// Token: 0x17004DF4 RID: 19956
		// (get) Token: 0x06017344 RID: 95044 RVA: 0x003604B9 File Offset: 0x0035E6B9
		// (set) Token: 0x06017345 RID: 95045 RVA: 0x003604D1 File Offset: 0x0035E6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTeamUpgradeStepPbData TeamUpgradeStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepAdvanceRequest.StepPbDataOneofCase.TeamUpgradeStepPbData)
				{
					return null;
				}
				return (RoleTowerTeamUpgradeStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepAdvanceRequest.StepPbDataOneofCase.None : RoleTowerStepAdvanceRequest.StepPbDataOneofCase.TeamUpgradeStepPbData);
			}
		}

		// Token: 0x17004DF5 RID: 19957
		// (get) Token: 0x06017346 RID: 95046 RVA: 0x003604E7 File Offset: 0x0035E6E7
		// (set) Token: 0x06017347 RID: 95047 RVA: 0x00360500 File Offset: 0x0035E700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerLoadSubLevelStepPbData LoadSubLevelStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepAdvanceRequest.StepPbDataOneofCase.LoadSubLevelStepPbData)
				{
					return null;
				}
				return (RoleTowerLoadSubLevelStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepAdvanceRequest.StepPbDataOneofCase.None : RoleTowerStepAdvanceRequest.StepPbDataOneofCase.LoadSubLevelStepPbData);
			}
		}

		// Token: 0x17004DF6 RID: 19958
		// (get) Token: 0x06017348 RID: 95048 RVA: 0x00360517 File Offset: 0x0035E717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepAdvanceRequest.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x06017349 RID: 95049 RVA: 0x0036051F File Offset: 0x0035E71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = RoleTowerStepAdvanceRequest.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0601734A RID: 95050 RVA: 0x0036052F File Offset: 0x0035E72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStepAdvanceRequest);
		}

		// Token: 0x0601734B RID: 95051 RVA: 0x00360540 File Offset: 0x0035E740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStepAdvanceRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PrepareStepPbData, other.PrepareStepPbData) && object.Equals(this.BattleStepPbData, other.BattleStepPbData) && object.Equals(this.SettleStepPbData, other.SettleStepPbData) && object.Equals(this.TeamUpgradeStepPbData, other.TeamUpgradeStepPbData) && object.Equals(this.LoadSubLevelStepPbData, other.LoadSubLevelStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601734C RID: 95052 RVA: 0x003605E4 File Offset: 0x0035E7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
			{
				num ^= this.PrepareStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.BattleStepPbData)
			{
				num ^= this.BattleStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.SettleStepPbData)
			{
				num ^= this.SettleStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.TeamUpgradeStepPbData)
			{
				num ^= this.TeamUpgradeStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.LoadSubLevelStepPbData)
			{
				num ^= this.LoadSubLevelStepPbData.GetHashCode();
			}
			num ^= (int)this.stepPbDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601734D RID: 95053 RVA: 0x00360688 File Offset: 0x0035E888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601734E RID: 95054 RVA: 0x00360695 File Offset: 0x0035E895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601734F RID: 95055 RVA: 0x003606A0 File Offset: 0x0035E8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.SettleStepPbData)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SettleStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.TeamUpgradeStepPbData)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TeamUpgradeStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.BattleStepPbData)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.BattleStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.LoadSubLevelStepPbData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LoadSubLevelStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PrepareStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017350 RID: 95056 RVA: 0x00360754 File Offset: 0x0035E954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.BattleStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.SettleStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SettleStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.TeamUpgradeStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TeamUpgradeStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.LoadSubLevelStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LoadSubLevelStepPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017351 RID: 95057 RVA: 0x003607FC File Offset: 0x0035E9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStepAdvanceRequest other)
		{
			if (other == null)
			{
				return;
			}
			RoleTowerStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			switch (stepPbDataCase)
			{
			case RoleTowerStepAdvanceRequest.StepPbDataOneofCase.SettleStepPbData:
				if (this.SettleStepPbData == null)
				{
					this.SettleStepPbData = new RoleTowerSettleStepPbData();
				}
				this.SettleStepPbData.MergeFrom(other.SettleStepPbData);
				break;
			case (RoleTowerStepAdvanceRequest.StepPbDataOneofCase)5:
			case (RoleTowerStepAdvanceRequest.StepPbDataOneofCase)8:
			case (RoleTowerStepAdvanceRequest.StepPbDataOneofCase)9:
				break;
			case RoleTowerStepAdvanceRequest.StepPbDataOneofCase.TeamUpgradeStepPbData:
				if (this.TeamUpgradeStepPbData == null)
				{
					this.TeamUpgradeStepPbData = new RoleTowerTeamUpgradeStepPbData();
				}
				this.TeamUpgradeStepPbData.MergeFrom(other.TeamUpgradeStepPbData);
				break;
			case RoleTowerStepAdvanceRequest.StepPbDataOneofCase.BattleStepPbData:
				if (this.BattleStepPbData == null)
				{
					this.BattleStepPbData = new RoleTowerBattleStepPbData();
				}
				this.BattleStepPbData.MergeFrom(other.BattleStepPbData);
				break;
			case RoleTowerStepAdvanceRequest.StepPbDataOneofCase.LoadSubLevelStepPbData:
				if (this.LoadSubLevelStepPbData == null)
				{
					this.LoadSubLevelStepPbData = new RoleTowerLoadSubLevelStepPbData();
				}
				this.LoadSubLevelStepPbData.MergeFrom(other.LoadSubLevelStepPbData);
				break;
			default:
				if (stepPbDataCase == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
				{
					if (this.PrepareStepPbData == null)
					{
						this.PrepareStepPbData = new RoleTowerPrepareStepPbData();
					}
					this.PrepareStepPbData.MergeFrom(other.PrepareStepPbData);
				}
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017352 RID: 95058 RVA: 0x00360916 File Offset: 0x0035EB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017353 RID: 95059 RVA: 0x00360920 File Offset: 0x0035EB20
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
				if (num <= 50U)
				{
					if (num == 34U)
					{
						RoleTowerSettleStepPbData roleTowerSettleStepPbData = new RoleTowerSettleStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.SettleStepPbData)
						{
							roleTowerSettleStepPbData.MergeFrom(this.SettleStepPbData);
						}
						input.ReadMessage(roleTowerSettleStepPbData);
						this.SettleStepPbData = roleTowerSettleStepPbData;
						continue;
					}
					if (num == 50U)
					{
						RoleTowerTeamUpgradeStepPbData roleTowerTeamUpgradeStepPbData = new RoleTowerTeamUpgradeStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.TeamUpgradeStepPbData)
						{
							roleTowerTeamUpgradeStepPbData.MergeFrom(this.TeamUpgradeStepPbData);
						}
						input.ReadMessage(roleTowerTeamUpgradeStepPbData);
						this.TeamUpgradeStepPbData = roleTowerTeamUpgradeStepPbData;
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						RoleTowerBattleStepPbData roleTowerBattleStepPbData = new RoleTowerBattleStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.BattleStepPbData)
						{
							roleTowerBattleStepPbData.MergeFrom(this.BattleStepPbData);
						}
						input.ReadMessage(roleTowerBattleStepPbData);
						this.BattleStepPbData = roleTowerBattleStepPbData;
						continue;
					}
					if (num == 82U)
					{
						RoleTowerLoadSubLevelStepPbData roleTowerLoadSubLevelStepPbData = new RoleTowerLoadSubLevelStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.LoadSubLevelStepPbData)
						{
							roleTowerLoadSubLevelStepPbData.MergeFrom(this.LoadSubLevelStepPbData);
						}
						input.ReadMessage(roleTowerLoadSubLevelStepPbData);
						this.LoadSubLevelStepPbData = roleTowerLoadSubLevelStepPbData;
						continue;
					}
					if (num == 106U)
					{
						RoleTowerPrepareStepPbData roleTowerPrepareStepPbData = new RoleTowerPrepareStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepAdvanceRequest.StepPbDataOneofCase.PrepareStepPbData)
						{
							roleTowerPrepareStepPbData.MergeFrom(this.PrepareStepPbData);
						}
						input.ReadMessage(roleTowerPrepareStepPbData);
						this.PrepareStepPbData = roleTowerPrepareStepPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008AD3 RID: 35539
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AD4 RID: 35540
		public const int PrepareStepPbDataFieldNumber = 13;

		// Token: 0x04008AD5 RID: 35541
		public const int BattleStepPbDataFieldNumber = 7;

		// Token: 0x04008AD6 RID: 35542
		public const int SettleStepPbDataFieldNumber = 4;

		// Token: 0x04008AD7 RID: 35543
		public const int TeamUpgradeStepPbDataFieldNumber = 6;

		// Token: 0x04008AD8 RID: 35544
		public const int LoadSubLevelStepPbDataFieldNumber = 10;

		// Token: 0x04008AD9 RID: 35545
		private object stepPbData_;

		// Token: 0x04008ADA RID: 35546
		private RoleTowerStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x020019E9 RID: 6633
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CF02 RID: 52994
			None,
			// Token: 0x0400CF03 RID: 52995
			PrepareStepPbData = 13,
			// Token: 0x0400CF04 RID: 52996
			BattleStepPbData = 7,
			// Token: 0x0400CF05 RID: 52997
			SettleStepPbData = 4,
			// Token: 0x0400CF06 RID: 52998
			TeamUpgradeStepPbData = 6,
			// Token: 0x0400CF07 RID: 52999
			LoadSubLevelStepPbData = 10
		}
	}
}
