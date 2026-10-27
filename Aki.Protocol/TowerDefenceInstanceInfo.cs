using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A0 RID: 5024
	public sealed class TowerDefenceInstanceInfo : IMessage<TowerDefenceInstanceInfo>, IMessage, IEquatable<TowerDefenceInstanceInfo>, IDeepCloneable<TowerDefenceInstanceInfo>, IBufferMessage
	{
		// Token: 0x0601AA82 RID: 109186 RVA: 0x003DDCE0 File Offset: 0x003DBEE0
		[NullableContext(1)]
		public static TowerDefenceInstanceInfo Create()
		{
			return new TowerDefenceInstanceInfo();
		}

		// Token: 0x170059E1 RID: 23009
		// (get) Token: 0x0601AA83 RID: 109187 RVA: 0x003DDCE7 File Offset: 0x003DBEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceInstanceInfo> Parser
		{
			get
			{
				return TowerDefenceInstanceInfo._parser;
			}
		}

		// Token: 0x170059E2 RID: 23010
		// (get) Token: 0x0601AA84 RID: 109188 RVA: 0x003DDCEE File Offset: 0x003DBEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059E3 RID: 23011
		// (get) Token: 0x0601AA85 RID: 109189 RVA: 0x003DDCF1 File Offset: 0x003DBEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInstanceInfo.Descriptor;
			}
		}

		// Token: 0x0601AA86 RID: 109190 RVA: 0x003DDCF8 File Offset: 0x003DBEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfo()
		{
		}

		// Token: 0x0601AA87 RID: 109191 RVA: 0x003DDD00 File Offset: 0x003DBF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfo(TowerDefenceInstanceInfo other) : this()
		{
			this.id_ = other.id_;
			this.score_ = other.score_;
			this.rewarded_ = other.rewarded_;
			this.passed_ = other.passed_;
			this.unlockTime_ = other.unlockTime_;
			this.maxScore_ = other.maxScore_;
			this.passTime_ = other.passTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA88 RID: 109192 RVA: 0x003DDD78 File Offset: 0x003DBF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfo Clone()
		{
			return new TowerDefenceInstanceInfo(this);
		}

		// Token: 0x170059E4 RID: 23012
		// (get) Token: 0x0601AA89 RID: 109193 RVA: 0x003DDD80 File Offset: 0x003DBF80
		// (set) Token: 0x0601AA8A RID: 109194 RVA: 0x003DDD88 File Offset: 0x003DBF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170059E5 RID: 23013
		// (get) Token: 0x0601AA8B RID: 109195 RVA: 0x003DDD91 File Offset: 0x003DBF91
		// (set) Token: 0x0601AA8C RID: 109196 RVA: 0x003DDD99 File Offset: 0x003DBF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x170059E6 RID: 23014
		// (get) Token: 0x0601AA8D RID: 109197 RVA: 0x003DDDA2 File Offset: 0x003DBFA2
		// (set) Token: 0x0601AA8E RID: 109198 RVA: 0x003DDDAA File Offset: 0x003DBFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x170059E7 RID: 23015
		// (get) Token: 0x0601AA8F RID: 109199 RVA: 0x003DDDB3 File Offset: 0x003DBFB3
		// (set) Token: 0x0601AA90 RID: 109200 RVA: 0x003DDDBB File Offset: 0x003DBFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Passed
		{
			get
			{
				return this.passed_;
			}
			set
			{
				this.passed_ = value;
			}
		}

		// Token: 0x170059E8 RID: 23016
		// (get) Token: 0x0601AA91 RID: 109201 RVA: 0x003DDDC4 File Offset: 0x003DBFC4
		// (set) Token: 0x0601AA92 RID: 109202 RVA: 0x003DDDCC File Offset: 0x003DBFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x170059E9 RID: 23017
		// (get) Token: 0x0601AA93 RID: 109203 RVA: 0x003DDDD5 File Offset: 0x003DBFD5
		// (set) Token: 0x0601AA94 RID: 109204 RVA: 0x003DDDDD File Offset: 0x003DBFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x170059EA RID: 23018
		// (get) Token: 0x0601AA95 RID: 109205 RVA: 0x003DDDE6 File Offset: 0x003DBFE6
		// (set) Token: 0x0601AA96 RID: 109206 RVA: 0x003DDDEE File Offset: 0x003DBFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x0601AA97 RID: 109207 RVA: 0x003DDDF7 File Offset: 0x003DBFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInstanceInfo);
		}

		// Token: 0x0601AA98 RID: 109208 RVA: 0x003DDE08 File Offset: 0x003DC008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInstanceInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && this.Rewarded == other.Rewarded && this.Passed == other.Passed && this.UnlockTime == other.UnlockTime && this.MaxScore == other.MaxScore && this.PassTime == other.PassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA99 RID: 109209 RVA: 0x003DDEA4 File Offset: 0x003DC0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this.Passed)
			{
				num ^= this.Passed.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AA9A RID: 109210 RVA: 0x003DDF79 File Offset: 0x003DC179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA9B RID: 109211 RVA: 0x003DDF86 File Offset: 0x003DC186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA9C RID: 109212 RVA: 0x003DDF90 File Offset: 0x003DC190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Rewarded);
			}
			if (this.Passed)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Passed);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxScore);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA9D RID: 109213 RVA: 0x003DE074 File Offset: 0x003DC274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this.Passed)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AA9E RID: 109214 RVA: 0x003DE12C File Offset: 0x003DC32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceInstanceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			if (other.Passed)
			{
				this.Passed = other.Passed;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AA9F RID: 109215 RVA: 0x003DE1E0 File Offset: 0x003DC3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AAA0 RID: 109216 RVA: 0x003DE1EC File Offset: 0x003DC3EC
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Rewarded = input.ReadBool();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.Passed = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009ADA RID: 39642
		private static readonly MessageParser<TowerDefenceInstanceInfo> _parser = new MessageParser<TowerDefenceInstanceInfo>(() => new TowerDefenceInstanceInfo());

		// Token: 0x04009ADB RID: 39643
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ADC RID: 39644
		public const int IdFieldNumber = 1;

		// Token: 0x04009ADD RID: 39645
		private int id_;

		// Token: 0x04009ADE RID: 39646
		public const int ScoreFieldNumber = 2;

		// Token: 0x04009ADF RID: 39647
		private int score_;

		// Token: 0x04009AE0 RID: 39648
		public const int RewardedFieldNumber = 3;

		// Token: 0x04009AE1 RID: 39649
		private bool rewarded_;

		// Token: 0x04009AE2 RID: 39650
		public const int PassedFieldNumber = 4;

		// Token: 0x04009AE3 RID: 39651
		private bool passed_;

		// Token: 0x04009AE4 RID: 39652
		public const int UnlockTimeFieldNumber = 5;

		// Token: 0x04009AE5 RID: 39653
		private long unlockTime_;

		// Token: 0x04009AE6 RID: 39654
		public const int MaxScoreFieldNumber = 6;

		// Token: 0x04009AE7 RID: 39655
		private int maxScore_;

		// Token: 0x04009AE8 RID: 39656
		public const int PassTimeFieldNumber = 7;

		// Token: 0x04009AE9 RID: 39657
		private int passTime_;
	}
}
