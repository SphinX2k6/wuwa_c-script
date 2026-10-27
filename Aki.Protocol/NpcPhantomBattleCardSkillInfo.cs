using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6D RID: 2925
	public sealed class NpcPhantomBattleCardSkillInfo : IMessage<NpcPhantomBattleCardSkillInfo>, IMessage, IEquatable<NpcPhantomBattleCardSkillInfo>, IDeepCloneable<NpcPhantomBattleCardSkillInfo>, IBufferMessage
	{
		// Token: 0x0600FD6A RID: 64874 RVA: 0x0024E7C3 File Offset: 0x0024C9C3
		[NullableContext(1)]
		public static NpcPhantomBattleCardSkillInfo Create()
		{
			return new NpcPhantomBattleCardSkillInfo();
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600FD6B RID: 64875 RVA: 0x0024E7CA File Offset: 0x0024C9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600FD6C RID: 64876 RVA: 0x0024E7CD File Offset: 0x0024C9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardSkillInfo.Descriptor;
			}
		}

		// Token: 0x0600FD6D RID: 64877 RVA: 0x0024E7D4 File Offset: 0x0024C9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSkillInfo()
		{
		}

		// Token: 0x0600FD6E RID: 64878 RVA: 0x0024E7E8 File Offset: 0x0024C9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSkillInfo(NpcPhantomBattleCardSkillInfo other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.cardConfId_ = other.cardConfId_;
			this.skillId_ = other.skillId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this.phantomBattleEffectResultInfo_ = ((other.phantomBattleEffectResultInfo_ != null) ? other.phantomBattleEffectResultInfo_.Clone() : null);
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this.handCardNum_ = other.handCardNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD6F RID: 64879 RVA: 0x0024E875 File Offset: 0x0024CA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSkillInfo Clone()
		{
			return new NpcPhantomBattleCardSkillInfo(this);
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600FD70 RID: 64880 RVA: 0x0024E87D File Offset: 0x0024CA7D
		// (set) Token: 0x0600FD71 RID: 64881 RVA: 0x0024E885 File Offset: 0x0024CA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600FD72 RID: 64882 RVA: 0x0024E88E File Offset: 0x0024CA8E
		// (set) Token: 0x0600FD73 RID: 64883 RVA: 0x0024E896 File Offset: 0x0024CA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardConfId
		{
			get
			{
				return this.cardConfId_;
			}
			set
			{
				this.cardConfId_ = value;
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600FD74 RID: 64884 RVA: 0x0024E89F File Offset: 0x0024CA9F
		// (set) Token: 0x0600FD75 RID: 64885 RVA: 0x0024E8A7 File Offset: 0x0024CAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600FD76 RID: 64886 RVA: 0x0024E8B0 File Offset: 0x0024CAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600FD77 RID: 64887 RVA: 0x0024E8B8 File Offset: 0x0024CAB8
		// (set) Token: 0x0600FD78 RID: 64888 RVA: 0x0024E8C0 File Offset: 0x0024CAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo PhantomBattleEffectResultInfo
		{
			get
			{
				return this.phantomBattleEffectResultInfo_;
			}
			set
			{
				this.phantomBattleEffectResultInfo_ = value;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600FD79 RID: 64889 RVA: 0x0024E8C9 File Offset: 0x0024CAC9
		// (set) Token: 0x0600FD7A RID: 64890 RVA: 0x0024E8D1 File Offset: 0x0024CAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600FD7B RID: 64891 RVA: 0x0024E8DA File Offset: 0x0024CADA
		// (set) Token: 0x0600FD7C RID: 64892 RVA: 0x0024E8E2 File Offset: 0x0024CAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x0600FD7D RID: 64893 RVA: 0x0024E8EB File Offset: 0x0024CAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardSkillInfo);
		}

		// Token: 0x0600FD7E RID: 64894 RVA: 0x0024E8FC File Offset: 0x0024CAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardSkillInfo other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.CardConfId == other.CardConfId && this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && this.CurCardLibraryNum == other.CurCardLibraryNum && this.HandCardNum == other.HandCardNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD7F RID: 64895 RVA: 0x0024E9A0 File Offset: 0x0024CBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			if (this.CardConfId != 0)
			{
				num ^= this.CardConfId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.selectFighterUId_.GetHashCode();
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				num ^= this.PhantomBattleEffectResultInfo.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD80 RID: 64896 RVA: 0x0024EA67 File Offset: 0x0024CC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD81 RID: 64897 RVA: 0x0024EA74 File Offset: 0x0024CC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD82 RID: 64898 RVA: 0x0024EA80 File Offset: 0x0024CC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUId);
			}
			if (this.CardConfId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardConfId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillId);
			}
			this.selectFighterUId_.WriteTo(ref output, NpcPhantomBattleCardSkillInfo._repeated_selectFighterUId_codec);
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PhantomBattleEffectResultInfo);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HandCardNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FD83 RID: 64899 RVA: 0x0024EB5C File Offset: 0x0024CD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			if (this.CardConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardConfId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			num += this.selectFighterUId_.CalculateSize(NpcPhantomBattleCardSkillInfo._repeated_selectFighterUId_codec);
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleEffectResultInfo);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FD84 RID: 64900 RVA: 0x0024EC28 File Offset: 0x0024CE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleCardSkillInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			if (other.CardConfId != 0)
			{
				this.CardConfId = other.CardConfId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this.selectFighterUId_.Add(other.selectFighterUId_);
			if (other.phantomBattleEffectResultInfo_ != null)
			{
				if (this.phantomBattleEffectResultInfo_ == null)
				{
					this.PhantomBattleEffectResultInfo = new PhantomBattleEffectResultInfo();
				}
				this.PhantomBattleEffectResultInfo.MergeFrom(other.PhantomBattleEffectResultInfo);
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FD85 RID: 64901 RVA: 0x0024ECF1 File Offset: 0x0024CEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD86 RID: 64902 RVA: 0x0024ECFC File Offset: 0x0024CEFC
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.CardUId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.CardConfId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SkillId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							goto IL_89;
						}
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						goto IL_89;
					}
					if (num == 42U)
					{
						if (this.phantomBattleEffectResultInfo_ == null)
						{
							this.PhantomBattleEffectResultInfo = new PhantomBattleEffectResultInfo();
						}
						input.ReadMessage(this.PhantomBattleEffectResultInfo);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.CurCardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_89:
				this.selectFighterUId_.AddEntriesFrom(ref input, NpcPhantomBattleCardSkillInfo._repeated_selectFighterUId_codec);
			}
		}

		// Token: 0x04006513 RID: 25875
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006514 RID: 25876
		public const int CardUIdFieldNumber = 1;

		// Token: 0x04006515 RID: 25877
		private int cardUId_;

		// Token: 0x04006516 RID: 25878
		public const int CardConfIdFieldNumber = 2;

		// Token: 0x04006517 RID: 25879
		private int cardConfId_;

		// Token: 0x04006518 RID: 25880
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04006519 RID: 25881
		private int skillId_;

		// Token: 0x0400651A RID: 25882
		public const int SelectFighterUIdFieldNumber = 4;

		// Token: 0x0400651B RID: 25883
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400651C RID: 25884
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x0400651D RID: 25885
		public const int PhantomBattleEffectResultInfoFieldNumber = 5;

		// Token: 0x0400651E RID: 25886
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;

		// Token: 0x0400651F RID: 25887
		public const int CurCardLibraryNumFieldNumber = 6;

		// Token: 0x04006520 RID: 25888
		private int curCardLibraryNum_;

		// Token: 0x04006521 RID: 25889
		public const int HandCardNumFieldNumber = 7;

		// Token: 0x04006522 RID: 25890
		private int handCardNum_;
	}
}
