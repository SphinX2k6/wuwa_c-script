using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028AA RID: 10410
	public class ISwitchEffectState : PlayEffect2
	{
		// Token: 0x0600E7EB RID: 59371 RVA: 0x00224A50 File Offset: 0x00222C50
		public static ISwitchEffectState Create(ISwitchEffectState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchEffectState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x0600E7EC RID: 59372 RVA: 0x00224A6F File Offset: 0x00222C6F
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x0600E7ED RID: 59373 RVA: 0x00224A7C File Offset: 0x00222C7C
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x0600E7EE RID: 59374 RVA: 0x00224A89 File Offset: 0x00222C89
		public virtual ISwitchEffectStateEffectBase EffectType
		{
			get
			{
				if (this._EffectTypeInited)
				{
					return this._EffectTypeCache;
				}
				this._EffectTypeInited = true;
				this._EffectTypeCache = ActionReadHelper.ReadISwitchEffectState_EffectType(this.Instance);
				return this._EffectTypeCache;
			}
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x0600E7EF RID: 59375 RVA: 0x00224AB8 File Offset: 0x00222CB8
		public virtual int TargetStateIndex
		{
			get
			{
				return this.Instance.TargetStateIndex;
			}
		}

		// Token: 0x04007FB8 RID: 32696
		private ISwitchEffectState Instance;

		// Token: 0x04007FB9 RID: 32697
		private ISwitchEffectStateEffectBase _EffectTypeCache;

		// Token: 0x04007FBA RID: 32698
		private bool _EffectTypeInited;
	}
}
