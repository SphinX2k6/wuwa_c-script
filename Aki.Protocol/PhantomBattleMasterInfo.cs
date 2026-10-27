using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C96 RID: 3222
	public sealed class PhantomBattleMasterInfo : IMessage<PhantomBattleMasterInfo>, IMessage, IEquatable<PhantomBattleMasterInfo>, IDeepCloneable<PhantomBattleMasterInfo>, IBufferMessage
	{
		// Token: 0x0601176A RID: 71530 RVA: 0x0028F0B7 File Offset: 0x0028D2B7
		[NullableContext(1)]
		public static PhantomBattleMasterInfo Create()
		{
			return new PhantomBattleMasterInfo();
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0601176B RID: 71531 RVA: 0x0028F0BE File Offset: 0x0028D2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0601176C RID: 71532 RVA: 0x0028F0C1 File Offset: 0x0028D2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleMasterInfo.Descriptor;
			}
		}

		// Token: 0x0601176D RID: 71533 RVA: 0x0028F0C8 File Offset: 0x0028D2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfo()
		{
		}

		// Token: 0x0601176E RID: 71534 RVA: 0x0028F0DC File Offset: 0x0028D2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfo(PhantomBattleMasterInfo other) : this()
		{
			this.phantomBattleMasterLevelId_ = other.phantomBattleMasterLevelId_;
			this.exp_ = other.exp_;
			this.rewardedPhantomBattleMasterLevelIds_ = other.rewardedPhantomBattleMasterLevelIds_.Clone();
			this.weekRewardExp_ = other.weekRewardExp_;
			this.lastUseCardGroupIndex_ = other.lastUseCardGroupIndex_;
			this.lastUseCardRoleId_ = other.lastUseCardRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601176F RID: 71535 RVA: 0x0028F14D File Offset: 0x0028D34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfo Clone()
		{
			return new PhantomBattleMasterInfo(this);
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x06011770 RID: 71536 RVA: 0x0028F155 File Offset: 0x0028D355
		// (set) Token: 0x06011771 RID: 71537 RVA: 0x0028F15D File Offset: 0x0028D35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleMasterLevelId
		{
			get
			{
				return this.phantomBattleMasterLevelId_;
			}
			set
			{
				this.phantomBattleMasterLevelId_ = value;
			}
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x06011772 RID: 71538 RVA: 0x0028F166 File Offset: 0x0028D366
		// (set) Token: 0x06011773 RID: 71539 RVA: 0x0028F16E File Offset: 0x0028D36E
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

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x06011774 RID: 71540 RVA: 0x0028F177 File Offset: 0x0028D377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedPhantomBattleMasterLevelIds
		{
			get
			{
				return this.rewardedPhantomBattleMasterLevelIds_;
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x06011775 RID: 71541 RVA: 0x0028F17F File Offset: 0x0028D37F
		// (set) Token: 0x06011776 RID: 71542 RVA: 0x0028F187 File Offset: 0x0028D387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekRewardExp
		{
			get
			{
				return this.weekRewardExp_;
			}
			set
			{
				this.weekRewardExp_ = value;
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x06011777 RID: 71543 RVA: 0x0028F190 File Offset: 0x0028D390
		// (set) Token: 0x06011778 RID: 71544 RVA: 0x0028F198 File Offset: 0x0028D398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastUseCardGroupIndex
		{
			get
			{
				return this.lastUseCardGroupIndex_;
			}
			set
			{
				this.lastUseCardGroupIndex_ = value;
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x06011779 RID: 71545 RVA: 0x0028F1A1 File Offset: 0x0028D3A1
		// (set) Token: 0x0601177A RID: 71546 RVA: 0x0028F1A9 File Offset: 0x0028D3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastUseCardRoleId
		{
			get
			{
				return this.lastUseCardRoleId_;
			}
			set
			{
				this.lastUseCardRoleId_ = value;
			}
		}

		// Token: 0x0601177B RID: 71547 RVA: 0x0028F1B2 File Offset: 0x0028D3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleMasterInfo);
		}

		// Token: 0x0601177C RID: 71548 RVA: 0x0028F1C0 File Offset: 0x0028D3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleMasterInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleMasterLevelId == other.PhantomBattleMasterLevelId && this.Exp == other.Exp && this.rewardedPhantomBattleMasterLevelIds_.Equals(other.rewardedPhantomBattleMasterLevelIds_) && this.WeekRewardExp == other.WeekRewardExp && this.LastUseCardGroupIndex == other.LastUseCardGroupIndex && this.LastUseCardRoleId == other.LastUseCardRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601177D RID: 71549 RVA: 0x0028F250 File Offset: 0x0028D450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleMasterLevelId != 0)
			{
				num ^= this.PhantomBattleMasterLevelId.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.rewardedPhantomBattleMasterLevelIds_.GetHashCode();
			if (this.WeekRewardExp != 0)
			{
				num ^= this.WeekRewardExp.GetHashCode();
			}
			if (this.LastUseCardGroupIndex != 0)
			{
				num ^= this.LastUseCardGroupIndex.GetHashCode();
			}
			if (this.LastUseCardRoleId != 0)
			{
				num ^= this.LastUseCardRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601177E RID: 71550 RVA: 0x0028F301 File Offset: 0x0028D501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601177F RID: 71551 RVA: 0x0028F30E File Offset: 0x0028D50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011780 RID: 71552 RVA: 0x0028F318 File Offset: 0x0028D518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleMasterLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleMasterLevelId);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Exp);
			}
			this.rewardedPhantomBattleMasterLevelIds_.WriteTo(ref output, PhantomBattleMasterInfo._repeated_rewardedPhantomBattleMasterLevelIds_codec);
			if (this.WeekRewardExp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WeekRewardExp);
			}
			if (this.LastUseCardGroupIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LastUseCardGroupIndex);
			}
			if (this.LastUseCardRoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LastUseCardRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011781 RID: 71553 RVA: 0x0028F3D8 File Offset: 0x0028D5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleMasterLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleMasterLevelId);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			num += this.rewardedPhantomBattleMasterLevelIds_.CalculateSize(PhantomBattleMasterInfo._repeated_rewardedPhantomBattleMasterLevelIds_codec);
			if (this.WeekRewardExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekRewardExp);
			}
			if (this.LastUseCardGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastUseCardGroupIndex);
			}
			if (this.LastUseCardRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastUseCardRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011782 RID: 71554 RVA: 0x0028F48C File Offset: 0x0028D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleMasterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleMasterLevelId != 0)
			{
				this.PhantomBattleMasterLevelId = other.PhantomBattleMasterLevelId;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			this.rewardedPhantomBattleMasterLevelIds_.Add(other.rewardedPhantomBattleMasterLevelIds_);
			if (other.WeekRewardExp != 0)
			{
				this.WeekRewardExp = other.WeekRewardExp;
			}
			if (other.LastUseCardGroupIndex != 0)
			{
				this.LastUseCardGroupIndex = other.LastUseCardGroupIndex;
			}
			if (other.LastUseCardRoleId != 0)
			{
				this.LastUseCardRoleId = other.LastUseCardRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011783 RID: 71555 RVA: 0x0028F529 File Offset: 0x0028D729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011784 RID: 71556 RVA: 0x0028F534 File Offset: 0x0028D734
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
						this.PhantomBattleMasterLevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_6C;
					}
				}
				else if (num <= 32U)
				{
					if (num == 26U)
					{
						goto IL_6C;
					}
					if (num == 32U)
					{
						this.WeekRewardExp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.LastUseCardGroupIndex = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.LastUseCardRoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_6C:
				this.rewardedPhantomBattleMasterLevelIds_.AddEntriesFrom(ref input, PhantomBattleMasterInfo._repeated_rewardedPhantomBattleMasterLevelIds_codec);
			}
		}

		// Token: 0x04006E34 RID: 28212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E35 RID: 28213
		public const int PhantomBattleMasterLevelIdFieldNumber = 1;

		// Token: 0x04006E36 RID: 28214
		private int phantomBattleMasterLevelId_;

		// Token: 0x04006E37 RID: 28215
		public const int ExpFieldNumber = 2;

		// Token: 0x04006E38 RID: 28216
		private int exp_;

		// Token: 0x04006E39 RID: 28217
		public const int RewardedPhantomBattleMasterLevelIdsFieldNumber = 3;

		// Token: 0x04006E3A RID: 28218
		private static readonly FieldCodec<int> _repeated_rewardedPhantomBattleMasterLevelIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006E3B RID: 28219
		private readonly RepeatedField<int> rewardedPhantomBattleMasterLevelIds_ = new RepeatedField<int>();

		// Token: 0x04006E3C RID: 28220
		public const int WeekRewardExpFieldNumber = 4;

		// Token: 0x04006E3D RID: 28221
		private int weekRewardExp_;

		// Token: 0x04006E3E RID: 28222
		public const int LastUseCardGroupIndexFieldNumber = 5;

		// Token: 0x04006E3F RID: 28223
		private int lastUseCardGroupIndex_;

		// Token: 0x04006E40 RID: 28224
		public const int LastUseCardRoleIdFieldNumber = 6;

		// Token: 0x04006E41 RID: 28225
		private int lastUseCardRoleId_;
	}
}
