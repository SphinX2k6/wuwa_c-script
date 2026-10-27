using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB6 RID: 8118
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithPlayFlow : ITeleportTransitionType
	{
		// Token: 0x0600B28E RID: 45710 RVA: 0x001A013C File Offset: 0x0019E33C
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

		// Token: 0x0600B28F RID: 45711 RVA: 0x001A0174 File Offset: 0x0019E374
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

		// Token: 0x0600B290 RID: 45712 RVA: 0x001A0187 File Offset: 0x0019E387
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

		// Token: 0x0600B291 RID: 45713 RVA: 0x001A019A File Offset: 0x0019E39A
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

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600B292 RID: 45714 RVA: 0x001A01D1 File Offset: 0x0019E3D1
		// (set) Token: 0x0600B293 RID: 45715 RVA: 0x001A01FC File Offset: 0x0019E3FC
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

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600B294 RID: 45716 RVA: 0x001A020C File Offset: 0x0019E40C
		// (set) Token: 0x0600B295 RID: 45717 RVA: 0x001A026D File Offset: 0x0019E46D
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

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600B296 RID: 45718 RVA: 0x001A0284 File Offset: 0x0019E484
		// (set) Token: 0x0600B297 RID: 45719 RVA: 0x001A02E5 File Offset: 0x0019E4E5
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

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600B298 RID: 45720 RVA: 0x001A02FC File Offset: 0x0019E4FC
		// (set) Token: 0x0600B299 RID: 45721 RVA: 0x001A035D File Offset: 0x0019E55D
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

		// Token: 0x04006BD1 RID: 27601
		[Nullable(2)]
		protected new ITeleportTransitionWithPlayFlow FbInstance;

		// Token: 0x04006BD2 RID: 27602
		[Nullable(2)]
		protected new ITeleportTransitionWithPlayFlow_SetValue PocoInterface;

		// Token: 0x04006BD3 RID: 27603
		private PlayFlow _FlowCache;

		// Token: 0x04006BD4 RID: 27604
		private bool _FlowInited;

		// Token: 0x04006BD5 RID: 27605
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04006BD6 RID: 27606
		private bool _FadeInEffectInited;

		// Token: 0x04006BD7 RID: 27607
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04006BD8 RID: 27608
		private bool _FadeOutEffectInited;
	}
}
