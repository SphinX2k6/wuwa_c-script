using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002698 RID: 9880
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithPlayFlow : ITeleportTransitionType
	{
		// Token: 0x0600DD28 RID: 56616 RVA: 0x0020DD75 File Offset: 0x0020BF75
		[NullableContext(1)]
		public static ITeleportTransitionWithPlayFlow Create(ITeleportTransitionWithPlayFlow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithPlayFlow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x0600DD29 RID: 56617 RVA: 0x0020DD94 File Offset: 0x0020BF94
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x0600DD2A RID: 56618 RVA: 0x0020DDA1 File Offset: 0x0020BFA1
		[Nullable(1)]
		public virtual PlayFlow Flow
		{
			[NullableContext(1)]
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = PlayFlow.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x0600DD2B RID: 56619 RVA: 0x0020DDD5 File Offset: 0x0020BFD5
		public virtual IFadeBackgroundFadeInEffect FadeInEffect
		{
			get
			{
				if (this._FadeInEffectInited)
				{
					return this._FadeInEffectCache;
				}
				this._FadeInEffectInited = true;
				this._FadeInEffectCache = IFadeBackgroundFadeInEffect.Create(this.Instance.FadeInEffect);
				return this._FadeInEffectCache;
			}
		}

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x0600DD2C RID: 56620 RVA: 0x0020DE09 File Offset: 0x0020C009
		public virtual IFadeBackgroundFadeOutEffect FadeOutEffect
		{
			get
			{
				if (this._FadeOutEffectInited)
				{
					return this._FadeOutEffectCache;
				}
				this._FadeOutEffectInited = true;
				this._FadeOutEffectCache = IFadeBackgroundFadeOutEffect.Create(this.Instance.FadeOutEffect);
				return this._FadeOutEffectCache;
			}
		}

		// Token: 0x04007AD4 RID: 31444
		private ITeleportTransitionWithPlayFlow Instance;

		// Token: 0x04007AD5 RID: 31445
		private PlayFlow _FlowCache;

		// Token: 0x04007AD6 RID: 31446
		private bool _FlowInited;

		// Token: 0x04007AD7 RID: 31447
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04007AD8 RID: 31448
		private bool _FadeInEffectInited;

		// Token: 0x04007AD9 RID: 31449
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04007ADA RID: 31450
		private bool _FadeOutEffectInited;
	}
}
