using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002538 RID: 9528
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorVisibility
	{
		// Token: 0x0600D458 RID: 54360 RVA: 0x001F6F69 File Offset: 0x001F5169
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

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0600D459 RID: 54361 RVA: 0x001F6F88 File Offset: 0x001F5188
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x0600D45A RID: 54362 RVA: 0x001F6F95 File Offset: 0x001F5195
		public virtual EActorVisibilityPlayMode PlayMode
		{
			get
			{
				return (EActorVisibilityPlayMode)this.Instance.PlayMode;
			}
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0600D45B RID: 54363 RVA: 0x001F6FA2 File Offset: 0x001F51A2
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

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x0600D45C RID: 54364 RVA: 0x001F6FD8 File Offset: 0x001F51D8
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

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0600D45D RID: 54365 RVA: 0x001F7010 File Offset: 0x001F5210
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

		// Token: 0x04007452 RID: 29778
		private IActorVisibility Instance;

		// Token: 0x04007453 RID: 29779
		[Nullable(2)]
		private IActorVisibilityEffectDefault _EffectCache;

		// Token: 0x04007454 RID: 29780
		private bool _EffectInited;
	}
}
