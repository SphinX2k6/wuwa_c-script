using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C3C RID: 7228
	public class IFlowTextConfig
	{
		// Token: 0x060099BE RID: 39358 RVA: 0x001642F4 File Offset: 0x001624F4
		private IFlowTextConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowTextConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowTextConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowTextConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060099BF RID: 39359 RVA: 0x0016432C File Offset: 0x0016252C
		public static IFlowTextConfig Create([Nullable(2)] IFlowTextConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTextConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099C0 RID: 39360 RVA: 0x0016433F File Offset: 0x0016253F
		public static IFlowTextConfig CreateFromSetValue([Nullable(2)] IFlowTextConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowTextConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x00164354 File Offset: 0x00162554
		public IFlowTextConfig_SetValue ToSetValue()
		{
			return new IFlowTextConfig_SetValue
			{
				Text = this.Text,
				PlotLineKey = this.PlotLineKey,
				StringKey = this.StringKey,
				FlowListId = this.FlowListId,
				IsNoPlotText = this.IsNoPlotText
			};
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x001643A2 File Offset: 0x001625A2
		// (set) Token: 0x060099C3 RID: 39363 RVA: 0x001643CD File Offset: 0x001625CD
		public virtual string Text
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Text;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Text;
			}
			set
			{
				this.GetOrCreatePoco().Text = value;
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x060099C4 RID: 39364 RVA: 0x001643DB File Offset: 0x001625DB
		// (set) Token: 0x060099C5 RID: 39365 RVA: 0x00164402 File Offset: 0x00162602
		[Nullable(2)]
		public virtual string PlotLineKey
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotLineKey;
				}
				IFlowTextConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotLineKey;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PlotLineKey = value;
			}
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x060099C6 RID: 39366 RVA: 0x00164410 File Offset: 0x00162610
		// (set) Token: 0x060099C7 RID: 39367 RVA: 0x0016443B File Offset: 0x0016263B
		public virtual string StringKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StringKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.StringKey;
			}
			set
			{
				this.GetOrCreatePoco().StringKey = value;
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x060099C8 RID: 39368 RVA: 0x00164449 File Offset: 0x00162649
		// (set) Token: 0x060099C9 RID: 39369 RVA: 0x00164474 File Offset: 0x00162674
		public virtual int FlowListId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowListId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FlowListId;
			}
			set
			{
				this.GetOrCreatePoco().FlowListId = value;
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x060099CA RID: 39370 RVA: 0x00164484 File Offset: 0x00162684
		// (set) Token: 0x060099CB RID: 39371 RVA: 0x001644BE File Offset: 0x001626BE
		public virtual bool? IsNoPlotText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNoPlotText;
				}
				IFlowTextConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNoPlotText;
			}
			set
			{
				this.GetOrCreatePoco().IsNoPlotText = value;
			}
		}

		// Token: 0x04005E81 RID: 24193
		[Nullable(2)]
		protected IFlowTextConfig FbInstance;

		// Token: 0x04005E82 RID: 24194
		[Nullable(2)]
		protected IFlowTextConfig_SetValue PocoInterface;
	}
}
