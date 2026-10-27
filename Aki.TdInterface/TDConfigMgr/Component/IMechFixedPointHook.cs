using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004EA RID: 1258
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechFixedPointHook : IMechHookConfigType
	{
		// Token: 0x0600198C RID: 6540 RVA: 0x0004B4E0 File Offset: 0x000496E0
		private IMechFixedPointHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechFixedPointHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechFixedPointHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechFixedPointHook_SetValue());
			}
			return result;
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0004B518 File Offset: 0x00049718
		public static IMechFixedPointHook Create([Nullable(2)] IMechFixedPointHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechFixedPointHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0004B52B File Offset: 0x0004972B
		public static IMechFixedPointHook CreateFromSetValue([Nullable(2)] IMechFixedPointHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechFixedPointHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0004B53E File Offset: 0x0004973E
		public new IMechFixedPointHook_SetValue ToSetValue()
		{
			return new IMechFixedPointHook_SetValue
			{
				Type = this.Type,
				MechBehaviorConfig = this.MechBehaviorConfig
			};
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x0004B55D File Offset: 0x0004975D
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x0004B588 File Offset: 0x00049788
		public override EMechHookConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechHookConfigType.BurrowHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x0004B598 File Offset: 0x00049798
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x0004B5F9 File Offset: 0x000497F9
		[Nullable(2)]
		public virtual IMechBehaviorConfig MechBehaviorConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._MechBehaviorConfigInited)
				{
					return this._MechBehaviorConfigCache;
				}
				this._MechBehaviorConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MechBehaviorConfigCache = IMechBehaviorConfig.Create(this.FbInstance.MechBehaviorConfig);
				}
				else
				{
					IMechFixedPointHook_SetValue pocoInterface = this.PocoInterface;
					this._MechBehaviorConfigCache = ((pocoInterface != null) ? pocoInterface.MechBehaviorConfig : null);
				}
				return this._MechBehaviorConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MechBehaviorConfig = value;
				this._MechBehaviorConfigInited = false;
			}
		}

		// Token: 0x040012B2 RID: 4786
		[Nullable(2)]
		protected new IMechFixedPointHook FbInstance;

		// Token: 0x040012B3 RID: 4787
		[Nullable(2)]
		protected new IMechFixedPointHook_SetValue PocoInterface;

		// Token: 0x040012B4 RID: 4788
		private IMechBehaviorConfig _MechBehaviorConfigCache;

		// Token: 0x040012B5 RID: 4789
		private bool _MechBehaviorConfigInited;
	}
}
