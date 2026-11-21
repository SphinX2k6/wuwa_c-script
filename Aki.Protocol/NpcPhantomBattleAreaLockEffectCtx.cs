using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B56 RID: 2902
	public sealed class NpcPhantomBattleAreaLockEffectCtx : IMessage<NpcPhantomBattleAreaLockEffectCtx>, IMessage, IEquatable<NpcPhantomBattleAreaLockEffectCtx>, IDeepCloneable<NpcPhantomBattleAreaLockEffectCtx>, IBufferMessage
	{
		// Token: 0x0600FBC6 RID: 64454 RVA: 0x0024AF24 File Offset: 0x00249124
		[NullableContext(1)]
		public static NpcPhantomBattleAreaLockEffectCtx Create()
		{
			return new NpcPhantomBattleAreaLockEffectCtx();
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600FBC7 RID: 64455 RVA: 0x0024AF2B File Offset: 0x0024912B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600FBC8 RID: 64456 RVA: 0x0024AF2E File Offset: 0x0024912E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleAreaLockEffectCtx.Descriptor;
			}
		}

		// Token: 0x0600FBC9 RID: 64457 RVA: 0x0024AF35 File Offset: 0x00249135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleAreaLockEffectCtx()
		{
		}

		// Token: 0x0600FBCA RID: 64458 RVA: 0x0024AF40 File Offset: 0x00249140
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

		// Token: 0x0600FBCB RID: 64459 RVA: 0x0024AFB0 File Offset: 0x002491B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleAreaLockEffectCtx Clone()
		{
			return new NpcPhantomBattleAreaLockEffectCtx(this);
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600FBCC RID: 64460 RVA: 0x0024AFB8 File Offset: 0x002491B8
		// (set) Token: 0x0600FBCD RID: 64461 RVA: 0x0024AFC0 File Offset: 0x002491C0
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

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600FBCE RID: 64462 RVA: 0x0024AFC9 File Offset: 0x002491C9
		// (set) Token: 0x0600FBCF RID: 64463 RVA: 0x0024AFD1 File Offset: 0x002491D1
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

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600FBD0 RID: 64464 RVA: 0x0024AFDA File Offset: 0x002491DA
		// (set) Token: 0x0600FBD1 RID: 64465 RVA: 0x0024AFE2 File Offset: 0x002491E2
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

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600FBD2 RID: 64466 RVA: 0x0024AFEB File Offset: 0x002491EB
		// (set) Token: 0x0600FBD3 RID: 64467 RVA: 0x0024AFF3 File Offset: 0x002491F3
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

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600FBD4 RID: 64468 RVA: 0x0024AFFC File Offset: 0x002491FC
		// (set) Token: 0x0600FBD5 RID: 64469 RVA: 0x0024B004 File Offset: 0x00249204
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

		// Token: 0x0600FBD6 RID: 64470 RVA: 0x0024B00D File Offset: 0x0024920D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleAreaLockEffectCtx);
		}

		// Token: 0x0600FBD7 RID: 64471 RVA: 0x0024B01C File Offset: 0x0024921C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleAreaLockEffectCtx other)
		{
			return other != null && (other == this || (this.AreaType == other.AreaType && this.Seal == other.Seal && this.UnLockRound == other.UnLockRound && this.Camp == other.Camp && object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FBD8 RID: 64472 RVA: 0x0024B09C File Offset: 0x0024929C
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

		// Token: 0x0600FBD9 RID: 64473 RVA: 0x0024B149 File Offset: 0x00249349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FBDA RID: 64474 RVA: 0x0024B156 File Offset: 0x00249356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FBDB RID: 64475 RVA: 0x0024B160 File Offset: 0x00249360
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

		// Token: 0x0600FBDC RID: 64476 RVA: 0x0024B20C File Offset: 0x0024940C
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

		// Token: 0x0600FBDD RID: 64477 RVA: 0x0024B2A0 File Offset: 0x002494A0
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

		// Token: 0x0600FBDE RID: 64478 RVA: 0x0024B344 File Offset: 0x00249544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FBDF RID: 64479 RVA: 0x0024B350 File Offset: 0x00249550
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

		// Token: 0x040064E9 RID: 25833
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064EA RID: 25834
		public const int AreaTypeFieldNumber = 1;

		// Token: 0x040064EB RID: 25835
		private BattleAreaType areaType_;

		// Token: 0x040064EC RID: 25836
		public const int SealFieldNumber = 2;

		// Token: 0x040064ED RID: 25837
		private bool seal_;

		// Token: 0x040064EE RID: 25838
		public const int UnLockRoundFieldNumber = 3;

		// Token: 0x040064EF RID: 25839
		private int unLockRound_;

		// Token: 0x040064F0 RID: 25840
		public const int CampFieldNumber = 5;

		// Token: 0x040064F1 RID: 25841
		private PhantomBattleEffectCardCamp camp_;

		// Token: 0x040064F2 RID: 25842
		public const int PhantomBattleFighterInfoFieldNumber = 6;

		// Token: 0x040064F3 RID: 25843
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;
	}
}
