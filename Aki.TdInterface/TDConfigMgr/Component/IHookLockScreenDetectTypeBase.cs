using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000497 RID: 1175
	public class IHookLockScreenDetectTypeBase
	{
		// Token: 0x0600178D RID: 6029 RVA: 0x000481A4 File Offset: 0x000463A4
		private IHookLockScreenDetectTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookLockScreenDetectTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookLockScreenDetectTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookLockScreenDetectTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x000481DC File Offset: 0x000463DC
		public static IHookLockScreenDetectTypeBase Create([Nullable(2)] IHookLockScreenDetectTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x000481EF File Offset: 0x000463EF
		public static IHookLockScreenDetectTypeBase CreateFromSetValue([Nullable(2)] IHookLockScreenDetectTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00048202 File Offset: 0x00046402
		public IHookLockScreenDetectTypeBase_SetValue ToSetValue()
		{
			return new IHookLockScreenDetectTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x00048215 File Offset: 0x00046415
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x00048240 File Offset: 0x00046440
		public virtual EHookLockScreenDetectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHookLockScreenDetectType.CentralEllipse;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040011FF RID: 4607
		[Nullable(2)]
		protected IHookLockScreenDetectTypeBase FbInstance;

		// Token: 0x04001200 RID: 4608
		[Nullable(2)]
		protected IHookLockScreenDetectTypeBase_SetValue PocoInterface;
	}
}
