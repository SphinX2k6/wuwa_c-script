using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF9 RID: 6905
	[NullableContext(1)]
	[Nullable(0)]
	public class IHealthBarDisplayClientFunction : EnableClientFunction
	{
		// Token: 0x060093E2 RID: 37858 RVA: 0x00156D88 File Offset: 0x00154F88
		private IHealthBarDisplayClientFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHealthBarDisplayClientFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHealthBarDisplayClientFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHealthBarDisplayClientFunction_SetValue());
			}
			return result;
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x00156DC0 File Offset: 0x00154FC0
		public static IHealthBarDisplayClientFunction Create([Nullable(2)] IHealthBarDisplayClientFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHealthBarDisplayClientFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093E4 RID: 37860 RVA: 0x00156DD3 File Offset: 0x00154FD3
		public static IHealthBarDisplayClientFunction CreateFromSetValue([Nullable(2)] IHealthBarDisplayClientFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHealthBarDisplayClientFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x00156DE6 File Offset: 0x00154FE6
		public new IHealthBarDisplayClientFunction_SetValue ToSetValue()
		{
			return new IHealthBarDisplayClientFunction_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				IsVisible = this.IsVisible
			};
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x060093E6 RID: 37862 RVA: 0x00156E11 File Offset: 0x00155011
		// (set) Token: 0x060093E7 RID: 37863 RVA: 0x00156E3C File Offset: 0x0015503C
		public override EEnableClientFunctionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableClientFunctionType.HealthBarDisplay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x060093E8 RID: 37864 RVA: 0x00156E4A File Offset: 0x0015504A
		// (set) Token: 0x060093E9 RID: 37865 RVA: 0x00156E75 File Offset: 0x00155075
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x060093EA RID: 37866 RVA: 0x00156E83 File Offset: 0x00155083
		// (set) Token: 0x060093EB RID: 37867 RVA: 0x00156EAE File Offset: 0x001550AE
		public virtual bool IsVisible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsVisible;
				}
				return this.PocoInterface != null && this.PocoInterface.IsVisible;
			}
			set
			{
				this.GetOrCreatePoco().IsVisible = value;
			}
		}

		// Token: 0x04005AC8 RID: 23240
		[Nullable(2)]
		protected new IHealthBarDisplayClientFunction FbInstance;

		// Token: 0x04005AC9 RID: 23241
		[Nullable(2)]
		protected new IHealthBarDisplayClientFunction_SetValue PocoInterface;
	}
}
