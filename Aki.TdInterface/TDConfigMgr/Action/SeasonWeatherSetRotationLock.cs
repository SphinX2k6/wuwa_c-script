using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E8 RID: 9192
	public class SeasonWeatherSetRotationLock : ActionParams
	{
		// Token: 0x0600C82A RID: 51242 RVA: 0x001C9DC4 File Offset: 0x001C7FC4
		private SeasonWeatherSetRotationLock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SeasonWeatherSetRotationLock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SeasonWeatherSetRotationLock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SeasonWeatherSetRotationLock_SetValue());
			}
			return result;
		}

		// Token: 0x0600C82B RID: 51243 RVA: 0x001C9DFC File Offset: 0x001C7FFC
		public static SeasonWeatherSetRotationLock Create([Nullable(2)] SeasonWeatherSetRotationLock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeasonWeatherSetRotationLock
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C82C RID: 51244 RVA: 0x001C9E0F File Offset: 0x001C800F
		public static SeasonWeatherSetRotationLock CreateFromSetValue([Nullable(2)] SeasonWeatherSetRotationLock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SeasonWeatherSetRotationLock
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C82D RID: 51245 RVA: 0x001C9E22 File Offset: 0x001C8022
		public SeasonWeatherSetRotationLock_SetValue ToSetValue()
		{
			return new SeasonWeatherSetRotationLock_SetValue
			{
				IsLocked = this.IsLocked
			};
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0600C82E RID: 51246 RVA: 0x001C9E35 File Offset: 0x001C8035
		// (set) Token: 0x0600C82F RID: 51247 RVA: 0x001C9E60 File Offset: 0x001C8060
		public virtual bool IsLocked
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLocked;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLocked;
			}
			set
			{
				this.GetOrCreatePoco().IsLocked = value;
			}
		}

		// Token: 0x040076D4 RID: 30420
		[Nullable(2)]
		protected new SeasonWeatherSetRotationLock FbInstance;

		// Token: 0x040076D5 RID: 30421
		[Nullable(2)]
		protected SeasonWeatherSetRotationLock_SetValue PocoInterface;
	}
}
