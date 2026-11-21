using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5D RID: 2909
	public sealed class NpcPhantomBattleCardSkillInfo : IMessage<NpcPhantomBattleCardSkillInfo>, IMessage, IEquatable<NpcPhantomBattleCardSkillInfo>, IDeepCloneable<NpcPhantomBattleCardSkillInfo>, IBufferMessage
	{
		// Token: 0x0600FC66 RID: 64614 RVA: 0x0024C8F3 File Offset: 0x0024AAF3
		[NullableContext(1)]
		public static NpcPhantomBattleCardSkillInfo Create()
		{
			return new NpcPhantomBattleCardSkillInfo();
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600FC67 RID: 64615 RVA: 0x0024C8FA File Offset: 0x0024AAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600FC68 RID: 64616 RVA: 0x0024C8FD File Offset: 0x0024AAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardSkillInfo.Descriptor;
			}
		}

		// Token: 0x0600FC69 RID: 64617 RVA: 0x0024C904 File Offset: 0x0024AB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSkillInfo()
		{
		}

		// Token: 0x0600FC6A RID: 64618 RVA: 0x0024C918 File Offset: 0x0024AB18
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

		// Token: 0x0600FC6B RID: 64619 RVA: 0x0024C9A5 File Offset: 0x0024ABA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSkillInfo Clone()
		{
			return new NpcPhantomBattleCardSkillInfo(this);
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600FC6C RID: 64620 RVA: 0x0024C9AD File Offset: 0x0024ABAD
		// (set) Token: 0x0600FC6D RID: 64621 RVA: 0x0024C9B5 File Offset: 0x0024ABB5
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

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600FC6E RID: 64622 RVA: 0x0024C9BE File Offset: 0x0024ABBE
		// (set) Token: 0x0600FC6F RID: 64623 RVA: 0x0024C9C6 File Offset: 0x0024ABC6
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

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600FC70 RID: 64624 RVA: 0x0024C9CF File Offset: 0x0024ABCF
		// (set) Token: 0x0600FC71 RID: 64625 RVA: 0x0024C9D7 File Offset: 0x0024ABD7
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

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600FC72 RID: 64626 RVA: 0x0024C9E0 File Offset: 0x0024ABE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600FC73 RID: 64627 RVA: 0x0024C9E8 File Offset: 0x0024ABE8
		// (set) Token: 0x0600FC74 RID: 64628 RVA: 0x0024C9F0 File Offset: 0x0024ABF0
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

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600FC75 RID: 64629 RVA: 0x0024C9F9 File Offset: 0x0024ABF9
		// (set) Token: 0x0600FC76 RID: 64630 RVA: 0x0024CA01 File Offset: 0x0024AC01
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

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600FC77 RID: 64631 RVA: 0x0024CA0A File Offset: 0x0024AC0A
		// (set) Token: 0x0600FC78 RID: 64632 RVA: 0x0024CA12 File Offset: 0x0024AC12
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

		// Token: 0x0600FC79 RID: 64633 RVA: 0x0024CA1B File Offset: 0x0024AC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardSkillInfo);
		}

		// Token: 0x0600FC7A RID: 64634 RVA: 0x0024CA2C File Offset: 0x0024AC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardSkillInfo other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.CardConfId == other.CardConfId && this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && this.CurCardLibraryNum == other.CurCardLibraryNum && this.HandCardNum == other.HandCardNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC7B RID: 64635 RVA: 0x0024CAD0 File Offset: 0x0024ACD0
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

		// Token: 0x0600FC7C RID: 64636 RVA: 0x0024CB97 File Offset: 0x0024AD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC7D RID: 64637 RVA: 0x0024CBA4 File Offset: 0x0024ADA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC7E RID: 64638 RVA: 0x0024CBB0 File Offset: 0x0024ADB0
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

		// Token: 0x0600FC7F RID: 64639 RVA: 0x0024CC8C File Offset: 0x0024AE8C
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

		// Token: 0x0600FC80 RID: 64640 RVA: 0x0024CD58 File Offset: 0x0024AF58
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

		// Token: 0x0600FC81 RID: 64641 RVA: 0x0024CE21 File Offset: 0x0024B021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC82 RID: 64642 RVA: 0x0024CE2C File Offset: 0x0024B02C
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

		// Token: 0x04006523 RID: 25891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006524 RID: 25892
		public const int CardUIdFieldNumber = 1;

		// Token: 0x04006525 RID: 25893
		private int cardUId_;

		// Token: 0x04006526 RID: 25894
		public const int CardConfIdFieldNumber = 2;

		// Token: 0x04006527 RID: 25895
		private int cardConfId_;

		// Token: 0x04006528 RID: 25896
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04006529 RID: 25897
		private int skillId_;

		// Token: 0x0400652A RID: 25898
		public const int SelectFighterUIdFieldNumber = 4;

		// Token: 0x0400652B RID: 25899
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400652C RID: 25900
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x0400652D RID: 25901
		public const int PhantomBattleEffectResultInfoFieldNumber = 5;

		// Token: 0x0400652E RID: 25902
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;

		// Token: 0x0400652F RID: 25903
		public const int CurCardLibraryNumFieldNumber = 6;

		// Token: 0x04006530 RID: 25904
		private int curCardLibraryNum_;

		// Token: 0x04006531 RID: 25905
		public const int HandCardNumFieldNumber = 7;

		// Token: 0x04006532 RID: 25906
		private int handCardNum_;
	}
}
