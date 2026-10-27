using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB3 RID: 10931
	[NullableContext(1)]
	[Nullable(0)]
	public class SetSkillBtnEffect : ActionParams
	{
		// Token: 0x0600EFF1 RID: 61425 RVA: 0x0022DCB0 File Offset: 0x0022BEB0
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

		// Token: 0x17004C4D RID: 19533
		// (get) Token: 0x0600EFF2 RID: 61426 RVA: 0x0022DCCF File Offset: 0x0022BECF
		public virtual ESkillButtonType SkillBtnType
		{
			get
			{
				return (ESkillButtonType)this.Instance.SkillBtnType;
			}
		}

		// Token: 0x17004C4E RID: 19534
		// (get) Token: 0x0600EFF3 RID: 61427 RVA: 0x0022DCDC File Offset: 0x0022BEDC
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

		// Token: 0x17004C4F RID: 19535
		// (get) Token: 0x0600EFF4 RID: 61428 RVA: 0x0022DD10 File Offset: 0x0022BF10
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x040083FF RID: 33791
		private ISetSkillBtnEffect Instance;

		// Token: 0x04008400 RID: 33792
		[Nullable(2)]
		private IMusicBattleBtnEffect _SkillBtnEffectDataCache;

		// Token: 0x04008401 RID: 33793
		private bool _SkillBtnEffectDataInited;
	}
}
