using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F1 RID: 8689
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithCustomScreen : ITeleportTransitionType
	{
		// Token: 0x0600BD58 RID: 48472 RVA: 0x001B5D28 File Offset: 0x001B3F28
		[NullableContext(0)]
		private ITeleportTransitionWithCustomScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithCustomScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithCustomScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithCustomScreen_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD59 RID: 48473 RVA: 0x001B5D60 File Offset: 0x001B3F60
		[NullableContext(0)]
		public static ITeleportTransitionWithCustomScreen Create([Nullable(2)] ITeleportTransitionWithCustomScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD5A RID: 48474 RVA: 0x001B5D73 File Offset: 0x001B3F73
		[NullableContext(0)]
		public static ITeleportTransitionWithCustomScreen CreateFromSetValue([Nullable(2)] ITeleportTransitionWithCustomScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x001B5D88 File Offset: 0x001B3F88
		[NullableContext(0)]
		public new ITeleportTransitionWithCustomScreen_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithCustomScreen_SetValue
			{
				Type = this.Type,
				ScreenType = this.ScreenType,
				FadeInEffect = this.FadeInEffect,
				FadeOutEffect = this.FadeOutEffect,
				KeepTime = this.KeepTime,
				CustomShowUi = this.CustomShowUi,
				StartAkEvent = this.StartAkEvent
			};
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0600BD5C RID: 48476 RVA: 0x001B5DEE File Offset: 0x001B3FEE
		// (set) Token: 0x0600BD5D RID: 48477 RVA: 0x001B5E19 File Offset: 0x001B4019
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

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0600BD5E RID: 48478 RVA: 0x001B5E27 File Offset: 0x001B4027
		// (set) Token: 0x0600BD5F RID: 48479 RVA: 0x001B5E4E File Offset: 0x001B404E
		[Nullable(0)]
		public virtual ICustomScreenTypeBase ScreenType
		{
			[NullableContext(0)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenType;
				}
				ITeleportTransitionWithCustomScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenType;
			}
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().ScreenType = value;
			}
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0600BD60 RID: 48480 RVA: 0x001B5E5C File Offset: 0x001B405C
		// (set) Token: 0x0600BD61 RID: 48481 RVA: 0x001B5EBD File Offset: 0x001B40BD
		public virtual IFadeBackgroundFadeInEffect FadeInEffect
		{
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
					ITeleportTransitionWithCustomScreen_SetValue pocoInterface = this.PocoInterface;
					this._FadeInEffectCache = ((pocoInterface != null) ? pocoInterface.FadeInEffect : null);
				}
				return this._FadeInEffectCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeInEffect = value;
				this._FadeInEffectInited = false;
			}
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x0600BD62 RID: 48482 RVA: 0x001B5ED4 File Offset: 0x001B40D4
		// (set) Token: 0x0600BD63 RID: 48483 RVA: 0x001B5F35 File Offset: 0x001B4135
		public virtual IFadeBackgroundFadeOutEffect FadeOutEffect
		{
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
					ITeleportTransitionWithCustomScreen_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutEffectCache = ((pocoInterface != null) ? pocoInterface.FadeOutEffect : null);
				}
				return this._FadeOutEffectCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutEffect = value;
				this._FadeOutEffectInited = false;
			}
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x0600BD64 RID: 48484 RVA: 0x001B5F4C File Offset: 0x001B414C
		// (set) Token: 0x0600BD65 RID: 48485 RVA: 0x001B5F86 File Offset: 0x001B4186
		public virtual float? KeepTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepTime;
				}
				ITeleportTransitionWithCustomScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepTime;
			}
			set
			{
				this.GetOrCreatePoco().KeepTime = value;
			}
		}

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0600BD66 RID: 48486 RVA: 0x001B5F94 File Offset: 0x001B4194
		// (set) Token: 0x0600BD67 RID: 48487 RVA: 0x001B5FF5 File Offset: 0x001B41F5
		public virtual ICustomShowUi CustomShowUi
		{
			get
			{
				if (this._CustomShowUiInited)
				{
					return this._CustomShowUiCache;
				}
				this._CustomShowUiInited = true;
				if (this.FbInstance != null)
				{
					this._CustomShowUiCache = ICustomShowUi.Create(this.FbInstance.CustomShowUi);
				}
				else
				{
					ITeleportTransitionWithCustomScreen_SetValue pocoInterface = this.PocoInterface;
					this._CustomShowUiCache = ((pocoInterface != null) ? pocoInterface.CustomShowUi : null);
				}
				return this._CustomShowUiCache;
			}
			set
			{
				this.GetOrCreatePoco().CustomShowUi = value;
				this._CustomShowUiInited = false;
			}
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0600BD68 RID: 48488 RVA: 0x001B600A File Offset: 0x001B420A
		// (set) Token: 0x0600BD69 RID: 48489 RVA: 0x001B6031 File Offset: 0x001B4231
		public virtual string StartAkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartAkEvent;
				}
				ITeleportTransitionWithCustomScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartAkEvent;
			}
			set
			{
				this.GetOrCreatePoco().StartAkEvent = value;
			}
		}

		// Token: 0x040071AB RID: 29099
		protected new ITeleportTransitionWithCustomScreen FbInstance;

		// Token: 0x040071AC RID: 29100
		protected new ITeleportTransitionWithCustomScreen_SetValue PocoInterface;

		// Token: 0x040071AD RID: 29101
		[Nullable(0)]
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x040071AE RID: 29102
		private bool _FadeInEffectInited;

		// Token: 0x040071AF RID: 29103
		[Nullable(0)]
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x040071B0 RID: 29104
		private bool _FadeOutEffectInited;

		// Token: 0x040071B1 RID: 29105
		[Nullable(0)]
		private ICustomShowUi _CustomShowUiCache;

		// Token: 0x040071B2 RID: 29106
		private bool _CustomShowUiInited;
	}
}
