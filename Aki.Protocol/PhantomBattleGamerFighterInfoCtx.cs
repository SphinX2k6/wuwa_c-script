using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8C RID: 3212
	public sealed class PhantomBattleGamerFighterInfoCtx : IMessage<PhantomBattleGamerFighterInfoCtx>, IMessage, IEquatable<PhantomBattleGamerFighterInfoCtx>, IDeepCloneable<PhantomBattleGamerFighterInfoCtx>, IBufferMessage
	{
		// Token: 0x06011694 RID: 71316 RVA: 0x0028D234 File Offset: 0x0028B434
		[NullableContext(1)]
		public static PhantomBattleGamerFighterInfoCtx Create()
		{
			return new PhantomBattleGamerFighterInfoCtx();
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x06011695 RID: 71317 RVA: 0x0028D23B File Offset: 0x0028B43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x06011696 RID: 71318 RVA: 0x0028D23E File Offset: 0x0028B43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGamerFighterInfoCtx.Descriptor;
			}
		}

		// Token: 0x06011697 RID: 71319 RVA: 0x0028D245 File Offset: 0x0028B445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFighterInfoCtx()
		{
		}

		// Token: 0x06011698 RID: 71320 RVA: 0x0028D264 File Offset: 0x0028B464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFighterInfoCtx(PhantomBattleGamerFighterInfoCtx other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.cardRoleId_ = other.cardRoleId_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this.handCardNum_ = other.handCardNum_;
			this.canEvolveNum_ = other.canEvolveNum_;
			this.battleAttr_ = other.battleAttr_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011699 RID: 71321 RVA: 0x0028D2E6 File Offset: 0x0028B4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFighterInfoCtx Clone()
		{
			return new PhantomBattleGamerFighterInfoCtx(this);
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0601169A RID: 71322 RVA: 0x0028D2EE File Offset: 0x0028B4EE
		// (set) Token: 0x0601169B RID: 71323 RVA: 0x0028D2F6 File Offset: 0x0028B4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamerIndex
		{
			get
			{
				return this.gamerIndex_;
			}
			set
			{
				this.gamerIndex_ = value;
			}
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0601169C RID: 71324 RVA: 0x0028D2FF File Offset: 0x0028B4FF
		// (set) Token: 0x0601169D RID: 71325 RVA: 0x0028D307 File Offset: 0x0028B507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardRoleId
		{
			get
			{
				return this.cardRoleId_;
			}
			set
			{
				this.cardRoleId_ = value;
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0601169E RID: 71326 RVA: 0x0028D310 File Offset: 0x0028B510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0601169F RID: 71327 RVA: 0x0028D318 File Offset: 0x0028B518
		// (set) Token: 0x060116A0 RID: 71328 RVA: 0x0028D320 File Offset: 0x0028B520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x060116A1 RID: 71329 RVA: 0x0028D329 File Offset: 0x0028B529
		// (set) Token: 0x060116A2 RID: 71330 RVA: 0x0028D331 File Offset: 0x0028B531
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

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x060116A3 RID: 71331 RVA: 0x0028D33A File Offset: 0x0028B53A
		// (set) Token: 0x060116A4 RID: 71332 RVA: 0x0028D342 File Offset: 0x0028B542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CanEvolveNum
		{
			get
			{
				return this.canEvolveNum_;
			}
			set
			{
				this.canEvolveNum_ = value;
			}
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x060116A5 RID: 71333 RVA: 0x0028D34B File Offset: 0x0028B54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleAttr
		{
			get
			{
				return this.battleAttr_;
			}
		}

		// Token: 0x060116A6 RID: 71334 RVA: 0x0028D353 File Offset: 0x0028B553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGamerFighterInfoCtx);
		}

		// Token: 0x060116A7 RID: 71335 RVA: 0x0028D364 File Offset: 0x0028B564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGamerFighterInfoCtx other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.CardRoleId == other.CardRoleId && this.BattleStatus.Equals(other.BattleStatus) && this.CardLibraryNum == other.CardLibraryNum && this.HandCardNum == other.HandCardNum && this.CanEvolveNum == other.CanEvolveNum && this.BattleAttr.Equals(other.BattleAttr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060116A8 RID: 71336 RVA: 0x0028D408 File Offset: 0x0028B608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamerIndex != 0)
			{
				num ^= this.GamerIndex.GetHashCode();
			}
			if (this.CardRoleId != 0)
			{
				num ^= this.CardRoleId.GetHashCode();
			}
			num ^= this.BattleStatus.GetHashCode();
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this.CanEvolveNum != 0)
			{
				num ^= this.CanEvolveNum.GetHashCode();
			}
			num ^= this.BattleAttr.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060116A9 RID: 71337 RVA: 0x0028D4C7 File Offset: 0x0028B6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116AA RID: 71338 RVA: 0x0028D4D4 File Offset: 0x0028B6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116AB RID: 71339 RVA: 0x0028D4E0 File Offset: 0x0028B6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamerIndex);
			}
			if (this.CardRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardRoleId);
			}
			this.battleStatus_.WriteTo(ref output, PhantomBattleGamerFighterInfoCtx._map_battleStatus_codec);
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HandCardNum);
			}
			if (this.CanEvolveNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CanEvolveNum);
			}
			this.battleAttr_.WriteTo(ref output, PhantomBattleGamerFighterInfoCtx._map_battleAttr_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060116AC RID: 71340 RVA: 0x0028D5B0 File Offset: 0x0028B7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamerIndex);
			}
			if (this.CardRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardRoleId);
			}
			num += this.battleStatus_.CalculateSize(PhantomBattleGamerFighterInfoCtx._map_battleStatus_codec);
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this.CanEvolveNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CanEvolveNum);
			}
			num += this.battleAttr_.CalculateSize(PhantomBattleGamerFighterInfoCtx._map_battleAttr_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060116AD RID: 71341 RVA: 0x0028D674 File Offset: 0x0028B874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleGamerFighterInfoCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamerIndex != 0)
			{
				this.GamerIndex = other.GamerIndex;
			}
			if (other.CardRoleId != 0)
			{
				this.CardRoleId = other.CardRoleId;
			}
			this.battleStatus_.MergeFrom(other.battleStatus_);
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.CanEvolveNum != 0)
			{
				this.CanEvolveNum = other.CanEvolveNum;
			}
			this.battleAttr_.MergeFrom(other.battleAttr_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060116AE RID: 71342 RVA: 0x0028D722 File Offset: 0x0028B922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116AF RID: 71343 RVA: 0x0028D72C File Offset: 0x0028B92C
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.GamerIndex = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CardRoleId = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.battleStatus_.AddEntriesFrom(ref input, PhantomBattleGamerFighterInfoCtx._map_battleStatus_codec);
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.CardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.CanEvolveNum = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						this.battleAttr_.AddEntriesFrom(ref input, PhantomBattleGamerFighterInfoCtx._map_battleAttr_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006DEF RID: 28143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DF0 RID: 28144
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006DF1 RID: 28145
		private int gamerIndex_;

		// Token: 0x04006DF2 RID: 28146
		public const int CardRoleIdFieldNumber = 2;

		// Token: 0x04006DF3 RID: 28147
		private int cardRoleId_;

		// Token: 0x04006DF4 RID: 28148
		public const int BattleStatusFieldNumber = 3;

		// Token: 0x04006DF5 RID: 28149
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x04006DF6 RID: 28150
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();

		// Token: 0x04006DF7 RID: 28151
		public const int CardLibraryNumFieldNumber = 4;

		// Token: 0x04006DF8 RID: 28152
		private int cardLibraryNum_;

		// Token: 0x04006DF9 RID: 28153
		public const int HandCardNumFieldNumber = 5;

		// Token: 0x04006DFA RID: 28154
		private int handCardNum_;

		// Token: 0x04006DFB RID: 28155
		public const int CanEvolveNumFieldNumber = 6;

		// Token: 0x04006DFC RID: 28156
		private int canEvolveNum_;

		// Token: 0x04006DFD RID: 28157
		public const int BattleAttrFieldNumber = 7;

		// Token: 0x04006DFE RID: 28158
		private static readonly MapField<int, int>.Codec _map_battleAttr_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 58U);

		// Token: 0x04006DFF RID: 28159
		private readonly MapField<int, int> battleAttr_ = new MapField<int, int>();
	}
}
