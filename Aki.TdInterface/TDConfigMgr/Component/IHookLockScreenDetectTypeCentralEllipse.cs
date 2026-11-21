using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000499 RID: 1177
	public class IHookLockScreenDetectTypeCentralEllipse : IHookLockScreenDetectTypeBase
	{
		// Token: 0x06001795 RID: 6037 RVA: 0x00048260 File Offset: 0x00046460
		private IHookLockScreenDetectTypeCentralEllipse_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookLockScreenDetectTypeCentralEllipse 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookLockScreenDetectTypeCentralEllipse_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookLockScreenDetectTypeCentralEllipse_SetValue());
			}
			return result;
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00048298 File Offset: 0x00046498
		public static IHookLockScreenDetectTypeCentralEllipse Create([Nullable(2)] IHookLockScreenDetectTypeCentralEllipse instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeCentralEllipse
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x000482AB File Offset: 0x000464AB
		public static IHookLockScreenDetectTypeCentralEllipse CreateFromSetValue([Nullable(2)] IHookLockScreenDetectTypeCentralEllipse_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeCentralEllipse
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000482BE File Offset: 0x000464BE
		public new IHookLockScreenDetectTypeCentralEllipse_SetValue ToSetValue()
		{
			return new IHookLockScreenDetectTypeCentralEllipse_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x000482D1 File Offset: 0x000464D1
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x000482FC File Offset: 0x000464FC
		public override EHookLockScreenDetectType Type
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

		// Token: 0x04001202 RID: 4610
		[Nullable(2)]
		protected new IHookLockScreenDetectTypeCentralEllipse FbInstance;

		// Token: 0x04001203 RID: 4611
		[Nullable(2)]
		protected new IHookLockScreenDetectTypeCentralEllipse_SetValue PocoInterface;
	}
}
