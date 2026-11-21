using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D47 RID: 3399
	public sealed class PinballResultRolePb : IMessage<PinballResultRolePb>, IMessage, IEquatable<PinballResultRolePb>, IDeepCloneable<PinballResultRolePb>, IBufferMessage
	{
		// Token: 0x060125C2 RID: 75202 RVA: 0x002AE823 File Offset: 0x002ACA23
		[NullableContext(1)]
		public static PinballResultRolePb Create()
		{
			return new PinballResultRolePb();
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x060125C3 RID: 75203 RVA: 0x002AE82A File Offset: 0x002ACA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballResultRolePb> Parser
		{
			get
			{
				return PinballResultRolePb._parser;
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x060125C4 RID: 75204 RVA: 0x002AE831 File Offset: 0x002ACA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x060125C5 RID: 75205 RVA: 0x002AE834 File Offset: 0x002ACA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballResultRolePb.Descriptor;
			}
		}

		// Token: 0x060125C6 RID: 75206 RVA: 0x002AE83B File Offset: 0x002ACA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResultRolePb()
		{
		}

		// Token: 0x060125C7 RID: 75207 RVA: 0x002AE844 File Offset: 0x002ACA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResultRolePb(PinballResultRolePb other) : this()
		{
			this.roleId_ = other.roleId_;
			this.damage_ = other.damage_;
			this.skillTimes_ = other.skillTimes_;
			this.dropCostHp_ = other.dropCostHp_;
			this.hitCostHp_ = other.hitCostHp_;
			this.tempDieTimes_ = other.tempDieTimes_;
			this.tempReviveTimes_ = other.tempReviveTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125C8 RID: 75208 RVA: 0x002AE8BC File Offset: 0x002ACABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResultRolePb Clone()
		{
			return new PinballResultRolePb(this);
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x060125C9 RID: 75209 RVA: 0x002AE8C4 File Offset: 0x002ACAC4
		// (set) Token: 0x060125CA RID: 75210 RVA: 0x002AE8CC File Offset: 0x002ACACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x060125CB RID: 75211 RVA: 0x002AE8D5 File Offset: 0x002ACAD5
		// (set) Token: 0x060125CC RID: 75212 RVA: 0x002AE8DD File Offset: 0x002ACADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Damage
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

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x060125CD RID: 75213 RVA: 0x002AE8E6 File Offset: 0x002ACAE6
		// (set) Token: 0x060125CE RID: 75214 RVA: 0x002AE8EE File Offset: 0x002ACAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillTimes
		{
			get
			{
				return this.skillTimes_;
			}
			set
			{
				this.skillTimes_ = value;
			}
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x060125CF RID: 75215 RVA: 0x002AE8F7 File Offset: 0x002ACAF7
		// (set) Token: 0x060125D0 RID: 75216 RVA: 0x002AE8FF File Offset: 0x002ACAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DropCostHp
		{
			get
			{
				return this.dropCostHp_;
			}
			set
			{
				this.dropCostHp_ = value;
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x060125D1 RID: 75217 RVA: 0x002AE908 File Offset: 0x002ACB08
		// (set) Token: 0x060125D2 RID: 75218 RVA: 0x002AE910 File Offset: 0x002ACB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HitCostHp
		{
			get
			{
				return this.hitCostHp_;
			}
			set
			{
				this.hitCostHp_ = value;
			}
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x060125D3 RID: 75219 RVA: 0x002AE919 File Offset: 0x002ACB19
		// (set) Token: 0x060125D4 RID: 75220 RVA: 0x002AE921 File Offset: 0x002ACB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TempDieTimes
		{
			get
			{
				return this.tempDieTimes_;
			}
			set
			{
				this.tempDieTimes_ = value;
			}
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x060125D5 RID: 75221 RVA: 0x002AE92A File Offset: 0x002ACB2A
		// (set) Token: 0x060125D6 RID: 75222 RVA: 0x002AE932 File Offset: 0x002ACB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TempReviveTimes
		{
			get
			{
				return this.tempReviveTimes_;
			}
			set
			{
				this.tempReviveTimes_ = value;
			}
		}

		// Token: 0x060125D7 RID: 75223 RVA: 0x002AE93B File Offset: 0x002ACB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballResultRolePb);
		}

		// Token: 0x060125D8 RID: 75224 RVA: 0x002AE94C File Offset: 0x002ACB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballResultRolePb other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Damage == other.Damage && this.SkillTimes == other.SkillTimes && this.DropCostHp == other.DropCostHp && this.HitCostHp == other.HitCostHp && this.TempDieTimes == other.TempDieTimes && this.TempReviveTimes == other.TempReviveTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060125D9 RID: 75225 RVA: 0x002AE9E8 File Offset: 0x002ACBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Damage != 0L)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.SkillTimes != 0)
			{
				num ^= this.SkillTimes.GetHashCode();
			}
			if (this.DropCostHp != 0L)
			{
				num ^= this.DropCostHp.GetHashCode();
			}
			if (this.HitCostHp != 0L)
			{
				num ^= this.HitCostHp.GetHashCode();
			}
			if (this.TempDieTimes != 0)
			{
				num ^= this.TempDieTimes.GetHashCode();
			}
			if (this.TempReviveTimes != 0)
			{
				num ^= this.TempReviveTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060125DA RID: 75226 RVA: 0x002AEABD File Offset: 0x002ACCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060125DB RID: 75227 RVA: 0x002AEACA File Offset: 0x002ACCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060125DC RID: 75228 RVA: 0x002AEAD4 File Offset: 0x002ACCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Damage != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Damage);
			}
			if (this.SkillTimes != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillTimes);
			}
			if (this.DropCostHp != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.DropCostHp);
			}
			if (this.HitCostHp != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.HitCostHp);
			}
			if (this.TempDieTimes != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TempDieTimes);
			}
			if (this.TempReviveTimes != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TempReviveTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060125DD RID: 75229 RVA: 0x002AEBB8 File Offset: 0x002ACDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Damage != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Damage);
			}
			if (this.SkillTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillTimes);
			}
			if (this.DropCostHp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DropCostHp);
			}
			if (this.HitCostHp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HitCostHp);
			}
			if (this.TempDieTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TempDieTimes);
			}
			if (this.TempReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TempReviveTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060125DE RID: 75230 RVA: 0x002AEC88 File Offset: 0x002ACE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballResultRolePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Damage != 0L)
			{
				this.Damage = other.Damage;
			}
			if (other.SkillTimes != 0)
			{
				this.SkillTimes = other.SkillTimes;
			}
			if (other.DropCostHp != 0L)
			{
				this.DropCostHp = other.DropCostHp;
			}
			if (other.HitCostHp != 0L)
			{
				this.HitCostHp = other.HitCostHp;
			}
			if (other.TempDieTimes != 0)
			{
				this.TempDieTimes = other.TempDieTimes;
			}
			if (other.TempReviveTimes != 0)
			{
				this.TempReviveTimes = other.TempReviveTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060125DF RID: 75231 RVA: 0x002AED3C File Offset: 0x002ACF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125E0 RID: 75232 RVA: 0x002AED48 File Offset: 0x002ACF48
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
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Damage = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.SkillTimes = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.DropCostHp = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.HitCostHp = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.TempDieTimes = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.TempReviveTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040072C7 RID: 29383
		private static readonly MessageParser<PinballResultRolePb> _parser = new MessageParser<PinballResultRolePb>(() => new PinballResultRolePb());

		// Token: 0x040072C8 RID: 29384
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072C9 RID: 29385
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040072CA RID: 29386
		private int roleId_;

		// Token: 0x040072CB RID: 29387
		public const int DamageFieldNumber = 2;

		// Token: 0x040072CC RID: 29388
		private long damage_;

		// Token: 0x040072CD RID: 29389
		public const int SkillTimesFieldNumber = 3;

		// Token: 0x040072CE RID: 29390
		private int skillTimes_;

		// Token: 0x040072CF RID: 29391
		public const int DropCostHpFieldNumber = 4;

		// Token: 0x040072D0 RID: 29392
		private long dropCostHp_;

		// Token: 0x040072D1 RID: 29393
		public const int HitCostHpFieldNumber = 5;

		// Token: 0x040072D2 RID: 29394
		private long hitCostHp_;

		// Token: 0x040072D3 RID: 29395
		public const int TempDieTimesFieldNumber = 6;

		// Token: 0x040072D4 RID: 29396
		private int tempDieTimes_;

		// Token: 0x040072D5 RID: 29397
		public const int TempReviveTimesFieldNumber = 7;

		// Token: 0x040072D6 RID: 29398
		private int tempReviveTimes_;
	}
}
