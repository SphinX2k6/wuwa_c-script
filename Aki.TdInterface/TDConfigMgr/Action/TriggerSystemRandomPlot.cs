using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200225E RID: 8798
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerSystemRandomPlot : ActionParams
	{
		// Token: 0x0600C10A RID: 49418 RVA: 0x001BB2B4 File Offset: 0x001B94B4
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

		// Token: 0x0600C10B RID: 49419 RVA: 0x001BB2EC File Offset: 0x001B94EC
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

		// Token: 0x0600C10C RID: 49420 RVA: 0x001BB2FF File Offset: 0x001B94FF
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

		// Token: 0x0600C10D RID: 49421 RVA: 0x001BB312 File Offset: 0x001B9512
		public TriggerSystemRandomPlot_SetValue ToSetValue()
		{
			return new TriggerSystemRandomPlot_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0600C10E RID: 49422 RVA: 0x001BB325 File Offset: 0x001B9525
		// (set) Token: 0x0600C10F RID: 49423 RVA: 0x001BB350 File Offset: 0x001B9550
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

		// Token: 0x0400730D RID: 29453
		[Nullable(2)]
		protected new TriggerSystemRandomPlot FbInstance;

		// Token: 0x0400730E RID: 29454
		[Nullable(2)]
		protected TriggerSystemRandomPlot_SetValue PocoInterface;
	}
}
