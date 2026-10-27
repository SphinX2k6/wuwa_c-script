using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200224A RID: 8778
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleScanSplineEffect : ActionParams
	{
		// Token: 0x0600C09E RID: 49310 RVA: 0x001BA630 File Offset: 0x001B8830
		private ToggleScanSplineEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleScanSplineEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleScanSplineEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleScanSplineEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600C09F RID: 49311 RVA: 0x001BA668 File Offset: 0x001B8868
		public static ToggleScanSplineEffect Create([Nullable(2)] ToggleScanSplineEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleScanSplineEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0A0 RID: 49312 RVA: 0x001BA67B File Offset: 0x001B887B
		public static ToggleScanSplineEffect CreateFromSetValue([Nullable(2)] ToggleScanSplineEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleScanSplineEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x001BA68E File Offset: 0x001B888E
		public ToggleScanSplineEffect_SetValue ToSetValue()
		{
			return new ToggleScanSplineEffect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0600C0A2 RID: 49314 RVA: 0x001BA6A1 File Offset: 0x001B88A1
		// (set) Token: 0x0600C0A3 RID: 49315 RVA: 0x001BA6CC File Offset: 0x001B88CC
		public virtual ETraceSplineOptionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETraceSplineOptionType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040072D1 RID: 29393
		[Nullable(2)]
		protected new ToggleScanSplineEffect FbInstance;

		// Token: 0x040072D2 RID: 29394
		[Nullable(2)]
		protected ToggleScanSplineEffect_SetValue PocoInterface;
	}
}
