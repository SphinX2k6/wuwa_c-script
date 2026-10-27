using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FAE RID: 8110
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionWithCustomScreen : ITeleportTransitionType
	{
		// Token: 0x0600B254 RID: 45652 RVA: 0x0019F978 File Offset: 0x0019DB78
		[NullableContext(1)]
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

		// Token: 0x0600B255 RID: 45653 RVA: 0x0019F9B0 File Offset: 0x0019DBB0
		[NullableContext(1)]
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

		// Token: 0x0600B256 RID: 45654 RVA: 0x0019F9C3 File Offset: 0x0019DBC3
		[NullableContext(1)]
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

		// Token: 0x0600B257 RID: 45655 RVA: 0x0019F9D8 File Offset: 0x0019DBD8
		[NullableContext(1)]
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

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600B258 RID: 45656 RVA: 0x0019FA3E File Offset: 0x0019DC3E
		// (set) Token: 0x0600B259 RID: 45657 RVA: 0x0019FA69 File Offset: 0x0019DC69
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

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600B25A RID: 45658 RVA: 0x0019FA77 File Offset: 0x0019DC77
		// (set) Token: 0x0600B25B RID: 45659 RVA: 0x0019FA9E File Offset: 0x0019DC9E
		[Nullable(1)]
		public virtual ICustomScreenTypeBase ScreenType
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().ScreenType = value;
			}
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600B25C RID: 45660 RVA: 0x0019FAAC File Offset: 0x0019DCAC
		// (set) Token: 0x0600B25D RID: 45661 RVA: 0x0019FB0D File Offset: 0x0019DD0D
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

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600B25E RID: 45662 RVA: 0x0019FB24 File Offset: 0x0019DD24
		// (set) Token: 0x0600B25F RID: 45663 RVA: 0x0019FB85 File Offset: 0x0019DD85
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

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600B260 RID: 45664 RVA: 0x0019FB9C File Offset: 0x0019DD9C
		// (set) Token: 0x0600B261 RID: 45665 RVA: 0x0019FBD6 File Offset: 0x0019DDD6
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

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0600B262 RID: 45666 RVA: 0x0019FBE4 File Offset: 0x0019DDE4
		// (set) Token: 0x0600B263 RID: 45667 RVA: 0x0019FC45 File Offset: 0x0019DE45
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

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600B264 RID: 45668 RVA: 0x0019FC5A File Offset: 0x0019DE5A
		// (set) Token: 0x0600B265 RID: 45669 RVA: 0x0019FC81 File Offset: 0x0019DE81
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

		// Token: 0x04006BB0 RID: 27568
		protected new ITeleportTransitionWithCustomScreen FbInstance;

		// Token: 0x04006BB1 RID: 27569
		protected new ITeleportTransitionWithCustomScreen_SetValue PocoInterface;

		// Token: 0x04006BB2 RID: 27570
		[Nullable(1)]
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04006BB3 RID: 27571
		private bool _FadeInEffectInited;

		// Token: 0x04006BB4 RID: 27572
		[Nullable(1)]
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04006BB5 RID: 27573
		private bool _FadeOutEffectInited;

		// Token: 0x04006BB6 RID: 27574
		[Nullable(1)]
		private ICustomShowUi _CustomShowUiCache;

		// Token: 0x04006BB7 RID: 27575
		private bool _CustomShowUiInited;
	}
}
