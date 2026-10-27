using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D8 RID: 8664
	[NullableContext(1)]
	[Nullable(0)]
	public class SetSkillBtnEffect : ActionParams
	{
		// Token: 0x0600BE63 RID: 48739 RVA: 0x001B65A0 File Offset: 0x001B47A0
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

		// Token: 0x0600BE64 RID: 48740 RVA: 0x001B65D8 File Offset: 0x001B47D8
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

		// Token: 0x0600BE65 RID: 48741 RVA: 0x001B65EB File Offset: 0x001B47EB
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

		// Token: 0x0600BE66 RID: 48742 RVA: 0x001B65FE File Offset: 0x001B47FE
		public SetSkillBtnEffect_SetValue ToSetValue()
		{
			return new SetSkillBtnEffect_SetValue
			{
				SkillBtnType = this.SkillBtnType,
				SkillBtnEffectData = this.SkillBtnEffectData,
				Time = this.Time
			};
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0600BE67 RID: 48743 RVA: 0x001B6629 File Offset: 0x001B4829
		// (set) Token: 0x0600BE68 RID: 48744 RVA: 0x001B6654 File Offset: 0x001B4854
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

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0600BE69 RID: 48745 RVA: 0x001B6664 File Offset: 0x001B4864
		// (set) Token: 0x0600BE6A RID: 48746 RVA: 0x001B66C5 File Offset: 0x001B48C5
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

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0600BE6B RID: 48747 RVA: 0x001B66DA File Offset: 0x001B48DA
		// (set) Token: 0x0600BE6C RID: 48748 RVA: 0x001B6709 File Offset: 0x001B4909
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

		// Token: 0x0400719F RID: 29087
		[Nullable(2)]
		protected new SetSkillBtnEffect FbInstance;

		// Token: 0x040071A0 RID: 29088
		[Nullable(2)]
		protected SetSkillBtnEffect_SetValue PocoInterface;

		// Token: 0x040071A1 RID: 29089
		private IMusicBattleBtnEffect _SkillBtnEffectDataCache;

		// Token: 0x040071A2 RID: 29090
		private bool _SkillBtnEffectDataInited;
	}
}
