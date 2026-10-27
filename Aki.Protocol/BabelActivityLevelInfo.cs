using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000144 RID: 324
	public sealed class BabelActivityLevelInfo : IMessage<BabelActivityLevelInfo>, IMessage, IEquatable<BabelActivityLevelInfo>, IDeepCloneable<BabelActivityLevelInfo>, IBufferMessage
	{
		// Token: 0x060029D0 RID: 10704 RVA: 0x0006D9C1 File Offset: 0x0006BBC1
		[NullableContext(1)]
		public static BabelActivityLevelInfo Create()
		{
			return new BabelActivityLevelInfo();
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x0006D9C8 File Offset: 0x0006BBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BabelActivityLevelInfo> Parser
		{
			get
			{
				return BabelActivityLevelInfo._parser;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x0006D9CF File Offset: 0x0006BBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x0006D9D2 File Offset: 0x0006BBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityLevelInfo.Descriptor;
			}
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x0006D9DC File Offset: 0x0006BBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfo()
		{
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0006DA3C File Offset: 0x0006BC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfo(BabelActivityLevelInfo other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.unlockTime_ = other.unlockTime_;
			this.babelDeTermId_ = other.babelDeTermId_.Clone();
			this.limitWeaponTypes_ = other.limitWeaponTypes_.Clone();
			this.buffSelection_ = other.buffSelection_.Clone();
			this.roleSelection_ = other.roleSelection_.Clone();
			this.passStar_ = other.passStar_;
			this.isFinished_ = other.isFinished_;
			this.maxPassRoleSelection_ = other.maxPassRoleSelection_.Clone();
			this.maxPassBuffSelection_ = other.maxPassBuffSelection_.Clone();
			this.maxPassStar_ = other.maxPassStar_;
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this.maxPassUseTime_ = other.maxPassUseTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0006DB1F File Offset: 0x0006BD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfo Clone()
		{
			return new BabelActivityLevelInfo(this);
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x0006DB27 File Offset: 0x0006BD27
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x0006DB2F File Offset: 0x0006BD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelsId
		{
			get
			{
				return this.levelsId_;
			}
			set
			{
				this.levelsId_ = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x0006DB38 File Offset: 0x0006BD38
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x0006DB40 File Offset: 0x0006BD40
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

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x0006DB49 File Offset: 0x0006BD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BabelDeTermId
		{
			get
			{
				return this.babelDeTermId_;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x0006DB51 File Offset: 0x0006BD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LimitWeaponTypes
		{
			get
			{
				return this.limitWeaponTypes_;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x0006DB59 File Offset: 0x0006BD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffSelection
		{
			get
			{
				return this.buffSelection_;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060029DE RID: 10718 RVA: 0x0006DB61 File Offset: 0x0006BD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleSelection
		{
			get
			{
				return this.roleSelection_;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x0006DB69 File Offset: 0x0006BD69
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x0006DB71 File Offset: 0x0006BD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassStar
		{
			get
			{
				return this.passStar_;
			}
			set
			{
				this.passStar_ = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0006DB7A File Offset: 0x0006BD7A
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x0006DB82 File Offset: 0x0006BD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x0006DB8B File Offset: 0x0006BD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MaxPassRoleSelection
		{
			get
			{
				return this.maxPassRoleSelection_;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x0006DB93 File Offset: 0x0006BD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MaxPassBuffSelection
		{
			get
			{
				return this.maxPassBuffSelection_;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x0006DB9B File Offset: 0x0006BD9B
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x0006DBA3 File Offset: 0x0006BDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxPassStar
		{
			get
			{
				return this.maxPassStar_;
			}
			set
			{
				this.maxPassStar_ = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x0006DBAC File Offset: 0x0006BDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x0006DBB4 File Offset: 0x0006BDB4
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x0006DBBC File Offset: 0x0006BDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxPassUseTime
		{
			get
			{
				return this.maxPassUseTime_;
			}
			set
			{
				this.maxPassUseTime_ = value;
			}
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x0006DBC5 File Offset: 0x0006BDC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityLevelInfo);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x0006DBD4 File Offset: 0x0006BDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityLevelInfo other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.UnlockTime == other.UnlockTime && this.babelDeTermId_.Equals(other.babelDeTermId_) && this.limitWeaponTypes_.Equals(other.limitWeaponTypes_) && this.buffSelection_.Equals(other.buffSelection_) && this.roleSelection_.Equals(other.roleSelection_) && this.PassStar == other.PassStar && this.IsFinished == other.IsFinished && this.maxPassRoleSelection_.Equals(other.maxPassRoleSelection_) && this.maxPassBuffSelection_.Equals(other.maxPassBuffSelection_) && this.MaxPassStar == other.MaxPassStar && this.skillBranchId_.Equals(other.skillBranchId_) && this.MaxPassUseTime == other.MaxPassUseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x0006DCF0 File Offset: 0x0006BEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			num ^= this.babelDeTermId_.GetHashCode();
			num ^= this.limitWeaponTypes_.GetHashCode();
			num ^= this.buffSelection_.GetHashCode();
			num ^= this.roleSelection_.GetHashCode();
			if (this.PassStar != 0)
			{
				num ^= this.PassStar.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			num ^= this.maxPassRoleSelection_.GetHashCode();
			num ^= this.maxPassBuffSelection_.GetHashCode();
			if (this.MaxPassStar != 0)
			{
				num ^= this.MaxPassStar.GetHashCode();
			}
			num ^= this.skillBranchId_.GetHashCode();
			if (this.MaxPassUseTime != 0)
			{
				num ^= this.MaxPassUseTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x0006DE0E File Offset: 0x0006C00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x0006DE1B File Offset: 0x0006C01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x0006DE24 File Offset: 0x0006C024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelsId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			this.babelDeTermId_.WriteTo(ref output, BabelActivityLevelInfo._repeated_babelDeTermId_codec);
			this.limitWeaponTypes_.WriteTo(ref output, BabelActivityLevelInfo._repeated_limitWeaponTypes_codec);
			this.buffSelection_.WriteTo(ref output, BabelActivityLevelInfo._repeated_buffSelection_codec);
			this.roleSelection_.WriteTo(ref output, BabelActivityLevelInfo._repeated_roleSelection_codec);
			if (this.PassStar != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PassStar);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsFinished);
			}
			this.maxPassRoleSelection_.WriteTo(ref output, BabelActivityLevelInfo._repeated_maxPassRoleSelection_codec);
			this.maxPassBuffSelection_.WriteTo(ref output, BabelActivityLevelInfo._repeated_maxPassBuffSelection_codec);
			if (this.MaxPassStar != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MaxPassStar);
			}
			this.skillBranchId_.WriteTo(ref output, BabelActivityLevelInfo._repeated_skillBranchId_codec);
			if (this.MaxPassUseTime != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MaxPassUseTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x0006DF64 File Offset: 0x0006C164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			num += this.babelDeTermId_.CalculateSize(BabelActivityLevelInfo._repeated_babelDeTermId_codec);
			num += this.limitWeaponTypes_.CalculateSize(BabelActivityLevelInfo._repeated_limitWeaponTypes_codec);
			num += this.buffSelection_.CalculateSize(BabelActivityLevelInfo._repeated_buffSelection_codec);
			num += this.roleSelection_.CalculateSize(BabelActivityLevelInfo._repeated_roleSelection_codec);
			if (this.PassStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassStar);
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			num += this.maxPassRoleSelection_.CalculateSize(BabelActivityLevelInfo._repeated_maxPassRoleSelection_codec);
			num += this.maxPassBuffSelection_.CalculateSize(BabelActivityLevelInfo._repeated_maxPassBuffSelection_codec);
			if (this.MaxPassStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxPassStar);
			}
			num += this.skillBranchId_.CalculateSize(BabelActivityLevelInfo._repeated_skillBranchId_codec);
			if (this.MaxPassUseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxPassUseTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x0006E094 File Offset: 0x0006C294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this.babelDeTermId_.Add(other.babelDeTermId_);
			this.limitWeaponTypes_.Add(other.limitWeaponTypes_);
			this.buffSelection_.Add(other.buffSelection_);
			this.roleSelection_.Add(other.roleSelection_);
			if (other.PassStar != 0)
			{
				this.PassStar = other.PassStar;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			this.maxPassRoleSelection_.Add(other.maxPassRoleSelection_);
			this.maxPassBuffSelection_.Add(other.maxPassBuffSelection_);
			if (other.MaxPassStar != 0)
			{
				this.MaxPassStar = other.MaxPassStar;
			}
			this.skillBranchId_.Add(other.skillBranchId_);
			if (other.MaxPassUseTime != 0)
			{
				this.MaxPassUseTime = other.MaxPassUseTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x0006E1AB File Offset: 0x0006C3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x0006E1B4 File Offset: 0x0006C3B4
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
					if (num > 32U)
					{
						if (num <= 40U)
						{
							if (num == 34U)
							{
								goto IL_131;
							}
							if (num != 40U)
							{
								goto IL_E2;
							}
						}
						else if (num != 42U)
						{
							if (num != 48U && num != 50U)
							{
								goto IL_E2;
							}
							this.roleSelection_.AddEntriesFrom(ref input, BabelActivityLevelInfo._repeated_roleSelection_codec);
							continue;
						}
						this.buffSelection_.AddEntriesFrom(ref input, BabelActivityLevelInfo._repeated_buffSelection_codec);
						continue;
					}
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.LevelsId = input.ReadInt32();
							continue;
						}
						if (num != 16U)
						{
							goto IL_E2;
						}
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					else
					{
						if (num == 24U || num == 26U)
						{
							this.babelDeTermId_.AddEntriesFrom(ref input, BabelActivityLevelInfo._repeated_babelDeTermId_codec);
							continue;
						}
						if (num != 32U)
						{
							goto IL_E2;
						}
					}
					IL_131:
					this.limitWeaponTypes_.AddEntriesFrom(ref input, BabelActivityLevelInfo._repeated_limitWeaponTypes_codec);
					continue;
				}
				if (num <= 80U)
				{
					if (num <= 64U)
					{
						if (num == 56U)
						{
							this.PassStar = input.ReadInt32();
							continue;
						}
						if (num != 64U)
						{
							goto IL_E2;
						}
						this.IsFinished = input.ReadBool();
						continue;
					}
					else
					{
						if (num == 72U || num == 74U)
						{
							this.maxPassRoleSelection_.AddEntriesFrom(ref input, BabelActivityLevelInfo._repeated_maxPassRoleSelection_codec);
							continue;
						}
						if (num != 80U)
						{
							goto IL_E2;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num != 82U)
					{
						if (num != 88U)
						{
							goto IL_E2;
						}
						this.MaxPassStar = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U || num == 98U)
					{
						this.skillBranchId_.AddEntriesFrom(ref input, BabelActivityLevelInfo._repeated_skillBranchId_codec);
						continue;
					}
					if (num != 104U)
					{
						goto IL_E2;
					}
					this.MaxPassUseTime = input.ReadInt32();
					continue;
				}
				this.maxPassBuffSelection_.AddEntriesFrom(ref input, BabelActivityLevelInfo._repeated_maxPassBuffSelection_codec);
				continue;
				IL_E2:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400271A RID: 10010
		private static readonly MessageParser<BabelActivityLevelInfo> _parser = new MessageParser<BabelActivityLevelInfo>(() => new BabelActivityLevelInfo());

		// Token: 0x0400271B RID: 10011
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400271C RID: 10012
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x0400271D RID: 10013
		private int levelsId_;

		// Token: 0x0400271E RID: 10014
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x0400271F RID: 10015
		private long unlockTime_;

		// Token: 0x04002720 RID: 10016
		public const int BabelDeTermIdFieldNumber = 3;

		// Token: 0x04002721 RID: 10017
		private static readonly FieldCodec<int> _repeated_babelDeTermId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002722 RID: 10018
		private readonly RepeatedField<int> babelDeTermId_ = new RepeatedField<int>();

		// Token: 0x04002723 RID: 10019
		public const int LimitWeaponTypesFieldNumber = 4;

		// Token: 0x04002724 RID: 10020
		private static readonly FieldCodec<int> _repeated_limitWeaponTypes_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04002725 RID: 10021
		private readonly RepeatedField<int> limitWeaponTypes_ = new RepeatedField<int>();

		// Token: 0x04002726 RID: 10022
		public const int BuffSelectionFieldNumber = 5;

		// Token: 0x04002727 RID: 10023
		private static readonly FieldCodec<int> _repeated_buffSelection_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04002728 RID: 10024
		private readonly RepeatedField<int> buffSelection_ = new RepeatedField<int>();

		// Token: 0x04002729 RID: 10025
		public const int RoleSelectionFieldNumber = 6;

		// Token: 0x0400272A RID: 10026
		private static readonly FieldCodec<int> _repeated_roleSelection_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400272B RID: 10027
		private readonly RepeatedField<int> roleSelection_ = new RepeatedField<int>();

		// Token: 0x0400272C RID: 10028
		public const int PassStarFieldNumber = 7;

		// Token: 0x0400272D RID: 10029
		private int passStar_;

		// Token: 0x0400272E RID: 10030
		public const int IsFinishedFieldNumber = 8;

		// Token: 0x0400272F RID: 10031
		private bool isFinished_;

		// Token: 0x04002730 RID: 10032
		public const int MaxPassRoleSelectionFieldNumber = 9;

		// Token: 0x04002731 RID: 10033
		private static readonly FieldCodec<int> _repeated_maxPassRoleSelection_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04002732 RID: 10034
		private readonly RepeatedField<int> maxPassRoleSelection_ = new RepeatedField<int>();

		// Token: 0x04002733 RID: 10035
		public const int MaxPassBuffSelectionFieldNumber = 10;

		// Token: 0x04002734 RID: 10036
		private static readonly FieldCodec<int> _repeated_maxPassBuffSelection_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04002735 RID: 10037
		private readonly RepeatedField<int> maxPassBuffSelection_ = new RepeatedField<int>();

		// Token: 0x04002736 RID: 10038
		public const int MaxPassStarFieldNumber = 11;

		// Token: 0x04002737 RID: 10039
		private int maxPassStar_;

		// Token: 0x04002738 RID: 10040
		public const int SkillBranchIdFieldNumber = 12;

		// Token: 0x04002739 RID: 10041
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400273A RID: 10042
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();

		// Token: 0x0400273B RID: 10043
		public const int MaxPassUseTimeFieldNumber = 13;

		// Token: 0x0400273C RID: 10044
		private int maxPassUseTime_;
	}
}
