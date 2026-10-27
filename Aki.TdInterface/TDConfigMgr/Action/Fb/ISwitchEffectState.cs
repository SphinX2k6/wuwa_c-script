using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025EB RID: 9707
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchEffectState : PlayEffect2
	{
		// Token: 0x0600DA22 RID: 55842 RVA: 0x00208364 File Offset: 0x00206564
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

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x0600DA23 RID: 55843 RVA: 0x00208383 File Offset: 0x00206583
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x0600DA24 RID: 55844 RVA: 0x00208390 File Offset: 0x00206590
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x0600DA25 RID: 55845 RVA: 0x0020839D File Offset: 0x0020659D
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

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x0600DA26 RID: 55846 RVA: 0x002083CC File Offset: 0x002065CC
		public virtual int TargetStateIndex
		{
			get
			{
				return this.Instance.TargetStateIndex;
			}
		}

		// Token: 0x04007921 RID: 31009
		private ISwitchEffectState Instance;

		// Token: 0x04007922 RID: 31010
		private ISwitchEffectStateEffectBase _EffectTypeCache;

		// Token: 0x04007923 RID: 31011
		private bool _EffectTypeInited;
	}
}
