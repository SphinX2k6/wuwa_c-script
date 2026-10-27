using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA3 RID: 6819
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowTextConfig
	{
		// Token: 0x0600923E RID: 37438 RVA: 0x00154108 File Offset: 0x00152308
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

		// Token: 0x0600923F RID: 37439 RVA: 0x00154140 File Offset: 0x00152340
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

		// Token: 0x06009240 RID: 37440 RVA: 0x00154153 File Offset: 0x00152353
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

		// Token: 0x06009241 RID: 37441 RVA: 0x00154168 File Offset: 0x00152368
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

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x06009242 RID: 37442 RVA: 0x001541B6 File Offset: 0x001523B6
		// (set) Token: 0x06009243 RID: 37443 RVA: 0x001541E1 File Offset: 0x001523E1
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

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x06009244 RID: 37444 RVA: 0x001541EF File Offset: 0x001523EF
		// (set) Token: 0x06009245 RID: 37445 RVA: 0x00154216 File Offset: 0x00152416
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

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x06009246 RID: 37446 RVA: 0x00154224 File Offset: 0x00152424
		// (set) Token: 0x06009247 RID: 37447 RVA: 0x0015424F File Offset: 0x0015244F
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

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x06009248 RID: 37448 RVA: 0x0015425D File Offset: 0x0015245D
		// (set) Token: 0x06009249 RID: 37449 RVA: 0x00154288 File Offset: 0x00152488
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

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0600924A RID: 37450 RVA: 0x00154298 File Offset: 0x00152498
		// (set) Token: 0x0600924B RID: 37451 RVA: 0x001542D2 File Offset: 0x001524D2
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

		// Token: 0x04005A11 RID: 23057
		[Nullable(2)]
		protected IFlowTextConfig FbInstance;

		// Token: 0x04005A12 RID: 23058
		[Nullable(2)]
		protected IFlowTextConfig_SetValue PocoInterface;
	}
}
