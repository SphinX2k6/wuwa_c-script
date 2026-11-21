using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000527 RID: 1319
	public class ILockConfig
	{
		// Token: 0x06001A94 RID: 6804 RVA: 0x0004E204 File Offset: 0x0004C404
		private ILockConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILockConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILockConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILockConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0004E23C File Offset: 0x0004C43C
		public static ILockConfig Create([Nullable(2)] ILockConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILockConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0004E24F File Offset: 0x0004C44F
		public static ILockConfig CreateFromSetValue([Nullable(2)] ILockConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILockConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0004E262 File Offset: 0x0004C462
		public ILockConfig_SetValue ToSetValue()
		{
			return new ILockConfig_SetValue
			{
				IsInitLock = this.IsInitLock,
				LockType = this.LockType
			};
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0004E281 File Offset: 0x0004C481
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0004E2AC File Offset: 0x0004C4AC
		public virtual bool IsInitLock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsInitLock;
				}
				return this.PocoInterface != null && this.PocoInterface.IsInitLock;
			}
			set
			{
				this.GetOrCreatePoco().IsInitLock = value;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0004E2BC File Offset: 0x0004C4BC
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0004E2F6 File Offset: 0x0004C4F6
		public virtual ELockType? LockType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockType;
				}
				ILockConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LockType;
			}
			set
			{
				this.GetOrCreatePoco().LockType = value;
			}
		}

		// Token: 0x04001391 RID: 5009
		[Nullable(2)]
		protected ILockConfig FbInstance;

		// Token: 0x04001392 RID: 5010
		[Nullable(2)]
		protected ILockConfig_SetValue PocoInterface;
	}
}
