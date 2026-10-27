using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000442 RID: 1090
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookLockScreenDetectTypeFullScreen : IHookLockScreenDetectTypeBase
	{
		// Token: 0x06001603 RID: 5635 RVA: 0x000445D4 File Offset: 0x000427D4
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

		// Token: 0x06001604 RID: 5636 RVA: 0x0004460C File Offset: 0x0004280C
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

		// Token: 0x06001605 RID: 5637 RVA: 0x0004461F File Offset: 0x0004281F
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

		// Token: 0x06001606 RID: 5638 RVA: 0x00044632 File Offset: 0x00042832
		public new IHookLockScreenDetectTypeFullScreen_SetValue ToSetValue()
		{
			return new IHookLockScreenDetectTypeFullScreen_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00044645 File Offset: 0x00042845
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x00044670 File Offset: 0x00042870
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

		// Token: 0x040010E3 RID: 4323
		[Nullable(2)]
		protected new IHookLockScreenDetectTypeFullScreen FbInstance;

		// Token: 0x040010E4 RID: 4324
		[Nullable(2)]
		protected new IHookLockScreenDetectTypeFullScreen_SetValue PocoInterface;
	}
}
