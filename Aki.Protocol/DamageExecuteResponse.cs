using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000337 RID: 823
	[NetMessage(EMessageId.DamageExecuteResponse)]
	public sealed class DamageExecuteResponse : IMessage<DamageExecuteResponse>, IMessage, IEquatable<DamageExecuteResponse>, IDeepCloneable<DamageExecuteResponse>, IBufferMessage
	{
		// Token: 0x060052D7 RID: 21207 RVA: 0x000CA358 File Offset: 0x000C8558
		[NullableContext(1)]
		public static DamageExecuteResponse Create()
		{
			return new DamageExecuteResponse();
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x000CA35F File Offset: 0x000C855F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x060052D9 RID: 21209 RVA: 0x000CA362 File Offset: 0x000C8562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageExecuteResponse.Descriptor;
			}
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x000CA369 File Offset: 0x000C8569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteResponse()
		{
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x000CA374 File Offset: 0x000C8574
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

		// Token: 0x060052DC RID: 21212 RVA: 0x000CA428 File Offset: 0x000C8628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteResponse Clone()
		{
			return new DamageExecuteResponse(this);
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x060052DD RID: 21213 RVA: 0x000CA430 File Offset: 0x000C8630
		// (set) Token: 0x060052DE RID: 21214 RVA: 0x000CA438 File Offset: 0x000C8638
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

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x060052DF RID: 21215 RVA: 0x000CA441 File Offset: 0x000C8641
		// (set) Token: 0x060052E0 RID: 21216 RVA: 0x000CA449 File Offset: 0x000C8649
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

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x060052E1 RID: 21217 RVA: 0x000CA452 File Offset: 0x000C8652
		// (set) Token: 0x060052E2 RID: 21218 RVA: 0x000CA45A File Offset: 0x000C865A
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

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x060052E3 RID: 21219 RVA: 0x000CA463 File Offset: 0x000C8663
		// (set) Token: 0x060052E4 RID: 21220 RVA: 0x000CA46B File Offset: 0x000C866B
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

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x060052E5 RID: 21221 RVA: 0x000CA474 File Offset: 0x000C8674
		// (set) Token: 0x060052E6 RID: 21222 RVA: 0x000CA47C File Offset: 0x000C867C
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

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x060052E7 RID: 21223 RVA: 0x000CA485 File Offset: 0x000C8685
		// (set) Token: 0x060052E8 RID: 21224 RVA: 0x000CA48D File Offset: 0x000C868D
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

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x060052E9 RID: 21225 RVA: 0x000CA496 File Offset: 0x000C8696
		// (set) Token: 0x060052EA RID: 21226 RVA: 0x000CA49E File Offset: 0x000C869E
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

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x060052EB RID: 21227 RVA: 0x000CA4A7 File Offset: 0x000C86A7
		// (set) Token: 0x060052EC RID: 21228 RVA: 0x000CA4AF File Offset: 0x000C86AF
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

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x000CA4B8 File Offset: 0x000C86B8
		// (set) Token: 0x060052EE RID: 21230 RVA: 0x000CA4C0 File Offset: 0x000C86C0
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

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x060052EF RID: 21231 RVA: 0x000CA4C9 File Offset: 0x000C86C9
		// (set) Token: 0x060052F0 RID: 21232 RVA: 0x000CA4D1 File Offset: 0x000C86D1
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

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x060052F1 RID: 21233 RVA: 0x000CA4DA File Offset: 0x000C86DA
		// (set) Token: 0x060052F2 RID: 21234 RVA: 0x000CA4E2 File Offset: 0x000C86E2
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

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x060052F3 RID: 21235 RVA: 0x000CA4EB File Offset: 0x000C86EB
		// (set) Token: 0x060052F4 RID: 21236 RVA: 0x000CA4F3 File Offset: 0x000C86F3
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

		// Token: 0x060052F5 RID: 21237 RVA: 0x000CA4FC File Offset: 0x000C86FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageExecuteResponse);
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x000CA50C File Offset: 0x000C870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageExecuteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.AttackerEntityId == other.AttackerEntityId && this.TargetEntityId == other.TargetEntityId && this.Damage == other.Damage && this.PartId == other.PartId && this.IsCrit == other.IsCrit && this.KilledTarget == other.KilledTarget && this.ShieldCoverDamage == other.ShieldCoverDamage && this.ImmuneType == other.ImmuneType && this.ElementType == other.ElementType && this.ChangeLife == other.ChangeLife && this.ChangeWeakness == other.ChangeWeakness && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x000CA5F8 File Offset: 0x000C87F8
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

		// Token: 0x060052F8 RID: 21240 RVA: 0x000CA759 File Offset: 0x000C8959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x000CA766 File Offset: 0x000C8966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x000CA770 File Offset: 0x000C8970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttackerEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.AttackerEntityId);
			}
			if (this.KilledTarget)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.KilledTarget);
			}
			if (this.IsCrit)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsCrit);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ChangeLife != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ChangeLife);
			}
			if (this.ImmuneType != EDamageImmune.Default)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ImmuneType);
			}
			if (this.ShieldCoverDamage != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ShieldCoverDamage);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Damage);
			}
			if (this.ChangeWeakness != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ChangeWeakness);
			}
			if (this.PartId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PartId);
			}
			if (this.ElementType != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ElementType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x000CA8E0 File Offset: 0x000C8AE0
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

		// Token: 0x060052FC RID: 21244 RVA: 0x000CAA10 File Offset: 0x000C8C10
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

		// Token: 0x060052FD RID: 21245 RVA: 0x000CAB28 File Offset: 0x000C8D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x000CAB34 File Offset: 0x000C8D34
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
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.AttackerEntityId = input.ReadInt64();
							continue;
						}
						if (num == 16U)
						{
							this.KilledTarget = input.ReadBool();
							continue;
						}
						if (num == 24U)
						{
							this.IsCrit = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.TargetEntityId = input.ReadInt64();
							continue;
						}
						if (num == 40U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 48U)
						{
							this.ChangeLife = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.ImmuneType = (EDamageImmune)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.ShieldCoverDamage = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Damage = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ChangeWeakness = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.PartId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ElementType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003391 RID: 13201
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003392 RID: 13202
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04003393 RID: 13203
		private ErrorCode errorCode_;

		// Token: 0x04003394 RID: 13204
		public const int AttackerEntityIdFieldNumber = 1;

		// Token: 0x04003395 RID: 13205
		private long attackerEntityId_;

		// Token: 0x04003396 RID: 13206
		public const int TargetEntityIdFieldNumber = 4;

		// Token: 0x04003397 RID: 13207
		private long targetEntityId_;

		// Token: 0x04003398 RID: 13208
		public const int DamageFieldNumber = 9;

		// Token: 0x04003399 RID: 13209
		private int damage_;

		// Token: 0x0400339A RID: 13210
		public const int PartIdFieldNumber = 13;

		// Token: 0x0400339B RID: 13211
		private int partId_;

		// Token: 0x0400339C RID: 13212
		public const int IsCritFieldNumber = 3;

		// Token: 0x0400339D RID: 13213
		private bool isCrit_;

		// Token: 0x0400339E RID: 13214
		public const int KilledTargetFieldNumber = 2;

		// Token: 0x0400339F RID: 13215
		private bool killedTarget_;

		// Token: 0x040033A0 RID: 13216
		public const int ShieldCoverDamageFieldNumber = 8;

		// Token: 0x040033A1 RID: 13217
		private int shieldCoverDamage_;

		// Token: 0x040033A2 RID: 13218
		public const int ImmuneTypeFieldNumber = 7;

		// Token: 0x040033A3 RID: 13219
		private EDamageImmune immuneType_;

		// Token: 0x040033A4 RID: 13220
		public const int ElementTypeFieldNumber = 15;

		// Token: 0x040033A5 RID: 13221
		private int elementType_;

		// Token: 0x040033A6 RID: 13222
		public const int ChangeLifeFieldNumber = 6;

		// Token: 0x040033A7 RID: 13223
		private int changeLife_;

		// Token: 0x040033A8 RID: 13224
		public const int ChangeWeaknessFieldNumber = 12;

		// Token: 0x040033A9 RID: 13225
		private int changeWeakness_;
	}
}
