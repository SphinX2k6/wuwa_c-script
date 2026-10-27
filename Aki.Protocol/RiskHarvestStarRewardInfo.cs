using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F67 RID: 3943
	public sealed class RiskHarvestStarRewardInfo : IMessage<RiskHarvestStarRewardInfo>, IMessage, IEquatable<RiskHarvestStarRewardInfo>, IDeepCloneable<RiskHarvestStarRewardInfo>, IBufferMessage
	{
		// Token: 0x06015154 RID: 86356 RVA: 0x0030E9A1 File Offset: 0x0030CBA1
		[NullableContext(1)]
		public static RiskHarvestStarRewardInfo Create()
		{
			return new RiskHarvestStarRewardInfo();
		}

		// Token: 0x1700461F RID: 17951
		// (get) Token: 0x06015155 RID: 86357 RVA: 0x0030E9A8 File Offset: 0x0030CBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RiskHarvestStarRewardInfo> Parser
		{
			get
			{
				return RiskHarvestStarRewardInfo._parser;
			}
		}

		// Token: 0x17004620 RID: 17952
		// (get) Token: 0x06015156 RID: 86358 RVA: 0x0030E9AF File Offset: 0x0030CBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004621 RID: 17953
		// (get) Token: 0x06015157 RID: 86359 RVA: 0x0030E9B2 File Offset: 0x0030CBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestStarRewardInfo.Descriptor;
			}
		}

		// Token: 0x06015158 RID: 86360 RVA: 0x0030E9B9 File Offset: 0x0030CBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardInfo()
		{
		}

		// Token: 0x06015159 RID: 86361 RVA: 0x0030E9C1 File Offset: 0x0030CBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardInfo(RiskHarvestStarRewardInfo other) : this()
		{
			this.targetScore_ = other.targetScore_;
			this.starRewardStates_ = other.starRewardStates_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601515A RID: 86362 RVA: 0x0030E9F2 File Offset: 0x0030CBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardInfo Clone()
		{
			return new RiskHarvestStarRewardInfo(this);
		}

		// Token: 0x17004622 RID: 17954
		// (get) Token: 0x0601515B RID: 86363 RVA: 0x0030E9FA File Offset: 0x0030CBFA
		// (set) Token: 0x0601515C RID: 86364 RVA: 0x0030EA02 File Offset: 0x0030CC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetScore
		{
			get
			{
				return this.targetScore_;
			}
			set
			{
				this.targetScore_ = value;
			}
		}

		// Token: 0x17004623 RID: 17955
		// (get) Token: 0x0601515D RID: 86365 RVA: 0x0030EA0B File Offset: 0x0030CC0B
		// (set) Token: 0x0601515E RID: 86366 RVA: 0x0030EA13 File Offset: 0x0030CC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StarRewardState StarRewardStates
		{
			get
			{
				return this.starRewardStates_;
			}
			set
			{
				this.starRewardStates_ = value;
			}
		}

		// Token: 0x0601515F RID: 86367 RVA: 0x0030EA1C File Offset: 0x0030CC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestStarRewardInfo);
		}

		// Token: 0x06015160 RID: 86368 RVA: 0x0030EA2A File Offset: 0x0030CC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestStarRewardInfo other)
		{
			return other != null && (other == this || (this.TargetScore == other.TargetScore && this.StarRewardStates == other.StarRewardStates && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015161 RID: 86369 RVA: 0x0030EA68 File Offset: 0x0030CC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetScore != 0)
			{
				num ^= this.TargetScore.GetHashCode();
			}
			if (this.StarRewardStates != StarRewardState.RiskHarvestCanNoReward)
			{
				num ^= this.StarRewardStates.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015162 RID: 86370 RVA: 0x0030EAC6 File Offset: 0x0030CCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015163 RID: 86371 RVA: 0x0030EAD3 File Offset: 0x0030CCD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015164 RID: 86372 RVA: 0x0030EADC File Offset: 0x0030CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetScore);
			}
			if (this.StarRewardStates != StarRewardState.RiskHarvestCanNoReward)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.StarRewardStates);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015165 RID: 86373 RVA: 0x0030EB34 File Offset: 0x0030CD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetScore);
			}
			if (this.StarRewardStates != StarRewardState.RiskHarvestCanNoReward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.StarRewardStates);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015166 RID: 86374 RVA: 0x0030EB8C File Offset: 0x0030CD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestStarRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetScore != 0)
			{
				this.TargetScore = other.TargetScore;
			}
			if (other.StarRewardStates != StarRewardState.RiskHarvestCanNoReward)
			{
				this.StarRewardStates = other.StarRewardStates;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015167 RID: 86375 RVA: 0x0030EBDC File Offset: 0x0030CDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015168 RID: 86376 RVA: 0x0030EBE8 File Offset: 0x0030CDE8
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StarRewardStates = (StarRewardState)input.ReadEnum();
					}
				}
				else
				{
					this.TargetScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007EEC RID: 32492
		private static readonly MessageParser<RiskHarvestStarRewardInfo> _parser = new MessageParser<RiskHarvestStarRewardInfo>(() => new RiskHarvestStarRewardInfo());

		// Token: 0x04007EED RID: 32493
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EEE RID: 32494
		public const int TargetScoreFieldNumber = 1;

		// Token: 0x04007EEF RID: 32495
		private int targetScore_;

		// Token: 0x04007EF0 RID: 32496
		public const int StarRewardStatesFieldNumber = 2;

		// Token: 0x04007EF1 RID: 32497
		private StarRewardState starRewardStates_;
	}
}
