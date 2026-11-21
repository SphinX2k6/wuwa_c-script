using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000357 RID: 855
	public sealed class DangoBrawlFightActionInfo : IMessage<DangoBrawlFightActionInfo>, IMessage, IEquatable<DangoBrawlFightActionInfo>, IDeepCloneable<DangoBrawlFightActionInfo>, IBufferMessage
	{
		// Token: 0x06005592 RID: 21906 RVA: 0x000D0AF8 File Offset: 0x000CECF8
		[NullableContext(1)]
		public static DangoBrawlFightActionInfo Create()
		{
			return new DangoBrawlFightActionInfo();
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x000D0AFF File Offset: 0x000CECFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlFightActionInfo> Parser
		{
			get
			{
				return DangoBrawlFightActionInfo._parser;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06005594 RID: 21908 RVA: 0x000D0B06 File Offset: 0x000CED06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06005595 RID: 21909 RVA: 0x000D0B09 File Offset: 0x000CED09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionInfo.Descriptor;
			}
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x000D0B10 File Offset: 0x000CED10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInfo()
		{
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x000D0B18 File Offset: 0x000CED18
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

		// Token: 0x06005598 RID: 21912 RVA: 0x000D0CBD File Offset: 0x000CEEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInfo Clone()
		{
			return new DangoBrawlFightActionInfo(this);
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x000D0CC5 File Offset: 0x000CEEC5
		// (set) Token: 0x0600559A RID: 21914 RVA: 0x000D0CCD File Offset: 0x000CEECD
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

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x000D0CD6 File Offset: 0x000CEED6
		// (set) Token: 0x0600559C RID: 21916 RVA: 0x000D0CDE File Offset: 0x000CEEDE
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

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x0600559D RID: 21917 RVA: 0x000D0CE7 File Offset: 0x000CEEE7
		// (set) Token: 0x0600559E RID: 21918 RVA: 0x000D0CFF File Offset: 0x000CEEFF
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

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x0600559F RID: 21919 RVA: 0x000D0D15 File Offset: 0x000CEF15
		// (set) Token: 0x060055A0 RID: 21920 RVA: 0x000D0D2D File Offset: 0x000CEF2D
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

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x000D0D43 File Offset: 0x000CEF43
		// (set) Token: 0x060055A2 RID: 21922 RVA: 0x000D0D5B File Offset: 0x000CEF5B
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

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x000D0D71 File Offset: 0x000CEF71
		// (set) Token: 0x060055A4 RID: 21924 RVA: 0x000D0D89 File Offset: 0x000CEF89
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

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x060055A5 RID: 21925 RVA: 0x000D0D9F File Offset: 0x000CEF9F
		// (set) Token: 0x060055A6 RID: 21926 RVA: 0x000D0DB7 File Offset: 0x000CEFB7
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

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x060055A7 RID: 21927 RVA: 0x000D0DCD File Offset: 0x000CEFCD
		// (set) Token: 0x060055A8 RID: 21928 RVA: 0x000D0DE5 File Offset: 0x000CEFE5
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

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x060055A9 RID: 21929 RVA: 0x000D0DFB File Offset: 0x000CEFFB
		// (set) Token: 0x060055AA RID: 21930 RVA: 0x000D0E14 File Offset: 0x000CF014
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

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x060055AB RID: 21931 RVA: 0x000D0E2B File Offset: 0x000CF02B
		// (set) Token: 0x060055AC RID: 21932 RVA: 0x000D0E44 File Offset: 0x000CF044
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

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x060055AD RID: 21933 RVA: 0x000D0E5B File Offset: 0x000CF05B
		// (set) Token: 0x060055AE RID: 21934 RVA: 0x000D0E74 File Offset: 0x000CF074
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

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x060055AF RID: 21935 RVA: 0x000D0E8B File Offset: 0x000CF08B
		// (set) Token: 0x060055B0 RID: 21936 RVA: 0x000D0EA4 File Offset: 0x000CF0A4
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

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x060055B1 RID: 21937 RVA: 0x000D0EBB File Offset: 0x000CF0BB
		// (set) Token: 0x060055B2 RID: 21938 RVA: 0x000D0ED4 File Offset: 0x000CF0D4
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

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x060055B3 RID: 21939 RVA: 0x000D0EEB File Offset: 0x000CF0EB
		// (set) Token: 0x060055B4 RID: 21940 RVA: 0x000D0F04 File Offset: 0x000CF104
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

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x060055B5 RID: 21941 RVA: 0x000D0F1B File Offset: 0x000CF11B
		// (set) Token: 0x060055B6 RID: 21942 RVA: 0x000D0F34 File Offset: 0x000CF134
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

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x060055B7 RID: 21943 RVA: 0x000D0F4B File Offset: 0x000CF14B
		// (set) Token: 0x060055B8 RID: 21944 RVA: 0x000D0F64 File Offset: 0x000CF164
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

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x060055B9 RID: 21945 RVA: 0x000D0F7B File Offset: 0x000CF17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInfo.BodyOneofCase BodyCase
		{
			get
			{
				return this.bodyCase_;
			}
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x000D0F83 File Offset: 0x000CF183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBody()
		{
			this.bodyCase_ = DangoBrawlFightActionInfo.BodyOneofCase.None;
			this.body_ = null;
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x000D0F93 File Offset: 0x000CF193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionInfo);
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x000D0FA4 File Offset: 0x000CF1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionInfo other)
		{
			return other != null && (other == this || (this.TimeMs == other.TimeMs && this.ActionGroupUId == other.ActionGroupUId && object.Equals(this.SkillCast, other.SkillCast) && object.Equals(this.FatigueDamage, other.FatigueDamage) && object.Equals(this.BuffChange, other.BuffChange) && object.Equals(this.BuffRemove, other.BuffRemove) && object.Equals(this.AttrChange, other.AttrChange) && object.Equals(this.Death, other.Death) && object.Equals(this.BuffTick, other.BuffTick) && object.Equals(this.Heal, other.Heal) && object.Equals(this.ReflectDamage, other.ReflectDamage) && object.Equals(this.WeaponStop, other.WeaponStop) && object.Equals(this.ShieldAdd, other.ShieldAdd) && object.Equals(this.Lifesteal, other.Lifesteal) && object.Equals(this.EffectShow, other.EffectShow) && object.Equals(this.InitWeaponCd, other.InitWeaponCd) && this.BodyCase == other.BodyCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x000D1124 File Offset: 0x000CF324
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

		// Token: 0x060055BE RID: 21950 RVA: 0x000D12CF File Offset: 0x000CF4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x000D12DC File Offset: 0x000CF4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x000D12E8 File Offset: 0x000CF4E8
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

		// Token: 0x060055C1 RID: 21953 RVA: 0x000D14E4 File Offset: 0x000CF6E4
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

		// Token: 0x060055C2 RID: 21954 RVA: 0x000D16A0 File Offset: 0x000CF8A0
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

		// Token: 0x060055C3 RID: 21955 RVA: 0x000D196C File Offset: 0x000CFB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x000D1978 File Offset: 0x000CFB78
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

		// Token: 0x0400347A RID: 13434
		private static readonly MessageParser<DangoBrawlFightActionInfo> _parser = new MessageParser<DangoBrawlFightActionInfo>(() => new DangoBrawlFightActionInfo());

		// Token: 0x0400347B RID: 13435
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400347C RID: 13436
		public const int TimeMsFieldNumber = 1;

		// Token: 0x0400347D RID: 13437
		private int timeMs_;

		// Token: 0x0400347E RID: 13438
		public const int ActionGroupUIdFieldNumber = 2;

		// Token: 0x0400347F RID: 13439
		private int actionGroupUId_;

		// Token: 0x04003480 RID: 13440
		public const int SkillCastFieldNumber = 3;

		// Token: 0x04003481 RID: 13441
		public const int FatigueDamageFieldNumber = 4;

		// Token: 0x04003482 RID: 13442
		public const int BuffChangeFieldNumber = 5;

		// Token: 0x04003483 RID: 13443
		public const int BuffRemoveFieldNumber = 6;

		// Token: 0x04003484 RID: 13444
		public const int AttrChangeFieldNumber = 7;

		// Token: 0x04003485 RID: 13445
		public const int DeathFieldNumber = 8;

		// Token: 0x04003486 RID: 13446
		public const int BuffTickFieldNumber = 9;

		// Token: 0x04003487 RID: 13447
		public const int HealFieldNumber = 10;

		// Token: 0x04003488 RID: 13448
		public const int ReflectDamageFieldNumber = 11;

		// Token: 0x04003489 RID: 13449
		public const int WeaponStopFieldNumber = 12;

		// Token: 0x0400348A RID: 13450
		public const int ShieldAddFieldNumber = 13;

		// Token: 0x0400348B RID: 13451
		public const int LifestealFieldNumber = 14;

		// Token: 0x0400348C RID: 13452
		public const int EffectShowFieldNumber = 15;

		// Token: 0x0400348D RID: 13453
		public const int InitWeaponCdFieldNumber = 16;

		// Token: 0x0400348E RID: 13454
		private object body_;

		// Token: 0x0400348F RID: 13455
		private DangoBrawlFightActionInfo.BodyOneofCase bodyCase_;

		// Token: 0x020017BE RID: 6078
		public enum BodyOneofCase
		{
			// Token: 0x0400CAE0 RID: 51936
			None,
			// Token: 0x0400CAE1 RID: 51937
			SkillCast = 3,
			// Token: 0x0400CAE2 RID: 51938
			FatigueDamage,
			// Token: 0x0400CAE3 RID: 51939
			BuffChange,
			// Token: 0x0400CAE4 RID: 51940
			BuffRemove,
			// Token: 0x0400CAE5 RID: 51941
			AttrChange,
			// Token: 0x0400CAE6 RID: 51942
			Death,
			// Token: 0x0400CAE7 RID: 51943
			BuffTick,
			// Token: 0x0400CAE8 RID: 51944
			Heal,
			// Token: 0x0400CAE9 RID: 51945
			ReflectDamage,
			// Token: 0x0400CAEA RID: 51946
			WeaponStop,
			// Token: 0x0400CAEB RID: 51947
			ShieldAdd,
			// Token: 0x0400CAEC RID: 51948
			Lifesteal,
			// Token: 0x0400CAED RID: 51949
			EffectShow,
			// Token: 0x0400CAEE RID: 51950
			InitWeaponCd
		}
	}
}
