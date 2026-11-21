using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F57 RID: 3927
	public sealed class RiskHarvestStarRewardInfo : IMessage<RiskHarvestStarRewardInfo>, IMessage, IEquatable<RiskHarvestStarRewardInfo>, IDeepCloneable<RiskHarvestStarRewardInfo>, IBufferMessage
	{
		// Token: 0x0601506F RID: 86127 RVA: 0x0030D2F1 File Offset: 0x0030B4F1
		[NullableContext(1)]
		public static RiskHarvestStarRewardInfo Create()
		{
			return new RiskHarvestStarRewardInfo();
		}

		// Token: 0x170045F5 RID: 17909
		// (get) Token: 0x06015070 RID: 86128 RVA: 0x0030D2F8 File Offset: 0x0030B4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RiskHarvestStarRewardInfo> Parser
		{
			get
			{
				return RiskHarvestStarRewardInfo._parser;
			}
		}

		// Token: 0x170045F6 RID: 17910
		// (get) Token: 0x06015071 RID: 86129 RVA: 0x0030D2FF File Offset: 0x0030B4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045F7 RID: 17911
		// (get) Token: 0x06015072 RID: 86130 RVA: 0x0030D302 File Offset: 0x0030B502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestStarRewardInfo.Descriptor;
			}
		}

		// Token: 0x06015073 RID: 86131 RVA: 0x0030D309 File Offset: 0x0030B509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardInfo()
		{
		}

		// Token: 0x06015074 RID: 86132 RVA: 0x0030D311 File Offset: 0x0030B511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardInfo(RiskHarvestStarRewardInfo other) : this()
		{
			this.targetScore_ = other.targetScore_;
			this.starRewardStates_ = other.starRewardStates_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015075 RID: 86133 RVA: 0x0030D342 File Offset: 0x0030B542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardInfo Clone()
		{
			return new RiskHarvestStarRewardInfo(this);
		}

		// Token: 0x170045F8 RID: 17912
		// (get) Token: 0x06015076 RID: 86134 RVA: 0x0030D34A File Offset: 0x0030B54A
		// (set) Token: 0x06015077 RID: 86135 RVA: 0x0030D352 File Offset: 0x0030B552
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

		// Token: 0x170045F9 RID: 17913
		// (get) Token: 0x06015078 RID: 86136 RVA: 0x0030D35B File Offset: 0x0030B55B
		// (set) Token: 0x06015079 RID: 86137 RVA: 0x0030D363 File Offset: 0x0030B563
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

		// Token: 0x0601507A RID: 86138 RVA: 0x0030D36C File Offset: 0x0030B56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestStarRewardInfo);
		}

		// Token: 0x0601507B RID: 86139 RVA: 0x0030D37A File Offset: 0x0030B57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestStarRewardInfo other)
		{
			return other != null && (other == this || (this.TargetScore == other.TargetScore && this.StarRewardStates == other.StarRewardStates && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601507C RID: 86140 RVA: 0x0030D3B8 File Offset: 0x0030B5B8
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

		// Token: 0x0601507D RID: 86141 RVA: 0x0030D416 File Offset: 0x0030B616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601507E RID: 86142 RVA: 0x0030D423 File Offset: 0x0030B623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601507F RID: 86143 RVA: 0x0030D42C File Offset: 0x0030B62C
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

		// Token: 0x06015080 RID: 86144 RVA: 0x0030D484 File Offset: 0x0030B684
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

		// Token: 0x06015081 RID: 86145 RVA: 0x0030D4DC File Offset: 0x0030B6DC
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

		// Token: 0x06015082 RID: 86146 RVA: 0x0030D52C File Offset: 0x0030B72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015083 RID: 86147 RVA: 0x0030D538 File Offset: 0x0030B738
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

		// Token: 0x04007F16 RID: 32534
		private static readonly MessageParser<RiskHarvestStarRewardInfo> _parser = new MessageParser<RiskHarvestStarRewardInfo>(() => new RiskHarvestStarRewardInfo());

		// Token: 0x04007F17 RID: 32535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F18 RID: 32536
		public const int TargetScoreFieldNumber = 1;

		// Token: 0x04007F19 RID: 32537
		private int targetScore_;

		// Token: 0x04007F1A RID: 32538
		public const int StarRewardStatesFieldNumber = 2;

		// Token: 0x04007F1B RID: 32539
		private StarRewardState starRewardStates_;
	}
}
