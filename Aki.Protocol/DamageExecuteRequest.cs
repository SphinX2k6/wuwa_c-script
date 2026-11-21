using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000336 RID: 822
	[NetMessage(EMessageId.DamageExecuteRequest)]
	public sealed class DamageExecuteRequest : IMessage<DamageExecuteRequest>, IMessage, IEquatable<DamageExecuteRequest>, IDeepCloneable<DamageExecuteRequest>, IBufferMessage
	{
		// Token: 0x060052AD RID: 21165 RVA: 0x000C9968 File Offset: 0x000C7B68
		[NullableContext(1)]
		public static DamageExecuteRequest Create()
		{
			return new DamageExecuteRequest();
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x060052AE RID: 21166 RVA: 0x000C996F File Offset: 0x000C7B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x000C9972 File Offset: 0x000C7B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageExecuteRequest.Descriptor;
			}
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x000C9979 File Offset: 0x000C7B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteRequest()
		{
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x000C9984 File Offset: 0x000C7B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteRequest(DamageExecuteRequest other) : this()
		{
			this.damageId_ = other.damageId_;
			this.skillLevel_ = other.skillLevel_;
			this.attackerEntityId_ = other.attackerEntityId_;
			this.targetEntityId_ = other.targetEntityId_;
			this.isAddEnergy_ = other.isAddEnergy_;
			this.isCounterAttack_ = other.isCounterAttack_;
			this.forceCritical_ = other.forceCritical_;
			this.isBlocked_ = other.isBlocked_;
			this.partId_ = other.partId_;
			this.counterSkillMessageId_ = other.counterSkillMessageId_;
			this.damageContext_ = ((other.damageContext_ != null) ? other.damageContext_.Clone() : null);
			this.randomSeed_ = other.randomSeed_;
			this.isBreakWeakness_ = other.isBreakWeakness_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x000C9A54 File Offset: 0x000C7C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteRequest Clone()
		{
			return new DamageExecuteRequest(this);
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x060052B3 RID: 21171 RVA: 0x000C9A5C File Offset: 0x000C7C5C
		// (set) Token: 0x060052B4 RID: 21172 RVA: 0x000C9A64 File Offset: 0x000C7C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DamageId
		{
			get
			{
				return this.damageId_;
			}
			set
			{
				this.damageId_ = value;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x060052B5 RID: 21173 RVA: 0x000C9A6D File Offset: 0x000C7C6D
		// (set) Token: 0x060052B6 RID: 21174 RVA: 0x000C9A75 File Offset: 0x000C7C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillLevel
		{
			get
			{
				return this.skillLevel_;
			}
			set
			{
				this.skillLevel_ = value;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x060052B7 RID: 21175 RVA: 0x000C9A7E File Offset: 0x000C7C7E
		// (set) Token: 0x060052B8 RID: 21176 RVA: 0x000C9A86 File Offset: 0x000C7C86
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

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x060052B9 RID: 21177 RVA: 0x000C9A8F File Offset: 0x000C7C8F
		// (set) Token: 0x060052BA RID: 21178 RVA: 0x000C9A97 File Offset: 0x000C7C97
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

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x000C9AA0 File Offset: 0x000C7CA0
		// (set) Token: 0x060052BC RID: 21180 RVA: 0x000C9AA8 File Offset: 0x000C7CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAddEnergy
		{
			get
			{
				return this.isAddEnergy_;
			}
			set
			{
				this.isAddEnergy_ = value;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x000C9AB1 File Offset: 0x000C7CB1
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x000C9AB9 File Offset: 0x000C7CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCounterAttack
		{
			get
			{
				return this.isCounterAttack_;
			}
			set
			{
				this.isCounterAttack_ = value;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x000C9AC2 File Offset: 0x000C7CC2
		// (set) Token: 0x060052C0 RID: 21184 RVA: 0x000C9ACA File Offset: 0x000C7CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ForceCritical
		{
			get
			{
				return this.forceCritical_;
			}
			set
			{
				this.forceCritical_ = value;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x060052C1 RID: 21185 RVA: 0x000C9AD3 File Offset: 0x000C7CD3
		// (set) Token: 0x060052C2 RID: 21186 RVA: 0x000C9ADB File Offset: 0x000C7CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBlocked
		{
			get
			{
				return this.isBlocked_;
			}
			set
			{
				this.isBlocked_ = value;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x060052C3 RID: 21187 RVA: 0x000C9AE4 File Offset: 0x000C7CE4
		// (set) Token: 0x060052C4 RID: 21188 RVA: 0x000C9AEC File Offset: 0x000C7CEC
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

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x060052C5 RID: 21189 RVA: 0x000C9AF5 File Offset: 0x000C7CF5
		// (set) Token: 0x060052C6 RID: 21190 RVA: 0x000C9AFD File Offset: 0x000C7CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CounterSkillMessageId
		{
			get
			{
				return this.counterSkillMessageId_;
			}
			set
			{
				this.counterSkillMessageId_ = value;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x060052C7 RID: 21191 RVA: 0x000C9B06 File Offset: 0x000C7D06
		// (set) Token: 0x060052C8 RID: 21192 RVA: 0x000C9B0E File Offset: 0x000C7D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageContext DamageContext
		{
			get
			{
				return this.damageContext_;
			}
			set
			{
				this.damageContext_ = value;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x060052C9 RID: 21193 RVA: 0x000C9B17 File Offset: 0x000C7D17
		// (set) Token: 0x060052CA RID: 21194 RVA: 0x000C9B1F File Offset: 0x000C7D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RandomSeed
		{
			get
			{
				return this.randomSeed_;
			}
			set
			{
				this.randomSeed_ = value;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x060052CB RID: 21195 RVA: 0x000C9B28 File Offset: 0x000C7D28
		// (set) Token: 0x060052CC RID: 21196 RVA: 0x000C9B30 File Offset: 0x000C7D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBreakWeakness
		{
			get
			{
				return this.isBreakWeakness_;
			}
			set
			{
				this.isBreakWeakness_ = value;
			}
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x000C9B39 File Offset: 0x000C7D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageExecuteRequest);
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x000C9B48 File Offset: 0x000C7D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageExecuteRequest other)
		{
			return other != null && (other == this || (this.DamageId == other.DamageId && this.SkillLevel == other.SkillLevel && this.AttackerEntityId == other.AttackerEntityId && this.TargetEntityId == other.TargetEntityId && this.IsAddEnergy == other.IsAddEnergy && this.IsCounterAttack == other.IsCounterAttack && this.ForceCritical == other.ForceCritical && this.IsBlocked == other.IsBlocked && this.PartId == other.PartId && this.CounterSkillMessageId == other.CounterSkillMessageId && object.Equals(this.DamageContext, other.DamageContext) && this.RandomSeed == other.RandomSeed && this.IsBreakWeakness == other.IsBreakWeakness && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x000C9C48 File Offset: 0x000C7E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DamageId != 0L)
			{
				num ^= this.DamageId.GetHashCode();
			}
			if (this.SkillLevel != 0)
			{
				num ^= this.SkillLevel.GetHashCode();
			}
			if (this.AttackerEntityId != 0L)
			{
				num ^= this.AttackerEntityId.GetHashCode();
			}
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.IsAddEnergy)
			{
				num ^= this.IsAddEnergy.GetHashCode();
			}
			if (this.IsCounterAttack)
			{
				num ^= this.IsCounterAttack.GetHashCode();
			}
			if (this.ForceCritical)
			{
				num ^= this.ForceCritical.GetHashCode();
			}
			if (this.IsBlocked)
			{
				num ^= this.IsBlocked.GetHashCode();
			}
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this.CounterSkillMessageId != 0L)
			{
				num ^= this.CounterSkillMessageId.GetHashCode();
			}
			if (this.damageContext_ != null)
			{
				num ^= this.DamageContext.GetHashCode();
			}
			if (this.RandomSeed != 0)
			{
				num ^= this.RandomSeed.GetHashCode();
			}
			if (this.IsBreakWeakness)
			{
				num ^= this.IsBreakWeakness.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x000C9DB0 File Offset: 0x000C7FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x000C9DBD File Offset: 0x000C7FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x000C9DC8 File Offset: 0x000C7FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.damageContext_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DamageContext);
			}
			if (this.IsBreakWeakness)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsBreakWeakness);
			}
			if (this.CounterSkillMessageId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CounterSkillMessageId);
			}
			if (this.AttackerEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.AttackerEntityId);
			}
			if (this.ForceCritical)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ForceCritical);
			}
			if (this.SkillLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillLevel);
			}
			if (this.PartId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PartId);
			}
			if (this.IsAddEnergy)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsAddEnergy);
			}
			if (this.IsBlocked)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsBlocked);
			}
			if (this.IsCounterAttack)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsCounterAttack);
			}
			if (this.DamageId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.DamageId);
			}
			if (this.RandomSeed != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RandomSeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x000C9F54 File Offset: 0x000C8154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DamageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DamageId);
			}
			if (this.SkillLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillLevel);
			}
			if (this.AttackerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AttackerEntityId);
			}
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this.IsAddEnergy)
			{
				num += 2;
			}
			if (this.IsCounterAttack)
			{
				num += 2;
			}
			if (this.ForceCritical)
			{
				num += 2;
			}
			if (this.IsBlocked)
			{
				num += 2;
			}
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this.CounterSkillMessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CounterSkillMessageId);
			}
			if (this.damageContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageContext);
			}
			if (this.RandomSeed != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RandomSeed);
			}
			if (this.IsBreakWeakness)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x000CA078 File Offset: 0x000C8278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DamageExecuteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DamageId != 0L)
			{
				this.DamageId = other.DamageId;
			}
			if (other.SkillLevel != 0)
			{
				this.SkillLevel = other.SkillLevel;
			}
			if (other.AttackerEntityId != 0L)
			{
				this.AttackerEntityId = other.AttackerEntityId;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.IsAddEnergy)
			{
				this.IsAddEnergy = other.IsAddEnergy;
			}
			if (other.IsCounterAttack)
			{
				this.IsCounterAttack = other.IsCounterAttack;
			}
			if (other.ForceCritical)
			{
				this.ForceCritical = other.ForceCritical;
			}
			if (other.IsBlocked)
			{
				this.IsBlocked = other.IsBlocked;
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			if (other.CounterSkillMessageId != 0L)
			{
				this.CounterSkillMessageId = other.CounterSkillMessageId;
			}
			if (other.damageContext_ != null)
			{
				if (this.damageContext_ == null)
				{
					this.DamageContext = new DamageContext();
				}
				this.DamageContext.MergeFrom(other.DamageContext);
			}
			if (other.RandomSeed != 0)
			{
				this.RandomSeed = other.RandomSeed;
			}
			if (other.IsBreakWeakness)
			{
				this.IsBreakWeakness = other.IsBreakWeakness;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x000CA1BC File Offset: 0x000C83BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x000CA1C8 File Offset: 0x000C83C8
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
							this.TargetEntityId = input.ReadInt64();
							continue;
						}
						if (num == 18U)
						{
							if (this.damageContext_ == null)
							{
								this.DamageContext = new DamageContext();
							}
							input.ReadMessage(this.DamageContext);
							continue;
						}
						if (num == 24U)
						{
							this.IsBreakWeakness = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.CounterSkillMessageId = input.ReadInt64();
							continue;
						}
						if (num == 40U)
						{
							this.AttackerEntityId = input.ReadInt64();
							continue;
						}
						if (num == 48U)
						{
							this.ForceCritical = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 56U)
					{
						this.SkillLevel = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.PartId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.IsAddEnergy = input.ReadBool();
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.IsBlocked = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.IsCounterAttack = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.DamageId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.RandomSeed = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003376 RID: 13174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003377 RID: 13175
		public const int DamageIdFieldNumber = 14;

		// Token: 0x04003378 RID: 13176
		private long damageId_;

		// Token: 0x04003379 RID: 13177
		public const int SkillLevelFieldNumber = 7;

		// Token: 0x0400337A RID: 13178
		private int skillLevel_;

		// Token: 0x0400337B RID: 13179
		public const int AttackerEntityIdFieldNumber = 5;

		// Token: 0x0400337C RID: 13180
		private long attackerEntityId_;

		// Token: 0x0400337D RID: 13181
		public const int TargetEntityIdFieldNumber = 1;

		// Token: 0x0400337E RID: 13182
		private long targetEntityId_;

		// Token: 0x0400337F RID: 13183
		public const int IsAddEnergyFieldNumber = 11;

		// Token: 0x04003380 RID: 13184
		private bool isAddEnergy_;

		// Token: 0x04003381 RID: 13185
		public const int IsCounterAttackFieldNumber = 13;

		// Token: 0x04003382 RID: 13186
		private bool isCounterAttack_;

		// Token: 0x04003383 RID: 13187
		public const int ForceCriticalFieldNumber = 6;

		// Token: 0x04003384 RID: 13188
		private bool forceCritical_;

		// Token: 0x04003385 RID: 13189
		public const int IsBlockedFieldNumber = 12;

		// Token: 0x04003386 RID: 13190
		private bool isBlocked_;

		// Token: 0x04003387 RID: 13191
		public const int PartIdFieldNumber = 10;

		// Token: 0x04003388 RID: 13192
		private int partId_;

		// Token: 0x04003389 RID: 13193
		public const int CounterSkillMessageIdFieldNumber = 4;

		// Token: 0x0400338A RID: 13194
		private long counterSkillMessageId_;

		// Token: 0x0400338B RID: 13195
		public const int DamageContextFieldNumber = 2;

		// Token: 0x0400338C RID: 13196
		private DamageContext damageContext_;

		// Token: 0x0400338D RID: 13197
		public const int RandomSeedFieldNumber = 15;

		// Token: 0x0400338E RID: 13198
		private int randomSeed_;

		// Token: 0x0400338F RID: 13199
		public const int IsBreakWeaknessFieldNumber = 3;

		// Token: 0x04003390 RID: 13200
		private bool isBreakWeakness_;
	}
}
