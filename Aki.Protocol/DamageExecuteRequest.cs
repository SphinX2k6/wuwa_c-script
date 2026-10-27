using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032F RID: 815
	[NetMessage(EMessageId.DamageExecuteRequest)]
	public sealed class DamageExecuteRequest : IMessage<DamageExecuteRequest>, IMessage, IEquatable<DamageExecuteRequest>, IDeepCloneable<DamageExecuteRequest>, IBufferMessage
	{
		// Token: 0x060051D4 RID: 20948 RVA: 0x000C757A File Offset: 0x000C577A
		[NullableContext(1)]
		public static DamageExecuteRequest Create()
		{
			return new DamageExecuteRequest();
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060051D5 RID: 20949 RVA: 0x000C7581 File Offset: 0x000C5781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x000C7584 File Offset: 0x000C5784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageExecuteRequest.Descriptor;
			}
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x000C758B File Offset: 0x000C578B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteRequest()
		{
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x000C7594 File Offset: 0x000C5794
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

		// Token: 0x060051D9 RID: 20953 RVA: 0x000C7664 File Offset: 0x000C5864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteRequest Clone()
		{
			return new DamageExecuteRequest(this);
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x000C766C File Offset: 0x000C586C
		// (set) Token: 0x060051DB RID: 20955 RVA: 0x000C7674 File Offset: 0x000C5874
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

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x000C767D File Offset: 0x000C587D
		// (set) Token: 0x060051DD RID: 20957 RVA: 0x000C7685 File Offset: 0x000C5885
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

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x060051DE RID: 20958 RVA: 0x000C768E File Offset: 0x000C588E
		// (set) Token: 0x060051DF RID: 20959 RVA: 0x000C7696 File Offset: 0x000C5896
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

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x000C769F File Offset: 0x000C589F
		// (set) Token: 0x060051E1 RID: 20961 RVA: 0x000C76A7 File Offset: 0x000C58A7
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

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x000C76B0 File Offset: 0x000C58B0
		// (set) Token: 0x060051E3 RID: 20963 RVA: 0x000C76B8 File Offset: 0x000C58B8
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x000C76C1 File Offset: 0x000C58C1
		// (set) Token: 0x060051E5 RID: 20965 RVA: 0x000C76C9 File Offset: 0x000C58C9
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

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x000C76D2 File Offset: 0x000C58D2
		// (set) Token: 0x060051E7 RID: 20967 RVA: 0x000C76DA File Offset: 0x000C58DA
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

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x060051E8 RID: 20968 RVA: 0x000C76E3 File Offset: 0x000C58E3
		// (set) Token: 0x060051E9 RID: 20969 RVA: 0x000C76EB File Offset: 0x000C58EB
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

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x000C76F4 File Offset: 0x000C58F4
		// (set) Token: 0x060051EB RID: 20971 RVA: 0x000C76FC File Offset: 0x000C58FC
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

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x000C7705 File Offset: 0x000C5905
		// (set) Token: 0x060051ED RID: 20973 RVA: 0x000C770D File Offset: 0x000C590D
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

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x000C7716 File Offset: 0x000C5916
		// (set) Token: 0x060051EF RID: 20975 RVA: 0x000C771E File Offset: 0x000C591E
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

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x000C7727 File Offset: 0x000C5927
		// (set) Token: 0x060051F1 RID: 20977 RVA: 0x000C772F File Offset: 0x000C592F
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

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x000C7738 File Offset: 0x000C5938
		// (set) Token: 0x060051F3 RID: 20979 RVA: 0x000C7740 File Offset: 0x000C5940
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

		// Token: 0x060051F4 RID: 20980 RVA: 0x000C7749 File Offset: 0x000C5949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageExecuteRequest);
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x000C7758 File Offset: 0x000C5958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageExecuteRequest other)
		{
			return other != null && (other == this || (this.DamageId == other.DamageId && this.SkillLevel == other.SkillLevel && this.AttackerEntityId == other.AttackerEntityId && this.TargetEntityId == other.TargetEntityId && this.IsAddEnergy == other.IsAddEnergy && this.IsCounterAttack == other.IsCounterAttack && this.ForceCritical == other.ForceCritical && this.IsBlocked == other.IsBlocked && this.PartId == other.PartId && this.CounterSkillMessageId == other.CounterSkillMessageId && object.Equals(this.DamageContext, other.DamageContext) && this.RandomSeed == other.RandomSeed && this.IsBreakWeakness == other.IsBreakWeakness && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x000C7858 File Offset: 0x000C5A58
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

		// Token: 0x060051F7 RID: 20983 RVA: 0x000C79C0 File Offset: 0x000C5BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x000C79CD File Offset: 0x000C5BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051F9 RID: 20985 RVA: 0x000C79D8 File Offset: 0x000C5BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsCounterAttack)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsCounterAttack);
			}
			if (this.ForceCritical)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ForceCritical);
			}
			if (this.CounterSkillMessageId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CounterSkillMessageId);
			}
			if (this.RandomSeed != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RandomSeed);
			}
			if (this.PartId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PartId);
			}
			if (this.IsAddEnergy)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsAddEnergy);
			}
			if (this.IsBlocked)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsBlocked);
			}
			if (this.IsBreakWeakness)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsBreakWeakness);
			}
			if (this.DamageId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.DamageId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.SkillLevel != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SkillLevel);
			}
			if (this.AttackerEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.AttackerEntityId);
			}
			if (this.damageContext_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.DamageContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x000C7B64 File Offset: 0x000C5D64
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

		// Token: 0x060051FB RID: 20987 RVA: 0x000C7C88 File Offset: 0x000C5E88
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

		// Token: 0x060051FC RID: 20988 RVA: 0x000C7DCC File Offset: 0x000C5FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x000C7DD8 File Offset: 0x000C5FD8
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
							this.IsCounterAttack = input.ReadBool();
							continue;
						}
						if (num == 16U)
						{
							this.ForceCritical = input.ReadBool();
							continue;
						}
						if (num == 24U)
						{
							this.CounterSkillMessageId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.RandomSeed = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.PartId = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.IsAddEnergy = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.IsBlocked = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.IsBreakWeakness = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.DamageId = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 80U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.SkillLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.AttackerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						if (this.damageContext_ == null)
						{
							this.DamageContext = new DamageContext();
						}
						input.ReadMessage(this.DamageContext);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032DF RID: 13023
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032E0 RID: 13024
		public const int DamageIdFieldNumber = 9;

		// Token: 0x040032E1 RID: 13025
		private long damageId_;

		// Token: 0x040032E2 RID: 13026
		public const int SkillLevelFieldNumber = 12;

		// Token: 0x040032E3 RID: 13027
		private int skillLevel_;

		// Token: 0x040032E4 RID: 13028
		public const int AttackerEntityIdFieldNumber = 13;

		// Token: 0x040032E5 RID: 13029
		private long attackerEntityId_;

		// Token: 0x040032E6 RID: 13030
		public const int TargetEntityIdFieldNumber = 10;

		// Token: 0x040032E7 RID: 13031
		private long targetEntityId_;

		// Token: 0x040032E8 RID: 13032
		public const int IsAddEnergyFieldNumber = 6;

		// Token: 0x040032E9 RID: 13033
		private bool isAddEnergy_;

		// Token: 0x040032EA RID: 13034
		public const int IsCounterAttackFieldNumber = 1;

		// Token: 0x040032EB RID: 13035
		private bool isCounterAttack_;

		// Token: 0x040032EC RID: 13036
		public const int ForceCriticalFieldNumber = 2;

		// Token: 0x040032ED RID: 13037
		private bool forceCritical_;

		// Token: 0x040032EE RID: 13038
		public const int IsBlockedFieldNumber = 7;

		// Token: 0x040032EF RID: 13039
		private bool isBlocked_;

		// Token: 0x040032F0 RID: 13040
		public const int PartIdFieldNumber = 5;

		// Token: 0x040032F1 RID: 13041
		private int partId_;

		// Token: 0x040032F2 RID: 13042
		public const int CounterSkillMessageIdFieldNumber = 3;

		// Token: 0x040032F3 RID: 13043
		private long counterSkillMessageId_;

		// Token: 0x040032F4 RID: 13044
		public const int DamageContextFieldNumber = 15;

		// Token: 0x040032F5 RID: 13045
		private DamageContext damageContext_;

		// Token: 0x040032F6 RID: 13046
		public const int RandomSeedFieldNumber = 4;

		// Token: 0x040032F7 RID: 13047
		private int randomSeed_;

		// Token: 0x040032F8 RID: 13048
		public const int IsBreakWeaknessFieldNumber = 8;

		// Token: 0x040032F9 RID: 13049
		private bool isBreakWeakness_;
	}
}
