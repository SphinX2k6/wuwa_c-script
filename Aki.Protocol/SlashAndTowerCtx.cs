using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001247 RID: 4679
	public sealed class SlashAndTowerCtx : IMessage<SlashAndTowerCtx>, IMessage, IEquatable<SlashAndTowerCtx>, IDeepCloneable<SlashAndTowerCtx>, IBufferMessage
	{
		// Token: 0x06018EEF RID: 102127 RVA: 0x003A0C79 File Offset: 0x0039EE79
		[NullableContext(1)]
		public static SlashAndTowerCtx Create()
		{
			return new SlashAndTowerCtx();
		}

		// Token: 0x17005414 RID: 21524
		// (get) Token: 0x06018EF0 RID: 102128 RVA: 0x003A0C80 File Offset: 0x0039EE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005415 RID: 21525
		// (get) Token: 0x06018EF1 RID: 102129 RVA: 0x003A0C83 File Offset: 0x0039EE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerCtx.Descriptor;
			}
		}

		// Token: 0x06018EF2 RID: 102130 RVA: 0x003A0C8A File Offset: 0x0039EE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerCtx()
		{
		}

		// Token: 0x06018EF3 RID: 102131 RVA: 0x003A0CB4 File Offset: 0x0039EEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerCtx(SlashAndTowerCtx other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.selectBuff_ = other.selectBuff_.Clone();
			this.secondRoles_ = other.secondRoles_.Clone();
			this.skillBranchIds_ = other.skillBranchIds_.Clone();
			this.reChallenge_ = other.reChallenge_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018EF4 RID: 102132 RVA: 0x003A0D23 File Offset: 0x0039EF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerCtx Clone()
		{
			return new SlashAndTowerCtx(this);
		}

		// Token: 0x17005416 RID: 21526
		// (get) Token: 0x06018EF5 RID: 102133 RVA: 0x003A0D2B File Offset: 0x0039EF2B
		// (set) Token: 0x06018EF6 RID: 102134 RVA: 0x003A0D33 File Offset: 0x0039EF33
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

		// Token: 0x17005417 RID: 21527
		// (get) Token: 0x06018EF7 RID: 102135 RVA: 0x003A0D3C File Offset: 0x0039EF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectBuff
		{
			get
			{
				return this.selectBuff_;
			}
		}

		// Token: 0x17005418 RID: 21528
		// (get) Token: 0x06018EF8 RID: 102136 RVA: 0x003A0D44 File Offset: 0x0039EF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SecondRoles
		{
			get
			{
				return this.secondRoles_;
			}
		}

		// Token: 0x17005419 RID: 21529
		// (get) Token: 0x06018EF9 RID: 102137 RVA: 0x003A0D4C File Offset: 0x0039EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchIds
		{
			get
			{
				return this.skillBranchIds_;
			}
		}

		// Token: 0x1700541A RID: 21530
		// (get) Token: 0x06018EFA RID: 102138 RVA: 0x003A0D54 File Offset: 0x0039EF54
		// (set) Token: 0x06018EFB RID: 102139 RVA: 0x003A0D5C File Offset: 0x0039EF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ReChallenge
		{
			get
			{
				return this.reChallenge_;
			}
			set
			{
				this.reChallenge_ = value;
			}
		}

		// Token: 0x06018EFC RID: 102140 RVA: 0x003A0D65 File Offset: 0x0039EF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerCtx);
		}

		// Token: 0x06018EFD RID: 102141 RVA: 0x003A0D74 File Offset: 0x0039EF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerCtx other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.selectBuff_.Equals(other.selectBuff_) && this.secondRoles_.Equals(other.secondRoles_) && this.skillBranchIds_.Equals(other.skillBranchIds_) && this.ReChallenge == other.ReChallenge && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018EFE RID: 102142 RVA: 0x003A0DFC File Offset: 0x0039EFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			num ^= this.selectBuff_.GetHashCode();
			num ^= this.secondRoles_.GetHashCode();
			num ^= this.skillBranchIds_.GetHashCode();
			if (this.ReChallenge)
			{
				num ^= this.ReChallenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018EFF RID: 102143 RVA: 0x003A0E7E File Offset: 0x0039F07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F00 RID: 102144 RVA: 0x003A0E8B File Offset: 0x0039F08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F01 RID: 102145 RVA: 0x003A0E94 File Offset: 0x0039F094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelsId);
			}
			this.selectBuff_.WriteTo(ref output, SlashAndTowerCtx._repeated_selectBuff_codec);
			this.secondRoles_.WriteTo(ref output, SlashAndTowerCtx._repeated_secondRoles_codec);
			this.skillBranchIds_.WriteTo(ref output, SlashAndTowerCtx._repeated_skillBranchIds_codec);
			if (this.ReChallenge)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.ReChallenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F02 RID: 102146 RVA: 0x003A0F20 File Offset: 0x0039F120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			num += this.selectBuff_.CalculateSize(SlashAndTowerCtx._repeated_selectBuff_codec);
			num += this.secondRoles_.CalculateSize(SlashAndTowerCtx._repeated_secondRoles_codec);
			num += this.skillBranchIds_.CalculateSize(SlashAndTowerCtx._repeated_skillBranchIds_codec);
			if (this.ReChallenge)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F03 RID: 102147 RVA: 0x003A0FA4 File Offset: 0x0039F1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			this.selectBuff_.Add(other.selectBuff_);
			this.secondRoles_.Add(other.secondRoles_);
			this.skillBranchIds_.Add(other.skillBranchIds_);
			if (other.ReChallenge)
			{
				this.ReChallenge = other.ReChallenge;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F04 RID: 102148 RVA: 0x003A1027 File Offset: 0x0039F227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F05 RID: 102149 RVA: 0x003A1030 File Offset: 0x0039F230
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
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.LevelsId = input.ReadInt32();
							continue;
						}
						if (num != 16U)
						{
							goto IL_48;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U)
						{
							goto IL_48;
						}
						goto IL_7D;
					}
					this.selectBuff_.AddEntriesFrom(ref input, SlashAndTowerCtx._repeated_selectBuff_codec);
					continue;
				}
				if (num <= 32U)
				{
					if (num == 26U)
					{
						goto IL_7D;
					}
					if (num != 32U)
					{
						goto IL_48;
					}
				}
				else if (num != 34U)
				{
					if (num != 40U)
					{
						goto IL_48;
					}
					this.ReChallenge = input.ReadBool();
					continue;
				}
				this.skillBranchIds_.AddEntriesFrom(ref input, SlashAndTowerCtx._repeated_skillBranchIds_codec);
				continue;
				IL_48:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_7D:
				this.secondRoles_.AddEntriesFrom(ref input, SlashAndTowerCtx._repeated_secondRoles_codec);
			}
		}

		// Token: 0x040092FF RID: 37631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009300 RID: 37632
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x04009301 RID: 37633
		private int levelsId_;

		// Token: 0x04009302 RID: 37634
		public const int SelectBuffFieldNumber = 2;

		// Token: 0x04009303 RID: 37635
		private static readonly FieldCodec<int> _repeated_selectBuff_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009304 RID: 37636
		private readonly RepeatedField<int> selectBuff_ = new RepeatedField<int>();

		// Token: 0x04009305 RID: 37637
		public const int SecondRolesFieldNumber = 3;

		// Token: 0x04009306 RID: 37638
		private static readonly FieldCodec<int> _repeated_secondRoles_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009307 RID: 37639
		private readonly RepeatedField<int> secondRoles_ = new RepeatedField<int>();

		// Token: 0x04009308 RID: 37640
		public const int SkillBranchIdsFieldNumber = 4;

		// Token: 0x04009309 RID: 37641
		private static readonly FieldCodec<int> _repeated_skillBranchIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400930A RID: 37642
		private readonly RepeatedField<int> skillBranchIds_ = new RepeatedField<int>();

		// Token: 0x0400930B RID: 37643
		public const int ReChallengeFieldNumber = 5;

		// Token: 0x0400930C RID: 37644
		private bool reChallenge_;
	}
}
