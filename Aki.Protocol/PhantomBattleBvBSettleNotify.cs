using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2F RID: 3119
	[NetMessage(EMessageId.PhantomBattleBvBSettleNotify)]
	public sealed class PhantomBattleBvBSettleNotify : IMessage<PhantomBattleBvBSettleNotify>, IMessage, IEquatable<PhantomBattleBvBSettleNotify>, IDeepCloneable<PhantomBattleBvBSettleNotify>, IBufferMessage
	{
		// Token: 0x06010EF1 RID: 69361 RVA: 0x0027AE98 File Offset: 0x00279098
		[NullableContext(1)]
		public static PhantomBattleBvBSettleNotify Create()
		{
			return new PhantomBattleBvBSettleNotify();
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x06010EF2 RID: 69362 RVA: 0x0027AE9F File Offset: 0x0027909F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x06010EF3 RID: 69363 RVA: 0x0027AEA2 File Offset: 0x002790A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBSettleNotify.Descriptor;
			}
		}

		// Token: 0x06010EF4 RID: 69364 RVA: 0x0027AEA9 File Offset: 0x002790A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBSettleNotify()
		{
		}

		// Token: 0x06010EF5 RID: 69365 RVA: 0x0027AEB4 File Offset: 0x002790B4
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

		// Token: 0x06010EF6 RID: 69366 RVA: 0x0027AF38 File Offset: 0x00279138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBSettleNotify Clone()
		{
			return new PhantomBattleBvBSettleNotify(this);
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x06010EF7 RID: 69367 RVA: 0x0027AF40 File Offset: 0x00279140
		// (set) Token: 0x06010EF8 RID: 69368 RVA: 0x0027AF48 File Offset: 0x00279148
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

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x06010EF9 RID: 69369 RVA: 0x0027AF51 File Offset: 0x00279151
		// (set) Token: 0x06010EFA RID: 69370 RVA: 0x0027AF59 File Offset: 0x00279159
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

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x06010EFB RID: 69371 RVA: 0x0027AF62 File Offset: 0x00279162
		// (set) Token: 0x06010EFC RID: 69372 RVA: 0x0027AF6A File Offset: 0x0027916A
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

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x06010EFD RID: 69373 RVA: 0x0027AF73 File Offset: 0x00279173
		// (set) Token: 0x06010EFE RID: 69374 RVA: 0x0027AF7B File Offset: 0x0027917B
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

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x06010EFF RID: 69375 RVA: 0x0027AF84 File Offset: 0x00279184
		// (set) Token: 0x06010F00 RID: 69376 RVA: 0x0027AF8C File Offset: 0x0027918C
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

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x06010F01 RID: 69377 RVA: 0x0027AF95 File Offset: 0x00279195
		// (set) Token: 0x06010F02 RID: 69378 RVA: 0x0027AF9D File Offset: 0x0027919D
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

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x06010F03 RID: 69379 RVA: 0x0027AFA6 File Offset: 0x002791A6
		// (set) Token: 0x06010F04 RID: 69380 RVA: 0x0027AFAE File Offset: 0x002791AE
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

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x06010F05 RID: 69381 RVA: 0x0027AFB7 File Offset: 0x002791B7
		// (set) Token: 0x06010F06 RID: 69382 RVA: 0x0027AFBF File Offset: 0x002791BF
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

		// Token: 0x06010F07 RID: 69383 RVA: 0x0027AFC8 File Offset: 0x002791C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBSettleNotify);
		}

		// Token: 0x06010F08 RID: 69384 RVA: 0x0027AFD8 File Offset: 0x002791D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBSettleNotify other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && this.PlayerDeductLife == other.PlayerDeductLife && this.PlayerCurLife == other.PlayerCurLife && this.NpcDeductLife == other.NpcDeductLife && this.NpcCurLife == other.NpcCurLife && this.IsFinalSettle == other.IsFinalSettle && this.PlayerOriginalDamage == other.PlayerOriginalDamage && this.NpcOriginalDamage == other.NpcOriginalDamage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F09 RID: 69385 RVA: 0x0027B084 File Offset: 0x00279284
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

		// Token: 0x06010F0A RID: 69386 RVA: 0x0027B172 File Offset: 0x00279372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F0B RID: 69387 RVA: 0x0027B17F File Offset: 0x0027937F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F0C RID: 69388 RVA: 0x0027B188 File Offset: 0x00279388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcOriginalDamage != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NpcOriginalDamage);
			}
			if (this.NpcCurLife != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NpcCurLife);
			}
			if (this.IsFinalSettle)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinalSettle);
			}
			if (this.IsWin)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsWin);
			}
			if (this.PlayerDeductLife != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerDeductLife);
			}
			if (this.PlayerOriginalDamage != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerOriginalDamage);
			}
			if (this.NpcDeductLife != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.NpcDeductLife);
			}
			if (this.PlayerCurLife != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerCurLife);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F0D RID: 69389 RVA: 0x0027B288 File Offset: 0x00279488
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

		// Token: 0x06010F0E RID: 69390 RVA: 0x0027B358 File Offset: 0x00279558
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

		// Token: 0x06010F0F RID: 69391 RVA: 0x0027B420 File Offset: 0x00279620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F10 RID: 69392 RVA: 0x0027B42C File Offset: 0x0027962C
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
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.NpcOriginalDamage = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.NpcCurLife = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.IsFinalSettle = input.ReadBool();
							continue;
						}
						if (num == 48U)
						{
							this.IsWin = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 88U)
					{
						this.PlayerDeductLife = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.PlayerOriginalDamage = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.NpcDeductLife = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.PlayerCurLife = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006BBF RID: 27583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BC0 RID: 27584
		public const int IsWinFieldNumber = 6;

		// Token: 0x04006BC1 RID: 27585
		private bool isWin_;

		// Token: 0x04006BC2 RID: 27586
		public const int PlayerDeductLifeFieldNumber = 11;

		// Token: 0x04006BC3 RID: 27587
		private int playerDeductLife_;

		// Token: 0x04006BC4 RID: 27588
		public const int PlayerCurLifeFieldNumber = 15;

		// Token: 0x04006BC5 RID: 27589
		private int playerCurLife_;

		// Token: 0x04006BC6 RID: 27590
		public const int NpcDeductLifeFieldNumber = 13;

		// Token: 0x04006BC7 RID: 27591
		private int npcDeductLife_;

		// Token: 0x04006BC8 RID: 27592
		public const int NpcCurLifeFieldNumber = 2;

		// Token: 0x04006BC9 RID: 27593
		private int npcCurLife_;

		// Token: 0x04006BCA RID: 27594
		public const int IsFinalSettleFieldNumber = 3;

		// Token: 0x04006BCB RID: 27595
		private bool isFinalSettle_;

		// Token: 0x04006BCC RID: 27596
		public const int PlayerOriginalDamageFieldNumber = 12;

		// Token: 0x04006BCD RID: 27597
		private int playerOriginalDamage_;

		// Token: 0x04006BCE RID: 27598
		public const int NpcOriginalDamageFieldNumber = 1;

		// Token: 0x04006BCF RID: 27599
		private int npcOriginalDamage_;
	}
}
