using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200049B RID: 1179
	public class IHookLockScreenDetectTypeFullScreen : IHookLockScreenDetectTypeBase
	{
		// Token: 0x0600179D RID: 6045 RVA: 0x0004831C File Offset: 0x0004651C
		private IHookLockScreenDetectTypeFullScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookLockScreenDetectTypeFullScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookLockScreenDetectTypeFullScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookLockScreenDetectTypeFullScreen_SetValue());
			}
			return result;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00048354 File Offset: 0x00046554
		public static IHookLockScreenDetectTypeFullScreen Create([Nullable(2)] IHookLockScreenDetectTypeFullScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeFullScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00048367 File Offset: 0x00046567
		public static IHookLockScreenDetectTypeFullScreen CreateFromSetValue([Nullable(2)] IHookLockScreenDetectTypeFullScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeFullScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0004837A File Offset: 0x0004657A
		public new IHookLockScreenDetectTypeFullScreen_SetValue ToSetValue()
		{
			return new IHookLockScreenDetectTypeFullScreen_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x0004838D File Offset: 0x0004658D
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x000483B8 File Offset: 0x000465B8
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

		// Token: 0x04001205 RID: 4613
		[Nullable(2)]
		protected new IHookLockScreenDetectTypeFullScreen FbInstance;

		// Token: 0x04001206 RID: 4614
		[Nullable(2)]
		protected new IHookLockScreenDetectTypeFullScreen_SetValue PocoInterface;
	}
}
