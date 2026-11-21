using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002443 RID: 9283
	public class SetSkillBtnEffect : ActionParams
	{
		// Token: 0x0600CA1F RID: 51743 RVA: 0x001CDC2C File Offset: 0x001CBE2C
		private SetSkillBtnEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetSkillBtnEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetSkillBtnEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetSkillBtnEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA20 RID: 51744 RVA: 0x001CDC64 File Offset: 0x001CBE64
		public static SetSkillBtnEffect Create([Nullable(2)] SetSkillBtnEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSkillBtnEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA21 RID: 51745 RVA: 0x001CDC77 File Offset: 0x001CBE77
		public static SetSkillBtnEffect CreateFromSetValue([Nullable(2)] SetSkillBtnEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetSkillBtnEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x001CDC8A File Offset: 0x001CBE8A
		public SetSkillBtnEffect_SetValue ToSetValue()
		{
			return new SetSkillBtnEffect_SetValue
			{
				SkillBtnType = this.SkillBtnType,
				SkillBtnEffectData = this.SkillBtnEffectData,
				Time = this.Time
			};
		}

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x0600CA23 RID: 51747 RVA: 0x001CDCB5 File Offset: 0x001CBEB5
		// (set) Token: 0x0600CA24 RID: 51748 RVA: 0x001CDCE0 File Offset: 0x001CBEE0
		public virtual ESkillButtonType SkillBtnType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillBtnType;
				}
				if (this.PocoInterface == null)
				{
					return (ESkillButtonType)0;
				}
				return this.PocoInterface.SkillBtnType;
			}
			set
			{
				this.GetOrCreatePoco().SkillBtnType = value;
			}
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0600CA25 RID: 51749 RVA: 0x001CDCF0 File Offset: 0x001CBEF0
		// (set) Token: 0x0600CA26 RID: 51750 RVA: 0x001CDD51 File Offset: 0x001CBF51
		public virtual IMusicBattleBtnEffect SkillBtnEffectData
		{
			get
			{
				if (this._SkillBtnEffectDataInited)
				{
					return this._SkillBtnEffectDataCache;
				}
				this._SkillBtnEffectDataInited = true;
				if (this.FbInstance != null)
				{
					this._SkillBtnEffectDataCache = IMusicBattleBtnEffect.Create(this.FbInstance.SkillBtnEffectData);
				}
				else
				{
					SetSkillBtnEffect_SetValue pocoInterface = this.PocoInterface;
					this._SkillBtnEffectDataCache = ((pocoInterface != null) ? pocoInterface.SkillBtnEffectData : null);
				}
				return this._SkillBtnEffectDataCache;
			}
			set
			{
				this.GetOrCreatePoco().SkillBtnEffectData = value;
				this._SkillBtnEffectDataInited = false;
			}
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0600CA27 RID: 51751 RVA: 0x001CDD66 File Offset: 0x001CBF66
		// (set) Token: 0x0600CA28 RID: 51752 RVA: 0x001CDD95 File Offset: 0x001CBF95
		public virtual float Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x040077E8 RID: 30696
		[Nullable(2)]
		protected new SetSkillBtnEffect FbInstance;

		// Token: 0x040077E9 RID: 30697
		[Nullable(2)]
		protected SetSkillBtnEffect_SetValue PocoInterface;

		// Token: 0x040077EA RID: 30698
		private IMusicBattleBtnEffect _SkillBtnEffectDataCache;

		// Token: 0x040077EB RID: 30699
		private bool _SkillBtnEffectDataInited;
	}
}
