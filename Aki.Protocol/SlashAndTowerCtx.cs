using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001284 RID: 4740
	public sealed class SlashAndTowerCtx : IMessage<SlashAndTowerCtx>, IMessage, IEquatable<SlashAndTowerCtx>, IDeepCloneable<SlashAndTowerCtx>, IBufferMessage
	{
		// Token: 0x060194D9 RID: 103641 RVA: 0x003B0BD9 File Offset: 0x003AEDD9
		[NullableContext(1)]
		public static SlashAndTowerCtx Create()
		{
			return new SlashAndTowerCtx();
		}

		// Token: 0x17005593 RID: 21907
		// (get) Token: 0x060194DA RID: 103642 RVA: 0x003B0BE0 File Offset: 0x003AEDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005594 RID: 21908
		// (get) Token: 0x060194DB RID: 103643 RVA: 0x003B0BE3 File Offset: 0x003AEDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerCtx.Descriptor;
			}
		}

		// Token: 0x060194DC RID: 103644 RVA: 0x003B0BEA File Offset: 0x003AEDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerCtx()
		{
		}

		// Token: 0x060194DD RID: 103645 RVA: 0x003B0C14 File Offset: 0x003AEE14
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

		// Token: 0x060194DE RID: 103646 RVA: 0x003B0C83 File Offset: 0x003AEE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerCtx Clone()
		{
			return new SlashAndTowerCtx(this);
		}

		// Token: 0x17005595 RID: 21909
		// (get) Token: 0x060194DF RID: 103647 RVA: 0x003B0C8B File Offset: 0x003AEE8B
		// (set) Token: 0x060194E0 RID: 103648 RVA: 0x003B0C93 File Offset: 0x003AEE93
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

		// Token: 0x17005596 RID: 21910
		// (get) Token: 0x060194E1 RID: 103649 RVA: 0x003B0C9C File Offset: 0x003AEE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectBuff
		{
			get
			{
				return this.selectBuff_;
			}
		}

		// Token: 0x17005597 RID: 21911
		// (get) Token: 0x060194E2 RID: 103650 RVA: 0x003B0CA4 File Offset: 0x003AEEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SecondRoles
		{
			get
			{
				return this.secondRoles_;
			}
		}

		// Token: 0x17005598 RID: 21912
		// (get) Token: 0x060194E3 RID: 103651 RVA: 0x003B0CAC File Offset: 0x003AEEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchIds
		{
			get
			{
				return this.skillBranchIds_;
			}
		}

		// Token: 0x17005599 RID: 21913
		// (get) Token: 0x060194E4 RID: 103652 RVA: 0x003B0CB4 File Offset: 0x003AEEB4
		// (set) Token: 0x060194E5 RID: 103653 RVA: 0x003B0CBC File Offset: 0x003AEEBC
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

		// Token: 0x060194E6 RID: 103654 RVA: 0x003B0CC5 File Offset: 0x003AEEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerCtx);
		}

		// Token: 0x060194E7 RID: 103655 RVA: 0x003B0CD4 File Offset: 0x003AEED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerCtx other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.selectBuff_.Equals(other.selectBuff_) && this.secondRoles_.Equals(other.secondRoles_) && this.skillBranchIds_.Equals(other.skillBranchIds_) && this.ReChallenge == other.ReChallenge && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194E8 RID: 103656 RVA: 0x003B0D5C File Offset: 0x003AEF5C
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

		// Token: 0x060194E9 RID: 103657 RVA: 0x003B0DDE File Offset: 0x003AEFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194EA RID: 103658 RVA: 0x003B0DEB File Offset: 0x003AEFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194EB RID: 103659 RVA: 0x003B0DF4 File Offset: 0x003AEFF4
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

		// Token: 0x060194EC RID: 103660 RVA: 0x003B0E80 File Offset: 0x003AF080
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

		// Token: 0x060194ED RID: 103661 RVA: 0x003B0F04 File Offset: 0x003AF104
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

		// Token: 0x060194EE RID: 103662 RVA: 0x003B0F87 File Offset: 0x003AF187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194EF RID: 103663 RVA: 0x003B0F90 File Offset: 0x003AF190
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

		// Token: 0x040095B1 RID: 38321
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095B2 RID: 38322
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x040095B3 RID: 38323
		private int levelsId_;

		// Token: 0x040095B4 RID: 38324
		public const int SelectBuffFieldNumber = 2;

		// Token: 0x040095B5 RID: 38325
		private static readonly FieldCodec<int> _repeated_selectBuff_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040095B6 RID: 38326
		private readonly RepeatedField<int> selectBuff_ = new RepeatedField<int>();

		// Token: 0x040095B7 RID: 38327
		public const int SecondRolesFieldNumber = 3;

		// Token: 0x040095B8 RID: 38328
		private static readonly FieldCodec<int> _repeated_secondRoles_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040095B9 RID: 38329
		private readonly RepeatedField<int> secondRoles_ = new RepeatedField<int>();

		// Token: 0x040095BA RID: 38330
		public const int SkillBranchIdsFieldNumber = 4;

		// Token: 0x040095BB RID: 38331
		private static readonly FieldCodec<int> _repeated_skillBranchIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040095BC RID: 38332
		private readonly RepeatedField<int> skillBranchIds_ = new RepeatedField<int>();

		// Token: 0x040095BD RID: 38333
		public const int ReChallengeFieldNumber = 5;

		// Token: 0x040095BE RID: 38334
		private bool reChallenge_;
	}
}
