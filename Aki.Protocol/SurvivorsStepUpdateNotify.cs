using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E9 RID: 4841
	[NetMessage(EMessageId.SurvivorsStepUpdateNotify)]
	public sealed class SurvivorsStepUpdateNotify : IMessage<SurvivorsStepUpdateNotify>, IMessage, IEquatable<SurvivorsStepUpdateNotify>, IDeepCloneable<SurvivorsStepUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019BEA RID: 105450 RVA: 0x003BDE91 File Offset: 0x003BC091
		[NullableContext(1)]
		public static SurvivorsStepUpdateNotify Create()
		{
			return new SurvivorsStepUpdateNotify();
		}

		// Token: 0x170056D6 RID: 22230
		// (get) Token: 0x06019BEB RID: 105451 RVA: 0x003BDE98 File Offset: 0x003BC098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056D7 RID: 22231
		// (get) Token: 0x06019BEC RID: 105452 RVA: 0x003BDE9B File Offset: 0x003BC09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsStepUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019BED RID: 105453 RVA: 0x003BDEA2 File Offset: 0x003BC0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepUpdateNotify()
		{
		}

		// Token: 0x06019BEE RID: 105454 RVA: 0x003BDEAC File Offset: 0x003BC0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepUpdateNotify(SurvivorsStepUpdateNotify other) : this()
		{
			switch (other.StepPbDataCase)
			{
			case SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData:
				this.EndStepPbData = other.EndStepPbData.Clone();
				break;
			case SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData:
				this.CombatStepPbData = other.CombatStepPbData.Clone();
				break;
			case SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData:
				this.PrepareStepPbData = other.PrepareStepPbData.Clone();
				break;
			case SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData:
				this.RewardStepPbData = other.RewardStepPbData.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BEF RID: 105455 RVA: 0x003BDF43 File Offset: 0x003BC143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepUpdateNotify Clone()
		{
			return new SurvivorsStepUpdateNotify(this);
		}

		// Token: 0x170056D8 RID: 22232
		// (get) Token: 0x06019BF0 RID: 105456 RVA: 0x003BDF4B File Offset: 0x003BC14B
		// (set) Token: 0x06019BF1 RID: 105457 RVA: 0x003BDF64 File Offset: 0x003BC164
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

		// Token: 0x170056D9 RID: 22233
		// (get) Token: 0x06019BF2 RID: 105458 RVA: 0x003BDF7B File Offset: 0x003BC17B
		// (set) Token: 0x06019BF3 RID: 105459 RVA: 0x003BDF94 File Offset: 0x003BC194
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

		// Token: 0x170056DA RID: 22234
		// (get) Token: 0x06019BF4 RID: 105460 RVA: 0x003BDFAB File Offset: 0x003BC1AB
		// (set) Token: 0x06019BF5 RID: 105461 RVA: 0x003BDFC3 File Offset: 0x003BC1C3
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

		// Token: 0x170056DB RID: 22235
		// (get) Token: 0x06019BF6 RID: 105462 RVA: 0x003BDFD9 File Offset: 0x003BC1D9
		// (set) Token: 0x06019BF7 RID: 105463 RVA: 0x003BDFF2 File Offset: 0x003BC1F2
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

		// Token: 0x170056DC RID: 22236
		// (get) Token: 0x06019BF8 RID: 105464 RVA: 0x003BE009 File Offset: 0x003BC209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepUpdateNotify.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x06019BF9 RID: 105465 RVA: 0x003BE011 File Offset: 0x003BC211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = SurvivorsStepUpdateNotify.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x06019BFA RID: 105466 RVA: 0x003BE021 File Offset: 0x003BC221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsStepUpdateNotify);
		}

		// Token: 0x06019BFB RID: 105467 RVA: 0x003BE030 File Offset: 0x003BC230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsStepUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PrepareStepPbData, other.PrepareStepPbData) && object.Equals(this.CombatStepPbData, other.CombatStepPbData) && object.Equals(this.EndStepPbData, other.EndStepPbData) && object.Equals(this.RewardStepPbData, other.RewardStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BFC RID: 105468 RVA: 0x003BE0C0 File Offset: 0x003BC2C0
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

		// Token: 0x06019BFD RID: 105469 RVA: 0x003BE14E File Offset: 0x003BC34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BFE RID: 105470 RVA: 0x003BE15B File Offset: 0x003BC35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BFF RID: 105471 RVA: 0x003BE164 File Offset: 0x003BC364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.EndStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CombatStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RewardStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C00 RID: 105472 RVA: 0x003BE1FC File Offset: 0x003BC3FC
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

		// Token: 0x06019C01 RID: 105473 RVA: 0x003BE28C File Offset: 0x003BC48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsStepUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.StepPbDataCase)
			{
			case SurvivorsStepUpdateNotify.StepPbDataOneofCase.EndStepPbData:
				if (this.EndStepPbData == null)
				{
					this.EndStepPbData = new SurvivorsEndStepPbData();
				}
				this.EndStepPbData.MergeFrom(other.EndStepPbData);
				break;
			case SurvivorsStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData:
				if (this.CombatStepPbData == null)
				{
					this.CombatStepPbData = new SurvivorsCombatStepPbData();
				}
				this.CombatStepPbData.MergeFrom(other.CombatStepPbData);
				break;
			case SurvivorsStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData:
				if (this.PrepareStepPbData == null)
				{
					this.PrepareStepPbData = new SurvivorsPrepareStepPbData();
				}
				this.PrepareStepPbData.MergeFrom(other.PrepareStepPbData);
				break;
			case SurvivorsStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData:
				if (this.RewardStepPbData == null)
				{
					this.RewardStepPbData = new SurvivorsRewardStepPbData();
				}
				this.RewardStepPbData.MergeFrom(other.RewardStepPbData);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019C02 RID: 105474 RVA: 0x003BE376 File Offset: 0x003BC576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C03 RID: 105475 RVA: 0x003BE380 File Offset: 0x003BC580
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
				if (num <= 74U)
				{
					if (num == 66U)
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
					if (num == 74U)
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
				else
				{
					if (num == 82U)
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
					if (num == 106U)
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040096C2 RID: 38594
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096C3 RID: 38595
		public const int PrepareStepPbDataFieldNumber = 10;

		// Token: 0x040096C4 RID: 38596
		public const int CombatStepPbDataFieldNumber = 9;

		// Token: 0x040096C5 RID: 38597
		public const int EndStepPbDataFieldNumber = 8;

		// Token: 0x040096C6 RID: 38598
		public const int RewardStepPbDataFieldNumber = 13;

		// Token: 0x040096C7 RID: 38599
		private object stepPbData_;

		// Token: 0x040096C8 RID: 38600
		private SurvivorsStepUpdateNotify.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x020019B3 RID: 6579
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CA61 RID: 51809
			None,
			// Token: 0x0400CA62 RID: 51810
			PrepareStepPbData = 10,
			// Token: 0x0400CA63 RID: 51811
			CombatStepPbData = 9,
			// Token: 0x0400CA64 RID: 51812
			EndStepPbData = 8,
			// Token: 0x0400CA65 RID: 51813
			RewardStepPbData = 13
		}
	}
}
