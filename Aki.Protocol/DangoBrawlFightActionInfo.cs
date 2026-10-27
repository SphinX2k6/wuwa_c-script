using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034F RID: 847
	public sealed class DangoBrawlFightActionInfo : IMessage<DangoBrawlFightActionInfo>, IMessage, IEquatable<DangoBrawlFightActionInfo>, IDeepCloneable<DangoBrawlFightActionInfo>, IBufferMessage
	{
		// Token: 0x060054A5 RID: 21669 RVA: 0x000CE46C File Offset: 0x000CC66C
		[NullableContext(1)]
		public static DangoBrawlFightActionInfo Create()
		{
			return new DangoBrawlFightActionInfo();
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x000CE473 File Offset: 0x000CC673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlFightActionInfo> Parser
		{
			get
			{
				return DangoBrawlFightActionInfo._parser;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x000CE47A File Offset: 0x000CC67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x000CE47D File Offset: 0x000CC67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionInfo.Descriptor;
			}
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x000CE484 File Offset: 0x000CC684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInfo()
		{
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x000CE48C File Offset: 0x000CC68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInfo(DangoBrawlFightActionInfo other) : this()
		{
			this.timeMs_ = other.timeMs_;
			this.actionGroupUId_ = other.actionGroupUId_;
			switch (other.BodyCase)
			{
			case DangoBrawlFightActionInfo.BodyOneofCase.SkillCast:
				this.SkillCast = other.SkillCast.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.FatigueDamage:
				this.FatigueDamage = other.FatigueDamage.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.BuffChange:
				this.BuffChange = other.BuffChange.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.BuffRemove:
				this.BuffRemove = other.BuffRemove.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.AttrChange:
				this.AttrChange = other.AttrChange.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.Death:
				this.Death = other.Death.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.BuffTick:
				this.BuffTick = other.BuffTick.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.Heal:
				this.Heal = other.Heal.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.ReflectDamage:
				this.ReflectDamage = other.ReflectDamage.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.WeaponStop:
				this.WeaponStop = other.WeaponStop.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.ShieldAdd:
				this.ShieldAdd = other.ShieldAdd.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.Lifesteal:
				this.Lifesteal = other.Lifesteal.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.EffectShow:
				this.EffectShow = other.EffectShow.Clone();
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.InitWeaponCd:
				this.InitWeaponCd = other.InitWeaponCd.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x000CE631 File Offset: 0x000CC831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInfo Clone()
		{
			return new DangoBrawlFightActionInfo(this);
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x000CE639 File Offset: 0x000CC839
		// (set) Token: 0x060054AD RID: 21677 RVA: 0x000CE641 File Offset: 0x000CC841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeMs
		{
			get
			{
				return this.timeMs_;
			}
			set
			{
				this.timeMs_ = value;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x000CE64A File Offset: 0x000CC84A
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x000CE652 File Offset: 0x000CC852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionGroupUId
		{
			get
			{
				return this.actionGroupUId_;
			}
			set
			{
				this.actionGroupUId_ = value;
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x000CE65B File Offset: 0x000CC85B
		// (set) Token: 0x060054B1 RID: 21681 RVA: 0x000CE673 File Offset: 0x000CC873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionSkillCastInfo SkillCast
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.SkillCast)
				{
					return null;
				}
				return (DangoBrawlFightActionSkillCastInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.SkillCast);
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x060054B2 RID: 21682 RVA: 0x000CE689 File Offset: 0x000CC889
		// (set) Token: 0x060054B3 RID: 21683 RVA: 0x000CE6A1 File Offset: 0x000CC8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionFatigueDamageInfo FatigueDamage
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.FatigueDamage)
				{
					return null;
				}
				return (DangoBrawlFightActionFatigueDamageInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.FatigueDamage);
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x000CE6B7 File Offset: 0x000CC8B7
		// (set) Token: 0x060054B5 RID: 21685 RVA: 0x000CE6CF File Offset: 0x000CC8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffChangeInfo BuffChange
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.BuffChange)
				{
					return null;
				}
				return (DangoBrawlFightActionBuffChangeInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.BuffChange);
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x000CE6E5 File Offset: 0x000CC8E5
		// (set) Token: 0x060054B7 RID: 21687 RVA: 0x000CE6FD File Offset: 0x000CC8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffRemoveInfo BuffRemove
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.BuffRemove)
				{
					return null;
				}
				return (DangoBrawlFightActionBuffRemoveInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.BuffRemove);
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x000CE713 File Offset: 0x000CC913
		// (set) Token: 0x060054B9 RID: 21689 RVA: 0x000CE72B File Offset: 0x000CC92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionAttrChangeInfo AttrChange
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.AttrChange)
				{
					return null;
				}
				return (DangoBrawlFightActionAttrChangeInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.AttrChange);
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x060054BA RID: 21690 RVA: 0x000CE741 File Offset: 0x000CC941
		// (set) Token: 0x060054BB RID: 21691 RVA: 0x000CE759 File Offset: 0x000CC959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionDeathInfo Death
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.Death)
				{
					return null;
				}
				return (DangoBrawlFightActionDeathInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.Death);
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x060054BC RID: 21692 RVA: 0x000CE76F File Offset: 0x000CC96F
		// (set) Token: 0x060054BD RID: 21693 RVA: 0x000CE788 File Offset: 0x000CC988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffTickInfo BuffTick
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.BuffTick)
				{
					return null;
				}
				return (DangoBrawlFightActionBuffTickInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.BuffTick);
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x060054BE RID: 21694 RVA: 0x000CE79F File Offset: 0x000CC99F
		// (set) Token: 0x060054BF RID: 21695 RVA: 0x000CE7B8 File Offset: 0x000CC9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionHealInfo Heal
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.Heal)
				{
					return null;
				}
				return (DangoBrawlFightActionHealInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.Heal);
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x060054C0 RID: 21696 RVA: 0x000CE7CF File Offset: 0x000CC9CF
		// (set) Token: 0x060054C1 RID: 21697 RVA: 0x000CE7E8 File Offset: 0x000CC9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionReflectDamageInfo ReflectDamage
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.ReflectDamage)
				{
					return null;
				}
				return (DangoBrawlFightActionReflectDamageInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.ReflectDamage);
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x000CE7FF File Offset: 0x000CC9FF
		// (set) Token: 0x060054C3 RID: 21699 RVA: 0x000CE818 File Offset: 0x000CCA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionWeaponStopInfo WeaponStop
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.WeaponStop)
				{
					return null;
				}
				return (DangoBrawlFightActionWeaponStopInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.WeaponStop);
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x060054C4 RID: 21700 RVA: 0x000CE82F File Offset: 0x000CCA2F
		// (set) Token: 0x060054C5 RID: 21701 RVA: 0x000CE848 File Offset: 0x000CCA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionShieldAddInfo ShieldAdd
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.ShieldAdd)
				{
					return null;
				}
				return (DangoBrawlFightActionShieldAddInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.ShieldAdd);
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x000CE85F File Offset: 0x000CCA5F
		// (set) Token: 0x060054C7 RID: 21703 RVA: 0x000CE878 File Offset: 0x000CCA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionLifestealInfo Lifesteal
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.Lifesteal)
				{
					return null;
				}
				return (DangoBrawlFightActionLifestealInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.Lifesteal);
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x060054C8 RID: 21704 RVA: 0x000CE88F File Offset: 0x000CCA8F
		// (set) Token: 0x060054C9 RID: 21705 RVA: 0x000CE8A8 File Offset: 0x000CCAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionEffectShowInfo EffectShow
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.EffectShow)
				{
					return null;
				}
				return (DangoBrawlFightActionEffectShowInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.EffectShow);
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x000CE8BF File Offset: 0x000CCABF
		// (set) Token: 0x060054CB RID: 21707 RVA: 0x000CE8D8 File Offset: 0x000CCAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInitWeaponCdInfo InitWeaponCd
		{
			get
			{
				if (this.bodyCase_ != DangoBrawlFightActionInfo.BodyOneofCase.InitWeaponCd)
				{
					return null;
				}
				return (DangoBrawlFightActionInitWeaponCdInfo)this.body_;
			}
			set
			{
				this.body_ = value;
				this.bodyCase_ = ((value == null) ? DangoBrawlFightActionInfo.BodyOneofCase.None : DangoBrawlFightActionInfo.BodyOneofCase.InitWeaponCd);
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x000CE8EF File Offset: 0x000CCAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInfo.BodyOneofCase BodyCase
		{
			get
			{
				return this.bodyCase_;
			}
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x000CE8F7 File Offset: 0x000CCAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBody()
		{
			this.bodyCase_ = DangoBrawlFightActionInfo.BodyOneofCase.None;
			this.body_ = null;
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x000CE907 File Offset: 0x000CCB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionInfo);
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x000CE918 File Offset: 0x000CCB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionInfo other)
		{
			return other != null && (other == this || (this.TimeMs == other.TimeMs && this.ActionGroupUId == other.ActionGroupUId && object.Equals(this.SkillCast, other.SkillCast) && object.Equals(this.FatigueDamage, other.FatigueDamage) && object.Equals(this.BuffChange, other.BuffChange) && object.Equals(this.BuffRemove, other.BuffRemove) && object.Equals(this.AttrChange, other.AttrChange) && object.Equals(this.Death, other.Death) && object.Equals(this.BuffTick, other.BuffTick) && object.Equals(this.Heal, other.Heal) && object.Equals(this.ReflectDamage, other.ReflectDamage) && object.Equals(this.WeaponStop, other.WeaponStop) && object.Equals(this.ShieldAdd, other.ShieldAdd) && object.Equals(this.Lifesteal, other.Lifesteal) && object.Equals(this.EffectShow, other.EffectShow) && object.Equals(this.InitWeaponCd, other.InitWeaponCd) && this.BodyCase == other.BodyCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x000CEA98 File Offset: 0x000CCC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimeMs != 0)
			{
				num ^= this.TimeMs.GetHashCode();
			}
			if (this.ActionGroupUId != 0)
			{
				num ^= this.ActionGroupUId.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.SkillCast)
			{
				num ^= this.SkillCast.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.FatigueDamage)
			{
				num ^= this.FatigueDamage.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffChange)
			{
				num ^= this.BuffChange.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffRemove)
			{
				num ^= this.BuffRemove.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.AttrChange)
			{
				num ^= this.AttrChange.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Death)
			{
				num ^= this.Death.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffTick)
			{
				num ^= this.BuffTick.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Heal)
			{
				num ^= this.Heal.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.ReflectDamage)
			{
				num ^= this.ReflectDamage.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.WeaponStop)
			{
				num ^= this.WeaponStop.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.ShieldAdd)
			{
				num ^= this.ShieldAdd.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Lifesteal)
			{
				num ^= this.Lifesteal.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.EffectShow)
			{
				num ^= this.EffectShow.GetHashCode();
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.InitWeaponCd)
			{
				num ^= this.InitWeaponCd.GetHashCode();
			}
			num ^= (int)this.bodyCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x000CEC43 File Offset: 0x000CCE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x000CEC50 File Offset: 0x000CCE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x000CEC5C File Offset: 0x000CCE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeMs != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TimeMs);
			}
			if (this.ActionGroupUId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActionGroupUId);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.SkillCast)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SkillCast);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.FatigueDamage)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.FatigueDamage);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffChange)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.BuffChange);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffRemove)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.BuffRemove);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.AttrChange)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.AttrChange);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Death)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Death);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffTick)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.BuffTick);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Heal)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Heal);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.ReflectDamage)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ReflectDamage);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.WeaponStop)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.WeaponStop);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.ShieldAdd)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ShieldAdd);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Lifesteal)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Lifesteal);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.EffectShow)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.EffectShow);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.InitWeaponCd)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.InitWeaponCd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x000CEE58 File Offset: 0x000CD058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimeMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeMs);
			}
			if (this.ActionGroupUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionGroupUId);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.SkillCast)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillCast);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.FatigueDamage)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FatigueDamage);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffChange)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffChange);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffRemove)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffRemove);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.AttrChange)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttrChange);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Death)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Death);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffTick)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffTick);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Heal)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Heal);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.ReflectDamage)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReflectDamage);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.WeaponStop)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WeaponStop);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.ShieldAdd)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShieldAdd);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Lifesteal)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lifesteal);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.EffectShow)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EffectShow);
			}
			if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.InitWeaponCd)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InitWeaponCd);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x000CF014 File Offset: 0x000CD214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimeMs != 0)
			{
				this.TimeMs = other.TimeMs;
			}
			if (other.ActionGroupUId != 0)
			{
				this.ActionGroupUId = other.ActionGroupUId;
			}
			switch (other.BodyCase)
			{
			case DangoBrawlFightActionInfo.BodyOneofCase.SkillCast:
				if (this.SkillCast == null)
				{
					this.SkillCast = new DangoBrawlFightActionSkillCastInfo();
				}
				this.SkillCast.MergeFrom(other.SkillCast);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.FatigueDamage:
				if (this.FatigueDamage == null)
				{
					this.FatigueDamage = new DangoBrawlFightActionFatigueDamageInfo();
				}
				this.FatigueDamage.MergeFrom(other.FatigueDamage);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.BuffChange:
				if (this.BuffChange == null)
				{
					this.BuffChange = new DangoBrawlFightActionBuffChangeInfo();
				}
				this.BuffChange.MergeFrom(other.BuffChange);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.BuffRemove:
				if (this.BuffRemove == null)
				{
					this.BuffRemove = new DangoBrawlFightActionBuffRemoveInfo();
				}
				this.BuffRemove.MergeFrom(other.BuffRemove);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.AttrChange:
				if (this.AttrChange == null)
				{
					this.AttrChange = new DangoBrawlFightActionAttrChangeInfo();
				}
				this.AttrChange.MergeFrom(other.AttrChange);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.Death:
				if (this.Death == null)
				{
					this.Death = new DangoBrawlFightActionDeathInfo();
				}
				this.Death.MergeFrom(other.Death);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.BuffTick:
				if (this.BuffTick == null)
				{
					this.BuffTick = new DangoBrawlFightActionBuffTickInfo();
				}
				this.BuffTick.MergeFrom(other.BuffTick);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.Heal:
				if (this.Heal == null)
				{
					this.Heal = new DangoBrawlFightActionHealInfo();
				}
				this.Heal.MergeFrom(other.Heal);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.ReflectDamage:
				if (this.ReflectDamage == null)
				{
					this.ReflectDamage = new DangoBrawlFightActionReflectDamageInfo();
				}
				this.ReflectDamage.MergeFrom(other.ReflectDamage);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.WeaponStop:
				if (this.WeaponStop == null)
				{
					this.WeaponStop = new DangoBrawlFightActionWeaponStopInfo();
				}
				this.WeaponStop.MergeFrom(other.WeaponStop);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.ShieldAdd:
				if (this.ShieldAdd == null)
				{
					this.ShieldAdd = new DangoBrawlFightActionShieldAddInfo();
				}
				this.ShieldAdd.MergeFrom(other.ShieldAdd);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.Lifesteal:
				if (this.Lifesteal == null)
				{
					this.Lifesteal = new DangoBrawlFightActionLifestealInfo();
				}
				this.Lifesteal.MergeFrom(other.Lifesteal);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.EffectShow:
				if (this.EffectShow == null)
				{
					this.EffectShow = new DangoBrawlFightActionEffectShowInfo();
				}
				this.EffectShow.MergeFrom(other.EffectShow);
				break;
			case DangoBrawlFightActionInfo.BodyOneofCase.InitWeaponCd:
				if (this.InitWeaponCd == null)
				{
					this.InitWeaponCd = new DangoBrawlFightActionInitWeaponCdInfo();
				}
				this.InitWeaponCd.MergeFrom(other.InitWeaponCd);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x000CF2E0 File Offset: 0x000CD4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x000CF2EC File Offset: 0x000CD4EC
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
				if (num <= 66U)
				{
					if (num <= 34U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.TimeMs = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.ActionGroupUId = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								DangoBrawlFightActionSkillCastInfo dangoBrawlFightActionSkillCastInfo = new DangoBrawlFightActionSkillCastInfo();
								if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.SkillCast)
								{
									dangoBrawlFightActionSkillCastInfo.MergeFrom(this.SkillCast);
								}
								input.ReadMessage(dangoBrawlFightActionSkillCastInfo);
								this.SkillCast = dangoBrawlFightActionSkillCastInfo;
								continue;
							}
							if (num == 34U)
							{
								DangoBrawlFightActionFatigueDamageInfo dangoBrawlFightActionFatigueDamageInfo = new DangoBrawlFightActionFatigueDamageInfo();
								if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.FatigueDamage)
								{
									dangoBrawlFightActionFatigueDamageInfo.MergeFrom(this.FatigueDamage);
								}
								input.ReadMessage(dangoBrawlFightActionFatigueDamageInfo);
								this.FatigueDamage = dangoBrawlFightActionFatigueDamageInfo;
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 42U)
						{
							DangoBrawlFightActionBuffChangeInfo dangoBrawlFightActionBuffChangeInfo = new DangoBrawlFightActionBuffChangeInfo();
							if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffChange)
							{
								dangoBrawlFightActionBuffChangeInfo.MergeFrom(this.BuffChange);
							}
							input.ReadMessage(dangoBrawlFightActionBuffChangeInfo);
							this.BuffChange = dangoBrawlFightActionBuffChangeInfo;
							continue;
						}
						if (num == 50U)
						{
							DangoBrawlFightActionBuffRemoveInfo dangoBrawlFightActionBuffRemoveInfo = new DangoBrawlFightActionBuffRemoveInfo();
							if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffRemove)
							{
								dangoBrawlFightActionBuffRemoveInfo.MergeFrom(this.BuffRemove);
							}
							input.ReadMessage(dangoBrawlFightActionBuffRemoveInfo);
							this.BuffRemove = dangoBrawlFightActionBuffRemoveInfo;
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							DangoBrawlFightActionAttrChangeInfo dangoBrawlFightActionAttrChangeInfo = new DangoBrawlFightActionAttrChangeInfo();
							if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.AttrChange)
							{
								dangoBrawlFightActionAttrChangeInfo.MergeFrom(this.AttrChange);
							}
							input.ReadMessage(dangoBrawlFightActionAttrChangeInfo);
							this.AttrChange = dangoBrawlFightActionAttrChangeInfo;
							continue;
						}
						if (num == 66U)
						{
							DangoBrawlFightActionDeathInfo dangoBrawlFightActionDeathInfo = new DangoBrawlFightActionDeathInfo();
							if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Death)
							{
								dangoBrawlFightActionDeathInfo.MergeFrom(this.Death);
							}
							input.ReadMessage(dangoBrawlFightActionDeathInfo);
							this.Death = dangoBrawlFightActionDeathInfo;
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num <= 82U)
					{
						if (num == 74U)
						{
							DangoBrawlFightActionBuffTickInfo dangoBrawlFightActionBuffTickInfo = new DangoBrawlFightActionBuffTickInfo();
							if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.BuffTick)
							{
								dangoBrawlFightActionBuffTickInfo.MergeFrom(this.BuffTick);
							}
							input.ReadMessage(dangoBrawlFightActionBuffTickInfo);
							this.BuffTick = dangoBrawlFightActionBuffTickInfo;
							continue;
						}
						if (num == 82U)
						{
							DangoBrawlFightActionHealInfo dangoBrawlFightActionHealInfo = new DangoBrawlFightActionHealInfo();
							if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Heal)
							{
								dangoBrawlFightActionHealInfo.MergeFrom(this.Heal);
							}
							input.ReadMessage(dangoBrawlFightActionHealInfo);
							this.Heal = dangoBrawlFightActionHealInfo;
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							DangoBrawlFightActionReflectDamageInfo dangoBrawlFightActionReflectDamageInfo = new DangoBrawlFightActionReflectDamageInfo();
							if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.ReflectDamage)
							{
								dangoBrawlFightActionReflectDamageInfo.MergeFrom(this.ReflectDamage);
							}
							input.ReadMessage(dangoBrawlFightActionReflectDamageInfo);
							this.ReflectDamage = dangoBrawlFightActionReflectDamageInfo;
							continue;
						}
						if (num == 98U)
						{
							DangoBrawlFightActionWeaponStopInfo dangoBrawlFightActionWeaponStopInfo = new DangoBrawlFightActionWeaponStopInfo();
							if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.WeaponStop)
							{
								dangoBrawlFightActionWeaponStopInfo.MergeFrom(this.WeaponStop);
							}
							input.ReadMessage(dangoBrawlFightActionWeaponStopInfo);
							this.WeaponStop = dangoBrawlFightActionWeaponStopInfo;
							continue;
						}
					}
				}
				else if (num <= 114U)
				{
					if (num == 106U)
					{
						DangoBrawlFightActionShieldAddInfo dangoBrawlFightActionShieldAddInfo = new DangoBrawlFightActionShieldAddInfo();
						if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.ShieldAdd)
						{
							dangoBrawlFightActionShieldAddInfo.MergeFrom(this.ShieldAdd);
						}
						input.ReadMessage(dangoBrawlFightActionShieldAddInfo);
						this.ShieldAdd = dangoBrawlFightActionShieldAddInfo;
						continue;
					}
					if (num == 114U)
					{
						DangoBrawlFightActionLifestealInfo dangoBrawlFightActionLifestealInfo = new DangoBrawlFightActionLifestealInfo();
						if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.Lifesteal)
						{
							dangoBrawlFightActionLifestealInfo.MergeFrom(this.Lifesteal);
						}
						input.ReadMessage(dangoBrawlFightActionLifestealInfo);
						this.Lifesteal = dangoBrawlFightActionLifestealInfo;
						continue;
					}
				}
				else
				{
					if (num == 122U)
					{
						DangoBrawlFightActionEffectShowInfo dangoBrawlFightActionEffectShowInfo = new DangoBrawlFightActionEffectShowInfo();
						if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.EffectShow)
						{
							dangoBrawlFightActionEffectShowInfo.MergeFrom(this.EffectShow);
						}
						input.ReadMessage(dangoBrawlFightActionEffectShowInfo);
						this.EffectShow = dangoBrawlFightActionEffectShowInfo;
						continue;
					}
					if (num == 130U)
					{
						DangoBrawlFightActionInitWeaponCdInfo dangoBrawlFightActionInitWeaponCdInfo = new DangoBrawlFightActionInitWeaponCdInfo();
						if (this.bodyCase_ == DangoBrawlFightActionInfo.BodyOneofCase.InitWeaponCd)
						{
							dangoBrawlFightActionInitWeaponCdInfo.MergeFrom(this.InitWeaponCd);
						}
						input.ReadMessage(dangoBrawlFightActionInitWeaponCdInfo);
						this.InitWeaponCd = dangoBrawlFightActionInitWeaponCdInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040033DE RID: 13278
		private static readonly MessageParser<DangoBrawlFightActionInfo> _parser = new MessageParser<DangoBrawlFightActionInfo>(() => new DangoBrawlFightActionInfo());

		// Token: 0x040033DF RID: 13279
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033E0 RID: 13280
		public const int TimeMsFieldNumber = 1;

		// Token: 0x040033E1 RID: 13281
		private int timeMs_;

		// Token: 0x040033E2 RID: 13282
		public const int ActionGroupUIdFieldNumber = 2;

		// Token: 0x040033E3 RID: 13283
		private int actionGroupUId_;

		// Token: 0x040033E4 RID: 13284
		public const int SkillCastFieldNumber = 3;

		// Token: 0x040033E5 RID: 13285
		public const int FatigueDamageFieldNumber = 4;

		// Token: 0x040033E6 RID: 13286
		public const int BuffChangeFieldNumber = 5;

		// Token: 0x040033E7 RID: 13287
		public const int BuffRemoveFieldNumber = 6;

		// Token: 0x040033E8 RID: 13288
		public const int AttrChangeFieldNumber = 7;

		// Token: 0x040033E9 RID: 13289
		public const int DeathFieldNumber = 8;

		// Token: 0x040033EA RID: 13290
		public const int BuffTickFieldNumber = 9;

		// Token: 0x040033EB RID: 13291
		public const int HealFieldNumber = 10;

		// Token: 0x040033EC RID: 13292
		public const int ReflectDamageFieldNumber = 11;

		// Token: 0x040033ED RID: 13293
		public const int WeaponStopFieldNumber = 12;

		// Token: 0x040033EE RID: 13294
		public const int ShieldAddFieldNumber = 13;

		// Token: 0x040033EF RID: 13295
		public const int LifestealFieldNumber = 14;

		// Token: 0x040033F0 RID: 13296
		public const int EffectShowFieldNumber = 15;

		// Token: 0x040033F1 RID: 13297
		public const int InitWeaponCdFieldNumber = 16;

		// Token: 0x040033F2 RID: 13298
		private object body_;

		// Token: 0x040033F3 RID: 13299
		private DangoBrawlFightActionInfo.BodyOneofCase bodyCase_;

		// Token: 0x02001740 RID: 5952
		public enum BodyOneofCase
		{
			// Token: 0x0400C5AA RID: 50602
			None,
			// Token: 0x0400C5AB RID: 50603
			SkillCast = 3,
			// Token: 0x0400C5AC RID: 50604
			FatigueDamage,
			// Token: 0x0400C5AD RID: 50605
			BuffChange,
			// Token: 0x0400C5AE RID: 50606
			BuffRemove,
			// Token: 0x0400C5AF RID: 50607
			AttrChange,
			// Token: 0x0400C5B0 RID: 50608
			Death,
			// Token: 0x0400C5B1 RID: 50609
			BuffTick,
			// Token: 0x0400C5B2 RID: 50610
			Heal,
			// Token: 0x0400C5B3 RID: 50611
			ReflectDamage,
			// Token: 0x0400C5B4 RID: 50612
			WeaponStop,
			// Token: 0x0400C5B5 RID: 50613
			ShieldAdd,
			// Token: 0x0400C5B6 RID: 50614
			Lifesteal,
			// Token: 0x0400C5B7 RID: 50615
			EffectShow,
			// Token: 0x0400C5B8 RID: 50616
			InitWeaponCd
		}
	}
}
