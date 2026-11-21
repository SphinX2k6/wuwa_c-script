using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DF RID: 10207
	public class IActorVisibility
	{
		// Token: 0x0600E1B8 RID: 57784 RVA: 0x002129C9 File Offset: 0x00210BC9
		public static IActorVisibility Create(IActorVisibility? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorVisibility
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x0600E1B9 RID: 57785 RVA: 0x002129E8 File Offset: 0x00210BE8
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x0600E1BA RID: 57786 RVA: 0x002129F5 File Offset: 0x00210BF5
		public virtual EActorVisibilityPlayMode PlayMode
		{
			get
			{
				return (EActorVisibilityPlayMode)this.Instance.PlayMode;
			}
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x0600E1BB RID: 57787 RVA: 0x00212A02 File Offset: 0x00210C02
		public virtual IActorVisibilityEffectDefault Effect
		{
			get
			{
				if (this._EffectInited)
				{
					return this._EffectCache;
				}
				this._EffectInited = true;
				this._EffectCache = IActorVisibilityEffectDefault.Create(this.Instance.Effect);
				return this._EffectCache;
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0600E1BC RID: 57788 RVA: 0x00212A38 File Offset: 0x00210C38
		public virtual float? FadeDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeDuration);
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x0600E1BD RID: 57789 RVA: 0x00212A70 File Offset: 0x00210C70
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

		// Token: 0x04007AA7 RID: 31399
		private IActorVisibility Instance;

		// Token: 0x04007AA8 RID: 31400
		[Nullable(2)]
		private IActorVisibilityEffectDefault _EffectCache;

		// Token: 0x04007AA9 RID: 31401
		private bool _EffectInited;
	}
}
