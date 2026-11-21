using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA7 RID: 11687
	public class SetSkillBtnEffect : ActionParams
	{
		// Token: 0x0600FEA7 RID: 65191 RVA: 0x0024B9BC File Offset: 0x00249BBC
		public static SetSkillBtnEffect Create(ISetSkillBtnEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSkillBtnEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005007 RID: 20487
		// (get) Token: 0x0600FEA8 RID: 65192 RVA: 0x0024B9DB File Offset: 0x00249BDB
		public virtual ESkillButtonType SkillBtnType
		{
			get
			{
				return (ESkillButtonType)this.Instance.SkillBtnType;
			}
		}

		// Token: 0x17005008 RID: 20488
		// (get) Token: 0x0600FEA9 RID: 65193 RVA: 0x0024B9E8 File Offset: 0x00249BE8
		public virtual IMusicBattleBtnEffect SkillBtnEffectData
		{
			get
			{
				if (this._SkillBtnEffectDataInited)
				{
					return this._SkillBtnEffectDataCache;
				}
				this._SkillBtnEffectDataInited = true;
				this._SkillBtnEffectDataCache = IMusicBattleBtnEffect.Create(this.Instance.SkillBtnEffectData);
				return this._SkillBtnEffectDataCache;
			}
		}

		// Token: 0x17005009 RID: 20489
		// (get) Token: 0x0600FEAA RID: 65194 RVA: 0x0024BA1C File Offset: 0x00249C1C
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x04008B03 RID: 35587
		private ISetSkillBtnEffect Instance;

		// Token: 0x04008B04 RID: 35588
		[Nullable(2)]
		private IMusicBattleBtnEffect _SkillBtnEffectDataCache;

		// Token: 0x04008B05 RID: 35589
		private bool _SkillBtnEffectDataInited;
	}
}
