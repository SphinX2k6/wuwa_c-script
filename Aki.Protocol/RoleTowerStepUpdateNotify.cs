using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F6 RID: 4342
	[NetMessage(EMessageId.RoleTowerStepUpdateNotify)]
	public sealed class RoleTowerStepUpdateNotify : IMessage<RoleTowerStepUpdateNotify>, IMessage, IEquatable<RoleTowerStepUpdateNotify>, IDeepCloneable<RoleTowerStepUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017366 RID: 95078 RVA: 0x00360C4D File Offset: 0x0035EE4D
		[NullableContext(1)]
		public static RoleTowerStepUpdateNotify Create()
		{
			return new RoleTowerStepUpdateNotify();
		}

		// Token: 0x17004DFA RID: 19962
		// (get) Token: 0x06017367 RID: 95079 RVA: 0x00360C54 File Offset: 0x0035EE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DFB RID: 19963
		// (get) Token: 0x06017368 RID: 95080 RVA: 0x00360C57 File Offset: 0x0035EE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStepUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017369 RID: 95081 RVA: 0x00360C5E File Offset: 0x0035EE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepUpdateNotify()
		{
		}

		// Token: 0x0601736A RID: 95082 RVA: 0x00360C68 File Offset: 0x0035EE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepUpdateNotify(RoleTowerStepUpdateNotify other) : this()
		{
			this.needOpenUi_ = other.needOpenUi_;
			RoleTowerStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase != RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				if (stepPbDataCase != RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData)
				{
					switch (stepPbDataCase)
					{
					case RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData:
						this.SettleStepPbData = other.SettleStepPbData.Clone();
						break;
					case RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData:
						this.LoadSubLevelStepPbData = other.LoadSubLevelStepPbData.Clone();
						break;
					case RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData:
						this.BattleStepPbData = other.BattleStepPbData.Clone();
						break;
					}
				}
				else
				{
					this.TeamUpgradeStepPbData = other.TeamUpgradeStepPbData.Clone();
				}
			}
			else
			{
				this.PrepareStepPbData = other.PrepareStepPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601736B RID: 95083 RVA: 0x00360D1B File Offset: 0x0035EF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepUpdateNotify Clone()
		{
			return new RoleTowerStepUpdateNotify(this);
		}

		// Token: 0x17004DFC RID: 19964
		// (get) Token: 0x0601736C RID: 95084 RVA: 0x00360D23 File Offset: 0x0035EF23
		// (set) Token: 0x0601736D RID: 95085 RVA: 0x00360D2B File Offset: 0x0035EF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedOpenUi
		{
			get
			{
				return this.needOpenUi_;
			}
			set
			{
				this.needOpenUi_ = value;
			}
		}

		// Token: 0x17004DFD RID: 19965
		// (get) Token: 0x0601736E RID: 95086 RVA: 0x00360D34 File Offset: 0x0035EF34
		// (set) Token: 0x0601736F RID: 95087 RVA: 0x00360D4C File Offset: 0x0035EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareStepPbData PrepareStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
				{
					return null;
				}
				return (RoleTowerPrepareStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepUpdateNotify.StepPbDataOneofCase.None : RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData);
			}
		}

		// Token: 0x17004DFE RID: 19966
		// (get) Token: 0x06017370 RID: 95088 RVA: 0x00360D62 File Offset: 0x0035EF62
		// (set) Token: 0x06017371 RID: 95089 RVA: 0x00360D7B File Offset: 0x0035EF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBattleStepPbData BattleStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData)
				{
					return null;
				}
				return (RoleTowerBattleStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepUpdateNotify.StepPbDataOneofCase.None : RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData);
			}
		}

		// Token: 0x17004DFF RID: 19967
		// (get) Token: 0x06017372 RID: 95090 RVA: 0x00360D92 File Offset: 0x0035EF92
		// (set) Token: 0x06017373 RID: 95091 RVA: 0x00360DAB File Offset: 0x0035EFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSettleStepPbData SettleStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData)
				{
					return null;
				}
				return (RoleTowerSettleStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepUpdateNotify.StepPbDataOneofCase.None : RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData);
			}
		}

		// Token: 0x17004E00 RID: 19968
		// (get) Token: 0x06017374 RID: 95092 RVA: 0x00360DC2 File Offset: 0x0035EFC2
		// (set) Token: 0x06017375 RID: 95093 RVA: 0x00360DDA File Offset: 0x0035EFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTeamUpgradeStepPbData TeamUpgradeStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData)
				{
					return null;
				}
				return (RoleTowerTeamUpgradeStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepUpdateNotify.StepPbDataOneofCase.None : RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData);
			}
		}

		// Token: 0x17004E01 RID: 19969
		// (get) Token: 0x06017376 RID: 95094 RVA: 0x00360DF0 File Offset: 0x0035EFF0
		// (set) Token: 0x06017377 RID: 95095 RVA: 0x00360E09 File Offset: 0x0035F009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerLoadSubLevelStepPbData LoadSubLevelStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData)
				{
					return null;
				}
				return (RoleTowerLoadSubLevelStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? RoleTowerStepUpdateNotify.StepPbDataOneofCase.None : RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData);
			}
		}

		// Token: 0x17004E02 RID: 19970
		// (get) Token: 0x06017378 RID: 95096 RVA: 0x00360E20 File Offset: 0x0035F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStepUpdateNotify.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x06017379 RID: 95097 RVA: 0x00360E28 File Offset: 0x0035F028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = RoleTowerStepUpdateNotify.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0601737A RID: 95098 RVA: 0x00360E38 File Offset: 0x0035F038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStepUpdateNotify);
		}

		// Token: 0x0601737B RID: 95099 RVA: 0x00360E48 File Offset: 0x0035F048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStepUpdateNotify other)
		{
			return other != null && (other == this || (this.NeedOpenUi == other.NeedOpenUi && object.Equals(this.PrepareStepPbData, other.PrepareStepPbData) && object.Equals(this.BattleStepPbData, other.BattleStepPbData) && object.Equals(this.SettleStepPbData, other.SettleStepPbData) && object.Equals(this.TeamUpgradeStepPbData, other.TeamUpgradeStepPbData) && object.Equals(this.LoadSubLevelStepPbData, other.LoadSubLevelStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601737C RID: 95100 RVA: 0x00360EFC File Offset: 0x0035F0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NeedOpenUi)
			{
				num ^= this.NeedOpenUi.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				num ^= this.PrepareStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData)
			{
				num ^= this.BattleStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData)
			{
				num ^= this.SettleStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData)
			{
				num ^= this.TeamUpgradeStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData)
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

		// Token: 0x0601737D RID: 95101 RVA: 0x00360FBA File Offset: 0x0035F1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601737E RID: 95102 RVA: 0x00360FC7 File Offset: 0x0035F1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601737F RID: 95103 RVA: 0x00360FD0 File Offset: 0x0035F1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TeamUpgradeStepPbData);
			}
			if (this.NeedOpenUi)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.NeedOpenUi);
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.SettleStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LoadSubLevelStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.BattleStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017380 RID: 95104 RVA: 0x003610A4 File Offset: 0x0035F2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NeedOpenUi)
			{
				num += 2;
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SettleStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TeamUpgradeStepPbData);
			}
			if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LoadSubLevelStepPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017381 RID: 95105 RVA: 0x00361158 File Offset: 0x0035F358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStepUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NeedOpenUi)
			{
				this.NeedOpenUi = other.NeedOpenUi;
			}
			RoleTowerStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase != RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				if (stepPbDataCase != RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData)
				{
					switch (stepPbDataCase)
					{
					case RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData:
						if (this.SettleStepPbData == null)
						{
							this.SettleStepPbData = new RoleTowerSettleStepPbData();
						}
						this.SettleStepPbData.MergeFrom(other.SettleStepPbData);
						break;
					case RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData:
						if (this.LoadSubLevelStepPbData == null)
						{
							this.LoadSubLevelStepPbData = new RoleTowerLoadSubLevelStepPbData();
						}
						this.LoadSubLevelStepPbData.MergeFrom(other.LoadSubLevelStepPbData);
						break;
					case RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData:
						if (this.BattleStepPbData == null)
						{
							this.BattleStepPbData = new RoleTowerBattleStepPbData();
						}
						this.BattleStepPbData.MergeFrom(other.BattleStepPbData);
						break;
					}
				}
				else
				{
					if (this.TeamUpgradeStepPbData == null)
					{
						this.TeamUpgradeStepPbData = new RoleTowerTeamUpgradeStepPbData();
					}
					this.TeamUpgradeStepPbData.MergeFrom(other.TeamUpgradeStepPbData);
				}
			}
			else
			{
				if (this.PrepareStepPbData == null)
				{
					this.PrepareStepPbData = new RoleTowerPrepareStepPbData();
				}
				this.PrepareStepPbData.MergeFrom(other.PrepareStepPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017382 RID: 95106 RVA: 0x0036127F File Offset: 0x0035F47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017383 RID: 95107 RVA: 0x00361288 File Offset: 0x0035F488
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
				if (num <= 32U)
				{
					if (num == 18U)
					{
						RoleTowerPrepareStepPbData roleTowerPrepareStepPbData = new RoleTowerPrepareStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
						{
							roleTowerPrepareStepPbData.MergeFrom(this.PrepareStepPbData);
						}
						input.ReadMessage(roleTowerPrepareStepPbData);
						this.PrepareStepPbData = roleTowerPrepareStepPbData;
						continue;
					}
					if (num == 26U)
					{
						RoleTowerTeamUpgradeStepPbData roleTowerTeamUpgradeStepPbData = new RoleTowerTeamUpgradeStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData)
						{
							roleTowerTeamUpgradeStepPbData.MergeFrom(this.TeamUpgradeStepPbData);
						}
						input.ReadMessage(roleTowerTeamUpgradeStepPbData);
						this.TeamUpgradeStepPbData = roleTowerTeamUpgradeStepPbData;
						continue;
					}
					if (num == 32U)
					{
						this.NeedOpenUi = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						RoleTowerSettleStepPbData roleTowerSettleStepPbData = new RoleTowerSettleStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData)
						{
							roleTowerSettleStepPbData.MergeFrom(this.SettleStepPbData);
						}
						input.ReadMessage(roleTowerSettleStepPbData);
						this.SettleStepPbData = roleTowerSettleStepPbData;
						continue;
					}
					if (num == 82U)
					{
						RoleTowerLoadSubLevelStepPbData roleTowerLoadSubLevelStepPbData = new RoleTowerLoadSubLevelStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData)
						{
							roleTowerLoadSubLevelStepPbData.MergeFrom(this.LoadSubLevelStepPbData);
						}
						input.ReadMessage(roleTowerLoadSubLevelStepPbData);
						this.LoadSubLevelStepPbData = roleTowerLoadSubLevelStepPbData;
						continue;
					}
					if (num == 90U)
					{
						RoleTowerBattleStepPbData roleTowerBattleStepPbData = new RoleTowerBattleStepPbData();
						if (this.stepPbDataCase_ == RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData)
						{
							roleTowerBattleStepPbData.MergeFrom(this.BattleStepPbData);
						}
						input.ReadMessage(roleTowerBattleStepPbData);
						this.BattleStepPbData = roleTowerBattleStepPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008ADE RID: 35550
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ADF RID: 35551
		public const int NeedOpenUiFieldNumber = 4;

		// Token: 0x04008AE0 RID: 35552
		private bool needOpenUi_;

		// Token: 0x04008AE1 RID: 35553
		public const int PrepareStepPbDataFieldNumber = 2;

		// Token: 0x04008AE2 RID: 35554
		public const int BattleStepPbDataFieldNumber = 11;

		// Token: 0x04008AE3 RID: 35555
		public const int SettleStepPbDataFieldNumber = 9;

		// Token: 0x04008AE4 RID: 35556
		public const int TeamUpgradeStepPbDataFieldNumber = 3;

		// Token: 0x04008AE5 RID: 35557
		public const int LoadSubLevelStepPbDataFieldNumber = 10;

		// Token: 0x04008AE6 RID: 35558
		private object stepPbData_;

		// Token: 0x04008AE7 RID: 35559
		private RoleTowerStepUpdateNotify.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x020019EA RID: 6634
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CF09 RID: 53001
			None,
			// Token: 0x0400CF0A RID: 53002
			PrepareStepPbData = 2,
			// Token: 0x0400CF0B RID: 53003
			BattleStepPbData = 11,
			// Token: 0x0400CF0C RID: 53004
			SettleStepPbData = 9,
			// Token: 0x0400CF0D RID: 53005
			TeamUpgradeStepPbData = 3,
			// Token: 0x0400CF0E RID: 53006
			LoadSubLevelStepPbData = 10
		}
	}
}
