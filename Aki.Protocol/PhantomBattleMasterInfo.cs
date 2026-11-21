using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C86 RID: 3206
	public sealed class PhantomBattleMasterInfo : IMessage<PhantomBattleMasterInfo>, IMessage, IEquatable<PhantomBattleMasterInfo>, IDeepCloneable<PhantomBattleMasterInfo>, IBufferMessage
	{
		// Token: 0x0601166A RID: 71274 RVA: 0x0028D34B File Offset: 0x0028B54B
		[NullableContext(1)]
		public static PhantomBattleMasterInfo Create()
		{
			return new PhantomBattleMasterInfo();
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0601166B RID: 71275 RVA: 0x0028D352 File Offset: 0x0028B552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0601166C RID: 71276 RVA: 0x0028D355 File Offset: 0x0028B555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleMasterInfo.Descriptor;
			}
		}

		// Token: 0x0601166D RID: 71277 RVA: 0x0028D35C File Offset: 0x0028B55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfo()
		{
		}

		// Token: 0x0601166E RID: 71278 RVA: 0x0028D370 File Offset: 0x0028B570
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

		// Token: 0x0601166F RID: 71279 RVA: 0x0028D3E1 File Offset: 0x0028B5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfo Clone()
		{
			return new PhantomBattleMasterInfo(this);
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x06011670 RID: 71280 RVA: 0x0028D3E9 File Offset: 0x0028B5E9
		// (set) Token: 0x06011671 RID: 71281 RVA: 0x0028D3F1 File Offset: 0x0028B5F1
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

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x06011672 RID: 71282 RVA: 0x0028D3FA File Offset: 0x0028B5FA
		// (set) Token: 0x06011673 RID: 71283 RVA: 0x0028D402 File Offset: 0x0028B602
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

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x06011674 RID: 71284 RVA: 0x0028D40B File Offset: 0x0028B60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedPhantomBattleMasterLevelIds
		{
			get
			{
				return this.rewardedPhantomBattleMasterLevelIds_;
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x06011675 RID: 71285 RVA: 0x0028D413 File Offset: 0x0028B613
		// (set) Token: 0x06011676 RID: 71286 RVA: 0x0028D41B File Offset: 0x0028B61B
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

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x06011677 RID: 71287 RVA: 0x0028D424 File Offset: 0x0028B624
		// (set) Token: 0x06011678 RID: 71288 RVA: 0x0028D42C File Offset: 0x0028B62C
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

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x06011679 RID: 71289 RVA: 0x0028D435 File Offset: 0x0028B635
		// (set) Token: 0x0601167A RID: 71290 RVA: 0x0028D43D File Offset: 0x0028B63D
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

		// Token: 0x0601167B RID: 71291 RVA: 0x0028D446 File Offset: 0x0028B646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleMasterInfo);
		}

		// Token: 0x0601167C RID: 71292 RVA: 0x0028D454 File Offset: 0x0028B654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleMasterInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleMasterLevelId == other.PhantomBattleMasterLevelId && this.Exp == other.Exp && this.rewardedPhantomBattleMasterLevelIds_.Equals(other.rewardedPhantomBattleMasterLevelIds_) && this.WeekRewardExp == other.WeekRewardExp && this.LastUseCardGroupIndex == other.LastUseCardGroupIndex && this.LastUseCardRoleId == other.LastUseCardRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601167D RID: 71293 RVA: 0x0028D4E4 File Offset: 0x0028B6E4
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

		// Token: 0x0601167E RID: 71294 RVA: 0x0028D595 File Offset: 0x0028B795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601167F RID: 71295 RVA: 0x0028D5A2 File Offset: 0x0028B7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011680 RID: 71296 RVA: 0x0028D5AC File Offset: 0x0028B7AC
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

		// Token: 0x06011681 RID: 71297 RVA: 0x0028D66C File Offset: 0x0028B86C
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

		// Token: 0x06011682 RID: 71298 RVA: 0x0028D720 File Offset: 0x0028B920
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

		// Token: 0x06011683 RID: 71299 RVA: 0x0028D7BD File Offset: 0x0028B9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011684 RID: 71300 RVA: 0x0028D7C8 File Offset: 0x0028B9C8
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

		// Token: 0x04006E48 RID: 28232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E49 RID: 28233
		public const int PhantomBattleMasterLevelIdFieldNumber = 1;

		// Token: 0x04006E4A RID: 28234
		private int phantomBattleMasterLevelId_;

		// Token: 0x04006E4B RID: 28235
		public const int ExpFieldNumber = 2;

		// Token: 0x04006E4C RID: 28236
		private int exp_;

		// Token: 0x04006E4D RID: 28237
		public const int RewardedPhantomBattleMasterLevelIdsFieldNumber = 3;

		// Token: 0x04006E4E RID: 28238
		private static readonly FieldCodec<int> _repeated_rewardedPhantomBattleMasterLevelIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006E4F RID: 28239
		private readonly RepeatedField<int> rewardedPhantomBattleMasterLevelIds_ = new RepeatedField<int>();

		// Token: 0x04006E50 RID: 28240
		public const int WeekRewardExpFieldNumber = 4;

		// Token: 0x04006E51 RID: 28241
		private int weekRewardExp_;

		// Token: 0x04006E52 RID: 28242
		public const int LastUseCardGroupIndexFieldNumber = 5;

		// Token: 0x04006E53 RID: 28243
		private int lastUseCardGroupIndex_;

		// Token: 0x04006E54 RID: 28244
		public const int LastUseCardRoleIdFieldNumber = 6;

		// Token: 0x04006E55 RID: 28245
		private int lastUseCardRoleId_;
	}
}
