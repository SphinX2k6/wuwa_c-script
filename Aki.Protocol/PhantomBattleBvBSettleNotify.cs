using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3F RID: 3135
	[NetMessage(EMessageId.PhantomBattleBvBSettleNotify)]
	public sealed class PhantomBattleBvBSettleNotify : IMessage<PhantomBattleBvBSettleNotify>, IMessage, IEquatable<PhantomBattleBvBSettleNotify>, IDeepCloneable<PhantomBattleBvBSettleNotify>, IBufferMessage
	{
		// Token: 0x06010FF1 RID: 69617 RVA: 0x0027CBF8 File Offset: 0x0027ADF8
		[NullableContext(1)]
		public static PhantomBattleBvBSettleNotify Create()
		{
			return new PhantomBattleBvBSettleNotify();
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x06010FF2 RID: 69618 RVA: 0x0027CBFF File Offset: 0x0027ADFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x06010FF3 RID: 69619 RVA: 0x0027CC02 File Offset: 0x0027AE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBSettleNotify.Descriptor;
			}
		}

		// Token: 0x06010FF4 RID: 69620 RVA: 0x0027CC09 File Offset: 0x0027AE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBSettleNotify()
		{
		}

		// Token: 0x06010FF5 RID: 69621 RVA: 0x0027CC14 File Offset: 0x0027AE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBSettleNotify(PhantomBattleBvBSettleNotify other) : this()
		{
			this.isWin_ = other.isWin_;
			this.playerDeductLife_ = other.playerDeductLife_;
			this.playerCurLife_ = other.playerCurLife_;
			this.npcDeductLife_ = other.npcDeductLife_;
			this.npcCurLife_ = other.npcCurLife_;
			this.isFinalSettle_ = other.isFinalSettle_;
			this.playerOriginalDamage_ = other.playerOriginalDamage_;
			this.npcOriginalDamage_ = other.npcOriginalDamage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FF6 RID: 69622 RVA: 0x0027CC98 File Offset: 0x0027AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBSettleNotify Clone()
		{
			return new PhantomBattleBvBSettleNotify(this);
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x06010FF7 RID: 69623 RVA: 0x0027CCA0 File Offset: 0x0027AEA0
		// (set) Token: 0x06010FF8 RID: 69624 RVA: 0x0027CCA8 File Offset: 0x0027AEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x06010FF9 RID: 69625 RVA: 0x0027CCB1 File Offset: 0x0027AEB1
		// (set) Token: 0x06010FFA RID: 69626 RVA: 0x0027CCB9 File Offset: 0x0027AEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerDeductLife
		{
			get
			{
				return this.playerDeductLife_;
			}
			set
			{
				this.playerDeductLife_ = value;
			}
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x06010FFB RID: 69627 RVA: 0x0027CCC2 File Offset: 0x0027AEC2
		// (set) Token: 0x06010FFC RID: 69628 RVA: 0x0027CCCA File Offset: 0x0027AECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerCurLife
		{
			get
			{
				return this.playerCurLife_;
			}
			set
			{
				this.playerCurLife_ = value;
			}
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x06010FFD RID: 69629 RVA: 0x0027CCD3 File Offset: 0x0027AED3
		// (set) Token: 0x06010FFE RID: 69630 RVA: 0x0027CCDB File Offset: 0x0027AEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcDeductLife
		{
			get
			{
				return this.npcDeductLife_;
			}
			set
			{
				this.npcDeductLife_ = value;
			}
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x06010FFF RID: 69631 RVA: 0x0027CCE4 File Offset: 0x0027AEE4
		// (set) Token: 0x06011000 RID: 69632 RVA: 0x0027CCEC File Offset: 0x0027AEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcCurLife
		{
			get
			{
				return this.npcCurLife_;
			}
			set
			{
				this.npcCurLife_ = value;
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x06011001 RID: 69633 RVA: 0x0027CCF5 File Offset: 0x0027AEF5
		// (set) Token: 0x06011002 RID: 69634 RVA: 0x0027CCFD File Offset: 0x0027AEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinalSettle
		{
			get
			{
				return this.isFinalSettle_;
			}
			set
			{
				this.isFinalSettle_ = value;
			}
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x06011003 RID: 69635 RVA: 0x0027CD06 File Offset: 0x0027AF06
		// (set) Token: 0x06011004 RID: 69636 RVA: 0x0027CD0E File Offset: 0x0027AF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerOriginalDamage
		{
			get
			{
				return this.playerOriginalDamage_;
			}
			set
			{
				this.playerOriginalDamage_ = value;
			}
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x06011005 RID: 69637 RVA: 0x0027CD17 File Offset: 0x0027AF17
		// (set) Token: 0x06011006 RID: 69638 RVA: 0x0027CD1F File Offset: 0x0027AF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcOriginalDamage
		{
			get
			{
				return this.npcOriginalDamage_;
			}
			set
			{
				this.npcOriginalDamage_ = value;
			}
		}

		// Token: 0x06011007 RID: 69639 RVA: 0x0027CD28 File Offset: 0x0027AF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBSettleNotify);
		}

		// Token: 0x06011008 RID: 69640 RVA: 0x0027CD38 File Offset: 0x0027AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBSettleNotify other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && this.PlayerDeductLife == other.PlayerDeductLife && this.PlayerCurLife == other.PlayerCurLife && this.NpcDeductLife == other.NpcDeductLife && this.NpcCurLife == other.NpcCurLife && this.IsFinalSettle == other.IsFinalSettle && this.PlayerOriginalDamage == other.PlayerOriginalDamage && this.NpcOriginalDamage == other.NpcOriginalDamage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011009 RID: 69641 RVA: 0x0027CDE4 File Offset: 0x0027AFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.PlayerDeductLife != 0)
			{
				num ^= this.PlayerDeductLife.GetHashCode();
			}
			if (this.PlayerCurLife != 0)
			{
				num ^= this.PlayerCurLife.GetHashCode();
			}
			if (this.NpcDeductLife != 0)
			{
				num ^= this.NpcDeductLife.GetHashCode();
			}
			if (this.NpcCurLife != 0)
			{
				num ^= this.NpcCurLife.GetHashCode();
			}
			if (this.IsFinalSettle)
			{
				num ^= this.IsFinalSettle.GetHashCode();
			}
			if (this.PlayerOriginalDamage != 0)
			{
				num ^= this.PlayerOriginalDamage.GetHashCode();
			}
			if (this.NpcOriginalDamage != 0)
			{
				num ^= this.NpcOriginalDamage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601100A RID: 69642 RVA: 0x0027CED2 File Offset: 0x0027B0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601100B RID: 69643 RVA: 0x0027CEDF File Offset: 0x0027B0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601100C RID: 69644 RVA: 0x0027CEE8 File Offset: 0x0027B0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsWin)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsWin);
			}
			if (this.PlayerOriginalDamage != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerOriginalDamage);
			}
			if (this.IsFinalSettle)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsFinalSettle);
			}
			if (this.NpcCurLife != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NpcCurLife);
			}
			if (this.NpcDeductLife != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NpcDeductLife);
			}
			if (this.PlayerCurLife != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerCurLife);
			}
			if (this.NpcOriginalDamage != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.NpcOriginalDamage);
			}
			if (this.PlayerDeductLife != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerDeductLife);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601100D RID: 69645 RVA: 0x0027CFEC File Offset: 0x0027B1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.PlayerDeductLife != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerDeductLife);
			}
			if (this.PlayerCurLife != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerCurLife);
			}
			if (this.NpcDeductLife != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcDeductLife);
			}
			if (this.NpcCurLife != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcCurLife);
			}
			if (this.IsFinalSettle)
			{
				num += 2;
			}
			if (this.PlayerOriginalDamage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerOriginalDamage);
			}
			if (this.NpcOriginalDamage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcOriginalDamage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601100E RID: 69646 RVA: 0x0027D0BC File Offset: 0x0027B2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.PlayerDeductLife != 0)
			{
				this.PlayerDeductLife = other.PlayerDeductLife;
			}
			if (other.PlayerCurLife != 0)
			{
				this.PlayerCurLife = other.PlayerCurLife;
			}
			if (other.NpcDeductLife != 0)
			{
				this.NpcDeductLife = other.NpcDeductLife;
			}
			if (other.NpcCurLife != 0)
			{
				this.NpcCurLife = other.NpcCurLife;
			}
			if (other.IsFinalSettle)
			{
				this.IsFinalSettle = other.IsFinalSettle;
			}
			if (other.PlayerOriginalDamage != 0)
			{
				this.PlayerOriginalDamage = other.PlayerOriginalDamage;
			}
			if (other.NpcOriginalDamage != 0)
			{
				this.NpcOriginalDamage = other.NpcOriginalDamage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601100F RID: 69647 RVA: 0x0027D184 File Offset: 0x0027B384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011010 RID: 69648 RVA: 0x0027D190 File Offset: 0x0027B390
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
				if (num <= 48U)
				{
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.IsWin = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.PlayerOriginalDamage = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.IsFinalSettle = input.ReadBool();
							continue;
						}
						if (num == 48U)
						{
							this.NpcCurLife = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.NpcDeductLife = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.PlayerCurLife = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.NpcOriginalDamage = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.PlayerDeductLife = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006BAB RID: 27563
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BAC RID: 27564
		public const int IsWinFieldNumber = 3;

		// Token: 0x04006BAD RID: 27565
		private bool isWin_;

		// Token: 0x04006BAE RID: 27566
		public const int PlayerDeductLifeFieldNumber = 13;

		// Token: 0x04006BAF RID: 27567
		private int playerDeductLife_;

		// Token: 0x04006BB0 RID: 27568
		public const int PlayerCurLifeFieldNumber = 8;

		// Token: 0x04006BB1 RID: 27569
		private int playerCurLife_;

		// Token: 0x04006BB2 RID: 27570
		public const int NpcDeductLifeFieldNumber = 7;

		// Token: 0x04006BB3 RID: 27571
		private int npcDeductLife_;

		// Token: 0x04006BB4 RID: 27572
		public const int NpcCurLifeFieldNumber = 6;

		// Token: 0x04006BB5 RID: 27573
		private int npcCurLife_;

		// Token: 0x04006BB6 RID: 27574
		public const int IsFinalSettleFieldNumber = 5;

		// Token: 0x04006BB7 RID: 27575
		private bool isFinalSettle_;

		// Token: 0x04006BB8 RID: 27576
		public const int PlayerOriginalDamageFieldNumber = 4;

		// Token: 0x04006BB9 RID: 27577
		private int playerOriginalDamage_;

		// Token: 0x04006BBA RID: 27578
		public const int NpcOriginalDamageFieldNumber = 12;

		// Token: 0x04006BBB RID: 27579
		private int npcOriginalDamage_;
	}
}
