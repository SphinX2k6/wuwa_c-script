using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016A RID: 362
	[NetMessage(EMessageId.BattlePassExpUpdateNotify)]
	public sealed class BattlePassExpUpdateNotify : IMessage<BattlePassExpUpdateNotify>, IMessage, IEquatable<BattlePassExpUpdateNotify>, IDeepCloneable<BattlePassExpUpdateNotify>, IBufferMessage
	{
		// Token: 0x06002CDC RID: 11484 RVA: 0x0007471E File Offset: 0x0007291E
		[NullableContext(1)]
		public static BattlePassExpUpdateNotify Create()
		{
			return new BattlePassExpUpdateNotify();
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x00074725 File Offset: 0x00072925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x00074728 File Offset: 0x00072928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassExpUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0007472F File Offset: 0x0007292F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassExpUpdateNotify()
		{
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x00074744 File Offset: 0x00072944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassExpUpdateNotify(BattlePassExpUpdateNotify other) : this()
		{
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.weeklyTotalExp_ = other.weeklyTotalExp_;
			this.recurringRewards_ = other.recurringRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x0007479D File Offset: 0x0007299D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassExpUpdateNotify Clone()
		{
			return new BattlePassExpUpdateNotify(this);
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000747A5 File Offset: 0x000729A5
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x000747AD File Offset: 0x000729AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000747B6 File Offset: 0x000729B6
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x000747BE File Offset: 0x000729BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000747C7 File Offset: 0x000729C7
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x000747CF File Offset: 0x000729CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeeklyTotalExp
		{
			get
			{
				return this.weeklyTotalExp_;
			}
			set
			{
				this.weeklyTotalExp_ = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000747D8 File Offset: 0x000729D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassRecurringReward> RecurringRewards
		{
			get
			{
				return this.recurringRewards_;
			}
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x000747E0 File Offset: 0x000729E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassExpUpdateNotify);
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x000747F0 File Offset: 0x000729F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassExpUpdateNotify other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Exp == other.Exp && this.WeeklyTotalExp == other.WeeklyTotalExp && this.recurringRewards_.Equals(other.recurringRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00074860 File Offset: 0x00072A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.WeeklyTotalExp != 0)
			{
				num ^= this.WeeklyTotalExp.GetHashCode();
			}
			num ^= this.recurringRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x000748DF File Offset: 0x00072ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000748EC File Offset: 0x00072AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000748F8 File Offset: 0x00072AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recurringRewards_.WriteTo(ref output, BattlePassExpUpdateNotify._repeated_recurringRewards_codec);
			if (this.Exp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Exp);
			}
			if (this.WeeklyTotalExp != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.WeeklyTotalExp);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00074980 File Offset: 0x00072B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.WeeklyTotalExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeeklyTotalExp);
			}
			num += this.recurringRewards_.CalculateSize(BattlePassExpUpdateNotify._repeated_recurringRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00074A04 File Offset: 0x00072C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassExpUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.WeeklyTotalExp != 0)
			{
				this.WeeklyTotalExp = other.WeeklyTotalExp;
			}
			this.recurringRewards_.Add(other.recurringRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00074A79 File Offset: 0x00072C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00074A84 File Offset: 0x00072C84
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
				if (num <= 48U)
				{
					if (num == 26U)
					{
						this.recurringRewards_.AddEntriesFrom(ref input, BattlePassExpUpdateNotify._repeated_recurringRewards_codec);
						continue;
					}
					if (num == 48U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.WeeklyTotalExp = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002813 RID: 10259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002814 RID: 10260
		public const int LevelFieldNumber = 13;

		// Token: 0x04002815 RID: 10261
		private int level_;

		// Token: 0x04002816 RID: 10262
		public const int ExpFieldNumber = 6;

		// Token: 0x04002817 RID: 10263
		private int exp_;

		// Token: 0x04002818 RID: 10264
		public const int WeeklyTotalExpFieldNumber = 10;

		// Token: 0x04002819 RID: 10265
		private int weeklyTotalExp_;

		// Token: 0x0400281A RID: 10266
		public const int RecurringRewardsFieldNumber = 3;

		// Token: 0x0400281B RID: 10267
		private static readonly FieldCodec<PbBattlePassRecurringReward> _repeated_recurringRewards_codec = FieldCodec.ForMessage<PbBattlePassRecurringReward>(26U, PbBattlePassRecurringReward.Parser);

		// Token: 0x0400281C RID: 10268
		private readonly RepeatedField<PbBattlePassRecurringReward> recurringRewards_ = new RepeatedField<PbBattlePassRecurringReward>();
	}
}
