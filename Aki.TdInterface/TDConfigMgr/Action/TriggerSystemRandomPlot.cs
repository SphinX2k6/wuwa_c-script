using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024CB RID: 9419
	public class TriggerSystemRandomPlot : ActionParams
	{
		// Token: 0x0600CCD0 RID: 52432 RVA: 0x001D2A38 File Offset: 0x001D0C38
		private TriggerSystemRandomPlot_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TriggerSystemRandomPlot 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TriggerSystemRandomPlot_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TriggerSystemRandomPlot_SetValue());
			}
			return result;
		}

		// Token: 0x0600CCD1 RID: 52433 RVA: 0x001D2A70 File Offset: 0x001D0C70
		public static TriggerSystemRandomPlot Create([Nullable(2)] TriggerSystemRandomPlot instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerSystemRandomPlot
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CCD2 RID: 52434 RVA: 0x001D2A83 File Offset: 0x001D0C83
		public static TriggerSystemRandomPlot CreateFromSetValue([Nullable(2)] TriggerSystemRandomPlot_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TriggerSystemRandomPlot
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CCD3 RID: 52435 RVA: 0x001D2A96 File Offset: 0x001D0C96
		public TriggerSystemRandomPlot_SetValue ToSetValue()
		{
			return new TriggerSystemRandomPlot_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0600CCD4 RID: 52436 RVA: 0x001D2AA9 File Offset: 0x001D0CA9
		// (set) Token: 0x0600CCD5 RID: 52437 RVA: 0x001D2AD4 File Offset: 0x001D0CD4
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x0400795A RID: 31066
		[Nullable(2)]
		protected new TriggerSystemRandomPlot FbInstance;

		// Token: 0x0400795B RID: 31067
		[Nullable(2)]
		protected TriggerSystemRandomPlot_SetValue PocoInterface;
	}
}
