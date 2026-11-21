using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002794 RID: 10132
	public class IFlowTextConfig
	{
		// Token: 0x0600E071 RID: 57457 RVA: 0x002107EE File Offset: 0x0020E9EE
		public static IFlowTextConfig Create(IFlowTextConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTextConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x0600E072 RID: 57458 RVA: 0x0021080D File Offset: 0x0020EA0D
		public virtual string Text
		{
			get
			{
				return this.Instance.Text;
			}
		}

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0600E073 RID: 57459 RVA: 0x0021081A File Offset: 0x0020EA1A
		[Nullable(2)]
		public virtual string PlotLineKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0600E074 RID: 57460 RVA: 0x00210827 File Offset: 0x0020EA27
		public virtual string StringKey
		{
			get
			{
				return this.Instance.StringKey;
			}
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x0600E075 RID: 57461 RVA: 0x00210834 File Offset: 0x0020EA34
		public virtual int FlowListId
		{
			get
			{
				return this.Instance.FlowListId;
			}
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x0600E076 RID: 57462 RVA: 0x00210844 File Offset: 0x0020EA44
		public virtual bool? IsNoPlotText
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNoPlotText);
			}
		}

		// Token: 0x04007A12 RID: 31250
		private IFlowTextConfig Instance;
	}
}
