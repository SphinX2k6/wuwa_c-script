using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E3 RID: 10211
	public class ITalkEffectPlay : ITalkEffectActionType
	{
		// Token: 0x0600E1CB RID: 57803 RVA: 0x00212BC2 File Offset: 0x00210DC2
		public static ITalkEffectPlay Create(ITalkEffectPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x0600E1CC RID: 57804 RVA: 0x00212BE1 File Offset: 0x00210DE1
		public override ETalkEffectActionType Type
		{
			get
			{
				return (ETalkEffectActionType)this.Instance.Type;
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x0600E1CD RID: 57805 RVA: 0x00212BEE File Offset: 0x00210DEE
		public virtual ITalkCommonEffect Effect
		{
			get
			{
				if (this._EffectInited)
				{
					return this._EffectCache;
				}
				this._EffectInited = true;
				this._EffectCache = ITalkCommonEffect.Create(this.Instance.Effect);
				return this._EffectCache;
			}
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x0600E1CE RID: 57806 RVA: 0x00212C24 File Offset: 0x00210E24
		public virtual bool? KeepPlay
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepPlay);
			}
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x0600E1CF RID: 57807 RVA: 0x00212C5A File Offset: 0x00210E5A
		[Nullable(2)]
		public virtual string EffectKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.EffectKey;
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x0600E1D0 RID: 57808 RVA: 0x00212C68 File Offset: 0x00210E68
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x04007AAF RID: 31407
		private ITalkEffectPlay Instance;

		// Token: 0x04007AB0 RID: 31408
		[Nullable(2)]
		private ITalkCommonEffect _EffectCache;

		// Token: 0x04007AB1 RID: 31409
		private bool _EffectInited;
	}
}
