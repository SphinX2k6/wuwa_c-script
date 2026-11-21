using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C9 RID: 457
	public sealed class BossPilingLevelInfo : IMessage<BossPilingLevelInfo>, IMessage, IEquatable<BossPilingLevelInfo>, IDeepCloneable<BossPilingLevelInfo>, IBufferMessage
	{
		// Token: 0x0600348A RID: 13450 RVA: 0x00084C5A File Offset: 0x00082E5A
		[NullableContext(1)]
		public static BossPilingLevelInfo Create()
		{
			return new BossPilingLevelInfo();
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x00084C61 File Offset: 0x00082E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BossPilingLevelInfo> Parser
		{
			get
			{
				return BossPilingLevelInfo._parser;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600348C RID: 13452 RVA: 0x00084C68 File Offset: 0x00082E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x00084C6B File Offset: 0x00082E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00084C72 File Offset: 0x00082E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfo()
		{
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00084C90 File Offset: 0x00082E90
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

		// Token: 0x06003490 RID: 13456 RVA: 0x00084CFA File Offset: 0x00082EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfo Clone()
		{
			return new BossPilingLevelInfo(this);
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06003491 RID: 13457 RVA: 0x00084D02 File Offset: 0x00082F02
		// (set) Token: 0x06003492 RID: 13458 RVA: 0x00084D0A File Offset: 0x00082F0A
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

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x00084D13 File Offset: 0x00082F13
		// (set) Token: 0x06003494 RID: 13460 RVA: 0x00084D1B File Offset: 0x00082F1B
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

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x00084D24 File Offset: 0x00082F24
		// (set) Token: 0x06003496 RID: 13462 RVA: 0x00084D2C File Offset: 0x00082F2C
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

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x00084D35 File Offset: 0x00082F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectRoleIds
		{
			get
			{
				return this.selectRoleIds_;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x00084D3D File Offset: 0x00082F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00084D45 File Offset: 0x00082F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingLevelInfo);
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00084D54 File Offset: 0x00082F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnlockTime == other.UnlockTime && this.BossHpNum == other.BossHpNum && this.selectRoleIds_.Equals(other.selectRoleIds_) && this.skillBranchId_.Equals(other.skillBranchId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00084DD8 File Offset: 0x00082FD8
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

		// Token: 0x0600349C RID: 13468 RVA: 0x00084E65 File Offset: 0x00083065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00084E72 File Offset: 0x00083072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00084E7C File Offset: 0x0008307C
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

		// Token: 0x0600349F RID: 13471 RVA: 0x00084F14 File Offset: 0x00083114
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

		// Token: 0x060034A0 RID: 13472 RVA: 0x00084FA8 File Offset: 0x000831A8
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

		// Token: 0x060034A1 RID: 13473 RVA: 0x0008502E File Offset: 0x0008322E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00085038 File Offset: 0x00083238
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

		// Token: 0x04002A5E RID: 10846
		private static readonly MessageParser<BossPilingLevelInfo> _parser = new MessageParser<BossPilingLevelInfo>(() => new BossPilingLevelInfo());

		// Token: 0x04002A5F RID: 10847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A60 RID: 10848
		public const int IdFieldNumber = 1;

		// Token: 0x04002A61 RID: 10849
		private int id_;

		// Token: 0x04002A62 RID: 10850
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04002A63 RID: 10851
		private long unlockTime_;

		// Token: 0x04002A64 RID: 10852
		public const int BossHpNumFieldNumber = 3;

		// Token: 0x04002A65 RID: 10853
		private int bossHpNum_;

		// Token: 0x04002A66 RID: 10854
		public const int SelectRoleIdsFieldNumber = 4;

		// Token: 0x04002A67 RID: 10855
		private static readonly FieldCodec<int> _repeated_selectRoleIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04002A68 RID: 10856
		private readonly RepeatedField<int> selectRoleIds_ = new RepeatedField<int>();

		// Token: 0x04002A69 RID: 10857
		public const int SkillBranchIdFieldNumber = 5;

		// Token: 0x04002A6A RID: 10858
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04002A6B RID: 10859
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();
	}
}
