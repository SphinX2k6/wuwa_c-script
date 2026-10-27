using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B66 RID: 2918
	public sealed class NpcPhantomBattleAreaLockEffectCtx : IMessage<NpcPhantomBattleAreaLockEffectCtx>, IMessage, IEquatable<NpcPhantomBattleAreaLockEffectCtx>, IDeepCloneable<NpcPhantomBattleAreaLockEffectCtx>, IBufferMessage
	{
		// Token: 0x0600FCCA RID: 64714 RVA: 0x0024CDF4 File Offset: 0x0024AFF4
		[NullableContext(1)]
		public static NpcPhantomBattleAreaLockEffectCtx Create()
		{
			return new NpcPhantomBattleAreaLockEffectCtx();
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600FCCB RID: 64715 RVA: 0x0024CDFB File Offset: 0x0024AFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600FCCC RID: 64716 RVA: 0x0024CDFE File Offset: 0x0024AFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleAreaLockEffectCtx.Descriptor;
			}
		}

		// Token: 0x0600FCCD RID: 64717 RVA: 0x0024CE05 File Offset: 0x0024B005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleAreaLockEffectCtx()
		{
		}

		// Token: 0x0600FCCE RID: 64718 RVA: 0x0024CE10 File Offset: 0x0024B010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleAreaLockEffectCtx(NpcPhantomBattleAreaLockEffectCtx other) : this()
		{
			this.areaType_ = other.areaType_;
			this.seal_ = other.seal_;
			this.unLockRound_ = other.unLockRound_;
			this.camp_ = other.camp_;
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FCCF RID: 64719 RVA: 0x0024CE80 File Offset: 0x0024B080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleAreaLockEffectCtx Clone()
		{
			return new NpcPhantomBattleAreaLockEffectCtx(this);
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600FCD0 RID: 64720 RVA: 0x0024CE88 File Offset: 0x0024B088
		// (set) Token: 0x0600FCD1 RID: 64721 RVA: 0x0024CE90 File Offset: 0x0024B090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAreaType AreaType
		{
			get
			{
				return this.areaType_;
			}
			set
			{
				this.areaType_ = value;
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600FCD2 RID: 64722 RVA: 0x0024CE99 File Offset: 0x0024B099
		// (set) Token: 0x0600FCD3 RID: 64723 RVA: 0x0024CEA1 File Offset: 0x0024B0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Seal
		{
			get
			{
				return this.seal_;
			}
			set
			{
				this.seal_ = value;
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600FCD4 RID: 64724 RVA: 0x0024CEAA File Offset: 0x0024B0AA
		// (set) Token: 0x0600FCD5 RID: 64725 RVA: 0x0024CEB2 File Offset: 0x0024B0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockRound
		{
			get
			{
				return this.unLockRound_;
			}
			set
			{
				this.unLockRound_ = value;
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600FCD6 RID: 64726 RVA: 0x0024CEBB File Offset: 0x0024B0BB
		// (set) Token: 0x0600FCD7 RID: 64727 RVA: 0x0024CEC3 File Offset: 0x0024B0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectCardCamp Camp
		{
			get
			{
				return this.camp_;
			}
			set
			{
				this.camp_ = value;
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600FCD8 RID: 64728 RVA: 0x0024CECC File Offset: 0x0024B0CC
		// (set) Token: 0x0600FCD9 RID: 64729 RVA: 0x0024CED4 File Offset: 0x0024B0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
			set
			{
				this.phantomBattleFighterInfo_ = value;
			}
		}

		// Token: 0x0600FCDA RID: 64730 RVA: 0x0024CEDD File Offset: 0x0024B0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleAreaLockEffectCtx);
		}

		// Token: 0x0600FCDB RID: 64731 RVA: 0x0024CEEC File Offset: 0x0024B0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleAreaLockEffectCtx other)
		{
			return other != null && (other == this || (this.AreaType == other.AreaType && this.Seal == other.Seal && this.UnLockRound == other.UnLockRound && this.Camp == other.Camp && object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FCDC RID: 64732 RVA: 0x0024CF6C File Offset: 0x0024B16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaType != BattleAreaType.Retrieve)
			{
				num ^= this.AreaType.GetHashCode();
			}
			if (this.Seal)
			{
				num ^= this.Seal.GetHashCode();
			}
			if (this.UnLockRound != 0)
			{
				num ^= this.UnLockRound.GetHashCode();
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				num ^= this.Camp.GetHashCode();
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				num ^= this.PhantomBattleFighterInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FCDD RID: 64733 RVA: 0x0024D019 File Offset: 0x0024B219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FCDE RID: 64734 RVA: 0x0024D026 File Offset: 0x0024B226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FCDF RID: 64735 RVA: 0x0024D030 File Offset: 0x0024B230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaType != BattleAreaType.Retrieve)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.AreaType);
			}
			if (this.Seal)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Seal);
			}
			if (this.UnLockRound != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.UnLockRound);
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Camp);
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PhantomBattleFighterInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FCE0 RID: 64736 RVA: 0x0024D0DC File Offset: 0x0024B2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaType != BattleAreaType.Retrieve)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AreaType);
			}
			if (this.Seal)
			{
				num += 2;
			}
			if (this.UnLockRound != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockRound);
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Camp);
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFighterInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FCE1 RID: 64737 RVA: 0x0024D170 File Offset: 0x0024B370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleAreaLockEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaType != BattleAreaType.Retrieve)
			{
				this.AreaType = other.AreaType;
			}
			if (other.Seal)
			{
				this.Seal = other.Seal;
			}
			if (other.UnLockRound != 0)
			{
				this.UnLockRound = other.UnLockRound;
			}
			if (other.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				this.Camp = other.Camp;
			}
			if (other.phantomBattleFighterInfo_ != null)
			{
				if (this.phantomBattleFighterInfo_ == null)
				{
					this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
				}
				this.PhantomBattleFighterInfo.MergeFrom(other.PhantomBattleFighterInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FCE2 RID: 64738 RVA: 0x0024D214 File Offset: 0x0024B414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCE3 RID: 64739 RVA: 0x0024D220 File Offset: 0x0024B420
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.AreaType = (BattleAreaType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Seal = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.UnLockRound = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Camp = (PhantomBattleEffectCardCamp)input.ReadEnum();
						continue;
					}
					if (num == 50U)
					{
						if (this.phantomBattleFighterInfo_ == null)
						{
							this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
						}
						input.ReadMessage(this.PhantomBattleFighterInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040064D9 RID: 25817
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064DA RID: 25818
		public const int AreaTypeFieldNumber = 1;

		// Token: 0x040064DB RID: 25819
		private BattleAreaType areaType_;

		// Token: 0x040064DC RID: 25820
		public const int SealFieldNumber = 2;

		// Token: 0x040064DD RID: 25821
		private bool seal_;

		// Token: 0x040064DE RID: 25822
		public const int UnLockRoundFieldNumber = 3;

		// Token: 0x040064DF RID: 25823
		private int unLockRound_;

		// Token: 0x040064E0 RID: 25824
		public const int CampFieldNumber = 5;

		// Token: 0x040064E1 RID: 25825
		private PhantomBattleEffectCardCamp camp_;

		// Token: 0x040064E2 RID: 25826
		public const int PhantomBattleFighterInfoFieldNumber = 6;

		// Token: 0x040064E3 RID: 25827
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;
	}
}
