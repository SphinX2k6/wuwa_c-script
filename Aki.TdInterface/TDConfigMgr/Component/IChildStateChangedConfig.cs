using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023F RID: 575
	[NullableContext(1)]
	[Nullable(0)]
	public class IChildStateChangedConfig
	{
		// Token: 0x06000A42 RID: 2626 RVA: 0x0002B0A8 File Offset: 0x000292A8
		private IChildStateChangedConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChildStateChangedConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChildStateChangedConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChildStateChangedConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002B0E0 File Offset: 0x000292E0
		public static IChildStateChangedConfig Create([Nullable(2)] IChildStateChangedConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChildStateChangedConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002B0F3 File Offset: 0x000292F3
		public static IChildStateChangedConfig CreateFromSetValue([Nullable(2)] IChildStateChangedConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChildStateChangedConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002B106 File Offset: 0x00029306
		public IChildStateChangedConfig_SetValue ToSetValue()
		{
			return new IChildStateChangedConfig_SetValue
			{
				State = this.State,
				DelayChangeState = this.DelayChangeState
			};
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0002B125 File Offset: 0x00029325
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0002B150 File Offset: 0x00029350
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0002B160 File Offset: 0x00029360
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x0002B1C1 File Offset: 0x000293C1
		[Nullable(2)]
		public virtual IDelayChangeState DelayChangeState
		{
			[NullableContext(2)]
			get
			{
				if (this._DelayChangeStateInited)
				{
					return this._DelayChangeStateCache;
				}
				this._DelayChangeStateInited = true;
				if (this.FbInstance != null)
				{
					this._DelayChangeStateCache = IDelayChangeState.Create(this.FbInstance.DelayChangeState);
				}
				else
				{
					IChildStateChangedConfig_SetValue pocoInterface = this.PocoInterface;
					this._DelayChangeStateCache = ((pocoInterface != null) ? pocoInterface.DelayChangeState : null);
				}
				return this._DelayChangeStateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DelayChangeState = value;
				this._DelayChangeStateInited = false;
			}
		}

		// Token: 0x04000A4C RID: 2636
		[Nullable(2)]
		protected IChildStateChangedConfig FbInstance;

		// Token: 0x04000A4D RID: 2637
		[Nullable(2)]
		protected IChildStateChangedConfig_SetValue PocoInterface;

		// Token: 0x04000A4E RID: 2638
		private IDelayChangeState _DelayChangeStateCache;

		// Token: 0x04000A4F RID: 2639
		private bool _DelayChangeStateInited;
	}
}
