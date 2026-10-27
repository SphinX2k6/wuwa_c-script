using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004CE RID: 1230
	[NullableContext(1)]
	[Nullable(0)]
	public class ILockConfig
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x0004A4BC File Offset: 0x000486BC
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

		// Token: 0x060018FB RID: 6395 RVA: 0x0004A4F4 File Offset: 0x000486F4
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

		// Token: 0x060018FC RID: 6396 RVA: 0x0004A507 File Offset: 0x00048707
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

		// Token: 0x060018FD RID: 6397 RVA: 0x0004A51A File Offset: 0x0004871A
		public ILockConfig_SetValue ToSetValue()
		{
			return new ILockConfig_SetValue
			{
				IsInitLock = this.IsInitLock,
				LockType = this.LockType
			};
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0004A539 File Offset: 0x00048739
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0004A564 File Offset: 0x00048764
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

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0004A574 File Offset: 0x00048774
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0004A5AE File Offset: 0x000487AE
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

		// Token: 0x0400126F RID: 4719
		[Nullable(2)]
		protected ILockConfig FbInstance;

		// Token: 0x04001270 RID: 4720
		[Nullable(2)]
		protected ILockConfig_SetValue PocoInterface;
	}
}
