using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F1 RID: 8689
	[NullableContext(2)]
	[Nullable(0)]
	public class SetWeatherLockState : ActionParams
	{
		// Token: 0x0600BED7 RID: 48855 RVA: 0x001B7198 File Offset: 0x001B5398
		[NullableContext(1)]
		private SetWeatherLockState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetWeatherLockState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetWeatherLockState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetWeatherLockState_SetValue());
			}
			return result;
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x001B71D0 File Offset: 0x001B53D0
		[NullableContext(1)]
		public static SetWeatherLockState Create([Nullable(2)] SetWeatherLockState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWeatherLockState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BED9 RID: 48857 RVA: 0x001B71E3 File Offset: 0x001B53E3
		[NullableContext(1)]
		public static SetWeatherLockState CreateFromSetValue([Nullable(2)] SetWeatherLockState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetWeatherLockState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEDA RID: 48858 RVA: 0x001B71F6 File Offset: 0x001B53F6
		[NullableContext(1)]
		public SetWeatherLockState_SetValue ToSetValue()
		{
			return new SetWeatherLockState_SetValue
			{
				LockState = this.LockState,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0600BEDB RID: 48859 RVA: 0x001B7215 File Offset: 0x001B5415
		// (set) Token: 0x0600BEDC RID: 48860 RVA: 0x001B7240 File Offset: 0x001B5440
		public virtual ELockState LockState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockState;
				}
				if (this.PocoInterface == null)
				{
					return ELockState.Lock;
				}
				return this.PocoInterface.LockState;
			}
			set
			{
				this.GetOrCreatePoco().LockState = value;
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0600BEDD RID: 48861 RVA: 0x001B724E File Offset: 0x001B544E
		// (set) Token: 0x0600BEDE RID: 48862 RVA: 0x001B7275 File Offset: 0x001B5475
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				SetWeatherLockState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x040071D3 RID: 29139
		protected new SetWeatherLockState FbInstance;

		// Token: 0x040071D4 RID: 29140
		protected SetWeatherLockState_SetValue PocoInterface;
	}
}
