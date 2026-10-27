using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C5 RID: 453
	public sealed class BossPilingLevelInfo : IMessage<BossPilingLevelInfo>, IMessage, IEquatable<BossPilingLevelInfo>, IDeepCloneable<BossPilingLevelInfo>, IBufferMessage
	{
		// Token: 0x060033FD RID: 13309 RVA: 0x000834E9 File Offset: 0x000816E9
		[NullableContext(1)]
		public static BossPilingLevelInfo Create()
		{
			return new BossPilingLevelInfo();
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x000834F0 File Offset: 0x000816F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BossPilingLevelInfo> Parser
		{
			get
			{
				return BossPilingLevelInfo._parser;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060033FF RID: 13311 RVA: 0x000834F7 File Offset: 0x000816F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06003400 RID: 13312 RVA: 0x000834FA File Offset: 0x000816FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingLevelInfo.Descriptor;
			}
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00083501 File Offset: 0x00081701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfo()
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00083520 File Offset: 0x00081720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfo(BossPilingLevelInfo other) : this()
		{
			this.id_ = other.id_;
			this.unlockTime_ = other.unlockTime_;
			this.bossHpNum_ = other.bossHpNum_;
			this.selectRoleIds_ = other.selectRoleIds_.Clone();
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x0008358A File Offset: 0x0008178A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfo Clone()
		{
			return new BossPilingLevelInfo(this);
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x00083592 File Offset: 0x00081792
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x0008359A File Offset: 0x0008179A
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

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x000835A3 File Offset: 0x000817A3
		// (set) Token: 0x06003407 RID: 13319 RVA: 0x000835AB File Offset: 0x000817AB
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

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x000835B4 File Offset: 0x000817B4
		// (set) Token: 0x06003409 RID: 13321 RVA: 0x000835BC File Offset: 0x000817BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossHpNum
		{
			get
			{
				return this.bossHpNum_;
			}
			set
			{
				this.bossHpNum_ = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x000835C5 File Offset: 0x000817C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectRoleIds
		{
			get
			{
				return this.selectRoleIds_;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x000835CD File Offset: 0x000817CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x000835D5 File Offset: 0x000817D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingLevelInfo);
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x000835E4 File Offset: 0x000817E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnlockTime == other.UnlockTime && this.BossHpNum == other.BossHpNum && this.selectRoleIds_.Equals(other.selectRoleIds_) && this.skillBranchId_.Equals(other.skillBranchId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x00083668 File Offset: 0x00081868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.BossHpNum != 0)
			{
				num ^= this.BossHpNum.GetHashCode();
			}
			num ^= this.selectRoleIds_.GetHashCode();
			num ^= this.skillBranchId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x000836F5 File Offset: 0x000818F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x00083702 File Offset: 0x00081902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x0008370C File Offset: 0x0008190C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.BossHpNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BossHpNum);
			}
			this.selectRoleIds_.WriteTo(ref output, BossPilingLevelInfo._repeated_selectRoleIds_codec);
			this.skillBranchId_.WriteTo(ref output, BossPilingLevelInfo._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x000837A4 File Offset: 0x000819A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.BossHpNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossHpNum);
			}
			num += this.selectRoleIds_.CalculateSize(BossPilingLevelInfo._repeated_selectRoleIds_codec);
			num += this.skillBranchId_.CalculateSize(BossPilingLevelInfo._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x00083838 File Offset: 0x00081A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.BossHpNum != 0)
			{
				this.BossHpNum = other.BossHpNum;
			}
			this.selectRoleIds_.Add(other.selectRoleIds_);
			this.skillBranchId_.Add(other.skillBranchId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x000838BE File Offset: 0x00081ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x000838C8 File Offset: 0x00081AC8
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
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.BossHpNum = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.selectRoleIds_.AddEntriesFrom(ref input, BossPilingLevelInfo._repeated_selectRoleIds_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.skillBranchId_.AddEntriesFrom(ref input, BossPilingLevelInfo._repeated_skillBranchId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040029E3 RID: 10723
		private static readonly MessageParser<BossPilingLevelInfo> _parser = new MessageParser<BossPilingLevelInfo>(() => new BossPilingLevelInfo());

		// Token: 0x040029E4 RID: 10724
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029E5 RID: 10725
		public const int IdFieldNumber = 1;

		// Token: 0x040029E6 RID: 10726
		private int id_;

		// Token: 0x040029E7 RID: 10727
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x040029E8 RID: 10728
		private long unlockTime_;

		// Token: 0x040029E9 RID: 10729
		public const int BossHpNumFieldNumber = 3;

		// Token: 0x040029EA RID: 10730
		private int bossHpNum_;

		// Token: 0x040029EB RID: 10731
		public const int SelectRoleIdsFieldNumber = 4;

		// Token: 0x040029EC RID: 10732
		private static readonly FieldCodec<int> _repeated_selectRoleIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040029ED RID: 10733
		private readonly RepeatedField<int> selectRoleIds_ = new RepeatedField<int>();

		// Token: 0x040029EE RID: 10734
		public const int SkillBranchIdFieldNumber = 5;

		// Token: 0x040029EF RID: 10735
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040029F0 RID: 10736
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();
	}
}
