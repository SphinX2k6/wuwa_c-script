using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016D RID: 365
	[NetMessage(EMessageId.BattlePassExpUpdateNotify)]
	public sealed class BattlePassExpUpdateNotify : IMessage<BattlePassExpUpdateNotify>, IMessage, IEquatable<BattlePassExpUpdateNotify>, IDeepCloneable<BattlePassExpUpdateNotify>, IBufferMessage
	{
		// Token: 0x06002D53 RID: 11603 RVA: 0x00075B52 File Offset: 0x00073D52
		[NullableContext(1)]
		public static BattlePassExpUpdateNotify Create()
		{
			return new BattlePassExpUpdateNotify();
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x00075B59 File Offset: 0x00073D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x00075B5C File Offset: 0x00073D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassExpUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00075B63 File Offset: 0x00073D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassExpUpdateNotify()
		{
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00075B78 File Offset: 0x00073D78
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

		// Token: 0x06002D58 RID: 11608 RVA: 0x00075BD1 File Offset: 0x00073DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassExpUpdateNotify Clone()
		{
			return new BattlePassExpUpdateNotify(this);
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x00075BD9 File Offset: 0x00073DD9
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x00075BE1 File Offset: 0x00073DE1
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

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x00075BEA File Offset: 0x00073DEA
		// (set) Token: 0x06002D5C RID: 11612 RVA: 0x00075BF2 File Offset: 0x00073DF2
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

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x00075BFB File Offset: 0x00073DFB
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x00075C03 File Offset: 0x00073E03
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

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x00075C0C File Offset: 0x00073E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassRecurringReward> RecurringRewards
		{
			get
			{
				return this.recurringRewards_;
			}
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00075C14 File Offset: 0x00073E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassExpUpdateNotify);
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00075C24 File Offset: 0x00073E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassExpUpdateNotify other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Exp == other.Exp && this.WeeklyTotalExp == other.WeeklyTotalExp && this.recurringRewards_.Equals(other.recurringRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00075C94 File Offset: 0x00073E94
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

		// Token: 0x06002D63 RID: 11619 RVA: 0x00075D13 File Offset: 0x00073F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00075D20 File Offset: 0x00073F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00075D2C File Offset: 0x00073F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Exp);
			}
			this.recurringRewards_.WriteTo(ref output, BattlePassExpUpdateNotify._repeated_recurringRewards_codec);
			if (this.Level != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Level);
			}
			if (this.WeeklyTotalExp != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.WeeklyTotalExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00075DB4 File Offset: 0x00073FB4
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

		// Token: 0x06002D67 RID: 11623 RVA: 0x00075E38 File Offset: 0x00074038
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

		// Token: 0x06002D68 RID: 11624 RVA: 0x00075EAD File Offset: 0x000740AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00075EB8 File Offset: 0x000740B8
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
					if (num == 56U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
					if (num == 66U)
					{
						this.recurringRewards_.AddEntriesFrom(ref input, BattlePassExpUpdateNotify._repeated_recurringRewards_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.WeeklyTotalExp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002887 RID: 10375
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002888 RID: 10376
		public const int LevelFieldNumber = 11;

		// Token: 0x04002889 RID: 10377
		private int level_;

		// Token: 0x0400288A RID: 10378
		public const int ExpFieldNumber = 7;

		// Token: 0x0400288B RID: 10379
		private int exp_;

		// Token: 0x0400288C RID: 10380
		public const int WeeklyTotalExpFieldNumber = 13;

		// Token: 0x0400288D RID: 10381
		private int weeklyTotalExp_;

		// Token: 0x0400288E RID: 10382
		public const int RecurringRewardsFieldNumber = 8;

		// Token: 0x0400288F RID: 10383
		private static readonly FieldCodec<PbBattlePassRecurringReward> _repeated_recurringRewards_codec = FieldCodec.ForMessage<PbBattlePassRecurringReward>(66U, PbBattlePassRecurringReward.Parser);

		// Token: 0x04002890 RID: 10384
		private readonly RepeatedField<PbBattlePassRecurringReward> recurringRewards_ = new RepeatedField<PbBattlePassRecurringReward>();
	}
}
