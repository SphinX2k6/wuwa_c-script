using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6D RID: 3181
	public sealed class PhantomBattleDirectDamage : IMessage<PhantomBattleDirectDamage>, IMessage, IEquatable<PhantomBattleDirectDamage>, IDeepCloneable<PhantomBattleDirectDamage>, IBufferMessage
	{
		// Token: 0x0601143A RID: 70714 RVA: 0x00287897 File Offset: 0x00285A97
		[NullableContext(1)]
		public static PhantomBattleDirectDamage Create()
		{
			return new PhantomBattleDirectDamage();
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0601143B RID: 70715 RVA: 0x0028789E File Offset: 0x00285A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0601143C RID: 70716 RVA: 0x002878A1 File Offset: 0x00285AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDirectDamage.Descriptor;
			}
		}

		// Token: 0x0601143D RID: 70717 RVA: 0x002878A8 File Offset: 0x00285AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDirectDamage()
		{
		}

		// Token: 0x0601143E RID: 70718 RVA: 0x002878B0 File Offset: 0x00285AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDirectDamage(PhantomBattleDirectDamage other) : this()
		{
			this.targetIsPlayer_ = other.targetIsPlayer_;
			this.damage_ = other.damage_;
			this.cardFighterUid_ = other.cardFighterUid_;
			this.finalHp_ = other.finalHp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601143F RID: 70719 RVA: 0x00287904 File Offset: 0x00285B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDirectDamage Clone()
		{
			return new PhantomBattleDirectDamage(this);
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x06011440 RID: 70720 RVA: 0x0028790C File Offset: 0x00285B0C
		// (set) Token: 0x06011441 RID: 70721 RVA: 0x00287914 File Offset: 0x00285B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TargetIsPlayer
		{
			get
			{
				return this.targetIsPlayer_;
			}
			set
			{
				this.targetIsPlayer_ = value;
			}
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x06011442 RID: 70722 RVA: 0x0028791D File Offset: 0x00285B1D
		// (set) Token: 0x06011443 RID: 70723 RVA: 0x00287925 File Offset: 0x00285B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x06011444 RID: 70724 RVA: 0x0028792E File Offset: 0x00285B2E
		// (set) Token: 0x06011445 RID: 70725 RVA: 0x00287936 File Offset: 0x00285B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardFighterUid
		{
			get
			{
				return this.cardFighterUid_;
			}
			set
			{
				this.cardFighterUid_ = value;
			}
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x06011446 RID: 70726 RVA: 0x0028793F File Offset: 0x00285B3F
		// (set) Token: 0x06011447 RID: 70727 RVA: 0x00287947 File Offset: 0x00285B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinalHp
		{
			get
			{
				return this.finalHp_;
			}
			set
			{
				this.finalHp_ = value;
			}
		}

		// Token: 0x06011448 RID: 70728 RVA: 0x00287950 File Offset: 0x00285B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDirectDamage);
		}

		// Token: 0x06011449 RID: 70729 RVA: 0x00287960 File Offset: 0x00285B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDirectDamage other)
		{
			return other != null && (other == this || (this.TargetIsPlayer == other.TargetIsPlayer && this.Damage == other.Damage && this.CardFighterUid == other.CardFighterUid && this.FinalHp == other.FinalHp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601144A RID: 70730 RVA: 0x002879CC File Offset: 0x00285BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetIsPlayer)
			{
				num ^= this.TargetIsPlayer.GetHashCode();
			}
			if (this.Damage != 0)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.CardFighterUid != 0)
			{
				num ^= this.CardFighterUid.GetHashCode();
			}
			if (this.FinalHp != 0)
			{
				num ^= this.FinalHp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601144B RID: 70731 RVA: 0x00287A56 File Offset: 0x00285C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601144C RID: 70732 RVA: 0x00287A63 File Offset: 0x00285C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601144D RID: 70733 RVA: 0x00287A6C File Offset: 0x00285C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetIsPlayer)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.TargetIsPlayer);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Damage);
			}
			if (this.CardFighterUid != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardFighterUid);
			}
			if (this.FinalHp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FinalHp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601144E RID: 70734 RVA: 0x00287AFC File Offset: 0x00285CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetIsPlayer)
			{
				num += 2;
			}
			if (this.Damage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Damage);
			}
			if (this.CardFighterUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardFighterUid);
			}
			if (this.FinalHp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinalHp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601144F RID: 70735 RVA: 0x00287B78 File Offset: 0x00285D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDirectDamage other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetIsPlayer)
			{
				this.TargetIsPlayer = other.TargetIsPlayer;
			}
			if (other.Damage != 0)
			{
				this.Damage = other.Damage;
			}
			if (other.CardFighterUid != 0)
			{
				this.CardFighterUid = other.CardFighterUid;
			}
			if (other.FinalHp != 0)
			{
				this.FinalHp = other.FinalHp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011450 RID: 70736 RVA: 0x00287BF0 File Offset: 0x00285DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011451 RID: 70737 RVA: 0x00287BFC File Offset: 0x00285DFC
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
						this.TargetIsPlayer = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.Damage = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CardFighterUid = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FinalHp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006D97 RID: 28055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D98 RID: 28056
		public const int TargetIsPlayerFieldNumber = 1;

		// Token: 0x04006D99 RID: 28057
		private bool targetIsPlayer_;

		// Token: 0x04006D9A RID: 28058
		public const int DamageFieldNumber = 2;

		// Token: 0x04006D9B RID: 28059
		private int damage_;

		// Token: 0x04006D9C RID: 28060
		public const int CardFighterUidFieldNumber = 3;

		// Token: 0x04006D9D RID: 28061
		private int cardFighterUid_;

		// Token: 0x04006D9E RID: 28062
		public const int FinalHpFieldNumber = 4;

		// Token: 0x04006D9F RID: 28063
		private int finalHp_;
	}
}
