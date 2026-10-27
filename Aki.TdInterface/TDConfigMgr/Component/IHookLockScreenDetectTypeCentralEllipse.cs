using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000440 RID: 1088
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookLockScreenDetectTypeCentralEllipse : IHookLockScreenDetectTypeBase
	{
		// Token: 0x060015FB RID: 5627 RVA: 0x00044518 File Offset: 0x00042718
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

		// Token: 0x060015FC RID: 5628 RVA: 0x00044550 File Offset: 0x00042750
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

		// Token: 0x060015FD RID: 5629 RVA: 0x00044563 File Offset: 0x00042763
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

		// Token: 0x060015FE RID: 5630 RVA: 0x00044576 File Offset: 0x00042776
		public new IHookLockScreenDetectTypeCentralEllipse_SetValue ToSetValue()
		{
			return new IHookLockScreenDetectTypeCentralEllipse_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00044589 File Offset: 0x00042789
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x000445B4 File Offset: 0x000427B4
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

		// Token: 0x040010E0 RID: 4320
		[Nullable(2)]
		protected new IHookLockScreenDetectTypeCentralEllipse FbInstance;

		// Token: 0x040010E1 RID: 4321
		[Nullable(2)]
		protected new IHookLockScreenDetectTypeCentralEllipse_SetValue PocoInterface;
	}
}
