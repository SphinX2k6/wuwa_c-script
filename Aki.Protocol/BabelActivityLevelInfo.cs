using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000147 RID: 327
	public sealed class BabelActivityLevelInfo : IMessage<BabelActivityLevelInfo>, IMessage, IEquatable<BabelActivityLevelInfo>, IDeepCloneable<BabelActivityLevelInfo>, IBufferMessage
	{
		// Token: 0x06002A47 RID: 10823 RVA: 0x0006EDF5 File Offset: 0x0006CFF5
		[NullableContext(1)]
		public static BabelActivityLevelInfo Create()
		{
			return new BabelActivityLevelInfo();
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x0006EDFC File Offset: 0x0006CFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BabelActivityLevelInfo> Parser
		{
			get
			{
				return BabelActivityLevelInfo._parser;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x0006EE03 File Offset: 0x0006D003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x0006EE06 File Offset: 0x0006D006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityLevelInfo.Descriptor;
			}
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x0006EE10 File Offset: 0x0006D010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfo()
		{
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x0006EE70 File Offset: 0x0006D070
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

		// Token: 0x06002A4D RID: 10829 RVA: 0x0006EF53 File Offset: 0x0006D153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfo Clone()
		{
			return new BabelActivityLevelInfo(this);
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x0006EF5B File Offset: 0x0006D15B
		// (set) Token: 0x06002A4F RID: 10831 RVA: 0x0006EF63 File Offset: 0x0006D163
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

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x0006EF6C File Offset: 0x0006D16C
		// (set) Token: 0x06002A51 RID: 10833 RVA: 0x0006EF74 File Offset: 0x0006D174
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x0006EF7D File Offset: 0x0006D17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BabelDeTermId
		{
			get
			{
				return this.babelDeTermId_;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x0006EF85 File Offset: 0x0006D185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LimitWeaponTypes
		{
			get
			{
				return this.limitWeaponTypes_;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x0006EF8D File Offset: 0x0006D18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffSelection
		{
			get
			{
				return this.buffSelection_;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x0006EF95 File Offset: 0x0006D195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleSelection
		{
			get
			{
				return this.roleSelection_;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x0006EF9D File Offset: 0x0006D19D
		// (set) Token: 0x06002A57 RID: 10839 RVA: 0x0006EFA5 File Offset: 0x0006D1A5
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x0006EFAE File Offset: 0x0006D1AE
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x0006EFB6 File Offset: 0x0006D1B6
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x0006EFBF File Offset: 0x0006D1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MaxPassRoleSelection
		{
			get
			{
				return this.maxPassRoleSelection_;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x0006EFC7 File Offset: 0x0006D1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MaxPassBuffSelection
		{
			get
			{
				return this.maxPassBuffSelection_;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x0006EFCF File Offset: 0x0006D1CF
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x0006EFD7 File Offset: 0x0006D1D7
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

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x0006EFE0 File Offset: 0x0006D1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x0006EFE8 File Offset: 0x0006D1E8
		// (set) Token: 0x06002A60 RID: 10848 RVA: 0x0006EFF0 File Offset: 0x0006D1F0
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

		// Token: 0x06002A61 RID: 10849 RVA: 0x0006EFF9 File Offset: 0x0006D1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityLevelInfo);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x0006F008 File Offset: 0x0006D208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityLevelInfo other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.UnlockTime == other.UnlockTime && this.babelDeTermId_.Equals(other.babelDeTermId_) && this.limitWeaponTypes_.Equals(other.limitWeaponTypes_) && this.buffSelection_.Equals(other.buffSelection_) && this.roleSelection_.Equals(other.roleSelection_) && this.PassStar == other.PassStar && this.IsFinished == other.IsFinished && this.maxPassRoleSelection_.Equals(other.maxPassRoleSelection_) && this.maxPassBuffSelection_.Equals(other.maxPassBuffSelection_) && this.MaxPassStar == other.MaxPassStar && this.skillBranchId_.Equals(other.skillBranchId_) && this.MaxPassUseTime == other.MaxPassUseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x0006F124 File Offset: 0x0006D324
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

		// Token: 0x06002A64 RID: 10852 RVA: 0x0006F242 File Offset: 0x0006D442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x0006F24F File Offset: 0x0006D44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x0006F258 File Offset: 0x0006D458
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

		// Token: 0x06002A67 RID: 10855 RVA: 0x0006F398 File Offset: 0x0006D598
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

		// Token: 0x06002A68 RID: 10856 RVA: 0x0006F4C8 File Offset: 0x0006D6C8
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

		// Token: 0x06002A69 RID: 10857 RVA: 0x0006F5DF File Offset: 0x0006D7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x0006F5E8 File Offset: 0x0006D7E8
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

		// Token: 0x0400278E RID: 10126
		private static readonly MessageParser<BabelActivityLevelInfo> _parser = new MessageParser<BabelActivityLevelInfo>(() => new BabelActivityLevelInfo());

		// Token: 0x0400278F RID: 10127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002790 RID: 10128
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x04002791 RID: 10129
		private int levelsId_;

		// Token: 0x04002792 RID: 10130
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04002793 RID: 10131
		private long unlockTime_;

		// Token: 0x04002794 RID: 10132
		public const int BabelDeTermIdFieldNumber = 3;

		// Token: 0x04002795 RID: 10133
		private static readonly FieldCodec<int> _repeated_babelDeTermId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002796 RID: 10134
		private readonly RepeatedField<int> babelDeTermId_ = new RepeatedField<int>();

		// Token: 0x04002797 RID: 10135
		public const int LimitWeaponTypesFieldNumber = 4;

		// Token: 0x04002798 RID: 10136
		private static readonly FieldCodec<int> _repeated_limitWeaponTypes_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04002799 RID: 10137
		private readonly RepeatedField<int> limitWeaponTypes_ = new RepeatedField<int>();

		// Token: 0x0400279A RID: 10138
		public const int BuffSelectionFieldNumber = 5;

		// Token: 0x0400279B RID: 10139
		private static readonly FieldCodec<int> _repeated_buffSelection_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400279C RID: 10140
		private readonly RepeatedField<int> buffSelection_ = new RepeatedField<int>();

		// Token: 0x0400279D RID: 10141
		public const int RoleSelectionFieldNumber = 6;

		// Token: 0x0400279E RID: 10142
		private static readonly FieldCodec<int> _repeated_roleSelection_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400279F RID: 10143
		private readonly RepeatedField<int> roleSelection_ = new RepeatedField<int>();

		// Token: 0x040027A0 RID: 10144
		public const int PassStarFieldNumber = 7;

		// Token: 0x040027A1 RID: 10145
		private int passStar_;

		// Token: 0x040027A2 RID: 10146
		public const int IsFinishedFieldNumber = 8;

		// Token: 0x040027A3 RID: 10147
		private bool isFinished_;

		// Token: 0x040027A4 RID: 10148
		public const int MaxPassRoleSelectionFieldNumber = 9;

		// Token: 0x040027A5 RID: 10149
		private static readonly FieldCodec<int> _repeated_maxPassRoleSelection_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040027A6 RID: 10150
		private readonly RepeatedField<int> maxPassRoleSelection_ = new RepeatedField<int>();

		// Token: 0x040027A7 RID: 10151
		public const int MaxPassBuffSelectionFieldNumber = 10;

		// Token: 0x040027A8 RID: 10152
		private static readonly FieldCodec<int> _repeated_maxPassBuffSelection_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040027A9 RID: 10153
		private readonly RepeatedField<int> maxPassBuffSelection_ = new RepeatedField<int>();

		// Token: 0x040027AA RID: 10154
		public const int MaxPassStarFieldNumber = 11;

		// Token: 0x040027AB RID: 10155
		private int maxPassStar_;

		// Token: 0x040027AC RID: 10156
		public const int SkillBranchIdFieldNumber = 12;

		// Token: 0x040027AD RID: 10157
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040027AE RID: 10158
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();

		// Token: 0x040027AF RID: 10159
		public const int MaxPassUseTimeFieldNumber = 13;

		// Token: 0x040027B0 RID: 10160
		private int maxPassUseTime_;
	}
}
