using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200043E RID: 1086
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookLockScreenDetectTypeBase
	{
		// Token: 0x060015F3 RID: 5619 RVA: 0x0004445C File Offset: 0x0004265C
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

		// Token: 0x060015F4 RID: 5620 RVA: 0x00044494 File Offset: 0x00042694
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

		// Token: 0x060015F5 RID: 5621 RVA: 0x000444A7 File Offset: 0x000426A7
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

		// Token: 0x060015F6 RID: 5622 RVA: 0x000444BA File Offset: 0x000426BA
		public IHookLockScreenDetectTypeBase_SetValue ToSetValue()
		{
			return new IHookLockScreenDetectTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x000444CD File Offset: 0x000426CD
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x000444F8 File Offset: 0x000426F8
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

		// Token: 0x040010DD RID: 4317
		[Nullable(2)]
		protected IHookLockScreenDetectTypeBase FbInstance;

		// Token: 0x040010DE RID: 4318
		[Nullable(2)]
		protected IHookLockScreenDetectTypeBase_SetValue PocoInterface;
	}
}
