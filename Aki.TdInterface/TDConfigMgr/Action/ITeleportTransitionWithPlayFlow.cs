using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F9 RID: 8697
	public class ITeleportTransitionWithPlayFlow : ITeleportTransitionType
	{
		// Token: 0x0600BD92 RID: 48530 RVA: 0x001B64EC File Offset: 0x001B46EC
		private ITeleportTransitionWithPlayFlow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithPlayFlow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithPlayFlow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithPlayFlow_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD93 RID: 48531 RVA: 0x001B6524 File Offset: 0x001B4724
		public static ITeleportTransitionWithPlayFlow Create([Nullable(2)] ITeleportTransitionWithPlayFlow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithPlayFlow
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x001B6537 File Offset: 0x001B4737
		public static ITeleportTransitionWithPlayFlow CreateFromSetValue([Nullable(2)] ITeleportTransitionWithPlayFlow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithPlayFlow
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x001B654A File Offset: 0x001B474A
		public new ITeleportTransitionWithPlayFlow_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithPlayFlow_SetValue
			{
				Type = this.Type,
				Flow = this.Flow,
				FadeInEffect = this.FadeInEffect,
				FadeOutEffect = this.FadeOutEffect
			};
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0600BD96 RID: 48534 RVA: 0x001B6581 File Offset: 0x001B4781
		// (set) Token: 0x0600BD97 RID: 48535 RVA: 0x001B65AC File Offset: 0x001B47AC
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0600BD98 RID: 48536 RVA: 0x001B65BC File Offset: 0x001B47BC
		// (set) Token: 0x0600BD99 RID: 48537 RVA: 0x001B661D File Offset: 0x001B481D
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					ITeleportTransitionWithPlayFlow_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0600BD9A RID: 48538 RVA: 0x001B6634 File Offset: 0x001B4834
		// (set) Token: 0x0600BD9B RID: 48539 RVA: 0x001B6695 File Offset: 0x001B4895
		[Nullable(2)]
		public virtual IFadeBackgroundFadeInEffect FadeInEffect
		{
			[NullableContext(2)]
			get
			{
				if (this._FadeInEffectInited)
				{
					return this._FadeInEffectCache;
				}
				this._FadeInEffectInited = true;
				if (this.FbInstance != null)
				{
					this._FadeInEffectCache = IFadeBackgroundFadeInEffect.Create(this.FbInstance.FadeInEffect);
				}
				else
				{
					ITeleportTransitionWithPlayFlow_SetValue pocoInterface = this.PocoInterface;
					this._FadeInEffectCache = ((pocoInterface != null) ? pocoInterface.FadeInEffect : null);
				}
				return this._FadeInEffectCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FadeInEffect = value;
				this._FadeInEffectInited = false;
			}
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0600BD9C RID: 48540 RVA: 0x001B66AC File Offset: 0x001B48AC
		// (set) Token: 0x0600BD9D RID: 48541 RVA: 0x001B670D File Offset: 0x001B490D
		[Nullable(2)]
		public virtual IFadeBackgroundFadeOutEffect FadeOutEffect
		{
			[NullableContext(2)]
			get
			{
				if (this._FadeOutEffectInited)
				{
					return this._FadeOutEffectCache;
				}
				this._FadeOutEffectInited = true;
				if (this.FbInstance != null)
				{
					this._FadeOutEffectCache = IFadeBackgroundFadeOutEffect.Create(this.FbInstance.FadeOutEffect);
				}
				else
				{
					ITeleportTransitionWithPlayFlow_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutEffectCache = ((pocoInterface != null) ? pocoInterface.FadeOutEffect : null);
				}
				return this._FadeOutEffectCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FadeOutEffect = value;
				this._FadeOutEffectInited = false;
			}
		}

		// Token: 0x040071CC RID: 29132
		[Nullable(2)]
		protected new ITeleportTransitionWithPlayFlow FbInstance;

		// Token: 0x040071CD RID: 29133
		[Nullable(2)]
		protected new ITeleportTransitionWithPlayFlow_SetValue PocoInterface;

		// Token: 0x040071CE RID: 29134
		private PlayFlow _FlowCache;

		// Token: 0x040071CF RID: 29135
		private bool _FlowInited;

		// Token: 0x040071D0 RID: 29136
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x040071D1 RID: 29137
		private bool _FadeInEffectInited;

		// Token: 0x040071D2 RID: 29138
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x040071D3 RID: 29139
		private bool _FadeOutEffectInited;
	}
}
