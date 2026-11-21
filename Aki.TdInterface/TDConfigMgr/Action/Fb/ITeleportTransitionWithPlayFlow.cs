using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295B RID: 10587
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithPlayFlow : ITeleportTransitionType
	{
		// Token: 0x0600EAFF RID: 60159 RVA: 0x0022A515 File Offset: 0x00228715
		[NullableContext(0)]
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

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x0600EB00 RID: 60160 RVA: 0x0022A534 File Offset: 0x00228734
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x0600EB01 RID: 60161 RVA: 0x0022A541 File Offset: 0x00228741
		[Nullable(0)]
		public virtual PlayFlow Flow
		{
			[NullableContext(0)]
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

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x0600EB02 RID: 60162 RVA: 0x0022A575 File Offset: 0x00228775
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

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x0600EB03 RID: 60163 RVA: 0x0022A5A9 File Offset: 0x002287A9
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

		// Token: 0x04008171 RID: 33137
		private ITeleportTransitionWithPlayFlow Instance;

		// Token: 0x04008172 RID: 33138
		private PlayFlow _FlowCache;

		// Token: 0x04008173 RID: 33139
		private bool _FlowInited;

		// Token: 0x04008174 RID: 33140
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04008175 RID: 33141
		private bool _FadeInEffectInited;

		// Token: 0x04008176 RID: 33142
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04008177 RID: 33143
		private bool _FadeOutEffectInited;
	}
}
