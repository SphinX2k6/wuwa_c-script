using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200149F RID: 5279
	[NullableContext(1)]
	[Nullable(0)]
	public class AdjustTodTime : ActionParams
	{
		// Token: 0x06007836 RID: 30774 RVA: 0x00120550 File Offset: 0x0011E750
		private AdjustTodTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AdjustTodTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AdjustTodTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AdjustTodTime_SetValue());
			}
			return result;
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00120588 File Offset: 0x0011E788
		public static AdjustTodTime Create([Nullable(2)] AdjustTodTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdjustTodTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x0012059B File Offset: 0x0011E79B
		public static AdjustTodTime CreateFromSetValue([Nullable(2)] AdjustTodTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AdjustTodTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x001205AE File Offset: 0x0011E7AE
		public AdjustTodTime_SetValue ToSetValue()
		{
			return new AdjustTodTime_SetValue
			{
				Hour = this.Hour,
				Min = this.Min,
				ShowUi = this.ShowUi
			};
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x0600783A RID: 30778 RVA: 0x001205D9 File Offset: 0x0011E7D9
		// (set) Token: 0x0600783B RID: 30779 RVA: 0x00120604 File Offset: 0x0011E804
		public virtual int Hour
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Hour;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Hour;
			}
			set
			{
				this.GetOrCreatePoco().Hour = value;
			}
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600783C RID: 30780 RVA: 0x00120612 File Offset: 0x0011E812
		// (set) Token: 0x0600783D RID: 30781 RVA: 0x0012063D File Offset: 0x0011E83D
		public virtual int Min
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Min;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Min;
			}
			set
			{
				this.GetOrCreatePoco().Min = value;
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600783E RID: 30782 RVA: 0x0012064B File Offset: 0x0011E84B
		// (set) Token: 0x0600783F RID: 30783 RVA: 0x00120676 File Offset: 0x0011E876
		public virtual bool ShowUi
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowUi;
				}
				return this.PocoInterface != null && this.PocoInterface.ShowUi;
			}
			set
			{
				this.GetOrCreatePoco().ShowUi = value;
			}
		}

		// Token: 0x040045E2 RID: 17890
		[Nullable(2)]
		protected new AdjustTodTime FbInstance;

		// Token: 0x040045E3 RID: 17891
		[Nullable(2)]
		protected AdjustTodTime_SetValue PocoInterface;
	}
}
