using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000330 RID: 816
	[NetMessage(EMessageId.DamageExecuteResponse)]
	public sealed class DamageExecuteResponse : IMessage<DamageExecuteResponse>, IMessage, IEquatable<DamageExecuteResponse>, IDeepCloneable<DamageExecuteResponse>, IBufferMessage
	{
		// Token: 0x060051FE RID: 20990 RVA: 0x000C7F6E File Offset: 0x000C616E
		[NullableContext(1)]
		public static DamageExecuteResponse Create()
		{
			return new DamageExecuteResponse();
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x060051FF RID: 20991 RVA: 0x000C7F75 File Offset: 0x000C6175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x000C7F78 File Offset: 0x000C6178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageExecuteResponse.Descriptor;
			}
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x000C7F7F File Offset: 0x000C617F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteResponse()
		{
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x000C7F88 File Offset: 0x000C6188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteResponse(DamageExecuteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.attackerEntityId_ = other.attackerEntityId_;
			this.targetEntityId_ = other.targetEntityId_;
			this.damage_ = other.damage_;
			this.partId_ = other.partId_;
			this.isCrit_ = other.isCrit_;
			this.killedTarget_ = other.killedTarget_;
			this.shieldCoverDamage_ = other.shieldCoverDamage_;
			this.immuneType_ = other.immuneType_;
			this.elementType_ = other.elementType_;
			this.changeLife_ = other.changeLife_;
			this.changeWeakness_ = other.changeWeakness_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x000C803C File Offset: 0x000C623C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteResponse Clone()
		{
			return new DamageExecuteResponse(this);
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x000C8044 File Offset: 0x000C6244
		// (set) Token: 0x06005205 RID: 20997 RVA: 0x000C804C File Offset: 0x000C624C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x000C8055 File Offset: 0x000C6255
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x000C805D File Offset: 0x000C625D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AttackerEntityId
		{
			get
			{
				return this.attackerEntityId_;
			}
			set
			{
				this.attackerEntityId_ = value;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x000C8066 File Offset: 0x000C6266
		// (set) Token: 0x06005209 RID: 21001 RVA: 0x000C806E File Offset: 0x000C626E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x000C8077 File Offset: 0x000C6277
		// (set) Token: 0x0600520B RID: 21003 RVA: 0x000C807F File Offset: 0x000C627F
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

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x000C8088 File Offset: 0x000C6288
		// (set) Token: 0x0600520D RID: 21005 RVA: 0x000C8090 File Offset: 0x000C6290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x000C8099 File Offset: 0x000C6299
		// (set) Token: 0x0600520F RID: 21007 RVA: 0x000C80A1 File Offset: 0x000C62A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCrit
		{
			get
			{
				return this.isCrit_;
			}
			set
			{
				this.isCrit_ = value;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x000C80AA File Offset: 0x000C62AA
		// (set) Token: 0x06005211 RID: 21009 RVA: 0x000C80B2 File Offset: 0x000C62B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KilledTarget
		{
			get
			{
				return this.killedTarget_;
			}
			set
			{
				this.killedTarget_ = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x000C80BB File Offset: 0x000C62BB
		// (set) Token: 0x06005213 RID: 21011 RVA: 0x000C80C3 File Offset: 0x000C62C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShieldCoverDamage
		{
			get
			{
				return this.shieldCoverDamage_;
			}
			set
			{
				this.shieldCoverDamage_ = value;
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x000C80CC File Offset: 0x000C62CC
		// (set) Token: 0x06005215 RID: 21013 RVA: 0x000C80D4 File Offset: 0x000C62D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDamageImmune ImmuneType
		{
			get
			{
				return this.immuneType_;
			}
			set
			{
				this.immuneType_ = value;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06005216 RID: 21014 RVA: 0x000C80DD File Offset: 0x000C62DD
		// (set) Token: 0x06005217 RID: 21015 RVA: 0x000C80E5 File Offset: 0x000C62E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementType
		{
			get
			{
				return this.elementType_;
			}
			set
			{
				this.elementType_ = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x000C80EE File Offset: 0x000C62EE
		// (set) Token: 0x06005219 RID: 21017 RVA: 0x000C80F6 File Offset: 0x000C62F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangeLife
		{
			get
			{
				return this.changeLife_;
			}
			set
			{
				this.changeLife_ = value;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x000C80FF File Offset: 0x000C62FF
		// (set) Token: 0x0600521B RID: 21019 RVA: 0x000C8107 File Offset: 0x000C6307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangeWeakness
		{
			get
			{
				return this.changeWeakness_;
			}
			set
			{
				this.changeWeakness_ = value;
			}
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x000C8110 File Offset: 0x000C6310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageExecuteResponse);
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x000C8120 File Offset: 0x000C6320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageExecuteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.AttackerEntityId == other.AttackerEntityId && this.TargetEntityId == other.TargetEntityId && this.Damage == other.Damage && this.PartId == other.PartId && this.IsCrit == other.IsCrit && this.KilledTarget == other.KilledTarget && this.ShieldCoverDamage == other.ShieldCoverDamage && this.ImmuneType == other.ImmuneType && this.ElementType == other.ElementType && this.ChangeLife == other.ChangeLife && this.ChangeWeakness == other.ChangeWeakness && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x000C820C File Offset: 0x000C640C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.AttackerEntityId != 0L)
			{
				num ^= this.AttackerEntityId.GetHashCode();
			}
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.Damage != 0)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this.IsCrit)
			{
				num ^= this.IsCrit.GetHashCode();
			}
			if (this.KilledTarget)
			{
				num ^= this.KilledTarget.GetHashCode();
			}
			if (this.ShieldCoverDamage != 0)
			{
				num ^= this.ShieldCoverDamage.GetHashCode();
			}
			if (this.ImmuneType != EDamageImmune.Default)
			{
				num ^= this.ImmuneType.GetHashCode();
			}
			if (this.ElementType != 0)
			{
				num ^= this.ElementType.GetHashCode();
			}
			if (this.ChangeLife != 0)
			{
				num ^= this.ChangeLife.GetHashCode();
			}
			if (this.ChangeWeakness != 0)
			{
				num ^= this.ChangeWeakness.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x000C836D File Offset: 0x000C656D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x000C837A File Offset: 0x000C657A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x000C8384 File Offset: 0x000C6584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PartId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PartId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.ElementType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ElementType);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ImmuneType != EDamageImmune.Default)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ImmuneType);
			}
			if (this.ChangeLife != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChangeLife);
			}
			if (this.AttackerEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.AttackerEntityId);
			}
			if (this.ChangeWeakness != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChangeWeakness);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Damage);
			}
			if (this.IsCrit)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsCrit);
			}
			if (this.KilledTarget)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.KilledTarget);
			}
			if (this.ShieldCoverDamage != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ShieldCoverDamage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x000C84F4 File Offset: 0x000C66F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.AttackerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AttackerEntityId);
			}
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this.Damage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Damage);
			}
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this.IsCrit)
			{
				num += 2;
			}
			if (this.KilledTarget)
			{
				num += 2;
			}
			if (this.ShieldCoverDamage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShieldCoverDamage);
			}
			if (this.ImmuneType != EDamageImmune.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ImmuneType);
			}
			if (this.ElementType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ElementType);
			}
			if (this.ChangeLife != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangeLife);
			}
			if (this.ChangeWeakness != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangeWeakness);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x000C8624 File Offset: 0x000C6824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DamageExecuteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.AttackerEntityId != 0L)
			{
				this.AttackerEntityId = other.AttackerEntityId;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.Damage != 0)
			{
				this.Damage = other.Damage;
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			if (other.IsCrit)
			{
				this.IsCrit = other.IsCrit;
			}
			if (other.KilledTarget)
			{
				this.KilledTarget = other.KilledTarget;
			}
			if (other.ShieldCoverDamage != 0)
			{
				this.ShieldCoverDamage = other.ShieldCoverDamage;
			}
			if (other.ImmuneType != EDamageImmune.Default)
			{
				this.ImmuneType = other.ImmuneType;
			}
			if (other.ElementType != 0)
			{
				this.ElementType = other.ElementType;
			}
			if (other.ChangeLife != 0)
			{
				this.ChangeLife = other.ChangeLife;
			}
			if (other.ChangeWeakness != 0)
			{
				this.ChangeWeakness = other.ChangeWeakness;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x000C873C File Offset: 0x000C693C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x000C8748 File Offset: 0x000C6948
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
				if (num <= 56U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.PartId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.TargetEntityId = input.ReadInt64();
							continue;
						}
						if (num == 24U)
						{
							this.ElementType = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 40U)
						{
							this.ImmuneType = (EDamageImmune)input.ReadEnum();
							continue;
						}
						if (num == 56U)
						{
							this.ChangeLife = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.AttackerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.ChangeWeakness = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Damage = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.IsCrit = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.KilledTarget = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.ShieldCoverDamage = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032FA RID: 13050
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032FB RID: 13051
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040032FC RID: 13052
		private ErrorCode errorCode_;

		// Token: 0x040032FD RID: 13053
		public const int AttackerEntityIdFieldNumber = 8;

		// Token: 0x040032FE RID: 13054
		private long attackerEntityId_;

		// Token: 0x040032FF RID: 13055
		public const int TargetEntityIdFieldNumber = 2;

		// Token: 0x04003300 RID: 13056
		private long targetEntityId_;

		// Token: 0x04003301 RID: 13057
		public const int DamageFieldNumber = 10;

		// Token: 0x04003302 RID: 13058
		private int damage_;

		// Token: 0x04003303 RID: 13059
		public const int PartIdFieldNumber = 1;

		// Token: 0x04003304 RID: 13060
		private int partId_;

		// Token: 0x04003305 RID: 13061
		public const int IsCritFieldNumber = 11;

		// Token: 0x04003306 RID: 13062
		private bool isCrit_;

		// Token: 0x04003307 RID: 13063
		public const int KilledTargetFieldNumber = 13;

		// Token: 0x04003308 RID: 13064
		private bool killedTarget_;

		// Token: 0x04003309 RID: 13065
		public const int ShieldCoverDamageFieldNumber = 15;

		// Token: 0x0400330A RID: 13066
		private int shieldCoverDamage_;

		// Token: 0x0400330B RID: 13067
		public const int ImmuneTypeFieldNumber = 5;

		// Token: 0x0400330C RID: 13068
		private EDamageImmune immuneType_;

		// Token: 0x0400330D RID: 13069
		public const int ElementTypeFieldNumber = 3;

		// Token: 0x0400330E RID: 13070
		private int elementType_;

		// Token: 0x0400330F RID: 13071
		public const int ChangeLifeFieldNumber = 7;

		// Token: 0x04003310 RID: 13072
		private int changeLife_;

		// Token: 0x04003311 RID: 13073
		public const int ChangeWeaknessFieldNumber = 9;

		// Token: 0x04003312 RID: 13074
		private int changeWeakness_;
	}
}
